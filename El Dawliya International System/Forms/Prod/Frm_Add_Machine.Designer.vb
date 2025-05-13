<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Add_Machine
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MachineID = New System.Windows.Forms.TextBox()
        Me.Btn_Close = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Btn_Add = New System.Windows.Forms.Button()
        Me.Btn_Edit = New System.Windows.Forms.Button()
        Me.Btn_Delete = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MachineName = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgv_Machine = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgv_Machine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.MachineID)
        Me.Panel1.Controls.Add(Me.Btn_Close)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(573, 49)
        Me.Panel1.TabIndex = 0
        '
        'MachineID
        '
        Me.MachineID.Location = New System.Drawing.Point(12, 4)
        Me.MachineID.Name = "MachineID"
        Me.MachineID.Size = New System.Drawing.Size(59, 39)
        Me.MachineID.TabIndex = 104
        Me.MachineID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.MachineID.Visible = False
        '
        'Btn_Close
        '
        Me.Btn_Close.Dock = System.Windows.Forms.DockStyle.Right
        Me.Btn_Close.Font = New System.Drawing.Font("Cairo SemiBold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Close.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Cancel1
        Me.Btn_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Close.Location = New System.Drawing.Point(511, 0)
        Me.Btn_Close.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Size = New System.Drawing.Size(62, 49)
        Me.Btn_Close.TabIndex = 103
        Me.Btn_Close.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Close.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(573, 49)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "شاشة إضافة ماكينة جديدة"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Btn_Add)
        Me.Panel2.Controls.Add(Me.Btn_Edit)
        Me.Panel2.Controls.Add(Me.Btn_Delete)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 341)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(573, 74)
        Me.Panel2.TabIndex = 1
        '
        'Btn_Add
        '
        Me.Btn_Add.Font = New System.Drawing.Font("Cairo SemiBold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Add.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Add1
        Me.Btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Add.Location = New System.Drawing.Point(450, 11)
        Me.Btn_Add.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Btn_Add.Name = "Btn_Add"
        Me.Btn_Add.Size = New System.Drawing.Size(110, 49)
        Me.Btn_Add.TabIndex = 104
        Me.Btn_Add.Text = "حفظ"
        Me.Btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Add.UseVisualStyleBackColor = True
        '
        'Btn_Edit
        '
        Me.Btn_Edit.Font = New System.Drawing.Font("Cairo SemiBold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Edit.Image = Global.El_Dawliya_International_System.My.Resources.Resources.edit_24px
        Me.Btn_Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Edit.Location = New System.Drawing.Point(229, 11)
        Me.Btn_Edit.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Btn_Edit.Name = "Btn_Edit"
        Me.Btn_Edit.Size = New System.Drawing.Size(122, 49)
        Me.Btn_Edit.TabIndex = 104
        Me.Btn_Edit.Text = "تعديل"
        Me.Btn_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Edit.UseVisualStyleBackColor = True
        '
        'Btn_Delete
        '
        Me.Btn_Delete.Font = New System.Drawing.Font("Cairo SemiBold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Delete.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Remove1
        Me.Btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Delete.Location = New System.Drawing.Point(12, 11)
        Me.Btn_Delete.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Btn_Delete.Name = "Btn_Delete"
        Me.Btn_Delete.Size = New System.Drawing.Size(118, 49)
        Me.Btn_Delete.TabIndex = 104
        Me.Btn_Delete.Text = "حذف"
        Me.Btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Delete.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FlowLayoutPanel1.Controls.Add(Me.Label2)
        Me.FlowLayoutPanel1.Controls.Add(Me.MachineName)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 49)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(573, 78)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(-2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(568, 30)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "اسم الماكينة"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MachineName
        '
        Me.MachineName.Location = New System.Drawing.Point(-2, 33)
        Me.MachineName.Name = "MachineName"
        Me.MachineName.Size = New System.Drawing.Size(568, 39)
        Me.MachineName.TabIndex = 1
        Me.MachineName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel3.Controls.Add(Me.dgv_Machine)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 127)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(573, 214)
        Me.Panel3.TabIndex = 3
        '
        'dgv_Machine
        '
        Me.dgv_Machine.AllowUserToAddRows = False
        Me.dgv_Machine.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgv_Machine.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Machine.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_Machine.BackgroundColor = System.Drawing.Color.White
        Me.dgv_Machine.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_Machine.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Machine.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_Machine.ColumnHeadersHeight = 40
        Me.dgv_Machine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Machine.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_Machine.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Machine.EnableHeadersVisualStyles = False
        Me.dgv_Machine.GridColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dgv_Machine.Location = New System.Drawing.Point(0, 0)
        Me.dgv_Machine.Name = "dgv_Machine"
        Me.dgv_Machine.ReadOnly = True
        Me.dgv_Machine.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Machine.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_Machine.RowHeadersVisible = False
        Me.dgv_Machine.RowHeadersWidth = 51
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgv_Machine.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_Machine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Machine.Size = New System.Drawing.Size(573, 214)
        Me.dgv_Machine.TabIndex = 1
        '
        'Frm_Add_Machine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 415)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "Frm_Add_Machine"
        Me.RightToLeftLayout = True
        Me.Text = "Frm_Add_Maquina"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgv_Machine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents MachineName As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Btn_Close As Button
    Friend WithEvents Btn_Add As Button
    Friend WithEvents Btn_Edit As Button
    Friend WithEvents Btn_Delete As Button
    Friend WithEvents dgv_Machine As DataGridView
    Friend WithEvents MachineID As TextBox
End Class
