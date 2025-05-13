<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Update
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Lbl_Update = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Blue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1062, 61)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1062, 61)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "شاشة البحث عن تحديثات البرنامج"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnUpdate
        '
        Me.BtnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed
        Me.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdate.Font = New System.Drawing.Font("Questv1", 10.2!, System.Drawing.FontStyle.Bold)
        Me.BtnUpdate.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Ok
        Me.BtnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnUpdate.Location = New System.Drawing.Point(455, 518)
        Me.BtnUpdate.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnUpdate.Size = New System.Drawing.Size(117, 48)
        Me.BtnUpdate.TabIndex = 107
        Me.BtnUpdate.Text = "تحديث"
        Me.BtnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUpdate.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(4, 64)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(223, 37)
        Me.WebBrowser1.TabIndex = 108
        Me.WebBrowser1.Visible = False
        '
        'Lbl_Update
        '
        Me.Lbl_Update.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Update.Location = New System.Drawing.Point(260, 64)
        Me.Lbl_Update.Name = "Lbl_Update"
        Me.Lbl_Update.Size = New System.Drawing.Size(516, 37)
        Me.Lbl_Update.TabIndex = 109
        Me.Lbl_Update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Frm_Update
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1062, 673)
        Me.Controls.Add(Me.Lbl_Update)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.BtnUpdate)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Frm_Update"
        Me.Text = "Frm_Update"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents Lbl_Update As Label
End Class
