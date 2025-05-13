Imports System.Data.SqlClient
Public Class Frm_Add_Machine
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Public dt_Machine As New DataTable

    Public Sub ClearControls()
        Me.MachineName.Text = vbNullString
        Me.MachineName.Focus()
    End Sub

    Public Sub SelectAll_Machine(dgv As DataGridView)
        Dim da As New SqlDataAdapter
        dt_Machine.Clear()
        da = New SqlDataAdapter("select * from Machine", Con)
        da.Fill(dt_Machine)
        dgv.DataSource = dt_Machine
        With dgv
            .Columns("MachineName").HeaderText = "اسم الماكينة"
            ' ضبط عرض العمود "MachineName" لملء العرض
            .Columns("MachineName").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns("MachineID").Visible = False
        End With
    End Sub

    Public Sub Insert_Machine(ByVal MachineName As String)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Machine (MachineName) values (@MachineName)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@MachineName", SqlDbType.VarChar).Value = MachineName
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub

    Public Sub Update_Machine(ByVal MachineName As String, ByVal MachineIDW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Machine Set MachineName = @MachineName Where MachineID = @MachineID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@MachineName", SqlDbType.VarChar).Value = MachineName
            .Parameters.AddWithValue("@MachineID", SqlDbType.Int).Value = MachineIDW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Public Sub Delete_Machine(ByVal dgv_Machine As DataGridView)
        Dim Position As Integer = dgv_Machine.CurrentRow.Index
        Dim ID_Position As Integer = dgv_Machine.Rows(Position).Cells("MachineID").Value
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Delete  From Machine Where MachineID = @MachineID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@MachineID", SqlDbType.Int).Value = ID_Position
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم حذف السجل.", MsgBoxStyle.Information, "حذف")
        Cmd = Nothing
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub

    Private Sub Frm_Add_Maquina_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearControls()
        SelectAll_Machine(dgv_Machine)
    End Sub

    Private Sub dgv_Machine_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Machine.CellContentClick
        Try
            With dgv_Machine
                Me.MachineID.Text = .CurrentRow.Cells("MachineID").Value.ToString()
                Me.MachineName.Text = .CurrentRow.Cells("MachineName").Value.ToString()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click
        If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
            Exit Sub
        Else
            Delete_Machine(dgv_Machine)
        End If

    End Sub

    Private Sub Btn_Edit_Click(sender As Object, e As EventArgs) Handles Btn_Edit.Click
        Update_Machine(MachineName.Text, MachineID.Text)
        ClearControls()
        SelectAll_Machine(dgv_Machine)
    End Sub

    Private Sub Btn_Add_Click(sender As Object, e As EventArgs) Handles Btn_Add.Click
        Insert_Machine(MachineName.Text)
        ClearControls()
        SelectAll_Machine(dgv_Machine)
    End Sub
End Class