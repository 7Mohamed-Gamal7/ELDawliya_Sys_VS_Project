Imports System.Data.SqlClient

Public Class Meeetings_Search
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)

    Public Sub FillMeetingsCombo()
        Try
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter
            dt.Clear()
            da = New SqlDataAdapter("SELECT Meeting_ID, Meeting_Title FROM Tbl_Meetings ORDER BY Meeting_ID DESC", Con)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                With Combo_Meeting_Addres
                    .DataSource = dt
                    .ValueMember = "Meeting_ID"
                    .DisplayMember = "Meeting_Title"
                End With
            Else
                Combo_Meeting_Addres.DataSource = Nothing
            End If

        Catch ex As Exception
            MessageBox.Show("حدث خطأ أثناء تحميل بيانات الاجتماعات: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub SearchMeetingsBetweenDates()
        Try
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter
            dt.Clear()

            ' إنشاء استعلام البحث بين تاريخين
            Dim query As String = "SELECT Meeting_ID, Meeting_Title FROM Tbl_Meetings " &
                                "WHERE Meeting_Date BETWEEN @StartDate AND @EndDate " &
                                "ORDER BY Meeting_Date DESC"

            da = New SqlDataAdapter(query, Con)

            ' إضافة المعاملات
            da.SelectCommand.Parameters.AddWithValue("@StartDate", Srat_Meeting_Date.Value.Date)
            da.SelectCommand.Parameters.AddWithValue("@EndDate", End_Meeting_Date.Value.Date)

            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                With Combo_Meeting_Addres
                    .DataSource = dt
                    .ValueMember = "Meeting_ID"
                    .DisplayMember = "Meeting_Title"
                End With
                MessageBox.Show("تم العثور على " & dt.Rows.Count & " اجتماع", "نتيجة البحث", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Combo_Meeting_Addres.DataSource = Nothing
                MessageBox.Show("لم يتم العثور على اجتماعات في هذه الفترة", "نتيجة البحث", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("حدث خطأ أثناء البحث عن الاجتماعات: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub SearchSelectedMeeting()
        Try
            ' التحقق من أن هناك اجتماعاً مختاراً
            If Combo_Meeting_Addres.SelectedValue Is Nothing Then
                MessageBox.Show("يرجى اختيار اجتماع لعرض التفاصيل.", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' إنشاء DataTable لتخزين البيانات
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter
            dt.Clear()

            ' استعلام لجلب تفاصيل الاجتماع
            Dim query As String = "SELECT Meeting_ID, Meeting_Title, Meeting_Date, Meeting_Description " &
                              "FROM Tbl_Meetings WHERE Meeting_ID = @MeetingID"

            da = New SqlDataAdapter(query, Con)

            ' إضافة المعامل لمعرفة الاجتماع المختار
            da.SelectCommand.Parameters.AddWithValue("@MeetingID", Combo_Meeting_Addres.SelectedValue)

            da.Fill(dt)

            ' التحقق من وجود بيانات
            If dt.Rows.Count > 0 Then
                ' عرض تفاصيل الاجتماع في MessageBox
                Dim meetingDetails As String = "رقم الاجتماع: " & dt.Rows(0)("Meeting_ID").ToString() & vbCrLf &
                                            "عنوان الاجتماع: " & dt.Rows(0)("Meeting_Title").ToString() & vbCrLf &
                                            "تاريخ الاجتماع: " & Date.Parse(dt.Rows(0)("Meeting_Date")).ToString("yyyy-MM-dd") & vbCrLf &
                                            "وصف الاجتماع: " & dt.Rows(0)("Meeting_Description").ToString()
                MessageBox.Show(meetingDetails, "تفاصيل الاجتماع", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("لم يتم العثور على تفاصيل الاجتماع.", "نتيجة البحث", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("حدث خطأ أثناء البحث عن تفاصيل الاجتماع: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Public Sub ViewMeetingData()
        Try
            If Combo_Meeting_Addres.SelectedValue Is Nothing Then
                MessageBox.Show("الرجاء اختيار اجتماع", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim meetingID As Integer = CInt(Combo_Meeting_Addres.SelectedValue)

            ' جلب بيانات الاجتماع
            Dim dtMeeting As New DataTable
            Dim cmdMeeting As New SqlCommand("SELECT * FROM Tbl_Meetings WHERE Meeting_ID = @MeetingID", Con)
            cmdMeeting.Parameters.AddWithValue("@MeetingID", meetingID)
            Dim daMeeting As New SqlDataAdapter(cmdMeeting)
            daMeeting.Fill(dtMeeting)

            If dtMeeting.Rows.Count > 0 Then
                ' عرض بيانات الاجتماع
                With dtMeeting.Rows(0)
                    Meeting_ID_View.Text = .Item("Meeting_ID").ToString()
                    Meeting_Title_View.Text = .Item("Meeting_Title").ToString()
                    Meeting_Date_View.Value = Convert.ToDateTime(.Item("Meeting_Date"))
                    Meeting_Location_View.Text = .Item("Meeting_Location").ToString()
                    Meeting_Description_View.Text = .Item("Meeting_Description").ToString()
                End With

                ' جلب بيانات الحضور
                Dim dtAttendees As New DataTable
                Dim cmdAttendees As New SqlCommand(
                    "SELECT e.Emp_ID, e.Emp_Full_Name " &
                    "FROM Tbl_Meeting_Attendees ma " &
                    "INNER JOIN Tbl_Employee e ON ma.Emp_ID = e.Emp_ID " &
                    "WHERE ma.Meeting_ID = @MeetingID", Con)
                cmdAttendees.Parameters.AddWithValue("@MeetingID", meetingID)
                Dim daAttendees As New SqlDataAdapter(cmdAttendees)
                daAttendees.Fill(dtAttendees)

                ' عرض بيانات الحضور في DataGridView
                dgv_Attendees.DataSource = dtAttendees

                ' جلب بيانات المهام
                Dim dtTasks As New DataTable
                Dim cmdTasks As New SqlCommand(
                    "SELECT t.Task_ID, t.Task_Description, e.Emp_Full_Name AS Assigned_To, " &
                    "t.Due_Date, t.Status " &
                    "FROM Tbl_Meeting_Tasks t " &
                    "LEFT JOIN Tbl_Employee e ON t.Assigned_To = e.Emp_ID " &
                    "WHERE t.Meeting_ID = @MeetingID", Con)
                cmdTasks.Parameters.AddWithValue("@MeetingID", meetingID)
                Dim daTasks As New SqlDataAdapter(cmdTasks)
                daTasks.Fill(dtTasks)

                ' عرض بيانات المهام في DataGridView
                Dgv_Task.DataSource = dtTasks

                ' تنسيق عرض البيانات
                FormatDataGridViews()

            Else
                MessageBox.Show("لم يتم العثور على بيانات الاجتماع", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show("حدث خطأ أثناء عرض بيانات الاجتماع: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub FormatDataGridViews()
        ' تنسيق جدول الحضور
        With dgv_Attendees
            .Columns("Emp_ID").HeaderText = "كود الموظف"
            .Columns("Emp_Full_Name").HeaderText = "اسم الموظف"
            .Columns("Emp_Full_Name").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End With

        ' تنسيق جدول المهام
        With Dgv_Task
            .Columns("Task_ID").HeaderText = "رقم المهمة"
            .Columns("Task_Description").HeaderText = "وصف المهمة"
            .Columns("Assigned_To").HeaderText = "مسند إلى"
            .Columns("Due_Date").HeaderText = "تاريخ الإنتهاء"
            .Columns("Status").HeaderText = "الحالة"

            .Columns("Task_Description").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns("Due_Date").DefaultCellStyle.Format = "dd/MM/yyyy"
        End With
    End Sub

    Private Sub Meeetings_Search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyPermissions(Me.Name)
        CustomizeForm(Me)
        FillMeetingsCombo()
    End Sub

    Private Sub Btn_Search_Meeting_Click(sender As Object, e As EventArgs) Handles Btn_Search_Meeting.Click
        ' التحقق من التواريخ
        If End_Meeting_Date.Value < Srat_Meeting_Date.Value Then
            MessageBox.Show("تاريخ النهاية يجب أن يكون أكبر من أو يساوي تاريخ البداية", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        'SearchMeetingsBetweenDates()
        SearchSelectedMeeting()
    End Sub

    Private Sub btn_View_Meeting_Data_Click(sender As Object, e As EventArgs) Handles btn_View_Meeting_Data.Click
        ViewMeetingData()
    End Sub

    Private Sub Dgv_Task_DoubleClick(sender As Object, e As EventArgs) Handles Dgv_Task.DoubleClick
        Try
            If Dgv_Task.CurrentRow Is Nothing Then Return

            ' التأكد من أن الصف المحدد يحتوي على بيانات
            If Dgv_Task.CurrentRow.Index < 0 Then Return

            ' الحصول على بيانات المهمة المحددة
            Dim taskID As Integer = CInt(Dgv_Task.CurrentRow.Cells("Task_ID").Value)
            Dim assignedTo As String = Dgv_Task.CurrentRow.Cells("Assigned_To").Value.ToString()
            Dim dueDate As Date = CDate(Dgv_Task.CurrentRow.Cells("Due_Date").Value)
            Dim meetingID As Integer = CInt(Meeting_ID_View.Text)

            ' فتح نموذج تعديل المهمة
            Using editForm As New EditTaskForm(taskID, meetingID, assignedTo, dueDate)
                If editForm.ShowDialog() = DialogResult.OK Then
                    ' إعادة تحميل بيانات المهام بعد التعديل
                    ViewMeetingData()
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("حدث خطأ أثناء فتح نموذج تعديل المهمة: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class