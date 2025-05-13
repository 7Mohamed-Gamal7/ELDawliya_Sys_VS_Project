Imports System.Data.SqlClient
Public Class Frm_Notes
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Public dt_Tbl_Note As New DataTable
    Dim MachinesName As String = Frm_Machine_Stop.SharedVariable
    Public Sub ClearControls()
        Me.Note_ID.Text = vbNullString
        Me.Note_Info.Text = vbNullString
        Me.Machine_Note.Text = vbNullString
        Me.Note_Date.Value = Now
    End Sub
    Public Function Max_Tbl_Notes()
        Dim Number As Integer
        Try
            Dim cmd As New SqlCommand("Select Max(Note_ID) From Tbl_Notes ", Con)
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

    Public Sub Insert_Tbl_Notes(ByVal Note_ID As Int32, ByVal Note_Info As String, ByVal Machine_Note As String, ByVal Note_Date As DateTime)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Tbl_Notes ( Note_ID,Note_Info,Machine_Note,Note_Date)values(@Note_ID,@Note_Info,@Machine_Note,@Note_Date)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Note_ID", SqlDbType.Int).Value = Note_ID
            .Parameters.AddWithValue("@Note_Info", SqlDbType.VarChar).Value = Note_Info
            .Parameters.AddWithValue("@Machine_Note", SqlDbType.VarChar).Value = Machine_Note
            .Parameters.AddWithValue("@Note_Date", SqlDbType.Date).Value = Note_Date
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub
    Public Sub Update_Tbl_Notes(ByVal Reply As String, ByVal Reply_Date As DateTime, ByVal Note_IDW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_Notes Set Reply = @Reply,Reply_Date = @Reply_Date Where Note_ID = @Note_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Reply", SqlDbType.VarChar).Value = Reply
            .Parameters.AddWithValue("@Reply_Date", SqlDbType.Date).Value = Reply_Date
            .Parameters.AddWithValue("@Note_ID", SqlDbType.Int).Value = Note_IDW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub
    Public Sub Update_Archive(ByVal Archvie As String, ByVal Note_IDW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_Notes Set Archvie = @Archvie Where Note_ID = @Note_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Archvie", SqlDbType.VarChar).Value = Archvie
            .Parameters.AddWithValue("@Note_ID", SqlDbType.Int).Value = Note_IDW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Public Sub SelectAll_Tbl_Note(dgv As DataGridView)
        Dim StartDate As Date
        Dim EndDate As Date
        Dim MachineName As String
        'MachineName = Frm_Machine_Stop.Lbl_Machine.Text.ToString()
        MachineName = MachinesName
        StartDate = Now.Date.AddHours(0).AddMinutes(0).AddSeconds(0)
        EndDate = Now.Date.AddHours(23).AddMinutes(59).AddSeconds(59)
        '''Dim cmd As New SqlCommand("SELECT * FROM Tbl_Notes WHERE Note_Date BETWEEN @StartDate AND @EndDate AND Machine_Note = @MachineName", Con)
        Dim cmd As New SqlCommand("SELECT * FROM Tbl_Notes WHERE Note_Date BETWEEN @StartDate AND @EndDate AND Machine_Note = @MachineName ORDER BY Note_Date DESC", Con)
        cmd.Parameters.AddWithValue("@StartDate", StartDate)
        cmd.Parameters.AddWithValue("@EndDate", EndDate)
        cmd.Parameters.AddWithValue("@MachineName", MachineName)
        Dim da As New SqlDataAdapter(cmd)
        dt_Tbl_Note.Clear()
        da.Fill(dt_Tbl_Note)
        dgv.DataSource = dt_Tbl_Note
        With Frm_Machine_Stop.dgv_Notes
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .Columns(0).HeaderText = "كود الملاحظة"
            .Columns(0).Visible = False
            .Columns(1).HeaderText = "الملاحظات"
            .Columns(2).HeaderText = "ماكينة الملاحظة"
            .Columns(2).Visible = False
            .Columns(3).HeaderText = "تاريخ الملاحظة"
            .Columns(3).Visible = False
            .Columns(4).HeaderText = "الرد"
            .Columns(4).Visible = False
            .Columns(5).HeaderText = "تاريخ الرد"
            .Columns(5).Visible = False
        End With
    End Sub
    Private Sub Frm_Notes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearControls()
        Note_ID.Text = Max_Tbl_Notes() + 1
        Machine_Note.Text = loggedInUserName
        Machine_Name.Text = MachinesName
        Me.Note_Info.Focus()
        'SelectAll_Tbl_Note(dgv_Notes)
    End Sub

    Private Sub BtnSave1_Click(sender As Object, e As EventArgs) Handles BtnSave1.Click
        If Note_Info.Text = vbNullString Then
            MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Exit Sub
        End If
        'Insert_Tbl_Notes(Note_ID.Text, Note_Info.Text, Machine_Note.Text, Note_Date.Value)
        Insert_Tbl_Notes(Note_ID.Text, Note_Info.Text, MachinesName, Note_Date.Value)
        '''SelectAll_Tbl_Note(dgv_Notes)
        ClearControls()
        Note_ID.Text = Max_Tbl_Notes() + 1
        Me.Note_Info.Focus()
        'Me.Close()
        ' استدعاء الدالة لتحديث DataGridView على الفورم الأول
        Dim frmMachineStop As Frm_Machine_Stop = DirectCast(Application.OpenForms("Frm_Machine_Stop"), Frm_Machine_Stop)
        'frmMachineStop.UpdateDataGridView()
        frmMachineStop.SelectAll_Tbl_Notes(Frm_Machine_Stop.dgv_Notes)
        Me.Close()
    End Sub
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Update_Tbl_Notes(Txt_Reply.Text, Reply_Date.Value, Note_ID.Text)
        Dim frmMachineStop As Frm_Machine_Stop = DirectCast(Application.OpenForms("Frm_Machine_Stop"), Frm_Machine_Stop)
        frmMachineStop.SelectAll_Tbl_Notes(Frm_Machine_Stop.dgv_Notes)
        Me.Close()
    End Sub

    Private Sub BtnHide_Click(sender As Object, e As EventArgs) Handles BtnHide.Click
        Update_Archive("Hide", Note_ID.Text)
        Dim frmMachineStop As Frm_Machine_Stop = DirectCast(Application.OpenForms("Frm_Machine_Stop"), Frm_Machine_Stop)
        frmMachineStop.SelectAll_Tbl_Notes(Frm_Machine_Stop.dgv_Notes)
        Me.Close()
    End Sub
End Class

