Imports System.Net
Public Class Frm_Update

    Private Sub Frm_Update_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
    '    Dim Web As New WebClient
    '    Lbl_Update.Text = Web.DownloadString("https://dl.dropboxusercontent.com/scl/fi/uxt28smvtsm96tdw061iw/Update.txt?rlkey=e52lnl431ffkbexu4i4tfwigb&dl=0")
    '    If Lbl_Update.Text = "متاح" Then
    '        MsgBox("لا توجد تحديثات جديدة", 64, "البحث عن تحديثات")
    '    Else
    '        WebBrowser1.Navigate("https://dl.dropbox.com/scl/fi/06jj68q35v1khq5w5goef/El-Dawliya-International-System.exe?rlkey=ebn6yssu1i31292bq5kacsd53&dl=0")
    '    End If
    'End Sub

    'Private Async Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
    '    Try
    '        Dim updateUrl As String = "https://dl.dropboxusercontent.com/scl/fi/uxt28smvtsm96tdw061iw/Update.txt?rlkey=e52lnl431ffkbexu4i4tfwigb&dl=0"
    '        Dim Web As New WebClient()
    '        Dim updateContent As String = Await Web.DownloadStringTaskAsync(updateUrl)
    '        If updateContent = "متاح" Then
    '            MsgBox("لا توجد تحديثات جديدة", 64, "البحث عن تحديثات")
    '        Else
    '            Dim newVersionUrl As String = "https://dl.dropbox.com/scl/fi/06jj68q35v1khq5w5goef/El-Dawliya-International-System.exe?rlkey=ebn6yssu1i31292bq5kacsd53&dl=0"
    '            ' قم بتعيين المسار الجديد هنا (تأكد من وجود العلامة "\" بين المسار واسم الملف)
    '            Dim newPath As String = "C:\Users\Mohamed Gamal\Documents\" & "El Dawliya International System.exe"
    '            ' قم بتنزيل الملف إلى المسار الجديد
    '            Await Web.DownloadFileTaskAsync(newVersionUrl, newPath)
    '            ' اعرض رسالة بأن التحديث تم بنجاح
    '            MsgBox("تم تحديث التطبيق بنجاح!", 64, "تحديث ناجح")
    '        End If
    '    Catch ex As Exception
    '        ' يمكنك إضافة رسالة خطأ هنا
    '        MsgBox("حدث خطأ أثناء التحديث", 48, "خطأ")
    '    End Try
    'End Sub
    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Try
            Dim updateUrl As String = "https://dl.dropboxusercontent.com/scl/fi/uxt28smvtsm96tdw061iw/Update.txt?rlkey=e52lnl431ffkbexu4i4tfwigb&dl=0"
            Dim Web As New WebClient()
            Dim updateContent As String = Web.DownloadString(updateUrl)

            If updateContent = "متاح" Then
                MsgBox("لا توجد تحديثات جديدة", 64, "البحث عن تحديثات")
            Else
                Dim newVersionUrl As String = "https://dl.dropbox.com/scl/fi/06jj68q35v1khq5w5goef/El-Dawliya-International-System.exe?rlkey=ebn6yssu1i31292bq5kacsd53&dl=0"

                ' قم بتحديد مسار لحفظ الملف هنا
                Dim newPath As String = "C:\Users\Mohamed Gamal\Documents\El-Dawliya-International-System.exe"

                ' قم بتنزيل الملف إلى المسار الجديد
                Web.DownloadFile(newVersionUrl, newPath)

                ' اعرض رسالة بأن التحديث تم بنجاح
                MsgBox("تم تحديث التطبيق بنجاح!", 64, "تحديث ناجح")
            End If
        Catch ex As Exception
            ' يمكنك إضافة رسالة خطأ هنا
            MsgBox("حدث خطأ أثناء التحديث", 48, "خطأ")
        End Try
    End Sub

End Class