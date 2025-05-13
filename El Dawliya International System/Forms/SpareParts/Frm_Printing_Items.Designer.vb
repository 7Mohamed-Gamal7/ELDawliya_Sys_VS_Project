<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Printing_Items
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Invoice_IDlbl = New System.Windows.Forms.Label()
        Me.dgv_Tbl_InvoiceItems = New System.Windows.Forms.DataGridView()
        Me.DGV_Product_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Product_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_ElWarad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_ElMonsarf = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_MortagaaElMawarden = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_MortagaaOmalaa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_QTE_IN_STOCK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Unit_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Unit_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_ID_CAT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Initial_Balance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Unit_Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Minimum_Threshold = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Maximum_Threshold = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dgv_Location = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Total_Unit_Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Invoice_ID = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BtnNewAdd = New System.Windows.Forms.ToolStripButton()
        Me.BtnDelete = New System.Windows.Forms.ToolStripButton()
        Me.Btn_Export_Excel = New System.Windows.Forms.ToolStripButton()
        Me.btn_Report = New System.Windows.Forms.ToolStripButton()
        Me.Btn_Sreach_Product = New System.Windows.Forms.ToolStripButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Btn_Add_Group_Code = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.NumberOfItems = New System.Windows.Forms.ToolStripLabel()
        CType(Me.dgv_Tbl_InvoiceItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Teal
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Hacen Saudi Arabia", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1387, 45)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "الجرد اليومى"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Invoice_IDlbl
        '
        Me.Invoice_IDlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Invoice_IDlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Invoice_IDlbl.ForeColor = System.Drawing.Color.White
        Me.Invoice_IDlbl.Location = New System.Drawing.Point(172, 0)
        Me.Invoice_IDlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Invoice_IDlbl.Name = "Invoice_IDlbl"
        Me.Invoice_IDlbl.Size = New System.Drawing.Size(140, 34)
        Me.Invoice_IDlbl.TabIndex = 16
        Me.Invoice_IDlbl.Text = "كود المستند"
        Me.Invoice_IDlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Invoice_IDlbl.Visible = False
        '
        'dgv_Tbl_InvoiceItems
        '
        Me.dgv_Tbl_InvoiceItems.AllowUserToOrderColumns = True
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_Tbl_InvoiceItems.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.dgv_Tbl_InvoiceItems.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Tbl_InvoiceItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgv_Tbl_InvoiceItems.ColumnHeadersHeight = 40
        Me.dgv_Tbl_InvoiceItems.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGV_Product_ID, Me.DGV_Product_Name, Me.DGV_ElWarad, Me.DGV_ElMonsarf, Me.DGV_MortagaaElMawarden, Me.DGV_MortagaaOmalaa, Me.DGV_QTE_IN_STOCK, Me.DGV_Unit_Name, Me.DGV_Unit_ID, Me.DGV_ID_CAT, Me.DGV_Initial_Balance, Me.DGV_Unit_Price, Me.DGV_Minimum_Threshold, Me.DGV_Maximum_Threshold, Me.Dgv_Location, Me.DGV_Total_Unit_Price})
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Tbl_InvoiceItems.DefaultCellStyle = DataGridViewCellStyle13
        Me.dgv_Tbl_InvoiceItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Tbl_InvoiceItems.EnableHeadersVisualStyles = False
        Me.dgv_Tbl_InvoiceItems.Location = New System.Drawing.Point(0, 0)
        Me.dgv_Tbl_InvoiceItems.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.dgv_Tbl_InvoiceItems.Name = "dgv_Tbl_InvoiceItems"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Tbl_InvoiceItems.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dgv_Tbl_InvoiceItems.RowHeadersVisible = False
        Me.dgv_Tbl_InvoiceItems.RowHeadersWidth = 51
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_Tbl_InvoiceItems.RowsDefaultCellStyle = DataGridViewCellStyle15
        Me.dgv_Tbl_InvoiceItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Tbl_InvoiceItems.Size = New System.Drawing.Size(1387, 648)
        Me.dgv_Tbl_InvoiceItems.TabIndex = 1
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
        Me.DGV_Product_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DGV_Product_Name.HeaderText = "اسم الصنف"
        Me.DGV_Product_Name.MinimumWidth = 6
        Me.DGV_Product_Name.Name = "DGV_Product_Name"
        Me.DGV_Product_Name.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Product_Name.Width = 124
        '
        'DGV_ElWarad
        '
        Me.DGV_ElWarad.HeaderText = "الوارد"
        Me.DGV_ElWarad.MinimumWidth = 6
        Me.DGV_ElWarad.Name = "DGV_ElWarad"
        Me.DGV_ElWarad.Width = 125
        '
        'DGV_ElMonsarf
        '
        Me.DGV_ElMonsarf.HeaderText = "المنصرف"
        Me.DGV_ElMonsarf.MinimumWidth = 6
        Me.DGV_ElMonsarf.Name = "DGV_ElMonsarf"
        Me.DGV_ElMonsarf.Width = 125
        '
        'DGV_MortagaaElMawarden
        '
        Me.DGV_MortagaaElMawarden.HeaderText = "مرتجع موردين"
        Me.DGV_MortagaaElMawarden.MinimumWidth = 6
        Me.DGV_MortagaaElMawarden.Name = "DGV_MortagaaElMawarden"
        Me.DGV_MortagaaElMawarden.Width = 125
        '
        'DGV_MortagaaOmalaa
        '
        Me.DGV_MortagaaOmalaa.HeaderText = "مرتجع عملاء"
        Me.DGV_MortagaaOmalaa.MinimumWidth = 6
        Me.DGV_MortagaaOmalaa.Name = "DGV_MortagaaOmalaa"
        Me.DGV_MortagaaOmalaa.Width = 125
        '
        'DGV_QTE_IN_STOCK
        '
        Me.DGV_QTE_IN_STOCK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DGV_QTE_IN_STOCK.HeaderText = "الرصيد الحالى"
        Me.DGV_QTE_IN_STOCK.MinimumWidth = 6
        Me.DGV_QTE_IN_STOCK.Name = "DGV_QTE_IN_STOCK"
        Me.DGV_QTE_IN_STOCK.Width = 137
        '
        'DGV_Unit_Name
        '
        Me.DGV_Unit_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DGV_Unit_Name.HeaderText = "اسم الوحدة"
        Me.DGV_Unit_Name.MinimumWidth = 6
        Me.DGV_Unit_Name.Name = "DGV_Unit_Name"
        Me.DGV_Unit_Name.Width = 129
        '
        'DGV_Unit_ID
        '
        Me.DGV_Unit_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DGV_Unit_ID.HeaderText = "كود الوحدة"
        Me.DGV_Unit_ID.MinimumWidth = 6
        Me.DGV_Unit_ID.Name = "DGV_Unit_ID"
        Me.DGV_Unit_ID.Visible = False
        Me.DGV_Unit_ID.Width = 127
        '
        'DGV_ID_CAT
        '
        Me.DGV_ID_CAT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DGV_ID_CAT.HeaderText = "اسم التصنيف"
        Me.DGV_ID_CAT.MinimumWidth = 6
        Me.DGV_ID_CAT.Name = "DGV_ID_CAT"
        Me.DGV_ID_CAT.Visible = False
        Me.DGV_ID_CAT.Width = 136
        '
        'DGV_Initial_Balance
        '
        Me.DGV_Initial_Balance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DGV_Initial_Balance.HeaderText = "الرصيد الافتتاحى"
        Me.DGV_Initial_Balance.MinimumWidth = 6
        Me.DGV_Initial_Balance.Name = "DGV_Initial_Balance"
        Me.DGV_Initial_Balance.Width = 159
        '
        'DGV_Unit_Price
        '
        Me.DGV_Unit_Price.HeaderText = "سعر الوحدة"
        Me.DGV_Unit_Price.MinimumWidth = 6
        Me.DGV_Unit_Price.Name = "DGV_Unit_Price"
        Me.DGV_Unit_Price.Visible = False
        Me.DGV_Unit_Price.Width = 125
        '
        'DGV_Minimum_Threshold
        '
        Me.DGV_Minimum_Threshold.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DGV_Minimum_Threshold.HeaderText = "اقل كمية"
        Me.DGV_Minimum_Threshold.MinimumWidth = 6
        Me.DGV_Minimum_Threshold.Name = "DGV_Minimum_Threshold"
        Me.DGV_Minimum_Threshold.Width = 112
        '
        'DGV_Maximum_Threshold
        '
        Me.DGV_Maximum_Threshold.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DGV_Maximum_Threshold.HeaderText = "اعلى كمية"
        Me.DGV_Maximum_Threshold.MinimumWidth = 6
        Me.DGV_Maximum_Threshold.Name = "DGV_Maximum_Threshold"
        Me.DGV_Maximum_Threshold.Width = 120
        '
        'Dgv_Location
        '
        Me.Dgv_Location.HeaderText = "التواجد"
        Me.Dgv_Location.MinimumWidth = 6
        Me.Dgv_Location.Name = "Dgv_Location"
        Me.Dgv_Location.Width = 125
        '
        'DGV_Total_Unit_Price
        '
        Me.DGV_Total_Unit_Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DGV_Total_Unit_Price.HeaderText = "اجمالى السعر للصنف"
        Me.DGV_Total_Unit_Price.MinimumWidth = 6
        Me.DGV_Total_Unit_Price.Name = "DGV_Total_Unit_Price"
        Me.DGV_Total_Unit_Price.Visible = False
        Me.DGV_Total_Unit_Price.Width = 191
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Invoice_IDlbl)
        Me.Panel1.Controls.Add(Me.Invoice_ID)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1387, 45)
        Me.Panel1.TabIndex = 60
        '
        'Invoice_ID
        '
        Me.Invoice_ID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Invoice_ID.Enabled = False
        Me.Invoice_ID.Location = New System.Drawing.Point(290, 4)
        Me.Invoice_ID.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Invoice_ID.Name = "Invoice_ID"
        Me.Invoice_ID.ReadOnly = True
        Me.Invoice_ID.Size = New System.Drawing.Size(140, 34)
        Me.Invoice_ID.TabIndex = 17
        Me.Invoice_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Invoice_ID.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.dgv_Tbl_InvoiceItems)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1387, 648)
        Me.Panel3.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.ToolStrip1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 693)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1387, 63)
        Me.Panel4.TabIndex = 2
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNewAdd, Me.BtnDelete, Me.Btn_Export_Excel, Me.Btn_Sreach_Product, Me.Btn_Add_Group_Code, Me.btn_Report, Me.ToolStripLabel1, Me.NumberOfItems})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1387, 63)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BtnNewAdd
        '
        Me.BtnNewAdd.BackColor = System.Drawing.Color.SeaGreen
        Me.BtnNewAdd.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNewAdd.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Add
        Me.BtnNewAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnNewAdd.Name = "BtnNewAdd"
        Me.BtnNewAdd.Size = New System.Drawing.Size(72, 60)
        Me.BtnNewAdd.Text = "جديد"
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.Red
        Me.BtnDelete.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Remove
        Me.BtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(179, 60)
        Me.BtnDelete.Text = "حذف السطر المحدد"
        '
        'Btn_Export_Excel
        '
        Me.Btn_Export_Excel.BackColor = System.Drawing.Color.AliceBlue
        Me.Btn_Export_Excel.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Export_Excel.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Microsoft_Excel_48px
        Me.Btn_Export_Excel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_Export_Excel.Name = "Btn_Export_Excel"
        Me.Btn_Export_Excel.Size = New System.Drawing.Size(135, 60)
        Me.Btn_Export_Excel.Text = "تصدير لاكسل"
        '
        'btn_Report
        '
        Me.btn_Report.BackColor = System.Drawing.Color.LightCyan
        Me.btn_Report.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Report.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Print
        Me.btn_Report.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_Report.Name = "btn_Report"
        Me.btn_Report.Size = New System.Drawing.Size(84, 60)
        Me.btn_Report.Text = "طباعة"
        '
        'Btn_Sreach_Product
        '
        Me.Btn_Sreach_Product.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Btn_Sreach_Product.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Sreach_Product.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Search_More5
        Me.Btn_Sreach_Product.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_Sreach_Product.Name = "Btn_Sreach_Product"
        Me.Btn_Sreach_Product.Size = New System.Drawing.Size(167, 60)
        Me.Btn_Sreach_Product.Text = "استعلام عن صنف"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 45)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1387, 648)
        Me.Panel2.TabIndex = 61
        '
        'Btn_Add_Group_Code
        '
        Me.Btn_Add_Group_Code.BackColor = System.Drawing.Color.Brown
        Me.Btn_Add_Group_Code.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Add_Group_Code.Image = Global.El_Dawliya_International_System.My.Resources.Resources.txt_100px
        Me.Btn_Add_Group_Code.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_Add_Group_Code.Name = "Btn_Add_Group_Code"
        Me.Btn_Add_Group_Code.Size = New System.Drawing.Size(199, 60)
        Me.Btn_Add_Group_Code.Text = "اضافة مجموعة أكواد"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(106, 60)
        Me.ToolStripLabel1.Text = "عدد الاصناف"
        '
        'NumberOfItems
        '
        Me.NumberOfItems.Name = "NumberOfItems"
        Me.NumberOfItems.Size = New System.Drawing.Size(12, 60)
        Me.NumberOfItems.Text = "."
        '
        'Frm_Printing_Items
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1387, 756)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Frm_Printing_Items"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgv_Tbl_InvoiceItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Invoice_IDlbl As Label
    Friend WithEvents dgv_Tbl_InvoiceItems As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Invoice_ID As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DGV_Product_ID As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Product_Name As DataGridViewTextBoxColumn
    Friend WithEvents DGV_ElWarad As DataGridViewTextBoxColumn
    Friend WithEvents DGV_ElMonsarf As DataGridViewTextBoxColumn
    Friend WithEvents DGV_MortagaaElMawarden As DataGridViewTextBoxColumn
    Friend WithEvents DGV_MortagaaOmalaa As DataGridViewTextBoxColumn
    Friend WithEvents DGV_QTE_IN_STOCK As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Unit_Name As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Unit_ID As DataGridViewTextBoxColumn
    Friend WithEvents DGV_ID_CAT As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Initial_Balance As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Unit_Price As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Minimum_Threshold As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Maximum_Threshold As DataGridViewTextBoxColumn
    Friend WithEvents Dgv_Location As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Total_Unit_Price As DataGridViewTextBoxColumn
    Friend WithEvents Panel4 As Panel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents BtnNewAdd As ToolStripButton
    Friend WithEvents BtnDelete As ToolStripButton
    Friend WithEvents Btn_Export_Excel As ToolStripButton
    Friend WithEvents btn_Report As ToolStripButton
    Friend WithEvents Btn_Sreach_Product As ToolStripButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Btn_Add_Group_Code As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents NumberOfItems As ToolStripLabel
End Class
