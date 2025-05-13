<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Notes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Notes))
        Me.Note_IDlbl = New System.Windows.Forms.Label()
        Me.Note_ID = New System.Windows.Forms.TextBox()
        Me.Note_Infolbl = New System.Windows.Forms.Label()
        Me.Machine_Notelbl = New System.Windows.Forms.Label()
        Me.Machine_Note = New System.Windows.Forms.TextBox()
        Me.Note_Datelbl = New System.Windows.Forms.Label()
        Me.Note_Date = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBoxClose = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.Note_Info = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_Reply = New System.Windows.Forms.RichTextBox()
        Me.Reply_Date = New System.Windows.Forms.DateTimePicker()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Machine_Name = New System.Windows.Forms.TextBox()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnHide = New System.Windows.Forms.Button()
        Me.BtnSave1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Note_IDlbl
        '
        Me.Note_IDlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Note_IDlbl.Font = New System.Drawing.Font("Questv1", 7.8!)
        Me.Note_IDlbl.Location = New System.Drawing.Point(194, 17)
        Me.Note_IDlbl.Name = "Note_IDlbl"
        Me.Note_IDlbl.Size = New System.Drawing.Size(83, 27)
        Me.Note_IDlbl.TabIndex = 0
        Me.Note_IDlbl.Text = "Note_ID"
        Me.Note_IDlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Note_IDlbl.Visible = False
        '
        'Note_ID
        '
        Me.Note_ID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Note_ID.Font = New System.Drawing.Font("Questv1", 7.8!)
        Me.Note_ID.Location = New System.Drawing.Point(83, 17)
        Me.Note_ID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Note_ID.Name = "Note_ID"
        Me.Note_ID.Size = New System.Drawing.Size(104, 29)
        Me.Note_ID.TabIndex = 1
        Me.Note_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Note_ID.Visible = False
        '
        'Note_Infolbl
        '
        Me.Note_Infolbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Note_Infolbl.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Note_Infolbl.Location = New System.Drawing.Point(749, 60)
        Me.Note_Infolbl.Name = "Note_Infolbl"
        Me.Note_Infolbl.Size = New System.Drawing.Size(135, 112)
        Me.Note_Infolbl.TabIndex = 2
        Me.Note_Infolbl.Text = "الملاحظة"
        Me.Note_Infolbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Machine_Notelbl
        '
        Me.Machine_Notelbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Machine_Notelbl.Font = New System.Drawing.Font("Questv1", 7.8!)
        Me.Machine_Notelbl.Location = New System.Drawing.Point(393, 17)
        Me.Machine_Notelbl.Name = "Machine_Notelbl"
        Me.Machine_Notelbl.Size = New System.Drawing.Size(104, 27)
        Me.Machine_Notelbl.TabIndex = 4
        Me.Machine_Notelbl.Text = "Machine_Note"
        Me.Machine_Notelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Machine_Notelbl.Visible = False
        '
        'Machine_Note
        '
        Me.Machine_Note.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Machine_Note.Font = New System.Drawing.Font("Questv1", 7.8!)
        Me.Machine_Note.Location = New System.Drawing.Point(283, 17)
        Me.Machine_Note.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Machine_Note.Name = "Machine_Note"
        Me.Machine_Note.Size = New System.Drawing.Size(104, 29)
        Me.Machine_Note.TabIndex = 5
        Me.Machine_Note.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Machine_Note.Visible = False
        '
        'Note_Datelbl
        '
        Me.Note_Datelbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Note_Datelbl.Font = New System.Drawing.Font("Questv1", 7.8!)
        Me.Note_Datelbl.Location = New System.Drawing.Point(694, 17)
        Me.Note_Datelbl.Name = "Note_Datelbl"
        Me.Note_Datelbl.Size = New System.Drawing.Size(104, 27)
        Me.Note_Datelbl.TabIndex = 6
        Me.Note_Datelbl.Text = "Note_Date"
        Me.Note_Datelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Note_Datelbl.Visible = False
        '
        'Note_Date
        '
        Me.Note_Date.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Note_Date.Font = New System.Drawing.Font("Questv1", 7.8!)
        Me.Note_Date.Location = New System.Drawing.Point(584, 17)
        Me.Note_Date.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Note_Date.Name = "Note_Date"
        Me.Note_Date.Size = New System.Drawing.Size(104, 29)
        Me.Note_Date.TabIndex = 7
        Me.Note_Date.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.PictureBoxClose)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1029, 51)
        Me.Panel1.TabIndex = 85
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(2701, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 85
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3216, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'PictureBoxClose
        '
        Me.PictureBoxClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxClose.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxClose.Image = CType(resources.GetObject("PictureBoxClose.Image"), System.Drawing.Image)
        Me.PictureBoxClose.Location = New System.Drawing.Point(4303, 12)
        Me.PictureBoxClose.Name = "PictureBoxClose"
        Me.PictureBoxClose.Size = New System.Drawing.Size(48, 48)
        Me.PictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBoxClose.TabIndex = 36
        Me.PictureBoxClose.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Cairo", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1029, 51)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "اضافة ملاحظة"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.PictureBox4)
        Me.Panel2.Controls.Add(Me.PictureBox5)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 356)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1029, 41)
        Me.Panel2.TabIndex = 86
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(3565, 3)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 85
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(4080, 6)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 37
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(5167, 12)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox5.TabIndex = 36
        Me.PictureBox5.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Panel3.Controls.Add(Me.PictureBox6)
        Me.Panel3.Controls.Add(Me.PictureBox7)
        Me.Panel3.Controls.Add(Me.PictureBox8)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 51)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(66, 305)
        Me.Panel3.TabIndex = 89
        '
        'PictureBox6
        '
        Me.PictureBox6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(3430, 3)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 85
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(3945, 6)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 37
        Me.PictureBox7.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox8.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(5032, 12)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox8.TabIndex = 36
        Me.PictureBox8.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Panel4.Controls.Add(Me.PictureBox9)
        Me.Panel4.Controls.Add(Me.PictureBox10)
        Me.Panel4.Controls.Add(Me.PictureBox11)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(963, 51)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(66, 305)
        Me.Panel4.TabIndex = 90
        '
        'PictureBox9
        '
        Me.PictureBox9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox9.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox9.Image = CType(resources.GetObject("PictureBox9.Image"), System.Drawing.Image)
        Me.PictureBox9.Location = New System.Drawing.Point(3296, 3)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox9.TabIndex = 85
        Me.PictureBox9.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox10.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox10.Image = CType(resources.GetObject("PictureBox10.Image"), System.Drawing.Image)
        Me.PictureBox10.Location = New System.Drawing.Point(3811, 6)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox10.TabIndex = 37
        Me.PictureBox10.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox11.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), System.Drawing.Image)
        Me.PictureBox11.Location = New System.Drawing.Point(4898, 12)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox11.TabIndex = 36
        Me.PictureBox11.TabStop = False
        '
        'Note_Info
        '
        Me.Note_Info.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Note_Info.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!)
        Me.Note_Info.Location = New System.Drawing.Point(135, 60)
        Me.Note_Info.Name = "Note_Info"
        Me.Note_Info.Size = New System.Drawing.Size(616, 112)
        Me.Note_Info.TabIndex = 92
        Me.Note_Info.Text = ""
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(756, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 113)
        Me.Label2.TabIndex = 93
        Me.Label2.Text = "الرد"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label2.Visible = False
        '
        'Txt_Reply
        '
        Me.Txt_Reply.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Txt_Reply.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!)
        Me.Txt_Reply.Location = New System.Drawing.Point(135, 178)
        Me.Txt_Reply.Name = "Txt_Reply"
        Me.Txt_Reply.Size = New System.Drawing.Size(616, 113)
        Me.Txt_Reply.TabIndex = 92
        Me.Txt_Reply.Text = ""
        Me.Txt_Reply.Visible = False
        '
        'Reply_Date
        '
        Me.Reply_Date.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Reply_Date.Font = New System.Drawing.Font("Questv1", 7.8!)
        Me.Reply_Date.Location = New System.Drawing.Point(787, 17)
        Me.Reply_Date.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Reply_Date.Name = "Reply_Date"
        Me.Reply_Date.Size = New System.Drawing.Size(104, 29)
        Me.Reply_Date.TabIndex = 7
        Me.Reply_Date.Visible = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Machine_Name)
        Me.Panel5.Controls.Add(Me.Txt_Reply)
        Me.Panel5.Controls.Add(Me.Note_Info)
        Me.Panel5.Controls.Add(Me.Reply_Date)
        Me.Panel5.Controls.Add(Me.Note_IDlbl)
        Me.Panel5.Controls.Add(Me.BtnEdit)
        Me.Panel5.Controls.Add(Me.Note_Date)
        Me.Panel5.Controls.Add(Me.BtnClose)
        Me.Panel5.Controls.Add(Me.Note_Datelbl)
        Me.Panel5.Controls.Add(Me.BtnHide)
        Me.Panel5.Controls.Add(Me.BtnSave1)
        Me.Panel5.Controls.Add(Me.Machine_Note)
        Me.Panel5.Controls.Add(Me.Machine_Notelbl)
        Me.Panel5.Controls.Add(Me.Note_ID)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.Note_Infolbl)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(66, 51)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(897, 305)
        Me.Panel5.TabIndex = 95
        '
        'Machine_Name
        '
        Me.Machine_Name.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Machine_Name.Font = New System.Drawing.Font("Questv1", 7.8!)
        Me.Machine_Name.Location = New System.Drawing.Point(-25, 17)
        Me.Machine_Name.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Machine_Name.Name = "Machine_Name"
        Me.Machine_Name.Size = New System.Drawing.Size(104, 29)
        Me.Machine_Name.TabIndex = 95
        Me.Machine_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Machine_Name.Visible = False
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnEdit.Font = New System.Drawing.Font("Cairo", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Reply
        Me.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEdit.Location = New System.Drawing.Point(8, 119)
        Me.BtnEdit.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnEdit.Size = New System.Drawing.Size(119, 53)
        Me.BtnEdit.TabIndex = 94
        Me.BtnEdit.Text = "الرد"
        Me.BtnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEdit.UseVisualStyleBackColor = False
        Me.BtnEdit.Visible = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.Red
        Me.BtnClose.Font = New System.Drawing.Font("Cairo", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Cancel
        Me.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnClose.Location = New System.Drawing.Point(8, 237)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(119, 53)
        Me.BtnClose.TabIndex = 88
        Me.BtnClose.Text = "انهاء"
        Me.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnHide
        '
        Me.BtnHide.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BtnHide.Font = New System.Drawing.Font("Cairo", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHide.Image = Global.El_Dawliya_International_System.My.Resources.Resources.hide_48px
        Me.BtnHide.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHide.Location = New System.Drawing.Point(8, 178)
        Me.BtnHide.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.BtnHide.Name = "BtnHide"
        Me.BtnHide.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnHide.Size = New System.Drawing.Size(119, 53)
        Me.BtnHide.TabIndex = 87
        Me.BtnHide.Text = "اخفاء"
        Me.BtnHide.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnHide.UseVisualStyleBackColor = False
        Me.BtnHide.Visible = False
        '
        'BtnSave1
        '
        Me.BtnSave1.BackColor = System.Drawing.Color.SpringGreen
        Me.BtnSave1.Font = New System.Drawing.Font("Cairo", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave1.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Save
        Me.BtnSave1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave1.Location = New System.Drawing.Point(8, 60)
        Me.BtnSave1.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.BtnSave1.Name = "BtnSave1"
        Me.BtnSave1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnSave1.Size = New System.Drawing.Size(119, 53)
        Me.BtnSave1.TabIndex = 87
        Me.BtnSave1.Text = "حفظ"
        Me.BtnSave1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSave1.UseVisualStyleBackColor = False
        '
        'Frm_Notes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1029, 397)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Questv1", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Frm_Notes"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Note_ID As System.Windows.Forms.TextBox
    Friend WithEvents Note_IDlbl As System.Windows.Forms.Label
    'Friend WithEvents Note_Info As System.Windows.Forms.TextBox
    Friend WithEvents Note_Infolbl As System.Windows.Forms.Label
    Friend WithEvents Machine_Note As System.Windows.Forms.TextBox
    Friend WithEvents Machine_Notelbl As System.Windows.Forms.Label
    Friend WithEvents Note_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Note_Datelbl As System.Windows.Forms.Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBoxClose As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents BtnSave1 As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents Note_Info As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_Reply As RichTextBox
    Friend WithEvents BtnEdit As Button
    Friend WithEvents Reply_Date As DateTimePicker
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Machine_Name As TextBox
    Friend WithEvents BtnHide As Button

End Class
