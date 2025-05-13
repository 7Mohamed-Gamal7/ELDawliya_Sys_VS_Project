<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Add_Tool
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Add_Tool))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgv_Tbl_Tool_Name = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBoxClose = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Txt_Search = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnNewAdd = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.Tool_Name = New System.Windows.Forms.TextBox()
        Me.Tool_ID = New System.Windows.Forms.TextBox()
        Me.Frm_IDlbl = New System.Windows.Forms.Label()
        Me.Tool_Namelbl = New System.Windows.Forms.Label()
        Me.Frm_ID_lbl = New System.Windows.Forms.Label()
        Me.Frm_ID = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgv_Tbl_Tool_Name, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(436, 208)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 36)
        Me.Label2.TabIndex = 111
        Me.Label2.Text = "ابحث هنا"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgv_Tbl_Tool_Name
        '
        Me.dgv_Tbl_Tool_Name.AllowUserToAddRows = False
        Me.dgv_Tbl_Tool_Name.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Cairo", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv_Tbl_Tool_Name.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Tbl_Tool_Name.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_Tbl_Tool_Name.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Tbl_Tool_Name.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_Tbl_Tool_Name.ColumnHeadersHeight = 40
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Tbl_Tool_Name.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_Tbl_Tool_Name.EnableHeadersVisualStyles = False
        Me.dgv_Tbl_Tool_Name.Location = New System.Drawing.Point(14, 262)
        Me.dgv_Tbl_Tool_Name.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.dgv_Tbl_Tool_Name.Name = "dgv_Tbl_Tool_Name"
        Me.dgv_Tbl_Tool_Name.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Tbl_Tool_Name.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_Tbl_Tool_Name.RowHeadersVisible = False
        Me.dgv_Tbl_Tool_Name.RowHeadersWidth = 51
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Cairo SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_Tbl_Tool_Name.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_Tbl_Tool_Name.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Tbl_Tool_Name.Size = New System.Drawing.Size(577, 233)
        Me.dgv_Tbl_Tool_Name.TabIndex = 110
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(539, 4)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(52, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'PictureBoxClose
        '
        Me.PictureBoxClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxClose.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxClose.Image = CType(resources.GetObject("PictureBoxClose.Image"), System.Drawing.Image)
        Me.PictureBoxClose.Location = New System.Drawing.Point(3016, 20)
        Me.PictureBoxClose.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.PictureBoxClose.Name = "PictureBoxClose"
        Me.PictureBoxClose.Size = New System.Drawing.Size(71, 104)
        Me.PictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxClose.TabIndex = 36
        Me.PictureBoxClose.TabStop = False
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Cairo", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(604, 45)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "اضافة اداة جديدة"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(3603, 20)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(71, 104)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 36
        Me.PictureBox3.TabStop = False
        '
        'Txt_Search
        '
        Me.Txt_Search.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_Search.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Txt_Search.Location = New System.Drawing.Point(12, 212)
        Me.Txt_Search.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.Txt_Search.Name = "Txt_Search"
        Me.Txt_Search.Size = New System.Drawing.Size(416, 36)
        Me.Txt_Search.TabIndex = 112
        Me.Txt_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.PictureBoxClose)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(604, 51)
        Me.Panel1.TabIndex = 109
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.BtnNewAdd)
        Me.Panel2.Controls.Add(Me.BtnSave)
        Me.Panel2.Controls.Add(Me.BtnEdit)
        Me.Panel2.Controls.Add(Me.BtnDelete)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 502)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(604, 66)
        Me.Panel2.TabIndex = 108
        '
        'BtnNewAdd
        '
        Me.BtnNewAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BtnNewAdd.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Bold)
        Me.BtnNewAdd.ForeColor = System.Drawing.Color.White
        Me.BtnNewAdd.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Add
        Me.BtnNewAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNewAdd.Location = New System.Drawing.Point(488, 7)
        Me.BtnNewAdd.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.BtnNewAdd.Name = "BtnNewAdd"
        Me.BtnNewAdd.Size = New System.Drawing.Size(102, 53)
        Me.BtnNewAdd.TabIndex = 103
        Me.BtnNewAdd.Text = "جديد"
        Me.BtnNewAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNewAdd.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BtnSave.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Bold)
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Save
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSave.Location = New System.Drawing.Point(330, 7)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnSave.Size = New System.Drawing.Size(102, 53)
        Me.BtnSave.TabIndex = 104
        Me.BtnSave.Text = "حفظ"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BtnEdit.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Bold)
        Me.BtnEdit.ForeColor = System.Drawing.Color.White
        Me.BtnEdit.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Pencil
        Me.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEdit.Location = New System.Drawing.Point(172, 7)
        Me.BtnEdit.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(102, 53)
        Me.BtnEdit.TabIndex = 105
        Me.BtnEdit.Text = "تعديل"
        Me.BtnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BtnDelete.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Bold)
        Me.BtnDelete.ForeColor = System.Drawing.Color.White
        Me.BtnDelete.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Remove
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.Location = New System.Drawing.Point(14, 7)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(102, 53)
        Me.BtnDelete.TabIndex = 106
        Me.BtnDelete.Text = "حذف"
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'Tool_Name
        '
        Me.Tool_Name.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tool_Name.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Tool_Name.Location = New System.Drawing.Point(11, 118)
        Me.Tool_Name.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.Tool_Name.Name = "Tool_Name"
        Me.Tool_Name.Size = New System.Drawing.Size(417, 36)
        Me.Tool_Name.TabIndex = 102
        Me.Tool_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Tool_ID
        '
        Me.Tool_ID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tool_ID.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Tool_ID.Location = New System.Drawing.Point(11, 75)
        Me.Tool_ID.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.Tool_ID.Name = "Tool_ID"
        Me.Tool_ID.ReadOnly = True
        Me.Tool_ID.Size = New System.Drawing.Size(417, 36)
        Me.Tool_ID.TabIndex = 101
        Me.Tool_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Frm_IDlbl
        '
        Me.Frm_IDlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Frm_IDlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Frm_IDlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Frm_IDlbl.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Frm_IDlbl.ForeColor = System.Drawing.Color.White
        Me.Frm_IDlbl.Location = New System.Drawing.Point(436, 71)
        Me.Frm_IDlbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Frm_IDlbl.Name = "Frm_IDlbl"
        Me.Frm_IDlbl.Size = New System.Drawing.Size(155, 36)
        Me.Frm_IDlbl.TabIndex = 99
        Me.Frm_IDlbl.Text = "كود الاداة"
        Me.Frm_IDlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tool_Namelbl
        '
        Me.Tool_Namelbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tool_Namelbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Tool_Namelbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Tool_Namelbl.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Tool_Namelbl.ForeColor = System.Drawing.Color.White
        Me.Tool_Namelbl.Location = New System.Drawing.Point(436, 114)
        Me.Tool_Namelbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Tool_Namelbl.Name = "Tool_Namelbl"
        Me.Tool_Namelbl.Size = New System.Drawing.Size(155, 36)
        Me.Tool_Namelbl.TabIndex = 100
        Me.Tool_Namelbl.Text = "اسم الاداة"
        Me.Tool_Namelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Frm_ID_lbl
        '
        Me.Frm_ID_lbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Frm_ID_lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Frm_ID_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Frm_ID_lbl.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Frm_ID_lbl.ForeColor = System.Drawing.Color.White
        Me.Frm_ID_lbl.Location = New System.Drawing.Point(436, 163)
        Me.Frm_ID_lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Frm_ID_lbl.Name = "Frm_ID_lbl"
        Me.Frm_ID_lbl.Size = New System.Drawing.Size(155, 36)
        Me.Frm_ID_lbl.TabIndex = 113
        Me.Frm_ID_lbl.Text = "اسم الشاشة"
        Me.Frm_ID_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Frm_ID
        '
        Me.Frm_ID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Frm_ID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.Frm_ID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Frm_ID.Font = New System.Drawing.Font("Cairo SemiBold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frm_ID.FormattingEnabled = True
        Me.Frm_ID.Items.AddRange(New Object() {"D1", "D2", "F1", "F2", "H1"})
        Me.Frm_ID.Location = New System.Drawing.Point(158, 159)
        Me.Frm_ID.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Frm_ID.Name = "Frm_ID"
        Me.Frm_ID.Size = New System.Drawing.Size(270, 42)
        Me.Frm_ID.TabIndex = 114
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Hacen Saudi Arabia", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(11, 161)
        Me.Button1.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 42)
        Me.Button1.TabIndex = 115
        Me.Button1.Text = "اضف شاشة  ..."
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Frm_Add_Tool
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(604, 568)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Frm_ID)
        Me.Controls.Add(Me.Frm_ID_lbl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgv_Tbl_Tool_Name)
        Me.Controls.Add(Me.Txt_Search)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Tool_Name)
        Me.Controls.Add(Me.Tool_ID)
        Me.Controls.Add(Me.Frm_IDlbl)
        Me.Controls.Add(Me.Tool_Namelbl)
        Me.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "Frm_Add_Tool"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "اضافة اداة جديدة"
        CType(Me.dgv_Tbl_Tool_Name, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents dgv_Tbl_Tool_Name As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBoxClose As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Txt_Search As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnNewAdd As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents Tool_Name As TextBox
    Friend WithEvents Tool_ID As TextBox
    Friend WithEvents Frm_IDlbl As Label
    Friend WithEvents Tool_Namelbl As Label
    Friend WithEvents Frm_ID_lbl As Label
    Friend WithEvents Frm_ID As ComboBox
    Friend WithEvents Button1 As Button
End Class
