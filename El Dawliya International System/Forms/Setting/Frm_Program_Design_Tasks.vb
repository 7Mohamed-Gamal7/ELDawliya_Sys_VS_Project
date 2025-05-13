Imports System.Data.SqlClient
Imports El_Dawliya_International_System.El_Dawliya_International_System.Forms.Report

Public Class Frm_Program_Design_Tasks
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Public dt_Program_Design_Tasks As New DataTable

    Private Sub Frm_Program_Design_Tasks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomizeForm(Me)
        ClearControls()
        SelectAll_Program_Design_Tasks(dgv_Program_Design_Tasks)
        fillcmb_Tbl_Department(Dept_Code)
    End Sub


    Public Sub Insert_Program_Design_Tasks(ByVal Task_Name As String, ByVal Task_Type As String, ByVal Task_Description As String, ByVal Task_Status As String, ByVal Task_Priority As String, ByVal Dept_Code As Int32, ByVal StartDate As Date, ByVal DueDate As Date, ByVal Notes As String)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Program_Design_Tasks (Task_Name,Task_Type,Task_Description,Task_Status,Task_Priority,Dept_Code,StartDate,DueDate,Notes)values(@Task_Name,@Task_Type,@Task_Description,@Task_Status,@Task_Priority,@Dept_Code,@StartDate,@DueDate,@Notes)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Task_Name", SqlDbType.VarChar).Value = Task_Name
            .Parameters.AddWithValue("@Task_Type", SqlDbType.VarChar).Value = Task_Type
            .Parameters.AddWithValue("@Task_Description", SqlDbType.VarChar).Value = Task_Description
            .Parameters.AddWithValue("@Task_Status", SqlDbType.VarChar).Value = Task_Status
            .Parameters.AddWithValue("@Task_Priority", SqlDbType.VarChar).Value = Task_Priority
            .Parameters.AddWithValue("@Dept_Code", SqlDbType.Int).Value = Dept_Code
            .Parameters.AddWithValue("@StartDate", SqlDbType.Date).Value = StartDate
            .Parameters.AddWithValue("@DueDate", SqlDbType.Date).Value = DueDate
            .Parameters.AddWithValue("@Notes", SqlDbType.VarChar).Value = Notes
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub

    Public Sub Update_Program_Design_Tasks(ByVal Task_Name As String, ByVal Task_Type As String, ByVal Task_Description As String, ByVal Task_Status As String, ByVal Task_Priority As String, ByVal Dept_Code As Int32, ByVal StartDate As Date, ByVal DueDate As Date, ByVal Notes As String, ByVal TaskIDW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Program_Design_Tasks Set Task_Name = @Task_Name,Task_Type = @Task_Type,Task_Description = @Task_Description,Task_Status = @Task_Status,Task_Priority = @Task_Priority,Dept_Code = @Dept_Code,StartDate = @StartDate,DueDate = @DueDate,Notes = @Notes Where TaskID = @TaskID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Task_Name", SqlDbType.VarChar).Value = Task_Name
            .Parameters.AddWithValue("@Task_Type", SqlDbType.VarChar).Value = Task_Type
            .Parameters.AddWithValue("@Task_Description", SqlDbType.VarChar).Value = Task_Description
            .Parameters.AddWithValue("@Task_Status", SqlDbType.VarChar).Value = Task_Status
            .Parameters.AddWithValue("@Task_Priority", SqlDbType.VarChar).Value = Task_Priority
            .Parameters.AddWithValue("@Dept_Code", SqlDbType.Int).Value = Dept_Code
            .Parameters.AddWithValue("@StartDate", SqlDbType.Date).Value = StartDate
            .Parameters.AddWithValue("@DueDate", SqlDbType.Date).Value = DueDate
            .Parameters.AddWithValue("@Notes", SqlDbType.VarChar).Value = Notes
            .Parameters.AddWithValue("@TaskID", SqlDbType.Int).Value = TaskIDW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Public Sub Delete_Program_Design_Tasks(ByVal dgv_Program_Design_Tasks As DataGridView)
        Dim Position As Integer = dgv_Program_Design_Tasks.CurrentRow.Index
        Dim ID_Position As Integer = dgv_Program_Design_Tasks.Rows(Position).Cells("TaskID").Value
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Delete  From Program_Design_Tasks Where TaskID = @TaskID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@TaskID", SqlDbType.Int).Value = ID_Position
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم حذف السجل.", MsgBoxStyle.Information, "حذف")
        Cmd = Nothing
    End Sub


    Public Sub SelectAll_Program_Design_Tasks(dgv As DataGridView)
        Dim da As New SqlDataAdapter
        dt_Program_Design_Tasks.Clear()
        da = New SqlDataAdapter("SELECT dbo.Program_Design_Tasks.*, dbo.Tbl_Department.Dept_Name
                  FROM     dbo.Program_Design_Tasks INNER JOIN
                  dbo.Tbl_Department ON dbo.Program_Design_Tasks.Dept_Code = dbo.Tbl_Department.Dept_Code", Con)
        da.Fill(dt_Program_Design_Tasks)
        dgv.DataSource = dt_Program_Design_Tasks
        'If dgv.RowCount > 0 Then
        With dgv
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .Columns("TaskID").HeaderText = "كود المهمة"
            .Columns("TaskID").Visible = False
            .Columns("Task_Name").HeaderText = "عنوان المهمة"
            .Columns("Task_Type").HeaderText = "نوع المهمة"
            .Columns("Task_Description").HeaderText = "وصف المهمة"
            .Columns("Task_Status").HeaderText = "حالة المهمة"
            .Columns("Task_Priority").HeaderText = "اولوية المهمة"
            .Columns("Dept_Code").HeaderText = "كود القسم"
            .Columns("Dept_Code").Visible = False
            .Columns("Dept_Name").HeaderText = "القسم"
            .Columns("StartDate").HeaderText = "تاريخ البدء"
            .Columns("DueDate").HeaderText = "تاريخ الانتهاء"
            .Columns("AssignedTo").HeaderText = "معين له"
            .Columns("AssignedTo").Visible = False
            .Columns("Notes").HeaderText = "ملاحظات"
            .Columns("CreatedAt").HeaderText = "معين له"
            .Columns("CreatedAt").Visible = False
        End With
        'End If
    End Sub

    Public Sub SelectDueDate(dgv As DataGridView, NumericDay As NumericUpDown)
        Dim da As New SqlDataAdapter
        dt_Program_Design_Tasks.Clear()

        ' قراءة قيمة الأيام من NumericUpDown
        Dim days As Integer = NumericDay.Value

        ' إنشاء نص الاستعلام
        Dim query As String = "SELECT dbo.Program_Design_Tasks.*, dbo.Tbl_Department.Dept_Name " &
                          "FROM dbo.Program_Design_Tasks INNER JOIN " &
                          "dbo.Tbl_Department ON dbo.Program_Design_Tasks.Dept_Code = dbo.Tbl_Department.Dept_Code " &
                          "WHERE DueDate <= DATEADD(DAY, @Days, GETDATE()) AND Task_Status <> 'مكتمل'"

        ' إعداد SqlDataAdapter مع المعلمة
        da = New SqlDataAdapter(query, Con)
        da.SelectCommand.Parameters.AddWithValue("@Days", days)

        ' تعبئة البيانات
        da.Fill(dt_Program_Design_Tasks)
        dgv.DataSource = dt_Program_Design_Tasks

        ' إعداد DataGridView
        With dgv
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .Columns("TaskID").HeaderText = "كود المهمة"
            .Columns("TaskID").Visible = False
            .Columns("Task_Name").HeaderText = "اسم المهمة"
            .Columns("Task_Type").HeaderText = "نوع المهمة"
            .Columns("Task_Description").HeaderText = "وصف المهمة"
            .Columns("Task_Status").HeaderText = "حالة المهمة"
            .Columns("Task_Priority").HeaderText = "أولوية المهمة"
            .Columns("Dept_Code").HeaderText = "كود القسم"
            .Columns("Dept_Code").Visible = False
            .Columns("Dept_Name").HeaderText = "القسم"
            .Columns("StartDate").HeaderText = "تاريخ البدء"
            .Columns("DueDate").HeaderText = "تاريخ الانتهاء"
            .Columns("AssignedTo").HeaderText = "معين له"
            .Columns("AssignedTo").Visible = False
            .Columns("Notes").HeaderText = "ملاحظات"
            .Columns("CreatedAt").HeaderText = "تاريخ الإنشاء"
            .Columns("CreatedAt").Visible = False
        End With
    End Sub

    Public Sub ClearControls()
        Me.TaskID.Text = vbNullString
        Me.Task_Name.Text = vbNullString
        Me.Task_Type.Text = vbNullString
        Me.Task_Description.Text = vbNullString
        Me.Task_Status.Text = vbNullString
        Me.Task_Priority.Text = vbNullString
        Me.Dept_Code.Text = vbNullString
        Me.StartDate.Value = Today
        Me.DueDate.Value = Today
        Me.Notes.Text = vbNullString
        BtnNewAdd.Enabled = True
        BtnSave.Enabled = True
        BtnEdit.Enabled = False
        BtnDelete.Enabled = False
        Me.Task_Name.Focus()
        SelectAll_Program_Design_Tasks(dgv_Program_Design_Tasks)
    End Sub

    Public Sub fillcmb_Tbl_Department(ByVal cmb As ComboBox)
        Dim DT As New DataTable
        Dim DA As New SqlDataAdapter
        DT.Clear()
        DA = New SqlDataAdapter("Select * FROM Tbl_Department ", Con)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            cmb.DataSource = DT
            cmb.ValueMember = "Dept_Code"
            cmb.DisplayMember = "Dept_Name"
        Else
            cmb.DataSource = Nothing
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Insert_Program_Design_Tasks(Task_Name.Text, Task_Type.Text, Task_Description.Text, Task_Status.Text, Task_Priority.Text, Int(Dept_Code.SelectedValue), StartDate.Value, DueDate.Value, Notes.Text)
        ClearControls()
    End Sub

    Private Sub txt_Search_TextChanged(sender As Object, e As EventArgs) Handles txt_Search.TextChanged
        Try
            Dim dv As DataView = dt_Program_Design_Tasks.DefaultView
            dv.RowFilter = "Task_Name LIKE '%" & txt_Search.Text & "%' OR " &
                       "Task_Type LIKE '%" & txt_Search.Text & "%' OR " &
                       "Task_Status LIKE '%" & txt_Search.Text & "%' OR " &
                       "Task_Priority LIKE '%" & txt_Search.Text & "%' OR " &
                       "Dept_Name LIKE '%" & txt_Search.Text & "%'"
        Catch ex As Exception
            ' يمكنك إضافة رسالة خطأ أو تسجيله حسب الحاجة
        End Try
    End Sub


    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Update_Program_Design_Tasks(Task_Name.Text, Task_Type.Text, Task_Description.Text, Task_Status.Text, Task_Priority.Text, Int(Dept_Code.SelectedValue), StartDate.Value, DueDate.Value, Notes.Text, TaskID.Text)
        ClearControls()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
            Exit Sub
        Else
            Delete_Program_Design_Tasks(dgv_Program_Design_Tasks)
        End If
        ClearControls()
    End Sub

    Private Sub TextBoxEnglish_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles Task_Name.Enter
        Arabic(DirectCast(sender, TextBox))
    End Sub

    Private Sub BtnNewAdd_Click(sender As Object, e As EventArgs) Handles BtnNewAdd.Click
        ClearControls()
    End Sub

    Private Sub dgv_Program_Design_Tasks_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Program_Design_Tasks.CellContentClick
        Try
            With dgv_Program_Design_Tasks
                Me.TaskID.Text = .CurrentRow.Cells("TaskID").Value.ToString()
                Me.Task_Name.Text = .CurrentRow.Cells("Task_Name").Value.ToString()
                Me.Task_Type.Text = .CurrentRow.Cells("Task_Type").Value.ToString()
                Me.Task_Description.Text = .CurrentRow.Cells("Task_Description").Value.ToString()
                Me.Task_Status.Text = .CurrentRow.Cells("Task_Status").Value.ToString()
                Me.Task_Priority.Text = .CurrentRow.Cells("Task_Priority").Value.ToString()
                Me.Dept_Code.SelectedValue = .CurrentRow.Cells("Dept_Code").Value.ToString()
                Me.StartDate.Value = .CurrentRow.Cells("StartDate").Value.ToString()
                Me.DueDate.Value = .CurrentRow.Cells("DueDate").Value.ToString()
                Me.Notes.Text = .CurrentRow.Cells("Notes").Value.ToString()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        BtnSave.Enabled = False
        BtnEdit.Enabled = True
        BtnDelete.Enabled = True
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            SelectDueDate(dgv_Program_Design_Tasks, NumericDay)

        ElseIf CheckBox1.Checked = False Then
            SelectAll_Program_Design_Tasks(dgv_Program_Design_Tasks)
        End If
    End Sub

    Private Sub btn_Print_Click(sender As Object, e As EventArgs) Handles btn_Print.Click
        Dim rep As New Rep_Program_Design_Tasks
        rep.SetDataSource(dt_Program_Design_Tasks.DefaultView)
        'rep.Section1.SectionFormat.BackgroundColor = Color.FromArgb(248, 247, 255)
        'rep.Section2.SectionFormat.BackgroundColor = Color.FromArgb(248, 247, 255)
        'rep.Section3.SectionFormat.BackgroundColor = Color.FromArgb(248, 247, 255)
        'rep.Section4.SectionFormat.BackgroundColor = Color.FromArgb(248, 247, 255)
        'rep.Section5.SectionFormat.BackgroundColor = Color.FromArgb(248, 247, 255)
        Frm_Report.CrystalReportViewer1.ReportSource = rep
        Frm_Report.CrystalReportViewer1.Refresh()
        Frm_Report.ShowDialog()
    End Sub
End Class