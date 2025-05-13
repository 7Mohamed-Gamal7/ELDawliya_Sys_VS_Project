<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Report_Inquiry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Report_Inquiry))
        Me.Lbl_MachineID = New System.Windows.Forms.Label()
        Me.Lbl_DepartmentID = New System.Windows.Forms.Label()
        Me.Lbl_ReportDate = New System.Windows.Forms.Label()
        Me.MachineID = New System.Windows.Forms.ComboBox()
        Me.Dept_Code = New System.Windows.Forms.ComboBox()
        Me.ReportDate = New System.Windows.Forms.DateTimePicker()
        Me.dgv_Report_Inquiry = New System.Windows.Forms.DataGridView()
        Me.Btn_Fetch_Data = New System.Windows.Forms.Button()
        Me.btn_Print = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        CType(Me.dgv_Report_Inquiry, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_MachineID
        '
        Me.Lbl_MachineID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_MachineID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_MachineID.Location = New System.Drawing.Point(1053, 0)
        Me.Lbl_MachineID.Name = "Lbl_MachineID"
        Me.Lbl_MachineID.Size = New System.Drawing.Size(394, 35)
        Me.Lbl_MachineID.TabIndex = 6
        Me.Lbl_MachineID.Text = "الماكينة"
        Me.Lbl_MachineID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_DepartmentID
        '
        Me.Lbl_DepartmentID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_DepartmentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_DepartmentID.Location = New System.Drawing.Point(463, 0)
        Me.Lbl_DepartmentID.Name = "Lbl_DepartmentID"
        Me.Lbl_DepartmentID.Size = New System.Drawing.Size(584, 35)
        Me.Lbl_DepartmentID.TabIndex = 8
        Me.Lbl_DepartmentID.Text = "القسم"
        Me.Lbl_DepartmentID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_ReportDate
        '
        Me.Lbl_ReportDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_ReportDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_ReportDate.Location = New System.Drawing.Point(20, 0)
        Me.Lbl_ReportDate.Name = "Lbl_ReportDate"
        Me.Lbl_ReportDate.Size = New System.Drawing.Size(437, 35)
        Me.Lbl_ReportDate.TabIndex = 10
        Me.Lbl_ReportDate.Text = "التاريخ"
        Me.Lbl_ReportDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MachineID
        '
        Me.MachineID.FormattingEnabled = True
        Me.MachineID.Location = New System.Drawing.Point(1053, 38)
        Me.MachineID.Name = "MachineID"
        Me.MachineID.Size = New System.Drawing.Size(394, 40)
        Me.MachineID.TabIndex = 7
        '
        'Dept_Code
        '
        Me.Dept_Code.FormattingEnabled = True
        Me.Dept_Code.Location = New System.Drawing.Point(463, 38)
        Me.Dept_Code.Name = "Dept_Code"
        Me.Dept_Code.Size = New System.Drawing.Size(584, 40)
        Me.Dept_Code.TabIndex = 9
        '
        'ReportDate
        '
        Me.ReportDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ReportDate.Location = New System.Drawing.Point(20, 38)
        Me.ReportDate.Name = "ReportDate"
        Me.ReportDate.Size = New System.Drawing.Size(437, 39)
        Me.ReportDate.TabIndex = 11
        '
        'dgv_Report_Inquiry
        '
        Me.dgv_Report_Inquiry.AllowUserToAddRows = False
        Me.dgv_Report_Inquiry.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgv_Report_Inquiry.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Report_Inquiry.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_Report_Inquiry.BackgroundColor = System.Drawing.Color.White
        Me.dgv_Report_Inquiry.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_Report_Inquiry.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Report_Inquiry.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_Report_Inquiry.ColumnHeadersHeight = 40
        Me.dgv_Report_Inquiry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Report_Inquiry.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_Report_Inquiry.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Report_Inquiry.EnableHeadersVisualStyles = False
        Me.dgv_Report_Inquiry.GridColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dgv_Report_Inquiry.Location = New System.Drawing.Point(0, 0)
        Me.dgv_Report_Inquiry.Name = "dgv_Report_Inquiry"
        Me.dgv_Report_Inquiry.ReadOnly = True
        Me.dgv_Report_Inquiry.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Report_Inquiry.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_Report_Inquiry.RowHeadersVisible = False
        Me.dgv_Report_Inquiry.RowHeadersWidth = 51
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgv_Report_Inquiry.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_Report_Inquiry.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Report_Inquiry.Size = New System.Drawing.Size(1446, 494)
        Me.dgv_Report_Inquiry.TabIndex = 12
        '
        'Btn_Fetch_Data
        '
        Me.Btn_Fetch_Data.Font = New System.Drawing.Font("Cairo SemiBold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Fetch_Data.Image = Global.El_Dawliya_International_System.My.Resources.Resources._1469967782_icon_111_search
        Me.Btn_Fetch_Data.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Fetch_Data.Location = New System.Drawing.Point(1295, 12)
        Me.Btn_Fetch_Data.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Btn_Fetch_Data.Name = "Btn_Fetch_Data"
        Me.Btn_Fetch_Data.Size = New System.Drawing.Size(143, 49)
        Me.Btn_Fetch_Data.TabIndex = 110
        Me.Btn_Fetch_Data.Text = "استعلام"
        Me.Btn_Fetch_Data.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Fetch_Data.UseVisualStyleBackColor = True
        '
        'btn_Print
        '
        Me.btn_Print.Font = New System.Drawing.Font("Cairo SemiBold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Print.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Print
        Me.btn_Print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Print.Location = New System.Drawing.Point(14, 12)
        Me.btn_Print.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_Print.Name = "btn_Print"
        Me.btn_Print.Size = New System.Drawing.Size(209, 49)
        Me.btn_Print.TabIndex = 111
        Me.btn_Print.Text = "طباعة التقرير"
        Me.btn_Print.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Print.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1450, 62)
        Me.Panel1.TabIndex = 112
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btn_Print)
        Me.Panel2.Controls.Add(Me.Btn_Fetch_Data)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 643)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1450, 75)
        Me.Panel2.TabIndex = 113
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1450, 62)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "شاشة الاستعلام عن تقارير "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Lbl_MachineID)
        Me.FlowLayoutPanel1.Controls.Add(Me.Lbl_DepartmentID)
        Me.FlowLayoutPanel1.Controls.Add(Me.Lbl_ReportDate)
        Me.FlowLayoutPanel1.Controls.Add(Me.MachineID)
        Me.FlowLayoutPanel1.Controls.Add(Me.Dept_Code)
        Me.FlowLayoutPanel1.Controls.Add(Me.ReportDate)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 62)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1450, 83)
        Me.FlowLayoutPanel1.TabIndex = 114
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.dgv_Report_Inquiry)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 145)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1450, 498)
        Me.Panel3.TabIndex = 115
        '
        'Report_Inquiry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1450, 718)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "Report_Inquiry"
        Me.RightToLeftLayout = True
        Me.Text = "استعلام عن تقرير"
        CType(Me.dgv_Report_Inquiry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Lbl_MachineID As Label
    Friend WithEvents Lbl_DepartmentID As Label
    Friend WithEvents Lbl_ReportDate As Label
    Friend WithEvents MachineID As ComboBox
    Friend WithEvents Dept_Code As ComboBox
    Friend WithEvents ReportDate As DateTimePicker
    Friend WithEvents dgv_Report_Inquiry As DataGridView
    Friend WithEvents Btn_Fetch_Data As Button
    Friend WithEvents btn_Print As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel3 As Panel
End Class
