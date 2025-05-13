<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_BackUp_New
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_BackUp_New))
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.BC = New System.Windows.Forms.Button()
        Me.BCO = New System.Windows.Forms.Button()
        Me.t1 = New System.Windows.Forms.TextBox()
        Me.ch1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cod = New System.Windows.Forms.ComboBox()
        Me.dbr = New System.Windows.Forms.Button()
        Me.tf = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tet = New System.Windows.Forms.TextBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.T2 = New System.Windows.Forms.TextBox()
        Me.BRO = New System.Windows.Forms.Button()
        Me.BR = New System.Windows.Forms.Button()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.BD = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TabControl2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Controls.Add(Me.TabPage6)
        Me.TabControl2.Font = New System.Drawing.Font("Traditional Arabic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl2.Location = New System.Drawing.Point(13, 13)
        Me.TabControl2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.RightToLeftLayout = True
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(632, 351)
        Me.TabControl2.TabIndex = 67
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TabPage4.Controls.Add(Me.GroupBox2)
        Me.TabPage4.Controls.Add(Me.ch1)
        Me.TabPage4.Controls.Add(Me.GroupBox1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 38)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage4.Size = New System.Drawing.Size(624, 309)
        Me.TabPage4.TabIndex = 0
        Me.TabPage4.Text = "أخذ نسخة إحتياطية"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label32)
        Me.GroupBox2.Controls.Add(Me.BC)
        Me.GroupBox2.Controls.Add(Me.BCO)
        Me.GroupBox2.Controls.Add(Me.t1)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 7)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(604, 150)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "نسخ يدوي"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Traditional Arabic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(322, 23)
        Me.Label32.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(286, 37)
        Me.Label32.TabIndex = 19
        Me.Label32.Text = "قم بتحديد مسار حفظ النسخة الاحتياطية"
        '
        'BC
        '
        Me.BC.Font = New System.Drawing.Font("Traditional Arabic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BC.Location = New System.Drawing.Point(9, 101)
        Me.BC.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.BC.Name = "BC"
        Me.BC.Size = New System.Drawing.Size(162, 42)
        Me.BC.TabIndex = 15
        Me.BC.Text = "أخذ نسخة إحتياطية"
        Me.BC.UseVisualStyleBackColor = True
        '
        'BCO
        '
        Me.BCO.Font = New System.Drawing.Font("Traditional Arabic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCO.Location = New System.Drawing.Point(496, 66)
        Me.BCO.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.BCO.Name = "BCO"
        Me.BCO.Size = New System.Drawing.Size(74, 32)
        Me.BCO.TabIndex = 17
        Me.BCO.Text = "......"
        Me.BCO.UseVisualStyleBackColor = True
        '
        't1
        '
        Me.t1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t1.Location = New System.Drawing.Point(9, 66)
        Me.t1.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.t1.Name = "t1"
        Me.t1.ReadOnly = True
        Me.t1.Size = New System.Drawing.Size(474, 30)
        Me.t1.TabIndex = 18
        '
        'ch1
        '
        Me.ch1.AutoSize = True
        Me.ch1.Location = New System.Drawing.Point(523, 165)
        Me.ch1.Margin = New System.Windows.Forms.Padding(4)
        Me.ch1.Name = "ch1"
        Me.ch1.Size = New System.Drawing.Size(97, 33)
        Me.ch1.TabIndex = 21
        Me.ch1.Text = "نسخ تلقائي"
        Me.ch1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.cod)
        Me.GroupBox1.Controls.Add(Me.dbr)
        Me.GroupBox1.Controls.Add(Me.tf)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tet)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(19, 193)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(593, 105)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "النسخ التلقائي"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Traditional Arabic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(9, 69)
        Me.Button1.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 32)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "حفظ الإعدادات"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cod
        '
        Me.cod.Font = New System.Drawing.Font("Traditional Arabic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cod.FormattingEnabled = True
        Me.cod.Items.AddRange(New Object() {"السبت", "الأحد", "الإثنين", "الثلاثاء", "الأربعاء", "الخميس", "الجمعة"})
        Me.cod.Location = New System.Drawing.Point(443, 30)
        Me.cod.Margin = New System.Windows.Forms.Padding(4)
        Me.cod.Name = "cod"
        Me.cod.Size = New System.Drawing.Size(79, 37)
        Me.cod.TabIndex = 26
        '
        'dbr
        '
        Me.dbr.Font = New System.Drawing.Font("Traditional Arabic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dbr.Location = New System.Drawing.Point(130, 33)
        Me.dbr.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.dbr.Name = "dbr"
        Me.dbr.Size = New System.Drawing.Size(74, 32)
        Me.dbr.TabIndex = 22
        Me.dbr.Text = "......"
        Me.dbr.UseVisualStyleBackColor = True
        '
        'tf
        '
        Me.tf.Font = New System.Drawing.Font("Traditional Arabic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tf.Location = New System.Drawing.Point(9, 30)
        Me.tf.Margin = New System.Windows.Forms.Padding(4)
        Me.tf.Name = "tf"
        Me.tf.Size = New System.Drawing.Size(110, 36)
        Me.tf.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Traditional Arabic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(208, 30)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 37)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "مسار الحفظ:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Traditional Arabic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(374, 30)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 37)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "الساعة:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Traditional Arabic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(532, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 37)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "اليوم:"
        '
        'tet
        '
        Me.tet.Font = New System.Drawing.Font("Traditional Arabic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tet.Location = New System.Drawing.Point(310, 30)
        Me.tet.Margin = New System.Windows.Forms.Padding(4)
        Me.tet.Name = "tet"
        Me.tet.Size = New System.Drawing.Size(61, 36)
        Me.tet.TabIndex = 0
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TabPage5.Controls.Add(Me.Label33)
        Me.TabPage5.Controls.Add(Me.T2)
        Me.TabPage5.Controls.Add(Me.BRO)
        Me.TabPage5.Controls.Add(Me.BR)
        Me.TabPage5.Location = New System.Drawing.Point(4, 38)
        Me.TabPage5.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage5.Size = New System.Drawing.Size(624, 309)
        Me.TabPage5.TabIndex = 1
        Me.TabPage5.Text = "إستعادة نسخة إحتياطية"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Traditional Arabic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(369, 50)
        Me.Label33.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(247, 37)
        Me.Label33.TabIndex = 24
        Me.Label33.Text = "قم بتحديد مسار النسخة الاحتياطية"
        '
        'T2
        '
        Me.T2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.T2.Location = New System.Drawing.Point(6, 94)
        Me.T2.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.T2.Name = "T2"
        Me.T2.ReadOnly = True
        Me.T2.Size = New System.Drawing.Size(507, 30)
        Me.T2.TabIndex = 23
        '
        'BRO
        '
        Me.BRO.Font = New System.Drawing.Font("Traditional Arabic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BRO.Location = New System.Drawing.Point(522, 94)
        Me.BRO.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.BRO.Name = "BRO"
        Me.BRO.Size = New System.Drawing.Size(74, 32)
        Me.BRO.TabIndex = 22
        Me.BRO.Text = "......"
        Me.BRO.UseVisualStyleBackColor = True
        '
        'BR
        '
        Me.BR.Font = New System.Drawing.Font("Traditional Arabic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BR.Location = New System.Drawing.Point(6, 140)
        Me.BR.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.BR.Name = "BR"
        Me.BR.Size = New System.Drawing.Size(162, 42)
        Me.BR.TabIndex = 20
        Me.BR.Text = "إستعادة النسخة الاحتياطية"
        Me.BR.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TabPage6.Controls.Add(Me.BD)
        Me.TabPage6.Location = New System.Drawing.Point(4, 38)
        Me.TabPage6.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(624, 309)
        Me.TabPage6.TabIndex = 2
        Me.TabPage6.Text = "تفريغ قاعدة البيانات"
        '
        'BD
        '
        Me.BD.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BD.Font = New System.Drawing.Font("Traditional Arabic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BD.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BD.Location = New System.Drawing.Point(219, 122)
        Me.BD.Margin = New System.Windows.Forms.Padding(4)
        Me.BD.Name = "BD"
        Me.BD.Size = New System.Drawing.Size(178, 49)
        Me.BD.TabIndex = 0
        Me.BD.Text = "تفريغ القاعدة"
        Me.BD.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 3000
        '
        'Frm_BackUp_New
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(654, 366)
        Me.Controls.Add(Me.TabControl2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm_BackUp_New"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "نسخ_ واستعادة قاعدة البيانات"
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage4 As TabPage
    Private WithEvents Label32 As Label
    Private WithEvents t1 As TextBox
    Private WithEvents BCO As Button
    Private WithEvents BC As Button
    Friend WithEvents TabPage5 As TabPage
    Private WithEvents Label33 As Label
    Private WithEvents T2 As TextBox
    Private WithEvents BRO As Button
    Private WithEvents BR As Button
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents BD As Button
    Friend WithEvents ch1 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cod As System.Windows.Forms.ComboBox
    Private WithEvents dbr As System.Windows.Forms.Button
    Friend WithEvents tf As System.Windows.Forms.TextBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tet As System.Windows.Forms.TextBox
    Private WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
