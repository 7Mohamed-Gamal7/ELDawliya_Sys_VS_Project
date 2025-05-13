Imports System.Data.SqlClient

Public Class Frm_Add_Proplem
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Public dt_Tbl_Problem_Machine As New DataTable
    ' تعيين القيم في البناء
    Public Sub ClearControls()
        Me.Problem_Code.Text = vbNullString
        Me.Problem_Name.Text = vbNullString
        'Me.Problem_Department.Text = vbNullString
        'Me.Problem_Machine.Text = vbNullString
        'Me.Combo_Unit.Text = vbNullString
    End Sub
    Public Sub fillcmb_Tbl_Unit(ByVal cmb As ComboBox)
        Dim DT As New DataTable
        Dim DA As New SqlDataAdapter
        DT.Clear()
        DA = New SqlDataAdapter("Select * FROM Tbl_Unit ", Con)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            cmb.DataSource = DT
            cmb.ValueMember = "Unit_ID"
            cmb.DisplayMember = "Unit_Name"
        Else
            cmb.DataSource = Nothing
        End If
    End Sub
    Public Sub Insert_Tbl_Problem_Machine(ByVal Problem_Code As Int32, ByVal Problem_Name As String, ByVal Problem_Department As String, ByVal Problem_Machine As String, ByVal Unit_ID As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Tbl_Problem_Machine ( Problem_Code,Problem_Name,Problem_Department,Problem_Machine,Unit_ID)values(@Problem_Code,@Problem_Name,@Problem_Department,@Problem_Machine,@Unit_ID)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Problem_Code", SqlDbType.Int).Value = Problem_Code
            .Parameters.AddWithValue("@Problem_Name", SqlDbType.VarChar).Value = Problem_Name
            .Parameters.AddWithValue("@Problem_Department", SqlDbType.VarChar).Value = Problem_Department
            .Parameters.AddWithValue("@Problem_Machine", SqlDbType.VarChar).Value = Problem_Machine
            .Parameters.AddWithValue("@Unit_ID", SqlDbType.Int).Value = Unit_ID
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub
    Public Sub SelectAll_Tbl_Problem_Machine(dgv As DataGridView)
        Dim da As New SqlDataAdapter
        dt_Tbl_Problem_Machine.Clear()
        '''da = New SqlDataAdapter("select * from Tbl_Problem_Machine", Con)
        da = New SqlDataAdapter("SELECT P.Problem_Code, P.Problem_Name, P.Problem_Department, P.Problem_Machine, U.Unit_Name " &
                           "FROM Tbl_Problem_Machine P INNER JOIN Tbl_Unit U ON P.Unit_ID = U.Unit_ID", Con)
        da.Fill(dt_Tbl_Problem_Machine)
        dgv.DataSource = dt_Tbl_Problem_Machine
        If dgv.RowCount > 0 Then
            With dgv
                '.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                .Columns("Problem_Code").HeaderText = "كود المشكلة"
                .Columns("Problem_Code").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                .Columns("Problem_Name").HeaderText = "اسم المشكلة"
                .Columns("Problem_Name").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns("Problem_Department").Visible = False
                .Columns("Problem_Department").HeaderText = "قسم المشكلة"
                .Columns("Problem_Machine").Visible = False
                .Columns("Problem_Machine").HeaderText = "ماكينة المشكلة"
                .Columns("Unit_Name").HeaderText = "اسم الوحدة"
                .Columns("Unit_Name").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            End With
        End If
    End Sub
    '''Public Sub Load_Tbl_Problem_Machine()
    '''    Try
    '''        dgv_Tbl_Problem_Machine.Rows.Clear()
    '''        If Con.State = 1 Then Con.Close()
    '''        Con.Open()
    '''        Dim cmd As New SqlCommand("SELECT PM.Problem_Code, PM.Problem_Name, PM.Problem_Department, PM.Problem_Machine, U.Unit_Name " &
    '''                              "FROM Tbl_Problem_Machine PM " &
    '''                              "JOIN Tbl_Unit U ON PM.Unit_ID = U.Unit_ID", Con)
    '''        Dim adp As New SqlDataAdapter(cmd)
    '''        Dim dr As SqlDataReader
    '''        dr = cmd.ExecuteReader
    '''        While dr.Read
    '''            dgv_Tbl_Problem_Machine.Rows.Add(dr("Problem_Code").ToString, dr("Problem_Name").ToString, dr("Problem_Department").ToString, dr("Problem_Machine").ToString, dr("Unit_Name").ToString)
    '''        End While
    '''        dr.Close()
    '''        Con.Close()
    '''    Catch ex As Exception
    '''        Con.Close()
    '''    End Try
    '''End Sub
    Public Function Max_Tbl_Problem_Machine()
        Dim Number As Integer
        Try
            Dim cmd As New SqlCommand("Select Max(Problem_Code) From Tbl_Problem_Machine ", Con)
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
    Public Sub Update_Tbl_Problem_Machine(ByVal Problem_Name As String, ByVal Problem_Department As String, ByVal Problem_Machine As String, ByVal Unit_ID As Int32, ByVal Problem_CodeW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_Problem_Machine Set Problem_Name = @Problem_Name,Problem_Department = @Problem_Department,Problem_Machine = @Problem_Machine,Unit_ID = @Unit_ID Where Problem_Code = @Problem_Code"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Problem_Name", SqlDbType.VarChar).Value = Problem_Name
            .Parameters.AddWithValue("@Problem_Department", SqlDbType.VarChar).Value = Problem_Department
            .Parameters.AddWithValue("@Problem_Machine", SqlDbType.VarChar).Value = Problem_Machine
            .Parameters.AddWithValue("@Unit_ID", SqlDbType.Int).Value = Unit_ID
            .Parameters.AddWithValue("@Problem_Code", SqlDbType.Int).Value = Problem_CodeW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub
    Public Sub Delete_Tbl_Problem_Machine(ByVal dgv_Tbl_Problem_Machine As DataGridView)
        Dim Position As Integer = dgv_Tbl_Problem_Machine.CurrentRow.Index
        Dim ID_Position As Integer = dgv_Tbl_Problem_Machine.Rows(Position).Cells("Problem_Code").Value
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Delete  From Tbl_Problem_Machine Where Problem_Code = @Problem_Code"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Problem_Code", SqlDbType.Int).Value = ID_Position
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم حذف السجل.", MsgBoxStyle.Information, "حذف")
        Cmd = Nothing
        SelectAll_Tbl_Problem_Machine(dgv_Tbl_Problem_Machine)
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
    '''Private Sub UpdateControlState(Tool_ID As String, permissionLevel As Integer)
    '''    ' قم بتحديث حالة العنصر (التفاعلية أو القابلة للرؤية) بناءً على مستوى الصلاحية
    '''    ' يمكنك تعديل هذا الكود وفقًا لتصميم وعناصر الفورم الفعليين.
    '''    Select Case Tool_ID
    '''        Case "BtnSave"
    '''            BtnSave.Visible = (permissionLevel >= 2)
    '''        Case "BtnDelete"
    '''            BtnDelete.Visible = (permissionLevel >= 2)
    '''        Case "BtnEdit"
    '''            BtnEdit.Visible = (permissionLevel >= 2)
    '''    End Select
    '''End Sub
    Private Sub Frm_AddNewProplem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ChangeScreenResolution(Me)
        ClearControls()
        Problem_Code.Text = Max_Tbl_Problem_Machine() + 1
        SelectAll_Tbl_Problem_Machine(dgv_Tbl_Problem_Machine)
        fillcmb_Tbl_Department(Problem_Department)
        fillcmb_Tbl_Unit(Combo_Unit)
        Try
            Dim currentUserID As Integer = loggedInUserID
            ' استعلم عن صلاحيات المستخدم على Frm_Home
            Dim permissionData As New Dictionary(Of String, Integer)
            ' استعلم عن صلاحيات المستخدم على Frm_Home
            Dim query As String = "SELECT Tbl_Tool_Name.Tool_Name, PermissionLevel FROM UserPermissions INNER JOIN Tbl_Tool_Name ON UserPermissions.Tool_ID = Tbl_Tool_Name.Tool_ID WHERE UserID = " & currentUserID & " AND UserPermissions.Frm_ID = Tbl_Tool_Name.Frm_ID"
            ' قم بتنفيذ الاستعلام وقراءة النتائج
            Using connection As New SqlConnection(GetConnectionString())
                connection.Open()
                Using cmd As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim Tool_ID As String = reader("Tool_Name").ToString()
                            Dim permissionLevel As Integer = Convert.ToInt32(reader("PermissionLevel"))
                            ' قم بإضافة البيانات إلى القاموس
                            permissionData.Add(Tool_ID, permissionLevel)
                        End While
                    End Using
                End Using
            End Using
            '''UpdateControlState("BtnSave", permissionData("BtnSave"))
            '''UpdateControlState("BtnEdit", permissionData("BtnEdit"))
            '''UpdateControlState("BtnDelete", permissionData("BtnDelete"))
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub BtnNewAdd_Click(sender As Object, e As EventArgs) Handles BtnNewAdd.Click
        ClearControls()
        Me.Problem_Code.Text = Max_Tbl_Problem_Machine() + 1
        Me.Problem_Name.Focus()
    End Sub
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Update_Tbl_Problem_Machine(Problem_Name.Text, Problem_Department.Text, Problem_Machine.Text, Int(Combo_Unit.SelectedValue), Problem_Code.Text)
        ClearControls()
        Me.Problem_Code.Text = Max_Tbl_Problem_Machine() + 1
        SelectAll_Tbl_Problem_Machine(dgv_Tbl_Problem_Machine)
        Me.Problem_Name.Focus()
    End Sub
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
            Exit Sub
        Else
            Delete_Tbl_Problem_Machine(dgv_Tbl_Problem_Machine)
        End If
        ClearControls()
        Me.Problem_Code.Text = Max_Tbl_Problem_Machine() + 1
        SelectAll_Tbl_Problem_Machine(dgv_Tbl_Problem_Machine)
        Me.Problem_Name.Focus()
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        'Dim problemCode As Int32
        'problemCode = Problem_Code.Text
        Try
            If Problem_Name.Text = vbNullString Or Problem_Department.Text = vbNullString Or Problem_Machine.Text = vbNullString Then
                MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                Exit Sub
            End If
            Insert_Tbl_Problem_Machine(Problem_Code.Text, Problem_Name.Text, Problem_Department.Text, Problem_Machine.Text, Int(Combo_Unit.SelectedValue))
            ClearControls()
            Problem_Code.Text = Max_Tbl_Problem_Machine() + 1
            SelectAll_Tbl_Problem_Machine(dgv_Tbl_Problem_Machine)
            Me.Problem_Name.Focus()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub dgv_Tbl_Problem_Machine_Click(sender As Object, e As EventArgs) Handles dgv_Tbl_Problem_Machine.Click
        Try
            With dgv_Tbl_Problem_Machine
                Me.Problem_Code.Text = .CurrentRow.Cells("Problem_Code").Value.ToString()
                Me.Problem_Name.Text = .CurrentRow.Cells("Problem_Name").Value.ToString()
                Me.Problem_Department.Text = .CurrentRow.Cells("Problem_Department").Value.ToString()
                Me.Problem_Machine.Text = .CurrentRow.Cells("Problem_Machine").Value.ToString()
                Me.Combo_Unit.DisplayMember = .CurrentRow.Cells("Unit_Name").Value.ToString()
            End With
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Frm_Add_Unit.Show()
    End Sub
    Private Sub Combo_Unit_DropDown(sender As Object, e As EventArgs) Handles Combo_Unit.DropDown
        fillcmb_Tbl_Unit(Combo_Unit)
    End Sub
    'Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
    '    If Panel1.Width > 50 Then
    '        While Panel1.Width > 50
    '            Panel1.Width -= 10
    '        End While
    '        Exit Sub
    '    End If

    '    If Panel1.Width < 100 Then
    '        While Panel1.Width < 100
    '            Panel1.Width += 10
    '        End While
    '        Exit Sub
    '    End If
    'End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

End Class