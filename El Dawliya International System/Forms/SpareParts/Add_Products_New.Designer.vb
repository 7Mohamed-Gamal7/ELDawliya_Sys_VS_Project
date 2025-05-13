<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Add_Products_New
    Inherits BaseForm
    'Inherits System.Windows.Forms.Form

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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgv_Products = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Btn_Item_Alert = New System.Windows.Forms.Button()
        Me.BtnNewAdd = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Lbl_Count_Product = New System.Windows.Forms.Label()
        Me.IMAGE_PRODUCT = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Radio_Product_ID = New System.Windows.Forms.RadioButton()
        Me.Radio_Product_Name = New System.Windows.Forms.RadioButton()
        Me.Txt_Search = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ID_CATlbl = New System.Windows.Forms.Label()
        Me.Minimum_Thresholdlbl = New System.Windows.Forms.Label()
        Me.Maximum_Thresholdlbl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LocationLbl = New System.Windows.Forms.Label()
        Me.Unit_PriceLbl = New System.Windows.Forms.Label()
        Me.CAT_ID = New System.Windows.Forms.ComboBox()
        Me.Minimum_Threshold = New System.Windows.Forms.TextBox()
        Me.Maximum_Threshold = New System.Windows.Forms.TextBox()
        Me.Expiry_Warning = New System.Windows.Forms.ComboBox()
        Me.Location = New System.Windows.Forms.TextBox()
        Me.Unit_Price = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ID_PRODUCTlbl = New System.Windows.Forms.Label()
        Me.Product_Namelbl = New System.Windows.Forms.Label()
        Me.Initial_Balancelbl = New System.Windows.Forms.Label()
        Me.Unitlbl = New System.Windows.Forms.Label()
        Me.QTE_IN_STOCKlbl = New System.Windows.Forms.Label()
        Me.Product_ID = New System.Windows.Forms.TextBox()
        Me.Product_Name = New System.Windows.Forms.TextBox()
        Me.Initial_Balance = New System.Windows.Forms.TextBox()
        Me.Unit_ID = New System.Windows.Forms.ComboBox()
        Me.QTE_IN_STOCK = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgv_Products, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.IMAGE_PRODUCT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1232, 29)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "اضافة منتج جديد"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1232, 29)
        Me.Panel1.TabIndex = 102
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.dgv_Products)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 223)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1232, 278)
        Me.Panel2.TabIndex = 103
        '
        'dgv_Products
        '
        Me.dgv_Products.AllowUserToAddRows = False
        Me.dgv_Products.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_Products.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Products.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Products.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_Products.ColumnHeadersHeight = 60
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Products.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_Products.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Products.EnableHeadersVisualStyles = False
        Me.dgv_Products.GridColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dgv_Products.Location = New System.Drawing.Point(0, 0)
        Me.dgv_Products.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.dgv_Products.Name = "dgv_Products"
        Me.dgv_Products.ReadOnly = True
        Me.dgv_Products.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Products.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_Products.RowHeadersVisible = False
        Me.dgv_Products.RowHeadersWidth = 51
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_Products.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_Products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Products.Size = New System.Drawing.Size(1228, 274)
        Me.dgv_Products.TabIndex = 13
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.BtnSave)
        Me.Panel3.Controls.Add(Me.Btn_Item_Alert)
        Me.Panel3.Controls.Add(Me.BtnNewAdd)
        Me.Panel3.Controls.Add(Me.BtnEdit)
        Me.Panel3.Controls.Add(Me.BtnDelete)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Lbl_Count_Product)
        Me.Panel3.Controls.Add(Me.IMAGE_PRODUCT)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 501)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1232, 52)
        Me.Panel3.TabIndex = 2
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Location = New System.Drawing.Point(972, 7)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnSave.Size = New System.Drawing.Size(119, 35)
        Me.BtnSave.TabIndex = 105
        Me.BtnSave.Text = "حفظ"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'Btn_Item_Alert
        '
        Me.Btn_Item_Alert.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Item_Alert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Item_Alert.Location = New System.Drawing.Point(576, 7)
        Me.Btn_Item_Alert.Name = "Btn_Item_Alert"
        Me.Btn_Item_Alert.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Btn_Item_Alert.Size = New System.Drawing.Size(119, 35)
        Me.Btn_Item_Alert.TabIndex = 108
        Me.Btn_Item_Alert.Text = "تبيه الاصناف"
        Me.Btn_Item_Alert.UseVisualStyleBackColor = True
        '
        'BtnNewAdd
        '
        Me.BtnNewAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNewAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNewAdd.Location = New System.Drawing.Point(1104, 6)
        Me.BtnNewAdd.Name = "BtnNewAdd"
        Me.BtnNewAdd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnNewAdd.Size = New System.Drawing.Size(119, 35)
        Me.BtnNewAdd.TabIndex = 109
        Me.BtnNewAdd.Text = "جديد"
        Me.BtnNewAdd.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEdit.Location = New System.Drawing.Point(708, 7)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnEdit.Size = New System.Drawing.Size(119, 35)
        Me.BtnEdit.TabIndex = 106
        Me.BtnEdit.Text = "تعديل"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.Location = New System.Drawing.Point(840, 7)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnDelete.Size = New System.Drawing.Size(119, 35)
        Me.BtnDelete.TabIndex = 107
        Me.BtnDelete.Text = "حذف"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(243, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 28)
        Me.Label4.TabIndex = 105
        Me.Label4.Text = "عدد الاصناف"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_Count_Product
        '
        Me.Lbl_Count_Product.Location = New System.Drawing.Point(162, 7)
        Me.Lbl_Count_Product.Name = "Lbl_Count_Product"
        Me.Lbl_Count_Product.Size = New System.Drawing.Size(75, 28)
        Me.Lbl_Count_Product.TabIndex = 105
        Me.Lbl_Count_Product.Text = "."
        Me.Lbl_Count_Product.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IMAGE_PRODUCT
        '
        Me.IMAGE_PRODUCT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IMAGE_PRODUCT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IMAGE_PRODUCT.Dock = System.Windows.Forms.DockStyle.Left
        Me.IMAGE_PRODUCT.ErrorImage = Nothing
        Me.IMAGE_PRODUCT.InitialImage = Nothing
        Me.IMAGE_PRODUCT.Location = New System.Drawing.Point(0, 0)
        Me.IMAGE_PRODUCT.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.IMAGE_PRODUCT.Name = "IMAGE_PRODUCT"
        Me.IMAGE_PRODUCT.Size = New System.Drawing.Size(138, 48)
        Me.IMAGE_PRODUCT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IMAGE_PRODUCT.TabIndex = 17
        Me.IMAGE_PRODUCT.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.Txt_Search)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 181)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1232, 42)
        Me.Panel4.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label3.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(1098, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 38)
        Me.Label3.TabIndex = 141
        Me.Label3.Text = "ابحث هنا"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.Radio_Product_ID)
        Me.Panel5.Controls.Add(Me.Radio_Product_Name)
        Me.Panel5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.Location = New System.Drawing.Point(624, 4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(467, 29)
        Me.Panel5.TabIndex = 142
        '
        'Radio_Product_ID
        '
        Me.Radio_Product_ID.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Radio_Product_ID.Checked = True
        Me.Radio_Product_ID.Dock = System.Windows.Forms.DockStyle.Right
        Me.Radio_Product_ID.Font = New System.Drawing.Font("Cairo ExtraBold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radio_Product_ID.ForeColor = System.Drawing.Color.White
        Me.Radio_Product_ID.Location = New System.Drawing.Point(2, 0)
        Me.Radio_Product_ID.Name = "Radio_Product_ID"
        Me.Radio_Product_ID.Size = New System.Drawing.Size(246, 25)
        Me.Radio_Product_ID.TabIndex = 104
        Me.Radio_Product_ID.TabStop = True
        Me.Radio_Product_ID.Text = "كود الصنف"
        Me.Radio_Product_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Radio_Product_ID.UseVisualStyleBackColor = False
        '
        'Radio_Product_Name
        '
        Me.Radio_Product_Name.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Radio_Product_Name.Dock = System.Windows.Forms.DockStyle.Right
        Me.Radio_Product_Name.Font = New System.Drawing.Font("Cairo ExtraBold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radio_Product_Name.ForeColor = System.Drawing.Color.White
        Me.Radio_Product_Name.Location = New System.Drawing.Point(248, 0)
        Me.Radio_Product_Name.Name = "Radio_Product_Name"
        Me.Radio_Product_Name.Size = New System.Drawing.Size(215, 25)
        Me.Radio_Product_Name.TabIndex = 105
        Me.Radio_Product_Name.TabStop = True
        Me.Radio_Product_Name.Text = "اسم الصنف"
        Me.Radio_Product_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Radio_Product_Name.UseVisualStyleBackColor = False
        '
        'Txt_Search
        '
        Me.Txt_Search.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Search.Location = New System.Drawing.Point(13, 4)
        Me.Txt_Search.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.Txt_Search.Name = "Txt_Search"
        Me.Txt_Search.Size = New System.Drawing.Size(607, 32)
        Me.Txt_Search.TabIndex = 143
        Me.Txt_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FlowLayoutPanel2.Controls.Add(Me.ID_CATlbl)
        Me.FlowLayoutPanel2.Controls.Add(Me.Minimum_Thresholdlbl)
        Me.FlowLayoutPanel2.Controls.Add(Me.Maximum_Thresholdlbl)
        Me.FlowLayoutPanel2.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel2.Controls.Add(Me.LocationLbl)
        Me.FlowLayoutPanel2.Controls.Add(Me.Unit_PriceLbl)
        Me.FlowLayoutPanel2.Controls.Add(Me.CAT_ID)
        Me.FlowLayoutPanel2.Controls.Add(Me.Minimum_Threshold)
        Me.FlowLayoutPanel2.Controls.Add(Me.Maximum_Threshold)
        Me.FlowLayoutPanel2.Controls.Add(Me.Expiry_Warning)
        Me.FlowLayoutPanel2.Controls.Add(Me.Location)
        Me.FlowLayoutPanel2.Controls.Add(Me.Unit_Price)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel2.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 104)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(1232, 77)
        Me.FlowLayoutPanel2.TabIndex = 1
        '
        'ID_CATlbl
        '
        Me.ID_CATlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ID_CATlbl.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_CATlbl.ForeColor = System.Drawing.Color.White
        Me.ID_CATlbl.Location = New System.Drawing.Point(1018, 0)
        Me.ID_CATlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ID_CATlbl.Name = "ID_CATlbl"
        Me.ID_CATlbl.Size = New System.Drawing.Size(208, 33)
        Me.ID_CATlbl.TabIndex = 9
        Me.ID_CATlbl.Text = "التصنيف"
        Me.ID_CATlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Minimum_Thresholdlbl
        '
        Me.Minimum_Thresholdlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Minimum_Thresholdlbl.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Minimum_Thresholdlbl.ForeColor = System.Drawing.Color.White
        Me.Minimum_Thresholdlbl.Location = New System.Drawing.Point(876, 0)
        Me.Minimum_Thresholdlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Minimum_Thresholdlbl.Name = "Minimum_Thresholdlbl"
        Me.Minimum_Thresholdlbl.Size = New System.Drawing.Size(138, 33)
        Me.Minimum_Thresholdlbl.TabIndex = 17
        Me.Minimum_Thresholdlbl.Text = "اقل رصيد"
        Me.Minimum_Thresholdlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Maximum_Thresholdlbl
        '
        Me.Maximum_Thresholdlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Maximum_Thresholdlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Maximum_Thresholdlbl.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Maximum_Thresholdlbl.ForeColor = System.Drawing.Color.White
        Me.Maximum_Thresholdlbl.Location = New System.Drawing.Point(683, 0)
        Me.Maximum_Thresholdlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Maximum_Thresholdlbl.Name = "Maximum_Thresholdlbl"
        Me.Maximum_Thresholdlbl.Size = New System.Drawing.Size(189, 33)
        Me.Maximum_Thresholdlbl.TabIndex = 141
        Me.Maximum_Thresholdlbl.Text = "اعلى رصيد"
        Me.Maximum_Thresholdlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(432, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(247, 33)
        Me.Label2.TabIndex = 111
        Me.Label2.Text = "يظهر فى التنبيهات"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LocationLbl
        '
        Me.LocationLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.LocationLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LocationLbl.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocationLbl.ForeColor = System.Drawing.Color.White
        Me.LocationLbl.Location = New System.Drawing.Point(221, 0)
        Me.LocationLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LocationLbl.Name = "LocationLbl"
        Me.LocationLbl.Size = New System.Drawing.Size(207, 33)
        Me.LocationLbl.TabIndex = 142
        Me.LocationLbl.Text = "المكان"
        Me.LocationLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Unit_PriceLbl
        '
        Me.Unit_PriceLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Unit_PriceLbl.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Unit_PriceLbl.ForeColor = System.Drawing.Color.White
        Me.Unit_PriceLbl.Location = New System.Drawing.Point(18, 0)
        Me.Unit_PriceLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Unit_PriceLbl.Name = "Unit_PriceLbl"
        Me.Unit_PriceLbl.Size = New System.Drawing.Size(199, 33)
        Me.Unit_PriceLbl.TabIndex = 147
        Me.Unit_PriceLbl.Text = "سعر الوحدة"
        Me.Unit_PriceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CAT_ID
        '
        Me.CAT_ID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CAT_ID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CAT_ID.Font = New System.Drawing.Font("Cairo ExtraBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CAT_ID.FormattingEnabled = True
        Me.CAT_ID.Location = New System.Drawing.Point(1018, 36)
        Me.CAT_ID.Name = "CAT_ID"
        Me.CAT_ID.Size = New System.Drawing.Size(207, 37)
        Me.CAT_ID.TabIndex = 113
        '
        'Minimum_Threshold
        '
        Me.Minimum_Threshold.Font = New System.Drawing.Font("Cairo ExtraBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Minimum_Threshold.Location = New System.Drawing.Point(876, 37)
        Me.Minimum_Threshold.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Minimum_Threshold.Name = "Minimum_Threshold"
        Me.Minimum_Threshold.Size = New System.Drawing.Size(137, 36)
        Me.Minimum_Threshold.TabIndex = 114
        Me.Minimum_Threshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Maximum_Threshold
        '
        Me.Maximum_Threshold.Font = New System.Drawing.Font("Cairo ExtraBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Maximum_Threshold.Location = New System.Drawing.Point(683, 37)
        Me.Maximum_Threshold.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Maximum_Threshold.Name = "Maximum_Threshold"
        Me.Maximum_Threshold.Size = New System.Drawing.Size(189, 36)
        Me.Maximum_Threshold.TabIndex = 145
        Me.Maximum_Threshold.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Expiry_Warning
        '
        Me.Expiry_Warning.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Expiry_Warning.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Expiry_Warning.Font = New System.Drawing.Font("Cairo ExtraBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Expiry_Warning.FormattingEnabled = True
        Me.Expiry_Warning.Items.AddRange(New Object() {"نعم", "لا"})
        Me.Expiry_Warning.Location = New System.Drawing.Point(432, 36)
        Me.Expiry_Warning.Name = "Expiry_Warning"
        Me.Expiry_Warning.Size = New System.Drawing.Size(246, 37)
        Me.Expiry_Warning.TabIndex = 142
        Me.Expiry_Warning.Text = "نعم"
        '
        'Location
        '
        Me.Location.Font = New System.Drawing.Font("Cairo ExtraBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location.Location = New System.Drawing.Point(223, 37)
        Me.Location.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Location.Name = "Location"
        Me.Location.Size = New System.Drawing.Size(204, 36)
        Me.Location.TabIndex = 146
        Me.Location.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Unit_Price
        '
        Me.Unit_Price.Font = New System.Drawing.Font("Cairo ExtraBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Unit_Price.Location = New System.Drawing.Point(18, 37)
        Me.Unit_Price.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Unit_Price.Name = "Unit_Price"
        Me.Unit_Price.ReadOnly = True
        Me.Unit_Price.Size = New System.Drawing.Size(201, 36)
        Me.Unit_Price.TabIndex = 148
        Me.Unit_Price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FlowLayoutPanel1.Controls.Add(Me.ID_PRODUCTlbl)
        Me.FlowLayoutPanel1.Controls.Add(Me.Product_Namelbl)
        Me.FlowLayoutPanel1.Controls.Add(Me.Initial_Balancelbl)
        Me.FlowLayoutPanel1.Controls.Add(Me.Unitlbl)
        Me.FlowLayoutPanel1.Controls.Add(Me.QTE_IN_STOCKlbl)
        Me.FlowLayoutPanel1.Controls.Add(Me.Product_ID)
        Me.FlowLayoutPanel1.Controls.Add(Me.Product_Name)
        Me.FlowLayoutPanel1.Controls.Add(Me.Initial_Balance)
        Me.FlowLayoutPanel1.Controls.Add(Me.Unit_ID)
        Me.FlowLayoutPanel1.Controls.Add(Me.QTE_IN_STOCK)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 29)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1232, 75)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'ID_PRODUCTlbl
        '
        Me.ID_PRODUCTlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ID_PRODUCTlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ID_PRODUCTlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ID_PRODUCTlbl.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID_PRODUCTlbl.ForeColor = System.Drawing.Color.White
        Me.ID_PRODUCTlbl.Location = New System.Drawing.Point(1050, 0)
        Me.ID_PRODUCTlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ID_PRODUCTlbl.Name = "ID_PRODUCTlbl"
        Me.ID_PRODUCTlbl.Size = New System.Drawing.Size(176, 33)
        Me.ID_PRODUCTlbl.TabIndex = 138
        Me.ID_PRODUCTlbl.Text = "كود الصنف"
        Me.ID_PRODUCTlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Product_Namelbl
        '
        Me.Product_Namelbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Product_Namelbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Product_Namelbl.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Product_Namelbl.ForeColor = System.Drawing.Color.White
        Me.Product_Namelbl.Location = New System.Drawing.Point(542, 0)
        Me.Product_Namelbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Product_Namelbl.Name = "Product_Namelbl"
        Me.Product_Namelbl.Size = New System.Drawing.Size(504, 33)
        Me.Product_Namelbl.TabIndex = 3
        Me.Product_Namelbl.Text = "اسم الصنف"
        Me.Product_Namelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Initial_Balancelbl
        '
        Me.Initial_Balancelbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Initial_Balancelbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Initial_Balancelbl.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Initial_Balancelbl.ForeColor = System.Drawing.Color.White
        Me.Initial_Balancelbl.Location = New System.Drawing.Point(407, 0)
        Me.Initial_Balancelbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Initial_Balancelbl.Name = "Initial_Balancelbl"
        Me.Initial_Balancelbl.Size = New System.Drawing.Size(131, 33)
        Me.Initial_Balancelbl.TabIndex = 140
        Me.Initial_Balancelbl.Text = "رصيد بداية المدة"
        Me.Initial_Balancelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Unitlbl
        '
        Me.Unitlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Unitlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Unitlbl.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Unitlbl.ForeColor = System.Drawing.Color.White
        Me.Unitlbl.Location = New System.Drawing.Point(177, 0)
        Me.Unitlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Unitlbl.Name = "Unitlbl"
        Me.Unitlbl.Size = New System.Drawing.Size(226, 33)
        Me.Unitlbl.TabIndex = 139
        Me.Unitlbl.Text = "الوحدة"
        Me.Unitlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'QTE_IN_STOCKlbl
        '
        Me.QTE_IN_STOCKlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.QTE_IN_STOCKlbl.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QTE_IN_STOCKlbl.ForeColor = System.Drawing.Color.White
        Me.QTE_IN_STOCKlbl.Location = New System.Drawing.Point(18, 0)
        Me.QTE_IN_STOCKlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.QTE_IN_STOCKlbl.Name = "QTE_IN_STOCKlbl"
        Me.QTE_IN_STOCKlbl.Size = New System.Drawing.Size(155, 33)
        Me.QTE_IN_STOCKlbl.TabIndex = 18
        Me.QTE_IN_STOCKlbl.Text = "الرصيد الحالى"
        Me.QTE_IN_STOCKlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Product_ID
        '
        Me.Product_ID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Product_ID.Font = New System.Drawing.Font("Cairo ExtraBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Product_ID.Location = New System.Drawing.Point(1050, 37)
        Me.Product_ID.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Product_ID.Name = "Product_ID"
        Me.Product_ID.Size = New System.Drawing.Size(176, 36)
        Me.Product_ID.TabIndex = 143
        Me.Product_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Product_Name
        '
        Me.Product_Name.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Product_Name.Font = New System.Drawing.Font("Cairo ExtraBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Product_Name.Location = New System.Drawing.Point(542, 37)
        Me.Product_Name.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Product_Name.Name = "Product_Name"
        Me.Product_Name.Size = New System.Drawing.Size(504, 36)
        Me.Product_Name.TabIndex = 112
        Me.Product_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Initial_Balance
        '
        Me.Initial_Balance.Font = New System.Drawing.Font("Cairo ExtraBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Initial_Balance.Location = New System.Drawing.Point(407, 37)
        Me.Initial_Balance.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Initial_Balance.Name = "Initial_Balance"
        Me.Initial_Balance.Size = New System.Drawing.Size(131, 36)
        Me.Initial_Balance.TabIndex = 147
        Me.Initial_Balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Unit_ID
        '
        Me.Unit_ID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Unit_ID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Unit_ID.Font = New System.Drawing.Font("Cairo ExtraBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Unit_ID.FormattingEnabled = True
        Me.Unit_ID.Location = New System.Drawing.Point(177, 36)
        Me.Unit_ID.Name = "Unit_ID"
        Me.Unit_ID.Size = New System.Drawing.Size(225, 37)
        Me.Unit_ID.TabIndex = 144
        '
        'QTE_IN_STOCK
        '
        Me.QTE_IN_STOCK.Font = New System.Drawing.Font("Cairo ExtraBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QTE_IN_STOCK.Location = New System.Drawing.Point(18, 37)
        Me.QTE_IN_STOCK.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.QTE_IN_STOCK.Name = "QTE_IN_STOCK"
        Me.QTE_IN_STOCK.Size = New System.Drawing.Size(154, 36)
        Me.QTE_IN_STOCK.TabIndex = 115
        Me.QTE_IN_STOCK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Add_Products_New
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(1232, 553)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.FlowLayoutPanel2)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "Add_Products_New"
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.Text = "شاشة اضافة صنف جديد "
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgv_Products, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.IMAGE_PRODUCT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents ID_PRODUCTlbl As Label
    Friend WithEvents Maximum_Thresholdlbl As Label
    Friend WithEvents Initial_Balancelbl As Label
    Friend WithEvents Unitlbl As Label
    Friend WithEvents LocationLbl As Label
    Friend WithEvents Product_ID As TextBox
    Friend WithEvents Unit_ID As ComboBox
    Friend WithEvents Maximum_Threshold As TextBox
    Friend WithEvents Location As TextBox
    Friend WithEvents Initial_Balance As TextBox
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Product_Namelbl As Label
    Friend WithEvents ID_CATlbl As Label
    Friend WithEvents Minimum_Thresholdlbl As Label
    Friend WithEvents QTE_IN_STOCKlbl As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Product_Name As TextBox
    Friend WithEvents CAT_ID As ComboBox
    Friend WithEvents Minimum_Threshold As TextBox
    Friend WithEvents QTE_IN_STOCK As TextBox
    Friend WithEvents Expiry_Warning As ComboBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents IMAGE_PRODUCT As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Radio_Product_ID As RadioButton
    Friend WithEvents Radio_Product_Name As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_Search As TextBox
    Friend WithEvents dgv_Products As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Lbl_Count_Product As Label
    Friend WithEvents Unit_PriceLbl As Label
    Friend WithEvents Unit_Price As TextBox
    Friend WithEvents BtnNewAdd As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents Btn_Item_Alert As Button
End Class
