Imports System.Data.SqlClient
Public Class Frm_Car
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Public dt_Tbl_Car As New DataTable
    Public Sub ClearControls()
        Me.Car_ID.Text = vbNullString
        Me.Car_Name.Text = vbNullString
        Me.Car_Type.Text = vbNullString
        Me.Car_Salary.Text = "0.00"
        Me.Car_Salary_Farda.Text = "0.00"
        Me.Supplier.Text = vbNullString
        Me.Contract_Type.Text = vbNullString
        Me.Car_Number.Text = vbNullString
        Me.Car_License_Expiration_Date.Value = Today
        Me.Driver_Name.Text = vbNullString
        Me.Driver_Phone.Text = vbNullString
        Me.Driver_License_Expiration_Date.Value = Today
        Me.Contract_Type_Farada.Text = vbNullString
        Me.Is_Active.Checked = False
    End Sub
    Public Sub Insert_Tbl_Car(ByVal Car_ID As Int32, ByVal Car_Name As String, ByVal Car_Type As String, ByVal Car_Salary As Double, ByVal Supplier As String, ByVal Contract_Type As String, ByVal Car_Number As String, ByVal Car_License_Expiration_Date As DateTime, ByVal Driver_Name As String, ByVal Driver_Phone As String, ByVal Driver_License_Expiration_Date As DateTime, ByVal Car_Salary_Farda As Double, ByVal Contract_Type_Farada As String, ByVal is_active As Boolean)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Tbl_Car ( Car_ID,Car_Name,Car_Type,Car_Salary,Supplier,Contract_Type,Car_Number,Car_License_Expiration_Date,Driver_Name,Driver_Phone,Driver_License_Expiration_Date,Car_Salary_Farda,Contract_Type_Farada,Is_Active)values(@Car_ID,@Car_Name,@Car_Type,@Car_Salary,@Supplier,@Contract_Type,@Car_Number,@Car_License_Expiration_Date,@Driver_Name,@Driver_Phone,@Driver_License_Expiration_Date,@Car_Salary_Farda,@Contract_Type_Farada, @Is_Active)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Car_ID", SqlDbType.Int).Value = Car_ID
            .Parameters.AddWithValue("@Car_Name", SqlDbType.VarChar).Value = Car_Name
            .Parameters.AddWithValue("@Car_Type", SqlDbType.VarChar).Value = Car_Type
            .Parameters.AddWithValue("@Car_Salary", SqlDbType.Decimal).Value = Car_Salary
            .Parameters.AddWithValue("@Supplier", SqlDbType.VarChar).Value = Supplier
            .Parameters.AddWithValue("@Contract_Type", SqlDbType.VarChar).Value = Contract_Type
            .Parameters.AddWithValue("@Car_Number", SqlDbType.VarChar).Value = Car_Number
            .Parameters.AddWithValue("@Car_License_Expiration_Date", SqlDbType.Date).Value = Car_License_Expiration_Date
            .Parameters.AddWithValue("@Driver_Name", SqlDbType.VarChar).Value = Driver_Name
            .Parameters.AddWithValue("@Driver_Phone", SqlDbType.VarChar).Value = Driver_Phone
            .Parameters.AddWithValue("@Driver_License_Expiration_Date", SqlDbType.Date).Value = Driver_License_Expiration_Date
            .Parameters.AddWithValue("@Car_Salary_Farda", SqlDbType.Decimal).Value = Car_Salary_Farda
            .Parameters.AddWithValue("@Contract_Type_Farada", SqlDbType.VarChar).Value = Contract_Type_Farada
            .Parameters.AddWithValue("@Is_Active", SqlDbType.Bit).Value = is_active
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub
    Public Sub Delete_Tbl_Car(ByVal dgv_Tbl_Car As DataGridView)
        Dim Position As Integer = dgv_Tbl_Car.CurrentRow.Index
        Dim ID_Position As Integer = dgv_Tbl_Car.Rows(Position).Cells("Car_ID").Value
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Delete  From Tbl_Car Where Car_ID = @Car_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Car_ID", SqlDbType.Int).Value = ID_Position
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم حذف السجل.", MsgBoxStyle.Information, "حذف")
        Cmd = Nothing
    End Sub
    Public Sub Update_Tbl_Car(ByVal Car_Name As String, ByVal Car_Type As String, ByVal Car_Salary As Double, ByVal Supplier As String, ByVal Contract_Type As String, ByVal Car_Number As String, ByVal Car_License_Expiration_Date As DateTime, ByVal Driver_Name As String, ByVal Driver_Phone As String, ByVal Driver_License_Expiration_Date As DateTime, ByVal Car_Salary_Farda As Double, ByVal Contract_Type_Farada As String, ByVal Is_Active As Boolean, ByVal Car_IDW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_Car Set Car_Name = @Car_Name,Car_Type = @Car_Type,Car_Salary = @Car_Salary,Supplier = @Supplier,Contract_Type = @Contract_Type,Car_Number = @Car_Number,Car_License_Expiration_Date = @Car_License_Expiration_Date,Driver_Name = @Driver_Name,Driver_Phone = @Driver_Phone,Driver_License_Expiration_Date = @Driver_License_Expiration_Date,Car_Salary_Farda = @Car_Salary_Farda,Contract_Type_Farada = @Contract_Type_Farada,Is_Active = @Is_Active Where Car_ID = @Car_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Car_Name", SqlDbType.VarChar).Value = Car_Name
            .Parameters.AddWithValue("@Car_Type", SqlDbType.VarChar).Value = Car_Type
            .Parameters.AddWithValue("@Car_Salary", SqlDbType.Decimal).Value = Car_Salary
            .Parameters.AddWithValue("@Supplier", SqlDbType.VarChar).Value = Supplier
            .Parameters.AddWithValue("@Contract_Type", SqlDbType.VarChar).Value = Contract_Type
            .Parameters.AddWithValue("@Car_Number", SqlDbType.VarChar).Value = Car_Number
            .Parameters.AddWithValue("@Car_License_Expiration_Date", SqlDbType.Date).Value = Car_License_Expiration_Date
            .Parameters.AddWithValue("@Driver_Name", SqlDbType.VarChar).Value = Driver_Name
            .Parameters.AddWithValue("@Driver_Phone", SqlDbType.VarChar).Value = Driver_Phone
            .Parameters.AddWithValue("@Driver_License_Expiration_Date", SqlDbType.Date).Value = Driver_License_Expiration_Date
            .Parameters.AddWithValue("@Car_Salary_Farda", SqlDbType.Decimal).Value = Car_Salary_Farda
            .Parameters.AddWithValue("@Contract_Type_Farada", SqlDbType.VarChar).Value = Contract_Type_Farada
            .Parameters.AddWithValue("@Is_Active", SqlDbType.Bit).Value = Is_Active
            .Parameters.AddWithValue("@Car_ID", SqlDbType.Int).Value = Car_IDW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub
    Public Function Max_Tbl_Car()
        Dim Number As Integer
        Try
            Dim cmd As New SqlCommand("Select Max(Car_ID) From Tbl_Car ", Con)
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
    Public Sub SelectAll_Tbl_Car(dgv As DataGridView)
        Dim da As New SqlDataAdapter
        dt_Tbl_Car.Clear()
        da = New SqlDataAdapter("select * from Tbl_Car", Con)
        da.Fill(dt_Tbl_Car)
        dgv.DataSource = dt_Tbl_Car
        'If dgv.RowCount > 0 Then
        With dgv
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            .Columns("Car_ID").HeaderText = "كود السيارة"
            .Columns("Car_ID").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns("Car_Name").HeaderText = "اسم السيارة"
            .Columns("Car_Name").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns("Car_Type").HeaderText = "نوع السيارة"
            '.Columns("Car_Type").Width = 100
            .Columns("Car_Salary").Visible = False
            .Columns("Car_Salary").HeaderText = "اجر السيارة"
            '.Columns("Car_Salary").Width = 100
            .Columns("Supplier").HeaderText = "المورد"
            '.Columns("Supplier").Width = 100
            .Columns("Contract_Type").HeaderText = "نوع الوردية"
            '.Columns("Contract_Type").Width = 100
            .Columns("Car_Number").HeaderText = "رقم السيارة"
            '.Columns("Car_Number").Width = 100
            .Columns("Car_License_Expiration_Date").Visible = False
            .Columns("Car_License_Expiration_Date").HeaderText = "تاريخ انتهاء رخصة السيارة"
            '.Columns("Car_License_Expiration_Date").Width = 100
            .Columns("Driver_Name").Visible = False
            .Columns("Driver_Name").HeaderText = "اسم السائق"
            '.Columns("Driver_Name").Width = 100
            .Columns("Driver_Phone").Visible = False
            .Columns("Driver_Phone").HeaderText = "رقم تليفون السائق"
            '.Columns("Driver_Phone").Width = 100
            .Columns("Driver_License_Expiration_Date").Visible = False
            .Columns("Driver_License_Expiration_Date").HeaderText = "تاريخ انتهاء رخصة السائق"
            '.Columns("Driver_License_Expiration_Date").Width = 100
            .Columns("Car_Salary_Farda").Visible = False
            .Columns("Car_Salary_Farda").HeaderText = "اجر السيارة فردي"
            '.Columns("Car_Salary_Farda").Width = 100
            .Columns("Contract_Type_Farada").Visible = False
            .Columns("Contract_Type_Farada").HeaderText = "نوع الوردية فردي"
            '.Columns("Contract_Type_Farada").Width = 100
            .Columns("Is_Active").Visible = False
            .Columns("Is_Active").HeaderText = "مفعل"
            '.Columns("Is_Active").Width = 100
            .Columns("Shift_Type").Visible = False
            .Columns("Car_ID").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Car_Name").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Car_Type").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Car_Salary").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Supplier").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Contract_Type").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Car_Number").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Car_License_Expiration_Date").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Driver_Name").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Driver_Phone").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Driver_License_Expiration_Date").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Car_Salary_Farda").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Contract_Type_Farada").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Is_Active").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("Car_ID").DefaultCellStyle.BackColor = Color.FromArgb(255, 192, 128)
            .Columns("Car_Name").DefaultCellStyle.BackColor = Color.FromArgb(255, 192, 128)
            .Columns("Car_Type").DefaultCellStyle.BackColor = Color.FromArgb(255, 192, 128)
            .Columns("Car_Salary").DefaultCellStyle.BackColor = Color.FromArgb(255, 192, 128)

            .Columns("Supplier").DefaultCellStyle.BackColor = Color.FromArgb(255, 192, 128)
            .Columns("Contract_Type").DefaultCellStyle.BackColor = Color.FromArgb(255, 192, 128)
            .Columns("Car_Number").DefaultCellStyle.BackColor = Color.FromArgb(255, 192, 128)
            .Columns("Car_License_Expiration_Date").DefaultCellStyle.BackColor = Color.FromArgb(255, 192, 128)
            .Columns("Driver_Name").DefaultCellStyle.BackColor = Color.FromArgb(255, 192, 128)
            .Columns("Driver_Phone").DefaultCellStyle.BackColor = Color.FromArgb(255, 192, 128)
            .Columns("Driver_License_Expiration_Date").DefaultCellStyle.BackColor = Color.FromArgb(255, 192, 128)
            .Columns("Car_Salary_Farda").DefaultCellStyle.BackColor = Color.FromArgb(255, 192, 128)
            .Columns("Contract_Type_Farada").DefaultCellStyle.BackColor = Color.FromArgb(255, 192, 128)
            .Columns("Is_Active").DefaultCellStyle.BackColor = Color.FromArgb(255, 192, 128)


        End With
        'End If
    End Sub
    Private Sub Frm_Car_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyPermissions(Me.Name)
        'ChangeScreenResolution(Me)
        ClearControls()
        'Car_ID.Text = Max_Tbl_Car() + 1
        SelectAll_Tbl_Car(dgv_Tbl_Car)
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        '------------------------------------------------------------------------------------------------------
        'خاص بالصلاحيات للفورم
        If Not CanAdd Then
            MessageBox.Show("ليس لديك صلاحية الاضافة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        '------------------------------------------------------------------------------------------------------
        Insert_Tbl_Car(Car_ID.Text, Car_Name.Text, Car_Type.Text, Car_Salary.Text, Supplier.Text, Contract_Type.Text, Car_Number.Text, Car_License_Expiration_Date.Value, Driver_Name.Text, Driver_Phone.Text, Driver_License_Expiration_Date.Value, Car_Salary_Farda.Text, Contract_Type_Farada.Text, Is_Active.Checked)
        ClearControls()
        'Car_ID.Text = Max_Tbl_Car() + 1
        SelectAll_Tbl_Car(dgv_Tbl_Car)
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        '------------------------------------------------------------------------------------------------------
        'خاص بالصلاحيات للفورم
        If Not CanDelete Then
            MessageBox.Show("ليس لديك صلاحية الحذف.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        '------------------------------------------------------------------------------------------------------
        If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
            Exit Sub
        Else
            Delete_Tbl_Car(dgv_Tbl_Car)
        End If
        ClearControls()
        'Car_ID.Text = Max_Tbl_Car() + 1
        SelectAll_Tbl_Car(dgv_Tbl_Car)
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        '------------------------------------------------------------------------------------------------------
        'خاص بالصلاحيات للفورم
        If Not CanEdit Then
            MessageBox.Show("ليس لديك صلاحية التعديل.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        '------------------------------------------------------------------------------------------------------
        Update_Tbl_Car(Car_Name.Text, Car_Type.Text, Car_Salary.Text, Supplier.Text, Contract_Type.Text, Car_Number.Text, Car_License_Expiration_Date.Value, Driver_Name.Text, Driver_Phone.Text, Driver_License_Expiration_Date.Value, Car_Salary_Farda.Text, Contract_Type_Farada.Text, Is_Active.Checked, Car_ID.Text)
        ClearControls()
        'Car_ID.Text = Max_Tbl_Car() + 1
        SelectAll_Tbl_Car(dgv_Tbl_Car)
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub
    Private Sub dgv_Tbl_Car_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Tbl_Car.CellContentClick
        Me.BtnSave.Enabled = False
        Try
            With dgv_Tbl_Car
                Me.Car_ID.Text = .CurrentRow.Cells("Car_ID").Value.ToString()
                Me.Car_Name.Text = .CurrentRow.Cells("Car_Name").Value.ToString()
                Me.Car_Type.Text = .CurrentRow.Cells("Car_Type").Value.ToString()
                Me.Car_Salary.Text = .CurrentRow.Cells("Car_Salary").Value.ToString()
                Me.Supplier.Text = .CurrentRow.Cells("Supplier").Value.ToString()
                Me.Contract_Type.Text = .CurrentRow.Cells("Contract_Type").Value.ToString()
                Me.Car_Number.Text = .CurrentRow.Cells("Car_Number").Value.ToString()
                Me.Driver_Name.Text = .CurrentRow.Cells("Driver_Name").Value.ToString()
                Me.Driver_Phone.Text = .CurrentRow.Cells("Driver_Phone").Value.ToString()
                Me.Car_License_Expiration_Date.Value = .CurrentRow.Cells("Car_License_Expiration_Date").Value.ToString()
                Me.Driver_License_Expiration_Date.Value = .CurrentRow.Cells("Driver_License_Expiration_Date").Value.ToString()
                Me.Car_Salary_Farda.Text = .CurrentRow.Cells("Car_Salary_Farda").Value.ToString()
                Me.Contract_Type_Farada.Text = .CurrentRow.Cells("Contract_Type_Farada").Value.ToString()
                Me.Is_Active.Checked = .CurrentRow.Cells("Is_Active").Value.ToString()
                'Me.Shift_Type.Text = .CurrentRow.Cells("Shift_Type").Value.ToString()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnNewAdd_Click(sender As Object, e As EventArgs) Handles BtnNewAdd.Click
        '------------------------------------------------------------------------------------------------------
        'خاص بالصلاحيات للفورم
        If Not CanAdd Then
            MessageBox.Show("ليس لديك صلاحية الاضافة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        '------------------------------------------------------------------------------------------------------
        Me.BtnSave.Enabled = True
        ClearControls()
        'Car_ID.Text = Max_Tbl_Car() + 1
        SelectAll_Tbl_Car(dgv_Tbl_Car)
    End Sub

    Private Sub Txt_Search_TextChanged(sender As Object, e As EventArgs) Handles Txt_Search.TextChanged
        Try
            Dim dv As DataView = dt_Tbl_Car.DefaultView
            Select Case True
                Case Me.RadioCar_ID.Checked
                    dv.RowFilter = "Convert(Car_ID, 'System.String') LIKE '%" & Txt_Search.Text & "%'"
                Case Me.Radio_Car_Name.Checked
                    dv.RowFilter = " Car_Name LIKE '%" & Txt_Search.Text & "%' "
                Case Me.RadioSupplier.Checked
                    dv.RowFilter = " Supplier LIKE '%" & Txt_Search.Text & "%' "
                Case Me.Radio_Car_Salary.Checked
                    dv.RowFilter = " Car_Salary LIKE '%" & Txt_Search.Text & "%' "
                Case Me.Radio_Contract_Type.Checked
                    dv.RowFilter = " Contract_Type LIKE '%" & Txt_Search.Text & "%' "
            End Select
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try

    End Sub

End Class