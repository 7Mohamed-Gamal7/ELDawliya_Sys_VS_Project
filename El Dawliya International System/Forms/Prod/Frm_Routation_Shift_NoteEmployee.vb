Imports System.Data.SqlClient

Public Class Frm_Routation_Shift_NoteEmployee

    Private Shared _instance As PerformanceManager
    Private ReadOnly _performanceCounters As New Dictionary(Of String, Stopwatch)
    Private ReadOnly _memoryThreshold As Long = 500 * 1024 * 1024 ' 500 MB
    Private ReadOnly _logger As Logger = Logger.GetInstance() ' إضافة تهيئة للمتغير _logger
    Dim pm As PerformanceManager = PerformanceManager.GetInstance()

    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Public dt_Tbl_Employee As New DataTable
    Dim ds As New DataSet
    Private columnsToExport As Object






    Private Function GetColumnHeaderName(columnName As String) As String
        Select Case columnName
            Case "Emp_ID" : Return "الكود"
            Case "Emp_First_Name" : Return "الاسم الأول"
            Case "Emp_Second_Name" : Return "الاسم الثاني"
            Case "Emp_Full_Name" : Return "اسم الموظف"
            Case "Emp_Name_English" : Return "الاسم باللغة الإنجليزية"
            Case "Emp_Phone1" : Return "رقم التليفون الأول"
            Case "Emp_Phone2" : Return "رقم التليفون الثاني"
            Case "Emp_Address" : Return "العنوان"
            Case "Emp_Marital_Status" : Return "الحالة الاجتماعية"
            Case "Emp_Nationality" : Return "الجنسية"
            Case "People_With_Special_Needs" : Return "أشخاص ذوي احتياجات خاصة"
            Case "National_ID" : Return "الرقم القومي"
            Case "Date_Birth" : Return "تاريخ الميلاد"
            Case "Place_Birth" : Return "مكان الميلاد"
            Case "Emp_Image" : Return "صورة الموظف"
            Case "Emp_Type" : Return "نوع الموظف"
            Case "Working_Condition" : Return "حالة العمل"
            Case "Dept_Code" : Return "كود القسم"
            Case "Dept_Name" : Return "اسم القسم"
            Case "Jop_Code" : Return "كود الوظيفة"
            Case "Jop_Name" : Return "اسم الوظيفة"
            Case "Emp_Date_Hiring" : Return "تاريخ التعيين"
            Case "Emp_Car" : Return "السيارة"
            Case "Car_Ride_Time" : Return "وقت ركوب السيارة"
            Case "Car_Pick_Up_Point" : Return "نقطة ركوب السيارة"
            Case "Insurance_Status" : Return "حالة التأمين"
            Case "Jop_Code_insurance" : Return "كود المهنة في التأمين"
            Case "Jop_Name_insurance" : Return "اسم المهنة في التأمين"
            Case "Health_Card" : Return "بطاقة الصحة"
            Case "Health_Card_Number" : Return "رقم بطاقة الصحة"
            Case "Health_Card_Start_Date" : Return "تاريخ بدء بطاقة الصحة"
            Case "Health_Card_Renewal_Date" : Return "تاريخ تجديد البطاقة الصحية"
            Case "Health_Card_Expiration_Date" : Return "تاريخ انتهاء البطاقة الصحية"
            Case "Number_Insurance" : Return "رقم التأمين"
            Case "Date_Insurance_Start" : Return "تاريخ بدء التأمين"
            Case "Insurance_Salary" : Return "راتب التأمين"
            Case "Percentage_Insurance_Payable" : Return "نسبة التأمين المدفوعة"
            Case "Due_Insurance_Amount" : Return "المبلغ المستحق للتأمين"
            Case "Form_S1" : Return "نموذج S1"
            Case "Confirmation_Insurance_Entry" : Return "تأكيد دخول التأمين"
            Case "Delivery_Date_S1" : Return "تاريخ تسليم نموذج S1"
            Case "Receive_Date_S1" : Return "تاريخ استلام نموذج S1"
            Case "Form_S6" : Return "نموذج S6"
            Case "Delivery_Date_S6" : Return "تاريخ تسليم نموذج S6"
            Case "Receive_Date_S6" : Return "تاريخ استلام نموذج S6"
            Case "Hiring_Date_Health_Card" : Return "تاريخ التعيين للبطاقة الصحية"
            Case "Skill_level_measurement_certificate" : Return "شهادة قياس مستوى المهارة"
            Case "The_health_card_remains_expire" : Return "بتقى على انتهاء البطاقة الصحية"
            Case "End_date_probationary_period" : Return "تاريخ انتهاء فترة الاختبار"
            Case "CurrentWeekShift" : Return "وردية الأسبوع الحالي"
            Case "NextWeekShift" : Return "وردية الأسبوع القادم"
            Case "Friday_Operation" : Return "تشغيل يوم الجمعة"
            Case "Shift_Type" : Return "نوع الوردية"
            Case "Entrance_Date_S1" : Return "تاريخ دخول نموذج S1"
            Case "Entrance_Number_S1" : Return "رقم دخول نموذج S1"
            Case "Remaining_Contract_Renewal" : Return "تجديد العقد المتبقي"
            Case "Medical_Exam_Form_Submission" : Return "تقديم نموذج الفحص الطبي"
            Case "Years_Since_Contract_Start" : Return "يعمل فى الشركة منذ"
            Case "Contract_Renewal_Date" : Return "تاريخ تجديد العقد"
            Case "Contract_Expiry_Date" : Return "تاريخ انتهاء العقد"
            Case "Insurance_Code" : Return "كود التأمين"
            Case "Personal_ID_Expiry_Date" : Return "تاريخ انتهاء بطاقة الهوية الشخصية"
            Case "Contract_Renewal_Month" : Return "شهر تجديد العقد"
            Case "Military_Service_Certificate" : Return "شهادة الخدمة العسكرية"
            Case "Qualification_Certificate" : Return "شهادة التأهيل"
            Case "Birth_Certificate" : Return "شهادة الميلاد"
            Case "Insurance_Printout" : Return "طباعة التأمين"
            Case "ID_Card_Photo" : Return "صورة بطاقة الهوية"
            Case "Personal_Photos" : Return "صور شخصية"
            Case "Employment_Contract" : Return "عقد العمل"
            Case "Medical_Exam_Form" : Return "نموذج الفحص الطبي"
            Case "Criminal_Record_Check" : Return "فحص السجل الجنائي"
            Case "Social_Status_Report" : Return "تقرير الحالة الاجتماعية"
            Case "Work_Heel" : Return "العمل على الكعب"
            Case "Heel_Work_Number" : Return "رقم العمل على الكعب"
            Case "Heel_Work_Registration_Date" : Return "اخر تاريخ لتسجيل كعب العمل"
            Case "Heel_Work_Recipient" : Return "مستلم العمل على الكعب"
            Case "Heel_Work_Recipient_Address" : Return "عنوان مستلم العمل على الكعب"
            Case "Entrance_Number_S6" : Return "رقم دخول نموذج S6"
            Case "Entrance_Date_S6" : Return "تاريخ دخول نموذج S6"
            Case "Shift_paper" : Return "ورق الورديات"
            Case "Age" : Return "العمر"
            Case "Date_Resignation" : Return "تاريخ الاستقالة"
            Case "Reason_Resignation" : Return "سبب الاستقالة"
            Case "Mother_Name" : Return "اسم الأم"
            Case "Confirm_Exit_Insurance" : Return "تأكيد الخروج من التأمينات"
            Case "Governorate" : Return "المحافظة"
            Case Else : Return columnName
        End Select
    End Function

    Public Sub HideColumns(dgv As DataGridView, ParamArray columnNames() As String)
        For Each columnName As String In columnNames
            If dgv.Columns.Contains(columnName) Then
                dgv.Columns(columnName).Visible = False
            End If
        Next
    End Sub

    Public Sub ClearControls_Without_EmpID()
        Me.Emp_Full_Name.Text = vbNullString
        Me.Emp_Image.Image = Nothing
        Me.Emp_Car.Text = vbNullString
        Me.Car_Ride_Time.Value = Now
        Me.Car_Pick_Up_Point.Text = vbNullString
        Me.CurrentWeekShift.Text = vbNullString
        Me.NextWeekShift.Text = vbNullString
        Me.Friday_Operation.Text = vbNullString
        Me.Shift_Type.Text = vbNullString
        Me.Emp_ID.Focus()
    End Sub

    Private Sub RetrieveEmployeeData(ByVal empID As String)
        PerformanceManager.GetInstance().StartMeasurement("RetrieveEmployeeData")

        'performanceEnhancer.StartMeasurement("RetrieveEmployeeData")
        'Dim result = performanceEnhancer.CacheResults("ExpensiveOperation", Function() PerformExpensiveOperation())
        ClearControls_Without_EmpID()
        Using command As New SqlCommand("GetEmployee_BY_EmpID", Con)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@EmpID", empID)
            If Con.State = 1 Then Con.Close()
            Con.Open()
            PerformanceManager.GetInstance().MonitorMemoryUsage()
            Try
                Dim reader As SqlDataReader = command.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read()
                        ' استرداد البيانات الأساسية
                        Emp_Full_Name.Text = reader("Emp_Full_Name").ToString()
                        ' استرداد الصورة إذا كانت متاحة
                        If Not IsDBNull(reader("Emp_Image")) Then
                            Dim imageData As Byte() = DirectCast(reader("Emp_Image"), Byte())
                            Using ms As New System.IO.MemoryStream(imageData)
                                Emp_Image.Image = Image.FromStream(ms)
                            End Using
                        Else
                            Emp_Image.Image = My.Resources.icons8_add_image_96
                        End If
                        CurrentWeekShift.Text = reader("CurrentWeekShift").ToString()
                    End While
                Else
                    MessageBox.Show("لم يتم العثور على معلومات لهذا الموظف")
                End If
            Catch ex As Exception
                MessageBox.Show("خطأ:  " & ex.Message)
            End Try
            'Con.Close()
        End Using
        PerformanceManager.GetInstance().MonitorMemoryUsage()
        Dim elapsed As TimeSpan = PerformanceManager.GetInstance().StopMeasurement("RetrieveEmployeeData")
        ' عرض وقت التنفيذ
        'MessageBox.Show($"Time taken to retrieve employee data: {elapsed.TotalMilliseconds:F2} ms")
        'Me.Age.Text = CalcDateDiff(Date_Birth.Value, DateTime.Now)
        'End Using
        Con.Close()
    End Sub

    Public Sub Update_CurrentWeekShift(ByVal CurrentWeekShift As String, ByVal Emp_IDW As Int32)
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.StoredProcedure
            .CommandText = "Update_CurrentWeekShift" ' اسم الإجراء المخزن هنا
            .Parameters.Clear()
            .Parameters.AddWithValue("@CurrentWeekShift", CurrentWeekShift)
            .Parameters.AddWithValue("@Emp_ID", Emp_IDW)
        End With
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Private Sub Btn_Add_Note_Click(sender As Object, e As EventArgs) Handles Btn_Add_Note.Click
        If Emp_ID.Text = vbNullString Then
            MessageBox.Show("قم باختيار الموظف أولاً", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Exit Sub
        Else
            Frm_Note_Employee.Show()
            Frm_Note_Employee.Note_Emp_ID.Text = Int(Me.Emp_ID.Text)
            Frm_Note_Employee.Note_Employee_Name.Text = Me.Emp_Full_Name.Text
        End If
    End Sub

    Private Sub Btn_ShiftChange_ForEmp_Click(sender As Object, e As EventArgs) Handles Btn_ShiftChange_ForEmp.Click
        Update_CurrentWeekShift(CurrentWeekShift.Text, Int(Emp_ID.Text))
        RetrieveEmployeeData(Emp_ID.Text)
    End Sub

    Public Sub fillcmb_Tbl_Car(ByVal cmb As ComboBox)
        Dim DT As New DataTable
        Dim DA As New SqlDataAdapter
        DT.Clear()
        DA = New SqlDataAdapter("SelectAll_Tbl_Car", Con)
        DA.SelectCommand.CommandType = CommandType.StoredProcedure
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            cmb.DataSource = DT
            cmb.ValueMember = "Car_ID"
            cmb.DisplayMember = "Car_Name"
            cmb.SelectedIndex = -1
        Else
            cmb.DataSource = Nothing
        End If
    End Sub


    Public Async Function SelectAll_Tbl_EmployeeAsync(dgv As DataGridView) As Task
        pm.StartMeasurement("SelectAll_Tbl_Employee")

        Try
            ' 1. استخدام Using لإدارة الموارد تلقائيًا
            Using connection As New SqlConnection(ConStr)
                Using da As New SqlDataAdapter("Select_All_Employee_WithSequence", connection)
                    da.SelectCommand.CommandType = CommandType.StoredProcedure

                    ' 4. استخدام Async/Await للعمليات غير المتزامنة
                    Await connection.OpenAsync()

                    ' 2. إنشاء DataTable جديد بدلًا من استخدام واحد عام
                    Dim tempTable As New DataTable()

                    ' 3. استخدام FillAsync بدلًا من Fill
                    Await Task.Run(Sub() da.Fill(tempTable))

                    ' تحديث واجهة المستخدم في سياقها الأصلي
                    dgv.Invoke(Sub()
                                   dt_Tbl_Employee = tempTable
                                   dgv.DataSource = dt_Tbl_Employee

                                   HideColumns(dgv, "مسلسل", "Emp_First_Name", "Emp_Second_Name", "Emp_Name_English", "Emp_Phone1", "Emp_Phone2",
                                           "Emp_Address", "Emp_Marital_Status", "Emp_Nationality", "People_With_Special_Needs", "National_ID", "Date_Birth",
                                           "Place_Birth", "Emp_Image", "Emp_Type", "Working_Condition", "Dept_Code", "Dept_Name", "Jop_Code", "Jop_Name",
                                           "Emp_Date_Hiring", "Emp_Car", "Car_Ride_Time", "Car_Pick_Up_Point", "Insurance_Status", "Jop_Code_insurance",
                                           "Jop_Name_insurance", "Health_Card", "Health_Card_Number", "Health_Card_Start_Date", "Health_Card_Renewal_Date", "Health_Card_Expiration_Date",
                                           "Number_Insurance", "Date_Insurance_Start", "Insurance_Salary", "Percentage_Insurance_Payable", "Due_Insurance_Amount",
                                           "Form_S1", "Confirmation_Insurance_Entry", "Delivery_Date_S1", "Receive_Date_S1", "Form_S6", "Delivery_Date_S6",
                                           "Receive_Date_S6", "Hiring_Date_Health_Card", "Skill_level_measurement_certificate", "The_health_card_remains_expire",
                                           "End_date_probationary_period", "CurrentWeekShift", "NextWeekShift", "Friday_Operation", "Shift_Type",
                                           "Entrance_Date_S1", "Entrance_Number_S1", "Remaining_Contract_Renewal", "Medical_Exam_Form_Submission", "Years_Since_Contract_Start",
                                           "Contract_Renewal_Date", "Contract_Expiry_Date", "Insurance_Code", "Personal_ID_Expiry_Date", "Contract_Renewal_Month",
                                           "Military_Service_Certificate", "Qualification_Certificate", "Birth_Certificate", "Insurance_Printout", "ID_Card_Photo",
                                           "Personal_Photos", "Employment_Contract", "Medical_Exam_Form", "Criminal_Record_Check", "Social_Status_Report",
                                           "Work_Heel", "Heel_Work_Number", "Heel_Work_Registration_Date", "Heel_Work_Recipient", "Heel_Work_Recipient_Address",
                                           "Entrance_Number_S6", "Entrance_Date_S6", "Shift_paper", "Age", "Date_Resignation", "Reason_Resignation", "Mother_Name", "Confirm_Exit_Insurance", "Governorate")

                                   For Each column As DataGridViewColumn In dgv.Columns
                                       column.HeaderText = GetColumnHeaderName(column.Name)
                                   Next

                                   ' تكبير العمود المطلوب
                                   dgv.Columns("Emp_Full_Name").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                               End Sub)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"حدث خطأ: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '_logger.LogError(ex.ToString(), "فشل في تحميل بيانات الموظفين")
        Finally
            Dim elapsed = pm.StopMeasurement("SelectAll_Tbl_Employee")
            'Dim value = _logger.LogInformation($"تم تنفيذ الإجراء في {elapsed.TotalMilliseconds:F2} مللي ثانية")
        End Try
    End Function

    Private Sub Frm_Routation_Shift_NoteEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '-------------------------------------------------------------------------------------------------------
        'خاص بتطبيق الصلاحيات
        ApplyPermissions(Me.Name)
        '-------------------------------------------------------------------------------------------------------
        Me.KeyPreview = True

        Emp_ID.Focus()

        Try
            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If
            Dim da As New SqlDataAdapter
            da = New SqlDataAdapter("Select_All_Employee", Con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.Fill(ds, "ds_Tbl_Employee")
            fillcmb_Tbl_Car(Emp_Car)

            SelectAll_Tbl_EmployeeAsync(dgv_Tbl_Employee)
            dgv_Tbl_Employee.DataSource = ds.Tables("ds_Tbl_Employee")
            BindingSource1.DataSource = dt_Tbl_Employee.DefaultView

            Con.Close()
        Catch ex As Exception
            MessageBox.Show("خطأ: " & ex.Message)
        End Try
        Con.Close()
        Txt_Count.Text = dgv_Tbl_Employee.RowCount.ToString()
    End Sub
End Class