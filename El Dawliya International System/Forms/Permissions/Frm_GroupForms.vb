Imports System.Data.SqlClient

Public Class Frm_GroupForms
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Public dt_GroupForms As New DataTable

    Public Sub fillcmb_Forms(ByVal cmb As ComboBox)
        Dim DT As New DataTable
        Dim DA As New SqlDataAdapter
        DT.Clear()
        DA = New SqlDataAdapter("Select * FROM Forms ", Con)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            cmb.DataSource = DT
            cmb.ValueMember = "FormID"
            'cmb.DisplayMember = "FormName"
            cmb.DisplayMember = "FormName_Ar"
        Else
            cmb.DataSource = Nothing
        End If
    End Sub


    Public Sub fillcmb_Groups(ByVal cmb As ComboBox)
        Dim DT As New DataTable
        Dim DA As New SqlDataAdapter
        DT.Clear()
        DA = New SqlDataAdapter("Select * FROM Groups ", Con)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            cmb.DataSource = DT
            cmb.ValueMember = "GroupID"
            cmb.DisplayMember = "GroupName"
        Else
            cmb.DataSource = Nothing
        End If
    End Sub

    Public Sub SelectAll_GroupForms(dgv As DataGridView)
        Try
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim da As New SqlDataAdapter
            dt_GroupForms.Clear()
            da = New SqlDataAdapter("SELECT dbo.GroupForms.GroupFormID,dbo.Forms.FormName,dbo.Forms.FormName_Ar, dbo.Forms.FormDescription, dbo.Groups.GroupName
                  FROM     dbo.Forms INNER JOIN
                  dbo.GroupForms ON dbo.Forms.FormID = dbo.GroupForms.FormID INNER JOIN
                  dbo.Groups ON dbo.GroupForms.GroupID = dbo.Groups.GroupID", Con)
            da.Fill(dt_GroupForms)
            dgv.DataSource = dt_GroupForms
            'If dgv.RowCount > 0 Then
            With dgv
                .Columns("GroupFormID").HeaderText = "كود مجموعة النماذج"
                .Columns("GroupFormID").Width = 50
                '.Columns("GroupID").HeaderText = "كود المجموعة"
                '.Columns("GroupID").Width = 50
                .Columns("GroupName").HeaderText = "اسم المجموعة"
                .Columns("GroupName").Width = 200
                '.Columns("FormID").HeaderText = "كود النموذج"
                '.Columns("FormID").Width = 50
                .Columns("FormName").HeaderText = "اسم النموذج"
                .Columns("FormName").Width = 200
                .Columns("FormName_Ar").HeaderText = "اسم النموذج باللغة العربية"
                .Columns("FormName").Width = 200
                .Columns("FormDescription").HeaderText = "وصف النموذج"
                .Columns("FormDescription").Width = 200
            End With
            'End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Con.Close()
    End Sub


    Public Sub ClearControls()
        Me.GroupFormID.Text = vbNullString
        Me.GroupID.Text = vbNullString
        Me.FormID.Text = vbNullString
    End Sub

    Public Sub Insert_GroupForms(ByVal GroupID As Int32, ByVal FormID As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into GroupForms ( GroupID,FormID) values (@GroupID,@FormID)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@GroupID", SqlDbType.Int).Value = GroupID
            .Parameters.AddWithValue("@FormID", SqlDbType.Int).Value = FormID
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub


    Public Sub Update_GroupForms(ByVal GroupID As Int32, ByVal FormID As Int32, ByVal GroupFormIDW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update GroupForms Set GroupID = @GroupID,FormID = @FormID Where GroupFormID = @GroupFormID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@GroupID", SqlDbType.Int).Value = GroupID
            .Parameters.AddWithValue("@FormID", SqlDbType.Int).Value = FormID
            .Parameters.AddWithValue("@GroupFormID", SqlDbType.Int).Value = GroupFormIDW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Public Sub Delete_GroupForms(ByVal dgv_GroupForms As DataGridView)
        Dim Position As Integer = dgv_GroupForms.CurrentRow.Index
        Dim ID_Position As Integer = dgv_GroupForms.Rows(Position).Cells("GroupFormID").Value
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Delete  From GroupForms Where GroupFormID = @GroupFormID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@GroupFormID", SqlDbType.Int).Value = ID_Position
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم حذف السجل.", MsgBoxStyle.Information, "حذف")
        Cmd = Nothing
    End Sub


    Private Sub Frm_GroupForms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomizeForm(Me)
        ClearControls()
        SelectAll_GroupForms(dgv_GroupForms)
        fillcmb_Forms(FormID)
        fillcmb_Groups(GroupID)
    End Sub

    Private Sub dgv_GroupForms_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_GroupForms.CellContentClick
        Try
            With dgv_GroupForms
                Me.GroupFormID.Text = .CurrentRow.Cells("GroupFormID").Value.ToString()
                Me.GroupID.ValueMember = .CurrentRow.Cells("GroupID").Value.ToString()
                Me.FormID.ValueMember = .CurrentRow.Cells("FormID").Value.ToString()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If GroupID.SelectedValue IsNot Nothing AndAlso FormID.SelectedValue IsNot Nothing Then
            Insert_GroupForms(Convert.ToInt32(GroupID.SelectedValue), Convert.ToInt32(FormID.SelectedValue))
            ClearControls()
        Else
            MsgBox("يرجى اختيار مجموعة ونموذج قبل الحفظ", MsgBoxStyle.Exclamation, "خطأ")
        End If
        SelectAll_GroupForms(dgv_GroupForms)
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Update_GroupForms(GroupID.ValueMember, FormID.ValueMember, GroupFormID.Text)
        ClearControls()
        SelectAll_GroupForms(dgv_GroupForms)
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
            Exit Sub
        Else
            Delete_GroupForms(dgv_GroupForms)
        End If
        ClearControls()
        SelectAll_GroupForms(dgv_GroupForms)
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class