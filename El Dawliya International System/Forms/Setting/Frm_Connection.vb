Imports System.Data.SqlClient
Imports Microsoft.SqlServer.Management.Common
Imports Microsoft.SqlServer.Management.Smo
Imports Microsoft.Win32
Public Class Frm_Connection
    Public serverconnection As ServerConnection = Nothing
    Public Property connectionstring() As String
    Public Property serverName() As String
    Public Property DatabaseName() As String
    Public dt As New DataTable
    Public cmd As New SqlCommand
    Public da As New SqlDataAdapter

    Public Sub loadserver(ByVal combo As ComboBox)
        combo.Items.Clear()
        Try
            Dim localmachine = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64)
            Dim rk = localmachine.OpenSubKey("SOFTWARE\microsoft\microsoft sql server")
            Dim instances = CType(rk.GetValue("installedinstances"), String())
            If instances.Length > 0 Then
                For Each element As String In instances

                    If element = "MSSQLSERVER" Then
                        combo.Items.Add(System.Environment.MachineName)
                    Else
                        combo.Items.Add(System.Environment.MachineName + "\" + element)
                    End If
                Next element
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Public Sub selectdata(comboserver As ComboBox, combodatabase As ComboBox)
        combodatabase.Items.Clear()
        Dim con As New SqlConnection("server=" & comboserver.Text & "; database = master ; integrated security=true")
        Dim da As New SqlDataAdapter("select name from sys.databases ", con)
        Dim dt As New DataTable
        da.Fill(dt)
        For i As Integer = 0 To dt.Rows.Count - 1
            combodatabase.Items.Add(dt.Rows(i)("name").ToString)
        Next
    End Sub
    Public Sub DatabaseDropDown(checkmode As CheckBox, comboserver As ComboBox, txtuser As TextBox, txtpass As TextBox, combodatabase As ComboBox)
        If checkmode.Checked Then
            serverconnection = New ServerConnection(comboserver.Text, txtuser.Text, txtpass.Text)
        Else
            serverconnection = New ServerConnection(comboserver.Text)
        End If
        Dim server As New Server(serverconnection)
        Dim databases As DatabaseCollection = server.Databases
        combodatabase.Items.Clear()
        For Each Database As Database In databases
            combodatabase.Items.Add(Database.Name)
        Next Database
    End Sub


    Public Sub Databaseseslectedindexchanged(checkmode As CheckBox, cmbserver As ComboBox, txtuser As TextBox, txtpass As TextBox)
        serverconnection.Disconnect()
        If checkmode.Checked Then
            serverconnection = New ServerConnection(cmbserver.Text, txtuser.Text, txtpass.Text)
        Else
            serverconnection = New ServerConnection(cmbserver.Text)
        End If
        serverconnection.DatabaseName = combodatabase.Text.ToString()
        connectionstring = serverconnection.ConnectionString
        serverName = serverconnection.ServerInstance
        DatabaseName = combodatabase.Text.ToString()
    End Sub
    'Private Sub TextBox_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles Emp_Full_Name.Enter, Emp_First_Name.Enter, Emp_Second_Name.Enter, Emp_Address.Enter
    '    Arabic(DirectCast(sender, TextBox))
    'End Sub
    Private Sub TextBoxEnglish_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txtuser.Enter, txtpass.Enter
        English(DirectCast(sender, TextBox))
    End Sub


    Private Sub Frm_Connection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadserver(comboserver)
        txtpass.PasswordChar = "*"
        'comboserver.Text = My.Settings.server
        'combodatabase.Text = My.Settings.database
        'checkmode.Checked = (My.Settings.model = "SQL")
        'txtuser.Text = My.Settings.id
        'txtpass.Text = My.Settings.Passowrd
    End Sub

    Private Sub checkmode_CheckedChanged(sender As Object, e As EventArgs) Handles checkmode.CheckedChanged
        txtuser.Enabled = checkmode.Checked
        txtpass.Enabled = checkmode.Checked
    End Sub

    Private Sub btnconnection_Click(sender As Object, e As EventArgs) Handles btnconnection.Click
        My.Settings.server = comboserver.Text
        My.Settings.database = combodatabase.Text
        My.Settings.model = If(checkmode.Checked = True, "SQL", "Windows")
        My.Settings.id = txtuser.Text
        My.Settings.Password = txtpass.Text
        My.Settings.Save()
        MessageBox.Show("تم الاتصال بقاعدة البيانات بنجاح")
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub combodatabase_DropDown(sender As Object, e As EventArgs) Handles combodatabase.DropDown
        DatabaseDropDown(checkmode, comboserver, txtuser, txtpass, combodatabase)
    End Sub
End Class