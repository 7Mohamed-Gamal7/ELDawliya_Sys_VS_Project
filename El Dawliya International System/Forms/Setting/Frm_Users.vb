Imports System.Data.SqlClient
Public Class Frm_Users
    'Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
    '    If Panel1.Width > 50 Then
    '        While Panel1.Width > 50
    '            Panel1.Width -= 20
    '        End While
    '        Exit Sub
    '    End If

    '    If Panel1.Width < 125 Then
    '        While Panel1.Width < 125
    '            Panel1.Width += 20
    '        End While
    '        Exit Sub
    '    End If
    'End Sub
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Public dt_Users As New DataTable
    Public Sub ClearControls()
        Me.UserID.Text = vbNullString
        Me.Username.Text = vbNullString
        Me.Password.Text = vbNullString
        Me.Permissions.Text = vbNullString
        Me.Forms.Text = vbNullString
        Me.Jop.Text = vbNullString
        Me.Dept.Text = vbNullString
        Me.Chk_D1.Checked = False
        Me.Chk_D2.Checked = False
        Me.Chk_F1.Checked = False
        Me.Chk_F2.Checked = False
        Me.Chk_H.Checked = False
    End Sub
    Public Sub Insert_Users(ByVal UserID As Int32, ByVal Username As String, ByVal Password As String, ByVal Permissions As String, ByVal Forms As String, ByVal Jop As String, ByVal Dept As String, ByVal D1 As Boolean, ByVal D2 As Boolean, ByVal F1 As Boolean, ByVal F2 As Boolean, ByVal H As Boolean)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Users ( UserID,Username,Password,Permissions,Forms,Jop,Dept,D1,D2,F1,F2,H)values(@UserID,@Username,@Password,@Permissions,@Forms,@Jop,@Dept,@D1,@D2,@F1,@F2,@H)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@UserID", SqlDbType.Int).Value = UserID
            .Parameters.AddWithValue("@Username", SqlDbType.VarChar).Value = Username
            .Parameters.AddWithValue("@Password", SqlDbType.VarChar).Value = Password
            .Parameters.AddWithValue("@Permissions", SqlDbType.VarChar).Value = Permissions
            .Parameters.AddWithValue("@Forms", SqlDbType.VarChar).Value = Forms
            .Parameters.AddWithValue("@Jop", SqlDbType.VarChar).Value = Jop
            .Parameters.AddWithValue("@Dept", SqlDbType.VarChar).Value = Dept
            .Parameters.AddWithValue("@D1", SqlDbType.Decimal).Value = D1
            .Parameters.AddWithValue("@D2", SqlDbType.Decimal).Value = D2
            .Parameters.AddWithValue("@F1", SqlDbType.Decimal).Value = F1
            .Parameters.AddWithValue("@F2", SqlDbType.Decimal).Value = F2
            .Parameters.AddWithValue("@H", SqlDbType.Decimal).Value = H
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub
    Public Sub Update_Users(ByVal Username As String, ByVal Password As String, ByVal Permissions As String, ByVal Forms As String, ByVal Jop As String, ByVal Dept As String, ByVal D1 As Boolean, ByVal D2 As Boolean, ByVal F1 As Boolean, ByVal F2 As Boolean, ByVal H As Boolean, ByVal UserIDW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Users Set Username = @Username,Password = @Password,Permissions = @Permissions,Forms = @Forms,Jop = @Jop,Dept = @Dept,D1 = @D1,D2 = @D2,F1 = @F1,F2 = @F2,H = @H Where UserID = @UserID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Username", SqlDbType.VarChar).Value = Username
            .Parameters.AddWithValue("@Password", SqlDbType.VarChar).Value = Password
            .Parameters.AddWithValue("@Permissions", SqlDbType.VarChar).Value = Permissions
            .Parameters.AddWithValue("@Forms", SqlDbType.VarChar).Value = Forms
            .Parameters.AddWithValue("@Jop", SqlDbType.VarChar).Value = Jop
            .Parameters.AddWithValue("@Dept", SqlDbType.VarChar).Value = Dept
            .Parameters.AddWithValue("@D1", SqlDbType.Decimal).Value = D1
            .Parameters.AddWithValue("@D2", SqlDbType.Decimal).Value = D2
            .Parameters.AddWithValue("@F1", SqlDbType.Decimal).Value = F1
            .Parameters.AddWithValue("@F2", SqlDbType.Decimal).Value = F2
            .Parameters.AddWithValue("@H", SqlDbType.Decimal).Value = H
            .Parameters.AddWithValue("@UserID", SqlDbType.Int).Value = UserIDW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
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

    '''Public Sub fillcmb_Tbl_Jop(ByVal cmb As ComboBox)
    '''    Dim DT As New DataTable
    '''    Dim DA As New SqlDataAdapter
    '''    DT.Clear()
    '''    'DA = New SqlDataAdapter("Select * FROM Tbl_Jop  where Dept_Code = " & Dept.SelectedValue, Con)
    '''    'DA = New SqlDataAdapter("Select * FROM Tbl_Jop where Dept_Code = " & Dept.SelectedValue.ToString(), Con)
    '''    If Dept.SelectedItem IsNot Nothing Then
    '''        Dim selectedDataRowView As DataRowView = DirectCast(Dept.SelectedItem, DataRowView)
    '''        Dim deptCode As String = selectedDataRowView("Dept_Code").ToString()

    '''        ' الآن يمكنك استخدام deptCode في استعلام SQL
    '''        DA = New SqlDataAdapter("SELECT * FROM Tbl_Jop WHERE Dept_Code = " & deptCode, Con)
    '''        ' ... الأكواد الإضافية هنا ...
    '''    Else
    '''        ' رسالة خطأ أو إجراء آخر في حالة عدم اختيار عنصر
    '''    End If
    '''    DA.Fill(DT)
    '''    If DT.Rows.Count > 0 Then
    '''        cmb.DataSource = DT
    '''        cmb.ValueMember = "Jop_Code"
    '''        cmb.DisplayMember = "Jop_Name"
    '''        'cmb.DisplayMember = "Dept_Code"
    '''    Else
    '''        cmb.DataSource = Nothing
    '''    End If
    '''End Sub
    Public Sub fillcmb_Tbl_Jop(ByVal cmb As ComboBox)
        Dim DT As New DataTable
        Dim DA As New SqlDataAdapter()

        ' تحديد الاستعلام SQL
        If Dept.SelectedItem IsNot Nothing Then
            Dim selectedDataRowView As DataRowView = DirectCast(Dept.SelectedItem, DataRowView)
            Dim deptCode As String = selectedDataRowView("Dept_Code").ToString()

            ' الآن يمكنك استخدام deptCode في استعلام SQL
            Dim query As String = "SELECT * FROM Tbl_Jop WHERE Dept_Code = " & deptCode
            DA.SelectCommand = New SqlCommand(query, Con)
            DA.Fill(DT)
            If DT.Rows.Count > 0 Then
                cmb.DataSource = DT
                cmb.ValueMember = "Jop_Code"
                cmb.DisplayMember = "Jop_Name"
            End If
        Else
            cmb.DataSource = Nothing ' رسالة خطأ أو إجراء آخر في حالة عدم اختيار عنصر
        End If

    End Sub
    Public Sub SelectAll_Users(dgv As DataGridView)
        Dim da As New SqlDataAdapter
        dt_Users.Clear()
        'da = New SqlDataAdapter("select UserID,Username,Permissions,Forms,Jop,Dept from Users", Con)
        da = New SqlDataAdapter("select * from Users", Con)
        da.Fill(dt_Users)
        dgv.DataSource = dt_Users
        With dgv
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            .Columns("UserID").HeaderText = "كود المستخدم"
            '.Columns("UserID").Width = 100
            .Columns("Username").HeaderText = "اسم المستخدم"
            .Columns("Username").AutoSizeMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
            '.Columns("Username").Width = 150
            .Columns("Password").HeaderText = "الرقم السرى"
            '.Columns("Password").Width = 0
            .Columns("Password").Visible = False
            .Columns("Permissions").HeaderText = "الصلاحيات"
            .Columns("Permissions").Visible = False
            '.Columns("Permissions").Width = 150
            .Columns("Forms").HeaderText = "النموذج المتاح"
            .Columns("Forms").Visible = False
            '.Columns("Forms").Width = 150
            .Columns("Jop").HeaderText = "الوظيفة"
            '.Columns("Jop").Width = 150
            .Columns("Dept").HeaderText = "القسم"
            '.Columns("Dept").Width = 150
            Dim checkBoxColumnD1 As New DataGridViewCheckBoxColumn()
            checkBoxColumnD1.HeaderText = "D1"
            checkBoxColumnD1.Name = "D1"
            Dim checkBoxColumnD2 As New DataGridViewCheckBoxColumn()
            checkBoxColumnD2.HeaderText = "D2"
            checkBoxColumnD2.Name = "D2"
            Dim checkBoxColumnF1 As New DataGridViewCheckBoxColumn()
            checkBoxColumnF1.HeaderText = "F1"
            checkBoxColumnF1.Name = "F1"
            Dim checkBoxColumnF2 As New DataGridViewCheckBoxColumn()
            checkBoxColumnF2.HeaderText = "F2"
            checkBoxColumnF2.Name = "F2"
            Dim checkBoxColumnH As New DataGridViewCheckBoxColumn()
            checkBoxColumnH.HeaderText = "H"
            checkBoxColumnH.Name = "H"

        End With
    End Sub
    Public Sub Delete_Users(ByVal dgv_Users As DataGridView)
        Dim Position As Integer = dgv_Users.CurrentRow.Index
        Dim ID_Position As Integer = dgv_Users.Rows(Position).Cells("UserID").Value
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Delete  From Users Where UserID = @UserID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@UserID", SqlDbType.Int).Value = ID_Position
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم حذف السجل.", MsgBoxStyle.Information, "حذف")
        Cmd = Nothing
    End Sub
    Private Sub Frm_Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearControls()
        Me.UserID.Focus()
        fillcmb_Tbl_Department(Dept)
        SelectAll_Users(dgv_Users)
        fillcmb_Tbl_Jop(Jop)
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Insert_Users(UserID.Text, Username.Text, Password.Text, Permissions.Text, Forms.Text, Jop.Text, Dept.Text, Chk_D1.Checked, Chk_D2.Checked, Chk_F1.Checked, Chk_F2.Checked, Chk_H.Checked)
        ClearControls()
        Me.UserID.Focus()
        SelectAll_Users(dgv_Users)
    End Sub
    Private Sub BtnNewAdd_Click(sender As Object, e As EventArgs) Handles BtnNewAdd.Click
        ClearControls()
        Me.UserID.Focus()
        SelectAll_Users(dgv_Users)
    End Sub
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Update_Users(Username.Text, Password.Text, Permissions.Text, Forms.Text, Jop.Text, Dept.Text, Chk_D1.Checked, Chk_D2.Checked, Chk_F1.Checked, Chk_F2.Checked, Chk_H.Checked, UserID.Text)

        ClearControls()
        Me.UserID.Focus()
        SelectAll_Users(dgv_Users)
    End Sub
    Private Sub Txt_Search_TextChanged(sender As Object, e As EventArgs) Handles Txt_Search.TextChanged
        Try
            Dim dv As DataView = dt_Users.DefaultView
            Select Case True
                Case Radio_Name.Checked
                    dv.RowFilter = "Username LIKE '%" & Txt_Search.Text & "%'"
                Case Radio_ID.Checked
                    dv.RowFilter = If(Txt_Search.Text = "", "", "userid = '" & Txt_Search.Text & "'")
                Case Radio_Dept.Checked
                    dv.RowFilter = "Dept LIKE '%" & Txt_Search.Text & "%'"
                Case Radio_Forms.Checked
                    dv.RowFilter = "Forms LIKE '%" & Txt_Search.Text & "%'"
            End Select
        Catch ex As Exception
            ' يمكنك إضافة معالجة للخطأ هنا إذا لزم الأمر
        End Try
    End Sub
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
            Exit Sub
        Else
            Delete_Users(dgv_Users)
        End If
        ClearControls()
        Me.UserID.Focus()
        SelectAll_Users(dgv_Users)
    End Sub
    Private Sub dgv_Users_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Users.CellContentClick
        ClearControls()
        Try
            With dgv_Users
                Me.UserID.Text = .CurrentRow.Cells("UserID").Value.ToString()
                Me.Username.Text = .CurrentRow.Cells("Username").Value.ToString()
                Me.Password.Text = .CurrentRow.Cells("password").Value.ToString()
                Me.Permissions.Text = .CurrentRow.Cells("Permissions").Value.ToString()
                Me.Dept.Text = .CurrentRow.Cells("Dept").Value.ToString()
                Me.Jop.Text = .CurrentRow.Cells("Jop").Value.ToString()
                Me.Chk_D1.Checked = .CurrentRow.Cells("D1").Value.ToString()
                Me.Chk_D2.Checked = .CurrentRow.Cells("D2").Value.ToString()
                Me.Chk_F1.Checked = .CurrentRow.Cells("F1").Value.ToString()
                Me.Chk_F2.Checked = .CurrentRow.Cells("F2").Value.ToString()
                Me.Chk_H.Checked = .CurrentRow.Cells("H").Value.ToString()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Dept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Dept.SelectedIndexChanged
        fillcmb_Tbl_Jop(Jop)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub
End Class