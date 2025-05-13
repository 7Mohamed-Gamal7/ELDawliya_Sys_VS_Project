<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Add_Suppliers
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
        Me.Supplier_Name = New System.Windows.Forms.TextBox()
        Me.Supplier_IDLbl = New System.Windows.Forms.Label()
        Me.Supplier_NAMELbl = New System.Windows.Forms.Label()
        Me.Supplier_ID = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BtnNewAdd = New System.Windows.Forms.ToolStripButton()
        Me.BtnSave = New System.Windows.Forms.ToolStripButton()
        Me.BtnEdit = New System.Windows.Forms.ToolStripButton()
        Me.BtnDelete = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_Suppliers = New System.Windows.Forms.DataGridView()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.Txt_Search = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgv_Suppliers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Supplier_Name
        '
        Me.Supplier_Name.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Supplier_Name.Location = New System.Drawing.Point(23, 49)
        Me.Supplier_Name.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Supplier_Name.Name = "Supplier_Name"
        Me.Supplier_Name.Size = New System.Drawing.Size(429, 38)
        Me.Supplier_Name.TabIndex = 3
        Me.Supplier_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Supplier_IDLbl
        '
        Me.Supplier_IDLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Supplier_IDLbl.ForeColor = System.Drawing.Color.Black
        Me.Supplier_IDLbl.Location = New System.Drawing.Point(458, 5)
        Me.Supplier_IDLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Supplier_IDLbl.Name = "Supplier_IDLbl"
        Me.Supplier_IDLbl.Size = New System.Drawing.Size(170, 34)
        Me.Supplier_IDLbl.TabIndex = 0
        Me.Supplier_IDLbl.Text = "كود المورد"
        Me.Supplier_IDLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Supplier_NAMELbl
        '
        Me.Supplier_NAMELbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Supplier_NAMELbl.ForeColor = System.Drawing.Color.Black
        Me.Supplier_NAMELbl.Location = New System.Drawing.Point(458, 49)
        Me.Supplier_NAMELbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Supplier_NAMELbl.Name = "Supplier_NAMELbl"
        Me.Supplier_NAMELbl.Size = New System.Drawing.Size(170, 34)
        Me.Supplier_NAMELbl.TabIndex = 2
        Me.Supplier_NAMELbl.Text = "اسم المورد"
        Me.Supplier_NAMELbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Supplier_ID
        '
        Me.Supplier_ID.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Supplier_ID.Location = New System.Drawing.Point(23, 5)
        Me.Supplier_ID.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Supplier_ID.Name = "Supplier_ID"
        Me.Supplier_ID.ReadOnly = True
        Me.Supplier_ID.Size = New System.Drawing.Size(429, 38)
        Me.Supplier_ID.TabIndex = 1
        Me.Supplier_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 566)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(640, 60)
        Me.Panel1.TabIndex = 115
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtnNewAdd, Me.BtnSave, Me.BtnEdit, Me.BtnDelete})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(640, 60)
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
        Me.BtnNewAdd.Text = "جديد"
        Me.BtnNewAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNewAdd.ToolTipText = "اضافة سجل جديد"
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
        Me.BtnSave.ToolTipText = "حفظ السجل المحدد"
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
        Me.BtnEdit.ToolTipText = "تعديل السجل المحدد"
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
        Me.BtnDelete.ToolTipText = "حذف السجل المحدد"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Hacen Saudi Arabia", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(640, 54)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "اضافة مورد جديد"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgv_Suppliers
        '
        Me.dgv_Suppliers.AllowUserToAddRows = False
        Me.dgv_Suppliers.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Cairo", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv_Suppliers.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Suppliers.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Suppliers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_Suppliers.ColumnHeadersHeight = 40
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Suppliers.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_Suppliers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Suppliers.EnableHeadersVisualStyles = False
        Me.dgv_Suppliers.Location = New System.Drawing.Point(0, 0)
        Me.dgv_Suppliers.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.dgv_Suppliers.Name = "dgv_Suppliers"
        Me.dgv_Suppliers.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Suppliers.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_Suppliers.RowHeadersVisible = False
        Me.dgv_Suppliers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Cairo SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_Suppliers.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_Suppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Suppliers.Size = New System.Drawing.Size(640, 376)
        Me.dgv_Suppliers.TabIndex = 116
        '
        'MetroPanel2
        '
        Me.MetroPanel2.BackColor = System.Drawing.Color.Teal
        Me.MetroPanel2.Controls.Add(Me.Label1)
        Me.MetroPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(0, 0)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(640, 54)
        Me.MetroPanel2.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroPanel2.TabIndex = 160
        Me.MetroPanel2.UseCustomBackColor = True
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'Txt_Search
        '
        Me.Txt_Search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_Search.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Search.Location = New System.Drawing.Point(23, 93)
        Me.Txt_Search.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Txt_Search.Name = "Txt_Search"
        Me.Txt_Search.Size = New System.Drawing.Size(429, 38)
        Me.Txt_Search.TabIndex = 43
        Me.Txt_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(458, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 34)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "ابحث هنا"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Txt_Search)
        Me.Panel2.Controls.Add(Me.Supplier_ID)
        Me.Panel2.Controls.Add(Me.Supplier_NAMELbl)
        Me.Panel2.Controls.Add(Me.Supplier_IDLbl)
        Me.Panel2.Controls.Add(Me.Supplier_Name)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 54)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(640, 136)
        Me.Panel2.TabIndex = 161
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dgv_Suppliers)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 190)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(640, 376)
        Me.Panel3.TabIndex = 162
        '
        'Frm_Add_Suppliers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(640, 626)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MetroPanel2)
        Me.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Frm_Add_Suppliers"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgv_Suppliers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Supplier_Name As TextBox
    Friend WithEvents Supplier_IDLbl As Label
    Friend WithEvents Supplier_NAMELbl As Label
    Friend WithEvents Supplier_ID As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents dgv_Suppliers As DataGridView
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents Txt_Search As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents BtnNewAdd As ToolStripButton
    Friend WithEvents BtnSave As ToolStripButton
    Friend WithEvents BtnEdit As ToolStripButton
    Friend WithEvents BtnDelete As ToolStripButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
