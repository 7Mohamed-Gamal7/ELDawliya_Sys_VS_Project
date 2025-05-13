<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PermissionManagementForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkReadOnly = New MetroFramework.Controls.MetroCheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbForms = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbGroups = New System.Windows.Forms.ComboBox()
        Me.chkCanPrint = New MetroFramework.Controls.MetroCheckBox()
        Me.chkCanDelete = New MetroFramework.Controls.MetroCheckBox()
        Me.cmbUsers = New System.Windows.Forms.ComboBox()
        Me.chkCanAdd = New MetroFramework.Controls.MetroCheckBox()
        Me.chkCanEdit = New MetroFramework.Controls.MetroCheckBox()
        Me.MetroCheckBox1 = New MetroFramework.Controls.MetroCheckBox()
        Me.chkCanView = New MetroFramework.Controls.MetroCheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btn_Save = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Dgv_Forms = New ADGV.AdvancedDataGridView()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.Dgv_Forms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.chkReadOnly)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cmbForms)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cmbGroups)
        Me.Panel1.Controls.Add(Me.chkCanPrint)
        Me.Panel1.Controls.Add(Me.chkCanDelete)
        Me.Panel1.Controls.Add(Me.cmbUsers)
        Me.Panel1.Controls.Add(Me.chkCanAdd)
        Me.Panel1.Controls.Add(Me.chkCanEdit)
        Me.Panel1.Controls.Add(Me.MetroCheckBox1)
        Me.Panel1.Controls.Add(Me.chkCanView)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1435, 153)
        Me.Panel1.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(956, 58)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(137, 34)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Button2"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(956, 13)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(137, 34)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "اضافة مجموعة"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Cairo", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(382, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(591, 48)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "شاشة إدارة الصلاحيات"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'chkReadOnly
        '
        Me.chkReadOnly.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkReadOnly.FontSize = MetroFramework.MetroCheckBoxSize.Tall
        Me.chkReadOnly.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold
        Me.chkReadOnly.Location = New System.Drawing.Point(12, 103)
        Me.chkReadOnly.Name = "chkReadOnly"
        Me.chkReadOnly.Size = New System.Drawing.Size(174, 34)
        Me.chkReadOnly.Style = MetroFramework.MetroColorStyle.Black
        Me.chkReadOnly.TabIndex = 2
        Me.chkReadOnly.Text = "صلاحية القراءة فقط"
        Me.chkReadOnly.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkReadOnly.Theme = MetroFramework.MetroThemeStyle.Light
        Me.chkReadOnly.UseCustomBackColor = True
        Me.chkReadOnly.UseCustomForeColor = True
        Me.chkReadOnly.UseSelectable = True
        Me.chkReadOnly.UseStyleColors = True
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1315, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 29)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "اختر الفورم"
        Me.Label4.Visible = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1315, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "اختر المجموعة"
        '
        'cmbForms
        '
        Me.cmbForms.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbForms.FormattingEnabled = True
        Me.cmbForms.Location = New System.Drawing.Point(1099, 55)
        Me.cmbForms.Name = "cmbForms"
        Me.cmbForms.Size = New System.Drawing.Size(210, 37)
        Me.cmbForms.TabIndex = 1
        Me.cmbForms.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1315, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "اختر المستخدم"
        '
        'cmbGroups
        '
        Me.cmbGroups.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbGroups.FormattingEnabled = True
        Me.cmbGroups.Location = New System.Drawing.Point(1099, 10)
        Me.cmbGroups.Name = "cmbGroups"
        Me.cmbGroups.Size = New System.Drawing.Size(210, 37)
        Me.cmbGroups.TabIndex = 1
        '
        'chkCanPrint
        '
        Me.chkCanPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkCanPrint.FontSize = MetroFramework.MetroCheckBoxSize.Tall
        Me.chkCanPrint.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold
        Me.chkCanPrint.Location = New System.Drawing.Point(221, 103)
        Me.chkCanPrint.Name = "chkCanPrint"
        Me.chkCanPrint.Size = New System.Drawing.Size(153, 34)
        Me.chkCanPrint.Style = MetroFramework.MetroColorStyle.Black
        Me.chkCanPrint.TabIndex = 3
        Me.chkCanPrint.Text = "صلاحية الطباعة"
        Me.chkCanPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkCanPrint.Theme = MetroFramework.MetroThemeStyle.Light
        Me.chkCanPrint.UseCustomBackColor = True
        Me.chkCanPrint.UseCustomForeColor = True
        Me.chkCanPrint.UseSelectable = True
        Me.chkCanPrint.UseStyleColors = True
        '
        'chkCanDelete
        '
        Me.chkCanDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkCanDelete.FontSize = MetroFramework.MetroCheckBoxSize.Tall
        Me.chkCanDelete.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold
        Me.chkCanDelete.Location = New System.Drawing.Point(409, 103)
        Me.chkCanDelete.Name = "chkCanDelete"
        Me.chkCanDelete.Size = New System.Drawing.Size(137, 34)
        Me.chkCanDelete.Style = MetroFramework.MetroColorStyle.Black
        Me.chkCanDelete.TabIndex = 3
        Me.chkCanDelete.Text = "صلاحية الحذف"
        Me.chkCanDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkCanDelete.Theme = MetroFramework.MetroThemeStyle.Light
        Me.chkCanDelete.UseCustomBackColor = True
        Me.chkCanDelete.UseCustomForeColor = True
        Me.chkCanDelete.UseSelectable = True
        Me.chkCanDelete.UseStyleColors = True
        '
        'cmbUsers
        '
        Me.cmbUsers.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbUsers.FormattingEnabled = True
        Me.cmbUsers.Location = New System.Drawing.Point(1099, 100)
        Me.cmbUsers.Name = "cmbUsers"
        Me.cmbUsers.Size = New System.Drawing.Size(210, 37)
        Me.cmbUsers.TabIndex = 1
        '
        'chkCanAdd
        '
        Me.chkCanAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkCanAdd.FontSize = MetroFramework.MetroCheckBoxSize.Tall
        Me.chkCanAdd.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold
        Me.chkCanAdd.Location = New System.Drawing.Point(581, 103)
        Me.chkCanAdd.Name = "chkCanAdd"
        Me.chkCanAdd.Size = New System.Drawing.Size(145, 34)
        Me.chkCanAdd.Style = MetroFramework.MetroColorStyle.Black
        Me.chkCanAdd.TabIndex = 0
        Me.chkCanAdd.Text = "صلاحية الاضافة"
        Me.chkCanAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkCanAdd.Theme = MetroFramework.MetroThemeStyle.Light
        Me.chkCanAdd.UseCustomBackColor = True
        Me.chkCanAdd.UseCustomForeColor = True
        Me.chkCanAdd.UseSelectable = True
        Me.chkCanAdd.UseStyleColors = True
        '
        'chkCanEdit
        '
        Me.chkCanEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkCanEdit.FontSize = MetroFramework.MetroCheckBoxSize.Tall
        Me.chkCanEdit.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold
        Me.chkCanEdit.Location = New System.Drawing.Point(761, 103)
        Me.chkCanEdit.Name = "chkCanEdit"
        Me.chkCanEdit.Size = New System.Drawing.Size(143, 34)
        Me.chkCanEdit.Style = MetroFramework.MetroColorStyle.Black
        Me.chkCanEdit.TabIndex = 0
        Me.chkCanEdit.Text = "صلاحية التعديل"
        Me.chkCanEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkCanEdit.Theme = MetroFramework.MetroThemeStyle.Light
        Me.chkCanEdit.UseCustomBackColor = True
        Me.chkCanEdit.UseCustomForeColor = True
        Me.chkCanEdit.UseSelectable = True
        Me.chkCanEdit.UseStyleColors = True
        '
        'MetroCheckBox1
        '
        Me.MetroCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroCheckBox1.DisplayFocus = True
        Me.MetroCheckBox1.FontSize = MetroFramework.MetroCheckBoxSize.Tall
        Me.MetroCheckBox1.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold
        Me.MetroCheckBox1.Location = New System.Drawing.Point(12, 8)
        Me.MetroCheckBox1.Name = "MetroCheckBox1"
        Me.MetroCheckBox1.Size = New System.Drawing.Size(170, 34)
        Me.MetroCheckBox1.Style = MetroFramework.MetroColorStyle.Black
        Me.MetroCheckBox1.TabIndex = 0
        Me.MetroCheckBox1.Text = "كل المستخدمين "
        Me.MetroCheckBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.MetroCheckBox1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroCheckBox1.UseCustomBackColor = True
        Me.MetroCheckBox1.UseCustomForeColor = True
        Me.MetroCheckBox1.UseSelectable = True
        Me.MetroCheckBox1.UseStyleColors = True
        '
        'chkCanView
        '
        Me.chkCanView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.chkCanView.DisplayFocus = True
        Me.chkCanView.FontSize = MetroFramework.MetroCheckBoxSize.Tall
        Me.chkCanView.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold
        Me.chkCanView.Location = New System.Drawing.Point(939, 103)
        Me.chkCanView.Name = "chkCanView"
        Me.chkCanView.Size = New System.Drawing.Size(141, 34)
        Me.chkCanView.Style = MetroFramework.MetroColorStyle.Black
        Me.chkCanView.TabIndex = 0
        Me.chkCanView.Text = "صلاحية الاظهار"
        Me.chkCanView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkCanView.Theme = MetroFramework.MetroThemeStyle.Light
        Me.chkCanView.UseCustomBackColor = True
        Me.chkCanView.UseCustomForeColor = True
        Me.chkCanView.UseSelectable = True
        Me.chkCanView.UseStyleColors = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.btnDelete)
        Me.Panel2.Controls.Add(Me.btnEdit)
        Me.Panel2.Controls.Add(Me.btnAdd)
        Me.Panel2.Controls.Add(Me.btn_Save)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 702)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1435, 53)
        Me.Panel2.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(196, 46)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "إضافة فورم جديد"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(608, 6)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(196, 46)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "حذف"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(823, 6)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(196, 46)
        Me.btnEdit.TabIndex = 2
        Me.btnEdit.Text = "تعديل"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(1025, 6)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(196, 46)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "جديد"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btn_Save
        '
        Me.btn_Save.Location = New System.Drawing.Point(1227, 6)
        Me.btn_Save.Name = "btn_Save"
        Me.btn_Save.Size = New System.Drawing.Size(196, 46)
        Me.btn_Save.TabIndex = 2
        Me.btn_Save.Text = "حفظ"
        Me.btn_Save.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Dgv_Forms)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 153)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1435, 549)
        Me.Panel3.TabIndex = 2
        '
        'Dgv_Forms
        '
        Me.Dgv_Forms.AllowUserToAddRows = False
        Me.Dgv_Forms.AllowUserToDeleteRows = False
        Me.Dgv_Forms.AutoGenerateContextFilters = True
        Me.Dgv_Forms.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.Dgv_Forms.BackgroundColor = System.Drawing.Color.White
        Me.Dgv_Forms.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dgv_Forms.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_Forms.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv_Forms.ColumnHeadersHeight = 40
        Me.Dgv_Forms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Dgv_Forms.DateWithTime = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dgv_Forms.DefaultCellStyle = DataGridViewCellStyle2
        Me.Dgv_Forms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dgv_Forms.EnableHeadersVisualStyles = False
        Me.Dgv_Forms.GridColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Dgv_Forms.Location = New System.Drawing.Point(0, 0)
        Me.Dgv_Forms.MultiSelect = False
        Me.Dgv_Forms.Name = "Dgv_Forms"
        Me.Dgv_Forms.ReadOnly = True
        Me.Dgv_Forms.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_Forms.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.Dgv_Forms.RowHeadersVisible = False
        Me.Dgv_Forms.RowHeadersWidth = 51
        Me.Dgv_Forms.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Dgv_Forms.RowTemplate.Height = 26
        Me.Dgv_Forms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dgv_Forms.Size = New System.Drawing.Size(1435, 549)
        Me.Dgv_Forms.TabIndex = 5
        Me.Dgv_Forms.TimeFilter = False
        '
        'PermissionManagementForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1435, 755)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Cairo", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "PermissionManagementForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.Dgv_Forms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbUsers As ComboBox
    Friend WithEvents chkCanView As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkReadOnly As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkCanDelete As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkCanAdd As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkCanEdit As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_Save As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Dgv_Forms As ADGV.AdvancedDataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbForms As ComboBox
    Friend WithEvents cmbGroups As ComboBox
    Friend WithEvents MetroCheckBox1 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents chkCanPrint As MetroFramework.Controls.MetroCheckBox
End Class
