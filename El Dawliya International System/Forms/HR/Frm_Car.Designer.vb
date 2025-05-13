<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Car
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Car))
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Car_IDlbl = New System.Windows.Forms.Label()
        Me.Car_ID = New System.Windows.Forms.TextBox()
        Me.Car_Namelbl = New System.Windows.Forms.Label()
        Me.Car_Name = New System.Windows.Forms.TextBox()
        Me.Car_Typelbl = New System.Windows.Forms.Label()
        Me.Car_Salarylbl = New System.Windows.Forms.Label()
        Me.Car_Salary = New System.Windows.Forms.TextBox()
        Me.Supplierlbl = New System.Windows.Forms.Label()
        Me.Contract_Typelbl = New System.Windows.Forms.Label()
        Me.Car_Numberlbl = New System.Windows.Forms.Label()
        Me.Car_Number = New System.Windows.Forms.TextBox()
        Me.Car_License_Expiration_Datelbl = New System.Windows.Forms.Label()
        Me.Car_License_Expiration_Date = New System.Windows.Forms.DateTimePicker()
        Me.Driver_Namelbl = New System.Windows.Forms.Label()
        Me.Driver_Name = New System.Windows.Forms.TextBox()
        Me.Driver_Phonelbl = New System.Windows.Forms.Label()
        Me.Driver_Phone = New System.Windows.Forms.TextBox()
        Me.Driver_License_Expiration_Datelbl = New System.Windows.Forms.Label()
        Me.Driver_License_Expiration_Date = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnNewAdd = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Radio_Contract_Type = New System.Windows.Forms.RadioButton()
        Me.Radio_Car_Salary = New System.Windows.Forms.RadioButton()
        Me.RadioSupplier = New System.Windows.Forms.RadioButton()
        Me.Radio_Car_Name = New System.Windows.Forms.RadioButton()
        Me.RadioCar_ID = New System.Windows.Forms.RadioButton()
        Me.Txt_Search = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgv_Tbl_Car = New System.Windows.Forms.DataGridView()
        Me.Contract_Type = New System.Windows.Forms.ComboBox()
        Me.Supplier = New System.Windows.Forms.ComboBox()
        Me.Car_Type = New System.Windows.Forms.ComboBox()
        Me.Car_Salary_Farda = New System.Windows.Forms.TextBox()
        Me.Car_Salary_FardaLbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Is_Active = New System.Windows.Forms.CheckBox()
        Me.Contract_Type_Farada = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgv_Tbl_Car, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Car_IDlbl
        '
        Me.Car_IDlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Car_IDlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Car_IDlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Car_IDlbl.Font = New System.Drawing.Font("Tajawal Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Car_IDlbl.ForeColor = System.Drawing.Color.Black
        Me.Car_IDlbl.Location = New System.Drawing.Point(863, 7)
        Me.Car_IDlbl.Name = "Car_IDlbl"
        Me.Car_IDlbl.Size = New System.Drawing.Size(234, 38)
        Me.Car_IDlbl.TabIndex = 30
        Me.Car_IDlbl.Text = "كود السيارة"
        Me.Car_IDlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Car_ID
        '
        Me.Car_ID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Car_ID.Font = New System.Drawing.Font("Tajawal Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Car_ID.Location = New System.Drawing.Point(557, 7)
        Me.Car_ID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Car_ID.Name = "Car_ID"
        Me.Car_ID.Size = New System.Drawing.Size(300, 33)
        Me.Car_ID.TabIndex = 1
        Me.Car_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Car_Namelbl
        '
        Me.Car_Namelbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Car_Namelbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Car_Namelbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Car_Namelbl.Font = New System.Drawing.Font("Tajawal Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Car_Namelbl.ForeColor = System.Drawing.Color.Black
        Me.Car_Namelbl.Location = New System.Drawing.Point(317, 7)
        Me.Car_Namelbl.Name = "Car_Namelbl"
        Me.Car_Namelbl.Size = New System.Drawing.Size(234, 38)
        Me.Car_Namelbl.TabIndex = 36
        Me.Car_Namelbl.Text = "اسم السيارة"
        Me.Car_Namelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Car_Name
        '
        Me.Car_Name.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Car_Name.Font = New System.Drawing.Font("Tajawal Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Car_Name.Location = New System.Drawing.Point(11, 7)
        Me.Car_Name.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Car_Name.Name = "Car_Name"
        Me.Car_Name.Size = New System.Drawing.Size(300, 33)
        Me.Car_Name.TabIndex = 2
        Me.Car_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Car_Typelbl
        '
        Me.Car_Typelbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Car_Typelbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Car_Typelbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Car_Typelbl.Font = New System.Drawing.Font("Tajawal Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Car_Typelbl.ForeColor = System.Drawing.Color.Black
        Me.Car_Typelbl.Location = New System.Drawing.Point(863, 52)
        Me.Car_Typelbl.Name = "Car_Typelbl"
        Me.Car_Typelbl.Size = New System.Drawing.Size(234, 38)
        Me.Car_Typelbl.TabIndex = 31
        Me.Car_Typelbl.Text = "نوع السيارة"
        Me.Car_Typelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Car_Salarylbl
        '
        Me.Car_Salarylbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Car_Salarylbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Car_Salarylbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Car_Salarylbl.Font = New System.Drawing.Font("Tajawal Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Car_Salarylbl.ForeColor = System.Drawing.Color.Black
        Me.Car_Salarylbl.Location = New System.Drawing.Point(863, 98)
        Me.Car_Salarylbl.Name = "Car_Salarylbl"
        Me.Car_Salarylbl.Size = New System.Drawing.Size(234, 38)
        Me.Car_Salarylbl.TabIndex = 32
        Me.Car_Salarylbl.Text = "اجر السيارة"
        Me.Car_Salarylbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Car_Salary
        '
        Me.Car_Salary.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Car_Salary.Font = New System.Drawing.Font("Tajawal Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Car_Salary.Location = New System.Drawing.Point(557, 98)
        Me.Car_Salary.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Car_Salary.Name = "Car_Salary"
        Me.Car_Salary.Size = New System.Drawing.Size(300, 33)
        Me.Car_Salary.TabIndex = 5
        Me.Car_Salary.Text = "0.00"
        Me.Car_Salary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Supplierlbl
        '
        Me.Supplierlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Supplierlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Supplierlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Supplierlbl.Font = New System.Drawing.Font("Tajawal Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Supplierlbl.ForeColor = System.Drawing.Color.Black
        Me.Supplierlbl.Location = New System.Drawing.Point(317, 52)
        Me.Supplierlbl.Name = "Supplierlbl"
        Me.Supplierlbl.Size = New System.Drawing.Size(234, 38)
        Me.Supplierlbl.TabIndex = 37
        Me.Supplierlbl.Text = "المورد"
        Me.Supplierlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Contract_Typelbl
        '
        Me.Contract_Typelbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Contract_Typelbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Contract_Typelbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Contract_Typelbl.Font = New System.Drawing.Font("Tajawal Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Contract_Typelbl.ForeColor = System.Drawing.Color.Black
        Me.Contract_Typelbl.Location = New System.Drawing.Point(317, 142)
        Me.Contract_Typelbl.Name = "Contract_Typelbl"
        Me.Contract_Typelbl.Size = New System.Drawing.Size(234, 38)
        Me.Contract_Typelbl.TabIndex = 39
        Me.Contract_Typelbl.Text = "نوع التعاقد"
        Me.Contract_Typelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Car_Numberlbl
        '
        Me.Car_Numberlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Car_Numberlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Car_Numberlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Car_Numberlbl.Font = New System.Drawing.Font("Tajawal Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Car_Numberlbl.ForeColor = System.Drawing.Color.Black
        Me.Car_Numberlbl.Location = New System.Drawing.Point(863, 142)
        Me.Car_Numberlbl.Name = "Car_Numberlbl"
        Me.Car_Numberlbl.Size = New System.Drawing.Size(234, 38)
        Me.Car_Numberlbl.TabIndex = 33
        Me.Car_Numberlbl.Text = "رقم السيارة"
        Me.Car_Numberlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Car_Number
        '
        Me.Car_Number.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Car_Number.Font = New System.Drawing.Font("Tajawal Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Car_Number.Location = New System.Drawing.Point(557, 142)
        Me.Car_Number.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Car_Number.Name = "Car_Number"
        Me.Car_Number.Size = New System.Drawing.Size(300, 33)
        Me.Car_Number.TabIndex = 7
        Me.Car_Number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Car_License_Expiration_Datelbl
        '
        Me.Car_License_Expiration_Datelbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Car_License_Expiration_Datelbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Car_License_Expiration_Datelbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Car_License_Expiration_Datelbl.Font = New System.Drawing.Font("Tajawal Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Car_License_Expiration_Datelbl.ForeColor = System.Drawing.Color.Black
        Me.Car_License_Expiration_Datelbl.Location = New System.Drawing.Point(317, 232)
        Me.Car_License_Expiration_Datelbl.Name = "Car_License_Expiration_Datelbl"
        Me.Car_License_Expiration_Datelbl.Size = New System.Drawing.Size(234, 38)
        Me.Car_License_Expiration_Datelbl.TabIndex = 41
        Me.Car_License_Expiration_Datelbl.Text = "تاريخ انتهاء رخصة السيارة"
        Me.Car_License_Expiration_Datelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Car_License_Expiration_Date
        '
        Me.Car_License_Expiration_Date.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Car_License_Expiration_Date.Font = New System.Drawing.Font("Tajawal Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Car_License_Expiration_Date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Car_License_Expiration_Date.Location = New System.Drawing.Point(11, 232)
        Me.Car_License_Expiration_Date.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Car_License_Expiration_Date.Name = "Car_License_Expiration_Date"
        Me.Car_License_Expiration_Date.Size = New System.Drawing.Size(300, 33)
        Me.Car_License_Expiration_Date.TabIndex = 12
        '
        'Driver_Namelbl
        '
        Me.Driver_Namelbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Driver_Namelbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Driver_Namelbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Driver_Namelbl.Font = New System.Drawing.Font("Tajawal Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Driver_Namelbl.ForeColor = System.Drawing.Color.Black
        Me.Driver_Namelbl.Location = New System.Drawing.Point(863, 187)
        Me.Driver_Namelbl.Name = "Driver_Namelbl"
        Me.Driver_Namelbl.Size = New System.Drawing.Size(234, 38)
        Me.Driver_Namelbl.TabIndex = 34
        Me.Driver_Namelbl.Text = "اسم السائق"
        Me.Driver_Namelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Driver_Name
        '
        Me.Driver_Name.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Driver_Name.Font = New System.Drawing.Font("Tajawal Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Driver_Name.Location = New System.Drawing.Point(557, 187)
        Me.Driver_Name.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Driver_Name.Name = "Driver_Name"
        Me.Driver_Name.Size = New System.Drawing.Size(300, 33)
        Me.Driver_Name.TabIndex = 9
        Me.Driver_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Driver_Phonelbl
        '
        Me.Driver_Phonelbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Driver_Phonelbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Driver_Phonelbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Driver_Phonelbl.Font = New System.Drawing.Font("Tajawal Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Driver_Phonelbl.ForeColor = System.Drawing.Color.Black
        Me.Driver_Phonelbl.Location = New System.Drawing.Point(317, 187)
        Me.Driver_Phonelbl.Name = "Driver_Phonelbl"
        Me.Driver_Phonelbl.Size = New System.Drawing.Size(234, 38)
        Me.Driver_Phonelbl.TabIndex = 40
        Me.Driver_Phonelbl.Text = "رقم السائق"
        Me.Driver_Phonelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Driver_Phone
        '
        Me.Driver_Phone.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Driver_Phone.Font = New System.Drawing.Font("Tajawal Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Driver_Phone.Location = New System.Drawing.Point(11, 187)
        Me.Driver_Phone.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Driver_Phone.Name = "Driver_Phone"
        Me.Driver_Phone.Size = New System.Drawing.Size(300, 33)
        Me.Driver_Phone.TabIndex = 10
        Me.Driver_Phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Driver_License_Expiration_Datelbl
        '
        Me.Driver_License_Expiration_Datelbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Driver_License_Expiration_Datelbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Driver_License_Expiration_Datelbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Driver_License_Expiration_Datelbl.Font = New System.Drawing.Font("Tajawal Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Driver_License_Expiration_Datelbl.ForeColor = System.Drawing.Color.Black
        Me.Driver_License_Expiration_Datelbl.Location = New System.Drawing.Point(863, 232)
        Me.Driver_License_Expiration_Datelbl.Name = "Driver_License_Expiration_Datelbl"
        Me.Driver_License_Expiration_Datelbl.Size = New System.Drawing.Size(234, 38)
        Me.Driver_License_Expiration_Datelbl.TabIndex = 35
        Me.Driver_License_Expiration_Datelbl.Text = "تاريخ انتهاء رخصة السائق"
        Me.Driver_License_Expiration_Datelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Driver_License_Expiration_Date
        '
        Me.Driver_License_Expiration_Date.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Driver_License_Expiration_Date.Font = New System.Drawing.Font("Tajawal Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Driver_License_Expiration_Date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Driver_License_Expiration_Date.Location = New System.Drawing.Point(557, 232)
        Me.Driver_License_Expiration_Date.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Driver_License_Expiration_Date.Name = "Driver_License_Expiration_Date"
        Me.Driver_License_Expiration_Date.Size = New System.Drawing.Size(300, 33)
        Me.Driver_License_Expiration_Date.TabIndex = 11
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
        Me.Panel1.Location = New System.Drawing.Point(0, 692)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1109, 60)
        Me.Panel1.TabIndex = 23
        '
        'BtnSave
        '
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Bold)
        Me.BtnSave.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Ok
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSave.Location = New System.Drawing.Point(734, 7)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnSave.Size = New System.Drawing.Size(117, 48)
        Me.BtnSave.TabIndex = 106
        Me.BtnSave.Text = "حفظ"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.FlatAppearance.BorderSize = 0
        Me.BtnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed
        Me.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEdit.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Bold)
        Me.BtnEdit.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Save_as
        Me.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEdit.Location = New System.Drawing.Point(494, 7)
        Me.BtnEdit.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(113, 48)
        Me.BtnEdit.TabIndex = 107
        Me.BtnEdit.Text = "تعديل"
        Me.BtnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnNewAdd
        '
        Me.BtnNewAdd.FlatAppearance.BorderSize = 0
        Me.BtnNewAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed
        Me.BtnNewAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNewAdd.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Bold)
        Me.BtnNewAdd.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Add
        Me.BtnNewAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNewAdd.Location = New System.Drawing.Point(978, 7)
        Me.BtnNewAdd.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.BtnNewAdd.Name = "BtnNewAdd"
        Me.BtnNewAdd.Size = New System.Drawing.Size(117, 48)
        Me.BtnNewAdd.TabIndex = 105
        Me.BtnNewAdd.Text = "جديد"
        Me.BtnNewAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNewAdd.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.FlatAppearance.BorderSize = 0
        Me.BtnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Bold)
        Me.BtnDelete.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Remove
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.Location = New System.Drawing.Point(254, 7)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(113, 48)
        Me.BtnDelete.TabIndex = 108
        Me.BtnDelete.Text = "حذف"
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.FlatAppearance.BorderSize = 0
        Me.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Bold)
        Me.BtnClose.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Cancel
        Me.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnClose.Location = New System.Drawing.Point(14, 7)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(113, 48)
        Me.BtnClose.TabIndex = 109
        Me.BtnClose.Text = "انهاء"
        Me.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnClose.UseVisualStyleBackColor = True
        Me.BtnClose.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1109, 33)
        Me.Panel2.TabIndex = 24
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1063, 2)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(42, 29)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 110
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Tajawal Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1109, 31)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "اضافة سيارة جديدة"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Contract_Type_Farada)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Is_Active)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.dgv_Tbl_Car)
        Me.Panel3.Controls.Add(Me.Contract_Type)
        Me.Panel3.Controls.Add(Me.Supplier)
        Me.Panel3.Controls.Add(Me.Car_Type)
        Me.Panel3.Controls.Add(Me.Car_IDlbl)
        Me.Panel3.Controls.Add(Me.Car_Salary_Farda)
        Me.Panel3.Controls.Add(Me.Car_Salary)
        Me.Panel3.Controls.Add(Me.Car_License_Expiration_Datelbl)
        Me.Panel3.Controls.Add(Me.Supplierlbl)
        Me.Panel3.Controls.Add(Me.Car_License_Expiration_Date)
        Me.Panel3.Controls.Add(Me.Driver_Namelbl)
        Me.Panel3.Controls.Add(Me.Car_Salary_FardaLbl)
        Me.Panel3.Controls.Add(Me.Driver_Name)
        Me.Panel3.Controls.Add(Me.Car_Salarylbl)
        Me.Panel3.Controls.Add(Me.Driver_Phonelbl)
        Me.Panel3.Controls.Add(Me.Contract_Typelbl)
        Me.Panel3.Controls.Add(Me.Driver_Phone)
        Me.Panel3.Controls.Add(Me.Car_ID)
        Me.Panel3.Controls.Add(Me.Driver_License_Expiration_Datelbl)
        Me.Panel3.Controls.Add(Me.Driver_License_Expiration_Date)
        Me.Panel3.Controls.Add(Me.Car_Numberlbl)
        Me.Panel3.Controls.Add(Me.Car_Namelbl)
        Me.Panel3.Controls.Add(Me.Car_Number)
        Me.Panel3.Controls.Add(Me.Car_Typelbl)
        Me.Panel3.Controls.Add(Me.Car_Name)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 33)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1109, 659)
        Me.Panel3.TabIndex = 25
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.Controls.Add(Me.Radio_Contract_Type)
        Me.Panel4.Controls.Add(Me.Radio_Car_Salary)
        Me.Panel4.Controls.Add(Me.RadioSupplier)
        Me.Panel4.Controls.Add(Me.Radio_Car_Name)
        Me.Panel4.Controls.Add(Me.RadioCar_ID)
        Me.Panel4.Controls.Add(Me.Txt_Search)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Location = New System.Drawing.Point(11, 322)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1086, 48)
        Me.Panel4.TabIndex = 112
        '
        'Radio_Contract_Type
        '
        Me.Radio_Contract_Type.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Radio_Contract_Type.Font = New System.Drawing.Font("Hacen Saudi Arabia", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radio_Contract_Type.Location = New System.Drawing.Point(14, 5)
        Me.Radio_Contract_Type.Name = "Radio_Contract_Type"
        Me.Radio_Contract_Type.Size = New System.Drawing.Size(128, 30)
        Me.Radio_Contract_Type.TabIndex = 24
        Me.Radio_Contract_Type.TabStop = True
        Me.Radio_Contract_Type.Text = "نوع التعاقد"
        Me.Radio_Contract_Type.UseVisualStyleBackColor = True
        '
        'Radio_Car_Salary
        '
        Me.Radio_Car_Salary.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Radio_Car_Salary.Font = New System.Drawing.Font("Hacen Saudi Arabia", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radio_Car_Salary.Location = New System.Drawing.Point(170, 5)
        Me.Radio_Car_Salary.Name = "Radio_Car_Salary"
        Me.Radio_Car_Salary.Size = New System.Drawing.Size(105, 30)
        Me.Radio_Car_Salary.TabIndex = 23
        Me.Radio_Car_Salary.TabStop = True
        Me.Radio_Car_Salary.Text = "اجر السيارة"
        Me.Radio_Car_Salary.UseVisualStyleBackColor = True
        '
        'RadioSupplier
        '
        Me.RadioSupplier.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioSupplier.Font = New System.Drawing.Font("Hacen Saudi Arabia", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioSupplier.Location = New System.Drawing.Point(303, 5)
        Me.RadioSupplier.Name = "RadioSupplier"
        Me.RadioSupplier.Size = New System.Drawing.Size(78, 30)
        Me.RadioSupplier.TabIndex = 23
        Me.RadioSupplier.TabStop = True
        Me.RadioSupplier.Text = "المورد"
        Me.RadioSupplier.UseVisualStyleBackColor = True
        '
        'Radio_Car_Name
        '
        Me.Radio_Car_Name.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Radio_Car_Name.Font = New System.Drawing.Font("Hacen Saudi Arabia", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Radio_Car_Name.Location = New System.Drawing.Point(409, 5)
        Me.Radio_Car_Name.Name = "Radio_Car_Name"
        Me.Radio_Car_Name.Size = New System.Drawing.Size(122, 30)
        Me.Radio_Car_Name.TabIndex = 23
        Me.Radio_Car_Name.TabStop = True
        Me.Radio_Car_Name.Text = "اسم السيارة"
        Me.Radio_Car_Name.UseVisualStyleBackColor = True
        '
        'RadioCar_ID
        '
        Me.RadioCar_ID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioCar_ID.Font = New System.Drawing.Font("Hacen Saudi Arabia", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioCar_ID.Location = New System.Drawing.Point(559, 5)
        Me.RadioCar_ID.Name = "RadioCar_ID"
        Me.RadioCar_ID.Size = New System.Drawing.Size(119, 30)
        Me.RadioCar_ID.TabIndex = 23
        Me.RadioCar_ID.TabStop = True
        Me.RadioCar_ID.Text = "كود السيارة"
        Me.RadioCar_ID.UseVisualStyleBackColor = True
        '
        'Txt_Search
        '
        Me.Txt_Search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_Search.Location = New System.Drawing.Point(688, 5)
        Me.Txt_Search.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Txt_Search.Name = "Txt_Search"
        Me.Txt_Search.Size = New System.Drawing.Size(300, 38)
        Me.Txt_Search.TabIndex = 22
        Me.Txt_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(994, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 38)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "ابحث هنا"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgv_Tbl_Car
        '
        Me.dgv_Tbl_Car.AllowUserToAddRows = False
        Me.dgv_Tbl_Car.AllowUserToDeleteRows = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Cairo", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv_Tbl_Car.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_Tbl_Car.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_Tbl_Car.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Tbl_Car.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgv_Tbl_Car.ColumnHeadersHeight = 40
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Tbl_Car.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgv_Tbl_Car.EnableHeadersVisualStyles = False
        Me.dgv_Tbl_Car.Location = New System.Drawing.Point(11, 376)
        Me.dgv_Tbl_Car.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.dgv_Tbl_Car.Name = "dgv_Tbl_Car"
        Me.dgv_Tbl_Car.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Tbl_Car.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgv_Tbl_Car.RowHeadersVisible = False
        Me.dgv_Tbl_Car.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Cairo SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_Tbl_Car.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgv_Tbl_Car.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Tbl_Car.Size = New System.Drawing.Size(1086, 265)
        Me.dgv_Tbl_Car.TabIndex = 111
        '
        'Contract_Type
        '
        Me.Contract_Type.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Contract_Type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Contract_Type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Contract_Type.Font = New System.Drawing.Font("Tajawal Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Contract_Type.FormattingEnabled = True
        Me.Contract_Type.Items.AddRange(New Object() {"ميكروباص نهارى", "اتوبيس نهارى", "ميكروباص صد رد", "ميكروباص فردة", "اتوبيس صد رد ", "اتوبيس فردة", "اقاليم"})
        Me.Contract_Type.Location = New System.Drawing.Point(11, 142)
        Me.Contract_Type.Name = "Contract_Type"
        Me.Contract_Type.Size = New System.Drawing.Size(300, 33)
        Me.Contract_Type.TabIndex = 8
        '
        'Supplier
        '
        Me.Supplier.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Supplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Supplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Supplier.Font = New System.Drawing.Font("Tajawal Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Supplier.FormattingEnabled = True
        Me.Supplier.Items.AddRange(New Object() {"الشركة العربية", "هيثم"})
        Me.Supplier.Location = New System.Drawing.Point(11, 52)
        Me.Supplier.Name = "Supplier"
        Me.Supplier.Size = New System.Drawing.Size(300, 33)
        Me.Supplier.TabIndex = 4
        '
        'Car_Type
        '
        Me.Car_Type.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Car_Type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Car_Type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Car_Type.Font = New System.Drawing.Font("Tajawal Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Car_Type.FormattingEnabled = True
        Me.Car_Type.Items.AddRange(New Object() {"ميكروباص", "اتوبيس", "سوزوكى", "ملاكى", "ميكروباص سقف عالى"})
        Me.Car_Type.Location = New System.Drawing.Point(557, 52)
        Me.Car_Type.Name = "Car_Type"
        Me.Car_Type.Size = New System.Drawing.Size(300, 33)
        Me.Car_Type.TabIndex = 3
        '
        'Car_Salary_Farda
        '
        Me.Car_Salary_Farda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Car_Salary_Farda.Font = New System.Drawing.Font("Tajawal Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Car_Salary_Farda.Location = New System.Drawing.Point(11, 98)
        Me.Car_Salary_Farda.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Car_Salary_Farda.Name = "Car_Salary_Farda"
        Me.Car_Salary_Farda.Size = New System.Drawing.Size(300, 33)
        Me.Car_Salary_Farda.TabIndex = 6
        Me.Car_Salary_Farda.Text = "0.00"
        Me.Car_Salary_Farda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Car_Salary_FardaLbl
        '
        Me.Car_Salary_FardaLbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Car_Salary_FardaLbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Car_Salary_FardaLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Car_Salary_FardaLbl.Font = New System.Drawing.Font("Tajawal Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Car_Salary_FardaLbl.ForeColor = System.Drawing.Color.Black
        Me.Car_Salary_FardaLbl.Location = New System.Drawing.Point(317, 98)
        Me.Car_Salary_FardaLbl.Name = "Car_Salary_FardaLbl"
        Me.Car_Salary_FardaLbl.Size = New System.Drawing.Size(234, 38)
        Me.Car_Salary_FardaLbl.TabIndex = 38
        Me.Car_Salary_FardaLbl.Text = "اجر الفردة"
        Me.Car_Salary_FardaLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Tajawal Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(863, 280)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(234, 38)
        Me.Label3.TabIndex = 113
        Me.Label3.Text = "حالة السيارة"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Is_Active
        '
        Me.Is_Active.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Is_Active.Location = New System.Drawing.Point(557, 280)
        Me.Is_Active.Name = "Is_Active"
        Me.Is_Active.Size = New System.Drawing.Size(300, 21)
        Me.Is_Active.TabIndex = 114
        Me.Is_Active.UseVisualStyleBackColor = True
        '
        'Contract_Type_Farada
        '
        Me.Contract_Type_Farada.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Contract_Type_Farada.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Contract_Type_Farada.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Contract_Type_Farada.Font = New System.Drawing.Font("Tajawal Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Contract_Type_Farada.FormattingEnabled = True
        Me.Contract_Type_Farada.Items.AddRange(New Object() {"ميكروباص نهارى", "اتوبيس نهارى", "ميكروباص صد رد", "ميكروباص فردة", "اتوبيس صد رد ", "اتوبيس فردة", "اقاليم"})
        Me.Contract_Type_Farada.Location = New System.Drawing.Point(11, 280)
        Me.Contract_Type_Farada.Name = "Contract_Type_Farada"
        Me.Contract_Type_Farada.Size = New System.Drawing.Size(300, 33)
        Me.Contract_Type_Farada.TabIndex = 115
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Tajawal Black", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(317, 280)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(234, 38)
        Me.Label4.TabIndex = 116
        Me.Label4.Text = "نوع الوردية فى حالة الفردة"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Frm_Car
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1109, 752)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.Name = "Frm_Car"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.dgv_Tbl_Car, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Car_ID As System.Windows.Forms.TextBox
    Friend WithEvents Car_IDlbl As System.Windows.Forms.Label
    Friend WithEvents Car_Name As System.Windows.Forms.TextBox
    Friend WithEvents Car_Namelbl As System.Windows.Forms.Label
    Friend WithEvents Car_Type1 As System.Windows.Forms.TextBox
    Friend WithEvents Car_Typelbl As System.Windows.Forms.Label
    Friend WithEvents Car_Salary As System.Windows.Forms.TextBox
    Friend WithEvents Car_Salarylbl As System.Windows.Forms.Label
    Friend WithEvents Supplierlbl As System.Windows.Forms.Label
    Friend WithEvents Contract_Typelbl As System.Windows.Forms.Label
    Friend WithEvents Car_Number As System.Windows.Forms.TextBox
    Friend WithEvents Car_Numberlbl As System.Windows.Forms.Label
    Friend WithEvents Car_License_Expiration_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Car_License_Expiration_Datelbl As System.Windows.Forms.Label
    Friend WithEvents Driver_Name As System.Windows.Forms.TextBox
    Friend WithEvents Driver_Namelbl As System.Windows.Forms.Label
    Friend WithEvents Driver_Phone As System.Windows.Forms.TextBox
    Friend WithEvents Driver_Phonelbl As System.Windows.Forms.Label
    Friend WithEvents Driver_License_Expiration_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Driver_License_Expiration_Datelbl As System.Windows.Forms.Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnNewAdd As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Car_Type As ComboBox
    Friend WithEvents Contract_Type As ComboBox
    Friend WithEvents dgv_Tbl_Car As DataGridView
    Friend WithEvents Supplier As ComboBox
    Friend WithEvents Car_Salary_Farda As TextBox
    Friend WithEvents Car_Salary_FardaLbl As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Radio_Contract_Type As RadioButton
    Friend WithEvents Radio_Car_Salary As RadioButton
    Friend WithEvents RadioSupplier As RadioButton
    Friend WithEvents Radio_Car_Name As RadioButton
    Friend WithEvents RadioCar_ID As RadioButton
    Friend WithEvents Txt_Search As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Contract_Type_Farada As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Is_Active As CheckBox
    Friend WithEvents Label3 As Label
End Class
