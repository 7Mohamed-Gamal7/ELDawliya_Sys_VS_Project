﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmServerConnection
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnHelp = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.lblConfirmMsg = New System.Windows.Forms.Label()
        Me.PicMsg = New System.Windows.Forms.PictureBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnDelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnClose = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.rbLocal = New System.Windows.Forms.RadioButton()
        Me.rbNetwork = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CKShow1 = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UserPassword = New System.Windows.Forms.TextBox()
        Me.UserId = New System.Windows.Forms.TextBox()
        Me.CombAuth = New System.Windows.Forms.ComboBox()
        Me.CombServers = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CKShow2 = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIPAddress = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.WANConString = New System.Windows.Forms.TextBox()
        Me.rbWAN = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ComboDBs = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.PicMsg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(621, 50)
        Me.Panel1.TabIndex = 7
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.SteelBlue
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnHelp, Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(621, 50)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnHelp
        '
        Me.btnHelp.AutoSize = False
        Me.btnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(31, 31)
        Me.btnHelp.ToolTipText = "مساعده"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.AutoSize = False
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Sakkal Majalla", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(450, 34)
        Me.ToolStripLabel1.Text = "إعدادات الاتصال السيرفر"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel8.Controls.Add(Me.lblConfirmMsg)
        Me.Panel8.Controls.Add(Me.PicMsg)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(0, 682)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(621, 36)
        Me.Panel8.TabIndex = 9
        '
        'lblConfirmMsg
        '
        Me.lblConfirmMsg.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblConfirmMsg.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmMsg.ForeColor = System.Drawing.Color.Navy
        Me.lblConfirmMsg.Location = New System.Drawing.Point(139, 0)
        Me.lblConfirmMsg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblConfirmMsg.Name = "lblConfirmMsg"
        Me.lblConfirmMsg.Size = New System.Drawing.Size(450, 34)
        Me.lblConfirmMsg.TabIndex = 14
        Me.lblConfirmMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PicMsg
        '
        Me.PicMsg.Dock = System.Windows.Forms.DockStyle.Right
        Me.PicMsg.Location = New System.Drawing.Point(589, 0)
        Me.PicMsg.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PicMsg.Name = "PicMsg"
        Me.PicMsg.Size = New System.Drawing.Size(30, 34)
        Me.PicMsg.TabIndex = 13
        Me.PicMsg.TabStop = False
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.ToolStrip2)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 50)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Panel7.Size = New System.Drawing.Size(621, 49)
        Me.Panel7.TabIndex = 10
        '
        'ToolStrip2
        '
        Me.ToolStrip2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNew, Me.ToolStripSeparator1, Me.btnSave, Me.ToolStripSeparator2, Me.btnDelete, Me.ToolStripSeparator5, Me.btnClose, Me.ToolStripSeparator6})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStrip2.Size = New System.Drawing.Size(621, 49)
        Me.ToolStrip2.TabIndex = 0
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'btnNew
        '
        Me.btnNew.Font = New System.Drawing.Font("Sakkal Majalla", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(127, 46)
        Me.btnNew.Text = "فحص الاتصال"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 49)
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Sakkal Majalla", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(140, 46)
        Me.btnSave.Text = "حفظ  الإعدادات"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 49)
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Sakkal Majalla", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(131, 46)
        Me.btnDelete.Text = "الغاء الاعدادات"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 49)
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Sakkal Majalla", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(60, 46)
        Me.btnClose.Text = "إغلاق"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 49)
        '
        'rbLocal
        '
        Me.rbLocal.AutoSize = True
        Me.rbLocal.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rbLocal.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbLocal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rbLocal.Location = New System.Drawing.Point(14, 110)
        Me.rbLocal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbLocal.Name = "rbLocal"
        Me.rbLocal.Size = New System.Drawing.Size(200, 27)
        Me.rbLocal.TabIndex = 11
        Me.rbLocal.TabStop = True
        Me.rbLocal.Text = "Local Connection"
        Me.rbLocal.UseVisualStyleBackColor = True
        '
        'rbNetwork
        '
        Me.rbNetwork.AutoSize = True
        Me.rbNetwork.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rbNetwork.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNetwork.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rbNetwork.Location = New System.Drawing.Point(14, 378)
        Me.rbNetwork.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbNetwork.Name = "rbNetwork"
        Me.rbNetwork.Size = New System.Drawing.Size(229, 27)
        Me.rbNetwork.TabIndex = 11
        Me.rbNetwork.TabStop = True
        Me.rbNetwork.Text = "Network Connection"
        Me.rbNetwork.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CKShow1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.UserPassword)
        Me.GroupBox1.Controls.Add(Me.UserId)
        Me.GroupBox1.Controls.Add(Me.CombAuth)
        Me.GroupBox1.Controls.Add(Me.CombServers)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 134)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(593, 171)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'CKShow1
        '
        Me.CKShow1.AutoSize = True
        Me.CKShow1.BackColor = System.Drawing.SystemColors.Control
        Me.CKShow1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CKShow1.Location = New System.Drawing.Point(516, 137)
        Me.CKShow1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CKShow1.Name = "CKShow1"
        Me.CKShow1.Size = New System.Drawing.Size(65, 20)
        Me.CKShow1.TabIndex = 4
        Me.CKShow1.Text = "Show"
        Me.CKShow1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(64, 137)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 23)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(54, 97)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "User Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 58)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Authentication"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Server Name"
        '
        'UserPassword
        '
        Me.UserPassword.BackColor = System.Drawing.SystemColors.Window
        Me.UserPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserPassword.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserPassword.Location = New System.Drawing.Point(213, 132)
        Me.UserPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UserPassword.Name = "UserPassword"
        Me.UserPassword.Size = New System.Drawing.Size(370, 31)
        Me.UserPassword.TabIndex = 1
        Me.UserPassword.UseSystemPasswordChar = True
        '
        'UserId
        '
        Me.UserId.BackColor = System.Drawing.SystemColors.Window
        Me.UserId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserId.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserId.Location = New System.Drawing.Point(213, 94)
        Me.UserId.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UserId.Name = "UserId"
        Me.UserId.Size = New System.Drawing.Size(370, 31)
        Me.UserId.TabIndex = 1
        '
        'CombAuth
        '
        Me.CombAuth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CombAuth.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CombAuth.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CombAuth.FormattingEnabled = True
        Me.CombAuth.Items.AddRange(New Object() {"Windows Authentication", "SQL Server Authentication"})
        Me.CombAuth.Location = New System.Drawing.Point(213, 57)
        Me.CombAuth.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CombAuth.Name = "CombAuth"
        Me.CombAuth.Size = New System.Drawing.Size(369, 31)
        Me.CombAuth.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.CombAuth, "اختر طريقة الاتصال بالسيرفر")
        '
        'CombServers
        '
        Me.CombServers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CombServers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CombServers.BackColor = System.Drawing.Color.White
        Me.CombServers.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CombServers.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CombServers.FormattingEnabled = True
        Me.CombServers.Location = New System.Drawing.Point(213, 17)
        Me.CombServers.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CombServers.Name = "CombServers"
        Me.CombServers.Size = New System.Drawing.Size(369, 31)
        Me.CombServers.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.CombServers, "اختر اسم السيرفر")
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CKShow2)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtIPAddress)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtUserName)
        Me.GroupBox2.Controls.Add(Me.txtPort)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtPassword)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 401)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox2.Size = New System.Drawing.Size(593, 175)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'CKShow2
        '
        Me.CKShow2.AutoSize = True
        Me.CKShow2.BackColor = System.Drawing.Color.White
        Me.CKShow2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CKShow2.Location = New System.Drawing.Point(509, 140)
        Me.CKShow2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CKShow2.Name = "CKShow2"
        Me.CKShow2.Size = New System.Drawing.Size(65, 20)
        Me.CKShow2.TabIndex = 3
        Me.CKShow2.Text = "Show"
        Me.CKShow2.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(38, 60)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(135, 23)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Port Number"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(61, 137)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 23)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Password"
        '
        'txtIPAddress
        '
        Me.txtIPAddress.BackColor = System.Drawing.Color.White
        Me.txtIPAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIPAddress.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIPAddress.Location = New System.Drawing.Point(208, 22)
        Me.txtIPAddress.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtIPAddress.Name = "txtIPAddress"
        Me.txtIPAddress.Size = New System.Drawing.Size(370, 31)
        Me.txtIPAddress.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 25)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(177, 22)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Server IP Address"
        '
        'txtUserName
        '
        Me.txtUserName.BackColor = System.Drawing.Color.White
        Me.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Location = New System.Drawing.Point(208, 97)
        Me.txtUserName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(370, 31)
        Me.txtUserName.TabIndex = 1
        '
        'txtPort
        '
        Me.txtPort.BackColor = System.Drawing.Color.White
        Me.txtPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPort.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPort.Location = New System.Drawing.Point(208, 59)
        Me.txtPort.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(370, 31)
        Me.txtPort.TabIndex = 1
        Me.txtPort.Text = "1433"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(54, 98)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 23)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "User Name"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(208, 135)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(370, 31)
        Me.txtPassword.TabIndex = 1
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.WANConString)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(14, 610)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox4.Size = New System.Drawing.Size(593, 69)
        Me.GroupBox4.TabIndex = 12
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Connection String"
        '
        'WANConString
        '
        Me.WANConString.BackColor = System.Drawing.Color.White
        Me.WANConString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.WANConString.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WANConString.Location = New System.Drawing.Point(12, 25)
        Me.WANConString.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.WANConString.Multiline = True
        Me.WANConString.Name = "WANConString"
        Me.WANConString.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.WANConString.Size = New System.Drawing.Size(574, 36)
        Me.WANConString.TabIndex = 2
        '
        'rbWAN
        '
        Me.rbWAN.AutoSize = True
        Me.rbWAN.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rbWAN.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbWAN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rbWAN.Location = New System.Drawing.Point(14, 582)
        Me.rbWAN.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rbWAN.Name = "rbWAN"
        Me.rbWAN.Size = New System.Drawing.Size(195, 27)
        Me.rbWAN.TabIndex = 13
        Me.rbWAN.TabStop = True
        Me.rbWAN.Text = "WAN Connection"
        Me.rbWAN.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ComboDBs)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(14, 305)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox3.Size = New System.Drawing.Size(593, 65)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        '
        'ComboDBs
        '
        Me.ComboDBs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboDBs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboDBs.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboDBs.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboDBs.FormattingEnabled = True
        Me.ComboDBs.Location = New System.Drawing.Point(209, 21)
        Me.ComboDBs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboDBs.Name = "ComboDBs"
        Me.ComboDBs.Size = New System.Drawing.Size(369, 31)
        Me.ComboDBs.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.ComboDBs, "اختر قاعدة البيانات")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(8, 26)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(167, 23)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "DataBase Name"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 50
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 100
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
        '
        'FrmServerConnection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(621, 718)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.rbWAN)
        Me.Controls.Add(Me.rbLocal)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.rbNetwork)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel8)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmServerConnection"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "إعدادات الاتصال بالسيرفر"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        CType(Me.PicMsg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnHelp As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents rbLocal As System.Windows.Forms.RadioButton
    Friend WithEvents rbNetwork As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents UserPassword As System.Windows.Forms.TextBox
    Friend WithEvents UserId As System.Windows.Forms.TextBox
    Friend WithEvents CombAuth As System.Windows.Forms.ComboBox
    Friend WithEvents CombServers As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtIPAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents txtPort As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents CKShow2 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents WANConString As System.Windows.Forms.TextBox
    Friend WithEvents rbWAN As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboDBs As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CKShow1 As System.Windows.Forms.CheckBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblConfirmMsg As System.Windows.Forms.Label
    Friend WithEvents PicMsg As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class


