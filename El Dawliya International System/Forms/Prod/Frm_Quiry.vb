Imports System.Data.SqlClient
Imports El_Dawliya_International_System.El_Dawliya_International_System.Forms.Report

Public Class Frm_Quiry
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Dim DTT As New DataTable

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

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub Frm_Quiry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Txt_UserID.Text = loggedInUserName
        Me.Txt_User.Text = loggedInUserID
        fillcmb_Tbl_Department(Combo_Dept)
        If Combo_Machine.DataSource Is Nothing Then
            If loggedInUserName = "D1" Then
                'Combo_Machine.Items.Add("D1")
                Dim machineValues As String() = {"D1"}
                Combo_Machine.DataSource = machineValues
            ElseIf loggedInUserName = "D2" Then
                'Combo_Machine.Items.Add("D2")
                Dim machineValues As String() = {"D2"}

                Combo_Machine.DataSource = machineValues
            ElseIf loggedInUserName = "F1" Then
                'Combo_Machine.Items.Add("F1")
                Dim machineValues As String() = {"F1"}
                Combo_Machine.DataSource = machineValues
            ElseIf loggedInUserName = "F2" Then
                'Combo_Machine.Items.Add("F2")
                Dim machineValues As String() = {"F2"}
                Combo_Machine.DataSource = machineValues
            ElseIf loggedInUserName = "H" Then
                'Combo_Machine.Items.Add("H")
                Dim machineValues As String() = {"H"}
                Combo_Machine.DataSource = machineValues
            Else
                'Combo_Machine.Items.AddRange(New String() {"D1", "D2", "F1", "F2", "H"})
                Dim machineValues As String() = {"D1", "D2", "F1", "F2", "H"}
                Combo_Machine.DataSource = machineValues
            End If
        End If
    End Sub

    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
        DTT.Clear()

        Try
            Dim startDate As Date = Txt_StartDate.Value
            Dim endDate As Date = Txt_EndDate.Value
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
                    'query = $"SELECT {selectedFields} FROM Tbl_MachineProblems_Time WHERE Machine_stop_time BETWEEN @StartDate AND @EndDate AND {fieldToQuery} = @SelectedValue  "
                    'query = $"SELECT {selectedFields} FROM Tbl_MachineProblems_Time WHERE Machine_stop_time BETWEEN @StartDate AND @EndDate  And {fieldToQuery} = @SelectedValue AND Machine_Name = @MachineName"
                    query = $"SELECT {selectedFields} FROM Tbl_MachineProblems_Time WHERE  Machine_Name = @MachineName And Machine_stop_time BETWEEN @StartDate AND @EndDate AND {fieldToQuery} = @SelectedValue "
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@MachineName", MachineName)
                        command.Parameters.AddWithValue("@StartDate", startDate)
                        command.Parameters.AddWithValue("@EndDate", endDate)
                        command.Parameters.AddWithValue("@SelectedValue", selectedValue)
                        Dim adapter As New SqlDataAdapter(command)
                        'Dim DTT As New DataTable()
                        adapter.Fill(DTT)
                        dgv_Data.DataSource = DTT
                        With dgv_Data
                            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
                            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                            .Columns(0).HeaderText = "كود المشكلة"
                            .Columns(1).HeaderText = "وقت ايقاف الماكينة"
                            .Columns(1).DefaultCellStyle.Format = "HH:mm"
                            .Columns(2).HeaderText = "وقت تحديد المشكلة"
                            .Columns(2).DefaultCellStyle.Format = "HH:mm"
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
                            .Columns(13).HeaderText = "من قام بكتابة الملاحظات"
                            .Columns(14).Visible = False
                            .Columns(14).HeaderText = "القسم"
                            .Columns(15).Visible = False
                            .Columns(15).HeaderText = "اسم الماكينة"
                            .Columns(15).Width = 100
                            .Columns(16).Visible = False
                            .Columns(16).HeaderText = "تشغيل الماكينة"
                            .Columns(16).DefaultCellStyle.Format = "HH:mm"
                            .Columns(17).Visible = False
                            .Columns(17).HeaderText = "الوقت الكلى للإستجابة للمشكلة"
                            .Columns(18).Visible = False
                            .Columns(18).HeaderText = "الوقت الكلى لحل المشكلة"
                            '.Columns(19).Visible = False
                            .Columns(19).HeaderText = "الوقت الكلى للمشكلة"
                            .Columns(19).DefaultCellStyle.Format = "HH:mm:ss"
                        End With
                        Lbl_Count_Proplem.Text = dgv_Data.RowCount.ToString()
                        ' تحديث Label بمجموع الوقت في العمود رقم 19 في DataGridView
                        Dim totalTime As TimeSpan = TimeSpan.Zero
                        ' حلقة عبر جميع الصفوف في العمود رقم 19
                        For Each row As DataGridViewRow In dgv_Data.Rows
                            If row.Cells.Count >= 20 AndAlso row.Cells(19).Value IsNot Nothing Then
                                Dim timeValue As String = row.Cells(19).Value.ToString()

                                Dim dateTimeValue As DateTime
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
                        Dim totalDays As Integer = CInt(totalTime.TotalDays)
                        Dim totalHours As Integer = CInt(totalTime.TotalHours) Mod 24
                        Dim totalMinutes As Integer = CInt(totalTime.TotalMinutes) Mod 60
                        Dim totalSeconds As Integer = CInt(totalTime.TotalSeconds) Mod 60

                        Lbl_Total_Time_All_Proplem.Text = $"{totalDays} أيام، {totalHours} ساعات، {totalMinutes} دقائق، {totalSeconds} ثواني"

                        'Lbl_Total_Time_All_Proplem.Text = totalTime.ToString("hh\:mm\:ss")

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
                Me.Txt_Unity_problem.Text = .CurrentRow.Cells(8).Value.ToString()
                Me.Txt_Part_problem.Text = .CurrentRow.Cells(9).Value.ToString()
                Me.Txt_Problem_status.Text = .CurrentRow.Cells(10).Value.ToString()
                Me.Txt_Notes.Text = .CurrentRow.Cells(11).Value.ToString()
                Me.Txt_Time_write_notes.Text = .CurrentRow.Cells(12).Value.ToString()
                Me.Txt_Who_Note_writer.Text = .CurrentRow.Cells(13).Value.ToString()
                Me.Txt_Department_Proplem.Text = .CurrentRow.Cells(14).Value.ToString()
                Me.Txt_Machine_running_time.Text = .CurrentRow.Cells(16).Value.ToString()
                Try
                    Dim totalTime As TimeSpan = TimeSpan.Zero
                    Dim timeValue As String = .CurrentRow.Cells(19).Value.ToString()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.Text = "" Then
            Dim rep As New Rep_Machine_Stop
            rep.SetDataSource(DTT.DefaultView)
            rep.Section1.SectionFormat.BackgroundColor = Color.FromArgb(248, 247, 255)
            rep.Section2.SectionFormat.BackgroundColor = Color.FromArgb(248, 247, 255)
            rep.Section3.SectionFormat.BackgroundColor = Color.FromArgb(248, 247, 255)
            rep.Section4.SectionFormat.BackgroundColor = Color.FromArgb(248, 247, 255)
            rep.Section5.SectionFormat.BackgroundColor = Color.FromArgb(248, 247, 255)
            Frm_Report.CrystalReportViewer1.ReportSource = rep
            rep.SetParameterValue("FromDate", Convert.ToDateTime(Me.Txt_StartDate.Value))
            rep.SetParameterValue("ToDate", Convert.ToDateTime(Me.Txt_EndDate.Value))
            Frm_Report.CrystalReportViewer1.Refresh()
            Frm_Report.ShowDialog()
        ElseIf ComboBox1.Text = "المشاكل تخطت نصف ساعة" Then
            Dim rep As New Report_major_problems
            rep.SetDataSource(DTT.DefaultView)
            rep.Section1.SectionFormat.BackgroundColor = Color.FromArgb(248, 247, 255)
            rep.Section2.SectionFormat.BackgroundColor = Color.FromArgb(248, 247, 255)
            rep.Section3.SectionFormat.BackgroundColor = Color.FromArgb(248, 247, 255)
            rep.Section4.SectionFormat.BackgroundColor = Color.FromArgb(248, 247, 255)
            rep.Section5.SectionFormat.BackgroundColor = Color.FromArgb(248, 247, 255)
            Frm_Report.CrystalReportViewer1.ReportSource = rep
            rep.SetParameterValue("FromDate", Convert.ToDateTime(Me.Txt_StartDate.Value))
            rep.SetParameterValue("ToDate", Convert.ToDateTime(Me.Txt_EndDate.Value))
            Frm_Report.CrystalReportViewer1.Refresh()
            Frm_Report.ShowDialog()
        End If

    End Sub

    Private Sub Combo_Shift_TextChanged(sender As Object, e As EventArgs) Handles Combo_Shift.TextChanged
        Dim dv As DataView
        Dim shift As String = Combo_Shift.Text
        If DTT IsNot Nothing Then
            dv = New DataView(DTT) ' يتم إنشاء نسخة من الداتا تابل
            Select Case shift
                Case "الاولى"
                    dv.RowFilter = "SUBSTRING(CONVERT(Machine_stop_time, 'System.String'), 12, 8) >= '07:30:00' AND SUBSTRING(CONVERT(Machine_stop_time, 'System.String'), 12, 8) <= '15:30:00'"
                Case "الثانية"
                    dv.RowFilter = "SUBSTRING(CONVERT(Machine_stop_time, 'System.String'), 12, 8) >= '15:30:01' AND SUBSTRING(CONVERT(Machine_stop_time, 'System.String'), 12, 8) <= '23:30:00'"
                Case "الثالثة"
                    dv.RowFilter = "SUBSTRING(CONVERT(Machine_stop_time, 'System.String'), 12, 8) >= '23:30:01' OR SUBSTRING(CONVERT(Machine_stop_time, 'System.String'), 12, 8) <= '07:29:59'"
            End Select
            dgv_Data.DataSource = dv 'عرض الداتا الجديده في الداتا جريد
        End If
    End Sub

End Class
