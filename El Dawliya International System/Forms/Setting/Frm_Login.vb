'Imports UserRoles
Imports System.Data.SqlClient
Imports System.Reflection
Public Class Frm_Login
    Public ConStr As String = GetConnectionString()
    'Public ConStr As String = "Server=" + My.Settings.server + ";Database=" + My.Settings.database + ";Integrated Security=True;"
    Public Con As New SqlConnection(ConStr)
    Dim IsActive As Boolean
    Public Function Max_UserLoginLogoutHistory()
        Dim Number As Integer
        Try
            Dim cmd As New SqlCommand("Select Max(ID) From UserLoginLogoutHistory", Con)
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
    Public Sub Insert_UserLoginLogoutHistory(ByVal ID As Int32, ByVal UserName As String, ByVal LoginTime As DateTime, ByVal DeviceName As String)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into UserLoginLogoutHistory (ID,UserName,LoginTime,DeviceName)values(@ID,@UserName,@LoginTime,@DeviceName)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@ID", SqlDbType.Int).Value = ID
            .Parameters.AddWithValue("@UserName", SqlDbType.VarChar).Value = UserName
            .Parameters.AddWithValue("@LoginTime", SqlDbType.Date).Value = LoginTime
            .Parameters.AddWithValue("@DeviceName", SqlDbType.VarChar).Value = DeviceName
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        'MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim Entry_Number As Integer = Max_UserLoginLogoutHistory() + 1
        Dim User_Name As String = Txt_Username.Text
        Dim User_Password As String = Txt_Password.Text
        My.Settings.User_Name = User_Name
        My.Settings.User_Passowrd = User_Password
        My.Settings.Entry_Number = Entry_Number
        My.Settings.Save()
        IsActive = False
        ' التحقق من صحة اسم المستخدم وكلمة المرور واسترجاع UserID
        Dim currentUserID As Integer = ValidateCredentials(User_Name, User_Password)
        If currentUserID > 0 Then
            ' إذا كانت البيانات صحيحة، قم بفتح الفورم Home
            Dim homeForm As New Frm_Home(User_Name, currentUserID)
            homeForm.Show()
            IsActive = True
            ' الحصول على اسم الجهاز / اسم الكمبيوتر
            Dim DeviceName As String = Environ$("computername")
            Insert_UserLoginLogoutHistory(Entry_Number, User_Name, DateTime.Now, DeviceName)
            Update_Users_Login(IsActive, currentUserID)
            ' قم بإخفاء نموذج تسجيل الدخول
            Txt_Password.Text = vbNullString
            Me.Hide()
        Else
            ' إذا كانت البيانات غير صحيحة، قم بعرض رسالة خطأ
            MessageBox.Show("اسم المستخدم أو كلمة المرور غير صحيحة!", "خطأ في تسجيل الدخول", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Function ValidateCredentials(UserName As String, UserPassowrd As String) As Integer
        Try
            Dim query As String = "SELECT UserID FROM Users_Login WHERE UserName = @UserName AND UserPassword = @UserPassword"
            Using con As New SqlConnection(GetConnectionString())
                Using command As New SqlCommand(query, con)
                    'UserName = Txt_Username.Text
                    'UserPassowrd = Txt_Password.Text
                    UserName = My.Settings.User_Name
                    UserPassowrd = My.Settings.User_Passowrd
                    ' استخدام باراميتر لتجنب هجمات SQL Injection
                    command.Parameters.AddWithValue("@UserName", UserName)
                    command.Parameters.AddWithValue("@UserPassword", UserPassowrd)
                    If con.State = 1 Then
                        con.Close()
                    End If
                    con.Open()
                    Dim userID As Object = command.ExecuteScalar()
                    If userID IsNot Nothing Then
                        Return Convert.ToInt32(userID)
                    Else
                        Return 0
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function
    Private Function AuthenticateUser(username As String, Password As String) As Integer
        ' قم بتنفيذ التحقق من المستخدم في قاعدة البيانات
        Dim currentUserID As Integer = 1
        ' استعلم قاعدة البيانات للحصول على معرف المستخدم بناءً على اسم المستخدم وكلمة المرور
        Dim query As String = "SELECT UserID FROM Users WHERE UserName = @UserName AND Password = @Password"
        Using connection As New SqlConnection(GetConnectionString())
            connection.Open()
            Using cmd As New SqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@UserName", username)
                cmd.Parameters.AddWithValue("@Password", Password)
                Dim result As Object = cmd.ExecuteScalar()
                If result IsNot Nothing Then
                    currentUserID = Convert.ToInt32(result)
                End If
            End Using
        End Using
        Return currentUserID
    End Function
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        'End
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Frm_Connection.ShowDialog()
    End Sub

    Private Sub Txt_Password_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Password.KeyDown
        If e.KeyCode = Keys.Enter Then

            Dim Entry_Number As Integer = Max_UserLoginLogoutHistory() + 1
            Dim User_Name As String = Txt_Username.Text
            Dim User_Password As String = Txt_Password.Text
            My.Settings.User_Name = User_Name
            My.Settings.User_Passowrd = User_Password
            My.Settings.Entry_Number = Entry_Number
            My.Settings.Save()
            ' التحقق من صحة اسم المستخدم وكلمة المرور واسترجاع UserID
            Dim currentUserID As Integer = ValidateCredentials(User_Name, User_Password)
            If currentUserID > 0 Then
                IsActive = True
                ' إذا كانت البيانات صحيحة، قم بفتح الفورم Home
                Dim homeForm As New Frm_Home(User_Name, currentUserID)
                homeForm.Show()
                ' الحصول على اسم الجهاز / اسم الكمبيوتر
                Dim DeviceName As String = Environ$("computername")
                Insert_UserLoginLogoutHistory(Entry_Number, User_Name, DateTime.Now, DeviceName)
                Update_Users_Login(IsActive, currentUserID)
                ' قم بإخفاء نموذج تسجيل الدخول
                Txt_Password.Text = vbNullString
                Me.Hide()
            Else
                ' إذا كانت البيانات غير صحيحة، قم بعرض رسالة خطأ
                MessageBox.Show("اسم المستخدم أو كلمة المرور غير صحيحة!", "خطأ في تسجيل الدخول", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        End If
    End Sub

    Private Sub Frm_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Settings.server = Nothing Then
            Frm_Connection.ShowDialog()
        Else
            Me.Show()
        End If
        Me.Txt_Password.PasswordChar = "*"
        Me.Txt_Username.Focus()


        Dim currentAssembly As Assembly = Assembly.GetExecutingAssembly()
        Dim types As Type() = currentAssembly.GetTypes()

        ' عرض أسماء النماذج في نافذة الـ Console
        Console.WriteLine("أسماء النماذج في المشروع:")
        For Each t As Type In types
            ' التحقق من أن النوع يرث من System.Windows.Forms.Form
            If t.IsSubclassOf(GetType(System.Windows.Forms.Form)) Then
                Console.WriteLine(t.Name)
            End If
        Next

    End Sub

    Private Sub TextBoxEnglish_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles Txt_Username.Enter, Txt_Password.Enter
        English(DirectCast(sender, TextBox))
    End Sub

    Private Sub Frm_Login_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        'RestoreScreenResolution(Me)
    End Sub


    Public Sub Update_Users_Login(ByVal IsActive As Boolean, ByVal UserIDW As Int32)
        Try
            Dim Cmd As New SqlCommand
            With Cmd
                .Connection = Con
                .CommandType = CommandType.Text
                .CommandText = "Update Users_Login Set IsActive = @IsActive Where UserID = @UserID"
                .Parameters.Clear()
                .Parameters.AddWithValue("@IsActive", SqlDbType.Bit).Value = IsActive
                .Parameters.AddWithValue("@UserID", SqlDbType.Int).Value = UserIDW
            End With
            If Con.State = ConnectionState.Open Then Con.Close()
            Con.Open()
            Cmd.ExecuteNonQuery()
            Con.Close()
            'MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Catch ex As Exception
            MsgBox("خطأ أثناء تحديث البيانات: " & ex.Message, MsgBoxStyle.Critical, "خطأ")
        End Try
    End Sub




    ''''Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
    ''''    Dim Entry_Number As Integer
    ''''    Entry_Number = Max_UserLoginLogoutHistory() + 1
    ''''    ' استرجاع قيم اسم المستخدم وكلمة المرور من TextBoxes
    ''''    Dim User_Name As String = Txt_Username.Text
    ''''    Dim User_Passowrd As String = Txt_Password.Text
    ''''    My.Settings.User_Name = User_Name
    ''''    My.Settings.User_Passowrd = User_Passowrd
    ''''    My.Settings.Entry_Number = Entry_Number
    ''''    My.Settings.Save()
    ''''    ' التحقق من صحة اسم المستخدم وكلمة المرور واسترجاع UserID
    ''''    Dim currentUserID As Integer = ValidateCredentials(User_Name, User_Passowrd)
    ''''    If currentUserID > 0 Then
    ''''        ' إذا كانت البيانات صحيحة، قم بفتح الفورم Home
    ''''        Dim homeForm As New Frm_Home(User_Name, currentUserID)
    ''''        homeForm.Show()
    ''''        Dim DeviceName As String
    ''''        ' الحصول على اسم الجهاز / اسم الكمبيوتر
    ''''        DeviceName = Environ$("computername")
    ''''        Insert_UserLoginLogoutHistory(Int(Entry_Number), Txt_Username.Text, DateTime.Now, DeviceName)
    ''''        ' قم بإخفاء نموذج تسجيل الدخول
    ''''        'Txt_Username.Text = vbNullString
    ''''        Txt_Password.Text = vbNullString
    ''''        Me.Hide()
    ''''    Else
    ''''        ' إذا كانت البيانات غير صحيحة، قم بعرض رسالة خطأ
    ''''        MessageBox.Show("اسم المستخدم أو كلمة المرور غير صحيحة!", "خطأ في تسجيل الدخول", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    ''''    End If
    ''''End Sub
End Class



