<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Categories
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
        Me.ID_CATlbl = New System.Windows.Forms.Label()
        Me.CAT_ID = New System.Windows.Forms.TextBox()
        Me.DESCRIPTION_CATlbl = New System.Windows.Forms.Label()
        Me.CAT_Name = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnNewAdd = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.dgv_CATEGORIES = New System.Windows.Forms.DataGridView()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.Txt_Search = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv_CATEGORIES, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel1.SuspendLayout()
        Me.MetroPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ID_CATlbl
        '
        Me.ID_CATlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.ID_CATlbl.ForeColor = System.Drawing.Color.Black
        Me.ID_CATlbl.Location = New System.Drawing.Point(452, 6)
        Me.ID_CATlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ID_CATlbl.Name = "ID_CATlbl"
        Me.ID_CATlbl.Size = New System.Drawing.Size(170, 34)
        Me.ID_CATlbl.TabIndex = 0
        Me.ID_CATlbl.Text = "كود التصنيف"
        Me.ID_CATlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CAT_ID
        '
        Me.CAT_ID.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CAT_ID.Location = New System.Drawing.Point(17, 6)
        Me.CAT_ID.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.CAT_ID.Name = "CAT_ID"
        Me.CAT_ID.ReadOnly = True
        Me.CAT_ID.Size = New System.Drawing.Size(429, 38)
        Me.CAT_ID.TabIndex = 1
        Me.CAT_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DESCRIPTION_CATlbl
        '
        Me.DESCRIPTION_CATlbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.DESCRIPTION_CATlbl.ForeColor = System.Drawing.Color.Black
        Me.DESCRIPTION_CATlbl.Location = New System.Drawing.Point(452, 50)
        Me.DESCRIPTION_CATlbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DESCRIPTION_CATlbl.Name = "DESCRIPTION_CATlbl"
        Me.DESCRIPTION_CATlbl.Size = New System.Drawing.Size(170, 34)
        Me.DESCRIPTION_CATlbl.TabIndex = 2
        Me.DESCRIPTION_CATlbl.Text = "اسم التصنيف"
        Me.DESCRIPTION_CATlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CAT_Name
        '
        Me.CAT_Name.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CAT_Name.Location = New System.Drawing.Point(17, 50)
        Me.CAT_Name.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.CAT_Name.Name = "CAT_Name"
        Me.CAT_Name.Size = New System.Drawing.Size(429, 38)
        Me.CAT_Name.TabIndex = 3
        Me.CAT_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.BtnSave)
        Me.Panel1.Controls.Add(Me.BtnEdit)
        Me.Panel1.Controls.Add(Me.BtnNewAdd)
        Me.Panel1.Controls.Add(Me.BtnDelete)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 566)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(631, 60)
        Me.Panel1.TabIndex = 24
        '
        'BtnSave
        '
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Questv1", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Ok
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSave.Location = New System.Drawing.Point(339, 5)
        Me.BtnSave.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnSave.Size = New System.Drawing.Size(117, 48)
        Me.BtnSave.TabIndex = 106
        Me.BtnSave.Text = "حفظ"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.FlatAppearance.BorderSize = 0
        Me.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEdit.Font = New System.Drawing.Font("Questv1", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Save_as
        Me.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEdit.Location = New System.Drawing.Point(172, 5)
        Me.BtnEdit.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(113, 48)
        Me.BtnEdit.TabIndex = 107
        Me.BtnEdit.Text = "تعديل"
        Me.BtnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnNewAdd
        '
        Me.BtnNewAdd.FlatAppearance.BorderSize = 0
        Me.BtnNewAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNewAdd.Font = New System.Drawing.Font("Questv1", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNewAdd.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Add
        Me.BtnNewAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNewAdd.Location = New System.Drawing.Point(510, 5)
        Me.BtnNewAdd.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.BtnNewAdd.Name = "BtnNewAdd"
        Me.BtnNewAdd.Size = New System.Drawing.Size(117, 48)
        Me.BtnNewAdd.TabIndex = 105
        Me.BtnNewAdd.Text = "جديد"
        Me.BtnNewAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNewAdd.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.FlatAppearance.BorderSize = 0
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Font = New System.Drawing.Font("Questv1", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Remove
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.Location = New System.Drawing.Point(5, 5)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(113, 48)
        Me.BtnDelete.TabIndex = 108
        Me.BtnDelete.Text = "حذف"
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'dgv_CATEGORIES
        '
        Me.dgv_CATEGORIES.AllowUserToAddRows = False
        Me.dgv_CATEGORIES.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Cairo", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv_CATEGORIES.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv_CATEGORIES.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_CATEGORIES.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_CATEGORIES.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv_CATEGORIES.ColumnHeadersHeight = 40
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_CATEGORIES.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_CATEGORIES.EnableHeadersVisualStyles = False
        Me.dgv_CATEGORIES.Location = New System.Drawing.Point(7, 187)
        Me.dgv_CATEGORIES.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.dgv_CATEGORIES.Name = "dgv_CATEGORIES"
        Me.dgv_CATEGORIES.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_CATEGORIES.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_CATEGORIES.RowHeadersVisible = False
        Me.dgv_CATEGORIES.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Cairo SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_CATEGORIES.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_CATEGORIES.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_CATEGORIES.Size = New System.Drawing.Size(615, 372)
        Me.dgv_CATEGORIES.TabIndex = 112
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.Label1)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(0, 0)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(631, 48)
        Me.MetroPanel1.Style = MetroFramework.MetroColorStyle.Silver
        Me.MetroPanel1.TabIndex = 113
        Me.MetroPanel1.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Hacen Saudi Arabia", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(631, 48)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "اضافة تصنيف جديد"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MetroPanel2
        '
        Me.MetroPanel2.BackColor = System.Drawing.Color.Teal
        Me.MetroPanel2.Controls.Add(Me.Txt_Search)
        Me.MetroPanel2.Controls.Add(Me.Label2)
        Me.MetroPanel2.Controls.Add(Me.CAT_Name)
        Me.MetroPanel2.Controls.Add(Me.ID_CATlbl)
        Me.MetroPanel2.Controls.Add(Me.DESCRIPTION_CATlbl)
        Me.MetroPanel2.Controls.Add(Me.CAT_ID)
        Me.MetroPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(0, 48)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(631, 134)
        Me.MetroPanel2.Style = MetroFramework.MetroColorStyle.Orange
        Me.MetroPanel2.TabIndex = 114
        Me.MetroPanel2.UseCustomBackColor = True
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'Txt_Search
        '
        Me.Txt_Search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_Search.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Search.Location = New System.Drawing.Point(17, 94)
        Me.Txt_Search.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Txt_Search.Name = "Txt_Search"
        Me.Txt_Search.Size = New System.Drawing.Size(429, 38)
        Me.Txt_Search.TabIndex = 43
        Me.Txt_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(452, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 34)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "ابحث هنا"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Frm_Categories
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 27.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(631, 626)
        Me.Controls.Add(Me.MetroPanel2)
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.dgv_CATEGORIES)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Hacen Saudi Arabia", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.MaximizeBox = False
        Me.Name = "Frm_Categories"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgv_CATEGORIES, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CAT_ID As System.Windows.Forms.TextBox
    Friend WithEvents ID_CATlbl As System.Windows.Forms.Label
    Friend WithEvents CAT_Name As System.Windows.Forms.TextBox
    Friend WithEvents DESCRIPTION_CATlbl As System.Windows.Forms.Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnNewAdd As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents dgv_CATEGORIES As DataGridView
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_Search As TextBox
    Friend WithEvents Label2 As Label
End Class
