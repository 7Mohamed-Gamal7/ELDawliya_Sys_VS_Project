Public Class ThemeManager
    Private Shared _instance As ThemeManager
    Private _currentTheme As Theme

    Public Enum Theme
        Light
        Dark
        Custom
    End Enum

    Private Sub New()
        _currentTheme = Theme.Light
    End Sub

    Public Shared Function GetInstance() As ThemeManager
        If _instance Is Nothing Then
            _instance = New ThemeManager()
        End If
        Return _instance
    End Function

    Public Sub ApplyTheme(form As Form, theme As Theme)
        _currentTheme = theme

        Select Case _currentTheme
            Case Theme.Light
                ApplyLightTheme(form)
            Case Theme.Dark
                ApplyDarkTheme(form)
            Case Theme.Custom
                ApplyCustomTheme(form)
        End Select
    End Sub


    Private Sub ApplyLightTheme(form As Form)
        form.BackColor = Color.White
        form.ForeColor = Color.Black

        For Each control As Control In form.Controls
            ApplyThemeToControl(control, Color.White, Color.Black)
        Next
    End Sub

    Private Sub ApplyDarkTheme(form As Form)
        form.BackColor = Color.FromArgb(45, 45, 48)
        form.ForeColor = Color.White

        For Each control As Control In form.Controls
            ApplyThemeToControl(control, Color.FromArgb(45, 45, 48), Color.White)
        Next
    End Sub

    Private Sub ApplyCustomTheme(form As Form)
        ' يمكن إضافة تخصيص إضافي هنا
        form.BackColor = Color.FromArgb(240, 240, 240)
        form.ForeColor = Color.FromArgb(64, 64, 64)

        For Each control As Control In form.Controls
            ApplyThemeToControl(control, Color.FromArgb(240, 240, 240), Color.FromArgb(64, 64, 64))
        Next
    End Sub

    Private Sub ApplyThemeToControl(control As Control, backColor As Color, foreColor As Color)
        If TypeOf control Is Button Then
            Dim btn As Button = DirectCast(control, Button)
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 1
            btn.BackColor = backColor
            btn.ForeColor = foreColor
        ElseIf TypeOf control Is TextBox Then
            control.BackColor = backColor
            control.ForeColor = foreColor
        ElseIf TypeOf control Is Panel Then
            control.BackColor = backColor
            For Each childControl As Control In control.Controls
                ApplyThemeToControl(childControl, backColor, foreColor)
            Next
        End If
    End Sub

    Friend Sub ApplyTheme(frm_Note_Employee As Frm_Note_Employee)
        Throw New NotImplementedException()
    End Sub
End Class
