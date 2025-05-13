Imports System.Runtime.InteropServices

Module PuplicModule
    Public loggedInUserName As String
    Public loggedInUserID As Integer
    Public D1 As String = "D1"
    Public D2 As String = "D2"
    Public F1 As String = "F1"
    Public F2 As String = "F2"
    Public H As String = "H"
    Public Function DGVCurrentImageView(ByVal byt As Byte()) As Image
        Using MS As New System.IO.MemoryStream()
            Dim drwing As Image = Nothing
            MS.Write(byt, 0, byt.Length)
            drwing = New Bitmap(MS)
            MS.Close()
            Return drwing
        End Using
    End Function
    'Public Sub Arabic()
    '    Dim Lang As InputLanguage
    '    For Each Lang In InputLanguage.InstalledInputLanguages
    '        If Lang.Culture.EnglishName.ToUpper Like "*Arabic*".ToUpper Then
    '            InputLanguage.CurrentInputLanguage = Lang
    '        End If
    '    Next
    'End Sub
    '''Public Sub Arabic(ParamArray textBoxes() As TextBox)
    '''    Dim Lang As InputLanguage
    '''    For Each Lang In InputLanguage.InstalledInputLanguages
    '''        If Lang.Culture.EnglishName.ToUpper Like "*Arabic*".ToUpper Then
    '''            InputLanguage.CurrentInputLanguage = Lang
    '''            For Each tb As TextBox In textBoxes
    '''                tb.RightToLeft = RightToLeft.Yes
    '''                AddHandler tb.Enter, AddressOf TextBox_Enter
    '''            Next
    '''        End If
    '''    Next
    '''End Sub

    '''Private Sub TextBox_Enter(ByVal sender As Object, ByVal e As EventArgs)
    '''    ' لا تحتاج لعمل أي شيء هنا لأن الاتجاه قد تم تعيينه بالفعل في الدالة الرئيسية.
    '''End Sub


    Public Sub Arabic(ParamArray textBoxes() As TextBox)
        Dim Lang As InputLanguage
        For Each Lang In InputLanguage.InstalledInputLanguages
            If Lang.Culture.EnglishName.ToUpper Like "*Arabic*".ToUpper Then
                InputLanguage.CurrentInputLanguage = Lang
                For Each tb As TextBox In textBoxes
                    ' تعيين الاتجاه إلى اليمين
                    tb.RightToLeft = RightToLeft.Yes
                Next
            End If
        Next
        ' ربط حدث الـ"Enter" لكل التيكست بوكس بالدالة Arabic
        For Each tb As TextBox In textBoxes
            AddHandler tb.Enter, AddressOf TextBox_Enter
        Next
    End Sub


    Public Sub ArabicToolStrip(ParamArray controls() As Object)
        Dim Lang As InputLanguage
        For Each Lang In InputLanguage.InstalledInputLanguages
            If Lang.Culture.EnglishName.ToUpper Like "*Arabic*".ToUpper Then
                InputLanguage.CurrentInputLanguage = Lang
                For Each control As Object In controls
                    If TypeOf control Is TextBox Then
                        DirectCast(control, TextBox).RightToLeft = RightToLeft.Yes
                    ElseIf TypeOf control Is ToolStripTextBox Then
                        DirectCast(control, ToolStripTextBox).RightToLeft = RightToLeft.Yes
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub TextBox_Enter(ByVal sender As Object, ByVal e As EventArgs)
        ' تغيير لغة الإدخال إلى العربية عند الدخول إلى التيكست بوكس
        If TypeOf sender Is TextBox OrElse TypeOf sender Is ToolStripTextBox Then
            Arabic(sender)
        End If
    End Sub


    'Private Sub TextBox_Enter(ByVal sender As Object, ByVal e As EventArgs)
    '    '' إعادة تعيين الاتجاه إلى اليمين عند حدوث حدث الـ"Enter"
    'CType(sender, TextBox).RightToLeft = RightToLeft.Yes

    'End Sub


    Public Sub English(ParamArray textBoxes() As TextBox)
        Dim Lang As InputLanguage
        For Each Lang In InputLanguage.InstalledInputLanguages
            If Lang.Culture.EnglishName.ToUpper Like "*English*".ToUpper Then
                InputLanguage.CurrentInputLanguage = Lang
                For Each tb As TextBox In textBoxes
                    ' Set text direction to left-to-right
                    tb.RightToLeft = RightToLeft.No
                Next
            End If
        Next

        ' Attach Enter event handler for all text boxes to English function
        For Each tb As TextBox In textBoxes
            AddHandler tb.Enter, AddressOf TextBoxEnglish_Enter
        Next
    End Sub

    Private Sub TextBoxEnglish_Enter(ByVal sender As Object, ByVal e As EventArgs)
        ' Reset text direction to left-to-right when Enter event occurs
        CType(sender, TextBox).RightToLeft = RightToLeft.No
    End Sub

    Public Function GetDateValue(valueDate As String) As Date
        Dim dateValue As Date
        If String.IsNullOrWhiteSpace(valueDate) Then
            Return #1/1/1900# ' يمكنك تغييرها إلى القيمة الافتراضية التي تناسب تطبيقك
        End If
        If Date.TryParse(valueDate, dateValue) Then
            Return dateValue
        End If
        ' يمكنك إضافة مزيد من المنطق هنا، مثل إظهار رسالة خطأ
        Return #1/1/1900# ' أو القيمة الافتراضية التي تناسب تطبيقك
    End Function

    Public Function GetIntegerValue(valueString As String) As Integer
        Dim integerValue As Integer
        If String.IsNullOrWhiteSpace(valueString) Then
            Return vbNullString
        End If
        If Integer.TryParse(valueString, integerValue) Then
            Return integerValue
        End If
        ' يمكنك إضافة مزيد من المنطق هنا، مثل إظهار رسالة خطأ
        Return 0 ' أو القيمة الافتراضية التي تناسب تطبيقك
    End Function

    Public Function GetDecimalValue(valueString As String) As Decimal
        Dim doubleValue As Decimal
        If String.IsNullOrWhiteSpace(valueString) Then
            Return 0.00
        End If
        If Decimal.TryParse(valueString, doubleValue) Then
            Return doubleValue
        End If
        ' يمكنك إضافة مزيد من المنطق هنا، مثل إظهار رسالة خطأ
        Return 0.00 ' أو القيمة الافتراضية التي تناسب تطبيقك
    End Function

    Public Function GetDoubleValue(valueString As String) As Double
        Dim doubleValue As Double
        If String.IsNullOrWhiteSpace(valueString) Then
            Return vbNullString
        End If
        If Double.TryParse(valueString, doubleValue) Then
            Return doubleValue
        End If
        ' يمكنك إضافة مزيد من المنطق هنا، مثل إظهار رسالة خطأ
        Return vbNullString ' أو القيمة الافتراضية التي تناسب تطبيقك
    End Function

    Public Function GetStringValue(valueString As String) As String
        If String.IsNullOrWhiteSpace(valueString) Then
            Return vbNullString
        End If
        ' يمكنك إضافة المزيد من المنطق هنا إذا لزم الأمر، مثل إظهار رسالة خطأ أو تحديد قيمة افتراضية
        Return valueString ' يُرجى استبدال هذه القيمة بالقيمة الافتراضية التي تناسب تطبيقك إذا لزم الأمر
    End Function

    Public Function GetDateValueFor_date_Birth(dateOfBirth As Date) As Object
        ' تحقق مما إذا كان التاريخ ضمن النطاق المسموح وليس تاريخ اليوم
        If dateOfBirth >= #1/1/1753# AndAlso dateOfBirth <= #12/31/9999# AndAlso dateOfBirth <> Date.Today Then
            Return dateOfBirth
        Else
            ' إذا كان التاريخ خارج النطاق أو يساوي تاريخ اليوم، يعود قيمة Null
            Return #1/1/1900#
        End If
    End Function


    Public Sub ChoosePicture(Pbox As PictureBox)
        Dim a As New OpenFileDialog
        With a
            .AddExtension = True
            .CheckPathExists = True
            .CheckFileExists = True
            .Title = "Choose Image"
            .Filter = "Choose Image (*.PNG; *.JPG; *.GIF; *.JPEG)| *.PNG; *.JPG; *.GIF; *.JPEG | All Files (*.*)|*.*"
            If .ShowDialog = DialogResult.OK Then
                Pbox.Image = Image.FromFile(.FileName)
            End If
        End With
    End Sub
    Public Class RoundButton
        Inherits Button

        <DllImport("gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
        Private Shared Function CreateRoundButton(ByVal nLeftRect As Integer, ByVal nTopRec As Integer, ByVal nRightRec As Integer, ByVal nBottomRec As Integer, ByVal nHighRec As Integer, ByVal nWidthRec As Integer) As IntPtr

        End Function

        Protected Overrides Sub OnCreateControl()
            MyBase.OnCreateControl()
            Me.Region = System.Drawing.Region.FromHrgn(CreateRoundButton(2, 2, Me.Width - 2, Me.Height - 2, 20, 20))
        End Sub

        Protected Overrides Sub OnResize(e As EventArgs)
            MyBase.OnResize(e)
            Me.Region = System.Drawing.Region.FromHrgn(CreateRoundButton(2, 2, Me.Width - 2, Me.Height - 2, 20, 20))
        End Sub


        'Public Sub PopulateTextBox(DGV As DataGridView, textBox As TextBox, columnName As String)
        '    Dim value = DGV.CurrentRow.Cells(columnName).Value
        '    textBox.Text = If(Not IsDBNull(value), value.ToString(), "")
        'End Sub
        'Public Sub PopulateCheckBox(DGV As DataGridView, Checkbox As CheckBox, columnName As String)
        '    Dim value = DGV.CurrentRow.Cells(columnName).Value
        '    Checkbox.Checked = If(Not IsDBNull(value), value.ToString(), False)
        'End Sub
        'Public Sub PopulateComboBox(DGV As DataGridView, ComboBox As ComboBox, columnName As String)
        '    Dim value = DGV.CurrentRow.Cells(columnName).Value
        '    ComboBox.Text = If(Not IsDBNull(value), value.ToString(), "")
        'End Sub
        'Public Sub PopulateDateTimePicker(DGV As DataGridView, DateTimePicker As DateTimePicker, columnName As String)
        '    Dim value = DGV.CurrentRow.Cells(columnName).Value
        '    DateTimePicker.Value = If(Not IsDBNull(value), value.ToString(), "")
        'End Sub
    End Class
End Module
