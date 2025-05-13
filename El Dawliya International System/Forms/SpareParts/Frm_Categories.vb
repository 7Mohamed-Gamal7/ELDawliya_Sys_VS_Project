Imports System.Data.SqlClient

Public Class Frm_Categories
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Public dt_CATEGORIES As New DataTable
    Public Sub ClearControls()
        Me.CAT_ID.Text = vbNullString
        Me.CAT_Name.Text = vbNullString
    End Sub
    Public Function Max_CATEGORIES()
        Dim Number As Integer
        Try
            Dim cmd As New SqlCommand("Select Max(CAT_ID) From Tbl_Categories ", Con)
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
    Public Sub Insert_CATEGORIES(ByVal CAT_ID As Int32, ByVal CAT_Name As String)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Tbl_Categories ( CAT_ID,CAT_Name)values(@CAT_ID,@CAT_Name)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@CAT_ID", SqlDbType.Int).Value = CAT_ID
            .Parameters.AddWithValue("@CAT_Name", SqlDbType.VarChar).Value = CAT_Name
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub
    Public Sub Update_CATEGORIES(ByVal CAT_Name As String, ByVal CAT_IDW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_Categories Set CAT_Name = @CAT_Name Where CAT_ID = @CAT_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@CAT_Name", SqlDbType.VarChar).Value = CAT_Name
            .Parameters.AddWithValue("@CAT_ID", SqlDbType.Int).Value = CAT_IDW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub
    Public Sub Delete_CATEGORIES(ByVal dgv_CATEGORIES As DataGridView)
        Dim Position As Integer = dgv_CATEGORIES.CurrentRow.Index
        Dim ID_Position As Integer = dgv_CATEGORIES.Rows(Position).Cells("CAT_ID").Value
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Delete  From Tbl_Categories Where CAT_ID = @CAT_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@CAT_ID", SqlDbType.Int).Value = ID_Position
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم حذف السجل.", MsgBoxStyle.Information, "حذف")
        Cmd = Nothing
    End Sub
    Public Sub SelectAll_CATEGORIES(dgv As DataGridView)
        Dim da As New SqlDataAdapter
        dt_CATEGORIES.Clear()
        da = New SqlDataAdapter("select * from Tbl_Categories", Con)
        da.Fill(dt_CATEGORIES)
        dgv.DataSource = dt_CATEGORIES
        With dgv
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            .Columns("CAT_ID").HeaderText = "كود التصنيف"
            .Columns("CAT_ID").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns("CAT_Name").HeaderText = "اسم التصنيف"
            .Columns("CAT_Name").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End With
    End Sub
    Private Sub Frm_Categories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearControls()
        CAT_ID.Text = Max_CATEGORIES() + 1
        CAT_Name.Focus()
        SelectAll_CATEGORIES(dgv_CATEGORIES)
        BtnEdit.Enabled = False
        BtnDelete.Enabled = False
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If CAT_Name.Text = vbNullString Then
            MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Exit Sub
        End If
        Insert_CATEGORIES(CAT_ID.Text, CAT_Name.Text)
        ClearControls()
        CAT_ID.Text = Max_CATEGORIES() + 1
        CAT_Name.Focus()
        SelectAll_CATEGORIES(dgv_CATEGORIES)

    End Sub
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If CAT_Name.Text = vbNullString Then
            MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Exit Sub
        End If
        Update_CATEGORIES(CAT_Name.Text, CAT_ID.Text)
        CAT_ID.Text = Max_CATEGORIES() + 1
        CAT_Name.Focus()
        SelectAll_CATEGORIES(dgv_CATEGORIES)

    End Sub
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
            Exit Sub
        Else
            Delete_CATEGORIES(dgv_CATEGORIES)
        End If
        ClearControls()
        CAT_ID.Text = Max_CATEGORIES() + 1
        CAT_Name.Focus()
        SelectAll_CATEGORIES(dgv_CATEGORIES)

    End Sub
    Private Sub dgv_CATEGORIES_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_CATEGORIES.CellContentClick
        Try
            With dgv_CATEGORIES
                Me.CAT_ID.Text = .CurrentRow.Cells("CAT_ID").Value.ToString()
                Me.CAT_Name.Text = .CurrentRow.Cells("CAT_Name").Value.ToString()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Me.BtnSave.Enabled = False
        Me.BtnEdit.Enabled = True
        BtnDelete.Enabled = True
    End Sub
    Private Sub BtnNewAdd_Click(sender As Object, e As EventArgs) Handles BtnNewAdd.Click
        ClearControls()
        CAT_ID.Text = Max_CATEGORIES() + 1
        CAT_Name.Focus()
        SelectAll_CATEGORIES(dgv_CATEGORIES)
        Me.BtnSave.Enabled = True
        Me.BtnEdit.Enabled = False
        BtnDelete.Enabled = False
    End Sub
End Class