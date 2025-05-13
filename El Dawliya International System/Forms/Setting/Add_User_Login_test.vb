Imports System.Data.SqlClient
Public Class Add_User_Login_test
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Public dt_Users_Login As New DataTable


    Public Sub ClearControls()
        Me.UserID.Text = vbNullString
        Me.UserName.Text = vbNullString
        Me.UserPassword.Text = vbNullString
        Me.User_Group.Text = vbNullString
        UserID.Text = Max_Users_Login() + 1
        UserName.Focus()
        UserPassword.PasswordChar = "*"
    End Sub

    Public Function Max_Users_Login()
        Dim Number As Integer
        Try
            Dim cmd As New SqlCommand("Select Max(UserID) From Users_Login ", Con)
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

    Private Function GetColumnHeaderName(columnName As String) As String
        Select Case columnName
            Case "UserID" : Return "كود المستخدم"
            Case "UserName" : Return "اسم المستخدم"
            Case "UserPassword" : Return "الرقم السرى"
            Case "User_Group" : Return "المجموعة"
            Case "VIEW_MENU" : Return "؟؟"
            Case "Allowed_Add" : Return "الاضافة"
            Case "Allows_Reading" : Return "القراءة"
            Case "Allows_Edit" : Return "التعديل"
            Case "Allows_Delete" : Return "الحذف"
            Case "Allows_Prod" : Return "الانتاج"
            Case "Allows_Quly" : Return "الجودة"
            Case "Allows_Spar" : Return "قطع الغيار"
            Case "Allows_Maintenance" : Return "الصيانة"
            Case "Allows_WH" : Return "المخازن"
            Case "Allows_Raw_Materials" : Return "المواد الاولية"
            Case "Allows_HR" : Return "الموارد البشرية"
            Case "Allows_Settings" : Return "الاعدادات"
            Case "Allows_Electricity" : Return "الكهرباء"
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

    Public Sub SelectAll_Users_Login(dgv As DataGridView)
        Dim da As New SqlDataAdapter
        dt_Users_Login.Clear()
        da = New SqlDataAdapter("select * from Users_Login", Con)
        da.Fill(dt_Users_Login)
        dgv.DataSource = dt_Users_Login
        Try
            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If
            ' لاخفاء الاعمدة
            HideColumns(dgv, "UserID", "UserPassword", "VIEW_MENU",
            "Place_Birth", "Emp_Image", "Emp_Type")
            For Each column As DataGridViewColumn In dgv.Columns
                column.HeaderText = GetColumnHeaderName(column.Name)
            Next

        Catch ex As Exception
            MessageBox.Show("خطأ: " & ex.Message)
        End Try



    End Sub


    Public Sub Insert_Users_Login(ByVal UserID As Int32, ByVal UserName As String, ByVal UserPassword As String, ByVal User_Group As String, ByVal Allowed_Add As Boolean, ByVal Allows_Reading As Boolean, ByVal Allows_Edit As Boolean, ByVal Allows_Delete As Boolean, ByVal Allows_Prod As Boolean, ByVal Allows_Quly As Boolean, ByVal Allows_Spar As Boolean, ByVal Allows_Maintenance As Boolean, ByVal Allows_WH As Boolean, ByVal Allows_Raw_Materials As Boolean, ByVal Allows_HR As Boolean, ByVal Allows_Settings As Boolean, ByVal Allows_Electricity As Boolean)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Users_Login ( UserID,UserName,UserPassword,User_Group,Allowed_Add,Allows_Reading,Allows_Edit,Allows_Delete,Allows_Prod,Allows_Quly,Allows_Spar,Allows_Maintenance,Allows_WH,Allows_Raw_Materials,Allows_HR,Allows_Settings,Allows_Electricity)values(@UserID,@UserName,@UserPassword,@User_Group,@Allowed_Add,@Allows_Reading,@Allows_Edit,@Allows_Delete,@Allows_Prod,@Allows_Quly,@Allows_Spar,@Allows_Maintenance,@Allows_WH,@Allows_Raw_Materials,@Allows_HR,@Allows_Settings,@Allows_Electricity)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@UserID", SqlDbType.Int).Value = UserID
            .Parameters.AddWithValue("@UserName", SqlDbType.VarChar).Value = UserName
            .Parameters.AddWithValue("@UserPassword", SqlDbType.VarChar).Value = UserPassword
            .Parameters.AddWithValue("@User_Group", SqlDbType.VarChar).Value = User_Group
            .Parameters.AddWithValue("@Allowed_Add", SqlDbType.Decimal).Value = Allowed_Add
            .Parameters.AddWithValue("@Allows_Reading", SqlDbType.Decimal).Value = Allows_Reading
            .Parameters.AddWithValue("@Allows_Edit", SqlDbType.Decimal).Value = Allows_Edit
            .Parameters.AddWithValue("@Allows_Delete", SqlDbType.Decimal).Value = Allows_Delete
            .Parameters.AddWithValue("@Allows_Prod", SqlDbType.Decimal).Value = Allows_Prod
            .Parameters.AddWithValue("@Allows_Quly", SqlDbType.Decimal).Value = Allows_Quly
            .Parameters.AddWithValue("@Allows_Spar", SqlDbType.Decimal).Value = Allows_Spar
            .Parameters.AddWithValue("@Allows_Maintenance", SqlDbType.Decimal).Value = Allows_Maintenance
            .Parameters.AddWithValue("@Allows_WH", SqlDbType.Decimal).Value = Allows_WH
            .Parameters.AddWithValue("@Allows_Raw_Materials", SqlDbType.Decimal).Value = Allows_Raw_Materials
            .Parameters.AddWithValue("@Allows_HR", SqlDbType.Decimal).Value = Allows_HR
            .Parameters.AddWithValue("@Allows_Settings", SqlDbType.Decimal).Value = Allows_Settings
            .Parameters.AddWithValue("@Allows_Electricity", SqlDbType.Decimal).Value = Allows_Electricity
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub

    Public Sub Update_Users_Login(ByVal UserName As String, ByVal UserPassword As String, ByVal User_Group As String, ByVal Allowed_Add As Boolean, ByVal Allows_Reading As Boolean, ByVal Allows_Edit As Boolean, ByVal Allows_Delete As Boolean, ByVal Allows_Prod As Boolean, ByVal Allows_Quly As Boolean, ByVal Allows_Spar As Boolean, ByVal Allows_Maintenance As Boolean, ByVal Allows_WH As Boolean, ByVal Allows_Raw_Materials As Boolean, ByVal Allows_HR As Boolean, ByVal Allows_Settings As Boolean, ByVal Allows_Electricity As Boolean, ByVal UserIDW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Users_Login Set UserName = @UserName,UserPassword = @UserPassword,User_Group = @User_Group,Allowed_Add = @Allowed_Add,Allows_Reading = @Allows_Reading,Allows_Edit = @Allows_Edit,Allows_Delete = @Allows_Delete,Allows_Prod = @Allows_Prod,Allows_Quly = @Allows_Quly,Allows_Spar = @Allows_Spar,Allows_Maintenance = @Allows_Maintenance,Allows_WH = @Allows_WH,Allows_Raw_Materials = @Allows_Raw_Materials,Allows_HR = @Allows_HR,Allows_Settings = @Allows_Settings,Allows_Electricity = @Allows_Electricity Where UserID = @UserID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@UserName", SqlDbType.VarChar).Value = UserName
            .Parameters.AddWithValue("@UserPassword", SqlDbType.VarChar).Value = UserPassword
            .Parameters.AddWithValue("@User_Group", SqlDbType.VarChar).Value = User_Group
            .Parameters.AddWithValue("@Allowed_Add", SqlDbType.Decimal).Value = Allowed_Add
            .Parameters.AddWithValue("@Allows_Reading", SqlDbType.Decimal).Value = Allows_Reading
            .Parameters.AddWithValue("@Allows_Edit", SqlDbType.Decimal).Value = Allows_Edit
            .Parameters.AddWithValue("@Allows_Delete", SqlDbType.Decimal).Value = Allows_Delete
            .Parameters.AddWithValue("@Allows_Prod", SqlDbType.Decimal).Value = Allows_Prod
            .Parameters.AddWithValue("@Allows_Quly", SqlDbType.Decimal).Value = Allows_Quly
            .Parameters.AddWithValue("@Allows_Spar", SqlDbType.Decimal).Value = Allows_Spar
            .Parameters.AddWithValue("@Allows_Maintenance", SqlDbType.Decimal).Value = Allows_Maintenance
            .Parameters.AddWithValue("@Allows_WH", SqlDbType.Decimal).Value = Allows_WH
            .Parameters.AddWithValue("@Allows_Raw_Materials", SqlDbType.Decimal).Value = Allows_Raw_Materials
            .Parameters.AddWithValue("@Allows_HR", SqlDbType.Decimal).Value = Allows_HR
            .Parameters.AddWithValue("@Allows_Settings", SqlDbType.Decimal).Value = Allows_Settings
            .Parameters.AddWithValue("@Allows_Electricity", SqlDbType.Decimal).Value = Allows_Electricity
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

    Private Sub dgv_Users_Login_Click(sender As Object, e As EventArgs) Handles dgv_Users_Login.Click
        Try
            With dgv_Users_Login
                Me.UserID.Text = .CurrentRow.Cells("UserID").Value.ToString()
                Me.UserName.Text = .CurrentRow.Cells("UserName").Value.ToString()
                Me.UserPassword.Text = .CurrentRow.Cells("UserPassword").Value.ToString()
                Me.User_Group.Text = .CurrentRow.Cells("User_Group").Value.ToString()

                Me.Allowed_Add.Checked = .CurrentRow.Cells("Allowed_Add").Value.ToString()
                Me.Allows_Reading.Checked = .CurrentRow.Cells("Allows_Reading").Value.ToString()
                Me.Allows_Edit.Checked = .CurrentRow.Cells("Allows_Edit").Value.ToString()
                Me.Allows_Delete.Checked = .CurrentRow.Cells("Allows_Delete").Value.ToString()
                Me.Allows_Prod.Checked = .CurrentRow.Cells("Allows_Prod").Value.ToString()
                Me.Allows_Quly.Checked = .CurrentRow.Cells("Allows_Quly").Value.ToString()
                Me.Allows_Spar.Checked = .CurrentRow.Cells("Allows_Spar").Value.ToString()
                Me.Allows_Maintenance.Checked = .CurrentRow.Cells("Allows_Maintenance").Value.ToString()
                Me.Allows_WH.Checked = .CurrentRow.Cells("Allows_WH").Value.ToString()
                Me.Allows_Raw_Materials.Checked = .CurrentRow.Cells("Allows_Raw_Materials").Value.ToString()
                Me.Allows_HR.Checked = .CurrentRow.Cells("Allows_HR").Value.ToString()
                Me.Allows_Settings.Checked = .CurrentRow.Cells("Allows_Settings").Value.ToString()
                Me.Allows_Electricity.Checked = .CurrentRow.Cells("Allows_Electricity").Value.ToString()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        BtnDelete.Enabled = True
        BtnEdit.Enabled = True
    End Sub

    Private Sub Add_User_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearControls()
        SelectAll_Users_Login(dgv_Users_Login)

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If UserName.Text = vbNullString Or UserPassword.Text = vbNullString Then
            MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Exit Sub
        End If
        Insert_Users_Login(UserID.Text, UserName.Text, UserPassword.Text, User_Group.Text, Allowed_Add.Checked, Allows_Reading.Checked, Allows_Edit.Checked, Allows_Delete.Checked, Allows_Prod.Checked, Allows_Quly.Checked, Allows_Spar.Checked, Allows_Maintenance.Checked, Allows_WH.Checked, Allows_Raw_Materials.Checked, Allows_HR.Checked, Allows_Settings.Checked, Allows_Electricity.Checked)
        ClearControls()
        SelectAll_Users_Login(dgv_Users_Login)
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Update_Users_Login(UserName.Text, UserPassword.Text, User_Group.Text, Allowed_Add.Checked, Allows_Reading.Checked, Allows_Edit.Checked, Allows_Delete.Checked, Allows_Prod.Checked, Allows_Quly.Checked, Allows_Spar.Checked, Allows_Maintenance.Checked, Allows_WH.Checked, Allows_Raw_Materials.Checked, Allows_HR.Checked, Allows_Settings.Checked, Allows_Electricity.Checked, UserID.Text)
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
        BtnDelete.Enabled = False
        BtnEdit.Enabled = False
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If Me.CheckBox1.Checked = True Then
            UserPassword.PasswordChar = ""
        Else
            UserPassword.PasswordChar = "*"
        End If
    End Sub

End Class