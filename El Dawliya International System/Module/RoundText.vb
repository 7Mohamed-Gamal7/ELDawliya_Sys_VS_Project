Imports System.Runtime.InteropServices
Namespace El_Dawliya_International_System
    Public Class RoundText
        Inherits TextBox

        <DllImport("gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
        Private Shared Function CreateRoundText(ByVal nLeftRect As Integer, ByVal nTopRec As Integer, ByVal nRightRec As Integer, ByVal nBottomRec As Integer, ByVal nHighRec As Integer, ByVal nWidthRec As Integer) As IntPtr

        End Function

        Protected Overrides Sub OnCreateControl()
            MyBase.OnCreateControl()
            Me.Region = System.Drawing.Region.FromHrgn(CreateRoundText(2, 2, Me.Width - 2, Me.Height - 2, 20, 20))
        End Sub

        Protected Overrides Sub OnResize(e As EventArgs)
            MyBase.OnResize(e)
            Me.Region = System.Drawing.Region.FromHrgn(CreateRoundText(2, 2, Me.Width - 2, Me.Height - 2, 20, 20))
        End Sub

    End Class
End Namespace