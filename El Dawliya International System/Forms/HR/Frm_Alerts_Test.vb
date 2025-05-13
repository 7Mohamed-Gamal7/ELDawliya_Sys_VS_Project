Imports System.Data.SqlClient
Imports El_Dawliya_International_System.El_Dawliya_International_System.Forms.Report

Public Class Frm_Alerts_Test
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Public dt_Tbl_Alerts As New DataTable

    Private Function GetColumnHeaderName(columnName As String) As String
        Select Case columnName
            Case "TaskCode" : Return "كود المهمة"
            Case "TaskCreationDate" : Return "تاريخ انشاء المهمة"
            Case "TaskStartDate" : Return "تاريخ بدا المهمة"
            Case "TaskEndDate" : Return "تاريخ انتهاء المهمة"
            Case "TaskDescription" : Return "وصف المهمة"
            Case "TaskDepartment" : Return "قسم المهمة"
            Case "TaskStatus" : Return "حالة المهمة"
            Case "TaskItem" : Return "Task  Item"
            Case "Emp_ID" : Return "كود الموظف"
            Case "TaskExecutor" : Return "القائم بالمهمة"
            Case "ReminderDaysBeforeDueDate" : Return "عدد الايام للتذكير قبل انتهاء المهمة"
            Case "Step1" : Return "خطوة1"
            Case "Step2" : Return "خطوة2"
            Case Else : Return columnName
        End Select
    End Function

    Public Sub HideColumns(dgv As DataGridView, ParamArray columnNames() As String)
        For Each columnName As String In columnNames
            If dgv.Columns.Contains(columnName) Then
                dgv.Columns(columnName).Visible = False
            End If
        Next
    End Sub


    Public Sub SelectAll_Alarm_Alerts(dgv As DataGridView)
        Dim da As New SqlDataAdapter
        dt_Tbl_Alerts.Clear()
        da = New SqlDataAdapter("SELECT Tbl_Alerts.* FROM  Tbl_Alerts 
            where DATEADD(DAY , (ReminderDaysBeforeDueDate) , GETDATE())>= TaskEndDate and TaskStatus <> 'انتهت'", Con)
        da.Fill(dt_Tbl_Alerts)
        dgv.DataSource = dt_Tbl_Alerts

        HideColumns(dgv, "TaskCode", "TaskItem", "Emp_ID", "TaskExecutor", "ReminderDaysBeforeDueDate", "Step1", "Step2")
        For Each col As DataGridViewColumn In dgv.Columns
            col.HeaderText = GetColumnHeaderName(col.Name)
        Next
        With dgv
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        End With
    End Sub

    Public Sub SelectAll_Tbl_Alerts(dgv As DataGridView)
        Dim da As New SqlDataAdapter
        dt_Tbl_Alerts.Clear()
        da = New SqlDataAdapter("select * from Tbl_Alerts", Con)
        da.Fill(dt_Tbl_Alerts)
        dgv.DataSource = dt_Tbl_Alerts
        HideColumns(dgv, "TaskCode", "TaskItem", "Emp_ID", "TaskExecutor", "ReminderDaysBeforeDueDate", "Step1", "Step2")

        For Each col As DataGridViewColumn In dgv.Columns
            col.HeaderText = GetColumnHeaderName(col.Name)
        Next
        With dgv
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        End With

    End Sub

    Public Sub ClearControls()
        Me.TaskCode.Text = vbNullString
        Me.TaskCreationDate.Value = Today
        Me.TaskStartDate.Text = Today
        Me.TaskEndDate.Text = Today
        Me.TaskDescription.Text = vbNullString
        Me.TaskDepartment.Text = vbNullString
        Me.TaskStatus.Text = vbNullString
        Me.Emp_ID.Text = vbNullString
        Me.TaskExecutor.Text = vbNullString
        Me.ReminderDaysBeforeDueDate.Text = vbNullString
        Me.Step1.Text = vbNullString
        Me.Step2.Text = vbNullString
        TaskCode.Text = Max_Tbl_Alerts() + 1
        TaskCode.Focus()
        BtnEdit.Enabled = False
        BtnDelete.Enabled = False
        BtnSave.Enabled = True
    End Sub

    Public Function Max_Tbl_Alerts()
        Dim Number As Integer
        Try
            Dim cmd As New SqlCommand("Select Max(TaskCode) From Tbl_Alerts ", Con)
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

    Public Sub Insert_Tbl_Alerts(ByVal TaskCode As Int32, ByVal TaskCreationDate As Date, ByVal TaskStartDate As Date, ByVal TaskEndDate As Date, ByVal TaskDescription As String, ByVal TaskDepartment As String, ByVal TaskStatus As String, ByVal Emp_ID As Int32, ByVal TaskExecutor As String, ByVal ReminderDaysBeforeDueDate As Int32, ByVal Step1 As String, ByVal Step2 As String)
        Try
            Dim Cmd As New SqlCommand
            With Cmd
                .Connection = Con
                .CommandType = CommandType.Text
                .CommandText = "Insert Into Tbl_Alerts ( TaskCode,TaskCreationDate,TaskStartDate,TaskEndDate,TaskDescription,TaskDepartment,TaskStatus,Emp_ID,TaskExecutor,ReminderDaysBeforeDueDate,Step1,Step2)values(@TaskCode,@TaskCreationDate,@TaskStartDate,@TaskEndDate,@TaskDescription,@TaskDepartment,@TaskStatus,@Emp_ID,@TaskExecutor,@ReminderDaysBeforeDueDate,@Step1,@Step2)"
                .Parameters.Clear()
                .Parameters.AddWithValue("@TaskCode", SqlDbType.Int).Value = TaskCode
                .Parameters.AddWithValue("@TaskCreationDate", SqlDbType.Date).Value = TaskCreationDate
                .Parameters.AddWithValue("@TaskStartDate", SqlDbType.Date).Value = TaskStartDate
                .Parameters.AddWithValue("@TaskEndDate", SqlDbType.Date).Value = TaskEndDate
                .Parameters.AddWithValue("@TaskDescription", SqlDbType.VarChar).Value = TaskDescription
                .Parameters.AddWithValue("@TaskDepartment", SqlDbType.VarChar).Value = TaskDepartment
                .Parameters.AddWithValue("@TaskStatus", SqlDbType.VarChar).Value = TaskStatus
                .Parameters.AddWithValue("@Emp_ID", SqlDbType.Int).Value = Emp_ID
                .Parameters.AddWithValue("@TaskExecutor", SqlDbType.VarChar).Value = TaskExecutor
                .Parameters.AddWithValue("@ReminderDaysBeforeDueDate", SqlDbType.Int).Value = ReminderDaysBeforeDueDate
                .Parameters.AddWithValue("@Step1", SqlDbType.VarChar).Value = Step1
                .Parameters.AddWithValue("@Step2", SqlDbType.VarChar).Value = Step2
            End With
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Cmd.ExecuteNonQuery()
            Con.Close()
            MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
            Cmd = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub Update_Tbl_Alerts(ByVal TaskCreationDate As Date, ByVal TaskStartDate As Date, ByVal TaskEndDate As Date, ByVal TaskDescription As String, ByVal TaskDepartment As String, ByVal TaskStatus As String, ByVal Emp_ID As Int32, ByVal TaskExecutor As String, ByVal ReminderDaysBeforeDueDate As Int32, ByVal Step1 As String, ByVal Step2 As String, ByVal TaskCodeW As Int32)
        Try
            Dim Cmd As New SqlCommand
            With Cmd
                .Connection = Con
                .CommandType = CommandType.Text
                .CommandText = "Update Tbl_Alerts Set TaskCreationDate = @TaskCreationDate,TaskStartDate = @TaskStartDate,TaskEndDate = @TaskEndDate,TaskDescription = @TaskDescription,TaskDepartment = @TaskDepartment,TaskStatus = @TaskStatus,Emp_ID = @Emp_ID,TaskExecutor = @TaskExecutor,ReminderDaysBeforeDueDate = @ReminderDaysBeforeDueDate,Step1 = @Step1,Step2 = @Step2 Where TaskCode = @TaskCode"
                .Parameters.Clear()
                .Parameters.AddWithValue("@TaskCreationDate", SqlDbType.Date).Value = TaskCreationDate
                .Parameters.AddWithValue("@TaskStartDate", SqlDbType.Date).Value = TaskStartDate
                .Parameters.AddWithValue("@TaskEndDate", SqlDbType.Date).Value = TaskEndDate
                .Parameters.AddWithValue("@TaskDescription", SqlDbType.VarChar).Value = TaskDescription
                .Parameters.AddWithValue("@TaskDepartment", SqlDbType.VarChar).Value = TaskDepartment
                .Parameters.AddWithValue("@TaskStatus", SqlDbType.VarChar).Value = TaskStatus
                .Parameters.AddWithValue("@Emp_ID", SqlDbType.Int).Value = Emp_ID
                .Parameters.AddWithValue("@TaskExecutor", SqlDbType.VarChar).Value = TaskExecutor
                .Parameters.AddWithValue("@ReminderDaysBeforeDueDate", SqlDbType.Int).Value = ReminderDaysBeforeDueDate
                .Parameters.AddWithValue("@Step1", SqlDbType.VarChar).Value = Step1
                .Parameters.AddWithValue("@Step2", SqlDbType.VarChar).Value = Step2
                .Parameters.AddWithValue("@TaskCode", SqlDbType.Int).Value = TaskCodeW
            End With
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Cmd.ExecuteNonQuery()
            Con.Close()
            MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
            Cmd = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Frm_Alerts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ApplyPermissions(Me.Name)
            CustomizeForm(Me)
            ClearControls()
            SelectAll_Tbl_Alerts(dgv_Tbl_Alerts)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        '------------------------------------------------------------------------------------------------------
        'خاص بالصلاحيات للفورم
        If Not CanAdd Then
            MessageBox.Show("ليس لديك صلاحية الإضافة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        '------------------------------------------------------------------------------------------------------
        Dim MovementDescription As String = " تم حفظ المهمة  " + TaskDescription.Text
        Dim DeviceName As String = Environ$("computername")

        Try
            If String.IsNullOrWhiteSpace(TaskDescription.Text) Then
                MessageBox.Show("يرجى إدخال وصف المهمة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                Exit Sub
            End If
            Dim Emp_ID_Value As Integer = GetIntegerValue(Emp_ID.Text)
            Insert_Tbl_Alerts(TaskCode.Text, TaskCreationDate.Value, TaskStartDate.Text, TaskEndDate.Text, TaskDescription.Text, TaskDepartment.Text, TaskStatus.Text, Emp_ID_Value, TaskExecutor.Text, ReminderDaysBeforeDueDate.Text, Step1.Text, Step2.Text)
            Insert_MovementHistory(MovementDescription, DateTime.Now, loggedInUserName, DeviceName, Me.Name, "BtnSave")
            ClearControls()
            SelectAll_Tbl_Alerts(dgv_Tbl_Alerts)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ''Private Sub TaskStartDate_Leave(sender As Object, e As KeyEventArgs) Handles TaskStartDate.Leave
    ''    Try
    ''        Dim day As Integer
    ''        Dim month As Integer
    ''        Dim yearr As Integer
    ''        ' تحويل النص المدخل في TextBox إلى أرقام
    ''        day = Val(Mid(TaskStartDate.Text, 1, 2))
    ''        month = Val(Mid(TaskStartDate.Text, 3, 2))
    ''        ' تحديد السنة
    ''        If Len(TaskStartDate.Text) > 5 Then
    ''            If Year(Now) Mod 100 < 50 Then
    ''                yearr = 2000 + Val(Mid(TaskStartDate.Text, 5, 6))
    ''            Else
    ''                yearr = 1900 + Val(Mid(TaskStartDate.Text, 5, 6))
    ''            End If
    ''        Else
    ''            yearr = Year(Now)
    ''        End If
    ''        TaskStartDate.Text = Format(day, "00") & "-" & Format(month, "00") & "-" & yearr
    ''    Catch ex As Exception
    ''        MessageBox.Show(ex.Message)
    ''    End Try

    ''End Sub



    Private Sub dgv_Tbl_Alerts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Tbl_Alerts.CellContentClick
        Try

            ' Get values from DataGridView cells
            Dim taskCode1 As String = dgv_Tbl_Alerts.CurrentRow.Cells("TaskCode").Value.ToString()
            Dim taskCreationDate1 As Date = dgv_Tbl_Alerts.CurrentRow.Cells("TaskCreationDate").Value
            Dim taskStartDate1 As Date = dgv_Tbl_Alerts.CurrentRow.Cells("TaskStartDate").Value
            Dim taskEndDate1 As Date = dgv_Tbl_Alerts.CurrentRow.Cells("TaskEndDate").Value
            Dim taskDescription1 As String = dgv_Tbl_Alerts.CurrentRow.Cells("TaskDescription").Value.ToString()
            Dim taskDepartment1 As String = dgv_Tbl_Alerts.CurrentRow.Cells("TaskDepartment").Value.ToString()
            Dim taskStatus1 As String = dgv_Tbl_Alerts.CurrentRow.Cells("TaskStatus").Value.ToString()
            Dim empID1 As Integer = CInt(dgv_Tbl_Alerts.CurrentRow.Cells("Emp_ID").Value)
            Dim taskExecutor1 As String = dgv_Tbl_Alerts.CurrentRow.Cells("TaskExecutor").Value.ToString()
            Dim reminderDaysBeforeDueDate1 As Integer = CInt(dgv_Tbl_Alerts.CurrentRow.Cells("ReminderDaysBeforeDueDate").Value)
            Dim Step_One As String = dgv_Tbl_Alerts.CurrentRow.Cells("Step1").Value.ToString()
            Dim Step_Two As String = dgv_Tbl_Alerts.CurrentRow.Cells("Step2").Value.ToString()
            ' Validate data
            If Not IsDate(taskStartDate1) Or Not IsDate(taskEndDate1) Then
                MessageBox.Show("خطأ فى التنسيق")
                Exit Sub
            End If
            ' Format start and end dates
            Dim formattedStartDate As String = taskStartDate1.ToString("dd - MM - yyyy")
            Dim formattedEndDate As String = taskEndDate1.ToString("dd - MM - yyyy")
            ' Set values to textboxes
            TaskCode.Text = taskCode1
            TaskCreationDate.Text = taskCreationDate1.ToString("dd - MM - yyyy")
            TaskStartDate.Text = formattedStartDate
            TaskEndDate.Text = formattedEndDate
            TaskDescription.Text = taskDescription1
            TaskDepartment.Text = taskDepartment1
            TaskStatus.Text = taskStatus1
            Emp_ID.Text = empID1.ToString()
            TaskExecutor.Text = taskExecutor1
            ReminderDaysBeforeDueDate.Text = reminderDaysBeforeDueDate1.ToString()
            Step1.Text = Step_One.ToString()
            Step2.Text = Step_Two.ToString()
            BtnSave.Enabled = False
            BtnEdit.Enabled = True
            BtnDelete.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        '------------------------------------------------------------------------------------------------------
        'خاص بالصلاحيات للفورم
        If Not CanEdit Then
            MessageBox.Show("ليس لديك صلاحية التعديل.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        '------------------------------------------------------------------------------------------------------
        Try
            Update_Tbl_Alerts(TaskCreationDate.Value, TaskStartDate.Text, TaskEndDate.Text, TaskDescription.Text, TaskDepartment.Text, TaskStatus.Text, Emp_ID.Text, TaskExecutor.Text, ReminderDaysBeforeDueDate.Text, Step1.Text, Step2.Text, TaskCode.Text)
            ClearControls()
            SelectAll_Tbl_Alerts(dgv_Tbl_Alerts)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Btn_Task_Alert_Click(sender As Object, e As EventArgs) Handles Btn_Task_Alert.Click
        ClearControls()
        SelectAll_Alarm_Alerts(dgv_Tbl_Alerts)
    End Sub

    Private Sub BtnNewAdd_Click(sender As Object, e As EventArgs) Handles BtnNewAdd.Click
        '------------------------------------------------------------------------------------------------------
        'خاص بالصلاحيات للفورم
        If Not CanAdd Then
            MessageBox.Show("ليس لديك صلاحية الإضافة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        '------------------------------------------------------------------------------------------------------
        ClearControls()
    End Sub

    Private Sub Txt_Search_TextChanged(sender As Object, e As EventArgs) Handles Txt_Search.TextChanged
        Dim da As New SqlDataAdapter
        dt_Tbl_Alerts.Clear()
        da = New SqlDataAdapter("Select * from Tbl_Alerts", Con)
        da.Fill(dt_Tbl_Alerts)
        Try
            Dim dv As DataView = dt_Tbl_Alerts.DefaultView
            Select Case True
                Case RadioButton1.Checked ' إذا كان الراديو الأول محدد
                    Dim da1 As New SqlDataAdapter
                    dt_Tbl_Alerts.Clear()
                    da1 = New SqlDataAdapter("Select * from Tbl_Alerts where TaskStatus = 'انتهت'", Con)
                    da1.Fill(dt_Tbl_Alerts)
                    Select Case ComboSearch.Text
                        Case "قسم المهمة"
                            dv.RowFilter = "TaskDepartment LIKE '%" & Txt_Search.Text & "%'"
                        Case "كود الموظف"
                            dv.RowFilter = "Convert(Emp_ID, 'System.String') LIKE '%" & Txt_Search.Text & "%'"
                        Case "تاريخ المهمة"
                            dv.RowFilter = "TaskStartDate LIKE '%" & Txt_Search.Text & "%'"
                        Case "القائم بالمهمة"
                            dv.RowFilter = "TaskExecutor LIKE '%" & Txt_Search.Text & "%'"
                    End Select
                Case RadioButton2.Checked ' إذا كان الراديو الثاني محدد
                    Dim da2 As New SqlDataAdapter
                    dt_Tbl_Alerts.Clear()
                    da2 = New SqlDataAdapter("Select * from Tbl_Alerts where TaskStatus = 'جارى العمل عليها'", Con)
                    da2.Fill(dt_Tbl_Alerts)
                    Select Case ComboSearch.Text
                        Case "قسم المهمة"
                            dv.RowFilter = "TaskDepartment LIKE '%" & Txt_Search.Text & "%'"
                        Case "كود الموظف"
                            dv.RowFilter = "Convert(Emp_ID, 'System.String') LIKE '%" & Txt_Search.Text & "%'"
                        Case "تاريخ المهمة"
                            dv.RowFilter = "TaskStartDate LIKE '%" & Txt_Search.Text & "%'"
                        Case "القائم بالمهمة"
                            dv.RowFilter = "TaskExecutor LIKE '%" & Txt_Search.Text & "%'"
                    End Select
                Case RadioButton3.Checked ' إذا كان الراديو الثالث محدد
                    Dim da3 As New SqlDataAdapter
                    dt_Tbl_Alerts.Clear()
                    da3 = New SqlDataAdapter("Select * from Tbl_Alerts where TaskStatus = 'مؤجل'", Con)
                    da3.Fill(dt_Tbl_Alerts)
                    Select Case ComboSearch.Text
                        Case "قسم المهمة"
                            dv.RowFilter = "TaskDepartment LIKE '%" & Txt_Search.Text & "%'"
                        Case "كود الموظف"
                            dv.RowFilter = "Convert(Emp_ID, 'System.String') LIKE '%" & Txt_Search.Text & "%'"
                        Case "تاريخ المهمة"
                            dv.RowFilter = "TaskStartDate LIKE '%" & Txt_Search.Text & "%'"
                        Case "القائم بالمهمة"
                            dv.RowFilter = "TaskExecutor LIKE '%" & Txt_Search.Text & "%'"
                    End Select
                Case RadioButton4.Checked ' إذا كان الراديو الرابع محدد
                    Dim da4 As New SqlDataAdapter
                    dt_Tbl_Alerts.Clear()
                    da4 = New SqlDataAdapter("Select * from Tbl_Alerts where TaskStatus = 'هام'", Con)
                    da4.Fill(dt_Tbl_Alerts)

                    Select Case ComboSearch.Text
                        Case "قسم المهمة"
                            dv.RowFilter = "TaskDepartment LIKE '%" & Txt_Search.Text & "%'"
                        Case "كود الموظف"
                            dv.RowFilter = "Convert(Emp_ID, 'System.String') LIKE '%" & Txt_Search.Text & "%'"
                        Case "تاريخ المهمة"
                            dv.RowFilter = "TaskStartDate LIKE '%" & Txt_Search.Text & "%'"
                        Case "القائم بالمهمة"
                            dv.RowFilter = "TaskExecutor LIKE '%" & Txt_Search.Text & "%'"
                    End Select
            End Select
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Btn_Print_Click(sender As Object, e As EventArgs) Handles Btn_Print.Click
        '------------------------------------------------------------------------------------------------------
        'خاص بالصلاحيات للفورم
        If Not CanPrint Then
            MessageBox.Show("ليس لديك صلاحية الطباعة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        '------------------------------------------------------------------------------------------------------

        Dim rep As New Rep_Task_Reminder
        rep.SetDataSource(dt_Tbl_Alerts.DefaultView)
        'rep.Section2.SectionFormat.BackgroundColor = Color.FromArgb(0, 167, 131)
        Frm_Report.CrystalReportViewer1.ReportSource = rep
        Frm_Report.CrystalReportViewer1.Refresh()
        Frm_Report.ShowDialog()
    End Sub


    Private Sub TaskStartDate_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles TaskStartDate.PreviewKeyDown
        If e.KeyCode = Keys.Tab Then
            ' تعيين IsInputKey إلى True لتفعيل الحدث KeyDown عند الضغط على Tab
            e.IsInputKey = True
        End If
    End Sub

    Private Sub TaskStartDate_KeyDown(sender As Object, e As KeyEventArgs) Handles TaskStartDate.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            ' عند الضغط على مفتاح Enter
            Dim day As Integer
            Dim month As Integer
            Dim yearr As Integer
            ' تحويل النص المدخل في TextBox إلى أرقام
            day = Val(Mid(TaskStartDate.Text, 1, 2))
            month = Val(Mid(TaskStartDate.Text, 3, 2))
            ' تحديد السنة
            If Len(TaskStartDate.Text) > 5 Then
                If Year(Now) Mod 100 < 50 Then
                    yearr = 2000 + Val(Mid(TaskStartDate.Text, 5, 6))
                Else
                    yearr = 1900 + Val(Mid(TaskStartDate.Text, 5, 6))
                End If
            Else
                yearr = Year(Now)
            End If
            ' عرض التاريخ بالتنسيق المطلوب
            TaskStartDate.Text = Format(day, "00") & "-" & Format(month, "00") & "-" & yearr
            e.SuppressKeyPress = True
            TaskEndDate.Focus()
        End If
    End Sub


    Private Sub TaskEndDate_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles TaskEndDate.PreviewKeyDown
        If e.KeyCode = Keys.Tab Then
            ' تعيين IsInputKey إلى True لتفعيل الحدث KeyDown عند الضغط على Tab
            e.IsInputKey = True
        End If
    End Sub


    Private Sub TaskEndDate_KeyDown(sender As Object, e As KeyEventArgs) Handles TaskEndDate.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Tab Then
            Dim day As Integer
            Dim month As Integer
            Dim yearr As Integer
            ' تحويل النص المدخل في TextBox إلى أرقام
            day = Val(Mid(TaskEndDate.Text, 1, 2))
            month = Val(Mid(TaskEndDate.Text, 3, 2))
            ' تحديد السنة
            If Len(TaskEndDate.Text) > 5 Then
                If Year(Now) Mod 100 < 50 Then
                    yearr = 2000 + Val(Mid(TaskEndDate.Text, 5, 6))
                Else
                    yearr = 1900 + Val(Mid(TaskEndDate.Text, 5, 6))
                End If
            Else
                yearr = Year(Now)
            End If
            ' عرض التاريخ بالتنسيق المطلوب
            TaskEndDate.Text = Format(day, "00") & "-" & Format(month, "00") & "-" & yearr
            ' منع الفعل الافتراضي لمفتاح Tab
            e.SuppressKeyPress = True
            ' نقل التركيز إلى مربع النص الآخر
            TaskDepartment.Focus()
        End If
    End Sub

End Class