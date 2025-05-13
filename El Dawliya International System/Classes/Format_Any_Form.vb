Public Class Format_Any_Form
    Dim MyFont As String = "Cairo"
    'MyFont

    ' Modern UI Properties
    Public Property BackgroundColor As Color = Color.FromArgb(250, 250, 252) ' Light background
    Public Property ForeColor As Color = Color.FromArgb(33, 37, 41) ' Dark text color
    Public Property AccentColor As Color = Color.FromArgb(79, 70, 229) ' Modern indigo
    Public Property DefaultFont As Font = New Font(MyFont, 10, FontStyle.Regular)
    Public Property HeaderFont As Font = New Font(MyFont, 10, FontStyle.Bold)

    ' Control Colors
    Public Property TextBoxBackColor As Color = Color.White
    Public Property TextBoxBorderColor As Color = Color.FromArgb(226, 232, 240)
    Public Property ButtonHoverColor As Color = Color.FromArgb(67, 56, 202) ' Darker indigo
    Public Property ComboBoxBackColor As Color = Color.White
    Public Property ListBoxBackColor As Color = Color.White
    Public Property DataGridViewBackColor As Color = Color.White
    Public Property DataGridViewHeaderColor As Color = Color.FromArgb(243, 244, 246)
    Public Property DataGridViewRowColor As Color = Color.White
    Public Property DataGridViewAlternateRowColor As Color = Color.FromArgb(249, 250, 251)
    Public Property DataGridViewBorderColor As Color = Color.FromArgb(226, 232, 240)

    ' Method to format the form
    Public Sub FormatForm(targetForm As Form)
        ' Form settings
        targetForm.BackColor = BackgroundColor
        targetForm.Font = DefaultFont
        targetForm.StartPosition = FormStartPosition.CenterScreen
        targetForm.FormBorderStyle = FormBorderStyle.FixedDialog
        targetForm.MaximizeBox = True
        AdjustFormSize(targetForm)

        ' Apply styles to all controls
        For Each ctrl As Control In targetForm.Controls
            ApplyStyle(ctrl)
        Next
    End Sub

    ' Method to apply styling based on control type
    Private Sub ApplyStyle(ctrl As Control)
        If TypeOf ctrl Is TextBox Then
            Dim txtBox As TextBox = CType(ctrl, TextBox)
            txtBox.BackColor = TextBoxBackColor
            txtBox.ForeColor = ForeColor
            txtBox.Font = DefaultFont
            txtBox.BorderStyle = BorderStyle.FixedSingle
            AddShadowEffect(txtBox)

        ElseIf TypeOf ctrl Is ComboBox Then
            Dim comboBox As ComboBox = CType(ctrl, ComboBox)
            comboBox.BackColor = ComboBoxBackColor
            comboBox.ForeColor = ForeColor
            comboBox.Font = DefaultFont
            comboBox.FlatStyle = FlatStyle.Flat
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList
            AddShadowEffect(comboBox)

        ElseIf TypeOf ctrl Is ListBox Then
            Dim listBox As ListBox = CType(ctrl, ListBox)
            listBox.BackColor = ListBoxBackColor
            listBox.ForeColor = ForeColor
            listBox.Font = DefaultFont
            listBox.BorderStyle = BorderStyle.None
            AddShadowEffect(listBox)

        ElseIf TypeOf ctrl Is DataGridView Then
            FormatDataGridView(CType(ctrl, DataGridView))

        ElseIf TypeOf ctrl Is Button Then
            FormatButton(CType(ctrl, Button))

        ElseIf TypeOf ctrl Is Label Then
            Dim lbl As Label = CType(ctrl, Label)
            lbl.ForeColor = ForeColor
            lbl.Font = DefaultFont
            lbl.BackColor = Color.Transparent
        End If

        ' Apply styles to child controls
        If ctrl.HasChildren Then
            For Each childCtrl As Control In ctrl.Controls
                ApplyStyle(childCtrl)
            Next
        End If
    End Sub

    ' Enhanced DataGridView formatting
    Private Sub FormatDataGridView(dgv As DataGridView)
        With dgv
            .BackgroundColor = DataGridViewBackColor
            .BorderStyle = BorderStyle.None
            .GridColor = DataGridViewBorderColor
            .CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
            .RowHeadersVisible = False
            .EnableHeadersVisualStyles = False
            .AllowUserToResizeRows = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect

            ' Cell styles
            .DefaultCellStyle.BackColor = DataGridViewRowColor
            .DefaultCellStyle.ForeColor = ForeColor
            .DefaultCellStyle.Font = DefaultFont
            .DefaultCellStyle.SelectionBackColor = AccentColor
            .DefaultCellStyle.SelectionForeColor = Color.White
            .DefaultCellStyle.Padding = New Padding(5)
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

            ' Header styles
            .ColumnHeadersDefaultCellStyle.BackColor = DataGridViewHeaderColor
            .ColumnHeadersDefaultCellStyle.ForeColor = ForeColor
            .ColumnHeadersDefaultCellStyle.Font = HeaderFont
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .ColumnHeadersDefaultCellStyle.Padding = New Padding(5)
            .ColumnHeadersHeight = 40
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None

            ' Alternate row color
            .AlternatingRowsDefaultCellStyle.BackColor = DataGridViewAlternateRowColor
        End With
    End Sub

    ' Enhanced button formatting
    Private Sub FormatButton(btn As Button)
        btn.BackColor = AccentColor
        btn.ForeColor = Color.White
        btn.Font = DefaultFont
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        btn.Cursor = Cursors.Hand
        btn.Padding = New Padding(10, 5, 10, 5)

        ' Add hover effect
        AddHandler btn.MouseEnter, Sub(sender, e)
                                       btn.BackColor = ButtonHoverColor
                                   End Sub
        AddHandler btn.MouseLeave, Sub(sender, e)
                                       btn.BackColor = AccentColor
                                   End Sub
    End Sub

    ' Add shadow effect to controls
    Private Sub AddShadowEffect(ctrl As Control)
        ctrl.BackColor = Color.White
        If TypeOf ctrl Is TextBox Then
            Dim txt As TextBox = DirectCast(ctrl, TextBox)
            txt.BorderStyle = BorderStyle.FixedSingle
        ElseIf TypeOf ctrl Is ComboBox Then
            Dim cmb As ComboBox = DirectCast(ctrl, ComboBox)
            cmb.FlatStyle = FlatStyle.Flat
        End If
    End Sub

    ' Adjust form size to fit screen
    Private Sub AdjustFormSize(targetForm As Form)
        Dim screenWidth As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.WorkingArea.Height

        ' Set maximum size to 90% of screen
        Dim maxWidth As Integer = CInt(screenWidth * 0.9)
        Dim maxHeight As Integer = CInt(screenHeight * 0.9)

        ' Set minimum size
        '«·«”«”Ì…
        'Dim minWidth As Integer = 400
        'Dim minHeight As Integer = 300

        Dim minWidth As Integer = 1465
        Dim minHeight As Integer = 765

        ' Adjust form size
        targetForm.Width = Math.Min(Math.Max(targetForm.Width, minWidth), maxWidth)
        targetForm.Height = Math.Min(Math.Max(targetForm.Height, minHeight), maxHeight)

        ' Center the form
        targetForm.StartPosition = FormStartPosition.CenterScreen
    End Sub
End Class
