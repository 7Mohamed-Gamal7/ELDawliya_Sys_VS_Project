<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Document_Management
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Invoice_ID = New System.Windows.Forms.TextBox()
        Me.txt_Recipient = New System.Windows.Forms.TextBox()
        Me.Supplier_Invoice_Number = New System.Windows.Forms.TextBox()
        Me.Supplier_Invoice_NumberLbl = New System.Windows.Forms.Label()
        Me.Total_Invoice_ValueLbl = New System.Windows.Forms.Label()
        Me.Total_Invoice_Value = New System.Windows.Forms.TextBox()
        Me.Invoice_TypeLbL = New System.Windows.Forms.Label()
        Me.NumberOfItemsLbl = New System.Windows.Forms.Label()
        Me.Customer_IDLbl = New System.Windows.Forms.Label()
        Me.Supplier_IDlbl = New System.Windows.Forms.Label()
        Me.Invoice_Type = New System.Windows.Forms.TextBox()
        Me.NumberOfItems = New System.Windows.Forms.TextBox()
        Me.Customer_ID = New System.Windows.Forms.ComboBox()
        Me.Supplier_ID = New System.Windows.Forms.ComboBox()
        Me.dtp_Invoice_Date = New System.Windows.Forms.DateTimePicker()
        Me.cmb_Invoice_Type = New System.Windows.Forms.ComboBox()
        Me.txt_Invoice_Number = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgv_Tbl_InvoiceItems = New System.Windows.Forms.DataGridView()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_Tbl_InvoiceItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Invoice_ID)
        Me.GroupBox1.Controls.Add(Me.txt_Recipient)
        Me.GroupBox1.Controls.Add(Me.Supplier_Invoice_Number)
        Me.GroupBox1.Controls.Add(Me.Supplier_Invoice_NumberLbl)
        Me.GroupBox1.Controls.Add(Me.Total_Invoice_ValueLbl)
        Me.GroupBox1.Controls.Add(Me.Total_Invoice_Value)
        Me.GroupBox1.Controls.Add(Me.Invoice_TypeLbL)
        Me.GroupBox1.Controls.Add(Me.NumberOfItemsLbl)
        Me.GroupBox1.Controls.Add(Me.Customer_IDLbl)
        Me.GroupBox1.Controls.Add(Me.Supplier_IDlbl)
        Me.GroupBox1.Controls.Add(Me.Invoice_Type)
        Me.GroupBox1.Controls.Add(Me.NumberOfItems)
        Me.GroupBox1.Controls.Add(Me.Customer_ID)
        Me.GroupBox1.Controls.Add(Me.Supplier_ID)
        Me.GroupBox1.Controls.Add(Me.dtp_Invoice_Date)
        Me.GroupBox1.Controls.Add(Me.cmb_Invoice_Type)
        Me.GroupBox1.Controls.Add(Me.txt_Invoice_Number)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 15)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(1120, 199)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "بيانات المستند"
        '
        'Invoice_ID
        '
        Me.Invoice_ID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Invoice_ID.Enabled = False
        Me.Invoice_ID.Location = New System.Drawing.Point(295, 16)
        Me.Invoice_ID.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Invoice_ID.Name = "Invoice_ID"
        Me.Invoice_ID.ReadOnly = True
        Me.Invoice_ID.Size = New System.Drawing.Size(116, 24)
        Me.Invoice_ID.TabIndex = 149
        Me.Invoice_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_Recipient
        '
        Me.txt_Recipient.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Recipient.Enabled = False
        Me.txt_Recipient.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Recipient.Location = New System.Drawing.Point(298, 60)
        Me.txt_Recipient.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txt_Recipient.Name = "txt_Recipient"
        Me.txt_Recipient.ReadOnly = True
        Me.txt_Recipient.Size = New System.Drawing.Size(203, 38)
        Me.txt_Recipient.TabIndex = 148
        Me.txt_Recipient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Supplier_Invoice_Number
        '
        Me.Supplier_Invoice_Number.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Supplier_Invoice_Number.Enabled = False
        Me.Supplier_Invoice_Number.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Supplier_Invoice_Number.Location = New System.Drawing.Point(298, 102)
        Me.Supplier_Invoice_Number.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Supplier_Invoice_Number.Name = "Supplier_Invoice_Number"
        Me.Supplier_Invoice_Number.ReadOnly = True
        Me.Supplier_Invoice_Number.Size = New System.Drawing.Size(203, 38)
        Me.Supplier_Invoice_Number.TabIndex = 148
        Me.Supplier_Invoice_Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Supplier_Invoice_NumberLbl
        '
        Me.Supplier_Invoice_NumberLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Supplier_Invoice_NumberLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Supplier_Invoice_NumberLbl.ForeColor = System.Drawing.Color.Black
        Me.Supplier_Invoice_NumberLbl.Location = New System.Drawing.Point(505, 106)
        Me.Supplier_Invoice_NumberLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Supplier_Invoice_NumberLbl.Name = "Supplier_Invoice_NumberLbl"
        Me.Supplier_Invoice_NumberLbl.Size = New System.Drawing.Size(158, 34)
        Me.Supplier_Invoice_NumberLbl.TabIndex = 147
        Me.Supplier_Invoice_NumberLbl.Text = "رقم الاذن للمورد"
        Me.Supplier_Invoice_NumberLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Total_Invoice_ValueLbl
        '
        Me.Total_Invoice_ValueLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Total_Invoice_ValueLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Total_Invoice_ValueLbl.ForeColor = System.Drawing.Color.Black
        Me.Total_Invoice_ValueLbl.Location = New System.Drawing.Point(505, 145)
        Me.Total_Invoice_ValueLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Total_Invoice_ValueLbl.Name = "Total_Invoice_ValueLbl"
        Me.Total_Invoice_ValueLbl.Size = New System.Drawing.Size(161, 34)
        Me.Total_Invoice_ValueLbl.TabIndex = 145
        Me.Total_Invoice_ValueLbl.Text = "الاجمالى الكلى للفاتورة"
        Me.Total_Invoice_ValueLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Total_Invoice_Value
        '
        Me.Total_Invoice_Value.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Total_Invoice_Value.Enabled = False
        Me.Total_Invoice_Value.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total_Invoice_Value.Location = New System.Drawing.Point(298, 142)
        Me.Total_Invoice_Value.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Total_Invoice_Value.Name = "Total_Invoice_Value"
        Me.Total_Invoice_Value.ReadOnly = True
        Me.Total_Invoice_Value.Size = New System.Drawing.Size(203, 38)
        Me.Total_Invoice_Value.TabIndex = 146
        Me.Total_Invoice_Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Invoice_TypeLbL
        '
        Me.Invoice_TypeLbL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Invoice_TypeLbL.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Invoice_TypeLbL.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Invoice_TypeLbL.ForeColor = System.Drawing.Color.Black
        Me.Invoice_TypeLbL.Location = New System.Drawing.Point(186, 146)
        Me.Invoice_TypeLbL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Invoice_TypeLbL.Name = "Invoice_TypeLbL"
        Me.Invoice_TypeLbL.Size = New System.Drawing.Size(108, 34)
        Me.Invoice_TypeLbL.TabIndex = 117
        Me.Invoice_TypeLbL.Text = "نوع المستند"
        Me.Invoice_TypeLbL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NumberOfItemsLbl
        '
        Me.NumberOfItemsLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumberOfItemsLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.NumberOfItemsLbl.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberOfItemsLbl.ForeColor = System.Drawing.Color.Black
        Me.NumberOfItemsLbl.Location = New System.Drawing.Point(186, 106)
        Me.NumberOfItemsLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.NumberOfItemsLbl.Name = "NumberOfItemsLbl"
        Me.NumberOfItemsLbl.Size = New System.Drawing.Size(108, 34)
        Me.NumberOfItemsLbl.TabIndex = 118
        Me.NumberOfItemsLbl.Text = "عدد الاصناف"
        Me.NumberOfItemsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Customer_IDLbl
        '
        Me.Customer_IDLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Customer_IDLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Customer_IDLbl.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Customer_IDLbl.ForeColor = System.Drawing.Color.Black
        Me.Customer_IDLbl.Location = New System.Drawing.Point(186, 64)
        Me.Customer_IDLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Customer_IDLbl.Name = "Customer_IDLbl"
        Me.Customer_IDLbl.Size = New System.Drawing.Size(107, 34)
        Me.Customer_IDLbl.TabIndex = 121
        Me.Customer_IDLbl.Text = "اسم العميل"
        Me.Customer_IDLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Supplier_IDlbl
        '
        Me.Supplier_IDlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Supplier_IDlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Supplier_IDlbl.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Supplier_IDlbl.ForeColor = System.Drawing.Color.Black
        Me.Supplier_IDlbl.Location = New System.Drawing.Point(186, 16)
        Me.Supplier_IDlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Supplier_IDlbl.Name = "Supplier_IDlbl"
        Me.Supplier_IDlbl.Size = New System.Drawing.Size(105, 34)
        Me.Supplier_IDlbl.TabIndex = 122
        Me.Supplier_IDlbl.Text = "اسم المورد"
        Me.Supplier_IDlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Invoice_Type
        '
        Me.Invoice_Type.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Invoice_Type.Enabled = False
        Me.Invoice_Type.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Invoice_Type.Location = New System.Drawing.Point(7, 146)
        Me.Invoice_Type.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Invoice_Type.Name = "Invoice_Type"
        Me.Invoice_Type.ReadOnly = True
        Me.Invoice_Type.Size = New System.Drawing.Size(175, 36)
        Me.Invoice_Type.TabIndex = 119
        Me.Invoice_Type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NumberOfItems
        '
        Me.NumberOfItems.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumberOfItems.Enabled = False
        Me.NumberOfItems.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumberOfItems.Location = New System.Drawing.Point(7, 106)
        Me.NumberOfItems.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.NumberOfItems.Name = "NumberOfItems"
        Me.NumberOfItems.ReadOnly = True
        Me.NumberOfItems.Size = New System.Drawing.Size(175, 36)
        Me.NumberOfItems.TabIndex = 120
        Me.NumberOfItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Customer_ID
        '
        Me.Customer_ID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Customer_ID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Customer_ID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Customer_ID.Enabled = False
        Me.Customer_ID.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Customer_ID.FormattingEnabled = True
        Me.Customer_ID.Location = New System.Drawing.Point(7, 64)
        Me.Customer_ID.Name = "Customer_ID"
        Me.Customer_ID.Size = New System.Drawing.Size(175, 37)
        Me.Customer_ID.TabIndex = 123
        '
        'Supplier_ID
        '
        Me.Supplier_ID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Supplier_ID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Supplier_ID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Supplier_ID.Enabled = False
        Me.Supplier_ID.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Supplier_ID.FormattingEnabled = True
        Me.Supplier_ID.Location = New System.Drawing.Point(7, 16)
        Me.Supplier_ID.Name = "Supplier_ID"
        Me.Supplier_ID.Size = New System.Drawing.Size(175, 37)
        Me.Supplier_ID.TabIndex = 124
        '
        'dtp_Invoice_Date
        '
        Me.dtp_Invoice_Date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Invoice_Date.Location = New System.Drawing.Point(525, 33)
        Me.dtp_Invoice_Date.Margin = New System.Windows.Forms.Padding(4)
        Me.dtp_Invoice_Date.Name = "dtp_Invoice_Date"
        Me.dtp_Invoice_Date.Size = New System.Drawing.Size(167, 24)
        Me.dtp_Invoice_Date.TabIndex = 5
        '
        'cmb_Invoice_Type
        '
        Me.cmb_Invoice_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Invoice_Type.FormattingEnabled = True
        Me.cmb_Invoice_Type.Location = New System.Drawing.Point(817, 70)
        Me.cmb_Invoice_Type.Margin = New System.Windows.Forms.Padding(4)
        Me.cmb_Invoice_Type.Name = "cmb_Invoice_Type"
        Me.cmb_Invoice_Type.Size = New System.Drawing.Size(167, 24)
        Me.cmb_Invoice_Type.TabIndex = 3
        '
        'txt_Invoice_Number
        '
        Me.txt_Invoice_Number.Location = New System.Drawing.Point(817, 33)
        Me.txt_Invoice_Number.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_Invoice_Number.Name = "txt_Invoice_Number"
        Me.txt_Invoice_Number.Size = New System.Drawing.Size(167, 24)
        Me.txt_Invoice_Number.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(700, 37)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "تاريخ المستند:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(992, 74)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "نوع المستند:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(992, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "رقم المستند:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgv_Tbl_InvoiceItems)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 222)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox2.Size = New System.Drawing.Size(1120, 492)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "تفاصيل الأصناف"
        '
        'dgv_Tbl_InvoiceItems
        '
        Me.dgv_Tbl_InvoiceItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Tbl_InvoiceItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_Tbl_InvoiceItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Tbl_InvoiceItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Tbl_InvoiceItems.Location = New System.Drawing.Point(4, 21)
        Me.dgv_Tbl_InvoiceItems.Margin = New System.Windows.Forms.Padding(4)
        Me.dgv_Tbl_InvoiceItems.Name = "dgv_Tbl_InvoiceItems"
        Me.dgv_Tbl_InvoiceItems.RowHeadersWidth = 51
        Me.dgv_Tbl_InvoiceItems.Size = New System.Drawing.Size(1112, 467)
        Me.dgv_Tbl_InvoiceItems.TabIndex = 0
        '
        'btn_Save
        '
        Me.btn_Save.Location = New System.Drawing.Point(1046, 718)
        Me.btn_Save.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(88, 28)
        Me.btn_Save.TabIndex = 2
        Me.btn_Save.Text = "حفظ"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'btn_Clear
        '
        Me.btn_Clear.Location = New System.Drawing.Point(952, 718)
        Me.btn_Clear.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(88, 28)
        Me.btn_Clear.TabIndex = 3
        Me.btn_Clear.Text = "مسح"
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'Document_Management
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1148, 755)
        Me.Controls.Add(Me.btn_Clear)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Document_Management"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "إدارة المستندات"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgv_Tbl_InvoiceItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_Invoice_Number As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_Invoice_Type As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtp_Invoice_Date As DateTimePicker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgv_Tbl_InvoiceItems As DataGridView
    Friend WithEvents btn_Save As Button
    Friend WithEvents btn_Clear As Button
    Friend WithEvents Invoice_TypeLbL As Label
    Friend WithEvents NumberOfItemsLbl As Label
    Friend WithEvents Customer_IDLbl As Label
    Friend WithEvents Supplier_IDlbl As Label
    Friend WithEvents Invoice_Type As TextBox
    Friend WithEvents NumberOfItems As TextBox
    Friend WithEvents Customer_ID As ComboBox
    Friend WithEvents Supplier_ID As ComboBox
    Friend WithEvents Supplier_Invoice_Number As TextBox
    Friend WithEvents Supplier_Invoice_NumberLbl As Label
    Friend WithEvents Total_Invoice_ValueLbl As Label
    Friend WithEvents Total_Invoice_Value As TextBox
    Friend WithEvents Invoice_ID As TextBox
    Friend WithEvents txt_Recipient As TextBox
End Class
