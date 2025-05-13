<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Document_Query_Delete
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Supplier_Invoice_Number = New System.Windows.Forms.TextBox()
        Me.Supplier_Invoice_NumberLbl = New System.Windows.Forms.Label()
        Me.Total_Invoice_ValueLbl = New System.Windows.Forms.Label()
        Me.Total_Invoice_Value = New System.Windows.Forms.TextBox()
        Me.Invoice_Numberlbl = New System.Windows.Forms.Label()
        Me.Invoice_Number = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Invoice_TypeLbL = New System.Windows.Forms.Label()
        Me.NumberOfItemsLbl = New System.Windows.Forms.Label()
        Me.Customer_IDLbl = New System.Windows.Forms.Label()
        Me.Invoice_Type_SearchLbl = New System.Windows.Forms.Label()
        Me.Supplier_IDlbl = New System.Windows.Forms.Label()
        Me.Invoice_Date = New System.Windows.Forms.DateTimePicker()
        Me.Invoice_Type = New System.Windows.Forms.TextBox()
        Me.Invoice_DateDatelbl = New System.Windows.Forms.Label()
        Me.NumberOfItems = New System.Windows.Forms.TextBox()
        Me.Customer_ID = New System.Windows.Forms.ComboBox()
        Me.Invoice_Type_Search = New System.Windows.Forms.ComboBox()
        Me.Supplier_ID = New System.Windows.Forms.ComboBox()
        Me.Btn_Delet = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Invoice_IDlbl = New System.Windows.Forms.Label()
        Me.Invoice_ID = New System.Windows.Forms.TextBox()
        Me.dgv_Tbl_InvoiceItems = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_Tbl_InvoiceItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Supplier_Invoice_Number
        '
        Me.Supplier_Invoice_Number.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Supplier_Invoice_Number.Enabled = False
        Me.Supplier_Invoice_Number.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Supplier_Invoice_Number.Location = New System.Drawing.Point(877, 111)
        Me.Supplier_Invoice_Number.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Supplier_Invoice_Number.Name = "Supplier_Invoice_Number"
        Me.Supplier_Invoice_Number.ReadOnly = True
        Me.Supplier_Invoice_Number.Size = New System.Drawing.Size(203, 38)
        Me.Supplier_Invoice_Number.TabIndex = 144
        Me.Supplier_Invoice_Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Supplier_Invoice_NumberLbl
        '
        Me.Supplier_Invoice_NumberLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Supplier_Invoice_NumberLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Supplier_Invoice_NumberLbl.ForeColor = System.Drawing.Color.Black
        Me.Supplier_Invoice_NumberLbl.Location = New System.Drawing.Point(1089, 113)
        Me.Supplier_Invoice_NumberLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Supplier_Invoice_NumberLbl.Name = "Supplier_Invoice_NumberLbl"
        Me.Supplier_Invoice_NumberLbl.Size = New System.Drawing.Size(237, 34)
        Me.Supplier_Invoice_NumberLbl.TabIndex = 143
        Me.Supplier_Invoice_NumberLbl.Text = "رقم الاذن للمورد"
        Me.Supplier_Invoice_NumberLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Total_Invoice_ValueLbl
        '
        Me.Total_Invoice_ValueLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Total_Invoice_ValueLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Total_Invoice_ValueLbl.ForeColor = System.Drawing.Color.Black
        Me.Total_Invoice_ValueLbl.Location = New System.Drawing.Point(570, 129)
        Me.Total_Invoice_ValueLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Total_Invoice_ValueLbl.Name = "Total_Invoice_ValueLbl"
        Me.Total_Invoice_ValueLbl.Size = New System.Drawing.Size(237, 34)
        Me.Total_Invoice_ValueLbl.TabIndex = 138
        Me.Total_Invoice_ValueLbl.Text = "الاجمالى الكلى للفاتورة"
        Me.Total_Invoice_ValueLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Total_Invoice_ValueLbl.Visible = False
        '
        'Total_Invoice_Value
        '
        Me.Total_Invoice_Value.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Total_Invoice_Value.Enabled = False
        Me.Total_Invoice_Value.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total_Invoice_Value.Location = New System.Drawing.Point(498, 129)
        Me.Total_Invoice_Value.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Total_Invoice_Value.Name = "Total_Invoice_Value"
        Me.Total_Invoice_Value.ReadOnly = True
        Me.Total_Invoice_Value.Size = New System.Drawing.Size(68, 38)
        Me.Total_Invoice_Value.TabIndex = 139
        Me.Total_Invoice_Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Total_Invoice_Value.Visible = False
        '
        'Invoice_Numberlbl
        '
        Me.Invoice_Numberlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Invoice_Numberlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Invoice_Numberlbl.ForeColor = System.Drawing.Color.Black
        Me.Invoice_Numberlbl.Location = New System.Drawing.Point(1089, 25)
        Me.Invoice_Numberlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Invoice_Numberlbl.Name = "Invoice_Numberlbl"
        Me.Invoice_Numberlbl.Size = New System.Drawing.Size(237, 34)
        Me.Invoice_Numberlbl.TabIndex = 2
        Me.Invoice_Numberlbl.Text = "ابحث هنا برقم الاذن"
        Me.Invoice_Numberlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Invoice_Number
        '
        Me.Invoice_Number.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Invoice_Number.BackColor = System.Drawing.Color.White
        Me.Invoice_Number.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Invoice_Number.ForeColor = System.Drawing.Color.Black
        Me.Invoice_Number.Location = New System.Drawing.Point(875, 25)
        Me.Invoice_Number.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Invoice_Number.Name = "Invoice_Number"
        Me.Invoice_Number.Size = New System.Drawing.Size(205, 38)
        Me.Invoice_Number.TabIndex = 1
        Me.Invoice_Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Teal
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Supplier_Invoice_Number)
        Me.GroupBox1.Controls.Add(Me.Supplier_Invoice_NumberLbl)
        Me.GroupBox1.Controls.Add(Me.Total_Invoice_ValueLbl)
        Me.GroupBox1.Controls.Add(Me.Total_Invoice_Value)
        Me.GroupBox1.Controls.Add(Me.Invoice_TypeLbL)
        Me.GroupBox1.Controls.Add(Me.NumberOfItemsLbl)
        Me.GroupBox1.Controls.Add(Me.Invoice_Numberlbl)
        Me.GroupBox1.Controls.Add(Me.Customer_IDLbl)
        Me.GroupBox1.Controls.Add(Me.Invoice_Type_SearchLbl)
        Me.GroupBox1.Controls.Add(Me.Supplier_IDlbl)
        Me.GroupBox1.Controls.Add(Me.Invoice_Date)
        Me.GroupBox1.Controls.Add(Me.Invoice_Type)
        Me.GroupBox1.Controls.Add(Me.Invoice_DateDatelbl)
        Me.GroupBox1.Controls.Add(Me.NumberOfItems)
        Me.GroupBox1.Controls.Add(Me.Customer_ID)
        Me.GroupBox1.Controls.Add(Me.Invoice_Type_Search)
        Me.GroupBox1.Controls.Add(Me.Invoice_Number)
        Me.GroupBox1.Controls.Add(Me.Supplier_ID)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1338, 209)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "بيانات المستند"
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Questv1", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Blue
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.Location = New System.Drawing.Point(1089, 25)
        Me.Button4.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(82, 32)
        Me.Button4.TabIndex = 145
        Me.Button4.Text = "تفريغ الحقول"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Invoice_TypeLbL
        '
        Me.Invoice_TypeLbL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Invoice_TypeLbL.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Invoice_TypeLbL.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Invoice_TypeLbL.ForeColor = System.Drawing.Color.Black
        Me.Invoice_TypeLbL.Location = New System.Drawing.Point(320, 23)
        Me.Invoice_TypeLbL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Invoice_TypeLbL.Name = "Invoice_TypeLbL"
        Me.Invoice_TypeLbL.Size = New System.Drawing.Size(165, 34)
        Me.Invoice_TypeLbL.TabIndex = 2
        Me.Invoice_TypeLbL.Text = "نوع المستند"
        Me.Invoice_TypeLbL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumberOfItemsLbl
        '
        Me.NumberOfItemsLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumberOfItemsLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.NumberOfItemsLbl.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberOfItemsLbl.ForeColor = System.Drawing.Color.Black
        Me.NumberOfItemsLbl.Location = New System.Drawing.Point(1089, 155)
        Me.NumberOfItemsLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.NumberOfItemsLbl.Name = "NumberOfItemsLbl"
        Me.NumberOfItemsLbl.Size = New System.Drawing.Size(238, 34)
        Me.NumberOfItemsLbl.TabIndex = 2
        Me.NumberOfItemsLbl.Text = "عدد الاصناف"
        Me.NumberOfItemsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Customer_IDLbl
        '
        Me.Customer_IDLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Customer_IDLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Customer_IDLbl.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Customer_IDLbl.ForeColor = System.Drawing.Color.Black
        Me.Customer_IDLbl.Location = New System.Drawing.Point(320, 115)
        Me.Customer_IDLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Customer_IDLbl.Name = "Customer_IDLbl"
        Me.Customer_IDLbl.Size = New System.Drawing.Size(166, 34)
        Me.Customer_IDLbl.TabIndex = 6
        Me.Customer_IDLbl.Text = "اسم العميل"
        Me.Customer_IDLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Invoice_Type_SearchLbl
        '
        Me.Invoice_Type_SearchLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Invoice_Type_SearchLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Invoice_Type_SearchLbl.ForeColor = System.Drawing.Color.Black
        Me.Invoice_Type_SearchLbl.Location = New System.Drawing.Point(577, 30)
        Me.Invoice_Type_SearchLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Invoice_Type_SearchLbl.Name = "Invoice_Type_SearchLbl"
        Me.Invoice_Type_SearchLbl.Size = New System.Drawing.Size(166, 34)
        Me.Invoice_Type_SearchLbl.TabIndex = 6
        Me.Invoice_Type_SearchLbl.Text = "ابحث بنوع المستند"
        Me.Invoice_Type_SearchLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Supplier_IDlbl
        '
        Me.Supplier_IDlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Supplier_IDlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Supplier_IDlbl.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Supplier_IDlbl.ForeColor = System.Drawing.Color.Black
        Me.Supplier_IDlbl.Location = New System.Drawing.Point(320, 69)
        Me.Supplier_IDlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Supplier_IDlbl.Name = "Supplier_IDlbl"
        Me.Supplier_IDlbl.Size = New System.Drawing.Size(166, 34)
        Me.Supplier_IDlbl.TabIndex = 6
        Me.Supplier_IDlbl.Text = "اسم المورد"
        Me.Supplier_IDlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Invoice_Date
        '
        Me.Invoice_Date.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Invoice_Date.CalendarFont = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Invoice_Date.Enabled = False
        Me.Invoice_Date.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Invoice_Date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Invoice_Date.Location = New System.Drawing.Point(875, 72)
        Me.Invoice_Date.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Invoice_Date.Name = "Invoice_Date"
        Me.Invoice_Date.Size = New System.Drawing.Size(205, 30)
        Me.Invoice_Date.TabIndex = 5
        '
        'Invoice_Type
        '
        Me.Invoice_Type.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Invoice_Type.Enabled = False
        Me.Invoice_Type.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Invoice_Type.Location = New System.Drawing.Point(38, 23)
        Me.Invoice_Type.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Invoice_Type.Name = "Invoice_Type"
        Me.Invoice_Type.ReadOnly = True
        Me.Invoice_Type.Size = New System.Drawing.Size(274, 38)
        Me.Invoice_Type.TabIndex = 3
        Me.Invoice_Type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Invoice_DateDatelbl
        '
        Me.Invoice_DateDatelbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Invoice_DateDatelbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Invoice_DateDatelbl.ForeColor = System.Drawing.Color.Black
        Me.Invoice_DateDatelbl.Location = New System.Drawing.Point(1089, 69)
        Me.Invoice_DateDatelbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Invoice_DateDatelbl.Name = "Invoice_DateDatelbl"
        Me.Invoice_DateDatelbl.Size = New System.Drawing.Size(237, 34)
        Me.Invoice_DateDatelbl.TabIndex = 4
        Me.Invoice_DateDatelbl.Text = "تاريخ الاذن"
        Me.Invoice_DateDatelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumberOfItems
        '
        Me.NumberOfItems.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumberOfItems.Enabled = False
        Me.NumberOfItems.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberOfItems.Location = New System.Drawing.Point(877, 155)
        Me.NumberOfItems.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.NumberOfItems.Name = "NumberOfItems"
        Me.NumberOfItems.ReadOnly = True
        Me.NumberOfItems.Size = New System.Drawing.Size(203, 38)
        Me.NumberOfItems.TabIndex = 3
        Me.NumberOfItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Customer_ID
        '
        Me.Customer_ID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Customer_ID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Customer_ID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Customer_ID.Enabled = False
        Me.Customer_ID.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Customer_ID.FormattingEnabled = True
        Me.Customer_ID.Location = New System.Drawing.Point(39, 113)
        Me.Customer_ID.Name = "Customer_ID"
        Me.Customer_ID.Size = New System.Drawing.Size(274, 40)
        Me.Customer_ID.TabIndex = 116
        '
        'Invoice_Type_Search
        '
        Me.Invoice_Type_Search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Invoice_Type_Search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Invoice_Type_Search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Invoice_Type_Search.FormattingEnabled = True
        Me.Invoice_Type_Search.Items.AddRange(New Object() {"اذن صرف", "اذن وارد", "اذن مرتجع عميل", "اذن مرتجع مورد"})
        Me.Invoice_Type_Search.Location = New System.Drawing.Point(577, 75)
        Me.Invoice_Type_Search.Name = "Invoice_Type_Search"
        Me.Invoice_Type_Search.Size = New System.Drawing.Size(166, 35)
        Me.Invoice_Type_Search.TabIndex = 116
        '
        'Supplier_ID
        '
        Me.Supplier_ID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Supplier_ID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Supplier_ID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Supplier_ID.Enabled = False
        Me.Supplier_ID.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Supplier_ID.FormattingEnabled = True
        Me.Supplier_ID.Location = New System.Drawing.Point(39, 67)
        Me.Supplier_ID.Name = "Supplier_ID"
        Me.Supplier_ID.Size = New System.Drawing.Size(274, 40)
        Me.Supplier_ID.TabIndex = 116
        '
        'Btn_Delet
        '
        Me.Btn_Delet.FlatAppearance.BorderSize = 0
        Me.Btn_Delet.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Delet.Font = New System.Drawing.Font("Questv1", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Delet.Image = My.Resources.Resources.Remove1
        Me.Btn_Delet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Delet.Location = New System.Drawing.Point(570, 4)
        Me.Btn_Delet.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.Btn_Delet.Name = "Btn_Delet"
        Me.Btn_Delet.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Btn_Delet.Size = New System.Drawing.Size(132, 50)
        Me.Btn_Delet.TabIndex = 146
        Me.Btn_Delet.Text = "حذف"
        Me.Btn_Delet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Delet.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Invoice_IDlbl)
        Me.Panel1.Controls.Add(Me.Invoice_ID)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1338, 38)
        Me.Panel1.TabIndex = 143
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Teal
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Cairo", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1338, 38)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "حذف مستند"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Invoice_IDlbl
        '
        Me.Invoice_IDlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Invoice_IDlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Invoice_IDlbl.ForeColor = System.Drawing.Color.White
        Me.Invoice_IDlbl.Location = New System.Drawing.Point(123, 0)
        Me.Invoice_IDlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Invoice_IDlbl.Name = "Invoice_IDlbl"
        Me.Invoice_IDlbl.Size = New System.Drawing.Size(140, 34)
        Me.Invoice_IDlbl.TabIndex = 16
        Me.Invoice_IDlbl.Text = "كود المستند"
        Me.Invoice_IDlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Invoice_IDlbl.Visible = False
        '
        'Invoice_ID
        '
        Me.Invoice_ID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Invoice_ID.Enabled = False
        Me.Invoice_ID.Location = New System.Drawing.Point(123, 13)
        Me.Invoice_ID.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Invoice_ID.Name = "Invoice_ID"
        Me.Invoice_ID.ReadOnly = True
        Me.Invoice_ID.Size = New System.Drawing.Size(140, 34)
        Me.Invoice_ID.TabIndex = 17
        Me.Invoice_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Invoice_ID.Visible = False
        '
        'dgv_Tbl_InvoiceItems
        '
        Me.dgv_Tbl_InvoiceItems.AllowUserToAddRows = False
        Me.dgv_Tbl_InvoiceItems.AllowUserToDeleteRows = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Cairo", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv_Tbl_InvoiceItems.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_Tbl_InvoiceItems.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_Tbl_InvoiceItems.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Tbl_InvoiceItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgv_Tbl_InvoiceItems.ColumnHeadersHeight = 40
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Tbl_InvoiceItems.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgv_Tbl_InvoiceItems.EnableHeadersVisualStyles = False
        Me.dgv_Tbl_InvoiceItems.Location = New System.Drawing.Point(0, 8)
        Me.dgv_Tbl_InvoiceItems.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.dgv_Tbl_InvoiceItems.Name = "dgv_Tbl_InvoiceItems"
        Me.dgv_Tbl_InvoiceItems.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Tbl_InvoiceItems.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgv_Tbl_InvoiceItems.RowHeadersVisible = False
        Me.dgv_Tbl_InvoiceItems.RowHeadersWidth = 51
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Cairo SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_Tbl_InvoiceItems.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgv_Tbl_InvoiceItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Tbl_InvoiceItems.Size = New System.Drawing.Size(1344, 470)
        Me.dgv_Tbl_InvoiceItems.TabIndex = 142
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 38)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1338, 209)
        Me.Panel3.TabIndex = 145
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Teal
        Me.Panel4.Controls.Add(Me.dgv_Tbl_InvoiceItems)
        Me.Panel4.Location = New System.Drawing.Point(0, 247)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1344, 478)
        Me.Panel4.TabIndex = 146
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Teal
        Me.Panel2.Controls.Add(Me.Btn_Delet)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 690)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1338, 60)
        Me.Panel2.TabIndex = 147
        '
        'Document_Query_Delete
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1338, 750)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Document_Query_Delete"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv_Tbl_InvoiceItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Supplier_Invoice_Number As TextBox
    Friend WithEvents Supplier_Invoice_NumberLbl As Label
    Friend WithEvents Total_Invoice_ValueLbl As Label
    Friend WithEvents Total_Invoice_Value As TextBox
    Friend WithEvents Invoice_Numberlbl As Label
    Friend WithEvents Invoice_Number As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents NumberOfItemsLbl As Label
    Friend WithEvents Supplier_IDlbl As Label
    Friend WithEvents Invoice_Date As DateTimePicker
    Friend WithEvents Invoice_DateDatelbl As Label
    Friend WithEvents NumberOfItems As TextBox
    Friend WithEvents Supplier_ID As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Invoice_IDlbl As Label
    Friend WithEvents Invoice_ID As TextBox
    Friend WithEvents dgv_Tbl_InvoiceItems As DataGridView
    Friend WithEvents Customer_IDLbl As Label
    Friend WithEvents Customer_ID As ComboBox
    Friend WithEvents Invoice_TypeLbL As Label
    Friend WithEvents Invoice_Type As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Invoice_Type_SearchLbl As Label
    Friend WithEvents Invoice_Type_Search As ComboBox
    Friend WithEvents Btn_Delet As Button
    Friend WithEvents Panel2 As Panel
End Class
