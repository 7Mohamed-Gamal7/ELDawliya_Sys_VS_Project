<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_GroupForms
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
        Me.GroupFormIDlbl = New System.Windows.Forms.Label()
        Me.GroupFormID = New System.Windows.Forms.TextBox()
        Me.GroupIDlbl = New System.Windows.Forms.Label()
        Me.FormIDlbl = New System.Windows.Forms.Label()
        Me.BtnNewAdd = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.FormID = New System.Windows.Forms.ComboBox()
        Me.GroupID = New System.Windows.Forms.ComboBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dgv_GroupForms = New ADGV.AdvancedDataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgv_GroupForms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupFormIDlbl
        '
        Me.GroupFormIDlbl.Location = New System.Drawing.Point(1244, 5)
        Me.GroupFormIDlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GroupFormIDlbl.Name = "GroupFormIDlbl"
        Me.GroupFormIDlbl.Size = New System.Drawing.Size(184, 32)
        Me.GroupFormIDlbl.TabIndex = 0
        Me.GroupFormIDlbl.Text = "كود مجموعة النماذج"
        Me.GroupFormIDlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.GroupFormIDlbl.Visible = False
        '
        'GroupFormID
        '
        Me.GroupFormID.Location = New System.Drawing.Point(1014, 5)
        Me.GroupFormID.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.GroupFormID.Name = "GroupFormID"
        Me.GroupFormID.Size = New System.Drawing.Size(226, 39)
        Me.GroupFormID.TabIndex = 1
        Me.GroupFormID.Visible = False
        '
        'GroupIDlbl
        '
        Me.GroupIDlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupIDlbl.Location = New System.Drawing.Point(1208, 6)
        Me.GroupIDlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GroupIDlbl.Name = "GroupIDlbl"
        Me.GroupIDlbl.Size = New System.Drawing.Size(222, 32)
        Me.GroupIDlbl.TabIndex = 2
        Me.GroupIDlbl.Text = "مجموعة المستخدمين"
        Me.GroupIDlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FormIDlbl
        '
        Me.FormIDlbl.Location = New System.Drawing.Point(265, 6)
        Me.FormIDlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.FormIDlbl.Name = "FormIDlbl"
        Me.FormIDlbl.Size = New System.Drawing.Size(145, 32)
        Me.FormIDlbl.TabIndex = 4
        Me.FormIDlbl.Text = "اسم النموذج"
        Me.FormIDlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnNewAdd
        '
        Me.BtnNewAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNewAdd.Location = New System.Drawing.Point(1205, 8)
        Me.BtnNewAdd.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.BtnNewAdd.Name = "BtnNewAdd"
        Me.BtnNewAdd.Size = New System.Drawing.Size(224, 50)
        Me.BtnNewAdd.TabIndex = 7
        Me.BtnNewAdd.Text = "إضافة"
        Me.BtnNewAdd.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.Location = New System.Drawing.Point(906, 8)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(224, 50)
        Me.BtnSave.TabIndex = 8
        Me.BtnSave.Text = "حفظ"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEdit.Location = New System.Drawing.Point(607, 8)
        Me.BtnEdit.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(224, 50)
        Me.BtnEdit.TabIndex = 9
        Me.BtnEdit.Text = "تعديل"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(308, 8)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(224, 50)
        Me.BtnDelete.TabIndex = 10
        Me.BtnDelete.Text = "حذف"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(9, 8)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(224, 50)
        Me.BtnClose.TabIndex = 11
        Me.BtnClose.Text = "انهاء"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.GroupFormIDlbl)
        Me.Panel1.Controls.Add(Me.GroupFormID)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1436, 58)
        Me.Panel1.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1436, 58)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "شاشة ربط النماذج بالمجموعات"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.BtnNewAdd)
        Me.Panel2.Controls.Add(Me.BtnClose)
        Me.Panel2.Controls.Add(Me.BtnDelete)
        Me.Panel2.Controls.Add(Me.BtnEdit)
        Me.Panel2.Controls.Add(Me.BtnSave)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 704)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1436, 62)
        Me.Panel2.TabIndex = 13
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.FormID)
        Me.Panel3.Controls.Add(Me.GroupID)
        Me.Panel3.Controls.Add(Me.FormIDlbl)
        Me.Panel3.Controls.Add(Me.GroupIDlbl)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 58)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1436, 54)
        Me.Panel3.TabIndex = 14
        '
        'FormID
        '
        Me.FormID.FormattingEnabled = True
        Me.FormID.Location = New System.Drawing.Point(3, 6)
        Me.FormID.Name = "FormID"
        Me.FormID.Size = New System.Drawing.Size(257, 40)
        Me.FormID.TabIndex = 6
        '
        'GroupID
        '
        Me.GroupID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupID.FormattingEnabled = True
        Me.GroupID.Location = New System.Drawing.Point(946, 6)
        Me.GroupID.Name = "GroupID"
        Me.GroupID.Size = New System.Drawing.Size(257, 40)
        Me.GroupID.TabIndex = 6
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.dgv_GroupForms)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 112)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1436, 592)
        Me.Panel4.TabIndex = 15
        '
        'dgv_GroupForms
        '
        Me.dgv_GroupForms.AllowUserToAddRows = False
        Me.dgv_GroupForms.AllowUserToDeleteRows = False
        Me.dgv_GroupForms.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_GroupForms.AutoGenerateContextFilters = True
        Me.dgv_GroupForms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_GroupForms.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_GroupForms.BackgroundColor = System.Drawing.Color.White
        Me.dgv_GroupForms.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_GroupForms.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_GroupForms.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_GroupForms.ColumnHeadersHeight = 40
        Me.dgv_GroupForms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_GroupForms.DateWithTime = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_GroupForms.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_GroupForms.EnableHeadersVisualStyles = False
        Me.dgv_GroupForms.GridColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dgv_GroupForms.Location = New System.Drawing.Point(12, 6)
        Me.dgv_GroupForms.Name = "dgv_GroupForms"
        Me.dgv_GroupForms.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_GroupForms.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_GroupForms.RowHeadersVisible = False
        Me.dgv_GroupForms.RowHeadersWidth = 51
        Me.dgv_GroupForms.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgv_GroupForms.RowTemplate.Height = 26
        Me.dgv_GroupForms.Size = New System.Drawing.Size(1418, 580)
        Me.dgv_GroupForms.TabIndex = 7
        Me.dgv_GroupForms.TimeFilter = False
        '
        'Frm_GroupForms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1436, 766)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.MaximizeBox = False
        Me.Name = "Frm_GroupForms"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.dgv_GroupForms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupFormID As System.Windows.Forms.TextBox
    Friend WithEvents GroupFormIDlbl As System.Windows.Forms.Label
    Friend WithEvents GroupIDlbl As System.Windows.Forms.Label
    Friend WithEvents FormIDlbl As System.Windows.Forms.Label
    Friend WithEvents BtnNewAdd As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents dgv_GroupForms As ADGV.AdvancedDataGridView
    Friend WithEvents FormID As ComboBox
    Friend WithEvents GroupID As ComboBox
    Friend WithEvents Label1 As Label
End Class
