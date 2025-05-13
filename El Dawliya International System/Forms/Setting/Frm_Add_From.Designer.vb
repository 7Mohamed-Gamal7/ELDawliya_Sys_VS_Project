<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Add_From
    'Inherits MetroFramework.Forms.MetroForm
    Inherits System.Windows.Forms.Form
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgv_Tbl_Frm_Name = New MetroFramework.Controls.MetroGrid()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.Txt_Search = New MetroFramework.Controls.MetroTextBox()
        Me.Frm_Name = New MetroFramework.Controls.MetroTextBox()
        Me.BtnClose = New MetroFramework.Controls.MetroButton()
        Me.BtnDelete = New MetroFramework.Controls.MetroButton()
        Me.BtnEdit = New MetroFramework.Controls.MetroButton()
        Me.BtnSave = New MetroFramework.Controls.MetroButton()
        Me.BtnNewAdd = New MetroFramework.Controls.MetroButton()
        Me.Frm_ID = New MetroFramework.Controls.MetroTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgv_Tbl_Frm_Name, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_Tbl_Frm_Name
        '
        Me.dgv_Tbl_Frm_Name.AllowUserToDeleteRows = False
        Me.dgv_Tbl_Frm_Name.AllowUserToResizeRows = False
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_Tbl_Frm_Name.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.dgv_Tbl_Frm_Name.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_Tbl_Frm_Name.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_Tbl_Frm_Name.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_Tbl_Frm_Name.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgv_Tbl_Frm_Name.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Tbl_Frm_Name.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgv_Tbl_Frm_Name.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle13.Font = New System.Drawing.Font("High Tower Text", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Tbl_Frm_Name.DefaultCellStyle = DataGridViewCellStyle13
        Me.dgv_Tbl_Frm_Name.EnableHeadersVisualStyles = False
        Me.dgv_Tbl_Frm_Name.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgv_Tbl_Frm_Name.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgv_Tbl_Frm_Name.Location = New System.Drawing.Point(4, 123)
        Me.dgv_Tbl_Frm_Name.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgv_Tbl_Frm_Name.Name = "dgv_Tbl_Frm_Name"
        Me.dgv_Tbl_Frm_Name.ReadOnly = True
        Me.dgv_Tbl_Frm_Name.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Tbl_Frm_Name.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dgv_Tbl_Frm_Name.RowHeadersVisible = False
        Me.dgv_Tbl_Frm_Name.RowHeadersWidth = 51
        Me.dgv_Tbl_Frm_Name.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_Tbl_Frm_Name.RowsDefaultCellStyle = DataGridViewCellStyle15
        Me.dgv_Tbl_Frm_Name.RowTemplate.Height = 26
        Me.dgv_Tbl_Frm_Name.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Tbl_Frm_Name.Size = New System.Drawing.Size(741, 300)
        Me.dgv_Tbl_Frm_Name.Style = MetroFramework.MetroColorStyle.Orange
        Me.dgv_Tbl_Frm_Name.TabIndex = 3
        Me.dgv_Tbl_Frm_Name.UseCustomBackColor = True
        Me.dgv_Tbl_Frm_Name.UseCustomForeColor = True
        Me.dgv_Tbl_Frm_Name.UseStyleColors = True
        '
        'MetroPanel1
        '
        Me.MetroPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MetroPanel1.Controls.Add(Me.Txt_Search)
        Me.MetroPanel1.Controls.Add(Me.Frm_Name)
        Me.MetroPanel1.Controls.Add(Me.dgv_Tbl_Frm_Name)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 17
        Me.MetroPanel1.Location = New System.Drawing.Point(6, 75)
        Me.MetroPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(749, 428)
        Me.MetroPanel1.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroPanel1.TabIndex = 3
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 14
        '
        'Txt_Search
        '
        Me.Txt_Search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_Search.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        '
        '
        Me.Txt_Search.CustomButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Txt_Search.CustomButton.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Search.CustomButton.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Binoculars1
        Me.Txt_Search.CustomButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Txt_Search.CustomButton.Location = New System.Drawing.Point(669, 2)
        Me.Txt_Search.CustomButton.Name = ""
        Me.Txt_Search.CustomButton.Size = New System.Drawing.Size(45, 45)
        Me.Txt_Search.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Txt_Search.CustomButton.TabIndex = 1
        Me.Txt_Search.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Txt_Search.CustomButton.UseSelectable = True
        Me.Txt_Search.CustomButton.UseVisualStyleBackColor = False
        Me.Txt_Search.CustomButton.Visible = False
        Me.Txt_Search.DisplayIcon = True
        Me.Txt_Search.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.Txt_Search.Icon = Global.El_Dawliya_International_System.My.Resources.Resources.Search_More
        Me.Txt_Search.Lines = New String(-1) {}
        Me.Txt_Search.Location = New System.Drawing.Point(19, 65)
        Me.Txt_Search.MaxLength = 32767
        Me.Txt_Search.Multiline = True
        Me.Txt_Search.Name = "Txt_Search"
        Me.Txt_Search.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Txt_Search.PromptText = "ابحث هنا"
        Me.Txt_Search.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Txt_Search.SelectedText = ""
        Me.Txt_Search.SelectionLength = 0
        Me.Txt_Search.SelectionStart = 0
        Me.Txt_Search.ShortcutsEnabled = True
        Me.Txt_Search.Size = New System.Drawing.Size(717, 50)
        Me.Txt_Search.Style = MetroFramework.MetroColorStyle.Green
        Me.Txt_Search.TabIndex = 3
        Me.Txt_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Txt_Search.UseSelectable = True
        Me.Txt_Search.WaterMark = "ابحث هنا"
        Me.Txt_Search.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Txt_Search.WaterMarkFont = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Frm_Name
        '
        Me.Frm_Name.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.Frm_Name.CustomButton.BackgroundImage = Global.El_Dawliya_International_System.My.Resources.Resources.Ok
        Me.Frm_Name.CustomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Frm_Name.CustomButton.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frm_Name.CustomButton.Image = Nothing
        Me.Frm_Name.CustomButton.Location = New System.Drawing.Point(669, 2)
        Me.Frm_Name.CustomButton.Name = ""
        Me.Frm_Name.CustomButton.Size = New System.Drawing.Size(45, 45)
        Me.Frm_Name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Frm_Name.CustomButton.TabIndex = 1
        Me.Frm_Name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Frm_Name.CustomButton.UseSelectable = True
        Me.Frm_Name.CustomButton.Visible = False
        Me.Frm_Name.DisplayIcon = True
        Me.Frm_Name.FontSize = MetroFramework.MetroTextBoxSize.Tall
        Me.Frm_Name.FontWeight = MetroFramework.MetroTextBoxWeight.Bold
        Me.Frm_Name.Lines = New String(-1) {}
        Me.Frm_Name.Location = New System.Drawing.Point(19, 9)
        Me.Frm_Name.MaxLength = 32767
        Me.Frm_Name.Multiline = True
        Me.Frm_Name.Name = "Frm_Name"
        Me.Frm_Name.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Frm_Name.PromptText = "اكتب اسم الشاشة هنا"
        Me.Frm_Name.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Frm_Name.SelectedText = ""
        Me.Frm_Name.SelectionLength = 0
        Me.Frm_Name.SelectionStart = 0
        Me.Frm_Name.ShortcutsEnabled = True
        Me.Frm_Name.Size = New System.Drawing.Size(717, 50)
        Me.Frm_Name.Style = MetroFramework.MetroColorStyle.Orange
        Me.Frm_Name.TabIndex = 3
        Me.Frm_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Frm_Name.UseSelectable = True
        Me.Frm_Name.WaterMark = "اكتب اسم الشاشة هنا"
        Me.Frm_Name.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Frm_Name.WaterMarkFont = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BtnClose
        '
        Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClose.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnClose.BackgroundImage = Global.El_Dawliya_International_System.My.Resources.Resources.Cancel
        Me.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnClose.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.BtnClose.Highlight = True
        Me.BtnClose.Location = New System.Drawing.Point(3, 0)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(89, 45)
        Me.BtnClose.Style = MetroFramework.MetroColorStyle.Brown
        Me.BtnClose.TabIndex = 4
        Me.BtnClose.Text = "اغلاق"
        Me.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnClose.UseSelectable = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDelete.BackColor = System.Drawing.Color.Red
        Me.BtnDelete.BackgroundImage = Global.El_Dawliya_International_System.My.Resources.Resources.Remove
        Me.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnDelete.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.BtnDelete.Highlight = True
        Me.BtnDelete.Location = New System.Drawing.Point(155, 0)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(89, 45)
        Me.BtnDelete.Style = MetroFramework.MetroColorStyle.Brown
        Me.BtnDelete.TabIndex = 4
        Me.BtnDelete.Text = "حذف"
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.UseSelectable = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEdit.BackColor = System.Drawing.SystemColors.Menu
        Me.BtnEdit.BackgroundImage = Global.El_Dawliya_International_System.My.Resources.Resources.Refresh1
        Me.BtnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnEdit.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.BtnEdit.Highlight = True
        Me.BtnEdit.Location = New System.Drawing.Point(307, 0)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(89, 45)
        Me.BtnEdit.Style = MetroFramework.MetroColorStyle.Brown
        Me.BtnEdit.TabIndex = 4
        Me.BtnEdit.Text = "تعديل"
        Me.BtnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEdit.UseSelectable = True
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnSave.BackgroundImage = Global.El_Dawliya_International_System.My.Resources.Resources.Save
        Me.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnSave.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.BtnSave.Highlight = True
        Me.BtnSave.Location = New System.Drawing.Point(459, 0)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(89, 45)
        Me.BtnSave.Style = MetroFramework.MetroColorStyle.Brown
        Me.BtnSave.TabIndex = 4
        Me.BtnSave.Text = "حفظ"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.UseSelectable = True
        '
        'BtnNewAdd
        '
        Me.BtnNewAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNewAdd.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnNewAdd.BackgroundImage = Global.El_Dawliya_International_System.My.Resources.Resources.Add
        Me.BtnNewAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnNewAdd.FontSize = MetroFramework.MetroButtonSize.Tall
        Me.BtnNewAdd.Highlight = True
        Me.BtnNewAdd.Location = New System.Drawing.Point(611, 0)
        Me.BtnNewAdd.Name = "BtnNewAdd"
        Me.BtnNewAdd.Size = New System.Drawing.Size(89, 45)
        Me.BtnNewAdd.Style = MetroFramework.MetroColorStyle.Brown
        Me.BtnNewAdd.TabIndex = 4
        Me.BtnNewAdd.Text = "جديد"
        Me.BtnNewAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNewAdd.UseSelectable = True
        '
        'Frm_ID
        '
        Me.Frm_ID.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        '
        '
        '
        Me.Frm_ID.CustomButton.Image = Nothing
        Me.Frm_ID.CustomButton.Location = New System.Drawing.Point(699, 1)
        Me.Frm_ID.CustomButton.Name = ""
        Me.Frm_ID.CustomButton.Size = New System.Drawing.Size(49, 49)
        Me.Frm_ID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.Frm_ID.CustomButton.TabIndex = 1
        Me.Frm_ID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.Frm_ID.CustomButton.UseSelectable = True
        Me.Frm_ID.CustomButton.Visible = False
        Me.Frm_ID.Enabled = False
        Me.Frm_ID.Lines = New String(-1) {}
        Me.Frm_ID.Location = New System.Drawing.Point(0, 0)
        Me.Frm_ID.MaxLength = 32767
        Me.Frm_ID.Multiline = True
        Me.Frm_ID.Name = "Frm_ID"
        Me.Frm_ID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Frm_ID.PromptText = "اضافة شاشة جديدة"
        Me.Frm_ID.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Frm_ID.SelectedText = ""
        Me.Frm_ID.SelectionLength = 0
        Me.Frm_ID.SelectionStart = 0
        Me.Frm_ID.ShortcutsEnabled = True
        Me.Frm_ID.Size = New System.Drawing.Size(31, 51)
        Me.Frm_ID.Style = MetroFramework.MetroColorStyle.Orange
        Me.Frm_ID.TabIndex = 3
        Me.Frm_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Frm_ID.UseCustomBackColor = True
        Me.Frm_ID.UseCustomForeColor = True
        Me.Frm_ID.UseSelectable = True
        Me.Frm_ID.UseStyleColors = True
        Me.Frm_ID.WaterMark = "اضافة شاشة جديدة"
        Me.Frm_ID.WaterMarkColor = System.Drawing.Color.Black
        Me.Frm_ID.WaterMarkFont = New System.Drawing.Font("Cairo", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnClose)
        Me.Panel1.Controls.Add(Me.BtnNewAdd)
        Me.Panel1.Controls.Add(Me.BtnDelete)
        Me.Panel1.Controls.Add(Me.BtnSave)
        Me.Panel1.Controls.Add(Me.BtnEdit)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(29, 511)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(707, 51)
        Me.Panel1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Frm_ID)
        Me.Panel2.Location = New System.Drawing.Point(6, 16)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(749, 51)
        Me.Panel2.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(749, 51)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "اضافة شاشة جديدة"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Frm_Add_From
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.El_Dawliya_International_System.My.Resources.Resources.Binoculars
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(765, 596)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "Frm_Add_From"
        Me.Padding = New System.Windows.Forms.Padding(29, 101, 29, 34)
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.Text = "اضافة شاشة جديدة"
        CType(Me.dgv_Tbl_Frm_Name, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgv_Tbl_Frm_Name As MetroFramework.Controls.MetroGrid
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents Frm_Name As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Txt_Search As MetroFramework.Controls.MetroTextBox
    Friend WithEvents Frm_ID As MetroFramework.Controls.MetroTextBox
    Friend WithEvents BtnNewAdd As MetroFramework.Controls.MetroButton
    Friend WithEvents BtnDelete As MetroFramework.Controls.MetroButton
    Friend WithEvents BtnEdit As MetroFramework.Controls.MetroButton
    Friend WithEvents BtnSave As MetroFramework.Controls.MetroButton
    Friend WithEvents BtnClose As MetroFramework.Controls.MetroButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
End Class
