Imports System.Data.SqlClient
Public Class Frm_Quiry_ForEmp
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Public Sub fillcmb_Tbl_Department(ByVal cmb As ComboBox)
        Dim DT As New DataTable
        Dim DA As New SqlDataAdapter
        DT.Clear()
        'DA = New SqlDataAdapter("Select Dept_Name FROM Tbl_Department", Con)
        DA = New SqlDataAdapter("SELECT Dept_Name FROM Tbl_Department WHERE Dept_Code IN (1,2,3,4,5,7)", Con)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            cmb.DataSource = DT
            cmb.ValueMember = "Dept_Name" ' افترض أنه يوجد عمود بالاسم "Dept_Code" يحتوي على القيم الفعلية
            'cmb.DisplayMember = "Dept_Name"
        Else
            cmb.DataSource = Nothing
        End If
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBoxClose.Click
        Me.Close()
    End Sub
    Private Sub Frm_Quiry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ChangeScreenResolution(Me)
        '''Modul_Font.ApplyFontToTextBoxesAndLabels(Me)
        '''Modul_Font.ApplyFontToDateTimePickers(Me)
        Dim StartDate As Date
        Dim EndDate As Date
        StartDate = Now.Date.AddHours(0).AddMinutes(0).AddSeconds(0)
        EndDate = Now.Date.AddHours(47).AddMinutes(59).AddSeconds(59)
        Me.Txt_UserID.Text = loggedInUserName
        Me.Txt_User.Text = loggedInUserID
        fillcmb_Tbl_Department(Combo_Dept)
        If Combo_Machine.DataSource Is Nothing Then
            If loggedInUserName = "D1" Or loggedInUserName = "d1" Then
                'Combo_Machine.Items.Add("D1")
                Dim machineValues As String() = {"D1"}
                Combo_Machine.DataSource = machineValues
            ElseIf loggedInUserName = "D2" Or loggedInUserName = "d2" Then
                'Combo_Machine.Items.Add("D2")
                Dim machineValues As String() = {"D2"}
                Combo_Machine.DataSource = machineValues
            ElseIf loggedInUserName = "F1" Or loggedInUserName = "f1" Then
                'Combo_Machine.Items.Add("F1")
                Dim machineValues As String() = {"F1"}
                Combo_Machine.DataSource = machineValues
            ElseIf loggedInUserName = "F2" Or loggedInUserName = "f2" Then
                'Combo_Machine.Items.Add("F2")
                Dim machineValues As String() = {"F2"}
                Combo_Machine.DataSource = machineValues
            ElseIf loggedInUserName = "H" Or loggedInUserName = "h" Then
                'Combo_Machine.Items.Add("H")
                Dim machineValues As String() = {"H"}
                Combo_Machine.DataSource = machineValues
            Else
                'Combo_Machine.Items.AddRange(New String() {"D1", "D2", "F1", "F2", "H"})
                Dim machineValues As String() = {"D1", "D2", "F1", "F2", "H"}
                Combo_Machine.DataSource = machineValues
            End If
        End If
        Txt_StartDate.Value = StartDate
        Txt_EndDate.Value = EndDate
    End Sub
    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
        Dim startDate As Date = Txt_StartDate.Value
        Dim endDate As Date = Txt_EndDate.Value
        If Combo_Shift.Text = vbNullString Then
            'startDate = Now.Date.AddHours(0).AddMinutes(0).AddSeconds(0)
            startDate = Now.AddHours(-48)
            endDate = Now.Date.AddHours(23).AddMinutes(59).AddSeconds(59)
        ElseIf Combo_Shift.Text = "الاولى" Then
            startDate = Now.Date.AddHours(7).AddMinutes(30).AddSeconds(0)
            endDate = Now.Date.AddHours(15).AddMinutes(29).AddSeconds(59)
        ElseIf Combo_Shift.Text = "الثانية" Then
            startDate = Now.Date.AddHours(15).AddMinutes(30).AddSeconds(0)
            endDate = Now.Date.AddHours(23).AddMinutes(29).AddSeconds(59)
        ElseIf Combo_Shift.Text = "الثالثة" Then
            startDate = Now.Date.AddHours(23).AddMinutes(30).AddSeconds(0)
            endDate = Now.Date.AddHours(7).AddMinutes(29).AddSeconds(59)
        End If
        Try
            Dim MachineName As String = If(Combo_Machine.SelectedValue IsNot Nothing, Combo_Machine.SelectedValue.ToString(), "")
            'Dim MachineName As String = Combo_Machine.SelectedValue.ToString()
            Dim selectedValue As String = Combo_Dept.SelectedValue.ToString()
            Dim query As String = ""
            Dim StrProduction As String = "Problem_Code,Machine_stop_time,PressProductionButtonTime,PressedProductionButtonBy,ProductionTechnicianResponseTime,ProductionResponseTechnician,ProductionResolutionTime,ProductionResolutionTechnician,BreakdownUnit_Production,FailurePartForProduction,ProductionFailureSituation,ProductionNotes,WriteNotesTime_Production,NotesAuthor_Production,Section_Production,Machine_Name,FinalMachineRunningTime,TotalResponseTime_Production,TotalResolutionTime_Production,TotalProblemTime "
            Dim StrMaintenance As String = "Problem_Code,Machine_stop_time,VisitTime_Maintenance,PressedMaintenanceButtonBy,MaintenanceTechnicianResponseTime,MaintenanceResponseTechnician,MaintenanceResolutionTime,MaintenanceResolutionTechnician,MalfunctionUnit_Maintenance,MalfunctionPart_Maintenance,FailureCondition_Maintenance,MaintenanceNotes,WriteNotesTime_Maintenance,NotesAuthor_Maintenance,Section_Maintenance,Machine_Name,FinalMachineRunningTime,TotalResponseTime_Maintenance,TotalResolutionTime_Maintenance,TotalProblemTime" ' استبدل بالحقول التي تحتاجها
            Dim StrQuality As String = "Problem_Code,Machine_stop_time,PressQualityButtonTime,PressedQualityButtonBy,QualityTechnicianResponseTime,QualityResponseTechnician,QualityResolutionTime,QualityResolutionTechnician,MalfunctionUnit_Quality,PartFailure_Quality,QualityFailureCondition,QualityNotes,WriteNotesTime_Quality,NotesAuthor_Quality,Section_Quality,Machine_Name,FinalMachineRunningTime,TotalResponseTime_Quality,TotalResolutionTime_Quality,TotalProblemTime"
            Dim StrElectricity As String = "Problem_Code,Machine_stop_time, Time_to_press_the_power_button, Who_pressed_the_power_button, Response_time_to_electrical_fault, Electrical_technician_name, Time_Solve_Power_Malfunction, Electrician_Who_Solved_Problem, Electricity_Unit, Cause_Electricity_Malfunction, Power_malfunction_status, Notes_Electricity, Time_to_write_notes_electricity, Who_wrote_the_electricity_notes, Electricity_Department,Machine_Name,FinalMachineRunningTime,TotalResponseTime_Electricity,TotalResolutionTime_Electricity,TotalProblemTime" ' استبدل بالحقول التي تحتاجها
            Dim StrRawMaterials As String = "Problem_Code,Machine_stop_time,VisitTime_RawMaterials,ClickedRawMaterialsButtonBy,RawMaterialsTechnicianResponseTime,RawMaterialsResponseTechnician,RawMaterialsResolutionTime,RawMaterialsResolutionTechnician,FailureUnit_RawMaterials,FailurePart_RawMaterials,FailureCondition_RawMaterials,RawMaterialsNotes,WriteNotesTime_RawMaterials,NotesAuthor_RawMaterials,Section_RawMaterials,Machine_Name,FinalMachineRunningTime,TotalResponseTime_RawMaterials,TotalResolutionTime_RawMaterials,TotalProblemTime" ' استبدل بالحقول التي تحتاجها
            Dim StrSpareParts As String = "Problem_Code,Machine_stop_time,PressSparePartsButtonTime,PressedSparePartsButtonBy,SparePartsTechnicianResponseTime,SparePartsResponseTechnician,SparePartsResolutionTime,SparePartsResolutionTechnician,BreakdownUnit_SpareParts,FailurePartForSpareParts,SparePartsFailure,SparePartsNotes,WriteNotesTime_SpareParts,NotesAuthor_SpareParts,Section_SpareParts,Machine_Name,FinalMachineRunningTime,TotalResponseTime_SpareParts,TotalResolutionTime_SpareParts,TotalProblemTime"
            Using connection As New SqlConnection(GetConnectionString())
                connection.Open() ' فتح الاتصال
                ' تحديد الحقل الذي سيتم الاستعلام به بناءً على الاختيار
                Dim fieldToQuery As String = ""
                Dim selectedFields As String = ""
                If selectedValue = "الصيانة" Then
                    fieldToQuery = "Section_Maintenance"
                    selectedFields = StrMaintenance
                ElseIf selectedValue = "الكهرباء" Then
                    fieldToQuery = "Electricity_Department"
                    selectedFields = StrElectricity
                ElseIf selectedValue = "المواد الأولية" Then
                    fieldToQuery = "Section_RawMaterials"
                    selectedFields = StrRawMaterials
                ElseIf selectedValue = "الجودة" Then
                    fieldToQuery = "Section_Quality"
                    selectedFields = StrQuality
                ElseIf selectedValue = "الانتاج" Then
                    fieldToQuery = "Section_Production"
                    selectedFields = StrProduction
                ElseIf selectedValue = "مخزن قطع الغيار" Then
                    fieldToQuery = "Section_SpareParts"
                    selectedFields = StrSpareParts
                End If
                ' بناء الاستعلام باستخدام الحقل المحدد والحقول المختارة
                If Not String.IsNullOrEmpty(fieldToQuery) AndAlso Not String.IsNullOrEmpty(selectedFields) Then
                    query = $"SELECT {selectedFields} FROM Tbl_MachineProblems_Time WHERE  Machine_Name = @MachineName And Machine_stop_time BETWEEN @StartDate AND @EndDate AND {fieldToQuery} = @SelectedValue "
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@MachineName", MachineName)
                        command.Parameters.AddWithValue("@StartDate", startDate)
                        command.Parameters.AddWithValue("@EndDate", endDate)
                        command.Parameters.AddWithValue("@SelectedValue", selectedValue)
                        Dim adapter As New SqlDataAdapter(command)
                        Dim dataTable As New DataTable()
                        adapter.Fill(dataTable)
                        dgv_Data.DataSource = dataTable
                        With dgv_Data
                            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                            .Columns(0).HeaderText = "كود المشكلة"

                            .Columns(1).HeaderText = "وقت ايقاف الماكينة"
                            .Columns(1).DefaultCellStyle.Format = "HH:mm"
                            .Columns(2).HeaderText = "وقت تحديد المشكلة"
                            .Columns(2).DefaultCellStyle.Format = "HH:mm"
                            .Columns(3).Visible = False
                            .Columns(3).HeaderText = "من قام بتحديد المشكلة"
                            .Columns(4).Visible = False
                            .Columns(4).HeaderText = "وقت حضور الفنى"
                            .Columns(4).DefaultCellStyle.Format = "HH:mm"
                            .Columns(5).Visible = False
                            .Columns(5).HeaderText = "اسم الفنى"
                            .Columns(6).Visible = False
                            .Columns(6).HeaderText = "وقت إصلاح العطل"
                            .Columns(6).DefaultCellStyle.Format = "HH:mm"
                            .Columns(7).Visible = False
                            .Columns(7).HeaderText = "من الذى أصلح العطل"
                            .Columns(8).HeaderText = "وحدة العطل"
                            .Columns(9).HeaderText = "جزء العطل"
                            .Columns(10).HeaderText = "حالة العطل"
                            .Columns(11).HeaderText = "ملاحظات المشكلة"
                            .Columns(12).Visible = False
                            .Columns(12).HeaderText = "وقت كتابة الملاحظات"
                            .Columns(12).DefaultCellStyle.Format = "HH:mm"
                            .Columns(13).Visible = False
                            .Columns(13).HeaderText = "من قام بكتابة الملاحظات"
                            .Columns(14).HeaderText = "القسم"
                            .Columns(15).HeaderText = "اسم الماكينة"
                            .Columns(16).HeaderText = "وقت تشغيل الماكينة"
                            .Columns(16).DefaultCellStyle.Format = "HH:mm"
                            .Columns(17).Visible = False
                            .Columns(17).HeaderText = "الوقت الكلى للإستجابة للمشكلة"
                            .Columns(18).Visible = False
                            .Columns(18).HeaderText = "الوقت الكلى لحل المشكلة"
                            .Columns(19).Visible = False
                            .Columns(19).HeaderText = "الوقت الكلى للمشكلة"
                        End With
                        Lbl_Count_Proplem.Text = dgv_Data.RowCount.ToString()
                        ' تحديث Label بمجموع الوقت في العمود رقم 19 في DataGridView
                        Dim totalTime As TimeSpan = TimeSpan.Zero
                        ' حلقة عبر جميع الصفوف في العمود رقم 19
                        For Each row As DataGridViewRow In dgv_Data.Rows
                            If row.Cells.Count >= 20 AndAlso row.Cells(19).Value IsNot Nothing Then
                                Dim timeValue As String = row.Cells(19).Value.ToString()
                                ' قم بتحويل النص إلى DateTime
                                Dim dateTimeValue As DateTime
                                'If DateTime.TryParseExact(timeValue, "dd-MM-yyyy hh:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.None, dateTimeValue) Then
                                '        ' قم بتحويل DateTime إلى TimeSpan وإضافته إلى المجموع
                                '        totalTime = totalTime.Add(dateTimeValue.TimeOfDay)
                                '    Else
                                '        ' إذا كان هناك استثناء FormatException، فقد يكون الوقت غير صحيح
                                '        MessageBox.Show("قيمة الوقت غير صحيحة. يرجى التأكد من التنسيق الصحيح.")
                                'End If
                                If DateTime.TryParse(timeValue, dateTimeValue) Then
                                    ' قم بتحويل DateTime إلى TimeSpan وإضافته إلى المجموع
                                    totalTime = totalTime.Add(dateTimeValue.TimeOfDay)
                                Else
                                    ' إذا كان هناك استثناء FormatException، فقد يكون الوقت غير صحيح
                                    MessageBox.Show("قيمة الوقت غير صحيحة. يرجى التأكد من التنسيق الصحيح.")
                                End If
                            End If
                        Next
                        ' عرض المجموع في Label
                        Lbl_Total_Time_All_Proplem.Text = totalTime.ToString("hh\:mm\:ss")
                    End Using
                Else
                    ' إذا لم يتم تحديد حقل صالح أو حقول مختارة
                    MessageBox.Show("حدث خطأ في تحديد الحقل أو الحقول للاستعلام.")
                End If
            End Using
        Catch ex As Exception
            ' التعامل مع الأخطاء والاستثناءات هنا
            MessageBox.Show("حدث خطأ أثناء تنفيذ العملية. الخطأ الفعلي: " & ex.Message)
        End Try
    End Sub
    Private Sub dgv_Data_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Data.CellContentClick
        Txt_Notes.ScrollBars = ScrollBars.Vertical
        Try
            With dgv_Data
                Me.Txt_Proplem_Code.Text = .CurrentRow.Cells(0).Value.ToString()
                Me.Txt_StopMachineTime.Text = .CurrentRow.Cells(1).Value.ToString()
                Me.Txt_Time_identify_problem.Text = .CurrentRow.Cells(2).Value.ToString()
                Me.Txt_Who_identified_problem.Text = .CurrentRow.Cells(3).Value.ToString()
                '''Me.Txt_Technician_attendance_time.Text = .CurrentRow.Cells(4).Value.ToString()
                '''Me.Txt_Technician_name.Text = .CurrentRow.Cells(5).Value.ToString()
                '''Me.Txt_Time_fix_problem.Text = .CurrentRow.Cells(6).Value.ToString()
                '''Me.Txt_Who_fixed_problem.Text = .CurrentRow.Cells(7).Value.ToString()
                Me.Txt_Unity_problem.Text = .CurrentRow.Cells(8).Value.ToString()
                Me.Txt_Part_problem.Text = .CurrentRow.Cells(9).Value.ToString()
                Me.Txt_Problem_status.Text = .CurrentRow.Cells(10).Value.ToString()
                Me.Txt_Notes.Text = .CurrentRow.Cells(11).Value.ToString()
                Me.Txt_Time_write_notes.Text = .CurrentRow.Cells(12).Value.ToString()
                Me.Txt_Who_Note_writer.Text = .CurrentRow.Cells(13).Value.ToString()
                Me.Txt_Department_Proplem.Text = .CurrentRow.Cells(14).Value.ToString()
                'Me.Txt_Time_fix_problem.Text = .CurrentRow.Cells(15).Value.ToString()
                Me.Txt_Machine_running_time.Text = .CurrentRow.Cells(16).Value.ToString()
                'Me.Txt_Total_response_time.Text = .CurrentRow.Cells(17).Value.ToString()
                '''Try
                '''    Dim responseTimeValue As String = .CurrentRow.Cells(17).Value.ToString()
                '''    Dim responseDateTimeValue As DateTime = DateTime.ParseExact(responseTimeValue, "dd-MM-yyyy hh:mm:ss tt", CultureInfo.InvariantCulture)
                '''    Me.Txt_Total_response_time.Text = responseDateTimeValue.ToString("HH:mm:ss")
                '''Catch ex As FormatException
                '''    MessageBox.Show("قيمة الوقت للرد غير صحيحة. يرجى التأكد من التنسيق الصحيح.")
                '''End Try

                'Me.Txt_Total_time_solve_problem.Text = .CurrentRow.Cells(18).Value.ToString()
                '''Try
                '''    Dim solveTimeValue As String = .CurrentRow.Cells(18).Value.ToString()
                '''    Dim solveDateTimeValue As DateTime = DateTime.ParseExact(solveTimeValue, "dd-MM-yyyy hh:mm:ss tt", CultureInfo.InvariantCulture)
                '''    Me.Txt_Total_time_solve_problem.Text = solveDateTimeValue.ToString("HH:mm:ss")
                '''Catch ex As FormatException
                '''    MessageBox.Show("قيمة الوقت لحل المشكلة غير صحيحة. يرجى التأكد من التنسيق الصحيح.")
                '''End Try
                'Me.Txt_Total_time_problem.Text = .CurrentRow.Cells(19).Value.ToString()
                Try
                    Dim totalTime As TimeSpan = TimeSpan.Zero
                    Dim timeValue As String = .CurrentRow.Cells(19).Value.ToString()
                    ' قم بتحويل النص إلى DateTime
                    Dim dateTimeValue As DateTime
                    If DateTime.TryParse(timeValue, dateTimeValue) Then
                        ' قم بتحويل DateTime إلى TimeSpan وإضافته إلى المجموع
                        totalTime = totalTime.Add(dateTimeValue.TimeOfDay)
                    End If
                    Me.Txt_Total_time_problem.Text = dateTimeValue.ToString("HH\: mm\: ss")
                Catch ex As FormatException
                    MessageBox.Show("قيمة الوقت غير صحيحة. يرجى التأكد من التنسيق الصحيح.")
                End Try
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Frm_Quiry_ForEmp_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        'RestoreScreenResolution(Me)
    End Sub
End Class
