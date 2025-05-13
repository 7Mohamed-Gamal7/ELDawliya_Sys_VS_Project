<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Purchase_Orders
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Order_Numberlbl = New System.Windows.Forms.Label()
        Me.Order_Number = New System.Windows.Forms.TextBox()
        Me.OrderDatelbl = New System.Windows.Forms.Label()
        Me.OrderDate = New System.Windows.Forms.DateTimePicker()
        Me.OrderStatuslbl = New System.Windows.Forms.Label()
        Me.OrderStatus = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_Report = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.NumberOfItemsLbl = New System.Windows.Forms.Label()
        Me.NumberOfItems = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Request_Side = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dgv_PurchaseOrders = New System.Windows.Forms.DataGridView()
        Me.DGV_Product_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Product_Name = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DGV_Unit_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_QTE_IN_STOCK = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Minimum_Threshold = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Add_Balance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Purpose = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Unit_Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Total_Unit_Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Maximum_Threshold = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Unit_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_CAT_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_CAT_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGV_Initial_Balance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgv_PurchaseOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Order_Numberlbl
        '
        Me.Order_Numberlbl.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Order_Numberlbl.Location = New System.Drawing.Point(1279, 14)
        Me.Order_Numberlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Order_Numberlbl.Name = "Order_Numberlbl"
        Me.Order_Numberlbl.Size = New System.Drawing.Size(122, 27)
        Me.Order_Numberlbl.TabIndex = 2
        Me.Order_Numberlbl.Text = "رقم الطلب"
        Me.Order_Numberlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Order_Number
        '
        Me.Order_Number.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Order_Number.Location = New System.Drawing.Point(1049, 11)
        Me.Order_Number.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Order_Number.Name = "Order_Number"
        Me.Order_Number.Size = New System.Drawing.Size(226, 32)
        Me.Order_Number.TabIndex = 3
        Me.Order_Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OrderDatelbl
        '
        Me.OrderDatelbl.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderDatelbl.Location = New System.Drawing.Point(858, 14)
        Me.OrderDatelbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.OrderDatelbl.Name = "OrderDatelbl"
        Me.OrderDatelbl.Size = New System.Drawing.Size(122, 27)
        Me.OrderDatelbl.TabIndex = 4
        Me.OrderDatelbl.Text = "تاريخ الطلب"
        Me.OrderDatelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OrderDate
        '
        Me.OrderDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.OrderDate.Location = New System.Drawing.Point(698, 14)
        Me.OrderDate.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.OrderDate.Name = "OrderDate"
        Me.OrderDate.Size = New System.Drawing.Size(156, 32)
        Me.OrderDate.TabIndex = 5
        '
        'OrderStatuslbl
        '
        Me.OrderStatuslbl.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderStatuslbl.Location = New System.Drawing.Point(175, 14)
        Me.OrderStatuslbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.OrderStatuslbl.Name = "OrderStatuslbl"
        Me.OrderStatuslbl.Size = New System.Drawing.Size(122, 27)
        Me.OrderStatuslbl.TabIndex = 20
        Me.OrderStatuslbl.Text = "حالة الطلب"
        Me.OrderStatuslbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.OrderStatuslbl.Visible = False
        '
        'OrderStatus
        '
        Me.OrderStatus.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderStatus.FormattingEnabled = True
        Me.OrderStatus.Location = New System.Drawing.Point(12, 11)
        Me.OrderStatus.Name = "OrderStatus"
        Me.OrderStatus.Size = New System.Drawing.Size(158, 32)
        Me.OrderStatus.TabIndex = 23
        Me.OrderStatus.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1410, 53)
        Me.Panel1.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Questv1", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1410, 53)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "أمر شراء"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.btn_Report)
        Me.Panel2.Controls.Add(Me.BtnSave)
        Me.Panel2.Controls.Add(Me.NumberOfItemsLbl)
        Me.Panel2.Controls.Add(Me.NumberOfItems)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 579)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1410, 72)
        Me.Panel2.TabIndex = 25
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Questv1", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Search
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(1220, 10)
        Me.Button2.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.Button2.Name = "Button2"
        Me.Button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button2.Size = New System.Drawing.Size(178, 48)
        Me.Button2.TabIndex = 109
        Me.Button2.Text = "بـــحـــث"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btn_Report
        '
        Me.btn_Report.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_Report.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btn_Report.FlatAppearance.BorderSize = 0
        Me.btn_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Report.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Bold)
        Me.btn_Report.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Print
        Me.btn_Report.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Report.Location = New System.Drawing.Point(14, 10)
        Me.btn_Report.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.btn_Report.Name = "btn_Report"
        Me.btn_Report.Size = New System.Drawing.Size(169, 48)
        Me.btn_Report.TabIndex = 108
        Me.btn_Report.Text = "طباعة"
        Me.btn_Report.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Report.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Questv1", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Ok
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSave.Location = New System.Drawing.Point(653, 12)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnSave.Size = New System.Drawing.Size(117, 48)
        Me.BtnSave.TabIndex = 107
        Me.BtnSave.Text = "حفظ"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'NumberOfItemsLbl
        '
        Me.NumberOfItemsLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumberOfItemsLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.NumberOfItemsLbl.ForeColor = System.Drawing.Color.White
        Me.NumberOfItemsLbl.Location = New System.Drawing.Point(525, 19)
        Me.NumberOfItemsLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.NumberOfItemsLbl.Name = "NumberOfItemsLbl"
        Me.NumberOfItemsLbl.Size = New System.Drawing.Size(105, 31)
        Me.NumberOfItemsLbl.TabIndex = 4
        Me.NumberOfItemsLbl.Text = "عدد الاصناف"
        Me.NumberOfItemsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NumberOfItemsLbl.Visible = False
        '
        'NumberOfItems
        '
        Me.NumberOfItems.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumberOfItems.Enabled = False
        Me.NumberOfItems.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberOfItems.Location = New System.Drawing.Point(396, 16)
        Me.NumberOfItems.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.NumberOfItems.Name = "NumberOfItems"
        Me.NumberOfItems.ReadOnly = True
        Me.NumberOfItems.Size = New System.Drawing.Size(125, 38)
        Me.NumberOfItems.TabIndex = 5
        Me.NumberOfItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumberOfItems.Visible = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Request_Side)
        Me.Panel3.Controls.Add(Me.Order_Numberlbl)
        Me.Panel3.Controls.Add(Me.Order_Number)
        Me.Panel3.Controls.Add(Me.OrderDatelbl)
        Me.Panel3.Controls.Add(Me.OrderStatus)
        Me.Panel3.Controls.Add(Me.OrderDate)
        Me.Panel3.Controls.Add(Me.OrderStatuslbl)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 53)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1410, 55)
        Me.Panel3.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(551, 14)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 27)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "جهة الطلب"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Request_Side
        '
        Me.Request_Side.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Request_Side.Location = New System.Drawing.Point(321, 11)
        Me.Request_Side.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Request_Side.Name = "Request_Side"
        Me.Request_Side.Size = New System.Drawing.Size(226, 32)
        Me.Request_Side.TabIndex = 25
        Me.Request_Side.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.dgv_PurchaseOrders)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 108)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1410, 471)
        Me.Panel4.TabIndex = 27
        '
        'dgv_PurchaseOrders
        '
        Me.dgv_PurchaseOrders.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv_PurchaseOrders.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_PurchaseOrders.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_PurchaseOrders.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_PurchaseOrders.ColumnHeadersHeight = 40
        Me.dgv_PurchaseOrders.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGV_Product_ID, Me.DGV_Product_Name, Me.DGV_Unit_Name, Me.DGV_QTE_IN_STOCK, Me.DGV_Minimum_Threshold, Me.DGV_Add_Balance, Me.DGV_Purpose, Me.DGV_Unit_Price, Me.DGV_Total_Unit_Price, Me.DGV_Maximum_Threshold, Me.DGV_Unit_ID, Me.DGV_CAT_ID, Me.DGV_CAT_Name, Me.DGV_Initial_Balance})
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_PurchaseOrders.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgv_PurchaseOrders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_PurchaseOrders.EnableHeadersVisualStyles = False
        Me.dgv_PurchaseOrders.Location = New System.Drawing.Point(0, 0)
        Me.dgv_PurchaseOrders.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.dgv_PurchaseOrders.Name = "dgv_PurchaseOrders"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_PurchaseOrders.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgv_PurchaseOrders.RowHeadersVisible = False
        Me.dgv_PurchaseOrders.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_PurchaseOrders.RowsDefaultCellStyle = DataGridViewCellStyle11
        Me.dgv_PurchaseOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_PurchaseOrders.Size = New System.Drawing.Size(1410, 471)
        Me.dgv_PurchaseOrders.TabIndex = 140
        '
        'DGV_Product_ID
        '
        Me.DGV_Product_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Product_ID.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_Product_ID.HeaderText = "كود الصنف"
        Me.DGV_Product_ID.MinimumWidth = 6
        Me.DGV_Product_ID.Name = "DGV_Product_ID"
        Me.DGV_Product_ID.Width = 122
        '
        'DGV_Product_Name
        '
        Me.DGV_Product_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Product_Name.DefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_Product_Name.HeaderText = "اسم الصنف"
        Me.DGV_Product_Name.MinimumWidth = 6
        Me.DGV_Product_Name.Name = "DGV_Product_Name"
        Me.DGV_Product_Name.ReadOnly = True
        Me.DGV_Product_Name.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Product_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DGV_Unit_Name
        '
        Me.DGV_Unit_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Unit_Name.DefaultCellStyle = DataGridViewCellStyle5
        Me.DGV_Unit_Name.HeaderText = "اسم الوحدة"
        Me.DGV_Unit_Name.MinimumWidth = 6
        Me.DGV_Unit_Name.Name = "DGV_Unit_Name"
        Me.DGV_Unit_Name.Width = 129
        '
        'DGV_QTE_IN_STOCK
        '
        Me.DGV_QTE_IN_STOCK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_QTE_IN_STOCK.DefaultCellStyle = DataGridViewCellStyle6
        Me.DGV_QTE_IN_STOCK.HeaderText = "الرصيد الحالى"
        Me.DGV_QTE_IN_STOCK.MinimumWidth = 6
        Me.DGV_QTE_IN_STOCK.Name = "DGV_QTE_IN_STOCK"
        Me.DGV_QTE_IN_STOCK.Width = 137
        '
        'DGV_Minimum_Threshold
        '
        Me.DGV_Minimum_Threshold.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DGV_Minimum_Threshold.HeaderText = "الحد الادنى"
        Me.DGV_Minimum_Threshold.MinimumWidth = 6
        Me.DGV_Minimum_Threshold.Name = "DGV_Minimum_Threshold"
        Me.DGV_Minimum_Threshold.Width = 119
        '
        'DGV_Add_Balance
        '
        Me.DGV_Add_Balance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Add_Balance.DefaultCellStyle = DataGridViewCellStyle7
        Me.DGV_Add_Balance.HeaderText = "الكمية المطلوبة"
        Me.DGV_Add_Balance.MinimumWidth = 6
        Me.DGV_Add_Balance.Name = "DGV_Add_Balance"
        Me.DGV_Add_Balance.Width = 168
        '
        'DGV_Purpose
        '
        Me.DGV_Purpose.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Purpose.DefaultCellStyle = DataGridViewCellStyle8
        Me.DGV_Purpose.HeaderText = "الـــغـــرض مـــن الـــشـــراء"
        Me.DGV_Purpose.MinimumWidth = 6
        Me.DGV_Purpose.Name = "DGV_Purpose"
        Me.DGV_Purpose.Width = 224
        '
        'DGV_Unit_Price
        '
        Me.DGV_Unit_Price.HeaderText = "سعر الوحدة"
        Me.DGV_Unit_Price.MinimumWidth = 6
        Me.DGV_Unit_Price.Name = "DGV_Unit_Price"
        Me.DGV_Unit_Price.Visible = False
        Me.DGV_Unit_Price.Width = 125
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
        'DGV_Maximum_Threshold
        '
        Me.DGV_Maximum_Threshold.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DGV_Maximum_Threshold.HeaderText = "الحد الاقصى"
        Me.DGV_Maximum_Threshold.MinimumWidth = 6
        Me.DGV_Maximum_Threshold.Name = "DGV_Maximum_Threshold"
        Me.DGV_Maximum_Threshold.Visible = False
        Me.DGV_Maximum_Threshold.Width = 129
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
        'DGV_CAT_ID
        '
        Me.DGV_CAT_ID.HeaderText = "كود التصنيف"
        Me.DGV_CAT_ID.MinimumWidth = 6
        Me.DGV_CAT_ID.Name = "DGV_CAT_ID"
        Me.DGV_CAT_ID.Visible = False
        Me.DGV_CAT_ID.Width = 125
        '
        'DGV_CAT_Name
        '
        Me.DGV_CAT_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DGV_CAT_Name.HeaderText = "اسم التصنيف"
        Me.DGV_CAT_Name.MinimumWidth = 6
        Me.DGV_CAT_Name.Name = "DGV_CAT_Name"
        Me.DGV_CAT_Name.Visible = False
        Me.DGV_CAT_Name.Width = 136
        '
        'DGV_Initial_Balance
        '
        Me.DGV_Initial_Balance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DGV_Initial_Balance.HeaderText = "الرصيد الافتتاحى"
        Me.DGV_Initial_Balance.MinimumWidth = 6
        Me.DGV_Initial_Balance.Name = "DGV_Initial_Balance"
        Me.DGV_Initial_Balance.Visible = False
        Me.DGV_Initial_Balance.Width = 159
        '
        'Frm_Purchase_Orders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1410, 651)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.MaximizeBox = False
        Me.Name = "Frm_Purchase_Orders"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.dgv_PurchaseOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Order_Number As System.Windows.Forms.TextBox
    Friend WithEvents Order_Numberlbl As System.Windows.Forms.Label
    Friend WithEvents OrderDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents OrderDatelbl As System.Windows.Forms.Label
    Friend WithEvents OrderStatuslbl As System.Windows.Forms.Label
    Friend WithEvents OrderStatus As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents dgv_PurchaseOrders As DataGridView
    Friend WithEvents NumberOfItemsLbl As Label
    Friend WithEvents NumberOfItems As TextBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents btn_Report As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Request_Side As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents DGV_Product_ID As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Product_Name As DataGridViewComboBoxColumn
    Friend WithEvents DGV_Unit_Name As DataGridViewTextBoxColumn
    Friend WithEvents DGV_QTE_IN_STOCK As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Minimum_Threshold As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Add_Balance As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Purpose As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Unit_Price As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Total_Unit_Price As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Maximum_Threshold As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Unit_ID As DataGridViewTextBoxColumn
    Friend WithEvents DGV_CAT_ID As DataGridViewTextBoxColumn
    Friend WithEvents DGV_CAT_Name As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Initial_Balance As DataGridViewTextBoxColumn
End Class
