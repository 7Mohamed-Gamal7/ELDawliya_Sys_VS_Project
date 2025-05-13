Imports System.Data.SqlClient

Public Class Add_Report_Machine
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Dim ProblemID As Integer

    Public Sub ClearControls()
        Me.MachineID.Text = vbNullString
        Me.ReportTitle.Text = vbNullString
        Me.MachineID.SelectedValue = -1
        Me.DepartmentID.SelectedValue = -1
        Me.ReportDate.Value = Today
        Me.ProblemDescription.Text = vbNullString
        Me.ProblemDescription.Text = vbNullString
        Me.Emp_ID.SelectedValue = -1
        Me.ReportTitle.Focus()
    End Sub


    Public Function Max_Reports_Machine_Problems()
        Dim Number As Integer
        Try
            Dim cmd As New SqlCommand("Select Max(ReportID) From Reports_Machine_Problems ", Con)
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

    Public Function Max_Problems()
        Dim Number As Integer
        Try
            Dim cmd As New SqlCommand("Select Max(ProblemID) From Problems ", Con)
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


    Public Sub fillcmb_Machine(ByVal cmb As ComboBox)
        Dim DT As New DataTable
        Dim DA As New SqlDataAdapter
        DT.Clear()
        DA = New SqlDataAdapter("Select * FROM Machine ", Con)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            cmb.DataSource = DT
            cmb.ValueMember = "MachineID"
            cmb.DisplayMember = "MachineName"
        Else
            cmb.DataSource = Nothing
        End If
    End Sub

    Public Sub fillcmb_Tbl_Employee(ByVal cmb As ComboBox)
        Dim DT As New DataTable
        Dim DA As New SqlDataAdapter
        DT.Clear()
        DA = New SqlDataAdapter("SELECT * FROM Tbl_Employee WHERE Dept_Code IN (1, 2, 3,4,5,21) and Working_Condition = 'سارى'", Con)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            cmb.DataSource = DT
            cmb.ValueMember = "Emp_ID"
            cmb.DisplayMember = "Emp_Full_Name"
        Else
            cmb.DataSource = Nothing
        End If
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

    Public Sub Insert_Reports_Machine_Problems(ByVal ReportTitle As String, ByVal ReportDate As Date, ByVal Dept_Code As String, ByVal Report_Writer As String)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Reports_Machine_Problems ( ReportTitle,ReportDate,Dept_Code,Report_Writer)values(@ReportTitle,@ReportDate,@Dept_Code,@Report_Writer)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@ReportTitle", SqlDbType.VarChar).Value = ReportTitle
            .Parameters.AddWithValue("@ReportDate", SqlDbType.Date).Value = ReportDate
            .Parameters.AddWithValue("@Dept_Code", SqlDbType.VarChar).Value = Dept_Code
            .Parameters.AddWithValue("@Report_Writer", SqlDbType.VarChar).Value = Report_Writer
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub

    Public Sub Insert_Problems(ByVal ProblemDescription As String, ByVal ProblemDate As Date, ByVal MachineID As Int32, ByVal ReportID As Int32, ByVal Dept_Code As Int32, ByVal Action_Taken As String)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Problems ( ProblemDescription,ProblemDate,MachineID,ReportID,Dept_Code,Action_Taken)values(@ProblemDescription,@ProblemDate,@MachineID,@ReportID,@Dept_Code,@Action_Taken)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@ProblemDescription", SqlDbType.VarChar).Value = ProblemDescription
            .Parameters.AddWithValue("@ProblemDate", SqlDbType.Date).Value = ProblemDate
            .Parameters.AddWithValue("@MachineID", SqlDbType.Int).Value = MachineID
            .Parameters.AddWithValue("@ReportID", SqlDbType.Int).Value = ReportID
            .Parameters.AddWithValue("@Dept_Code", SqlDbType.Int).Value = Dept_Code
            .Parameters.AddWithValue("@Action_Taken", SqlDbType.VarChar).Value = Action_Taken
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub

    Public Sub Insert_ProblemParticipants(ByVal ProblemID As Int32, ByVal Emp_ID As Int32, ByVal ReportID As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into ProblemParticipants ( ProblemID,Emp_ID,ReportID)values(@ProblemID,@Emp_ID,@ReportID)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@ProblemID", SqlDbType.Int).Value = ProblemID
            .Parameters.AddWithValue("@Emp_ID", SqlDbType.Int).Value = Emp_ID
            .Parameters.AddWithValue("@ReportID", SqlDbType.Int).Value = ReportID
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub


    Private Sub Add_Report_Machine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyPermissions(Me.Name)
        CustomizeForm(Me)
        fillcmb_Machine(MachineID)
        fillcmb_Tbl_Employee(Emp_ID)
        fillcmb_Tbl_Department(DepartmentID)
        fillcmb_Users_Login(cmbAssignProblem)
    End Sub

    Private Sub Btn_Add_Report_Click(sender As Object, e As EventArgs) Handles Btn_Add_Report.Click
        '-------------------------------------------------------------------------------------------------------
        'خاص بتطبيق الصلاحيات
        If Not CanAdd Then
            MessageBox.Show("ليس لديك صلاحية الحفظ.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        '-------------------------------------------------------------------------------------------------------

        Insert_Reports_Machine_Problems(ReportTitle.Text, ReportDate.Value, Int(DepartmentID.SelectedValue), loggedInUserName)
        ReportID.Text = Max_Reports_Machine_Problems()
        pnl_Report.Enabled = False
        Pnl_Problem.Visible = True
        'Pnl_Emp.Visible = True
        Me.Btn_Add_Report.Enabled = False

    End Sub

    '''Private Sub btn_Add_Problems_Click(sender As Object, e As EventArgs) Handles btn_Add_Problems.Click

    '''    Insert_Problems(ProblemDescription.Text, Date.Now, Int(MachineID.SelectedValue), ReportID.Text, Int(DepartmentID.SelectedValue))
    '''    ProblemDescription.Text = vbNullString
    '''    ProblemID = Max_Problems()
    '''    Pnl_Emp.Visible = True
    '''    btn_Add_New_Problems.Visible = True
    '''    btnAssignProblem.Visible = True
    '''    cmbAssignProblem.Visible = True
    '''    btn_Add_New_Problems.Visible = True
    '''    btnAssignProblem.Visible = True
    '''    cmbAssignProblem.Visible = True
    '''End Sub

    Private Sub btn_Add_Problems_Click(sender As Object, e As EventArgs) Handles btn_Add_Problems.Click
        Insert_Problems(ProblemDescription.Text, Date.Now, Int(MachineID.SelectedValue), ReportID.Text, Int(DepartmentID.SelectedValue), Txt_Action_Taken.Text)
        ' إضافة TextBox لعرض ProblemDescription في TabPage2
        Dim descriptionTextBox As New TextBox
        descriptionTextBox.Name = "ProblemDescriptionTextBox"
        descriptionTextBox.Text = ProblemDescription.Text
        descriptionTextBox.ReadOnly = True
        descriptionTextBox.Multiline = True
        descriptionTextBox.Height = 100  ' يمكن تعديل الارتفاع حسب الحاجة
        TabPage2.Controls.Add(descriptionTextBox)

        ' إضافة TextBox لعرض Action_Taken في TabPage2
        Dim actionTakenTextBox As New TextBox
        actionTakenTextBox.Name = "ActionTakenTextBox"
        actionTakenTextBox.Text = Txt_Action_Taken.Text  ' افترضنا أن Action_Taken تم جلبه من قاعدة البيانات
        actionTakenTextBox.ReadOnly = True
        actionTakenTextBox.Multiline = True
        actionTakenTextBox.Height = 100  ' يمكن تعديل الارتفاع حسب الحاجة
        TabPage2.Controls.Add(actionTakenTextBox)

        ' جلب المشاركين من جدول ProblemParticipants وعرضهم في TextBox
        Dim participants As List(Of String) = GetProblemParticipants(ProblemID)  ' دالة جلب المشاركين من قاعدة البيانات
        For Each participant In participants
            Dim participantTextBox As New TextBox
            participantTextBox.Name = "ParticipantTextBox_" & participant
            participantTextBox.Text = participant
            participantTextBox.ReadOnly = True
            TabPage2.Controls.Add(participantTextBox)
        Next

        ' إضافة ComboBox لاختيار مستخدم من البرنامج
        Dim userComboBox As New ComboBox
        userComboBox.Name = "UserComboBox"
        userComboBox.Items.Add("User 1")  ' أضف أسماء المستخدمين من قاعدة البيانات
        userComboBox.Items.Add("User 2")  ' يمكنك تعديل هذه القيم حسب الحاجة
        userComboBox.SelectedIndex = 0
        TabPage2.Controls.Add(userComboBox)

        ' ترتيب العناصر رأسياً باستخدام FlowLayoutPanel
        Dim flowPanel As New FlowLayoutPanel
        flowPanel.FlowDirection = FlowDirection.TopDown
        flowPanel.Controls.Add(descriptionTextBox)
        flowPanel.Controls.Add(actionTakenTextBox)
        For Each participant In participants
            Dim participantTextBox As New TextBox
            participantTextBox.Name = "ParticipantTextBox_" & participant
            participantTextBox.Text = participant
            participantTextBox.ReadOnly = True
            flowPanel.Controls.Add(participantTextBox)
        Next
        flowPanel.Controls.Add(userComboBox)
        TabPage2.Controls.Add(flowPanel)

        ' متابعة تنفيذ العمليات الأخرى
        ProblemDescription.Text = vbNullString
        Txt_Action_Taken.Text = vbNullString
        ProblemID = Max_Problems()

        ' عرض العناصر الإضافية
        btn_Add_New_Problems.Visible = True
        btnAssignProblem.Visible = True
        cmbAssignProblem.Visible = True
        Label2.Visible = True
        Lbl_Emp_ID.Visible = True
        Emp_ID.Visible = True
        Btn_Add_Participant.Visible = True
        Me.btn_Add_Problems.Enabled = False
    End Sub

    ' دالة جلب المشاركين من قاعدة البيانات
    Private Function GetProblemParticipants(problemID As Integer) As List(Of String)
        Dim participants As New List(Of String)
        ' استعلام SQL لجلب المشاركين
        Dim query As String = "SELECT Emp_ID FROM ProblemParticipants WHERE ProblemID = @ProblemID"
        ' تنفيذ الاستعلام وتخزين النتائج في participants (افترض وجود طريقة لتنفيذ استعلام SQL)
        ' سيتم إضافة المنطق الخاص بالاتصال بقاعدة البيانات هنا.
        ' يجب عليك استخدام ADO.NET أو أي طريقة أخرى للتفاعل مع قاعدة البيانات.
        Return participants
    End Function


    Private Sub Btn_Add_Click(sender As Object, e As EventArgs) Handles Btn_Add.Click
        ClearControls()
        pnl_Report.Enabled = True
        Pnl_Problem.Visible = False
        Me.Btn_Add_Report.Enabled = True
        btn_Add_New_Problems.Visible = False
        btnAssignProblem.Visible = False
        cmbAssignProblem.Visible = False
    End Sub
    Private Sub btnAssignProblem_Click(sender As Object, e As EventArgs) Handles btnAssignProblem.Click
        Dim selectedUserID As Integer = CType(cmbAssignProblem.SelectedValue, Integer)
        Dim report_ID As Integer = CType(ReportID.Text, Integer)

        ' تحديث تقرير التوجيه في قاعدة البيانات
        Dim query As String = "UPDATE Reports_Machine_Problems SET AssignedTo = @AssignedTo WHERE ReportID = @ReportID"
        Using conn As New SqlConnection(ConStr)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@AssignedTo", selectedUserID)
                cmd.Parameters.AddWithValue("@ReportID", report_ID)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using

        ' إضافة إشعار جديد
        Dim notificationQuery As String = "INSERT INTO Notifications (ReportID, UserID, Message, IsRead) VALUES (@ReportID, @UserID, @Message, 0)"
        Using conn As New SqlConnection(ConStr)
            Using cmd As New SqlCommand(notificationQuery, conn)
                cmd.Parameters.AddWithValue("@ReportID", report_ID)
                cmd.Parameters.AddWithValue("@UserID", selectedUserID)
                cmd.Parameters.AddWithValue("@Message", "هناك مشكلة جديدة موجهة إليك.")
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Public Sub fillcmb_Users_Login(ByVal cmb As ComboBox)
        Dim DT As New DataTable
        Dim DA As New SqlDataAdapter
        DT.Clear()
        DA = New SqlDataAdapter("Select * FROM Users_Login ", Con)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            cmb.DataSource = DT
            cmb.ValueMember = "UserID"
            cmb.DisplayMember = "UserName"
        Else
            cmb.DataSource = Nothing
        End If
    End Sub

    Private Sub Btn_Add_Participant_Click_1(sender As Object, e As EventArgs) Handles Btn_Add_Participant.Click
        ProblemID = Max_Problems()
        Insert_ProblemParticipants(ProblemID.ToString, Int(Emp_ID.SelectedValue), ReportID.Text)
    End Sub

    Private Sub btn_Add_New_Problems_Click(sender As Object, e As EventArgs) Handles btn_Add_New_Problems.Click
        Label2.Visible = False
        Lbl_Emp_ID.Visible = False
        Emp_ID.Visible = False
        Btn_Add_Participant.Visible = False
        Me.btn_Add_Problems.Enabled = True
    End Sub
End Class