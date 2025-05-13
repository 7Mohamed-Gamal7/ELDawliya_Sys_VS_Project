<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Search_Item_Movement
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Balance = New System.Windows.Forms.TextBox()
        Me.Supplier_Invoice_NumberLbl = New System.Windows.Forms.Label()
        Me.NumberOfItems = New System.Windows.Forms.TextBox()
        Me.Invoice_IDlbl = New System.Windows.Forms.Label()
        Me.Invoice_ID = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Btn_ExportToExcel = New System.Windows.Forms.Button()
        Me.Btn_Search_Products = New System.Windows.Forms.Button()
        Me.Btn_Search = New System.Windows.Forms.Button()
        Me.NumberOfItemsLbl = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Product_ID = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Sum_MortagaaElMawarden = New System.Windows.Forms.TextBox()
        Me.Sum_MortagaaElMawardenLbl = New System.Windows.Forms.Label()
        Me.Sum_MortagaaOmalaa = New System.Windows.Forms.TextBox()
        Me.Sum_MortagaaOmalaaLbl = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Btn_Search_FromDate = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_Date_To = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_Date_From = New System.Windows.Forms.TextBox()
        Me.Sum_ElMonsarf = New System.Windows.Forms.TextBox()
        Me.Initial_Balance = New System.Windows.Forms.TextBox()
        Me.Sum_ElMonsarfLbl = New System.Windows.Forms.Label()
        Me.Initial_BalanceLBL = New System.Windows.Forms.Label()
        Me.Sum_ElWarad = New System.Windows.Forms.TextBox()
        Me.Sum_ElWaradLbl = New System.Windows.Forms.Label()
        Me.Product_IDLbl = New System.Windows.Forms.Label()
        Me.Product_Namelbl = New System.Windows.Forms.Label()
        Me.Product_Name = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.dgv_Tbl_InvoiceItems = New ADGV.AdvancedDataGridView()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.dgv_Tbl_InvoiceItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Hacen Saudi Arabia", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1417, 45)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "كشف حركة الصنف"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Balance
        '
        Me.Balance.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Balance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Balance.Location = New System.Drawing.Point(601, 74)
        Me.Balance.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Balance.Name = "Balance"
        Me.Balance.ReadOnly = True
        Me.Balance.Size = New System.Drawing.Size(276, 32)
        Me.Balance.TabIndex = 144
        Me.Balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Supplier_Invoice_NumberLbl
        '
        Me.Supplier_Invoice_NumberLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Supplier_Invoice_NumberLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Supplier_Invoice_NumberLbl.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Supplier_Invoice_NumberLbl.ForeColor = System.Drawing.Color.Black
        Me.Supplier_Invoice_NumberLbl.Location = New System.Drawing.Point(881, 74)
        Me.Supplier_Invoice_NumberLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Supplier_Invoice_NumberLbl.Name = "Supplier_Invoice_NumberLbl"
        Me.Supplier_Invoice_NumberLbl.Size = New System.Drawing.Size(155, 30)
        Me.Supplier_Invoice_NumberLbl.TabIndex = 143
        Me.Supplier_Invoice_NumberLbl.Text = "الرصيد الحالى"
        Me.Supplier_Invoice_NumberLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumberOfItems
        '
        Me.NumberOfItems.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumberOfItems.BackColor = System.Drawing.Color.Black
        Me.NumberOfItems.Enabled = False
        Me.NumberOfItems.ForeColor = System.Drawing.Color.White
        Me.NumberOfItems.Location = New System.Drawing.Point(5, 56)
        Me.NumberOfItems.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.NumberOfItems.Name = "NumberOfItems"
        Me.NumberOfItems.ReadOnly = True
        Me.NumberOfItems.Size = New System.Drawing.Size(163, 38)
        Me.NumberOfItems.TabIndex = 3
        Me.NumberOfItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Invoice_IDlbl
        '
        Me.Invoice_IDlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Invoice_IDlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Invoice_IDlbl.ForeColor = System.Drawing.Color.White
        Me.Invoice_IDlbl.Location = New System.Drawing.Point(202, 0)
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
        Me.Invoice_ID.Location = New System.Drawing.Point(2, 0)
        Me.Invoice_ID.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Invoice_ID.Name = "Invoice_ID"
        Me.Invoice_ID.ReadOnly = True
        Me.Invoice_ID.Size = New System.Drawing.Size(140, 34)
        Me.Invoice_ID.TabIndex = 17
        Me.Invoice_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Invoice_ID.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Teal
        Me.Panel2.Controls.Add(Me.Btn_ExportToExcel)
        Me.Panel2.Controls.Add(Me.Btn_Search_Products)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 697)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1417, 59)
        Me.Panel2.TabIndex = 90
        '
        'Btn_ExportToExcel
        '
        Me.Btn_ExportToExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_ExportToExcel.FlatAppearance.BorderSize = 0
        Me.Btn_ExportToExcel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_ExportToExcel.Font = New System.Drawing.Font("Questv1", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_ExportToExcel.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Microsoft_Excel_96px
        Me.Btn_ExportToExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_ExportToExcel.Location = New System.Drawing.Point(6, 6)
        Me.Btn_ExportToExcel.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Btn_ExportToExcel.Name = "Btn_ExportToExcel"
        Me.Btn_ExportToExcel.Size = New System.Drawing.Size(222, 44)
        Me.Btn_ExportToExcel.TabIndex = 127
        Me.Btn_ExportToExcel.Text = "تصدير إلى الاكسل"
        Me.Btn_ExportToExcel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_ExportToExcel.UseVisualStyleBackColor = True
        '
        'Btn_Search_Products
        '
        Me.Btn_Search_Products.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Search_Products.BackColor = System.Drawing.Color.Teal
        Me.Btn_Search_Products.Font = New System.Drawing.Font("Questv1", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Search_Products.ForeColor = System.Drawing.Color.Black
        Me.Btn_Search_Products.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Search_More4
        Me.Btn_Search_Products.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Search_Products.Location = New System.Drawing.Point(1184, 5)
        Me.Btn_Search_Products.Name = "Btn_Search_Products"
        Me.Btn_Search_Products.Size = New System.Drawing.Size(229, 50)
        Me.Btn_Search_Products.TabIndex = 55
        Me.Btn_Search_Products.Text = "ابحث عن صنف"
        Me.Btn_Search_Products.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Search_Products.UseVisualStyleBackColor = False
        '
        'Btn_Search
        '
        Me.Btn_Search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Search.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Search.Font = New System.Drawing.Font("Questv1", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Search.ForeColor = System.Drawing.Color.Black
        Me.Btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Search.Location = New System.Drawing.Point(6, 94)
        Me.Btn_Search.Name = "Btn_Search"
        Me.Btn_Search.Size = New System.Drawing.Size(161, 35)
        Me.Btn_Search.TabIndex = 110
        Me.Btn_Search.Text = "بــحـث"
        Me.Btn_Search.UseVisualStyleBackColor = False
        '
        'NumberOfItemsLbl
        '
        Me.NumberOfItemsLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumberOfItemsLbl.BackColor = System.Drawing.Color.White
        Me.NumberOfItemsLbl.ForeColor = System.Drawing.Color.Black
        Me.NumberOfItemsLbl.Location = New System.Drawing.Point(5, 24)
        Me.NumberOfItemsLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.NumberOfItemsLbl.Name = "NumberOfItemsLbl"
        Me.NumberOfItemsLbl.Size = New System.Drawing.Size(163, 28)
        Me.NumberOfItemsLbl.TabIndex = 2
        Me.NumberOfItemsLbl.Text = "عدد الحركات"
        Me.NumberOfItemsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Product_ID)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Sum_MortagaaElMawarden)
        Me.GroupBox1.Controls.Add(Me.Sum_MortagaaElMawardenLbl)
        Me.GroupBox1.Controls.Add(Me.Sum_MortagaaOmalaa)
        Me.GroupBox1.Controls.Add(Me.Sum_MortagaaOmalaaLbl)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Sum_ElMonsarf)
        Me.GroupBox1.Controls.Add(Me.Initial_Balance)
        Me.GroupBox1.Controls.Add(Me.Sum_ElMonsarfLbl)
        Me.GroupBox1.Controls.Add(Me.Initial_BalanceLBL)
        Me.GroupBox1.Controls.Add(Me.Sum_ElWarad)
        Me.GroupBox1.Controls.Add(Me.Balance)
        Me.GroupBox1.Controls.Add(Me.Sum_ElWaradLbl)
        Me.GroupBox1.Controls.Add(Me.Supplier_Invoice_NumberLbl)
        Me.GroupBox1.Controls.Add(Me.Product_IDLbl)
        Me.GroupBox1.Controls.Add(Me.Product_Namelbl)
        Me.GroupBox1.Controls.Add(Me.Product_Name)
        Me.GroupBox1.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1403, 161)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "بيانات المستند"
        '
        'Product_ID
        '
        Me.Product_ID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Product_ID.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Product_ID.Location = New System.Drawing.Point(1040, 30)
        Me.Product_ID.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Product_ID.Name = "Product_ID"
        Me.Product_ID.Size = New System.Drawing.Size(181, 32)
        Me.Product_ID.TabIndex = 0
        Me.Product_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.NumberOfItems)
        Me.GroupBox2.Controls.Add(Me.Btn_Search)
        Me.GroupBox2.Controls.Add(Me.NumberOfItemsLbl)
        Me.GroupBox2.Location = New System.Drawing.Point(425, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(173, 132)
        Me.GroupBox2.TabIndex = 147
        Me.GroupBox2.TabStop = False
        '
        'Sum_MortagaaElMawarden
        '
        Me.Sum_MortagaaElMawarden.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sum_MortagaaElMawarden.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sum_MortagaaElMawarden.Location = New System.Drawing.Point(800, 116)
        Me.Sum_MortagaaElMawarden.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Sum_MortagaaElMawarden.Name = "Sum_MortagaaElMawarden"
        Me.Sum_MortagaaElMawarden.ReadOnly = True
        Me.Sum_MortagaaElMawarden.Size = New System.Drawing.Size(79, 32)
        Me.Sum_MortagaaElMawarden.TabIndex = 152
        Me.Sum_MortagaaElMawarden.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Sum_MortagaaElMawardenLbl
        '
        Me.Sum_MortagaaElMawardenLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sum_MortagaaElMawardenLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Sum_MortagaaElMawardenLbl.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sum_MortagaaElMawardenLbl.ForeColor = System.Drawing.Color.Black
        Me.Sum_MortagaaElMawardenLbl.Location = New System.Drawing.Point(881, 116)
        Me.Sum_MortagaaElMawardenLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Sum_MortagaaElMawardenLbl.Name = "Sum_MortagaaElMawardenLbl"
        Me.Sum_MortagaaElMawardenLbl.Size = New System.Drawing.Size(129, 30)
        Me.Sum_MortagaaElMawardenLbl.TabIndex = 151
        Me.Sum_MortagaaElMawardenLbl.Text = "مجموع مرتجع الموردين"
        Me.Sum_MortagaaElMawardenLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Sum_MortagaaOmalaa
        '
        Me.Sum_MortagaaOmalaa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sum_MortagaaOmalaa.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sum_MortagaaOmalaa.Location = New System.Drawing.Point(601, 116)
        Me.Sum_MortagaaOmalaa.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Sum_MortagaaOmalaa.Name = "Sum_MortagaaOmalaa"
        Me.Sum_MortagaaOmalaa.ReadOnly = True
        Me.Sum_MortagaaOmalaa.Size = New System.Drawing.Size(70, 32)
        Me.Sum_MortagaaOmalaa.TabIndex = 150
        Me.Sum_MortagaaOmalaa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Sum_MortagaaOmalaaLbl
        '
        Me.Sum_MortagaaOmalaaLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sum_MortagaaOmalaaLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Sum_MortagaaOmalaaLbl.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sum_MortagaaOmalaaLbl.ForeColor = System.Drawing.Color.Black
        Me.Sum_MortagaaOmalaaLbl.Location = New System.Drawing.Point(671, 116)
        Me.Sum_MortagaaOmalaaLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Sum_MortagaaOmalaaLbl.Name = "Sum_MortagaaOmalaaLbl"
        Me.Sum_MortagaaOmalaaLbl.Size = New System.Drawing.Size(125, 30)
        Me.Sum_MortagaaOmalaaLbl.TabIndex = 149
        Me.Sum_MortagaaOmalaaLbl.Text = "مجموع مرتجع العملاء"
        Me.Sum_MortagaaOmalaaLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.Btn_Search_FromDate)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Txt_Date_To)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Txt_Date_From)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(411, 136)
        Me.GroupBox3.TabIndex = 148
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ابحث بين تاريخين"
        '
        'Btn_Search_FromDate
        '
        Me.Btn_Search_FromDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Search_FromDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Search_FromDate.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Search_FromDate.ForeColor = System.Drawing.Color.Black
        Me.Btn_Search_FromDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Search_FromDate.Location = New System.Drawing.Point(7, 100)
        Me.Btn_Search_FromDate.Name = "Btn_Search_FromDate"
        Me.Btn_Search_FromDate.Size = New System.Drawing.Size(398, 30)
        Me.Btn_Search_FromDate.TabIndex = 111
        Me.Btn_Search_FromDate.Text = "بــحـث"
        Me.Btn_Search_FromDate.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(277, 34)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 30)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "التاريخ من"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt_Date_To
        '
        Me.Txt_Date_To.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_Date_To.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Date_To.Location = New System.Drawing.Point(7, 66)
        Me.Txt_Date_To.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Txt_Date_To.Name = "Txt_Date_To"
        Me.Txt_Date_To.Size = New System.Drawing.Size(261, 27)
        Me.Txt_Date_To.TabIndex = 3
        Me.Txt_Date_To.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(277, 66)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 30)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "التاريخ الى"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt_Date_From
        '
        Me.Txt_Date_From.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_Date_From.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Date_From.Location = New System.Drawing.Point(7, 34)
        Me.Txt_Date_From.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Txt_Date_From.Name = "Txt_Date_From"
        Me.Txt_Date_From.Size = New System.Drawing.Size(261, 27)
        Me.Txt_Date_From.TabIndex = 2
        Me.Txt_Date_From.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Sum_ElMonsarf
        '
        Me.Sum_ElMonsarf.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sum_ElMonsarf.BackColor = System.Drawing.Color.Red
        Me.Sum_ElMonsarf.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sum_ElMonsarf.Location = New System.Drawing.Point(1187, 116)
        Me.Sum_ElMonsarf.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Sum_ElMonsarf.Name = "Sum_ElMonsarf"
        Me.Sum_ElMonsarf.ReadOnly = True
        Me.Sum_ElMonsarf.Size = New System.Drawing.Size(79, 32)
        Me.Sum_ElMonsarf.TabIndex = 146
        Me.Sum_ElMonsarf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Initial_Balance
        '
        Me.Initial_Balance.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Initial_Balance.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Initial_Balance.Location = New System.Drawing.Point(1040, 74)
        Me.Initial_Balance.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Initial_Balance.Name = "Initial_Balance"
        Me.Initial_Balance.ReadOnly = True
        Me.Initial_Balance.Size = New System.Drawing.Size(181, 32)
        Me.Initial_Balance.TabIndex = 146
        Me.Initial_Balance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Sum_ElMonsarfLbl
        '
        Me.Sum_ElMonsarfLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sum_ElMonsarfLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Sum_ElMonsarfLbl.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sum_ElMonsarfLbl.ForeColor = System.Drawing.Color.Black
        Me.Sum_ElMonsarfLbl.Location = New System.Drawing.Point(1266, 116)
        Me.Sum_ElMonsarfLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Sum_ElMonsarfLbl.Name = "Sum_ElMonsarfLbl"
        Me.Sum_ElMonsarfLbl.Size = New System.Drawing.Size(125, 30)
        Me.Sum_ElMonsarfLbl.TabIndex = 145
        Me.Sum_ElMonsarfLbl.Text = "مجموع المنصرف"
        Me.Sum_ElMonsarfLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Initial_BalanceLBL
        '
        Me.Initial_BalanceLBL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Initial_BalanceLBL.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Initial_BalanceLBL.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Initial_BalanceLBL.ForeColor = System.Drawing.Color.Black
        Me.Initial_BalanceLBL.Location = New System.Drawing.Point(1236, 74)
        Me.Initial_BalanceLBL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Initial_BalanceLBL.Name = "Initial_BalanceLBL"
        Me.Initial_BalanceLBL.Size = New System.Drawing.Size(155, 30)
        Me.Initial_BalanceLBL.TabIndex = 145
        Me.Initial_BalanceLBL.Text = "رصيد بداية المدة"
        Me.Initial_BalanceLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Sum_ElWarad
        '
        Me.Sum_ElWarad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sum_ElWarad.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sum_ElWarad.Location = New System.Drawing.Point(1014, 116)
        Me.Sum_ElWarad.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Sum_ElWarad.Name = "Sum_ElWarad"
        Me.Sum_ElWarad.ReadOnly = True
        Me.Sum_ElWarad.Size = New System.Drawing.Size(70, 32)
        Me.Sum_ElWarad.TabIndex = 144
        Me.Sum_ElWarad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Sum_ElWaradLbl
        '
        Me.Sum_ElWaradLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sum_ElWaradLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Sum_ElWaradLbl.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sum_ElWaradLbl.ForeColor = System.Drawing.Color.Black
        Me.Sum_ElWaradLbl.Location = New System.Drawing.Point(1084, 116)
        Me.Sum_ElWaradLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Sum_ElWaradLbl.Name = "Sum_ElWaradLbl"
        Me.Sum_ElWaradLbl.Size = New System.Drawing.Size(100, 30)
        Me.Sum_ElWaradLbl.TabIndex = 143
        Me.Sum_ElWaradLbl.Text = "مجموع الوارد"
        Me.Sum_ElWaradLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Product_IDLbl
        '
        Me.Product_IDLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Product_IDLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Product_IDLbl.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Product_IDLbl.ForeColor = System.Drawing.Color.Black
        Me.Product_IDLbl.Location = New System.Drawing.Point(1236, 30)
        Me.Product_IDLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Product_IDLbl.Name = "Product_IDLbl"
        Me.Product_IDLbl.Size = New System.Drawing.Size(155, 30)
        Me.Product_IDLbl.TabIndex = 2
        Me.Product_IDLbl.Text = "كود الصنف"
        Me.Product_IDLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Product_Namelbl
        '
        Me.Product_Namelbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Product_Namelbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Product_Namelbl.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Product_Namelbl.ForeColor = System.Drawing.Color.Black
        Me.Product_Namelbl.Location = New System.Drawing.Point(881, 30)
        Me.Product_Namelbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Product_Namelbl.Name = "Product_Namelbl"
        Me.Product_Namelbl.Size = New System.Drawing.Size(155, 30)
        Me.Product_Namelbl.TabIndex = 6
        Me.Product_Namelbl.Text = "اسم الصنف"
        Me.Product_Namelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Product_Name
        '
        Me.Product_Name.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Product_Name.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Product_Name.Location = New System.Drawing.Point(601, 30)
        Me.Product_Name.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Product_Name.Name = "Product_Name"
        Me.Product_Name.ReadOnly = True
        Me.Product_Name.Size = New System.Drawing.Size(276, 32)
        Me.Product_Name.TabIndex = 4
        Me.Product_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Invoice_IDlbl)
        Me.Panel1.Controls.Add(Me.Invoice_ID)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1417, 45)
        Me.Panel1.TabIndex = 143
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.GroupBox1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 45)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1417, 172)
        Me.Panel4.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.dgv_Tbl_InvoiceItems)
        Me.Panel5.Location = New System.Drawing.Point(2, 223)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1412, 468)
        Me.Panel5.TabIndex = 151
        '
        'dgv_Tbl_InvoiceItems
        '
        Me.dgv_Tbl_InvoiceItems.AllowUserToAddRows = False
        Me.dgv_Tbl_InvoiceItems.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_Tbl_InvoiceItems.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Tbl_InvoiceItems.AutoGenerateContextFilters = True
        Me.dgv_Tbl_InvoiceItems.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Tbl_InvoiceItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_Tbl_InvoiceItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Tbl_InvoiceItems.DateWithTime = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Tbl_InvoiceItems.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_Tbl_InvoiceItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Tbl_InvoiceItems.Location = New System.Drawing.Point(0, 0)
        Me.dgv_Tbl_InvoiceItems.Name = "dgv_Tbl_InvoiceItems"
        Me.dgv_Tbl_InvoiceItems.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Tbl_InvoiceItems.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_Tbl_InvoiceItems.RowHeadersVisible = False
        Me.dgv_Tbl_InvoiceItems.RowHeadersWidth = 51
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_Tbl_InvoiceItems.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_Tbl_InvoiceItems.RowTemplate.Height = 26
        Me.dgv_Tbl_InvoiceItems.Size = New System.Drawing.Size(1412, 468)
        Me.dgv_Tbl_InvoiceItems.TabIndex = 150
        Me.dgv_Tbl_InvoiceItems.TimeFilter = False
        '
        'Frm_Search_Item_Movement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1417, 756)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Frm_Search_Item_Movement"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.dgv_Tbl_InvoiceItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Balance As TextBox
    Friend WithEvents Supplier_Invoice_NumberLbl As Label
    Friend WithEvents NumberOfItems As TextBox
    Friend WithEvents Invoice_IDlbl As Label
    Friend WithEvents Invoice_ID As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Product_IDLbl As Label
    Friend WithEvents Product_Namelbl As Label
    Friend WithEvents Product_ID As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents NumberOfItemsLbl As Label
    Friend WithEvents Product_Name As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_Date_To As TextBox
    Friend WithEvents Txt_Date_From As TextBox
    Friend WithEvents Initial_Balance As TextBox
    Friend WithEvents Initial_BalanceLBL As Label
    Friend WithEvents Btn_Search As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Btn_Search_Products As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Btn_Search_FromDate As Button
    Friend WithEvents Btn_ExportToExcel As Button
    Friend WithEvents Sum_ElMonsarf As TextBox
    Friend WithEvents Sum_ElMonsarfLbl As Label
    Friend WithEvents Sum_ElWarad As TextBox
    Friend WithEvents Sum_ElWaradLbl As Label
    Friend WithEvents Sum_MortagaaElMawarden As TextBox
    Friend WithEvents Sum_MortagaaElMawardenLbl As Label
    Friend WithEvents Sum_MortagaaOmalaa As TextBox
    Friend WithEvents Sum_MortagaaOmalaaLbl As Label
    Friend WithEvents dgv_Tbl_InvoiceItems As ADGV.AdvancedDataGridView
    Friend WithEvents BindingSource1 As BindingSource
End Class
