Public Class CustomComboBox
    Inherits UserControl

    'Private WithEvents txtBox As New TextBox
    '    Private WithEvents btnDropDown As New Button
    '    Private WithEvents lstBox As New ListBox

    '    Public Sub New()
    '        ' إعداد المكونات
    '        txtBox.Dock = DockStyle.Top
    '        txtBox.ReadOnly = True
    '        txtBox.BackColor = Color.White

    '        btnDropDown.Dock = DockStyle.Right
    '        btnDropDown.Text = "▼"
    '        btnDropDown.Width = 30

    '        lstBox.Dock = DockStyle.Bottom
    '        lstBox.Visible = False
    '        lstBox.Height = 100

    '        ' إضافة المكونات إلى الـ UserControl
    '        Me.Controls.Add(txtBox)
    '        Me.Controls.Add(btnDropDown)
    '        Me.Controls.Add(lstBox)
    '        Me.Height = 50 ' التحكم في الارتفاع

    '        ' إضافة عناصر
    '        lstBox.Items.AddRange(New String() {"عنصر 1", "عنصر 2", "عنصر 3"})
    '    End Sub

    '    ' عرض وإخفاء القائمة
    '    Private Sub btnDropDown_Click(sender As Object, e As EventArgs) Handles btnDropDown.Click
    '        lstBox.Visible = Not lstBox.Visible
    '    End Sub

    '    ' تحديد عنصر من القائمة
    '    Private Sub lstBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBox.SelectedIndexChanged
    '        If lstBox.SelectedIndex >= 0 Then
    '            txtBox.Text = lstBox.SelectedItem.ToString()
    '            lstBox.Visible = False
    '        End If
    '    End Sub

    Private WithEvents txtBox As New TextBox
    Private WithEvents btnDropDown As New Button
    Private WithEvents lstBox As New ListBox

    Private _dataSource As IEnumerable
    Private _displayMember As String
    Private _valueMember As String
    Private _selectedValue As Object

    Public Sub New()
        ' إعداد المكونات
        txtBox.Dock = DockStyle.Top
        txtBox.ReadOnly = True
        txtBox.BackColor = Color.White

        btnDropDown.Dock = DockStyle.Right
        btnDropDown.Text = "▼"
        btnDropDown.Width = 30

        lstBox.Dock = DockStyle.Bottom
        lstBox.Visible = False
        lstBox.Height = 100

        ' إضافة المكونات إلى الـ UserControl
        Me.Controls.Add(txtBox)
        Me.Controls.Add(btnDropDown)
        Me.Controls.Add(lstBox)
        Me.Height = 50 ' التحكم في الارتفاع
    End Sub

    ' الخصائص المضافة
    Public Property DataSource As IEnumerable
        Get
            Return _dataSource
        End Get
        Set(value As IEnumerable)
            _dataSource = value
            BindData()
        End Set
    End Property

    Public Property DisplayMember As String
        Get
            Return _displayMember
        End Get
        Set(value As String)
            _displayMember = value
            BindData()
        End Set
    End Property

    Public Property ValueMember As String
        Get
            Return _valueMember
        End Get
        Set(value As String)
            _valueMember = value
        End Set
    End Property

    Public ReadOnly Property SelectedValue As Object
        Get
            Return _selectedValue
        End Get
    End Property

    ' الربط مع البيانات
    Private Sub BindData()
        lstBox.Items.Clear()
        If _dataSource IsNot Nothing AndAlso Not String.IsNullOrEmpty(_displayMember) Then
            For Each item In _dataSource
                Dim prop = item.GetType().GetProperty(_displayMember)
                If prop IsNot Nothing Then
                    lstBox.Items.Add(New With {.Display = prop.GetValue(item), .Value = item.GetType().GetProperty(_valueMember)?.GetValue(item)})
                End If
            Next
        End If
    End Sub

    ' عرض وإخفاء القائمة
    Private Sub btnDropDown_Click(sender As Object, e As EventArgs) Handles btnDropDown.Click
        lstBox.Visible = Not lstBox.Visible
    End Sub

    ' تحديد العنصر
    Private Sub lstBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBox.SelectedIndexChanged
        If lstBox.SelectedIndex >= 0 Then
            Dim selectedItem = lstBox.SelectedItem
            txtBox.Text = selectedItem.Display
            _selectedValue = selectedItem.Value
            lstBox.Visible = False
        End If
    End Sub

End Class


