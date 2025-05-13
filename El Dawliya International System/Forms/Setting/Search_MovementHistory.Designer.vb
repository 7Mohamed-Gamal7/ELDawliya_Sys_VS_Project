<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Search_MovementHistory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MovementIDlbl = New System.Windows.Forms.Label()
        Me.MovementID = New System.Windows.Forms.TextBox()
        Me.MovementDescriptionlbl = New System.Windows.Forms.Label()
        Me.MovementDescription = New System.Windows.Forms.TextBox()
        Me.MovementDatelbl = New System.Windows.Forms.Label()
        Me.MovementDate = New System.Windows.Forms.DateTimePicker()
        Me.PerformedBylbl = New System.Windows.Forms.Label()
        Me.PerformedBy = New System.Windows.Forms.TextBox()
        Me.DeviceNamelbl = New System.Windows.Forms.Label()
        Me.DeviceName = New System.Windows.Forms.TextBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgv_MovementHistory = New ADGV.AdvancedDataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Txt_Search = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Radio_Btn = New System.Windows.Forms.RadioButton()
        Me.Radio_Frm_Name = New System.Windows.Forms.RadioButton()
        Me.Radio_PerformedBy = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTNlbl = New System.Windows.Forms.Label()
        Me.Frm_NameLbl = New System.Windows.Forms.Label()
        Me.BTN = New System.Windows.Forms.TextBox()
        Me.Frm_Name = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgv_MovementHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MovementIDlbl
        '
        Me.MovementIDlbl.Location = New System.Drawing.Point(1032, 9)
        Me.MovementIDlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MovementIDlbl.Name = "MovementIDlbl"
        Me.MovementIDlbl.Size = New System.Drawing.Size(129, 24)
        Me.MovementIDlbl.TabIndex = 0
        Me.MovementIDlbl.Text = "MovementID"
        Me.MovementIDlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MovementIDlbl.Visible = False
        '
        'MovementID
        '
        Me.MovementID.Location = New System.Drawing.Point(978, 9)
        Me.MovementID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MovementID.Name = "MovementID"
        Me.MovementID.Size = New System.Drawing.Size(50, 32)
        Me.MovementID.TabIndex = 1
        Me.MovementID.Visible = False
        '
        'MovementDescriptionlbl
        '
        Me.MovementDescriptionlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MovementDescriptionlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MovementDescriptionlbl.Location = New System.Drawing.Point(1004, 6)
        Me.MovementDescriptionlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MovementDescriptionlbl.Name = "MovementDescriptionlbl"
        Me.MovementDescriptionlbl.Size = New System.Drawing.Size(156, 27)
        Me.MovementDescriptionlbl.TabIndex = 2
        Me.MovementDescriptionlbl.Text = "الوصف"
        Me.MovementDescriptionlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MovementDescription
        '
        Me.MovementDescription.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MovementDescription.Location = New System.Drawing.Point(35, 4)
        Me.MovementDescription.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MovementDescription.Name = "MovementDescription"
        Me.MovementDescription.ReadOnly = True
        Me.MovementDescription.Size = New System.Drawing.Size(961, 32)
        Me.MovementDescription.TabIndex = 3
        Me.MovementDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MovementDatelbl
        '
        Me.MovementDatelbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MovementDatelbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MovementDatelbl.Location = New System.Drawing.Point(1004, 53)
        Me.MovementDatelbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.MovementDatelbl.Name = "MovementDatelbl"
        Me.MovementDatelbl.Size = New System.Drawing.Size(156, 32)
        Me.MovementDatelbl.TabIndex = 4
        Me.MovementDatelbl.Text = "تاريخ الحركة"
        Me.MovementDatelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MovementDate
        '
        Me.MovementDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MovementDate.Enabled = False
        Me.MovementDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.MovementDate.Location = New System.Drawing.Point(745, 53)
        Me.MovementDate.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MovementDate.Name = "MovementDate"
        Me.MovementDate.Size = New System.Drawing.Size(251, 32)
        Me.MovementDate.TabIndex = 5
        '
        'PerformedBylbl
        '
        Me.PerformedBylbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PerformedBylbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PerformedBylbl.Location = New System.Drawing.Point(1004, 112)
        Me.PerformedBylbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.PerformedBylbl.Name = "PerformedBylbl"
        Me.PerformedBylbl.Size = New System.Drawing.Size(156, 27)
        Me.PerformedBylbl.TabIndex = 6
        Me.PerformedBylbl.Text = "بواسطة"
        Me.PerformedBylbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PerformedBy
        '
        Me.PerformedBy.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PerformedBy.Location = New System.Drawing.Point(745, 112)
        Me.PerformedBy.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PerformedBy.Name = "PerformedBy"
        Me.PerformedBy.ReadOnly = True
        Me.PerformedBy.Size = New System.Drawing.Size(251, 32)
        Me.PerformedBy.TabIndex = 7
        Me.PerformedBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DeviceNamelbl
        '
        Me.DeviceNamelbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DeviceNamelbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DeviceNamelbl.Location = New System.Drawing.Point(1004, 161)
        Me.DeviceNamelbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DeviceNamelbl.Name = "DeviceNamelbl"
        Me.DeviceNamelbl.Size = New System.Drawing.Size(156, 27)
        Me.DeviceNamelbl.TabIndex = 8
        Me.DeviceNamelbl.Text = "اسم الجهاز"
        Me.DeviceNamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DeviceName
        '
        Me.DeviceName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DeviceName.Location = New System.Drawing.Point(745, 161)
        Me.DeviceName.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.DeviceName.Name = "DeviceName"
        Me.DeviceName.ReadOnly = True
        Me.DeviceName.Size = New System.Drawing.Size(251, 32)
        Me.DeviceName.TabIndex = 9
        Me.DeviceName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnClose
        '
        Me.BtnClose.Font = New System.Drawing.Font("Questv1", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Cancel
        Me.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnClose.Location = New System.Drawing.Point(804, 6)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(148, 50)
        Me.BtnClose.TabIndex = 11
        Me.BtnClose.Text = "انهاء"
        Me.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.MovementIDlbl)
        Me.Panel1.Controls.Add(Me.MovementID)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1172, 67)
        Me.Panel1.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Questv1", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1172, 67)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "شاشة البحث عن تعديلات النظام"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button12)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.BtnClose)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 716)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1172, 68)
        Me.Panel2.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Questv1", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Refresh1
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(195, 6)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 50)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "تحديث"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgv_MovementHistory
        '
        Me.dgv_MovementHistory.AllowUserToAddRows = False
        Me.dgv_MovementHistory.AllowUserToDeleteRows = False
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_MovementHistory.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle21
        Me.dgv_MovementHistory.AutoGenerateContextFilters = True
        Me.dgv_MovementHistory.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle22.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_MovementHistory.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle22
        Me.dgv_MovementHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_MovementHistory.DateWithTime = False
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle23.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle23.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_MovementHistory.DefaultCellStyle = DataGridViewCellStyle23
        Me.dgv_MovementHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_MovementHistory.Location = New System.Drawing.Point(0, 0)
        Me.dgv_MovementHistory.Name = "dgv_MovementHistory"
        Me.dgv_MovementHistory.ReadOnly = True
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle24.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_MovementHistory.RowHeadersDefaultCellStyle = DataGridViewCellStyle24
        Me.dgv_MovementHistory.RowHeadersVisible = False
        Me.dgv_MovementHistory.RowHeadersWidth = 51
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_MovementHistory.RowsDefaultCellStyle = DataGridViewCellStyle25
        Me.dgv_MovementHistory.RowTemplate.Height = 26
        Me.dgv_MovementHistory.Size = New System.Drawing.Size(1172, 456)
        Me.dgv_MovementHistory.TabIndex = 149
        Me.dgv_MovementHistory.TimeFilter = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 67)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1172, 649)
        Me.Panel3.TabIndex = 150
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Controls.Add(Me.BTNlbl)
        Me.Panel5.Controls.Add(Me.Frm_NameLbl)
        Me.Panel5.Controls.Add(Me.BTN)
        Me.Panel5.Controls.Add(Me.DeviceNamelbl)
        Me.Panel5.Controls.Add(Me.Frm_Name)
        Me.Panel5.Controls.Add(Me.MovementDate)
        Me.Panel5.Controls.Add(Me.DeviceName)
        Me.Panel5.Controls.Add(Me.PerformedBylbl)
        Me.Panel5.Controls.Add(Me.MovementDescription)
        Me.Panel5.Controls.Add(Me.MovementDescriptionlbl)
        Me.Panel5.Controls.Add(Me.MovementDatelbl)
        Me.Panel5.Controls.Add(Me.PerformedBy)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1172, 193)
        Me.Panel5.TabIndex = 151
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Txt_Search)
        Me.Panel6.Controls.Add(Me.GroupBox1)
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Location = New System.Drawing.Point(11, 39)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(286, 151)
        Me.Panel6.TabIndex = 10
        '
        'Txt_Search
        '
        Me.Txt_Search.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Txt_Search.Location = New System.Drawing.Point(0, 119)
        Me.Txt_Search.Name = "Txt_Search"
        Me.Txt_Search.Size = New System.Drawing.Size(286, 32)
        Me.Txt_Search.TabIndex = 149
        Me.Txt_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Radio_Btn)
        Me.GroupBox1.Controls.Add(Me.Radio_Frm_Name)
        Me.GroupBox1.Controls.Add(Me.Radio_PerformedBy)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(280, 86)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'Radio_Btn
        '
        Me.Radio_Btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Radio_Btn.BackColor = System.Drawing.Color.Teal
        Me.Radio_Btn.Font = New System.Drawing.Font("Cairo Black", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radio_Btn.ForeColor = System.Drawing.Color.Black
        Me.Radio_Btn.Location = New System.Drawing.Point(6, 18)
        Me.Radio_Btn.Name = "Radio_Btn"
        Me.Radio_Btn.Size = New System.Drawing.Size(127, 31)
        Me.Radio_Btn.TabIndex = 105
        Me.Radio_Btn.Text = "الزر"
        Me.Radio_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Radio_Btn.UseVisualStyleBackColor = False
        '
        'Radio_Frm_Name
        '
        Me.Radio_Frm_Name.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Radio_Frm_Name.BackColor = System.Drawing.Color.Teal
        Me.Radio_Frm_Name.Font = New System.Drawing.Font("Cairo Black", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radio_Frm_Name.ForeColor = System.Drawing.Color.Black
        Me.Radio_Frm_Name.Location = New System.Drawing.Point(151, 55)
        Me.Radio_Frm_Name.Name = "Radio_Frm_Name"
        Me.Radio_Frm_Name.Size = New System.Drawing.Size(123, 25)
        Me.Radio_Frm_Name.TabIndex = 105
        Me.Radio_Frm_Name.Text = "الشاشة"
        Me.Radio_Frm_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Radio_Frm_Name.UseVisualStyleBackColor = False
        '
        'Radio_PerformedBy
        '
        Me.Radio_PerformedBy.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Radio_PerformedBy.BackColor = System.Drawing.Color.Teal
        Me.Radio_PerformedBy.Checked = True
        Me.Radio_PerformedBy.Font = New System.Drawing.Font("Cairo Black", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radio_PerformedBy.ForeColor = System.Drawing.Color.Black
        Me.Radio_PerformedBy.Location = New System.Drawing.Point(151, 18)
        Me.Radio_PerformedBy.Name = "Radio_PerformedBy"
        Me.Radio_PerformedBy.Size = New System.Drawing.Size(123, 31)
        Me.Radio_PerformedBy.TabIndex = 105
        Me.Radio_PerformedBy.TabStop = True
        Me.Radio_PerformedBy.Text = "بواسطة"
        Me.Radio_PerformedBy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Radio_PerformedBy.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(286, 27)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "ابحث هنا"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BTNlbl
        '
        Me.BTNlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BTNlbl.Location = New System.Drawing.Point(585, 112)
        Me.BTNlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BTNlbl.Name = "BTNlbl"
        Me.BTNlbl.Size = New System.Drawing.Size(156, 27)
        Me.BTNlbl.TabIndex = 8
        Me.BTNlbl.Text = "اسم الزر"
        Me.BTNlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Frm_NameLbl
        '
        Me.Frm_NameLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Frm_NameLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Frm_NameLbl.Location = New System.Drawing.Point(585, 53)
        Me.Frm_NameLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Frm_NameLbl.Name = "Frm_NameLbl"
        Me.Frm_NameLbl.Size = New System.Drawing.Size(156, 27)
        Me.Frm_NameLbl.TabIndex = 8
        Me.Frm_NameLbl.Text = "اسم الشاشة"
        Me.Frm_NameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BTN
        '
        Me.BTN.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTN.Location = New System.Drawing.Point(326, 112)
        Me.BTN.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BTN.Name = "BTN"
        Me.BTN.ReadOnly = True
        Me.BTN.Size = New System.Drawing.Size(251, 32)
        Me.BTN.TabIndex = 9
        Me.BTN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Frm_Name
        '
        Me.Frm_Name.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Frm_Name.Location = New System.Drawing.Point(326, 53)
        Me.Frm_Name.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Frm_Name.Name = "Frm_Name"
        Me.Frm_Name.ReadOnly = True
        Me.Frm_Name.Size = New System.Drawing.Size(251, 32)
        Me.Frm_Name.TabIndex = 9
        Me.Frm_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.dgv_MovementHistory)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 193)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1172, 456)
        Me.Panel4.TabIndex = 150
        '
        'Button12
        '
        Me.Button12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button12.FlatAppearance.BorderSize = 0
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button12.Font = New System.Drawing.Font("Hacen Saudi Arabia", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Microsoft_Excel_96px
        Me.Button12.Location = New System.Drawing.Point(504, 9)
        Me.Button12.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(139, 47)
        Me.Button12.TabIndex = 127
        Me.Button12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Search_MovementHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1172, 784)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Search_MovementHistory"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgv_MovementHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MovementID As System.Windows.Forms.TextBox
    Friend WithEvents MovementIDlbl As System.Windows.Forms.Label
    Friend WithEvents MovementDescription As System.Windows.Forms.TextBox
    Friend WithEvents MovementDescriptionlbl As System.Windows.Forms.Label
    Friend WithEvents MovementDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents MovementDatelbl As System.Windows.Forms.Label
    Friend WithEvents PerformedBy As System.Windows.Forms.TextBox
    Friend WithEvents PerformedBylbl As System.Windows.Forms.Label
    Friend WithEvents DeviceName As System.Windows.Forms.TextBox
    Friend WithEvents DeviceNamelbl As System.Windows.Forms.Label
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgv_MovementHistory As ADGV.AdvancedDataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BTNlbl As Label
    Friend WithEvents Frm_NameLbl As Label
    Friend WithEvents BTN As TextBox
    Friend WithEvents Frm_Name As TextBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Radio_PerformedBy As RadioButton
    Friend WithEvents Radio_Btn As RadioButton
    Friend WithEvents Radio_Frm_Name As RadioButton
    Friend WithEvents Txt_Search As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Button12 As Button
End Class
