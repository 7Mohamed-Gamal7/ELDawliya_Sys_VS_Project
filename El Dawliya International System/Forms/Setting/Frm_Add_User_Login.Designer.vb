<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Add_User_Login
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.UserIDlbl = New System.Windows.Forms.Label()
        Me.UserID = New System.Windows.Forms.TextBox()
        Me.UserNamelbl = New System.Windows.Forms.Label()
        Me.UserName = New System.Windows.Forms.TextBox()
        Me.UserPasswordlbl = New System.Windows.Forms.Label()
        Me.UserPassword = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnNewAdd = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgv_Users_Login = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgv_Users_Login, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'UserIDlbl
        '
        Me.UserIDlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.UserIDlbl.ForeColor = System.Drawing.Color.White
        Me.UserIDlbl.Location = New System.Drawing.Point(526, 10)
        Me.UserIDlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UserIDlbl.Name = "UserIDlbl"
        Me.UserIDlbl.Size = New System.Drawing.Size(199, 27)
        Me.UserIDlbl.TabIndex = 0
        Me.UserIDlbl.Text = "كود المستخدم"
        Me.UserIDlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UserID
        '
        Me.UserID.Enabled = False
        Me.UserID.Location = New System.Drawing.Point(174, 7)
        Me.UserID.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.UserID.Name = "UserID"
        Me.UserID.Size = New System.Drawing.Size(325, 34)
        Me.UserID.TabIndex = 1
        Me.UserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'UserNamelbl
        '
        Me.UserNamelbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.UserNamelbl.ForeColor = System.Drawing.Color.White
        Me.UserNamelbl.Location = New System.Drawing.Point(526, 54)
        Me.UserNamelbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UserNamelbl.Name = "UserNamelbl"
        Me.UserNamelbl.Size = New System.Drawing.Size(199, 27)
        Me.UserNamelbl.TabIndex = 2
        Me.UserNamelbl.Text = "اسم المستخدم"
        Me.UserNamelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UserName
        '
        Me.UserName.Location = New System.Drawing.Point(174, 51)
        Me.UserName.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.UserName.Name = "UserName"
        Me.UserName.Size = New System.Drawing.Size(325, 34)
        Me.UserName.TabIndex = 3
        Me.UserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'UserPasswordlbl
        '
        Me.UserPasswordlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(1, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.UserPasswordlbl.ForeColor = System.Drawing.Color.White
        Me.UserPasswordlbl.Location = New System.Drawing.Point(526, 95)
        Me.UserPasswordlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UserPasswordlbl.Name = "UserPasswordlbl"
        Me.UserPasswordlbl.Size = New System.Drawing.Size(199, 27)
        Me.UserPasswordlbl.TabIndex = 4
        Me.UserPasswordlbl.Text = "الباسورد"
        Me.UserPasswordlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UserPassword
        '
        Me.UserPassword.Location = New System.Drawing.Point(174, 93)
        Me.UserPassword.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.UserPassword.Name = "UserPassword"
        Me.UserPassword.Size = New System.Drawing.Size(325, 34)
        Me.UserPassword.TabIndex = 5
        Me.UserPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(736, 73)
        Me.Panel1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Hacen Saudi Arabia", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(736, 73)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "شاشة اضافة مستخدم جديد"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.UserIDlbl)
        Me.Panel2.Controls.Add(Me.UserPasswordlbl)
        Me.Panel2.Controls.Add(Me.UserID)
        Me.Panel2.Controls.Add(Me.UserNamelbl)
        Me.Panel2.Controls.Add(Me.UserName)
        Me.Panel2.Controls.Add(Me.UserPassword)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 73)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(736, 141)
        Me.Panel2.TabIndex = 7
        '
        'BtnDelete
        '
        Me.BtnDelete.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Bold)
        Me.BtnDelete.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Remove
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.Location = New System.Drawing.Point(13, 7)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(103, 52)
        Me.BtnDelete.TabIndex = 90
        Me.BtnDelete.Text = "حذف"
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Bold)
        Me.BtnEdit.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Pencil
        Me.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEdit.Location = New System.Drawing.Point(217, 7)
        Me.BtnEdit.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(103, 52)
        Me.BtnEdit.TabIndex = 89
        Me.BtnEdit.Text = "تعديل"
        Me.BtnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSave.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Bold)
        Me.BtnSave.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Save
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Location = New System.Drawing.Point(421, 7)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnSave.Size = New System.Drawing.Size(103, 52)
        Me.BtnSave.TabIndex = 88
        Me.BtnSave.Text = "حفظ"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnNewAdd
        '
        Me.BtnNewAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnNewAdd.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Bold)
        Me.BtnNewAdd.ForeColor = System.Drawing.Color.Black
        Me.BtnNewAdd.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Add
        Me.BtnNewAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNewAdd.Location = New System.Drawing.Point(625, 7)
        Me.BtnNewAdd.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.BtnNewAdd.Name = "BtnNewAdd"
        Me.BtnNewAdd.Size = New System.Drawing.Size(103, 52)
        Me.BtnNewAdd.TabIndex = 87
        Me.BtnNewAdd.Text = "جديد"
        Me.BtnNewAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNewAdd.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BtnNewAdd)
        Me.Panel3.Controls.Add(Me.BtnEdit)
        Me.Panel3.Controls.Add(Me.BtnDelete)
        Me.Panel3.Controls.Add(Me.BtnSave)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 555)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(736, 71)
        Me.Panel3.TabIndex = 91
        '
        'dgv_Users_Login
        '
        Me.dgv_Users_Login.AllowUserToAddRows = False
        Me.dgv_Users_Login.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Cairo", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv_Users_Login.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_Users_Login.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Users_Login.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_Users_Login.ColumnHeadersHeight = 40
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Users_Login.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_Users_Login.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Users_Login.EnableHeadersVisualStyles = False
        Me.dgv_Users_Login.Location = New System.Drawing.Point(0, 0)
        Me.dgv_Users_Login.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.dgv_Users_Login.Name = "dgv_Users_Login"
        Me.dgv_Users_Login.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Users_Login.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_Users_Login.RowHeadersVisible = False
        Me.dgv_Users_Login.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Cairo SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_Users_Login.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_Users_Login.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_Users_Login.Size = New System.Drawing.Size(736, 341)
        Me.dgv_Users_Login.TabIndex = 144
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.dgv_Users_Login)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 214)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(736, 341)
        Me.Panel4.TabIndex = 145
        '
        'Frm_Add_User_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(736, 626)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.MaximizeBox = False
        Me.Name = "Frm_Add_User_Login"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgv_Users_Login, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UserID As System.Windows.Forms.TextBox
    Friend WithEvents UserIDlbl As System.Windows.Forms.Label
    Friend WithEvents UserName As System.Windows.Forms.TextBox
    Friend WithEvents UserNamelbl As System.Windows.Forms.Label
    Friend WithEvents UserPassword As System.Windows.Forms.TextBox
    Friend WithEvents UserPasswordlbl As System.Windows.Forms.Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnNewAdd As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dgv_Users_Login As DataGridView
    Friend WithEvents Panel4 As Panel
End Class
