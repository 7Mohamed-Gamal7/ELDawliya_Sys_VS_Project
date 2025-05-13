Imports System.Data.SqlClient
'Imports System.Drawing.Color
'Imports System.Windows.Media.Color

Public Class Frm_Home
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Dim Filename As String
    Dim dir As String = Application.StartupPath & "\Skins\"
    'Private WithEvents MyNotifyIcon As New NotifyIcon()
    'Private WithEvents Timer As New Timer(5000) ' فاصل زمني 5 ثوانٍ
    'Dim MessageNotification As String


    Public Sub New(userName As String, userID As Integer)
        InitializeComponent()
        loggedInUserName = userName
        loggedInUserID = userID
    End Sub
    ' تعيين القيم في البناء

    Private Sub اضافةقسمجديدToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Frm_Add_Department.ShowDialog()
    End Sub
    'Private Sub ToolSetting_Add_User_Click(sender As Object, e As EventArgs)
    '    Dim Frm As New Frm_Users
    '    Frm.TopLevel = False
    '    MainPanel.Controls.Add(Frm)
    '    Frm.BringToFront()
    '    Frm.Show()
    'End Sub
    Private Sub ToolStopMachineD1_Click(sender As Object, e As EventArgs) Handles ToolStopMachineD1.Click
        Dim Frm As New Frm_Machine_Stop
        Frm.TopLevel = False
        MainPanel.Controls.Add(Frm)
        Frm.Lbl_Machine.Text = D1
        Frm.BringToFront()
        Frm.Show()
        If Txt_UserID.Text = "D1" Then
            ToolStopMachineD1.Enabled = False
        Else
            ToolStopMachineD1.Enabled = True
        End If
    End Sub
    Private Sub ToolStopMachineD2_Click(sender As Object, e As EventArgs) Handles ToolStopMachineD2.Click
        Dim Frm As New Frm_Machine_Stop
        Frm.TopLevel = False
        MainPanel.Controls.Add(Frm)
        Frm.Lbl_Machine.Text = D2
        Frm.BringToFront()
        Frm.Show()
        If Txt_UserID.Text = "D2" Then
            ToolStopMachineD2.Enabled = False
        Else
            ToolStopMachineD2.Enabled = True
        End If
    End Sub
    Private Sub ToolStopMachineF1_Click(sender As Object, e As EventArgs) Handles ToolStopMachineF1.Click
        Dim Frm As New Frm_Machine_Stop
        Frm.TopLevel = False
        MainPanel.Controls.Add(Frm)
        Frm.Lbl_Machine.Text = F1
        Frm.BringToFront()
        Frm.Show()
        If Txt_UserID.Text = "F1" Then
            Me.ToolStopMachineF1.Enabled = False
        Else
            Me.ToolStopMachineF1.Enabled = True
        End If
    End Sub
    Private Sub ToolStopMachineF2_Click(sender As Object, e As EventArgs) Handles ToolStopMachineF2.Click
        Dim Frm As New Frm_Machine_Stop
        Frm.TopLevel = False
        MainPanel.Controls.Add(Frm)
        Frm.Lbl_Machine.Text = F2
        Frm.BringToFront()
        Frm.Show()
        If Txt_UserID.Text = "F2" Then
            Me.ToolStopMachineF2.Enabled = False
        Else
            Me.ToolStopMachineF2.Enabled = True
        End If
    End Sub
    Private Sub ToolStopMachineH_Click(sender As Object, e As EventArgs) Handles ToolStopMachineH.Click
        Dim Frm As New Frm_Machine_Stop
        Frm.TopLevel = False
        MainPanel.Controls.Add(Frm)
        Frm.Lbl_Machine.Text = H
        Frm.BringToFront()
        Frm.Show()
        If Txt_UserID.Text = "H" Then
            Me.ToolStopMachineH.Enabled = False
        Else
            Me.ToolStopMachineH.Enabled = True
        End If

    End Sub
    Private Sub إستعلامToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToolStopMachine_Quariy.Click
        'Dim Frm As New Frm_Quiry
        'Frm.TopLevel = False
        'MainPanel.Controls.Add(Frm)
        'Frm.BringToFront()
        'Frm.Show()
        Frm_Quiry.Show()
    End Sub
    Private Sub ToolStopMachine_Add_Parts_Click(sender As Object, e As EventArgs) Handles ToolStopMachine_Add_Parts.Click
        'Dim Frm As New Frm_Add_Unit
        'Frm.TopLevel = False
        'MainPanel.Controls.Add(Frm)
        'Frm.BringToFront()
        'Frm.Show()
        Frm_Add_Unit.Show()
    End Sub
    '====================================================================================================================
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''تجربة جديدة
    '====================================================================================================================
    Public Sub UpdateControlState(Tool_ID As String, permissionLevel As Integer)
        ' قم بتحديث حالة العنصر (التفاعلية أو القابلة للرؤية) بناءً على مستوى الصلاحية
        ' يمكنك تعديل هذا الكود وفقًا لتصميم وعناصر الفورم الفعليين.
        Select Case Tool_ID
            Case "ToolProduction"
                ToolProduction.Visible = (permissionLevel >= 2)
            Case "ToolStopMachine"
                ToolStopMachine.Visible = (permissionLevel >= 2)
            Case "ToolStopMachineD1"
                ToolStopMachineD1.Visible = (permissionLevel >= 2)
            Case "ToolStopMachineD2"
                ToolStopMachineD2.Visible = (permissionLevel >= 2)
            Case "ToolStopMachineF1"
                ToolStopMachineF1.Visible = (permissionLevel >= 2)
            Case "ToolStopMachineF2"
                ToolStopMachineF2.Visible = (permissionLevel >= 2)
            Case "ToolStopMachineH"
                ToolStopMachineH.Visible = (permissionLevel >= 2)
            Case "ToolStopMachine_Add_Parts"
                ToolStopMachine_Add_Parts.Visible = (permissionLevel >= 2)
                '================================================================================
            Case "ToolStopMachine_Add_Proplem"
                ToolStopMachine_Add_Proplem.Visible = (permissionLevel >= 2)
            Case "ToolStopMachine_Quariy"
                ToolStopMachine_Quariy.Visible = (permissionLevel >= 2)
            Case "ToolMaintenance"
                ToolMaintenance.Visible = (permissionLevel >= 2) ' ViewOnly وما فوق مفعلة
            Case "ToolElectricity"
                ToolElectricity.Visible = (permissionLevel >= 2)
            Case "ToolRaw_Materials"
                ToolRaw_Materials.Visible = (permissionLevel >= 2)
            Case "ToolSpare_Parts"
                ToolSpare_Parts.Visible = (permissionLevel >= 2)
            Case "ToolGlue"
                ToolGlue.Visible = (permissionLevel >= 2)
            Case "ToolHR"
                ToolHR.Visible = (permissionLevel >= 2) ' فقط ViewAndInteract و FullControl مفعلة
            Case "ToolQaulty"
                ToolQaulty.Visible = (permissionLevel >= 2)
            Case "ToolSetting"
                ToolSetting.Visible = (permissionLevel >= 2)
            Case "ToolSetting_Add_Department"
                ToolSetting_Add_Department.Visible = (permissionLevel >= 2)
            Case "ToolSetting_Add_User"
                ToolSetting_Add_User.Visible = (permissionLevel >= 2)
            Case "ToolSetting_User_Permissions"
                ToolSetting_User_Permissions.Visible = (permissionLevel >= 2)
            Case "Tool_Production_Rates"
                Tool_Production_Rates.Visible = (permissionLevel >= 2)
            Case "Tool_Production_Card"
                Tool_Production_Card.Visible = (permissionLevel >= 2)
            Case "Tool_Kart_Production"
                Tool_Kart_Production.Visible = (permissionLevel >= 2)
            Case "Tool_Daily_Report"
                Tool_Daily_Report.Visible = (permissionLevel >= 2)
            Case "Tool_Performance_Index"
                Tool_Performance_Index.Visible = (permissionLevel >= 2)
            Case "Tool_Quiry_ForEmp"
                Tool_Quiry_ForEmp.Visible = (permissionLevel >= 2)
            Case "ToolMeeting"
                ToolMeeting.Visible = (permissionLevel >= 2)
            Case "ToolMassage"
                ToolMassage.Visible = (permissionLevel >= 2)

                'Case "Tool_Quiry_ForEmp"
                '    Tool_Quiry_ForEmp.Visible = (permissionLevel >= 2)


        End Select
    End Sub
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Txt_Company.Text = My.Settings.Company_Name
        Me.Txt_UserID.Text = loggedInUserName
        Me.Txt_User.Text = loggedInUserID
        Txt_User_Name.Text = loggedInUserName
        Txt_date.Text = Today
        If Txt_User.Text = "2" Or Txt_User.Text = "3" Or Txt_User.Text = "4" Or Txt_User.Text = "5" Or Txt_User.Text = "6" Then
            Me.FormBorderStyle = FormBorderStyle.None
            Me.MaximizeBox = False
            Me.MinimizeBox = False
        Else
            Me.FormBorderStyle = FormBorderStyle.Sizable
            Me.MaximizeBox = True
            Me.MinimizeBox = True
        End If
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
                            permissionData.Add(Tool_ID, permissionLevel)
                        End While
                    End Using
                End Using
            End Using
            ' قم بتحديث حالة العناصر بناءً على الصلاحيات
            UpdateControlState("ToolHR", permissionData("ToolHR"))
            UpdateControlState("ToolMaintenance", permissionData("ToolMaintenance"))
            UpdateControlState("ToolSetting", permissionData("ToolSetting"))
            UpdateControlState("ToolQaulty", permissionData("ToolQaulty"))
            '================================================================
            UpdateControlState("ToolProduction", permissionData("ToolProduction"))
            UpdateControlState("ToolStopMachine", permissionData("ToolStopMachine"))
            UpdateControlState("ToolStopMachineD1", permissionData("ToolStopMachineD1"))
            UpdateControlState("ToolStopMachineD2", permissionData("ToolStopMachineD2"))
            UpdateControlState("ToolStopMachineF1", permissionData("ToolStopMachineF1"))
            UpdateControlState("ToolStopMachineF2", permissionData("ToolStopMachineF2"))
            UpdateControlState("ToolStopMachineH", permissionData("ToolStopMachineH"))
            UpdateControlState("ToolStopMachine_Add_Parts", permissionData("ToolStopMachine_Add_Parts"))
            UpdateControlState("ToolStopMachine_Add_Proplem", permissionData("ToolStopMachine_Add_Proplem"))
            UpdateControlState("ToolStopMachine_Quariy", permissionData("ToolStopMachine_Quariy"))
            UpdateControlState("ToolElectricity", permissionData("ToolElectricity"))
            UpdateControlState("ToolRaw_Materials", permissionData("ToolRaw_Materials"))
            UpdateControlState("ToolSpare_Parts", permissionData("ToolSpare_Parts"))
            UpdateControlState("ToolGlue", permissionData("ToolGlue"))
            UpdateControlState("ToolSetting_Add_Department", permissionData("ToolSetting_Add_Department"))
            UpdateControlState("ToolSetting_Add_User", permissionData("ToolSetting_Add_User"))
            UpdateControlState("ToolSetting_User_Permissions", permissionData("ToolSetting_User_Permissions"))
            '================================================================
            UpdateControlState("Tool_Production_Rates", permissionData("Tool_Production_Rates"))
            UpdateControlState("Tool_Production_Card", permissionData("Tool_Production_Card"))
            UpdateControlState("Tool_Kart_Production", permissionData("Tool_Kart_Production"))
            UpdateControlState("Tool_Daily_Report", permissionData("Tool_Daily_Report"))
            UpdateControlState("Tool_Performance_Index", permissionData("Tool_Performance_Index"))
            UpdateControlState("Tool_Quiry_ForEmp", permissionData("Tool_Quiry_ForEmp"))
            UpdateControlState("ToolMeeting", permissionData("ToolMeeting"))
            UpdateControlState("ToolMassage", permissionData("ToolMassage"))
            'UpdateControlState("Tool_Quiry_ForEmp", permissionData("Tool_Quiry_ForEmp"))
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
        LoadUserTasks()

        '' إعداد NotifyIcon
        ''MyNotifyIcon.Icon = New Icon("E:\El Dawliya International System\El Dawliya International System\Resources\icons8_Notifications.ico") ' تأكد من أنك تستخدم أيقونة صالحة
        'MyNotifyIcon.Visible = True

        '' إعداد Timer لبدء التكرار
        'Timer.Interval = 5000 ' تحديد الفاصل الزمني لـ 5 ثوانٍ
        'Timer.Start()

        '' طباعة رسالة لتأكيد بدء Timer
        'Debug.WriteLine("Timer started.")
    End Sub
    Private Sub اضافةشاشةToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles اضافةشاشةToolStripMenuItem.Click
        Frm_Add_From.Show()
    End Sub
    Private Sub اضاقةاداةجديدةToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles اضاقةاداةجديدةToolStripMenuItem.Click
        Frm_Add_Tool.Show()
    End Sub
    Private Sub صلاحياتالمستخدمينToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles صلاحياتالمستخدمينToolStripMenuItem.Click
        Frm_UserPermissions.Show()
    End Sub
    Private Sub ToolStopMachine_Add_Proplem_Click(sender As Object, e As EventArgs) Handles ToolStopMachine_Add_Proplem.Click
        'Dim Frm2 As New Frm_Add_Proplem
        'Frm2.TopLevel = False
        'MainPanel.Controls.Add(Frm2)
        'Frm2.BringToFront()
        'Frm2.Show()
        Frm_Add_Proplem.Show()
    End Sub
    Private Sub اضافةموظفToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Frm_Add_Employee.Show()
    End Sub

    Private Sub Tool_Quiry_ForEmp_Click(sender As Object, e As EventArgs) Handles Tool_Quiry_ForEmp.Click
        Frm_Quiry_ForEmp.Show()
    End Sub
    Private Sub اضافةوظيفةجديدةToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Frm_Add_Jop.Show()
    End Sub
    Private Sub اعادةدخولToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles اعادةدخولToolStripMenuItem.Click
        Try
            ' تحقق من أن المستخدم مسجل دخوله ولديه UserID
            If My.Settings.User_Name IsNot Nothing AndAlso My.Settings.Entry_Number > 0 Then
                ' استدعاء الإجراء لتحديث الحقل IsActive
                Update_Users_Login(False, loggedInUserID)
            End If
        Catch ex As Exception
            MsgBox("خطأ أثناء تحديث حالة المستخدم عند الخروج: " & ex.Message, MsgBoxStyle.Critical, "خطأ")
        End Try
        Application.Exit()
        Me.Close()
        Frm_Login.Show()
    End Sub

    Private Sub تكويدصنفToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تكويدصنفToolStripMenuItem.Click
        Try
            'Add_Products_New.Show()
            Frm_Products.Show()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub تToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تToolStripMenuItem.Click
        Frm_Categories.Show()
    End Sub

    Private Sub تكويدعميلToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تكويدعميلToolStripMenuItem.Click
        Frm_Customer.Show()
    End Sub
    Public Sub Update_UserLoginLogoutHistory(ByVal LogoutTime As DateTime, ByVal IDW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update UserLoginLogoutHistory Set LogoutTime = @LogoutTime Where ID = @ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@LogoutTime", SqlDbType.Date).Value = LogoutTime
            .Parameters.AddWithValue("@ID", SqlDbType.Int).Value = IDW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        'MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub
    Private Sub Frm_Home_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Update_UserLoginLogoutHistory(DateTime.Now, My.Settings.Entry_Number)
    End Sub

    Private Sub اذناضافةToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles اذناضافةToolStripMenuItem.Click
        Frm_Invoice_Items.Show()

        'Try
        '    Ezn_Edafah_New.Show()
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub اذنصرفToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles اذنصرفToolStripMenuItem.Click
        'Ezn_Sarf_New.Show()
        Frm_Ezn_Sarf.Show()
    End Sub

    Private Sub تكويدموردToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تكويدموردToolStripMenuItem.Click
        Frm_Add_Suppliers.Show()
    End Sub

    Private Sub استعلاممستندToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles استعلاممستندToolStripMenuItem.Click
        'Frm_Document_Query.Show()
        Frm_Document_Query_Test.Show()
    End Sub

    Private Sub اذنمرتجعToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles اذنمرتجعToolStripMenuItem.Click
        Frm_Return_Suppliers.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Frm_Customer_Return.Show()
    End Sub

    Private Sub كشفحركةللصنفToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles كشفحركةللصنفToolStripMenuItem.Click
        Frm_Search_Item_Movement.Show()
    End Sub

    Private Sub الاصنافالتىقاربتعلىالانتهاءToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles الاصنافالتىقاربتعلىالانتهاءToolStripMenuItem.Click
        Frm_Expiry_Notification.Show()
    End Sub

    Private Sub اضافةمستخدمدخولToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Frm_Add_User_Login.Show()
    End Sub

    Private Sub تصديراصنافToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تصديراصنافToolStripMenuItem.Click
        Frm_Printing_Items.Show()
    End Sub

    Private Sub أمرشراءToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles أمرشراءToolStripMenuItem.Click
        Frm_Purchase_Orders.Show()
    End Sub

    Private Sub اضافةمهمةToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles اضافةمهمةToolStripMenuItem.Click
        Try
            Frm_Alerts_Test.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub اضافةوظيفةجديدةToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles اضافةوظيفةجديدةToolStripMenuItem.Click
        Frm_Add_Jop.Show()
    End Sub

    Private Sub اضافةموظفToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles اضافةموظفToolStripMenuItem.Click
        Frm_Add_Employee.Show()
    End Sub

    Private Sub شاشةالاستعلامToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles شاشةالاستعلامToolStripMenuItem.Click
        Frm_Quiry_Print.Show()
    End Sub

    Private Sub تنفيذتبديلالورادىللكلToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تنفيذتبديلالورادىللكلToolStripMenuItem.Click
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If
        ' استدعاء الإجراء المخزني UpdateNextShift_AllEmp في قاعدة البيانات '
        'Dim sqlConnection As New SqlConnection(ConStr)
        Dim sqlCommand As New SqlCommand()
        Try
            ' تعيين اسم الإجراء المخزن '
            sqlCommand.CommandText = "ShiftChange_AllEmp"
            sqlCommand.CommandType = CommandType.StoredProcedure
            sqlCommand.Connection = Con

            Con.Open()
            ' تنفيذ الإجراء المخزن '
            sqlCommand.ExecuteNonQuery()
            MessageBox.Show("تم تحديث الورديات بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("حدث خطأ أثناء تحديث الورديات: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' إغلاق الاتصال بقاعدة البيانات بغض النظر عن نجاح أو فشل التنفيذ '
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Sub
    Private Sub الجرداليومىToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles الجرداليومىToolStripMenuItem.Click
        Frm_Daily_Inventory.Show()
    End Sub

    Private Sub تصديرتقريرإكسلToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تصديرتقريرإكسلToolStripMenuItem.Click
        Frm_Rebort_HR.Show()
    End Sub

    Private Sub تعديلمستندToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تعديلمستندToolStripMenuItem.Click
        'Document_Query_Edit.Show()
        Document_Management.Show()
    End Sub

    Private Sub حذفمستندToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles حذفمستندToolStripMenuItem.Click
        Document_Query_Delete.Show()
    End Sub

    Private Sub ToolStrip_Emp_Info_Click(sender As Object, e As EventArgs) Handles ToolStrip_Emp_Info.Click
        'Frm_Emp_Info_New.Show()
        Frm_Emp_Info.Show()
    End Sub


    Private Sub البحثعنصنفToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles البحثعنصنفToolStripMenuItem.Click
        Frm_Search_Product.Show()
    End Sub

    Private Sub ToolStripMenuItem_Backup_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem_Backup.Click
        Frm_BackUp_New.Show()
    End Sub

    Private Sub ToolSetting_Add_Department_Click(sender As Object, e As EventArgs) Handles ToolSetting_Add_Department.Click
        Frm_Add_Department.Show()
    End Sub

    Private Sub ToolSetting_Add_User_Click(sender As Object, e As EventArgs) Handles ToolSetting_Add_User.Click
        Dim Frm As New Frm_Users
        Frm.TopLevel = False
        MainPanel.Controls.Add(Frm)
        Frm.BringToFront()
        Frm.Show()
    End Sub

    Private Sub البحثعنالحركاتToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles البحثعنالحركاتToolStripMenuItem.Click
        Search_MovementHistory.Show()
    End Sub

    Private Sub تفريغبياناتعملالجمعةToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تفريغبياناتعملالجمعةToolStripMenuItem.Click
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If
        Dim sqlCommand As New SqlCommand()
        Try
            ' تعيين اسم الإجراء المخزن '
            sqlCommand.CommandText = "Delete_Friday_Operation"
            sqlCommand.CommandType = CommandType.StoredProcedure
            sqlCommand.Connection = Con
            Con.Open()
            ' تنفيذ الإجراء المخزن '
            sqlCommand.ExecuteNonQuery()
            MessageBox.Show("تم تفريغ البيانات بنجاح.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("حدث خطأ أثناء تفريغ وردبات الجمعة: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' إغلاق الاتصال بقاعدة البيانات بغض النظر عن نجاح أو فشل التنفيذ '
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Sub

    Sub Backup()
        Try
            Dim Cmd As New SqlCommand
            Dim dt As DateTime = Today
            Dim destdir As String = "El_Dawliya_International " & System.DateTime.Now.ToString("dd-MM-yyyy_h-mm-ss") & ".bak"
            Dim objdlg As New SaveFileDialog
            objdlg.FileName = destdir
            objdlg.ShowDialog()
            Filename = objdlg.FileName
            Cursor = Cursors.WaitCursor
            Timer2.Enabled = True
            Con = New SqlConnection(ConStr)
            Con.Open()
            Dim cb As String = "backup database El_Dawliya_International to disk='" & Filename & "'with init,stats=10"
            Cmd = New SqlCommand(cb)
            Cmd.Connection = Con
            Cmd.ExecuteReader()
            Con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Cursor = Cursors.Default
        Timer2.Enabled = False
    End Sub

    Private Sub نسخةاحتياطيةToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles نسخةاحتياطيةToolStripMenuItem.Click
        Backup()
    End Sub

    Private Sub استرجاعنسخةاحتياطيةToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles استرجاعنسخةاحتياطيةToolStripMenuItem.Click
        Dim Cmd As New SqlCommand
        Try
            With OpenFileDialog1
                .Filter = ("DB Backup File|*.bak;")
                .FilterIndex = 4
            End With
            'Clear the file name
            OpenFileDialog1.FileName = ""

            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                Cursor = Cursors.WaitCursor
                Timer2.Enabled = True
                SqlConnection.ClearAllPools()
                Con = New SqlConnection(ConStr)
                Con.Open()
                Dim cb As String = "USE Master ALTER DATABASE El_Dawliya_International SET Single_User WITH Rollback Immediate Restore database El_Dawliya_International FROM disk='" & OpenFileDialog1.FileName & "' WITH REPLACE ALTER DATABASE El_Dawliya_International SET Multi_User "
                Cmd = New SqlCommand(cb)
                Cmd.Connection = Con
                Cmd.ExecuteReader()
                Con.Close()
                Dim st As String = "Sucessfully performed the restore"
                'LogFunc(lblUser.Text, st)
                MessageBox.Show("تمت بنجاح ", "استعادة قاعدة البيانات", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Me.SkinEngine1.SkinFile = (dir & MaterialComboBox1.Text)
    End Sub

    Private Sub تنبيهToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تنبيهToolStripMenuItem.Click
        Notifications_Screen.Show()
    End Sub

    Private Sub الاجتماعاتToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Frm_Message.Show()
    End Sub

    'Private Sub Card_User_Task_Click(sender As Object, e As EventArgs) Handles Card_User_Task.Click
    '    Try
    '        UserTasks.Show()
    '    Catch ex As Exception

    '    End Try
    'End Sub

    Private Sub LoadUserTasks()
        Try
            ' التحقق من تسجيل دخول المستخدم
            If loggedInUserID = 0 Then
                MessageBox.Show("الرجاء تسجيل الدخول أولاً", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.Close()
                Return
            End If
            ' جلب المهام الخاصة بالمستخدم
            Dim dtUserTasks As New DataTable
            Dim cmdTasks As New SqlCommand(
                            "SELECT " &
                "    t.Task_ID, " &
                "    m.Meeting_Title, " &
                "    m.Meeting_Date, " &
                "    t.Task_Description, " &
                "    t.Due_Date, " &
                "    t.Status " &
                "FROM Tbl_Meeting_Tasks t " &
                "INNER JOIN Tbl_Meetings m ON t.Meeting_ID = m.Meeting_ID " &
                "WHERE t.Assigned_To = @UserID " &
                "AND t.Status <> 'مكتمل' " &
                "ORDER BY t.Due_Date ASC", Con)

            cmdTasks.Parameters.AddWithValue("@UserID", loggedInUserID)
            Dim daTasks As New SqlDataAdapter(cmdTasks)
            daTasks.Fill(dtUserTasks)

            ' عرض إجمالي عدد المهام
            Card_User_Task.Text2 = $"{dtUserTasks.Rows.Count}"

        Catch ex As Exception
            MessageBox.Show("حدث خطأ أثناء تحميل المهام: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolMeeting.Click
        Try
            Meetings.Show()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ToolQaulty_Click(sender As Object, e As EventArgs) Handles ToolMassage.Click

        Try
            Frm_Message.Show()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub الاصنافالتىلمتستخدممنذ3اشهرToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles الاصنافالتىلمتستخدممنذ3اشهرToolStripMenuItem.Click
        Try
            Frm_Last_used_item.Show()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub اضافةمجموعةجديدةToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles اضافةمجموعةجديدةToolStripMenuItem1.Click
        Try
            GroupManagementForm2.Show()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub إدارةعضويةالمستخدمينفيالمجموعاتToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles إدارةعضويةالمستخدمينفيالمجموعاتToolStripMenuItem1.Click
        Try
            UserGroupManagementForm.Show()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub أدارةالنماذجToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles أدارةالنماذجToolStripMenuItem1.Click
        Try
            FormManagementForm.Show()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub مجموعةالنماذجوالمستخدمينToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles مجموعةالنماذجوالمستخدمينToolStripMenuItem1.Click
        Try
            Frm_GroupForms.Show()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub اضافةصلاحيةجديدةToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles اضافةصلاحيةجديدةToolStripMenuItem.Click
        Try
            PermissionManagementForm.Show()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Frm_Home_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        Try
            ' تحقق من أن المستخدم مسجل دخوله ولديه UserID
            If My.Settings.User_Name IsNot Nothing AndAlso My.Settings.Entry_Number > 0 Then
                ' استدعاء الإجراء لتحديث الحقل IsActive
                Update_Users_Login(False, loggedInUserID)
            End If
        Catch ex As Exception
            MsgBox("خطأ أثناء تحديث حالة المستخدم عند الخروج: " & ex.Message, MsgBoxStyle.Critical, "خطأ")
        End Try
        Application.Exit()
    End Sub

    'Private Sub تجربةنموذجالحضورToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تجربةنموذجالحضورToolStripMenuItem.Click
    '    Try
    '        Frm_Attend.Show()
    '    Catch ex As Exception

    '    End Try

    'End Sub

    'Private Sub تجربةنموذجالحضورجديدToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تجربةنموذجالحضورجديدToolStripMenuItem.Click
    '    Try
    '        'Frm_Attend_New.Show()
    '        Frm_Attend.Show()
    '    Catch ex As Exception

    '    End Try

    'End Sub

    Private Sub اضافةماكينةToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles اضافةماكينةToolStripMenuItem.Click
        Try
            Frm_Add_Machine.Show()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub اضافةورديةToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles اضافةورديةToolStripMenuItem.Click
        Try
            Frm_Shift_For_Machine.ShowDialog()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub اضافةتقريرماكينةطToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles اضافةتقريرماكينةطToolStripMenuItem.Click
        Try
            Add_Report_Machine.Show()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub استعلامعنتقريرToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles استعلامعنتقريرToolStripMenuItem.Click
        Try
            Report_Inquiry.Show()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub اخراجكلالمستخدمينToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles اخراجكلالمستخدمينToolStripMenuItem.Click
        ' زر إخراج جميع المستخدمين
        Try
            ' اسم العملية أو التطبيق المراد إنهاءه (اسم EXE الخاص بالبرنامج)
            Dim processName As String = "El Dawliya International System"

            ' جلب جميع العمليات المرتبطة بنفس اسم التطبيق
            Dim processes As Process() = Process.GetProcessesByName(processName)

            ' إنهاء جميع العمليات المرتبطة
            For Each proc As Process In processes
                proc.Kill()
            Next

            MessageBox.Show("تم إخراج جميع المستخدمين من البرنامج!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("حدث خطأ أثناء إخراج المستخدمين: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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

    Private Sub btn_InternalPhones_Click(sender As Object, e As EventArgs) Handles btn_InternalPhones.Click
        InternalPhones.Show()
    End Sub

    Private Sub LoadUserReportMachine()
        Try
            ' التحقق من تسجيل دخول المستخدم
            If loggedInUserID = 0 Then
                MessageBox.Show("الرجاء تسجيل الدخول أولاً", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Me.Close()
                Return
            End If
            ' جلب المهام الخاصة بالمستخدم
            Dim dtUserReportMachine As New DataTable
            Dim cmdReportMachine As New SqlCommand("Select * from Notifications where  USERID = @UserID And IsRead = 0", Con)

            cmdReportMachine.Parameters.AddWithValue("@UserID", loggedInUserID)
            Dim daTasks As New SqlDataAdapter(cmdReportMachine)
            daTasks.Fill(dtUserReportMachine)

            ' عرض إجمالي عدد المهام
            Card_User_ReportMachine.Text2 = $"{dtUserReportMachine.Rows.Count}"

        Catch ex As Exception
            MessageBox.Show("حدث خطأ أثناء تحميل المهام: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub اضافةمهمةتصميموبرمجةToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles اضافةمهمةتصميموبرمجةToolStripMenuItem.Click
        Frm_Program_Design_Tasks.Show()
    End Sub

    Private Sub اضافةحادثToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles اضافةحادثToolStripMenuItem.Click
        Frm_Accidents.Show()
    End Sub

    Private Sub مواصلاتالموظفينToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles مواصلاتالموظفينToolStripMenuItem.Click
        Emp_Transportation.Show()
    End Sub

    Private Sub حضوروانصرافالسياراتToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Frm_Car_Attendance.Show()
    End Sub

    Private Sub سيارةنقلموظفينToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles سيارةنقلموظفينToolStripMenuItem.Click
        Frm_Car.Show()
    End Sub

    Private Sub استعلامعنحضوروانصرافالسياراتToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles استعلامعنحضوروانصرافالسياراتToolStripMenuItem.Click
        Frm_Car_Attendance_Search.Show()
    End Sub

    Private Sub حضوروانصرافالسياراتToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles حضوروانصرافالسياراتToolStripMenuItem.Click
        Frm_Car_Attendance.Show()
    End Sub
End Class



'=======================================================================================================================================
'=======================================================================================================================================
'Private Sub Button_MouseEnter(sender As Object, e As EventArgs)
'    targetButton = DirectCast(sender, Button)
'    'currentColor = targetButton.BackColor
'    'targetColor = Color.LightBlue

'    currentColor = targetButton.BackColor
'    targetColor = System.Drawing.Color.LightBlue

'    colorTimer.Start()
'End Sub

'Private Sub Button_MouseLeave(sender As Object, e As EventArgs)
'    targetButton = DirectCast(sender, Button)
'    currentColor = targetButton.BackColor
'    targetColor = SystemColors.Control
'    colorTimer.Start()
'End Sub

'Private Sub colorTimer_Tick(sender As Object, e As EventArgs) Handles colorTimer.Tick
'    If targetButton IsNot Nothing Then
'        ' حساب لون جديد بالتدريج
'        Dim r = currentColor.R + Math.Sign(targetColor.R - currentColor.R)
'        Dim g = currentColor.G + Math.Sign(targetColor.G - currentColor.G)
'        Dim b = currentColor.B + Math.Sign(targetColor.B - currentColor.B)

'        currentColor = Color.FromArgb(r, g, b)
'        targetButton.BackColor = currentColor

'        ' إيقاف المؤقت إذا وصلنا إلى اللون الهدف
'        If currentColor = targetColor Then
'            colorTimer.Stop()
'        End If
'    End If
'End Sub

'Private Sub CheckForNewTasks()
'    Using connection As New SqlConnection(ConStr)
'        Try
'            ' استعلام لجلب المهام الجديدة التي لم يتم قراءتها للمستخدم الحالي
'            Dim query As String = "SELECT * FROM Notifications WHERE UserID = @UserID AND IsRead = 0"

'            ' إعداد الاستعلام باستخدام المعامل المجهول @UserID
'            Dim command As New SqlCommand(query, connection)
'            command.Parameters.AddWithValue("@UserID", loggedInUserID) ' استبدال loggedInUserID بمعرف المستخدم الحالي

'            connection.Open()

'            Dim reader As SqlDataReader = command.ExecuteReader()

'            ' إذا كانت هناك مهام جديدة
'            If reader.HasRows Then
'                While reader.Read()
'                    MessageNotification = reader("Message").ToString()
'                    Dim notificationID As Integer = reader("NotificationID").ToString()
'                    ' عرض التنبيه
'                    ShowNotification("تنبيه جديد", MessageNotification, notificationID)
'                End While
'            End If
'        Catch ex As Exception
'            MessageBox.Show("حدث خطأ أثناء الاتصال بقاعدة البيانات: " & ex.Message)
'        End Try
'    End Using
'End Sub


''Private Sub CheckForNewTasks()
''    Using connection As New SqlConnection(ConStr)
''        Try
''            ' استعلام لجلب المهام الجديدة التي لم يتم قراءتها للمستخدم الحالي
''            Dim query As String = "SELECT * FROM Notifications WHERE UserID = @UserID AND IsRead = 0"

''            ' إعداد الاستعلام باستخدام المعامل المجهول @UserID
''            Dim command As New SqlCommand(query, connection)
''            command.Parameters.AddWithValue("@UserID", loggedInUserID) ' استبدال loggedInUserID بمعرف المستخدم الحالي

''            connection.Open()

''            Dim reader As SqlDataReader = command.ExecuteReader()

''            ' إذا كانت هناك مهام جديدة
''            If reader.HasRows Then
''                While reader.Read()
''                    MessageNotification = reader("Message").ToString()
''                    Dim notificationID As Integer = Convert.ToInt32(reader("NotificationID"))

''                    ' عرض التنبيه
''                    ShowNotification("تنبيه جديد", MessageNotification, notificationID)
''                End While
''            End If
''        Catch ex As Exception
''            MessageBox.Show("حدث خطأ أثناء الاتصال بقاعدة البيانات: " & ex.Message)
''        End Try
''    End Using
''End Sub

''Private Sub ShowNotification(title As String, description As String, notificationID As Integer)
''    ' عرض التنبيه باستخدام NotifyIcon
''    MyNotifyIcon.BalloonTipTitle = title
''    MyNotifyIcon.BalloonTipText = MessageNotification
''    MyNotifyIcon.BalloonTipIcon = ToolTipIcon.Info
''    MyNotifyIcon.ShowBalloonTip(5000) ' عرض الإشعار لمدة 5 ثوانٍ

''    ' بعد عرض التنبيه، تحديث عمود IsRead في قاعدة البيانات
''    UpdateNotificationStatus(notificationID)
''End Sub


''Private Sub UpdateNotificationStatus(notificationID As Integer)
''    Using connection As New SqlConnection(ConStr)
''        Try
''            ' استعلام لتحديث عمود IsRead إلى 1 بعد عرض التنبيه
''            Dim query As String = "UPDATE Notifications SET IsRead = 1 WHERE NotificationID = @NotificationID"

''            Dim command As New SqlCommand(query, connection)
''            command.Parameters.AddWithValue("@NotificationID", notificationID)

''            connection.Open()
''            command.ExecuteNonQuery()
''        Catch ex As Exception
''            MessageBox.Show("حدث خطأ أثناء تحديث حالة الإشعار: " & ex.Message)
''        End Try
''    End Using
''End Sub


'''' عند النقر على الأيقونة
''Private Sub MyNotifyIcon_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles MyNotifyIcon.MouseDoubleClick
''    ' عرض رسالة التنبيه عند النقر على الأيقونة
''    MessageBox.Show(MessageNotification)
''End Sub

''Private Sub ShowToastNotification(title As String, description As String)
''    ' XML للإشعار المنبثق
''    Dim toastXml As String = "<toast><visual><binding template='ToastGeneric'>" &
''                         "<text>" & title & "</text>" &
''                         "<text>" & description & "</text>" &
''                         "</binding></visual></toast>"

''    ' تحويل XML إلى ToastNotification
''    Dim toastDocument As New Windows.Data.Xml.Dom.XmlDocument()
''    toastDocument.LoadXml(toastXml)

''    Dim toast As New ToastNotification(toastDocument)

''    ' عرض الإشعار
''    ToastNotificationManager.CreateToastNotifier().Show(toast)
''End Sub


