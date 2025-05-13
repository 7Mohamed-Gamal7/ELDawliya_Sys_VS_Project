Imports System.Data.SqlClient

Public Class Frm_Customer
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Public dt_CUSTOMER As New DataTable
    Public Sub ClearControls()
        Me.Customer_ID.Text = vbNullString
        Me.CUSTOMER_NAME.Text = vbNullString
    End Sub
    Public Function Max_CUSTOMER()
        Dim Number As Integer
        Try
            Dim cmd As New SqlCommand("Select Max(Customer_ID) From Tbl_Customers ", Con)
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
    Public Sub Insert_CUSTOMER(ByVal Customer_ID As Int32, ByVal Customer_Name As String)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Tbl_Customers (Customer_ID,Customer_Name)values(@Customer_ID,@Customer_Name)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Customer_ID", SqlDbType.Int).Value = Customer_ID
            .Parameters.AddWithValue("@Customer_Name", SqlDbType.VarChar).Value = Customer_Name
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub
    Public Sub Update_CUSTOMER(ByVal Customer_Name As String, ByVal Customer_IDW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_Customers Set Customer_Name = @Customer_Name Where Customer_ID = @Customer_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Customer_Name", SqlDbType.VarChar).Value = Customer_Name
            .Parameters.AddWithValue("@Customer_ID", SqlDbType.Int).Value = Customer_IDW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub
    Public Sub Delete_CUSTOMER(ByVal dgv_CUSTOMERS As DataGridView)
        Dim Position As Integer = dgv_CUSTOMERS.CurrentRow.Index
        Dim ID_Position As Integer = dgv_CUSTOMERS.Rows(Position).Cells("Customer_ID").Value
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Delete  From Tbl_Customers Where Customer_ID = @Customer_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Customer_ID", SqlDbType.Int).Value = ID_Position
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
        dt_CUSTOMER.Clear()
        da = New SqlDataAdapter("select * from Tbl_Customers", Con)
        da.Fill(dt_CUSTOMER)
        dgv.DataSource = dt_CUSTOMER
        With dgv
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            .Columns("Customer_ID").HeaderText = "كود العميل"
            .Columns("Customer_ID").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns("Customer_Name").HeaderText = "اسم العميل"
            .Columns("Customer_Name").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End With
    End Sub
    Private Sub Frm_CUSTOMER_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearControls()
        Customer_ID.Text = Max_CUSTOMER() + 1
        CUSTOMER_NAME.Focus()
        SelectAll_CUSTOMER(dgv_CUSTOMERS)
        BtnEdit.Enabled = False
        BtnDelete.Enabled = False
        GotFoucs_LostFocus_For_Control_On_Panal(MetroPanel2)
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If CUSTOMER_NAME.Text = vbNullString Then
            MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Exit Sub
        End If
        Insert_CUSTOMER(Customer_ID.Text, CUSTOMER_NAME.Text)
        ClearControls()
        Customer_ID.Text = Max_CUSTOMER() + 1
        CUSTOMER_NAME.Focus()
        SelectAll_CUSTOMER(dgv_CUSTOMERS)

    End Sub
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If CUSTOMER_NAME.Text = vbNullString Then
            MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Exit Sub
        End If
        Update_CUSTOMER(CUSTOMER_NAME.Text, Customer_ID.Text)
        Customer_ID.Text = Max_CUSTOMER() + 1
        CUSTOMER_NAME.Focus()
        SelectAll_CUSTOMER(dgv_CUSTOMERS)

    End Sub
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
            Exit Sub
        Else
            Delete_CUSTOMER(dgv_CUSTOMERS)
        End If
        ClearControls()
        Customer_ID.Text = Max_CUSTOMER() + 1
        CUSTOMER_NAME.Focus()
        SelectAll_CUSTOMER(dgv_CUSTOMERS)

    End Sub
    Private Sub dgv_CUSTOMERS_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_CUSTOMERS.CellContentClick
        Try
            With dgv_CUSTOMERS
                Me.Customer_ID.Text = .CurrentRow.Cells("Customer_ID").Value.ToString()
                Me.CUSTOMER_NAME.Text = .CurrentRow.Cells("Customer_Name").Value.ToString()
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
        Customer_ID.Text = Max_CUSTOMER() + 1
        CUSTOMER_NAME.Focus()
        SelectAll_CUSTOMER(dgv_CUSTOMERS)
        Me.BtnSave.Enabled = True
        Me.BtnEdit.Enabled = False
        BtnDelete.Enabled = False
    End Sub

    Private Sub Txt_Search_TextChanged(sender As Object, e As EventArgs) Handles Txt_Search.TextChanged
        Try
            Dim dv As DataView = dt_CUSTOMER.DefaultView
            dv.RowFilter = " Customer_Name LIKE '%" & Txt_Search.Text & "%' "
        Catch ex As Exception
        End Try
        ' ضعه في حدث تكست بوكس تشانج (TextChanged)

    End Sub
End Class