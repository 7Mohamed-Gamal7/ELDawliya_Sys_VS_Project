<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Last_used_item
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_TaskCount = New System.Windows.Forms.Label()
        Me.btn_Print_Report = New System.Windows.Forms.Button()
        Me.btn_UpdateStatus = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgv_Last_used_item = New ADGV.AdvancedDataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgv_Last_used_item, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lbl_TaskCount)
        Me.Panel1.Controls.Add(Me.btn_Print_Report)
        Me.Panel1.Controls.Add(Me.btn_UpdateStatus)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 662)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1438, 70)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Cairo", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(1271, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "عدد الاصناف "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_TaskCount
        '
        Me.lbl_TaskCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_TaskCount.Font = New System.Drawing.Font("Cairo", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TaskCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_TaskCount.Location = New System.Drawing.Point(1178, 15)
        Me.lbl_TaskCount.Name = "lbl_TaskCount"
        Me.lbl_TaskCount.Size = New System.Drawing.Size(87, 37)
        Me.lbl_TaskCount.TabIndex = 1
        Me.lbl_TaskCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.btn_Print_Report.Location = New System.Drawing.Point(150, 15)
        Me.btn_Print_Report.Name = "btn_Print_Report"
        Me.btn_Print_Report.Size = New System.Drawing.Size(161, 40)
        Me.btn_Print_Report.TabIndex = 5
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
        Me.btn_UpdateStatus.Location = New System.Drawing.Point(20, 15)
        Me.btn_UpdateStatus.Name = "btn_UpdateStatus"
        Me.btn_UpdateStatus.Size = New System.Drawing.Size(120, 40)
        Me.btn_UpdateStatus.TabIndex = 6
        Me.btn_UpdateStatus.Text = "إغلاق"
        Me.btn_UpdateStatus.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgv_Last_used_item)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(20)
        Me.Panel2.Size = New System.Drawing.Size(1438, 732)
        Me.Panel2.TabIndex = 3
        '
        'dgv_Last_used_item
        '
        Me.dgv_Last_used_item.AllowUserToAddRows = False
        Me.dgv_Last_used_item.AllowUserToDeleteRows = False
        Me.dgv_Last_used_item.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_Last_used_item.AutoGenerateContextFilters = True
        Me.dgv_Last_used_item.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Last_used_item.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_Last_used_item.BackgroundColor = System.Drawing.Color.White
        Me.dgv_Last_used_item.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_Last_used_item.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Last_used_item.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Last_used_item.ColumnHeadersHeight = 40
        Me.dgv_Last_used_item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgv_Last_used_item.DateWithTime = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Last_used_item.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_Last_used_item.EnableHeadersVisualStyles = False
        Me.dgv_Last_used_item.GridColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dgv_Last_used_item.Location = New System.Drawing.Point(12, 60)
        Me.dgv_Last_used_item.Name = "dgv_Last_used_item"
        Me.dgv_Last_used_item.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Last_used_item.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_Last_used_item.RowHeadersVisible = False
        Me.dgv_Last_used_item.RowHeadersWidth = 51
        Me.dgv_Last_used_item.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgv_Last_used_item.RowTemplate.Height = 26
        Me.dgv_Last_used_item.Size = New System.Drawing.Size(1426, 596)
        Me.dgv_Last_used_item.TabIndex = 4
        Me.dgv_Last_used_item.TimeFilter = False
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Cairo", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1398, 37)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "شاشة البحث عن الاصناف التى لم يتم اى عمليات عليها منذ 3 اشهر "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Frm_Last_used_item
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1438, 732)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "Frm_Last_used_item"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgv_Last_used_item, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_TaskCount As Label
    Friend WithEvents btn_Print_Report As Button
    Friend WithEvents btn_UpdateStatus As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents dgv_Last_used_item As ADGV.AdvancedDataGridView
    Friend WithEvents BindingSource1 As BindingSource
End Class
