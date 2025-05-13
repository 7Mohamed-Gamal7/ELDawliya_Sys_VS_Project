Imports System.Data.SqlClient

Public Class Frm_Add_Tool
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Public dt_Tbl_Tool_Name As New DataTable
    Public Sub ClearControls()
        Me.Tool_ID.Text = vbNullString
        Me.Tool_Name.Text = vbNullString
        Me.Frm_ID.Text = vbNullString
    End Sub
    Public Sub fillcmb_Tbl_Frm_Name(ByVal cmb As ComboBox)
        Dim DT As New DataTable
        Dim DA As New SqlDataAdapter
        DT.Clear()
        DA = New SqlDataAdapter("Select * FROM Tbl_Frm_Name ", Con)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            cmb.DataSource = DT
            cmb.ValueMember = "Frm_ID"
            cmb.DisplayMember = "Frm_Name"
        Else
            cmb.DataSource = Nothing
        End If
    End Sub

    Public Sub SelectAll_Tbl_Tool_Name(dgv As DataGridView)
        Try
            Dim da As New SqlDataAdapter
            dt_Tbl_Tool_Name.Clear()
            Dim query As String = "SELECT Tbl_Tool_Name.Tool_ID, Tbl_Tool_Name.Tool_Name, Tbl_Frm_Name.Frm_Name " &
                              "FROM Tbl_Tool_Name INNER JOIN Tbl_Frm_Name ON Tbl_Tool_Name.Frm_ID = Tbl_Frm_Name.Frm_ID"
            da = New SqlDataAdapter(query, Con)

            da.Fill(dt_Tbl_Tool_Name)
            dgv.DataSource = dt_Tbl_Tool_Name
            If dgv.RowCount > 0 Then
                With dgv
                    .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                    .Columns("Tool_ID").HeaderText = "كود الاداة"
                    .Columns("Tool_Name").HeaderText = "اسم الاداة"
                    .Columns("Frm_Name").HeaderText = "اسم الشاشة"
                End With
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub
    Public Sub Insert_Tbl_Tool_Name(ByVal Tool_ID As Int32, ByVal Tool_Name As String, ByVal Frm_ID As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Tbl_Tool_Name ( Tool_ID,Tool_Name,Frm_ID)values(@Tool_ID,@Tool_Name,@Frm_ID)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Tool_ID", SqlDbType.Int).Value = Tool_ID
            .Parameters.AddWithValue("@Tool_Name", SqlDbType.VarChar).Value = Tool_Name
            .Parameters.AddWithValue("@Frm_ID", SqlDbType.Int).Value = Frm_ID
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub
    Public Sub Update_Tbl_Tool_Name(ByVal Tool_Name As String, ByVal Frm_ID As Int32, ByVal Tool_IDW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_Tool_Name Set Tool_Name = @Tool_Name,Frm_ID = @Frm_ID Where Tool_ID = @Tool_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Tool_Name", SqlDbType.VarChar).Value = Tool_Name
            .Parameters.AddWithValue("@Frm_ID", SqlDbType.Int).Value = Frm_ID
            .Parameters.AddWithValue("@Tool_ID", SqlDbType.Int).Value = Tool_IDW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Public Sub Delete_Tbl_Tool_Name(ByVal dgv_Tbl_Tool_Name As DataGridView)
        Dim Position As Integer = dgv_Tbl_Tool_Name.CurrentRow.Index
        Dim ID_Position As Integer = dgv_Tbl_Tool_Name.Rows(Position).Cells("Tool_ID").Value
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Delete  From Tbl_Tool_Name Where Tool_ID = @Tool_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Tool_ID", SqlDbType.Int).Value = ID_Position
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم حذف السجل.", MsgBoxStyle.Information, "حذف")
        Cmd = Nothing
    End Sub
    Public Function Max_Tbl_Tool_Name()
        Dim Number As Integer
        Try
            Dim cmd As New SqlCommand("Select Max(Tool_ID) From Tbl_Tool_Name ", Con)
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Number = cmd.ExecuteScalar
            Con.Close()
        Catch ex As Exception
            Number = 0
            Con.Close()
        End Try
        Return Number
    End Function
    Private Sub Frm_Add_Tool_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ChangeScreenResolution(Me)
        ClearControls()
        SelectAll_Tbl_Tool_Name(dgv_Tbl_Tool_Name)
        Tool_ID.Text = Max_Tbl_Tool_Name() + 1
        Tool_Name.Focus()
        fillcmb_Tbl_Frm_Name(Frm_ID)
    End Sub
    Private Sub dgv_Tbl_Tool_Name_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Tbl_Tool_Name.CellContentClick
        Try
            With dgv_Tbl_Tool_Name
                Me.Tool_ID.Text = .CurrentRow.Cells("Tool_ID").Value.ToString()
                Me.Tool_Name.Text = .CurrentRow.Cells("Tool_Name").Value.ToString()
                Me.Frm_ID.Text = .CurrentRow.Cells("Frm_Name").Value.ToString()
                Me.BtnSave.Enabled = False
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        'Dim frmId As Integer
        'Int32.TryParse(Frm_ID.ValueMember, frmId)
        If Tool_ID.Text = vbNullString Or Tool_Name.Text = vbNullString Or Frm_ID.Text = vbNullString Then
            MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Exit Sub
        End If

        Insert_Tbl_Tool_Name(Tool_ID.Text, Tool_Name.Text, Int(Frm_ID.SelectedValue))
        ClearControls()
        Tool_ID.Text = Max_Tbl_Tool_Name() + 1
        SelectAll_Tbl_Tool_Name(dgv_Tbl_Tool_Name)
        Tool_Name.Focus()
    End Sub
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
            Exit Sub
        Else
            Delete_Tbl_Tool_Name(dgv_Tbl_Tool_Name)
        End If
        ClearControls()
        Tool_ID.Text = Max_Tbl_Tool_Name() + 1
        SelectAll_Tbl_Tool_Name(dgv_Tbl_Tool_Name)
        Tool_Name.Focus()
    End Sub
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Update_Tbl_Tool_Name(Tool_Name.Text, Int(Frm_ID.SelectedValue), Tool_ID.Text)
        ClearControls()
        Tool_ID.Text = Max_Tbl_Tool_Name() + 1
        SelectAll_Tbl_Tool_Name(dgv_Tbl_Tool_Name)
        Tool_Name.Focus()
        Me.BtnSave.Enabled = True
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub BtnNewAdd_Click(sender As Object, e As EventArgs) Handles BtnNewAdd.Click
        ClearControls()
        Tool_ID.Text = Max_Tbl_Tool_Name() + 1
        SelectAll_Tbl_Tool_Name(dgv_Tbl_Tool_Name)
        Tool_Name.Focus()
    End Sub

    Private Sub Txt_Search_TextChanged(sender As Object, e As EventArgs) Handles Txt_Search.TextChanged
        Try
            Dim dv As DataView = dt_Tbl_Tool_Name.DefaultView
            dv.RowFilter = " Tool_Name LIKE '%" & Txt_Search.Text & "%' "
        Catch ex As Exception
        End Try
        ' ضعه في حدث تكست بوكس تشانج (TextChanged)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Frm_Add_From.Show()
    End Sub

    Private Sub Frm_ID_DropDown(sender As Object, e As EventArgs) Handles Frm_ID.DropDown
        fillcmb_Tbl_Frm_Name(Frm_ID)
    End Sub

End Class