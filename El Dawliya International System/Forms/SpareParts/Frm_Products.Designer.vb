<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Products
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ID_PRODUCTlbl = New System.Windows.Forms.Label()
        Me.Product_ID = New System.Windows.Forms.TextBox()
        Me.Product_Namelbl = New System.Windows.Forms.Label()
        Me.Product_Name = New System.Windows.Forms.TextBox()
        Me.QTE_IN_STOCKlbl = New System.Windows.Forms.Label()
        Me.QTE_IN_STOCK = New System.Windows.Forms.TextBox()
        Me.IMAGE_PRODUCTlbl = New System.Windows.Forms.Label()
        Me.ID_CATlbl = New System.Windows.Forms.Label()
        Me.Unitlbl = New System.Windows.Forms.Label()
        Me.Initial_Balancelbl = New System.Windows.Forms.Label()
        Me.Initial_Balance = New System.Windows.Forms.TextBox()
        Me.Minimum_Thresholdlbl = New System.Windows.Forms.Label()
        Me.Minimum_Threshold = New System.Windows.Forms.TextBox()
        Me.Maximum_Thresholdlbl = New System.Windows.Forms.Label()
        Me.Maximum_Threshold = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CAT_ID = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BtnNewAdd = New System.Windows.Forms.ToolStripButton()
        Me.BtnSave = New System.Windows.Forms.ToolStripButton()
        Me.BtnEdit = New System.Windows.Forms.ToolStripButton()
        Me.BtnDelete = New System.Windows.Forms.ToolStripButton()
        Me.Btn_Item_Alert = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Lbl_Count_Product = New System.Windows.Forms.ToolStripLabel()
        Me.dgv_Products = New System.Windows.Forms.DataGridView()
        Me.Location = New System.Windows.Forms.TextBox()
        Me.LocationLbl = New System.Windows.Forms.Label()
        Me.Unit_ID = New System.Windows.Forms.ComboBox()
        Me.Unit_Price = New System.Windows.Forms.TextBox()
        Me.Unit_PriceLbl = New System.Windows.Forms.Label()
        Me.Txt_Search = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Radio_Product_ID = New System.Windows.Forms.RadioButton()
        Me.Radio_Product_Name = New System.Windows.Forms.RadioButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Expiry_Warning = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IMAGE_PRODUCT = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgv_Products, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.IMAGE_PRODUCT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID_PRODUCTlbl
        '
        Me.ID_PRODUCTlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ID_PRODUCTlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.ID_PRODUCTlbl.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_PRODUCTlbl.ForeColor = System.Drawing.Color.Black
        Me.ID_PRODUCTlbl.Location = New System.Drawing.Point(1093, 4)
        Me.ID_PRODUCTlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ID_PRODUCTlbl.Name = "ID_PRODUCTlbl"
        Me.ID_PRODUCTlbl.Size = New System.Drawing.Size(228, 33)
        Me.ID_PRODUCTlbl.TabIndex = 0
        Me.ID_PRODUCTlbl.Text = "كود الصنف"
        Me.ID_PRODUCTlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Product_ID
        '
        Me.Product_ID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Product_ID.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Product_ID.Location = New System.Drawing.Point(787, 3)
        Me.Product_ID.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Product_ID.Name = "Product_ID"
        Me.Product_ID.Size = New System.Drawing.Size(302, 32)
        Me.Product_ID.TabIndex = 1
        Me.Product_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Product_Namelbl
        '
        Me.Product_Namelbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Product_Namelbl.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Product_Namelbl.ForeColor = System.Drawing.Color.Black
        Me.Product_Namelbl.Location = New System.Drawing.Point(576, 4)
        Me.Product_Namelbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Product_Namelbl.Name = "Product_Namelbl"
        Me.Product_Namelbl.Size = New System.Drawing.Size(193, 33)
        Me.Product_Namelbl.TabIndex = 2
        Me.Product_Namelbl.Text = "اسم الصنف"
        Me.Product_Namelbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Product_Name
        '
        Me.Product_Name.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Product_Name.Location = New System.Drawing.Point(275, 3)
        Me.Product_Name.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Product_Name.Name = "Product_Name"
        Me.Product_Name.Size = New System.Drawing.Size(298, 32)
        Me.Product_Name.TabIndex = 2
        Me.Product_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'QTE_IN_STOCKlbl
        '
        Me.QTE_IN_STOCKlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.QTE_IN_STOCKlbl.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QTE_IN_STOCKlbl.ForeColor = System.Drawing.Color.Black
        Me.QTE_IN_STOCKlbl.Location = New System.Drawing.Point(576, 133)
        Me.QTE_IN_STOCKlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.QTE_IN_STOCKlbl.Name = "QTE_IN_STOCKlbl"
        Me.QTE_IN_STOCKlbl.Size = New System.Drawing.Size(193, 33)
        Me.QTE_IN_STOCKlbl.TabIndex = 4
        Me.QTE_IN_STOCKlbl.Text = "الرصيد الحالى"
        Me.QTE_IN_STOCKlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'QTE_IN_STOCK
        '
        Me.QTE_IN_STOCK.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QTE_IN_STOCK.Location = New System.Drawing.Point(274, 134)
        Me.QTE_IN_STOCK.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.QTE_IN_STOCK.Name = "QTE_IN_STOCK"
        Me.QTE_IN_STOCK.Size = New System.Drawing.Size(298, 32)
        Me.QTE_IN_STOCK.TabIndex = 8
        Me.QTE_IN_STOCK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'IMAGE_PRODUCTlbl
        '
        Me.IMAGE_PRODUCTlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.IMAGE_PRODUCTlbl.ForeColor = System.Drawing.Color.Black
        Me.IMAGE_PRODUCTlbl.Location = New System.Drawing.Point(10, 4)
        Me.IMAGE_PRODUCTlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.IMAGE_PRODUCTlbl.Name = "IMAGE_PRODUCTlbl"
        Me.IMAGE_PRODUCTlbl.Size = New System.Drawing.Size(259, 27)
        Me.IMAGE_PRODUCTlbl.TabIndex = 6
        Me.IMAGE_PRODUCTlbl.Text = "صورة الصنف"
        Me.IMAGE_PRODUCTlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ID_CATlbl
        '
        Me.ID_CATlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.ID_CATlbl.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_CATlbl.ForeColor = System.Drawing.Color.Black
        Me.ID_CATlbl.Location = New System.Drawing.Point(576, 47)
        Me.ID_CATlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ID_CATlbl.Name = "ID_CATlbl"
        Me.ID_CATlbl.Size = New System.Drawing.Size(193, 33)
        Me.ID_CATlbl.TabIndex = 8
        Me.ID_CATlbl.Text = "التصنيف"
        Me.ID_CATlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Unitlbl
        '
        Me.Unitlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Unitlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Unitlbl.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Unitlbl.ForeColor = System.Drawing.Color.Black
        Me.Unitlbl.Location = New System.Drawing.Point(1092, 47)
        Me.Unitlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Unitlbl.Name = "Unitlbl"
        Me.Unitlbl.Size = New System.Drawing.Size(228, 33)
        Me.Unitlbl.TabIndex = 10
        Me.Unitlbl.Text = "الوحدة"
        Me.Unitlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Initial_Balancelbl
        '
        Me.Initial_Balancelbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Initial_Balancelbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Initial_Balancelbl.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Initial_Balancelbl.ForeColor = System.Drawing.Color.Black
        Me.Initial_Balancelbl.Location = New System.Drawing.Point(1091, 176)
        Me.Initial_Balancelbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Initial_Balancelbl.Name = "Initial_Balancelbl"
        Me.Initial_Balancelbl.Size = New System.Drawing.Size(229, 33)
        Me.Initial_Balancelbl.TabIndex = 12
        Me.Initial_Balancelbl.Text = "رصيد بداية المدة"
        Me.Initial_Balancelbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Initial_Balance
        '
        Me.Initial_Balance.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Initial_Balance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Initial_Balance.Location = New System.Drawing.Point(786, 177)
        Me.Initial_Balance.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Initial_Balance.Name = "Initial_Balance"
        Me.Initial_Balance.Size = New System.Drawing.Size(301, 32)
        Me.Initial_Balance.TabIndex = 9
        Me.Initial_Balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Minimum_Thresholdlbl
        '
        Me.Minimum_Thresholdlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Minimum_Thresholdlbl.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Minimum_Thresholdlbl.ForeColor = System.Drawing.Color.Black
        Me.Minimum_Thresholdlbl.Location = New System.Drawing.Point(576, 90)
        Me.Minimum_Thresholdlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Minimum_Thresholdlbl.Name = "Minimum_Thresholdlbl"
        Me.Minimum_Thresholdlbl.Size = New System.Drawing.Size(193, 33)
        Me.Minimum_Thresholdlbl.TabIndex = 16
        Me.Minimum_Thresholdlbl.Text = "اقل رصيد"
        Me.Minimum_Thresholdlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Minimum_Threshold
        '
        Me.Minimum_Threshold.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Minimum_Threshold.Location = New System.Drawing.Point(274, 91)
        Me.Minimum_Threshold.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Minimum_Threshold.Name = "Minimum_Threshold"
        Me.Minimum_Threshold.Size = New System.Drawing.Size(298, 32)
        Me.Minimum_Threshold.TabIndex = 6
        Me.Minimum_Threshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Maximum_Thresholdlbl
        '
        Me.Maximum_Thresholdlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Maximum_Thresholdlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Maximum_Thresholdlbl.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Maximum_Thresholdlbl.ForeColor = System.Drawing.Color.Black
        Me.Maximum_Thresholdlbl.Location = New System.Drawing.Point(1092, 90)
        Me.Maximum_Thresholdlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Maximum_Thresholdlbl.Name = "Maximum_Thresholdlbl"
        Me.Maximum_Thresholdlbl.Size = New System.Drawing.Size(228, 33)
        Me.Maximum_Thresholdlbl.TabIndex = 18
        Me.Maximum_Thresholdlbl.Text = "اعلى رصيد"
        Me.Maximum_Thresholdlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Maximum_Threshold
        '
        Me.Maximum_Threshold.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Maximum_Threshold.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Maximum_Threshold.Location = New System.Drawing.Point(786, 91)
        Me.Maximum_Threshold.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Maximum_Threshold.Name = "Maximum_Threshold"
        Me.Maximum_Threshold.Size = New System.Drawing.Size(302, 32)
        Me.Maximum_Threshold.TabIndex = 5
        Me.Maximum_Threshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1332, 47)
        Me.Panel1.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1332, 47)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "اضافة منتج جديد"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CAT_ID
        '
        Me.CAT_ID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CAT_ID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CAT_ID.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CAT_ID.FormattingEnabled = True
        Me.CAT_ID.Location = New System.Drawing.Point(274, 46)
        Me.CAT_ID.Name = "CAT_ID"
        Me.CAT_ID.Size = New System.Drawing.Size(297, 32)
        Me.CAT_ID.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Teal
        Me.Panel2.Controls.Add(Me.ToolStrip1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 364)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1332, 64)
        Me.Panel2.TabIndex = 24
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNewAdd, Me.BtnSave, Me.BtnEdit, Me.BtnDelete, Me.Btn_Item_Alert, Me.ToolStripLabel1, Me.Lbl_Count_Product})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1332, 64)
        Me.ToolStrip1.TabIndex = 19
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnNewAdd
        '
        Me.BtnNewAdd.AutoSize = False
        Me.BtnNewAdd.BackColor = System.Drawing.Color.DodgerBlue
        Me.BtnNewAdd.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNewAdd.ForeColor = System.Drawing.Color.Black
        Me.BtnNewAdd.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Add
        Me.BtnNewAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNewAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnNewAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewAdd.Name = "BtnNewAdd"
        Me.BtnNewAdd.Size = New System.Drawing.Size(120, 84)
        Me.BtnNewAdd.Text = "جديد"
        Me.BtnNewAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNewAdd.ToolTipText = "اضافة صنف جديد"
        '
        'BtnSave
        '
        Me.BtnSave.AutoSize = False
        Me.BtnSave.BackColor = System.Drawing.Color.Green
        Me.BtnSave.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.Black
        Me.BtnSave.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Ok
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(120, 84)
        Me.BtnSave.Text = "حفظ"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSave.ToolTipText = "حفظ الصنف المحدد"
        '
        'BtnEdit
        '
        Me.BtnEdit.AutoSize = False
        Me.BtnEdit.BackColor = System.Drawing.Color.Aquamarine
        Me.BtnEdit.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.Image = Global.El_Dawliya_International_System.My.Resources.Resources.edit_32px
        Me.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(120, 84)
        Me.BtnEdit.Text = "تعديل"
        Me.BtnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEdit.ToolTipText = "تعديل الصنف المحدد"
        '
        'BtnDelete
        '
        Me.BtnDelete.AutoSize = False
        Me.BtnDelete.BackColor = System.Drawing.Color.Red
        Me.BtnDelete.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Remove
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(120, 84)
        Me.BtnDelete.Text = "حذف"
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.ToolTipText = "حذف الصنف المحدد"
        '
        'Btn_Item_Alert
        '
        Me.Btn_Item_Alert.AutoSize = False
        Me.Btn_Item_Alert.BackColor = System.Drawing.Color.Magenta
        Me.Btn_Item_Alert.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Item_Alert.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Notification_64px
        Me.Btn_Item_Alert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Item_Alert.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_Item_Alert.Name = "Btn_Item_Alert"
        Me.Btn_Item_Alert.Size = New System.Drawing.Size(150, 84)
        Me.Btn_Item_Alert.Text = "تنبيه الاصناف"
        Me.Btn_Item_Alert.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Item_Alert.ToolTipText = "تنبيه بالاصناف التى يجب شرائها"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(106, 61)
        Me.ToolStripLabel1.Text = "عدد الاصناف"
        '
        'Lbl_Count_Product
        '
        Me.Lbl_Count_Product.BackColor = System.Drawing.Color.Black
        Me.Lbl_Count_Product.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Count_Product.ForeColor = System.Drawing.Color.White
        Me.Lbl_Count_Product.Name = "Lbl_Count_Product"
        Me.Lbl_Count_Product.Size = New System.Drawing.Size(18, 61)
        Me.Lbl_Count_Product.Text = "."
        '
        'dgv_Products
        '
        Me.dgv_Products.AllowUserToAddRows = False
        Me.dgv_Products.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv_Products.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Products.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Products.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_Products.ColumnHeadersHeight = 60
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Products.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_Products.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Products.EnableHeadersVisualStyles = False
        Me.dgv_Products.Location = New System.Drawing.Point(0, 0)
        Me.dgv_Products.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.dgv_Products.Name = "dgv_Products"
        Me.dgv_Products.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Products.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_Products.RowHeadersVisible = False
        Me.dgv_Products.RowHeadersWidth = 51
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_Products.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_Products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Products.Size = New System.Drawing.Size(1332, 364)
        Me.dgv_Products.TabIndex = 12
        '
        'Location
        '
        Me.Location.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Location.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location.Location = New System.Drawing.Point(786, 134)
        Me.Location.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Location.Name = "Location"
        Me.Location.Size = New System.Drawing.Size(302, 32)
        Me.Location.TabIndex = 7
        Me.Location.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LocationLbl
        '
        Me.LocationLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LocationLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.LocationLbl.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocationLbl.ForeColor = System.Drawing.Color.Black
        Me.LocationLbl.Location = New System.Drawing.Point(1092, 133)
        Me.LocationLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LocationLbl.Name = "LocationLbl"
        Me.LocationLbl.Size = New System.Drawing.Size(228, 33)
        Me.LocationLbl.TabIndex = 18
        Me.LocationLbl.Text = "المكان"
        Me.LocationLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Unit_ID
        '
        Me.Unit_ID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Unit_ID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Unit_ID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Unit_ID.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Unit_ID.FormattingEnabled = True
        Me.Unit_ID.Location = New System.Drawing.Point(787, 46)
        Me.Unit_ID.Name = "Unit_ID"
        Me.Unit_ID.Size = New System.Drawing.Size(302, 32)
        Me.Unit_ID.TabIndex = 3
        '
        'Unit_Price
        '
        Me.Unit_Price.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Unit_Price.Location = New System.Drawing.Point(274, 177)
        Me.Unit_Price.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Unit_Price.Name = "Unit_Price"
        Me.Unit_Price.ReadOnly = True
        Me.Unit_Price.Size = New System.Drawing.Size(299, 32)
        Me.Unit_Price.TabIndex = 10
        Me.Unit_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Unit_PriceLbl
        '
        Me.Unit_PriceLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Unit_PriceLbl.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Unit_PriceLbl.ForeColor = System.Drawing.Color.Black
        Me.Unit_PriceLbl.Location = New System.Drawing.Point(579, 178)
        Me.Unit_PriceLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Unit_PriceLbl.Name = "Unit_PriceLbl"
        Me.Unit_PriceLbl.Size = New System.Drawing.Size(193, 33)
        Me.Unit_PriceLbl.TabIndex = 16
        Me.Unit_PriceLbl.Text = "سعر الوحدة"
        Me.Unit_PriceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Txt_Search
        '
        Me.Txt_Search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_Search.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Search.Location = New System.Drawing.Point(786, 220)
        Me.Txt_Search.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.Txt_Search.Name = "Txt_Search"
        Me.Txt_Search.Size = New System.Drawing.Size(182, 32)
        Me.Txt_Search.TabIndex = 11
        Me.Txt_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(1229, 219)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 36)
        Me.Label3.TabIndex = 138
        Me.Label3.Text = "ابحث هنا"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.AutoSize = True
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.Radio_Product_ID)
        Me.Panel5.Controls.Add(Me.Radio_Product_Name)
        Me.Panel5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.Location = New System.Drawing.Point(976, 220)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(246, 36)
        Me.Panel5.TabIndex = 140
        '
        'Radio_Product_ID
        '
        Me.Radio_Product_ID.BackColor = System.Drawing.Color.Teal
        Me.Radio_Product_ID.Checked = True
        Me.Radio_Product_ID.Font = New System.Drawing.Font("Cairo", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radio_Product_ID.ForeColor = System.Drawing.Color.Black
        Me.Radio_Product_ID.Location = New System.Drawing.Point(115, 2)
        Me.Radio_Product_ID.Name = "Radio_Product_ID"
        Me.Radio_Product_ID.Size = New System.Drawing.Size(99, 27)
        Me.Radio_Product_ID.TabIndex = 104
        Me.Radio_Product_ID.TabStop = True
        Me.Radio_Product_ID.Text = "كود الصنف"
        Me.Radio_Product_ID.UseVisualStyleBackColor = False
        '
        'Radio_Product_Name
        '
        Me.Radio_Product_Name.BackColor = System.Drawing.Color.Teal
        Me.Radio_Product_Name.Font = New System.Drawing.Font("Cairo", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radio_Product_Name.ForeColor = System.Drawing.Color.Black
        Me.Radio_Product_Name.Location = New System.Drawing.Point(5, 2)
        Me.Radio_Product_Name.Name = "Radio_Product_Name"
        Me.Radio_Product_Name.Size = New System.Drawing.Size(101, 27)
        Me.Radio_Product_Name.TabIndex = 105
        Me.Radio_Product_Name.TabStop = True
        Me.Radio_Product_Name.Text = "اسم الصنف"
        Me.Radio_Product_Name.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 314)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1332, 428)
        Me.Panel3.TabIndex = 141
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.dgv_Products)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1332, 364)
        Me.Panel6.TabIndex = 25
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Expiry_Warning)
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Controls.Add(Me.ID_PRODUCTlbl)
        Me.Panel4.Controls.Add(Me.Product_Name)
        Me.Panel4.Controls.Add(Me.Unit_PriceLbl)
        Me.Panel4.Controls.Add(Me.Maximum_Threshold)
        Me.Panel4.Controls.Add(Me.Product_Namelbl)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.Product_ID)
        Me.Panel4.Controls.Add(Me.Initial_Balance)
        Me.Panel4.Controls.Add(Me.Maximum_Thresholdlbl)
        Me.Panel4.Controls.Add(Me.Unit_Price)
        Me.Panel4.Controls.Add(Me.QTE_IN_STOCKlbl)
        Me.Panel4.Controls.Add(Me.Button10)
        Me.Panel4.Controls.Add(Me.Button5)
        Me.Panel4.Controls.Add(Me.Button4)
        Me.Panel4.Controls.Add(Me.QTE_IN_STOCK)
        Me.Panel4.Controls.Add(Me.Initial_Balancelbl)
        Me.Panel4.Controls.Add(Me.Location)
        Me.Panel4.Controls.Add(Me.Minimum_Thresholdlbl)
        Me.Panel4.Controls.Add(Me.IMAGE_PRODUCTlbl)
        Me.Panel4.Controls.Add(Me.Unitlbl)
        Me.Panel4.Controls.Add(Me.Txt_Search)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.CAT_ID)
        Me.Panel4.Controls.Add(Me.ID_CATlbl)
        Me.Panel4.Controls.Add(Me.LocationLbl)
        Me.Panel4.Controls.Add(Me.Minimum_Threshold)
        Me.Panel4.Controls.Add(Me.IMAGE_PRODUCT)
        Me.Panel4.Controls.Add(Me.Unit_ID)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 47)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1332, 267)
        Me.Panel4.TabIndex = 1
        '
        'Expiry_Warning
        '
        Me.Expiry_Warning.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Expiry_Warning.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Expiry_Warning.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Expiry_Warning.FormattingEnabled = True
        Me.Expiry_Warning.Items.AddRange(New Object() {"نعم", "لا"})
        Me.Expiry_Warning.Location = New System.Drawing.Point(276, 218)
        Me.Expiry_Warning.Name = "Expiry_Warning"
        Me.Expiry_Warning.Size = New System.Drawing.Size(297, 32)
        Me.Expiry_Warning.TabIndex = 141
        Me.Expiry_Warning.Text = "نعم"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Blue
        Me.Button1.Image = Global.El_Dawliya_International_System.My.Resources.Resources.add_24px
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(580, 179)
        Me.Button1.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(62, 29)
        Me.Button1.TabIndex = 135
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.AutoSize = True
        Me.Button10.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Button10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.Blue
        Me.Button10.Image = Global.El_Dawliya_International_System.My.Resources.Resources.add_24px
        Me.Button10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button10.Location = New System.Drawing.Point(579, 47)
        Me.Button10.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(62, 30)
        Me.Button10.TabIndex = 134
        Me.Button10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Questv1", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.Location = New System.Drawing.Point(13, 220)
        Me.Button5.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.Button5.Name = "Button5"
        Me.Button5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button5.Size = New System.Drawing.Size(254, 39)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "تحديث الاصناف"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Blue
        Me.Button4.Image = Global.El_Dawliya_International_System.My.Resources.Resources.add_24px
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.Location = New System.Drawing.Point(1096, 47)
        Me.Button4.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(62, 27)
        Me.Button4.TabIndex = 137
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(576, 221)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(193, 33)
        Me.Label2.TabIndex = 110
        Me.Label2.Text = "يظهر فى التنبيهات"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IMAGE_PRODUCT
        '
        Me.IMAGE_PRODUCT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IMAGE_PRODUCT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IMAGE_PRODUCT.ErrorImage = Nothing
        Me.IMAGE_PRODUCT.Image = Global.El_Dawliya_International_System.My.Resources.Resources.icons8_add_image_96
        Me.IMAGE_PRODUCT.InitialImage = Nothing
        Me.IMAGE_PRODUCT.Location = New System.Drawing.Point(13, 36)
        Me.IMAGE_PRODUCT.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.IMAGE_PRODUCT.Name = "IMAGE_PRODUCT"
        Me.IMAGE_PRODUCT.Size = New System.Drawing.Size(256, 173)
        Me.IMAGE_PRODUCT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IMAGE_PRODUCT.TabIndex = 7
        Me.IMAGE_PRODUCT.TabStop = False
        '
        'Frm_Products
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1332, 742)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.MaximizeBox = False
        Me.Name = "Frm_Products"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgv_Products, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.IMAGE_PRODUCT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Product_ID As System.Windows.Forms.TextBox
    Friend WithEvents ID_PRODUCTlbl As System.Windows.Forms.Label
    Friend WithEvents Product_Name As System.Windows.Forms.TextBox
    Friend WithEvents Product_Namelbl As System.Windows.Forms.Label
    Friend WithEvents QTE_IN_STOCK As System.Windows.Forms.TextBox
    Friend WithEvents QTE_IN_STOCKlbl As System.Windows.Forms.Label
    Friend WithEvents IMAGE_PRODUCT As System.Windows.Forms.PictureBox
    Friend WithEvents IMAGE_PRODUCTlbl As System.Windows.Forms.Label
    Friend WithEvents ID_CATlbl As System.Windows.Forms.Label
    Friend WithEvents Unitlbl As System.Windows.Forms.Label
    Friend WithEvents Initial_Balance As System.Windows.Forms.TextBox
    Friend WithEvents Initial_Balancelbl As System.Windows.Forms.Label
    Friend WithEvents Minimum_Threshold As System.Windows.Forms.TextBox
    Friend WithEvents Minimum_Thresholdlbl As System.Windows.Forms.Label
    Friend WithEvents Maximum_Threshold As System.Windows.Forms.TextBox
    Friend WithEvents Maximum_Thresholdlbl As System.Windows.Forms.Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents CAT_ID As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgv_Products As DataGridView
    Friend WithEvents Button10 As Button
    Friend WithEvents Location As TextBox
    Friend WithEvents LocationLbl As Label
    Friend WithEvents Unit_ID As ComboBox
    Friend WithEvents Unit_Price As TextBox
    Friend WithEvents Unit_PriceLbl As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Txt_Search As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Radio_Product_ID As RadioButton
    Friend WithEvents Radio_Product_Name As RadioButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents BtnNewAdd As ToolStripButton
    Friend WithEvents BtnSave As ToolStripButton
    Friend WithEvents BtnEdit As ToolStripButton
    Friend WithEvents BtnDelete As ToolStripButton
    Friend WithEvents Btn_Item_Alert As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents Lbl_Count_Product As ToolStripLabel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Expiry_Warning As ComboBox
    Friend WithEvents Label2 As Label
End Class
