<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Add_Report_Machine
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ReportID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Btn_Add = New System.Windows.Forms.Button()
        Me.Btn_Edit = New System.Windows.Forms.Button()
        Me.btn_Add_New_Problems = New System.Windows.Forms.Button()
        Me.Btn_Delete = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.pnl_Report = New System.Windows.Forms.FlowLayoutPanel()
        Me.Lbl_ReportTitle = New System.Windows.Forms.Label()
        Me.ReportTitle = New System.Windows.Forms.TextBox()
        Me.Lbl_MachineID = New System.Windows.Forms.Label()
        Me.Lbl_DepartmentID = New System.Windows.Forms.Label()
        Me.Lbl_ReportDate = New System.Windows.Forms.Label()
        Me.MachineID = New System.Windows.Forms.ComboBox()
        Me.DepartmentID = New System.Windows.Forms.ComboBox()
        Me.ReportDate = New System.Windows.Forms.DateTimePicker()
        Me.Btn_Add_Report = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Pnl_Problem = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_Add_Problems = New System.Windows.Forms.Button()
        Me.Btn_Add_Participant = New System.Windows.Forms.Button()
        Me.Emp_ID = New System.Windows.Forms.ComboBox()
        Me.Lbl_Emp_ID = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Txt_Action_Taken = New System.Windows.Forms.TextBox()
        Me.ProblemDescription = New System.Windows.Forms.TextBox()
        Me.lbl_ProblemDescription = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.cmbAssignProblem = New System.Windows.Forms.ComboBox()
        Me.btnAssignProblem = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.pnl_Report.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Pnl_Problem.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ReportID)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1446, 47)
        Me.Panel1.TabIndex = 0
        '
        'ReportID
        '
        Me.ReportID.Location = New System.Drawing.Point(28, 4)
        Me.ReportID.Name = "ReportID"
        Me.ReportID.Size = New System.Drawing.Size(128, 39)
        Me.ReportID.TabIndex = 7
        Me.ReportID.Visible = False
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1446, 47)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "اضافة تقرير مشكلة ماكينة"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Btn_Add)
        Me.Panel2.Controls.Add(Me.Btn_Edit)
        Me.Panel2.Controls.Add(Me.Btn_Delete)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 641)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1446, 75)
        Me.Panel2.TabIndex = 1
        '
        'Btn_Add
        '
        Me.Btn_Add.Font = New System.Drawing.Font("Cairo SemiBold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Add.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Add1
        Me.Btn_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Add.Location = New System.Drawing.Point(572, 14)
        Me.Btn_Add.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Btn_Add.Name = "Btn_Add"
        Me.Btn_Add.Size = New System.Drawing.Size(210, 49)
        Me.Btn_Add.TabIndex = 108
        Me.Btn_Add.Text = "تقرير جديد"
        Me.Btn_Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Add.UseVisualStyleBackColor = True
        '
        'Btn_Edit
        '
        Me.Btn_Edit.Font = New System.Drawing.Font("Cairo SemiBold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Edit.Image = Global.El_Dawliya_International_System.My.Resources.Resources.edit_24px
        Me.Btn_Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Edit.Location = New System.Drawing.Point(133, 14)
        Me.Btn_Edit.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Btn_Edit.Name = "Btn_Edit"
        Me.Btn_Edit.Size = New System.Drawing.Size(122, 49)
        Me.Btn_Edit.TabIndex = 109
        Me.Btn_Edit.Text = "تعديل"
        Me.Btn_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Edit.UseVisualStyleBackColor = True
        Me.Btn_Edit.Visible = False
        '
        'btn_Add_New_Problems
        '
        Me.btn_Add_New_Problems.Location = New System.Drawing.Point(6, 185)
        Me.btn_Add_New_Problems.Name = "btn_Add_New_Problems"
        Me.btn_Add_New_Problems.Size = New System.Drawing.Size(225, 39)
        Me.btn_Add_New_Problems.TabIndex = 4
        Me.btn_Add_New_Problems.Text = "اضافة مشكلة جديدة"
        Me.btn_Add_New_Problems.UseVisualStyleBackColor = True
        Me.btn_Add_New_Problems.Visible = False
        '
        'Btn_Delete
        '
        Me.Btn_Delete.Font = New System.Drawing.Font("Cairo SemiBold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Delete.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Remove1
        Me.Btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Delete.Location = New System.Drawing.Point(9, 14)
        Me.Btn_Delete.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Btn_Delete.Name = "Btn_Delete"
        Me.Btn_Delete.Size = New System.Drawing.Size(118, 49)
        Me.Btn_Delete.TabIndex = 110
        Me.Btn_Delete.Text = "حذف"
        Me.Btn_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Delete.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.pnl_Report)
        Me.Panel3.Controls.Add(Me.Btn_Add_Report)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 47)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1446, 191)
        Me.Panel3.TabIndex = 2
        '
        'pnl_Report
        '
        Me.pnl_Report.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnl_Report.Controls.Add(Me.Lbl_ReportTitle)
        Me.pnl_Report.Controls.Add(Me.ReportTitle)
        Me.pnl_Report.Controls.Add(Me.Lbl_MachineID)
        Me.pnl_Report.Controls.Add(Me.Lbl_DepartmentID)
        Me.pnl_Report.Controls.Add(Me.Lbl_ReportDate)
        Me.pnl_Report.Controls.Add(Me.MachineID)
        Me.pnl_Report.Controls.Add(Me.DepartmentID)
        Me.pnl_Report.Controls.Add(Me.ReportDate)
        Me.pnl_Report.Location = New System.Drawing.Point(0, 0)
        Me.pnl_Report.Name = "pnl_Report"
        Me.pnl_Report.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pnl_Report.Size = New System.Drawing.Size(1442, 134)
        Me.pnl_Report.TabIndex = 0
        '
        'Lbl_ReportTitle
        '
        Me.Lbl_ReportTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_ReportTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_ReportTitle.Location = New System.Drawing.Point(1041, 0)
        Me.Lbl_ReportTitle.Name = "Lbl_ReportTitle"
        Me.Lbl_ReportTitle.Size = New System.Drawing.Size(394, 42)
        Me.Lbl_ReportTitle.TabIndex = 3
        Me.Lbl_ReportTitle.Text = "عنوان التقرير"
        Me.Lbl_ReportTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ReportTitle
        '
        Me.ReportTitle.Location = New System.Drawing.Point(8, 3)
        Me.ReportTitle.Name = "ReportTitle"
        Me.ReportTitle.Size = New System.Drawing.Size(1027, 39)
        Me.ReportTitle.TabIndex = 6
        Me.ReportTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lbl_MachineID
        '
        Me.Lbl_MachineID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_MachineID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_MachineID.Location = New System.Drawing.Point(1041, 45)
        Me.Lbl_MachineID.Name = "Lbl_MachineID"
        Me.Lbl_MachineID.Size = New System.Drawing.Size(394, 35)
        Me.Lbl_MachineID.TabIndex = 0
        Me.Lbl_MachineID.Text = "الماكينة"
        Me.Lbl_MachineID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_DepartmentID
        '
        Me.Lbl_DepartmentID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_DepartmentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_DepartmentID.Location = New System.Drawing.Point(451, 45)
        Me.Lbl_DepartmentID.Name = "Lbl_DepartmentID"
        Me.Lbl_DepartmentID.Size = New System.Drawing.Size(584, 35)
        Me.Lbl_DepartmentID.TabIndex = 2
        Me.Lbl_DepartmentID.Text = "القسم"
        Me.Lbl_DepartmentID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_ReportDate
        '
        Me.Lbl_ReportDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_ReportDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_ReportDate.Location = New System.Drawing.Point(8, 45)
        Me.Lbl_ReportDate.Name = "Lbl_ReportDate"
        Me.Lbl_ReportDate.Size = New System.Drawing.Size(437, 35)
        Me.Lbl_ReportDate.TabIndex = 4
        Me.Lbl_ReportDate.Text = "التاريخ"
        Me.Lbl_ReportDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MachineID
        '
        Me.MachineID.FormattingEnabled = True
        Me.MachineID.Location = New System.Drawing.Point(1041, 83)
        Me.MachineID.Name = "MachineID"
        Me.MachineID.Size = New System.Drawing.Size(394, 40)
        Me.MachineID.TabIndex = 1
        '
        'DepartmentID
        '
        Me.DepartmentID.FormattingEnabled = True
        Me.DepartmentID.Location = New System.Drawing.Point(451, 83)
        Me.DepartmentID.Name = "DepartmentID"
        Me.DepartmentID.Size = New System.Drawing.Size(584, 40)
        Me.DepartmentID.TabIndex = 3
        '
        'ReportDate
        '
        Me.ReportDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ReportDate.Location = New System.Drawing.Point(8, 83)
        Me.ReportDate.Name = "ReportDate"
        Me.ReportDate.Size = New System.Drawing.Size(437, 39)
        Me.ReportDate.TabIndex = 5
        '
        'Btn_Add_Report
        '
        Me.Btn_Add_Report.Font = New System.Drawing.Font("Cairo SemiBold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Btn_Add_Report.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Add1
        Me.Btn_Add_Report.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Btn_Add_Report.Location = New System.Drawing.Point(570, 137)
        Me.Btn_Add_Report.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Btn_Add_Report.Name = "Btn_Add_Report"
        Me.Btn_Add_Report.Size = New System.Drawing.Size(263, 49)
        Me.Btn_Add_Report.TabIndex = 109
        Me.Btn_Add_Report.Text = "حفظ"
        Me.Btn_Add_Report.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Add_Report.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.Pnl_Problem)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 238)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1446, 403)
        Me.Panel4.TabIndex = 3
        '
        'Pnl_Problem
        '
        Me.Pnl_Problem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Pnl_Problem.Controls.Add(Me.TabControl1)
        Me.Pnl_Problem.Dock = System.Windows.Forms.DockStyle.Top
        Me.Pnl_Problem.Location = New System.Drawing.Point(0, 0)
        Me.Pnl_Problem.Name = "Pnl_Problem"
        Me.Pnl_Problem.Size = New System.Drawing.Size(1442, 350)
        Me.Pnl_Problem.TabIndex = 0
        Me.Pnl_Problem.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TabControl1.RightToLeftLayout = True
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1442, 350)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.btn_Add_Problems)
        Me.TabPage1.Controls.Add(Me.btn_Add_New_Problems)
        Me.TabPage1.Controls.Add(Me.Btn_Add_Participant)
        Me.TabPage1.Controls.Add(Me.Emp_ID)
        Me.TabPage1.Controls.Add(Me.Lbl_Emp_ID)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Txt_Action_Taken)
        Me.TabPage1.Controls.Add(Me.ProblemDescription)
        Me.TabPage1.Controls.Add(Me.lbl_ProblemDescription)
        Me.TabPage1.Location = New System.Drawing.Point(4, 41)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1434, 305)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "إضافة مشكلة"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Gray
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(544, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 90)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "الإجراء المتخذ"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_Add_Problems
        '
        Me.btn_Add_Problems.BackColor = System.Drawing.Color.Red
        Me.btn_Add_Problems.Location = New System.Drawing.Point(0, 40)
        Me.btn_Add_Problems.Name = "btn_Add_Problems"
        Me.btn_Add_Problems.Size = New System.Drawing.Size(115, 87)
        Me.btn_Add_Problems.TabIndex = 9
        Me.btn_Add_Problems.Text = "اضافة المشكلة"
        Me.btn_Add_Problems.UseVisualStyleBackColor = False
        '
        'Btn_Add_Participant
        '
        Me.Btn_Add_Participant.BackColor = System.Drawing.Color.Lime
        Me.Btn_Add_Participant.Location = New System.Drawing.Point(541, 184)
        Me.Btn_Add_Participant.Name = "Btn_Add_Participant"
        Me.Btn_Add_Participant.Size = New System.Drawing.Size(225, 39)
        Me.Btn_Add_Participant.TabIndex = 12
        Me.Btn_Add_Participant.Text = "اضافة مشارك جديد"
        Me.Btn_Add_Participant.UseVisualStyleBackColor = False
        Me.Btn_Add_Participant.Visible = False
        '
        'Emp_ID
        '
        Me.Emp_ID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Emp_ID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Emp_ID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Emp_ID.FormattingEnabled = True
        Me.Emp_ID.Location = New System.Drawing.Point(772, 184)
        Me.Emp_ID.Name = "Emp_ID"
        Me.Emp_ID.Size = New System.Drawing.Size(425, 40)
        Me.Emp_ID.TabIndex = 13
        Me.Emp_ID.Visible = False
        '
        'Lbl_Emp_ID
        '
        Me.Lbl_Emp_ID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Emp_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_Emp_ID.Location = New System.Drawing.Point(1203, 184)
        Me.Lbl_Emp_ID.Name = "Lbl_Emp_ID"
        Me.Lbl_Emp_ID.Size = New System.Drawing.Size(225, 42)
        Me.Lbl_Emp_ID.TabIndex = 11
        Me.Lbl_Emp_ID.Text = "اسم المشارك فى المشكلة"
        Me.Lbl_Emp_ID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Lbl_Emp_ID.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Gray
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(6, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(1422, 35)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "المشاركين فى المشكلة"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label2.Visible = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Gray
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Location = New System.Drawing.Point(3, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(1428, 30)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "المشاكل الموجودة"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt_Action_Taken
        '
        Me.Txt_Action_Taken.Location = New System.Drawing.Point(117, 40)
        Me.Txt_Action_Taken.Multiline = True
        Me.Txt_Action_Taken.Name = "Txt_Action_Taken"
        Me.Txt_Action_Taken.Size = New System.Drawing.Size(421, 87)
        Me.Txt_Action_Taken.TabIndex = 8
        Me.Txt_Action_Taken.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ProblemDescription
        '
        Me.ProblemDescription.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProblemDescription.Location = New System.Drawing.Point(634, 40)
        Me.ProblemDescription.Multiline = True
        Me.ProblemDescription.Name = "ProblemDescription"
        Me.ProblemDescription.Size = New System.Drawing.Size(704, 87)
        Me.ProblemDescription.TabIndex = 8
        Me.ProblemDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_ProblemDescription
        '
        Me.lbl_ProblemDescription.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_ProblemDescription.BackColor = System.Drawing.Color.Gray
        Me.lbl_ProblemDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_ProblemDescription.Location = New System.Drawing.Point(1344, 40)
        Me.lbl_ProblemDescription.Name = "lbl_ProblemDescription"
        Me.lbl_ProblemDescription.Size = New System.Drawing.Size(84, 90)
        Me.lbl_ProblemDescription.TabIndex = 7
        Me.lbl_ProblemDescription.Text = "تفاصيل المشكلة"
        Me.lbl_ProblemDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.cmbAssignProblem)
        Me.TabPage2.Controls.Add(Me.btnAssignProblem)
        Me.TabPage2.Location = New System.Drawing.Point(4, 41)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1434, 305)
        Me.TabPage2.TabIndex = 3
        Me.TabPage2.Text = "كل المشاكل وتوجيها "
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'cmbAssignProblem
        '
        Me.cmbAssignProblem.FormattingEnabled = True
        Me.cmbAssignProblem.Location = New System.Drawing.Point(142, 204)
        Me.cmbAssignProblem.Name = "cmbAssignProblem"
        Me.cmbAssignProblem.Size = New System.Drawing.Size(301, 40)
        Me.cmbAssignProblem.TabIndex = 11
        Me.cmbAssignProblem.Visible = False
        '
        'btnAssignProblem
        '
        Me.btnAssignProblem.Location = New System.Drawing.Point(449, 204)
        Me.btnAssignProblem.Name = "btnAssignProblem"
        Me.btnAssignProblem.Size = New System.Drawing.Size(225, 39)
        Me.btnAssignProblem.TabIndex = 10
        Me.btnAssignProblem.Text = "توجيه التقرير"
        Me.btnAssignProblem.UseVisualStyleBackColor = True
        Me.btnAssignProblem.Visible = False
        '
        'Add_Report_Machine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1446, 716)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "Add_Report_Machine"
        Me.RightToLeftLayout = True
        Me.ShowIcon = False
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.pnl_Report.ResumeLayout(False)
        Me.pnl_Report.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Pnl_Problem.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Lbl_MachineID As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents pnl_Report As FlowLayoutPanel
    Friend WithEvents Lbl_DepartmentID As Label
    Friend WithEvents Lbl_ReportDate As Label
    Friend WithEvents MachineID As ComboBox
    Friend WithEvents DepartmentID As ComboBox
    Friend WithEvents ReportDate As DateTimePicker
    Friend WithEvents Lbl_ReportTitle As Label
    Friend WithEvents ReportTitle As TextBox
    Friend WithEvents Pnl_Problem As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_Add_Problems As Button
    Friend WithEvents lbl_ProblemDescription As Label
    Friend WithEvents ProblemDescription As TextBox
    Friend WithEvents Btn_Add As Button
    Friend WithEvents Btn_Edit As Button
    Friend WithEvents Btn_Delete As Button
    Friend WithEvents ReportID As TextBox
    Friend WithEvents Btn_Add_Report As Button
    Friend WithEvents btn_Add_New_Problems As Button
    Friend WithEvents btnAssignProblem As Button
    Friend WithEvents cmbAssignProblem As ComboBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Btn_Add_Participant As Button
    Friend WithEvents Emp_ID As ComboBox
    Friend WithEvents Lbl_Emp_ID As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Txt_Action_Taken As TextBox
    Friend WithEvents Label3 As Label
End Class
