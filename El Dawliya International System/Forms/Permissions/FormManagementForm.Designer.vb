Imports System.Data.SqlClient

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormManagementForm
    Inherits BaseForm
    'Inherits System.Windows.Forms.Form

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

    Friend WithEvents FormID As TextBox
    Friend WithEvents Btn_Delete As Button
    Friend WithEvents Btn_Edit As Button
    Friend WithEvents Btn_New As Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FormID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_formName_ar = New System.Windows.Forms.TextBox()
        Me.txt_FormDescription = New System.Windows.Forms.TextBox()
        Me.txtFormName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Btn_Delete = New System.Windows.Forms.Button()
        Me.Btn_Edit = New System.Windows.Forms.Button()
        Me.Btn_New = New System.Windows.Forms.Button()
        Me.Btn_Save = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.DGV_Get_All_Forms_Name = New System.Windows.Forms.DataGridView()
        Me.FormName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Btn_Get_All_Forms_Name = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvForms = New System.Windows.Forms.DataGridView()
        Me.Txt_Search = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.DGV_Get_All_Forms_Name, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.dgvForms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.FormID)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txt_formName_ar)
        Me.Panel1.Controls.Add(Me.txt_FormDescription)
        Me.Panel1.Controls.Add(Me.txtFormName)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1450, 158)
        Me.Panel1.TabIndex = 0
        '
        'FormID
        '
        Me.FormID.Location = New System.Drawing.Point(1360, 0)
        Me.FormID.Name = "FormID"
        Me.FormID.Size = New System.Drawing.Size(78, 39)
        Me.FormID.TabIndex = 3
        Me.FormID.Visible = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Font = New System.Drawing.Font("Cairo", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1175, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(266, 37)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "وصف النموذج"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Cairo", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(318, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(266, 37)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "اسم النموذج باللغة العربية"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Font = New System.Drawing.Font("Cairo", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1175, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(266, 37)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "اسم النموذج باللغة الانجليزية"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_formName_ar
        '
        Me.txt_formName_ar.Location = New System.Drawing.Point(9, 53)
        Me.txt_formName_ar.Name = "txt_formName_ar"
        Me.txt_formName_ar.Size = New System.Drawing.Size(303, 39)
        Me.txt_formName_ar.TabIndex = 2
        Me.txt_formName_ar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_FormDescription
        '
        Me.txt_FormDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_FormDescription.Location = New System.Drawing.Point(9, 113)
        Me.txt_FormDescription.Name = "txt_FormDescription"
        Me.txt_FormDescription.Size = New System.Drawing.Size(1160, 39)
        Me.txt_FormDescription.TabIndex = 3
        Me.txt_FormDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFormName
        '
        Me.txtFormName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFormName.Location = New System.Drawing.Point(866, 57)
        Me.txtFormName.Name = "txtFormName"
        Me.txtFormName.Size = New System.Drawing.Size(303, 39)
        Me.txtFormName.TabIndex = 1
        Me.txtFormName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Cairo", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1450, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "نموذج إدارة النماذج"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel2.Controls.Add(Me.Btn_Delete)
        Me.Panel2.Controls.Add(Me.Btn_Edit)
        Me.Panel2.Controls.Add(Me.Btn_New)
        Me.Panel2.Controls.Add(Me.Btn_Save)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 647)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1450, 100)
        Me.Panel2.TabIndex = 1
        '
        'Btn_Delete
        '
        Me.Btn_Delete.Location = New System.Drawing.Point(560, 32)
        Me.Btn_Delete.Name = "Btn_Delete"
        Me.Btn_Delete.Size = New System.Drawing.Size(213, 56)
        Me.Btn_Delete.TabIndex = 8
        Me.Btn_Delete.Text = "حذف"
        Me.Btn_Delete.UseVisualStyleBackColor = True
        '
        'Btn_Edit
        '
        Me.Btn_Edit.Location = New System.Drawing.Point(779, 32)
        Me.Btn_Edit.Name = "Btn_Edit"
        Me.Btn_Edit.Size = New System.Drawing.Size(213, 56)
        Me.Btn_Edit.TabIndex = 7
        Me.Btn_Edit.Text = "تعديل"
        Me.Btn_Edit.UseVisualStyleBackColor = True
        '
        'Btn_New
        '
        Me.Btn_New.Location = New System.Drawing.Point(1225, 32)
        Me.Btn_New.Name = "Btn_New"
        Me.Btn_New.Size = New System.Drawing.Size(213, 56)
        Me.Btn_New.TabIndex = 5
        Me.Btn_New.Text = "جديد"
        Me.Btn_New.UseVisualStyleBackColor = True
        '
        'Btn_Save
        '
        Me.Btn_Save.Location = New System.Drawing.Point(998, 32)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.Size = New System.Drawing.Size(213, 56)
        Me.Btn_Save.TabIndex = 6
        Me.Btn_Save.Text = "حفظ"
        Me.Btn_Save.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.dgvForms)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 158)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1450, 489)
        Me.Panel3.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Panel7)
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(337, 489)
        Me.Panel4.TabIndex = 5
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Txt_Search)
        Me.Panel7.Controls.Add(Me.DGV_Get_All_Forms_Name)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(0, 37)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(337, 398)
        Me.Panel7.TabIndex = 3
        '
        'DGV_Get_All_Forms_Name
        '
        Me.DGV_Get_All_Forms_Name.AllowUserToAddRows = False
        Me.DGV_Get_All_Forms_Name.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_Get_All_Forms_Name.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Get_All_Forms_Name.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Get_All_Forms_Name.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGV_Get_All_Forms_Name.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Get_All_Forms_Name.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FormName})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV_Get_All_Forms_Name.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGV_Get_All_Forms_Name.Dock = System.Windows.Forms.DockStyle.Top
        Me.DGV_Get_All_Forms_Name.Location = New System.Drawing.Point(0, 0)
        Me.DGV_Get_All_Forms_Name.Name = "DGV_Get_All_Forms_Name"
        Me.DGV_Get_All_Forms_Name.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV_Get_All_Forms_Name.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGV_Get_All_Forms_Name.RowHeadersVisible = False
        Me.DGV_Get_All_Forms_Name.RowHeadersWidth = 51
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DGV_Get_All_Forms_Name.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DGV_Get_All_Forms_Name.RowTemplate.Height = 26
        Me.DGV_Get_All_Forms_Name.Size = New System.Drawing.Size(337, 359)
        Me.DGV_Get_All_Forms_Name.TabIndex = 0
        '
        'FormName
        '
        Me.FormName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FormName.HeaderText = "اسم النموذج"
        Me.FormName.MinimumWidth = 6
        Me.FormName.Name = "FormName"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Btn_Get_All_Forms_Name)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 435)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(337, 54)
        Me.Panel6.TabIndex = 2
        '
        'Btn_Get_All_Forms_Name
        '
        Me.Btn_Get_All_Forms_Name.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Btn_Get_All_Forms_Name.Location = New System.Drawing.Point(0, 0)
        Me.Btn_Get_All_Forms_Name.Name = "Btn_Get_All_Forms_Name"
        Me.Btn_Get_All_Forms_Name.Size = New System.Drawing.Size(337, 54)
        Me.Btn_Get_All_Forms_Name.TabIndex = 0
        Me.Btn_Get_All_Forms_Name.Text = "عرض كل اسماء النماذج"
        Me.Btn_Get_All_Forms_Name.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(337, 37)
        Me.Panel5.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(337, 37)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "جلب كل اسماء النماذج"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvForms
        '
        Me.dgvForms.AllowUserToAddRows = False
        Me.dgvForms.AllowUserToDeleteRows = False
        Me.dgvForms.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvForms.BackgroundColor = System.Drawing.SystemColors.Info
        Me.dgvForms.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvForms.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(73, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvForms.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvForms.ColumnHeadersHeight = 40
        Me.dgvForms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(52, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvForms.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvForms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvForms.EnableHeadersVisualStyles = False
        Me.dgvForms.GridColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.dgvForms.Location = New System.Drawing.Point(0, 0)
        Me.dgvForms.Name = "dgvForms"
        Me.dgvForms.ReadOnly = True
        Me.dgvForms.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dgvForms.RowHeadersVisible = False
        Me.dgvForms.RowHeadersWidth = 51
        Me.dgvForms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvForms.Size = New System.Drawing.Size(1450, 489)
        Me.dgvForms.TabIndex = 4
        '
        'Txt_Search
        '
        Me.Txt_Search.Dock = System.Windows.Forms.DockStyle.Top
        Me.Txt_Search.Location = New System.Drawing.Point(0, 359)
        Me.Txt_Search.Name = "Txt_Search"
        Me.Txt_Search.Size = New System.Drawing.Size(337, 39)
        Me.Txt_Search.TabIndex = 1
        '
        'FormManagementForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 32.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1450, 747)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Cairo", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "FormManagementForm"
        Me.ShowIcon = False
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        CType(Me.DGV_Get_All_Forms_Name, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.dgvForms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFormName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_Save As Button
    Friend WithEvents dgvForms As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_FormDescription As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_formName_ar As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents DGV_Get_All_Forms_Name As DataGridView
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Btn_Get_All_Forms_Name As Button
    Friend WithEvents FormName As DataGridViewTextBoxColumn
    Friend WithEvents Txt_Search As TextBox
End Class
