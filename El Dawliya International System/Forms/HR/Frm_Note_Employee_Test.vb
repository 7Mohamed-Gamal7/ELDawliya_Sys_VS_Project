Imports System.Data.SqlClient
Imports El_Dawliya_International_System.El_Dawliya_International_System.Forms.Report

Public Class Frm_Note_Employee_Test
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Public dt_Note_Employee As New DataTable

    Public noteEmpID As Integer

    Public Sub ClearControls()
        Me.Note_ID.Text = vbNullString
        'Me.Note_Emp_ID.Text = vbNullString
        'Me.Note_Employee_Name.Text = vbNullString
        Me.Description_Note.Text = vbNullString
        Me.Note_Date.Value = Today
        Note_ID.Text = Max_Note_Employee() + 1

    End Sub

    Public Function Max_Note_Employee()
        Dim Number As Integer
        Try
            Dim cmd As New SqlCommand("Select Max(Note_ID) From Note_Employee ", Con)
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

    Public Sub Insert_Note_Employee(ByVal Note_ID As Int32, ByVal Note_Emp_ID As Int32, ByVal Note_Employee_Name As String, ByVal Description_Note As String, ByVal Note_Date As Date)
        Try
            Dim Cmd As New SqlCommand
            With Cmd
                .Connection = Con
                .CommandType = CommandType.Text
                .CommandText = "Insert Into Note_Employee ( Note_ID,Note_Emp_ID,Note_Employee_Name,Description_Note,Note_Date)values(@Note_ID,@Note_Emp_ID,@Note_Employee_Name,@Description_Note,@Note_Date)"
                .Parameters.Clear()
                .Parameters.AddWithValue("@Note_ID", SqlDbType.Int).Value = Note_ID
                .Parameters.AddWithValue("@Note_Emp_ID", SqlDbType.Int).Value = Note_Emp_ID
                .Parameters.AddWithValue("@Note_Employee_Name", SqlDbType.VarChar).Value = Note_Employee_Name
                .Parameters.AddWithValue("@Description_Note", SqlDbType.VarChar).Value = Description_Note
                .Parameters.AddWithValue("@Note_Date", SqlDbType.Date).Value = Note_Date
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

    Public Sub Update_Note_Employee(ByVal Note_Emp_ID As Int32, ByVal Note_Employee_Name As String, ByVal Description_Note As String, ByVal Note_Date As Date, ByVal Note_IDW As Int32)
        Try
            Dim Cmd As New SqlCommand
            With Cmd
                .Connection = Con
                .CommandType = CommandType.Text
                .CommandText = "Update Note_Employee Set Note_Emp_ID = @Note_Emp_ID,Note_Employee_Name = @Note_Employee_Name,Description_Note = @Description_Note,Note_Date = @Note_Date Where Note_ID = @Note_ID"
                .Parameters.Clear()
                .Parameters.AddWithValue("@Note_Emp_ID", SqlDbType.Int).Value = Note_Emp_ID
                .Parameters.AddWithValue("@Note_Employee_Name", SqlDbType.VarChar).Value = Note_Employee_Name
                .Parameters.AddWithValue("@Description_Note", SqlDbType.VarChar).Value = Description_Note
                .Parameters.AddWithValue("@Note_Date", SqlDbType.Date).Value = Note_Date
                .Parameters.AddWithValue("@Note_ID", SqlDbType.Int).Value = Note_IDW
            End With
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Cmd.ExecuteNonQuery()
            Con.Close()
            MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
            Cmd = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub Delete_Note_Employee(ByVal dgv_Note_Employee As DataGridView)
        Try
            Dim Position As Integer = dgv_Note_Employee.CurrentRow.Index
            Dim ID_Position As Integer = dgv_Note_Employee.Rows(Position).Cells("Note_ID").Value
            Dim Cmd As New SqlCommand
            With Cmd
                .Connection = Con
                .CommandType = CommandType.Text
                .CommandText = "Delete  From Note_Employee Where Note_ID = @Note_ID"
                .Parameters.Clear()
                .Parameters.AddWithValue("@Note_ID", SqlDbType.Int).Value = ID_Position
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

    Public Sub SelectAll_Note_Employee(dgv As DataGridView)
        Try
            Dim da As New SqlDataAdapter
            dt_Note_Employee.Clear()
            'عدلت هنا الجزء ده Note_Emp_ID = @Note_Emp_ID
            'ولسه عاوز اعمل ستورد برسيدجر واعدل الكود عليه 
            da = New SqlDataAdapter("Select * from Note_Employee", Con)

            da.Fill(dt_Note_Employee)
            dgv.DataSource = dt_Note_Employee
            With dgv
                .Columns("Note_ID").HeaderText = "Note_ID"
                .Columns("Note_ID").Visible = False
                .Columns("Note_Emp_ID").HeaderText = "كود الموظف"
                .Columns("Note_Emp_ID").Width = 100
                .Columns("Note_Employee_Name").HeaderText = "اسم الموظف"
                .Columns("Note_Employee_Name").Width = 200
                .Columns("Note_Date").HeaderText = "تاريخ الملاحظة"
                .Columns("Note_Date").Width = 150
                .Columns("Description_Note").HeaderText = "الملاحظة"
                .Columns("Description_Note").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            End With
        Catch ex As Exception
            MessageBox.Show("خطأ", ex.Message)
        End Try

    End Sub

    Private Sub Frm_Note_Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            ApplyPermissions(Me.Name)
            CustomizeForm(Me)
            ClearControls()
            SelectAll_Note_Employee(dgv_Note_Employee)
            BindingSource1.DataSource = dt_Note_Employee.DefaultView
        Catch ex As Exception
            MessageBox.Show("حدث خطأ: " & ex.Message)
        End Try
        'txt_Company_Name.Text = My.Settings.Company_Name.ToString()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If Not CanAdd Then
            MessageBox.Show("ليس لديك صلاحية الإضافة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Note_Emp_ID.Text = vbNullString Or Note_Employee_Name.Text = vbNullString Or Description_Note.Text = vbNullString Then
            MessageBox.Show("عفواً ، قم بتعبئة كل الحقول", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Exit Sub
        End If
        Insert_Note_Employee(Note_ID.Text, Note_Emp_ID.Text, Note_Employee_Name.Text, Description_Note.Text, Note_Date.Value)
        ClearControls()
        SelectAll_Note_Employee(dgv_Note_Employee)
        BtnSave.Enabled = True
        BtnDelete.Enabled = False
        BtnEdit.Enabled = False
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        If Not CanEdit Then
            MessageBox.Show("ليس لديك صلاحية التعديل.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Update_Note_Employee(Note_Emp_ID.Text, Note_Employee_Name.Text, Description_Note.Text, Note_Date.Value, Note_ID.Text)
        ClearControls()
        SelectAll_Note_Employee(dgv_Note_Employee)
        BtnSave.Enabled = True
        BtnDelete.Enabled = False
        BtnEdit.Enabled = False

    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If Not CanDelete Then
            MessageBox.Show("ليس لديك صلاحية الحذف.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Try
            If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                Exit Sub
            Else
                Delete_Note_Employee(dgv_Note_Employee)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        ClearControls()
        SelectAll_Note_Employee(dgv_Note_Employee)
    End Sub

    Private Sub dgv_Note_Employee_Click(sender As Object, e As EventArgs) Handles dgv_Note_Employee.Click
        Try
            With dgv_Note_Employee
                Me.Note_ID.Text = .CurrentRow.Cells("Note_ID").Value.ToString()
                Me.Note_Emp_ID.Text = .CurrentRow.Cells("Note_Emp_ID").Value.ToString()
                Me.Note_Employee_Name.Text = .CurrentRow.Cells("Note_Employee_Name").Value.ToString()
                Me.Description_Note.Text = .CurrentRow.Cells("Description_Note").Value.ToString()
                Me.Note_Date.Value = .CurrentRow.Cells("Note_Date").Value.ToString()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        BtnSave.Enabled = False
        BtnDelete.Enabled = True
        BtnEdit.Enabled = True
    End Sub

    Private Sub BtnNewAdd_Click(sender As Object, e As EventArgs) Handles BtnNewAdd.Click
        If Not CanAdd Then
            MessageBox.Show("ليس لديك صلاحية الإضافة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        ClearControls()
        BtnSave.Enabled = True
        BtnDelete.Enabled = False
        BtnEdit.Enabled = False
    End Sub

    Private Sub dgv_Note_Employee_FilterStringChanged(sender As Object, e As EventArgs) Handles dgv_Note_Employee.FilterStringChanged
        BindingSource1.Filter = dgv_Note_Employee.FilterString
        dgv_Note_Employee.DataSource = BindingSource1
    End Sub

    Private Sub dgv_Note_Employee_SortStringChanged(sender As Object, e As EventArgs) Handles dgv_Note_Employee.SortStringChanged
        BindingSource1.Sort = dgv_Note_Employee.SortString
        dgv_Note_Employee.DataSource = BindingSource1
    End Sub

    Private Sub Btn_Print_Click(sender As Object, e As EventArgs) Handles Btn_Print.Click
        If Not CanPrint Then
            MessageBox.Show("ليس لديك صلاحية الطباعة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim rep As New Rpt_Employee_Note
        rep.SetDataSource(dt_Note_Employee.DefaultView)
        'rep.Section2.SectionFormat.BackgroundColor = Color.FromArgb(0, 167, 131)
        Frm_Report.CrystalReportViewer1.ReportSource = rep
        Frm_Report.CrystalReportViewer1.Refresh()
        Frm_Report.ShowDialog()
    End Sub

    Private Sub Note_Emp_ID_TextChanged(sender As Object, e As EventArgs) Handles Note_Emp_ID.TextChanged
        Try
            Dim dv As DataView = dt_Note_Employee.DefaultView
            'للبحث بجزء من النص 
            'dv.RowFilter = "Convert(Note_Emp_ID, 'System.String') like '%" & Note_Emp_ID.Text & "%' "
            dv.RowFilter = "Convert(Note_Emp_ID, 'System.String') = '" & Note_Emp_ID.Text & "'"
        Catch ex As Exception

        End Try
    End Sub
End Class