Imports System.Data.SqlClient

Public Class UserGroupManagementForm
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)

    Private Sub UserGroupManagementForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadUsers()
            LoadGroups()
        Catch ex As Exception
            MsgBox("حدث خطأ أثناء تحميل المجموعات: " & ex.Message, MsgBoxStyle.Critical, "خطأ")
        End Try
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

    Private Sub LoadGroups()
        Try
            Dim query As String = "SELECT GroupID, GroupName FROM Groups"
            Using connection As New SqlConnection(ConStr)
                Using adapter As New SqlDataAdapter(query, connection)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)

                    ' تأكد أن lstGroups معرف ومهيأ
                    If lvGroups IsNot Nothing Then
                        lvGroups.Items.Clear()
                        lvGroups.Columns.Clear()

                        ' إعداد الأعمدة
                        lvGroups.Columns.Add("GroupName", 400)
                        lvGroups.Columns.Add("GroupID", 200)

                        ' تعبئة البيانات في ListView
                        For Each row As DataRow In dt.Rows
                            Dim listItem As New ListViewItem(row("GroupName").ToString())
                            listItem.SubItems.Add(row("GroupID").ToString())
                            lvGroups.Items.Add(listItem)
                        Next

                        ' تمكين خاصية التحقق
                        lvGroups.CheckBoxes = True
                    Else
                        Throw New NullReferenceException("عنصر lstGroups لم يتم تهيئته.")
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("خطأ أثناء تحميل المجموعات: " & ex.Message, MsgBoxStyle.Critical, "خطأ")
        End Try
    End Sub

    'Private Sub btnSaveMembership_Click(sender As Object, e As EventArgs) Handles btnSaveMembership.Click
    '    Dim userID As Integer = Convert.ToInt32(cmbUsers.SelectedValue)

    '    ' حذف العضوية الحالية
    '    Dim queryDelete As String = "DELETE FROM UserGroups WHERE UserID = @UserID"
    '    Using connection As New SqlConnection(ConStr)
    '        Using command As New SqlCommand(queryDelete, connection)
    '            command.Parameters.AddWithValue("@UserID", userID)
    '            connection.Open()
    '            command.ExecuteNonQuery()
    '        End Using
    '    End Using

    '    ' إضافة العضوية الجديدة
    '    Dim queryInsert As String = "INSERT INTO UserGroups (UserID, GroupID) VALUES (@UserID, @GroupID)"
    '    Using connection As New SqlConnection(ConStr)
    '        connection.Open()
    '        For Each item As ListViewItem In lvGroups.Items
    '            If item.Checked Then
    '                Using command As New SqlCommand(queryInsert, connection)
    '                    command.Parameters.AddWithValue("@UserID", userID)
    '                    command.Parameters.AddWithValue("@GroupID", Convert.ToInt32(item.Text)) ' GroupID هو العمود الأول
    '                    command.ExecuteNonQuery()
    '                End Using
    '            End If
    '        Next
    '    End Using

    '    MessageBox.Show("تم تحديث عضوية المجموعات بنجاح.")
    'End Sub


    Private Sub btnSaveMembership_Click(sender As Object, e As EventArgs) Handles btnSaveMembership.Click
        Dim userID As Integer = Convert.ToInt32(cmbUsers.SelectedValue)

        ' حذف العضوية الحالية
        Dim queryDelete As String = "DELETE FROM UserGroups WHERE UserID = @UserID"
        Using connection As New SqlConnection(ConStr)
            Using command As New SqlCommand(queryDelete, connection)
                command.Parameters.AddWithValue("@UserID", userID)
                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using

        ' إضافة العضوية الجديدة
        Dim queryInsert As String = "INSERT INTO UserGroups (UserID, GroupID) VALUES (@UserID, @GroupID)"
        Using connection As New SqlConnection(ConStr)
            connection.Open()
            For Each item As ListViewItem In lvGroups.Items
                If item.Checked Then
                    Using command As New SqlCommand(queryInsert, connection)
                        command.Parameters.AddWithValue("@UserID", userID)
                        command.Parameters.AddWithValue("@GroupID", Convert.ToInt32(item.SubItems(1).Text)) ' GroupID هو العمود الثاني
                        command.ExecuteNonQuery()
                    End Using
                End If
            Next
        End Using

        MessageBox.Show("تم تحديث عضوية المجموعات بنجاح.")
    End Sub


    Private Sub cmbUsers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUsers.SelectedIndexChanged
        If cmbUsers.SelectedValue IsNot Nothing AndAlso IsNumeric(cmbUsers.SelectedValue) Then
            Dim userID As Integer = Convert.ToInt32(cmbUsers.SelectedValue)
            LoadUserMembership(userID)
        End If
    End Sub

    Private Sub LoadUserMembership(userID As Integer)
        Try
            ' جلب المجموعات التي ينتمي إليها المستخدم
            Dim query As String = "SELECT GroupID FROM UserGroups WHERE UserID = @UserID"
            Dim userGroupIDs As New HashSet(Of Integer)

            Using connection As New SqlConnection(ConStr)
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@UserID", userID)
                    connection.Open()
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            userGroupIDs.Add(Convert.ToInt32(reader("GroupID")))
                        End While
                    End Using
                End Using
            End Using

            ' تحديث حالة الشيك بوكس بناءً على العضوية
            For Each item As ListViewItem In lvGroups.Items
                Dim groupID As Integer = Convert.ToInt32(item.SubItems(1).Text) ' GroupID هو العمود الثاني
                item.Checked = userGroupIDs.Contains(groupID)
            Next
        Catch ex As Exception
            MsgBox("خطأ أثناء تحميل عضوية المستخدم: " & ex.Message, MsgBoxStyle.Critical, "خطأ")
        End Try
    End Sub


End Class

'Private Sub LoadGroups()
'    Try
'        Dim query As String = "SELECT GroupID, GroupName FROM Groups"
'        Using connection As New SqlConnection(ConStr)
'            Using adapter As New SqlDataAdapter(query, connection)
'                Dim dt As New DataTable()
'                adapter.Fill(dt)

'                ' تأكد أن clbGroups معرف ومهيأ
'                If clbGroups IsNot Nothing Then
'                    clbGroups.DataSource = dt
'                    clbGroups.DisplayMember = "GroupName"
'                    clbGroups.ValueMember = "GroupID"
'                Else
'                    Throw New NullReferenceException("عنصر clbGroups لم يتم تهيئته.")
'                End If
'            End Using
'        End Using
'    Catch ex As Exception
'        MsgBox("خطأ أثناء تحميل المجموعات: " & ex.Message, MsgBoxStyle.Critical, "خطأ")
'    End Try
'End Sub

'Private Sub btnSaveMembership_Click(sender As Object, e As EventArgs) Handles btnSaveMembership.Click
'    Dim userID As Integer = Convert.ToInt32(cmbUsers.SelectedValue)

'    Dim queryDelete As String = "DELETE FROM UserGroups WHERE UserID = @UserID"
'    Using connection As New SqlConnection(ConStr)
'        Using command As New SqlCommand(queryDelete, connection)
'            command.Parameters.AddWithValue("@UserID", userID)
'            connection.Open()
'            command.ExecuteNonQuery()
'        End Using
'    End Using

'    Dim queryInsert As String = "INSERT INTO UserGroups (UserID, GroupID) VALUES (@UserID, @GroupID)"
'    Using connection As New SqlConnection(ConStr)
'        connection.Open()
'        For Each item As DataRowView In clbGroups.CheckedItems
'            Using command As New SqlCommand(queryInsert, connection)
'                command.Parameters.AddWithValue("@UserID", userID)
'                command.Parameters.AddWithValue("@GroupID", Convert.ToInt32(item("GroupID")))
'                command.ExecuteNonQuery()
'            End Using
'        Next
'    End Using

'    MessageBox.Show("تم تحديث عضوية المجموعات بنجاح.")
'End Sub