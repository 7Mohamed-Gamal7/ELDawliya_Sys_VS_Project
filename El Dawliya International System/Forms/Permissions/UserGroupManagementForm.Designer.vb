<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserGroupManagementForm
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
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbUsers = New MetroFramework.Controls.MetroComboBox()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.btnSaveMembership = New System.Windows.Forms.Button()
        Me.lvGroups = New System.Windows.Forms.ListView()
        Me.MetroPanel1.SuspendLayout()
        Me.MetroPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.Label2)
        Me.MetroPanel1.Controls.Add(Me.Label1)
        Me.MetroPanel1.Controls.Add(Me.cmbUsers)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(0, 0)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(1450, 190)
        Me.MetroPanel1.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroPanel1.TabIndex = 0
        Me.MetroPanel1.UseStyleColors = True
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(525, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(279, 32)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "شاشة اضافة مستخدم إلى مجموعة"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1323, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "اختر المستخدم"
        '
        'cmbUsers
        '
        Me.cmbUsers.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbUsers.FormattingEnabled = True
        Me.cmbUsers.ItemHeight = 24
        Me.cmbUsers.Location = New System.Drawing.Point(1065, 102)
        Me.cmbUsers.Name = "cmbUsers"
        Me.cmbUsers.Size = New System.Drawing.Size(242, 30)
        Me.cmbUsers.TabIndex = 2
        Me.cmbUsers.UseSelectable = True
        '
        'MetroPanel2
        '
        Me.MetroPanel2.Controls.Add(Me.btnSaveMembership)
        Me.MetroPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(0, 650)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(1450, 100)
        Me.MetroPanel2.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroPanel2.TabIndex = 1
        Me.MetroPanel2.UseStyleColors = True
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'btnSaveMembership
        '
        Me.btnSaveMembership.BackColor = System.Drawing.Color.Green
        Me.btnSaveMembership.Location = New System.Drawing.Point(582, 24)
        Me.btnSaveMembership.Name = "btnSaveMembership"
        Me.btnSaveMembership.Size = New System.Drawing.Size(279, 53)
        Me.btnSaveMembership.TabIndex = 2
        Me.btnSaveMembership.Text = "حفظ"
        Me.btnSaveMembership.UseVisualStyleBackColor = False
        '
        'lvGroups
        '
        Me.lvGroups.CheckBoxes = True
        Me.lvGroups.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvGroups.HideSelection = False
        Me.lvGroups.Location = New System.Drawing.Point(0, 190)
        Me.lvGroups.Name = "lvGroups"
        Me.lvGroups.Size = New System.Drawing.Size(1450, 460)
        Me.lvGroups.TabIndex = 2
        Me.lvGroups.UseCompatibleStateImageBehavior = False
        Me.lvGroups.View = System.Windows.Forms.View.List
        '
        'UserGroupManagementForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1450, 750)
        Me.Controls.Add(Me.lvGroups)
        Me.Controls.Add(Me.MetroPanel2)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "UserGroupManagementForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.MetroPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lvGroups As ListView
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbUsers As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSaveMembership As Button

End Class
