Imports System.Data.SqlClient
Imports El_Dawliya_International_System.El_Dawliya_International_System.Forms.Report

Public Class InternalPhones
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Public dt_InternalPhones As New DataTable

    Public Sub ClearControls()
        Me.ID.Text = vbNullString
        Me.EmployeeName.Text = vbNullString
        Me.Dept_Code.Text = vbNullString
        Me.PhoneExtension.Text = vbNullString
        EmployeeName.Focus()
        SelectAll_InternalPhones(dgv_InternalPhones)
    End Sub

    Public Sub fillcmb_Tbl_Department(ByVal cmb As ComboBox)
        Dim DT As New DataTable
        Dim DA As New SqlDataAdapter
        DT.Clear()
        DA = New SqlDataAdapter("Select * FROM Tbl_Department ", Con)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            cmb.DataSource = DT
            cmb.ValueMember = "Dept_Code"
            cmb.DisplayMember = "Dept_Name"
        Else
            cmb.DataSource = Nothing
        End If
    End Sub

    Public Sub SelectAll_InternalPhones(dgv As DataGridView)
        Dim da As New SqlDataAdapter
        dt_InternalPhones.Clear()
        da = New SqlDataAdapter("SELECT dbo.InternalPhones.*, dbo.Tbl_Department.Dept_Name FROM 
                  dbo.InternalPhones 
                  INNER JOIN
                  dbo.Tbl_Department ON dbo.InternalPhones.Dept_Code = dbo.Tbl_Department.Dept_Code", Con)
        da.Fill(dt_InternalPhones)
        dgv.DataSource = dt_InternalPhones
        'With dgv
        '    .Columns("ID").HeaderText = "ID"
        '    .Columns("ID").Visible = False
        '    .Columns("EmployeeName").HeaderText = "اسم الموظف"
        '    .Columns("EmployeeName").Width = 300
        '    .Columns("Dept_Code").HeaderText = "كود القسم"
        '    .Columns("Dept_Code").Visible = False
        '    .Columns("Dept_Name").HeaderText = "القسم"
        '    .Columns("Dept_Name").Width = 300
        '    .Columns("PhoneExtension").HeaderText = "التليفون"
        '    .Columns("PhoneExtension").Width = 300
        'End With
        With dgv
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill ' ملائمة الأعمدة بناءً على المحتوى
            .Columns("ID").HeaderText = "ID"
            .Columns("ID").Visible = False
            .Columns("EmployeeName").HeaderText = "اسم الموظف"
            .Columns("Dept_Code").HeaderText = "كود القسم"
            .Columns("Dept_Code").Visible = False
            .Columns("Dept_Name").HeaderText = "القسم"
            .Columns("PhoneExtension").HeaderText = "التليفون"
        End With

    End Sub

    Public Sub Insert_InternalPhones(ByVal EmployeeName As String, ByVal Dept_Code As Int32, ByVal PhoneExtension As String)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into InternalPhones ( EmployeeName,Dept_Code,PhoneExtension)values(@EmployeeName,@Dept_Code,@PhoneExtension)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@EmployeeName", SqlDbType.VarChar).Value = EmployeeName
            .Parameters.AddWithValue("@Dept_Code", SqlDbType.Int).Value = Dept_Code
            .Parameters.AddWithValue("@PhoneExtension", SqlDbType.VarChar).Value = PhoneExtension
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub

    Public Sub Update_InternalPhones(ByVal EmployeeName As String, ByVal Dept_Code As Int32, ByVal PhoneExtension As String, ByVal IDW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update InternalPhones Set EmployeeName = @EmployeeName,Dept_Code = @Dept_Code,PhoneExtension = @PhoneExtension Where ID = @ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@EmployeeName", SqlDbType.VarChar).Value = EmployeeName
            .Parameters.AddWithValue("@Dept_Code", SqlDbType.Int).Value = Dept_Code
            .Parameters.AddWithValue("@PhoneExtension", SqlDbType.VarChar).Value = PhoneExtension
            .Parameters.AddWithValue("@ID", SqlDbType.Int).Value = IDW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub


    Public Sub Delete_InternalPhones(ByVal dgv_InternalPhones As DataGridView)
        Dim Position As Integer = dgv_InternalPhones.CurrentRow.Index
        Dim ID_Position As Integer = dgv_InternalPhones.Rows(Position).Cells("ID").Value
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Delete  From InternalPhones Where ID = @ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@ID", SqlDbType.Int).Value = ID_Position
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم حذف السجل.", MsgBoxStyle.Information, "حذف")
        Cmd = Nothing
    End Sub



    Private Sub InternalPhones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyPermissions(Me.Name)
        CustomizeForm(Me)
        ClearControls()
        fillcmb_Tbl_Department(Dept_Code)
    End Sub

    Private Sub dgv_InternalPhones_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_InternalPhones.CellContentClick
        Try
            With dgv_InternalPhones
                Me.ID.Text = .CurrentRow.Cells("ID").Value.ToString()
                Me.EmployeeName.Text = .CurrentRow.Cells("EmployeeName").Value.ToString()
                Me.Dept_Code.SelectedValue = .CurrentRow.Cells("Dept_Code").Value.ToString()
                Me.PhoneExtension.Text = .CurrentRow.Cells("PhoneExtension").Value.ToString()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        BtnEdit.Enabled = True
        BtnDelete.Enabled = True
        BtnSave.Enabled = False
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        '-------------------------------------------------------------------------------------------------------
        'خاص بتطبيق الصلاحيات
        If Not CanAdd Then
            MessageBox.Show("ليس لديك صلاحية الاضافة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        '-------------------------------------------------------------------------------------------------------

        Insert_InternalPhones(EmployeeName.Text, Dept_Code.SelectedValue, PhoneExtension.Text)
        ClearControls()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        '-------------------------------------------------------------------------------------------------------
        'خاص بتطبيق الصلاحيات
        If Not CanEdit Then
            MessageBox.Show("ليس لديك صلاحية التعديل.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        '-------------------------------------------------------------------------------------------------------
        Update_InternalPhones(EmployeeName.Text, Dept_Code.SelectedValue, PhoneExtension.Text, ID.Text)
        ClearControls()
    End Sub

    Private Sub BtnNewAdd_Click(sender As Object, e As EventArgs) Handles BtnNewAdd.Click
        '-------------------------------------------------------------------------------------------------------
        'خاص بتطبيق الصلاحيات
        If Not CanAdd Then
            MessageBox.Show("ليس لديك صلاحية الاضافة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        '-------------------------------------------------------------------------------------------------------
        ClearControls()
        BtnEdit.Enabled = False
        BtnDelete.Enabled = False
        BtnSave.Enabled = True
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        '-------------------------------------------------------------------------------------------------------
        'خاص بتطبيق الصلاحيات
        If Not CanDelete Then
            MessageBox.Show("ليس لديك صلاحية الحذف.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        '-------------------------------------------------------------------------------------------------------
        If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
            Exit Sub
        Else
            Delete_InternalPhones(dgv_InternalPhones)
        End If
        ClearControls()
    End Sub

    Private Sub btn_UpdateStatus_Click(sender As Object, e As EventArgs) Handles btn_UpdateStatus.Click
        Me.Close()
    End Sub

    Private Sub Txt_Search_TextChanged(sender As Object, e As EventArgs) Handles Txt_Search.TextChanged
        Try
            Dim dv As DataView = dt_InternalPhones.DefaultView
            dv.RowFilter = " EmployeeName LIKE '%" & Txt_Search.Text & "%' or Dept_Name LIKE '%" & Txt_Search.Text & "%' "
        Catch ex As Exception
        End Try
        ' ضعه في حدث تكست بوكس تشانج (TextChanged)

    End Sub

    Private Sub btn_Print_Report_Click(sender As Object, e As EventArgs) Handles btn_Print_Report.Click
        Dim rep As New Rep_InternalPhones
        rep.SetDataSource(dt_InternalPhones.DefaultView)
        Frm_Report.CrystalReportViewer1.ReportSource = rep
        Frm_Report.CrystalReportViewer1.Refresh()
        Frm_Report.ShowDialog()

    End Sub
End Class