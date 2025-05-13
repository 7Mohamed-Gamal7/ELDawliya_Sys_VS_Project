<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Alerts
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TaskCodelbl = New System.Windows.Forms.Label()
        Me.TaskCode = New System.Windows.Forms.TextBox()
        Me.TaskCreationDatelbl = New System.Windows.Forms.Label()
        Me.TaskCreationDate = New System.Windows.Forms.DateTimePicker()
        Me.TaskStartDatelbl = New System.Windows.Forms.Label()
        Me.TaskEndDatelbl = New System.Windows.Forms.Label()
        Me.TaskDescriptionlbl = New System.Windows.Forms.Label()
        Me.TaskDescription = New System.Windows.Forms.TextBox()
        Me.TaskDepartmentlbl = New System.Windows.Forms.Label()
        Me.TaskStatuslbl = New System.Windows.Forms.Label()
        Me.Emp_IDlbl = New System.Windows.Forms.Label()
        Me.Emp_ID = New System.Windows.Forms.TextBox()
        Me.TaskExecutorlbl = New System.Windows.Forms.Label()
        Me.ReminderDaysBeforeDueDatelbl = New System.Windows.Forms.Label()
        Me.ReminderDaysBeforeDueDate = New System.Windows.Forms.TextBox()
        Me.TaskExecutor = New System.Windows.Forms.ComboBox()
        Me.TaskStatus = New System.Windows.Forms.ComboBox()
        Me.TaskDepartment = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TaskStartDate = New System.Windows.Forms.TextBox()
        Me.TaskEndDate = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Btn_Print = New System.Windows.Forms.Button()
        Me.Btn_Task_Alert = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnNewAdd = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.ComboSearch = New System.Windows.Forms.ComboBox()
        Me.Txt_Search = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Step2 = New System.Windows.Forms.TextBox()
        Me.Step1 = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dgv_Tbl_Alerts = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.dgv_Tbl_Alerts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TaskCodelbl
        '
        Me.TaskCodelbl.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaskCodelbl.Location = New System.Drawing.Point(295, 5)
        Me.TaskCodelbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TaskCodelbl.Name = "TaskCodelbl"
        Me.TaskCodelbl.Size = New System.Drawing.Size(60, 23)
        Me.TaskCodelbl.TabIndex = 0
        Me.TaskCodelbl.Text = "كود المهمة"
        Me.TaskCodelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.TaskCodelbl.Visible = False
        '
        'TaskCode
        '
        Me.TaskCode.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaskCode.Location = New System.Drawing.Point(255, 6)
        Me.TaskCode.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.TaskCode.Name = "TaskCode"
        Me.TaskCode.Size = New System.Drawing.Size(37, 32)
        Me.TaskCode.TabIndex = 1
        Me.TaskCode.Visible = False
        '
        'TaskCreationDatelbl
        '
        Me.TaskCreationDatelbl.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaskCreationDatelbl.Location = New System.Drawing.Point(100, 9)
        Me.TaskCreationDatelbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TaskCreationDatelbl.Name = "TaskCreationDatelbl"
        Me.TaskCreationDatelbl.Size = New System.Drawing.Size(53, 26)
        Me.TaskCreationDatelbl.TabIndex = 2
        Me.TaskCreationDatelbl.Text = "تاريخ انشاء المهمة"
        Me.TaskCreationDatelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.TaskCreationDatelbl.Visible = False
        '
        'TaskCreationDate
        '
        Me.TaskCreationDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaskCreationDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TaskCreationDate.Location = New System.Drawing.Point(9, 5)
        Me.TaskCreationDate.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.TaskCreationDate.Name = "TaskCreationDate"
        Me.TaskCreationDate.Size = New System.Drawing.Size(86, 32)
        Me.TaskCreationDate.TabIndex = 3
        Me.TaskCreationDate.Visible = False
        '
        'TaskStartDatelbl
        '
        Me.TaskStartDatelbl.BackColor = System.Drawing.Color.Teal
        Me.TaskStartDatelbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TaskStartDatelbl.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaskStartDatelbl.Location = New System.Drawing.Point(1061, 7)
        Me.TaskStartDatelbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TaskStartDatelbl.Name = "TaskStartDatelbl"
        Me.TaskStartDatelbl.Size = New System.Drawing.Size(143, 32)
        Me.TaskStartDatelbl.TabIndex = 4
        Me.TaskStartDatelbl.Text = "تاريخ بدأ المهمة"
        Me.TaskStartDatelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TaskEndDatelbl
        '
        Me.TaskEndDatelbl.BackColor = System.Drawing.Color.Teal
        Me.TaskEndDatelbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TaskEndDatelbl.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaskEndDatelbl.Location = New System.Drawing.Point(792, 7)
        Me.TaskEndDatelbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TaskEndDatelbl.Name = "TaskEndDatelbl"
        Me.TaskEndDatelbl.Size = New System.Drawing.Size(119, 32)
        Me.TaskEndDatelbl.TabIndex = 6
        Me.TaskEndDatelbl.Text = "تاريخ انتهاء المهمة"
        Me.TaskEndDatelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TaskDescriptionlbl
        '
        Me.TaskDescriptionlbl.BackColor = System.Drawing.Color.Teal
        Me.TaskDescriptionlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TaskDescriptionlbl.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaskDescriptionlbl.Location = New System.Drawing.Point(4, 7)
        Me.TaskDescriptionlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TaskDescriptionlbl.Name = "TaskDescriptionlbl"
        Me.TaskDescriptionlbl.Size = New System.Drawing.Size(636, 35)
        Me.TaskDescriptionlbl.TabIndex = 8
        Me.TaskDescriptionlbl.Text = "وصف المهمة"
        Me.TaskDescriptionlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TaskDescription
        '
        Me.TaskDescription.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaskDescription.Location = New System.Drawing.Point(4, 45)
        Me.TaskDescription.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.TaskDescription.Multiline = True
        Me.TaskDescription.Name = "TaskDescription"
        Me.TaskDescription.Size = New System.Drawing.Size(637, 130)
        Me.TaskDescription.TabIndex = 8
        '
        'TaskDepartmentlbl
        '
        Me.TaskDepartmentlbl.BackColor = System.Drawing.Color.Teal
        Me.TaskDepartmentlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TaskDepartmentlbl.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaskDepartmentlbl.Location = New System.Drawing.Point(1061, 53)
        Me.TaskDepartmentlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TaskDepartmentlbl.Name = "TaskDepartmentlbl"
        Me.TaskDepartmentlbl.Size = New System.Drawing.Size(143, 32)
        Me.TaskDepartmentlbl.TabIndex = 10
        Me.TaskDepartmentlbl.Text = "قسم المهمة"
        Me.TaskDepartmentlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TaskStatuslbl
        '
        Me.TaskStatuslbl.BackColor = System.Drawing.Color.Teal
        Me.TaskStatuslbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TaskStatuslbl.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaskStatuslbl.Location = New System.Drawing.Point(797, 53)
        Me.TaskStatuslbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TaskStatuslbl.Name = "TaskStatuslbl"
        Me.TaskStatuslbl.Size = New System.Drawing.Size(114, 32)
        Me.TaskStatuslbl.TabIndex = 12
        Me.TaskStatuslbl.Text = "حالة المهمة"
        Me.TaskStatuslbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Emp_IDlbl
        '
        Me.Emp_IDlbl.BackColor = System.Drawing.Color.Teal
        Me.Emp_IDlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Emp_IDlbl.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Emp_IDlbl.Location = New System.Drawing.Point(797, 142)
        Me.Emp_IDlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Emp_IDlbl.Name = "Emp_IDlbl"
        Me.Emp_IDlbl.Size = New System.Drawing.Size(114, 32)
        Me.Emp_IDlbl.TabIndex = 16
        Me.Emp_IDlbl.Text = "كود الموظف"
        Me.Emp_IDlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Emp_ID
        '
        Me.Emp_ID.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Emp_ID.Location = New System.Drawing.Point(647, 142)
        Me.Emp_ID.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Emp_ID.Name = "Emp_ID"
        Me.Emp_ID.Size = New System.Drawing.Size(142, 32)
        Me.Emp_ID.TabIndex = 7
        Me.Emp_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TaskExecutorlbl
        '
        Me.TaskExecutorlbl.BackColor = System.Drawing.Color.Teal
        Me.TaskExecutorlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TaskExecutorlbl.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaskExecutorlbl.Location = New System.Drawing.Point(797, 98)
        Me.TaskExecutorlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TaskExecutorlbl.Name = "TaskExecutorlbl"
        Me.TaskExecutorlbl.Size = New System.Drawing.Size(114, 32)
        Me.TaskExecutorlbl.TabIndex = 18
        Me.TaskExecutorlbl.Text = "القائم بالمهمة"
        Me.TaskExecutorlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ReminderDaysBeforeDueDatelbl
        '
        Me.ReminderDaysBeforeDueDatelbl.BackColor = System.Drawing.Color.Teal
        Me.ReminderDaysBeforeDueDatelbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ReminderDaysBeforeDueDatelbl.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReminderDaysBeforeDueDatelbl.Location = New System.Drawing.Point(1061, 98)
        Me.ReminderDaysBeforeDueDatelbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ReminderDaysBeforeDueDatelbl.Name = "ReminderDaysBeforeDueDatelbl"
        Me.ReminderDaysBeforeDueDatelbl.Size = New System.Drawing.Size(143, 32)
        Me.ReminderDaysBeforeDueDatelbl.TabIndex = 20
        Me.ReminderDaysBeforeDueDatelbl.Text = "عدد الايام للتذكير بالمهمة قبل انتهائها "
        Me.ReminderDaysBeforeDueDatelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ReminderDaysBeforeDueDate
        '
        Me.ReminderDaysBeforeDueDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReminderDaysBeforeDueDate.Location = New System.Drawing.Point(915, 98)
        Me.ReminderDaysBeforeDueDate.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.ReminderDaysBeforeDueDate.Name = "ReminderDaysBeforeDueDate"
        Me.ReminderDaysBeforeDueDate.Size = New System.Drawing.Size(142, 32)
        Me.ReminderDaysBeforeDueDate.TabIndex = 5
        Me.ReminderDaysBeforeDueDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TaskExecutor
        '
        Me.TaskExecutor.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaskExecutor.FormattingEnabled = True
        Me.TaskExecutor.Items.AddRange(New Object() {"احمد مجدى", "محمد جمال", " عمرو الجندى", "مصطفى الجندى"})
        Me.TaskExecutor.Location = New System.Drawing.Point(647, 98)
        Me.TaskExecutor.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TaskExecutor.Name = "TaskExecutor"
        Me.TaskExecutor.Size = New System.Drawing.Size(142, 32)
        Me.TaskExecutor.TabIndex = 6
        '
        'TaskStatus
        '
        Me.TaskStatus.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaskStatus.FormattingEnabled = True
        Me.TaskStatus.Items.AddRange(New Object() {"جارى العمل عليها ", "هام ", "مؤجل ", "انتهت"})
        Me.TaskStatus.Location = New System.Drawing.Point(647, 53)
        Me.TaskStatus.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TaskStatus.Name = "TaskStatus"
        Me.TaskStatus.Size = New System.Drawing.Size(142, 32)
        Me.TaskStatus.TabIndex = 4
        '
        'TaskDepartment
        '
        Me.TaskDepartment.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaskDepartment.FormattingEnabled = True
        Me.TaskDepartment.Items.AddRange(New Object() {"التامين الاجتماعى", "التامين الصحى", "المواصلات الشهرية", "سيارات نقل الموظفين", "مشاكل الموظفين"})
        Me.TaskDepartment.Location = New System.Drawing.Point(915, 53)
        Me.TaskDepartment.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TaskDepartment.Name = "TaskDepartment"
        Me.TaskDepartment.Size = New System.Drawing.Size(142, 32)
        Me.TaskDepartment.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TaskCodelbl)
        Me.Panel1.Controls.Add(Me.TaskCode)
        Me.Panel1.Controls.Add(Me.TaskCreationDate)
        Me.Panel1.Controls.Add(Me.TaskCreationDatelbl)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1519, 37)
        Me.Panel1.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Teal
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Cairo", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1519, 37)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "شاشة ادارة المهام"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(158, 5)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "كود المهمة"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.Visible = False
        '
        'TaskStartDate
        '
        Me.TaskStartDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaskStartDate.Location = New System.Drawing.Point(915, 7)
        Me.TaskStartDate.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.TaskStartDate.Name = "TaskStartDate"
        Me.TaskStartDate.Size = New System.Drawing.Size(142, 32)
        Me.TaskStartDate.TabIndex = 1
        Me.TaskStartDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TaskEndDate
        '
        Me.TaskEndDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaskEndDate.Location = New System.Drawing.Point(645, 7)
        Me.TaskEndDate.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.TaskEndDate.Name = "TaskEndDate"
        Me.TaskEndDate.Size = New System.Drawing.Size(142, 32)
        Me.TaskEndDate.TabIndex = 2
        Me.TaskEndDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Teal
        Me.Panel2.Controls.Add(Me.Btn_Print)
        Me.Panel2.Controls.Add(Me.Btn_Task_Alert)
        Me.Panel2.Controls.Add(Me.BtnSave)
        Me.Panel2.Controls.Add(Me.BtnEdit)
        Me.Panel2.Controls.Add(Me.BtnNewAdd)
        Me.Panel2.Controls.Add(Me.BtnDelete)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 673)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1519, 68)
        Me.Panel2.TabIndex = 1
        '
        'Btn_Print
        '
        Me.Btn_Print.BackColor = System.Drawing.Color.Teal
        Me.Btn_Print.FlatAppearance.BorderSize = 0
        Me.Btn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Print.Font = New System.Drawing.Font("Cairo", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Print.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Print
        Me.Btn_Print.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Print.Location = New System.Drawing.Point(261, 12)
        Me.Btn_Print.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Btn_Print.Name = "Btn_Print"
        Me.Btn_Print.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Btn_Print.Size = New System.Drawing.Size(123, 47)
        Me.Btn_Print.TabIndex = 103
        Me.Btn_Print.Text = "طباعة"
        Me.Btn_Print.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Print.UseVisualStyleBackColor = False
        '
        'Btn_Task_Alert
        '
        Me.Btn_Task_Alert.BackColor = System.Drawing.Color.Teal
        Me.Btn_Task_Alert.FlatAppearance.BorderSize = 0
        Me.Btn_Task_Alert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Task_Alert.Font = New System.Drawing.Font("Cairo", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Task_Alert.Image = Global.El_Dawliya_International_System.My.Resources.Resources.sound_50px
        Me.Btn_Task_Alert.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Task_Alert.Location = New System.Drawing.Point(527, 12)
        Me.Btn_Task_Alert.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Btn_Task_Alert.Name = "Btn_Task_Alert"
        Me.Btn_Task_Alert.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Btn_Task_Alert.Size = New System.Drawing.Size(185, 47)
        Me.Btn_Task_Alert.TabIndex = 103
        Me.Btn_Task_Alert.Text = "تنبيه المهام"
        Me.Btn_Task_Alert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Task_Alert.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.Teal
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Cairo", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Ok
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSave.Location = New System.Drawing.Point(1123, 12)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnSave.Size = New System.Drawing.Size(118, 47)
        Me.BtnSave.TabIndex = 101
        Me.BtnSave.Text = "حفظ"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.Color.Teal
        Me.BtnEdit.FlatAppearance.BorderSize = 0
        Me.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEdit.Font = New System.Drawing.Font("Cairo", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Save_as
        Me.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEdit.Location = New System.Drawing.Point(855, 12)
        Me.BtnEdit.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(125, 47)
        Me.BtnEdit.TabIndex = 104
        Me.BtnEdit.Text = "تعديل"
        Me.BtnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'BtnNewAdd
        '
        Me.BtnNewAdd.BackColor = System.Drawing.Color.Teal
        Me.BtnNewAdd.FlatAppearance.BorderSize = 0
        Me.BtnNewAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNewAdd.Font = New System.Drawing.Font("Cairo", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNewAdd.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Add
        Me.BtnNewAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNewAdd.Location = New System.Drawing.Point(1384, 12)
        Me.BtnNewAdd.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BtnNewAdd.Name = "BtnNewAdd"
        Me.BtnNewAdd.Size = New System.Drawing.Size(111, 47)
        Me.BtnNewAdd.TabIndex = 100
        Me.BtnNewAdd.Text = "جديد"
        Me.BtnNewAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNewAdd.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.Teal
        Me.BtnDelete.FlatAppearance.BorderSize = 0
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Font = New System.Drawing.Font("Cairo", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Remove
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.Location = New System.Drawing.Point(5, 12)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(113, 47)
        Me.BtnDelete.TabIndex = 105
        Me.BtnDelete.Text = "حذف"
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.UseVisualStyleBackColor = False
        Me.BtnDelete.Visible = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(0, 37)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1519, 259)
        Me.Panel3.TabIndex = 26
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Teal
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Controls.Add(Me.RadioButton4)
        Me.Panel6.Controls.Add(Me.RadioButton3)
        Me.Panel6.Controls.Add(Me.RadioButton2)
        Me.Panel6.Controls.Add(Me.RadioButton1)
        Me.Panel6.Controls.Add(Me.ComboSearch)
        Me.Panel6.Controls.Add(Me.Txt_Search)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(308, 259)
        Me.Panel6.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Teal
        Me.Label5.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 7)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(275, 24)
        Me.Label5.TabIndex = 125
        Me.Label5.Text = "ابحث هنا"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadioButton4
        '
        Me.RadioButton4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.Location = New System.Drawing.Point(9, 219)
        Me.RadioButton4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RadioButton4.Size = New System.Drawing.Size(275, 28)
        Me.RadioButton4.TabIndex = 124
        Me.RadioButton4.Text = "هام"
        Me.RadioButton4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(9, 186)
        Me.RadioButton3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RadioButton3.Size = New System.Drawing.Size(275, 28)
        Me.RadioButton3.TabIndex = 124
        Me.RadioButton3.Text = "مؤجل"
        Me.RadioButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(9, 153)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RadioButton2.Size = New System.Drawing.Size(275, 28)
        Me.RadioButton2.TabIndex = 124
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "جارى العمل عليها"
        Me.RadioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(9, 120)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RadioButton1.Size = New System.Drawing.Size(275, 28)
        Me.RadioButton1.TabIndex = 124
        Me.RadioButton1.Text = "انتهت"
        Me.RadioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'ComboSearch
        '
        Me.ComboSearch.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboSearch.FormattingEnabled = True
        Me.ComboSearch.Items.AddRange(New Object() {"قسم المهمة", "كود الموظف", "تاريخ المهمة", "القائم بالمهمة"})
        Me.ComboSearch.Location = New System.Drawing.Point(9, 38)
        Me.ComboSearch.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ComboSearch.Name = "ComboSearch"
        Me.ComboSearch.Size = New System.Drawing.Size(276, 32)
        Me.ComboSearch.TabIndex = 123
        Me.ComboSearch.Text = "قسم المهمة"
        '
        'Txt_Search
        '
        Me.Txt_Search.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Search.Location = New System.Drawing.Point(9, 79)
        Me.Txt_Search.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Txt_Search.Name = "Txt_Search"
        Me.Txt_Search.Size = New System.Drawing.Size(276, 32)
        Me.Txt_Search.TabIndex = 122
        Me.Txt_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Teal
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.TaskDescription)
        Me.Panel5.Controls.Add(Me.TaskStartDate)
        Me.Panel5.Controls.Add(Me.TaskDescriptionlbl)
        Me.Panel5.Controls.Add(Me.TaskStartDatelbl)
        Me.Panel5.Controls.Add(Me.Step2)
        Me.Panel5.Controls.Add(Me.Step1)
        Me.Panel5.Controls.Add(Me.ReminderDaysBeforeDueDate)
        Me.Panel5.Controls.Add(Me.Emp_ID)
        Me.Panel5.Controls.Add(Me.TaskEndDate)
        Me.Panel5.Controls.Add(Me.Emp_IDlbl)
        Me.Panel5.Controls.Add(Me.TaskDepartment)
        Me.Panel5.Controls.Add(Me.TaskExecutorlbl)
        Me.Panel5.Controls.Add(Me.ReminderDaysBeforeDueDatelbl)
        Me.Panel5.Controls.Add(Me.TaskStatuslbl)
        Me.Panel5.Controls.Add(Me.TaskStatus)
        Me.Panel5.Controls.Add(Me.TaskDepartmentlbl)
        Me.Panel5.Controls.Add(Me.TaskEndDatelbl)
        Me.Panel5.Controls.Add(Me.TaskExecutor)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.Location = New System.Drawing.Point(308, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1211, 259)
        Me.Panel5.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Teal
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1061, 219)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 31)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "خطوة 2"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Teal
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1061, 181)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 29)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "خطوة 1"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Step2
        '
        Me.Step2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Step2.Location = New System.Drawing.Point(4, 221)
        Me.Step2.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Step2.Name = "Step2"
        Me.Step2.Size = New System.Drawing.Size(1053, 32)
        Me.Step2.TabIndex = 10
        Me.Step2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Step1
        '
        Me.Step1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Step1.Location = New System.Drawing.Point(4, 181)
        Me.Step1.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Step1.Name = "Step1"
        Me.Step1.Size = New System.Drawing.Size(1053, 32)
        Me.Step1.TabIndex = 9
        Me.Step1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.dgv_Tbl_Alerts)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(0, 296)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1519, 377)
        Me.Panel4.TabIndex = 27
        '
        'dgv_Tbl_Alerts
        '
        Me.dgv_Tbl_Alerts.AllowUserToAddRows = False
        Me.dgv_Tbl_Alerts.AllowUserToDeleteRows = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv_Tbl_Alerts.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv_Tbl_Alerts.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Tbl_Alerts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgv_Tbl_Alerts.ColumnHeadersHeight = 50
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Tbl_Alerts.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgv_Tbl_Alerts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Tbl_Alerts.EnableHeadersVisualStyles = False
        Me.dgv_Tbl_Alerts.Location = New System.Drawing.Point(0, 0)
        Me.dgv_Tbl_Alerts.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.dgv_Tbl_Alerts.Name = "dgv_Tbl_Alerts"
        Me.dgv_Tbl_Alerts.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Tbl_Alerts.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgv_Tbl_Alerts.RowHeadersVisible = False
        Me.dgv_Tbl_Alerts.RowHeadersWidth = 51
        Me.dgv_Tbl_Alerts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_Tbl_Alerts.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgv_Tbl_Alerts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Tbl_Alerts.Size = New System.Drawing.Size(1519, 377)
        Me.dgv_Tbl_Alerts.TabIndex = 140
        '
        'Frm_Alerts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1519, 741)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.MaximizeBox = False
        Me.Name = "Frm_Alerts"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        CType(Me.dgv_Tbl_Alerts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TaskCode As System.Windows.Forms.TextBox
    Friend WithEvents TaskCodelbl As System.Windows.Forms.Label
    Friend WithEvents TaskCreationDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents TaskCreationDatelbl As System.Windows.Forms.Label
    Friend WithEvents TaskStartDatelbl As System.Windows.Forms.Label
    Friend WithEvents TaskEndDatelbl As System.Windows.Forms.Label
    Friend WithEvents TaskDescription As System.Windows.Forms.TextBox
    Friend WithEvents TaskDescriptionlbl As System.Windows.Forms.Label
    Friend WithEvents TaskDepartmentlbl As System.Windows.Forms.Label
    Friend WithEvents TaskStatuslbl As System.Windows.Forms.Label
    Friend WithEvents Emp_ID As System.Windows.Forms.TextBox
    Friend WithEvents Emp_IDlbl As System.Windows.Forms.Label
    Friend WithEvents TaskExecutorlbl As System.Windows.Forms.Label
    Friend WithEvents ReminderDaysBeforeDueDate As System.Windows.Forms.TextBox
    Friend WithEvents ReminderDaysBeforeDueDatelbl As System.Windows.Forms.Label
    Friend WithEvents TaskExecutor As ComboBox
    Friend WithEvents TaskStatus As ComboBox
    Friend WithEvents TaskDepartment As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TaskStartDate As TextBox
    Friend WithEvents TaskEndDate As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents dgv_Tbl_Alerts As DataGridView
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnNewAdd As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents ComboSearch As ComboBox
    Friend WithEvents Txt_Search As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Step2 As TextBox
    Friend WithEvents Step1 As TextBox
    Friend WithEvents Btn_Task_Alert As Button
    Friend WithEvents Btn_Print As Button
End Class
