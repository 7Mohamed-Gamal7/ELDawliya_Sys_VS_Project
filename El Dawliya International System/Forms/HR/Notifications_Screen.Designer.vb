<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Notifications_Screen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Notifications_Screen))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Combo_Notifications = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.Txt_Days = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.Lbl_Count = New System.Windows.Forms.ToolStripLabel()
        Me.Btn_Export_Excel = New System.Windows.Forms.ToolStripButton()
        Me.Btn_Print = New System.Windows.Forms.ToolStripButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgv_Notifications = New ADGV.AdvancedDataGridView()
        Me.Lbl_Notifications_Name = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgv_Notifications, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1174, 64)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Cairo", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1174, 64)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "شاشة تنبيهات"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ToolStrip1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 595)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1174, 78)
        Me.Panel2.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripLabel1, Me.Combo_Notifications, Me.ToolStripLabel2, Me.Txt_Days, Me.ToolStripLabel3, Me.Lbl_Count, Me.Btn_Export_Excel, Me.Btn_Print})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStrip1.Size = New System.Drawing.Size(1174, 78)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ToolStripButton1.Image = Global.El_Dawliya_International_System.My.Resources.Resources.notification_24px
        Me.ToolStripButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(105, 75)
        Me.ToolStripButton1.Text = "استعلام"
        Me.ToolStripButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Cairo", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(132, 75)
        Me.ToolStripLabel1.Text = "اختر التنبيه الذى تريده"
        '
        'Combo_Notifications
        '
        Me.Combo_Notifications.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_Notifications.Items.AddRange(New Object() {"انتهاء الشهادة الصحية", "انتهاء عقد العمل", "انتهاء بطاقة الرقم القومى", "انتهاء فترة الاختبار"})
        Me.Combo_Notifications.Name = "Combo_Notifications"
        Me.Combo_Notifications.Size = New System.Drawing.Size(200, 78)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(171, 75)
        Me.ToolStripLabel2.Text = "اكتب عدد الايام التى تريدها"
        '
        'Txt_Days
        '
        Me.Txt_Days.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Days.Name = "Txt_Days"
        Me.Txt_Days.Size = New System.Drawing.Size(100, 78)
        Me.Txt_Days.Text = "30"
        Me.Txt_Days.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(97, 75)
        Me.ToolStripLabel3.Text = "عدد السجلات"
        '
        'Lbl_Count
        '
        Me.Lbl_Count.Name = "Lbl_Count"
        Me.Lbl_Count.Size = New System.Drawing.Size(12, 75)
        Me.Lbl_Count.Text = "."
        '
        'Btn_Export_Excel
        '
        Me.Btn_Export_Excel.AutoSize = False
        Me.Btn_Export_Excel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Btn_Export_Excel.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Microsoft_Excel_48px
        Me.Btn_Export_Excel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Btn_Export_Excel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_Export_Excel.Name = "Btn_Export_Excel"
        Me.Btn_Export_Excel.Size = New System.Drawing.Size(75, 75)
        Me.Btn_Export_Excel.Text = "ToolStripButton1"
        Me.Btn_Export_Excel.ToolTipText = "تصدير إلى الاكسل"
        '
        'Btn_Print
        '
        Me.Btn_Print.AutoSize = False
        Me.Btn_Print.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Btn_Print.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Print2
        Me.Btn_Print.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Btn_Print.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_Print.Name = "Btn_Print"
        Me.Btn_Print.Size = New System.Drawing.Size(75, 75)
        Me.Btn_Print.Text = "ToolStripButton1"
        Me.Btn_Print.ToolTipText = "طباعة"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dgv_Notifications)
        Me.Panel3.Controls.Add(Me.Lbl_Notifications_Name)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 64)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1174, 531)
        Me.Panel3.TabIndex = 2
        '
        'dgv_Notifications
        '
        Me.dgv_Notifications.AllowUserToAddRows = False
        Me.dgv_Notifications.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_Notifications.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Notifications.AutoGenerateContextFilters = True
        Me.dgv_Notifications.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(237, Byte), Integer))
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Notifications.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_Notifications.ColumnHeadersHeight = 29
        Me.dgv_Notifications.DateWithTime = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Notifications.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_Notifications.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Notifications.EnableHeadersVisualStyles = False
        Me.dgv_Notifications.Location = New System.Drawing.Point(0, 40)
        Me.dgv_Notifications.Name = "dgv_Notifications"
        Me.dgv_Notifications.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Notifications.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_Notifications.RowHeadersVisible = False
        Me.dgv_Notifications.RowHeadersWidth = 60
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_Notifications.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_Notifications.RowTemplate.Height = 26
        Me.dgv_Notifications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgv_Notifications.Size = New System.Drawing.Size(1174, 491)
        Me.dgv_Notifications.TabIndex = 118
        Me.dgv_Notifications.TimeFilter = False
        '
        'Lbl_Notifications_Name
        '
        Me.Lbl_Notifications_Name.BackColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.Lbl_Notifications_Name.Dock = System.Windows.Forms.DockStyle.Top
        Me.Lbl_Notifications_Name.Font = New System.Drawing.Font("Cairo", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Notifications_Name.Location = New System.Drawing.Point(0, 0)
        Me.Lbl_Notifications_Name.Name = "Lbl_Notifications_Name"
        Me.Lbl_Notifications_Name.Size = New System.Drawing.Size(1174, 40)
        Me.Lbl_Notifications_Name.TabIndex = 1
        Me.Lbl_Notifications_Name.Text = "."
        Me.Lbl_Notifications_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Notifications_Screen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1174, 673)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "Notifications_Screen"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "شاشة التنبيهات"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgv_Notifications, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Lbl_Notifications_Name As Label
    Friend WithEvents dgv_Notifications As ADGV.AdvancedDataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents Combo_Notifications As ToolStripComboBox
    Friend WithEvents Btn_Print As ToolStripButton
    Friend WithEvents Btn_Export_Excel As ToolStripButton
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents Txt_Days As ToolStripTextBox
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents Lbl_Count As ToolStripLabel
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents BindingSource1 As BindingSource
End Class
