'Imports System.Data.SqlClient
'Imports System.IO
'Imports System.Diagnostics

'Public Class Frm_Message
'    Public ConStr As String = GetConnectionString()
'    Public Con As New SqlConnection(ConStr)

'    Private notificationManager As NotificationManager
'    Private currentUserId As Integer = loggedInUserID
'    ' يمكنك تغيير هذا حسب المستخدم الحالي
'    'Private connectionString As String = "Data Source= DESKTOP-H361157\SQLEXPRESS;Initial Catalog = ElDawliyaDB;integrated security=true" ' ضع سلسلة الاتصال الخاصة بك
'    Private serverProcess As Process

'    Private Sub StartServer()
'        Try
'            ' تحديد مسار برنامج الخادم
'            'Dim serverPath As String = Path.Combine(
'            '        Application.StartupPath, "D", "تجربة جديدة",
'            '        "NotificationServer", "NotificationServer", "bin", "Debug",
'            '        "NotificationServer.exe")
'            Dim serverPath As String = "E:\El Dawliya International System\NotificationServer\NotificationServer\bin\Debug\NotificationServer.exe"

'            ' التحقق من وجود ملف الخادم
'            If Not File.Exists(serverPath) Then
'                MessageBox.Show("لم يتم العثور على ملف الخادم. الرجاء التأكد من بناء مشروع الخادم أولاً.",
'                                  "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
'                Return
'            End If

'            ' إنشاء عملية جديدة لتشغيل الخادم
'            serverProcess = New Process()
'            serverProcess.StartInfo.FileName = serverPath
'            serverProcess.StartInfo.WindowStyle = ProcessWindowStyle.Minimized
'            serverProcess.Start()

'            ' انتظار لحظة للتأكد من بدء الخادم
'            Threading.Thread.Sleep(1000)

'        Catch ex As Exception
'            MessageBox.Show($"حدث خطأ أثناء تشغيل الخادم: {ex.Message}",
'                              "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        End Try
'    End Sub

'    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        StartServer()
'        InitializeForm()
'        ConnectToServer()
'        LoadUsers()
'    End Sub

'    Private Sub InitializeForm()
'        Text = $"نظام الرسائل - المستخدم {currentUserId}"
'        lblStatus.Text = "جاري الاتصال..."

'        ' تهيئة مدير الإشعارات
'        notificationManager = New NotificationManager(currentUserId)
'        AddHandler notificationManager.MessageReceived, AddressOf HandleNewMessage
'        AddHandler notificationManager.UnreadMessageReceived, AddressOf HandleUnreadMessage
'        AddHandler notificationManager.ConnectionStatusChanged, AddressOf HandleConnectionStatus
'    End Sub

'    Private Sub ConnectToServer()
'        If notificationManager.Connect("127.0.0.1", 8888) Then
'            lblStatus.Text = "متصل"
'            lblStatus.ForeColor = Color.Green
'        Else
'            lblStatus.Text = "غير متصل"
'            lblStatus.ForeColor = Color.Red
'        End If
'    End Sub

'    Private Sub LoadUsers()
'        Try
'            'Using con As New SqlConnection("Data Source= DESKTOP-H361157\SQLEXPRESS;Initial Catalog = ElDawliyaDB;integrated security=true")
'            Using con As New SqlConnection(GetConnectionString())
'                con.Open()
'                Dim query As String = "SELECT UserID, UserName FROM Users_Login WHERE UserID <> @CurrentUserID"

'                Using cmd As New SqlCommand(query, con)
'                    cmd.Parameters.AddWithValue("@CurrentUserID", currentUserId)

'                    Using reader As SqlDataReader = cmd.ExecuteReader()
'                        cboReceivers.Items.Clear()
'                        While reader.Read()
'                            Dim item As New ComboBoxItem With {
'                                .Value = reader("UserID"),
'                                .Text = reader("UserName")
'                            }
'                            cboReceivers.Items.Add(item)
'                        End While
'                    End Using
'                End Using
'            End Using
'        Catch ex As Exception
'            MessageBox.Show($"خطأ في تحميل المستخدمين: {ex.Message}")
'        End Try
'    End Sub

'    Private Sub HandleNewMessage(senderId As Integer, content As String)
'        Invoke(Sub()
'                   lstMessages.Items.Add($"[{DateTime.Now:HH:mm:ss}] المستخدم {senderId}: {content}")
'                   lstMessages.SelectedIndex = lstMessages.Items.Count - 1
'               End Sub)
'    End Sub

'    Private Sub HandleUnreadMessage(messageId As Integer, senderId As Integer, content As String, sendDate As DateTime)
'        Invoke(Sub()
'                   lstMessages.Items.Add($"[{sendDate:dd/MM/yyyy HH:mm:ss}] المستخدم {senderId}: {content}")
'               End Sub)
'    End Sub

'    Private Sub HandleConnectionStatus(status As Boolean)
'        If Me IsNot Nothing AndAlso Not Me.IsDisposed AndAlso Me.InvokeRequired Then
'            Try
'                Invoke(Sub()
'                           If status Then
'                               lblStatus.Text = "متصل"
'                               lblStatus.ForeColor = Color.Green
'                           Else
'                               lblStatus.Text = "غير متصل"
'                               lblStatus.ForeColor = Color.Red
'                           End If
'                       End Sub)
'            Catch ex As ObjectDisposedException
'                ' تجاهل الخطأ إذا تم التخلص من النموذج
'            End Try
'        ElseIf Not Me.IsDisposed Then
'            If status Then
'                lblStatus.Text = "متصل"
'                lblStatus.ForeColor = Color.Green
'            Else
'                lblStatus.Text = "غير متصل"
'                lblStatus.ForeColor = Color.Red
'            End If
'        End If
'    End Sub


'    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
'        If cboReceivers.SelectedItem Is Nothing Then
'            MessageBox.Show("الرجاء اختيار المستلم")
'            Return
'        End If

'        If String.IsNullOrWhiteSpace(txtMessage.Text) Then
'            MessageBox.Show("الرجاء إدخال نص الرسالة")
'            Return
'        End If

'        Dim recipientId As Integer = DirectCast(cboReceivers.SelectedItem, ComboBoxItem).Value
'        notificationManager.SendMessage(recipientId, txtMessage.Text)

'        ' إضافة الرسالة إلى القائمة
'        lstMessages.Items.Add($"[{DateTime.Now:HH:mm:ss}] أنا: {txtMessage.Text}")
'        lstMessages.SelectedIndex = lstMessages.Items.Count - 1

'        ' مسح حقل الرسالة
'        txtMessage.Clear()
'    End Sub

'    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
'        ' إغلاق اتصال العميل
'        If notificationManager IsNot Nothing Then
'            notificationManager.Disconnect()
'        End If

'        ' إغلاق عملية الخادم
'        Try
'            If serverProcess IsNot Nothing AndAlso Not serverProcess.HasExited Then
'                serverProcess.Kill()
'                serverProcess.WaitForExit(1000)
'                serverProcess.Dispose()
'            End If
'        Catch ex As Exception
'            ' تجاهل أي أخطاء عند الإغلاق
'        End Try
'    End Sub
'End Class

'' فئة مساعدة لعناصر القائمة المنسدلة
'Public Class ComboBoxItem
'    Public Property Value As Integer
'    Public Property Text As String

'    Public Overrides Function ToString() As String
'        Return Text
'    End Function


'End Class







Imports System.Data.SqlClient
Imports System.IO

Public Class Frm_Message
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)

    Private notificationManager As NotificationManager
    Private currentUserId As Integer = loggedInUserID
    Private serverProcess As Process
    Private lastSenderId As Integer = -1 ' تخزين ID آخر مرسل

    Private Sub StartServer()
        Try
            Dim serverPath As String = "E:\El Dawliya International System\NotificationServer\NotificationServer\bin\Debug\NotificationServer.exe"

            If Not File.Exists(serverPath) Then
                MessageBox.Show("لم يتم العثور على ملف الخادم. الرجاء التأكد من بناء مشروع الخادم أولاً.",
                                "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            serverProcess = New Process()
            serverProcess.StartInfo.FileName = serverPath
            serverProcess.StartInfo.WindowStyle = ProcessWindowStyle.Minimized
            serverProcess.Start()
            Threading.Thread.Sleep(1000)

        Catch ex As Exception
            MessageBox.Show($"حدث خطأ أثناء تشغيل الخادم: {ex.Message}",
                            "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartServer()
        InitializeForm()
        ConnectToServer()
        LoadUsers()
    End Sub

    Private Sub HandleConnectionStatus(status As Boolean)
        If Me IsNot Nothing AndAlso Not Me.IsDisposed AndAlso Me.InvokeRequired Then
            Try
                Invoke(Sub()
                           If status Then
                               lblStatus.Text = "متصل"
                               lblStatus.ForeColor = Color.Green
                           Else
                               lblStatus.Text = "غير متصل"
                               lblStatus.ForeColor = Color.Red
                           End If
                       End Sub)
            Catch ex As ObjectDisposedException
                ' تجاهل الخطأ إذا تم التخلص من النموذج
            End Try
        ElseIf Not Me.IsDisposed Then
            If status Then
                lblStatus.Text = "متصل"
                lblStatus.ForeColor = Color.Green
            Else
                lblStatus.Text = "غير متصل"
                lblStatus.ForeColor = Color.Red
            End If
        End If
    End Sub

    Private Sub InitializeForm()
        Text = $"نظام الرسائل - المستخدم {currentUserId}"
        lblStatus.Text = "جاري الاتصال..."

        notificationManager = New NotificationManager(currentUserId)
        AddHandler notificationManager.MessageReceived, AddressOf HandleNewMessage
        AddHandler notificationManager.UnreadMessageReceived, AddressOf HandleUnreadMessage
        AddHandler notificationManager.ConnectionStatusChanged, AddressOf HandleConnectionStatus
    End Sub

    Private Sub ConnectToServer()
        If notificationManager.Connect("127.0.0.1", 8888) Then
            lblStatus.Text = "متصل"
            lblStatus.ForeColor = Color.Green
        Else
            lblStatus.Text = "غير متصل"
            lblStatus.ForeColor = Color.Red
        End If
    End Sub

    Private Sub LoadUsers()
        Try
            Using con As New SqlConnection(GetConnectionString())
                con.Open()
                Dim query As String = "SELECT UserID, UserName FROM Users_Login WHERE UserID <> @CurrentUserID"

                Using cmd As New SqlCommand(query, con)
                    cmd.Parameters.AddWithValue("@CurrentUserID", currentUserId)

                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        cboReceivers.Items.Clear()
                        While reader.Read()
                            Dim item As New ComboBoxItem With {
                                .Value = reader("UserID"),
                                .Text = reader("UserName")
                            }
                            cboReceivers.Items.Add(item)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"خطأ في تحميل المستخدمين: {ex.Message}")
        End Try
    End Sub

    Private Sub HandleNewMessage(senderId As Integer, content As String)
        Invoke(Sub()
                   lstMessages.Items.Add($"[{DateTime.Now:HH:mm:ss}] المستخدم {senderId}: {content}")
                   lstMessages.SelectedIndex = lstMessages.Items.Count - 1

                   ' تخزين معرف الراسل الأخير
                   lastSenderId = senderId

                   ' إظهار إشعار
                   ShowNotification($"رسالة جديدة من المستخدم {senderId}", content)
               End Sub)
    End Sub

    Private Sub HandleUnreadMessage(messageId As Integer, senderId As Integer, content As String, sendDate As DateTime)
        Invoke(Sub()
                   lstMessages.Items.Add($"[{sendDate:dd/MM/yyyy HH:mm:ss}] المستخدم {senderId}: {content}")
                   lastSenderId = senderId ' تخزين معرف الراسل الأخير
                   ShowNotification($"رسالة جديدة (غير مقروءة) من المستخدم {senderId}", content)
               End Sub)
    End Sub

    Private Sub ShowNotification(title As String, content As String)
        NotifyIcon1.BalloonTipTitle = title
        NotifyIcon1.BalloonTipText = content
        NotifyIcon1.ShowBalloonTip(3000)
    End Sub

    Private Sub btnReply_Click(sender As Object, e As EventArgs) Handles btnReply.Click
        If lastSenderId = -1 Then
            MessageBox.Show("لا يوجد مرسل للرد عليه.")
            Return
        End If

        Dim replyContent As String = txtMessage.Text
        If String.IsNullOrWhiteSpace(replyContent) Then
            MessageBox.Show("الرجاء إدخال نص الرد.")
            Return
        End If

        notificationManager.SendMessage(lastSenderId, replyContent)
        lstMessages.Items.Add($"[{DateTime.Now:HH:mm:ss}] أنا (رد): {replyContent}")
        txtMessage.Clear()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If notificationManager IsNot Nothing Then
            notificationManager.Disconnect()
        End If

        Try
            If serverProcess IsNot Nothing AndAlso Not serverProcess.HasExited Then
                serverProcess.Kill()
                serverProcess.WaitForExit(1000)
                serverProcess.Dispose()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        If cboReceivers.SelectedItem Is Nothing Then
            MessageBox.Show("الرجاء اختيار المستلم")
            Return
        End If

        If String.IsNullOrWhiteSpace(txtMessage.Text) Then
            MessageBox.Show("الرجاء إدخال نص الرسالة")
            Return
        End If

        Dim recipientId As Integer = DirectCast(cboReceivers.SelectedItem, ComboBoxItem).Value
        notificationManager.SendMessage(recipientId, txtMessage.Text)

        ' إضافة الرسالة إلى القائمة
        lstMessages.Items.Add($"[{DateTime.Now:HH:mm:ss}] أنا: {txtMessage.Text}")
        lstMessages.SelectedIndex = lstMessages.Items.Count - 1

        ' مسح حقل الرسالة
        txtMessage.Clear()
    End Sub
End Class

Public Class ComboBoxItem
    Public Property Value As Integer
    Public Property Text As String

    Public Overrides Function ToString() As String
        Return Text
    End Function
End Class
