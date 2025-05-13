Imports System.Data.SqlClient

Public Class Frm_Add_From
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Public dt_Tbl_Frm_Name As New DataTable
    Public Sub ClearControls()
        Me.Frm_ID.Text = vbNullString
        Me.Frm_Name.Text = vbNullString
    End Sub
    Public Sub SelectAll_Tbl_Frm_Name(dgv As DataGridView)
        Try
            Dim da As New SqlDataAdapter
            dt_Tbl_Frm_Name.Clear()
            da = New SqlDataAdapter("select * from Tbl_Frm_Name", Con)
            da.Fill(dt_Tbl_Frm_Name)
            dgv.DataSource = dt_Tbl_Frm_Name
            If dgv.RowCount > 0 Then
                With dgv
                    .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                    .Columns("Frm_ID").HeaderText = "كود الفورم"
                    .Columns("Frm_Name").HeaderText = "اسم الفورم"
                End With
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Public Function Max_Tbl_Frm_Name()
        Dim Number As Integer
        Try
            Dim cmd As New SqlCommand("Select Max(Frm_ID) From Tbl_Frm_Name ", Con)
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

    Public Sub Insert_Tbl_Frm_Name(ByVal Frm_ID As Int32, ByVal Frm_Name As String)
        Try
            Dim Cmd As New SqlCommand
            With Cmd
                .Connection = Con
                .CommandType = CommandType.Text
                .CommandText = "Insert Into Tbl_Frm_Name ( Frm_ID,Frm_Name)values(@Frm_ID,@Frm_Name)"
                .Parameters.Clear()
                .Parameters.AddWithValue("@Frm_ID", SqlDbType.Int).Value = Frm_ID
                .Parameters.AddWithValue("@Frm_Name", SqlDbType.VarChar).Value = Frm_Name
            End With
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Cmd.ExecuteNonQuery()
            Con.Close()
            MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
            Cmd = Nothing
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Public Sub Update_Tbl_Frm_Name(ByVal Frm_Name As String, ByVal Frm_IDW As Int32)
        Try
            Dim Cmd As New SqlCommand
            With Cmd
                .Connection = Con
                .CommandType = CommandType.Text
                .CommandText = "Update Tbl_Frm_Name Set Frm_Name = @Frm_Name Where Frm_ID = @Frm_ID"
                .Parameters.Clear()
                .Parameters.AddWithValue("@Frm_Name", SqlDbType.VarChar).Value = Frm_Name
                .Parameters.AddWithValue("@Frm_ID", SqlDbType.Int).Value = Frm_IDW
            End With
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Cmd.ExecuteNonQuery()
            Con.Close()
            MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
            Cmd = Nothing
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Public Sub Delete_Tbl_Frm_Name(ByVal dgv_Tbl_Frm_Name As DataGridView)
        Try
            Dim Position As Integer = dgv_Tbl_Frm_Name.CurrentRow.Index
            Dim ID_Position As Integer = dgv_Tbl_Frm_Name.Rows(Position).Cells("Frm_ID").Value
            Dim Cmd As New SqlCommand
            With Cmd
                .Connection = Con
                .CommandType = CommandType.Text
                .CommandText = "Delete  From Tbl_Frm_Name Where Frm_ID = @Frm_ID"
                .Parameters.Clear()
                .Parameters.AddWithValue("@Frm_ID", SqlDbType.Int).Value = ID_Position
            End With
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Cmd.ExecuteNonQuery()
            Con.Close()
            MsgBox("تم حذف السجل.", MsgBoxStyle.Information, "حذف")
            Cmd = Nothing
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If Frm_ID.Text = vbNullString Or Frm_Name.Text = vbNullString Then
            MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Exit Sub
        End If
        Try
            Insert_Tbl_Frm_Name(Frm_ID.Text, Frm_Name.Text)
            ClearControls()
            Frm_ID.Text = Max_Tbl_Frm_Name() + 1
            Me.Frm_Name.Focus()
            SelectAll_Tbl_Frm_Name(dgv_Tbl_Frm_Name)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub Frm_Add_From_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ChangeScreenResolution(Me)
        Modul_Font.ApplyFontToTextBoxesAndLabels(Me)
        Modul_Font.ApplyFontToDateTimePickers(Me)
        ClearControls()
        Frm_ID.Text = Max_Tbl_Frm_Name() + 1
        SelectAll_Tbl_Frm_Name(dgv_Tbl_Frm_Name)
        Frm_Name.Focus()
    End Sub
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If Frm_ID.Text = vbNullString Or Frm_Name.Text = vbNullString Then
            MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Exit Sub
        End If
        Try
            Update_Tbl_Frm_Name(Frm_Name.Text, Frm_ID.Text)
            ClearControls()
            Frm_ID.Text = Max_Tbl_Frm_Name() + 1
            SelectAll_Tbl_Frm_Name(dgv_Tbl_Frm_Name)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Try
            If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                Exit Sub
            Else
                Delete_Tbl_Frm_Name(dgv_Tbl_Frm_Name)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub dgv_Tbl_Frm_Name_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Tbl_Frm_Name.CellContentClick
        Try
            With dgv_Tbl_Frm_Name
                Me.Frm_ID.Text = .CurrentRow.Cells("Frm_ID").Value.ToString()
                Me.Frm_Name.Text = .CurrentRow.Cells("Frm_Name").Value.ToString()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Txt_Search_TextChanged(sender As Object, e As EventArgs) Handles Txt_Search.TextChanged
        Try
            Dim dv As DataView = dt_Tbl_Frm_Name.DefaultView
            dv.RowFilter = " Frm_Name LIKE '%" & Txt_Search.Text & "%' "
        Catch ex As Exception
        End Try
        ' ضعه في حدث تكست بوكس تشانج (TextChanged)
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

End Class