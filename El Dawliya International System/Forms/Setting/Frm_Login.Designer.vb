<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Login
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
        Me.Usernamelbl = New System.Windows.Forms.Label()
        Me.Txt_Username = New System.Windows.Forms.TextBox()
        Me.Passwordlbl = New System.Windows.Forms.Label()
        Me.Txt_Password = New System.Windows.Forms.TextBox()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Usernamelbl
        '
        Me.Usernamelbl.Font = New System.Drawing.Font("Cairo", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Usernamelbl.ForeColor = System.Drawing.Color.White
        Me.Usernamelbl.Location = New System.Drawing.Point(196, 14)
        Me.Usernamelbl.Name = "Usernamelbl"
        Me.Usernamelbl.Size = New System.Drawing.Size(143, 37)
        Me.Usernamelbl.TabIndex = 0
        Me.Usernamelbl.Text = "اسم المستخدم"
        Me.Usernamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt_Username
        '
        Me.Txt_Username.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Username.Location = New System.Drawing.Point(8, 14)
        Me.Txt_Username.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Txt_Username.Name = "Txt_Username"
        Me.Txt_Username.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_Username.Size = New System.Drawing.Size(185, 32)
        Me.Txt_Username.TabIndex = 2
        Me.Txt_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Passwordlbl
        '
        Me.Passwordlbl.ForeColor = System.Drawing.Color.White
        Me.Passwordlbl.Location = New System.Drawing.Point(196, 17)
        Me.Passwordlbl.Name = "Passwordlbl"
        Me.Passwordlbl.Size = New System.Drawing.Size(143, 37)
        Me.Passwordlbl.TabIndex = 2
        Me.Passwordlbl.Text = "كلمة المرور"
        Me.Passwordlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt_Password
        '
        Me.Txt_Password.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Password.Location = New System.Drawing.Point(8, 17)
        Me.Txt_Password.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Txt_Password.Name = "Txt_Password"
        Me.Txt_Password.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_Password.Size = New System.Drawing.Size(185, 32)
        Me.Txt_Password.TabIndex = 4
        Me.Txt_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnLogin
        '
        Me.BtnLogin.Font = New System.Drawing.Font("Cairo SemiBold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnLogin.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Padlock
        Me.BtnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnLogin.Location = New System.Drawing.Point(132, 260)
        Me.BtnLogin.Margin = New System.Windows.Forms.Padding(3, 8, 3, 8)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(114, 61)
        Me.BtnLogin.TabIndex = 5
        Me.BtnLogin.Text = "دخول"
        Me.BtnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Font = New System.Drawing.Font("Cairo SemiBold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BtnClose.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Cancel
        Me.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnClose.Location = New System.Drawing.Point(12, 260)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(3, 8, 3, 8)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(114, 61)
        Me.BtnClose.TabIndex = 6
        Me.BtnClose.Text = "انهاء"
        Me.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(20, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(328, 51)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "شاشة دخول المستخدمين"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Hacen Saudi Arabia", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(252, 260)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 8, 3, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 61)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "الاتصال بقاعدة البيانات"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Hacen Saudi Arabia", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkOrange
        Me.Label2.Location = New System.Drawing.Point(387, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(360, 175)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "مرحباً بكم فى البرنامج الخاص بالشركة الدولية إنترناشونال للطباعة والصنفات الصحية"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Usernamelbl)
        Me.Panel3.Controls.Add(Me.Txt_Username)
        Me.Panel3.Location = New System.Drawing.Point(12, 91)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(345, 72)
        Me.Panel3.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Passwordlbl)
        Me.Panel4.Controls.Add(Me.Txt_Password)
        Me.Panel4.Location = New System.Drawing.Point(12, 179)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(345, 70)
        Me.Panel4.TabIndex = 3
        '
        'Frm_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.BackgroundImage = Global.El_Dawliya_International_System.My.Resources.Resources.images1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(759, 381)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.BtnClose)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Cairo SemiBold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.MaximizeBox = False
        Me.Name = "Frm_Login"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Txt_Username As System.Windows.Forms.TextBox
    Friend WithEvents Usernamelbl As System.Windows.Forms.Label
    Friend WithEvents Txt_Password As System.Windows.Forms.TextBox
    Friend WithEvents Passwordlbl As System.Windows.Forms.Label
    Friend WithEvents BtnLogin As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
End Class
