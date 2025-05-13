<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Shift_For_Machine
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
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ShiftID = New System.Windows.Forms.TextBox()
        Me.Lbl_MaquinaID = New System.Windows.Forms.Label()
        Me.lbl_ShiftType = New System.Windows.Forms.Label()
        Me.ShiftType = New System.Windows.Forms.TextBox()
        Me.lbl_ShiftStartTime = New System.Windows.Forms.Label()
        Me.ShiftStartTime = New System.Windows.Forms.DateTimePicker()
        Me.lbl_ShiftEndTime = New System.Windows.Forms.Label()
        Me.ShiftEndTime = New System.Windows.Forms.DateTimePicker()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.MaquinaID = New System.Windows.Forms.ComboBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dgv_Shift = New System.Windows.Forms.DataGridView()
        Me.Btn_Add = New System.Windows.Forms.Button()
        Me.Btn_Edit = New System.Windows.Forms.Button()
        Me.Btn_Delete = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgv_Shift, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ShiftID)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1029, 57)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Btn_Add)
        Me.Panel2.Controls.Add(Me.Btn_Edit)
        Me.Panel2.Controls.Add(Me.Btn_Delete)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 602)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1029, 78)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 57)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1029, 545)
        Me.Panel3.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1029, 57)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "شاشة إضافة وردية جديدة"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ShiftID
        '
        Me.ShiftID.Location = New System.Drawing.Point(926, 3)
        Me.ShiftID.Name = "ShiftID"
        Me.ShiftID.Size = New System.Drawing.Size(100, 39)
        Me.ShiftID.TabIndex = 1
        Me.ShiftID.Visible = False
        '
        'Lbl_MaquinaID
        '
        Me.Lbl_MaquinaID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_MaquinaID.Location = New System.Drawing.Point(777, 0)
        Me.Lbl_MaquinaID.Name = "Lbl_MaquinaID"
        Me.Lbl_MaquinaID.Size = New System.Drawing.Size(241, 47)
        Me.Lbl_MaquinaID.TabIndex = 0
        Me.Lbl_MaquinaID.Text = "اسم الماكينة"
        Me.Lbl_MaquinaID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_ShiftType
        '
        Me.lbl_ShiftType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_ShiftType.Location = New System.Drawing.Point(441, 0)
        Me.lbl_ShiftType.Name = "lbl_ShiftType"
        Me.lbl_ShiftType.Size = New System.Drawing.Size(330, 47)
        Me.lbl_ShiftType.TabIndex = 0
        Me.lbl_ShiftType.Text = "اسم الوردية"
        Me.lbl_ShiftType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ShiftType
        '
        Me.ShiftType.Location = New System.Drawing.Point(441, 50)
        Me.ShiftType.Name = "ShiftType"
        Me.ShiftType.Size = New System.Drawing.Size(330, 39)
        Me.ShiftType.TabIndex = 2
        Me.ShiftType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_ShiftStartTime
        '
        Me.lbl_ShiftStartTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_ShiftStartTime.Location = New System.Drawing.Point(204, 0)
        Me.lbl_ShiftStartTime.Name = "lbl_ShiftStartTime"
        Me.lbl_ShiftStartTime.Size = New System.Drawing.Size(231, 47)
        Me.lbl_ShiftStartTime.TabIndex = 0
        Me.lbl_ShiftStartTime.Text = "وقت بداية الوردية"
        Me.lbl_ShiftStartTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ShiftStartTime
        '
        Me.ShiftStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.ShiftStartTime.Location = New System.Drawing.Point(204, 50)
        Me.ShiftStartTime.Name = "ShiftStartTime"
        Me.ShiftStartTime.Size = New System.Drawing.Size(231, 39)
        Me.ShiftStartTime.TabIndex = 3
        '
        'lbl_ShiftEndTime
        '
        Me.lbl_ShiftEndTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_ShiftEndTime.Location = New System.Drawing.Point(8, 0)
        Me.lbl_ShiftEndTime.Name = "lbl_ShiftEndTime"
        Me.lbl_ShiftEndTime.Size = New System.Drawing.Size(190, 47)
        Me.lbl_ShiftEndTime.TabIndex = 0
        Me.lbl_ShiftEndTime.Text = "وقت نهاية الوردية"
        Me.lbl_ShiftEndTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ShiftEndTime
        '
        Me.ShiftEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.ShiftEndTime.Location = New System.Drawing.Point(8, 50)
        Me.ShiftEndTime.Name = "ShiftEndTime"
        Me.ShiftEndTime.Size = New System.Drawing.Size(190, 39)
        Me.ShiftEndTime.TabIndex = 3
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FlowLayoutPanel1.Controls.Add(Me.Lbl_MaquinaID)
        Me.FlowLayoutPanel1.Controls.Add(Me.lbl_ShiftType)
        Me.FlowLayoutPanel1.Controls.Add(Me.lbl_ShiftStartTime)
        Me.FlowLayoutPanel1.Controls.Add(Me.lbl_ShiftEndTime)
        Me.FlowLayoutPanel1.Controls.Add(Me.MaquinaID)
        Me.FlowLayoutPanel1.Controls.Add(Me.ShiftType)
        Me.FlowLayoutPanel1.Controls.Add(Me.ShiftStartTime)
        Me.FlowLayoutPanel1.Controls.Add(Me.ShiftEndTime)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1025, 97)
        Me.FlowLayoutPanel1.TabIndex = 4
        '
        'MaquinaID
        '
        Me.MaquinaID.FormattingEnabled = True
        Me.MaquinaID.Location = New System.Drawing.Point(777, 50)
        Me.MaquinaID.Name = "MaquinaID"
        Me.MaquinaID.Size = New System.Drawing.Size(241, 40)
        Me.MaquinaID.TabIndex = 5
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.dgv_Shift)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 97)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1025, 444)
        Me.Panel4.TabIndex = 5
        '
        'dgv_Shift
        '
        Me.dgv_Shift.AllowUserToAddRows = False
        Me.dgv_Shift.AllowUserToDeleteRows = False
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgv_Shift.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle26
        Me.dgv_Shift.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_Shift.BackgroundColor = System.Drawing.Color.White
        Me.dgv_Shift.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_Shift.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle27.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle27.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Shift.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle27
        Me.dgv_Shift.ColumnHeadersHeight = 40
        Me.dgv_Shift.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle28.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle28.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle28.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Shift.DefaultCellStyle = DataGridViewCellStyle28
        Me.dgv_Shift.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Shift.EnableHeadersVisualStyles = False
        Me.dgv_Shift.GridColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dgv_Shift.Location = New System.Drawing.Point(0, 0)
        Me.dgv_Shift.Name = "dgv_Shift"
        Me.dgv_Shift.ReadOnly = True
        Me.dgv_Shift.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle29.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle29.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle29.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Shift.RowHeadersDefaultCellStyle = DataGridViewCellStyle29
        Me.dgv_Shift.RowHeadersVisible = False
        Me.dgv_Shift.RowHeadersWidth = 51
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgv_Shift.RowsDefaultCellStyle = DataGridViewCellStyle30
        Me.dgv_Shift.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Shift.Size = New System.Drawing.Size(1025, 444)
        Me.dgv_Shift.TabIndex = 1
        '
        'Btn_Add
        '
        Me.Btn_Add.Font = New System.Drawing.Font("Cairo SemiBold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Add.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Add1
        Me.Btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Add.Location = New System.Drawing.Point(678, 15)
        Me.Btn_Add.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Btn_Add.Name = "Btn_Add"
        Me.Btn_Add.Size = New System.Drawing.Size(110, 49)
        Me.Btn_Add.TabIndex = 105
        Me.Btn_Add.Text = "حفظ"
        Me.Btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Add.UseVisualStyleBackColor = True
        '
        'Btn_Edit
        '
        Me.Btn_Edit.Font = New System.Drawing.Font("Cairo SemiBold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Edit.Image = Global.El_Dawliya_International_System.My.Resources.Resources.edit_24px
        Me.Btn_Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Edit.Location = New System.Drawing.Point(457, 15)
        Me.Btn_Edit.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Btn_Edit.Name = "Btn_Edit"
        Me.Btn_Edit.Size = New System.Drawing.Size(122, 49)
        Me.Btn_Edit.TabIndex = 106
        Me.Btn_Edit.Text = "تعديل"
        Me.Btn_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Edit.UseVisualStyleBackColor = True
        '
        'Btn_Delete
        '
        Me.Btn_Delete.Font = New System.Drawing.Font("Cairo SemiBold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Delete.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Remove1
        Me.Btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Delete.Location = New System.Drawing.Point(240, 15)
        Me.Btn_Delete.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Btn_Delete.Name = "Btn_Delete"
        Me.Btn_Delete.Size = New System.Drawing.Size(118, 49)
        Me.Btn_Delete.TabIndex = 107
        Me.Btn_Delete.Text = "حذف"
        Me.Btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Delete.UseVisualStyleBackColor = True
        '
        'Frm_Shift_For_Machine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1029, 680)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "Frm_Shift_For_Machine"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Shift_For_Machine"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.dgv_Shift, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ShiftID As TextBox
    Friend WithEvents Lbl_MaquinaID As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents lbl_ShiftType As Label
    Friend WithEvents lbl_ShiftStartTime As Label
    Friend WithEvents lbl_ShiftEndTime As Label
    Friend WithEvents ShiftEndTime As DateTimePicker
    Friend WithEvents ShiftStartTime As DateTimePicker
    Friend WithEvents ShiftType As TextBox
    Friend WithEvents MaquinaID As ComboBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents dgv_Shift As DataGridView
    Friend WithEvents Btn_Add As Button
    Friend WithEvents Btn_Edit As Button
    Friend WithEvents Btn_Delete As Button
End Class
