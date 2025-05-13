Imports System.Data.SqlClient
Module Quary
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Public Sub Insert_MovementHistory(ByVal MovementDescription As String, ByVal MovementDate As DateTime, ByVal PerformedBy As String, ByVal DeviceName As String, ByVal Frm_Name As String, ByVal Btn As String)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into MovementHistory ( MovementDescription,MovementDate,PerformedBy,DeviceName,Frm_Name,Btn)values(@MovementDescription,@MovementDate,@PerformedBy,@DeviceName,@Frm_Name,@Btn)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@MovementDescription", SqlDbType.VarChar).Value = MovementDescription
            .Parameters.AddWithValue("@MovementDate", SqlDbType.Date).Value = MovementDate
            .Parameters.AddWithValue("@PerformedBy", SqlDbType.VarChar).Value = PerformedBy
            .Parameters.AddWithValue("@DeviceName", SqlDbType.VarChar).Value = DeviceName
            .Parameters.AddWithValue("@Frm_Name", SqlDbType.VarChar).Value = Frm_Name
            .Parameters.AddWithValue("@Btn", SqlDbType.VarChar).Value = Btn
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        'MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub
End Module
