<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Search_ProplemCode
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBoxClose = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txt_StopMachineTime = New System.Windows.Forms.TextBox()
        Me.Txt_Who_identified_problem = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txt_Unity_problem = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Txt_Time_identify_problem = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Txt_Notes = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Txt_Part_problem = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Section_Production = New System.Windows.Forms.TextBox()
        Me.Machine_Name = New System.Windows.Forms.TextBox()
        Me.TotalProblemTime = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txt_Who_Note_writer = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Txt_Problem_status = New System.Windows.Forms.TextBox()
        Me.Txt_Machine_running_time = New System.Windows.Forms.TextBox()
        Me.Txt_Proplem_Code = New System.Windows.Forms.TextBox()
        Me.Lbl_Who_Note_writer = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.PictureBoxClose)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1204, 51)
        Me.Panel1.TabIndex = 84
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Location = New System.Drawing.Point(1709, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(44, 35)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'PictureBoxClose
        '
        Me.PictureBoxClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBoxClose.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxClose.Location = New System.Drawing.Point(2895, 10)
        Me.PictureBoxClose.Name = "PictureBoxClose"
        Me.PictureBoxClose.Size = New System.Drawing.Size(48, 48)
        Me.PictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBoxClose.TabIndex = 36
        Me.PictureBoxClose.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Cairo", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1204, 51)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "شاشة الإستعلام عن الأعطال"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(995, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(184, 32)
        Me.Label5.TabIndex = 112
        Me.Label5.Text = "وقت ايقاف الماكينة"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt_StopMachineTime
        '
        Me.Txt_StopMachineTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_StopMachineTime.BackColor = System.Drawing.Color.Red
        Me.Txt_StopMachineTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_StopMachineTime.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_StopMachineTime.ForeColor = System.Drawing.Color.Black
        Me.Txt_StopMachineTime.Location = New System.Drawing.Point(403, 74)
        Me.Txt_StopMachineTime.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Txt_StopMachineTime.Name = "Txt_StopMachineTime"
        Me.Txt_StopMachineTime.ReadOnly = True
        Me.Txt_StopMachineTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_StopMachineTime.Size = New System.Drawing.Size(577, 39)
        Me.Txt_StopMachineTime.TabIndex = 113
        Me.Txt_StopMachineTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_Who_identified_problem
        '
        Me.Txt_Who_identified_problem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_Who_identified_problem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Who_identified_problem.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Who_identified_problem.ForeColor = System.Drawing.Color.Black
        Me.Txt_Who_identified_problem.Location = New System.Drawing.Point(403, 125)
        Me.Txt_Who_identified_problem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Txt_Who_identified_problem.Name = "Txt_Who_identified_problem"
        Me.Txt_Who_identified_problem.ReadOnly = True
        Me.Txt_Who_identified_problem.Size = New System.Drawing.Size(577, 39)
        Me.Txt_Who_identified_problem.TabIndex = 115
        Me.Txt_Who_identified_problem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(995, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(184, 32)
        Me.Label7.TabIndex = 114
        Me.Label7.Text = "من قام بتحديد المشكلة"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt_Unity_problem
        '
        Me.Txt_Unity_problem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_Unity_problem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Unity_problem.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Unity_problem.ForeColor = System.Drawing.Color.Black
        Me.Txt_Unity_problem.Location = New System.Drawing.Point(403, 278)
        Me.Txt_Unity_problem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Txt_Unity_problem.Name = "Txt_Unity_problem"
        Me.Txt_Unity_problem.ReadOnly = True
        Me.Txt_Unity_problem.Size = New System.Drawing.Size(577, 39)
        Me.Txt_Unity_problem.TabIndex = 127
        Me.Txt_Unity_problem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(995, 278)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(184, 32)
        Me.Label10.TabIndex = 126
        Me.Label10.Text = "وحدة العطل"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt_Time_identify_problem
        '
        Me.Txt_Time_identify_problem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_Time_identify_problem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Time_identify_problem.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Time_identify_problem.ForeColor = System.Drawing.Color.Black
        Me.Txt_Time_identify_problem.Location = New System.Drawing.Point(403, 176)
        Me.Txt_Time_identify_problem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Txt_Time_identify_problem.Name = "Txt_Time_identify_problem"
        Me.Txt_Time_identify_problem.ReadOnly = True
        Me.Txt_Time_identify_problem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_Time_identify_problem.Size = New System.Drawing.Size(577, 39)
        Me.Txt_Time_identify_problem.TabIndex = 121
        Me.Txt_Time_identify_problem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(995, 176)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(184, 32)
        Me.Label13.TabIndex = 120
        Me.Label13.Text = "وقت تحديد المشكلة"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt_Notes
        '
        Me.Txt_Notes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_Notes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Notes.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Notes.ForeColor = System.Drawing.Color.Black
        Me.Txt_Notes.Location = New System.Drawing.Point(6, 584)
        Me.Txt_Notes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Txt_Notes.Multiline = True
        Me.Txt_Notes.Name = "Txt_Notes"
        Me.Txt_Notes.ReadOnly = True
        Me.Txt_Notes.Size = New System.Drawing.Size(974, 105)
        Me.Txt_Notes.TabIndex = 131
        Me.Txt_Notes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label16.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(995, 584)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(184, 105)
        Me.Label16.TabIndex = 130
        Me.Label16.Text = "ملاحظات العطل"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt_Part_problem
        '
        Me.Txt_Part_problem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_Part_problem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Part_problem.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Part_problem.ForeColor = System.Drawing.Color.Black
        Me.Txt_Part_problem.Location = New System.Drawing.Point(403, 329)
        Me.Txt_Part_problem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Txt_Part_problem.Name = "Txt_Part_problem"
        Me.Txt_Part_problem.ReadOnly = True
        Me.Txt_Part_problem.Size = New System.Drawing.Size(577, 39)
        Me.Txt_Part_problem.TabIndex = 129
        Me.Txt_Part_problem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label17.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(995, 329)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(184, 32)
        Me.Label17.TabIndex = 128
        Me.Label17.Text = "جزء العطل"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.Section_Production)
        Me.GroupBox2.Controls.Add(Me.Machine_Name)
        Me.GroupBox2.Controls.Add(Me.TotalProblemTime)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Txt_Who_Note_writer)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Txt_Problem_status)
        Me.GroupBox2.Controls.Add(Me.Txt_Machine_running_time)
        Me.GroupBox2.Controls.Add(Me.Txt_Proplem_Code)
        Me.GroupBox2.Controls.Add(Me.Lbl_Who_Note_writer)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.Txt_Time_identify_problem)
        Me.GroupBox2.Controls.Add(Me.Txt_Notes)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Txt_Part_problem)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Txt_Unity_problem)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Txt_Who_identified_problem)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Txt_StopMachineTime)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox2.Location = New System.Drawing.Point(5, 56)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox2.Size = New System.Drawing.Size(1188, 695)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'Section_Production
        '
        Me.Section_Production.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Section_Production.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Section_Production.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Section_Production.ForeColor = System.Drawing.Color.Black
        Me.Section_Production.Location = New System.Drawing.Point(403, 227)
        Me.Section_Production.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Section_Production.Name = "Section_Production"
        Me.Section_Production.ReadOnly = True
        Me.Section_Production.Size = New System.Drawing.Size(577, 39)
        Me.Section_Production.TabIndex = 146
        Me.Section_Production.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Machine_Name
        '
        Me.Machine_Name.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Machine_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Machine_Name.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Machine_Name.ForeColor = System.Drawing.Color.Black
        Me.Machine_Name.Location = New System.Drawing.Point(12, 24)
        Me.Machine_Name.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Machine_Name.Name = "Machine_Name"
        Me.Machine_Name.ReadOnly = True
        Me.Machine_Name.Size = New System.Drawing.Size(230, 39)
        Me.Machine_Name.TabIndex = 146
        Me.Machine_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TotalProblemTime
        '
        Me.TotalProblemTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TotalProblemTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalProblemTime.Font = New System.Drawing.Font("Questv1", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalProblemTime.Location = New System.Drawing.Point(403, 533)
        Me.TotalProblemTime.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TotalProblemTime.Name = "TotalProblemTime"
        Me.TotalProblemTime.ReadOnly = True
        Me.TotalProblemTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TotalProblemTime.Size = New System.Drawing.Size(577, 41)
        Me.TotalProblemTime.TabIndex = 132
        Me.TotalProblemTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TotalProblemTime.WordWrap = False
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label24.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.White
        Me.Label24.Location = New System.Drawing.Point(995, 533)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(184, 32)
        Me.Label24.TabIndex = 131
        Me.Label24.Text = "الوقت الكلى للمشكلة"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Cairo ExtraBold", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(248, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 34)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = "الماكينة"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt_Who_Note_writer
        '
        Me.Txt_Who_Note_writer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_Who_Note_writer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Who_Note_writer.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Who_Note_writer.ForeColor = System.Drawing.Color.Black
        Me.Txt_Who_Note_writer.Location = New System.Drawing.Point(403, 482)
        Me.Txt_Who_Note_writer.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Txt_Who_Note_writer.Name = "Txt_Who_Note_writer"
        Me.Txt_Who_Note_writer.ReadOnly = True
        Me.Txt_Who_Note_writer.Size = New System.Drawing.Size(577, 39)
        Me.Txt_Who_Note_writer.TabIndex = 137
        Me.Txt_Who_Note_writer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label19.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(995, 431)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(184, 32)
        Me.Label19.TabIndex = 144
        Me.Label19.Text = "وقت تشغيل الماكينة"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt_Problem_status
        '
        Me.Txt_Problem_status.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_Problem_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Problem_status.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Problem_status.ForeColor = System.Drawing.Color.Black
        Me.Txt_Problem_status.Location = New System.Drawing.Point(403, 380)
        Me.Txt_Problem_status.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Txt_Problem_status.Name = "Txt_Problem_status"
        Me.Txt_Problem_status.ReadOnly = True
        Me.Txt_Problem_status.Size = New System.Drawing.Size(577, 39)
        Me.Txt_Problem_status.TabIndex = 141
        Me.Txt_Problem_status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_Machine_running_time
        '
        Me.Txt_Machine_running_time.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_Machine_running_time.BackColor = System.Drawing.Color.Lime
        Me.Txt_Machine_running_time.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Machine_running_time.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Machine_running_time.ForeColor = System.Drawing.Color.Black
        Me.Txt_Machine_running_time.Location = New System.Drawing.Point(403, 431)
        Me.Txt_Machine_running_time.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Txt_Machine_running_time.Name = "Txt_Machine_running_time"
        Me.Txt_Machine_running_time.ReadOnly = True
        Me.Txt_Machine_running_time.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_Machine_running_time.Size = New System.Drawing.Size(577, 39)
        Me.Txt_Machine_running_time.TabIndex = 145
        Me.Txt_Machine_running_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txt_Proplem_Code
        '
        Me.Txt_Proplem_Code.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_Proplem_Code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Proplem_Code.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Proplem_Code.ForeColor = System.Drawing.Color.Black
        Me.Txt_Proplem_Code.Location = New System.Drawing.Point(403, 23)
        Me.Txt_Proplem_Code.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Txt_Proplem_Code.Name = "Txt_Proplem_Code"
        Me.Txt_Proplem_Code.Size = New System.Drawing.Size(577, 39)
        Me.Txt_Proplem_Code.TabIndex = 1
        Me.Txt_Proplem_Code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lbl_Who_Note_writer
        '
        Me.Lbl_Who_Note_writer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Who_Note_writer.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Lbl_Who_Note_writer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lbl_Who_Note_writer.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Who_Note_writer.ForeColor = System.Drawing.Color.White
        Me.Lbl_Who_Note_writer.Location = New System.Drawing.Point(995, 482)
        Me.Lbl_Who_Note_writer.Name = "Lbl_Who_Note_writer"
        Me.Lbl_Who_Note_writer.Size = New System.Drawing.Size(184, 32)
        Me.Lbl_Who_Note_writer.TabIndex = 136
        Me.Lbl_Who_Note_writer.Text = "كاتب الملاحظات"
        Me.Lbl_Who_Note_writer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label21.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(995, 23)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(184, 32)
        Me.Label21.TabIndex = 142
        Me.Label21.Text = "كود العطل"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label22.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(995, 227)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(184, 32)
        Me.Label22.TabIndex = 138
        Me.Label22.Text = "قسم المشكلة"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label23.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.White
        Me.Label23.Location = New System.Drawing.Point(995, 380)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(184, 32)
        Me.Label23.TabIndex = 140
        Me.Label23.Text = "حالة العطل"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Frm_Search_ProplemCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1204, 760)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimizeBox = False
        Me.Name = "Frm_Search_ProplemCode"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBoxClose As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Txt_StopMachineTime As TextBox
    Friend WithEvents Txt_Who_identified_problem As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Txt_Unity_problem As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Txt_Time_identify_problem As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Txt_Notes As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Txt_Part_problem As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Txt_Who_Note_writer As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Txt_Problem_status As TextBox
    Friend WithEvents Txt_Machine_running_time As TextBox
    Friend WithEvents Txt_Proplem_Code As TextBox
    Friend WithEvents Lbl_Who_Note_writer As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents TotalProblemTime As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Section_Production As TextBox
    Friend WithEvents Machine_Name As TextBox
End Class
