'Imports System.Collections.Specialized.BitVector32
Imports System.Data.SqlClient

Public Class Frm_Machine_Stop
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Dim ss, tt, vv As Integer
    Public Shared SharedVariable As String
    Public dt_Tbl_Notes As New DataTable
    ' دالة لتحديث DataGridView
    Public Sub UpdateDataGridView()
        Dim dgv As New DataGridView
        Dim StartDate As Date
        Dim EndDate As Date
        Dim MachineName As String
        MachineName = Lbl_Machine.Text.ToString()
        StartDate = Now.Date.AddHours(0).AddMinutes(0).AddSeconds(0)
        EndDate = Now.Date.AddHours(23).AddMinutes(59).AddSeconds(59)
        ' استخدام SqlCommand بدلاً من SqlDataAdapter
        'Dim cmd As New SqlCommand("SELECT Note_Info FROM Tbl_Notes WHERE Note_Date BETWEEN @StartDate AND @EndDate AND Machine_Note = @MachineName", Con)
        Dim cmd As New SqlCommand("SELECT * FROM Tbl_Notes WHERE Note_Date BETWEEN @StartDate AND @EndDate AND Machine_Note = @MachineName", Con)
        cmd.Parameters.AddWithValue("@StartDate", StartDate)
        cmd.Parameters.AddWithValue("@EndDate", EndDate)
        cmd.Parameters.AddWithValue("@MachineName", MachineName)
        Dim da As New SqlDataAdapter(cmd)
        dt_Tbl_Notes.Clear()
        da.Fill(dt_Tbl_Notes)
        dgv.DataSource = dt_Tbl_Notes
        With dgv_Notes
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

    Public Function Max_Tbl_MachineProblems_Time()
        Dim Number As Integer
        Dim query As String = "SELECT MAX(Problem_Code) FROM Tbl_MachineProblems_Time"
        Try
            Dim cmd As New SqlCommand(query, Con)
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Lbl_Timer.Text = Format(ss, "00:") & Format(tt, "00:") & Format(vv, "00")
        vv = vv + 1
        If vv > 59 Then
            vv = 0
            tt = tt + 1
            If tt > 59 Then
                vv = 0
                tt = 0
                ss = ss + 1
            End If
        End If
        If ss = 23 Then
            vv = 0
            tt = 0
            Lbl_Timer.Text = "00:00:00"
            Timer1.Enabled = False
        End If
    End Sub

    Private Sub MachineStopButton_Click(sender As Object, e As EventArgs) Handles MachineStopButton.Click
        Timer1.Enabled = True
        Me.Txt_Time.Text = Now
        ProblemCode.Text = Max_Tbl_MachineProblems_Time()
        Txt_Max_Code.Text = Max_Tbl_MachineProblems_Time() + 1
        Insert_Tbl_MachineProblems_Time_Stop_Machine(Txt_Max_Code.Text, DateTime.Parse(Txt_Time.Text), Lbl_Machine.Text)
        ProblemCode.Text = Max_Tbl_MachineProblems_Time()
        Txt_Max_Code.Text = Max_Tbl_MachineProblems_Time() + 1
        Me.MachineStopButton.Visible = False
        Me.Panel3.Visible = True
    End Sub

    Private Sub Btn_Run_Machine_Click(sender As Object, e As EventArgs) Handles Btn_Run_Machine.Click
        vv = 0
        tt = 0
        ss = 0
        Lbl_Timer.Text = "00:00:00"
        Timer1.Enabled = False
        Me.Txt_Time.Text = Now
        Update_Tbl_MachineProblems_Time_Run_Machine(DateTime.Parse(Txt_Time.Text), ProblemCode.Text)
        Me.Panel3.Visible = False
        Me.Panel4.Visible = False
        Me.MachineStopButton.Visible = True
        Me.Btn_Run_Machine.Visible = False
        Me.Btn_Alarm_Mentinance.Visible = True
        Me.Btn_Alarm_Kahraba.Visible = True
        Me.Btn_Alarm_Mawad.Visible = True
        Me.Btn_Alarm_Production.Visible = True
        Me.Btn_Alarm_Quality.Visible = True
        Me.Btn_Alarm_SpareParts.Visible = True
        Me.Txt_Send_Report.Visible = True
        Me.Btn_Send_Report.Visible = True
        Frm_Machine_Stop_Load(Me, EventArgs.Empty)
    End Sub

    Public Sub UpdateControlState(Tool_ID As String, permissionLevel As Integer)
        ' قم بتحديث حالة العنصر (التفاعلية أو القابلة للرؤية) بناءً على مستوى الصلاحية
        ' يمكنك تعديل هذا الكود وفقًا لتصميم وعناصر الفورم الفعليين.
        Select Case Tool_ID
            Case "Btn_Close"
                Btn_Close.Visible = (permissionLevel >= 2)
        End Select
    End Sub

    Private Sub Frm_Machine_Stop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Arabic()
        If Con.State = 1 Then Con.Close()
        Con.Open()
        'WindowState = FormWindowState.Maximized
        FormBorderStyle = FormBorderStyle.None
        fillcmb_Tbl_Unit(Combo_Unit)
        ProblemCode.Text = Max_Tbl_MachineProblems_Time()
        Txt_Max_Code.Text = Max_Tbl_MachineProblems_Time() + 1
        SharedVariable = Lbl_Machine.Text
        SelectAll_Tbl_Notes(dgv_Notes)
        Try
            Dim currentUserID As Integer = loggedInUserID
            Dim permissionData As New Dictionary(Of String, Integer)
            Dim query As String = "SELECT Tbl_Tool_Name.Tool_Name, PermissionLevel FROM UserPermissions INNER JOIN Tbl_Tool_Name ON UserPermissions.Tool_ID = Tbl_Tool_Name.Tool_ID WHERE UserID = " & currentUserID & " AND UserPermissions.Frm_ID = Tbl_Tool_Name.Frm_ID"
            Using connection As New SqlConnection(GetConnectionString())
                connection.Open()
                Using cmd As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim Tool_ID As String = reader("Tool_Name").ToString()
                            Dim permissionLevel As Integer = Convert.ToInt32(reader("PermissionLevel"))
                            ' قم بإضافة البيانات إلى القاموس
                            permissionData.Add(Tool_ID, permissionLevel)
                        End While
                    End Using
                End Using
            End Using
            ' قم بتحديث حالة العناصر بناءً على الصلاحيات
            UpdateControlState("Btn_Close", permissionData("Btn_Close"))

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
        Me.Txt_Alarm_Production_password.PasswordChar = "*"
        Me.Txt_Alarm_Mentinance_password.PasswordChar = "*"
        Me.Txt_Alarm_Kahraba_password.PasswordChar = "*"
        Me.Txt_Alarm_Mawad_password.PasswordChar = "*"
        Me.Txt_Alarm_Quality_password.PasswordChar = "*"
        Me.Txt_Alarm_SpareParts_password.PasswordChar = "*"
        Me.Txt_Send_Report.PasswordChar = "*"
    End Sub
    '======================================================================================================================
    ''''''''''''''''''''''''''''''''''''''''''''''''متغيرات عامة'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '======================================================================================================================

    Public Sub fillcmb_Tbl_Unit(ByVal cmb As ComboBox)
        Dim DT As New DataTable
        Dim DA As New SqlDataAdapter
        DT.Clear()
        DA = New SqlDataAdapter("Select * FROM Tbl_Unit ", Con)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            cmb.DataSource = DT
            cmb.ValueMember = "Unit_ID"
            cmb.DisplayMember = "Unit_Name"
        Else
            cmb.DataSource = Nothing
        End If
    End Sub

    '''Public Function Max_Tbl_MachineProblems_Time_Stop_Machine(ByVal Problem_Code As TextBox) As DateTime
    '''    Dim maxDateTime As DateTime = DateTime.MinValue
    '''    Try
    '''        Using cmd As New SqlCommand("SELECT  Machine_stop_time FROM Tbl_MachineProblems_Time  where Problem_Code = @Problem_Code", Con)
    '''            cmd.Parameters.AddWithValue("@Problem_Code", Problem_Code)
    '''            If Con.State = 1 Then Con.Close()
    '''            Con.Open()
    '''            Dim result = cmd.ExecuteScalar()
    '''            If result IsNot DBNull.Value Then
    '''                maxDateTime = Convert.ToDateTime(result)
    '''            End If
    '''        End Using
    '''    Catch ex As Exception


    '''    End Try
    '''    Return maxDateTime
    '''End Function
    '''

    Public Function Max_Tbl_MachineProblems_Time_Stop_Machine(ByVal Problem_Code As String) As DateTime
        Dim maxDateTime As DateTime = DateTime.MinValue
        Try
            Using cmd As New SqlCommand("SELECT Machine_stop_time FROM Tbl_MachineProblems_Time WHERE Problem_Code = @Problem_Code", Con)
                cmd.Parameters.AddWithValue("@Problem_Code", Problem_Code)
                If Con.State = ConnectionState.Open Then Con.Close()
                Con.Open()
                Dim result = cmd.ExecuteScalar()
                If result IsNot DBNull.Value Then
                    maxDateTime = Convert.ToDateTime(result)
                End If
            End Using
        Catch ex As Exception
            ' يمكنك إضافة رمز للتعامل مع الاستثناء هنا
        End Try
        Return maxDateTime
    End Function


    Public Sub Insert_Tbl_MachineProblems_Time_Stop_Machine(ByVal Problem_Code As Int32, ByVal Machine_stop_time As DateTime, ByVal Machine_Name As String)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Tbl_MachineProblems_Time ( Problem_Code, Machine_stop_time,Machine_Name) values ( @Problem_Code, @Machine_stop_time,@Machine_Name)"
            'If Me.Lbl_Machine.Text = "D1" Then
            '    .CommandText = "Insert Into Tbl_MachineProblems_D1 ( Problem_Code, Machine_stop_time,Machine_Name) values ( @Problem_Code, @Machine_stop_time,@Machine_Name)"
            'ElseIf Me.Lbl_Machine.Text = "D2" Then
            '    .CommandText = "Insert Into Tbl_MachineProblems_D2 ( Problem_Code, Machine_stop_time,Machine_Name) values ( @Problem_Code, @Machine_stop_time,@Machine_Name)"
            'ElseIf Me.Lbl_Machine.Text = "F1" Then
            '    .CommandText = "Insert Into Tbl_MachineProblems_F1 ( Problem_Code, Machine_stop_time,Machine_Name) values ( @Problem_Code, @Machine_stop_time,@Machine_Name)"
            'ElseIf Me.Lbl_Machine.Text = "F2" Then
            '    .CommandText = "Insert Into Tbl_MachineProblems_F2 ( Problem_Code, Machine_stop_time,Machine_Name) values ( @Problem_Code, @Machine_stop_time,@Machine_Name)"
            'ElseIf Me.Lbl_Machine.Text = "H" Then
            '    .CommandText = "Insert Into Tbl_MachineProblems_H ( Problem_Code, Machine_stop_time,Machine_Name) values ( @Problem_Code, @Machine_stop_time,@Machine_Name)"
            'End If
            .Parameters.Clear()
            .Parameters.AddWithValue("@Problem_Code", SqlDbType.Int).Value = Problem_Code
            .Parameters.AddWithValue("@Machine_stop_time", SqlDbType.Date).Value = Machine_stop_time
            .Parameters.AddWithValue("@Machine_Name", SqlDbType.VarChar).Value = Machine_Name
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        'MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub

    '======================================================================================================================
    ''''''''''''''''''''''''''''''''''''''''''''''''متغيرات Update_Press'''''''''''''''''''''''''''''''''''''''''''''''''''
    '======================================================================================================================

    Public Sub Update_Tbl_MachineProblems_Time_Press_Mentinance_button(ByVal VisitTime_Maintenance As DateTime, ByVal PressedMaintenanceButtonBy As String, ByVal PressedMaintenanceButtonBy_ID As Int32, ByVal Section_Maintenance As String, ByVal Problem_CodeW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_MachineProblems_Time Set VisitTime_Maintenance = @VisitTime_Maintenance,PressedMaintenanceButtonBy = @PressedMaintenanceButtonBy,PressedMaintenanceButtonBy_ID = @PressedMaintenanceButtonBy_ID,Section_Maintenance = @Section_Maintenance Where Problem_Code = @Problem_Code"
            .Parameters.Clear()
            .Parameters.AddWithValue("@VisitTime_Maintenance", SqlDbType.Date).Value = VisitTime_Maintenance
            .Parameters.AddWithValue("@PressedMaintenanceButtonBy", SqlDbType.VarChar).Value = PressedMaintenanceButtonBy
            .Parameters.AddWithValue("@PressedMaintenanceButtonBy_ID", SqlDbType.Int).Value = PressedMaintenanceButtonBy_ID
            .Parameters.AddWithValue("@Section_Maintenance", SqlDbType.VarChar).Value = Section_Maintenance
            .Parameters.AddWithValue("@Problem_Code", SqlDbType.Int).Value = Problem_CodeW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        'MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Public Sub Update_Tbl_MachineProblems_Time_press_the_Electricity_button(ByVal Time_to_press_the_power_button As DateTime, ByVal Who_pressed_the_power_button As String, ByVal Who_pressed_the_power_button_ID As Int32, ByVal Electricity_Department As String, ByVal Problem_CodeW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_MachineProblems_Time Set Time_to_press_the_power_button = @Time_to_press_the_power_button,Who_pressed_the_power_button = @Who_pressed_the_power_button,Who_pressed_the_power_button_ID = @Who_pressed_the_power_button_ID,Electricity_Department = @Electricity_Department Where Problem_Code = @Problem_Code"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Time_to_press_the_power_button", SqlDbType.Date).Value = Time_to_press_the_power_button
            .Parameters.AddWithValue("@Who_pressed_the_power_button", SqlDbType.VarChar).Value = Who_pressed_the_power_button
            .Parameters.AddWithValue("@Who_pressed_the_power_button_ID", SqlDbType.Int).Value = Who_pressed_the_power_button_ID
            .Parameters.AddWithValue("@Electricity_Department", SqlDbType.VarChar).Value = Electricity_Department
            .Parameters.AddWithValue("@Problem_Code", SqlDbType.Int).Value = Problem_CodeW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        'MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Public Sub Update_Tbl_MachineProblems_Time_press_the_Mawad_button(ByVal VisitTime_RawMaterials As DateTime, ByVal ClickedRawMaterialsButtonBy As String, ByVal ClickedRawMaterialsButtonBy_ID As Int32, ByVal Section_RawMaterials As String, ByVal Problem_CodeW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_MachineProblems_Time Set VisitTime_RawMaterials = @VisitTime_RawMaterials,ClickedRawMaterialsButtonBy = @ClickedRawMaterialsButtonBy,ClickedRawMaterialsButtonBy_ID = @ClickedRawMaterialsButtonBy_ID,Section_RawMaterials = @Section_RawMaterials Where Problem_Code = @Problem_Code"
            .Parameters.Clear()
            .Parameters.AddWithValue("@VisitTime_RawMaterials", SqlDbType.Date).Value = VisitTime_RawMaterials
            .Parameters.AddWithValue("@ClickedRawMaterialsButtonBy", SqlDbType.VarChar).Value = ClickedRawMaterialsButtonBy
            .Parameters.AddWithValue("@ClickedRawMaterialsButtonBy_ID", SqlDbType.Int).Value = ClickedRawMaterialsButtonBy_ID
            .Parameters.AddWithValue("@Section_RawMaterials", SqlDbType.VarChar).Value = Section_RawMaterials
            .Parameters.AddWithValue("@Problem_Code", SqlDbType.Int).Value = Problem_CodeW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        'MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Public Sub Update_Tbl_MachineProblems_Time_press_the_Quality_button(ByVal PressQualityButtonTime As DateTime, ByVal PressedQualityButtonBy As String, ByVal PressedQualityButtonBy_ID As Int32, ByVal Section_Quality As String, ByVal Problem_CodeW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_MachineProblems_Time Set PressQualityButtonTime = @PressQualityButtonTime,PressedQualityButtonBy = @PressedQualityButtonBy,PressedQualityButtonBy_ID = @PressedQualityButtonBy_ID,Section_Quality = @Section_Quality Where Problem_Code = @Problem_Code"
            .Parameters.Clear()
            .Parameters.AddWithValue("@PressQualityButtonTime", SqlDbType.Date).Value = PressQualityButtonTime
            .Parameters.AddWithValue("@PressedQualityButtonBy", SqlDbType.VarChar).Value = PressedQualityButtonBy
            .Parameters.AddWithValue("@PressedQualityButtonBy_ID", SqlDbType.Int).Value = PressedQualityButtonBy_ID
            .Parameters.AddWithValue("@Section_Quality", SqlDbType.VarChar).Value = Section_Quality
            .Parameters.AddWithValue("@Problem_Code", SqlDbType.Int).Value = Problem_CodeW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        'MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Public Sub Update_Tbl_MachineProblems_Time_press_the_Production_button(ByVal PressProductionButtonTime As DateTime, ByVal PressedProductionButtonBy As String, ByVal PressedProductionButtonBy_ID As Int32, ByVal Section_Production As String, ByVal Problem_CodeW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_MachineProblems_Time Set PressProductionButtonTime = @PressProductionButtonTime,PressedProductionButtonBy = @PressedProductionButtonBy,PressedProductionButtonBy_ID = @PressedProductionButtonBy_ID,Section_Production = @Section_Production Where Problem_Code = @Problem_Code"
            .Parameters.Clear()
            .Parameters.AddWithValue("@PressProductionButtonTime", SqlDbType.Date).Value = PressProductionButtonTime
            .Parameters.AddWithValue("@PressedProductionButtonBy", SqlDbType.VarChar).Value = PressedProductionButtonBy
            .Parameters.AddWithValue("@PressedProductionButtonBy_ID", SqlDbType.Int).Value = PressedProductionButtonBy_ID
            .Parameters.AddWithValue("@Section_Production", SqlDbType.VarChar).Value = Section_Production
            .Parameters.AddWithValue("@Problem_Code", SqlDbType.Int).Value = Problem_CodeW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        'MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Public Sub Update_Tbl_MachineProblems_Time_press_the_SpareParts_button(ByVal PressSparePartsButtonTime As DateTime, ByVal PressedSparePartsButtonBy As String, ByVal PressedSparePartsButtonBy_Id As Int32, ByVal Section_SpareParts As String, ByVal Problem_CodeW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_MachineProblems_Time Set PressSparePartsButtonTime = @PressSparePartsButtonTime,PressedSparePartsButtonBy = @PressedSparePartsButtonBy,PressedSparePartsButtonBy_Id = @PressedSparePartsButtonBy_Id,Section_SpareParts = @Section_SpareParts Where Problem_Code = @Problem_Code"
            .Parameters.Clear()
            .Parameters.AddWithValue("@PressSparePartsButtonTime", SqlDbType.Date).Value = PressSparePartsButtonTime
            .Parameters.AddWithValue("@PressedSparePartsButtonBy", SqlDbType.VarChar).Value = PressedSparePartsButtonBy
            .Parameters.AddWithValue("@PressedSparePartsButtonBy_Id", SqlDbType.Int).Value = PressedSparePartsButtonBy_Id
            .Parameters.AddWithValue("@Section_SpareParts", SqlDbType.VarChar).Value = Section_SpareParts
            .Parameters.AddWithValue("@Problem_Code", SqlDbType.Int).Value = Problem_CodeW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        'MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub
    '======================================================================================================================
    ''''''''''''''''''''''''''''''''''''''''''''''''متغيرات Update_Estegaba'''''''''''''''''''''''''''''''''''''''''''''''''''
    '======================================================================================================================

    Public Sub Update_Tbl_MachineProblems_Time_EstegabaMentinance(ByVal MaintenanceTechnicianResponseTime As DateTime, ByVal MaintenanceResponseTechnician As String, ByVal MaintenanceResponseTechnician_ID As Int32, ByVal Problem_CodeW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_MachineProblems_Time Set MaintenanceTechnicianResponseTime = @MaintenanceTechnicianResponseTime,MaintenanceResponseTechnician = @MaintenanceResponseTechnician,MaintenanceResponseTechnician_ID = @MaintenanceResponseTechnician_ID Where Problem_Code = @Problem_Code"
            .Parameters.Clear()
            .Parameters.AddWithValue("@MaintenanceTechnicianResponseTime", SqlDbType.Date).Value = MaintenanceTechnicianResponseTime
            .Parameters.AddWithValue("@MaintenanceResponseTechnician", SqlDbType.VarChar).Value = MaintenanceResponseTechnician
            .Parameters.AddWithValue("@MaintenanceResponseTechnician_ID", SqlDbType.Int).Value = MaintenanceResponseTechnician_ID
            .Parameters.AddWithValue("@Problem_Code", SqlDbType.Int).Value = Problem_CodeW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        'MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Public Sub Update_Tbl_MachineProblems_Time_EstegabaKahraba(ByVal Response_time_to_electrical_fault As DateTime, ByVal Electrical_technician_name As String, ByVal Response_Electrical_Technician_ID As Int32, ByVal Problem_CodeW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_MachineProblems_Time Set Response_time_to_electrical_fault = @Response_time_to_electrical_fault,Electrical_technician_name = @Electrical_technician_name,Response_Electrical_Technician_ID = @Response_Electrical_Technician_ID Where Problem_Code = @Problem_Code"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Response_time_to_electrical_fault", SqlDbType.Date).Value = Response_time_to_electrical_fault
            .Parameters.AddWithValue("@Electrical_technician_name", SqlDbType.VarChar).Value = Electrical_technician_name
            .Parameters.AddWithValue("@Response_Electrical_Technician_ID", SqlDbType.Int).Value = Response_Electrical_Technician_ID
            .Parameters.AddWithValue("@Problem_Code", SqlDbType.Int).Value = Problem_CodeW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        'MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Public Sub Update_Tbl_MachineProblems_Time_EstegabaMawad(ByVal RawMaterialsTechnicianResponseTime As DateTime, ByVal RawMaterialsResponseTechnician As String, ByVal RawMaterialsResponseTechnician_ID As Int32, ByVal Problem_CodeW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_MachineProblems_Time Set RawMaterialsTechnicianResponseTime = @RawMaterialsTechnicianResponseTime,RawMaterialsResponseTechnician = @RawMaterialsResponseTechnician,RawMaterialsResponseTechnician_ID = @RawMaterialsResponseTechnician_ID Where Problem_Code = @Problem_Code"
            .Parameters.Clear()
            .Parameters.AddWithValue("@RawMaterialsTechnicianResponseTime", SqlDbType.Date).Value = RawMaterialsTechnicianResponseTime
            .Parameters.AddWithValue("@RawMaterialsResponseTechnician", SqlDbType.VarChar).Value = RawMaterialsResponseTechnician
            .Parameters.AddWithValue("@RawMaterialsResponseTechnician_ID", SqlDbType.Int).Value = RawMaterialsResponseTechnician_ID
            .Parameters.AddWithValue("@Problem_Code", SqlDbType.Int).Value = Problem_CodeW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        'MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Public Sub Update_Tbl_MachineProblems_Time_EstegabaQuality(ByVal QualityTechnicianResponseTime As DateTime, ByVal QualityResponseTechnician As String, ByVal QualityResponseTechnician_ID As Int32, ByVal Problem_CodeW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_MachineProblems_Time Set QualityTechnicianResponseTime = @QualityTechnicianResponseTime,QualityResponseTechnician = @QualityResponseTechnician,QualityResponseTechnician_ID = @QualityResponseTechnician_ID Where Problem_Code = @Problem_Code"
            .Parameters.Clear()
            .Parameters.AddWithValue("@QualityTechnicianResponseTime", SqlDbType.Date).Value = QualityTechnicianResponseTime
            .Parameters.AddWithValue("@QualityResponseTechnician", SqlDbType.VarChar).Value = QualityResponseTechnician
            .Parameters.AddWithValue("@QualityResponseTechnician_ID", SqlDbType.Int).Value = QualityResponseTechnician_ID
            .Parameters.AddWithValue("@Problem_Code", SqlDbType.Int).Value = Problem_CodeW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        'MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Public Sub Update_Tbl_MachineProblems_Time_EstegabaProduction(ByVal ProductionTechnicianResponseTime As DateTime, ByVal ProductionResponseTechnician As String, ByVal ProductionResponseTechnician_Id As Int32, ByVal Problem_CodeW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_MachineProblems_Time Set ProductionTechnicianResponseTime = @ProductionTechnicianResponseTime,ProductionResponseTechnician = @ProductionResponseTechnician,ProductionResponseTechnician_Id = @ProductionResponseTechnician_Id Where Problem_Code = @Problem_Code"
            .Parameters.Clear()
            .Parameters.AddWithValue("@ProductionTechnicianResponseTime", SqlDbType.Date).Value = ProductionTechnicianResponseTime
            .Parameters.AddWithValue("@ProductionResponseTechnician", SqlDbType.VarChar).Value = ProductionResponseTechnician
            .Parameters.AddWithValue("@ProductionResponseTechnician_Id", SqlDbType.Int).Value = ProductionResponseTechnician_Id
            .Parameters.AddWithValue("@Problem_Code", SqlDbType.Int).Value = Problem_CodeW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        'MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Public Sub Update_Tbl_MachineProblems_Time_EstegabaSpareParts(ByVal SparePartsTechnicianResponseTime As DateTime, ByVal SparePartsResponseTechnician As String, ByVal SparePartsResponseTechnician_ID As Int32, ByVal Problem_CodeW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_MachineProblems_Time Set SparePartsTechnicianResponseTime = @SparePartsTechnicianResponseTime,SparePartsResponseTechnician = @SparePartsResponseTechnician,SparePartsResponseTechnician_ID = @SparePartsResponseTechnician_ID Where Problem_Code = @Problem_Code"
            .Parameters.AddWithValue("@SparePartsTechnicianResponseTime", SqlDbType.Date).Value = SparePartsTechnicianResponseTime
            .Parameters.AddWithValue("@SparePartsResponseTechnician", SqlDbType.VarChar).Value = SparePartsResponseTechnician
            .Parameters.AddWithValue("@SparePartsResponseTechnician_ID", SqlDbType.Int).Value = SparePartsResponseTechnician_ID
            .Parameters.AddWithValue("@Problem_Code", SqlDbType.Int).Value = Problem_CodeW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        'MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub
    '======================================================================================================================
    ''''''''''''''''''''''''''''''''''''''''''''''''متغيرات Update_Fix'''''''''''''''''''''''''''''''''''''''''''''''''''
    '======================================================================================================================

    Public Sub Update_Tbl_MachineProblems_TimeFixMentinance(ByVal MaintenanceResolutionTime As DateTime, ByVal MaintenanceResolutionTechnician As String, ByVal MaintenanceResolutionTechnician_ID As Int32, ByVal Problem_CodeW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_MachineProblems_Time Set MaintenanceResolutionTime = @MaintenanceResolutionTime,MaintenanceResolutionTechnician = @MaintenanceResolutionTechnician,MaintenanceResolutionTechnician_ID = @MaintenanceResolutionTechnician_ID Where Problem_Code = @Problem_Code"
            .Parameters.Clear()
            .Parameters.AddWithValue("@MaintenanceResolutionTime", SqlDbType.Date).Value = MaintenanceResolutionTime
            .Parameters.AddWithValue("@MaintenanceResolutionTechnician", SqlDbType.VarChar).Value = MaintenanceResolutionTechnician
            .Parameters.AddWithValue("@MaintenanceResolutionTechnician_ID", SqlDbType.Int).Value = MaintenanceResolutionTechnician_ID
            .Parameters.AddWithValue("@Problem_Code", SqlDbType.Int).Value = Problem_CodeW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        'MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Public Sub Update_Tbl_MachineProblems_Time_FixKahraba(ByVal Time_Solve_Power_Malfunction As DateTime, ByVal Electrician_Who_Solved_Problem As String, ByVal Electrician_Who_Solved_Problem_ID As Int32, ByVal Problem_CodeW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_MachineProblems_Time Set Time_Solve_Power_Malfunction = @Time_Solve_Power_Malfunction,Electrician_Who_Solved_Problem = @Electrician_Who_Solved_Problem,Electrician_Who_Solved_Problem_ID = @Electrician_Who_Solved_Problem_ID Where Problem_Code = @Problem_Code"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Time_Solve_Power_Malfunction", SqlDbType.Date).Value = Time_Solve_Power_Malfunction
            .Parameters.AddWithValue("@Electrician_Who_Solved_Problem", SqlDbType.VarChar).Value = Electrician_Who_Solved_Problem
            .Parameters.AddWithValue("@Electrician_Who_Solved_Problem_ID", SqlDbType.Int).Value = Electrician_Who_Solved_Problem_ID
            .Parameters.AddWithValue("@Problem_Code", SqlDbType.Int).Value = Problem_CodeW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        'MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Public Sub Update_Tbl_MachineProblems_Time_FixQuality(ByVal QualityResolutionTime As DateTime, ByVal QualityResolutionTechnician As String, ByVal QualityResolutionTechnician_ID As Int32, ByVal Problem_CodeW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_MachineProblems_Time Set QualityResolutionTime = @QualityResolutionTime,QualityResolutionTechnician = @QualityResolutionTechnician,QualityResolutionTechnician_ID = @QualityResolutionTechnician_ID Where Problem_Code = @Problem_Code"
            .Parameters.Clear()
            .Parameters.AddWithValue("@QualityResolutionTime", SqlDbType.Date).Value = QualityResolutionTime
            .Parameters.AddWithValue("@QualityResolutionTechnician", SqlDbType.VarChar).Value = QualityResolutionTechnician
            .Parameters.AddWithValue("@QualityResolutionTechnician_ID", SqlDbType.Int).Value = QualityResolutionTechnician_ID
            .Parameters.AddWithValue("@Problem_Code", SqlDbType.Int).Value = Problem_CodeW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        'MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Public Sub Update_Tbl_MachineProblems_Time_FixMawad(ByVal RawMaterialsResolutionTime As DateTime, ByVal RawMaterialsResolutionTechnician As String, ByVal RawMaterialsResolutionTechnician_ID As Int32, ByVal Problem_CodeW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_MachineProblems_Time Set RawMaterialsResolutionTime = @RawMaterialsResolutionTime,RawMaterialsResolutionTechnician = @RawMaterialsResolutionTechnician,RawMaterialsResolutionTechnician_ID = @RawMaterialsResolutionTechnician_ID Where Problem_Code = @Problem_Code"
            .Parameters.Clear()
            .Parameters.AddWithValue("@RawMaterialsResolutionTime", SqlDbType.Date).Value = RawMaterialsResolutionTime
            .Parameters.AddWithValue("@RawMaterialsResolutionTechnician", SqlDbType.VarChar).Value = RawMaterialsResolutionTechnician
            .Parameters.AddWithValue("@RawMaterialsResolutionTechnician_ID", SqlDbType.Int).Value = RawMaterialsResolutionTechnician_ID
            .Parameters.AddWithValue("@Problem_Code", SqlDbType.Int).Value = Problem_CodeW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        'MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Public Sub Update_Tbl_MachineProblems_Time_FixProduction(ByVal ProductionResolutionTime As DateTime, ByVal ProductionResolutionTechnician As String, ByVal ProductionResolutionTechnician_Id As Int32, ByVal Problem_CodeW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_MachineProblems_Time Set ProductionResolutionTime = @ProductionResolutionTime,ProductionResolutionTechnician = @ProductionResolutionTechnician,ProductionResolutionTechnician_Id = @ProductionResolutionTechnician_Id Where Problem_Code = @Problem_Code"
            .Parameters.Clear()
            .Parameters.AddWithValue("@ProductionResolutionTime", SqlDbType.Date).Value = ProductionResolutionTime
            .Parameters.AddWithValue("@ProductionResolutionTechnician", SqlDbType.VarChar).Value = ProductionResolutionTechnician
            .Parameters.AddWithValue("@ProductionResolutionTechnician_Id", SqlDbType.Int).Value = ProductionResolutionTechnician_Id
            .Parameters.AddWithValue("@Problem_Code", SqlDbType.Int).Value = Problem_CodeW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        'MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Public Sub Update_Tbl_MachineProblems_Time_FixSpareParts(ByVal SparePartsResolutionTime As DateTime, ByVal SparePartsResolutionTechnician As String, ByVal SparePartsResolutionTechnician_ID As Int32, ByVal Problem_CodeW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_MachineProblems_Time Set SparePartsResolutionTime = @SparePartsResolutionTime,SparePartsResolutionTechnician = @SparePartsResolutionTechnician,SparePartsResolutionTechnician_ID = @SparePartsResolutionTechnician_ID  Where Problem_Code = @Problem_Code"
            .Parameters.Clear()
            .Parameters.AddWithValue("@SparePartsResolutionTime", SqlDbType.Date).Value = SparePartsResolutionTime
            .Parameters.AddWithValue("@SparePartsResolutionTechnician", SqlDbType.VarChar).Value = SparePartsResolutionTechnician
            .Parameters.AddWithValue("@SparePartsResolutionTechnician_ID", SqlDbType.Int).Value = SparePartsResolutionTechnician_ID
            .Parameters.AddWithValue("@Problem_Code", SqlDbType.Int).Value = Problem_CodeW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        'MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub
    '======================================================================================================================
    ''''''''''''''''''''''''''''''''''''''''''''''''متغيرات Max_Estegaba''''''''''''''''''''''''''''''''''''''''''''''''''''
    '======================================================================================================================

    Public Function Max_Tbl_MachineProblems_Estegaba_Mentinance() As DateTime
        Dim maxDateTimeEstegaba_Mentinance As DateTime = DateTime.MinValue
        Try
            Using cmd As New SqlCommand("SELECT MAX(MaintenanceTechnicianResponseTime) FROM Tbl_MachineProblems_Time", Con)
                If Con.State = 1 Then Con.Close()
                Con.Open()
                Dim resultEstegaba_Mentinance = cmd.ExecuteScalar()
                If resultEstegaba_Mentinance IsNot DBNull.Value Then
                    maxDateTimeEstegaba_Mentinance = Convert.ToDateTime(resultEstegaba_Mentinance)
                End If
            End Using
        Catch ex As Exception
            ' يمكنك إضافة رمز للتعامل مع الاستثناء هنا
        End Try
        Return maxDateTimeEstegaba_Mentinance
    End Function

    Public Function Max_Tbl_MachineProblems_Estegaba_Kahraba() As DateTime
        Dim maxDateTimeEstegaba_Kahraba As DateTime = DateTime.MinValue
        Try
            Using cmd As New SqlCommand("SELECT MAX(Response_time_to_electrical_fault) FROM Tbl_MachineProblems_Time", Con)
                If Con.State = 1 Then Con.Close()
                Con.Open()
                Dim resultEstegaba_Kahraba = cmd.ExecuteScalar()
                If resultEstegaba_Kahraba IsNot DBNull.Value Then
                    maxDateTimeEstegaba_Kahraba = Convert.ToDateTime(resultEstegaba_Kahraba)
                End If
            End Using
        Catch ex As Exception
            ' يمكنك إضافة رمز للتعامل مع الاستثناء هنا
        End Try
        Return maxDateTimeEstegaba_Kahraba
    End Function

    Public Function Max_Tbl_MachineProblems_Estegaba_Mawad() As DateTime
        Dim maxDateTimeEstegaba_Mawad As DateTime = DateTime.MinValue
        Try
            Using cmd As New SqlCommand("SELECT MAX(RawMaterialsTechnicianResponseTime) FROM Tbl_MachineProblems_Time", Con)
                If Con.State = 1 Then Con.Close()
                Con.Open()
                Dim resultEstegaba_Mawad = cmd.ExecuteScalar()
                If resultEstegaba_Mawad IsNot DBNull.Value Then
                    maxDateTimeEstegaba_Mawad = Convert.ToDateTime(resultEstegaba_Mawad)
                End If
            End Using
        Catch ex As Exception
            ' يمكنك إضافة رمز للتعامل مع الاستثناء هنا
        End Try
        Return maxDateTimeEstegaba_Mawad
    End Function

    Public Function Max_Tbl_MachineProblems_Estegaba_Quality() As DateTime
        Dim maxDateTimeEstegaba_Quality As DateTime = DateTime.MinValue
        Try
            Using cmd As New SqlCommand("SELECT MAX(QualityTechnicianResponseTime) FROM Tbl_MachineProblems_Time", Con)
                If Con.State = 1 Then Con.Close()
                Con.Open()
                Dim resultEstegaba_Quality = cmd.ExecuteScalar()
                If resultEstegaba_Quality IsNot DBNull.Value Then
                    maxDateTimeEstegaba_Quality = Convert.ToDateTime(resultEstegaba_Quality)
                End If
            End Using
        Catch ex As Exception
            ' يمكنك إضافة رمز للتعامل مع الاستثناء هنا
        End Try
        Return maxDateTimeEstegaba_Quality
    End Function

    Public Function Max_Tbl_MachineProblems_Estegaba_Production() As DateTime
        Dim maxDateTimeEstegaba_Production As DateTime = DateTime.MinValue
        Try
            Using cmd As New SqlCommand("SELECT MAX(ProductionTechnicianResponseTime) FROM Tbl_MachineProblems_Time", Con)
                If Con.State = 1 Then Con.Close()
                Con.Open()
                Dim resultEstegaba_Production = cmd.ExecuteScalar()
                If resultEstegaba_Production IsNot DBNull.Value Then
                    maxDateTimeEstegaba_Production = Convert.ToDateTime(resultEstegaba_Production)
                End If
            End Using
        Catch ex As Exception
            ' يمكنك إضافة رمز للتعامل مع الاستثناء هنا
        End Try
        Return maxDateTimeEstegaba_Production
    End Function

    Public Function Max_Tbl_MachineProblems_Estegaba_SpareParts() As DateTime
        Dim maxDateTimeEstegaba_SpareParts As DateTime = DateTime.MinValue
        Try
            Using cmd As New SqlCommand("SELECT MAX(SparePartsTechnicianResponseTime) FROM Tbl_MachineProblems_Time", Con)
                If Con.State = 1 Then Con.Close()
                Con.Open()
                Dim resultEstegaba_SpareParts = cmd.ExecuteScalar()
                If resultEstegaba_SpareParts IsNot DBNull.Value Then
                    maxDateTimeEstegaba_SpareParts = Convert.ToDateTime(resultEstegaba_SpareParts)
                End If
            End Using
        Catch ex As Exception
            ' يمكنك إضافة رمز للتعامل مع الاستثناء هنا
        End Try
        Return maxDateTimeEstegaba_SpareParts
    End Function
    '======================================================================================================================
    ''''''''''''''''''''''''''''''''''''''''''''''''متغيرات Max_End_Fix''''''''''''''''''''''''''''''''''''''''''''''''''''
    '======================================================================================================================

    Public Function Max_Tbl_MachineProblems_End_Fix_Mentinance() As DateTime
        Dim maxDateTime_Fix_Maintenance As DateTime = DateTime.MinValue
        Try
            Using cmd As New SqlCommand("SELECT MAX(MaintenanceResolutionTime) FROM Tbl_MachineProblems_Time", Con)
                If Con.State = 1 Then Con.Close()
                Con.Open()
                Dim result_End_Fix_Maintenance = cmd.ExecuteScalar()
                If result_End_Fix_Maintenance IsNot DBNull.Value Then
                    maxDateTime_Fix_Maintenance = Convert.ToDateTime(result_End_Fix_Maintenance)
                End If
            End Using
        Catch ex As Exception
            ' يمكنك إضافة رمز للتعامل مع الاستثناء هنا
        End Try
        Return maxDateTime_Fix_Maintenance
    End Function

    Public Function Max_Tbl_MachineProblems_End_Fix_Kahraba() As DateTime
        Dim maxDateTime_Fix_Kahraba As DateTime = DateTime.MinValue
        Try
            Using cmd As New SqlCommand("SELECT MAX(Response_time_to_electrical_fault) FROM Tbl_MachineProblems_Time", Con)
                If Con.State = 1 Then Con.Close()
                Con.Open()
                Dim result_End_Fix_Kahraba = cmd.ExecuteScalar()
                If result_End_Fix_Kahraba IsNot DBNull.Value Then
                    maxDateTime_Fix_Kahraba = Convert.ToDateTime(result_End_Fix_Kahraba)
                End If
            End Using
        Catch ex As Exception
            ' يمكنك إضافة رمز للتعامل مع الاستثناء هنا
        End Try
        Return maxDateTime_Fix_Kahraba
    End Function

    Public Function Max_Tbl_MachineProblems_End_Fix_Mawad() As DateTime
        Dim maxDateTime_Fix_Mawad As DateTime = DateTime.MinValue
        Try
            Using cmd As New SqlCommand("SELECT MAX(RawMaterialsResolutionTime) FROM Tbl_MachineProblems_Time", Con)
                If Con.State = 1 Then Con.Close()
                Con.Open()
                Dim result_End_Fix_Mawad = cmd.ExecuteScalar()
                If result_End_Fix_Mawad IsNot DBNull.Value Then
                    maxDateTime_Fix_Mawad = Convert.ToDateTime(result_End_Fix_Mawad)
                End If
            End Using
        Catch ex As Exception
            ' يمكنك إضافة رمز للتعامل مع الاستثناء هنا
        End Try
        Return maxDateTime_Fix_Mawad
    End Function

    Public Function Max_Tbl_MachineProblems_End_Fix_Quality() As DateTime
        Dim maxDateTime_Fix_Quality As DateTime = DateTime.MinValue
        Try
            Using cmd As New SqlCommand("SELECT MAX(QualityResolutionTime) FROM Tbl_MachineProblems_Time", Con)
                If Con.State = 1 Then Con.Close()
                Con.Open()
                Dim result_End_Fix_Quality = cmd.ExecuteScalar()
                If result_End_Fix_Quality IsNot DBNull.Value Then
                    maxDateTime_Fix_Quality = Convert.ToDateTime(result_End_Fix_Quality)
                End If
            End Using
        Catch ex As Exception
            ' يمكنك إضافة رمز للتعامل مع الاستثناء هنا
        End Try
        Return maxDateTime_Fix_Quality
    End Function

    Public Function Max_Tbl_MachineProblems_End_Fix_Production() As DateTime
        Dim maxDateTime_Fix_Production As DateTime = DateTime.MinValue
        Try
            Using cmd As New SqlCommand("SELECT MAX(ProductionResolutionTime) FROM Tbl_MachineProblems_Time", Con)
                If Con.State = 1 Then Con.Close()
                Con.Open()
                Dim result_End_Fix_Production = cmd.ExecuteScalar()
                If result_End_Fix_Production IsNot DBNull.Value Then
                    maxDateTime_Fix_Production = Convert.ToDateTime(result_End_Fix_Production)
                End If
            End Using
        Catch ex As Exception
            ' يمكنك إضافة رمز للتعامل مع الاستثناء هنا
        End Try
        Return maxDateTime_Fix_Production
    End Function

    Public Function Max_Tbl_MachineProblems_End_Fix_SpareParts() As DateTime
        Dim maxDateTime_Fix_SpareParts As DateTime = DateTime.MinValue
        Try
            Using cmd As New SqlCommand("SELECT MAX(SparePartsResolutionTime) FROM Tbl_MachineProblems_Time", Con)
                If Con.State = 1 Then Con.Close()
                Con.Open()
                Dim result_End_Fix_SpareParts = cmd.ExecuteScalar()
                If result_End_Fix_SpareParts IsNot DBNull.Value Then
                    maxDateTime_Fix_SpareParts = Convert.ToDateTime(result_End_Fix_SpareParts)
                End If
            End Using
        Catch ex As Exception
            ' يمكنك إضافة رمز للتعامل مع الاستثناء هنا
        End Try
        Return maxDateTime_Fix_SpareParts
    End Function
    '======================================================================================================================
    ''''''''''''''''''''''''''''''''''''''''''''''''متغيرات Max_Department'''''''''''''''''''''''''''''''''''''''''''''''''
    '======================================================================================================================

    Public Function Max_Tbl_MachineProblems_Time_Department_Maintenance() As String
        Dim Number As String
        Try
            Dim cmd As New SqlCommand("SELECT Max(Section_Maintenance) FROM Tbl_MachineProblems_Time WHERE Problem_Code = @Problem_Code", Con)
            cmd.Parameters.AddWithValue("@Problem_Code", Txt_Code_Proplem_Show.Text)
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Number = cmd.ExecuteScalar
            Con.Close()
        Catch ex As Exception
            Number = ""
            Con.Close()
        End Try
        Return Number
    End Function

    Public Function Max_Tbl_MachineProblems_Time_Department_Kharaba() As String
        Dim Number As String
        Try
            Dim cmd As New SqlCommand("SELECT Max(Electricity_Department) FROM Tbl_MachineProblems_Time WHERE Problem_Code = @Problem_Code", Con)
            cmd.Parameters.AddWithValue("@Problem_Code", Txt_Code_Proplem_Show.Text)
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Number = cmd.ExecuteScalar
            Con.Close()
        Catch ex As Exception
            Number = ""
            Con.Close()
        End Try
        Return Number
    End Function

    Public Function Max_Tbl_MachineProblems_Time_Department_Mawad() As String
        Dim Number As String
        Try
            Dim cmd As New SqlCommand("SELECT Max(Section_RawMaterials) FROM Tbl_MachineProblems_Time WHERE Problem_Code = @Problem_Code", Con)
            cmd.Parameters.AddWithValue("@Problem_Code", Txt_Code_Proplem_Show.Text)
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Number = cmd.ExecuteScalar
            Con.Close()
        Catch ex As Exception
            Number = ""
            Con.Close()
        End Try
        Return Number
    End Function

    Public Function Max_Tbl_MachineProblems_Time_Department_Quality() As String
        Dim Number As String
        Try
            Dim cmd As New SqlCommand("SELECT Max(Section_Quality) FROM Tbl_MachineProblems_Time WHERE Problem_Code = @Problem_Code", Con)
            cmd.Parameters.AddWithValue("@Problem_Code", Txt_Code_Proplem_Show.Text)
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Number = cmd.ExecuteScalar
            Con.Close()
        Catch ex As Exception
            Number = ""
            Con.Close()
        End Try
        Return Number
    End Function

    Public Function Max_Tbl_MachineProblems_Time_Department_Production() As String
        Dim Number As String
        Try
            Dim cmd As New SqlCommand("SELECT Max(Section_Production) FROM Tbl_MachineProblems_Time WHERE Problem_Code = @Problem_Code", Con)
            cmd.Parameters.AddWithValue("@Problem_Code", Txt_Code_Proplem_Show.Text)
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Number = cmd.ExecuteScalar
            Con.Close()
        Catch ex As Exception
            Number = ""
            Con.Close()
        End Try
        Return Number
    End Function

    Public Function Max_Tbl_MachineProblems_Time_Department_SpareParts() As String
        Dim Number As String
        Try
            Dim cmd As New SqlCommand("SELECT Max(Section_SpareParts) FROM Tbl_MachineProblems_Time WHERE Problem_Code = @Problem_Code", Con)
            cmd.Parameters.AddWithValue("@Problem_Code", Txt_Code_Proplem_Show.Text)
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Number = cmd.ExecuteScalar
            Con.Close()
        Catch ex As Exception
            Number = ""
            Con.Close()
        End Try
        Return Number
    End Function
    '======================================================================================================================
    ''''''''''''''''''''''''''''''''''''''''''''''''متغيرات Send Report'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '======================================================================================================================

    Public Sub Update_Tbl_MachineProblems_Time_Send_Report_Electricity(ByVal Electricity_Unit As String, ByVal Cause_Electricity_Malfunction As String, ByVal Power_malfunction_status As String, ByVal Notes_Electricity As String, ByVal Time_to_write_notes_electricity As DateTime, ByVal Who_wrote_the_electricity_notes As String, ByVal Who_wrote_the_electricity_notes_ID As Int32, ByVal Problem_CodeW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_MachineProblems_Time Set Electricity_Unit = @Electricity_Unit,Cause_Electricity_Malfunction = @Cause_Electricity_Malfunction,Power_malfunction_status = @Power_malfunction_status,Notes_Electricity = @Notes_Electricity,Time_to_write_notes_electricity = @Time_to_write_notes_electricity,Who_wrote_the_electricity_notes = @Who_wrote_the_electricity_notes,Who_wrote_the_electricity_notes_ID = @Who_wrote_the_electricity_notes_ID Where Problem_Code = @Problem_Code"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Electricity_Unit", SqlDbType.VarChar).Value = Electricity_Unit
            .Parameters.AddWithValue("@Cause_Electricity_Malfunction", SqlDbType.VarChar).Value = Cause_Electricity_Malfunction
            .Parameters.AddWithValue("@Power_malfunction_status", SqlDbType.VarChar).Value = Power_malfunction_status
            .Parameters.AddWithValue("@Notes_Electricity", SqlDbType.VarChar).Value = Notes_Electricity
            .Parameters.AddWithValue("@Time_to_write_notes_electricity", SqlDbType.Date).Value = Time_to_write_notes_electricity
            .Parameters.AddWithValue("@Who_wrote_the_electricity_notes", SqlDbType.VarChar).Value = Who_wrote_the_electricity_notes
            .Parameters.AddWithValue("@Who_wrote_the_electricity_notes_ID", SqlDbType.Int).Value = Who_wrote_the_electricity_notes_ID
            .Parameters.AddWithValue("@Problem_Code", SqlDbType.Int).Value = Problem_CodeW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        'MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        'Update_Tbl_MachineProblems_Time_Send_Report_Electricity(Combo_Unit.Text, Combo_Cause_Malfunction.Text, Combo_FailureSituation.Text, Txt_Notes.Text, DateTime.Parse(Txt_Time.Text), username, UserID, ProblemCode.Text)

        Cmd = Nothing
    End Sub

    Public Sub Update_Tbl_MachineProblems_Time_Send_Report_Maintenance(ByVal MalfunctionUnit_Maintenance As String, ByVal MalfunctionPart_Maintenance As String, ByVal FailureCondition_Maintenance As String, ByVal MaintenanceNotes As String, ByVal WriteNotesTime_Maintenance As DateTime, ByVal NotesAuthor_Maintenance As String, ByVal NotesAuthor_Maintenance_ID As Int32, ByVal Problem_CodeW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_MachineProblems_Time Set MalfunctionUnit_Maintenance = @MalfunctionUnit_Maintenance,MalfunctionPart_Maintenance = @MalfunctionPart_Maintenance,FailureCondition_Maintenance = @FailureCondition_Maintenance,MaintenanceNotes = @MaintenanceNotes,WriteNotesTime_Maintenance = @WriteNotesTime_Maintenance,NotesAuthor_Maintenance = @NotesAuthor_Maintenance,NotesAuthor_Maintenance_ID = @NotesAuthor_Maintenance_ID Where Problem_Code = @Problem_Code"
            .Parameters.Clear()
            .Parameters.AddWithValue("@MalfunctionUnit_Maintenance", SqlDbType.VarChar).Value = MalfunctionUnit_Maintenance
            .Parameters.AddWithValue("@MalfunctionPart_Maintenance", SqlDbType.VarChar).Value = MalfunctionPart_Maintenance
            .Parameters.AddWithValue("@FailureCondition_Maintenance", SqlDbType.VarChar).Value = FailureCondition_Maintenance
            .Parameters.AddWithValue("@MaintenanceNotes", SqlDbType.VarChar).Value = MaintenanceNotes
            .Parameters.AddWithValue("@WriteNotesTime_Maintenance", SqlDbType.Date).Value = WriteNotesTime_Maintenance
            .Parameters.AddWithValue("@NotesAuthor_Maintenance", SqlDbType.VarChar).Value = NotesAuthor_Maintenance
            .Parameters.AddWithValue("@NotesAuthor_Maintenance_ID", SqlDbType.Int).Value = NotesAuthor_Maintenance_ID
            .Parameters.AddWithValue("@Problem_Code", SqlDbType.Int).Value = Problem_CodeW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        'MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        'Update_Tbl_MachineProblems_Time_Send_Report_Maintenance(Combo_Unit.Text, Combo_Cause_Malfunction.Text, Combo_FailureSituation.Text, Txt_Notes.Text, DateTime.Parse(Txt_Time.Text), username, UserID, ProblemCode.Text)

        Cmd = Nothing
    End Sub

    Public Sub Update_Tbl_MachineProblems_Time_Send_Report_RawMaterials(ByVal FailureUnit_RawMaterials As String, ByVal FailurePart_RawMaterials As String, ByVal FailureCondition_RawMaterials As String, ByVal RawMaterialsNotes As String, ByVal WriteNotesTime_RawMaterials As DateTime, ByVal NotesAuthor_RawMaterials As String, ByVal NotesAuthor_RawMaterials_ID As Int32, ByVal Problem_CodeW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_MachineProblems_Time Set FailureUnit_RawMaterials = @FailureUnit_RawMaterials,FailurePart_RawMaterials = @FailurePart_RawMaterials,FailureCondition_RawMaterials = @FailureCondition_RawMaterials,RawMaterialsNotes = @RawMaterialsNotes,WriteNotesTime_RawMaterials = @WriteNotesTime_RawMaterials,NotesAuthor_RawMaterials = @NotesAuthor_RawMaterials,NotesAuthor_RawMaterials_ID = @NotesAuthor_RawMaterials_ID Where Problem_Code = @Problem_Code"
            .Parameters.Clear()
            .Parameters.AddWithValue("@FailureUnit_RawMaterials", SqlDbType.VarChar).Value = FailureUnit_RawMaterials
            .Parameters.AddWithValue("@FailurePart_RawMaterials", SqlDbType.VarChar).Value = FailurePart_RawMaterials
            .Parameters.AddWithValue("@FailureCondition_RawMaterials", SqlDbType.VarChar).Value = FailureCondition_RawMaterials
            .Parameters.AddWithValue("@RawMaterialsNotes", SqlDbType.VarChar).Value = RawMaterialsNotes
            .Parameters.AddWithValue("@WriteNotesTime_RawMaterials", SqlDbType.Date).Value = WriteNotesTime_RawMaterials
            .Parameters.AddWithValue("@NotesAuthor_RawMaterials", SqlDbType.VarChar).Value = NotesAuthor_RawMaterials
            .Parameters.AddWithValue("@NotesAuthor_RawMaterials_ID", SqlDbType.Int).Value = NotesAuthor_RawMaterials_ID
            .Parameters.AddWithValue("@Problem_Code", SqlDbType.Int).Value = Problem_CodeW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        'MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        'Update_Tbl_MachineProblems_Time_Send_Report_RawMaterials(Combo_Unit.Text, Combo_Cause_Malfunction.Text, Combo_FailureSituation.Text, Txt_Notes.Text, DateTime.Parse(Txt_Time.Text), username, UserID, ProblemCode.Text)

        Cmd = Nothing
    End Sub

    Public Sub Update_Tbl_MachineProblems_Time_Send_Report_Quality(ByVal MalfunctionUnit_Quality As String, ByVal PartFailure_Quality As String, ByVal QualityFailureCondition As String, ByVal QualityNotes As String, ByVal WriteNotesTime_Quality As DateTime, ByVal NotesAuthor_Quality As String, ByVal NotesAuthor_Quality_ID As Int32, ByVal Problem_CodeW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_MachineProblems_Time Set MalfunctionUnit_Quality = @MalfunctionUnit_Quality,PartFailure_Quality = @PartFailure_Quality,QualityFailureCondition = @QualityFailureCondition,QualityNotes = @QualityNotes,WriteNotesTime_Quality = @WriteNotesTime_Quality,NotesAuthor_Quality = @NotesAuthor_Quality,NotesAuthor_Quality_ID = @NotesAuthor_Quality_ID Where Problem_Code = @Problem_Code"
            .Parameters.Clear()
            .Parameters.AddWithValue("@MalfunctionUnit_Quality", SqlDbType.VarChar).Value = MalfunctionUnit_Quality
            .Parameters.AddWithValue("@PartFailure_Quality", SqlDbType.VarChar).Value = PartFailure_Quality
            .Parameters.AddWithValue("@QualityFailureCondition", SqlDbType.VarChar).Value = QualityFailureCondition
            .Parameters.AddWithValue("@QualityNotes", SqlDbType.VarChar).Value = QualityNotes
            .Parameters.AddWithValue("@WriteNotesTime_Quality", SqlDbType.Date).Value = WriteNotesTime_Quality
            .Parameters.AddWithValue("@NotesAuthor_Quality", SqlDbType.VarChar).Value = NotesAuthor_Quality
            .Parameters.AddWithValue("@NotesAuthor_Quality_ID", SqlDbType.Int).Value = NotesAuthor_Quality_ID
            .Parameters.AddWithValue("@Problem_Code", SqlDbType.Int).Value = Problem_CodeW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        'MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        'Update_Tbl_MachineProblems_Time_Send_Report_Quality(Combo_Unit.Text, Combo_Cause_Malfunction.Text, Combo_FailureSituation.Text, Txt_Notes.Text, DateTime.Parse(Txt_Time.Text), username, UserID, ProblemCode.Text)

        Cmd = Nothing
    End Sub

    Public Sub Update_Tbl_MachineProblems_Time_Send_Report_Production(ByVal BreakdownUnit_Production As String, ByVal FailurePartForProduction As String, ByVal ProductionFailureSituation As String, ByVal ProductionNotes As String, ByVal WriteNotesTime_Production As DateTime, ByVal NotesAuthor_Production As String, ByVal NotesAuthor_Production_ID As Int32, ByVal Problem_CodeW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_MachineProblems_Time Set BreakdownUnit_Production = @BreakdownUnit_Production,FailurePartForProduction = @FailurePartForProduction,ProductionFailureSituation = @ProductionFailureSituation,ProductionNotes = @ProductionNotes,WriteNotesTime_Production = @WriteNotesTime_Production,NotesAuthor_Production = @NotesAuthor_Production,NotesAuthor_Production_ID = @NotesAuthor_Production_ID Where Problem_Code = @Problem_Code"
            .Parameters.Clear()
            .Parameters.AddWithValue("@BreakdownUnit_Production", SqlDbType.VarChar).Value = BreakdownUnit_Production
            .Parameters.AddWithValue("@FailurePartForProduction", SqlDbType.VarChar).Value = FailurePartForProduction
            .Parameters.AddWithValue("@ProductionFailureSituation", SqlDbType.VarChar).Value = ProductionFailureSituation
            .Parameters.AddWithValue("@ProductionNotes", SqlDbType.VarChar).Value = ProductionNotes
            .Parameters.AddWithValue("@WriteNotesTime_Production", SqlDbType.Date).Value = WriteNotesTime_Production
            .Parameters.AddWithValue("@NotesAuthor_Production", SqlDbType.VarChar).Value = NotesAuthor_Production
            .Parameters.AddWithValue("@NotesAuthor_Production_ID", SqlDbType.Int).Value = NotesAuthor_Production_ID
            .Parameters.AddWithValue("@Problem_Code", SqlDbType.Int).Value = Problem_CodeW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        'MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        'Update_Tbl_MachineProblems_Time_Send_Report_Production(Combo_Unit.Text, Combo_Cause_Malfunction.Text, Combo_FailureSituation.Text, Txt_Notes.Text, DateTime.Parse(Txt_Time.Text), username, UserID, ProblemCode.Text)

        Cmd = Nothing
    End Sub

    Public Sub Update_Tbl_MachineProblems_Time_Send_Report_SpareParts(ByVal BreakdownUnit_SpareParts As String, ByVal FailurePartForSpareParts As String, ByVal SparePartsFailure As String, ByVal SparePartsNotes As String, ByVal WriteNotesTime_SpareParts As DateTime, ByVal NotesAuthor_SpareParts As String, ByVal NotesAuthor_SpareParts_ID As Int32, ByVal Problem_CodeW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_MachineProblems_Time Set BreakdownUnit_SpareParts = @BreakdownUnit_SpareParts,FailurePartForSpareParts = @FailurePartForSpareParts,SparePartsFailure = @SparePartsFailure,SparePartsNotes = @SparePartsNotes,WriteNotesTime_SpareParts = @WriteNotesTime_SpareParts,NotesAuthor_SpareParts = @NotesAuthor_SpareParts,NotesAuthor_SpareParts_ID = @NotesAuthor_SpareParts_ID Where Problem_Code = @Problem_Code"
            .Parameters.Clear()
            .Parameters.AddWithValue("@BreakdownUnit_SpareParts", SqlDbType.VarChar).Value = BreakdownUnit_SpareParts
            .Parameters.AddWithValue("@FailurePartForSpareParts", SqlDbType.VarChar).Value = FailurePartForSpareParts
            .Parameters.AddWithValue("@SparePartsFailure", SqlDbType.VarChar).Value = SparePartsFailure
            .Parameters.AddWithValue("@SparePartsNotes", SqlDbType.VarChar).Value = SparePartsNotes
            .Parameters.AddWithValue("@WriteNotesTime_SpareParts", SqlDbType.Date).Value = WriteNotesTime_SpareParts
            .Parameters.AddWithValue("@NotesAuthor_SpareParts", SqlDbType.VarChar).Value = NotesAuthor_SpareParts
            .Parameters.AddWithValue("@NotesAuthor_SpareParts_ID", SqlDbType.Int).Value = NotesAuthor_SpareParts_ID
            .Parameters.AddWithValue("@Problem_Code", SqlDbType.Int).Value = Problem_CodeW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        'MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        'Update_Tbl_MachineProblems_Time_Send_Report_SpareParts(Combo_Unit.Text, Combo_Cause_Malfunction.Text, Combo_FailureSituation.Text, Txt_Notes.Text, DateTime.Parse(Txt_Time.Text), username, UserID, ProblemCode.Text)

        Cmd = Nothing
    End Sub
    '======================================================================================================================
    Public Sub Update_Tbl_MachineProblems_Time_Run_Machine(ByVal FinalMachineRunningTime As DateTime, ByVal Problem_CodeW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_MachineProblems_Time Set FinalMachineRunningTime = @FinalMachineRunningTime Where Problem_Code = @Problem_Code"
            .Parameters.Clear()
            .Parameters.AddWithValue("@FinalMachineRunningTime", SqlDbType.Date).Value = FinalMachineRunningTime
            .Parameters.AddWithValue("@Problem_Code", SqlDbType.Int).Value = Problem_CodeW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        Cmd = Nothing
    End Sub
    '======================================================================================================================

    Private Sub Btn_Alarm_Mentinance_Click(sender As Object, e As EventArgs) Handles Btn_Alarm_Mentinance.Click
        Me.Btn_Alarm_Mentinance.Visible = False
        Me.Lbl_Alarm_Mentinance.Visible = True
        Me.Txt_Alarm_Mentinance_password.Visible = True
        Me.Txt_Alarm_Mentinance_password.Focus()
    End Sub

    Private Sub Btn_Estgaba_Mentinance_Click(sender As Object, e As EventArgs) Handles Btn_Estgaba_Mentinance.Click
        Me.Lbl_Estgaba_Mentinance.Visible = True
        Me.Txt_Estgaba_Mentinance_password.Visible = True
        Me.Btn_Estgaba_Mentinance.Visible = False
        Me.Txt_Estgaba_Mentinance_password.Focus()
    End Sub

    Private Sub Txt_Estgaba_Mentinance_password_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Estgaba_Mentinance_password.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' الحصول على قيمة الرقم السري المدخل
            Dim enteredPassword As String = Txt_Estgaba_Mentinance_password.Text.Trim()

            ' الاتصال بقاعدة البيانات وتنفيذ الاستعلام
            'Dim connectionString As String = "Your_Connection_String_Here"
            Using con As New SqlConnection(ConStr)
                If con.State = 1 Then con.Close()
                con.Open()

                ' استعلام للتحقق من وجود الرقم السري في جدول المستخدمين
                Dim query As String = "SELECT * FROM Users WHERE Password = @EnteredPassword"
                Using command As New SqlCommand(query, con)
                    command.Parameters.AddWithValue("@EnteredPassword", enteredPassword)

                    ' قراءة البيانات المسترجعة من الاستعلام
                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            ' الرقم السري صحيح
                            reader.Read()
                            Dim UserID As String = reader("UserID").ToString()
                            Dim username As String = reader("Username").ToString()
                            Dim job As String = reader("Jop").ToString()
                            Dim dept As String = reader("Dept").ToString()
                            Dim forms As String = reader("Forms").ToString()
                            Dim D1 As String = reader("D1").ToString()
                            Dim D2 As String = reader("D2").ToString()
                            Dim F1 As String = reader("F1").ToString()
                            Dim F2 As String = reader("F2").ToString()
                            Dim H As String = reader("H").ToString()
                            If (job = "فنى صيانة" OrElse job = "مدير الصيانة") And dept = "الصيانة" And D1 = "True" Then
                                ' الرقم السري صحيح ونوع الوظيفة مدير والقسم الصيانة والنموذج D1
                                Txt_User.Text = username ' عرض اسم المستخدم في Txt_User
                                ' القبول وعرض البيانات الإضافية
                                ' إضافة الكود الخاص بعرض البيانات وفتح الواجهة المناسبة
                                Me.Txt_Time.Text = Now
                                Update_Tbl_MachineProblems_Time_EstegabaMentinance(DateTime.Parse(Txt_Time.Text), username, UserID, ProblemCode.Text)
                                Me.Txt_Estgaba_Mentinance_password.Visible = False
                                Me.Txt_Estgaba_Mentinance_password.Text = ""
                                Me.Lbl_Estgaba_Mentinance.Visible = False
                                Me.Btn_Fix_Mentinance.Visible = True
                                'fillcmb_Tbl_Problem_Machine(Me.Combo_Unit)
                            Else
                                ' إذا لم تتطابق الشروط المطلوبة
                                MsgBox("لا يسمح لك بالوصول إلى هذا التطبيق")
                                Me.Txt_Estgaba_Mentinance_password.Text = ""
                            End If
                        Else
                            ' الرقم السري غير صحيح
                            MsgBox("خطأ في الرقم السري")
                            Me.Txt_Estgaba_Mentinance_password.Text = ""
                        End If
                    End Using
                End Using
            End Using
        End If
    End Sub

    Private Sub Btn_Fix_Mentinance_Click(sender As Object, e As EventArgs) Handles Btn_Fix_Mentinance.Click
        Me.Btn_Fix_Mentinance.Visible = False
        Me.Lbl_Fix_Mentinance.Visible = True
        Me.Txt_Fix_Mentinance_Password.Visible = True
        Me.Txt_Fix_Mentinance_Password.Focus()
    End Sub

    Private Sub Txt_Fix_Mentinance_Password_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Fix_Mentinance_Password.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' الحصول على قيمة الرقم السري المدخل
            Dim enteredPassword As String = Txt_Fix_Mentinance_Password.Text.Trim()
            ' الاتصال بقاعدة البيانات وتنفيذ الاستعلام
            'Dim connectionString As String = "Your_Connection_String_Here"
            Using con As New SqlConnection(ConStr)
                If con.State = 1 Then con.Close()
                con.Open()
                ' استعلام للتحقق من وجود الرقم السري في جدول المستخدمين
                Dim query As String = "SELECT * FROM Users WHERE Password = @EnteredPassword"
                Using command As New SqlCommand(query, con)
                    command.Parameters.AddWithValue("@EnteredPassword", enteredPassword)

                    ' قراءة البيانات المسترجعة من الاستعلام
                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            ' الرقم السري صحيح
                            reader.Read()
                            Dim UserID As String = reader("UserID").ToString()
                            Dim username As String = reader("Username").ToString()
                            Dim job As String = reader("Jop").ToString()
                            Dim dept As String = reader("Dept").ToString()
                            Dim forms As String = reader("Forms").ToString()
                            Dim D1 As String = reader("D1").ToString()
                            Dim D2 As String = reader("D2").ToString()
                            Dim F1 As String = reader("F1").ToString()
                            Dim F2 As String = reader("F2").ToString()
                            Dim H As String = reader("H").ToString()
                            If (job = "فنى صيانة" OrElse job = "مدير الصيانة") And dept = "الصيانة" And D1 = "True" Then
                                ' الرقم السري صحيح ونوع الوظيفة مدير والقسم الصيانة والنموذج D1
                                Txt_User.Text = username ' عرض اسم المستخدم في Txt_User
                                ' القبول وعرض البيانات الإضافية
                                ' إضافة الكود الخاص بعرض البيانات وفتح الواجهة المناسبة
                                Me.Txt_Time.Text = Now
                                Update_Tbl_MachineProblems_TimeFixMentinance(DateTime.Parse(Txt_Time.Text), username, UserID, ProblemCode.Text)
                                Me.Txt_Fix_Mentinance_Password.Visible = False
                                Me.Txt_Fix_Mentinance_Password.Text = ""
                                Me.Lbl_Fix_Mentinance.Visible = False
                                Me.Panel4.Visible = True
                                '''Me.Txt_Code_Proplem_Show.Text = Max_Tbl_MachineProblems_Time()
                                Me.Txt_Time_Stop_Machine_Show.Text = DateTime.Parse(Max_Tbl_MachineProblems_Time_Stop_Machine(ProblemCode.Text))
                                Me.Txt_Time_Start_Fix_Show.Text = DateTime.Parse(Max_Tbl_MachineProblems_Estegaba_Mentinance())
                                Me.Txt_Time_End_Fix_Show.Text = DateTime.Parse(Max_Tbl_MachineProblems_End_Fix_Mentinance())
                                Me.Txt_Department_Show.Text = Max_Tbl_MachineProblems_Time_Department_Maintenance()
                                'fillcmb_Tbl_Problem_Machine(Me.Combo_Unit)
                            Else
                                ' إذا لم تتطابق الشروط المطلوبة
                                MsgBox("لا يسمح لك بالوصول إلى هذا التطبيق")
                                Me.Txt_Fix_Mentinance_Password.Text = ""
                            End If
                        Else
                            ' الرقم السري غير صحيح
                            MsgBox("خطأ في الرقم السري")
                            Me.Txt_Fix_Mentinance_Password.Text = ""
                        End If
                    End Using
                End Using
            End Using
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub

    Private Sub Btn_Alarm_Mawad_Click(sender As Object, e As EventArgs) Handles Btn_Alarm_Mawad.Click
        Me.Btn_Alarm_Mawad.Visible = False
        Me.Lbl_Alarm_Mawad.Visible = True
        Me.Txt_Alarm_Mawad_password.Visible = True
        Me.Txt_Alarm_Mawad_password.Focus()
    End Sub

    Private Sub Btn_Estgaba_Mawad_Click(sender As Object, e As EventArgs) Handles Btn_Estgaba_Mawad.Click
        Me.Lbl_Estgaba_Mawad.Visible = True
        Me.Txt_Estgaba_Mawad_password.Visible = True
        Me.Btn_Estgaba_Mawad.Visible = False
        Me.Txt_Estgaba_Mawad_password.Focus()
    End Sub

    Private Sub Txt_Estgaba_Mawad_password_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Estgaba_Mawad_password.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' الحصول على قيمة الرقم السري المدخل
            Dim enteredPassword As String = Txt_Estgaba_Mawad_password.Text.Trim()

            ' الاتصال بقاعدة البيانات وتنفيذ الاستعلام
            'Dim connectionString As String = "Your_Connection_String_Here"
            Using con As New SqlConnection(ConStr)
                If con.State = 1 Then con.Close()
                con.Open()

                ' استعلام للتحقق من وجود الرقم السري في جدول المستخدمين
                Dim query As String = "SELECT  UserID, Username, Jop, Dept, Forms FROM Users WHERE Password = @EnteredPassword"
                Using command As New SqlCommand(query, con)
                    command.Parameters.AddWithValue("@EnteredPassword", enteredPassword)

                    ' قراءة البيانات المسترجعة من الاستعلام
                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            ' الرقم السري صحيح
                            reader.Read()
                            Dim UserID As String = reader("UserID").ToString()
                            Dim username As String = reader("Username").ToString()
                            Dim job As String = reader("Jop").ToString()
                            Dim dept As String = reader("Dept").ToString()
                            Dim forms As String = reader("Forms").ToString()

                            ' التحقق من نوع الوظيفة والأقسام والنماذج
                            If job = "مدير الصيانة" And dept = "الصيانة" And forms = "D1" Then
                                ' الرقم السري صحيح ونوع الوظيفة مدير والقسم الصيانة والنموذج D1
                                Txt_User.Text = username ' عرض اسم المستخدم في Txt_User
                                ' القبول وعرض البيانات الإضافية
                                ' إضافة الكود الخاص بعرض البيانات وفتح الواجهة المناسبة
                                Me.Txt_Time.Text = Now
                                Update_Tbl_MachineProblems_Time_EstegabaMawad(DateTime.Parse(Txt_Time.Text), username, UserID, ProblemCode.Text)
                                Me.Txt_Estgaba_Mawad_password.Visible = False
                                Me.Txt_Estgaba_Mawad_password.Text = ""
                                Me.Lbl_Estgaba_Mawad.Visible = False
                                Me.Btn_Fix_Mawad.Visible = True
                            Else
                                ' إذا لم تتطابق الشروط المطلوبة
                                MsgBox("لا يسمح لك بالوصول إلى هذا التطبيق")
                                Me.Txt_Estgaba_Mawad_password.Text = ""
                            End If
                        Else
                            ' الرقم السري غير صحيح
                            MsgBox("خطأ في الرقم السري")
                            Me.Txt_Estgaba_Mawad_password.Text = ""
                        End If
                    End Using
                End Using
            End Using
        End If
    End Sub

    Private Sub Btn_Fix_Mawad_Click(sender As Object, e As EventArgs) Handles Btn_Fix_Mawad.Click
        Me.Btn_Fix_Mawad.Visible = False
        Me.Lbl_Fix_Mawad.Visible = True
        Me.Txt_Fix_Mawad_Password.Visible = True
        Me.Txt_Fix_Mawad_Password.Focus()
    End Sub

    Private Sub Btn_Alarm_Kahraba_Click(sender As Object, e As EventArgs) Handles Btn_Alarm_Kahraba.Click
        Me.Btn_Alarm_Kahraba.Visible = False
        Me.Lbl_Alarm_Kahraba.Visible = True
        Me.Txt_Alarm_Kahraba_password.Visible = True
        Me.Txt_Alarm_Kahraba_password.Focus()
    End Sub

    Private Sub Btn_Estgaba_Kahraba_Click(sender As Object, e As EventArgs) Handles Btn_Estgaba_Kahraba.Click
        Me.Lbl_Estgaba_Kahraba.Visible = True
        Me.Txt_Estgaba_Kahraba_password.Visible = True
        Me.Btn_Estgaba_Kahraba.Visible = False
        Me.Txt_Estgaba_Kahraba_password.Focus()
    End Sub

    Private Sub Txt_Fix_Mawad_Password_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Fix_Mawad_Password.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' الحصول على قيمة الرقم السري المدخل
            Dim enteredPassword As String = Txt_Fix_Mawad_Password.Text.Trim()
            Using con As New SqlConnection(ConStr)
                If con.State = 1 Then con.Close()
                con.Open()

                ' استعلام للتحقق من وجود الرقم السري في جدول المستخدمين
                Dim query As String = "SELECT  UserID, Username, Jop, Dept, Forms FROM Users WHERE Password = @EnteredPassword"
                Using command As New SqlCommand(query, con)
                    command.Parameters.AddWithValue("@EnteredPassword", enteredPassword)

                    ' قراءة البيانات المسترجعة من الاستعلام
                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            ' الرقم السري صحيح
                            reader.Read()
                            Dim UserID As String = reader("UserID").ToString()
                            Dim username As String = reader("Username").ToString()
                            Dim job As String = reader("Jop").ToString()
                            Dim dept As String = reader("Dept").ToString()
                            Dim forms As String = reader("Forms").ToString()

                            ' التحقق من نوع الوظيفة والأقسام والنماذج
                            If job = "مدير الصيانة" And dept = "الصيانة" And forms = "D1" Then
                                ' الرقم السري صحيح ونوع الوظيفة مدير والقسم الصيانة والنموذج D1
                                Txt_User.Text = username ' عرض اسم المستخدم في Txt_User
                                ' القبول وعرض البيانات الإضافية
                                ' إضافة الكود الخاص بعرض البيانات وفتح الواجهة المناسبة
                                Me.Txt_Time.Text = Now
                                Update_Tbl_MachineProblems_Time_FixMawad(DateTime.Parse(Txt_Time.Text), username, UserID, ProblemCode.Text)
                                Me.Txt_Fix_Mawad_Password.Visible = False
                                Me.Txt_Fix_Mawad_Password.Text = ""
                                Me.Lbl_Fix_Mawad.Visible = False
                                Me.Panel4.Visible = True
                                '''Me.Txt_Code_Proplem_Show.Text = Max_Tbl_MachineProblems_Time()
                                Me.Txt_Time_Stop_Machine_Show.Text = DateTime.Parse(Max_Tbl_MachineProblems_Time_Stop_Machine(ProblemCode.Text))
                                Me.Txt_Time_Start_Fix_Show.Text = DateTime.Parse(Max_Tbl_MachineProblems_Estegaba_Mawad())
                                Me.Txt_Time_End_Fix_Show.Text = DateTime.Parse(Max_Tbl_MachineProblems_End_Fix_Mawad())
                                Me.Txt_Department_Show.Text = Max_Tbl_MachineProblems_Time_Department_Mawad()
                                'fillcmb_Tbl_Problem_Machine(Me.Combo_Unit)
                            Else
                                ' إذا لم تتطابق الشروط المطلوبة
                                MsgBox("لا يسمح لك بالوصول إلى هذا التطبيق")
                                Me.Txt_Fix_Mawad_Password.Text = ""
                            End If
                        Else
                            ' الرقم السري غير صحيح
                            MsgBox("خطأ في الرقم السري")
                            Me.Txt_Fix_Mawad_Password.Text = ""
                        End If
                    End Using
                End Using
            End Using
        End If
    End Sub

    Private Sub Txt_Fix_Kahraba_Password_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Fix_Kahraba_Password.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' الحصول على قيمة الرقم السري المدخل
            Dim enteredPassword As String = Txt_Fix_Kahraba_Password.Text.Trim()
            Using con As New SqlConnection(ConStr)
                If con.State = 1 Then con.Close()
                con.Open()
                ' استعلام للتحقق من وجود الرقم السري في جدول المستخدمين
                Dim query As String = "SELECT  UserID, Username, Jop, Dept, Forms FROM Users WHERE Password = @EnteredPassword"
                Using command As New SqlCommand(query, con)
                    command.Parameters.AddWithValue("@EnteredPassword", enteredPassword)
                    ' قراءة البيانات المسترجعة من الاستعلام
                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            ' الرقم السري صحيح
                            reader.Read()
                            Dim UserID As String = reader("UserID").ToString()
                            Dim username As String = reader("Username").ToString()
                            Dim job As String = reader("Jop").ToString()
                            Dim dept As String = reader("Dept").ToString()
                            Dim forms As String = reader("Forms").ToString()

                            ' التحقق من نوع الوظيفة والأقسام والنماذج
                            If job = "مدير الصيانة" And dept = "الصيانة" And forms = "D1" Then
                                ' الرقم السري صحيح ونوع الوظيفة مدير والقسم الصيانة والنموذج D1
                                Txt_User.Text = username ' عرض اسم المستخدم في Txt_User
                                ' القبول وعرض البيانات الإضافية
                                ' إضافة الكود الخاص بعرض البيانات وفتح الواجهة المناسبة
                                Me.Txt_Time.Text = Now
                                Update_Tbl_MachineProblems_Time_FixKahraba(DateTime.Parse(Txt_Time.Text), username, UserID, ProblemCode.Text)
                                Me.Txt_Fix_Kahraba_Password.Visible = False
                                Me.Txt_Fix_Kahraba_Password.Text = ""
                                Me.Lbl_Fix_Kahraba.Visible = False
                                Me.Panel4.Visible = True
                                '''Me.Txt_Code_Proplem_Show.Text = Max_Tbl_MachineProblems_Time()
                                Me.Txt_Time_Stop_Machine_Show.Text = DateTime.Parse(Max_Tbl_MachineProblems_Time_Stop_Machine(ProblemCode.Text))
                                Me.Txt_Time_Start_Fix_Show.Text = DateTime.Parse(Max_Tbl_MachineProblems_Estegaba_Kahraba())
                                Me.Txt_Time_End_Fix_Show.Text = DateTime.Parse(Max_Tbl_MachineProblems_End_Fix_Kahraba())
                                Me.Txt_Department_Show.Text = Max_Tbl_MachineProblems_Time_Department_Kharaba()
                                'fillcmb_Tbl_Problem_Machine(Me.Combo_Unit)
                            Else
                                ' إذا لم تتطابق الشروط المطلوبة
                                MsgBox("لا يسمح لك بالوصول إلى هذا التطبيق")
                                Me.Txt_Fix_Kahraba_Password.Text = ""
                            End If
                        Else
                            ' الرقم السري غير صحيح
                            MsgBox("خطأ في الرقم السري")
                            Me.Txt_Fix_Kahraba_Password.Text = ""
                        End If
                    End Using
                End Using
            End Using
        End If
    End Sub

    Private Sub Btn_Alarm_Quality_Click(sender As Object, e As EventArgs) Handles Btn_Alarm_Quality.Click
        Me.Btn_Alarm_Quality.Visible = False
        Me.Lbl_Alarm_Quality.Visible = True
        Me.Txt_Alarm_Quality_password.Visible = True
        Me.Txt_Alarm_Quality_password.Focus()
    End Sub

    Private Sub Btn_Estgaba_Quality_Click(sender As Object, e As EventArgs) Handles Btn_Estgaba_Quality.Click
        Me.Lbl_Estgaba_Quality.Visible = True
        Me.Txt_Estgaba_Quality_password.Visible = True
        Me.Btn_Estgaba_Quality.Visible = False
        Me.Txt_Estgaba_Quality_password.Focus()
    End Sub

    Private Sub Txt_Estgaba_Kahraba_password_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Estgaba_Kahraba_password.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' الحصول على قيمة الرقم السري المدخل
            Dim enteredPassword As String = Txt_Estgaba_Kahraba_password.Text.Trim()
            Using con As New SqlConnection(ConStr)
                If con.State = 1 Then con.Close()
                con.Open()
                ' استعلام للتحقق من وجود الرقم السري في جدول المستخدمين
                Dim query As String = "SELECT  UserID, Username, Jop, Dept, Forms FROM Users WHERE Password = @EnteredPassword"
                Using command As New SqlCommand(query, con)
                    command.Parameters.AddWithValue("@EnteredPassword", enteredPassword)

                    ' قراءة البيانات المسترجعة من الاستعلام
                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            ' الرقم السري صحيح
                            reader.Read()
                            Dim UserID As String = reader("UserID").ToString()
                            Dim username As String = reader("Username").ToString()
                            Dim job As String = reader("Jop").ToString()
                            Dim dept As String = reader("Dept").ToString()
                            Dim forms As String = reader("Forms").ToString()
                            ' التحقق من نوع الوظيفة والأقسام والنماذج
                            If job = "مدير الصيانة" And dept = "الصيانة" And forms = "D1" Then
                                ' الرقم السري صحيح ونوع الوظيفة مدير والقسم الصيانة والنموذج D1
                                Txt_User.Text = username ' عرض اسم المستخدم في Txt_User
                                ' القبول وعرض البيانات الإضافية
                                ' إضافة الكود الخاص بعرض البيانات وفتح الواجهة المناسبة
                                Me.Txt_Time.Text = Now
                                Update_Tbl_MachineProblems_Time_EstegabaKahraba(DateTime.Parse(Txt_Time.Text), username, UserID, ProblemCode.Text)
                                Me.Txt_Estgaba_Kahraba_password.Visible = False
                                Me.Txt_Estgaba_Kahraba_password.Text = ""
                                Me.Lbl_Estgaba_Kahraba.Visible = False
                                Me.Btn_Fix_Kahraba.Visible = True
                            Else
                                ' إذا لم تتطابق الشروط المطلوبة
                                MsgBox("لا يسمح لك بالوصول إلى هذا التطبيق")
                                Me.Txt_Estgaba_Kahraba_password.Text = ""
                            End If
                        Else
                            ' الرقم السري غير صحيح
                            MsgBox("خطأ في الرقم السري")
                            Me.Txt_Estgaba_Kahraba_password.Text = ""
                        End If
                    End Using
                End Using
            End Using
        End If
    End Sub

    Private Sub Btn_Fix_Kahraba_Click(sender As Object, e As EventArgs) Handles Btn_Fix_Kahraba.Click
        Me.Btn_Fix_Kahraba.Visible = False
        Me.Lbl_Fix_Kahraba.Visible = True
        Me.Txt_Fix_Kahraba_Password.Visible = True
        Me.Txt_Fix_Kahraba_Password.Focus()
    End Sub

    Private Sub Txt_Estgaba_Quality_password_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Estgaba_Quality_password.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' الحصول على قيمة الرقم السري المدخل
            Dim enteredPassword As String = Txt_Estgaba_Quality_password.Text.Trim()
            Using con As New SqlConnection(ConStr)
                If con.State = 1 Then con.Close()
                con.Open()
                ' استعلام للتحقق من وجود الرقم السري في جدول المستخدمين
                Dim query As String = "SELECT  UserID, Username, Jop, Dept, Forms FROM Users WHERE Password = @EnteredPassword"
                Using command As New SqlCommand(query, con)
                    command.Parameters.AddWithValue("@EnteredPassword", enteredPassword)
                    ' قراءة البيانات المسترجعة من الاستعلام
                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            ' الرقم السري صحيح
                            reader.Read()
                            Dim UserID As String = reader("UserID").ToString()
                            Dim username As String = reader("Username").ToString()
                            Dim job As String = reader("Jop").ToString()
                            Dim dept As String = reader("Dept").ToString()
                            Dim forms As String = reader("Forms").ToString()
                            ' التحقق من نوع الوظيفة والأقسام والنماذج
                            If job = "مدير الصيانة" And dept = "الصيانة" And forms = "D1" Then
                                ' الرقم السري صحيح ونوع الوظيفة مدير والقسم الصيانة والنموذج D1
                                Txt_User.Text = username ' عرض اسم المستخدم في Txt_User
                                ' القبول وعرض البيانات الإضافية
                                ' إضافة الكود الخاص بعرض البيانات وفتح الواجهة المناسبة
                                Me.Txt_Time.Text = Now
                                Update_Tbl_MachineProblems_Time_EstegabaQuality(DateTime.Parse(Txt_Time.Text), username, UserID, ProblemCode.Text)
                                Me.Txt_Estgaba_Quality_password.Visible = False
                                Me.Txt_Estgaba_Quality_password.Text = ""
                                Me.Lbl_Estgaba_Quality.Visible = False
                                Me.Btn_Fix_Quality.Visible = True
                            Else
                                ' إذا لم تتطابق الشروط المطلوبة
                                MsgBox("لا يسمح لك بالوصول إلى هذا التطبيق")
                                Me.Txt_Estgaba_Quality_password.Text = ""
                            End If
                        Else
                            ' الرقم السري غير صحيح
                            MsgBox("خطأ في الرقم السري")
                            Me.Txt_Estgaba_Quality_password.Text = ""
                        End If
                    End Using
                End Using
            End Using
        End If
    End Sub

    Private Sub Btn_Fix_Quality_Click(sender As Object, e As EventArgs) Handles Btn_Fix_Quality.Click
        Me.Btn_Fix_Quality.Visible = False
        Me.Lbl_Fix_Quality.Visible = True
        Me.Txt_Fix_Quality_Password.Visible = True
        Me.Txt_Fix_Quality_Password.Focus()
    End Sub

    Private Sub Txt_Fix_Quality_Password_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Fix_Quality_Password.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' الحصول على قيمة الرقم السري المدخل
            Dim enteredPassword As String = Txt_Fix_Quality_Password.Text.Trim()
            Using con As New SqlConnection(ConStr)
                If con.State = 1 Then con.Close()
                con.Open()
                ' استعلام للتحقق من وجود الرقم السري في جدول المستخدمين
                Dim query As String = "SELECT  UserID, Username, Jop, Dept, Forms FROM Users WHERE Password = @EnteredPassword"
                Using command As New SqlCommand(query, con)
                    command.Parameters.AddWithValue("@EnteredPassword", enteredPassword)
                    ' قراءة البيانات المسترجعة من الاستعلام
                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            ' الرقم السري صحيح
                            reader.Read()
                            Dim UserID As String = reader("UserID").ToString()
                            Dim username As String = reader("Username").ToString()
                            Dim job As String = reader("Jop").ToString()
                            Dim dept As String = reader("Dept").ToString()
                            Dim forms As String = reader("Forms").ToString()
                            ' التحقق من نوع الوظيفة والأقسام والنماذج
                            If job = "مدير الصيانة" And dept = "الصيانة" And forms = "D1" Then
                                ' الرقم السري صحيح ونوع الوظيفة مدير والقسم الصيانة والنموذج D1
                                Txt_User.Text = username ' عرض اسم المستخدم في Txt_User
                                ' القبول وعرض البيانات الإضافية
                                ' إضافة الكود الخاص بعرض البيانات وفتح الواجهة المناسبة
                                Me.Txt_Time.Text = Now
                                Update_Tbl_MachineProblems_Time_FixQuality(DateTime.Parse(Txt_Time.Text), username, UserID, ProblemCode.Text)
                                Me.Txt_Fix_Quality_Password.Visible = False
                                Me.Txt_Fix_Quality_Password.Text = ""
                                Me.Lbl_Fix_Quality.Visible = False
                                Me.Panel4.Visible = True
                                '''Me.Txt_Code_Proplem_Show.Text = Max_Tbl_MachineProblems_Time()
                                Me.Txt_Time_Stop_Machine_Show.Text = DateTime.Parse(Max_Tbl_MachineProblems_Time_Stop_Machine(ProblemCode.Text))
                                Me.Txt_Time_Start_Fix_Show.Text = DateTime.Parse(Max_Tbl_MachineProblems_Estegaba_Quality())
                                Me.Txt_Time_End_Fix_Show.Text = DateTime.Parse(Max_Tbl_MachineProblems_End_Fix_Quality())
                                Me.Txt_Department_Show.Text = Max_Tbl_MachineProblems_Time_Department_Quality()
                                'fillcmb_Tbl_Problem_Machine(Me.Combo_Unit)
                            Else
                                ' إذا لم تتطابق الشروط المطلوبة
                                MsgBox("لا يسمح لك بالوصول إلى هذا التطبيق")
                                Me.Txt_Fix_Quality_Password.Text = ""
                            End If
                        Else
                            ' الرقم السري غير صحيح
                            MsgBox("خطأ في الرقم السري")
                            Me.Txt_Fix_Quality_Password.Text = ""
                        End If
                    End Using
                End Using
            End Using
        End If
    End Sub

    Private Sub Btn_Alarm_Production_Click(sender As Object, e As EventArgs) Handles Btn_Alarm_Production.Click
        Me.Btn_Alarm_Production.Visible = False
        Me.Lbl_Alarm_Production.Visible = True
        Me.Txt_Alarm_Production_password.Visible = True
        Me.Txt_Alarm_Production_password.Focus()
    End Sub

    Private Sub Btn_Estgaba_Production_Click(sender As Object, e As EventArgs) Handles Btn_Estgaba_Production.Click
        Me.Lbl_Estgaba_Production.Visible = True
        Me.Txt_Estgaba_Production_password.Visible = True
        Me.Btn_Estgaba_Production.Visible = False
        Me.Txt_Estgaba_Production_password.Focus()
    End Sub

    Private Sub Txt_Estgaba_Production_password_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Estgaba_Production_password.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' الحصول على قيمة الرقم السري المدخل
            Dim enteredPassword As String = Txt_Estgaba_Production_password.Text.Trim()
            Using con As New SqlConnection(ConStr)
                If con.State = 1 Then con.Close()
                con.Open()
                ' استعلام للتحقق من وجود الرقم السري في جدول المستخدمين
                Dim query As String = "SELECT  UserID, Username, Jop, Dept, Forms FROM Users WHERE Password = @EnteredPassword"
                Using command As New SqlCommand(query, con)
                    command.Parameters.AddWithValue("@EnteredPassword", enteredPassword)
                    ' قراءة البيانات المسترجعة من الاستعلام
                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            ' الرقم السري صحيح
                            reader.Read()
                            Dim UserID As String = reader("UserID").ToString()
                            Dim username As String = reader("Username").ToString()
                            Dim job As String = reader("Jop").ToString()
                            Dim dept As String = reader("Dept").ToString()
                            Dim forms As String = reader("Forms").ToString()
                            ' التحقق من نوع الوظيفة والأقسام والنماذج
                            If job = "مدير الصيانة" And dept = "الصيانة" And forms = "D1" Then
                                ' الرقم السري صحيح ونوع الوظيفة مدير والقسم الصيانة والنموذج D1
                                Txt_User.Text = username ' عرض اسم المستخدم في Txt_User
                                ' القبول وعرض البيانات الإضافية
                                ' إضافة الكود الخاص بعرض البيانات وفتح الواجهة المناسبة
                                Me.Txt_Time.Text = Now
                                Update_Tbl_MachineProblems_Time_EstegabaProduction(DateTime.Parse(Txt_Time.Text), username, UserID, ProblemCode.Text)
                                Me.Txt_Estgaba_Production_password.Visible = False
                                Me.Txt_Estgaba_Production_password.Text = ""
                                Me.Lbl_Estgaba_Production.Visible = False
                                Me.Btn_Fix_Production.Visible = True
                            Else
                                ' إذا لم تتطابق الشروط المطلوبة
                                MsgBox("لا يسمح لك بالوصول إلى هذا التطبيق")
                                Me.Txt_Estgaba_Production_password.Text = ""
                            End If
                        Else
                            ' الرقم السري غير صحيح
                            MsgBox("خطأ في الرقم السري")
                            Me.Txt_Estgaba_Production_password.Text = ""
                        End If
                    End Using
                End Using
            End Using
        End If
    End Sub

    Private Sub Btn_Fix_Production_Click(sender As Object, e As EventArgs) Handles Btn_Fix_Production.Click
        Me.Btn_Fix_Production.Visible = False
        Me.Lbl_Fix_Production.Visible = True
        Me.Txt_Fix_Production_Password.Visible = True
        Me.Txt_Fix_Production_Password.Focus()
    End Sub

    Private Sub Txt_Fix_Production_Password_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Fix_Production_Password.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' الحصول على قيمة الرقم السري المدخل
            Dim enteredPassword As String = Txt_Fix_Production_Password.Text.Trim()
            Using con As New SqlConnection(ConStr)
                If con.State = 1 Then con.Close()
                con.Open()
                Dim query As String = "SELECT  UserID, Username, Jop, Dept, Forms FROM Users WHERE Password = @EnteredPassword"
                Using command As New SqlCommand(query, con)
                    command.Parameters.AddWithValue("@EnteredPassword", enteredPassword)
                    ' قراءة البيانات المسترجعة من الاستعلام
                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            ' الرقم السري صحيح
                            reader.Read()
                            Dim UserID As String = reader("UserID").ToString()
                            Dim username As String = reader("Username").ToString()
                            Dim job As String = reader("Jop").ToString()
                            Dim dept As String = reader("Dept").ToString()
                            Dim forms As String = reader("Forms").ToString()
                            ' التحقق من نوع الوظيفة والأقسام والنماذج
                            If job = "مدير الصيانة" And dept = "الصيانة" And forms = "D1" Then
                                ' الرقم السري صحيح ونوع الوظيفة مدير والقسم الصيانة والنموذج D1
                                Txt_User.Text = username ' عرض اسم المستخدم في Txt_User
                                ' القبول وعرض البيانات الإضافية
                                ' إضافة الكود الخاص بعرض البيانات وفتح الواجهة المناسبة
                                Me.Txt_Time.Text = Now
                                Update_Tbl_MachineProblems_Time_FixProduction(DateTime.Parse(Txt_Time.Text), username, UserID, ProblemCode.Text)
                                Me.Txt_Fix_Production_Password.Visible = False
                                Me.Txt_Fix_Production_Password.Text = ""
                                Me.Lbl_Fix_Production.Visible = False
                                Me.Panel4.Visible = True
                                '''Me.Txt_Code_Proplem_Show.Text = Max_Tbl_MachineProblems_Time()
                                Me.Txt_Time_Stop_Machine_Show.Text = DateTime.Parse(Max_Tbl_MachineProblems_Time_Stop_Machine(ProblemCode.Text))
                                Me.Txt_Time_Start_Fix_Show.Text = DateTime.Parse(Max_Tbl_MachineProblems_Estegaba_Production())
                                Me.Txt_Time_End_Fix_Show.Text = DateTime.Parse(Max_Tbl_MachineProblems_End_Fix_Production())
                                Me.Txt_Department_Show.Text = Max_Tbl_MachineProblems_Time_Department_Production()
                                'fillcmb_Tbl_Problem_Machine(Me.Combo_Unit)
                            Else
                                ' إذا لم تتطابق الشروط المطلوبة
                                MsgBox("لا يسمح لك بالوصول إلى هذا التطبيق")
                                Me.Txt_Fix_Production_Password.Text = ""
                            End If
                        Else
                            ' الرقم السري غير صحيح
                            MsgBox("خطأ في الرقم السري")
                            Me.Txt_Fix_Production_Password.Text = ""
                        End If
                    End Using
                End Using
            End Using
        End If
    End Sub

    Private Sub Btn_Alarm_SpareParts_Click(sender As Object, e As EventArgs) Handles Btn_Alarm_SpareParts.Click
        Me.Btn_Alarm_SpareParts.Visible = False
        Me.Lbl_Alarm_SpareParts.Visible = True
        Me.Txt_Alarm_SpareParts_password.Visible = True
        Me.Txt_Alarm_SpareParts_password.Focus()
    End Sub

    Private Sub Btn_Estgaba_SpareParts_Click(sender As Object, e As EventArgs) Handles Btn_Estgaba_SpareParts.Click
        Me.Lbl_Estgaba_SpareParts.Visible = True
        Me.Txt_Estgaba_SpareParts_password.Visible = True
        Btn_Estgaba_SpareParts.Visible = False
        Me.Txt_Estgaba_SpareParts_password.Focus()
    End Sub

    Private Sub Btn_Fix_SpareParts_Click(sender As Object, e As EventArgs) Handles Btn_Fix_SpareParts.Click
        Btn_Fix_SpareParts.Visible = False
        Me.Lbl_Fix_SpareParts.Visible = True
        Me.Txt_Fix_SpareParts_Password.Visible = True
        Me.Txt_Fix_SpareParts_Password.Focus()
    End Sub

    Private Sub Txt_Estgaba_SpareParts_password_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Estgaba_SpareParts_password.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' الحصول على قيمة الرقم السري المدخل
            Dim enteredPassword As String = Txt_Estgaba_SpareParts_password.Text.Trim()
            Using con As New SqlConnection(ConStr)
                If con.State = 1 Then con.Close()
                con.Open()
                ' استعلام للتحقق من وجود الرقم السري في جدول المستخدمين
                Dim query As String = "SELECT  UserID, Username, Jop, Dept, Forms FROM Users WHERE Password = @EnteredPassword"
                Using command As New SqlCommand(query, con)
                    command.Parameters.AddWithValue("@EnteredPassword", enteredPassword)
                    ' قراءة البيانات المسترجعة من الاستعلام
                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            ' الرقم السري صحيح
                            reader.Read()
                            Dim UserID As String = reader("UserID").ToString()
                            Dim username As String = reader("Username").ToString()
                            Dim job As String = reader("Jop").ToString()
                            Dim dept As String = reader("Dept").ToString()
                            Dim forms As String = reader("Forms").ToString()
                            ' التحقق من نوع الوظيفة والأقسام والنماذج
                            If job = "مدير الصيانة" And dept = "الصيانة" And forms = "D1" Then
                                ' الرقم السري صحيح ونوع الوظيفة مدير والقسم الصيانة والنموذج D1
                                Txt_User.Text = username ' عرض اسم المستخدم في Txt_User
                                ' القبول وعرض البيانات الإضافية
                                ' إضافة الكود الخاص بعرض البيانات وفتح الواجهة المناسبة
                                Me.Txt_Time.Text = Now
                                Update_Tbl_MachineProblems_Time_EstegabaSpareParts(DateTime.Parse(Txt_Time.Text), username, UserID, ProblemCode.Text)
                                Me.Txt_Estgaba_SpareParts_password.Visible = False
                                Me.Txt_Estgaba_SpareParts_password.Text = ""
                                Me.Lbl_Estgaba_SpareParts.Visible = False
                                Me.Btn_Fix_SpareParts.Visible = True
                            Else
                                ' إذا لم تتطابق الشروط المطلوبة
                                MsgBox("لا يسمح لك بالوصول إلى هذا التطبيق")
                                Me.Txt_Estgaba_SpareParts_password.Text = ""
                            End If
                        Else
                            ' الرقم السري غير صحيح
                            MsgBox("خطأ في الرقم السري")
                            Me.Txt_Estgaba_SpareParts_password.Text = ""
                        End If
                    End Using
                End Using
            End Using
        End If
    End Sub

    Private Sub Txt_Fix_SpareParts_Password_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Fix_SpareParts_Password.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' الحصول على قيمة الرقم السري المدخل
            Dim enteredPassword As String = Txt_Fix_SpareParts_Password.Text.Trim()
            ' الاتصال بقاعدة البيانات وتنفيذ الاستعلام
            Using con As New SqlConnection(ConStr)
                If con.State = 1 Then con.Close()
                con.Open()
                ' استعلام للتحقق من وجود الرقم السري في جدول المستخدمين
                Dim query As String = "SELECT  UserID, Username, Jop, Dept, Forms FROM Users WHERE Password = @EnteredPassword"
                Using command As New SqlCommand(query, con)
                    command.Parameters.AddWithValue("@EnteredPassword", enteredPassword)
                    ' قراءة البيانات المسترجعة من الاستعلام
                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            ' الرقم السري صحيح
                            reader.Read()
                            Dim UserID As String = reader("UserID").ToString()
                            Dim username As String = reader("Username").ToString()
                            Dim job As String = reader("Jop").ToString()
                            Dim dept As String = reader("Dept").ToString()
                            Dim forms As String = reader("Forms").ToString()
                            ' التحقق من نوع الوظيفة والأقسام والنماذج
                            If job = "مدير الصيانة" And dept = "الصيانة" And forms = "D1" Then
                                ' الرقم السري صحيح ونوع الوظيفة مدير والقسم الصيانة والنموذج D1
                                Txt_User.Text = username ' عرض اسم المستخدم في Txt_User
                                ' القبول وعرض البيانات الإضافية
                                ' إضافة الكود الخاص بعرض البيانات وفتح الواجهة المناسبة
                                Txt_Time.Text = Now
                                Update_Tbl_MachineProblems_Time_FixSpareParts(Date.Parse(Txt_Time.Text), Txt_User.Text, UserID, ProblemCode.Text)
                                Txt_Fix_SpareParts_Password.Visible = False
                                Txt_Fix_SpareParts_Password.Text = ""
                                Lbl_Fix_SpareParts.Visible = False
                                Panel4.Visible = True
                                '''Txt_Code_Proplem_Show.Text = Max_Tbl_MachineProblems_Time()
                                Txt_Time_Stop_Machine_Show.Text = DateTime.Parse(Max_Tbl_MachineProblems_Time_Stop_Machine(ProblemCode.Text))
                                Txt_Time_Start_Fix_Show.Text = DateTime.Parse(Max_Tbl_MachineProblems_Estegaba_SpareParts)
                                Txt_Time_End_Fix_Show.Text = DateTime.Parse(Max_Tbl_MachineProblems_End_Fix_SpareParts)
                                Txt_Department_Show.Text = Max_Tbl_MachineProblems_Time_Department_SpareParts()
                                'fillcmb_Tbl_Problem_Machine(Combo_Unit)
                            Else
                                ' إذا لم تتطابق الشروط المطلوبة
                                MsgBox("لا يسمح لك بالوصول إلى هذا التطبيق")
                                Txt_Fix_SpareParts_Password.Text = ""
                            End If
                        Else
                            ' الرقم السري غير صحيح
                            MsgBox("خطأ في الرقم السري")
                            Txt_Fix_SpareParts_Password.Text = ""
                        End If
                    End Using
                End Using
            End Using
        End If
    End Sub

    Private Sub Txt_Alarm_Mentinance_password_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Alarm_Mentinance_password.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' الحصول على قيمة الرقم السري المدخل
            Dim enteredPassword As String = Txt_Alarm_Mentinance_password.Text.Trim()
            ' الاتصال بقاعدة البيانات وتنفيذ الاستعلام
            Using con As New SqlConnection(ConStr)
                If con.State = 1 Then con.Close()
                con.Open()
                ' استعلام للتحقق من وجود الرقم السري في جدول المستخدمين
                Dim query As String = "SELECT * FROM Users WHERE Password = @EnteredPassword"
                Using command As New SqlCommand(query, con)
                    command.Parameters.AddWithValue("@EnteredPassword", enteredPassword)
                    ' قراءة البيانات المسترجعة من الاستعلام
                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            ' الرقم السري صحيح
                            reader.Read()
                            Dim UserID As String = reader("UserID").ToString()
                            Dim username As String = reader("Username").ToString()
                            Dim job As String = reader("Jop").ToString()
                            Dim dept As String = reader("Dept").ToString()
                            Dim forms As String = reader("Forms").ToString()
                            Dim D1 As String = reader("D1").ToString()
                            Dim D2 As String = reader("D2").ToString()
                            Dim F1 As String = reader("F1").ToString()
                            Dim F2 As String = reader("F2").ToString()
                            Dim H As String = reader("H").ToString()
                            If (job = "فنى صيانة" Or job = "مدير الصيانة") And dept = "الصيانة" Then
                                Dim isD1True As Boolean = D1
                                Dim isD2True As Boolean = D2
                                Dim isF1True As Boolean = F1
                                Dim isF2True As Boolean = F2
                                Dim isHTrue As Boolean = H
                                If Lbl_Machine.Text = "D1" AndAlso isD1True = "True" Or Lbl_Machine.Text = "D2" AndAlso isD2True = "True" Or Lbl_Machine.Text = "F1" AndAlso isF1True = "True" Or Lbl_Machine.Text = "F2" AndAlso isF2True = "True" Or Lbl_Machine.Text = "H" AndAlso isHTrue = "True" Then

                                    Txt_User.Text = username ' عرض اسم المستخدم في Txt_User
                                    Me.Txt_Dept.Text = "الصيانة"
                                    Me.Txt_Time.Text = Now
                                    Update_Tbl_MachineProblems_Time_Press_Mentinance_button(DateTime.Parse(Txt_Time.Text), username, UserID, Txt_Dept.Text, ProblemCode.Text)
                                    Me.Btn_Alarm_Mentinance.Visible = False
                                    Me.Lbl_Alarm_Mentinance.Visible = False
                                    Me.Txt_Alarm_Mentinance_password.Visible = False
                                    Me.Txt_Alarm_Mentinance_password.Text = ""
                                    'Me.Btn_Estgaba_Mentinance.Visible = True
                                    'fillcmb_Tbl_Problem_Machine(Combo_Unit)
                                    Me.Panel4.Visible = True
                                    'Me.Txt_Code_Proplem_Show.Text = Max_Tbl_MachineProblems_Time()
                                    Me.Txt_Code_Proplem_Show.Text = ProblemCode.Text
                                    Me.Txt_Time_Stop_Machine_Show.Text = DateTime.Parse(Max_Tbl_MachineProblems_Time_Stop_Machine(ProblemCode.Text))
                                    Me.Txt_Time_Start_Fix_Show.Text = DateTime.Parse(Max_Tbl_MachineProblems_Estegaba_Mentinance())
                                    Me.Txt_Time_End_Fix_Show.Text = DateTime.Parse(Max_Tbl_MachineProblems_End_Fix_Mentinance())
                                    Me.Txt_Department_Show.Text = Max_Tbl_MachineProblems_Time_Department_Maintenance()
                                Else
                                    ' إذا لم تتطابق الشروط المطلوبة
                                    MsgBox("لا يسمح لك بالوصول إلى هذا التطبيق")
                                    Me.Txt_Alarm_Mentinance_password.Text = ""
                                End If
                            End If
                        Else
                            ' الرقم السري غير صحيح
                            MsgBox("خطأ في الرقم السري")
                            Me.Txt_Alarm_Mentinance_password.Text = ""
                        End If
                    End Using
                End Using
            End Using
        End If
    End Sub

    Private Sub Txt_Alarm_Kahraba_password_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Alarm_Kahraba_password.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' الحصول على قيمة الرقم السري المدخل
            Dim enteredPassword As String
            enteredPassword = Txt_Alarm_Kahraba_password.Text.Trim()
            Using con As New SqlConnection(ConStr)
                If con.State = 1 Then con.Close()
                con.Open()
                ' استعلام للتحقق من وجود الرقم السري في جدول المستخدمين
                Dim query As String = "SELECT  *  FROM Users WHERE Password = @EnteredPassword"
                Using command As New SqlCommand(query, con)
                    command.Parameters.AddWithValue("@EnteredPassword", enteredPassword)
                    ' قراءة البيانات المسترجعة من الاستعلام
                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            ' الرقم السري صحيح
                            reader.Read()
                            Dim UserID As String = reader("UserID").ToString()
                            Dim username As String = reader("Username").ToString()
                            Dim job As String = reader("Jop").ToString()
                            Dim dept As String = reader("Dept").ToString()
                            Dim forms As String = reader("Forms").ToString()
                            Dim D1 As String = reader("D1").ToString()
                            Dim D2 As String = reader("D2").ToString()
                            Dim F1 As String = reader("F1").ToString()
                            Dim F2 As String = reader("F2").ToString()
                            Dim H As String = reader("H").ToString()
                            If (job = "مدير الكهرباء" OrElse job = "مهندس كهرباء" OrElse job = "فنى كهرباء") And dept = "الكهرباء" Then
                                Dim isD1True As Boolean = D1
                                Dim isD2True As Boolean = D2
                                Dim isF1True As Boolean = F1
                                Dim isF2True As Boolean = F2
                                Dim isHTrue As Boolean = H
                                If Lbl_Machine.Text = "D1" AndAlso isD1True = "True" Or Lbl_Machine.Text = "D2" AndAlso isD2True = "True" Or Lbl_Machine.Text = "F1" AndAlso isF1True = "True" Or Lbl_Machine.Text = "F2" AndAlso isF2True = "True" Or Lbl_Machine.Text = "H" AndAlso isHTrue = "True" Then

                                    Txt_User.Text = username ' عرض اسم المستخدم في Txt_User
                                    ' القبول وعرض البيانات الإضافية
                                    ' إضافة الكود الخاص بعرض البيانات وفتح الواجهة المناسبة
                                    Me.Txt_Dept.Text = "الكهرباء"
                                    Me.Txt_Time.Text = Now
                                    Update_Tbl_MachineProblems_Time_press_the_Electricity_button(DateTime.Parse(Txt_Time.Text), username, UserID, Txt_Dept.Text, ProblemCode.Text)
                                    Me.Btn_Alarm_Kahraba.Visible = False
                                    Me.Lbl_Alarm_Kahraba.Visible = False
                                    Me.Txt_Alarm_Kahraba_password.Visible = False
                                    Me.Txt_Alarm_Kahraba_password.Text = ""
                                    '''Me.Btn_Estgaba_Kahraba.Visible = True
                                    Me.Panel4.Visible = True
                                    'Me.Txt_Code_Proplem_Show.Text = Max_Tbl_MachineProblems_Time()
                                    Me.Txt_Code_Proplem_Show.Text = ProblemCode.Text
                                    Me.Txt_Time_Stop_Machine_Show.Text = DateTime.Parse(Max_Tbl_MachineProblems_Time_Stop_Machine(ProblemCode.Text))
                                    Me.Txt_Time_Start_Fix_Show.Text = DateTime.Parse(Max_Tbl_MachineProblems_Estegaba_Kahraba())
                                    Me.Txt_Time_End_Fix_Show.Text = DateTime.Parse(Max_Tbl_MachineProblems_End_Fix_Kahraba())
                                    Me.Txt_Department_Show.Text = Max_Tbl_MachineProblems_Time_Department_Kharaba()

                                Else
                                    ' إذا لم تتطابق الشروط المطلوبة
                                    MsgBox("لا يسمح لك بالوصول إلى هذا التطبيق")
                                    Me.Txt_Alarm_Kahraba_password.Text = ""
                                End If
                            End If
                        Else
                            ' الرقم السري غير صحيح
                            MsgBox("خطأ في الرقم السري")
                            Me.Txt_Alarm_Kahraba_password.Text = ""
                        End If
                    End Using
                End Using
            End Using
        End If
    End Sub

    Private Sub Txt_Alarm_Mawad_password_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Alarm_Mawad_password.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' الحصول على قيمة الرقم السري المدخل
            Dim enteredPassword As String = Txt_Alarm_Mawad_password.Text.Trim()
            Using con As New SqlConnection(ConStr)
                If con.State = 1 Then con.Close()
                con.Open()
                ' استعلام للتحقق من وجود الرقم السري في جدول المستخدمين
                Dim query As String = "SELECT  * FROM Users WHERE Password = @EnteredPassword"
                Using command As New SqlCommand(query, con)
                    command.Parameters.AddWithValue("@EnteredPassword", enteredPassword)
                    ' قراءة البيانات المسترجعة من الاستعلام
                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            ' الرقم السري صحيح
                            reader.Read()
                            Dim UserID As String = reader("UserID").ToString()
                            Dim username As String = reader("Username").ToString()
                            Dim job As String = reader("Jop").ToString()
                            Dim dept As String = reader("Dept").ToString()
                            Dim forms As String = reader("Forms").ToString()
                            Dim D1 As String = reader("D1").ToString()
                            Dim D2 As String = reader("D2").ToString()
                            Dim F1 As String = reader("F1").ToString()
                            Dim F2 As String = reader("F2").ToString()
                            Dim H As String = reader("H").ToString()
                            If (job = "مشغل ماكينة A" OrElse job = "مشغل ماكينة B" OrElse job = "فنى انتاج" OrElse job = "دعم فنى") And dept = "الانتاج" Then
                                Dim isD1True As Boolean = D1
                                Dim isD2True As Boolean = D2
                                Dim isF1True As Boolean = F1
                                Dim isF2True As Boolean = F2
                                Dim isHTrue As Boolean = H
                                If Lbl_Machine.Text = "D1" AndAlso isD1True = "True" Or Lbl_Machine.Text = "D2" AndAlso isD2True = "True" Or Lbl_Machine.Text = "F1" AndAlso isF1True = "True" Or Lbl_Machine.Text = "F2" AndAlso isF2True = "True" Or Lbl_Machine.Text = "H" AndAlso isHTrue = "True" Then

                                    Txt_User.Text = username ' عرض اسم المستخدم في Txt_User
                                    ' القبول وعرض البيانات الإضافية
                                    ' إضافة الكود الخاص بعرض البيانات وفتح الواجهة المناسبة
                                    Me.Txt_Dept.Text = "المواد الأولية"
                                    Me.Txt_Time.Text = Now
                                    Update_Tbl_MachineProblems_Time_press_the_Mawad_button(DateTime.Parse(Txt_Time.Text), username, UserID, Txt_Dept.Text, ProblemCode.Text)
                                    Me.Btn_Alarm_Mawad.Visible = False
                                    Me.Lbl_Alarm_Mawad.Visible = False
                                    Me.Txt_Alarm_Mawad_password.Visible = False
                                    Me.Txt_Alarm_Mawad_password.Text = ""
                                    '''Me.Btn_Estgaba_Mawad.Visible = True
                                    Me.Panel4.Visible = True
                                    'Me.Txt_Code_Proplem_Show.Text = Max_Tbl_MachineProblems_Time()
                                    Me.Txt_Code_Proplem_Show.Text = ProblemCode.Text
                                    Me.Txt_Time_Stop_Machine_Show.Text = DateTime.Parse(Max_Tbl_MachineProblems_Time_Stop_Machine(ProblemCode.Text))
                                    Me.Txt_Time_Start_Fix_Show.Text = DateTime.Parse(Max_Tbl_MachineProblems_Estegaba_Mawad())
                                    Me.Txt_Time_End_Fix_Show.Text = DateTime.Parse(Max_Tbl_MachineProblems_End_Fix_Mawad())
                                    Me.Txt_Department_Show.Text = Max_Tbl_MachineProblems_Time_Department_Mawad()
                                Else
                                    ' إذا لم تتطابق الشروط المطلوبة
                                    MsgBox("لا يسمح لك بالوصول إلى هذا التطبيق")
                                    Me.Txt_Alarm_Mawad_password.Text = ""
                                End If
                            End If
                        Else
                            ' الرقم السري غير صحيح
                            MsgBox("خطأ في الرقم السري")
                            Me.Txt_Alarm_Mawad_password.Text = ""
                        End If
                    End Using
                End Using
            End Using
        End If
    End Sub

    Private Sub Txt_Alarm_Quality_password_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Alarm_Quality_password.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim enteredPassword As String = Txt_Alarm_Quality_password.Text.Trim()
            Using con As New SqlConnection(ConStr)
                If con.State = 1 Then con.Close()
                con.Open()
                ' استعلام للتحقق من وجود الرقم السري في جدول المستخدمين
                Dim query As String = "SELECT  * FROM Users WHERE Password = @EnteredPassword"
                Using command As New SqlCommand(query, con)
                    command.Parameters.AddWithValue("@EnteredPassword", enteredPassword)
                    ' قراءة البيانات المسترجعة من الاستعلام
                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            ' الرقم السري صحيح
                            reader.Read()
                            Dim UserID As String = reader("UserID").ToString()
                            Dim username As String = reader("Username").ToString()
                            Dim job As String = reader("Jop").ToString()
                            Dim dept As String = reader("Dept").ToString()
                            Dim forms As String = reader("Forms").ToString()
                            Dim D1 As String = reader("D1").ToString()
                            Dim D2 As String = reader("D2").ToString()
                            Dim F1 As String = reader("F1").ToString()
                            Dim F2 As String = reader("F2").ToString()
                            Dim H As String = reader("H").ToString()
                            If job = "مراقب جودة" And dept = "الجودة" Then
                                Dim isD1True As Boolean = D1
                                Dim isD2True As Boolean = D2
                                Dim isF1True As Boolean = F1
                                Dim isF2True As Boolean = F2
                                Dim isHTrue As Boolean = H
                                If Lbl_Machine.Text = "D1" AndAlso isD1True = "True" Or Lbl_Machine.Text = "D2" AndAlso isD2True = "True" Or Lbl_Machine.Text = "F1" AndAlso isF1True = "True" Or Lbl_Machine.Text = "F2" AndAlso isF2True = "True" Or Lbl_Machine.Text = "H" AndAlso isHTrue = "True" Then

                                    Txt_User.Text = username ' عرض اسم المستخدم في Txt_User
                                    ' القبول وعرض البيانات الإضافية
                                    ' إضافة الكود الخاص بعرض البيانات وفتح الواجهة المناسبة
                                    Me.Txt_Dept.Text = "الجودة"
                                    Me.Txt_Time.Text = Now
                                    Update_Tbl_MachineProblems_Time_press_the_Quality_button(DateTime.Parse(Txt_Time.Text), username, UserID, Txt_Dept.Text, ProblemCode.Text)
                                    Me.Btn_Alarm_Quality.Visible = False
                                    Me.Lbl_Alarm_Quality.Visible = False
                                    Me.Txt_Alarm_Quality_password.Visible = False
                                    Me.Txt_Alarm_Quality_password.Text = ""
                                    '''Me.Btn_Estgaba_Quality.Visible = True
                                    Me.Panel4.Visible = True
                                    'Me.Txt_Code_Proplem_Show.Text = Max_Tbl_MachineProblems_Time()
                                    Me.Txt_Code_Proplem_Show.Text = ProblemCode.Text
                                    Me.Txt_Time_Stop_Machine_Show.Text = DateTime.Parse(Max_Tbl_MachineProblems_Time_Stop_Machine(ProblemCode.Text))
                                    Me.Txt_Time_Start_Fix_Show.Text = DateTime.Parse(Max_Tbl_MachineProblems_Estegaba_Quality())
                                    Me.Txt_Time_End_Fix_Show.Text = DateTime.Parse(Max_Tbl_MachineProblems_End_Fix_Quality())
                                    Me.Txt_Department_Show.Text = Max_Tbl_MachineProblems_Time_Department_Quality()
                                Else
                                    ' إذا لم تتطابق الشروط المطلوبة
                                    MsgBox("لا يسمح لك بالوصول إلى هذا التطبيق")
                                    Me.Txt_Alarm_Quality_password.Text = ""
                                End If
                            End If
                        Else
                            ' الرقم السري غير صحيح
                            MsgBox("خطأ في الرقم السري")
                            Me.Txt_Alarm_Quality_password.Text = ""
                        End If
                    End Using
                End Using
            End Using
        End If
    End Sub

    Private Sub Txt_Alarm_Production_password_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Alarm_Production_password.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' الحصول على قيمة الرقم السري المدخل
            Dim enteredPassword As String = Txt_Alarm_Production_password.Text.Trim()
            Using con As New SqlConnection(ConStr)
                If con.State = 1 Then con.Close()
                con.Open()
                ' استعلام للتحقق من وجود الرقم السري في جدول المستخدمين
                Dim query As String = "SELECT  * FROM Users WHERE Password = @EnteredPassword"
                Using command As New SqlCommand(query, con)
                    command.Parameters.AddWithValue("@EnteredPassword", enteredPassword)
                    ' قراءة البيانات المسترجعة من الاستعلام
                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            ' الرقم السري صحيح
                            reader.Read()
                            Dim UserID As String = reader("UserID").ToString()
                            Dim username As String = reader("Username").ToString()
                            Dim job As String = reader("Jop").ToString()
                            Dim dept As String = reader("Dept").ToString()
                            Dim forms As String = reader("Forms").ToString()
                            Dim D1 As String = reader("D1").ToString()
                            Dim D2 As String = reader("D2").ToString()
                            Dim F1 As String = reader("F1").ToString()
                            Dim F2 As String = reader("F2").ToString()
                            Dim H As String = reader("H").ToString()
                            If (job = "مشغل ماكينة A" OrElse job = "مشغل ماكينة B" OrElse job = "فنى انتاج" OrElse job = "دعم فنى") And dept = "الانتاج" Then
                                Dim isD1True As Boolean = D1
                                Dim isD2True As Boolean = D2
                                Dim isF1True As Boolean = F1
                                Dim isF2True As Boolean = F2
                                Dim isHTrue As Boolean = H
                                If Lbl_Machine.Text = "D1" AndAlso isD1True = "True" Or Lbl_Machine.Text = "D2" AndAlso isD2True = "True" Or Lbl_Machine.Text = "F1" AndAlso isF1True = "True" Or Lbl_Machine.Text = "F2" AndAlso isF2True = "True" Or Lbl_Machine.Text = "H" AndAlso isHTrue = "True" Then
                                    Txt_User.Text = username ' عرض اسم المستخدم في Txt_User
                                    ' القبول وعرض البيانات الإضافية
                                    ' إضافة الكود الخاص بعرض البيانات وفتح الواجهة المناسبة
                                    Me.Txt_Dept.Text = "الانتاج"
                                    Me.Txt_Time.Text = Now
                                    Update_Tbl_MachineProblems_Time_press_the_Production_button(DateTime.Parse(Txt_Time.Text), username, UserID, Txt_Dept.Text, ProblemCode.Text)
                                    Me.Btn_Alarm_Production.Visible = False
                                    Me.Lbl_Alarm_Production.Visible = False
                                    Me.Txt_Alarm_Production_password.Visible = False
                                    Me.Txt_Alarm_Production_password.Text = ""
                                    '''Me.Btn_Estgaba_Production.Visible = True
                                    Me.Panel4.Visible = True
                                    If Combo_FailureSituation.Text = "تم حل المشكلة" Then
                                        Combo_FailureSituation.BackColor = Color.Green
                                    ElseIf Combo_FailureSituation.Text = "فى انتظار اقرب صيانة" Then
                                        Combo_FailureSituation.BackColor = Color.Yellow
                                    ElseIf Combo_FailureSituation.Text = "متوقفة تماماً" Then
                                        Combo_FailureSituation.BackColor = Color.Red
                                    End If
                                    '''Me.Txt_Code_Proplem_Show.Text = Max_Tbl_MachineProblems_Time()
                                    Me.Txt_Code_Proplem_Show.Text = ProblemCode.Text
                                    Me.Txt_Time_Stop_Machine_Show.Text = DateTime.Parse(Max_Tbl_MachineProblems_Time_Stop_Machine(ProblemCode.Text))
                                    Me.Txt_Time_Start_Fix_Show.Text = DateTime.Parse(Max_Tbl_MachineProblems_Estegaba_Production())
                                    Me.Txt_Time_End_Fix_Show.Text = DateTime.Parse(Max_Tbl_MachineProblems_End_Fix_Production())
                                    Me.Txt_Department_Show.Text = Max_Tbl_MachineProblems_Time_Department_Production()
                                    Combo_Unit.Focus()
                                Else
                                    ' إذا لم تتطابق الشروط المطلوبة
                                    MsgBox("لا يسمح لك بالوصول إلى هذا التطبيق")
                                    Me.Txt_Alarm_Production_password.Text = ""
                                End If
                            End If
                        Else
                            ' الرقم السري غير صحيح
                            MsgBox("خطأ في الرقم السري")
                            Me.Txt_Alarm_Production_password.Text = ""
                        End If
                    End Using
                End Using
            End Using
        End If
    End Sub

    Private Sub Txt_Alarm_SpareParts_password_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Alarm_SpareParts_password.KeyDown
        If e.KeyCode = Keys.Enter Then
            ' الحصول على قيمة الرقم السري المدخل
            Dim enteredPassword As String = Txt_Alarm_SpareParts_password.Text.Trim()
            Using con As New SqlConnection(ConStr)
                If con.State = 1 Then con.Close()
                con.Open()
                ' استعلام للتحقق من وجود الرقم السري في جدول المستخدمين
                Dim query As String = "SELECT  * FROM Users WHERE Password = @EnteredPassword"
                Using command As New SqlCommand(query, con)
                    command.Parameters.AddWithValue("@EnteredPassword", enteredPassword)
                    ' قراءة البيانات المسترجعة من الاستعلام
                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            ' الرقم السري صحيح
                            reader.Read()
                            Dim UserID As String = reader("UserID").ToString()
                            Dim username As String = reader("Username").ToString()
                            Dim job As String = reader("Jop").ToString()
                            Dim dept As String = reader("Dept").ToString()
                            Dim forms As String = reader("Forms").ToString()
                            Dim D1 As String = reader("D1").ToString()
                            Dim D2 As String = reader("D2").ToString()
                            Dim F1 As String = reader("F1").ToString()
                            Dim F2 As String = reader("F2").ToString()
                            Dim H As String = reader("H").ToString()
                            If (job = "مشغل ماكينة A" OrElse job = "مشغل ماكينة B" OrElse job = "فنى انتاج" OrElse job = "دعم فنى") And dept = "الانتاج" Then
                                Dim isD1True As Boolean = D1
                                Dim isD2True As Boolean = D2
                                Dim isF1True As Boolean = F1
                                Dim isF2True As Boolean = F2
                                Dim isHTrue As Boolean = H
                                If Lbl_Machine.Text = "D1" AndAlso isD1True = "True" Or Lbl_Machine.Text = "D2" AndAlso isD2True = "True" Or Lbl_Machine.Text = "F1" AndAlso isF1True = "True" Or Lbl_Machine.Text = "F2" AndAlso isF2True = "True" Or Lbl_Machine.Text = "H" AndAlso isHTrue = "True" Then

                                    Txt_User.Text = username ' عرض اسم المستخدم في Txt_User
                                    ' القبول وعرض البيانات الإضافية
                                    ' إضافة الكود الخاص بعرض البيانات وفتح الواجهة المناسبة
                                    Txt_Dept.Text = "مخزن قطع الغيار"
                                    Txt_Time.Text = Now
                                    Update_Tbl_MachineProblems_Time_press_the_SpareParts_button(DateTime.Parse(Txt_Time.Text), username, UserID, Txt_Dept.Text, ProblemCode.Text)
                                    Btn_Alarm_SpareParts.Visible = False
                                    Me.Lbl_Alarm_SpareParts.Visible = False
                                    Me.Txt_Alarm_SpareParts_password.Visible = False
                                    Me.Txt_Alarm_SpareParts_password.Text = ""
                                    '''Me.Btn_Estgaba_SpareParts.Visible = True
                                    Me.Panel4.Visible = True
                                    'Me.Txt_Code_Proplem_Show.Text = Max_Tbl_MachineProblems_Time()
                                    Me.Txt_Code_Proplem_Show.Text = ProblemCode.Text
                                    Me.Txt_Time_Stop_Machine_Show.Text = DateTime.Parse(Max_Tbl_MachineProblems_Time_Stop_Machine(ProblemCode.Text))
                                    Me.Txt_Time_Start_Fix_Show.Text = DateTime.Parse(Max_Tbl_MachineProblems_Estegaba_SpareParts())
                                    Me.Txt_Time_End_Fix_Show.Text = DateTime.Parse(Max_Tbl_MachineProblems_End_Fix_SpareParts())
                                    Me.Txt_Department_Show.Text = Max_Tbl_MachineProblems_Time_Department_SpareParts()
                                Else
                                    ' إذا لم تتطابق الشروط المطلوبة
                                    MsgBox("لا يسمح لك بالوصول إلى هذا التطبيق")
                                    Me.Txt_Alarm_SpareParts_password.Text = ""
                                End If
                            End If
                        Else
                            ' الرقم السري غير صحيح
                            MsgBox("خطأ في الرقم السري")
                            Me.Txt_Alarm_SpareParts_password.Text = ""
                        End If
                    End Using
                End Using
            End Using
        End If
    End Sub

    Private Sub Txt_Send_Report_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Send_Report.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim enteredPassword As String = Txt_Send_Report.Text.Trim()
            Using con As New SqlConnection(ConStr)
                If con.State = 1 Then con.Close()
                con.Open()
                Dim query As String = "SELECT * FROM Users WHERE Password = @EnteredPassword"
                'Dim Department As String = Txt_Department_Show.ToString()
                Using command As New SqlCommand(query, con)
                    command.Parameters.AddWithValue("@EnteredPassword", enteredPassword)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            ' الرقم السري صحيح
                            reader.Read()
                            Dim UserID As String = reader("UserID").ToString()
                            Dim username As String = reader("Username").ToString()
                            Dim job As String = reader("Jop").ToString()
                            Dim dept As String = reader("Dept").ToString()
                            'Dim forms As String = reader("Forms").ToString()
                            Dim D1 As String = reader("D1").ToString()
                            Dim D2 As String = reader("D2").ToString()
                            Dim F1 As String = reader("F1").ToString()
                            Dim F2 As String = reader("F2").ToString()
                            Dim H As String = reader("H").ToString()
                            Dim jobs() As String = {"مشغل ماكينة A", "مشغل ماكينة B", "فنى انتاج", "دعم فنى", "مراقب جودة", "مدير الكهرباء", "مهندس كهرباء", "فنى صيانة", "فنى كهرباء", "مدير الصيانة"}
                            ' البحث عن الوظيفة في المصفوفة
                            Dim isJobValid As Boolean = False
                            For Each validJob As String In jobs
                                If job = validJob AndAlso dept = Txt_Department_Show.Text Then
                                    ' الوظيفة صحيحة
                                    isJobValid = True
                                    Exit For
                                End If
                            Next
                            ' التحقق إذا كانت الوظيفة صحيحة
                            If isJobValid Then
                                'If (job = "مشغل ماكينة A" OrElse job = "مشغل ماكينة B" OrElse job = "فنى انتاج" OrElse job = "دعم فنى" OrElse job = "مراقب جودة" OrElse job = "مدير الكهرباء" OrElse job = "مهندس كهرباء") And dept = Txt_Department_Show.Text Then
                                Dim isD1True As Boolean = Convert.ToBoolean(D1)
                                Dim isD2True As Boolean = Convert.ToBoolean(D2)
                                Dim isF1True As Boolean = Convert.ToBoolean(F1)
                                Dim isF2True As Boolean = Convert.ToBoolean(F2)
                                Dim isHTrue As Boolean = Convert.ToBoolean(H)
                                If Lbl_Machine.Text = "D1" AndAlso isD1True = "True" Or Lbl_Machine.Text = "D2" AndAlso isD2True = "True" Or Lbl_Machine.Text = "F1" AndAlso isF1True = "True" Or Lbl_Machine.Text = "F2" AndAlso isF2True = "True" Or Lbl_Machine.Text = "H" AndAlso isHTrue = "True" Then
                                    Txt_User.Text = username
                                    Select Case Me.Txt_Department_Show.Text
                                        Case "مخزن قطع الغيار"
                                            Update_Tbl_MachineProblems_Time_Send_Report_SpareParts(Combo_Unit.Text, Combo_Cause_Malfunction.Text, Combo_FailureSituation.Text, Txt_Notes.Text, DateTime.Parse(Txt_Time.Text), username, UserID, ProblemCode.Text)

                                        Case "الكهرباء"
                                            Update_Tbl_MachineProblems_Time_Send_Report_Electricity(Combo_Unit.Text, Combo_Cause_Malfunction.Text, Combo_FailureSituation.Text, Txt_Notes.Text, DateTime.Parse(Txt_Time.Text), username, UserID, ProblemCode.Text)

                                        Case "الصيانة"
                                            Update_Tbl_MachineProblems_Time_Send_Report_Maintenance(Combo_Unit.Text, Combo_Cause_Malfunction.Text, Combo_FailureSituation.Text, Txt_Notes.Text, DateTime.Parse(Txt_Time.Text), username, UserID, ProblemCode.Text)

                                        Case "المواد الأولية"
                                            Update_Tbl_MachineProblems_Time_Send_Report_RawMaterials(Combo_Unit.Text, Combo_Cause_Malfunction.Text, Combo_FailureSituation.Text, Txt_Notes.Text, DateTime.Parse(Txt_Time.Text), username, UserID, ProblemCode.Text)

                                        Case "الجودة"
                                            Update_Tbl_MachineProblems_Time_Send_Report_Quality(Combo_Unit.Text, Combo_Cause_Malfunction.Text, Combo_FailureSituation.Text, Txt_Notes.Text, DateTime.Parse(Txt_Time.Text), username, UserID, ProblemCode.Text)

                                        Case "الانتاج"
                                            Update_Tbl_MachineProblems_Time_Send_Report_Production(Combo_Unit.Text, Combo_Cause_Malfunction.Text, Combo_FailureSituation.Text, Txt_Notes.Text, DateTime.Parse(Txt_Time.Text), username, UserID, ProblemCode.Text)

                                        Case Else
                                            MsgBox("حالة القسم غير معروفة.")
                                    End Select
                                    Me.Btn_Run_Machine.Visible = True
                                    Me.Txt_Send_Report.Text = ""
                                    Me.Txt_Send_Report.Text = ""
                                    Me.Combo_Unit.Text = ""
                                    Me.Combo_Cause_Malfunction.Text = ""
                                    Me.Combo_FailureSituation.Text = ""
                                    Me.Txt_Notes.Text = ""
                                    Me.Lbl_Send_ReportPass.Visible = False
                                    Me.Panel4.Visible = False
                                Else
                                    MsgBox("لا يسمح لك بالوصول إلى هذا التطبيق")
                                    Txt_Send_Report.Text = ""
                                End If
                            End If
                        Else
                            MsgBox("خطأ في الرقم السري")
                            Txt_Send_Report.Text = ""
                        End If
                    End Using
                End Using
            End Using
        End If
    End Sub

    Private Sub Btn_Send_Report_Click(sender As Object, e As EventArgs) Handles Btn_Send_Report.Click
        Me.Btn_Send_Report.Visible = False
        Lbl_Send_ReportPass.Visible = True
        Me.Txt_Send_Report.Visible = True
        Me.Txt_Send_Report.Focus()
    End Sub

    Private Sub Combo_Unit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_Unit.SelectedIndexChanged
        Dim dt As New DataTable
        Dim adapter As SqlDataAdapter
        Try
            adapter = New SqlDataAdapter("Select * from Tbl_Problem_Machine where Unit_ID = " & Combo_Unit.SelectedValue, Con)
            adapter.Fill(dt)
            Combo_Cause_Malfunction.DataSource = dt
            Combo_Cause_Malfunction.DisplayMember = "Problem_Name"
            Combo_Cause_Malfunction.ValueMember = "Problem_Code"
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub Combo_Unit_DropDown(sender As Object, e As EventArgs) Handles Combo_Unit.DropDown
        Dim dt As New DataTable
        Dim adapter As SqlDataAdapter
        Try
            adapter = New SqlDataAdapter("Select * from Tbl_Problem_Machine where Unit_ID = " & Combo_Unit.SelectedValue, Con)
            adapter.Fill(dt)
            Combo_Cause_Malfunction.DataSource = dt
            Combo_Cause_Malfunction.DisplayMember = "Problem_Name"
            Combo_Cause_Malfunction.ValueMember = "Problem_Code"
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub Combo_Cause_Malfunction_DropDown(sender As Object, e As EventArgs) Handles Combo_Cause_Malfunction.DropDown
        Try
            Dim dt As New DataTable
            Dim adapter As SqlDataAdapter

            ' تحقق من أن النص في الكمبوبوكس ليس فارغًا
            If Not String.IsNullOrEmpty(Combo_Cause_Malfunction.Text) Then
                ' استخدم استعلام SQL يستخدم LIKE للبحث عن النص المدخل
                adapter = New SqlDataAdapter("SELECT * FROM Tbl_Problem_Machine WHERE Problem_Name LIKE '%" & Combo_Cause_Malfunction.Text & "%' And Unit_ID = '%" & Combo_Cause_Malfunction.ValueMember & "%' ", Con)

                adapter.Fill(dt)
                Combo_Cause_Malfunction.DataSource = dt
                Combo_Cause_Malfunction.DisplayMember = "Problem_Name"
                Combo_Cause_Malfunction.ValueMember = "Problem_Code"
            End If
        Catch ex As Exception

            Exit Sub
        End Try
    End Sub

    Private Sub dgv_Notes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Notes.CellContentClick
        Try
            With Me.dgv_Notes
                Frm_Notes.Show()
                Frm_Notes.BtnSave1.Visible = False
                Frm_Notes.Note_Info.ReadOnly = True
                Frm_Notes.Txt_Reply.Visible = True
                Frm_Notes.BtnEdit.Visible = True
                Frm_Notes.Label2.Visible = True
                Frm_Notes.Txt_Reply.Focus()
                Frm_Notes.Note_Info.Text = .CurrentRow.Cells("Note_Info").Value.ToString()
                Frm_Notes.Note_ID.Text = .CurrentRow.Cells("Note_ID").Value.ToString()
                Frm_Notes.Machine_Note.Text = .CurrentRow.Cells("Machine_Note").Value.ToString()
                Frm_Notes.Note_Date.Value = .CurrentRow.Cells("Note_Date").Value.ToString()
                Frm_Notes.Txt_Reply.Text = .CurrentRow.Cells("Reply").Value.ToString()
                If Frm_Notes.Txt_Reply.Text = vbNullString Then
                    Frm_Notes.BtnHide.Visible = False
                Else
                    Frm_Notes.BtnHide.Visible = True
                End If

            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Combo_FailureSituation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo_FailureSituation.SelectedIndexChanged
        If Combo_FailureSituation.Text = "تم حل المشكلة" Then
            Combo_FailureSituation.BackColor = Color.Green
        ElseIf Combo_FailureSituation.Text = "فى انتظار اقرب صيانة" Then
            Combo_FailureSituation.BackColor = Color.Yellow
        ElseIf Combo_FailureSituation.Text = "متوقفة تماماً" Then
            Combo_FailureSituation.BackColor = Color.Red
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        SelectAll_Tbl_Notes(dgv_Notes)
    End Sub

    Public Sub SelectAll_Tbl_Notes(dgv As DataGridView)
        Dim StartDate As Date
        Dim EndDate As Date
        Dim MachineName As String
        MachineName = Lbl_Machine.Text.ToString()
        StartDate = Now.Date.AddHours(0).AddMinutes(0).AddSeconds(0)
        EndDate = Now.Date.AddHours(23).AddMinutes(59).AddSeconds(59)
        ' استخدام SqlCommand بدلاً من SqlDataAdapter
        'Dim cmd As New SqlCommand("SELECT Note_Info FROM Tbl_Notes WHERE Note_Date BETWEEN @StartDate AND @EndDate AND Machine_Note = @MachineName", Con)
        '''Dim cmd As New SqlCommand("SELECT * FROM Tbl_Notes WHERE Note_Date BETWEEN @StartDate AND @EndDate AND Machine_Note = @MachineName", Con)
        Dim cmd As New SqlCommand("SELECT * FROM Tbl_Notes WHERE Note_Date BETWEEN @StartDate AND @EndDate AND Machine_Note = @MachineName And Archvie IS NULL  ORDER BY Note_Date DESC", Con)
        cmd.Parameters.AddWithValue("@StartDate", StartDate)
        cmd.Parameters.AddWithValue("@EndDate", EndDate)
        cmd.Parameters.AddWithValue("@MachineName", MachineName)
        Dim da As New SqlDataAdapter(cmd)
        dt_Tbl_Notes.Clear()
        da.Fill(dt_Tbl_Notes)
        dgv.DataSource = dt_Tbl_Notes
        With dgv_Notes
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
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
            .Columns(6).HeaderText = "الحالة"
            .Columns(6).Visible = False
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Frm_Notes.ShowDialog()
        Frm_Notes.Machine_Note.Text = Me.Lbl_Machine.Text
        Frm_Notes.Note_Info.Focus()
    End Sub
End Class

