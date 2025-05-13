Imports System.Data.SqlClient

Public Class Frm_Shift_For_Machine
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Public dt_Shift As New DataTable

    Public Sub fillcmb_Maquinas(ByVal cmb As ComboBox)
        Dim DT As New DataTable
        Dim DA As New SqlDataAdapter
        DT.Clear()
        DA = New SqlDataAdapter("Select * FROM Maquinas ", Con)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            cmb.DataSource = DT
            cmb.ValueMember = "MaquinaID"
            cmb.DisplayMember = "MaquinaName"
        Else
            cmb.DataSource = Nothing
        End If
    End Sub


    Public Sub SelectAll_Shift(dgv As DataGridView)
        Dim da As New SqlDataAdapter
        dt_Shift.Clear()
        'da = New SqlDataAdapter("select * from Shift", Con)
        da = New SqlDataAdapter("SELECT dbo.Shift.*, dbo.Maquinas.* FROM dbo.Maquinas INNER JOIN
                  dbo.Shift ON dbo.Maquinas.MaquinaID = dbo.Shift.MaquinaID", Con)
        da.Fill(dt_Shift)
        dgv.DataSource = dt_Shift
        With dgv
            .Columns("ShiftID").Visible = False
            .Columns("MaquinaID").HeaderText = "اسم الماكينة"
            .Columns("MaquinaID").Width = 100
            .Columns("ShiftType").HeaderText = "اسم الوردية"
            .Columns("ShiftType").Width = 100
            .Columns("ShiftStartTime").HeaderText = "وقت بداية الوردية"
            .Columns("ShiftStartTime").Width = 100
            .Columns("ShiftEndTime").HeaderText = "وقت نهاية الوردية"
            .Columns("ShiftEndTime").Width = 100
        End With
    End Sub

    Public Sub ClearControls()
        Me.ShiftID.Text = vbNullString
        Me.MaquinaID.Text = vbNullString
        Me.ShiftType.Text = vbNullString
        Me.ShiftStartTime.Value = Now
        Me.ShiftEndTime.Value = Now
        fillcmb_Maquinas(MaquinaID)
    End Sub

    Public Sub Insert_Shift(ByVal MaquinaID As Int32, ByVal ShiftType As String, ByVal ShiftStartTime As DateTime, ByVal ShiftEndTime As DateTime)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Shift ( MaquinaID,ShiftType,ShiftStartTime,ShiftEndTime)values(@MaquinaID,@ShiftType,@ShiftStartTime,@ShiftEndTime)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@MaquinaID", SqlDbType.Int).Value = MaquinaID
            .Parameters.AddWithValue("@ShiftType", SqlDbType.VarChar).Value = ShiftType
            .Parameters.AddWithValue("@ShiftStartTime", SqlDbType.Date).Value = ShiftStartTime
            .Parameters.AddWithValue("@ShiftEndTime", SqlDbType.Date).Value = ShiftEndTime
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub

    Public Sub Update_Shift(ByVal MaquinaID As Int32, ByVal ShiftType As String, ByVal ShiftStartTime As DateTime, ByVal ShiftEndTime As DateTime, ByVal ShiftIDW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Shift Set MaquinaID = @MaquinaID,ShiftType = @ShiftType,ShiftStartTime = @ShiftStartTime,ShiftEndTime = @ShiftEndTime Where ShiftID = @ShiftID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@MaquinaID", SqlDbType.Int).Value = MaquinaID
            .Parameters.AddWithValue("@ShiftType", SqlDbType.VarChar).Value = ShiftType
            .Parameters.AddWithValue("@ShiftStartTime", SqlDbType.Date).Value = ShiftStartTime
            .Parameters.AddWithValue("@ShiftEndTime", SqlDbType.Date).Value = ShiftEndTime
            .Parameters.AddWithValue("@ShiftID", SqlDbType.Int).Value = ShiftIDW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Public Sub Delete_Shift(ByVal dgv_Shift As DataGridView)
        Dim Position As Integer = dgv_Shift.CurrentRow.Index
        Dim ID_Position As Integer = dgv_Shift.Rows(Position).Cells("ShiftID").Value
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Delete  From Shift Where ShiftID = @ShiftID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@ShiftID", SqlDbType.Int).Value = ID_Position
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم حذف السجل.", MsgBoxStyle.Information, "حذف")
        Cmd = Nothing
    End Sub


    Private Sub Frm_Shift_For_Machine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearControls()
        SelectAll_Shift(dgv_Shift)
    End Sub

    Private Sub Btn_Edit_Click(sender As Object, e As EventArgs) Handles Btn_Edit.Click
        Update_Shift(MaquinaID.Text, ShiftType.Text, ShiftStartTime.Value, ShiftEndTime.Value, ShiftID.Text)

    End Sub

    Private Sub Btn_Add_Click(sender As Object, e As EventArgs) Handles Btn_Add.Click
        Insert_Shift(MaquinaID.SelectedIndex, ShiftType.Text, ShiftStartTime.Value, ShiftEndTime.Value)
    End Sub

    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click
        If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
            Exit Sub
        Else
            Delete_Shift(dgv_Shift)
        End If

    End Sub
End Class