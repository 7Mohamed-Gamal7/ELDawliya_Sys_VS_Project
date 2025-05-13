<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Note_Employee_Test
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Note_ID = New System.Windows.Forms.TextBox()
        Me.Note_IDlbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Note_Emp_IDlbl = New System.Windows.Forms.Label()
        Me.Note_Employee_Namelbl = New System.Windows.Forms.Label()
        Me.Note_Datelbl = New System.Windows.Forms.Label()
        Me.Note_Emp_ID = New System.Windows.Forms.TextBox()
        Me.Note_Employee_Name = New System.Windows.Forms.TextBox()
        Me.Note_Date = New System.Windows.Forms.DateTimePicker()
        Me.Description_Notelbl = New System.Windows.Forms.Label()
        Me.Description_Note = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgv_Note_Employee = New ADGV.AdvancedDataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnNewAdd = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Btn_Print = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgv_Note_Employee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Note_ID)
        Me.Panel1.Controls.Add(Me.Note_IDlbl)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1427, 49)
        Me.Panel1.TabIndex = 0
        '
        'Note_ID
        '
        Me.Note_ID.Location = New System.Drawing.Point(21, 6)
        Me.Note_ID.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Note_ID.Name = "Note_ID"
        Me.Note_ID.Size = New System.Drawing.Size(101, 39)
        Me.Note_ID.TabIndex = 3
        Me.Note_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Note_ID.Visible = False
        '
        'Note_IDlbl
        '
        Me.Note_IDlbl.Location = New System.Drawing.Point(126, 9)
        Me.Note_IDlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Note_IDlbl.Name = "Note_IDlbl"
        Me.Note_IDlbl.Size = New System.Drawing.Size(119, 32)
        Me.Note_IDlbl.TabIndex = 2
        Me.Note_IDlbl.Text = "كود الملاحظة"
        Me.Note_IDlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Note_IDlbl.Visible = False
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1427, 49)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "شاشة ملاحظات الموظفين"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FlowLayoutPanel1.Controls.Add(Me.Note_Emp_IDlbl)
        Me.FlowLayoutPanel1.Controls.Add(Me.Note_Employee_Namelbl)
        Me.FlowLayoutPanel1.Controls.Add(Me.Note_Datelbl)
        Me.FlowLayoutPanel1.Controls.Add(Me.Note_Emp_ID)
        Me.FlowLayoutPanel1.Controls.Add(Me.Note_Employee_Name)
        Me.FlowLayoutPanel1.Controls.Add(Me.Note_Date)
        Me.FlowLayoutPanel1.Controls.Add(Me.Description_Notelbl)
        Me.FlowLayoutPanel1.Controls.Add(Me.Description_Note)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 49)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1427, 224)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'Note_Emp_IDlbl
        '
        Me.Note_Emp_IDlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Note_Emp_IDlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Note_Emp_IDlbl.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Note_Emp_IDlbl.Location = New System.Drawing.Point(1209, 0)
        Me.Note_Emp_IDlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Note_Emp_IDlbl.Name = "Note_Emp_IDlbl"
        Me.Note_Emp_IDlbl.Size = New System.Drawing.Size(212, 43)
        Me.Note_Emp_IDlbl.TabIndex = 3
        Me.Note_Emp_IDlbl.Text = "كود الموظف"
        Me.Note_Emp_IDlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Note_Employee_Namelbl
        '
        Me.Note_Employee_Namelbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Note_Employee_Namelbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Note_Employee_Namelbl.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Note_Employee_Namelbl.Location = New System.Drawing.Point(385, 0)
        Me.Note_Employee_Namelbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Note_Employee_Namelbl.Name = "Note_Employee_Namelbl"
        Me.Note_Employee_Namelbl.Size = New System.Drawing.Size(820, 43)
        Me.Note_Employee_Namelbl.TabIndex = 5
        Me.Note_Employee_Namelbl.Text = "اسم الموظف"
        Me.Note_Employee_Namelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Note_Datelbl
        '
        Me.Note_Datelbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Note_Datelbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Note_Datelbl.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Note_Datelbl.Location = New System.Drawing.Point(13, 0)
        Me.Note_Datelbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Note_Datelbl.Name = "Note_Datelbl"
        Me.Note_Datelbl.Size = New System.Drawing.Size(368, 43)
        Me.Note_Datelbl.TabIndex = 9
        Me.Note_Datelbl.Text = "تاريخ الملاحظة"
        Me.Note_Datelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Note_Emp_ID
        '
        Me.Note_Emp_ID.Enabled = False
        Me.Note_Emp_ID.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Note_Emp_ID.Location = New System.Drawing.Point(1209, 47)
        Me.Note_Emp_ID.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Note_Emp_ID.Name = "Note_Emp_ID"
        Me.Note_Emp_ID.Size = New System.Drawing.Size(212, 39)
        Me.Note_Emp_ID.TabIndex = 10
        Me.Note_Emp_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Note_Employee_Name
        '
        Me.Note_Employee_Name.Enabled = False
        Me.Note_Employee_Name.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Note_Employee_Name.Location = New System.Drawing.Point(385, 47)
        Me.Note_Employee_Name.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Note_Employee_Name.Name = "Note_Employee_Name"
        Me.Note_Employee_Name.Size = New System.Drawing.Size(820, 39)
        Me.Note_Employee_Name.TabIndex = 11
        Me.Note_Employee_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Note_Date
        '
        Me.Note_Date.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Note_Date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Note_Date.Location = New System.Drawing.Point(13, 47)
        Me.Note_Date.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Note_Date.Name = "Note_Date"
        Me.Note_Date.Size = New System.Drawing.Size(368, 39)
        Me.Note_Date.TabIndex = 12
        '
        'Description_Notelbl
        '
        Me.Description_Notelbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Description_Notelbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Description_Notelbl.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Description_Notelbl.Location = New System.Drawing.Point(13, 90)
        Me.Description_Notelbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Description_Notelbl.Name = "Description_Notelbl"
        Me.Description_Notelbl.Size = New System.Drawing.Size(1408, 35)
        Me.Description_Notelbl.TabIndex = 13
        Me.Description_Notelbl.Text = "الملاحظة"
        Me.Description_Notelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Description_Note
        '
        Me.Description_Note.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Description_Note.Location = New System.Drawing.Point(13, 129)
        Me.Description_Note.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Description_Note.Multiline = True
        Me.Description_Note.Name = "Description_Note"
        Me.Description_Note.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Description_Note.Size = New System.Drawing.Size(1408, 88)
        Me.Description_Note.TabIndex = 14
        Me.Description_Note.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.dgv_Note_Employee)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 273)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1427, 452)
        Me.Panel2.TabIndex = 2
        '
        'dgv_Note_Employee
        '
        Me.dgv_Note_Employee.AllowUserToAddRows = False
        Me.dgv_Note_Employee.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_Note_Employee.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Note_Employee.AutoGenerateContextFilters = True
        Me.dgv_Note_Employee.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Note_Employee.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_Note_Employee.ColumnHeadersHeight = 29
        Me.dgv_Note_Employee.DateWithTime = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Note_Employee.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_Note_Employee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Note_Employee.EnableHeadersVisualStyles = False
        Me.dgv_Note_Employee.Location = New System.Drawing.Point(0, 0)
        Me.dgv_Note_Employee.Name = "dgv_Note_Employee"
        Me.dgv_Note_Employee.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Note_Employee.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_Note_Employee.RowHeadersVisible = False
        Me.dgv_Note_Employee.RowHeadersWidth = 60
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_Note_Employee.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_Note_Employee.RowTemplate.Height = 26
        Me.dgv_Note_Employee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Note_Employee.Size = New System.Drawing.Size(1423, 448)
        Me.dgv_Note_Employee.TabIndex = 119
        Me.dgv_Note_Employee.TimeFilter = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BtnNewAdd)
        Me.Panel3.Controls.Add(Me.BtnSave)
        Me.Panel3.Controls.Add(Me.Btn_Print)
        Me.Panel3.Controls.Add(Me.BtnEdit)
        Me.Panel3.Controls.Add(Me.BtnDelete)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 643)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1427, 82)
        Me.Panel3.TabIndex = 3
        '
        'BtnNewAdd
        '
        Me.BtnNewAdd.BackColor = System.Drawing.Color.LightGray
        Me.BtnNewAdd.Image = Global.El_Dawliya_International_System.My.Resources.Resources.add_24px1
        Me.BtnNewAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNewAdd.Location = New System.Drawing.Point(1264, 16)
        Me.BtnNewAdd.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.BtnNewAdd.Name = "BtnNewAdd"
        Me.BtnNewAdd.Size = New System.Drawing.Size(151, 50)
        Me.BtnNewAdd.TabIndex = 15
        Me.BtnNewAdd.Text = "ملاحظة جديدة"
        Me.BtnNewAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNewAdd.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.Lime
        Me.BtnSave.Image = Global.El_Dawliya_International_System.My.Resources.Resources.data_quality_24px
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Location = New System.Drawing.Point(958, 16)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(115, 50)
        Me.BtnSave.TabIndex = 16
        Me.BtnSave.Text = "حفظ"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'Btn_Print
        '
        Me.Btn_Print.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Print1
        Me.Btn_Print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Print.Location = New System.Drawing.Point(321, 16)
        Me.Btn_Print.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Btn_Print.Name = "Btn_Print"
        Me.Btn_Print.Size = New System.Drawing.Size(140, 50)
        Me.Btn_Print.TabIndex = 17
        Me.Btn_Print.Text = "طباعة"
        Me.Btn_Print.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Print.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.Color.Blue
        Me.BtnEdit.Enabled = False
        Me.BtnEdit.Image = Global.El_Dawliya_International_System.My.Resources.Resources.edit_24px
        Me.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEdit.Location = New System.Drawing.Point(652, 16)
        Me.BtnEdit.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(115, 50)
        Me.BtnEdit.TabIndex = 18
        Me.BtnEdit.Text = "تعديل"
        Me.BtnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.Red
        Me.BtnDelete.Enabled = False
        Me.BtnDelete.Image = Global.El_Dawliya_International_System.My.Resources.Resources.delete_24px
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.Location = New System.Drawing.Point(15, 16)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(115, 50)
        Me.BtnDelete.TabIndex = 19
        Me.BtnDelete.Text = "حذف"
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'Frm_Note_Employee_Test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1427, 725)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "Frm_Note_Employee_Test"
        Me.RightToLeftLayout = True
        Me.Text = "شاشة إضافة ملاحظات للموظفين"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgv_Note_Employee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Note_Emp_IDlbl As Label
    Friend WithEvents Note_Employee_Namelbl As Label
    Friend WithEvents Note_Datelbl As Label
    Friend WithEvents Note_Emp_ID As TextBox
    Friend WithEvents Note_Employee_Name As TextBox
    Friend WithEvents Note_Date As DateTimePicker
    Friend WithEvents Description_Notelbl As Label
    Friend WithEvents Description_Note As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dgv_Note_Employee As ADGV.AdvancedDataGridView
    Friend WithEvents BtnNewAdd As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents Btn_Print As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents Note_ID As TextBox
    Friend WithEvents Note_IDlbl As Label
    Friend WithEvents BindingSource1 As BindingSource
End Class
