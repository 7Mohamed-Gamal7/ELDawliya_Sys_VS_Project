Imports System.Data.SqlClient

Public Class Frm_Add_Unit
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Public dt_Tbl_Unit As New DataTable
    '======================================================================================================================
    ''''''''''''''''''''''''''''''''''''''''''''''''متغيرات عامة'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '======================================================================================================================
    Public Sub ClearControls()
        Me.Txt_Unit_ID.Text = vbNullString
        Me.Txt_Unit_Name.Text = vbNullString
        Me.Txt_Unit_Machine.Text = vbNullString
    End Sub
    Public Function Max_Tbl_Unit()
        Dim Number As Integer
        Try
            Dim cmd As New SqlCommand("Select Max(Unit_ID) From Tbl_Unit ", Con)
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
    Public Sub SelectAll_Tbl_Unit(dgv As DataGridView)
        Dim da As New SqlDataAdapter
        dt_Tbl_Unit.Clear()
        da = New SqlDataAdapter("select * from Tbl_Unit", Con)
        da.Fill(dt_Tbl_Unit)
        dgv.DataSource = dt_Tbl_Unit
        With dgv
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .Columns("Unit_ID").HeaderText = "كود الوحدة"
            '.Columns("Unit_ID").Width = 150
            .Columns("Unit_Name").HeaderText = "اسم الوحدة"
            '.Columns("Unit_Name").Width = 200
            .Columns("Unit_Machine").HeaderText = "ماكينة الوحدة"
            '.Columns("Unit_Machine").Width = 150
        End With
    End Sub
    Public Sub Insert_Tbl_Unit(ByVal Unit_ID As Int32, ByVal Unit_Name As String, ByVal Unit_Machine As String)
        Try
            Dim Cmd As New SqlCommand
            With Cmd
                .Connection = Con
                .CommandType = CommandType.Text
                .CommandText = "Insert Into Tbl_Unit ( Unit_ID,Unit_Name,Unit_Machine)values(@Unit_ID,@Unit_Name,@Unit_Machine)"
                .Parameters.Clear()
                .Parameters.AddWithValue("@Unit_ID", SqlDbType.Int).Value = Unit_ID
                .Parameters.AddWithValue("@Unit_Name", SqlDbType.VarChar).Value = Unit_Name
                .Parameters.AddWithValue("@Unit_Machine", SqlDbType.VarChar).Value = Unit_Machine
            End With
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Cmd.ExecuteNonQuery()
            Con.Close()
            MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
            Cmd = Nothing
        Catch ex As Exception
            MessageBox.Show("حدث خطأ أثناء تنفيذ العملية. الخطأ الفعلي: " & ex.Message)
        End Try

    End Sub
    Public Sub Update_Tbl_Unit(ByVal Unit_Name As String, ByVal Unit_Machine As String, ByVal Unit_IDW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_Unit Set Unit_Name = @Unit_Name,Unit_Machine = @Unit_Machine Where Unit_ID = @Unit_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Unit_Name", SqlDbType.VarChar).Value = Unit_Name
            .Parameters.AddWithValue("@Unit_Machine", SqlDbType.VarChar).Value = Unit_Machine
            .Parameters.AddWithValue("@Unit_ID", SqlDbType.Int).Value = Unit_IDW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub
    Public Sub Delete_Tbl_Unit(ByVal dgv_Tbl_Unit As DataGridView)
        Dim Position As Integer = dgv_Tbl_Unit.CurrentRow.Index
        Dim ID_Position As Integer = dgv_Tbl_Unit.Rows(Position).Cells("Unit_ID").Value
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Delete  From Tbl_Unit Where Unit_ID = @Unit_ID"
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
    Private Sub BtnNewAdd_Click(sender As Object, e As EventArgs) Handles BtnNewAdd.Click
        ClearControls()
        Txt_Unit_ID.Text = Max_Tbl_Unit() + 1
        BtnNewAdd.Enabled = False
        BtnEdit.Enabled = False
        BtnDelete.Enabled = False
        BtnEdit.Enabled = True
        Txt_Unit_ID.Focus()
        SelectAll_Tbl_Unit(dgv_Unit)
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If Txt_Unit_ID.Text = vbNullString Or Txt_Unit_Name.Text = vbNullString Or Txt_Unit_Machine.Text = vbNullString Then
            MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Exit Sub
        End If
        Insert_Tbl_Unit(Txt_Unit_ID.Text, Txt_Unit_Name.Text, Txt_Unit_Machine.Text)
        ClearControls()
        Txt_Unit_ID.Text = Max_Tbl_Unit() + 1
        SelectAll_Tbl_Unit(dgv_Unit)
    End Sub
    Private Sub Frm_Add_New_Unit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ChangeScreenResolution(Me)
        ClearControls()
        Txt_Unit_ID.Text = Max_Tbl_Unit() + 1
        SelectAll_Tbl_Unit(dgv_Unit)
    End Sub
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If Txt_Unit_ID.Text = vbNullString Or Txt_Unit_Name.Text = vbNullString Or Txt_Unit_Machine.Text = vbNullString Then
            MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Exit Sub
        End If
        Update_Tbl_Unit(Txt_Unit_Name.Text, Txt_Unit_Machine.Text, Txt_Unit_ID.Text)
        ClearControls()
        Txt_Unit_ID.Text = Max_Tbl_Unit() + 1
        SelectAll_Tbl_Unit(dgv_Unit)
    End Sub

    Private Sub Txt_Search_TextChanged(sender As Object, e As EventArgs) Handles Txt_Search.TextChanged
        Try
            Dim dv As DataView = dt_Tbl_Unit.DefaultView
            dv.RowFilter = " Unit_Name LIKE '%" & Txt_Search.Text & "%'"
        Catch ex As Exception
        End Try
        ' ضعه في حدث تكست بوكس تشانج (TextChanged)

    End Sub

    Private Sub dgv_Unit_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Unit.CellContentClick
        Try
            With dgv_Unit
                Me.Txt_Unit_ID.Text = .CurrentRow.Cells("Unit_ID").Value.ToString()
                Me.Txt_Unit_Name.Text = .CurrentRow.Cells("Unit_Name").Value.ToString()
                Me.Txt_Unit_Machine.Text = .CurrentRow.Cells("Unit_Machine").Value.ToString()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
            Exit Sub
        Else
            Delete_Tbl_Unit(dgv_Unit)
        End If
        ClearControls()
        Me.Txt_Unit_ID.Text = Max_Tbl_Unit() + 1
        Me.Txt_Unit_Name.Focus()
        SelectAll_Tbl_Unit(dgv_Unit)
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Panel1.Width > 70 Then
            While Panel1.Width > 70
                Panel1.Width -= 10
            End While
            Exit Sub
        End If
        If Panel1.Width < 100 Then
            While Panel1.Width < 100
                Panel1.Width += 10
            End While
            Exit Sub
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

End Class