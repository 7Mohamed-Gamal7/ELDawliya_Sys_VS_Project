<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Alerts_Test
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Alerts_Test))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TaskCreationDate = New System.Windows.Forms.DateTimePicker()
        Me.TaskCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.TaskStartDatelbl = New System.Windows.Forms.Label()
        Me.TaskEndDatelbl = New System.Windows.Forms.Label()
        Me.Emp_IDlbl = New System.Windows.Forms.Label()
        Me.TaskExecutorlbl = New System.Windows.Forms.Label()
        Me.ReminderDaysBeforeDueDatelbl = New System.Windows.Forms.Label()
        Me.TaskStatuslbl = New System.Windows.Forms.Label()
        Me.TaskDepartmentlbl = New System.Windows.Forms.Label()
        Me.TaskStartDate = New System.Windows.Forms.TextBox()
        Me.TaskEndDate = New System.Windows.Forms.TextBox()
        Me.Emp_ID = New System.Windows.Forms.TextBox()
        Me.TaskExecutor = New System.Windows.Forms.ComboBox()
        Me.ReminderDaysBeforeDueDate = New System.Windows.Forms.TextBox()
        Me.TaskStatus = New System.Windows.Forms.ComboBox()
        Me.TaskDepartment = New System.Windows.Forms.ComboBox()
        Me.TaskDescriptionlbl = New System.Windows.Forms.Label()
        Me.TaskDescription = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Step1 = New System.Windows.Forms.TextBox()
        Me.Step2 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgv_Tbl_Alerts = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.ComboSearch = New System.Windows.Forms.ComboBox()
        Me.Txt_Search = New System.Windows.Forms.TextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Btn_Print = New System.Windows.Forms.Button()
        Me.Btn_Task_Alert = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnNewAdd = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgv_Tbl_Alerts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TaskCreationDate)
        Me.Panel1.Controls.Add(Me.TaskCode)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1453, 44)
        Me.Panel1.TabIndex = 0
        '
        'TaskCreationDate
        '
        Me.TaskCreationDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TaskCreationDate.Location = New System.Drawing.Point(24, 3)
        Me.TaskCreationDate.Name = "TaskCreationDate"
        Me.TaskCreationDate.Size = New System.Drawing.Size(200, 39)
        Me.TaskCreationDate.TabIndex = 2
        Me.TaskCreationDate.Visible = False
        '
        'TaskCode
        '
        Me.TaskCode.Location = New System.Drawing.Point(1348, 2)
        Me.TaskCode.Name = "TaskCode"
        Me.TaskCode.Size = New System.Drawing.Size(100, 39)
        Me.TaskCode.TabIndex = 1
        Me.TaskCode.Visible = False
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1453, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "شاشة ادارة المهام"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FlowLayoutPanel1.Controls.Add(Me.TaskStartDatelbl)
        Me.FlowLayoutPanel1.Controls.Add(Me.TaskEndDatelbl)
        Me.FlowLayoutPanel1.Controls.Add(Me.Emp_IDlbl)
        Me.FlowLayoutPanel1.Controls.Add(Me.TaskExecutorlbl)
        Me.FlowLayoutPanel1.Controls.Add(Me.ReminderDaysBeforeDueDatelbl)
        Me.FlowLayoutPanel1.Controls.Add(Me.TaskStatuslbl)
        Me.FlowLayoutPanel1.Controls.Add(Me.TaskDepartmentlbl)
        Me.FlowLayoutPanel1.Controls.Add(Me.TaskStartDate)
        Me.FlowLayoutPanel1.Controls.Add(Me.TaskEndDate)
        Me.FlowLayoutPanel1.Controls.Add(Me.Emp_ID)
        Me.FlowLayoutPanel1.Controls.Add(Me.TaskExecutor)
        Me.FlowLayoutPanel1.Controls.Add(Me.ReminderDaysBeforeDueDate)
        Me.FlowLayoutPanel1.Controls.Add(Me.TaskStatus)
        Me.FlowLayoutPanel1.Controls.Add(Me.TaskDepartment)
        Me.FlowLayoutPanel1.Controls.Add(Me.TaskDescriptionlbl)
        Me.FlowLayoutPanel1.Controls.Add(Me.TaskDescription)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label3)
        Me.FlowLayoutPanel1.Controls.Add(Me.Label4)
        Me.FlowLayoutPanel1.Controls.Add(Me.Step1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Step2)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 44)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1453, 281)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'TaskStartDatelbl
        '
        Me.TaskStartDatelbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TaskStartDatelbl.BackColor = System.Drawing.Color.Teal
        Me.TaskStartDatelbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TaskStartDatelbl.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaskStartDatelbl.Location = New System.Drawing.Point(1266, 0)
        Me.TaskStartDatelbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TaskStartDatelbl.Name = "TaskStartDatelbl"
        Me.TaskStartDatelbl.Size = New System.Drawing.Size(181, 32)
        Me.TaskStartDatelbl.TabIndex = 21
        Me.TaskStartDatelbl.Text = "تاريخ بدأ المهمة"
        Me.TaskStartDatelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TaskEndDatelbl
        '
        Me.TaskEndDatelbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TaskEndDatelbl.BackColor = System.Drawing.Color.Teal
        Me.TaskEndDatelbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TaskEndDatelbl.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaskEndDatelbl.Location = New System.Drawing.Point(1059, 0)
        Me.TaskEndDatelbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TaskEndDatelbl.Name = "TaskEndDatelbl"
        Me.TaskEndDatelbl.Size = New System.Drawing.Size(203, 32)
        Me.TaskEndDatelbl.TabIndex = 22
        Me.TaskEndDatelbl.Text = "تاريخ انتهاء المهمة"
        Me.TaskEndDatelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Emp_IDlbl
        '
        Me.Emp_IDlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Emp_IDlbl.BackColor = System.Drawing.Color.Teal
        Me.Emp_IDlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Emp_IDlbl.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Emp_IDlbl.Location = New System.Drawing.Point(897, 0)
        Me.Emp_IDlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Emp_IDlbl.Name = "Emp_IDlbl"
        Me.Emp_IDlbl.Size = New System.Drawing.Size(158, 32)
        Me.Emp_IDlbl.TabIndex = 25
        Me.Emp_IDlbl.Text = "كود الموظف"
        Me.Emp_IDlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TaskExecutorlbl
        '
        Me.TaskExecutorlbl.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TaskExecutorlbl.BackColor = System.Drawing.Color.Teal
        Me.TaskExecutorlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TaskExecutorlbl.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaskExecutorlbl.Location = New System.Drawing.Point(714, 0)
        Me.TaskExecutorlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TaskExecutorlbl.Name = "TaskExecutorlbl"
        Me.TaskExecutorlbl.Size = New System.Drawing.Size(179, 32)
        Me.TaskExecutorlbl.TabIndex = 26
        Me.TaskExecutorlbl.Text = "القائم بالمهمة"
        Me.TaskExecutorlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ReminderDaysBeforeDueDatelbl
        '
        Me.ReminderDaysBeforeDueDatelbl.BackColor = System.Drawing.Color.Teal
        Me.ReminderDaysBeforeDueDatelbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ReminderDaysBeforeDueDatelbl.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReminderDaysBeforeDueDatelbl.Location = New System.Drawing.Point(500, 0)
        Me.ReminderDaysBeforeDueDatelbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ReminderDaysBeforeDueDatelbl.Name = "ReminderDaysBeforeDueDatelbl"
        Me.ReminderDaysBeforeDueDatelbl.Size = New System.Drawing.Size(210, 32)
        Me.ReminderDaysBeforeDueDatelbl.TabIndex = 27
        Me.ReminderDaysBeforeDueDatelbl.Text = "عدد الايام للتذكير بالمهمة قبل انتهائها "
        Me.ReminderDaysBeforeDueDatelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TaskStatuslbl
        '
        Me.TaskStatuslbl.BackColor = System.Drawing.Color.Teal
        Me.TaskStatuslbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TaskStatuslbl.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaskStatuslbl.Location = New System.Drawing.Point(261, 0)
        Me.TaskStatuslbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TaskStatuslbl.Name = "TaskStatuslbl"
        Me.TaskStatuslbl.Size = New System.Drawing.Size(235, 32)
        Me.TaskStatuslbl.TabIndex = 24
        Me.TaskStatuslbl.Text = "حالة المهمة"
        Me.TaskStatuslbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TaskDepartmentlbl
        '
        Me.TaskDepartmentlbl.BackColor = System.Drawing.Color.Teal
        Me.TaskDepartmentlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TaskDepartmentlbl.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaskDepartmentlbl.Location = New System.Drawing.Point(9, 0)
        Me.TaskDepartmentlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TaskDepartmentlbl.Name = "TaskDepartmentlbl"
        Me.TaskDepartmentlbl.Size = New System.Drawing.Size(248, 32)
        Me.TaskDepartmentlbl.TabIndex = 23
        Me.TaskDepartmentlbl.Text = "قسم المهمة"
        Me.TaskDepartmentlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TaskStartDate
        '
        Me.TaskStartDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TaskStartDate.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaskStartDate.Location = New System.Drawing.Point(1266, 36)
        Me.TaskStartDate.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.TaskStartDate.Name = "TaskStartDate"
        Me.TaskStartDate.Size = New System.Drawing.Size(181, 39)
        Me.TaskStartDate.TabIndex = 28
        Me.TaskStartDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TaskEndDate
        '
        Me.TaskEndDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TaskEndDate.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaskEndDate.Location = New System.Drawing.Point(1059, 36)
        Me.TaskEndDate.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.TaskEndDate.Name = "TaskEndDate"
        Me.TaskEndDate.Size = New System.Drawing.Size(203, 39)
        Me.TaskEndDate.TabIndex = 29
        Me.TaskEndDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Emp_ID
        '
        Me.Emp_ID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Emp_ID.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Emp_ID.Location = New System.Drawing.Point(897, 36)
        Me.Emp_ID.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Emp_ID.Name = "Emp_ID"
        Me.Emp_ID.Size = New System.Drawing.Size(158, 39)
        Me.Emp_ID.TabIndex = 30
        Me.Emp_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TaskExecutor
        '
        Me.TaskExecutor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TaskExecutor.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaskExecutor.FormattingEnabled = True
        Me.TaskExecutor.Items.AddRange(New Object() {"احمد مجدى", "محمد جمال", " عمرو الجندى", "مصطفى الجندى"})
        Me.TaskExecutor.Location = New System.Drawing.Point(714, 35)
        Me.TaskExecutor.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TaskExecutor.Name = "TaskExecutor"
        Me.TaskExecutor.Size = New System.Drawing.Size(179, 40)
        Me.TaskExecutor.TabIndex = 31
        '
        'ReminderDaysBeforeDueDate
        '
        Me.ReminderDaysBeforeDueDate.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReminderDaysBeforeDueDate.Location = New System.Drawing.Point(500, 36)
        Me.ReminderDaysBeforeDueDate.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.ReminderDaysBeforeDueDate.Name = "ReminderDaysBeforeDueDate"
        Me.ReminderDaysBeforeDueDate.Size = New System.Drawing.Size(210, 39)
        Me.ReminderDaysBeforeDueDate.TabIndex = 32
        Me.ReminderDaysBeforeDueDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TaskStatus
        '
        Me.TaskStatus.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaskStatus.FormattingEnabled = True
        Me.TaskStatus.Items.AddRange(New Object() {"جارى العمل عليها ", "هام ", "مؤجل ", "انتهت"})
        Me.TaskStatus.Location = New System.Drawing.Point(261, 35)
        Me.TaskStatus.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TaskStatus.Name = "TaskStatus"
        Me.TaskStatus.Size = New System.Drawing.Size(235, 40)
        Me.TaskStatus.TabIndex = 33
        '
        'TaskDepartment
        '
        Me.TaskDepartment.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaskDepartment.FormattingEnabled = True
        Me.TaskDepartment.Items.AddRange(New Object() {"التامين الاجتماعى", "التامين الصحى", "المواصلات الشهرية", "سيارات نقل الموظفين", "مشاكل الموظفين"})
        Me.TaskDepartment.Location = New System.Drawing.Point(9, 35)
        Me.TaskDepartment.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TaskDepartment.Name = "TaskDepartment"
        Me.TaskDepartment.Size = New System.Drawing.Size(248, 40)
        Me.TaskDepartment.TabIndex = 34
        '
        'TaskDescriptionlbl
        '
        Me.TaskDescriptionlbl.BackColor = System.Drawing.Color.Teal
        Me.TaskDescriptionlbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TaskDescriptionlbl.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaskDescriptionlbl.Location = New System.Drawing.Point(9, 79)
        Me.TaskDescriptionlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TaskDescriptionlbl.Name = "TaskDescriptionlbl"
        Me.TaskDescriptionlbl.Size = New System.Drawing.Size(1438, 35)
        Me.TaskDescriptionlbl.TabIndex = 35
        Me.TaskDescriptionlbl.Text = "وصف المهمة"
        Me.TaskDescriptionlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TaskDescription
        '
        Me.TaskDescription.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TaskDescription.Location = New System.Drawing.Point(4, 118)
        Me.TaskDescription.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.TaskDescription.Multiline = True
        Me.TaskDescription.Name = "TaskDescription"
        Me.TaskDescription.Size = New System.Drawing.Size(1443, 84)
        Me.TaskDescription.TabIndex = 36
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Teal
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(714, 206)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(733, 29)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "خطوة 1"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Teal
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(4, 206)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(706, 31)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "خطوة 2"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Step1
        '
        Me.Step1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Step1.Location = New System.Drawing.Point(714, 241)
        Me.Step1.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Step1.Name = "Step1"
        Me.Step1.Size = New System.Drawing.Size(733, 32)
        Me.Step1.TabIndex = 39
        Me.Step1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Step2
        '
        Me.Step2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Step2.Location = New System.Drawing.Point(4, 241)
        Me.Step2.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.Step2.Name = "Step2"
        Me.Step2.Size = New System.Drawing.Size(706, 32)
        Me.Step2.TabIndex = 40
        Me.Step2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgv_Tbl_Alerts)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 325)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1453, 334)
        Me.Panel2.TabIndex = 2
        '
        'dgv_Tbl_Alerts
        '
        Me.dgv_Tbl_Alerts.AllowUserToAddRows = False
        Me.dgv_Tbl_Alerts.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv_Tbl_Alerts.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Tbl_Alerts.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Tbl_Alerts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_Tbl_Alerts.ColumnHeadersHeight = 50
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Tbl_Alerts.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_Tbl_Alerts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Tbl_Alerts.EnableHeadersVisualStyles = False
        Me.dgv_Tbl_Alerts.Location = New System.Drawing.Point(333, 0)
        Me.dgv_Tbl_Alerts.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.dgv_Tbl_Alerts.Name = "dgv_Tbl_Alerts"
        Me.dgv_Tbl_Alerts.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Tbl_Alerts.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_Tbl_Alerts.RowHeadersVisible = False
        Me.dgv_Tbl_Alerts.RowHeadersWidth = 51
        Me.dgv_Tbl_Alerts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_Tbl_Alerts.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_Tbl_Alerts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Tbl_Alerts.Size = New System.Drawing.Size(1120, 334)
        Me.dgv_Tbl_Alerts.TabIndex = 141
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.FlowLayoutPanel2)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(333, 334)
        Me.Panel3.TabIndex = 0
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.ComboSearch)
        Me.FlowLayoutPanel2.Controls.Add(Me.Txt_Search)
        Me.FlowLayoutPanel2.Controls.Add(Me.RadioButton1)
        Me.FlowLayoutPanel2.Controls.Add(Me.RadioButton2)
        Me.FlowLayoutPanel2.Controls.Add(Me.RadioButton3)
        Me.FlowLayoutPanel2.Controls.Add(Me.RadioButton4)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(0, 29)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(333, 221)
        Me.FlowLayoutPanel2.TabIndex = 1
        '
        'ComboSearch
        '
        Me.ComboSearch.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboSearch.FormattingEnabled = True
        Me.ComboSearch.Items.AddRange(New Object() {"قسم المهمة", "كود الموظف", "تاريخ المهمة", "القائم بالمهمة"})
        Me.ComboSearch.Location = New System.Drawing.Point(14, 3)
        Me.ComboSearch.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.ComboSearch.Name = "ComboSearch"
        Me.ComboSearch.Size = New System.Drawing.Size(317, 40)
        Me.ComboSearch.TabIndex = 124
        Me.ComboSearch.Text = "قسم المهمة"
        '
        'Txt_Search
        '
        Me.Txt_Search.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Search.Location = New System.Drawing.Point(13, 49)
        Me.Txt_Search.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Txt_Search.Name = "Txt_Search"
        Me.Txt_Search.Size = New System.Drawing.Size(318, 39)
        Me.Txt_Search.TabIndex = 125
        Me.Txt_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RadioButton1
        '
        Me.RadioButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButton1.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(191, 94)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RadioButton1.Size = New System.Drawing.Size(140, 52)
        Me.RadioButton1.TabIndex = 126
        Me.RadioButton1.Text = "انتهت"
        Me.RadioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(16, 94)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RadioButton2.Size = New System.Drawing.Size(171, 52)
        Me.RadioButton2.TabIndex = 127
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "جارى العمل عليها"
        Me.RadioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RadioButton3.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(191, 152)
        Me.RadioButton3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RadioButton3.Size = New System.Drawing.Size(140, 52)
        Me.RadioButton3.TabIndex = 128
        Me.RadioButton3.Text = "مؤجل"
        Me.RadioButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.Location = New System.Drawing.Point(16, 152)
        Me.RadioButton4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RadioButton4.Size = New System.Drawing.Size(171, 52)
        Me.RadioButton4.TabIndex = 129
        Me.RadioButton4.Text = "هام"
        Me.RadioButton4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(333, 29)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "إبحث هنا"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Btn_Print)
        Me.Panel4.Controls.Add(Me.Btn_Task_Alert)
        Me.Panel4.Controls.Add(Me.BtnSave)
        Me.Panel4.Controls.Add(Me.BtnEdit)
        Me.Panel4.Controls.Add(Me.BtnNewAdd)
        Me.Panel4.Controls.Add(Me.BtnDelete)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 659)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1453, 65)
        Me.Panel4.TabIndex = 3
        '
        'Btn_Print
        '
        Me.Btn_Print.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Print.FlatAppearance.BorderSize = 0
        Me.Btn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Print.Font = New System.Drawing.Font("Cairo ExtraBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Print.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Print
        Me.Btn_Print.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Print.Location = New System.Drawing.Point(258, 8)
        Me.Btn_Print.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Btn_Print.Name = "Btn_Print"
        Me.Btn_Print.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Btn_Print.Size = New System.Drawing.Size(123, 47)
        Me.Btn_Print.TabIndex = 108
        Me.Btn_Print.Text = "طباعة"
        Me.Btn_Print.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Print.UseVisualStyleBackColor = False
        '
        'Btn_Task_Alert
        '
        Me.Btn_Task_Alert.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Task_Alert.FlatAppearance.BorderSize = 0
        Me.Btn_Task_Alert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Task_Alert.Font = New System.Drawing.Font("Cairo ExtraBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Task_Alert.Image = Global.El_Dawliya_International_System.My.Resources.Resources.sound_50px
        Me.Btn_Task_Alert.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Task_Alert.Location = New System.Drawing.Point(513, 8)
        Me.Btn_Task_Alert.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Btn_Task_Alert.Name = "Btn_Task_Alert"
        Me.Btn_Task_Alert.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Btn_Task_Alert.Size = New System.Drawing.Size(185, 47)
        Me.Btn_Task_Alert.TabIndex = 109
        Me.Btn_Task_Alert.Text = "تنبيه المهام"
        Me.Btn_Task_Alert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Task_Alert.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.BackColor = System.Drawing.Color.Transparent
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Cairo ExtraBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Ok
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSave.Location = New System.Drawing.Point(1087, 8)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnSave.Size = New System.Drawing.Size(118, 47)
        Me.BtnSave.TabIndex = 107
        Me.BtnSave.Text = "حفظ"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnEdit
        '
        Me.BtnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEdit.BackColor = System.Drawing.Color.Transparent
        Me.BtnEdit.FlatAppearance.BorderSize = 0
        Me.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEdit.Font = New System.Drawing.Font("Cairo ExtraBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Save_as
        Me.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEdit.Location = New System.Drawing.Point(830, 8)
        Me.BtnEdit.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(125, 47)
        Me.BtnEdit.TabIndex = 110
        Me.BtnEdit.Text = "تعديل"
        Me.BtnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'BtnNewAdd
        '
        Me.BtnNewAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNewAdd.BackColor = System.Drawing.Color.Transparent
        Me.BtnNewAdd.FlatAppearance.BorderSize = 0
        Me.BtnNewAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNewAdd.Font = New System.Drawing.Font("Cairo ExtraBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNewAdd.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Add
        Me.BtnNewAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNewAdd.Location = New System.Drawing.Point(1337, 8)
        Me.BtnNewAdd.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BtnNewAdd.Name = "BtnNewAdd"
        Me.BtnNewAdd.Size = New System.Drawing.Size(111, 47)
        Me.BtnNewAdd.TabIndex = 106
        Me.BtnNewAdd.Text = "جديد"
        Me.BtnNewAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNewAdd.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.Transparent
        Me.BtnDelete.FlatAppearance.BorderSize = 0
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Font = New System.Drawing.Font("Cairo ExtraBold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Remove
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.Location = New System.Drawing.Point(11, 8)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(146, 47)
        Me.BtnDelete.TabIndex = 111
        Me.BtnDelete.Text = "حذف"
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.UseVisualStyleBackColor = False
        Me.BtnDelete.Visible = False
        '
        'Frm_Alerts_Test
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1453, 724)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "Frm_Alerts_Test"
        Me.Text = "شاشة المهام للموارد البشرية"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgv_Tbl_Alerts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents TaskStartDatelbl As Label
    Friend WithEvents Emp_IDlbl As Label
    Friend WithEvents TaskExecutorlbl As Label
    Friend WithEvents ReminderDaysBeforeDueDatelbl As Label
    Friend WithEvents TaskStatuslbl As Label
    Friend WithEvents TaskDepartmentlbl As Label
    Friend WithEvents TaskEndDatelbl As Label
    Friend WithEvents TaskStartDate As TextBox
    Friend WithEvents TaskEndDate As TextBox
    Friend WithEvents Emp_ID As TextBox
    Friend WithEvents TaskExecutor As ComboBox
    Friend WithEvents ReminderDaysBeforeDueDate As TextBox
    Friend WithEvents TaskStatus As ComboBox
    Friend WithEvents TaskDepartment As ComboBox
    Friend WithEvents TaskDescriptionlbl As Label
    Friend WithEvents TaskDescription As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Step1 As TextBox
    Friend WithEvents Step2 As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents dgv_Tbl_Alerts As DataGridView
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboSearch As ComboBox
    Friend WithEvents Txt_Search As TextBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents Btn_Print As Button
    Friend WithEvents Btn_Task_Alert As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnNewAdd As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents TaskCode As TextBox
    Friend WithEvents TaskCreationDate As DateTimePicker
End Class
