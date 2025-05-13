Imports System.Data.SqlClient
Public Class Frm_Add_Jop
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Public dt_Tbl_Jop As New DataTable
    Public Sub fillcmb_Tbl_Department(ByVal cmb As ComboBox)
        Dim DT As New DataTable
        Dim DA As New SqlDataAdapter
        DT.Clear()
        DA = New SqlDataAdapter("Select * FROM Tbl_Department ", Con)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            cmb.DataSource = DT
            cmb.ValueMember = "Dept_Code"
            cmb.DisplayMember = "Dept_Name"
        Else
            cmb.DataSource = Nothing
        End If
    End Sub
    Public Sub ClearControls()
        Me.Jop_Code.Text = vbNullString
        Me.Jop_Name.Text = vbNullString
        Me.Dept_Code.Text = vbNullString
    End Sub
    Public Sub SelectAll_Tbl_Jop(dgv As DataGridView)
        dt_Tbl_Jop.Clear()
        'Dim query As String = "SELECT Tbl_Jop.Jop_Code, Tbl_Jop.Jop_Name, Tbl_Department.Dept_Name " &
        '              "FROM Tbl_Jop " &
        '              "JOIN Tbl_Department ON Tbl_Jop.Dept_Code = Tbl_Department.Dept_Code ORDER BY Tbl_Jop.Dept_Code ASC"

        Dim query As String = "SELECT Tbl_Jop.Jop_Code, MIN(Tbl_Jop.Jop_Name) AS Jop_Name, MIN(Tbl_Department.Dept_Name) AS Dept_Name " &
                      "FROM Tbl_Jop " &
                      "JOIN Tbl_Department ON Tbl_Jop.Dept_Code = Tbl_Department.Dept_Code " &
                      "GROUP BY Tbl_Jop.Jop_Code, Tbl_Jop.Dept_Code " &
                      "ORDER BY Tbl_Jop.Dept_Code ASC"
        Dim da As New SqlDataAdapter(query, Con)
        da.Fill(dt_Tbl_Jop)
        dgv.DataSource = dt_Tbl_Jop
        With dgv
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .Columns("Jop_Code").HeaderText = "كود الوظيفة"
            .Columns("Jop_Code").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns("Jop_Name").HeaderText = "اسم الـــوظــيــفــة"
            .Columns("Jop_Name").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns("Dept_Name").HeaderText = "قسم الوظيفة"
            .Columns("Dept_Name").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        End With
    End Sub
    Public Sub Insert_Tbl_Jop(ByVal Jop_Code As Int32, ByVal Jop_Name As String, ByVal Dept_Code As Int32)
        Dim Cmd As New SqlCommand
        Try
            With Cmd
                .Connection = Con
                .CommandType = CommandType.Text
                .CommandText = "Insert Into Tbl_Jop ( Jop_Code,Jop_Name,Dept_Code)values(@Jop_Code,@Jop_Name,@Dept_Code)"
                .Parameters.Clear()
                .Parameters.AddWithValue("@Jop_Code", SqlDbType.Int).Value = Jop_Code
                .Parameters.AddWithValue("@Jop_Name", SqlDbType.VarChar).Value = Jop_Name
                .Parameters.AddWithValue("@Dept_Code", SqlDbType.Int).Value = Dept_Code
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
    Public Sub Update_Tbl_Jop(ByVal Jop_Name As String, ByVal Dept_Code As Int32, ByVal Jop_CodeW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_Jop Set Jop_Name = @Jop_Name,Dept_Code = @Dept_Code Where Jop_Code = @Jop_Code"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Jop_Name", SqlDbType.VarChar).Value = Jop_Name
            .Parameters.AddWithValue("@Dept_Code", SqlDbType.Int).Value = Dept_Code
            .Parameters.AddWithValue("@Jop_Code", SqlDbType.Int).Value = Jop_CodeW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub
    Public Sub Delete_Tbl_Jop(ByVal dgv_Tbl_Jop As DataGridView)
        Dim Position As Integer = dgv_Tbl_Jop.CurrentRow.Index
        Dim ID_Position As Integer = dgv_Tbl_Jop.Rows(Position).Cells("Jop_Code").Value
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Delete  From Tbl_Jop Where Jop_Code = @Jop_Code"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Jop_Code", SqlDbType.Int).Value = ID_Position
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم حذف السجل.", MsgBoxStyle.Information, "حذف")
        Cmd = Nothing
    End Sub
    Public Function Max_Tbl_Jop()
        Dim Number As Integer
        Try
            Dim cmd As New SqlCommand("Select Max(Jop_Code) From Tbl_Jop ", Con)
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
    Private Sub Frm_Add_Jop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyPermissions(Me.Name)

        'ChangeScreenResolution(Me)
        ClearControls()
        fillcmb_Tbl_Department(Dept_Code)
        SelectAll_Tbl_Jop(dgv_Tbl_Jop)
        Jop_Code.Text = Max_Tbl_Jop() + 1
    End Sub
    Private Sub dgv_Tbl_Jop_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Tbl_Jop.CellContentClick
        Try
            Me.BtnSave.Enabled = False
            With dgv_Tbl_Jop
                Me.Jop_Code.Text = .CurrentRow.Cells("Jop_Code").Value.ToString()
                Me.Jop_Name.Text = .CurrentRow.Cells("Jop_Name").Value.ToString()
                Me.Dept_Code.Text = .CurrentRow.Cells("Dept_Name").Value.ToString()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        '------------------------------------------------------------------------------------------------------
        'خاص بالصلاحيات للفورم
        If Not CanAdd Then
            MessageBox.Show("ليس لديك صلاحية الإضافة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        '------------------------------------------------------------------------------------------------------
        If Jop_Name.Text = vbNullString Or Dept_Code.Text = vbNullString Then
            MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Exit Sub
        End If
        Insert_Tbl_Jop(Jop_Code.Text, Jop_Name.Text, Int(Dept_Code.SelectedValue))
        ClearControls()
        SelectAll_Tbl_Jop(dgv_Tbl_Jop)
        Jop_Code.Text = Max_Tbl_Jop() + 1
        Jop_Name.Focus()
    End Sub
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        '------------------------------------------------------------------------------------------------------
        'خاص بالصلاحيات للفورم
        If Not CanEdit Then
            MessageBox.Show("ليس لديك صلاحية التعديل.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        '------------------------------------------------------------------------------------------------------
        If Jop_Name.Text = vbNullString Or Dept_Code.Text = vbNullString Then
            MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Exit Sub
        End If
        Update_Tbl_Jop(Jop_Name.Text, Int(Dept_Code.SelectedValue), Jop_Code.Text)
        ClearControls()
        SelectAll_Tbl_Jop(dgv_Tbl_Jop)
        Jop_Code.Text = Max_Tbl_Jop() + 1
        Jop_Name.Focus()
        Me.BtnSave.Enabled = True
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
            Delete_Tbl_Jop(dgv_Tbl_Jop)
        End If
        ClearControls()
        SelectAll_Tbl_Jop(dgv_Tbl_Jop)
        Jop_Code.Text = Max_Tbl_Jop() + 1
        Jop_Name.Focus()
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ExportToWord(dgv_Tbl_Jop, "عنوان القائمة")
    End Sub


End Class


