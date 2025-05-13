Imports System.Data.SqlClient

Public Class Frm_Waiting_Point
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Public dt_Tbl_Waiting_Point As New DataTable
    Public Sub ClearControls()
        Me.Waiting_Point_Name.Text = vbNullString
        Me.Waiting_Point_Time.Value = Today
    End Sub
    Public Sub SelectAll_Tbl_Waiting_Point(dgv As DataGridView)
        Dim da As New SqlDataAdapter
        dt_Tbl_Waiting_Point.Clear()
        'da = New SqlDataAdapter("select * from Tbl_Waiting_Point", Con)
        da = New SqlDataAdapter("SELECT Tbl_Waiting_Point.*, Tbl_Car.Car_Name FROM Tbl_Waiting_Point INNER JOIN Tbl_Car ON Tbl_Waiting_Point.Car_ID = Tbl_Car.Car_ID", Con)

        da.Fill(dt_Tbl_Waiting_Point)
        dgv.DataSource = dt_Tbl_Waiting_Point
        With dgv
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .Columns("Waiting_Point_ID").HeaderText = "كود النقطة"
            .Columns("Waiting_Point_ID").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns("Waiting_Point_Name").HeaderText = "اسم نقطة التجمع"
            .Columns("Waiting_Point_Name").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns("Waiting_Point_Time").HeaderText = "ميعاد نقطة التجمع"
            .Columns("Waiting_Point_Time").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns("Waiting_Point_Time").DefaultCellStyle.Format = "t"
            .Columns("Car_ID").Visible = False
            .Columns("Car_Name").HeaderText = "اسم السيارة"
        End With
    End Sub
    Public Sub fillcmb_Tbl_Car(ByVal cmb As ComboBox)
        Dim DT As New DataTable
        Dim DA As New SqlDataAdapter
        DT.Clear()
        DA = New SqlDataAdapter("Select Car_ID , Car_Name FROM Tbl_Car ", Con)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            cmb.DataSource = DT
            cmb.ValueMember = "Car_ID"
            cmb.DisplayMember = "Car_Name"
        Else
            cmb.DataSource = Nothing
        End If
    End Sub
    Public Sub Insert_Tbl_Waiting_Point(ByVal Waiting_Point_Name As String, ByVal Waiting_Point_Time As DateTime, ByVal Car_ID As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Tbl_Waiting_Point ( Waiting_Point_Name,Waiting_Point_Time,Car_ID)values(@Waiting_Point_Name,@Waiting_Point_Time,@Car_ID)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Waiting_Point_Name", SqlDbType.VarChar).Value = Waiting_Point_Name
            .Parameters.AddWithValue("@Waiting_Point_Time", SqlDbType.Date).Value = Waiting_Point_Time
            .Parameters.AddWithValue("@Car_ID", SqlDbType.Date).Value = Car_ID
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub
    Private Sub Frm_Waiting_Point_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillcmb_Tbl_Car(Car_ID)
        ClearControls()
        SelectAll_Tbl_Waiting_Point(dgv_Tbl_Waiting_Point)
        Me.Waiting_Point_Name.Focus()
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Insert_Tbl_Waiting_Point(Waiting_Point_Name.Text, Waiting_Point_Time.Value, Int(Car_ID.SelectedValue))
        ClearControls()
        SelectAll_Tbl_Waiting_Point(dgv_Tbl_Waiting_Point)
        Me.Waiting_Point_Name.Focus()
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub
    Public Sub Update_Tbl_Waiting_Point(ByVal Waiting_Point_Name As String, ByVal Waiting_Point_Time As DateTime, ByVal Car_ID As Int32, ByVal Waiting_Point_IDW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_Waiting_Point Set Waiting_Point_Name = @Waiting_Point_Name,Waiting_Point_Time = @Waiting_Point_Time,Car_ID = @Car_ID Where Waiting_Point_ID = @Waiting_Point_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Waiting_Point_Name", SqlDbType.VarChar).Value = Waiting_Point_Name
            .Parameters.AddWithValue("@Waiting_Point_Time", SqlDbType.Date).Value = Waiting_Point_Time
            .Parameters.AddWithValue("@Car_ID", SqlDbType.Int).Value = Car_ID
            .Parameters.AddWithValue("@Waiting_Point_ID", SqlDbType.Int).Value = Waiting_Point_IDW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Update_Tbl_Waiting_Point(Waiting_Point_Name.Text, Waiting_Point_Time.Value, Int(Car_ID.SelectedValue), Waiting_Point_ID.Text)
        ClearControls()
        fillcmb_Tbl_Car(Car_ID)
        SelectAll_Tbl_Waiting_Point(dgv_Tbl_Waiting_Point)
        Me.Waiting_Point_Name.Focus()
    End Sub
    Private Sub dgv_Tbl_Waiting_Point_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Tbl_Waiting_Point.CellContentClick
        Try
            'Car_ID.Visible = True
            'Car_IDlbl.Visible = True
            With dgv_Tbl_Waiting_Point
                Me.Waiting_Point_ID.Text = .CurrentRow.Cells("Waiting_Point_ID").Value.ToString()
                Me.Waiting_Point_Name.Text = .CurrentRow.Cells("Waiting_Point_Name").Value.ToString()
                Me.Car_ID.SelectedValue = .CurrentRow.Cells("Car_ID").Value.ToString()
                'Me.Car_ID.Text = .CurrentRow.Cells("Car_Name").Value.ToString()
                Me.Waiting_Point_Time.Value = .CurrentRow.Cells("Waiting_Point_Time").Value.ToString()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub BtnNewAdd_Click(sender As Object, e As EventArgs) Handles BtnNewAdd.Click
        ClearControls()
        SelectAll_Tbl_Waiting_Point(dgv_Tbl_Waiting_Point)
        Me.Waiting_Point_Name.Focus()
    End Sub
    Public Sub Delete_Tbl_Waiting_Point(ByVal dgv_Tbl_Waiting_Point As DataGridView)
        Dim Position As Integer = dgv_Tbl_Waiting_Point.CurrentRow.Index
        Dim ID_Position As Integer = dgv_Tbl_Waiting_Point.Rows(Position).Cells("Waiting_Point_ID").Value
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Delete  From Tbl_Waiting_Point Where Waiting_Point_ID = @Waiting_Point_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Waiting_Point_ID", SqlDbType.Int).Value = ID_Position
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم حذف السجل.", MsgBoxStyle.Information, "حذف")
        Cmd = Nothing
    End Sub
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
            Exit Sub
        Else
            Delete_Tbl_Waiting_Point(dgv_Tbl_Waiting_Point)
        End If
    End Sub
    Private Sub Car_ID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Car_ID.SelectedIndexChanged
        Dim da As New SqlDataAdapter
        Dim dgv As DataGridView
        dt_Tbl_Waiting_Point.Clear()
        'da = New SqlDataAdapter("select * from Tbl_Waiting_Point", Con)
        da = New SqlDataAdapter("SELECT Tbl_Waiting_Point.*, Tbl_Car.Car_Name FROM Tbl_Waiting_Point INNER JOIN Tbl_Car ON Tbl_Waiting_Point.Car_ID = Tbl_Car.Car_ID", Con)
        dgv = dgv_Tbl_Waiting_Point
        da.Fill(dt_Tbl_Waiting_Point)
        dgv.DataSource = dt_Tbl_Waiting_Point
        With dgv
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .Columns("Waiting_Point_ID").HeaderText = "كود النقطة"
            .Columns("Waiting_Point_ID").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns("Waiting_Point_Name").HeaderText = "اسم نقطة التجمع"
            .Columns("Waiting_Point_Name").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns("Waiting_Point_Time").HeaderText = "ميعاد نقطة التجمع"
            .Columns("Waiting_Point_Time").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns("Waiting_Point_Time").DefaultCellStyle.Format = "t"
            .Columns("Car_ID").Visible = False
            .Columns("Car_Name").HeaderText = "اسم السيارة"
        End With
    End Sub
    Private Sub Txt_Search_TextChanged(sender As Object, e As EventArgs) Handles Txt_Search.TextChanged
        Try
            Dim dv As DataView = dt_Tbl_Waiting_Point.DefaultView
            dv.RowFilter = " Waiting_Point_Name LIKE '%" & Txt_Search.Text & "%' "
        Catch ex As Exception
        End Try
        ' ضعه في حدث تكست بوكس تشانج (TextChanged)

    End Sub
End Class