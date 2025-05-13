<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Meeetings_Search
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
        Me.Meeting_ID_View = New System.Windows.Forms.TextBox()
        Me.Meeting_Datelbl = New System.Windows.Forms.Label()
        Me.Meeting_Date_View = New System.Windows.Forms.DateTimePicker()
        Me.Meeting_Descriptionlbl = New System.Windows.Forms.Label()
        Me.Meeting_Description_View = New System.Windows.Forms.TextBox()
        Me.Created_Datelbl = New System.Windows.Forms.Label()
        Me.Created_Date = New System.Windows.Forms.DateTimePicker()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel_Meeting_Details = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel_Attend = New System.Windows.Forms.Panel()
        Me.lbl_DGV_Attenf = New System.Windows.Forms.Panel()
        Me.dgv_Attendees = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Meeting_Location_View = New System.Windows.Forms.Label()
        Me.Meeting_Locationlbl = New System.Windows.Forms.Label()
        Me.Meeting_Title_View = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Dgv_Task = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_Print = New System.Windows.Forms.Button()
        Me.Combo_Meeting_Addres = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.End_Meeting_Date = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Srat_Meeting_Date = New System.Windows.Forms.DateTimePicker()
        Me.Btn_Search_Meeting = New System.Windows.Forms.Button()
        Me.btn_View_Meeting_Data = New System.Windows.Forms.Button()
        Me.Panel_Task = New System.Windows.Forms.Panel()
        Me.Panel_DGV_Task = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel_Search_Meeting = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel_Meeting_Details.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel_Attend.SuspendLayout()
        Me.lbl_DGV_Attenf.SuspendLayout()
        CType(Me.dgv_Attendees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.Dgv_Task, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel_Task.SuspendLayout()
        Me.Panel_DGV_Task.SuspendLayout()
        Me.Panel_Search_Meeting.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.SuspendLayout()
        '
        'Meeting_IDlbl
        '
        Me.Meeting_IDlbl.Location = New System.Drawing.Point(1356, 9)
        Me.Meeting_IDlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Meeting_IDlbl.Name = "Meeting_IDlbl"
        Me.Meeting_IDlbl.Size = New System.Drawing.Size(71, 32)
        Me.Meeting_IDlbl.TabIndex = 0
        Me.Meeting_IDlbl.Text = "كود الاجتماع"
        Me.Meeting_IDlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Meeting_IDlbl.Visible = False
        '
        'Meeting_ID_View
        '
        Me.Meeting_ID_View.Location = New System.Drawing.Point(1252, 4)
        Me.Meeting_ID_View.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Meeting_ID_View.Name = "Meeting_ID_View"
        Me.Meeting_ID_View.Size = New System.Drawing.Size(101, 39)
        Me.Meeting_ID_View.TabIndex = 1
        Me.Meeting_ID_View.Visible = False
        '
        'Meeting_Datelbl
        '
        Me.Meeting_Datelbl.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Meeting_Datelbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Meeting_Datelbl.Dock = System.Windows.Forms.DockStyle.Left
        Me.Meeting_Datelbl.Enabled = False
        Me.Meeting_Datelbl.Location = New System.Drawing.Point(175, 0)
        Me.Meeting_Datelbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Meeting_Datelbl.Name = "Meeting_Datelbl"
        Me.Meeting_Datelbl.Size = New System.Drawing.Size(117, 46)
        Me.Meeting_Datelbl.TabIndex = 4
        Me.Meeting_Datelbl.Text = "تاريخ الاجتماع"
        Me.Meeting_Datelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Meeting_Date_View
        '
        Me.Meeting_Date_View.Dock = System.Windows.Forms.DockStyle.Left
        Me.Meeting_Date_View.Enabled = False
        Me.Meeting_Date_View.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Meeting_Date_View.Location = New System.Drawing.Point(0, 0)
        Me.Meeting_Date_View.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Meeting_Date_View.Name = "Meeting_Date_View"
        Me.Meeting_Date_View.Size = New System.Drawing.Size(175, 39)
        Me.Meeting_Date_View.TabIndex = 5
        '
        'Meeting_Descriptionlbl
        '
        Me.Meeting_Descriptionlbl.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Meeting_Descriptionlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Meeting_Descriptionlbl.Dock = System.Windows.Forms.DockStyle.Right
        Me.Meeting_Descriptionlbl.Location = New System.Drawing.Point(1296, 0)
        Me.Meeting_Descriptionlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Meeting_Descriptionlbl.Name = "Meeting_Descriptionlbl"
        Me.Meeting_Descriptionlbl.Size = New System.Drawing.Size(130, 297)
        Me.Meeting_Descriptionlbl.TabIndex = 8
        Me.Meeting_Descriptionlbl.Text = "موضوع النقاش"
        Me.Meeting_Descriptionlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Meeting_Description_View
        '
        Me.Meeting_Description_View.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Meeting_Description_View.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Meeting_Description_View.Dock = System.Windows.Forms.DockStyle.Right
        Me.Meeting_Description_View.Enabled = False
        Me.Meeting_Description_View.Font = New System.Drawing.Font("Cairo ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Meeting_Description_View.Location = New System.Drawing.Point(484, 0)
        Me.Meeting_Description_View.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Meeting_Description_View.Multiline = True
        Me.Meeting_Description_View.Name = "Meeting_Description_View"
        Me.Meeting_Description_View.ReadOnly = True
        Me.Meeting_Description_View.Size = New System.Drawing.Size(812, 297)
        Me.Meeting_Description_View.TabIndex = 9
        Me.Meeting_Description_View.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Created_Datelbl
        '
        Me.Created_Datelbl.Location = New System.Drawing.Point(68, 6)
        Me.Created_Datelbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Created_Datelbl.Name = "Created_Datelbl"
        Me.Created_Datelbl.Size = New System.Drawing.Size(46, 37)
        Me.Created_Datelbl.TabIndex = 10
        Me.Created_Datelbl.Text = "تاريخ الانشاء"
        Me.Created_Datelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Created_Datelbl.Visible = False
        '
        'Created_Date
        '
        Me.Created_Date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Created_Date.Location = New System.Drawing.Point(11, 6)
        Me.Created_Date.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Created_Date.Name = "Created_Date"
        Me.Created_Date.Size = New System.Drawing.Size(53, 39)
        Me.Created_Date.TabIndex = 11
        Me.Created_Date.Visible = False
        '
        'BtnEdit
        '
        Me.BtnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEdit.BackColor = System.Drawing.Color.Transparent
        Me.BtnEdit.Image = Global.El_Dawliya_International_System.My.Resources.Resources.edit_24px
        Me.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEdit.Location = New System.Drawing.Point(1295, 5)
        Me.BtnEdit.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(132, 50)
        Me.BtnEdit.TabIndex = 15
        Me.BtnEdit.Text = "تعديل"
        Me.BtnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEdit.UseVisualStyleBackColor = False
        Me.BtnEdit.Visible = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.Transparent
        Me.BtnClose.Location = New System.Drawing.Point(22, 2)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(132, 50)
        Me.BtnClose.TabIndex = 17
        Me.BtnClose.Text = "انهاء"
        Me.BtnClose.UseVisualStyleBackColor = False
        Me.BtnClose.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Created_Date)
        Me.Panel1.Controls.Add(Me.Meeting_IDlbl)
        Me.Panel1.Controls.Add(Me.Created_Datelbl)
        Me.Panel1.Controls.Add(Me.Meeting_ID_View)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1438, 45)
        Me.Panel1.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Cairo", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1438, 45)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "شاشة بحـــث الاجتماعات"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel_Meeting_Details
        '
        Me.Panel_Meeting_Details.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_Meeting_Details.Controls.Add(Me.Panel2)
        Me.Panel_Meeting_Details.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Meeting_Details.Location = New System.Drawing.Point(0, 138)
        Me.Panel_Meeting_Details.Name = "Panel_Meeting_Details"
        Me.Panel_Meeting_Details.Size = New System.Drawing.Size(1438, 365)
        Me.Panel_Meeting_Details.TabIndex = 20
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1434, 358)
        Me.Panel2.TabIndex = 23
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.Meeting_Description_View)
        Me.Panel5.Controls.Add(Me.Meeting_Descriptionlbl)
        Me.Panel5.Controls.Add(Me.Panel_Attend)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 50)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1430, 301)
        Me.Panel5.TabIndex = 24
        '
        'Panel_Attend
        '
        Me.Panel_Attend.Controls.Add(Me.lbl_DGV_Attenf)
        Me.Panel_Attend.Controls.Add(Me.Label3)
        Me.Panel_Attend.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_Attend.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Attend.Name = "Panel_Attend"
        Me.Panel_Attend.Size = New System.Drawing.Size(470, 297)
        Me.Panel_Attend.TabIndex = 25
        '
        'lbl_DGV_Attenf
        '
        Me.lbl_DGV_Attenf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_DGV_Attenf.Controls.Add(Me.dgv_Attendees)
        Me.lbl_DGV_Attenf.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_DGV_Attenf.Location = New System.Drawing.Point(0, 41)
        Me.lbl_DGV_Attenf.Name = "lbl_DGV_Attenf"
        Me.lbl_DGV_Attenf.Size = New System.Drawing.Size(470, 256)
        Me.lbl_DGV_Attenf.TabIndex = 27
        '
        'dgv_Attendees
        '
        Me.dgv_Attendees.AllowUserToAddRows = False
        Me.dgv_Attendees.AllowUserToDeleteRows = False
        Me.dgv_Attendees.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_Attendees.BackgroundColor = System.Drawing.Color.White
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
        Me.dgv_Attendees.Size = New System.Drawing.Size(466, 252)
        Me.dgv_Attendees.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Cairo", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(470, 41)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "الحضور"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.Meeting_Datelbl)
        Me.Panel4.Controls.Add(Me.Meeting_Location_View)
        Me.Panel4.Controls.Add(Me.Meeting_Locationlbl)
        Me.Panel4.Controls.Add(Me.Meeting_Date_View)
        Me.Panel4.Controls.Add(Me.Meeting_Title_View)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1430, 50)
        Me.Panel4.TabIndex = 23
        '
        'Meeting_Location_View
        '
        Me.Meeting_Location_View.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Meeting_Location_View.Dock = System.Windows.Forms.DockStyle.Right
        Me.Meeting_Location_View.Font = New System.Drawing.Font("Cairo ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Meeting_Location_View.Location = New System.Drawing.Point(296, 0)
        Me.Meeting_Location_View.Name = "Meeting_Location_View"
        Me.Meeting_Location_View.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Meeting_Location_View.Size = New System.Drawing.Size(431, 46)
        Me.Meeting_Location_View.TabIndex = 25
        Me.Meeting_Location_View.Text = ".."
        Me.Meeting_Location_View.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Meeting_Locationlbl
        '
        Me.Meeting_Locationlbl.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Meeting_Locationlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Meeting_Locationlbl.Dock = System.Windows.Forms.DockStyle.Right
        Me.Meeting_Locationlbl.Location = New System.Drawing.Point(727, 0)
        Me.Meeting_Locationlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Meeting_Locationlbl.Name = "Meeting_Locationlbl"
        Me.Meeting_Locationlbl.Size = New System.Drawing.Size(138, 46)
        Me.Meeting_Locationlbl.TabIndex = 6
        Me.Meeting_Locationlbl.Text = "مكان الاجتماع"
        Me.Meeting_Locationlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Meeting_Title_View
        '
        Me.Meeting_Title_View.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Meeting_Title_View.Dock = System.Windows.Forms.DockStyle.Right
        Me.Meeting_Title_View.Font = New System.Drawing.Font("Cairo ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Meeting_Title_View.Location = New System.Drawing.Point(865, 0)
        Me.Meeting_Title_View.Name = "Meeting_Title_View"
        Me.Meeting_Title_View.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Meeting_Title_View.Size = New System.Drawing.Size(431, 46)
        Me.Meeting_Title_View.TabIndex = 24
        Me.Meeting_Title_View.Text = ".."
        Me.Meeting_Title_View.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label5.Location = New System.Drawing.Point(1296, 0)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 46)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "عنوان الاجتماع"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Dgv_Task
        '
        Me.Dgv_Task.AllowUserToAddRows = False
        Me.Dgv_Task.AllowUserToDeleteRows = False
        Me.Dgv_Task.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.Dgv_Task.BackgroundColor = System.Drawing.Color.White
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
        Me.Dgv_Task.Size = New System.Drawing.Size(1434, 192)
        Me.Dgv_Task.TabIndex = 24
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btn_Print)
        Me.Panel3.Controls.Add(Me.BtnClose)
        Me.Panel3.Controls.Add(Me.BtnEdit)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 746)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1438, 60)
        Me.Panel3.TabIndex = 23
        '
        'btn_Print
        '
        Me.btn_Print.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Print.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Print
        Me.btn_Print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Print.Location = New System.Drawing.Point(664, 4)
        Me.btn_Print.Name = "btn_Print"
        Me.btn_Print.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_Print.Size = New System.Drawing.Size(111, 53)
        Me.btn_Print.TabIndex = 26
        Me.btn_Print.Text = "طباعة"
        Me.btn_Print.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Print.UseVisualStyleBackColor = True
        '
        'Combo_Meeting_Addres
        '
        Me.Combo_Meeting_Addres.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Combo_Meeting_Addres.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Combo_Meeting_Addres.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Combo_Meeting_Addres.Font = New System.Drawing.Font("Cairo ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo_Meeting_Addres.FormattingEnabled = True
        Me.Combo_Meeting_Addres.Location = New System.Drawing.Point(0, 40)
        Me.Combo_Meeting_Addres.Name = "Combo_Meeting_Addres"
        Me.Combo_Meeting_Addres.Size = New System.Drawing.Size(753, 45)
        Me.Combo_Meeting_Addres.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(753, 40)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "ابحث عن عنوان الاجتماع"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'End_Meeting_Date
        '
        Me.End_Meeting_Date.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.End_Meeting_Date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.End_Meeting_Date.Location = New System.Drawing.Point(150, 42)
        Me.End_Meeting_Date.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.End_Meeting_Date.Name = "End_Meeting_Date"
        Me.End_Meeting_Date.Size = New System.Drawing.Size(160, 36)
        Me.End_Meeting_Date.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(150, 5)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(160, 36)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "إلى "
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Location = New System.Drawing.Point(317, 5)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(160, 36)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "الفترة من"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Srat_Meeting_Date
        '
        Me.Srat_Meeting_Date.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Srat_Meeting_Date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Srat_Meeting_Date.Location = New System.Drawing.Point(317, 42)
        Me.Srat_Meeting_Date.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Srat_Meeting_Date.Name = "Srat_Meeting_Date"
        Me.Srat_Meeting_Date.Size = New System.Drawing.Size(160, 36)
        Me.Srat_Meeting_Date.TabIndex = 11
        '
        'Btn_Search_Meeting
        '
        Me.Btn_Search_Meeting.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btn_Search_Meeting.Dock = System.Windows.Forms.DockStyle.Left
        Me.Btn_Search_Meeting.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Search_Meeting.Location = New System.Drawing.Point(0, 0)
        Me.Btn_Search_Meeting.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Btn_Search_Meeting.Name = "Btn_Search_Meeting"
        Me.Btn_Search_Meeting.Size = New System.Drawing.Size(144, 79)
        Me.Btn_Search_Meeting.TabIndex = 14
        Me.Btn_Search_Meeting.Text = "بحث عن الاجتماعات "
        Me.Btn_Search_Meeting.UseVisualStyleBackColor = False
        '
        'btn_View_Meeting_Data
        '
        Me.btn_View_Meeting_Data.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_View_Meeting_Data.Location = New System.Drawing.Point(0, 0)
        Me.btn_View_Meeting_Data.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.btn_View_Meeting_Data.Name = "btn_View_Meeting_Data"
        Me.btn_View_Meeting_Data.Size = New System.Drawing.Size(179, 89)
        Me.btn_View_Meeting_Data.TabIndex = 14
        Me.btn_View_Meeting_Data.Text = "عرض بيانات الاجتماع"
        Me.btn_View_Meeting_Data.UseVisualStyleBackColor = True
        '
        'Panel_Task
        '
        Me.Panel_Task.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_Task.Controls.Add(Me.Panel_DGV_Task)
        Me.Panel_Task.Controls.Add(Me.Label2)
        Me.Panel_Task.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel_Task.Location = New System.Drawing.Point(0, 509)
        Me.Panel_Task.Name = "Panel_Task"
        Me.Panel_Task.Size = New System.Drawing.Size(1438, 237)
        Me.Panel_Task.TabIndex = 24
        '
        'Panel_DGV_Task
        '
        Me.Panel_DGV_Task.Controls.Add(Me.Dgv_Task)
        Me.Panel_DGV_Task.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel_DGV_Task.Location = New System.Drawing.Point(0, 41)
        Me.Panel_DGV_Task.Name = "Panel_DGV_Task"
        Me.Panel_DGV_Task.Size = New System.Drawing.Size(1434, 192)
        Me.Panel_DGV_Task.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Cairo", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1434, 41)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "المهام"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel_Search_Meeting
        '
        Me.Panel_Search_Meeting.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel_Search_Meeting.Controls.Add(Me.Panel11)
        Me.Panel_Search_Meeting.Controls.Add(Me.Panel10)
        Me.Panel_Search_Meeting.Controls.Add(Me.Panel9)
        Me.Panel_Search_Meeting.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel_Search_Meeting.Location = New System.Drawing.Point(0, 45)
        Me.Panel_Search_Meeting.Name = "Panel_Search_Meeting"
        Me.Panel_Search_Meeting.Size = New System.Drawing.Size(1438, 93)
        Me.Panel_Search_Meeting.TabIndex = 25
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.btn_View_Meeting_Data)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel11.Location = New System.Drawing.Point(0, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(179, 89)
        Me.Panel11.TabIndex = 15
        '
        'Panel10
        '
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel10.Controls.Add(Me.Label8)
        Me.Panel10.Controls.Add(Me.Srat_Meeting_Date)
        Me.Panel10.Controls.Add(Me.Label7)
        Me.Panel10.Controls.Add(Me.Btn_Search_Meeting)
        Me.Panel10.Controls.Add(Me.End_Meeting_Date)
        Me.Panel10.Location = New System.Drawing.Point(185, 3)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(486, 83)
        Me.Panel10.TabIndex = 1
        '
        'Panel9
        '
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel9.Controls.Add(Me.Label6)
        Me.Panel9.Controls.Add(Me.Combo_Meeting_Addres)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel9.Location = New System.Drawing.Point(677, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(757, 89)
        Me.Panel9.TabIndex = 0
        '
        'Meeetings_Search
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1438, 806)
        Me.Controls.Add(Me.Panel_Meeting_Details)
        Me.Controls.Add(Me.Panel_Search_Meeting)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel_Task)
        Me.Controls.Add(Me.Panel3)
        Me.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.MaximizeBox = False
        Me.Name = "Meeetings_Search"
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel_Meeting_Details.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel_Attend.ResumeLayout(False)
        Me.lbl_DGV_Attenf.ResumeLayout(False)
        CType(Me.dgv_Attendees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.Dgv_Task, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel_Task.ResumeLayout(False)
        Me.Panel_DGV_Task.ResumeLayout(False)
        Me.Panel_Search_Meeting.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Meeting_ID_View As System.Windows.Forms.TextBox
    Friend WithEvents Meeting_IDlbl As System.Windows.Forms.Label
    Friend WithEvents Meeting_Date_View As System.Windows.Forms.DateTimePicker
    Friend WithEvents Meeting_Datelbl As System.Windows.Forms.Label
    Friend WithEvents Meeting_Description_View As System.Windows.Forms.TextBox
    Friend WithEvents Meeting_Descriptionlbl As System.Windows.Forms.Label
    Friend WithEvents Created_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Created_Datelbl As System.Windows.Forms.Label
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel_Meeting_Details As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Combo_Meeting_Addres As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents End_Meeting_Date As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Srat_Meeting_Date As DateTimePicker
    Friend WithEvents Btn_Search_Meeting As Button
    Friend WithEvents btn_View_Meeting_Data As Button
    Friend WithEvents Meeting_Locationlbl As Label
    Friend WithEvents dgv_Attendees As DataGridView
    Friend WithEvents Dgv_Task As DataGridView
    Friend WithEvents Panel_Task As Panel
    Friend WithEvents Panel_Attend As Panel
    Friend WithEvents lbl_DGV_Attenf As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel_DGV_Task As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel_Search_Meeting As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Meeting_Title_View As Label
    Friend WithEvents Meeting_Location_View As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btn_Print As Button
    Public Property Meeting_Timelbl As Label
End Class

