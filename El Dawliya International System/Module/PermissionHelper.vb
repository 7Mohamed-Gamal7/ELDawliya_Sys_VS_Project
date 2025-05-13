Imports System.Data.SqlClient
Module PermissionHelper
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)

    Public Function GetPermissions(userID As Integer, formName As String) As DataRow
        Dim query As String = "SELECT CanView, CanEdit, CanAdd, CanDelete, CanReadOnly,CanPrint 
                               FROM UserFormPermissions 
                               INNER JOIN Forms ON UserFormPermissions.FormID = Forms.FormID
                               WHERE UserID = @UserID AND FormName = @FormName"
        Using connection As New SqlConnection(ConStr)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@UserID", userID)
                command.Parameters.AddWithValue("@FormName", formName)
                Dim adapter As New SqlDataAdapter(command)
                Dim dt As New DataTable()
                adapter.Fill(dt)

                If dt.Rows.Count > 0 Then
                    Return dt.Rows(0) ' العودة للصف الوحيد للصلاحيات
                End If
            End Using
        End Using
        Return Nothing ' في حالة عدم وجود صلاحيات
    End Function

End Module
