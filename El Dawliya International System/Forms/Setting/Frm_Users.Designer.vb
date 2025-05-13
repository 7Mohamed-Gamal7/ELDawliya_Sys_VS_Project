<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Users
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Users))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.BtnNewAdd = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Radio_Forms = New System.Windows.Forms.RadioButton()
        Me.Radio_Dept = New System.Windows.Forms.RadioButton()
        Me.Radio_Name = New System.Windows.Forms.RadioButton()
        Me.Radio_ID = New System.Windows.Forms.RadioButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Chk_F2 = New System.Windows.Forms.CheckBox()
        Me.Chk_D2 = New System.Windows.Forms.CheckBox()
        Me.Chk_D1 = New System.Windows.Forms.CheckBox()
        Me.Chk_H = New System.Windows.Forms.CheckBox()
        Me.Chk_F1 = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_Search = New System.Windows.Forms.TextBox()
        Me.Forms = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Dept = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Jop = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.UserIDlbl = New System.Windows.Forms.Label()
        Me.UserID = New System.Windows.Forms.TextBox()
        Me.Usernamelbl = New System.Windows.Forms.Label()
        Me.Username = New System.Windows.Forms.TextBox()
        Me.Permissionslbl = New System.Windows.Forms.Label()
        Me.Permissions = New System.Windows.Forms.ComboBox()
        Me.dgv_Users = New System.Windows.Forms.DataGridView()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgv_Users, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 737)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1246, 72)
        Me.Panel1.TabIndex = 2
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.BtnNewAdd)
        Me.Panel6.Controls.Add(Me.BtnSave)
        Me.Panel6.Controls.Add(Me.BtnDelete)
        Me.Panel6.Controls.Add(Me.BtnEdit)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1246, 72)
        Me.Panel6.TabIndex = 109
        '
        'BtnNewAdd
        '
        Me.BtnNewAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNewAdd.FlatAppearance.BorderSize = 0
        Me.BtnNewAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNewAdd.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNewAdd.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Add
        Me.BtnNewAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNewAdd.Location = New System.Drawing.Point(1099, 9)
        Me.BtnNewAdd.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.BtnNewAdd.Name = "BtnNewAdd"
        Me.BtnNewAdd.Size = New System.Drawing.Size(130, 53)
        Me.BtnNewAdd.TabIndex = 105
        Me.BtnNewAdd.Text = "جديد"
        Me.BtnNewAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNewAdd.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSave.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Bold)
        Me.BtnSave.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Ok
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSave.Location = New System.Drawing.Point(737, 9)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnSave.Size = New System.Drawing.Size(130, 53)
        Me.BtnSave.TabIndex = 106
        Me.BtnSave.Text = "حفظ"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnDelete.FlatAppearance.BorderSize = 0
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnDelete.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Bold)
        Me.BtnDelete.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Remove
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.Location = New System.Drawing.Point(17, 9)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(130, 53)
        Me.BtnDelete.TabIndex = 108
        Me.BtnDelete.Text = "حذف"
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnEdit.FlatAppearance.BorderSize = 0
        Me.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEdit.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Bold)
        Me.BtnEdit.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Save_as
        Me.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEdit.Location = New System.Drawing.Point(375, 9)
        Me.BtnEdit.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(130, 53)
        Me.BtnEdit.TabIndex = 107
        Me.BtnEdit.Text = "تعديل"
        Me.BtnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1186, 3)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(54, 40)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 110
        Me.PictureBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Forms)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1246, 50)
        Me.Panel2.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Cairo", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1246, 50)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "اضافة مستخدم جديد"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Txt_Search)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Dept)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Jop)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.UserIDlbl)
        Me.Panel3.Controls.Add(Me.UserID)
        Me.Panel3.Controls.Add(Me.Usernamelbl)
        Me.Panel3.Controls.Add(Me.Username)
        Me.Panel3.Controls.Add(Me.Permissionslbl)
        Me.Panel3.Controls.Add(Me.Permissions)
        Me.Panel3.Controls.Add(Me.dgv_Users)
        Me.Panel3.Controls.Add(Me.Password)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 50)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1246, 687)
        Me.Panel3.TabIndex = 4
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.Radio_Forms)
        Me.Panel5.Controls.Add(Me.Radio_Dept)
        Me.Panel5.Controls.Add(Me.Radio_Name)
        Me.Panel5.Controls.Add(Me.Radio_ID)
        Me.Panel5.ForeColor = System.Drawing.Color.White
        Me.Panel5.Location = New System.Drawing.Point(14, 239)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1219, 44)
        Me.Panel5.TabIndex = 135
        '
        'Radio_Forms
        '
        Me.Radio_Forms.AutoSize = True
        Me.Radio_Forms.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Radio_Forms.Location = New System.Drawing.Point(3, 4)
        Me.Radio_Forms.Name = "Radio_Forms"
        Me.Radio_Forms.Size = New System.Drawing.Size(80, 33)
        Me.Radio_Forms.TabIndex = 107
        Me.Radio_Forms.TabStop = True
        Me.Radio_Forms.Text = "النماذج"
        Me.Radio_Forms.UseVisualStyleBackColor = True
        '
        'Radio_Dept
        '
        Me.Radio_Dept.AutoSize = True
        Me.Radio_Dept.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Radio_Dept.Location = New System.Drawing.Point(351, 3)
        Me.Radio_Dept.Name = "Radio_Dept"
        Me.Radio_Dept.Size = New System.Drawing.Size(79, 33)
        Me.Radio_Dept.TabIndex = 106
        Me.Radio_Dept.TabStop = True
        Me.Radio_Dept.Text = "القسم"
        Me.Radio_Dept.UseVisualStyleBackColor = True
        '
        'Radio_Name
        '
        Me.Radio_Name.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Radio_Name.AutoSize = True
        Me.Radio_Name.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Radio_Name.Location = New System.Drawing.Point(798, 3)
        Me.Radio_Name.Name = "Radio_Name"
        Me.Radio_Name.Size = New System.Drawing.Size(74, 33)
        Me.Radio_Name.TabIndex = 104
        Me.Radio_Name.TabStop = True
        Me.Radio_Name.Text = "الاسم"
        Me.Radio_Name.UseVisualStyleBackColor = True
        '
        'Radio_ID
        '
        Me.Radio_ID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Radio_ID.AutoSize = True
        Me.Radio_ID.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Radio_ID.Location = New System.Drawing.Point(1140, 3)
        Me.Radio_ID.Name = "Radio_ID"
        Me.Radio_ID.Size = New System.Drawing.Size(70, 33)
        Me.Radio_ID.TabIndex = 105
        Me.Radio_ID.TabStop = True
        Me.Radio_ID.Text = "الكود"
        Me.Radio_ID.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.Chk_F2)
        Me.Panel4.Controls.Add(Me.Chk_D2)
        Me.Panel4.Controls.Add(Me.Chk_D1)
        Me.Panel4.Controls.Add(Me.Chk_H)
        Me.Panel4.Controls.Add(Me.Chk_F1)
        Me.Panel4.ForeColor = System.Drawing.Color.White
        Me.Panel4.Location = New System.Drawing.Point(14, 161)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1034, 43)
        Me.Panel4.TabIndex = 134
        '
        'Chk_F2
        '
        Me.Chk_F2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chk_F2.AutoSize = True
        Me.Chk_F2.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Chk_F2.Location = New System.Drawing.Point(759, 2)
        Me.Chk_F2.Name = "Chk_F2"
        Me.Chk_F2.Size = New System.Drawing.Size(54, 36)
        Me.Chk_F2.TabIndex = 112
        Me.Chk_F2.Text = "F2"
        Me.Chk_F2.UseVisualStyleBackColor = True
        '
        'Chk_D2
        '
        Me.Chk_D2.AutoSize = True
        Me.Chk_D2.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Chk_D2.Location = New System.Drawing.Point(225, 2)
        Me.Chk_D2.Name = "Chk_D2"
        Me.Chk_D2.Size = New System.Drawing.Size(56, 36)
        Me.Chk_D2.TabIndex = 110
        Me.Chk_D2.Text = "D2"
        Me.Chk_D2.UseVisualStyleBackColor = True
        '
        'Chk_D1
        '
        Me.Chk_D1.AutoSize = True
        Me.Chk_D1.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Chk_D1.Location = New System.Drawing.Point(3, 2)
        Me.Chk_D1.Name = "Chk_D1"
        Me.Chk_D1.Size = New System.Drawing.Size(56, 36)
        Me.Chk_D1.TabIndex = 109
        Me.Chk_D1.Text = "D1"
        Me.Chk_D1.UseVisualStyleBackColor = True
        '
        'Chk_H
        '
        Me.Chk_H.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chk_H.AutoSize = True
        Me.Chk_H.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Chk_H.Location = New System.Drawing.Point(965, 3)
        Me.Chk_H.Name = "Chk_H"
        Me.Chk_H.Size = New System.Drawing.Size(47, 36)
        Me.Chk_H.TabIndex = 113
        Me.Chk_H.Text = "H"
        Me.Chk_H.UseVisualStyleBackColor = True
        '
        'Chk_F1
        '
        Me.Chk_F1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chk_F1.AutoSize = True
        Me.Chk_F1.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Chk_F1.Location = New System.Drawing.Point(539, 2)
        Me.Chk_F1.Name = "Chk_F1"
        Me.Chk_F1.Size = New System.Drawing.Size(54, 36)
        Me.Chk_F1.TabIndex = 111
        Me.Chk_F1.Text = "F1"
        Me.Chk_F1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(14, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(1219, 28)
        Me.Label4.TabIndex = 133
        Me.Label4.Text = "البحث بواسطة"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt_Search
        '
        Me.Txt_Search.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_Search.Location = New System.Drawing.Point(14, 288)
        Me.Txt_Search.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Txt_Search.Name = "Txt_Search"
        Me.Txt_Search.Size = New System.Drawing.Size(1215, 41)
        Me.Txt_Search.TabIndex = 132
        Me.Txt_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Forms
        '
        Me.Forms.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Forms.Font = New System.Drawing.Font("Cairo Medium", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Forms.Items.AddRange(New Object() {"D1", "D2", "F1", "F2", "H"})
        Me.Forms.Location = New System.Drawing.Point(12, 5)
        Me.Forms.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Forms.Name = "Forms"
        Me.Forms.Size = New System.Drawing.Size(178, 32)
        Me.Forms.TabIndex = 127
        Me.Forms.Visible = False
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(1051, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(178, 35)
        Me.Label6.TabIndex = 130
        Me.Label6.Text = "القسم"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Dept
        '
        Me.Dept.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dept.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.Dept.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Dept.Location = New System.Drawing.Point(778, 66)
        Me.Dept.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Dept.Name = "Dept"
        Me.Dept.Size = New System.Drawing.Size(270, 35)
        Me.Dept.TabIndex = 131
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(310, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(158, 35)
        Me.Label5.TabIndex = 128
        Me.Label5.Text = "الوظيفة"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Jop
        '
        Me.Jop.Location = New System.Drawing.Point(14, 68)
        Me.Jop.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Jop.Name = "Jop"
        Me.Jop.Size = New System.Drawing.Size(292, 35)
        Me.Jop.TabIndex = 129
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(1051, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(178, 37)
        Me.Label2.TabIndex = 125
        Me.Label2.Text = "باسورد المستخدم"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(1051, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(182, 43)
        Me.Label3.TabIndex = 126
        Me.Label3.Text = "النماذج المتاحة"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UserIDlbl
        '
        Me.UserIDlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserIDlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.UserIDlbl.ForeColor = System.Drawing.Color.White
        Me.UserIDlbl.Location = New System.Drawing.Point(1051, 13)
        Me.UserIDlbl.Name = "UserIDlbl"
        Me.UserIDlbl.Size = New System.Drawing.Size(178, 37)
        Me.UserIDlbl.TabIndex = 117
        Me.UserIDlbl.Text = "كود المستخدم"
        Me.UserIDlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UserID
        '
        Me.UserID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserID.Location = New System.Drawing.Point(778, 13)
        Me.UserID.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.UserID.Name = "UserID"
        Me.UserID.Size = New System.Drawing.Size(270, 41)
        Me.UserID.TabIndex = 118
        Me.UserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Usernamelbl
        '
        Me.Usernamelbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Usernamelbl.ForeColor = System.Drawing.Color.White
        Me.Usernamelbl.Location = New System.Drawing.Point(310, 15)
        Me.Usernamelbl.Name = "Usernamelbl"
        Me.Usernamelbl.Size = New System.Drawing.Size(158, 37)
        Me.Usernamelbl.TabIndex = 119
        Me.Usernamelbl.Text = "اسم المستخدم"
        Me.Usernamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Username
        '
        Me.Username.Location = New System.Drawing.Point(12, 15)
        Me.Username.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(292, 41)
        Me.Username.TabIndex = 120
        Me.Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Permissionslbl
        '
        Me.Permissionslbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Permissionslbl.ForeColor = System.Drawing.Color.White
        Me.Permissionslbl.Location = New System.Drawing.Point(310, 117)
        Me.Permissionslbl.Name = "Permissionslbl"
        Me.Permissionslbl.Size = New System.Drawing.Size(158, 37)
        Me.Permissionslbl.TabIndex = 122
        Me.Permissionslbl.Text = "الصلاحيات"
        Me.Permissionslbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Permissions
        '
        Me.Permissions.Items.AddRange(New Object() {"مدير", "مستخدم"})
        Me.Permissions.Location = New System.Drawing.Point(14, 117)
        Me.Permissions.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Permissions.Name = "Permissions"
        Me.Permissions.Size = New System.Drawing.Size(292, 35)
        Me.Permissions.TabIndex = 123
        '
        'dgv_Users
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_Users.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_Users.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_Users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader
        Me.dgv_Users.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Questv1", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Users.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgv_Users.ColumnHeadersHeight = 40
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Questv1", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Users.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgv_Users.Location = New System.Drawing.Point(14, 339)
        Me.dgv_Users.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.dgv_Users.Name = "dgv_Users"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Questv1", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(72, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Users.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgv_Users.RowHeadersVisible = False
        Me.dgv_Users.RowHeadersWidth = 51
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_Users.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgv_Users.Size = New System.Drawing.Size(1215, 340)
        Me.dgv_Users.TabIndex = 124
        '
        'Password
        '
        Me.Password.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Password.Location = New System.Drawing.Point(778, 111)
        Me.Password.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(270, 41)
        Me.Password.TabIndex = 121
        Me.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Frm_Users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1246, 809)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Questv1", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm_Users"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.dgv_Users, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnNewAdd As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Radio_Forms As RadioButton
    Friend WithEvents Radio_Dept As RadioButton
    Friend WithEvents Radio_Name As RadioButton
    Friend WithEvents Radio_ID As RadioButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Chk_F2 As CheckBox
    Friend WithEvents Chk_D2 As CheckBox
    Friend WithEvents Chk_D1 As CheckBox
    Friend WithEvents Chk_H As CheckBox
    Friend WithEvents Chk_F1 As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt_Search As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Dept As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Jop As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Forms As ComboBox
    Friend WithEvents UserIDlbl As Label
    Friend WithEvents UserID As TextBox
    Friend WithEvents Usernamelbl As Label
    Friend WithEvents Username As TextBox
    Friend WithEvents Permissionslbl As Label
    Friend WithEvents Permissions As ComboBox
    Friend WithEvents dgv_Users As DataGridView
    Friend WithEvents Password As TextBox
    Friend WithEvents Panel6 As Panel
End Class
