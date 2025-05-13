Imports System.Data.SqlClient

Public Class UserTasks
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)


    Private WithEvents colorTimer As New Timer()
    Private targetButton As Button
    Private currentColor As Color
    Private targetColor As Color






    Private Sub UserTasks_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        colorTimer.Interval = 50 ' تغيير تدريجي سريع
        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is Button Then
                Dim btn As Button = DirectCast(ctrl, Button)
                AddHandler btn.MouseEnter, AddressOf Button_MouseEnter
                AddHandler btn.MouseLeave, AddressOf Button_MouseLeave
            End If
        Next






        ApplyPermissions(Me.Name)
        CustomizeForm(Me)
        ' إضافة العناصر إلى قائمة البحث
        cbo_SearchStatus.Items.Add("الكل")
        cbo_SearchStatus.Items.AddRange({"قيد الانتظار", "غير مكتملة", "يجرى العمل عليها", "مكتمل", "تم الإلغاء"}.ToArray())
        cbo_SearchStatus.SelectedIndex = 0 ' اختيار "الكل" كقيمة افتراضية
        LoadUserTasks()
    End Sub

    Private Sub LoadUserTasks(Optional statusFilter As String = "")
        Try
            ' التحقق من تسجيل دخول المستخدم
            If loggedInUserID = 0 Then
                MessageBox.Show("الرجاء تسجيل الدخول أولاً", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.Close()
                Return
            End If

            ' بناء استعلام SQL
            Dim sqlQuery As String = "SELECT " &
                "    t.Task_ID, " &
                "    m.Meeting_Title, " &
                "    m.Meeting_Date, " &
                "    t.Task_Description, " &
                "    t.Due_Date, " &
                "    t.Status " &
                "FROM Tbl_Meeting_Tasks t " &
                "INNER JOIN Tbl_Meetings m ON t.Meeting_ID = m.Meeting_ID " &
                "WHERE t.Assigned_To = @UserID"

            ' إضافة فلتر الحالة إذا تم اختيار حالة محددة
            If statusFilter <> "" AndAlso statusFilter <> "الكل" Then
                sqlQuery &= " AND t.Status = @Status"
            End If

            sqlQuery &= " ORDER BY t.Due_Date ASC"

            ' جلب المهام الخاصة بالمستخدم
            Dim dtUserTasks As New DataTable
            Dim cmdTasks As New SqlCommand(sqlQuery, Con)
            cmdTasks.Parameters.AddWithValue("@UserID", loggedInUserID)

            If statusFilter <> "" AndAlso statusFilter <> "الكل" Then
                cmdTasks.Parameters.AddWithValue("@Status", statusFilter)
            End If

            Dim daTasks As New SqlDataAdapter(cmdTasks)
            daTasks.Fill(dtUserTasks)

            ' عرض البيانات في DataGridView
            dgv_UserTasks.DataSource = dtUserTasks

            ' تنسيق عرض البيانات
            FormatDataGridViews()

            ' عرض إجمالي عدد المهام
            lbl_TaskCount.Text = $"إجمالي المهام: {dtUserTasks.Rows.Count}"

        Catch ex As Exception
            MessageBox.Show("حدث خطأ أثناء تحميل المهام: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FormatDataGridViews()
        With dgv_UserTasks
            .Columns("Task_ID").HeaderText = "رقم المهمة"
            .Columns("Meeting_Title").HeaderText = "عنوان الاجتماع"
            .Columns("Meeting_Date").HeaderText = "تاريخ الاجتماع"
            .Columns("Task_Description").HeaderText = "وصف المهمة"
            .Columns("Due_Date").HeaderText = "تاريخ الإنتهاء"
            .Columns("Status").HeaderText = "الحالة"

            ' تنسيق التواريخ
            .Columns("Meeting_Date").DefaultCellStyle.Format = "dd/MM/yyyy"
            .Columns("Due_Date").DefaultCellStyle.Format = "dd/MM/yyyy"

            ' تنسيق العرض
            .Columns("Task_Description").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns("Meeting_Title").Width = 200

            ' إضافة تلوين للمهام المتأخرة
            For Each row As DataGridViewRow In .Rows
                If Not row.IsNewRow Then
                    Dim dueDate As Date = CDate(row.Cells("Due_Date").Value)
                    If dueDate < Date.Today AndAlso row.Cells("Status").Value.ToString().ToLower() <> "مكتمل" Then
                        row.DefaultCellStyle.BackColor = Color.LightPink
                    End If
                End If
            Next
        End With
    End Sub

    Private Sub btn_Refresh_Click(sender As Object, e As EventArgs) Handles btn_Refresh.Click
        LoadUserTasks()
    End Sub

    Private Sub btn_UpdateStatus_Click(sender As Object, e As EventArgs) Handles btn_UpdateStatus.Click
        '-------------------------------------------------------------------------------------------------------
        'خاص بتطبيق الصلاحيات
        If Not CanEdit Or Not CanAdd Then
            MessageBox.Show("ليس لديك صلاحية التعديل.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        '-------------------------------------------------------------------------------------------------------

        If dgv_UserTasks.SelectedRows.Count = 0 Then
            MessageBox.Show("الرجاء اختيار مهمة لتحديث حالتها", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Dim taskId As Integer = CInt(dgv_UserTasks.SelectedRows(0).Cells("Task_ID").Value)
            Dim currentStatus As String = dgv_UserTasks.SelectedRows(0).Cells("Status").Value.ToString()

            ' إنشاء قائمة بالحالات المتاحة
            Dim statuses As New List(Of String) From {"قيد الانتظار", "غير مكتملة", "يجرى العمل عليها", "مكتمل", "تم الإلغاء"}

            ' إنشاء ComboBox للاختيار
            Dim cboStatus As New ComboBox()
            cboStatus.Items.AddRange(statuses.ToArray())
            cboStatus.SelectedItem = currentStatus

            ' إنشاء نموذج مصغر لتحديث الحالة
            Dim updateForm As New Form()
            updateForm.Text = "تحديث حالة المهمة"
            updateForm.Size = New Size(300, 150)
            updateForm.StartPosition = FormStartPosition.CenterParent

            Dim lblStatus As New Label()
            lblStatus.Text = "الحالة الجديدة:"
            lblStatus.Location = New Point(200, 20)

            cboStatus.Location = New Point(20, 20)
            cboStatus.Width = 150

            Dim btnSave As New Button()
            btnSave.Text = "حفظ"
            btnSave.DialogResult = DialogResult.OK
            btnSave.Location = New Point(20, 60)

            Dim btnCancel As New Button()
            btnCancel.Text = "إلغاء"
            btnCancel.DialogResult = DialogResult.Cancel
            btnCancel.Location = New Point(120, 60)

            updateForm.Controls.AddRange({lblStatus, cboStatus, btnSave, btnCancel})

            If updateForm.ShowDialog() = DialogResult.OK Then
                ' تحديث حالة المهمة في قاعدة البيانات
                Dim cmdUpdate As New SqlCommand(
                    "UPDATE Tbl_Meeting_Tasks SET Status = @Status WHERE Task_ID = @TaskID", Con)
                cmdUpdate.Parameters.AddWithValue("@Status", cboStatus.SelectedItem.ToString())
                cmdUpdate.Parameters.AddWithValue("@TaskID", taskId)

                Con.Open()
                cmdUpdate.ExecuteNonQuery()
                Con.Close()

                MessageBox.Show("تم تحديث حالة المهمة بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadUserTasks()
            End If

        Catch ex As Exception
            MessageBox.Show("حدث خطأ أثناء تحديث حالة المهمة: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' إضافة حدث للبحث عند الضغط على زر البحث
    Private Sub btn_Search_Click(sender As Object, e As EventArgs) Handles btn_Search.Click
        Dim selectedStatus As String = cbo_SearchStatus.SelectedItem.ToString()
        LoadUserTasks(selectedStatus)
    End Sub


    '===================================================================================================================
    Private Sub Button_MouseEnter(sender As Object, e As EventArgs)
        targetButton = DirectCast(sender, Button)
        currentColor = targetButton.BackColor
        targetColor = Color.LightBlue
        colorTimer.Start()
    End Sub

    Private Sub Button_MouseLeave(sender As Object, e As EventArgs)
        targetButton = DirectCast(sender, Button)
        currentColor = targetButton.BackColor
        targetColor = SystemColors.Control
        colorTimer.Start()
    End Sub

    Private Sub colorTimer_Tick(sender As Object, e As EventArgs) Handles colorTimer.Tick
        If targetButton IsNot Nothing Then
            ' حساب لون جديد بالتدريج بطريقة آمنة
            Dim r = Clamp(CInt(currentColor.R) + Math.Sign(CInt(targetColor.R) - CInt(currentColor.R)), 0, 255)
            Dim g = Clamp(CInt(currentColor.G) + Math.Sign(CInt(targetColor.G) - CInt(currentColor.G)), 0, 255)
            Dim b = Clamp(CInt(currentColor.B) + Math.Sign(CInt(targetColor.B) - CInt(currentColor.B)), 0, 255)

            ' إنشاء اللون الجديد وتحديث الزر
            currentColor = Color.FromArgb(r, g, b)
            targetButton.BackColor = currentColor

            ' إيقاف المؤقت إذا وصلنا إلى اللون الهدف
            If currentColor = targetColor Then
                colorTimer.Stop()
            End If
        End If
    End Sub

    Private Function Clamp(value As Integer, min As Integer, max As Integer) As Integer
        If value < min Then
            Return min
        ElseIf value > max Then
            Return max
        End If
        Return value
    End Function


End Class
