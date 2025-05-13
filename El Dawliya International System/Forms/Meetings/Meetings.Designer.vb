<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Meetings
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
        Me.Meeting_IDlbl = New System.Windows.Forms.Label()
        Me.Meeting_ID = New System.Windows.Forms.TextBox()
        Me.Meeting_Titlelbl = New System.Windows.Forms.Label()
        Me.Meeting_Title = New System.Windows.Forms.TextBox()
        Me.Meeting_Datelbl = New System.Windows.Forms.Label()
        Me.Meeting_Date = New System.Windows.Forms.DateTimePicker()
        Me.Meeting_Locationlbl = New System.Windows.Forms.Label()
        Me.Meeting_Location = New System.Windows.Forms.TextBox()
        Me.Meeting_Descriptionlbl = New System.Windows.Forms.Label()
        Me.Meeting_Description = New System.Windows.Forms.TextBox()
        Me.Created_Datelbl = New System.Windows.Forms.Label()
        Me.Created_Date = New System.Windows.Forms.DateTimePicker()
        Me.BtnNewAdd = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel_dgv_Attendees = New System.Windows.Forms.Panel()
        Me.dgv_Attendees = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.cmb_Employee = New System.Windows.Forms.ComboBox()
        Me.Btn_Save_Attend = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel_Meeting_Address = New System.Windows.Forms.Panel()
        Me.Panel_Dgv_Task = New System.Windows.Forms.Panel()
        Me.Dgv_Task = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Btn_Search_Meeetings = New System.Windows.Forms.Button()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btn_Save_Task = New System.Windows.Forms.Button()
        Me.Due_Date = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_Task_Description = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cmb_Assigned_To = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel_dgv_Attendees.SuspendLayout()
        CType(Me.dgv_Attendees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel_Meeting_Address.SuspendLayout()
        Me.Panel_Dgv_Task.SuspendLayout()
        CType(Me.Dgv_Task, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Meeting_IDlbl
        '
        Me.Meeting_IDlbl.Location = New System.Drawing.Point(313, 8)
        Me.Meeting_IDlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Meeting_IDlbl.Name = "Meeting_IDlbl"
        Me.Meeting_IDlbl.Size = New System.Drawing.Size(71, 32)
        Me.Meeting_IDlbl.TabIndex = 0
        Me.Meeting_IDlbl.Text = "كود الاجتماع"
        Me.Meeting_IDlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Meeting_IDlbl.Visible = False
        '
        'Meeting_ID
        '
        Me.Meeting_ID.Location = New System.Drawing.Point(241, 4)
        Me.Meeting_ID.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Meeting_ID.Name = "Meeting_ID"
        Me.Meeting_ID.Size = New System.Drawing.Size(68, 39)
        Me.Meeting_ID.TabIndex = 1
        Me.Meeting_ID.Visible = False
        '
        'Meeting_Titlelbl
        '
        Me.Meeting_Titlelbl.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Meeting_Titlelbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Meeting_Titlelbl.Dock = System.Windows.Forms.DockStyle.Right
        Me.Meeting_Titlelbl.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Meeting_Titlelbl.Location = New System.Drawing.Point(1282, 0)
        Me.Meeting_Titlelbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Meeting_Titlelbl.Name = "Meeting_Titlelbl"
        Me.Meeting_Titlelbl.Size = New System.Drawing.Size(156, 39)
        Me.Meeting_Titlelbl.TabIndex = 3
        Me.Meeting_Titlelbl.Text = "عنوان الاجتماع"
        Me.Meeting_Titlelbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Meeting_Title
        '
        Me.Meeting_Title.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Meeting_Title.Font = New System.Drawing.Font("Cairo ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Meeting_Title.Location = New System.Drawing.Point(6, 0)
        Me.Meeting_Title.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Meeting_Title.Name = "Meeting_Title"
        Me.Meeting_Title.Size = New System.Drawing.Size(1276, 45)
        Me.Meeting_Title.TabIndex = 2
        Me.Meeting_Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Meeting_Datelbl
        '
        Me.Meeting_Datelbl.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Meeting_Datelbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Meeting_Datelbl.Dock = System.Windows.Forms.DockStyle.Right
        Me.Meeting_Datelbl.Enabled = False
        Me.Meeting_Datelbl.Location = New System.Drawing.Point(1278, 0)
        Me.Meeting_Datelbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Meeting_Datelbl.Name = "Meeting_Datelbl"
        Me.Meeting_Datelbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Meeting_Datelbl.Size = New System.Drawing.Size(156, 35)
        Me.Meeting_Datelbl.TabIndex = 4
        Me.Meeting_Datelbl.Text = "تاريخ الاجتماع"
        Me.Meeting_Datelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Meeting_Date
        '
        Me.Meeting_Date.Dock = System.Windows.Forms.DockStyle.Right
        Me.Meeting_Date.Enabled = False
        Me.Meeting_Date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Meeting_Date.Location = New System.Drawing.Point(1127, 0)
        Me.Meeting_Date.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Meeting_Date.Name = "Meeting_Date"
        Me.Meeting_Date.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Meeting_Date.Size = New System.Drawing.Size(151, 39)
        Me.Meeting_Date.TabIndex = 5
        '
        'Meeting_Locationlbl
        '
        Me.Meeting_Locationlbl.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Meeting_Locationlbl.Dock = System.Windows.Forms.DockStyle.Right
        Me.Meeting_Locationlbl.Location = New System.Drawing.Point(1003, 0)
        Me.Meeting_Locationlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Meeting_Locationlbl.Name = "Meeting_Locationlbl"
        Me.Meeting_Locationlbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Meeting_Locationlbl.Size = New System.Drawing.Size(124, 35)
        Me.Meeting_Locationlbl.TabIndex = 6
        Me.Meeting_Locationlbl.Text = "مكان الاجتماع"
        Me.Meeting_Locationlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Meeting_Location
        '
        Me.Meeting_Location.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Meeting_Location.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Meeting_Location.Font = New System.Drawing.Font("Cairo ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Meeting_Location.Location = New System.Drawing.Point(4, 0)
        Me.Meeting_Location.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Meeting_Location.Name = "Meeting_Location"
        Me.Meeting_Location.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Meeting_Location.Size = New System.Drawing.Size(999, 45)
        Me.Meeting_Location.TabIndex = 7
        Me.Meeting_Location.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Meeting_Descriptionlbl
        '
        Me.Meeting_Descriptionlbl.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Meeting_Descriptionlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Meeting_Descriptionlbl.Dock = System.Windows.Forms.DockStyle.Top
        Me.Meeting_Descriptionlbl.Location = New System.Drawing.Point(0, 0)
        Me.Meeting_Descriptionlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Meeting_Descriptionlbl.Name = "Meeting_Descriptionlbl"
        Me.Meeting_Descriptionlbl.Size = New System.Drawing.Size(911, 41)
        Me.Meeting_Descriptionlbl.TabIndex = 8
        Me.Meeting_Descriptionlbl.Text = "موضوع النقاش"
        Me.Meeting_Descriptionlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Meeting_Description
        '
        Me.Meeting_Description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Meeting_Description.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Meeting_Description.Font = New System.Drawing.Font("Cairo ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Meeting_Description.Location = New System.Drawing.Point(0, 0)
        Me.Meeting_Description.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Meeting_Description.Multiline = True
        Me.Meeting_Description.Name = "Meeting_Description"
        Me.Meeting_Description.Size = New System.Drawing.Size(911, 236)
        Me.Meeting_Description.TabIndex = 9
        Me.Meeting_Description.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Created_Datelbl
        '
        Me.Created_Datelbl.Location = New System.Drawing.Point(129, 8)
        Me.Created_Datelbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Created_Datelbl.Name = "Created_Datelbl"
        Me.Created_Datelbl.Size = New System.Drawing.Size(75, 34)
        Me.Created_Datelbl.TabIndex = 10
        Me.Created_Datelbl.Text = "تاريخ الانشاء"
        Me.Created_Datelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Created_Datelbl.Visible = False
        '
        'Created_Date
        '
        Me.Created_Date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Created_Date.Location = New System.Drawing.Point(11, 8)
        Me.Created_Date.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Created_Date.Name = "Created_Date"
        Me.Created_Date.Size = New System.Drawing.Size(114, 39)
        Me.Created_Date.TabIndex = 11
        Me.Created_Date.Visible = False
        '
        'BtnNewAdd
        '
        Me.BtnNewAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNewAdd.BackColor = System.Drawing.Color.Blue
        Me.BtnNewAdd.Location = New System.Drawing.Point(1203, 9)
        Me.BtnNewAdd.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.BtnNewAdd.Name = "BtnNewAdd"
        Me.BtnNewAdd.Size = New System.Drawing.Size(223, 50)
        Me.BtnNewAdd.TabIndex = 13
        Me.BtnNewAdd.Text = "إضافة جديد"
        Me.BtnNewAdd.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSave.Location = New System.Drawing.Point(804, 9)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(223, 50)
        Me.BtnSave.TabIndex = 14
        Me.BtnSave.Text = "حفظ"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.Red
        Me.BtnClose.Location = New System.Drawing.Point(6, 9)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(223, 50)
        Me.BtnClose.TabIndex = 17
        Me.BtnClose.Text = "انهاء"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Created_Date)
        Me.Panel1.Controls.Add(Me.Meeting_IDlbl)
        Me.Panel1.Controls.Add(Me.Created_Datelbl)
        Me.Panel1.Controls.Add(Me.Meeting_ID)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1438, 45)
        Me.Panel1.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FloralWhite
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Cairo", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1438, 45)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "شاشة الاجتماعات"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.Panel8)
        Me.Panel2.Controls.Add(Me.Panel10)
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Controls.Add(Me.Panel_Meeting_Address)
        Me.Panel2.Location = New System.Drawing.Point(0, 45)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1438, 359)
        Me.Panel2.TabIndex = 20
        '
        'Panel8
        '
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel8.Controls.Add(Me.Panel9)
        Me.Panel8.Controls.Add(Me.Meeting_Descriptionlbl)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel8.Location = New System.Drawing.Point(523, 78)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(915, 281)
        Me.Panel8.TabIndex = 24
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.Meeting_Description)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel9.Location = New System.Drawing.Point(0, 41)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(911, 236)
        Me.Panel9.TabIndex = 9
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.Panel_dgv_Attendees)
        Me.Panel10.Controls.Add(Me.Panel4)
        Me.Panel10.Controls.Add(Me.Label5)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel10.Location = New System.Drawing.Point(0, 78)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(517, 281)
        Me.Panel10.TabIndex = 24
        '
        'Panel_dgv_Attendees
        '
        Me.Panel_dgv_Attendees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_dgv_Attendees.Controls.Add(Me.dgv_Attendees)
        Me.Panel_dgv_Attendees.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_dgv_Attendees.Location = New System.Drawing.Point(0, 90)
        Me.Panel_dgv_Attendees.Name = "Panel_dgv_Attendees"
        Me.Panel_dgv_Attendees.Size = New System.Drawing.Size(517, 191)
        Me.Panel_dgv_Attendees.TabIndex = 28
        '
        'dgv_Attendees
        '
        Me.dgv_Attendees.AllowUserToAddRows = False
        Me.dgv_Attendees.AllowUserToDeleteRows = False
        Me.dgv_Attendees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_Attendees.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_Attendees.BackgroundColor = System.Drawing.Color.White
        Me.dgv_Attendees.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_Attendees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Attendees.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Attendees.ColumnHeadersHeight = 40
        Me.dgv_Attendees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Attendees.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_Attendees.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Attendees.EnableHeadersVisualStyles = False
        Me.dgv_Attendees.GridColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dgv_Attendees.Location = New System.Drawing.Point(0, 0)
        Me.dgv_Attendees.Name = "dgv_Attendees"
        Me.dgv_Attendees.ReadOnly = True
        Me.dgv_Attendees.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dgv_Attendees.RowHeadersVisible = False
        Me.dgv_Attendees.RowHeadersWidth = 51
        Me.dgv_Attendees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Attendees.Size = New System.Drawing.Size(513, 187)
        Me.dgv_Attendees.TabIndex = 25
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.cmb_Employee)
        Me.Panel4.Controls.Add(Me.Btn_Save_Attend)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 43)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(517, 47)
        Me.Panel4.TabIndex = 27
        '
        'cmb_Employee
        '
        Me.cmb_Employee.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_Employee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_Employee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_Employee.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Employee.FormattingEnabled = True
        Me.cmb_Employee.Location = New System.Drawing.Point(108, 3)
        Me.cmb_Employee.Name = "cmb_Employee"
        Me.cmb_Employee.Size = New System.Drawing.Size(406, 40)
        Me.cmb_Employee.TabIndex = 19
        '
        'Btn_Save_Attend
        '
        Me.Btn_Save_Attend.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Save_Attend.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Save_Attend.Location = New System.Drawing.Point(3, 3)
        Me.Btn_Save_Attend.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Btn_Save_Attend.Name = "Btn_Save_Attend"
        Me.Btn_Save_Attend.Size = New System.Drawing.Size(102, 40)
        Me.Btn_Save_Attend.TabIndex = 14
        Me.Btn_Save_Attend.Text = "حفظ"
        Me.Btn_Save_Attend.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Cairo", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(517, 43)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "الحضور"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel7.Controls.Add(Me.Meeting_Location)
        Me.Panel7.Controls.Add(Me.Meeting_Locationlbl)
        Me.Panel7.Controls.Add(Me.Meeting_Date)
        Me.Panel7.Controls.Add(Me.Meeting_Datelbl)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 39)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1438, 39)
        Me.Panel7.TabIndex = 23
        '
        'Panel_Meeting_Address
        '
        Me.Panel_Meeting_Address.Controls.Add(Me.Meeting_Title)
        Me.Panel_Meeting_Address.Controls.Add(Me.Meeting_Titlelbl)
        Me.Panel_Meeting_Address.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Meeting_Address.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Meeting_Address.Name = "Panel_Meeting_Address"
        Me.Panel_Meeting_Address.Size = New System.Drawing.Size(1438, 39)
        Me.Panel_Meeting_Address.TabIndex = 22
        '
        'Panel_Dgv_Task
        '
        Me.Panel_Dgv_Task.Controls.Add(Me.Dgv_Task)
        Me.Panel_Dgv_Task.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_Dgv_Task.Location = New System.Drawing.Point(0, 91)
        Me.Panel_Dgv_Task.Name = "Panel_Dgv_Task"
        Me.Panel_Dgv_Task.Size = New System.Drawing.Size(1416, 175)
        Me.Panel_Dgv_Task.TabIndex = 27
        '
        'Dgv_Task
        '
        Me.Dgv_Task.AllowUserToAddRows = False
        Me.Dgv_Task.AllowUserToDeleteRows = False
        Me.Dgv_Task.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.Dgv_Task.BackgroundColor = System.Drawing.Color.White
        Me.Dgv_Task.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dgv_Task.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_Task.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.Dgv_Task.ColumnHeadersHeight = 40
        Me.Dgv_Task.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dgv_Task.DefaultCellStyle = DataGridViewCellStyle4
        Me.Dgv_Task.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgv_Task.EnableHeadersVisualStyles = False
        Me.Dgv_Task.GridColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Dgv_Task.Location = New System.Drawing.Point(0, 0)
        Me.Dgv_Task.Name = "Dgv_Task"
        Me.Dgv_Task.ReadOnly = True
        Me.Dgv_Task.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Dgv_Task.RowHeadersVisible = False
        Me.Dgv_Task.RowHeadersWidth = 51
        Me.Dgv_Task.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_Task.Size = New System.Drawing.Size(1416, 175)
        Me.Dgv_Task.TabIndex = 25
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BtnNewAdd)
        Me.Panel3.Controls.Add(Me.BtnClose)
        Me.Panel3.Controls.Add(Me.Btn_Search_Meeetings)
        Me.Panel3.Controls.Add(Me.BtnSave)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 702)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1438, 67)
        Me.Panel3.TabIndex = 23
        '
        'Btn_Search_Meeetings
        '
        Me.Btn_Search_Meeetings.BackColor = System.Drawing.Color.Olive
        Me.Btn_Search_Meeetings.Location = New System.Drawing.Point(405, 9)
        Me.Btn_Search_Meeetings.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Btn_Search_Meeetings.Name = "Btn_Search_Meeetings"
        Me.Btn_Search_Meeetings.Size = New System.Drawing.Size(223, 50)
        Me.Btn_Search_Meeetings.TabIndex = 16
        Me.Btn_Search_Meeetings.Text = "استعلام عن اجتماع سابق"
        Me.Btn_Search_Meeetings.UseVisualStyleBackColor = False
        '
        'Panel11
        '
        Me.Panel11.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel11.Controls.Add(Me.Panel_Dgv_Task)
        Me.Panel11.Controls.Add(Me.Panel5)
        Me.Panel11.Controls.Add(Me.Label6)
        Me.Panel11.Location = New System.Drawing.Point(10, 430)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(1416, 266)
        Me.Panel11.TabIndex = 24
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.btn_Save_Task)
        Me.Panel5.Controls.Add(Me.Due_Date)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.txt_Task_Description)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.Cmb_Assigned_To)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 43)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1416, 48)
        Me.Panel5.TabIndex = 27
        '
        'btn_Save_Task
        '
        Me.btn_Save_Task.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_Save_Task.Location = New System.Drawing.Point(4, 4)
        Me.btn_Save_Task.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.btn_Save_Task.Name = "btn_Save_Task"
        Me.btn_Save_Task.Size = New System.Drawing.Size(102, 40)
        Me.btn_Save_Task.TabIndex = 14
        Me.btn_Save_Task.Text = "حفظ"
        Me.btn_Save_Task.UseVisualStyleBackColor = False
        '
        'Due_Date
        '
        Me.Due_Date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Due_Date.Location = New System.Drawing.Point(109, 4)
        Me.Due_Date.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Due_Date.Name = "Due_Date"
        Me.Due_Date.Size = New System.Drawing.Size(151, 39)
        Me.Due_Date.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Label3.Location = New System.Drawing.Point(1273, 4)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 40)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "وصف المهمة"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Label4.Location = New System.Drawing.Point(264, 4)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(191, 39)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "اخر تاريخ لانهاء المهمة"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_Task_Description
        '
        Me.txt_Task_Description.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_Task_Description.Font = New System.Drawing.Font("Cairo ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Task_Description.Location = New System.Drawing.Point(821, 4)
        Me.txt_Task_Description.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.txt_Task_Description.Name = "txt_Task_Description"
        Me.txt_Task_Description.Size = New System.Drawing.Size(448, 45)
        Me.txt_Task_Description.TabIndex = 20
        Me.txt_Task_Description.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Label2.Location = New System.Drawing.Point(730, 5)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 40)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "تسند إلى "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cmb_Assigned_To
        '
        Me.Cmb_Assigned_To.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cmb_Assigned_To.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_Assigned_To.FormattingEnabled = True
        Me.Cmb_Assigned_To.Location = New System.Drawing.Point(461, 4)
        Me.Cmb_Assigned_To.Name = "Cmb_Assigned_To"
        Me.Cmb_Assigned_To.Size = New System.Drawing.Size(264, 40)
        Me.Cmb_Assigned_To.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Cairo", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(1416, 43)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "المهام"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Meetings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1438, 769)
        Me.Controls.Add(Me.Panel11)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.MaximizeBox = False
        Me.Name = "Meetings"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "شاشة الاجتماعات"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel_dgv_Attendees.ResumeLayout(False)
        CType(Me.dgv_Attendees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel_Meeting_Address.ResumeLayout(False)
        Me.Panel_Meeting_Address.PerformLayout()
        Me.Panel_Dgv_Task.ResumeLayout(False)
        CType(Me.Dgv_Task, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Meeting_ID As System.Windows.Forms.TextBox
    Friend WithEvents Meeting_IDlbl As System.Windows.Forms.Label
    Friend WithEvents Meeting_Title As System.Windows.Forms.TextBox
    Friend WithEvents Meeting_Titlelbl As System.Windows.Forms.Label
    Friend WithEvents Meeting_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Meeting_Datelbl As System.Windows.Forms.Label
    Friend WithEvents Meeting_Location As System.Windows.Forms.TextBox
    Friend WithEvents Meeting_Locationlbl As System.Windows.Forms.Label
    Friend WithEvents Meeting_Description As System.Windows.Forms.TextBox
    Friend WithEvents Meeting_Descriptionlbl As System.Windows.Forms.Label
    Friend WithEvents Created_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Created_Datelbl As System.Windows.Forms.Label
    Friend WithEvents BtnNewAdd As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Btn_Search_Meeetings As Button
    Friend WithEvents dgv_Attendees As DataGridView
    Friend WithEvents Dgv_Task As DataGridView
    Friend WithEvents Panel_Dgv_Task As Panel
    Friend WithEvents Panel_Meeting_Address As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents cmb_Employee As ComboBox
    Friend WithEvents Btn_Save_Attend As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel_dgv_Attendees As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btn_Save_Task As Button
    Friend WithEvents Due_Date As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_Task_Description As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Cmb_Assigned_To As ComboBox
    Friend WithEvents Label6 As Label
    Public Property Meeting_Timelbl As Label
End Class