Imports System.Data.SqlClient

Public Class PermissionManagementForm
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Public dt_Forms As New DataTable

    Private Sub PermissionManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomizeForm(Me)
        LoadUsers()
        'LoadForms()
        SelectAll_Forms(Dgv_Forms)
        DataGridViewHeaderText(Dgv_Forms)
        BindingSource1.DataSource = dt_Forms.DefaultView
        '================================================
        'fillcmb_Groups(cmbGroups)
        LoadGroups()
    End Sub

    Private Sub LoadUsers()
        Dim query As String = "SELECT UserID, Username FROM Users_Login"
        Using connection As New SqlConnection(ConStr)
            Using adapter As New SqlDataAdapter(query, connection)
                Dim dt As New DataTable()
                adapter.Fill(dt)
                cmbUsers.DataSource = dt
                cmbUsers.DisplayMember = "Username"
                cmbUsers.ValueMember = "UserID"
            End Using
        End Using
    End Sub

    'الكود ده صح
    Private Sub LoadUserPermissionsDGV()
        If cmbUsers.SelectedValue Is Nothing OrElse Dgv_Forms.SelectedRows.Count = 0 Then
            Return
        End If

        Try
            Dim userID As Integer
            Dim formID As Integer

            ' التحقق من نوع البيانات وتحويلها بشكل صحيح
            If TypeOf cmbUsers.SelectedValue Is DataRowView Then
                userID = Convert.ToInt32(DirectCast(cmbUsers.SelectedValue, DataRowView)("UserID"))
            Else
                userID = Convert.ToInt32(cmbUsers.SelectedValue)
            End If

            ' التحقق من وجود صف محدد في DataGridView
            Dim selectedRow As DataGridViewRow = Dgv_Forms.SelectedRows(0)
            If selectedRow.Cells("FormID").Value IsNot Nothing Then
                formID = Convert.ToInt32(selectedRow.Cells("FormID").Value)
            Else
                MessageBox.Show("الرجاء تحديد نموذج صالح.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim query As String = "SELECT CanView, CanEdit, CanAdd, CanDelete, CanReadOnly,CanPrint FROM UserFormPermissions WHERE UserID = @UserID AND FormID = @FormID"

            Using connection As New SqlConnection(ConStr)
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@UserID", userID)
                    command.Parameters.AddWithValue("@FormID", formID)
                    connection.Open()

                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            chkCanView.Checked = Convert.ToBoolean(reader("CanView"))
                            chkCanEdit.Checked = Convert.ToBoolean(reader("CanEdit"))
                            chkCanAdd.Checked = Convert.ToBoolean(reader("CanAdd"))
                            chkCanDelete.Checked = Convert.ToBoolean(reader("CanDelete"))
                            chkReadOnly.Checked = Convert.ToBoolean(reader("CanReadOnly"))
                            chkCanPrint.Checked = Convert.ToBoolean(reader("CanPrint"))
                        Else
                            ' إذا لم يتم العثور على صلاحيات، نقوم بإلغاء تحديد جميع خانات الاختيار
                            chkCanView.Checked = False
                            chkCanEdit.Checked = False
                            chkCanAdd.Checked = False
                            chkCanDelete.Checked = False
                            chkReadOnly.Checked = False
                            chkCanPrint.Checked = False
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("حدث خطأ أثناء تحميل الصلاحيات: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Dgv_Forms_SelectionChanged(sender As Object, e As EventArgs) Handles Dgv_Forms.SelectionChanged
        LoadUserPermissionsDGV()
    End Sub

    Private Sub cmbUsers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUsers.SelectedIndexChanged
        LoadUserPermissionsDGV()
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        Dim userID As Integer = Convert.ToInt32(cmbUsers.SelectedValue)
        Dim formID As Integer = Convert.ToInt32(Dgv_Forms.SelectedRows(0).Cells("FormID").Value)
        Dim canView As Boolean = chkCanView.Checked
        Dim canEdit As Boolean = chkCanEdit.Checked
        Dim canAdd As Boolean = chkCanAdd.Checked
        Dim canDelete As Boolean = chkCanDelete.Checked
        Dim ReadOnlyForm As Boolean = chkReadOnly.Checked
        Dim canPrint As Boolean = chkCanPrint.Checked

        Dim query As String = "IF EXISTS (SELECT * FROM UserFormPermissions WHERE UserID = @UserID AND FormID = @FormID)
                                UPDATE UserFormPermissions 
                                SET CanView = @CanView, CanEdit = @CanEdit, CanAdd = @CanAdd, CanDelete = @CanDelete, CanReadOnly = @CanReadOnly,CanPrint = @CanPrint
                                WHERE UserID = @UserID AND FormID = @FormID
                               ELSE
                                INSERT INTO UserFormPermissions (UserID, FormID, CanView, CanEdit, CanAdd, CanDelete, CanReadOnly,CanPrint)
                                VALUES (@UserID, @FormID, @CanView, @CanEdit, @CanAdd, @CanDelete, @CanReadOnly,@CanPrint)"

        Using connection As New SqlConnection(ConStr)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@UserID", userID)
                command.Parameters.AddWithValue("@FormID", formID)
                command.Parameters.AddWithValue("@CanView", canView)
                command.Parameters.AddWithValue("@CanEdit", canEdit)
                command.Parameters.AddWithValue("@CanAdd", canAdd)
                command.Parameters.AddWithValue("@CanDelete", canDelete)
                command.Parameters.AddWithValue("@CanReadOnly", ReadOnlyForm)
                command.Parameters.AddWithValue("@CanPrint", canPrint)
                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("تم حفظ الصلاحيات بنجاح.")
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormManagementForm.Show()
    End Sub

    Public Sub DataGridViewHeaderText(ByVal DGV As DataGridView)
        If DGV.RowCount > 0 Then
            With DGV
                .Columns("FormID").HeaderText = "كود النموذج"
                .Columns("FormID").Width = 100
                .Columns("FormName").HeaderText = "الاسم البرمجى"
                .Columns("FormName").Width = 300
                .Columns("FormName_Ar").HeaderText = "الاسم باللغة العربية"
                .Columns("FormName_Ar").Width = 350
                .Columns("FormDescription").HeaderText = "الوصف"
                .Columns("FormDescription").Width = 400
            End With
        End If
    End Sub

    Public Sub SelectAll_Forms(dgv As DataGridView)
        Dim da As New SqlDataAdapter
        dt_Forms.Clear()
        da = New SqlDataAdapter("select * from Forms", Con)
        da.Fill(dt_Forms)
        dgv.DataSource = dt_Forms
    End Sub

    Private Sub Dgv_Forms_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv_Forms.CellContentClick
        LoadUserPermissionsDGV()
    End Sub

    Private Sub dgv_Last_used_item_FilterStringChanged(sender As Object, e As EventArgs) Handles Dgv_Forms.FilterStringChanged
        BindingSource1.Filter = Dgv_Forms.FilterString
        Dgv_Forms.DataSource = BindingSource1

    End Sub

    Private Sub dgv_Last_used_item_SortStringChanged(sender As Object, e As EventArgs) Handles Dgv_Forms.SortStringChanged
        BindingSource1.Sort = Dgv_Forms.SortString
        Dgv_Forms.DataSource = BindingSource1
    End Sub

    '====================================================================================================================================
    Private Sub LoadGroups()
        Con.Open()
        Dim query As String = "SELECT GroupID, GroupName FROM Groups"
        Dim command As New SqlCommand(query, Con)
        Dim reader As SqlDataReader = command.ExecuteReader()

        cmbGroups.Items.Clear()
        While reader.Read()
            ' إضافة العناصر إلى الكمبوكس باستخدام Object
            cmbGroups.Items.Add(New With {.GroupID = reader("GroupID"), .GroupName = reader("GroupName")})
        End While
        reader.Close()

        ' تعيين DisplayMember و ValueMember
        cmbGroups.DisplayMember = "GroupName"
        cmbGroups.ValueMember = "GroupID"
    End Sub


    Public Sub fillcmbForms(dgv As DataGridView)
        Dim da As New SqlDataAdapter
        dt_Forms.Clear()

        ' التحقق من أن هناك قيمة محددة في cmbGroups
        If cmbGroups.SelectedValue Is Nothing Then
            MessageBox.Show("Please select a group first.")
            Return
        End If

        ' تحديد الاستعلام مع المعامل
        da = New SqlDataAdapter("SELECT f.FormName FROM GroupForms gf JOIN Forms f ON gf.FormID = f.FormID WHERE gf.GroupID = @GroupID;", Con)
        da.SelectCommand.Parameters.AddWithValue("@GroupID", cmbGroups.SelectedValue)

        ' ملء DataTable بالبيانات
        da.Fill(dt_Forms)

        ' التأكد من أن DataGridView يعرض البيانات بشكل صحيح
        dgv.DataSource = dt_Forms
        dgv.AutoGenerateColumns = True  ' لتوليد الأعمدة تلقائيًا بناءً على الجدول
    End Sub
    '=============================================================================================================2
    Private Sub cmbGroups_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbGroups.SelectedIndexChanged
        If cmbGroups.SelectedItem IsNot Nothing Then
            Dim selectedGroup = cmbGroups.SelectedItem
            Dim groupID = selectedGroup.GroupID

            ' تحديث المستخدمين
            LoadUsersByGroup(groupID)

            ' تحديث النماذج
            LoadFormsByGroup(groupID)

            ' إعادة تحميل الصلاحيات للمستخدم الأول في القائمة (إذا كان هناك)
            If cmbUsers.SelectedValue IsNot Nothing Then
                LoadUserPermissionsDGV()
            End If
        End If
    End Sub

    Private Sub LoadUsersByGroup(groupID As Integer)
        Dim query As String = "SELECT u.UserID, u.UserName FROM Users_Login u " &
                          "JOIN UserGroups ug ON u.UserID = ug.UserID WHERE ug.GroupID = @GroupID"
        Dim command As New SqlCommand(query, Con)
        command.Parameters.AddWithValue("@GroupID", groupID)

        Dim adapter As New SqlDataAdapter(command)
        Dim dt As New DataTable()
        adapter.Fill(dt)

        ' إعداد الكمبو بوكس
        cmbUsers.DataSource = dt
        cmbUsers.DisplayMember = "UserName"
        cmbUsers.ValueMember = "UserID"
    End Sub


    Private Sub LoadFormsByGroup(groupID As Integer)
        Dim query As String = "SELECT f.FormID, f.FormName, f.FormName_Ar, f.FormDescription " &
                          "FROM Forms f " &
                          "JOIN GroupForms gf ON f.FormID = gf.FormID WHERE gf.GroupID = @GroupID"
        Dim command As New SqlCommand(query, Con)
        command.Parameters.AddWithValue("@GroupID", groupID)

        Dim adapter As New SqlDataAdapter(command)
        Dim dt As New DataTable()
        adapter.Fill(dt)

        ' ملء DataGridView بالنماذج
        Dgv_Forms.DataSource = dt
    End Sub


    ' عند إغلاق الفورم، تأكد من إغلاق الاتصال
    Private Sub YourForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Con IsNot Nothing AndAlso Con.State = ConnectionState.Open Then
            Con.Close()
        End If
    End Sub

    Private Sub MetroCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles MetroCheckBox1.CheckedChanged
        If Me.MetroCheckBox1.Checked = True Then
            LoadUsers()
        End If
    End Sub


End Class
