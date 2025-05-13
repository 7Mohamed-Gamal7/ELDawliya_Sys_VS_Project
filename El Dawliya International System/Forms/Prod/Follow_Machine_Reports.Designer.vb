<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Follow_Machine_Reports
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lbl_ReportTitle = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ReportTitle = New System.Windows.Forms.TextBox()
        Me.Lbl_MachineID = New System.Windows.Forms.Label()
        Me.Lbl_DepartmentID = New System.Windows.Forms.Label()
        Me.Lbl_ReportDate = New System.Windows.Forms.Label()
        Me.MachineID = New System.Windows.Forms.ComboBox()
        Me.DepartmentID = New System.Windows.Forms.ComboBox()
        Me.ReportDate = New System.Windows.Forms.DateTimePicker()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1062, 50)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 573)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1062, 100)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 50)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1062, 523)
        Me.Panel3.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Cairo ExtraBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1062, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "شاشة متابعة التقارير"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_ReportTitle
        '
        Me.Lbl_ReportTitle.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_ReportTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_ReportTitle.Location = New System.Drawing.Point(899, 3)
        Me.Lbl_ReportTitle.Name = "Lbl_ReportTitle"
        Me.Lbl_ReportTitle.Size = New System.Drawing.Size(147, 40)
        Me.Lbl_ReportTitle.TabIndex = 4
        Me.Lbl_ReportTitle.Text = "عنوان التقرير"
        Me.Lbl_ReportTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.MachineID)
        Me.Panel4.Controls.Add(Me.DepartmentID)
        Me.Panel4.Controls.Add(Me.ReportDate)
        Me.Panel4.Controls.Add(Me.Lbl_MachineID)
        Me.Panel4.Controls.Add(Me.Lbl_DepartmentID)
        Me.Panel4.Controls.Add(Me.Lbl_ReportDate)
        Me.Panel4.Controls.Add(Me.ReportTitle)
        Me.Panel4.Controls.Add(Me.Lbl_ReportTitle)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1058, 108)
        Me.Panel4.TabIndex = 5
        '
        'ReportTitle
        '
        Me.ReportTitle.Location = New System.Drawing.Point(3, 1)
        Me.ReportTitle.Name = "ReportTitle"
        Me.ReportTitle.Size = New System.Drawing.Size(890, 45)
        Me.ReportTitle.TabIndex = 7
        Me.ReportTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lbl_MachineID
        '
        Me.Lbl_MachineID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_MachineID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_MachineID.Location = New System.Drawing.Point(899, 57)
        Me.Lbl_MachineID.Name = "Lbl_MachineID"
        Me.Lbl_MachineID.Size = New System.Drawing.Size(147, 35)
        Me.Lbl_MachineID.TabIndex = 8
        Me.Lbl_MachineID.Text = "الماكينة"
        Me.Lbl_MachineID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_DepartmentID
        '
        Me.Lbl_DepartmentID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_DepartmentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_DepartmentID.Location = New System.Drawing.Point(502, 59)
        Me.Lbl_DepartmentID.Name = "Lbl_DepartmentID"
        Me.Lbl_DepartmentID.Size = New System.Drawing.Size(149, 35)
        Me.Lbl_DepartmentID.TabIndex = 9
        Me.Lbl_DepartmentID.Text = "القسم"
        Me.Lbl_DepartmentID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl_ReportDate
        '
        Me.Lbl_ReportDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_ReportDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl_ReportDate.Location = New System.Drawing.Point(151, 59)
        Me.Lbl_ReportDate.Name = "Lbl_ReportDate"
        Me.Lbl_ReportDate.Size = New System.Drawing.Size(97, 35)
        Me.Lbl_ReportDate.TabIndex = 10
        Me.Lbl_ReportDate.Text = "التاريخ"
        Me.Lbl_ReportDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MachineID
        '
        Me.MachineID.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MachineID.FormattingEnabled = True
        Me.MachineID.Location = New System.Drawing.Point(657, 57)
        Me.MachineID.Name = "MachineID"
        Me.MachineID.Size = New System.Drawing.Size(236, 37)
        Me.MachineID.TabIndex = 11
        '
        'DepartmentID
        '
        Me.DepartmentID.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepartmentID.FormattingEnabled = True
        Me.DepartmentID.Location = New System.Drawing.Point(254, 57)
        Me.DepartmentID.Name = "DepartmentID"
        Me.DepartmentID.Size = New System.Drawing.Size(242, 37)
        Me.DepartmentID.TabIndex = 12
        '
        'ReportDate
        '
        Me.ReportDate.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ReportDate.Location = New System.Drawing.Point(8, 58)
        Me.ReportDate.Name = "ReportDate"
        Me.ReportDate.Size = New System.Drawing.Size(137, 36)
        Me.ReportDate.TabIndex = 13
        '
        'Follow_Machine_Reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1062, 673)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Cairo", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.Name = "Follow_Machine_Reports"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Follow_Machine_Reports"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Lbl_ReportTitle As Label
    Friend WithEvents ReportTitle As TextBox
    Friend WithEvents Lbl_MachineID As Label
    Friend WithEvents Lbl_DepartmentID As Label
    Friend WithEvents Lbl_ReportDate As Label
    Friend WithEvents MachineID As ComboBox
    Friend WithEvents DepartmentID As ComboBox
    Friend WithEvents ReportDate As DateTimePicker
End Class
