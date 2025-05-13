<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserTasks
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserTasks))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgv_UserTasks = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbo_SearchStatus = New System.Windows.Forms.ComboBox()
        Me.btn_Search = New System.Windows.Forms.Button()
        Me.lbl_SearchStatus = New System.Windows.Forms.Label()
        Me.lbl_TaskCount = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Refresh = New System.Windows.Forms.Button()
        Me.btn_UpdateStatus = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2.SuspendLayout()
        CType(Me.dgv_UserTasks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgv_UserTasks)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 70)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(20)
        Me.Panel2.Size = New System.Drawing.Size(1438, 641)
        Me.Panel2.TabIndex = 1
        '
        'dgv_UserTasks
        '
        Me.dgv_UserTasks.AllowUserToAddRows = False
        Me.dgv_UserTasks.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgv_UserTasks.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_UserTasks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_UserTasks.BackgroundColor = System.Drawing.Color.White
        Me.dgv_UserTasks.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_UserTasks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_UserTasks.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_UserTasks.ColumnHeadersHeight = 40
        Me.dgv_UserTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_UserTasks.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_UserTasks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_UserTasks.EnableHeadersVisualStyles = False
        Me.dgv_UserTasks.GridColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dgv_UserTasks.Location = New System.Drawing.Point(20, 20)
        Me.dgv_UserTasks.Name = "dgv_UserTasks"
        Me.dgv_UserTasks.ReadOnly = True
        Me.dgv_UserTasks.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_UserTasks.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_UserTasks.RowHeadersVisible = False
        Me.dgv_UserTasks.RowHeadersWidth = 51
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgv_UserTasks.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_UserTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_UserTasks.Size = New System.Drawing.Size(1398, 601)
        Me.dgv_UserTasks.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Panel1.Controls.Add(Me.cbo_SearchStatus)
        Me.Panel1.Controls.Add(Me.btn_Search)
        Me.Panel1.Controls.Add(Me.lbl_SearchStatus)
        Me.Panel1.Controls.Add(Me.lbl_TaskCount)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btn_Refresh)
        Me.Panel1.Controls.Add(Me.btn_UpdateStatus)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1438, 70)
        Me.Panel1.TabIndex = 0
        '
        'cbo_SearchStatus
        '
        Me.cbo_SearchStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbo_SearchStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_SearchStatus.Font = New System.Drawing.Font("Cairo ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_SearchStatus.FormattingEnabled = True
        Me.cbo_SearchStatus.Location = New System.Drawing.Point(570, 13)
        Me.cbo_SearchStatus.Name = "cbo_SearchStatus"
        Me.cbo_SearchStatus.Size = New System.Drawing.Size(230, 45)
        Me.cbo_SearchStatus.TabIndex = 0
        '
        'btn_Search
        '
        Me.btn_Search.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Search.Image = Global.El_Dawliya_International_System.My.Resources.Resources.view_24px
        Me.btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Search.Location = New System.Drawing.Point(276, 15)
        Me.btn_Search.Name = "btn_Search"
        Me.btn_Search.Size = New System.Drawing.Size(120, 40)
        Me.btn_Search.TabIndex = 1
        Me.btn_Search.Text = "بحث"
        Me.btn_Search.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Search.UseVisualStyleBackColor = True
        '
        'lbl_SearchStatus
        '
        Me.lbl_SearchStatus.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_SearchStatus.Location = New System.Drawing.Point(800, 0)
        Me.lbl_SearchStatus.Name = "lbl_SearchStatus"
        Me.lbl_SearchStatus.Size = New System.Drawing.Size(154, 70)
        Me.lbl_SearchStatus.TabIndex = 2
        Me.lbl_SearchStatus.Text = "حالة المهمة"
        Me.lbl_SearchStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_TaskCount
        '
        Me.lbl_TaskCount.Dock = System.Windows.Forms.DockStyle.Right
        Me.lbl_TaskCount.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_TaskCount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_TaskCount.Location = New System.Drawing.Point(954, 0)
        Me.lbl_TaskCount.Name = "lbl_TaskCount"
        Me.lbl_TaskCount.Size = New System.Drawing.Size(242, 70)
        Me.lbl_TaskCount.TabIndex = 2
        Me.lbl_TaskCount.Text = "إجمالي المهام: 0"
        Me.lbl_TaskCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.Font = New System.Drawing.Font("Cairo", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(1196, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 70)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "المهام المسندة إليك"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_Refresh
        '
        Me.btn_Refresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btn_Refresh.FlatAppearance.BorderSize = 0
        Me.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Refresh.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_Refresh.ForeColor = System.Drawing.Color.White
        Me.btn_Refresh.Location = New System.Drawing.Point(150, 15)
        Me.btn_Refresh.Name = "btn_Refresh"
        Me.btn_Refresh.Size = New System.Drawing.Size(120, 40)
        Me.btn_Refresh.TabIndex = 1
        Me.btn_Refresh.Text = "تحديث"
        Me.btn_Refresh.UseVisualStyleBackColor = False
        '
        'btn_UpdateStatus
        '
        Me.btn_UpdateStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btn_UpdateStatus.FlatAppearance.BorderSize = 0
        Me.btn_UpdateStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_UpdateStatus.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btn_UpdateStatus.ForeColor = System.Drawing.Color.White
        Me.btn_UpdateStatus.Location = New System.Drawing.Point(20, 15)
        Me.btn_UpdateStatus.Name = "btn_UpdateStatus"
        Me.btn_UpdateStatus.Size = New System.Drawing.Size(120, 40)
        Me.btn_UpdateStatus.TabIndex = 0
        Me.btn_UpdateStatus.Text = "تحديث الحالة"
        Me.btn_UpdateStatus.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'UserTasks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1438, 711)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "UserTasks"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "المهام المسندة إليك"
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgv_UserTasks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dgv_UserTasks As DataGridView
    Friend WithEvents btn_UpdateStatus As Button
    Friend WithEvents btn_Refresh As Button
    Friend WithEvents lbl_TaskCount As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbo_SearchStatus As ComboBox
    Friend WithEvents btn_Search As Button
    Friend WithEvents lbl_SearchStatus As Label
    Friend WithEvents Timer1 As Timer
End Class
