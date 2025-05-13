Imports System.Data.SqlClient
Imports System.Reflection

Public Class FormManagementForm
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Private Sub FormManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyPermissions(Me.Name)
        CustomizeForm(Me)
        LoadForms()
        DataGridViewHeaderText(dgvForms)
        ClearControls()
    End Sub

    Private Sub LoadForms()
        Try
            Dim query As String = "SELECT FormID, FormName,FormName_Ar,FormDescription FROM Forms"
            Using connection As New SqlConnection(ConStr)
                Using adapter As New SqlDataAdapter(query, connection)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dgvForms.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnAddForm_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        '-------------------------------------------------------------------------------------------------------
        'خاص بتطبيق الصلاحيات
        If Not CanAdd Then
            MessageBox.Show("ليس لديك صلاحية التعديل.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        '-------------------------------------------------------------------------------------------------------

        Try
            Dim formName As String = txtFormName.Text
            Dim FormDescription As String = txt_FormDescription.Text
            Dim formName_ar As String = txt_formName_ar.Text
            'Dim query As String = "INSERT INTO Forms (FormName) VALUES (@FormName)"
            Dim query As String = "Insert Into Forms ( FormName,FormDescription,FormName_Ar)values(@FormName,@FormDescription,@FormName_Ar)"

            Using connection As New SqlConnection(ConStr)
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@FormName", formName)
                    command.Parameters.AddWithValue("@FormDescription", FormDescription)
                    command.Parameters.AddWithValue("@FormName_Ar", formName_ar)
                    connection.Open()
                    command.ExecuteNonQuery()
                    LoadForms()
                End Using
            End Using
            ClearControls()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub dgvForms_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvForms.CellContentClick
        Try
            With dgvForms
                Me.FormID.Text = .CurrentRow.Cells("FormID").Value.ToString()
                Me.txtFormName.Text = .CurrentRow.Cells("FormName").Value.ToString()
                Me.txt_formName_ar.Text = .CurrentRow.Cells("FormName_Ar").Value.ToString()
                Me.txt_FormDescription.Text = .CurrentRow.Cells("FormDescription").Value.ToString()
            End With
            Btn_New.Enabled = False
            Btn_Save.Enabled = False
            Btn_Delete.Enabled = True
            Btn_Edit.Enabled = True
            txtFormName.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub DataGridViewHeaderText(ByVal DGV As DataGridView)
        If DGV.RowCount > 0 Then
            With DGV
                .Columns("FormID").HeaderText = "كود النموذج"
                .Columns("FormID").Width = 100
                .Columns("FormName").HeaderText = "الاسم البرمجى"
                .Columns("FormName").Width = 300
                .Columns("FormName_Ar").HeaderText = "الاسم باللغة العربية"
                .Columns("FormName_Ar").Width = 400
                .Columns("FormDescription").HeaderText = "الوصف"
                .Columns("FormDescription").Width = 400
            End With
        End If
    End Sub

    Public Sub Update_Forms(ByVal FormName As String, ByVal FormName_Ar As String, ByVal FormDescription As String, ByVal FormIDW As Int32)
        Try
            Dim Cmd As New SqlCommand
            With Cmd
                .Connection = Con
                .CommandType = CommandType.Text
                .CommandText = "Update Forms Set FormName = @FormName,FormName_Ar = @FormName_Ar,FormDescription = @FormDescription Where FormID = @FormID"
                .Parameters.Clear()
                '.Parameters.AddWithValue("@FormID", SqlDbType.Int).Value = FormID
                .Parameters.AddWithValue("@FormName", SqlDbType.VarChar).Value = FormName
                .Parameters.AddWithValue("@FormName_Ar", SqlDbType.VarChar).Value = FormName_Ar
                .Parameters.AddWithValue("@FormDescription", SqlDbType.VarChar).Value = FormDescription
                .Parameters.AddWithValue("@FormID", SqlDbType.Int).Value = FormIDW
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

    Public Sub Delete_Forms(ByVal dgv_Forms As DataGridView)
        Try
            Dim Position As Integer = dgv_Forms.CurrentRow.Index
            Dim ID_Position As Integer = dgv_Forms.Rows(Position).Cells("FormID").Value
            Dim Cmd As New SqlCommand
            With Cmd
                .Connection = Con
                .CommandType = CommandType.Text
                .CommandText = "Delete  From Forms Where FormID = @FormID"
                .Parameters.Clear()
                .Parameters.AddWithValue("@FormID", SqlDbType.Int).Value = ID_Position
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

    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click
        '-------------------------------------------------------------------------------------------------------
        'خاص بتطبيق الصلاحيات
        If Not CanDelete Then
            MessageBox.Show("ليس لديك صلاحية التعديل.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        '-------------------------------------------------------------------------------------------------------
        If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
            Exit Sub
        Else
            Delete_Forms(dgvForms)
        End If

    End Sub

    Public Sub ClearControls()
        Me.FormID.Text = vbNullString
        Me.txtFormName.Text = vbNullString
        Me.txt_formName_ar.Text = vbNullString
        Me.txt_FormDescription.Text = vbNullString
        Btn_New.Enabled = True
        Btn_Save.Enabled = False
        Btn_Delete.Enabled = False
        Btn_Edit.Enabled = False
        txtFormName.Focus()
    End Sub

    Private Sub Btn_Edit_Click(sender As Object, e As EventArgs) Handles Btn_Edit.Click
        '-------------------------------------------------------------------------------------------------------
        'خاص بتطبيق الصلاحيات
        If Not CanEdit Then
            MessageBox.Show("ليس لديك صلاحية التعديل.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        '-------------------------------------------------------------------------------------------------------
        Try
            Update_Forms(txtFormName.Text, txt_formName_ar.Text, txt_FormDescription.Text, FormID.Text)
            ClearControls()
            LoadForms()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Btn_New_Click(sender As Object, e As EventArgs) Handles Btn_New.Click
        '-------------------------------------------------------------------------------------------------------
        'خاص بتطبيق الصلاحيات
        If Not CanAdd Then
            MessageBox.Show("ليس لديك صلاحية التعديل.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        '-------------------------------------------------------------------------------------------------------
        Btn_Save.Enabled = True
        Btn_Edit.Enabled = False
        Btn_Delete.Enabled = False
    End Sub

    Private Sub TextBoxEnglish_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txtFormName.Enter
        English(DirectCast(sender, TextBox))
    End Sub
    Private Sub TextBoxArabic_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txt_formName_ar.Enter
        Arabic(DirectCast(sender, TextBox))
    End Sub

    'Private Sub Btn_Get_All_Forms_Name_Click(sender As Object, e As EventArgs) Handles Btn_Get_All_Forms_Name.Click
    '    '-------------------------------------------------------------------------------------------------------
    '    'خاص بتطبيق الصلاحيات
    '    If Not CanEdit Then
    '        MessageBox.Show("ليس لديك صلاحية التعديل.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        Return
    '    End If
    '    '-------------------------------------------------------------------------------------------------------
    '    Try
    '        ' الحصول على جميع الأنواع في التجميع الحالي (المشروع الحالي)
    '        Dim currentAssembly As Assembly = Assembly.GetExecutingAssembly()
    '        Dim types As Type() = currentAssembly.GetTypes()

    '        ' مسح المحتوى الحالي في DataGridView
    '        DGV_Get_All_Forms_Name.Rows.Clear()
    '        ' تعيين عنوان العمود في DataGridView
    '        'DGV_Get_All_Forms_Name.Columns.Add("FormName", "اسم النموذج")

    '        ' إضافة أسماء النماذج إلى DataGridView
    '        For Each t As Type In types
    '            ' التحقق من أن النوع يرث من System.Windows.Forms.Form
    '            If t.IsSubclassOf(GetType(System.Windows.Forms.Form)) Then
    '                ' إضافة اسم النموذج إلى DataGridView
    '                DGV_Get_All_Forms_Name.Rows.Add(t.Name)
    '            End If
    '        Next
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub



    Private Sub Btn_Get_All_Forms_Name_Click(sender As Object, e As EventArgs) Handles Btn_Get_All_Forms_Name.Click
        '-------------------------------------------------------------------------------------------------------
        'خاص بتطبيق الصلاحيات
        If Not CanEdit Then
            MessageBox.Show("ليس لديك صلاحية التعديل.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        '-------------------------------------------------------------------------------------------------------
        Try
            ' الحصول على جميع الأنواع في التجميع الحالي (المشروع الحالي)
            Dim currentAssembly As Assembly = Assembly.GetExecutingAssembly()
            Dim types As Type() = currentAssembly.GetTypes()

            ' مسح المحتوى الحالي في DataGridView
            DGV_Get_All_Forms_Name.Rows.Clear()
            ' تعيين عنوان العمود في DataGridView
            'DGV_Get_All_Forms_Name.Columns.Add("FormName", "اسم النموذج")

            ' إضافة أسماء النماذج إلى DataGridView
            For Each t As Type In types
                ' التحقق من أن النوع يرث من System.Windows.Forms.Form
                If t.IsSubclassOf(GetType(System.Windows.Forms.Form)) Then
                    ' إضافة اسم النموذج إلى DataGridView
                    DGV_Get_All_Forms_Name.Rows.Add(t.Name)
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Txt_Search_TextChanged(sender As Object, e As EventArgs) Handles Txt_Search.TextChanged
        Try
            ' النص المدخل في Txt_Search
            Dim searchText As String = Txt_Search.Text.Trim().ToLower()

            ' فلترة البيانات في DataGridView
            For Each row As DataGridViewRow In DGV_Get_All_Forms_Name.Rows
                If row.Cells(0).Value IsNot Nothing Then
                    Dim formName As String = row.Cells(0).Value.ToString().ToLower()
                    row.Visible = formName.Contains(searchText)
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub DGV_Get_All_Forms_Name_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Get_All_Forms_Name.CellContentClick
        ' التحقق مما إذا كان الضغط على الخلية ليس في رأس العمود
        If e.RowIndex >= 0 Then
            ' جلب اسم النموذج من العمود الأول (FormName) في الصف الذي تم النقر عليه
            Dim selectedFormName As String = DGV_Get_All_Forms_Name.Rows(e.RowIndex).Cells("FormName").Value.ToString()

            ' نقل اسم النموذج إلى txtFormName
            txtFormName.Text = selectedFormName
        End If
    End Sub

End Class
