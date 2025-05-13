<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Document_Query_Test
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Document_Query_Test))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Total_Invoice_ValueLbl = New System.Windows.Forms.Label()
        Me.Total_Invoice_Value = New System.Windows.Forms.TextBox()
        Me.Txt_User = New System.Windows.Forms.TextBox()
        Me.Txt_UserID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Invoice_Numberlbl = New System.Windows.Forms.Label()
        Me.Invoice_DateDatelbl = New System.Windows.Forms.Label()
        Me.Supplier_Invoice_NumberLbl = New System.Windows.Forms.Label()
        Me.NumberOfItemsLbl = New System.Windows.Forms.Label()
        Me.Invoice_TypeLbL = New System.Windows.Forms.Label()
        Me.Supplier_IDlbl = New System.Windows.Forms.Label()
        Me.Customer_IDLbl = New System.Windows.Forms.Label()
        Me.Invoice_Type_SearchLbl = New System.Windows.Forms.Label()
        Me.Invoice_Number = New System.Windows.Forms.TextBox()
        Me.Invoice_Date = New System.Windows.Forms.DateTimePicker()
        Me.Supplier_Invoice_Number = New System.Windows.Forms.TextBox()
        Me.NumberOfItems = New System.Windows.Forms.TextBox()
        Me.Invoice_Type = New System.Windows.Forms.TextBox()
        Me.Supplier_ID = New System.Windows.Forms.ComboBox()
        Me.Customer_ID = New System.Windows.Forms.ComboBox()
        Me.Invoice_Type_Search = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Btn_Show_Edit_Price = New System.Windows.Forms.Button()
        Me.Btn_ExportToExcel = New System.Windows.Forms.Button()
        Me.Btn_Print = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgv_Tbl_InvoiceItems = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgv_Tbl_InvoiceItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Total_Invoice_ValueLbl)
        Me.Panel1.Controls.Add(Me.Total_Invoice_Value)
        Me.Panel1.Controls.Add(Me.Txt_User)
        Me.Panel1.Controls.Add(Me.Txt_UserID)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1428, 51)
        Me.Panel1.TabIndex = 0
        '
        'Total_Invoice_ValueLbl
        '
        Me.Total_Invoice_ValueLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Total_Invoice_ValueLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Total_Invoice_ValueLbl.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total_Invoice_ValueLbl.ForeColor = System.Drawing.Color.Black
        Me.Total_Invoice_ValueLbl.Location = New System.Drawing.Point(1320, 4)
        Me.Total_Invoice_ValueLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Total_Invoice_ValueLbl.Name = "Total_Invoice_ValueLbl"
        Me.Total_Invoice_ValueLbl.Size = New System.Drawing.Size(97, 34)
        Me.Total_Invoice_ValueLbl.TabIndex = 140
        Me.Total_Invoice_ValueLbl.Text = "الاجمالى الكلى للفاتورة"
        Me.Total_Invoice_ValueLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Total_Invoice_ValueLbl.Visible = False
        '
        'Total_Invoice_Value
        '
        Me.Total_Invoice_Value.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Total_Invoice_Value.Enabled = False
        Me.Total_Invoice_Value.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total_Invoice_Value.Location = New System.Drawing.Point(1245, 4)
        Me.Total_Invoice_Value.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Total_Invoice_Value.Name = "Total_Invoice_Value"
        Me.Total_Invoice_Value.ReadOnly = True
        Me.Total_Invoice_Value.Size = New System.Drawing.Size(71, 32)
        Me.Total_Invoice_Value.TabIndex = 141
        Me.Total_Invoice_Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Total_Invoice_Value.Visible = False
        '
        'Txt_User
        '
        Me.Txt_User.Location = New System.Drawing.Point(121, 3)
        Me.Txt_User.Name = "Txt_User"
        Me.Txt_User.ReadOnly = True
        Me.Txt_User.Size = New System.Drawing.Size(107, 39)
        Me.Txt_User.TabIndex = 21
        Me.Txt_User.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Txt_User.Visible = False
        '
        'Txt_UserID
        '
        Me.Txt_UserID.Location = New System.Drawing.Point(8, 3)
        Me.Txt_UserID.Name = "Txt_UserID"
        Me.Txt_UserID.ReadOnly = True
        Me.Txt_UserID.Size = New System.Drawing.Size(107, 39)
        Me.Txt_UserID.TabIndex = 22
        Me.Txt_UserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Txt_UserID.Visible = False
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Cairo ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1428, 51)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "البحث عن مستند"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FlowLayoutPanel1.Controls.Add(Me.Invoice_Numberlbl)
        Me.FlowLayoutPanel1.Controls.Add(Me.Invoice_DateDatelbl)
        Me.FlowLayoutPanel1.Controls.Add(Me.Supplier_Invoice_NumberLbl)
        Me.FlowLayoutPanel1.Controls.Add(Me.NumberOfItemsLbl)
        Me.FlowLayoutPanel1.Controls.Add(Me.Invoice_TypeLbL)
        Me.FlowLayoutPanel1.Controls.Add(Me.Supplier_IDlbl)
        Me.FlowLayoutPanel1.Controls.Add(Me.Customer_IDLbl)
        Me.FlowLayoutPanel1.Controls.Add(Me.Invoice_Type_SearchLbl)
        Me.FlowLayoutPanel1.Controls.Add(Me.Invoice_Number)
        Me.FlowLayoutPanel1.Controls.Add(Me.Invoice_Date)
        Me.FlowLayoutPanel1.Controls.Add(Me.Supplier_Invoice_Number)
        Me.FlowLayoutPanel1.Controls.Add(Me.NumberOfItems)
        Me.FlowLayoutPanel1.Controls.Add(Me.Invoice_Type)
        Me.FlowLayoutPanel1.Controls.Add(Me.Supplier_ID)
        Me.FlowLayoutPanel1.Controls.Add(Me.Customer_ID)
        Me.FlowLayoutPanel1.Controls.Add(Me.Invoice_Type_Search)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 51)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1428, 92)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'Invoice_Numberlbl
        '
        Me.Invoice_Numberlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Invoice_Numberlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Invoice_Numberlbl.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Invoice_Numberlbl.ForeColor = System.Drawing.Color.Black
        Me.Invoice_Numberlbl.Location = New System.Drawing.Point(1256, 0)
        Me.Invoice_Numberlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Invoice_Numberlbl.Name = "Invoice_Numberlbl"
        Me.Invoice_Numberlbl.Size = New System.Drawing.Size(166, 39)
        Me.Invoice_Numberlbl.TabIndex = 3
        Me.Invoice_Numberlbl.Text = "رقم المستند"
        Me.Invoice_Numberlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Invoice_DateDatelbl
        '
        Me.Invoice_DateDatelbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Invoice_DateDatelbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Invoice_DateDatelbl.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Invoice_DateDatelbl.ForeColor = System.Drawing.Color.Black
        Me.Invoice_DateDatelbl.Location = New System.Drawing.Point(1086, 0)
        Me.Invoice_DateDatelbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Invoice_DateDatelbl.Name = "Invoice_DateDatelbl"
        Me.Invoice_DateDatelbl.Size = New System.Drawing.Size(166, 39)
        Me.Invoice_DateDatelbl.TabIndex = 5
        Me.Invoice_DateDatelbl.Text = "تاريخ المستند"
        Me.Invoice_DateDatelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Supplier_Invoice_NumberLbl
        '
        Me.Supplier_Invoice_NumberLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Supplier_Invoice_NumberLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Supplier_Invoice_NumberLbl.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Supplier_Invoice_NumberLbl.ForeColor = System.Drawing.Color.Black
        Me.Supplier_Invoice_NumberLbl.Location = New System.Drawing.Point(937, 0)
        Me.Supplier_Invoice_NumberLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Supplier_Invoice_NumberLbl.Name = "Supplier_Invoice_NumberLbl"
        Me.Supplier_Invoice_NumberLbl.Size = New System.Drawing.Size(145, 39)
        Me.Supplier_Invoice_NumberLbl.TabIndex = 144
        Me.Supplier_Invoice_NumberLbl.Text = "رقم الاذن للمورد"
        Me.Supplier_Invoice_NumberLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumberOfItemsLbl
        '
        Me.NumberOfItemsLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumberOfItemsLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.NumberOfItemsLbl.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberOfItemsLbl.ForeColor = System.Drawing.Color.Black
        Me.NumberOfItemsLbl.Location = New System.Drawing.Point(807, 0)
        Me.NumberOfItemsLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.NumberOfItemsLbl.Name = "NumberOfItemsLbl"
        Me.NumberOfItemsLbl.Size = New System.Drawing.Size(126, 39)
        Me.NumberOfItemsLbl.TabIndex = 145
        Me.NumberOfItemsLbl.Text = "عدد المدخلات"
        Me.NumberOfItemsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Invoice_TypeLbL
        '
        Me.Invoice_TypeLbL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Invoice_TypeLbL.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Invoice_TypeLbL.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Invoice_TypeLbL.ForeColor = System.Drawing.Color.Black
        Me.Invoice_TypeLbL.Location = New System.Drawing.Point(640, 0)
        Me.Invoice_TypeLbL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Invoice_TypeLbL.Name = "Invoice_TypeLbL"
        Me.Invoice_TypeLbL.Size = New System.Drawing.Size(163, 39)
        Me.Invoice_TypeLbL.TabIndex = 146
        Me.Invoice_TypeLbL.Text = "نوع المستند"
        Me.Invoice_TypeLbL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Supplier_IDlbl
        '
        Me.Supplier_IDlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Supplier_IDlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Supplier_IDlbl.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Supplier_IDlbl.ForeColor = System.Drawing.Color.Black
        Me.Supplier_IDlbl.Location = New System.Drawing.Point(395, 0)
        Me.Supplier_IDlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Supplier_IDlbl.Name = "Supplier_IDlbl"
        Me.Supplier_IDlbl.Size = New System.Drawing.Size(241, 39)
        Me.Supplier_IDlbl.TabIndex = 147
        Me.Supplier_IDlbl.Text = "اسم المورد"
        Me.Supplier_IDlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Customer_IDLbl
        '
        Me.Customer_IDLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Customer_IDLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Customer_IDLbl.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Customer_IDLbl.ForeColor = System.Drawing.Color.Black
        Me.Customer_IDLbl.Location = New System.Drawing.Point(170, 0)
        Me.Customer_IDLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Customer_IDLbl.Name = "Customer_IDLbl"
        Me.Customer_IDLbl.Size = New System.Drawing.Size(221, 39)
        Me.Customer_IDLbl.TabIndex = 155
        Me.Customer_IDLbl.Text = "اسم العميل"
        Me.Customer_IDLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Invoice_Type_SearchLbl
        '
        Me.Invoice_Type_SearchLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Invoice_Type_SearchLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Invoice_Type_SearchLbl.ForeColor = System.Drawing.Color.Black
        Me.Invoice_Type_SearchLbl.Location = New System.Drawing.Point(6, 0)
        Me.Invoice_Type_SearchLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Invoice_Type_SearchLbl.Name = "Invoice_Type_SearchLbl"
        Me.Invoice_Type_SearchLbl.Size = New System.Drawing.Size(160, 39)
        Me.Invoice_Type_SearchLbl.TabIndex = 148
        Me.Invoice_Type_SearchLbl.Text = "ابحث بنوع المستند"
        Me.Invoice_Type_SearchLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Invoice_Number
        '
        Me.Invoice_Number.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Invoice_Number.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Invoice_Number.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Invoice_Number.ForeColor = System.Drawing.Color.White
        Me.Invoice_Number.Location = New System.Drawing.Point(1256, 43)
        Me.Invoice_Number.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Invoice_Number.Name = "Invoice_Number"
        Me.Invoice_Number.Size = New System.Drawing.Size(166, 39)
        Me.Invoice_Number.TabIndex = 149
        Me.Invoice_Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Invoice_Date
        '
        Me.Invoice_Date.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Invoice_Date.CalendarFont = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Invoice_Date.Enabled = False
        Me.Invoice_Date.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Invoice_Date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Invoice_Date.Location = New System.Drawing.Point(1086, 43)
        Me.Invoice_Date.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Invoice_Date.Name = "Invoice_Date"
        Me.Invoice_Date.Size = New System.Drawing.Size(166, 39)
        Me.Invoice_Date.TabIndex = 150
        '
        'Supplier_Invoice_Number
        '
        Me.Supplier_Invoice_Number.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Supplier_Invoice_Number.Enabled = False
        Me.Supplier_Invoice_Number.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Supplier_Invoice_Number.Location = New System.Drawing.Point(937, 43)
        Me.Supplier_Invoice_Number.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Supplier_Invoice_Number.Name = "Supplier_Invoice_Number"
        Me.Supplier_Invoice_Number.ReadOnly = True
        Me.Supplier_Invoice_Number.Size = New System.Drawing.Size(145, 39)
        Me.Supplier_Invoice_Number.TabIndex = 151
        Me.Supplier_Invoice_Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NumberOfItems
        '
        Me.NumberOfItems.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumberOfItems.Enabled = False
        Me.NumberOfItems.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberOfItems.Location = New System.Drawing.Point(807, 43)
        Me.NumberOfItems.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.NumberOfItems.Name = "NumberOfItems"
        Me.NumberOfItems.ReadOnly = True
        Me.NumberOfItems.Size = New System.Drawing.Size(126, 39)
        Me.NumberOfItems.TabIndex = 152
        Me.NumberOfItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Invoice_Type
        '
        Me.Invoice_Type.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Invoice_Type.Enabled = False
        Me.Invoice_Type.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Invoice_Type.Location = New System.Drawing.Point(640, 43)
        Me.Invoice_Type.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Invoice_Type.Name = "Invoice_Type"
        Me.Invoice_Type.ReadOnly = True
        Me.Invoice_Type.Size = New System.Drawing.Size(163, 39)
        Me.Invoice_Type.TabIndex = 153
        Me.Invoice_Type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Supplier_ID
        '
        Me.Supplier_ID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Supplier_ID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Supplier_ID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Supplier_ID.Enabled = False
        Me.Supplier_ID.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Supplier_ID.FormattingEnabled = True
        Me.Supplier_ID.Location = New System.Drawing.Point(395, 42)
        Me.Supplier_ID.Name = "Supplier_ID"
        Me.Supplier_ID.Size = New System.Drawing.Size(240, 40)
        Me.Supplier_ID.TabIndex = 154
        '
        'Customer_ID
        '
        Me.Customer_ID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Customer_ID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Customer_ID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Customer_ID.Enabled = False
        Me.Customer_ID.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Customer_ID.FormattingEnabled = True
        Me.Customer_ID.Location = New System.Drawing.Point(170, 42)
        Me.Customer_ID.Name = "Customer_ID"
        Me.Customer_ID.Size = New System.Drawing.Size(219, 40)
        Me.Customer_ID.TabIndex = 156
        '
        'Invoice_Type_Search
        '
        Me.Invoice_Type_Search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Invoice_Type_Search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Invoice_Type_Search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Invoice_Type_Search.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Invoice_Type_Search.FormattingEnabled = True
        Me.Invoice_Type_Search.Items.AddRange(New Object() {"اذن صرف", "اذن وارد", "اذن مرتجع عميل", "اذن مرتجع مورد"})
        Me.Invoice_Type_Search.Location = New System.Drawing.Point(6, 42)
        Me.Invoice_Type_Search.Name = "Invoice_Type_Search"
        Me.Invoice_Type_Search.Size = New System.Drawing.Size(158, 40)
        Me.Invoice_Type_Search.TabIndex = 157
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Btn_Show_Edit_Price)
        Me.Panel2.Controls.Add(Me.Btn_ExportToExcel)
        Me.Panel2.Controls.Add(Me.Btn_Print)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 647)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1428, 77)
        Me.Panel2.TabIndex = 2
        '
        'Btn_Show_Edit_Price
        '
        Me.Btn_Show_Edit_Price.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Show_Edit_Price.FlatAppearance.BorderSize = 0
        Me.Btn_Show_Edit_Price.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Show_Edit_Price.Font = New System.Drawing.Font("Questv1", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Show_Edit_Price.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Dollar_Coin_24px
        Me.Btn_Show_Edit_Price.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Show_Edit_Price.Location = New System.Drawing.Point(629, 13)
        Me.Btn_Show_Edit_Price.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Btn_Show_Edit_Price.Name = "Btn_Show_Edit_Price"
        Me.Btn_Show_Edit_Price.Size = New System.Drawing.Size(198, 49)
        Me.Btn_Show_Edit_Price.TabIndex = 150
        Me.Btn_Show_Edit_Price.Text = "تعديل الاسعار للفاتورة"
        Me.Btn_Show_Edit_Price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Show_Edit_Price.UseVisualStyleBackColor = True
        Me.Btn_Show_Edit_Price.Visible = False
        '
        'Btn_ExportToExcel
        '
        Me.Btn_ExportToExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_ExportToExcel.FlatAppearance.BorderSize = 0
        Me.Btn_ExportToExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_ExportToExcel.Font = New System.Drawing.Font("Questv1", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_ExportToExcel.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Microsoft_Excel_48px
        Me.Btn_ExportToExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_ExportToExcel.Location = New System.Drawing.Point(61, 11)
        Me.Btn_ExportToExcel.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Btn_ExportToExcel.Name = "Btn_ExportToExcel"
        Me.Btn_ExportToExcel.Size = New System.Drawing.Size(222, 49)
        Me.Btn_ExportToExcel.TabIndex = 149
        Me.Btn_ExportToExcel.Text = "تصدير إلى الاكسل"
        Me.Btn_ExportToExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_ExportToExcel.UseVisualStyleBackColor = True
        '
        'Btn_Print
        '
        Me.Btn_Print.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Print.FlatAppearance.BorderSize = 0
        Me.Btn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Print.Font = New System.Drawing.Font("Questv1", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Print.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Print2
        Me.Btn_Print.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Print.Location = New System.Drawing.Point(1192, 11)
        Me.Btn_Print.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.Btn_Print.Name = "Btn_Print"
        Me.Btn_Print.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Btn_Print.Size = New System.Drawing.Size(172, 48)
        Me.Btn_Print.TabIndex = 148
        Me.Btn_Print.Text = "طباعة"
        Me.Btn_Print.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Print.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.dgv_Tbl_InvoiceItems)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 143)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1428, 504)
        Me.Panel3.TabIndex = 3
        '
        'dgv_Tbl_InvoiceItems
        '
        Me.dgv_Tbl_InvoiceItems.AllowUserToAddRows = False
        Me.dgv_Tbl_InvoiceItems.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_Tbl_InvoiceItems.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Tbl_InvoiceItems.BackgroundColor = System.Drawing.Color.White
        Me.dgv_Tbl_InvoiceItems.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_Tbl_InvoiceItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Tbl_InvoiceItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_Tbl_InvoiceItems.ColumnHeadersHeight = 40
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Tbl_InvoiceItems.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_Tbl_InvoiceItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Tbl_InvoiceItems.EnableHeadersVisualStyles = False
        Me.dgv_Tbl_InvoiceItems.GridColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dgv_Tbl_InvoiceItems.Location = New System.Drawing.Point(0, 0)
        Me.dgv_Tbl_InvoiceItems.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.dgv_Tbl_InvoiceItems.Name = "dgv_Tbl_InvoiceItems"
        Me.dgv_Tbl_InvoiceItems.ReadOnly = True
        Me.dgv_Tbl_InvoiceItems.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Tbl_InvoiceItems.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_Tbl_InvoiceItems.RowHeadersVisible = False
        Me.dgv_Tbl_InvoiceItems.RowHeadersWidth = 51
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_Tbl_InvoiceItems.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_Tbl_InvoiceItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Tbl_InvoiceItems.Size = New System.Drawing.Size(1424, 500)
        Me.dgv_Tbl_InvoiceItems.TabIndex = 143
        '
        'Frm_Document_Query_Test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1428, 724)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "Frm_Document_Query_Test"
        Me.RightToLeftLayout = True
        Me.Text = "شاشة البحث عن مستند"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgv_Tbl_InvoiceItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Invoice_Numberlbl As Label
    Friend WithEvents Invoice_DateDatelbl As Label
    Friend WithEvents Supplier_Invoice_NumberLbl As Label
    Friend WithEvents NumberOfItemsLbl As Label
    Friend WithEvents Invoice_TypeLbL As Label
    Friend WithEvents Supplier_IDlbl As Label
    Friend WithEvents Invoice_Type_SearchLbl As Label
    Friend WithEvents Invoice_Number As TextBox
    Friend WithEvents Invoice_Date As DateTimePicker
    Friend WithEvents Supplier_Invoice_Number As TextBox
    Friend WithEvents NumberOfItems As TextBox
    Friend WithEvents Invoice_Type As TextBox
    Friend WithEvents Supplier_ID As ComboBox
    Friend WithEvents Customer_IDLbl As Label
    Friend WithEvents Customer_ID As ComboBox
    Friend WithEvents Invoice_Type_Search As ComboBox
    Friend WithEvents Txt_User As TextBox
    Friend WithEvents Txt_UserID As TextBox
    Friend WithEvents Total_Invoice_ValueLbl As Label
    Friend WithEvents Total_Invoice_Value As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dgv_Tbl_InvoiceItems As DataGridView
    Friend WithEvents Btn_Show_Edit_Price As Button
    Friend WithEvents Btn_ExportToExcel As Button
    Friend WithEvents Btn_Print As Button
End Class
