Imports System.Data.SqlClient
Public Class Meetings
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Public dt_Meetings As New DataTable
    Public Function Max_Tbl_Meetings()
        Dim Number As Integer
        Try
            Dim cmd As New SqlCommand("Select Max(Meeting_ID) From Tbl_Meetings ", Con)
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Number = cmd.ExecuteScalar
            Con.Close()
        Catch ex As Exception
            Number = 0
            Con.Close()
        End Try
        Return Number
    End Function

    Public Sub ClearControls()
        Me.Meeting_ID.Text = vbNullString
        Me.Meeting_Title.Text = vbNullString
        Me.Meeting_Date.Value = Today
        Me.Meeting_Location.Text = vbNullString
        Me.Meeting_Description.Text = vbNullString
        Me.Created_Date.Value = Today
        Me.Meeting_ID.Text = Max_Tbl_Meetings() + 1

        ' تفريغ جدول الحضور
        dgv_Attendees.Rows.Clear()
        fillcmb_Tbl_Employee(cmb_Employee)

        ' تفريغ جدول المهام
        Dgv_Task.Rows.Clear()

        ' إعادة تعيين Cmb_Assigned_To
        Cmb_Assigned_To.DataSource = Nothing
    End Sub

    Public Sub fillcmb_Tbl_Employee(ByVal cmb As ComboBox)
        Dim DT As New DataTable
        Dim DA As New SqlDataAdapter
        DT.Clear()
        DA = New SqlDataAdapter("Select Emp_ID , Emp_Full_Name FROM Tbl_Employee where Working_Condition = 'سارى'", Con)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            cmb.DataSource = DT
            cmb.ValueMember = "Emp_ID"
            cmb.DisplayMember = "Emp_Full_Name"
        Else
            cmb.DataSource = Nothing
        End If
    End Sub

    Private Sub Meetings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomizeForm(Me)
        ClearControls()
        ' إعداد أعمدة DataGridView للحضور
        If dgv_Attendees.Columns.Count = 0 Then
            dgv_Attendees.Columns.Add("Emp_ID", "كود الموظف")
            dgv_Attendees.Columns.Add("Emp_Full_Name", "اسم الموظف")
        End If

        ' إعداد Cmb_Assigned_To
        Cmb_Assigned_To.DisplayMember = "Emp_Full_Name"
        Cmb_Assigned_To.ValueMember = "Emp_ID"
        Cmb_Assigned_To.DataSource = Nothing

        ' إعداد أعمدة Dgv_Task
        SetupTaskDataGridView()
    End Sub

    Private Sub SetupTaskDataGridView()
        Try
            ' مسح الأعمدة الحالية إن وجدت
            Dgv_Task.Columns.Clear()

            ' إضافة الأعمدة
            Dgv_Task.Columns.Add("TaskID", "مسلسل")
            Dgv_Task.Columns.Add("TaskDescription", "وصف المهمة")
            Dgv_Task.Columns.Add("AssignedTo", "تم اسنادها الى")
            Dgv_Task.Columns.Add("DueDate", "آخر تاريخ للإنهاء")

            ' إنشاء عمود ComboBox للحالة
            Dim statusColumn As New DataGridViewComboBoxColumn()
            statusColumn.Name = "Status"
            statusColumn.HeaderText = "الحالة"
            statusColumn.Items.AddRange(New String() {"قيد الانتظار", "غير مكتملة", "يجرى العمل عليها", "مكتمل", "تم الإلغاء"})
            Dgv_Task.Columns.Add(statusColumn)

            ' تنسيق الجدول
            With Dgv_Task
                .RightToLeft = RightToLeft.Yes
                .Columns("TaskID").Width = 70
                .Columns("TaskDescription").Width = 400
                .Columns("AssignedTo").Width = 300
                .Columns("DueDate").Width = 200
                .Columns("Status").Width = 120

                ' جعل عمود المسلسل للقراءة فقط
                .Columns("TaskID").ReadOnly = True

                ' تنسيق عمود التاريخ
                .Columns("DueDate").DefaultCellStyle.Format = "dd/MM/yyyy"
                ' جعل عمود وصف المهمة يملأ المساحة المتبقية
                .Columns("TaskDescription").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With

        Catch ex As Exception
            MessageBox.Show("حدث خطأ أثناء إعداد جدول المهام: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateAssignedToComboBox()
        Try
            ' إنشاء DataTable جديد لتخزين بيانات الموظفين من DataGridView
            Dim dt As New DataTable()
            dt.Columns.Add("Emp_ID")
            dt.Columns.Add("Emp_Full_Name")

            ' نقل البيانات من DataGridView إلى DataTable
            For Each row As DataGridViewRow In dgv_Attendees.Rows
                If row.Cells("Emp_ID").Value IsNot Nothing Then
                    dt.Rows.Add(row.Cells("Emp_ID").Value, row.Cells("Emp_Full_Name").Value)
                End If
            Next

            ' تحديث Cmb_Assigned_To
            Cmb_Assigned_To.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("حدث خطأ أثناء تحديث قائمة التعيين: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Btn_Save_Attend_Click(sender As Object, e As EventArgs) Handles Btn_Save_Attend.Click
        Try
            ' التحقق من اختيار موظف
            If cmb_Employee.SelectedIndex = -1 Then
                MessageBox.Show("الرجاء اختيار موظف", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' التحقق من عدم تكرار الموظف
            For Each row As DataGridViewRow In dgv_Attendees.Rows
                If row.Cells("Emp_ID").Value?.ToString() = cmb_Employee.SelectedValue.ToString() Then
                    MessageBox.Show("تم إضافة هذا الموظف مسبقاً", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
            Next

            ' إضافة الموظف إلى DataGridView
            dgv_Attendees.Rows.Add(cmb_Employee.SelectedValue, cmb_Employee.Text)

            ' تحديث Cmb_Assigned_To
            UpdateAssignedToComboBox()

        Catch ex As Exception
            MessageBox.Show("حدث خطأ: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgv_Attendees_DoubleClick(sender As Object, e As EventArgs)
        Try
            If dgv_Attendees.CurrentRow IsNot Nothing Then
                If MessageBox.Show("هل تريد حذف هذا الموظف من قائمة الحضور؟", "تأكيد الحذف",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    dgv_Attendees.Rows.Remove(dgv_Attendees.CurrentRow)
                    ' تحديث Cmb_Assigned_To بعد الحذف
                    UpdateAssignedToComboBox()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("حدث خطأ: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_Save_Task_Click(sender As Object, e As EventArgs) Handles btn_Save_Task.Click
        Try
            ' التحقق من إدخال وصف المهمة
            If String.IsNullOrEmpty(txt_Task_Description.Text.Trim()) Then
                MessageBox.Show("الرجاء إدخال وصف المهمة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txt_Task_Description.Focus()
                Return
            End If

            ' التحقق من اختيار الموظف المسند إليه
            If Cmb_Assigned_To.SelectedIndex = -1 Then
                MessageBox.Show("الرجاء اختيار الموظف المسند إليه المهمة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Cmb_Assigned_To.Focus()
                Return
            End If

            ' إضافة صف جديد
            Dim rowIndex As Integer = Dgv_Task.Rows.Add()
            With Dgv_Task.Rows(rowIndex)
                .Cells("TaskID").Value = rowIndex + 1
                .Cells("TaskDescription").Value = txt_Task_Description.Text.Trim()
                .Cells("AssignedTo").Value = Cmb_Assigned_To.Text
                .Cells("DueDate").Value = Due_Date.Value
                .Cells("Status").Value = "غير مكتملة"
            End With

            ' مسح حقول الإدخال
            txt_Task_Description.Clear()
            txt_Task_Description.Focus()

        Catch ex As Exception
            MessageBox.Show("حدث خطأ أثناء حفظ المهمة: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Dgv_Task_DoubleClick(sender As Object, e As EventArgs)
        Try
            If Dgv_Task.CurrentRow IsNot Nothing Then
                If MessageBox.Show("هل تريد حذف هذه المهمة؟", "تأكيد الحذف",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Dgv_Task.Rows.Remove(Dgv_Task.CurrentRow)

                    ' إعادة ترقيم المسلسل
                    For i As Integer = 0 To Dgv_Task.Rows.Count - 1
                        Dgv_Task.Rows(i).Cells("TaskID").Value = i + 1
                    Next
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("حدث خطأ أثناء حذف المهمة: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function SaveMeetingData() As Boolean
        Try
            If Con.State = 1 Then Con.Close()
            Con.Open()

            ' بدء المعاملة
            Dim transaction As SqlTransaction = Con.BeginTransaction()
            Try
                ' 1. حفظ بيانات الاجتماع
                Dim cmdMeeting As New SqlCommand("INSERT INTO Tbl_Meetings (Meeting_ID, Meeting_Title, Meeting_Date, Meeting_Location, Meeting_Description) " &
                                               "VALUES (@Meeting_ID, @Meeting_Title, @Meeting_Date, @Meeting_Location, @Meeting_Description)", Con, transaction)

                With cmdMeeting.Parameters
                    .AddWithValue("@Meeting_ID", CInt(Meeting_ID.Text))
                    .AddWithValue("@Meeting_Title", Meeting_Title.Text.Trim())
                    .AddWithValue("@Meeting_Date", Meeting_Date.Value.Date)
                    .AddWithValue("@Meeting_Location", Meeting_Location.Text.Trim())
                    .AddWithValue("@Meeting_Description", Meeting_Description.Text.Trim())
                End With
                cmdMeeting.ExecuteNonQuery()

                ' 2. حفظ بيانات الحضور
                For Each row As DataGridViewRow In dgv_Attendees.Rows
                    If row.Cells("Emp_ID").Value IsNot Nothing Then
                        Dim cmdAttendee As New SqlCommand("INSERT INTO Tbl_Meeting_Attendees (Meeting_ID, Emp_ID) VALUES (@Meeting_ID, @Emp_ID)", Con, transaction)
                        cmdAttendee.Parameters.AddWithValue("@Meeting_ID", CInt(Meeting_ID.Text))
                        cmdAttendee.Parameters.AddWithValue("@Emp_ID", row.Cells("Emp_ID").Value)
                        cmdAttendee.ExecuteNonQuery()
                    End If
                Next

                ' 3. حفظ بيانات المهام
                For Each row As DataGridViewRow In Dgv_Task.Rows
                    If Not row.IsNewRow AndAlso row.Cells("TaskDescription").Value IsNot Nothing Then
                        Dim cmdTask As New SqlCommand("INSERT INTO Tbl_Meeting_Tasks (Meeting_ID, Task_Description, Assigned_To, Due_Date, Status) " &
                                                    "VALUES (@Meeting_ID, @Task_Description, @Assigned_To, @Due_Date, @Status)", Con, transaction)

                        With cmdTask.Parameters
                            .AddWithValue("@Meeting_ID", CInt(Meeting_ID.Text))
                            .AddWithValue("@Task_Description", row.Cells("TaskDescription").Value)
                            ' الحصول على كود الموظف من النص المعروض
                            Dim assignedToName As String = row.Cells("AssignedTo").Value.ToString()
                            Dim empID As Integer = GetEmployeeIDByName(assignedToName, Con, transaction)
                            .AddWithValue("@Assigned_To", empID)
                            .AddWithValue("@Due_Date", Convert.ToDateTime(row.Cells("DueDate").Value))
                            .AddWithValue("@Status", row.Cells("Status").Value.ToString())
                        End With
                        cmdTask.ExecuteNonQuery()
                    End If
                Next

                ' تأكيد المعاملة
                transaction.Commit()
                MessageBox.Show("تم حفظ البيانات بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return True

            Catch ex As Exception
                ' التراجع عن المعاملة في حالة حدوث خطأ
                transaction.Rollback()
                MessageBox.Show("حدث خطأ أثناء حفظ البيانات: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End Try

        Catch ex As Exception
            MessageBox.Show("حدث خطأ في الاتصال بقاعدة البيانات: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            If Con.State = ConnectionState.Open Then Con.Close()
        End Try
    End Function

    Private Function GetEmployeeIDByName(employeeName As String, connection As SqlConnection, transaction As SqlTransaction) As Integer
        Dim cmd As New SqlCommand("SELECT Emp_ID FROM Tbl_Employee WHERE Emp_Full_Name = @Name", connection, transaction)
        cmd.Parameters.AddWithValue("@Name", employeeName)
        Dim result As Object = cmd.ExecuteScalar()
        If result IsNot Nothing Then
            Return Convert.ToInt32(result)
        End If
        Return 0
    End Function

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        ' التحقق من البيانات المطلوبة
        If String.IsNullOrEmpty(Meeting_Title.Text.Trim()) Then
            MessageBox.Show("الرجاء إدخال عنوان الاجتماع", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Meeting_Title.Focus()
            Return
        End If

        If dgv_Attendees.Rows.Count = 0 Then
            MessageBox.Show("الرجاء إضافة حاضرين للاجتماع", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        ' حفظ البيانات
        If SaveMeetingData() Then
            ClearControls()
        End If
    End Sub

    Private Sub Btn_Search_Meeetings_Click(sender As Object, e As EventArgs) Handles Btn_Search_Meeetings.Click
        Try
            Meeetings_Search.Show()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnNewAdd_Click(sender As Object, e As EventArgs) Handles BtnNewAdd.Click
        ClearControls()
        ' إعداد أعمدة DataGridView للحضور
        If dgv_Attendees.Columns.Count = 0 Then
            dgv_Attendees.Columns.Add("Emp_ID", "كود الموظف")
            dgv_Attendees.Columns.Add("Emp_Full_Name", "اسم الموظف")
        End If

        ' إعداد Cmb_Assigned_To
        Cmb_Assigned_To.DisplayMember = "Emp_Full_Name"
        Cmb_Assigned_To.ValueMember = "Emp_ID"
        Cmb_Assigned_To.DataSource = Nothing

        ' إعداد أعمدة Dgv_Task
        SetupTaskDataGridView()
    End Sub


End Class