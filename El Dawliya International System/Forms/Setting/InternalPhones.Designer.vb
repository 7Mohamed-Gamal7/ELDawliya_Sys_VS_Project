<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InternalPhones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InternalPhones))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Txt_Search = New System.Windows.Forms.TextBox()
        Me.Lbl_Search = New System.Windows.Forms.Label()
        Me.BtnNewAdd = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.btn_Print_Report = New System.Windows.Forms.Button()
        Me.btn_UpdateStatus = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblEmployeeName = New System.Windows.Forms.Label()
        Me.lblDept_Code = New System.Windows.Forms.Label()
        Me.lblPhoneExtension = New System.Windows.Forms.Label()
        Me.EmployeeName = New System.Windows.Forms.TextBox()
        Me.Dept_Code = New System.Windows.Forms.ComboBox()
        Me.PhoneExtension = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgv_InternalPhones = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgv_InternalPhones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ID)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1415, 61)
        Me.Panel1.TabIndex = 0
        '
        'ID
        '
        Me.ID.Location = New System.Drawing.Point(12, 12)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(101, 39)
        Me.ID.TabIndex = 5
        Me.ID.Visible = False
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1415, 61)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "شاشة التليفون الداخلى للشركة"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Txt_Search)
        Me.Panel2.Controls.Add(Me.Lbl_Search)
        Me.Panel2.Controls.Add(Me.BtnNewAdd)
        Me.Panel2.Controls.Add(Me.BtnSave)
        Me.Panel2.Controls.Add(Me.BtnEdit)
        Me.Panel2.Controls.Add(Me.BtnDelete)
        Me.Panel2.Controls.Add(Me.btn_Print_Report)
        Me.Panel2.Controls.Add(Me.btn_UpdateStatus)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 620)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1415, 88)
        Me.Panel2.TabIndex = 1
        '
        'Txt_Search
        '
        Me.Txt_Search.Location = New System.Drawing.Point(191, 21)
        Me.Txt_Search.Name = "Txt_Search"
        Me.Txt_Search.Size = New System.Drawing.Size(204, 39)
        Me.Txt_Search.TabIndex = 110
        '
        'Lbl_Search
        '
        Me.Lbl_Search.AutoSize = True
        Me.Lbl_Search.Location = New System.Drawing.Point(413, 21)
        Me.Lbl_Search.Name = "Lbl_Search"
        Me.Lbl_Search.Size = New System.Drawing.Size(80, 32)
        Me.Lbl_Search.TabIndex = 109
        Me.Lbl_Search.Text = "إبحث هنا"
        '
        'BtnNewAdd
        '
        Me.BtnNewAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNewAdd.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Add
        Me.BtnNewAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNewAdd.Location = New System.Drawing.Point(1210, 13)
        Me.BtnNewAdd.Name = "BtnNewAdd"
        Me.BtnNewAdd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnNewAdd.Size = New System.Drawing.Size(193, 57)
        Me.BtnNewAdd.TabIndex = 105
        Me.BtnNewAdd.Text = "جديد"
        Me.BtnNewAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNewAdd.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Ok
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Location = New System.Drawing.Point(1011, 13)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnSave.Size = New System.Drawing.Size(193, 57)
        Me.BtnSave.TabIndex = 106
        Me.BtnSave.Text = "حفظ"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEdit.Enabled = False
        Me.BtnEdit.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Refresh4
        Me.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEdit.Location = New System.Drawing.Point(812, 13)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnEdit.Size = New System.Drawing.Size(193, 57)
        Me.BtnEdit.TabIndex = 107
        Me.BtnEdit.Text = "تعديل"
        Me.BtnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDelete.Enabled = False
        Me.BtnDelete.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Remove1
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.Location = New System.Drawing.Point(613, 13)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnDelete.Size = New System.Drawing.Size(193, 57)
        Me.BtnDelete.TabIndex = 108
        Me.BtnDelete.Text = "حذف"
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'btn_Print_Report
        '
        Me.btn_Print_Report.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btn_Print_Report.FlatAppearance.BorderSize = 0
        Me.btn_Print_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Print_Report.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Print_Report.ForeColor = System.Drawing.Color.White
        Me.btn_Print_Report.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Print1
        Me.btn_Print_Report.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Print_Report.Location = New System.Drawing.Point(20, 21)
        Me.btn_Print_Report.Name = "btn_Print_Report"
        Me.btn_Print_Report.Size = New System.Drawing.Size(161, 40)
        Me.btn_Print_Report.TabIndex = 6
        Me.btn_Print_Report.Text = "طباعة التقرير"
        Me.btn_Print_Report.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Print_Report.UseVisualStyleBackColor = False
        '
        'btn_UpdateStatus
        '
        Me.btn_UpdateStatus.BackColor = System.Drawing.Color.Red
        Me.btn_UpdateStatus.FlatAppearance.BorderSize = 0
        Me.btn_UpdateStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_UpdateStatus.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_UpdateStatus.ForeColor = System.Drawing.Color.White
        Me.btn_UpdateStatus.Location = New System.Drawing.Point(12, 21)
        Me.btn_UpdateStatus.Name = "btn_UpdateStatus"
        Me.btn_UpdateStatus.Size = New System.Drawing.Size(45, 40)
        Me.btn_UpdateStatus.TabIndex = 7
        Me.btn_UpdateStatus.Text = "إغلاق"
        Me.btn_UpdateStatus.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FlowLayoutPanel1.Controls.Add(Me.lblEmployeeName)
        Me.FlowLayoutPanel1.Controls.Add(Me.lblDept_Code)
        Me.FlowLayoutPanel1.Controls.Add(Me.lblPhoneExtension)
        Me.FlowLayoutPanel1.Controls.Add(Me.EmployeeName)
        Me.FlowLayoutPanel1.Controls.Add(Me.Dept_Code)
        Me.FlowLayoutPanel1.Controls.Add(Me.PhoneExtension)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 61)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1415, 103)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'lblEmployeeName
        '
        Me.lblEmployeeName.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.lblEmployeeName.ForeColor = System.Drawing.Color.White
        Me.lblEmployeeName.Location = New System.Drawing.Point(937, 0)
        Me.lblEmployeeName.Name = "lblEmployeeName"
        Me.lblEmployeeName.Size = New System.Drawing.Size(471, 49)
        Me.lblEmployeeName.TabIndex = 1
        Me.lblEmployeeName.Text = "اسم الموظف"
        Me.lblEmployeeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDept_Code
        '
        Me.lblDept_Code.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.lblDept_Code.ForeColor = System.Drawing.Color.White
        Me.lblDept_Code.Location = New System.Drawing.Point(476, 0)
        Me.lblDept_Code.Name = "lblDept_Code"
        Me.lblDept_Code.Size = New System.Drawing.Size(455, 49)
        Me.lblDept_Code.TabIndex = 2
        Me.lblDept_Code.Text = "القسم"
        Me.lblDept_Code.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPhoneExtension
        '
        Me.lblPhoneExtension.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.lblPhoneExtension.ForeColor = System.Drawing.Color.White
        Me.lblPhoneExtension.Location = New System.Drawing.Point(10, 0)
        Me.lblPhoneExtension.Name = "lblPhoneExtension"
        Me.lblPhoneExtension.Size = New System.Drawing.Size(460, 49)
        Me.lblPhoneExtension.TabIndex = 3
        Me.lblPhoneExtension.Text = "رقم الهاتف"
        Me.lblPhoneExtension.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EmployeeName
        '
        Me.EmployeeName.Location = New System.Drawing.Point(937, 52)
        Me.EmployeeName.Name = "EmployeeName"
        Me.EmployeeName.Size = New System.Drawing.Size(471, 39)
        Me.EmployeeName.TabIndex = 4
        '
        'Dept_Code
        '
        Me.Dept_Code.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Dept_Code.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Dept_Code.FormattingEnabled = True
        Me.Dept_Code.Location = New System.Drawing.Point(476, 52)
        Me.Dept_Code.Name = "Dept_Code"
        Me.Dept_Code.Size = New System.Drawing.Size(455, 40)
        Me.Dept_Code.TabIndex = 5
        '
        'PhoneExtension
        '
        Me.PhoneExtension.Location = New System.Drawing.Point(10, 52)
        Me.PhoneExtension.Name = "PhoneExtension"
        Me.PhoneExtension.Size = New System.Drawing.Size(460, 39)
        Me.PhoneExtension.TabIndex = 6
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dgv_InternalPhones)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 164)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1415, 456)
        Me.Panel3.TabIndex = 3
        '
        'dgv_InternalPhones
        '
        Me.dgv_InternalPhones.AllowUserToAddRows = False
        Me.dgv_InternalPhones.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgv_InternalPhones.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_InternalPhones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_InternalPhones.BackgroundColor = System.Drawing.Color.White
        Me.dgv_InternalPhones.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_InternalPhones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_InternalPhones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_InternalPhones.ColumnHeadersHeight = 40
        Me.dgv_InternalPhones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_InternalPhones.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_InternalPhones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_InternalPhones.EnableHeadersVisualStyles = False
        Me.dgv_InternalPhones.GridColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dgv_InternalPhones.Location = New System.Drawing.Point(0, 0)
        Me.dgv_InternalPhones.Name = "dgv_InternalPhones"
        Me.dgv_InternalPhones.ReadOnly = True
        Me.dgv_InternalPhones.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_InternalPhones.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_InternalPhones.RowHeadersVisible = False
        Me.dgv_InternalPhones.RowHeadersWidth = 51
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgv_InternalPhones.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_InternalPhones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_InternalPhones.Size = New System.Drawing.Size(1415, 456)
        Me.dgv_InternalPhones.TabIndex = 1
        '
        'InternalPhones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1415, 708)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "InternalPhones"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "التليفون الداخلى"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgv_InternalPhones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dgv_InternalPhones As DataGridView
    Friend WithEvents btn_Print_Report As Button
    Friend WithEvents btn_UpdateStatus As Button
    Friend WithEvents BtnNewAdd As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblEmployeeName As Label
    Friend WithEvents lblDept_Code As Label
    Friend WithEvents lblPhoneExtension As Label
    Friend WithEvents EmployeeName As TextBox
    Friend WithEvents Dept_Code As ComboBox
    Friend WithEvents PhoneExtension As TextBox
    Friend WithEvents ID As TextBox
    Friend WithEvents Txt_Search As TextBox
    Friend WithEvents Lbl_Search As Label
End Class
