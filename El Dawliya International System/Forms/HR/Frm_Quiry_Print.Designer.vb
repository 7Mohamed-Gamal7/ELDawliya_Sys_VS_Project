<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Quiry_Print
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Check_Hiring = New System.Windows.Forms.CheckBox()
        Me.Check_Resignations = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Btn_Print = New System.Windows.Forms.ToolStripButton()
        Me.Cmb_Report = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ComboSearch1 = New System.Windows.Forms.ToolStripComboBox()
        Me.Txt_Search1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Lbl_Count = New System.Windows.Forms.ToolStripLabel()
        Me.dgv_Tbl_Employee = New ADGV.AdvancedDataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgv_Tbl_Employee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Check_Hiring)
        Me.Panel1.Controls.Add(Me.Check_Resignations)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1423, 47)
        Me.Panel1.TabIndex = 0
        '
        'Check_Hiring
        '
        Me.Check_Hiring.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Check_Hiring.AutoSize = True
        Me.Check_Hiring.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Check_Hiring.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check_Hiring.Location = New System.Drawing.Point(1283, 4)
        Me.Check_Hiring.Name = "Check_Hiring"
        Me.Check_Hiring.Size = New System.Drawing.Size(135, 36)
        Me.Check_Hiring.TabIndex = 22
        Me.Check_Hiring.Text = "تقارير التعيين"
        Me.Check_Hiring.UseVisualStyleBackColor = False
        '
        'Check_Resignations
        '
        Me.Check_Resignations.AutoSize = True
        Me.Check_Resignations.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Check_Resignations.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check_Resignations.Location = New System.Drawing.Point(5, 4)
        Me.Check_Resignations.Name = "Check_Resignations"
        Me.Check_Resignations.Size = New System.Drawing.Size(153, 36)
        Me.Check_Resignations.TabIndex = 22
        Me.Check_Resignations.Text = "تقارير الاستقالة"
        Me.Check_Resignations.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Cairo", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1423, 47)
        Me.Label1.TabIndex = 124
        Me.Label1.Text = "شاشة الاستعلام وطباعة التقارير"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ToolStrip1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 610)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1423, 63)
        Me.Panel2.TabIndex = 50
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Btn_Print, Me.Cmb_Report, Me.ToolStripSeparator1, Me.ComboSearch1, Me.Txt_Search1, Me.ToolStripSeparator2, Me.ToolStripLabel1, Me.Lbl_Count})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStrip1.Size = New System.Drawing.Size(1423, 63)
        Me.ToolStrip1.TabIndex = 21
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Btn_Print
        '
        Me.Btn_Print.AutoSize = False
        Me.Btn_Print.BackColor = System.Drawing.Color.DodgerBlue
        Me.Btn_Print.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Print.ForeColor = System.Drawing.Color.Black
        Me.Btn_Print.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Print
        Me.Btn_Print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Print.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Btn_Print.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_Print.Name = "Btn_Print"
        Me.Btn_Print.Size = New System.Drawing.Size(110, 84)
        Me.Btn_Print.Text = "طباعة"
        Me.Btn_Print.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Print.ToolTipText = "طباعة تقرير"
        '
        'Cmb_Report
        '
        Me.Cmb_Report.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Report.Items.AddRange(New Object() {"ورق الورادى"})
        Me.Cmb_Report.Name = "Cmb_Report"
        Me.Cmb_Report.Size = New System.Drawing.Size(200, 63)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 63)
        '
        'ComboSearch1
        '
        Me.ComboSearch1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboSearch1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboSearch1.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboSearch1.Items.AddRange(New Object() {"اسم الموظف", "رقم التليفون", "رقم البطاقة الشخصية", "الجنسية", "تاريخ التعيين", "القسم", "الوظيفة", "النوع", "الحالة التأمينة", "البطاقة الصحية", "حالة الموظف", "السيارة", "نقطة تجمع السيارة", "الوردية للاسبوع الحالى", "الوردية للاسبوع القادم", "تشغيل الجمعة", "ورق الورادى"})
        Me.ComboSearch1.Name = "ComboSearch1"
        Me.ComboSearch1.Size = New System.Drawing.Size(150, 63)
        Me.ComboSearch1.Text = "كود الموظف"
        '
        'Txt_Search1
        '
        Me.Txt_Search1.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Search1.Name = "Txt_Search1"
        Me.Txt_Search1.Size = New System.Drawing.Size(200, 63)
        Me.Txt_Search1.ToolTipText = "اكتب ما تريد البحث عنه هنا"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 63)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(108, 60)
        Me.ToolStripLabel1.Text = "عدد السجلات"
        '
        'Lbl_Count
        '
        Me.Lbl_Count.Font = New System.Drawing.Font("Cairo", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Count.ForeColor = System.Drawing.Color.White
        Me.Lbl_Count.Name = "Lbl_Count"
        Me.Lbl_Count.Size = New System.Drawing.Size(22, 60)
        Me.Lbl_Count.Text = "."
        '
        'dgv_Tbl_Employee
        '
        Me.dgv_Tbl_Employee.AllowUserToAddRows = False
        Me.dgv_Tbl_Employee.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_Tbl_Employee.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Tbl_Employee.AutoGenerateContextFilters = True
        Me.dgv_Tbl_Employee.BackgroundColor = System.Drawing.Color.White
        Me.dgv_Tbl_Employee.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_Tbl_Employee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Tbl_Employee.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_Tbl_Employee.ColumnHeadersHeight = 40
        Me.dgv_Tbl_Employee.DateWithTime = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Tbl_Employee.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_Tbl_Employee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Tbl_Employee.EnableHeadersVisualStyles = False
        Me.dgv_Tbl_Employee.GridColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dgv_Tbl_Employee.Location = New System.Drawing.Point(0, 0)
        Me.dgv_Tbl_Employee.Name = "dgv_Tbl_Employee"
        Me.dgv_Tbl_Employee.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Tbl_Employee.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_Tbl_Employee.RowHeadersVisible = False
        Me.dgv_Tbl_Employee.RowHeadersWidth = 60
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_Tbl_Employee.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_Tbl_Employee.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgv_Tbl_Employee.RowTemplate.Height = 26
        Me.dgv_Tbl_Employee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Tbl_Employee.Size = New System.Drawing.Size(1423, 563)
        Me.dgv_Tbl_Employee.TabIndex = 118
        Me.dgv_Tbl_Employee.TimeFilter = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dgv_Tbl_Employee)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 47)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1423, 563)
        Me.Panel3.TabIndex = 51
        '
        'Frm_Quiry_Print
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1423, 673)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "Frm_Quiry_Print"
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "استعلام وطباعة"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgv_Tbl_Employee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dgv_Tbl_Employee As ADGV.AdvancedDataGridView
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Btn_Print As ToolStripButton
    Friend WithEvents Cmb_Report As ToolStripComboBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents Lbl_Count As ToolStripLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboSearch1 As ToolStripComboBox
    Friend WithEvents Txt_Search1 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents Check_Resignations As CheckBox
    Friend WithEvents Check_Hiring As CheckBox
End Class
