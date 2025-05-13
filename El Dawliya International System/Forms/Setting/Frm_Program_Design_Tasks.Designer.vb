<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Program_Design_Tasks
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Program_Design_Tasks))
        Me.TaskID = New System.Windows.Forms.TextBox()
        Me.Task_Namelbl = New System.Windows.Forms.Label()
        Me.Task_Name = New System.Windows.Forms.TextBox()
        Me.Task_Typelbl = New System.Windows.Forms.Label()
        Me.Task_Type = New System.Windows.Forms.ComboBox()
        Me.Task_Descriptionlbl = New System.Windows.Forms.Label()
        Me.Task_Description = New System.Windows.Forms.TextBox()
        Me.Task_Statuslbl = New System.Windows.Forms.Label()
        Me.Task_Status = New System.Windows.Forms.ComboBox()
        Me.Task_Prioritylbl = New System.Windows.Forms.Label()
        Me.Task_Priority = New System.Windows.Forms.ComboBox()
        Me.StartDatelbl = New System.Windows.Forms.Label()
        Me.StartDate = New System.Windows.Forms.DateTimePicker()
        Me.DueDatelbl = New System.Windows.Forms.Label()
        Me.DueDate = New System.Windows.Forms.DateTimePicker()
        Me.Noteslbl = New System.Windows.Forms.Label()
        Me.Notes = New System.Windows.Forms.TextBox()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.NumericDay = New System.Windows.Forms.NumericUpDown()
        Me.btn_Print = New System.Windows.Forms.Button()
        Me.txt_Search = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnNewAdd = New System.Windows.Forms.Button()
        Me.Dept_Code = New System.Windows.Forms.ComboBox()
        Me.Lbl_Dept_Code = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dgv_Program_Design_Tasks = New System.Windows.Forms.DataGridView()
        Me.Pnl_Controls = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.NumericDay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgv_Program_Design_Tasks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pnl_Controls.SuspendLayout()
        Me.SuspendLayout()
        '
        'TaskID
        '
        Me.TaskID.Location = New System.Drawing.Point(3, 3)
        Me.TaskID.Name = "TaskID"
        Me.TaskID.Size = New System.Drawing.Size(52, 39)
        Me.TaskID.TabIndex = 1
        Me.TaskID.Visible = False
        '
        'Task_Namelbl
        '
        Me.Task_Namelbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Task_Namelbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Task_Namelbl.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Task_Namelbl.Location = New System.Drawing.Point(836, 3)
        Me.Task_Namelbl.Name = "Task_Namelbl"
        Me.Task_Namelbl.Size = New System.Drawing.Size(215, 28)
        Me.Task_Namelbl.TabIndex = 2
        Me.Task_Namelbl.Text = "عنوان المهمة"
        Me.Task_Namelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Task_Name
        '
        Me.Task_Name.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Task_Name.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Task_Name.Location = New System.Drawing.Point(3, 3)
        Me.Task_Name.Name = "Task_Name"
        Me.Task_Name.Size = New System.Drawing.Size(829, 36)
        Me.Task_Name.TabIndex = 3
        Me.Task_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Task_Typelbl
        '
        Me.Task_Typelbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Task_Typelbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Task_Typelbl.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Task_Typelbl.Location = New System.Drawing.Point(836, 47)
        Me.Task_Typelbl.Name = "Task_Typelbl"
        Me.Task_Typelbl.Size = New System.Drawing.Size(215, 28)
        Me.Task_Typelbl.TabIndex = 4
        Me.Task_Typelbl.Text = "نوع المهمة"
        Me.Task_Typelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Task_Type
        '
        Me.Task_Type.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Task_Type.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Task_Type.Items.AddRange(New Object() {"انشاء نموذج وجدول بيانات جديد", "تعديل فى البرمجة", "انشاء جدول بيانات", "تعديل تصميم", "عمل تقرير"})
        Me.Task_Type.Location = New System.Drawing.Point(610, 47)
        Me.Task_Type.Name = "Task_Type"
        Me.Task_Type.Size = New System.Drawing.Size(222, 37)
        Me.Task_Type.TabIndex = 5
        '
        'Task_Descriptionlbl
        '
        Me.Task_Descriptionlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Task_Descriptionlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Task_Descriptionlbl.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Task_Descriptionlbl.Location = New System.Drawing.Point(836, 140)
        Me.Task_Descriptionlbl.Name = "Task_Descriptionlbl"
        Me.Task_Descriptionlbl.Size = New System.Drawing.Size(215, 28)
        Me.Task_Descriptionlbl.TabIndex = 6
        Me.Task_Descriptionlbl.Text = "وصف المهمة"
        Me.Task_Descriptionlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Task_Description
        '
        Me.Task_Description.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Task_Description.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Task_Description.Location = New System.Drawing.Point(3, 140)
        Me.Task_Description.Name = "Task_Description"
        Me.Task_Description.Size = New System.Drawing.Size(829, 36)
        Me.Task_Description.TabIndex = 7
        Me.Task_Description.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Task_Statuslbl
        '
        Me.Task_Statuslbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Task_Statuslbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Task_Statuslbl.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Task_Statuslbl.Location = New System.Drawing.Point(180, 47)
        Me.Task_Statuslbl.Name = "Task_Statuslbl"
        Me.Task_Statuslbl.Size = New System.Drawing.Size(143, 28)
        Me.Task_Statuslbl.TabIndex = 8
        Me.Task_Statuslbl.Text = "حالة المهمة"
        Me.Task_Statuslbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Task_Status
        '
        Me.Task_Status.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Task_Status.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Task_Status.Items.AddRange(New Object() {"يجرى العمل عليه", "مكتمل", "لم يبدأ بعد"})
        Me.Task_Status.Location = New System.Drawing.Point(3, 47)
        Me.Task_Status.Name = "Task_Status"
        Me.Task_Status.Size = New System.Drawing.Size(171, 37)
        Me.Task_Status.TabIndex = 9
        '
        'Task_Prioritylbl
        '
        Me.Task_Prioritylbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Task_Prioritylbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Task_Prioritylbl.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Task_Prioritylbl.Location = New System.Drawing.Point(836, 96)
        Me.Task_Prioritylbl.Name = "Task_Prioritylbl"
        Me.Task_Prioritylbl.Size = New System.Drawing.Size(215, 28)
        Me.Task_Prioritylbl.TabIndex = 10
        Me.Task_Prioritylbl.Text = "اولوية المهمة"
        Me.Task_Prioritylbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Task_Priority
        '
        Me.Task_Priority.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Task_Priority.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Task_Priority.Items.AddRange(New Object() {"مهم", "عادى", "غير مهم حاليا"})
        Me.Task_Priority.Location = New System.Drawing.Point(610, 96)
        Me.Task_Priority.Name = "Task_Priority"
        Me.Task_Priority.Size = New System.Drawing.Size(222, 37)
        Me.Task_Priority.TabIndex = 11
        '
        'StartDatelbl
        '
        Me.StartDatelbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StartDatelbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.StartDatelbl.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartDatelbl.Location = New System.Drawing.Point(435, 96)
        Me.StartDatelbl.Name = "StartDatelbl"
        Me.StartDatelbl.Size = New System.Drawing.Size(166, 28)
        Me.StartDatelbl.TabIndex = 12
        Me.StartDatelbl.Text = "تاريخ البدء فى المهمة"
        Me.StartDatelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StartDate
        '
        Me.StartDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StartDate.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.StartDate.Location = New System.Drawing.Point(295, 96)
        Me.StartDate.Name = "StartDate"
        Me.StartDate.Size = New System.Drawing.Size(134, 36)
        Me.StartDate.TabIndex = 13
        '
        'DueDatelbl
        '
        Me.DueDatelbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DueDatelbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DueDatelbl.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DueDatelbl.Location = New System.Drawing.Point(130, 96)
        Me.DueDatelbl.Name = "DueDatelbl"
        Me.DueDatelbl.Size = New System.Drawing.Size(159, 28)
        Me.DueDatelbl.TabIndex = 14
        Me.DueDatelbl.Text = "اخر تاريخ للانتهاء من المهمة"
        Me.DueDatelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DueDate
        '
        Me.DueDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DueDate.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DueDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DueDate.Location = New System.Drawing.Point(3, 96)
        Me.DueDate.Name = "DueDate"
        Me.DueDate.Size = New System.Drawing.Size(121, 36)
        Me.DueDate.TabIndex = 15
        '
        'Noteslbl
        '
        Me.Noteslbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Noteslbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Noteslbl.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Noteslbl.Location = New System.Drawing.Point(836, 182)
        Me.Noteslbl.Name = "Noteslbl"
        Me.Noteslbl.Size = New System.Drawing.Size(215, 28)
        Me.Noteslbl.TabIndex = 16
        Me.Noteslbl.Text = "ملاحظات"
        Me.Noteslbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Notes
        '
        Me.Notes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Notes.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Notes.Location = New System.Drawing.Point(3, 182)
        Me.Notes.Name = "Notes"
        Me.Notes.Size = New System.Drawing.Size(829, 36)
        Me.Notes.TabIndex = 17
        Me.Notes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnEdit
        '
        Me.BtnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEdit.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Edit
        Me.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEdit.Location = New System.Drawing.Point(687, 16)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnEdit.Size = New System.Drawing.Size(111, 53)
        Me.BtnEdit.TabIndex = 21
        Me.BtnEdit.Text = "تعديل"
        Me.BtnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.BtnEdit, "تعديل السجل")
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnDelete.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Remove
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.Location = New System.Drawing.Point(437, 16)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnDelete.Size = New System.Drawing.Size(111, 53)
        Me.BtnDelete.TabIndex = 22
        Me.BtnDelete.Text = "حذف"
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.BtnDelete, "حذف السجل الحالى")
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TaskID)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1062, 42)
        Me.Panel1.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Cairo ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1062, 42)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "متابعة مهام تصميم النظام"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CheckBox1)
        Me.Panel2.Controls.Add(Me.NumericDay)
        Me.Panel2.Controls.Add(Me.btn_Print)
        Me.Panel2.Controls.Add(Me.txt_Search)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.BtnDelete)
        Me.Panel2.Controls.Add(Me.BtnEdit)
        Me.Panel2.Controls.Add(Me.BtnSave)
        Me.Panel2.Controls.Add(Me.BtnNewAdd)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 582)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Panel2.Size = New System.Drawing.Size(1062, 91)
        Me.Panel2.TabIndex = 25
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.Location = New System.Drawing.Point(80, 51)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckBox1.Size = New System.Drawing.Size(221, 36)
        Me.CheckBox1.TabIndex = 28
        Me.CheckBox1.Text = "باقى على انتهاء المهمة"
        Me.CheckBox1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.CheckBox1, "اضغط هنا بعد اختيار عدد الايام الباقية على انتهاء المهام")
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'NumericDay
        '
        Me.NumericDay.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NumericDay.Location = New System.Drawing.Point(10, 49)
        Me.NumericDay.Maximum = New Decimal(New Integer() {30, 0, 0, 0})
        Me.NumericDay.Name = "NumericDay"
        Me.NumericDay.Size = New System.Drawing.Size(54, 39)
        Me.NumericDay.TabIndex = 26
        Me.ToolTip1.SetToolTip(Me.NumericDay, "اختر من هنا عدد الايام الباقية على انتهاء المهام")
        '
        'btn_Print
        '
        Me.btn_Print.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Print.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Print
        Me.btn_Print.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_Print.Location = New System.Drawing.Point(562, 16)
        Me.btn_Print.Name = "btn_Print"
        Me.btn_Print.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_Print.Size = New System.Drawing.Size(111, 53)
        Me.btn_Print.TabIndex = 25
        Me.btn_Print.Text = "طباعة"
        Me.btn_Print.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.btn_Print, "طباعة التقرير")
        Me.btn_Print.UseVisualStyleBackColor = True
        '
        'txt_Search
        '
        Me.txt_Search.Location = New System.Drawing.Point(7, 6)
        Me.txt_Search.Name = "txt_Search"
        Me.txt_Search.Size = New System.Drawing.Size(194, 39)
        Me.txt_Search.TabIndex = 24
        Me.txt_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Search_More
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(207, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(100, 39)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "بحث"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Save
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Location = New System.Drawing.Point(812, 16)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnSave.Size = New System.Drawing.Size(111, 53)
        Me.BtnSave.TabIndex = 20
        Me.BtnSave.Text = "حفظ"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.BtnSave, "حفظ السجل الحالى ")
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnNewAdd
        '
        Me.BtnNewAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNewAdd.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Add
        Me.BtnNewAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNewAdd.Location = New System.Drawing.Point(937, 16)
        Me.BtnNewAdd.Name = "BtnNewAdd"
        Me.BtnNewAdd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnNewAdd.Size = New System.Drawing.Size(111, 53)
        Me.BtnNewAdd.TabIndex = 19
        Me.BtnNewAdd.Text = "إضافة"
        Me.BtnNewAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.BtnNewAdd, "لاضافة سجل جديد")
        Me.BtnNewAdd.UseVisualStyleBackColor = True
        '
        'Dept_Code
        '
        Me.Dept_Code.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Dept_Code.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dept_Code.Location = New System.Drawing.Point(329, 47)
        Me.Dept_Code.Name = "Dept_Code"
        Me.Dept_Code.Size = New System.Drawing.Size(173, 37)
        Me.Dept_Code.TabIndex = 5
        '
        'Lbl_Dept_Code
        '
        Me.Lbl_Dept_Code.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Dept_Code.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_Dept_Code.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Dept_Code.Location = New System.Drawing.Point(508, 47)
        Me.Lbl_Dept_Code.Name = "Lbl_Dept_Code"
        Me.Lbl_Dept_Code.Size = New System.Drawing.Size(93, 28)
        Me.Lbl_Dept_Code.TabIndex = 4
        Me.Lbl_Dept_Code.Text = "القسم"
        Me.Lbl_Dept_Code.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Pnl_Controls)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 42)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1062, 540)
        Me.Panel3.TabIndex = 26
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.dgv_Program_Design_Tasks)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 224)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1058, 312)
        Me.Panel4.TabIndex = 19
        '
        'dgv_Program_Design_Tasks
        '
        Me.dgv_Program_Design_Tasks.AllowUserToAddRows = False
        Me.dgv_Program_Design_Tasks.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgv_Program_Design_Tasks.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Program_Design_Tasks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgv_Program_Design_Tasks.BackgroundColor = System.Drawing.Color.White
        Me.dgv_Program_Design_Tasks.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv_Program_Design_Tasks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Cairo", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Program_Design_Tasks.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_Program_Design_Tasks.ColumnHeadersHeight = 40
        Me.dgv_Program_Design_Tasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Cairo", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Program_Design_Tasks.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_Program_Design_Tasks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Program_Design_Tasks.EnableHeadersVisualStyles = False
        Me.dgv_Program_Design_Tasks.GridColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dgv_Program_Design_Tasks.Location = New System.Drawing.Point(0, 0)
        Me.dgv_Program_Design_Tasks.Name = "dgv_Program_Design_Tasks"
        Me.dgv_Program_Design_Tasks.ReadOnly = True
        Me.dgv_Program_Design_Tasks.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Cairo", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Program_Design_Tasks.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_Program_Design_Tasks.RowHeadersVisible = False
        Me.dgv_Program_Design_Tasks.RowHeadersWidth = 51
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgv_Program_Design_Tasks.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_Program_Design_Tasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Program_Design_Tasks.Size = New System.Drawing.Size(1054, 308)
        Me.dgv_Program_Design_Tasks.TabIndex = 1
        '
        'Pnl_Controls
        '
        Me.Pnl_Controls.Controls.Add(Me.Task_Name)
        Me.Pnl_Controls.Controls.Add(Me.DueDate)
        Me.Pnl_Controls.Controls.Add(Me.Dept_Code)
        Me.Pnl_Controls.Controls.Add(Me.Notes)
        Me.Pnl_Controls.Controls.Add(Me.Lbl_Dept_Code)
        Me.Pnl_Controls.Controls.Add(Me.DueDatelbl)
        Me.Pnl_Controls.Controls.Add(Me.Task_Priority)
        Me.Pnl_Controls.Controls.Add(Me.Noteslbl)
        Me.Pnl_Controls.Controls.Add(Me.Task_Prioritylbl)
        Me.Pnl_Controls.Controls.Add(Me.Task_Status)
        Me.Pnl_Controls.Controls.Add(Me.Task_Type)
        Me.Pnl_Controls.Controls.Add(Me.Task_Statuslbl)
        Me.Pnl_Controls.Controls.Add(Me.Task_Typelbl)
        Me.Pnl_Controls.Controls.Add(Me.StartDate)
        Me.Pnl_Controls.Controls.Add(Me.Task_Namelbl)
        Me.Pnl_Controls.Controls.Add(Me.StartDatelbl)
        Me.Pnl_Controls.Controls.Add(Me.Task_Descriptionlbl)
        Me.Pnl_Controls.Controls.Add(Me.Task_Description)
        Me.Pnl_Controls.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pnl_Controls.Location = New System.Drawing.Point(0, 0)
        Me.Pnl_Controls.Name = "Pnl_Controls"
        Me.Pnl_Controls.Size = New System.Drawing.Size(1058, 224)
        Me.Pnl_Controls.TabIndex = 18
        '
        'Frm_Program_Design_Tasks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1062, 673)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Cairo", 10.0!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_Program_Design_Tasks"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "متابعة مهام تصميم النظام"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.NumericDay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.dgv_Program_Design_Tasks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pnl_Controls.ResumeLayout(False)
        Me.Pnl_Controls.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TaskID As System.Windows.Forms.TextBox
    Friend WithEvents Task_Name As System.Windows.Forms.TextBox
    Friend WithEvents Task_Namelbl As System.Windows.Forms.Label
    Friend WithEvents Task_Type As System.Windows.Forms.ComboBox
    Friend WithEvents Task_Typelbl As System.Windows.Forms.Label
    Friend WithEvents Task_Description As System.Windows.Forms.TextBox
    Friend WithEvents Task_Descriptionlbl As System.Windows.Forms.Label
    Friend WithEvents Task_Status As System.Windows.Forms.ComboBox
    Friend WithEvents Task_Statuslbl As System.Windows.Forms.Label
    Friend WithEvents Task_Priority As System.Windows.Forms.ComboBox
    Friend WithEvents Task_Prioritylbl As System.Windows.Forms.Label
    Friend WithEvents StartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents StartDatelbl As System.Windows.Forms.Label
    Friend WithEvents DueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DueDatelbl As System.Windows.Forms.Label
    Friend WithEvents Notes As System.Windows.Forms.TextBox
    Friend WithEvents Noteslbl As System.Windows.Forms.Label
    Friend WithEvents BtnNewAdd As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Dept_Code As ComboBox
    Friend WithEvents Lbl_Dept_Code As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Pnl_Controls As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents dgv_Program_Design_Tasks As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_Search As TextBox
    Friend WithEvents btn_Print As Button
    Friend WithEvents NumericDay As NumericUpDown
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ToolTip1 As ToolTip
End Class
