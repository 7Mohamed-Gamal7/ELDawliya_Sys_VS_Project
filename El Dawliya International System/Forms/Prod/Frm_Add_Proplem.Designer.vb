<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Add_Proplem
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnNewAdd = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Problem_Code = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Problem_Namelbl = New System.Windows.Forms.Label()
        Me.Problem_Machinelbl = New System.Windows.Forms.Label()
        Me.dgv_Tbl_Problem_Machine = New System.Windows.Forms.DataGridView()
        Me.Problem_Departmentlbl = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Problem_Name = New System.Windows.Forms.TextBox()
        Me.Combo_Unit = New System.Windows.Forms.ComboBox()
        Me.Problem_Department = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Problem_Machine = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgv_Tbl_Problem_Machine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 564)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(667, 71)
        Me.Panel1.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Panel5.Controls.Add(Me.BtnDelete)
        Me.Panel5.Controls.Add(Me.BtnSave)
        Me.Panel5.Controls.Add(Me.BtnNewAdd)
        Me.Panel5.Controls.Add(Me.BtnEdit)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(667, 71)
        Me.Panel5.TabIndex = 109
        '
        'BtnDelete
        '
        Me.BtnDelete.FlatAppearance.BorderSize = 0
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Remove
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.Location = New System.Drawing.Point(11, 7)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnDelete.Size = New System.Drawing.Size(121, 53)
        Me.BtnDelete.TabIndex = 108
        Me.BtnDelete.Text = "حذف"
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Ok
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Location = New System.Drawing.Point(355, 7)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnSave.Size = New System.Drawing.Size(121, 53)
        Me.BtnSave.TabIndex = 106
        Me.BtnSave.Text = "حفظ"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnNewAdd
        '
        Me.BtnNewAdd.FlatAppearance.BorderSize = 0
        Me.BtnNewAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNewAdd.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNewAdd.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Add
        Me.BtnNewAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNewAdd.Location = New System.Drawing.Point(527, 7)
        Me.BtnNewAdd.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.BtnNewAdd.Name = "BtnNewAdd"
        Me.BtnNewAdd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnNewAdd.Size = New System.Drawing.Size(121, 53)
        Me.BtnNewAdd.TabIndex = 105
        Me.BtnNewAdd.Text = "جديد"
        Me.BtnNewAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNewAdd.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.FlatAppearance.BorderSize = 0
        Me.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEdit.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Save_as
        Me.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEdit.Location = New System.Drawing.Point(183, 7)
        Me.BtnEdit.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnEdit.Size = New System.Drawing.Size(121, 53)
        Me.BtnEdit.TabIndex = 107
        Me.BtnEdit.Text = "تعديل"
        Me.BtnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Problem_Code)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(667, 48)
        Me.Panel2.TabIndex = 2
        '
        'Problem_Code
        '
        Me.Problem_Code.Font = New System.Drawing.Font("Cairo SemiBold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Problem_Code.Location = New System.Drawing.Point(63, 3)
        Me.Problem_Code.Name = "Problem_Code"
        Me.Problem_Code.ReadOnly = True
        Me.Problem_Code.Size = New System.Drawing.Size(44, 45)
        Me.Problem_Code.TabIndex = 111
        Me.Problem_Code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Problem_Code.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Menu1
        Me.PictureBox1.Location = New System.Drawing.Point(12, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(45, 45)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Cancel
        Me.PictureBox2.Location = New System.Drawing.Point(613, 3)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(46, 45)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 110
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Cairo", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(667, 48)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "اضافة مشكلة جديدة"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 48)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(667, 635)
        Me.Panel3.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Problem_Namelbl)
        Me.Panel4.Controls.Add(Me.Problem_Machinelbl)
        Me.Panel4.Controls.Add(Me.dgv_Tbl_Problem_Machine)
        Me.Panel4.Controls.Add(Me.Problem_Departmentlbl)
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Controls.Add(Me.Problem_Name)
        Me.Panel4.Controls.Add(Me.Combo_Unit)
        Me.Panel4.Controls.Add(Me.Problem_Department)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Problem_Machine)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(667, 564)
        Me.Panel4.TabIndex = 93
        '
        'Problem_Namelbl
        '
        Me.Problem_Namelbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Problem_Namelbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Problem_Namelbl.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Problem_Namelbl.ForeColor = System.Drawing.Color.Black
        Me.Problem_Namelbl.Location = New System.Drawing.Point(484, 11)
        Me.Problem_Namelbl.Name = "Problem_Namelbl"
        Me.Problem_Namelbl.Size = New System.Drawing.Size(172, 31)
        Me.Problem_Namelbl.TabIndex = 65
        Me.Problem_Namelbl.Text = "اسم المشكلة"
        Me.Problem_Namelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Problem_Machinelbl
        '
        Me.Problem_Machinelbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Problem_Machinelbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Problem_Machinelbl.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Problem_Machinelbl.ForeColor = System.Drawing.Color.Black
        Me.Problem_Machinelbl.Location = New System.Drawing.Point(484, 62)
        Me.Problem_Machinelbl.Name = "Problem_Machinelbl"
        Me.Problem_Machinelbl.Size = New System.Drawing.Size(172, 31)
        Me.Problem_Machinelbl.TabIndex = 69
        Me.Problem_Machinelbl.Text = "ماكينة المشكلة"
        Me.Problem_Machinelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgv_Tbl_Problem_Machine
        '
        Me.dgv_Tbl_Problem_Machine.AllowUserToAddRows = False
        Me.dgv_Tbl_Problem_Machine.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv_Tbl_Problem_Machine.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Tbl_Problem_Machine.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_Tbl_Problem_Machine.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Tbl_Problem_Machine.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_Tbl_Problem_Machine.ColumnHeadersHeight = 40
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Tbl_Problem_Machine.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_Tbl_Problem_Machine.EnableHeadersVisualStyles = False
        Me.dgv_Tbl_Problem_Machine.Location = New System.Drawing.Point(25, 203)
        Me.dgv_Tbl_Problem_Machine.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.dgv_Tbl_Problem_Machine.Name = "dgv_Tbl_Problem_Machine"
        Me.dgv_Tbl_Problem_Machine.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Tbl_Problem_Machine.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_Tbl_Problem_Machine.RowHeadersVisible = False
        Me.dgv_Tbl_Problem_Machine.RowHeadersWidth = 51
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_Tbl_Problem_Machine.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_Tbl_Problem_Machine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Tbl_Problem_Machine.Size = New System.Drawing.Size(631, 355)
        Me.dgv_Tbl_Problem_Machine.TabIndex = 89
        '
        'Problem_Departmentlbl
        '
        Me.Problem_Departmentlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Problem_Departmentlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Problem_Departmentlbl.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Problem_Departmentlbl.ForeColor = System.Drawing.Color.Black
        Me.Problem_Departmentlbl.Location = New System.Drawing.Point(484, 113)
        Me.Problem_Departmentlbl.Name = "Problem_Departmentlbl"
        Me.Problem_Departmentlbl.Size = New System.Drawing.Size(172, 31)
        Me.Problem_Departmentlbl.TabIndex = 67
        Me.Problem_Departmentlbl.Text = "قسم المشكلة"
        Me.Problem_Departmentlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(25, 160)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(195, 31)
        Me.Button1.TabIndex = 74
        Me.Button1.Text = "إضافة وحدة جديدة"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Problem_Name
        '
        Me.Problem_Name.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Problem_Name.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Problem_Name.Location = New System.Drawing.Point(25, 11)
        Me.Problem_Name.Name = "Problem_Name"
        Me.Problem_Name.Size = New System.Drawing.Size(453, 34)
        Me.Problem_Name.TabIndex = 1
        Me.Problem_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Combo_Unit
        '
        Me.Combo_Unit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Combo_Unit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.Combo_Unit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Combo_Unit.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_Unit.FormattingEnabled = True
        Me.Combo_Unit.Location = New System.Drawing.Point(226, 160)
        Me.Combo_Unit.Name = "Combo_Unit"
        Me.Combo_Unit.Size = New System.Drawing.Size(252, 35)
        Me.Combo_Unit.TabIndex = 72
        '
        'Problem_Department
        '
        Me.Problem_Department.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Problem_Department.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.Problem_Department.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Problem_Department.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Problem_Department.FormattingEnabled = True
        Me.Problem_Department.Location = New System.Drawing.Point(25, 113)
        Me.Problem_Department.Name = "Problem_Department"
        Me.Problem_Department.Size = New System.Drawing.Size(453, 35)
        Me.Problem_Department.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(484, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 31)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "وحدة المشكلة"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Problem_Machine
        '
        Me.Problem_Machine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Problem_Machine.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.Problem_Machine.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Problem_Machine.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Problem_Machine.FormattingEnabled = True
        Me.Problem_Machine.Items.AddRange(New Object() {"D1", "D2", "F1", "F2", "H1"})
        Me.Problem_Machine.Location = New System.Drawing.Point(25, 62)
        Me.Problem_Machine.Name = "Problem_Machine"
        Me.Problem_Machine.Size = New System.Drawing.Size(453, 35)
        Me.Problem_Machine.TabIndex = 2
        '
        'Frm_Add_Proplem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(667, 683)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm_Add_Proplem"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.dgv_Tbl_Problem_Machine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnNewAdd As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Problem_Namelbl As Label
    Friend WithEvents Problem_Machinelbl As Label
    Friend WithEvents dgv_Tbl_Problem_Machine As DataGridView
    Friend WithEvents Problem_Departmentlbl As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Problem_Name As TextBox
    Friend WithEvents Combo_Unit As ComboBox
    Friend WithEvents Problem_Department As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Problem_Machine As ComboBox
    Friend WithEvents Problem_Code As TextBox
    Friend WithEvents Panel5 As Panel
End Class
