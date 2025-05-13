Imports System.Data.SqlClient

Public Class Frm_Accidents
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Public dt_Accidents As New DataTable

    Public Sub fillcmb_Tbl_Employee(ByVal cmb As ComboBox)
        Dim DT As New DataTable
        Dim DA As New SqlDataAdapter
        DT.Clear()
        DA = New SqlDataAdapter("SELECT * FROM Tbl_Employee where Working_Condition = 'سارى'", Con)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            cmb.DataSource = DT
            cmb.DisplayMember = "Emp_Full_Name"
            cmb.ValueMember = "Emp_ID"
        Else
            cmb.DataSource = Nothing
        End If
    End Sub

    Public Sub ClearControls()
        Me.AccidentID.Text = vbNullString
        Me.AccidentDate.Value = Today
        Me.Emp_ID.Text = vbNullString
        Me.AccidentLocation.Text = vbNullString
        Me.AccidentDescription.Text = vbNullString
        Me.CorrectiveActions.Text = vbNullString
        SelectAll_Accidents(dgv_Accidents)
        BtnDelete.Enabled = False
        BtnEdit.Enabled = False
        BtnSave.Enabled = True

    End Sub

    Public Sub SelectAll_Accidents(dgv As DataGridView)
        Try
            Dim da As New SqlDataAdapter
            dt_Accidents.Clear()
            da = New SqlDataAdapter("SELECT dbo.Accidents.*, dbo.Tbl_Employee.Emp_Full_Name
                   FROM     dbo.Accidents INNER JOIN
                  dbo.Tbl_Employee ON dbo.Accidents.Emp_ID = dbo.Tbl_Employee.Emp_ID", Con)
            da.Fill(dt_Accidents)
            dgv.DataSource = dt_Accidents
            With dgv
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                .Columns("AccidentID").HeaderText = "AccidentID"
                .Columns("AccidentID").Visible = False
                .Columns("AccidentDate").HeaderText = "تاريخ الحادث"
                '.Columns("AccidentDate").Width = 100
                .Columns("Emp_ID").HeaderText = "كود الموظف"
                .Columns("Emp_ID").Visible = False
                .Columns("AccidentLocation").HeaderText = "مكان الحادث"
                '.Columns("AccidentLocation").Width = 200
                .Columns("AccidentDescription").HeaderText = "وصف الحادث"
                '.Columns("AccidentDescription").Width = 250
                .Columns("CorrectiveActions").HeaderText = "الاجراءات الصحية"
                '.Columns("CorrectiveActions").Width = 200
                .Columns("Emp_Full_Name").HeaderText = "اسم الموظف"
                '.Columns("Emp_Full_Name").Width = 200
                .Columns("CreatedAt").HeaderText = "CreatedAt"
                .Columns("CreatedAt").Visible = False
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub Insert_Accidents(ByVal AccidentDate As Date, ByVal Emp_ID As Int32, ByVal AccidentLocation As String, ByVal AccidentDescription As String, ByVal CorrectiveActions As String)
        Try
            Dim Cmd As New SqlCommand
            With Cmd
                .Connection = Con
                .CommandType = CommandType.Text
                .CommandText = "Insert Into Accidents ( AccidentDate,Emp_ID,AccidentLocation,AccidentDescription,CorrectiveActions)values(@AccidentDate,@Emp_ID,@AccidentLocation,@AccidentDescription,@CorrectiveActions)"
                .Parameters.Clear()
                .Parameters.AddWithValue("@AccidentDate", SqlDbType.Date).Value = AccidentDate
                .Parameters.AddWithValue("@Emp_ID", SqlDbType.Int).Value = Emp_ID
                .Parameters.AddWithValue("@AccidentLocation", SqlDbType.VarChar).Value = AccidentLocation
                .Parameters.AddWithValue("@AccidentDescription", SqlDbType.VarChar).Value = AccidentDescription
                .Parameters.AddWithValue("@CorrectiveActions", SqlDbType.VarChar).Value = CorrectiveActions
            End With
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Cmd.ExecuteNonQuery()
            Con.Close()
            MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
            Cmd = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Sub Delete_Accidents(ByVal dgv_Accidents As DataGridView)
        Try
            Dim Position As Integer = dgv_Accidents.CurrentRow.Index
            Dim ID_Position As Integer = dgv_Accidents.Rows(Position).Cells("AccidentID").Value
            Dim Cmd As New SqlCommand
            With Cmd
                .Connection = Con
                .CommandType = CommandType.Text
                .CommandText = "Delete  From Accidents Where AccidentID = @AccidentID"
                .Parameters.Clear()
                .Parameters.AddWithValue("@AccidentID", SqlDbType.Int).Value = ID_Position
            End With
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Cmd.ExecuteNonQuery()
            Con.Close()
            MsgBox("تم حذف السجل.", MsgBoxStyle.Information, "حذف")
            Cmd = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Public Sub Update_Accidents(ByVal AccidentDate As Date, ByVal Emp_ID As Int32, ByVal AccidentLocation As String, ByVal AccidentDescription As String, ByVal CorrectiveActions As String, ByVal AccidentIDW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Accidents Set AccidentDate = @AccidentDate,Emp_ID = @Emp_ID,AccidentLocation = @AccidentLocation,AccidentDescription = @AccidentDescription,CorrectiveActions = @CorrectiveActions Where AccidentID = @AccidentID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@AccidentDate", SqlDbType.Date).Value = AccidentDate
            .Parameters.AddWithValue("@Emp_ID", SqlDbType.Int).Value = Emp_ID
            .Parameters.AddWithValue("@AccidentLocation", SqlDbType.VarChar).Value = AccidentLocation
            .Parameters.AddWithValue("@AccidentDescription", SqlDbType.VarChar).Value = AccidentDescription
            .Parameters.AddWithValue("@CorrectiveActions", SqlDbType.VarChar).Value = CorrectiveActions
            .Parameters.AddWithValue("@AccidentID", SqlDbType.Int).Value = AccidentIDW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub


    Private Sub dgv_Accidents_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Accidents.CellContentClick
        Try
            With dgv_Accidents
                Me.AccidentID.Text = .CurrentRow.Cells("AccidentID").Value.ToString()
                Me.AccidentDate.Value = .CurrentRow.Cells("AccidentDate").Value.ToString()
                Me.Emp_ID.SelectedValue = .CurrentRow.Cells("Emp_ID").Value.ToString()
                Me.AccidentLocation.Text = .CurrentRow.Cells("AccidentLocation").Value.ToString()
                Me.AccidentDescription.Text = .CurrentRow.Cells("AccidentDescription").Value.ToString()
                Me.CorrectiveActions.Text = .CurrentRow.Cells("CorrectiveActions").Value.ToString()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        BtnDelete.Enabled = True
        BtnEdit.Enabled = True
        BtnSave.Enabled = False
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If Not CanAdd Then
            MessageBox.Show("ليس لديك صلاحية الإضافة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Insert_Accidents(AccidentDate.Value, Int(Emp_ID.SelectedValue), AccidentLocation.Text, AccidentDescription.Text, CorrectiveActions.Text)
        ClearControls()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click

        If Not CanEdit Then
            MessageBox.Show("ليس لديك صلاحية التعديل.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Update_Accidents(AccidentDate.Value, Int(Emp_ID.SelectedValue), AccidentLocation.Text, AccidentDescription.Text, CorrectiveActions.Text, Int(AccidentID.Text))
        ClearControls()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If Not CanDelete Then
            MessageBox.Show("ليس لديك صلاحية الحذف.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
            Exit Sub
        Else
            Delete_Accidents(dgv_Accidents)
        End If
        ClearControls()
    End Sub

    Private Sub BtnNewAdd_Click(sender As Object, e As EventArgs) Handles BtnNewAdd.Click
        ClearControls()
    End Sub

    Private Sub Frm_Accidents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ApplyPermissions(Me.Name)
            CustomizeForm(Me)
            ClearControls()
            fillcmb_Tbl_Employee(Emp_ID)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btn_Print_Click(sender As Object, e As EventArgs) Handles btn_Print.Click
        If Not CanPrint Then
            MessageBox.Show("ليس لديك صلاحية الطباعة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

    End Sub
End Class