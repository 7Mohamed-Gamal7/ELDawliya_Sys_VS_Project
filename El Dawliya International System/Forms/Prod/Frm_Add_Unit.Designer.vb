<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Add_Unit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Add_Unit))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnNewAdd = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_Unit_Machine = New System.Windows.Forms.ComboBox()
        Me.Txt_Unit_ID = New System.Windows.Forms.TextBox()
        Me.Txt_Unit_Name = New System.Windows.Forms.TextBox()
        Me.Problem_Machinelbl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgv_Unit = New System.Windows.Forms.DataGridView()
        Me.Txt_Search = New System.Windows.Forms.TextBox()
        Me.Problem_Namelbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv_Unit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel1.Controls.Add(Me.Panel3)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Panel3.Controls.Add(Me.BtnDelete)
        Me.Panel3.Controls.Add(Me.BtnSave)
        Me.Panel3.Controls.Add(Me.BtnNewAdd)
        Me.Panel3.Controls.Add(Me.BtnEdit)
        resources.ApplyResources(Me.Panel3, "Panel3")
        Me.Panel3.Name = "Panel3"
        '
        'BtnDelete
        '
        resources.ApplyResources(Me.BtnDelete, "BtnDelete")
        Me.BtnDelete.FlatAppearance.BorderSize = 0
        Me.BtnDelete.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Remove
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        resources.ApplyResources(Me.BtnSave, "BtnSave")
        Me.BtnSave.FlatAppearance.BorderSize = 0
        Me.BtnSave.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Ok
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnNewAdd
        '
        resources.ApplyResources(Me.BtnNewAdd, "BtnNewAdd")
        Me.BtnNewAdd.FlatAppearance.BorderSize = 0
        Me.BtnNewAdd.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Add
        Me.BtnNewAdd.Name = "BtnNewAdd"
        Me.BtnNewAdd.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        resources.ApplyResources(Me.BtnEdit, "BtnEdit")
        Me.BtnEdit.FlatAppearance.BorderSize = 0
        Me.BtnEdit.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Save_as
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.Label1)
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Menu1
        resources.ApplyResources(Me.PictureBox1, "PictureBox1")
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        resources.ApplyResources(Me.PictureBox2, "PictureBox2")
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.El_Dawliya_International_System.My.Resources.Resources.Cancel
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Name = "Label1"
        '
        'Txt_Unit_Machine
        '
        resources.ApplyResources(Me.Txt_Unit_Machine, "Txt_Unit_Machine")
        Me.Txt_Unit_Machine.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Txt_Unit_Machine.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Txt_Unit_Machine.FormattingEnabled = True
        Me.Txt_Unit_Machine.Items.AddRange(New Object() {resources.GetString("Txt_Unit_Machine.Items"), resources.GetString("Txt_Unit_Machine.Items1"), resources.GetString("Txt_Unit_Machine.Items2"), resources.GetString("Txt_Unit_Machine.Items3"), resources.GetString("Txt_Unit_Machine.Items4")})
        Me.Txt_Unit_Machine.Name = "Txt_Unit_Machine"
        '
        'Txt_Unit_ID
        '
        resources.ApplyResources(Me.Txt_Unit_ID, "Txt_Unit_ID")
        Me.Txt_Unit_ID.Name = "Txt_Unit_ID"
        Me.Txt_Unit_ID.ReadOnly = True
        '
        'Txt_Unit_Name
        '
        resources.ApplyResources(Me.Txt_Unit_Name, "Txt_Unit_Name")
        Me.Txt_Unit_Name.Name = "Txt_Unit_Name"
        '
        'Problem_Machinelbl
        '
        resources.ApplyResources(Me.Problem_Machinelbl, "Problem_Machinelbl")
        Me.Problem_Machinelbl.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Problem_Machinelbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Problem_Machinelbl.ForeColor = System.Drawing.Color.Black
        Me.Problem_Machinelbl.Name = "Problem_Machinelbl"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Name = "Label2"
        '
        'dgv_Unit
        '
        Me.dgv_Unit.AllowUserToAddRows = False
        Me.dgv_Unit.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Questv1", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.dgv_Unit.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        resources.ApplyResources(Me.dgv_Unit, "dgv_Unit")
        Me.dgv_Unit.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Unit.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv_Unit.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv_Unit.EnableHeadersVisualStyles = False
        Me.dgv_Unit.Name = "dgv_Unit"
        Me.dgv_Unit.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Hacen Saudi Arabia", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv_Unit.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgv_Unit.RowHeadersVisible = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Questv1", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv_Unit.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv_Unit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'Txt_Search
        '
        resources.ApplyResources(Me.Txt_Search, "Txt_Search")
        Me.Txt_Search.Name = "Txt_Search"
        '
        'Problem_Namelbl
        '
        resources.ApplyResources(Me.Problem_Namelbl, "Problem_Namelbl")
        Me.Problem_Namelbl.ForeColor = System.Drawing.Color.Black
        Me.Problem_Namelbl.Name = "Problem_Namelbl"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(197, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Name = "Label3"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Problem_Namelbl)
        Me.Panel4.Controls.Add(Me.Txt_Search)
        Me.Panel4.Controls.Add(Me.dgv_Unit)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Problem_Machinelbl)
        Me.Panel4.Controls.Add(Me.Txt_Unit_Name)
        Me.Panel4.Controls.Add(Me.Txt_Unit_ID)
        Me.Panel4.Controls.Add(Me.Txt_Unit_Machine)
        resources.ApplyResources(Me.Panel4, "Panel4")
        Me.Panel4.Name = "Panel4"
        '
        'Frm_Add_Unit
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "Frm_Add_Unit"
        Me.ShowIcon = False
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv_Unit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnNewAdd As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Txt_Unit_Machine As ComboBox
    Friend WithEvents Txt_Unit_ID As TextBox
    Friend WithEvents Txt_Unit_Name As TextBox
    Friend WithEvents Problem_Machinelbl As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dgv_Unit As DataGridView
    Friend WithEvents Txt_Search As TextBox
    Friend WithEvents Problem_Namelbl As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
End Class
