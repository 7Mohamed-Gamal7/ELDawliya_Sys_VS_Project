Imports System.Data.SqlClient

Public Class GroupManagementForm2
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Public dt_Groups As New DataTable

    Public Sub ClearControls()
        Me.Txt_GroupID.Text = vbNullString
        Me.txtGroupName.Text = vbNullString
        btn_Edit.Enabled = False
        btnAddGroup.Enabled = True
        btnDeleteGroup.Enabled = False
        Me.txtGroupName.Focus()
    End Sub

    Public Sub DataGridViewHeaderText(ByVal DGV As DataGridView)
        If DGV.RowCount > 0 Then
            With DGV
                .Columns("GroupID").HeaderText = "كود المجموعة"
                .Columns("GroupID").Width = 300
                .Columns("GroupName").HeaderText = "اسم المجموعة"
                .Columns("GroupName").Width = 700
            End With
        End If
    End Sub


    Private Sub GroupManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomizeForm(Me)
        LoadGroups()
        DataGridViewHeaderText(dgvGroups)
        btn_Edit.Enabled = False
        btnAddGroup.Enabled = True
        btnDeleteGroup.Enabled = False
        txtGroupName.Focus()

    End Sub

    Private Sub LoadGroups()
        Dim query As String = "SELECT GroupID, GroupName FROM Groups"
        Dim adapter As New SqlDataAdapter(query, Con)
        Dim dt As New DataTable()
        adapter.Fill(dt)
        dgvGroups.DataSource = dt
    End Sub

    Private Sub btnAddGroup_Click(sender As Object, e As EventArgs) Handles btnAddGroup.Click
        If txtGroupName.Text = vbNullString Then
            MessageBox.Show("عفواً ، قم بتعبئة كل حقل اسم المجموعة", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Exit Sub
        End If

        Dim groupName As String = txtGroupName.Text
        Dim query As String = "INSERT INTO Groups (GroupName) VALUES (@GroupName)"
        Using Con As New SqlConnection(ConStr)
            Using command As New SqlCommand(query, Con)
                command.Parameters.AddWithValue("@GroupName", groupName)
                Con.Open()
                command.ExecuteNonQuery()
                LoadGroups()
            End Using
        End Using
        ClearControls()
    End Sub

    Private Sub btnDeleteGroup_Click(sender As Object, e As EventArgs) Handles btnDeleteGroup.Click
        If dgvGroups.SelectedRows.Count > 0 Then
            Dim groupID As Integer = Convert.ToInt32(dgvGroups.SelectedRows(0).Cells("GroupID").Value)
            Dim query As String = "DELETE FROM Groups WHERE GroupID = @GroupID"
            Using Con As New SqlConnection(ConStr)
                Using command As New SqlCommand(query, Con)
                    command.Parameters.AddWithValue("@GroupID", groupID)
                    Con.Open()
                    command.ExecuteNonQuery()
                    LoadGroups()
                End Using
            End Using
        End If
    End Sub

    Public Sub Update_Groups(ByVal GroupName As String, ByVal GroupIDW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Groups Set GroupName = @GroupName Where GroupID = @GroupID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@GroupName", SqlDbType.VarChar).Value = GroupName
            .Parameters.AddWithValue("@GroupID", SqlDbType.Int).Value = GroupIDW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Private Sub dgvGroups_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvGroups.CellContentClick
        Try
            With dgvGroups
                Me.Txt_GroupID.Text = .CurrentRow.Cells("GroupID").Value.ToString()
                Me.txtGroupName.Text = .CurrentRow.Cells("GroupName").Value.ToString()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        btn_Edit.Enabled = True
        btnAddGroup.Enabled = False
        btnDeleteGroup.Enabled = True
    End Sub


    Private Sub btn_Edit_Click(sender As Object, e As EventArgs) Handles btn_Edit.Click
        If Txt_GroupID.Text = vbNullString Or txtGroupName.Text = vbNullString Then
            MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Exit Sub
        End If
        Update_Groups(txtGroupName.Text, Txt_GroupID.Text)
        ClearControls()
        LoadGroups()
    End Sub

End Class
