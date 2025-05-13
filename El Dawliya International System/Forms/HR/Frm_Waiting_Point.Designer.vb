
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Waiting_Point
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
        Me.Waiting_Point_IDlbl = New System.Windows.Forms.Label()
        Me.Waiting_Point_ID = New System.Windows.Forms.TextBox()
        Me.Waiting_Point_Namelbl = New System.Windows.Forms.Label()
        Me.Waiting_Point_Name = New System.Windows.Forms.TextBox()
        Me.Waiting_Point_Timelbl = New System.Windows.Forms.Label()
        Me.Waiting_Point_Time = New System.Windows.Forms.DateTimePicker()
        Me.Car_IDlbl = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnNewAdd = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.dgv_Tbl_Waiting_Point = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Txt_Search = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Car_ID = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_Tbl_Waiting_Point, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Waiting_Point_IDlbl
        '
        Me.Waiting_Point_IDlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Waiting_Point_IDlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Waiting_Point_IDlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Waiting_Point_IDlbl.ForeColor = System.Drawing.Color.White
        Me.Waiting_Point_IDlbl.Location = New System.Drawing.Point(518, 15)
        Me.Waiting_Point_IDlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Waiting_Point_IDlbl.Name = "Waiting_Point_IDlbl"
        Me.Waiting_Point_IDlbl.Size = New System.Drawing.Size(208, 34)
        Me.Waiting_Point_IDlbl.TabIndex = 0
        Me.Waiting_Point_IDlbl.Text = "كود نقطة التجمع"
        Me.Waiting_Point_IDlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Waiting_Point_IDlbl.Visible = False
        '
        'Waiting_Point_ID
        '
        Me.Waiting_Point_ID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Waiting_Point_ID.Location = New System.Drawing.Point(74, 15)
        Me.Waiting_Point_ID.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Waiting_Point_ID.Name = "Waiting_Point_ID"
        Me.Waiting_Point_ID.Size = New System.Drawing.Size(440, 34)
        Me.Waiting_Point_ID.TabIndex = 1
        Me.Waiting_Point_ID.Visible = False
        '
        'Waiting_Point_Namelbl
        '
        Me.Waiting_Point_Namelbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Waiting_Point_Namelbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Waiting_Point_Namelbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Waiting_Point_Namelbl.ForeColor = System.Drawing.Color.Black
        Me.Waiting_Point_Namelbl.Location = New System.Drawing.Point(518, 57)
        Me.Waiting_Point_Namelbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Waiting_Point_Namelbl.Name = "Waiting_Point_Namelbl"
        Me.Waiting_Point_Namelbl.Size = New System.Drawing.Size(208, 34)
        Me.Waiting_Point_Namelbl.TabIndex = 2
        Me.Waiting_Point_Namelbl.Text = "اسم نقطة التجمع"
        Me.Waiting_Point_Namelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Waiting_Point_Name
        '
        Me.Waiting_Point_Name.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Waiting_Point_Name.Location = New System.Drawing.Point(13, 57)
        Me.Waiting_Point_Name.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Waiting_Point_Name.Name = "Waiting_Point_Name"
        Me.Waiting_Point_Name.Size = New System.Drawing.Size(501, 34)
        Me.Waiting_Point_Name.TabIndex = 3
        '
        'Waiting_Point_Timelbl
        '
        Me.Waiting_Point_Timelbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Waiting_Point_Timelbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Waiting_Point_Timelbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Waiting_Point_Timelbl.ForeColor = System.Drawing.Color.Black
        Me.Waiting_Point_Timelbl.Location = New System.Drawing.Point(518, 97)
        Me.Waiting_Point_Timelbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Waiting_Point_Timelbl.Name = "Waiting_Point_Timelbl"
        Me.Waiting_Point_Timelbl.Size = New System.Drawing.Size(208, 34)
        Me.Waiting_Point_Timelbl.TabIndex = 4
        Me.Waiting_Point_Timelbl.Text = "وقت نقطة التجمع"
        Me.Waiting_Point_Timelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Waiting_Point_Time
        '
        Me.Waiting_Point_Time.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Waiting_Point_Time.Font = New System.Drawing.Font("Imprint MT Shadow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Waiting_Point_Time.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Waiting_Point_Time.Location = New System.Drawing.Point(13, 97)
        Me.Waiting_Point_Time.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Waiting_Point_Time.Name = "Waiting_Point_Time"
        Me.Waiting_Point_Time.Size = New System.Drawing.Size(501, 28)
        Me.Waiting_Point_Time.TabIndex = 5
        '
        'Car_IDlbl
        '
        Me.Car_IDlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Car_IDlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Car_IDlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Car_IDlbl.ForeColor = System.Drawing.Color.Black
        Me.Car_IDlbl.Location = New System.Drawing.Point(518, 136)
        Me.Car_IDlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Car_IDlbl.Name = "Car_IDlbl"
        Me.Car_IDlbl.Size = New System.Drawing.Size(208, 34)
        Me.Car_IDlbl.TabIndex = 6
        Me.Car_IDlbl.Text = "السيارة"
        Me.Car_IDlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BtnSave)
        Me.Panel1.Controls.Add(Me.BtnEdit)
        Me.Panel1.Controls.Add(Me.BtnNewAdd)
        Me.Panel1.Controls.Add(Me.BtnDelete)
        Me.Panel1.Controls.Add(Me.BtnClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 594)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(737, 74)
        Me.Panel1.TabIndex = 24
        '
        'BtnSave
        '
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Bold)
        Me.BtnSave.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Ok
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSave.Location = New System.Drawing.Point(460, 15)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnSave.Size = New System.Drawing.Size(117, 53)
        Me.BtnSave.TabIndex = 106
        Me.BtnSave.Text = "حفظ"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.FlatAppearance.BorderSize = 0
        Me.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEdit.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Bold)
        Me.BtnEdit.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Save_as
        Me.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEdit.Location = New System.Drawing.Point(311, 15)
        Me.BtnEdit.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(113, 53)
        Me.BtnEdit.TabIndex = 107
        Me.BtnEdit.Text = "تعديل"
        Me.BtnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnNewAdd
        '
        Me.BtnNewAdd.FlatAppearance.BorderSize = 0
        Me.BtnNewAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNewAdd.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Bold)
        Me.BtnNewAdd.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Add
        Me.BtnNewAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNewAdd.Location = New System.Drawing.Point(613, 15)
        Me.BtnNewAdd.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.BtnNewAdd.Name = "BtnNewAdd"
        Me.BtnNewAdd.Size = New System.Drawing.Size(117, 53)
        Me.BtnNewAdd.TabIndex = 105
        Me.BtnNewAdd.Text = "جديد"
        Me.BtnNewAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNewAdd.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.FlatAppearance.BorderSize = 0
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Bold)
        Me.BtnDelete.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Remove
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.Location = New System.Drawing.Point(162, 15)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(113, 53)
        Me.BtnDelete.TabIndex = 108
        Me.BtnDelete.Text = "حذف"
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Bold)
        Me.BtnClose.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Cancel
        Me.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnClose.Location = New System.Drawing.Point(13, 15)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(113, 53)
        Me.BtnClose.TabIndex = 109
        Me.BtnClose.Text = "انهاء"
        Me.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'dgv_Tbl_Waiting_Point
        '
        Me.dgv_Tbl_Waiting_Point.AllowUserToAddRows = False
        Me.dgv_Tbl_Waiting_Point.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv_Tbl_Waiting_Point.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Tbl_Waiting_Point.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_Tbl_Waiting_Point.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Tbl_Waiting_Point.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_Tbl_Waiting_Point.ColumnHeadersHeight = 40
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Tbl_Waiting_Point.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_Tbl_Waiting_Point.EnableHeadersVisualStyles = False
        Me.dgv_Tbl_Waiting_Point.Location = New System.Drawing.Point(13, 226)
        Me.dgv_Tbl_Waiting_Point.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.dgv_Tbl_Waiting_Point.Name = "dgv_Tbl_Waiting_Point"
        Me.dgv_Tbl_Waiting_Point.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Tbl_Waiting_Point.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_Tbl_Waiting_Point.RowHeadersVisible = False
        Me.dgv_Tbl_Waiting_Point.RowHeadersWidth = 51
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_Tbl_Waiting_Point.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_Tbl_Waiting_Point.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Tbl_Waiting_Point.Size = New System.Drawing.Size(713, 353)
        Me.dgv_Tbl_Waiting_Point.TabIndex = 100
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(737, 57)
        Me.Panel2.TabIndex = 101
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Cancel
        Me.PictureBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PictureBox2.Location = New System.Drawing.Point(687, 4)
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
        Me.Label1.Font = New System.Drawing.Font("Cairo", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(737, 57)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "اضافة نقطة تجمع جديدة"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Txt_Search)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Car_ID)
        Me.Panel3.Controls.Add(Me.dgv_Tbl_Waiting_Point)
        Me.Panel3.Controls.Add(Me.Waiting_Point_IDlbl)
        Me.Panel3.Controls.Add(Me.Car_IDlbl)
        Me.Panel3.Controls.Add(Me.Waiting_Point_ID)
        Me.Panel3.Controls.Add(Me.Waiting_Point_Time)
        Me.Panel3.Controls.Add(Me.Waiting_Point_Namelbl)
        Me.Panel3.Controls.Add(Me.Waiting_Point_Timelbl)
        Me.Panel3.Controls.Add(Me.Waiting_Point_Name)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(737, 594)
        Me.Panel3.TabIndex = 102
        '
        'Txt_Search
        '
        Me.Txt_Search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_Search.Location = New System.Drawing.Point(13, 182)
        Me.Txt_Search.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Txt_Search.Name = "Txt_Search"
        Me.Txt_Search.Size = New System.Drawing.Size(501, 34)
        Me.Txt_Search.TabIndex = 102
        Me.Txt_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(520, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 34)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "ابحث هنا"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Car_ID
        '
        Me.Car_ID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Car_ID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Car_ID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Car_ID.FormattingEnabled = True
        Me.Car_ID.Location = New System.Drawing.Point(13, 135)
        Me.Car_ID.Name = "Car_ID"
        Me.Car_ID.Size = New System.Drawing.Size(501, 35)
        Me.Car_ID.TabIndex = 101
        '
        'Frm_Waiting_Point
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 668)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2, 5, 2, 5)
        Me.MaximizeBox = False
        Me.Name = "Frm_Waiting_Point"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgv_Tbl_Waiting_Point, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Waiting_Point_ID As System.Windows.Forms.TextBox
    Friend WithEvents Waiting_Point_IDlbl As System.Windows.Forms.Label
    Friend WithEvents Waiting_Point_Name As System.Windows.Forms.TextBox
    Friend WithEvents Waiting_Point_Namelbl As System.Windows.Forms.Label
    Friend WithEvents Waiting_Point_Time As System.Windows.Forms.DateTimePicker
    Friend WithEvents Waiting_Point_Timelbl As System.Windows.Forms.Label
    'Friend WithEvents Car_ID As System.Windows.Forms.TextBox
    Friend WithEvents Car_IDlbl As System.Windows.Forms.Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnNewAdd As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents dgv_Tbl_Waiting_Point As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Car_ID As ComboBox
    Friend WithEvents Txt_Search As TextBox
    Friend WithEvents Label2 As Label
    'Friend WithEvents BunifuThinButton21 As Bunifu.Framework.UI.BunifuThinButton2
    'Friend WithEvents BunifuLabel1 As BunifuLabel
End Class
