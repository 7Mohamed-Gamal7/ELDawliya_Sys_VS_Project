Imports System.Data.SqlClient

Public Class Frm_Units_SpareParts
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Public dt_Suppliers As New DataTable
    Public Sub ClearControls()
        Me.Unit_ID.Text = vbNullString
        Me.Unit_Name.Text = vbNullString
    End Sub
    Public Function Max_CUSTOMER()
        Dim Number As Integer
        Try
            Dim cmd As New SqlCommand("Select Max(Unit_ID) From Tbl_Units_SpareParts ", Con)
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
    Public Sub Insert_CUSTOMER(ByVal Unit_ID As Int32, ByVal Unit_Name As String)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Tbl_Units_SpareParts (Unit_ID,Unit_Name)values(@Unit_ID,@Unit_Name)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Unit_ID", SqlDbType.Int).Value = Unit_ID
            .Parameters.AddWithValue("@Unit_Name", SqlDbType.VarChar).Value = Unit_Name
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub
    Public Sub Update_CUSTOMER(ByVal Unit_Name As String, ByVal Unit_IDW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_Units_SpareParts Set Unit_Name = @Unit_Name Where Unit_ID = @Unit_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Unit_Name", SqlDbType.VarChar).Value = Unit_Name
            .Parameters.AddWithValue("@Unit_ID", SqlDbType.Int).Value = Unit_IDW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub
    Public Sub Delete_CUSTOMER(ByVal Dgv_Units_SpareParts As DataGridView)
        Dim Position As Integer = Dgv_Units_SpareParts.CurrentRow.Index
        Dim ID_Position As Integer = Dgv_Units_SpareParts.Rows(Position).Cells("Unit_ID").Value
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Delete  From Tbl_Units_SpareParts Where Unit_ID = @Unit_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Unit_ID", SqlDbType.Int).Value = ID_Position
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم حذف السجل.", MsgBoxStyle.Information, "حذف")
        Cmd = Nothing
    End Sub
    Public Sub SelectAll_CUSTOMER(dgv As DataGridView)
        Dim da As New SqlDataAdapter
        dt_Suppliers.Clear()
        da = New SqlDataAdapter("select * from Tbl_Units_SpareParts", Con)
        da.Fill(dt_Suppliers)
        dgv.DataSource = dt_Suppliers
        With dgv
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            .Columns("Unit_ID").HeaderText = "كود الوحدة"
            .Columns("Unit_ID").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns("Unit_Name").HeaderText = "اسم الوحدة"
            .Columns("Unit_Name").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End With
    End Sub
    Private Sub Frm_CUSTOMER_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearControls()
        Unit_ID.Text = Max_CUSTOMER() + 1
        Unit_Name.Focus()
        SelectAll_CUSTOMER(dgv_Units_SpareParts)
        BtnEdit.Enabled = False
        BtnDelete.Enabled = False
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If Unit_Name.Text = vbNullString Then
            MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Exit Sub
        End If
        Insert_CUSTOMER(Unit_ID.Text, Unit_Name.Text)
        ClearControls()
        Unit_ID.Text = Max_CUSTOMER() + 1
        Unit_Name.Focus()
        SelectAll_CUSTOMER(dgv_Units_SpareParts)

    End Sub
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If Unit_Name.Text = vbNullString Then
            MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Exit Sub
        End If
        Update_CUSTOMER(Unit_Name.Text, Unit_ID.Text)
        Unit_ID.Text = Max_CUSTOMER() + 1
        Unit_Name.Focus()
        SelectAll_CUSTOMER(dgv_Units_SpareParts)

    End Sub
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
            Exit Sub
        Else
            Delete_CUSTOMER(dgv_Units_SpareParts)
        End If
        ClearControls()
        Unit_ID.Text = Max_CUSTOMER() + 1
        Unit_Name.Focus()
        SelectAll_CUSTOMER(dgv_Units_SpareParts)

    End Sub
    Private Sub Dgv_Units_SpareParts_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Units_SpareParts.CellContentClick
        Try
            With dgv_Units_SpareParts
                Me.Unit_ID.Text = .CurrentRow.Cells("Unit_ID").Value.ToString()
                Me.Unit_Name.Text = .CurrentRow.Cells("Unit_Name").Value.ToString()
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
        Unit_ID.Text = Max_CUSTOMER() + 1
        Unit_Name.Focus()
        SelectAll_CUSTOMER(dgv_Units_SpareParts)
        Me.BtnSave.Enabled = True
        Me.BtnEdit.Enabled = False
        BtnDelete.Enabled = False
    End Sub

    Private Sub Txt_Search_TextChanged(sender As Object, e As EventArgs) Handles Txt_Search.TextChanged
        Try
            Dim dv As DataView = dt_Suppliers.DefaultView
            dv.RowFilter = " Unit_Name LIKE '%" & Txt_Search.Text & "%' "
        Catch ex As Exception
        End Try
        ' ضعه في حدث تكست بوكس تشانج (TextChanged)

    End Sub
End Class