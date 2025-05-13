<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_UserPermissions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_UserPermissions))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.UserIDlbl = New System.Windows.Forms.Label()
        Me.UserID = New System.Windows.Forms.ComboBox()
        Me.Frm_IDlbl = New System.Windows.Forms.Label()
        Me.Frm_ID = New System.Windows.Forms.ComboBox()
        Me.Tool_IDlbl = New System.Windows.Forms.Label()
        Me.Tool_ID = New System.Windows.Forms.ComboBox()
        Me.PermissionLevellbl = New System.Windows.Forms.Label()
        Me.PermissionLevel = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBoxClose = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnNewAdd = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.dgv_UserPermissions = New System.Windows.Forms.DataGridView()
        Me.Sin = New System.Windows.Forms.TextBox()
        Me.Txt_Search = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Radio_Forms = New System.Windows.Forms.RadioButton()
        Me.Radio_Tool = New System.Windows.Forms.RadioButton()
        Me.Radio_User = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_UserPermissions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'UserIDlbl
        '
        Me.UserIDlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserIDlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.UserIDlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.UserIDlbl.ForeColor = System.Drawing.Color.White
        Me.UserIDlbl.Location = New System.Drawing.Point(895, 67)
        Me.UserIDlbl.Name = "UserIDlbl"
        Me.UserIDlbl.Size = New System.Drawing.Size(142, 33)
        Me.UserIDlbl.TabIndex = 0
        Me.UserIDlbl.Text = "أسم المستخدم"
        Me.UserIDlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UserID
        '
        Me.UserID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.UserID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.UserID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserID.Location = New System.Drawing.Point(614, 67)
        Me.UserID.Name = "UserID"
        Me.UserID.Size = New System.Drawing.Size(275, 36)
        Me.UserID.TabIndex = 1
        '
        'Frm_IDlbl
        '
        Me.Frm_IDlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Frm_IDlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Frm_IDlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Frm_IDlbl.ForeColor = System.Drawing.Color.White
        Me.Frm_IDlbl.Location = New System.Drawing.Point(380, 67)
        Me.Frm_IDlbl.Name = "Frm_IDlbl"
        Me.Frm_IDlbl.Size = New System.Drawing.Size(191, 33)
        Me.Frm_IDlbl.TabIndex = 2
        Me.Frm_IDlbl.Text = "اسم الشاشة"
        Me.Frm_IDlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Frm_ID
        '
        Me.Frm_ID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Frm_ID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Frm_ID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frm_ID.Location = New System.Drawing.Point(12, 67)
        Me.Frm_ID.Name = "Frm_ID"
        Me.Frm_ID.Size = New System.Drawing.Size(362, 36)
        Me.Frm_ID.TabIndex = 3
        '
        'Tool_IDlbl
        '
        Me.Tool_IDlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tool_IDlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Tool_IDlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Tool_IDlbl.ForeColor = System.Drawing.Color.White
        Me.Tool_IDlbl.Location = New System.Drawing.Point(380, 108)
        Me.Tool_IDlbl.Name = "Tool_IDlbl"
        Me.Tool_IDlbl.Size = New System.Drawing.Size(191, 33)
        Me.Tool_IDlbl.TabIndex = 4
        Me.Tool_IDlbl.Text = "اسم الاداة"
        Me.Tool_IDlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Tool_ID
        '
        Me.Tool_ID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Tool_ID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Tool_ID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tool_ID.Location = New System.Drawing.Point(12, 108)
        Me.Tool_ID.Name = "Tool_ID"
        Me.Tool_ID.Size = New System.Drawing.Size(362, 36)
        Me.Tool_ID.TabIndex = 5
        '
        'PermissionLevellbl
        '
        Me.PermissionLevellbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PermissionLevellbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.PermissionLevellbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PermissionLevellbl.ForeColor = System.Drawing.Color.White
        Me.PermissionLevellbl.Location = New System.Drawing.Point(895, 108)
        Me.PermissionLevellbl.Name = "PermissionLevellbl"
        Me.PermissionLevellbl.Size = New System.Drawing.Size(142, 33)
        Me.PermissionLevellbl.TabIndex = 6
        Me.PermissionLevellbl.Text = "مستوى التحكم"
        Me.PermissionLevellbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PermissionLevel
        '
        Me.PermissionLevel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PermissionLevel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.PermissionLevel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.PermissionLevel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PermissionLevel.Items.AddRange(New Object() {"1", "2"})
        Me.PermissionLevel.Location = New System.Drawing.Point(614, 108)
        Me.PermissionLevel.Name = "PermissionLevel"
        Me.PermissionLevel.Size = New System.Drawing.Size(275, 36)
        Me.PermissionLevel.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.PictureBoxClose)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1051, 57)
        Me.Panel1.TabIndex = 96
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(986, 5)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(52, 45)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'PictureBoxClose
        '
        Me.PictureBoxClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxClose.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxClose.Image = CType(resources.GetObject("PictureBoxClose.Image"), System.Drawing.Image)
        Me.PictureBoxClose.Location = New System.Drawing.Point(3521, 20)
        Me.PictureBoxClose.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.PictureBoxClose.Name = "PictureBoxClose"
        Me.PictureBoxClose.Size = New System.Drawing.Size(71, 104)
        Me.PictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxClose.TabIndex = 36
        Me.PictureBoxClose.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Cairo", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1051, 57)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "صلاحيات المستخدمين"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 700)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1051, 83)
        Me.Panel2.TabIndex = 97
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.Button12)
        Me.Panel4.Controls.Add(Me.BtnDelete)
        Me.Panel4.Controls.Add(Me.Button1)
        Me.Panel4.Controls.Add(Me.BtnEdit)
        Me.Panel4.Controls.Add(Me.BtnSave)
        Me.Panel4.Controls.Add(Me.BtnNewAdd)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1051, 83)
        Me.Panel4.TabIndex = 121
        '
        'Button12
        '
        Me.Button12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button12.FlatAppearance.BorderSize = 0
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Font = New System.Drawing.Font("Hacen Saudi Arabia", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Microsoft_Excel_96px
        Me.Button12.Location = New System.Drawing.Point(367, 15)
        Me.Button12.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(127, 52)
        Me.Button12.TabIndex = 127
        Me.Button12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button12.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDelete.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Bold)
        Me.BtnDelete.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Remove
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.Location = New System.Drawing.Point(231, 16)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(127, 52)
        Me.BtnDelete.TabIndex = 86
        Me.BtnDelete.Text = "حذف"
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Button1.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Print
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(640, 14)
        Me.Button1.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 52)
        Me.Button1.TabIndex = 85
        Me.Button1.Text = "طباعة"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEdit.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Bold)
        Me.BtnEdit.Image = Global.El_Dawliya_International_System.My.Resources.Resources.edit_24px
        Me.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEdit.Location = New System.Drawing.Point(503, 14)
        Me.BtnEdit.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(127, 52)
        Me.BtnEdit.TabIndex = 85
        Me.BtnEdit.Text = "تعديل"
        Me.BtnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Bold)
        Me.BtnSave.Image = Global.El_Dawliya_International_System.My.Resources.Resources.done_26px
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Location = New System.Drawing.Point(777, 14)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(127, 52)
        Me.BtnSave.TabIndex = 84
        Me.BtnSave.Text = "حفظ"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnNewAdd
        '
        Me.BtnNewAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNewAdd.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Bold)
        Me.BtnNewAdd.ForeColor = System.Drawing.Color.Black
        Me.BtnNewAdd.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Add
        Me.BtnNewAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNewAdd.Location = New System.Drawing.Point(914, 14)
        Me.BtnNewAdd.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.BtnNewAdd.Name = "BtnNewAdd"
        Me.BtnNewAdd.Size = New System.Drawing.Size(127, 52)
        Me.BtnNewAdd.TabIndex = 83
        Me.BtnNewAdd.Text = "جديد"
        Me.BtnNewAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNewAdd.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(4108, 20)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(71, 104)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 36
        Me.PictureBox3.TabStop = False
        '
        'dgv_UserPermissions
        '
        Me.dgv_UserPermissions.AllowUserToAddRows = False
        Me.dgv_UserPermissions.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Cairo", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv_UserPermissions.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_UserPermissions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader
        Me.dgv_UserPermissions.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_UserPermissions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_UserPermissions.ColumnHeadersHeight = 40
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_UserPermissions.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_UserPermissions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_UserPermissions.EnableHeadersVisualStyles = False
        Me.dgv_UserPermissions.Location = New System.Drawing.Point(0, 0)
        Me.dgv_UserPermissions.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.dgv_UserPermissions.Name = "dgv_UserPermissions"
        Me.dgv_UserPermissions.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_UserPermissions.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_UserPermissions.RowHeadersVisible = False
        Me.dgv_UserPermissions.RowHeadersWidth = 51
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Cairo SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_UserPermissions.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_UserPermissions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_UserPermissions.Size = New System.Drawing.Size(1036, 451)
        Me.dgv_UserPermissions.TabIndex = 98
        '
        'Sin
        '
        Me.Sin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sin.Location = New System.Drawing.Point(580, 106)
        Me.Sin.Name = "Sin"
        Me.Sin.Size = New System.Drawing.Size(31, 36)
        Me.Sin.TabIndex = 100
        Me.Sin.Visible = False
        '
        'Txt_Search
        '
        Me.Txt_Search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_Search.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Txt_Search.Location = New System.Drawing.Point(614, 151)
        Me.Txt_Search.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.Txt_Search.Name = "Txt_Search"
        Me.Txt_Search.Size = New System.Drawing.Size(275, 36)
        Me.Txt_Search.TabIndex = 102
        Me.Txt_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(895, 151)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 36)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "ابحث هنا"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.Radio_Forms)
        Me.Panel5.Controls.Add(Me.Radio_Tool)
        Me.Panel5.Controls.Add(Me.Radio_User)
        Me.Panel5.Location = New System.Drawing.Point(10, 151)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(561, 44)
        Me.Panel5.TabIndex = 116
        '
        'Radio_Forms
        '
        Me.Radio_Forms.AutoSize = True
        Me.Radio_Forms.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Radio_Forms.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Radio_Forms.ForeColor = System.Drawing.Color.Black
        Me.Radio_Forms.Location = New System.Drawing.Point(3, 3)
        Me.Radio_Forms.Name = "Radio_Forms"
        Me.Radio_Forms.Size = New System.Drawing.Size(117, 33)
        Me.Radio_Forms.TabIndex = 107
        Me.Radio_Forms.TabStop = True
        Me.Radio_Forms.Text = "اسم النموذج"
        Me.Radio_Forms.UseVisualStyleBackColor = False
        '
        'Radio_Tool
        '
        Me.Radio_Tool.AutoSize = True
        Me.Radio_Tool.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Radio_Tool.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Radio_Tool.ForeColor = System.Drawing.Color.Black
        Me.Radio_Tool.Location = New System.Drawing.Point(218, 3)
        Me.Radio_Tool.Name = "Radio_Tool"
        Me.Radio_Tool.Size = New System.Drawing.Size(103, 33)
        Me.Radio_Tool.TabIndex = 104
        Me.Radio_Tool.TabStop = True
        Me.Radio_Tool.Text = "اسم الاداة"
        Me.Radio_Tool.UseVisualStyleBackColor = False
        '
        'Radio_User
        '
        Me.Radio_User.AutoSize = True
        Me.Radio_User.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Radio_User.Checked = True
        Me.Radio_User.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Radio_User.ForeColor = System.Drawing.Color.Black
        Me.Radio_User.Location = New System.Drawing.Point(419, 3)
        Me.Radio_User.Name = "Radio_User"
        Me.Radio_User.Size = New System.Drawing.Size(134, 33)
        Me.Radio_User.TabIndex = 105
        Me.Radio_User.TabStop = True
        Me.Radio_User.Text = "اسم المستخدم"
        Me.Radio_User.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(7, 654)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(273, 36)
        Me.TextBox1.TabIndex = 119
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.dgv_UserPermissions)
        Me.Panel3.Location = New System.Drawing.Point(7, 197)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1036, 451)
        Me.Panel3.TabIndex = 120
        '
        'Button10
        '
        Me.Button10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button10.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Button10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Button10.ForeColor = System.Drawing.Color.Blue
        Me.Button10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button10.Location = New System.Drawing.Point(382, 70)
        Me.Button10.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(67, 27)
        Me.Button10.TabIndex = 134
        Me.Button10.Text = "اضافة سيارة"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Button3.ForeColor = System.Drawing.Color.Blue
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.Location = New System.Drawing.Point(382, 110)
        Me.Button3.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(67, 27)
        Me.Button3.TabIndex = 134
        Me.Button3.Text = "اضافة سيارة"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(287, 653)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 36)
        Me.Label3.TabIndex = 135
        Me.Label3.Text = "عدد سجلات البحث"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Frm_UserPermissions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1051, 783)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Txt_Search)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Sin)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.UserIDlbl)
        Me.Controls.Add(Me.UserID)
        Me.Controls.Add(Me.Frm_IDlbl)
        Me.Controls.Add(Me.Frm_ID)
        Me.Controls.Add(Me.Tool_IDlbl)
        Me.Controls.Add(Me.Tool_ID)
        Me.Controls.Add(Me.PermissionLevellbl)
        Me.Controls.Add(Me.PermissionLevel)
        Me.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.Name = "Frm_UserPermissions"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_UserPermissions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UserID As System.Windows.Forms.ComboBox
    Friend WithEvents UserIDlbl As System.Windows.Forms.Label
    Friend WithEvents Frm_ID As System.Windows.Forms.ComboBox
    Friend WithEvents Frm_IDlbl As System.Windows.Forms.Label
    Friend WithEvents Tool_ID As System.Windows.Forms.ComboBox
    Friend WithEvents Tool_IDlbl As System.Windows.Forms.Label
    Friend WithEvents PermissionLevel As System.Windows.Forms.ComboBox
    Friend WithEvents PermissionLevellbl As System.Windows.Forms.Label
    Friend WithEvents BtnNewAdd As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBoxClose As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents dgv_UserPermissions As DataGridView
    Friend WithEvents Sin As TextBox
    Friend WithEvents Txt_Search As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Radio_Forms As RadioButton
    Friend WithEvents Radio_Tool As RadioButton
    Friend WithEvents Radio_User As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Button10 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Button12 As Button
    Friend WithEvents Button1 As Button
End Class
