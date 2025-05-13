<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Add_Employee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Add_Employee))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Emp_Full_Namelbl = New System.Windows.Forms.Label()
        Me.Emp_Full_Name = New System.Windows.Forms.TextBox()
        Me.Emp_IDlbl = New System.Windows.Forms.Label()
        Me.Emp_ID = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Place_Birthlbl = New System.Windows.Forms.Label()
        Me.Place_Birth = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Emp_Image = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Emp_Carlbl = New System.Windows.Forms.Label()
        Me.Car_Ride_Timelbl = New System.Windows.Forms.Label()
        Me.Car_Ride_Time = New System.Windows.Forms.DateTimePicker()
        Me.Emp_Car = New System.Windows.Forms.ComboBox()
        Me.Car_Pick_Up_Pointlbl = New System.Windows.Forms.Label()
        Me.Car_Pick_Up_Point = New System.Windows.Forms.ComboBox()
        Me.Dept_Codelbl = New System.Windows.Forms.Label()
        Me.Dept_Code = New System.Windows.Forms.ComboBox()
        Me.Jop_Codelbl = New System.Windows.Forms.Label()
        Me.Jop_Code = New System.Windows.Forms.ComboBox()
        Me.Emp_Date_Hiringlbl = New System.Windows.Forms.Label()
        Me.Emp_Date_Hiring = New System.Windows.Forms.DateTimePicker()
        Me.Emp_Phone1lbl = New System.Windows.Forms.Label()
        Me.Emp_Phone1 = New System.Windows.Forms.TextBox()
        Me.Emp_Addresslbl = New System.Windows.Forms.Label()
        Me.Emp_Address = New System.Windows.Forms.TextBox()
        Me.Emp_Marital_Statuslbl = New System.Windows.Forms.Label()
        Me.Emp_Marital_Status = New System.Windows.Forms.ComboBox()
        Me.Emp_Nationalitylbl = New System.Windows.Forms.Label()
        Me.Emp_Nationality = New System.Windows.Forms.ComboBox()
        Me.National_IDlbl = New System.Windows.Forms.Label()
        Me.National_ID = New System.Windows.Forms.TextBox()
        Me.Date_Birthlbl = New System.Windows.Forms.Label()
        Me.Date_Birth = New System.Windows.Forms.DateTimePicker()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.Emp_Image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.BtnSave)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 537)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(954, 60)
        Me.Panel1.TabIndex = 110
        '
        'BtnSave
        '
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Bold)
        Me.BtnSave.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Ok
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSave.Location = New System.Drawing.Point(398, 8)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(4, 8, 4, 8)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnSave.Size = New System.Drawing.Size(127, 44)
        Me.BtnSave.TabIndex = 106
        Me.BtnSave.Text = "حفظ"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(954, 52)
        Me.Panel2.TabIndex = 111
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.Teal
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(897, 5)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(42, 48)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 110
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Teal
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Cairo", 13.8!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(954, 53)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "اضافة موظف جديد"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Emp_Full_Namelbl
        '
        Me.Emp_Full_Namelbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Emp_Full_Namelbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Emp_Full_Namelbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Emp_Full_Namelbl.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Emp_Full_Namelbl.ForeColor = System.Drawing.Color.Black
        Me.Emp_Full_Namelbl.Location = New System.Drawing.Point(773, 56)
        Me.Emp_Full_Namelbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Emp_Full_Namelbl.Name = "Emp_Full_Namelbl"
        Me.Emp_Full_Namelbl.Size = New System.Drawing.Size(166, 32)
        Me.Emp_Full_Namelbl.TabIndex = 121
        Me.Emp_Full_Namelbl.Text = "اسم الموظف"
        Me.Emp_Full_Namelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Emp_Full_Name
        '
        Me.Emp_Full_Name.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Emp_Full_Name.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!)
        Me.Emp_Full_Name.Location = New System.Drawing.Point(463, 56)
        Me.Emp_Full_Name.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Emp_Full_Name.Name = "Emp_Full_Name"
        Me.Emp_Full_Name.Size = New System.Drawing.Size(304, 34)
        Me.Emp_Full_Name.TabIndex = 2
        Me.Emp_Full_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Emp_IDlbl
        '
        Me.Emp_IDlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Emp_IDlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Emp_IDlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Emp_IDlbl.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Emp_IDlbl.ForeColor = System.Drawing.Color.Black
        Me.Emp_IDlbl.Location = New System.Drawing.Point(773, 13)
        Me.Emp_IDlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Emp_IDlbl.Name = "Emp_IDlbl"
        Me.Emp_IDlbl.Size = New System.Drawing.Size(166, 32)
        Me.Emp_IDlbl.TabIndex = 119
        Me.Emp_IDlbl.Text = "كود الموظف"
        Me.Emp_IDlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Emp_ID
        '
        Me.Emp_ID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Emp_ID.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!)
        Me.Emp_ID.Location = New System.Drawing.Point(463, 13)
        Me.Emp_ID.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Emp_ID.Name = "Emp_ID"
        Me.Emp_ID.Size = New System.Drawing.Size(304, 34)
        Me.Emp_ID.TabIndex = 1
        Me.Emp_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Teal
        Me.Panel3.Controls.Add(Me.Place_Birthlbl)
        Me.Panel3.Controls.Add(Me.Place_Birth)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Emp_Image)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Controls.Add(Me.Dept_Codelbl)
        Me.Panel3.Controls.Add(Me.Dept_Code)
        Me.Panel3.Controls.Add(Me.Jop_Codelbl)
        Me.Panel3.Controls.Add(Me.Jop_Code)
        Me.Panel3.Controls.Add(Me.Emp_Date_Hiringlbl)
        Me.Panel3.Controls.Add(Me.Emp_Date_Hiring)
        Me.Panel3.Controls.Add(Me.Emp_Phone1lbl)
        Me.Panel3.Controls.Add(Me.Emp_Phone1)
        Me.Panel3.Controls.Add(Me.Emp_Addresslbl)
        Me.Panel3.Controls.Add(Me.Emp_Address)
        Me.Panel3.Controls.Add(Me.Emp_Marital_Statuslbl)
        Me.Panel3.Controls.Add(Me.Emp_Marital_Status)
        Me.Panel3.Controls.Add(Me.Emp_Nationalitylbl)
        Me.Panel3.Controls.Add(Me.Emp_Nationality)
        Me.Panel3.Controls.Add(Me.National_IDlbl)
        Me.Panel3.Controls.Add(Me.National_ID)
        Me.Panel3.Controls.Add(Me.Date_Birthlbl)
        Me.Panel3.Controls.Add(Me.Date_Birth)
        Me.Panel3.Controls.Add(Me.Emp_IDlbl)
        Me.Panel3.Controls.Add(Me.Emp_Full_Namelbl)
        Me.Panel3.Controls.Add(Me.Emp_ID)
        Me.Panel3.Controls.Add(Me.Emp_Full_Name)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 52)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(954, 485)
        Me.Panel3.TabIndex = 123
        '
        'Place_Birthlbl
        '
        Me.Place_Birthlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Place_Birthlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Place_Birthlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Place_Birthlbl.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Place_Birthlbl.ForeColor = System.Drawing.Color.Black
        Me.Place_Birthlbl.Location = New System.Drawing.Point(773, 196)
        Me.Place_Birthlbl.Name = "Place_Birthlbl"
        Me.Place_Birthlbl.Size = New System.Drawing.Size(166, 32)
        Me.Place_Birthlbl.TabIndex = 150
        Me.Place_Birthlbl.Text = "مكان الميلاد"
        Me.Place_Birthlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Place_Birth
        '
        Me.Place_Birth.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Place_Birth.Location = New System.Drawing.Point(462, 196)
        Me.Place_Birth.Name = "Place_Birth"
        Me.Place_Birth.Size = New System.Drawing.Size(305, 34)
        Me.Place_Birth.TabIndex = 6
        Me.Place_Birth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(50, 285)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(234, 35)
        Me.Label2.TabIndex = 149
        Me.Label2.Text = "صورة الموظف"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Emp_Image
        '
        Me.Emp_Image.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Emp_Image.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Emp_Image.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Emp_Image.Image = Global.El_Dawliya_International_System.My.Resources.Resources.icons8_add_image_96
        Me.Emp_Image.Location = New System.Drawing.Point(50, 333)
        Me.Emp_Image.Name = "Emp_Image"
        Me.Emp_Image.Size = New System.Drawing.Size(234, 116)
        Me.Emp_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Emp_Image.TabIndex = 148
        Me.Emp_Image.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Emp_Carlbl)
        Me.GroupBox1.Controls.Add(Me.Car_Ride_Timelbl)
        Me.GroupBox1.Controls.Add(Me.Car_Ride_Time)
        Me.GroupBox1.Controls.Add(Me.Emp_Car)
        Me.GroupBox1.Controls.Add(Me.Car_Pick_Up_Pointlbl)
        Me.GroupBox1.Controls.Add(Me.Car_Pick_Up_Point)
        Me.GroupBox1.Location = New System.Drawing.Point(461, 285)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(476, 179)
        Me.GroupBox1.TabIndex = 147
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "بيانات السيارة"
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Hacen Saudi Arabia", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Image = Global.El_Dawliya_International_System.My.Resources.Resources.add_24px
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.Location = New System.Drawing.Point(318, 134)
        Me.Button3.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(57, 27)
        Me.Button3.TabIndex = 153
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Hacen Saudi Arabia", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Image = Global.El_Dawliya_International_System.My.Resources.Resources.add_24px
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.Location = New System.Drawing.Point(318, 40)
        Me.Button4.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(67, 27)
        Me.Button4.TabIndex = 154
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Emp_Carlbl
        '
        Me.Emp_Carlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Emp_Carlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Emp_Carlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Emp_Carlbl.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Emp_Carlbl.ForeColor = System.Drawing.Color.Black
        Me.Emp_Carlbl.Location = New System.Drawing.Point(314, 35)
        Me.Emp_Carlbl.Name = "Emp_Carlbl"
        Me.Emp_Carlbl.Size = New System.Drawing.Size(157, 35)
        Me.Emp_Carlbl.TabIndex = 141
        Me.Emp_Carlbl.Text = "السيارة"
        Me.Emp_Carlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Car_Ride_Timelbl
        '
        Me.Car_Ride_Timelbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Car_Ride_Timelbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Car_Ride_Timelbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Car_Ride_Timelbl.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Car_Ride_Timelbl.ForeColor = System.Drawing.Color.Black
        Me.Car_Ride_Timelbl.Location = New System.Drawing.Point(314, 82)
        Me.Car_Ride_Timelbl.Name = "Car_Ride_Timelbl"
        Me.Car_Ride_Timelbl.Size = New System.Drawing.Size(157, 39)
        Me.Car_Ride_Timelbl.TabIndex = 143
        Me.Car_Ride_Timelbl.Text = "وقت السيارة"
        Me.Car_Ride_Timelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Car_Ride_Time
        '
        Me.Car_Ride_Time.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Car_Ride_Time.CalendarFont = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Car_Ride_Time.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Car_Ride_Time.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Car_Ride_Time.Location = New System.Drawing.Point(6, 83)
        Me.Car_Ride_Time.Name = "Car_Ride_Time"
        Me.Car_Ride_Time.Size = New System.Drawing.Size(304, 39)
        Me.Car_Ride_Time.TabIndex = 14
        '
        'Emp_Car
        '
        Me.Emp_Car.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Emp_Car.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Emp_Car.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Emp_Car.Location = New System.Drawing.Point(6, 36)
        Me.Emp_Car.Name = "Emp_Car"
        Me.Emp_Car.Size = New System.Drawing.Size(304, 35)
        Me.Emp_Car.TabIndex = 13
        '
        'Car_Pick_Up_Pointlbl
        '
        Me.Car_Pick_Up_Pointlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Car_Pick_Up_Pointlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Car_Pick_Up_Pointlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Car_Pick_Up_Pointlbl.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Car_Pick_Up_Pointlbl.ForeColor = System.Drawing.Color.Black
        Me.Car_Pick_Up_Pointlbl.Location = New System.Drawing.Point(314, 129)
        Me.Car_Pick_Up_Pointlbl.Name = "Car_Pick_Up_Pointlbl"
        Me.Car_Pick_Up_Pointlbl.Size = New System.Drawing.Size(157, 35)
        Me.Car_Pick_Up_Pointlbl.TabIndex = 145
        Me.Car_Pick_Up_Pointlbl.Text = "نقطة السيارة"
        Me.Car_Pick_Up_Pointlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Car_Pick_Up_Point
        '
        Me.Car_Pick_Up_Point.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Car_Pick_Up_Point.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Car_Pick_Up_Point.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Car_Pick_Up_Point.Location = New System.Drawing.Point(6, 130)
        Me.Car_Pick_Up_Point.Name = "Car_Pick_Up_Point"
        Me.Car_Pick_Up_Point.Size = New System.Drawing.Size(304, 35)
        Me.Car_Pick_Up_Point.TabIndex = 15
        '
        'Dept_Codelbl
        '
        Me.Dept_Codelbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dept_Codelbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Dept_Codelbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Dept_Codelbl.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dept_Codelbl.ForeColor = System.Drawing.Color.Black
        Me.Dept_Codelbl.Location = New System.Drawing.Point(293, 103)
        Me.Dept_Codelbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Dept_Codelbl.Name = "Dept_Codelbl"
        Me.Dept_Codelbl.Size = New System.Drawing.Size(166, 32)
        Me.Dept_Codelbl.TabIndex = 135
        Me.Dept_Codelbl.Text = "القسم"
        Me.Dept_Codelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Dept_Code
        '
        Me.Dept_Code.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dept_Code.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Dept_Code.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Dept_Code.ItemHeight = 27
        Me.Dept_Code.Location = New System.Drawing.Point(45, 103)
        Me.Dept_Code.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Dept_Code.Name = "Dept_Code"
        Me.Dept_Code.Size = New System.Drawing.Size(239, 35)
        Me.Dept_Code.TabIndex = 136
        '
        'Jop_Codelbl
        '
        Me.Jop_Codelbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Jop_Codelbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Jop_Codelbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Jop_Codelbl.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Jop_Codelbl.ForeColor = System.Drawing.Color.Black
        Me.Jop_Codelbl.Location = New System.Drawing.Point(293, 147)
        Me.Jop_Codelbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Jop_Codelbl.Name = "Jop_Codelbl"
        Me.Jop_Codelbl.Size = New System.Drawing.Size(166, 32)
        Me.Jop_Codelbl.TabIndex = 137
        Me.Jop_Codelbl.Text = "الوظيفة"
        Me.Jop_Codelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Jop_Code
        '
        Me.Jop_Code.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Jop_Code.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Jop_Code.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Jop_Code.ItemHeight = 27
        Me.Jop_Code.Location = New System.Drawing.Point(45, 147)
        Me.Jop_Code.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Jop_Code.Name = "Jop_Code"
        Me.Jop_Code.Size = New System.Drawing.Size(239, 35)
        Me.Jop_Code.TabIndex = 138
        '
        'Emp_Date_Hiringlbl
        '
        Me.Emp_Date_Hiringlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Emp_Date_Hiringlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Emp_Date_Hiringlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Emp_Date_Hiringlbl.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Emp_Date_Hiringlbl.ForeColor = System.Drawing.Color.Black
        Me.Emp_Date_Hiringlbl.Location = New System.Drawing.Point(293, 242)
        Me.Emp_Date_Hiringlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Emp_Date_Hiringlbl.Name = "Emp_Date_Hiringlbl"
        Me.Emp_Date_Hiringlbl.Size = New System.Drawing.Size(166, 32)
        Me.Emp_Date_Hiringlbl.TabIndex = 139
        Me.Emp_Date_Hiringlbl.Text = "تاريخ التعيين"
        Me.Emp_Date_Hiringlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Emp_Date_Hiring
        '
        Me.Emp_Date_Hiring.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Emp_Date_Hiring.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Emp_Date_Hiring.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Emp_Date_Hiring.Location = New System.Drawing.Point(46, 242)
        Me.Emp_Date_Hiring.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Emp_Date_Hiring.Name = "Emp_Date_Hiring"
        Me.Emp_Date_Hiring.Size = New System.Drawing.Size(238, 39)
        Me.Emp_Date_Hiring.TabIndex = 11
        '
        'Emp_Phone1lbl
        '
        Me.Emp_Phone1lbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Emp_Phone1lbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Emp_Phone1lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Emp_Phone1lbl.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Emp_Phone1lbl.ForeColor = System.Drawing.Color.Black
        Me.Emp_Phone1lbl.Location = New System.Drawing.Point(773, 242)
        Me.Emp_Phone1lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Emp_Phone1lbl.Name = "Emp_Phone1lbl"
        Me.Emp_Phone1lbl.Size = New System.Drawing.Size(166, 32)
        Me.Emp_Phone1lbl.TabIndex = 123
        Me.Emp_Phone1lbl.Text = "رقم التليفون"
        Me.Emp_Phone1lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Emp_Phone1
        '
        Me.Emp_Phone1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Emp_Phone1.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Emp_Phone1.Location = New System.Drawing.Point(462, 242)
        Me.Emp_Phone1.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Emp_Phone1.MaxLength = 11
        Me.Emp_Phone1.Name = "Emp_Phone1"
        Me.Emp_Phone1.Size = New System.Drawing.Size(304, 38)
        Me.Emp_Phone1.TabIndex = 7
        Me.Emp_Phone1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Emp_Addresslbl
        '
        Me.Emp_Addresslbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Emp_Addresslbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Emp_Addresslbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Emp_Addresslbl.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Emp_Addresslbl.ForeColor = System.Drawing.Color.Black
        Me.Emp_Addresslbl.Location = New System.Drawing.Point(773, 103)
        Me.Emp_Addresslbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Emp_Addresslbl.Name = "Emp_Addresslbl"
        Me.Emp_Addresslbl.Size = New System.Drawing.Size(166, 32)
        Me.Emp_Addresslbl.TabIndex = 125
        Me.Emp_Addresslbl.Text = "العنوان"
        Me.Emp_Addresslbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Emp_Address
        '
        Me.Emp_Address.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Emp_Address.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!)
        Me.Emp_Address.Location = New System.Drawing.Point(463, 103)
        Me.Emp_Address.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Emp_Address.Name = "Emp_Address"
        Me.Emp_Address.Size = New System.Drawing.Size(304, 34)
        Me.Emp_Address.TabIndex = 3
        Me.Emp_Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Emp_Marital_Statuslbl
        '
        Me.Emp_Marital_Statuslbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Emp_Marital_Statuslbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Emp_Marital_Statuslbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Emp_Marital_Statuslbl.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Emp_Marital_Statuslbl.ForeColor = System.Drawing.Color.Black
        Me.Emp_Marital_Statuslbl.Location = New System.Drawing.Point(293, 196)
        Me.Emp_Marital_Statuslbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Emp_Marital_Statuslbl.Name = "Emp_Marital_Statuslbl"
        Me.Emp_Marital_Statuslbl.Size = New System.Drawing.Size(166, 32)
        Me.Emp_Marital_Statuslbl.TabIndex = 127
        Me.Emp_Marital_Statuslbl.Text = "الحالة الإجتماعية"
        Me.Emp_Marital_Statuslbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Emp_Marital_Status
        '
        Me.Emp_Marital_Status.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Emp_Marital_Status.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Emp_Marital_Status.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Emp_Marital_Status.Items.AddRange(New Object() {"اعزب", "متزوج", "ارمل"})
        Me.Emp_Marital_Status.Location = New System.Drawing.Point(45, 196)
        Me.Emp_Marital_Status.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Emp_Marital_Status.Name = "Emp_Marital_Status"
        Me.Emp_Marital_Status.Size = New System.Drawing.Size(239, 35)
        Me.Emp_Marital_Status.TabIndex = 12
        '
        'Emp_Nationalitylbl
        '
        Me.Emp_Nationalitylbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Emp_Nationalitylbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Emp_Nationalitylbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Emp_Nationalitylbl.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Emp_Nationalitylbl.ForeColor = System.Drawing.Color.Black
        Me.Emp_Nationalitylbl.Location = New System.Drawing.Point(293, 13)
        Me.Emp_Nationalitylbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Emp_Nationalitylbl.Name = "Emp_Nationalitylbl"
        Me.Emp_Nationalitylbl.Size = New System.Drawing.Size(166, 32)
        Me.Emp_Nationalitylbl.TabIndex = 129
        Me.Emp_Nationalitylbl.Text = "الجنسية"
        Me.Emp_Nationalitylbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Emp_Nationality
        '
        Me.Emp_Nationality.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Emp_Nationality.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Emp_Nationality.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Emp_Nationality.ItemHeight = 27
        Me.Emp_Nationality.Items.AddRange(New Object() {"مصرى", "سورى"})
        Me.Emp_Nationality.Location = New System.Drawing.Point(45, 13)
        Me.Emp_Nationality.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Emp_Nationality.Name = "Emp_Nationality"
        Me.Emp_Nationality.Size = New System.Drawing.Size(239, 35)
        Me.Emp_Nationality.TabIndex = 130
        '
        'National_IDlbl
        '
        Me.National_IDlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.National_IDlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.National_IDlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.National_IDlbl.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.National_IDlbl.ForeColor = System.Drawing.Color.Black
        Me.National_IDlbl.Location = New System.Drawing.Point(773, 147)
        Me.National_IDlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.National_IDlbl.Name = "National_IDlbl"
        Me.National_IDlbl.Size = New System.Drawing.Size(166, 32)
        Me.National_IDlbl.TabIndex = 131
        Me.National_IDlbl.Text = "الرقم القومى"
        Me.National_IDlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'National_ID
        '
        Me.National_ID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.National_ID.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!)
        Me.National_ID.Location = New System.Drawing.Point(463, 147)
        Me.National_ID.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.National_ID.MaxLength = 14
        Me.National_ID.Name = "National_ID"
        Me.National_ID.Size = New System.Drawing.Size(304, 34)
        Me.National_ID.TabIndex = 4
        Me.National_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.National_ID.WordWrap = False
        '
        'Date_Birthlbl
        '
        Me.Date_Birthlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Date_Birthlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Date_Birthlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Date_Birthlbl.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_Birthlbl.ForeColor = System.Drawing.Color.Black
        Me.Date_Birthlbl.Location = New System.Drawing.Point(293, 56)
        Me.Date_Birthlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Date_Birthlbl.Name = "Date_Birthlbl"
        Me.Date_Birthlbl.Size = New System.Drawing.Size(166, 32)
        Me.Date_Birthlbl.TabIndex = 133
        Me.Date_Birthlbl.Text = "تاريخ الميلاد"
        Me.Date_Birthlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Date_Birth
        '
        Me.Date_Birth.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Date_Birth.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Date_Birth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Date_Birth.Location = New System.Drawing.Point(45, 56)
        Me.Date_Birth.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Date_Birth.Name = "Date_Birth"
        Me.Date_Birth.Size = New System.Drawing.Size(239, 39)
        Me.Date_Birth.TabIndex = 5
        '
        'Frm_Add_Employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 597)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Frm_Add_Employee"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.Emp_Image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnSave As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Emp_Full_Namelbl As Label
    Friend WithEvents Emp_Full_Name As TextBox
    Friend WithEvents Emp_IDlbl As Label
    Friend WithEvents Emp_ID As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Emp_Phone1lbl As Label
    Friend WithEvents Emp_Phone1 As TextBox
    Friend WithEvents Emp_Addresslbl As Label
    Friend WithEvents Emp_Address As TextBox
    Friend WithEvents Emp_Marital_Statuslbl As Label
    Friend WithEvents Emp_Marital_Status As ComboBox
    Friend WithEvents Emp_Nationalitylbl As Label
    Friend WithEvents Emp_Nationality As ComboBox
    Friend WithEvents National_IDlbl As Label
    Friend WithEvents National_ID As TextBox
    Friend WithEvents Date_Birthlbl As Label
    Friend WithEvents Date_Birth As DateTimePicker
    Friend WithEvents Dept_Codelbl As Label
    Friend WithEvents Dept_Code As ComboBox
    Friend WithEvents Jop_Codelbl As Label
    Friend WithEvents Jop_Code As ComboBox
    Friend WithEvents Emp_Date_Hiringlbl As Label
    Friend WithEvents Emp_Date_Hiring As DateTimePicker
    Friend WithEvents Emp_Carlbl As Label
    Friend WithEvents Emp_Car As ComboBox
    Friend WithEvents Car_Ride_Timelbl As Label
    Friend WithEvents Car_Ride_Time As DateTimePicker
    Friend WithEvents Car_Pick_Up_Pointlbl As Label
    Friend WithEvents Car_Pick_Up_Point As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Emp_Image As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Place_Birthlbl As Label
    Friend WithEvents Place_Birth As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
