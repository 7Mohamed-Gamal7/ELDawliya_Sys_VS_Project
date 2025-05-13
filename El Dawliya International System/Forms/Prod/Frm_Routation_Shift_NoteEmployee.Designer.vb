<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Routation_Shift_NoteEmployee
    Inherits BaseForm

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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Txt_Count = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.CurrentWeekShiftlbl = New System.Windows.Forms.Label()
        Me.CurrentWeekShift = New System.Windows.Forms.ComboBox()
        Me.Btn_ShiftChange_ForEmp = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.dgv_Tbl_Employee = New ADGV.AdvancedDataGridView()
        Me.Txt_Search = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboSearch = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Emp_Image = New System.Windows.Forms.PictureBox()
        Me.Btn_Add_Note = New System.Windows.Forms.Button()
        Me.Emp_IDlbl = New System.Windows.Forms.Label()
        Me.Emp_Full_Namelbl = New System.Windows.Forms.Label()
        Me.Emp_ID = New System.Windows.Forms.TextBox()
        Me.Emp_Full_Name = New System.Windows.Forms.TextBox()
        Me.NextWeekShiftlbl = New System.Windows.Forms.Label()
        Me.NextWeekShift = New System.Windows.Forms.ComboBox()
        Me.Friday_Operationlbl = New System.Windows.Forms.Label()
        Me.Friday_Operation = New System.Windows.Forms.ComboBox()
        Me.Shift_Typelbl = New System.Windows.Forms.Label()
        Me.Shift_Type = New System.Windows.Forms.ComboBox()
        Me.Emp_Carlbl = New System.Windows.Forms.Label()
        Me.Emp_Car = New System.Windows.Forms.ComboBox()
        Me.Car_Ride_Timelbl = New System.Windows.Forms.Label()
        Me.Car_Ride_Time = New System.Windows.Forms.DateTimePicker()
        Me.Car_Pick_Up_Pointlbl = New System.Windows.Forms.Label()
        Me.Car_Pick_Up_Point = New System.Windows.Forms.ComboBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.dgv_Tbl_Employee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.Emp_Image, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1440, 72)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(401, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(672, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "شاشة تعديل الورديات الاسبوعية للموظفين واضافة ملاحظات "
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Txt_Count)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 639)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1440, 66)
        Me.Panel2.TabIndex = 1
        '
        'Txt_Count
        '
        Me.Txt_Count.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Count.Location = New System.Drawing.Point(8, 3)
        Me.Txt_Count.Multiline = True
        Me.Txt_Count.Name = "Txt_Count"
        Me.Txt_Count.ReadOnly = True
        Me.Txt_Count.Size = New System.Drawing.Size(188, 39)
        Me.Txt_Count.TabIndex = 124
        Me.Txt_Count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(202, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(218, 39)
        Me.Label5.TabIndex = 123
        Me.Label5.Text = "عدد سجل البحث"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(556, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(262, 60)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "تعديل"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.NextWeekShiftlbl)
        Me.Panel3.Controls.Add(Me.NextWeekShift)
        Me.Panel3.Controls.Add(Me.Friday_Operationlbl)
        Me.Panel3.Controls.Add(Me.Friday_Operation)
        Me.Panel3.Controls.Add(Me.Shift_Typelbl)
        Me.Panel3.Controls.Add(Me.Shift_Type)
        Me.Panel3.Controls.Add(Me.Emp_Carlbl)
        Me.Panel3.Controls.Add(Me.Emp_Car)
        Me.Panel3.Controls.Add(Me.Car_Ride_Timelbl)
        Me.Panel3.Controls.Add(Me.Car_Ride_Time)
        Me.Panel3.Controls.Add(Me.Car_Pick_Up_Pointlbl)
        Me.Panel3.Controls.Add(Me.Car_Pick_Up_Point)
        Me.Panel3.Controls.Add(Me.CurrentWeekShiftlbl)
        Me.Panel3.Controls.Add(Me.CurrentWeekShift)
        Me.Panel3.Controls.Add(Me.Btn_ShiftChange_ForEmp)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 72)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1440, 567)
        Me.Panel3.TabIndex = 2
        '
        'CurrentWeekShiftlbl
        '
        Me.CurrentWeekShiftlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CurrentWeekShiftlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.CurrentWeekShiftlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CurrentWeekShiftlbl.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentWeekShiftlbl.ForeColor = System.Drawing.Color.Black
        Me.CurrentWeekShiftlbl.Location = New System.Drawing.Point(1245, 149)
        Me.CurrentWeekShiftlbl.Name = "CurrentWeekShiftlbl"
        Me.CurrentWeekShiftlbl.Size = New System.Drawing.Size(181, 32)
        Me.CurrentWeekShiftlbl.TabIndex = 136
        Me.CurrentWeekShiftlbl.Text = "وردية الاسبوع الحالى"
        Me.CurrentWeekShiftlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CurrentWeekShift
        '
        Me.CurrentWeekShift.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CurrentWeekShift.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CurrentWeekShift.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CurrentWeekShift.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentWeekShift.Items.AddRange(New Object() {"الوردية الأولى", "الوردية الثانية", "الوردية الثالثة", "الوردية الأولى الادارة", "الوردية الأولى 12 صباحى", "الوردية الثانية 12 مسائى", "لا يوجد وردية"})
        Me.CurrentWeekShift.Location = New System.Drawing.Point(1006, 149)
        Me.CurrentWeekShift.Name = "CurrentWeekShift"
        Me.CurrentWeekShift.Size = New System.Drawing.Size(233, 32)
        Me.CurrentWeekShift.TabIndex = 137
        '
        'Btn_ShiftChange_ForEmp
        '
        Me.Btn_ShiftChange_ForEmp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_ShiftChange_ForEmp.FlatAppearance.BorderSize = 0
        Me.Btn_ShiftChange_ForEmp.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_ShiftChange_ForEmp.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_ShiftChange_ForEmp.Image = Global.El_Dawliya_International_System.My.Resources.Resources.refresh_32px
        Me.Btn_ShiftChange_ForEmp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_ShiftChange_ForEmp.Location = New System.Drawing.Point(855, 149)
        Me.Btn_ShiftChange_ForEmp.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Btn_ShiftChange_ForEmp.Name = "Btn_ShiftChange_ForEmp"
        Me.Btn_ShiftChange_ForEmp.Size = New System.Drawing.Size(144, 35)
        Me.Btn_ShiftChange_ForEmp.TabIndex = 138
        Me.Btn_ShiftChange_ForEmp.Text = "تغيير الوردية"
        Me.Btn_ShiftChange_ForEmp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_ShiftChange_ForEmp.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.dgv_Tbl_Employee)
        Me.Panel5.Controls.Add(Me.Txt_Search)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.ComboSearch)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 119)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(421, 444)
        Me.Panel5.TabIndex = 122
        '
        'dgv_Tbl_Employee
        '
        Me.dgv_Tbl_Employee.AllowUserToAddRows = False
        Me.dgv_Tbl_Employee.AllowUserToDeleteRows = False
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_Tbl_Employee.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.dgv_Tbl_Employee.AutoGenerateContextFilters = True
        Me.dgv_Tbl_Employee.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!)
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Tbl_Employee.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgv_Tbl_Employee.ColumnHeadersHeight = 29
        Me.dgv_Tbl_Employee.DateWithTime = False
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!)
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Tbl_Employee.DefaultCellStyle = DataGridViewCellStyle13
        Me.dgv_Tbl_Employee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Tbl_Employee.EnableHeadersVisualStyles = False
        Me.dgv_Tbl_Employee.Location = New System.Drawing.Point(0, 121)
        Me.dgv_Tbl_Employee.Name = "dgv_Tbl_Employee"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!)
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Tbl_Employee.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dgv_Tbl_Employee.RowHeadersVisible = False
        Me.dgv_Tbl_Employee.RowHeadersWidth = 60
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_Tbl_Employee.RowsDefaultCellStyle = DataGridViewCellStyle15
        Me.dgv_Tbl_Employee.RowTemplate.Height = 26
        Me.dgv_Tbl_Employee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgv_Tbl_Employee.Size = New System.Drawing.Size(421, 323)
        Me.dgv_Tbl_Employee.TabIndex = 126
        Me.dgv_Tbl_Employee.TimeFilter = False
        '
        'Txt_Search
        '
        Me.Txt_Search.Dock = System.Windows.Forms.DockStyle.Top
        Me.Txt_Search.Location = New System.Drawing.Point(0, 83)
        Me.Txt_Search.Multiline = True
        Me.Txt_Search.Name = "Txt_Search"
        Me.Txt_Search.Size = New System.Drawing.Size(421, 38)
        Me.Txt_Search.TabIndex = 125
        Me.Txt_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(421, 21)
        Me.Label2.TabIndex = 124
        Me.Label2.Text = "................................................................................." &
    ""
        '
        'ComboSearch
        '
        Me.ComboSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.ComboSearch.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboSearch.FormattingEnabled = True
        Me.ComboSearch.Items.AddRange(New Object() {"اسم الموظف", "الجنسية", "القسم", "الوظيفة", "النوع", "السيارة", "نقطة تجمع السيارة", "الوردية للاسبوع الحالى", "تشغيل الجمعة"})
        Me.ComboSearch.Location = New System.Drawing.Point(0, 30)
        Me.ComboSearch.Name = "ComboSearch"
        Me.ComboSearch.Size = New System.Drawing.Size(421, 32)
        Me.ComboSearch.TabIndex = 122
        Me.ComboSearch.Text = "اسم الموظف"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(421, 30)
        Me.Label4.TabIndex = 121
        Me.Label4.Text = "ابحث "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.Emp_Image)
        Me.Panel4.Controls.Add(Me.Btn_Add_Note)
        Me.Panel4.Controls.Add(Me.Emp_IDlbl)
        Me.Panel4.Controls.Add(Me.Emp_Full_Namelbl)
        Me.Panel4.Controls.Add(Me.Emp_ID)
        Me.Panel4.Controls.Add(Me.Emp_Full_Name)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1436, 119)
        Me.Panel4.TabIndex = 0
        '
        'Emp_Image
        '
        Me.Emp_Image.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Emp_Image.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Emp_Image.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Emp_Image.Dock = System.Windows.Forms.DockStyle.Left
        Me.Emp_Image.Location = New System.Drawing.Point(0, 0)
        Me.Emp_Image.Name = "Emp_Image"
        Me.Emp_Image.Size = New System.Drawing.Size(240, 115)
        Me.Emp_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Emp_Image.TabIndex = 131
        Me.Emp_Image.TabStop = False
        '
        'Btn_Add_Note
        '
        Me.Btn_Add_Note.FlatAppearance.BorderSize = 0
        Me.Btn_Add_Note.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Add_Note.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Add_Note.Image = Global.El_Dawliya_International_System.My.Resources.Resources.add_24px
        Me.Btn_Add_Note.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_Add_Note.Location = New System.Drawing.Point(630, 6)
        Me.Btn_Add_Note.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Btn_Add_Note.Name = "Btn_Add_Note"
        Me.Btn_Add_Note.Size = New System.Drawing.Size(196, 80)
        Me.Btn_Add_Note.TabIndex = 130
        Me.Btn_Add_Note.Text = "اضافة ملاحظة للموظف"
        Me.Btn_Add_Note.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_Add_Note.UseVisualStyleBackColor = True
        '
        'Emp_IDlbl
        '
        Me.Emp_IDlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Emp_IDlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Emp_IDlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Emp_IDlbl.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Emp_IDlbl.ForeColor = System.Drawing.Color.Black
        Me.Emp_IDlbl.Location = New System.Drawing.Point(1237, 4)
        Me.Emp_IDlbl.Name = "Emp_IDlbl"
        Me.Emp_IDlbl.Size = New System.Drawing.Size(183, 40)
        Me.Emp_IDlbl.TabIndex = 120
        Me.Emp_IDlbl.Text = "كود الموظف"
        Me.Emp_IDlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Emp_Full_Namelbl
        '
        Me.Emp_Full_Namelbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Emp_Full_Namelbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Emp_Full_Namelbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Emp_Full_Namelbl.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Emp_Full_Namelbl.ForeColor = System.Drawing.Color.Black
        Me.Emp_Full_Namelbl.Location = New System.Drawing.Point(1238, 54)
        Me.Emp_Full_Namelbl.Name = "Emp_Full_Namelbl"
        Me.Emp_Full_Namelbl.Size = New System.Drawing.Size(183, 38)
        Me.Emp_Full_Namelbl.TabIndex = 121
        Me.Emp_Full_Namelbl.Text = "اسم الموظف"
        Me.Emp_Full_Namelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Emp_ID
        '
        Me.Emp_ID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Emp_ID.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Emp_ID.Location = New System.Drawing.Point(833, 6)
        Me.Emp_ID.Name = "Emp_ID"
        Me.Emp_ID.Size = New System.Drawing.Size(398, 32)
        Me.Emp_ID.TabIndex = 118
        Me.Emp_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Emp_Full_Name
        '
        Me.Emp_Full_Name.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Emp_Full_Name.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Emp_Full_Name.Location = New System.Drawing.Point(833, 54)
        Me.Emp_Full_Name.Name = "Emp_Full_Name"
        Me.Emp_Full_Name.Size = New System.Drawing.Size(398, 32)
        Me.Emp_Full_Name.TabIndex = 119
        Me.Emp_Full_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NextWeekShiftlbl
        '
        Me.NextWeekShiftlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NextWeekShiftlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.NextWeekShiftlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.NextWeekShiftlbl.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextWeekShiftlbl.ForeColor = System.Drawing.Color.Black
        Me.NextWeekShiftlbl.Location = New System.Drawing.Point(1245, 205)
        Me.NextWeekShiftlbl.Name = "NextWeekShiftlbl"
        Me.NextWeekShiftlbl.Size = New System.Drawing.Size(181, 32)
        Me.NextWeekShiftlbl.TabIndex = 147
        Me.NextWeekShiftlbl.Text = "وردية الاسبوع القادم"
        Me.NextWeekShiftlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NextWeekShift
        '
        Me.NextWeekShift.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NextWeekShift.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.NextWeekShift.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.NextWeekShift.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextWeekShift.Items.AddRange(New Object() {"الوردية الأولى", "الوردية الثانية", "الوردية الثالثة", "الوردية الأولى الادارة", "الوردية الأولى 12 صباحى", "الوردية الثانية 12 مسائى", "لا يوجد وردية"})
        Me.NextWeekShift.Location = New System.Drawing.Point(1006, 205)
        Me.NextWeekShift.Name = "NextWeekShift"
        Me.NextWeekShift.Size = New System.Drawing.Size(233, 32)
        Me.NextWeekShift.TabIndex = 148
        '
        'Friday_Operationlbl
        '
        Me.Friday_Operationlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Friday_Operationlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Friday_Operationlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Friday_Operationlbl.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Friday_Operationlbl.ForeColor = System.Drawing.Color.Black
        Me.Friday_Operationlbl.Location = New System.Drawing.Point(1245, 317)
        Me.Friday_Operationlbl.Name = "Friday_Operationlbl"
        Me.Friday_Operationlbl.Size = New System.Drawing.Size(181, 32)
        Me.Friday_Operationlbl.TabIndex = 149
        Me.Friday_Operationlbl.Text = "تشغيل الجمعة"
        Me.Friday_Operationlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Friday_Operation
        '
        Me.Friday_Operation.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Friday_Operation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Friday_Operation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Friday_Operation.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Friday_Operation.Items.AddRange(New Object() {"الوردية الأولى", "الوردية الثانية", "الوردية الثالثة", "الوردية الأولى الادارة", "الوردية الأولى 12 صباحى", "الوردية الثانية 12 مسائى", "لا يوجد وردية"})
        Me.Friday_Operation.Location = New System.Drawing.Point(1006, 317)
        Me.Friday_Operation.Name = "Friday_Operation"
        Me.Friday_Operation.Size = New System.Drawing.Size(233, 32)
        Me.Friday_Operation.TabIndex = 150
        '
        'Shift_Typelbl
        '
        Me.Shift_Typelbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Shift_Typelbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Shift_Typelbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Shift_Typelbl.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Shift_Typelbl.ForeColor = System.Drawing.Color.Black
        Me.Shift_Typelbl.Location = New System.Drawing.Point(1245, 261)
        Me.Shift_Typelbl.Name = "Shift_Typelbl"
        Me.Shift_Typelbl.Size = New System.Drawing.Size(181, 32)
        Me.Shift_Typelbl.TabIndex = 151
        Me.Shift_Typelbl.Text = "نوع الدوام"
        Me.Shift_Typelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Shift_Type
        '
        Me.Shift_Type.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Shift_Type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Shift_Type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Shift_Type.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Shift_Type.Items.AddRange(New Object() {"ثابت", "أولي & ثانية", "ثانية & ثالثة"})
        Me.Shift_Type.Location = New System.Drawing.Point(1006, 261)
        Me.Shift_Type.Name = "Shift_Type"
        Me.Shift_Type.Size = New System.Drawing.Size(233, 32)
        Me.Shift_Type.TabIndex = 152
        '
        'Emp_Carlbl
        '
        Me.Emp_Carlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Emp_Carlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Emp_Carlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Emp_Carlbl.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Emp_Carlbl.ForeColor = System.Drawing.Color.Black
        Me.Emp_Carlbl.Location = New System.Drawing.Point(1245, 373)
        Me.Emp_Carlbl.Name = "Emp_Carlbl"
        Me.Emp_Carlbl.Size = New System.Drawing.Size(181, 32)
        Me.Emp_Carlbl.TabIndex = 139
        Me.Emp_Carlbl.Text = "السيارة"
        Me.Emp_Carlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Emp_Car
        '
        Me.Emp_Car.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Emp_Car.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Emp_Car.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Emp_Car.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Emp_Car.Location = New System.Drawing.Point(1006, 373)
        Me.Emp_Car.Name = "Emp_Car"
        Me.Emp_Car.Size = New System.Drawing.Size(233, 32)
        Me.Emp_Car.TabIndex = 140
        '
        'Car_Ride_Timelbl
        '
        Me.Car_Ride_Timelbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Car_Ride_Timelbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Car_Ride_Timelbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Car_Ride_Timelbl.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Car_Ride_Timelbl.ForeColor = System.Drawing.Color.Black
        Me.Car_Ride_Timelbl.Location = New System.Drawing.Point(1245, 429)
        Me.Car_Ride_Timelbl.Name = "Car_Ride_Timelbl"
        Me.Car_Ride_Timelbl.Size = New System.Drawing.Size(181, 32)
        Me.Car_Ride_Timelbl.TabIndex = 141
        Me.Car_Ride_Timelbl.Text = "وقت السيارة"
        Me.Car_Ride_Timelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Car_Ride_Time
        '
        Me.Car_Ride_Time.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Car_Ride_Time.CalendarFont = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!)
        Me.Car_Ride_Time.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Car_Ride_Time.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.Car_Ride_Time.Location = New System.Drawing.Point(1006, 429)
        Me.Car_Ride_Time.Name = "Car_Ride_Time"
        Me.Car_Ride_Time.Size = New System.Drawing.Size(233, 32)
        Me.Car_Ride_Time.TabIndex = 142
        '
        'Car_Pick_Up_Pointlbl
        '
        Me.Car_Pick_Up_Pointlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Car_Pick_Up_Pointlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Car_Pick_Up_Pointlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Car_Pick_Up_Pointlbl.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Car_Pick_Up_Pointlbl.ForeColor = System.Drawing.Color.Black
        Me.Car_Pick_Up_Pointlbl.Location = New System.Drawing.Point(1245, 485)
        Me.Car_Pick_Up_Pointlbl.Name = "Car_Pick_Up_Pointlbl"
        Me.Car_Pick_Up_Pointlbl.Size = New System.Drawing.Size(181, 32)
        Me.Car_Pick_Up_Pointlbl.TabIndex = 143
        Me.Car_Pick_Up_Pointlbl.Text = "نقطة السيارة"
        Me.Car_Pick_Up_Pointlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Car_Pick_Up_Point
        '
        Me.Car_Pick_Up_Point.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Car_Pick_Up_Point.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Car_Pick_Up_Point.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Car_Pick_Up_Point.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Car_Pick_Up_Point.Location = New System.Drawing.Point(1006, 485)
        Me.Car_Pick_Up_Point.Name = "Car_Pick_Up_Point"
        Me.Car_Pick_Up_Point.Size = New System.Drawing.Size(233, 32)
        Me.Car_Pick_Up_Point.TabIndex = 144
        '
        'Frm_Routation_Shift_NoteEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1440, 705)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Frm_Routation_Shift_NoteEmployee"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.dgv_Tbl_Employee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.Emp_Image, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Emp_IDlbl As Label
    Friend WithEvents Emp_Full_Namelbl As Label
    Friend WithEvents Emp_ID As TextBox
    Friend WithEvents Emp_Full_Name As TextBox
    Friend WithEvents Btn_Add_Note As Button
    Friend WithEvents Emp_Image As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents ComboSearch As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Txt_Search As TextBox
    Friend WithEvents dgv_Tbl_Employee As ADGV.AdvancedDataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Txt_Count As TextBox
    Friend WithEvents CurrentWeekShiftlbl As Label
    Friend WithEvents CurrentWeekShift As ComboBox
    Friend WithEvents Btn_ShiftChange_ForEmp As Button
    Friend WithEvents NextWeekShiftlbl As Label
    Friend WithEvents NextWeekShift As ComboBox
    Friend WithEvents Friday_Operationlbl As Label
    Friend WithEvents Friday_Operation As ComboBox
    Friend WithEvents Shift_Typelbl As Label
    Friend WithEvents Shift_Type As ComboBox
    Friend WithEvents Emp_Carlbl As Label
    Friend WithEvents Emp_Car As ComboBox
    Friend WithEvents Car_Ride_Timelbl As Label
    Friend WithEvents Car_Ride_Time As DateTimePicker
    Friend WithEvents Car_Pick_Up_Pointlbl As Label
    Friend WithEvents Car_Pick_Up_Point As ComboBox
    Friend WithEvents BindingSource1 As BindingSource
End Class
