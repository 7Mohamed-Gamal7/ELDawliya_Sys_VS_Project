Partial Class EditTaskForm
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer = Nothing

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private Sub InitializeComponent()
        Me.cmb_Employee = New System.Windows.Forms.ComboBox()
        Me.Due_Date = New System.Windows.Forms.DateTimePicker()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.btn_Cancel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmb_Employee
        '
        Me.cmb_Employee.FormattingEnabled = True
        Me.cmb_Employee.Location = New System.Drawing.Point(110, 15)
        Me.cmb_Employee.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmb_Employee.Name = "cmb_Employee"
        Me.cmb_Employee.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmb_Employee.Size = New System.Drawing.Size(387, 24)
        Me.cmb_Employee.TabIndex = 3
        '
        'Due_Date
        '
        Me.Due_Date.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Due_Date.Location = New System.Drawing.Point(110, 52)
        Me.Due_Date.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Due_Date.Name = "Due_Date"
        Me.Due_Date.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Due_Date.Size = New System.Drawing.Size(387, 24)
        Me.Due_Date.TabIndex = 2
        '
        'btn_Save
        '
        Me.btn_Save.Location = New System.Drawing.Point(14, 98)
        Me.btn_Save.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(88, 28)
        Me.btn_Save.TabIndex = 1
        Me.btn_Save.Text = "حفظ"
        '
        'btn_Cancel
        '
        Me.btn_Cancel.Location = New System.Drawing.Point(108, 98)
        Me.btn_Cancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_Cancel.Name = "btn_Cancel"
        Me.btn_Cancel.Size = New System.Drawing.Size(88, 28)
        Me.btn_Cancel.TabIndex = 0
        Me.btn_Cancel.Text = "إلغاء"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 57)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(82, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "تاريخ الإنتهاء:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "مسند إلى:"
        '
        'EditTaskForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 142)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_Cancel)
        Me.Controls.Add(Me.btn_Save)
        Me.Controls.Add(Me.Due_Date)
        Me.Controls.Add(Me.cmb_Employee)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EditTaskForm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "تعديل المهمة"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmb_Employee As ComboBox
    Friend WithEvents Due_Date As DateTimePicker
    Friend WithEvents btn_Save As Button
    Friend WithEvents btn_Cancel As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
