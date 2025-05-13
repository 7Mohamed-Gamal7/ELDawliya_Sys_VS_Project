<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Accidents
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
        Me.AccidentIDlbl = New System.Windows.Forms.Label()
        Me.AccidentID = New System.Windows.Forms.TextBox()
        Me.AccidentDatelbl = New System.Windows.Forms.Label()
        Me.AccidentDate = New System.Windows.Forms.DateTimePicker()
        Me.Emp_IDlbl = New System.Windows.Forms.Label()
        Me.Emp_ID = New System.Windows.Forms.ComboBox()
        Me.AccidentLocationlbl = New System.Windows.Forms.Label()
        Me.AccidentLocation = New System.Windows.Forms.TextBox()
        Me.AccidentDescriptionlbl = New System.Windows.Forms.Label()
        Me.AccidentDescription = New System.Windows.Forms.TextBox()
        Me.CorrectiveActionslbl = New System.Windows.Forms.Label()
        Me.CorrectiveActions = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_Print = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnNewAdd = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.dgv_Accidents = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.dgv_Accidents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'AccidentIDlbl
        '
        Me.AccidentIDlbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AccidentIDlbl.Location = New System.Drawing.Point(0, 0)
        Me.AccidentIDlbl.Name = "AccidentIDlbl"
        Me.AccidentIDlbl.Size = New System.Drawing.Size(1062, 44)
        Me.AccidentIDlbl.TabIndex = 0
        Me.AccidentIDlbl.Text = "تسجيل إصابات الموظفين"
        Me.AccidentIDlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AccidentID
        '
        Me.AccidentID.Font = New System.Drawing.Font("Cairo", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccidentID.Location = New System.Drawing.Point(12, 6)
        Me.AccidentID.Name = "AccidentID"
        Me.AccidentID.Size = New System.Drawing.Size(56, 32)
        Me.AccidentID.TabIndex = 1
        Me.AccidentID.Visible = False
        '
        'AccidentDatelbl
        '
        Me.AccidentDatelbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AccidentDatelbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AccidentDatelbl.Location = New System.Drawing.Point(856, 9)
        Me.AccidentDatelbl.Name = "AccidentDatelbl"
        Me.AccidentDatelbl.Size = New System.Drawing.Size(195, 40)
        Me.AccidentDatelbl.TabIndex = 2
        Me.AccidentDatelbl.Text = "تاريخ الحادث"
        Me.AccidentDatelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AccidentDate
        '
        Me.AccidentDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AccidentDate.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccidentDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.AccidentDate.Location = New System.Drawing.Point(687, 9)
        Me.AccidentDate.Name = "AccidentDate"
        Me.AccidentDate.Size = New System.Drawing.Size(163, 39)
        Me.AccidentDate.TabIndex = 3
        '
        'Emp_IDlbl
        '
        Me.Emp_IDlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Emp_IDlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Emp_IDlbl.Location = New System.Drawing.Point(490, 9)
        Me.Emp_IDlbl.Name = "Emp_IDlbl"
        Me.Emp_IDlbl.Size = New System.Drawing.Size(179, 40)
        Me.Emp_IDlbl.TabIndex = 4
        Me.Emp_IDlbl.Text = "اسم الموظف"
        Me.Emp_IDlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Emp_ID
        '
        Me.Emp_ID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Emp_ID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Emp_ID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Emp_ID.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Emp_ID.Location = New System.Drawing.Point(3, 9)
        Me.Emp_ID.Name = "Emp_ID"
        Me.Emp_ID.Size = New System.Drawing.Size(481, 40)
        Me.Emp_ID.TabIndex = 5
        '
        'AccidentLocationlbl
        '
        Me.AccidentLocationlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AccidentLocationlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AccidentLocationlbl.Location = New System.Drawing.Point(856, 55)
        Me.AccidentLocationlbl.Name = "AccidentLocationlbl"
        Me.AccidentLocationlbl.Size = New System.Drawing.Size(195, 40)
        Me.AccidentLocationlbl.TabIndex = 6
        Me.AccidentLocationlbl.Text = "مكان الحادث"
        Me.AccidentLocationlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AccidentLocation
        '
        Me.AccidentLocation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AccidentLocation.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccidentLocation.Location = New System.Drawing.Point(3, 55)
        Me.AccidentLocation.Name = "AccidentLocation"
        Me.AccidentLocation.Size = New System.Drawing.Size(847, 39)
        Me.AccidentLocation.TabIndex = 7
        '
        'AccidentDescriptionlbl
        '
        Me.AccidentDescriptionlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AccidentDescriptionlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AccidentDescriptionlbl.Location = New System.Drawing.Point(856, 100)
        Me.AccidentDescriptionlbl.Name = "AccidentDescriptionlbl"
        Me.AccidentDescriptionlbl.Size = New System.Drawing.Size(195, 88)
        Me.AccidentDescriptionlbl.TabIndex = 8
        Me.AccidentDescriptionlbl.Text = "وصف الحادث"
        Me.AccidentDescriptionlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AccidentDescription
        '
        Me.AccidentDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AccidentDescription.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccidentDescription.Location = New System.Drawing.Point(3, 100)
        Me.AccidentDescription.Multiline = True
        Me.AccidentDescription.Name = "AccidentDescription"
        Me.AccidentDescription.Size = New System.Drawing.Size(847, 91)
        Me.AccidentDescription.TabIndex = 9
        '
        'CorrectiveActionslbl
        '
        Me.CorrectiveActionslbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CorrectiveActionslbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CorrectiveActionslbl.Location = New System.Drawing.Point(856, 195)
        Me.CorrectiveActionslbl.Name = "CorrectiveActionslbl"
        Me.CorrectiveActionslbl.Size = New System.Drawing.Size(195, 40)
        Me.CorrectiveActionslbl.TabIndex = 10
        Me.CorrectiveActionslbl.Text = "الاجراءات التصحيحية"
        Me.CorrectiveActionslbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CorrectiveActions
        '
        Me.CorrectiveActions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CorrectiveActions.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CorrectiveActions.Location = New System.Drawing.Point(3, 196)
        Me.CorrectiveActions.Name = "CorrectiveActions"
        Me.CorrectiveActions.Size = New System.Drawing.Size(847, 39)
        Me.CorrectiveActions.TabIndex = 11
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.AccidentID)
        Me.Panel1.Controls.Add(Me.AccidentIDlbl)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1062, 44)
        Me.Panel1.TabIndex = 18
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btn_Print)
        Me.Panel2.Controls.Add(Me.BtnDelete)
        Me.Panel2.Controls.Add(Me.BtnEdit)
        Me.Panel2.Controls.Add(Me.BtnSave)
        Me.Panel2.Controls.Add(Me.BtnNewAdd)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 600)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1062, 73)
        Me.Panel2.TabIndex = 18
        '
        'btn_Print
        '
        Me.btn_Print.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Print.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Print
        Me.btn_Print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Print.Location = New System.Drawing.Point(535, 10)
        Me.btn_Print.Name = "btn_Print"
        Me.btn_Print.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_Print.Size = New System.Drawing.Size(140, 53)
        Me.btn_Print.TabIndex = 30
        Me.btn_Print.Text = "طباعة"
        Me.btn_Print.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Print.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDelete.Enabled = False
        Me.BtnDelete.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Remove
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.Location = New System.Drawing.Point(418, 10)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnDelete.Size = New System.Drawing.Size(111, 53)
        Me.BtnDelete.TabIndex = 29
        Me.BtnDelete.Text = "حذف"
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEdit.Enabled = False
        Me.BtnEdit.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Edit
        Me.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEdit.Location = New System.Drawing.Point(689, 10)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnEdit.Size = New System.Drawing.Size(111, 53)
        Me.BtnEdit.TabIndex = 28
        Me.BtnEdit.Text = "تعديل"
        Me.BtnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Save
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Location = New System.Drawing.Point(814, 10)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnSave.Size = New System.Drawing.Size(111, 53)
        Me.BtnSave.TabIndex = 27
        Me.BtnSave.Text = "حفظ"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnNewAdd
        '
        Me.BtnNewAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNewAdd.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Add
        Me.BtnNewAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNewAdd.Location = New System.Drawing.Point(931, 10)
        Me.BtnNewAdd.Name = "BtnNewAdd"
        Me.BtnNewAdd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnNewAdd.Size = New System.Drawing.Size(119, 53)
        Me.BtnNewAdd.TabIndex = 26
        Me.BtnNewAdd.Text = "إضافة"
        Me.BtnNewAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNewAdd.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 44)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1062, 556)
        Me.Panel3.TabIndex = 18
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DimGray
        Me.Panel5.Controls.Add(Me.dgv_Accidents)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 242)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1062, 314)
        Me.Panel5.TabIndex = 20
        '
        'dgv_Accidents
        '
        Me.dgv_Accidents.AllowUserToAddRows = False
        Me.dgv_Accidents.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgv_Accidents.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Accidents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_Accidents.BackgroundColor = System.Drawing.Color.White
        Me.dgv_Accidents.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_Accidents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Cairo", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Accidents.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_Accidents.ColumnHeadersHeight = 40
        Me.dgv_Accidents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Cairo", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Accidents.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_Accidents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Accidents.EnableHeadersVisualStyles = False
        Me.dgv_Accidents.GridColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dgv_Accidents.Location = New System.Drawing.Point(0, 0)
        Me.dgv_Accidents.Name = "dgv_Accidents"
        Me.dgv_Accidents.ReadOnly = True
        Me.dgv_Accidents.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Cairo", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Accidents.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_Accidents.RowHeadersVisible = False
        Me.dgv_Accidents.RowHeadersWidth = 51
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgv_Accidents.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_Accidents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Accidents.Size = New System.Drawing.Size(1062, 314)
        Me.dgv_Accidents.TabIndex = 20
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.CorrectiveActions)
        Me.Panel4.Controls.Add(Me.CorrectiveActionslbl)
        Me.Panel4.Controls.Add(Me.AccidentDescription)
        Me.Panel4.Controls.Add(Me.AccidentDescriptionlbl)
        Me.Panel4.Controls.Add(Me.AccidentDatelbl)
        Me.Panel4.Controls.Add(Me.AccidentLocation)
        Me.Panel4.Controls.Add(Me.AccidentDate)
        Me.Panel4.Controls.Add(Me.AccidentLocationlbl)
        Me.Panel4.Controls.Add(Me.Emp_IDlbl)
        Me.Panel4.Controls.Add(Me.Emp_ID)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1062, 242)
        Me.Panel4.TabIndex = 19
        '
        'Frm_Accidents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1062, 673)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Cairo", 12.0!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Frm_Accidents"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "شاشة تسجيل الاصابات"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.dgv_Accidents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AccidentID As System.Windows.Forms.TextBox
    Friend WithEvents AccidentIDlbl As System.Windows.Forms.Label
    Friend WithEvents AccidentDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents AccidentDatelbl As System.Windows.Forms.Label
    Friend WithEvents Emp_ID As System.Windows.Forms.ComboBox
    Friend WithEvents Emp_IDlbl As System.Windows.Forms.Label
    Friend WithEvents AccidentLocation As System.Windows.Forms.TextBox
    Friend WithEvents AccidentLocationlbl As System.Windows.Forms.Label
    Friend WithEvents AccidentDescription As System.Windows.Forms.TextBox
    Friend WithEvents AccidentDescriptionlbl As System.Windows.Forms.Label
    Friend WithEvents CorrectiveActions As System.Windows.Forms.TextBox
    Friend WithEvents CorrectiveActionslbl As System.Windows.Forms.Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_Print As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnNewAdd As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents dgv_Accidents As DataGridView
    Friend WithEvents Panel5 As Panel
End Class
