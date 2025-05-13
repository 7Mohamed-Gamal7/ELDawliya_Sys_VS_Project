Imports System.Data.SqlClient

Public Class Frm_Add_Suppliers
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Public dt_Suppliers As New DataTable
    Public Sub ClearControls()
        Me.Supplier_ID.Text = vbNullString
        Me.Supplier_Name.Text = vbNullString
    End Sub

    Public Function Max_CUSTOMER()
        Dim Number As Integer
        Try
            Dim cmd As New SqlCommand("Select Max(Supplier_ID) From Tbl_Suppliers ", Con)
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

    Public Sub Insert_CUSTOMER(ByVal Supplier_ID As Int32, ByVal Supplier_Name As String)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Tbl_Suppliers (Supplier_ID,Supplier_Name)values(@Supplier_ID,@Supplier_Name)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Supplier_ID", SqlDbType.Int).Value = Supplier_ID
            .Parameters.AddWithValue("@Supplier_Name", SqlDbType.VarChar).Value = Supplier_Name
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub

    Public Sub Update_CUSTOMER(ByVal Supplier_Name As String, ByVal Supplier_IDW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_Suppliers Set Supplier_Name = @Supplier_Name Where Supplier_ID = @Supplier_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Supplier_Name", SqlDbType.VarChar).Value = Supplier_Name
            .Parameters.AddWithValue("@Supplier_ID", SqlDbType.Int).Value = Supplier_IDW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Public Sub Delete_CUSTOMER(ByVal dgv_Suppliers As DataGridView)
        Dim Position As Integer = dgv_Suppliers.CurrentRow.Index
        Dim ID_Position As Integer = dgv_Suppliers.Rows(Position).Cells("Supplier_ID").Value
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Delete  From Tbl_Suppliers Where Supplier_ID = @Supplier_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Supplier_ID", SqlDbType.Int).Value = ID_Position
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
        da = New SqlDataAdapter("select * from Tbl_Suppliers", Con)
        da.Fill(dt_Suppliers)
        dgv.DataSource = dt_Suppliers
        With dgv
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            .Columns("Supplier_ID").HeaderText = "كود المورد"
            .Columns("Supplier_ID").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns("Supplier_Name").HeaderText = "اسم المورد"
            .Columns("Supplier_Name").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End With
    End Sub

    Private Sub Frm_CUSTOMER_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearControls()
        Supplier_ID.Text = Max_CUSTOMER() + 1
        Supplier_Name.Focus()
        SelectAll_CUSTOMER(dgv_Suppliers)
        BtnEdit.Enabled = False
        BtnDelete.Enabled = False
        GotFoucs_LostFocus_For_Control_On_Panal(Panel2)
    End Sub

    Private Sub BtnNewAdd_Click(sender As Object, e As EventArgs) Handles BtnNewAdd.Click
        ClearControls()
        Supplier_ID.Text = Max_CUSTOMER() + 1
        Supplier_Name.Focus()
        SelectAll_CUSTOMER(dgv_Suppliers)
        Me.BtnSave.Enabled = True
        Me.BtnEdit.Enabled = False
        BtnDelete.Enabled = False
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If Supplier_Name.Text = vbNullString Then
            MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Exit Sub
        End If
        Insert_CUSTOMER(Supplier_ID.Text, Supplier_Name.Text)
        ClearControls()
        Supplier_ID.Text = Max_CUSTOMER() + 1
        Supplier_Name.Focus()
        SelectAll_CUSTOMER(dgv_Suppliers)

    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If Supplier_Name.Text = vbNullString Then
            MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Exit Sub
        End If
        Update_CUSTOMER(Supplier_Name.Text, Supplier_ID.Text)
        Supplier_ID.Text = Max_CUSTOMER() + 1
        Supplier_Name.Focus()
        SelectAll_CUSTOMER(dgv_Suppliers)

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
            Exit Sub
        Else
            Delete_CUSTOMER(dgv_Suppliers)
        End If
        ClearControls()
        Supplier_ID.Text = Max_CUSTOMER() + 1
        Supplier_Name.Focus()
        SelectAll_CUSTOMER(dgv_Suppliers)

    End Sub

    Private Sub dgv_Suppliers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Suppliers.CellContentClick
        Try
            With dgv_Suppliers
                Me.Supplier_ID.Text = .CurrentRow.Cells("Supplier_ID").Value.ToString()
                Me.Supplier_Name.Text = .CurrentRow.Cells("Supplier_Name").Value.ToString()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Me.BtnSave.Enabled = False
        Me.BtnEdit.Enabled = True
        BtnDelete.Enabled = True
    End Sub

    Private Sub Txt_Search_TextChanged(sender As Object, e As EventArgs) Handles Txt_Search.TextChanged
        Try
            Dim dv As DataView = dt_Suppliers.DefaultView
            dv.RowFilter = " Supplier_Name LIKE '%" & Txt_Search.Text & "%' "
        Catch ex As Exception
        End Try
        ' ضعه في حدث تكست بوكس تشانج (TextChanged)

    End Sub


End Class