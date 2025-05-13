<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ezn_Edafah_New
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ezn_Edafah_New))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Invoice_ID = New System.Windows.Forms.TextBox()
        Me.Total_Invoice_ValueLbl = New System.Windows.Forms.Label()
        Me.Total_Invoice_Value = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Calculator = New System.Windows.Forms.Button()
        Me.Lbl_NumberOfItems = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Btn_Export_Excel = New System.Windows.Forms.Button()
        Me.Btn_Add_Group_Codes = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.Btn_Add_Products = New System.Windows.Forms.Button()
        Me.Btn_Search_Products = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnNewAdd = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Invoice_Numberlbl = New System.Windows.Forms.Label()
        Me.Supplier_IDlbl = New System.Windows.Forms.Label()
        Me.Invoice_DateDatelbl = New System.Windows.Forms.Label()
        Me.Supplier_Invoice_NumberLbl = New System.Windows.Forms.Label()
        Me.NumberOfItemsLbl = New System.Windows.Forms.Label()
        Me.Invoice_Number = New System.Windows.Forms.TextBox()
        Me.Supplier_ID = New System.Windows.Forms.ComboBox()
        Me.Invoice_Date = New System.Windows.Forms.DateTimePicker()
        Me.Supplier_Invoice_Number = New System.Windows.Forms.TextBox()
        Me.NumberOfItems = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgv_Tbl_InvoiceItems = New System.Windows.Forms.DataGridView()
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
        Me.DGV_Machine_Unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Notes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgv_Tbl_InvoiceItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Invoice_ID)
        Me.Panel1.Controls.Add(Me.Total_Invoice_ValueLbl)
        Me.Panel1.Controls.Add(Me.Total_Invoice_Value)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1287, 57)
        Me.Panel1.TabIndex = 0
        '
        'Invoice_ID
        '
        Me.Invoice_ID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Invoice_ID.Enabled = False
        Me.Invoice_ID.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Invoice_ID.Location = New System.Drawing.Point(1209, 9)
        Me.Invoice_ID.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Invoice_ID.Name = "Invoice_ID"
        Me.Invoice_ID.ReadOnly = True
        Me.Invoice_ID.Size = New System.Drawing.Size(70, 38)
        Me.Invoice_ID.TabIndex = 142
        Me.Invoice_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Invoice_ID.Visible = False
        '
        'Total_Invoice_ValueLbl
        '
        Me.Total_Invoice_ValueLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Total_Invoice_ValueLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Total_Invoice_ValueLbl.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total_Invoice_ValueLbl.ForeColor = System.Drawing.Color.Black
        Me.Total_Invoice_ValueLbl.Location = New System.Drawing.Point(107, 10)
        Me.Total_Invoice_ValueLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Total_Invoice_ValueLbl.Name = "Total_Invoice_ValueLbl"
        Me.Total_Invoice_ValueLbl.Size = New System.Drawing.Size(165, 34)
        Me.Total_Invoice_ValueLbl.TabIndex = 140
        Me.Total_Invoice_ValueLbl.Text = "الاجمالى الكلى للفاتورة"
        Me.Total_Invoice_ValueLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Total_Invoice_ValueLbl.Visible = False
        '
        'Total_Invoice_Value
        '
        Me.Total_Invoice_Value.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Total_Invoice_Value.Enabled = False
        Me.Total_Invoice_Value.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total_Invoice_Value.Location = New System.Drawing.Point(-149, 9)
        Me.Total_Invoice_Value.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Total_Invoice_Value.Name = "Total_Invoice_Value"
        Me.Total_Invoice_Value.ReadOnly = True
        Me.Total_Invoice_Value.Size = New System.Drawing.Size(70, 38)
        Me.Total_Invoice_Value.TabIndex = 141
        Me.Total_Invoice_Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Total_Invoice_Value.Visible = False
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Cairo ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1287, 57)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "إذن وارد"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Calculator)
        Me.Panel2.Controls.Add(Me.Lbl_NumberOfItems)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Btn_Export_Excel)
        Me.Panel2.Controls.Add(Me.Btn_Add_Group_Codes)
        Me.Panel2.Controls.Add(Me.BtnDelete)
        Me.Panel2.Controls.Add(Me.Btn_Add_Products)
        Me.Panel2.Controls.Add(Me.Btn_Search_Products)
        Me.Panel2.Controls.Add(Me.BtnSave)
        Me.Panel2.Controls.Add(Me.BtnNewAdd)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 635)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1287, 83)
        Me.Panel2.TabIndex = 1
        '
        'Calculator
        '
        Me.Calculator.Location = New System.Drawing.Point(806, 19)
        Me.Calculator.Name = "Calculator"
        Me.Calculator.Size = New System.Drawing.Size(44, 56)
        Me.Calculator.TabIndex = 29
        Me.Calculator.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Calculator.UseVisualStyleBackColor = True
        '
        'Lbl_NumberOfItems
        '
        Me.Lbl_NumberOfItems.BackColor = System.Drawing.Color.Silver
        Me.Lbl_NumberOfItems.ForeColor = System.Drawing.Color.Black
        Me.Lbl_NumberOfItems.Location = New System.Drawing.Point(-2, 41)
        Me.Lbl_NumberOfItems.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_NumberOfItems.Name = "Lbl_NumberOfItems"
        Me.Lbl_NumberOfItems.Size = New System.Drawing.Size(140, 34)
        Me.Lbl_NumberOfItems.TabIndex = 27
        Me.Lbl_NumberOfItems.Text = "."
        Me.Lbl_NumberOfItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(-2, 5)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 34)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "عدد الاصناف"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Btn_Export_Excel
        '
        Me.Btn_Export_Excel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Export_Excel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Export_Excel.Location = New System.Drawing.Point(193, 17)
        Me.Btn_Export_Excel.Name = "Btn_Export_Excel"
        Me.Btn_Export_Excel.Size = New System.Drawing.Size(127, 56)
        Me.Btn_Export_Excel.TabIndex = 20
        Me.Btn_Export_Excel.Text = "تصدير للإكسل"
        Me.Btn_Export_Excel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Export_Excel.UseVisualStyleBackColor = True
        '
        'Btn_Add_Group_Codes
        '
        Me.Btn_Add_Group_Codes.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Add_Group_Codes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Add_Group_Codes.Location = New System.Drawing.Point(326, 17)
        Me.Btn_Add_Group_Codes.Name = "Btn_Add_Group_Codes"
        Me.Btn_Add_Group_Codes.Size = New System.Drawing.Size(187, 56)
        Me.Btn_Add_Group_Codes.TabIndex = 21
        Me.Btn_Add_Group_Codes.Text = "إضافة مجموعة أكواد"
        Me.Btn_Add_Group_Codes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Add_Group_Codes.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.Location = New System.Drawing.Point(856, 17)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(107, 56)
        Me.BtnDelete.TabIndex = 22
        Me.BtnDelete.Text = "حذف"
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'Btn_Add_Products
        '
        Me.Btn_Add_Products.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Add_Products.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Add_Products.Location = New System.Drawing.Point(519, 17)
        Me.Btn_Add_Products.Name = "Btn_Add_Products"
        Me.Btn_Add_Products.Size = New System.Drawing.Size(157, 56)
        Me.Btn_Add_Products.TabIndex = 23
        Me.Btn_Add_Products.Text = "اضافة صنف جديد"
        Me.Btn_Add_Products.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Add_Products.UseVisualStyleBackColor = True
        '
        'Btn_Search_Products
        '
        Me.Btn_Search_Products.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Search_Products.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Search_Products.Location = New System.Drawing.Point(677, 17)
        Me.Btn_Search_Products.Name = "Btn_Search_Products"
        Me.Btn_Search_Products.Size = New System.Drawing.Size(123, 56)
        Me.Btn_Search_Products.TabIndex = 24
        Me.Btn_Search_Products.Text = "بحث عن صنف"
        Me.Btn_Search_Products.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Search_Products.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Location = New System.Drawing.Point(968, 17)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(184, 56)
        Me.BtnSave.TabIndex = 25
        Me.BtnSave.Text = "حفظ بيانات المستند"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnNewAdd
        '
        Me.BtnNewAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNewAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNewAdd.Location = New System.Drawing.Point(1158, 17)
        Me.BtnNewAdd.Name = "BtnNewAdd"
        Me.BtnNewAdd.Size = New System.Drawing.Size(121, 56)
        Me.BtnNewAdd.TabIndex = 26
        Me.BtnNewAdd.Text = "إذن جديد"
        Me.BtnNewAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNewAdd.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FlowLayoutPanel1.Controls.Add(Me.Invoice_Numberlbl)
        Me.FlowLayoutPanel1.Controls.Add(Me.Supplier_IDlbl)
        Me.FlowLayoutPanel1.Controls.Add(Me.Invoice_DateDatelbl)
        Me.FlowLayoutPanel1.Controls.Add(Me.Supplier_Invoice_NumberLbl)
        Me.FlowLayoutPanel1.Controls.Add(Me.NumberOfItemsLbl)
        Me.FlowLayoutPanel1.Controls.Add(Me.Invoice_Number)
        Me.FlowLayoutPanel1.Controls.Add(Me.Supplier_ID)
        Me.FlowLayoutPanel1.Controls.Add(Me.Invoice_Date)
        Me.FlowLayoutPanel1.Controls.Add(Me.Supplier_Invoice_Number)
        Me.FlowLayoutPanel1.Controls.Add(Me.NumberOfItems)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 57)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1287, 88)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'Invoice_Numberlbl
        '
        Me.Invoice_Numberlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Invoice_Numberlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Invoice_Numberlbl.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Invoice_Numberlbl.ForeColor = System.Drawing.Color.White
        Me.Invoice_Numberlbl.Location = New System.Drawing.Point(1061, 0)
        Me.Invoice_Numberlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Invoice_Numberlbl.Name = "Invoice_Numberlbl"
        Me.Invoice_Numberlbl.Size = New System.Drawing.Size(220, 38)
        Me.Invoice_Numberlbl.TabIndex = 3
        Me.Invoice_Numberlbl.Text = "رقم الاذن"
        Me.Invoice_Numberlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Supplier_IDlbl
        '
        Me.Supplier_IDlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Supplier_IDlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Supplier_IDlbl.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Supplier_IDlbl.ForeColor = System.Drawing.Color.White
        Me.Supplier_IDlbl.Location = New System.Drawing.Point(835, 0)
        Me.Supplier_IDlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Supplier_IDlbl.Name = "Supplier_IDlbl"
        Me.Supplier_IDlbl.Size = New System.Drawing.Size(222, 38)
        Me.Supplier_IDlbl.TabIndex = 7
        Me.Supplier_IDlbl.Text = "اسم المورد"
        Me.Supplier_IDlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Invoice_DateDatelbl
        '
        Me.Invoice_DateDatelbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Invoice_DateDatelbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Invoice_DateDatelbl.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Invoice_DateDatelbl.ForeColor = System.Drawing.Color.White
        Me.Invoice_DateDatelbl.Location = New System.Drawing.Point(544, 0)
        Me.Invoice_DateDatelbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Invoice_DateDatelbl.Name = "Invoice_DateDatelbl"
        Me.Invoice_DateDatelbl.Size = New System.Drawing.Size(287, 38)
        Me.Invoice_DateDatelbl.TabIndex = 8
        Me.Invoice_DateDatelbl.Text = "تاريخ الاذن"
        Me.Invoice_DateDatelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Supplier_Invoice_NumberLbl
        '
        Me.Supplier_Invoice_NumberLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Supplier_Invoice_NumberLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Supplier_Invoice_NumberLbl.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Supplier_Invoice_NumberLbl.ForeColor = System.Drawing.Color.White
        Me.Supplier_Invoice_NumberLbl.Location = New System.Drawing.Point(264, 0)
        Me.Supplier_Invoice_NumberLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Supplier_Invoice_NumberLbl.Name = "Supplier_Invoice_NumberLbl"
        Me.Supplier_Invoice_NumberLbl.Size = New System.Drawing.Size(276, 38)
        Me.Supplier_Invoice_NumberLbl.TabIndex = 144
        Me.Supplier_Invoice_NumberLbl.Text = "رقم الاذن للمورد"
        Me.Supplier_Invoice_NumberLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumberOfItemsLbl
        '
        Me.NumberOfItemsLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumberOfItemsLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.NumberOfItemsLbl.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberOfItemsLbl.ForeColor = System.Drawing.Color.White
        Me.NumberOfItemsLbl.Location = New System.Drawing.Point(54, 0)
        Me.NumberOfItemsLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.NumberOfItemsLbl.Name = "NumberOfItemsLbl"
        Me.NumberOfItemsLbl.Size = New System.Drawing.Size(206, 38)
        Me.NumberOfItemsLbl.TabIndex = 145
        Me.NumberOfItemsLbl.Text = "عدد الاصناف"
        Me.NumberOfItemsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Invoice_Number
        '
        Me.Invoice_Number.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Invoice_Number.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Invoice_Number.Location = New System.Drawing.Point(1061, 42)
        Me.Invoice_Number.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Invoice_Number.Name = "Invoice_Number"
        Me.Invoice_Number.Size = New System.Drawing.Size(220, 39)
        Me.Invoice_Number.TabIndex = 146
        Me.Invoice_Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Supplier_ID
        '
        Me.Supplier_ID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Supplier_ID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Supplier_ID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Supplier_ID.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Supplier_ID.FormattingEnabled = True
        Me.Supplier_ID.Location = New System.Drawing.Point(835, 41)
        Me.Supplier_ID.Name = "Supplier_ID"
        Me.Supplier_ID.Size = New System.Drawing.Size(221, 40)
        Me.Supplier_ID.TabIndex = 147
        '
        'Invoice_Date
        '
        Me.Invoice_Date.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Invoice_Date.CalendarFont = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Invoice_Date.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Invoice_Date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Invoice_Date.Location = New System.Drawing.Point(544, 42)
        Me.Invoice_Date.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Invoice_Date.Name = "Invoice_Date"
        Me.Invoice_Date.Size = New System.Drawing.Size(286, 39)
        Me.Invoice_Date.TabIndex = 148
        '
        'Supplier_Invoice_Number
        '
        Me.Supplier_Invoice_Number.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Supplier_Invoice_Number.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Supplier_Invoice_Number.Location = New System.Drawing.Point(264, 42)
        Me.Supplier_Invoice_Number.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Supplier_Invoice_Number.Name = "Supplier_Invoice_Number"
        Me.Supplier_Invoice_Number.Size = New System.Drawing.Size(276, 39)
        Me.Supplier_Invoice_Number.TabIndex = 149
        Me.Supplier_Invoice_Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NumberOfItems
        '
        Me.NumberOfItems.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumberOfItems.Enabled = False
        Me.NumberOfItems.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberOfItems.Location = New System.Drawing.Point(54, 42)
        Me.NumberOfItems.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.NumberOfItems.Name = "NumberOfItems"
        Me.NumberOfItems.ReadOnly = True
        Me.NumberOfItems.Size = New System.Drawing.Size(206, 39)
        Me.NumberOfItems.TabIndex = 150
        Me.NumberOfItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.dgv_Tbl_InvoiceItems)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 145)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1287, 490)
        Me.Panel3.TabIndex = 3
        '
        'dgv_Tbl_InvoiceItems
        '
        Me.dgv_Tbl_InvoiceItems.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_Tbl_InvoiceItems.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Tbl_InvoiceItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgv_Tbl_InvoiceItems.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Tbl_InvoiceItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_Tbl_InvoiceItems.ColumnHeadersHeight = 40
        Me.dgv_Tbl_InvoiceItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGV_Product_ID, Me.DGV_Product_Name, Me.DGV_QTE_IN_STOCK, Me.DGV_ID_CAT, Me.DGV_Unit_ID, Me.DGV_Unit_Name, Me.DGV_Initial_Balance, Me.DGV_Unit_Price, Me.DGV_Minimum_Threshold, Me.DGV_Maximum_Threshold, Me.DGV_Add_Balance, Me.DGV_Total_Unit_Price, Me.DGV_Machine_Unit, Me.DGV_Notes})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.dgv_Tbl_InvoiceItems.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Tbl_InvoiceItems.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_Tbl_InvoiceItems.RowHeadersVisible = False
        Me.dgv_Tbl_InvoiceItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_Tbl_InvoiceItems.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_Tbl_InvoiceItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Tbl_InvoiceItems.Size = New System.Drawing.Size(1283, 486)
        Me.dgv_Tbl_InvoiceItems.TabIndex = 114
        '
        'DGV_Product_ID
        '
        Me.DGV_Product_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DGV_Product_ID.HeaderText = "كود الصنف"
        Me.DGV_Product_ID.MinimumWidth = 6
        Me.DGV_Product_ID.Name = "DGV_Product_ID"
        Me.DGV_Product_ID.Width = 126
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
        Me.DGV_QTE_IN_STOCK.Width = 139
        '
        'DGV_ID_CAT
        '
        Me.DGV_ID_CAT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DGV_ID_CAT.HeaderText = "اسم التصنيف"
        Me.DGV_ID_CAT.MinimumWidth = 6
        Me.DGV_ID_CAT.Name = "DGV_ID_CAT"
        Me.DGV_ID_CAT.ReadOnly = True
        Me.DGV_ID_CAT.Visible = False
        Me.DGV_ID_CAT.Width = 142
        '
        'DGV_Unit_ID
        '
        Me.DGV_Unit_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DGV_Unit_ID.HeaderText = "كود الوحدة"
        Me.DGV_Unit_ID.MinimumWidth = 6
        Me.DGV_Unit_ID.Name = "DGV_Unit_ID"
        Me.DGV_Unit_ID.ReadOnly = True
        Me.DGV_Unit_ID.Visible = False
        Me.DGV_Unit_ID.Width = 128
        '
        'DGV_Unit_Name
        '
        Me.DGV_Unit_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DGV_Unit_Name.HeaderText = "اسم الوحدة"
        Me.DGV_Unit_Name.MinimumWidth = 6
        Me.DGV_Unit_Name.Name = "DGV_Unit_Name"
        Me.DGV_Unit_Name.ReadOnly = True
        Me.DGV_Unit_Name.Width = 130
        '
        'DGV_Initial_Balance
        '
        Me.DGV_Initial_Balance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DGV_Initial_Balance.HeaderText = "الرصيد الافتتاحى"
        Me.DGV_Initial_Balance.MinimumWidth = 6
        Me.DGV_Initial_Balance.Name = "DGV_Initial_Balance"
        Me.DGV_Initial_Balance.ReadOnly = True
        Me.DGV_Initial_Balance.Width = 167
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
        Me.DGV_Minimum_Threshold.Visible = False
        Me.DGV_Minimum_Threshold.Width = 116
        '
        'DGV_Maximum_Threshold
        '
        Me.DGV_Maximum_Threshold.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DGV_Maximum_Threshold.HeaderText = "اعلى كمية"
        Me.DGV_Maximum_Threshold.MinimumWidth = 6
        Me.DGV_Maximum_Threshold.Name = "DGV_Maximum_Threshold"
        Me.DGV_Maximum_Threshold.ReadOnly = True
        Me.DGV_Maximum_Threshold.Visible = False
        Me.DGV_Maximum_Threshold.Width = 122
        '
        'DGV_Add_Balance
        '
        Me.DGV_Add_Balance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DGV_Add_Balance.HeaderText = "الكمية المضافة"
        Me.DGV_Add_Balance.MinimumWidth = 6
        Me.DGV_Add_Balance.Name = "DGV_Add_Balance"
        Me.DGV_Add_Balance.Width = 164
        '
        'DGV_Total_Unit_Price
        '
        Me.DGV_Total_Unit_Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DGV_Total_Unit_Price.HeaderText = "اجمالى السعر للصنف"
        Me.DGV_Total_Unit_Price.MinimumWidth = 6
        Me.DGV_Total_Unit_Price.Name = "DGV_Total_Unit_Price"
        Me.DGV_Total_Unit_Price.ReadOnly = True
        Me.DGV_Total_Unit_Price.Visible = False
        Me.DGV_Total_Unit_Price.Width = 196
        '
        'DGV_Machine_Unit
        '
        Me.DGV_Machine_Unit.HeaderText = "جزء الماكينة"
        Me.DGV_Machine_Unit.MinimumWidth = 6
        Me.DGV_Machine_Unit.Name = "DGV_Machine_Unit"
        Me.DGV_Machine_Unit.Visible = False
        Me.DGV_Machine_Unit.Width = 125
        '
        'DGV_Notes
        '
        Me.DGV_Notes.HeaderText = "بيان"
        Me.DGV_Notes.MinimumWidth = 6
        Me.DGV_Notes.Name = "DGV_Notes"
        Me.DGV_Notes.Visible = False
        Me.DGV_Notes.Width = 125
        '
        'Ezn_Edafah_New
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1287, 718)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "Ezn_Edafah_New"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "إذن إضافة"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgv_Tbl_InvoiceItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Lbl_NumberOfItems As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_Export_Excel As Button
    Friend WithEvents Btn_Add_Group_Codes As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents Btn_Add_Products As Button
    Friend WithEvents Btn_Search_Products As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnNewAdd As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Invoice_Numberlbl As Label
    Friend WithEvents Supplier_IDlbl As Label
    Friend WithEvents Invoice_DateDatelbl As Label
    Friend WithEvents Supplier_Invoice_NumberLbl As Label
    Friend WithEvents Total_Invoice_ValueLbl As Label
    Friend WithEvents Total_Invoice_Value As TextBox
    Friend WithEvents NumberOfItemsLbl As Label
    Friend WithEvents Invoice_Number As TextBox
    Friend WithEvents Supplier_ID As ComboBox
    Friend WithEvents Invoice_Date As DateTimePicker
    Friend WithEvents Supplier_Invoice_Number As TextBox
    Friend WithEvents NumberOfItems As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dgv_Tbl_InvoiceItems As DataGridView
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
    Friend WithEvents DGV_Machine_Unit As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Notes As DataGridViewTextBoxColumn
    Friend WithEvents Invoice_ID As TextBox
    Friend WithEvents Calculator As Button
End Class
