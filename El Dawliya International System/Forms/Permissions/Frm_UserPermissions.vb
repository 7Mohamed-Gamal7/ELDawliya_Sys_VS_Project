Imports System.Data.SqlClient
Imports El_Dawliya_International_System.El_Dawliya_International_System.Forms.Report
Public Class Frm_UserPermissions
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Public dt_UserPermissions As New DataTable
    Public Sub ClearControls()
        Me.UserID.Text = vbNullString
        Me.Frm_ID.Text = vbNullString
        Me.Tool_ID.Text = vbNullString
        Me.PermissionLevel.Text = vbNullString
    End Sub
    Public Sub SelectAll_UserPermissions(dgv As DataGridView)
        Try
            Dim da As New SqlDataAdapter
            dt_UserPermissions.Clear()
            ' استخدام INNER JOIN لربط الجداول
            Dim query As String = "SELECT UserPermissions.sin ,  Users_Login.UserName, Tbl_Frm_Name.Frm_Name, Tbl_Tool_Name.Tool_Name, UserPermissions.PermissionLevel " &
                              "FROM UserPermissions " &
                              "INNER JOIN Users_Login ON UserPermissions.UserID = Users_Login.UserID " &
                              "INNER JOIN Tbl_Frm_Name ON UserPermissions.Frm_ID = Tbl_Frm_Name.Frm_ID " &
                              "INNER JOIN Tbl_Tool_Name ON UserPermissions.Tool_ID = Tbl_Tool_Name.Tool_ID"
            da = New SqlDataAdapter(query, Con)
            da.Fill(dt_UserPermissions)
            dgv.DataSource = dt_UserPermissions
            If dgv.RowCount > 0 Then
                With dgv
                    .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                    .Columns("sin").HeaderText = "م"
                    .Columns("sin").Visible = False
                    .Columns("UserName").HeaderText = "اسم المستخدم"
                    .Columns("UserName").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    .Columns("Frm_Name").HeaderText = "اسم الشاشة"
                    .Columns("Frm_Name").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    .Columns("Tool_Name").HeaderText = "اسم الاداة"
                    .Columns("Tool_Name").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    .Columns("PermissionLevel").HeaderText = "مستوى الصلاحية"
                    .Columns("PermissionLevel").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                End With
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Public Sub fillcmb_Users_Login(ByVal cmb As ComboBox)
        Dim DT As New DataTable
        Dim DA As New SqlDataAdapter
        DT.Clear()
        DA = New SqlDataAdapter("Select * FROM Users_Login ", Con)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            cmb.DataSource = DT
            cmb.ValueMember = "UserID"
            cmb.DisplayMember = "UserName"
        Else
            cmb.DataSource = Nothing
        End If
    End Sub
    Public Sub fillcmb_Tbl_Frm_Name(ByVal cmb As ComboBox)
        Dim DT As New DataTable
        Dim DA As New SqlDataAdapter
        DT.Clear()
        DA = New SqlDataAdapter("Select * FROM Tbl_Frm_Name ", Con)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            cmb.DataSource = DT
            cmb.ValueMember = "Frm_ID"
            cmb.DisplayMember = "Frm_Name"
        Else
            cmb.DataSource = Nothing
        End If
    End Sub
    Public Sub Insert_UserPermissions(ByVal UserID As Int32, ByVal Frm_ID As Int32, ByVal Tool_ID As Int32, ByVal PermissionLevel As Int32)
        Try
            Dim Cmd As New SqlCommand
            With Cmd
                .Connection = Con
                .CommandType = CommandType.Text
                .CommandText = "Insert Into UserPermissions ( UserID,Frm_ID,Tool_ID,PermissionLevel)values(@UserID,@Frm_ID,@Tool_ID,@PermissionLevel)"
                .Parameters.Clear()
                .Parameters.AddWithValue("@UserID", SqlDbType.Int).Value = UserID
                .Parameters.AddWithValue("@Frm_ID", SqlDbType.Int).Value = Frm_ID
                .Parameters.AddWithValue("@Tool_ID", SqlDbType.Int).Value = Tool_ID
                .Parameters.AddWithValue("@PermissionLevel", SqlDbType.Int).Value = PermissionLevel
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
    Public Sub Update_UserPermissions(ByVal UserID As Int32, ByVal Frm_ID As Int32, ByVal Tool_ID As Int32, ByVal PermissionLevel As Int32, ByVal SinW As Int32)
        ', ByVal UserIDW As Int32, ByVal Frm_IDW As Int32, ByVal Tool_IDW As Int32
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update UserPermissions Set UserID = @UserID, Frm_ID = @Frm_ID, Tool_ID = @Tool_ID, PermissionLevel = @PermissionLevel Where Sin = @Sin "
            'And UserID = @UserIDW And Frm_ID = @Frm_IDW And Tool_ID = @Tool_IDW
            .Parameters.Clear()
            .Parameters.AddWithValue("@UserID", SqlDbType.Int).Value = UserID
            .Parameters.AddWithValue("@Frm_ID", SqlDbType.Int).Value = Frm_ID
            .Parameters.AddWithValue("@Tool_ID", SqlDbType.Int).Value = Tool_ID
            .Parameters.AddWithValue("@PermissionLevel", SqlDbType.Int).Value = PermissionLevel
            .Parameters.AddWithValue("@Sin", SqlDbType.Int).Value = SinW
            '.Parameters.AddWithValue("@UserIDW", SqlDbType.Int).Value = UserIDW
            '.Parameters.AddWithValue("@Frm_IDW", SqlDbType.Int).Value = Frm_IDW
            '.Parameters.AddWithValue("@Tool_IDW", SqlDbType.Int).Value = Tool_IDW
        End With

        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub
    Public Sub Delete_UserPermissions(ByVal dgv_UserPermissions As DataGridView)
        Dim Position As Integer = dgv_UserPermissions.CurrentRow.Index
        Dim ID_Position As Integer = dgv_UserPermissions.Rows(Position).Cells("Sin").Value
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Delete  From UserPermissions Where Sin = @Sin"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Sin", SqlDbType.Int).Value = ID_Position
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم حذف السجل.", MsgBoxStyle.Information, "حذف")
        Cmd = Nothing
    End Sub
    Private Sub Frm_UserPermissions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillcmb_Tbl_Frm_Name(Frm_ID)
        fillcmb_Users_Login(UserID)
        SelectAll_UserPermissions(dgv_UserPermissions)
        BtnEdit.Enabled = False
        BtnDelete.Enabled = False
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim Frm_ID_Value As Integer = GetIntegerValue(Frm_ID.SelectedValue)
        Dim Tool_ID_Value As Integer = GetIntegerValue(Tool_ID.SelectedValue)
        'Insert_UserPermissions(Int(UserID.SelectedValue), Int(Frm_ID.SelectedValue), Int(Tool_ID.SelectedValue), PermissionLevel.Text)
        Insert_UserPermissions(Int(UserID.SelectedValue), Frm_ID_Value, Tool_ID_Value, PermissionLevel.Text)
        'ClearControls()
        SelectAll_UserPermissions(dgv_UserPermissions)
        UserID.Focus()
    End Sub
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Try
            Update_UserPermissions(Int(UserID.SelectedValue), Int(Frm_ID.SelectedValue), Int(Tool_ID.SelectedValue), PermissionLevel.Text, Sin.Text)
            SelectAll_UserPermissions(dgv_UserPermissions)
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Private Sub Frm_ID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Frm_ID.SelectedIndexChanged
        Dim dt As New DataTable
        Dim adapter As SqlDataAdapter
        Try
            adapter = New SqlDataAdapter("Select * from Tbl_Tool_Name where Frm_ID = " & Frm_ID.SelectedValue, Con)
            adapter.Fill(dt)
            Tool_ID.DataSource = dt
            Tool_ID.DisplayMember = "Tool_Name"
            Tool_ID.ValueMember = "Tool_ID"
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Private Sub dgv_UserPermissions_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_UserPermissions.CellContentClick
        BtnEdit.Enabled = True
        BtnDelete.Enabled = True
        Try
            With dgv_UserPermissions
                Me.Sin.Text = .CurrentRow.Cells("sin").Value.ToString()
                Me.UserID.Text = .CurrentRow.Cells("UserName").Value.ToString()
                Me.Frm_ID.Text = .CurrentRow.Cells("Frm_Name").Value.ToString()
                Me.Tool_ID.Text = .CurrentRow.Cells("Tool_Name").Value.ToString()
                Me.PermissionLevel.Text = .CurrentRow.Cells("PermissionLevel").Value.ToString()
            End With
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
    Private Sub Txt_Search_TextChanged(sender As Object, e As EventArgs) Handles Txt_Search.TextChanged
        Try
            Dim dv As DataView = dt_UserPermissions.DefaultView
            Select Case True
                Case Me.Radio_Tool.Checked
                    dv.RowFilter = " Tool_Name LIKE '%" & Txt_Search.Text & "%' "
                Case Me.Radio_User.Checked
                    dv.RowFilter = " UserName LIKE '%" & Txt_Search.Text & "%' "
                Case Me.Radio_Forms.Checked
                    dv.RowFilter = " Frm_Name LIKE '%" & Txt_Search.Text & "%' "
            End Select

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
        TextBox1.Text = dgv_UserPermissions.RowCount.ToString()
    End Sub
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Try
            If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                Exit Sub
            Else
                Delete_UserPermissions(dgv_UserPermissions)
                ClearControls()
                SelectAll_UserPermissions(dgv_UserPermissions)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub BtnNewAdd_Click(sender As Object, e As EventArgs) Handles BtnNewAdd.Click
        BtnEdit.Enabled = False
        BtnSave.Enabled = True
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Frm_Add_From.Show()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Frm_Add_Tool.Show()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim saveDialog As New SaveFileDialog()
        saveDialog.Filter = "Excel Files|*.xlsx;*.xls"
        saveDialog.Title = "E:\El Dawliya International System\Excel"
        If saveDialog.ShowDialog() = DialogResult.OK Then
            ' قائمة بأسماء الأعمدة التي تريد تصديرها
            Dim columnsToExport As New List(Of String)
            ' اضف أسماء الأعمدة التي تريد تصديرها إلى القائمة
            columnsToExport.Add("UserName")
            columnsToExport.Add("Frm_Name")
            columnsToExport.Add("Tool_Name")
            columnsToExport.Add("PermissionLevel")
            ' استدعاء الدالة ExportToExcel مع تمرير قائمة الأعمدة المرغوب تصديرها
            ExportToExcel(dgv_UserPermissions, saveDialog.FileName, columnsToExport)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rep As New Rep_UserPermissions
        rep.SetDataSource(dt_UserPermissions.DefaultView)
        Frm_Report.CrystalReportViewer1.ReportSource = rep
        Frm_Report.CrystalReportViewer1.Refresh()
        Frm_Report.ShowDialog()
    End Sub
End Class