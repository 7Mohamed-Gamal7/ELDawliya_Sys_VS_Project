Imports System.Data.SqlClient
Public Class Frm_Add_Department
    Inherits BaseForm

    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Public Sub ClearControls()
        Me.Dept_Code.Text = vbNullString
        Me.Dept_Name.Text = vbNullString
    End Sub
    Public Sub Load_Tbl_Department()
        Try
            dgv_Tbl_Department.Rows.Clear()
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Dim cmd As New SqlCommand(" Select * from Tbl_Department", Con)
            Dim adp As New SqlDataAdapter(cmd)
            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader
            While dr.Read
                dgv_Tbl_Department.Rows.Add(dr("Dept_Code").ToString, dr("Dept_Name").ToString)
            End While
            dr.Close()
            Con.Close()
        Catch ex As Exception
            Con.Close()
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Public Sub Insert_Tbl_Department(ByVal Dept_Code As Int32, ByVal Dept_Name As String)
        Try
            Dim Cmd As New SqlCommand
            With Cmd
                .Connection = Con
                .CommandType = CommandType.Text
                .CommandText = "Insert Into Tbl_Department ( Dept_Code,Dept_Name)values(@Dept_Code,@Dept_Name)"
                .Parameters.Clear()
                .Parameters.AddWithValue("@Dept_Code", SqlDbType.Int).Value = Dept_Code
                .Parameters.AddWithValue("@Dept_Name", SqlDbType.VarChar).Value = Dept_Name
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
    Public Sub Update_Tbl_Department(ByVal Dept_Name As String, ByVal Dept_CodeW As Int32)
        Try
            Dim Cmd As New SqlCommand
            With Cmd
                .Connection = Con
                .CommandType = CommandType.Text
                .CommandText = "Update Tbl_Department Set Dept_Name = @Dept_Name Where Dept_Code = @Dept_Code"
                .Parameters.Clear()
                .Parameters.AddWithValue("@Dept_Name", SqlDbType.VarChar).Value = Dept_Name
                .Parameters.AddWithValue("@Dept_Code", SqlDbType.Int).Value = Dept_CodeW
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
    Public Sub Delete_Tbl_Department(ByVal dgv_Tbl_Department As DataGridView)
        Try
            Dim Position As Integer = dgv_Tbl_Department.CurrentRow.Index
            Dim ID_Position As Integer = dgv_Tbl_Department.Rows(Position).Cells("Dept_Code").Value
            Dim Cmd As New SqlCommand
            With Cmd
                .Connection = Con
                .CommandType = CommandType.Text
                .CommandText = "Delete  From Tbl_Department Where Dept_Code = @Dept_Code"
                .Parameters.Clear()
                .Parameters.AddWithValue("@Dept_Code", SqlDbType.Int).Value = ID_Position
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
    Public Function Max_Tbl_Department()
        Dim Number As Integer
        Try
            Dim cmd As New SqlCommand("Select Max(Dept_Code) From Tbl_Department ", Con)
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
    Private Sub dgv_Tbl_Department_Click(sender As Object, e As EventArgs) Handles dgv_Tbl_Department.Click
        Try
            With dgv_Tbl_Department
                Me.Dept_Code.Text = .CurrentRow.Cells("Column1").Value.ToString()
                Me.Dept_Name.Text = .CurrentRow.Cells("Column2").Value.ToString()
            End With
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
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

        Try
            Insert_Tbl_Department(Dept_Code.Text, Dept_Name.Text)
            ClearControls()
            Dept_Code.Text = Max_Tbl_Department() + 1
            Load_Tbl_Department()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        '------------------------------------------------------------------------------------------------------
        'خاص بالصلاحيات للفورم
        If Not CanEdit Then
            MessageBox.Show("ليس لديك صلاحية التعديل.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        '------------------------------------------------------------------------------------------------------

        Try
            Update_Tbl_Department(Dept_Name.Text, Dept_Code.Text)
            ClearControls()
            Dept_Code.Text = Max_Tbl_Department() + 1
            Load_Tbl_Department()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        '------------------------------------------------------------------------------------------------------
        'خاص بالصلاحيات للفورم
        If Not CanDelete Then
            MessageBox.Show("ليس لديك صلاحية الحذف.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        '------------------------------------------------------------------------------------------------------

        Try
            If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                Exit Sub
            Else
                Delete_Tbl_Department(dgv_Tbl_Department)
            End If
            ClearControls()
            Dept_Code.Text = Max_Tbl_Department() + 1
            Load_Tbl_Department()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub Frm_Add_Department_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyPermissions(Me.Name)
        ClearControls()
        Dept_Code.Text = Max_Tbl_Department() + 1
        Load_Tbl_Department()

    End Sub
    Private Sub BtnNewAdd_Click(sender As Object, e As EventArgs) Handles BtnNewAdd.Click
        '------------------------------------------------------------------------------------------------------
        'خاص بالصلاحيات للفورم
        If Not CanAdd Then
            MessageBox.Show("ليس لديك صلاحية الإضافة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        '------------------------------------------------------------------------------------------------------
        ClearControls()
        Dept_Code.Text = Max_Tbl_Department() + 1
        Load_Tbl_Department()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub
End Class