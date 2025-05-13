<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Customer_Return
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ReturnInvoiceNumberLbl = New System.Windows.Forms.Label()
        Me.ReturnInvoiceNumber = New System.Windows.Forms.TextBox()
        Me.Total_Invoice_ValueLbl = New System.Windows.Forms.Label()
        Me.Total_Invoice_Value = New System.Windows.Forms.TextBox()
        Me.Invoice_Numberlbl = New System.Windows.Forms.Label()
        Me.Supplier_IDlbl = New System.Windows.Forms.Label()
        Me.Invoice_Date = New System.Windows.Forms.DateTimePicker()
        Me.Invoice_DateDatelbl = New System.Windows.Forms.Label()
        Me.Invoice_Number = New System.Windows.Forms.TextBox()
        Me.Customer_ID = New System.Windows.Forms.ComboBox()
        Me.Invoice_IDlbl = New System.Windows.Forms.Label()
        Me.Invoice_ID = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BtnNewAdd = New System.Windows.Forms.ToolStripButton()
        Me.BtnSave = New System.Windows.Forms.ToolStripButton()
        Me.BtnDelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.Btn_Add_Products = New System.Windows.Forms.ToolStripButton()
        Me.Btn_Add_Group_Codes = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Lbl_Count_Product = New System.Windows.Forms.ToolStripLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgv_Tbl_InvoiceItems = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.DGV_Product_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Product_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_QTE_IN_STOCK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_ID_CAT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Unit_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Unit_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Initial_Balance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Unit_Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Minimum_Threshold = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Maximum_Threshold = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Add_Balance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Total_Unit_Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_Tbl_InvoiceItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Hacen Saudi Arabia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1377, 43)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "اذن مرتجع عميل"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.ReturnInvoiceNumberLbl)
        Me.GroupBox1.Controls.Add(Me.ReturnInvoiceNumber)
        Me.GroupBox1.Controls.Add(Me.Total_Invoice_ValueLbl)
        Me.GroupBox1.Controls.Add(Me.Total_Invoice_Value)
        Me.GroupBox1.Controls.Add(Me.Invoice_Numberlbl)
        Me.GroupBox1.Controls.Add(Me.Supplier_IDlbl)
        Me.GroupBox1.Controls.Add(Me.Invoice_Date)
        Me.GroupBox1.Controls.Add(Me.Invoice_DateDatelbl)
        Me.GroupBox1.Controls.Add(Me.Invoice_Number)
        Me.GroupBox1.Controls.Add(Me.Customer_ID)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1377, 123)
        Me.GroupBox1.TabIndex = 142
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "بيانات المستند"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Blue
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.Location = New System.Drawing.Point(731, 30)
        Me.Button1.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 30)
        Me.Button1.TabIndex = 141
        Me.Button1.Text = "اضافة سيارة"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ReturnInvoiceNumberLbl
        '
        Me.ReturnInvoiceNumberLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReturnInvoiceNumberLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.ReturnInvoiceNumberLbl.ForeColor = System.Drawing.Color.Black
        Me.ReturnInvoiceNumberLbl.Location = New System.Drawing.Point(1210, 75)
        Me.ReturnInvoiceNumberLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ReturnInvoiceNumberLbl.Name = "ReturnInvoiceNumberLbl"
        Me.ReturnInvoiceNumberLbl.Size = New System.Drawing.Size(155, 31)
        Me.ReturnInvoiceNumberLbl.TabIndex = 138
        Me.ReturnInvoiceNumberLbl.Text = "رقم اذن المرتجع"
        Me.ReturnInvoiceNumberLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ReturnInvoiceNumber
        '
        Me.ReturnInvoiceNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReturnInvoiceNumber.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReturnInvoiceNumber.Location = New System.Drawing.Point(921, 75)
        Me.ReturnInvoiceNumber.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.ReturnInvoiceNumber.Name = "ReturnInvoiceNumber"
        Me.ReturnInvoiceNumber.Size = New System.Drawing.Size(274, 38)
        Me.ReturnInvoiceNumber.TabIndex = 4
        Me.ReturnInvoiceNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Total_Invoice_ValueLbl
        '
        Me.Total_Invoice_ValueLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Total_Invoice_ValueLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Total_Invoice_ValueLbl.ForeColor = System.Drawing.Color.Black
        Me.Total_Invoice_ValueLbl.Location = New System.Drawing.Point(96, 76)
        Me.Total_Invoice_ValueLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Total_Invoice_ValueLbl.Name = "Total_Invoice_ValueLbl"
        Me.Total_Invoice_ValueLbl.Size = New System.Drawing.Size(77, 34)
        Me.Total_Invoice_ValueLbl.TabIndex = 138
        Me.Total_Invoice_ValueLbl.Text = "الاجمالى الكلى للفاتورة"
        Me.Total_Invoice_ValueLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Total_Invoice_ValueLbl.Visible = False
        '
        'Total_Invoice_Value
        '
        Me.Total_Invoice_Value.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Total_Invoice_Value.Enabled = False
        Me.Total_Invoice_Value.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total_Invoice_Value.Location = New System.Drawing.Point(6, 73)
        Me.Total_Invoice_Value.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Total_Invoice_Value.Name = "Total_Invoice_Value"
        Me.Total_Invoice_Value.ReadOnly = True
        Me.Total_Invoice_Value.Size = New System.Drawing.Size(86, 38)
        Me.Total_Invoice_Value.TabIndex = 139
        Me.Total_Invoice_Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Total_Invoice_Value.Visible = False
        '
        'Invoice_Numberlbl
        '
        Me.Invoice_Numberlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Invoice_Numberlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Invoice_Numberlbl.ForeColor = System.Drawing.Color.Black
        Me.Invoice_Numberlbl.Location = New System.Drawing.Point(1210, 29)
        Me.Invoice_Numberlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Invoice_Numberlbl.Name = "Invoice_Numberlbl"
        Me.Invoice_Numberlbl.Size = New System.Drawing.Size(155, 34)
        Me.Invoice_Numberlbl.TabIndex = 2
        Me.Invoice_Numberlbl.Text = "رقم الاذن"
        Me.Invoice_Numberlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Supplier_IDlbl
        '
        Me.Supplier_IDlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Supplier_IDlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Supplier_IDlbl.ForeColor = System.Drawing.Color.Black
        Me.Supplier_IDlbl.Location = New System.Drawing.Point(730, 29)
        Me.Supplier_IDlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Supplier_IDlbl.Name = "Supplier_IDlbl"
        Me.Supplier_IDlbl.Size = New System.Drawing.Size(166, 32)
        Me.Supplier_IDlbl.TabIndex = 6
        Me.Supplier_IDlbl.Text = "اسم العميل"
        Me.Supplier_IDlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Invoice_Date
        '
        Me.Invoice_Date.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Invoice_Date.CalendarFont = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Invoice_Date.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Invoice_Date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Invoice_Date.Location = New System.Drawing.Point(449, 77)
        Me.Invoice_Date.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Invoice_Date.Name = "Invoice_Date"
        Me.Invoice_Date.Size = New System.Drawing.Size(274, 30)
        Me.Invoice_Date.TabIndex = 3
        '
        'Invoice_DateDatelbl
        '
        Me.Invoice_DateDatelbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Invoice_DateDatelbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Invoice_DateDatelbl.ForeColor = System.Drawing.Color.Black
        Me.Invoice_DateDatelbl.Location = New System.Drawing.Point(730, 75)
        Me.Invoice_DateDatelbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Invoice_DateDatelbl.Name = "Invoice_DateDatelbl"
        Me.Invoice_DateDatelbl.Size = New System.Drawing.Size(166, 27)
        Me.Invoice_DateDatelbl.TabIndex = 4
        Me.Invoice_DateDatelbl.Text = "تاريخ الاذن"
        Me.Invoice_DateDatelbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Invoice_Number
        '
        Me.Invoice_Number.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Invoice_Number.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Invoice_Number.Location = New System.Drawing.Point(919, 29)
        Me.Invoice_Number.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Invoice_Number.Name = "Invoice_Number"
        Me.Invoice_Number.Size = New System.Drawing.Size(276, 38)
        Me.Invoice_Number.TabIndex = 1
        Me.Invoice_Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Customer_ID
        '
        Me.Customer_ID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Customer_ID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Customer_ID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Customer_ID.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Customer_ID.FormattingEnabled = True
        Me.Customer_ID.Location = New System.Drawing.Point(449, 29)
        Me.Customer_ID.Name = "Customer_ID"
        Me.Customer_ID.Size = New System.Drawing.Size(274, 40)
        Me.Customer_ID.TabIndex = 2
        '
        'Invoice_IDlbl
        '
        Me.Invoice_IDlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Invoice_IDlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Invoice_IDlbl.ForeColor = System.Drawing.Color.White
        Me.Invoice_IDlbl.Location = New System.Drawing.Point(296, 23)
        Me.Invoice_IDlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Invoice_IDlbl.Name = "Invoice_IDlbl"
        Me.Invoice_IDlbl.Size = New System.Drawing.Size(140, 34)
        Me.Invoice_IDlbl.TabIndex = 16
        Me.Invoice_IDlbl.Text = "كود المستند"
        Me.Invoice_IDlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Invoice_ID
        '
        Me.Invoice_ID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Invoice_ID.Enabled = False
        Me.Invoice_ID.Location = New System.Drawing.Point(152, 22)
        Me.Invoice_ID.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Invoice_ID.Name = "Invoice_ID"
        Me.Invoice_ID.ReadOnly = True
        Me.Invoice_ID.Size = New System.Drawing.Size(140, 34)
        Me.Invoice_ID.TabIndex = 17
        Me.Invoice_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Teal
        Me.Panel2.Controls.Add(Me.ToolStrip1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 639)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1377, 60)
        Me.Panel2.TabIndex = 141
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNewAdd, Me.BtnSave, Me.BtnDelete, Me.ToolStripButton2, Me.Btn_Add_Products, Me.Btn_Add_Group_Codes, Me.ToolStripLabel1, Me.Lbl_Count_Product})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1377, 60)
        Me.ToolStrip1.TabIndex = 20
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
        Me.BtnNewAdd.Text = "اذن جديد"
        Me.BtnNewAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNewAdd.ToolTipText = "اضافة صنف جديد"
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.Green
        Me.BtnSave.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.Black
        Me.BtnSave.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Ok
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(189, 57)
        Me.BtnSave.Text = "حفظ بيانات الاذن"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSave.ToolTipText = "حفظ الصنف المحدد"
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.Red
        Me.BtnDelete.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Remove
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(207, 57)
        Me.BtnDelete.Text = "حذف السطر المحدد"
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.ToolTipText = "حذف الصنف المحدد"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.BackColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton2.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Search_More2
        Me.ToolStripButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(137, 57)
        Me.ToolStripButton2.Text = "بحث عن صنف"
        Me.ToolStripButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolStripButton2.ToolTipText = "فتح نموذج بحث الاصناف"
        '
        'Btn_Add_Products
        '
        Me.Btn_Add_Products.BackColor = System.Drawing.Color.DarkOrange
        Me.Btn_Add_Products.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Add_Products.ForeColor = System.Drawing.Color.Black
        Me.Btn_Add_Products.Image = Global.El_Dawliya_International_System.My.Resources.Resources.checkout_60px
        Me.Btn_Add_Products.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_Add_Products.Name = "Btn_Add_Products"
        Me.Btn_Add_Products.Size = New System.Drawing.Size(165, 57)
        Me.Btn_Add_Products.Text = "اضافة صنف جديد"
        '
        'Btn_Add_Group_Codes
        '
        Me.Btn_Add_Group_Codes.BackColor = System.Drawing.Color.Peru
        Me.Btn_Add_Group_Codes.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Add_Group_Codes.Image = Global.El_Dawliya_International_System.My.Resources.Resources.txt_50px
        Me.Btn_Add_Group_Codes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_Add_Group_Codes.Name = "Btn_Add_Group_Codes"
        Me.Btn_Add_Group_Codes.Size = New System.Drawing.Size(199, 57)
        Me.Btn_Add_Group_Codes.Text = "اضافة مجموعة اكواد"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(106, 57)
        Me.ToolStripLabel1.Text = "عدد الاصناف"
        '
        'Lbl_Count_Product
        '
        Me.Lbl_Count_Product.BackColor = System.Drawing.Color.Black
        Me.Lbl_Count_Product.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Count_Product.ForeColor = System.Drawing.Color.White
        Me.Lbl_Count_Product.Name = "Lbl_Count_Product"
        Me.Lbl_Count_Product.Size = New System.Drawing.Size(26, 57)
        Me.Lbl_Count_Product.Text = "..."
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Invoice_IDlbl)
        Me.Panel1.Controls.Add(Me.Invoice_ID)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1377, 43)
        Me.Panel1.TabIndex = 148
        '
        'dgv_Tbl_InvoiceItems
        '
        Me.dgv_Tbl_InvoiceItems.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Cairo", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_Tbl_InvoiceItems.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Tbl_InvoiceItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgv_Tbl_InvoiceItems.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Tbl_InvoiceItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_Tbl_InvoiceItems.ColumnHeadersHeight = 40
        Me.dgv_Tbl_InvoiceItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGV_Product_ID, Me.DGV_Product_Name, Me.DGV_QTE_IN_STOCK, Me.DGV_ID_CAT, Me.DGV_Unit_ID, Me.DGV_Unit_Name, Me.DGV_Initial_Balance, Me.DGV_Unit_Price, Me.DGV_Minimum_Threshold, Me.DGV_Maximum_Threshold, Me.DGV_Add_Balance, Me.DGV_Total_Unit_Price})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Tbl_InvoiceItems.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_Tbl_InvoiceItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Tbl_InvoiceItems.EnableHeadersVisualStyles = False
        Me.dgv_Tbl_InvoiceItems.Location = New System.Drawing.Point(0, 0)
        Me.dgv_Tbl_InvoiceItems.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.dgv_Tbl_InvoiceItems.Name = "dgv_Tbl_InvoiceItems"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Tbl_InvoiceItems.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_Tbl_InvoiceItems.RowHeadersVisible = False
        Me.dgv_Tbl_InvoiceItems.RowHeadersWidth = 51
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Cairo SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_Tbl_InvoiceItems.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_Tbl_InvoiceItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Tbl_InvoiceItems.Size = New System.Drawing.Size(1377, 473)
        Me.dgv_Tbl_InvoiceItems.TabIndex = 139
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 43)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1377, 123)
        Me.Panel3.TabIndex = 1
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.dgv_Tbl_InvoiceItems)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(0, 166)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1377, 473)
        Me.Panel8.TabIndex = 2
        '
        'DGV_Product_ID
        '
        Me.DGV_Product_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DGV_Product_ID.HeaderText = "كود الصنف"
        Me.DGV_Product_ID.MinimumWidth = 6
        Me.DGV_Product_ID.Name = "DGV_Product_ID"
        Me.DGV_Product_ID.Width = 122
        '
        'DGV_Product_Name
        '
        Me.DGV_Product_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DGV_Product_Name.HeaderText = "اسم الصنف"
        Me.DGV_Product_Name.MinimumWidth = 6
        Me.DGV_Product_Name.Name = "DGV_Product_Name"
        Me.DGV_Product_Name.ReadOnly = True
        Me.DGV_Product_Name.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DGV_QTE_IN_STOCK
        '
        Me.DGV_QTE_IN_STOCK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DGV_QTE_IN_STOCK.HeaderText = "الرصيد الحالى"
        Me.DGV_QTE_IN_STOCK.MinimumWidth = 6
        Me.DGV_QTE_IN_STOCK.Name = "DGV_QTE_IN_STOCK"
        Me.DGV_QTE_IN_STOCK.ReadOnly = True
        Me.DGV_QTE_IN_STOCK.Width = 137
        '
        'DGV_ID_CAT
        '
        Me.DGV_ID_CAT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DGV_ID_CAT.HeaderText = "اسم التصنيف"
        Me.DGV_ID_CAT.MinimumWidth = 6
        Me.DGV_ID_CAT.Name = "DGV_ID_CAT"
        Me.DGV_ID_CAT.ReadOnly = True
        Me.DGV_ID_CAT.Visible = False
        Me.DGV_ID_CAT.Width = 136
        '
        'DGV_Unit_ID
        '
        Me.DGV_Unit_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DGV_Unit_ID.HeaderText = "كود الوحدة"
        Me.DGV_Unit_ID.MinimumWidth = 6
        Me.DGV_Unit_ID.Name = "DGV_Unit_ID"
        Me.DGV_Unit_ID.ReadOnly = True
        Me.DGV_Unit_ID.Visible = False
        Me.DGV_Unit_ID.Width = 127
        '
        'DGV_Unit_Name
        '
        Me.DGV_Unit_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DGV_Unit_Name.HeaderText = "اسم الوحدة"
        Me.DGV_Unit_Name.MinimumWidth = 6
        Me.DGV_Unit_Name.Name = "DGV_Unit_Name"
        Me.DGV_Unit_Name.ReadOnly = True
        Me.DGV_Unit_Name.Width = 129
        '
        'DGV_Initial_Balance
        '
        Me.DGV_Initial_Balance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DGV_Initial_Balance.HeaderText = "الرصيد الافتتاحى"
        Me.DGV_Initial_Balance.MinimumWidth = 6
        Me.DGV_Initial_Balance.Name = "DGV_Initial_Balance"
        Me.DGV_Initial_Balance.ReadOnly = True
        Me.DGV_Initial_Balance.Width = 159
        '
        'DGV_Unit_Price
        '
        Me.DGV_Unit_Price.HeaderText = "سعر الوحدة"
        Me.DGV_Unit_Price.MinimumWidth = 6
        Me.DGV_Unit_Price.Name = "DGV_Unit_Price"
        Me.DGV_Unit_Price.ReadOnly = True
        Me.DGV_Unit_Price.Visible = False
        Me.DGV_Unit_Price.Width = 125
        '
        'DGV_Minimum_Threshold
        '
        Me.DGV_Minimum_Threshold.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DGV_Minimum_Threshold.HeaderText = "اقل كمية"
        Me.DGV_Minimum_Threshold.MinimumWidth = 6
        Me.DGV_Minimum_Threshold.Name = "DGV_Minimum_Threshold"
        Me.DGV_Minimum_Threshold.ReadOnly = True
        Me.DGV_Minimum_Threshold.Width = 112
        '
        'DGV_Maximum_Threshold
        '
        Me.DGV_Maximum_Threshold.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DGV_Maximum_Threshold.HeaderText = "اعلى كمية"
        Me.DGV_Maximum_Threshold.MinimumWidth = 6
        Me.DGV_Maximum_Threshold.Name = "DGV_Maximum_Threshold"
        Me.DGV_Maximum_Threshold.ReadOnly = True
        Me.DGV_Maximum_Threshold.Width = 120
        '
        'DGV_Add_Balance
        '
        Me.DGV_Add_Balance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DGV_Add_Balance.HeaderText = "الكمية المضافة"
        Me.DGV_Add_Balance.MinimumWidth = 6
        Me.DGV_Add_Balance.Name = "DGV_Add_Balance"
        Me.DGV_Add_Balance.Width = 163
        '
        'DGV_Total_Unit_Price
        '
        Me.DGV_Total_Unit_Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DGV_Total_Unit_Price.HeaderText = "اجمالى السعر للصنف"
        Me.DGV_Total_Unit_Price.MinimumWidth = 6
        Me.DGV_Total_Unit_Price.Name = "DGV_Total_Unit_Price"
        Me.DGV_Total_Unit_Price.ReadOnly = True
        Me.DGV_Total_Unit_Price.Visible = False
        Me.DGV_Total_Unit_Price.Width = 191
        '
        'Frm_Customer_Return
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1377, 699)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Frm_Customer_Return"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv_Tbl_InvoiceItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ReturnInvoiceNumberLbl As Label
    Friend WithEvents Invoice_IDlbl As Label
    Friend WithEvents Invoice_ID As TextBox
    Friend WithEvents ReturnInvoiceNumber As TextBox
    Friend WithEvents Total_Invoice_ValueLbl As Label
    Friend WithEvents Total_Invoice_Value As TextBox
    Friend WithEvents Invoice_Numberlbl As Label
    Friend WithEvents Supplier_IDlbl As Label
    Friend WithEvents Invoice_Date As DateTimePicker
    Friend WithEvents Invoice_DateDatelbl As Label
    Friend WithEvents Invoice_Number As TextBox
    Friend WithEvents Customer_ID As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgv_Tbl_InvoiceItems As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents BtnNewAdd As ToolStripButton
    Friend WithEvents BtnSave As ToolStripButton
    Friend WithEvents BtnDelete As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents Lbl_Count_Product As ToolStripLabel
    Friend WithEvents Btn_Add_Group_Codes As ToolStripButton
    Friend WithEvents Btn_Add_Products As ToolStripButton
    Friend WithEvents Button1 As Button
    Friend WithEvents DGV_Product_ID As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Product_Name As DataGridViewTextBoxColumn
    Friend WithEvents DGV_QTE_IN_STOCK As DataGridViewTextBoxColumn
    Friend WithEvents DGV_ID_CAT As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Unit_ID As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Unit_Name As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Initial_Balance As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Unit_Price As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Minimum_Threshold As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Maximum_Threshold As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Add_Balance As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Total_Unit_Price As DataGridViewTextBoxColumn
End Class
