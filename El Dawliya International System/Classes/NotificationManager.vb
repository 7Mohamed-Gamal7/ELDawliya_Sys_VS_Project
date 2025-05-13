Imports System.Net.Sockets
Imports System.Text

Public Class NotificationManager
    Private client As TcpClient
    Private stream As NetworkStream
    Private userId As Integer
    Private isConnected As Boolean = False

    ' الأحداث التي سيتم إطلاقها عند استلام رسائل
    Public Event MessageReceived(senderId As Integer, content As String)
    Public Event ConnectionStatusChanged(status As Boolean)
    Public Event UnreadMessageReceived(messageId As Integer, senderId As Integer, content As String, sendDate As DateTime)

    Public Sub New(userID As Integer)
        Me.userId = userID
    End Sub

    Public Function Connect(serverIP As String, serverPort As Integer) As Boolean
        Try
            client = New TcpClient()
            client.Connect(serverIP, serverPort)
            stream = client.GetStream()

            ' إرسال معرف المستخدم للخادم
            Dim data As Byte() = Encoding.UTF8.GetBytes(userId.ToString())
            stream.Write(data, 0, data.Length)

            ' بدء استقبال الرسائل
            Dim thread As New Threading.Thread(AddressOf ReceiveMessages)
            thread.IsBackground = True
            thread.Start()

            isConnected = True
            RaiseEvent ConnectionStatusChanged(True)
            Return True

        Catch ex As Exception
            MessageBox.Show($"خطأ في الاتصال: {ex.Message}")
            isConnected = False
            RaiseEvent ConnectionStatusChanged(False)
            Return False
        End Try
    End Function

    Private Sub ReceiveMessages()
        Try
            While True
                Dim buffer(4096) As Byte
                Dim bytesRead As Integer = stream.Read(buffer, 0, buffer.Length)

                If bytesRead > 0 Then
                    Dim message As String = Encoding.UTF8.GetString(buffer, 0, bytesRead)
                    ProcessReceivedMessage(message)
                End If
            End While
        Catch ex As Exception
            isConnected = False
            RaiseEvent ConnectionStatusChanged(False)
        End Try
    End Sub

    Private Sub ProcessReceivedMessage(message As String)
        Try
            Dim parts() As String = message.Split("|"c)
            Select Case parts(0)
                Case "NEW"
                    ' رسالة جديدة
                    Dim senderId As Integer = Convert.ToInt32(parts(1))
                    Dim content As String = parts(2)
                    RaiseEvent MessageReceived(senderId, content)

                Case "UNREAD"
                    ' رسالة غير مقروءة
                    Dim messageId As Integer = Convert.ToInt32(parts(1))
                    Dim senderId As Integer = Convert.ToInt32(parts(2))
                    Dim content As String = parts(3)
                    Dim sendDate As DateTime = Convert.ToDateTime(parts(4))
                    RaiseEvent UnreadMessageReceived(messageId, senderId, content, sendDate)
            End Select
        Catch ex As Exception
            MessageBox.Show($"خطأ في معالجة الرسالة: {ex.Message}")
        End Try
    End Sub

    Public Sub SendMessage(recipientId As Integer, content As String)
        Try
            If Not isConnected Then
                MessageBox.Show("غير متصل بالخادم")
                Return
            End If

            Dim message As String = $"MSG|{recipientId}|{content}"
            Dim data As Byte() = Encoding.UTF8.GetBytes(message)
            stream.Write(data, 0, data.Length)

        Catch ex As Exception
            MessageBox.Show($"خطأ في إرسال الرسالة: {ex.Message}")
        End Try
    End Sub

    Public Sub Disconnect()
        Try
            If client IsNot Nothing Then
                client.Close()
            End If
            isConnected = False
            RaiseEvent ConnectionStatusChanged(False)
        Catch ex As Exception
            MessageBox.Show($"خطأ في قطع الاتصال: {ex.Message}")
        End Try
    End Sub
End Class