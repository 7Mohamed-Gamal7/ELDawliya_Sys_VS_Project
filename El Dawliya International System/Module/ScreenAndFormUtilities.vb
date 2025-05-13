Imports System.Runtime.InteropServices

Module ScreenAndFormUtilities
    ' Constants for screen resolution and DPI functions
    Private Const DM_PELSWIDTH As Integer = &H80000
    Private Const DM_PELSHEIGHT As Integer = &H100000
    Private Const CDS_UPDATEREGISTRY As Integer = &H1
    Private Const DISP_CHANGE_SUCCESSFUL As Integer = 0
    Private Const SM_CXSCREEN As Integer = 0
    Private Const SM_CYSCREEN As Integer = 1

    ' API function declarations
    <DllImport("user32.dll", CharSet:=CharSet.Ansi)>
    Private Function EnumDisplaySettings(ByVal lpszDeviceName As String, ByVal iModeNum As Integer, ByRef lpDevMode As DEVMODE) As Boolean
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Ansi)>
    Private Function ChangeDisplaySettings(ByRef lpDevMode As DEVMODE, ByVal dwFlags As Integer) As Integer
    End Function

    <DllImport("user32.dll", SetLastError:=True)>
    Private Function GetSystemMetrics(ByVal nIndex As Integer) As Integer
    End Function

    <DllImport("user32.dll", SetLastError:=True)>
    Private Function SetProcessDPIAware() As Boolean
    End Function

    ' DEVMODE structure for screen resolution manipulation
    <StructLayout(LayoutKind.Sequential)>
    Private Structure DEVMODE
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=32)>
        Public dmDeviceName As String
        Public dmSpecVersion As Short
        Public dmDriverVersion As Short
        Public dmSize As Short
        Public dmDriverExtra As Short
        Public dmFields As Integer
        Public dmPelsWidth As Integer
        Public dmPelsHeight As Integer
        Public dmBitsPerPel As Integer
        Public dmDisplayFrequency As Integer
    End Structure

    ' Original resolution values
    Private originalScreenWidth As Integer = GetSystemMetrics(SM_CXSCREEN)
    Private originalScreenHeight As Integer = GetSystemMetrics(SM_CYSCREEN)

    ' Function to adjust form and controls dynamically
    Public Sub AdjustFormAndControls(form As Form, originalWidth As Integer, originalHeight As Integer)
        Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height

        Dim widthRatio As Double = screenWidth / originalWidth
        Dim heightRatio As Double = screenHeight / originalHeight

        form.Width = CInt(form.Width * widthRatio)
        form.Height = CInt(form.Height * heightRatio)
        AdjustControls(form.Controls, widthRatio, heightRatio)
    End Sub

    Private Sub AdjustControls(controls As Control.ControlCollection, widthRatio As Double, heightRatio As Double)
        For Each ctrl As Control In controls
            ResizeControl(ctrl, widthRatio, heightRatio)
        Next
    End Sub

    Private Sub ResizeControl(ctrl As Control, widthRatio As Double, heightRatio As Double)
        ctrl.Left = CInt(ctrl.Left * widthRatio)
        ctrl.Top = CInt(ctrl.Top * heightRatio)
        ctrl.Width = CInt(ctrl.Width * widthRatio)
        ctrl.Height = CInt(ctrl.Height * heightRatio)

        If ctrl.Font IsNot Nothing Then
            Dim currentFont As Font = ctrl.Font
            ctrl.Font = New Font(currentFont.FontFamily, CSng(currentFont.Size * Math.Min(widthRatio, heightRatio)), currentFont.Style)
        End If

        If ctrl.HasChildren Then
            AdjustControls(ctrl.Controls, widthRatio, heightRatio)
        End If
    End Sub

    ' Function to change screen resolution
    Public Sub ChangeScreenResolution(width As Integer, height As Integer)
        Dim devMode As New DEVMODE()
        If Not EnumDisplaySettings(Nothing, 0, devMode) Then
            MessageBox.Show("Unable to retrieve display settings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        devMode.dmFields = DM_PELSWIDTH Or DM_PELSHEIGHT
        devMode.dmPelsWidth = width
        devMode.dmPelsHeight = height

        Dim result As Integer = ChangeDisplaySettings(devMode, CDS_UPDATEREGISTRY)
        If result = DISP_CHANGE_SUCCESSFUL Then
            MessageBox.Show("Screen resolution changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Failed to change screen resolution.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Function to restore original screen resolution
    Public Sub RestoreOriginalResolution()
        ChangeScreenResolution(originalScreenWidth, originalScreenHeight)
    End Sub

    ' Function to scale form for current screen DPI
    Public Sub ScaleFormForDPI(form As Form)
        SetProcessDPIAware()
        Dim currentScreenWidth As Integer = GetSystemMetrics(SM_CXSCREEN)
        Dim currentScreenHeight As Integer = GetSystemMetrics(SM_CYSCREEN)

        Dim scaleX As Double = currentScreenWidth / originalScreenWidth
        Dim scaleY As Double = currentScreenHeight / originalScreenHeight

        form.Scale(New SizeF(CSng(scaleX), CSng(scaleY)))
        form.Location = New Point(0, 0)
    End Sub
End Module
