<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Connection
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnconnection = New System.Windows.Forms.Button()
        Me.combodatabase = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.checkmode = New System.Windows.Forms.CheckBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.comboserver = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btnconnection)
        Me.GroupBox1.Controls.Add(Me.combodatabase)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.checkmode)
        Me.GroupBox1.Controls.Add(Me.txtpass)
        Me.GroupBox1.Controls.Add(Me.txtuser)
        Me.GroupBox1.Controls.Add(Me.comboserver)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(764, 427)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "بيانات الاتصال بالسيرفر"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Cairo SemiBold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Cancel1
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(6, 349)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 54)
        Me.Button1.TabIndex = 102
        Me.Button1.Text = "إنهاء"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnconnection
        '
        Me.btnconnection.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnconnection.Font = New System.Drawing.Font("Cairo SemiBold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnconnection.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Refresh
        Me.btnconnection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnconnection.Location = New System.Drawing.Point(369, 349)
        Me.btnconnection.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btnconnection.Name = "btnconnection"
        Me.btnconnection.Size = New System.Drawing.Size(113, 54)
        Me.btnconnection.TabIndex = 101
        Me.btnconnection.Text = "إتصال"
        Me.btnconnection.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnconnection.UseVisualStyleBackColor = True
        '
        'combodatabase
        '
        Me.combodatabase.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.combodatabase.Location = New System.Drawing.Point(6, 297)
        Me.combodatabase.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.combodatabase.Name = "combodatabase"
        Me.combodatabase.Size = New System.Drawing.Size(476, 42)
        Me.combodatabase.TabIndex = 100
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.Location = New System.Drawing.Point(499, 297)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(259, 45)
        Me.Label5.TabIndex = 99
        Me.Label5.Text = "اسم قاعدة البيانات"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'checkmode
        '
        Me.checkmode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.checkmode.Location = New System.Drawing.Point(6, 105)
        Me.checkmode.Name = "checkmode"
        Me.checkmode.Size = New System.Drawing.Size(482, 42)
        Me.checkmode.TabIndex = 98
        Me.checkmode.Text = "Sql Server Authentication"
        Me.checkmode.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.checkmode.UseVisualStyleBackColor = True
        '
        'txtpass
        '
        Me.txtpass.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtpass.Enabled = False
        Me.txtpass.Location = New System.Drawing.Point(6, 231)
        Me.txtpass.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(482, 41)
        Me.txtpass.TabIndex = 97
        Me.txtpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtuser
        '
        Me.txtuser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtuser.Enabled = False
        Me.txtuser.Location = New System.Drawing.Point(6, 168)
        Me.txtuser.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(482, 41)
        Me.txtuser.TabIndex = 96
        Me.txtuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'comboserver
        '
        Me.comboserver.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.comboserver.Items.AddRange(New Object() {"D1", "D2", "F1", "F2", "H"})
        Me.comboserver.Location = New System.Drawing.Point(6, 42)
        Me.comboserver.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.comboserver.Name = "comboserver"
        Me.comboserver.Size = New System.Drawing.Size(482, 42)
        Me.comboserver.TabIndex = 95
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Location = New System.Drawing.Point(499, 231)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(259, 45)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "كلمة المرور"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.Location = New System.Drawing.Point(499, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(259, 45)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "اسم المستخدم"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Location = New System.Drawing.Point(499, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(259, 45)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "طريقة الدخول"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Location = New System.Drawing.Point(499, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(259, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "اسم السيرفر"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Frm_Connection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 34.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(782, 451)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Cairo SemiBold", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Frm_Connection"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "الاتصال بالسيرفر وقاعدة البيانات"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents comboserver As ComboBox
    Friend WithEvents combodatabase As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents checkmode As CheckBox
    Friend WithEvents txtpass As TextBox
    Friend WithEvents txtuser As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnconnection As Button

End Class
