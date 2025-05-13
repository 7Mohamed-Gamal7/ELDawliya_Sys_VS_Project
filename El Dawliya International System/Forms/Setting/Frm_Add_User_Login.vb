Imports System.Data.SqlClient
Public Class Frm_Add_User_Login
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Public dt_Users_Login As New DataTable
    Public Sub ClearControls()
        'UserID.Text = Max_Users_Login() + 1
        Me.UserName.Text = vbNullString
        Me.UserPassword.Text = vbNullString
        Me.UserID.Focus()
    End Sub
    'Public Function Max_Users_Login()
    '    Dim Number As Integer
    '    Try
    '        Dim cmd As New SqlCommand("Select Max(UserID) From Users_Login ", Con)
    '        If Con.State = 1 Then Con.Close()
    '        Con.Open()
    '        Number = cmd.ExecuteScalar
    '        Con.Close()
    '    Catch ex As Exception
    '        Number = 0
    '        Con.Close()
    '    End Try
    '    Return Number
    'End Function

    Public Sub SelectAll_Users_Login(dgv As DataGridView)
        Dim da As New SqlDataAdapter
        dt_Users_Login.Clear()
        da = New SqlDataAdapter("select * from Users_Login", Con)
        da.Fill(dt_Users_Login)
        dgv.DataSource = dt_Users_Login
        With dgv
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            .Columns("UserID").HeaderText = "كود المستخدم"
            .Columns("UserID").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns("UserName").HeaderText = "اسم المستخدم"
            .Columns("UserName").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns("UserPassword").HeaderText = "الباسورد"
            .Columns("UserPassword").Visible = False
        End With
    End Sub

    Public Sub Insert_Users_Login(ByVal UserID AS Int32, ByVal UserName AS String, ByVal UserPassword AS String)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Users_Login ( UserID,UserName,UserPassword)values(@UserID,@UserName,@UserPassword)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@UserID", SqlDbType.Int).Value = UserID
            .Parameters.AddWithValue("@UserName", SqlDbType.VarChar).Value = UserName
            .Parameters.AddWithValue("@UserPassword", SqlDbType.VarChar).Value = UserPassword
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub
    Public Sub Update_Users_Login(ByVal UserName As String, ByVal UserPassword As String, ByVal UserIDW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Users_Login Set UserName = @UserName,UserPassword = @UserPassword Where UserID = @UserID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@UserName", SqlDbType.VarChar).Value = UserName
            .Parameters.AddWithValue("@UserPassword", SqlDbType.VarChar).Value = UserPassword
            .Parameters.AddWithValue("@UserID", SqlDbType.Int).Value = UserIDW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub
    Public Sub Delete_Users_Login(ByVal dgv_Users_Login As DataGridView)
        Dim Position As Integer = dgv_Users_Login.CurrentRow.Index
        Dim ID_Position As Integer = dgv_Users_Login.Rows(Position).Cells("UserID").Value
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Delete  From Users_Login Where UserID = @UserID"
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


    Private Sub Frm_Add_User_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearControls()
        SelectAll_Users_Login(dgv_Users_Login)
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Insert_Users_Login(UserID.Text, UserName.Text, UserPassword.Text)
        ClearControls()
        SelectAll_Users_Login(dgv_Users_Login)
    End Sub
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Update_Users_Login(UserName.Text, UserPassword.Text, UserID.Text)
        ClearControls()
        SelectAll_Users_Login(dgv_Users_Login)
    End Sub
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
            Exit Sub
        Else
            Delete_Users_Login(dgv_Users_Login)
        End If
        ClearControls()
        SelectAll_Users_Login(dgv_Users_Login)
    End Sub
    Private Sub BtnNewAdd_Click(sender As Object, e As EventArgs) Handles BtnNewAdd.Click
        ClearControls()
        SelectAll_Users_Login(dgv_Users_Login)
    End Sub
    Private Sub dgv_Users_Login_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Users_Login.CellContentClick
        Try
            With dgv_Users_Login
                Me.UserID.Text = .CurrentRow.Cells("UserID").Value.ToString()
                Me.UserName.Text = .CurrentRow.Cells("UserName").Value.ToString()
                Me.UserPassword.Text = .CurrentRow.Cells("UserPassword").Value.ToString()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class