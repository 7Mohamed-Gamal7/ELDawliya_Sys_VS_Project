Module Modul_Font
#Region "Got Foucs & Lost Focus"

    Public Sub controlGotFocus(ByVal sender As Object, ByVal e As EventArgs)
        Dim crl As Control = sender
        crl.BackColor = Color.BurlyWood
    End Sub

    Public Sub controlLostFocus(ByVal sender As Object, ByVal e As EventArgs)
        Dim crl As Control = sender
        crl.BackColor = Color.White
    End Sub

    Public Sub GotFoucs_LostFocus_For_Control_On_Panal(ByVal P As Panel)
        For Each crl As Control In P.Controls
            AddHandler crl.GotFocus, AddressOf controlGotFocus
            AddHandler crl.LostFocus, AddressOf controlLostFocus
        Next
    End Sub

    Public Sub GotFoucs_LostFocus_For_TabControl(ByVal T As TabControl)
        For Each tabPage As TabPage In T.TabPages
            For Each crl As Control In tabPage.Controls
                AddHandler crl.GotFocus, AddressOf controlGotFocus
                AddHandler crl.LostFocus, AddressOf controlLostFocus
            Next
        Next
    End Sub

    Public Sub GotFoucs_LostFocus_For_GroupBox(ByVal G As GroupBox)
        For Each crl As Control In G.Controls
            AddHandler crl.GotFocus, AddressOf controlGotFocus
            AddHandler crl.LostFocus, AddressOf controlLostFocus
        Next
    End Sub

    Public Sub GotFoucs_LostFocus_For_TextBoxes(ByVal form As Form)
        For Each ctrl As Control In form.Controls
            If TypeOf ctrl Is TextBox Then
                AddHandler ctrl.GotFocus, AddressOf controlGotFocus
                AddHandler ctrl.LostFocus, AddressOf controlLostFocus
            End If
        Next
    End Sub
#End Region

    Public Sub ApplyFontToTextBoxesAndLabels(ByVal form As Form)
        Dim myFont As New Font("Cairo", 10)
        For Each ctrl As Control In form.Controls
            If TypeOf ctrl Is TextBox Or TypeOf ctrl Is Label Then
                ctrl.Font = myFont
            End If
        Next
    End Sub

    Public Sub ApplyFontToDateTimePickers(ByVal form As Form)
        Dim dateTimePickerFont As New Font("Cairo", 10)
        For Each ctrl As Control In form.Controls
            If TypeOf ctrl Is DateTimePicker Then
                CType(ctrl, DateTimePicker).Font = dateTimePickerFont
            End If
        Next
    End Sub

End Module
