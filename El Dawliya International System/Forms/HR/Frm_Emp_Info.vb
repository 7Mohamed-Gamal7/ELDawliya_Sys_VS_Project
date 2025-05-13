Imports System.Data.SqlClient
Imports System.IO
Imports ClosedXML.Excel

Public Class Frm_Emp_Info
    Inherits BaseForm

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

    Private Sub Frm_Emp_Info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            ExecuteStoredProcedure("CalculateAndUpdateAge", Con)
            ExecuteStoredProcedure("CalculateDueInsuranceAmountForAllRows", Con)
            ExecuteStoredProcedure("CalculateAndUpdate_Duration_Employment", Con)
            fillcmb_Tbl_Car(Emp_Car)
            fillcmb_Tbl_Jop(Jop_Code)
            fillcmb_Tbl_Department(Dept_Code)
            fillcmb_Tbl_Jop_Name_insurance(Jop_Name_insurance)
            SelectAll_Tbl_EmployeeAsync(dgv_Tbl_Employee)
            dgv_Tbl_Employee.DataSource = ds.Tables("ds_Tbl_Employee")
            BindingSource1.DataSource = dt_Tbl_Employee.DefaultView
            'GotFoucs_LostFocus_For_Control_On_Panal(Panel1)
            'GotFoucs_LostFocus_For_Control_On_Panal(Panel2)
            'GotFoucs_LostFocus_For_Control_On_Panal(Panel3)
            'GotFoucs_LostFocus_For_Control_On_Panal(Panel4)
            'GotFoucs_LostFocus_For_Control_On_Panal(Panel5)
            'GotFoucs_LostFocus_For_Control_On_Panal(Panel6)
            'GotFoucs_LostFocus_For_Control_On_Panal(Panel7)
            'GotFoucs_LostFocus_For_Control_On_Panal(Panel8)
            'GotFoucs_LostFocus_For_Control_On_Panal(Panel9)
            'GotFoucs_LostFocus_For_Control_On_Panal(Panel10)
            'GotFoucs_LostFocus_For_Control_On_Panal(Panel11)
            'GotFoucs_LostFocus_For_Control_On_Panal(Panel12)
            'GotFoucs_LostFocus_For_Control_On_Panal(Panel2)
            'GotFoucs_LostFocus_For_TabControl(TabControl1)
            'GotFoucs_LostFocus_For_GroupBox(GroupBox1)
            'GotFoucs_LostFocus_For_GroupBox(GroupBox2)
            'GotFoucs_LostFocus_For_GroupBox(GroupBox3)
            Con.Close()
        Catch ex As Exception
            MessageBox.Show("خطأ: " & ex.Message)
        End Try
        Con.Close()
        Txt_Count.Text = dgv_Tbl_Employee.RowCount.ToString()
    End Sub

    'تم تعديه
    'Public Sub SelectAll_Tbl_Employee(dgv As DataGridView)
    '    pm.StartMeasurement("SelectAll_Tbl_Employee")
    '    Dim da As New SqlDataAdapter
    '    dt_Tbl_Employee.Clear()
    '    da = New SqlDataAdapter("Select_All_Employee_WithSequence", Con)
    '    da.SelectCommand.CommandType = CommandType.StoredProcedure
    '    da.Fill(dt_Tbl_Employee)
    '    dgv.DataSource = dt_Tbl_Employee
    '    Try
    '        If Con.State = ConnectionState.Closed Then
    '            Con.Open()
    '        End If
    '        ' لاخفاء الاعمدة
    '        HideColumns(dgv, "مسلسل", "Emp_First_Name", "Emp_Second_Name", "Emp_Name_English", "Emp_Phone1", "Emp_Phone2",
    '        "Emp_Address", "Emp_Marital_Status", "Emp_Nationality", "People_With_Special_Needs", "National_ID", "Date_Birth",
    '        "Place_Birth", "Emp_Image", "Emp_Type", "Working_Condition", "Dept_Code", "Dept_Name", "Jop_Code", "Jop_Name",
    '        "Emp_Date_Hiring", "Emp_Car", "Car_Ride_Time", "Car_Pick_Up_Point", "Insurance_Status", "Jop_Code_insurance",
    '        "Jop_Name_insurance", "Health_Card", "Health_Card_Number", "Health_Card_Start_Date", "Health_Card_Renewal_Date", "Health_Card_Expiration_Date",
    '        "Number_Insurance", "Date_Insurance_Start", "Insurance_Salary", "Percentage_Insurance_Payable", "Due_Insurance_Amount",
    '        "Form_S1", "Confirmation_Insurance_Entry", "Delivery_Date_S1", "Receive_Date_S1", "Form_S6", "Delivery_Date_S6",
    '        "Receive_Date_S6", "Hiring_Date_Health_Card", "Skill_level_measurement_certificate", "The_health_card_remains_expire",
    '        "End_date_probationary_period", "CurrentWeekShift", "NextWeekShift", "Friday_Operation", "Shift_Type",
    '        "Entrance_Date_S1", "Entrance_Number_S1", "Remaining_Contract_Renewal", "Medical_Exam_Form_Submission", "Years_Since_Contract_Start",
    '        "Contract_Renewal_Date", "Contract_Expiry_Date", "Insurance_Code", "Personal_ID_Expiry_Date", "Contract_Renewal_Month",
    '        "Military_Service_Certificate", "Qualification_Certificate", "Birth_Certificate", "Insurance_Printout", "ID_Card_Photo",
    '        "Personal_Photos", "Employment_Contract", "Medical_Exam_Form", "Criminal_Record_Check", "Social_Status_Report",
    '        "Work_Heel", "Heel_Work_Number", "Heel_Work_Registration_Date", "Heel_Work_Recipient", "Heel_Work_Recipient_Address",
    '        "Entrance_Number_S6", "Entrance_Date_S6", "Shift_paper", "Age", "Date_Resignation", "Reason_Resignation", "Mother_Name", "Confirm_Exit_Insurance", "Governorate")
    '        For Each column As DataGridViewColumn In dgv.Columns
    '            column.HeaderText = GetColumnHeaderName(column.Name)
    '        Next
    '        'dgv.Columns("Emp_Full_Name").AutoSizeMode = DataGridViewAutoSizeColumnsMode.Fill
    '    Catch ex As Exception
    '        MessageBox.Show("خطأ: " & ex.Message)
    '    End Try
    '    Dim elapsed = pm.StopMeasurement("Select_All_Employee_WithSequence")
    '    _logger.LogInfo($"Select_All_Employee_WithSequence filled in {elapsed.TotalMilliseconds:F2} ms")
    '    Con.Close()
    'End Sub

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

    Public Sub SelectAll_Tbl_Employee_Resignation(dgv As DataGridView)
        Dim da As New SqlDataAdapter
        dt_Tbl_Employee.Clear()
        da = New SqlDataAdapter("Select_All_Employee_Resignation", Con)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.Fill(dt_Tbl_Employee)
        dgv.DataSource = dt_Tbl_Employee
        Try
            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If
            ' لاخفاء الاعمدة
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
            "Entrance_Number_S6", "Entrance_Date_S6", "Shift_paper", "Age", "Date_Resignation", "Reason_Resignation", "Mother_Name", "Governorate")
            For Each column As DataGridViewColumn In dgv.Columns
                column.HeaderText = GetColumnHeaderName(column.Name)
            Next
            'dgv.Columns("Emp_Full_Name").AutoSizeMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MessageBox.Show("خطأ: " & ex.Message)
        End Try
        Con.Close()
    End Sub

    Public Sub Select_All_Employee_Reviewing_Monthly_Insurance(dgv As DataGridView)
        Dim da As New SqlDataAdapter
        dt_Tbl_Employee.Clear()
        da = New SqlDataAdapter("Select_All_Employee_Reviewing_Monthly_Insurance", Con)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.Fill(dt_Tbl_Employee)
        dgv.DataSource = dt_Tbl_Employee
        Try
            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If
            ' لاخفاء الاعمدة
            HideColumns(dgv, "مسلسل", "Emp_First_Name", "Emp_Second_Name", "Emp_Name_English", "Emp_Phone1", "Emp_Phone2",
            "Emp_Address", "Emp_Marital_Status", "Emp_Nationality", "People_With_Special_Needs", "National_ID", "Date_Birth",
            "Place_Birth", "Emp_Image", "Emp_Type", "Working_Condition", "Dept_Code", "Dept_Name", "Jop_Code", "Jop_Name",
            "Emp_Date_Hiring", "Emp_Car", "Car_Ride_Time", "Car_Pick_Up_Point", "Jop_Code_insurance",
            "Jop_Name_insurance", "Health_Card", "Health_Card_Number", "Health_Card_Start_Date", "Health_Card_Renewal_Date", "Health_Card_Expiration_Date",
            "Date_Insurance_Start",
            "Form_S1", "Confirmation_Insurance_Entry", "Delivery_Date_S1", "Receive_Date_S1", "Form_S6", "Delivery_Date_S6",
            "Receive_Date_S6", "Hiring_Date_Health_Card", "Skill_level_measurement_certificate", "The_health_card_remains_expire",
            "End_date_probationary_period", "CurrentWeekShift", "NextWeekShift", "Friday_Operation", "Shift_Type",
            "Entrance_Date_S1", "Entrance_Number_S1", "Remaining_Contract_Renewal", "Medical_Exam_Form_Submission", "Years_Since_Contract_Start",
            "Contract_Renewal_Date", "Contract_Expiry_Date", "Insurance_Code", "Personal_ID_Expiry_Date", "Contract_Renewal_Month",
            "Military_Service_Certificate", "Qualification_Certificate", "Birth_Certificate", "Insurance_Printout", "ID_Card_Photo",
            "Personal_Photos", "Employment_Contract", "Medical_Exam_Form", "Criminal_Record_Check", "Social_Status_Report",
            "Work_Heel", "Heel_Work_Number", "Heel_Work_Registration_Date", "Heel_Work_Recipient", "Heel_Work_Recipient_Address",
            "Entrance_Number_S6", "Entrance_Date_S6", "Shift_paper", "Age", "Date_Resignation", "Reason_Resignation", "Confirm_Exit_Insurance", "Mother_Name", "Governorate")
            '"Insurance_Status","Insurance_Salary","Percentage_Insurance_Payable","Due_Insurance_Amount","Number_Insurance",
            For Each column As DataGridViewColumn In dgv.Columns
                column.HeaderText = GetColumnHeaderName(column.Name)
            Next
            'dgv.Columns("Emp_Full_Name").AutoSizeMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MessageBox.Show("خطأ: " & ex.Message)
        End Try
        Con.Close()
    End Sub

    Public Sub ClearControls_Without_EmpID()
        Me.Emp_First_Name.Text = vbNullString
        Me.Emp_Second_Name.Text = vbNullString
        Me.Emp_Full_Name.Text = vbNullString
        Me.Emp_Name_English.Text = vbNullString
        Me.Mother_Name.Text = vbNullString
        Me.Emp_Phone1.Text = vbNullString
        Me.Emp_Phone2.Text = vbNullString
        Me.Emp_Address.Text = vbNullString
        Me.Emp_Marital_Status.Text = vbNullString
        Me.Emp_Nationality.Text = vbNullString
        Me.National_ID.Text = vbNullString
        Me.Date_Birth.Value = New DateTime(1900, 1, 1)
        Me.Place_Birth.Text = vbNullString
        Me.Emp_Image.Image = Nothing
        Me.Emp_Type.Text = vbNullString
        Me.Working_Condition.Text = vbNullString
        Me.Dept_Code.Text = vbNullString
        'Me.Dept_Name.Text = vbNullString
        Me.Jop_Code.Text = vbNullString
        'Me.Jop_Name.Text = vbNullString
        Me.Emp_Date_Hiring.Value = Today
        Me.Emp_Car.Text = vbNullString
        Me.Car_Ride_Time.Value = Now
        Me.Car_Pick_Up_Point.Text = vbNullString
        Me.Insurance_Status.Text = vbNullString
        Me.Jop_Code_insurance.Text = vbNullString
        Me.Jop_Name_insurance.Text = vbNullString
        Me.Health_Card.Text = vbNullString
        Me.Health_Card_Number.Text = vbNullString
        Me.Health_Card_Start_Date.Value = Today
        Me.Health_Card_Expiration_Date.Value = Today
        Me.Health_Card_Renewal_Date.Value = Today
        Me.Number_Insurance.Text = vbNullString
        Me.Date_Insurance_Start.Value = Today
        Me.Delivery_Date_S1.Value = Today
        Me.Receive_Date_S1.Value = Today
        Me.Delivery_Date_S6.Value = Today
        Me.Receive_Date_S6.Value = Today
        Me.Hiring_Date_Health_Card.Value = Today
        Me.The_health_card_remains_expire.Text = 0
        Me.End_date_probationary_period.Value = Today
        Me.CurrentWeekShift.Text = vbNullString
        Me.NextWeekShift.Text = vbNullString
        Me.Friday_Operation.Text = vbNullString
        Me.Shift_Type.Text = vbNullString
        Me.Entrance_Date_S1.Value = Today
        Me.Entrance_Number_S1.Text = vbNullString
        Me.Remaining_Contract_Renewal.Text = vbNullString
        Me.Years_Since_Contract_Start.Text = vbNullString
        Me.Contract_Renewal_Date.Value = Today
        Me.Contract_Expiry_Date.Value = Today
        'Me.Insurance_Code.Text = vbNullString
        Me.Personal_ID_Expiry_Date.Value = Today
        Me.Contract_Renewal_Month.Text = vbNullString
        Me.Military_Service_Certificate.Text = vbNullString
        Me.Qualification_Certificate.Text = vbNullString
        Me.Heel_Work_Number.Text = vbNullString
        Me.Heel_Work_Registration_Date.Value = Today
        Me.Heel_Work_Recipient.Text = vbNullString
        Me.Heel_Work_Recipient_Address.Text = vbNullString
        Me.Entrance_Number_S6.Text = vbNullString
        Me.Entrance_Date_S6.Value = Today
        Me.Insurance_Salary.Text = "0.00"
        Me.Percentage_Insurance_Payable.Text = "0.00"
        Me.Due_Insurance_Amount.Text = "0.00"
        Me.Confirmation_Insurance_Entry.Checked = False
        Form_S1.Checked = False
        Form_S6.Checked = False
        Medical_Exam_Form.Checked = False
        Birth_Certificate.Checked = False
        Insurance_Printout.Checked = False
        ID_Card_Photo.Checked = False
        Personal_Photos.Checked = False
        Employment_Contract.Checked = False
        Skill_level_measurement_certificate.Checked = False
        Social_Status_Report.Checked = False
        Work_Heel.Checked = False
        Medical_Exam_Form.Checked = False
        Criminal_Record_Check.Checked = False
        People_With_Special_Needs.Checked = False
        Medical_Exam_Form_Submission.Checked = False
        Me.Age.Text = vbNullString
        Me.Date_Resignation.Value = New DateTime(1900, 1, 1)
        Me.Reason_Resignation.Text = vbNullString
        Me.Date_Resignation.Visible = False
        Me.Reason_Resignation.Visible = False
        Me.Date_Resignation_Lbl.Visible = False
        Me.Reason_Resignation_Lbl.Visible = False
        Me.Btn_Resignation.Visible = False
        Confirm_Exit_Insurance.Checked = False
        Me.Emp_ID.Focus()
    End Sub

    Public Sub ClearControls()
        Me.Emp_ID.Text = vbNullString
        Me.Emp_First_Name.Text = vbNullString
        Me.Emp_Second_Name.Text = vbNullString
        Me.Emp_Full_Name.Text = vbNullString
        Me.Mother_Name.Text = vbNullString
        Me.Emp_Name_English.Text = vbNullString
        Me.Emp_Phone1.Text = vbNullString
        Me.Emp_Phone2.Text = vbNullString
        Me.Emp_Address.Text = vbNullString
        Me.Emp_Marital_Status.Text = vbNullString
        Me.Emp_Nationality.Text = vbNullString
        Me.National_ID.Text = vbNullString
        Me.Date_Birth.Value = New DateTime(1900, 1, 1)
        Me.Place_Birth.Text = vbNullString
        Me.Emp_Image.Image = Nothing
        Me.Emp_Type.Text = vbNullString
        Me.Working_Condition.Text = vbNullString
        Me.Dept_Code.Text = vbNullString
        'Me.Dept_Name.Text = vbNullString
        Me.Jop_Code.Text = vbNullString
        'Me.Jop_Name.Text = vbNullString
        Me.Emp_Date_Hiring.Value = Today
        Me.Emp_Car.Text = vbNullString
        Me.Car_Ride_Time.Value = Now
        Me.Car_Pick_Up_Point.Text = vbNullString
        Me.Insurance_Status.Text = vbNullString
        Me.Jop_Code_insurance.Text = vbNullString
        Me.Jop_Name_insurance.Text = vbNullString
        Me.Health_Card.Text = vbNullString
        Me.Health_Card_Number.Text = vbNullString
        Me.Health_Card_Start_Date.Value = Today
        Me.Health_Card_Renewal_Date.Value = Today
        Me.Health_Card_Expiration_Date.Value = Today
        Me.Number_Insurance.Text = vbNullString
        Me.Date_Insurance_Start.Value = Today
        Me.Delivery_Date_S1.Value = Today
        Me.Receive_Date_S1.Value = Today
        Me.Delivery_Date_S6.Value = Today
        Me.Receive_Date_S6.Value = Today
        Me.Hiring_Date_Health_Card.Value = Today
        Me.The_health_card_remains_expire.Text = 0
        Me.End_date_probationary_period.Value = Today
        Me.CurrentWeekShift.Text = vbNullString
        Me.NextWeekShift.Text = vbNullString
        Me.Friday_Operation.Text = vbNullString
        Me.Shift_Type.Text = vbNullString
        Me.Entrance_Date_S1.Value = Today
        Me.Entrance_Number_S1.Text = vbNullString
        Me.Remaining_Contract_Renewal.Text = vbNullString
        Me.Years_Since_Contract_Start.Text = vbNullString
        Me.Contract_Renewal_Date.Value = Today
        Me.Contract_Expiry_Date.Value = Today
        'Me.Insurance_Code.Text = vbNullString
        Me.Personal_ID_Expiry_Date.Value = Today
        Me.Contract_Renewal_Month.Text = vbNullString
        Me.Military_Service_Certificate.Text = vbNullString
        Me.Qualification_Certificate.Text = vbNullString
        Me.Heel_Work_Number.Text = vbNullString
        Me.Heel_Work_Registration_Date.Value = Today
        Me.Heel_Work_Recipient.Text = vbNullString
        Me.Heel_Work_Recipient_Address.Text = vbNullString
        Me.Entrance_Number_S6.Text = vbNullString
        Me.Entrance_Date_S6.Value = Today
        Me.Insurance_Salary.Text = "0.00"
        Me.Percentage_Insurance_Payable.Text = "0.00"
        Me.Due_Insurance_Amount.Text = "0.00"
        Me.Confirmation_Insurance_Entry.Checked = False
        Form_S1.Checked = False
        Form_S6.Checked = False
        Medical_Exam_Form.Checked = False
        Birth_Certificate.Checked = False
        Insurance_Printout.Checked = False
        ID_Card_Photo.Checked = False
        Personal_Photos.Checked = False
        Employment_Contract.Checked = False
        Skill_level_measurement_certificate.Checked = False
        Social_Status_Report.Checked = False
        Work_Heel.Checked = False
        Medical_Exam_Form.Checked = False
        Criminal_Record_Check.Checked = False
        People_With_Special_Needs.Checked = False
        Medical_Exam_Form_Submission.Checked = False
        Me.Age.Text = vbNullString
        Me.Date_Resignation.Value = New DateTime(1900, 1, 1)
        Me.Reason_Resignation.Text = vbNullString
        Me.Date_Resignation.Visible = False
        Me.Reason_Resignation.Visible = False
        Me.Date_Resignation_Lbl.Visible = False
        Me.Reason_Resignation_Lbl.Visible = False
        Me.Btn_Resignation.Visible = False
        Confirm_Exit_Insurance.Checked = False
        Me.Emp_ID.Focus()
    End Sub

    Public Sub fillcmb_Tbl_Jop(ByVal cmb As ComboBox)
        Dim DT As New DataTable
        Dim DA As New SqlDataAdapter
        DT.Clear()
        DA = New SqlDataAdapter("Select_All_Tbl_Jop", Con)
        DA.SelectCommand.CommandType = CommandType.StoredProcedure
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            cmb.DataSource = DT
            cmb.ValueMember = "Jop_Code"
            cmb.DisplayMember = "Jop_Name"
            cmb.SelectedIndex = -1
        Else
            cmb.DataSource = Nothing
        End If
    End Sub

    Public Sub fillcmb_Tbl_Department(ByVal cmb As ComboBox)
        Dim DT As New DataTable
        Dim DA As New SqlDataAdapter
        DT.Clear()
        DA = New SqlDataAdapter("Select * FROM Tbl_Department ", Con)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            cmb.DataSource = DT
            cmb.ValueMember = "Dept_Code"
            cmb.DisplayMember = "Dept_Name"
            cmb.SelectedIndex = -1
        Else
            cmb.DataSource = Nothing
        End If
    End Sub

    Public Sub fillcmb_Tbl_Jop_Name_insurance(ByVal cmb As ComboBox)
        Dim DT As New DataTable
        Dim DA As New SqlDataAdapter
        DT.Clear()
        DA = New SqlDataAdapter("Select_All_Tbl_Jop_Name_insurance", Con)
        DA.SelectCommand.CommandType = CommandType.StoredProcedure
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            cmb.DataSource = DT
            cmb.ValueMember = "Jop_Code_insurance"
            cmb.DisplayMember = "Jop_Name_insurance"
            cmb.SelectedIndex = -1
        Else
            cmb.DataSource = Nothing
        End If
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

    Public Sub fillcmb_Tbl_Waiting_Point(ByVal cmb As ComboBox)
        Dim DT As New DataTable
        Dim DA As New SqlDataAdapter
        DT.Clear()
        DA = New SqlDataAdapter("Select_All_Waiting_Point", Con)
        DA.SelectCommand.CommandType = CommandType.StoredProcedure
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            cmb.DataSource = DT
            cmb.ValueMember = "Waiting_Point_ID"
            cmb.DisplayMember = "Waiting_Point_Name"
            cmb.SelectedIndex = -1
        Else
            cmb.DataSource = Nothing
        End If
    End Sub

    Public Sub Update_Personal(ByVal Emp_First_Name As String, ByVal Emp_Second_Name As String, ByVal Emp_Full_Name As String, ByVal Emp_Name_English As String, ByVal Emp_Phone1 As String, ByVal Emp_Phone2 As String, ByVal Emp_Address As String, ByVal Emp_Marital_Status As String, ByVal Emp_Nationality As String, ByVal People_With_Special_Needs As Boolean, ByVal National_ID As String, ByVal Date_Birth As DateTime, ByVal Place_Birth As String, ByVal Personal_ID_Expiry_Date As DateTime, ByVal Emp_Type As String, ByVal Mother_Name As String, ByVal Governorate As String, ByVal Emp_IDW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_Employee Set Emp_First_Name = @Emp_First_Name,Emp_Second_Name = @Emp_Second_Name,Emp_Full_Name = @Emp_Full_Name,Emp_Name_English = @Emp_Name_English,Emp_Phone1 = @Emp_Phone1,Emp_Phone2 = @Emp_Phone2,Emp_Address = @Emp_Address,Emp_Marital_Status = @Emp_Marital_Status,Emp_Nationality = @Emp_Nationality,People_With_Special_Needs = @People_With_Special_Needs,National_ID = @National_ID,Date_Birth = @Date_Birth,Place_Birth = @Place_Birth,Personal_ID_Expiry_Date = @Personal_ID_Expiry_Date,Emp_Type = @Emp_Type,Mother_Name = @Mother_Name,Governorate = @Governorate Where Emp_ID = @Emp_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Emp_First_Name", SqlDbType.VarChar).Value = Emp_First_Name
            .Parameters.AddWithValue("@Emp_Second_Name", SqlDbType.VarChar).Value = Emp_Second_Name
            .Parameters.AddWithValue("@Emp_Full_Name", SqlDbType.VarChar).Value = Emp_Full_Name
            .Parameters.AddWithValue("@Emp_Name_English", SqlDbType.VarChar).Value = Emp_Name_English
            .Parameters.AddWithValue("@Emp_Phone1", SqlDbType.VarChar).Value = Emp_Phone1
            .Parameters.AddWithValue("@Emp_Phone2", SqlDbType.VarChar).Value = Emp_Phone2
            .Parameters.AddWithValue("@Emp_Address", SqlDbType.VarChar).Value = Emp_Address
            .Parameters.AddWithValue("@Emp_Marital_Status", SqlDbType.VarChar).Value = Emp_Marital_Status
            .Parameters.AddWithValue("@Emp_Nationality", SqlDbType.VarChar).Value = Emp_Nationality
            .Parameters.AddWithValue("@People_With_Special_Needs", SqlDbType.Decimal).Value = People_With_Special_Needs
            .Parameters.AddWithValue("@National_ID", SqlDbType.VarChar).Value = National_ID
            .Parameters.AddWithValue("@Date_Birth", SqlDbType.Date).Value = Date_Birth
            .Parameters.AddWithValue("@Place_Birth", SqlDbType.VarChar).Value = Place_Birth
            .Parameters.AddWithValue("@Personal_ID_Expiry_Date", SqlDbType.Date).Value = Personal_ID_Expiry_Date
            .Parameters.AddWithValue("@Emp_Type", SqlDbType.VarChar).Value = Emp_Type
            .Parameters.AddWithValue("@Mother_Name", SqlDbType.VarChar).Value = Mother_Name
            .Parameters.AddWithValue("@Governorate", SqlDbType.VarChar).Value = Governorate
            .Parameters.AddWithValue("@Emp_ID", SqlDbType.Int).Value = Emp_IDW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        Cmd = Nothing
    End Sub

    Public Sub Update_Work(ByVal Working_Condition As String, ByVal Dept_Code As Int32, ByVal Dept_Name As String, ByVal Jop_Code As Int32, ByVal Jop_Name As String, ByVal Emp_Date_Hiring As DateTime, ByVal Emp_IDW As Int32)
        'ByVal End_date_probationary_period As DateTime
        'End_date_probationary_period = ISNULL(@End_date_probationary_period, Null)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "UPDATE Tbl_Employee Set Working_Condition = ISNULL(@Working_Condition, NULL), Dept_Code = ISNULL(@Dept_Code, NULL), Dept_Name = ISNULL(@Dept_Name, NULL), Jop_Code = ISNULL(@Jop_Code, NULL), Jop_Name = ISNULL(@Jop_Name, NULL), Emp_Date_Hiring = ISNULL(@Emp_Date_Hiring, NULL)  WHERE Emp_ID = @Emp_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Working_Condition", SqlDbType.VarChar).Value = Working_Condition
            .Parameters.AddWithValue("@Dept_Code", SqlDbType.Int).Value = Dept_Code
            .Parameters.AddWithValue("@Dept_Name", SqlDbType.VarChar).Value = Dept_Name
            .Parameters.AddWithValue("@Jop_Code", SqlDbType.Int).Value = Jop_Code
            .Parameters.AddWithValue("@Jop_Name", SqlDbType.VarChar).Value = Jop_Name
            .Parameters.AddWithValue("@Emp_Date_Hiring", SqlDbType.Date).Value = Emp_Date_Hiring
            '.Parameters.AddWithValue("@End_date_probationary_period", SqlDbType.Date).Value = End_date_probationary_period
            .Parameters.AddWithValue("@Emp_ID", SqlDbType.Int).Value = Emp_IDW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        'MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Public Sub Update_Shift_Car(ByVal Emp_Car As String, ByVal Car_Ride_Time As DateTime, ByVal Car_Pick_Up_Point As String, ByVal CurrentWeekShift As String, ByVal Friday_Operation As String, ByVal Shift_Type As String, ByVal Shift_paper As String, ByVal Emp_IDW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_Employee Set Emp_Car = @Emp_Car,Car_Ride_Time = @Car_Ride_Time,Car_Pick_Up_Point = @Car_Pick_Up_Point,CurrentWeekShift = @CurrentWeekShift,Friday_Operation = @Friday_Operation,Shift_Type = @Shift_Type,Shift_paper=@Shift_paper Where Emp_ID = @Emp_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Emp_Car", SqlDbType.VarChar).Value = Emp_Car
            .Parameters.AddWithValue("@Car_Ride_Time", SqlDbType.Date).Value = Car_Ride_Time
            .Parameters.AddWithValue("@Car_Pick_Up_Point", SqlDbType.VarChar).Value = Car_Pick_Up_Point
            .Parameters.AddWithValue("@CurrentWeekShift", SqlDbType.VarChar).Value = CurrentWeekShift
            '.Parameters.AddWithValue("@NextWeekShift", SqlDbType.VarChar).Value = NextWeekShift
            .Parameters.AddWithValue("@Friday_Operation", SqlDbType.VarChar).Value = Friday_Operation
            .Parameters.AddWithValue("@Shift_Type", SqlDbType.VarChar).Value = Shift_Type
            .Parameters.AddWithValue("@Shift_paper", SqlDbType.VarChar).Value = Shift_paper
            .Parameters.AddWithValue("@Emp_ID", SqlDbType.Int).Value = Emp_IDW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        'MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Public Sub Update_Insurance_Status(ByVal Insurance_Status As String,
       ByVal Jop_Code_insurance As Int32,
       ByVal Jop_Name_insurance As String,
       ByVal Number_Insurance As Int32,
       ByVal Date_Insurance_Start As Date,
       ByVal Insurance_Salary As Double,
       ByVal Percentage_Insurance_Payable As Double,
       ByVal Form_S1 As Boolean,
       ByVal Confirmation_Insurance_Entry As Boolean,
       ByVal Delivery_Date_S1 As Date,
       ByVal Receive_Date_S1 As Date,
       ByVal Form_S6 As Boolean,
       ByVal Delivery_Date_S6 As Date,
       ByVal Receive_Date_S6 As Date,
       ByVal Entrance_Date_S1 As Date,
       ByVal Entrance_Number_S1 As Int32,
       ByVal Contract_Renewal_Date As Date,
       ByVal Contract_Renewal_Month As Int32,
       ByVal Entrance_Number_S6 As Int32,
       ByVal Entrance_Date_S6 As Date,
       ByVal Confirm_Exit_Insurance As Boolean,
       ByVal Emp_IDW As Int32)
        'ByVal Contract_Expiry_Date As Date,
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_Employee Set Insurance_Status = @Insurance_Status,Jop_Code_insurance = @Jop_Code_insurance,Jop_Name_insurance = @Jop_Name_insurance,Number_Insurance = @Number_Insurance,Date_Insurance_Start = @Date_Insurance_Start,Insurance_Salary = @Insurance_Salary,Percentage_Insurance_Payable = @Percentage_Insurance_Payable,Form_S1 = @Form_S1,Confirmation_Insurance_Entry = @Confirmation_Insurance_Entry,Delivery_Date_S1 = @Delivery_Date_S1,Receive_Date_S1 = @Receive_Date_S1,Form_S6 = @Form_S6,Delivery_Date_S6 = @Delivery_Date_S6,Receive_Date_S6 = @Receive_Date_S6,Entrance_Date_S1 = @Entrance_Date_S1,Entrance_Number_S1 = @Entrance_Number_S1,Contract_Renewal_Date = @Contract_Renewal_Date,Contract_Renewal_Month = @Contract_Renewal_Month,Entrance_Number_S6 = @Entrance_Number_S6,Entrance_Date_S6 = @Entrance_Date_S6,Confirm_Exit_Insurance = @Confirm_Exit_Insurance Where Emp_ID = @Emp_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Insurance_Status", SqlDbType.VarChar).Value = Insurance_Status
            .Parameters.AddWithValue("@Jop_Code_insurance", SqlDbType.Int).Value = Jop_Code_insurance
            .Parameters.AddWithValue("@Jop_Name_insurance", SqlDbType.VarChar).Value = Jop_Name_insurance
            .Parameters.AddWithValue("@Number_Insurance", SqlDbType.Int).Value = Number_Insurance
            .Parameters.AddWithValue("@Date_Insurance_Start", SqlDbType.Date).Value = Date_Insurance_Start
            .Parameters.AddWithValue("@Insurance_Salary", SqlDbType.Decimal).Value = Insurance_Salary
            .Parameters.AddWithValue("@Percentage_Insurance_Payable", SqlDbType.Decimal).Value = Percentage_Insurance_Payable
            .Parameters.AddWithValue("@Form_S1", SqlDbType.Decimal).Value = Form_S1
            .Parameters.AddWithValue("@Confirmation_Insurance_Entry", SqlDbType.Decimal).Value = Confirmation_Insurance_Entry
            .Parameters.AddWithValue("@Delivery_Date_S1", SqlDbType.Date).Value = Delivery_Date_S1
            .Parameters.AddWithValue("@Receive_Date_S1", SqlDbType.Date).Value = Receive_Date_S1
            .Parameters.AddWithValue("@Form_S6", SqlDbType.Decimal).Value = Form_S6
            .Parameters.AddWithValue("@Delivery_Date_S6", SqlDbType.Date).Value = Delivery_Date_S6
            .Parameters.AddWithValue("@Receive_Date_S6", SqlDbType.Date).Value = Receive_Date_S6
            .Parameters.AddWithValue("@Entrance_Date_S1", SqlDbType.Date).Value = Entrance_Date_S1
            .Parameters.AddWithValue("@Entrance_Number_S1", SqlDbType.Int).Value = Entrance_Number_S1
            .Parameters.AddWithValue("@Contract_Renewal_Date", SqlDbType.Date).Value = Contract_Renewal_Date
            '.Parameters.AddWithValue("@Contract_Expiry_Date", SqlDbType.Date).Value = Contract_Expiry_Date
            .Parameters.AddWithValue("@Contract_Renewal_Month", SqlDbType.Int).Value = Contract_Renewal_Month
            .Parameters.AddWithValue("@Entrance_Number_S6", SqlDbType.Int).Value = Entrance_Number_S6
            .Parameters.AddWithValue("@Entrance_Date_S6", SqlDbType.Date).Value = Entrance_Date_S6
            .Parameters.AddWithValue("@Confirm_Exit_Insurance", SqlDbType.Decimal).Value = Confirm_Exit_Insurance
            .Parameters.AddWithValue("@Emp_ID", SqlDbType.Int).Value = Emp_IDW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        'MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Public Sub Update_Health_Card(ByVal Health_Card As String, ByVal Health_Card_Number As Int32, ByVal Health_Card_Start_Date As Date, ByVal Health_Card_Renewal_Date As Date, ByVal Medical_Exam_Form_Submission As Boolean, ByVal Emp_IDW As Int32)
        'ByVal Hiring_Date_Health_Card As DateTime
        'Hiring_Date_Health_Card = @Hiring_Date_Health_Card
        'ByVal Health_Card_Expiration_Date As DateTime
        'Health_Card_Expiration_Date = @Health_Card_Expiration_Date
        'ByVal The_health_card_remains_expire As Date
        'The_health_card_remains_expire = @The_health_card_remains_expire
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_Employee Set Health_Card = @Health_Card,Health_Card_Number = @Health_Card_Number,Health_Card_Start_Date = @Health_Card_Start_Date,Health_Card_Renewal_Date = @Health_Card_Renewal_Date,Medical_Exam_Form_Submission = @Medical_Exam_Form_Submission Where Emp_ID = @Emp_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Health_Card", SqlDbType.VarChar).Value = Health_Card
            .Parameters.AddWithValue("@Health_Card_Number", SqlDbType.Int).Value = Health_Card_Number
            .Parameters.AddWithValue("@Health_Card_Start_Date", SqlDbType.Date).Value = Health_Card_Start_Date
            '.Parameters.AddWithValue("@Health_Card_Expiration_Date", SqlDbType.Date).Value = Health_Card_Expiration_Date
            '.Parameters.AddWithValue("@Hiring_Date_Health_Card", SqlDbType.Date).Value = Hiring_Date_Health_Card
            .Parameters.AddWithValue("@Health_Card_Renewal_Date", SqlDbType.Date).Value = Health_Card_Renewal_Date
            '.Parameters.AddWithValue("@The_health_card_remains_expire", SqlDbType.Date).Value = The_health_card_remains_expire
            .Parameters.AddWithValue("@Medical_Exam_Form_Submission", SqlDbType.Decimal).Value = Medical_Exam_Form_Submission
            .Parameters.AddWithValue("@Emp_ID", SqlDbType.Int).Value = Emp_IDW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        'MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Public Sub Update_Employee_papers(ByVal Military_Service_Certificate As String, ByVal Qualification_Certificate As String, ByVal Birth_Certificate As Boolean, ByVal Insurance_Printout As Boolean, ByVal ID_Card_Photo As Boolean, ByVal Personal_Photos As Boolean, ByVal Employment_Contract As Boolean, ByVal Medical_Exam_Form As Boolean, ByVal Criminal_Record_Check As Boolean, ByVal Social_Status_Report As Boolean, ByVal Work_Heel As Boolean, ByVal Heel_Work_Number As Int32, ByVal Heel_Work_Recipient As String, ByVal Heel_Work_Recipient_Address As String, ByVal Skill_level_measurement_certificate As Boolean, ByVal Emp_IDW As Int32)
        'ByVal Heel_Work_Registration_Date As DateTime
        'Heel_Work_Registration_Date = @Heel_Work_Registration_Date
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_Employee Set Military_Service_Certificate = @Military_Service_Certificate,Qualification_Certificate = @Qualification_Certificate,Birth_Certificate = @Birth_Certificate,Insurance_Printout = @Insurance_Printout,ID_Card_Photo = @ID_Card_Photo,Personal_Photos = @Personal_Photos,Employment_Contract = @Employment_Contract,Medical_Exam_Form = @Medical_Exam_Form,Criminal_Record_Check = @Criminal_Record_Check,Social_Status_Report = @Social_Status_Report,Work_Heel = @Work_Heel,Heel_Work_Number = @Heel_Work_Number,Heel_Work_Recipient = @Heel_Work_Recipient,Heel_Work_Recipient_Address = @Heel_Work_Recipient_Address,Skill_level_measurement_certificate = @Skill_level_measurement_certificate Where Emp_ID = @Emp_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Military_Service_Certificate", SqlDbType.VarChar).Value = Military_Service_Certificate
            .Parameters.AddWithValue("@Qualification_Certificate", SqlDbType.VarChar).Value = Qualification_Certificate
            .Parameters.AddWithValue("@Birth_Certificate", SqlDbType.Decimal).Value = Birth_Certificate
            .Parameters.AddWithValue("@Insurance_Printout", SqlDbType.Decimal).Value = Insurance_Printout
            .Parameters.AddWithValue("@ID_Card_Photo", SqlDbType.Decimal).Value = ID_Card_Photo
            .Parameters.AddWithValue("@Personal_Photos", SqlDbType.Decimal).Value = Personal_Photos
            .Parameters.AddWithValue("@Employment_Contract", SqlDbType.Decimal).Value = Employment_Contract
            .Parameters.AddWithValue("@Medical_Exam_Form", SqlDbType.Decimal).Value = Medical_Exam_Form
            .Parameters.AddWithValue("@Criminal_Record_Check", SqlDbType.Decimal).Value = Criminal_Record_Check
            .Parameters.AddWithValue("@Social_Status_Report", SqlDbType.Decimal).Value = Social_Status_Report
            .Parameters.AddWithValue("@Work_Heel", SqlDbType.Decimal).Value = Work_Heel
            .Parameters.AddWithValue("@Heel_Work_Number", SqlDbType.Int).Value = Heel_Work_Number
            '.Parameters.AddWithValue("@Heel_Work_Registration_Date", SqlDbType.Date).Value = Heel_Work_Registration_Date
            .Parameters.AddWithValue("@Heel_Work_Recipient", SqlDbType.VarChar).Value = Heel_Work_Recipient
            .Parameters.AddWithValue("@Heel_Work_Recipient_Address", SqlDbType.VarChar).Value = Heel_Work_Recipient_Address
            .Parameters.AddWithValue("@Skill_level_measurement_certificate", SqlDbType.VarChar).Value = Skill_level_measurement_certificate
            .Parameters.AddWithValue("@Emp_ID", SqlDbType.Int).Value = Emp_IDW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        'MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Private Sub Emp_Image_Click(sender As Object, e As EventArgs) Handles Emp_Image.Click
        Try
            ChoosePicture(Emp_Image)
            Update_Emp_Image(Emp_Image, Emp_ID.Text)
        Catch ex As Exception
            MessageBox.Show("خطأ: " & ex.Message)
        End Try

    End Sub

    Public Sub Update_Emp_Image(ByVal Emp_Image As PictureBox, ByVal Emp_IDW As Int32)
        ' التحقق مما إذا كانت الصورة تمثل قيمة صالحة
        If Emp_Image.Image IsNot Nothing Then
            Dim Cmd As New SqlCommand
            With Cmd
                .Connection = Con
                .CommandType = CommandType.Text
                .CommandText = "Update Tbl_Employee Set Emp_Image = @Emp_Image Where Emp_ID = @Emp_ID"
                .Parameters.Clear()
                Dim ms As New MemoryStream()
                Dim bmpImage As New Bitmap(Emp_Image.Image)
                bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim data As Byte() = ms.GetBuffer()
                Dim p As New SqlParameter("@Emp_Image", SqlDbType.Image)
                p.Value = data
                .Parameters.Add(p)
                .Parameters.AddWithValue("@Emp_ID", SqlDbType.Int).Value = Emp_IDW
            End With
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Cmd.ExecuteNonQuery()
            Con.Close()
            Cmd = Nothing
        Else
            ' إشعار المستخدم بأنه يجب اختيار صورة
            MsgBox("الرجاء اختيار صورة", MsgBoxStyle.Information, "تنبيه")
        End If
    End Sub

    Private Function GetValueOrDefault(ByVal value As Object) As String
        If Not IsDBNull(value) Then
            Return value.ToString()
        Else
            Return String.Empty
        End If
    End Function

    Private Function GetValueforCombobox(ByVal value As Object) As String
        'الكود ده للكمبوبوكس عشان لو فاضى ميدنيش خطأ
        If Not IsDBNull(value) Then
            Return value.ToString()
        Else
            Return -1
        End If
    End Function


    'Private Function PerformExpensiveOperation() As String
    '    ' محاكاة عملية باهظة التكلفة
    '    Thread.Sleep(3000) ' تأخير 3 ثواني
    '    Return "Data fetched"
    'End Function


    'Dim performanceEnhancer As PerformanceEnhancer = PerformanceEnhancer.GetInstance()

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
                        Emp_Phone1.Text = reader("Emp_Phone1").ToString()
                        Emp_Phone2.Text = reader("Emp_Phone2").ToString()
                        Emp_Address.Text = reader("Emp_Address").ToString()
                        Emp_Marital_Status.Text = reader("Emp_Marital_Status").ToString()
                        Emp_Nationality.Text = reader("Emp_Nationality").ToString()
                        If Not IsDBNull(reader("People_With_Special_Needs")) Then
                            People_With_Special_Needs.Checked = CType(reader("People_With_Special_Needs"), Boolean)
                        End If
                        National_ID.Text = reader("National_ID").ToString()
                        Mother_Name.Text = reader("Mother_Name").ToString()
                        Date_Birth.Text = reader("Date_Birth").ToString()
                        Place_Birth.Text = reader("Place_Birth").ToString()
                        ' استرداد الصورة إذا كانت متاحة
                        If Not IsDBNull(reader("Emp_Image")) Then
                            Dim imageData As Byte() = DirectCast(reader("Emp_Image"), Byte())
                            Using ms As New System.IO.MemoryStream(imageData)
                                Emp_Image.Image = Image.FromStream(ms)
                            End Using
                        Else
                            Emp_Image.Image = My.Resources.icons8_add_image_96
                        End If
                        Personal_ID_Expiry_Date.Text = reader("Personal_ID_Expiry_Date").ToString()
                        ' استرداد الحقول الإضافية
                        Emp_First_Name.Text = reader("Emp_First_Name").ToString()
                        Emp_Second_Name.Text = reader("Emp_Second_Name").ToString()
                        Emp_Name_English.Text = reader("Emp_Name_English").ToString()
                        Emp_Type.Text = reader("Emp_Type").ToString()
                        Working_Condition.Text = reader("Working_Condition").ToString()
                        Dept_Code.Text = reader("Dept_Name").ToString()
                        Jop_Code.Text = reader("Jop_Name").ToString()
                        Emp_Date_Hiring.Text = reader("Emp_Date_Hiring").ToString()
                        Emp_Car.Text = reader("Emp_Car").ToString()
                        Car_Ride_Time.Text = reader("Car_Ride_Time").ToString()
                        Car_Pick_Up_Point.Text = reader("Car_Pick_Up_Point").ToString()
                        Insurance_Status.Text = reader("Insurance_Status").ToString()
                        Jop_Name_insurance.SelectedValue = GetValueforCombobox(reader("Jop_Code_insurance"))
                        Jop_Code_insurance.Text = reader("Jop_Code_insurance").ToString()

                        Number_Insurance.Text = reader("Number_Insurance").ToString()
                        Date_Insurance_Start.Text = reader("Date_Insurance_Start").ToString()
                        Insurance_Salary.Text = reader("Insurance_Salary").ToString()
                        Due_Insurance_Amount.Text = reader("Due_Insurance_Amount").ToString()
                        Percentage_Insurance_Payable.Text = reader("Percentage_Insurance_Payable").ToString()
                        If Not IsDBNull(reader("Form_S1")) Then
                            Form_S1.Checked = CType(reader("Form_S1"), Boolean)
                        End If
                        If Not IsDBNull(reader("Confirmation_Insurance_Entry")) Then
                            Confirmation_Insurance_Entry.Checked = CType(reader("Confirmation_Insurance_Entry"), Boolean)
                        End If
                        Delivery_Date_S1.Text = reader("Delivery_Date_S1").ToString()
                        Receive_Date_S1.Text = reader("Receive_Date_S1").ToString()
                        If Not IsDBNull(reader("Form_S6")) Then
                            Form_S6.Checked = CType(reader("Form_S6"), Boolean)
                        End If

                        Delivery_Date_S6.Text = reader("Delivery_Date_S6").ToString()
                        Receive_Date_S6.Text = reader("Receive_Date_S6").ToString()
                        If Not IsDBNull(reader("Skill_level_measurement_certificate")) Then
                            Skill_level_measurement_certificate.Checked = CType(reader("Skill_level_measurement_certificate"), Boolean)
                        End If
                        CurrentWeekShift.Text = reader("CurrentWeekShift").ToString()
                        NextWeekShift.Text = reader("NextWeekShift").ToString()
                        Friday_Operation.Text = reader("Friday_Operation").ToString()
                        Shift_Type.Text = reader("Shift_Type").ToString()
                        Entrance_Date_S1.Text = reader("Entrance_Date_S1").ToString()
                        Entrance_Number_S1.Text = reader("Entrance_Number_S1").ToString()
                        Remaining_Contract_Renewal.Text = reader("Remaining_Contract_Renewal").ToString()
                        If Not IsDBNull(reader("Medical_Exam_Form_Submission")) Then
                            Medical_Exam_Form_Submission.Checked = CType(reader("Medical_Exam_Form_Submission"), Boolean)
                        End If
                        Years_Since_Contract_Start.Text = reader("Years_Since_Contract_Start").ToString()
                        Contract_Renewal_Date.Text = reader("Contract_Renewal_Date").ToString()
                        Contract_Expiry_Date.Text = reader("Contract_Expiry_Date").ToString()
                        Jop_Code_insurance.Text = reader("Jop_Code_insurance").ToString()
                        Contract_Renewal_Month.Text = reader("Contract_Renewal_Month").ToString()
                        Military_Service_Certificate.Text = reader("Military_Service_Certificate").ToString()
                        Qualification_Certificate.Text = reader("Qualification_Certificate").ToString()
                        If Not IsDBNull(reader("Birth_Certificate")) Then
                            Birth_Certificate.Checked = CType(reader("Birth_Certificate"), Boolean)
                        End If
                        If Not IsDBNull(reader("Insurance_Printout")) Then
                            Insurance_Printout.Checked = CType(reader("Insurance_Printout"), Boolean)
                        End If
                        If Not IsDBNull(reader("ID_Card_Photo")) Then
                            ID_Card_Photo.Checked = CType(reader("ID_Card_Photo"), Boolean)
                        End If
                        If Not IsDBNull(reader("Personal_Photos")) Then
                            Personal_Photos.Checked = CType(reader("Personal_Photos"), Boolean)
                        End If
                        If Not IsDBNull(reader("Employment_Contract")) Then
                            Employment_Contract.Checked = CType(reader("Employment_Contract"), Boolean)
                        End If

                        If Not IsDBNull(reader("Medical_Exam_Form")) Then
                            Medical_Exam_Form.Checked = CType(reader("Medical_Exam_Form"), Boolean)
                        End If
                        If Not IsDBNull(reader("Criminal_Record_Check")) Then
                            Criminal_Record_Check.Checked = CType(reader("Criminal_Record_Check"), Boolean)
                        End If

                        If Not IsDBNull(reader("Social_Status_Report")) Then
                            Social_Status_Report.Checked = CType(reader("Social_Status_Report"), Boolean)
                        End If
                        If Not IsDBNull(reader("Work_Heel")) Then
                            Work_Heel.Checked = CType(reader("Work_Heel"), Boolean)
                        End If
                        Heel_Work_Number.Text = reader("Heel_Work_Number").ToString()
                        Heel_Work_Recipient.Text = reader("Heel_Work_Recipient").ToString()
                        Heel_Work_Recipient_Address.Text = reader("Heel_Work_Recipient_Address").ToString()
                        Entrance_Number_S6.Text = reader("Entrance_Number_S6").ToString
                        Shift_paper.Text = reader("Shift_paper").ToString()
                        Age.Text = reader("Age").ToString()

                        Health_Card.Text = reader("Health_Card").ToString()
                        Health_Card_Number.Text = reader("Health_Card_Number").ToString()
                        'Health_Card_Start_Date.Text = reader("Health_Card_Start_Date").ToString()
                        If IsDBNull(reader("Health_Card_Start_Date")) OrElse String.IsNullOrEmpty(reader("Health_Card_Start_Date").ToString()) Then
                            Health_Card_Start_Date.Value = New DateTime(1900, 1, 1)
                        Else
                            Health_Card_Start_Date.Value = Convert.ToDateTime(reader("Health_Card_Start_Date"))
                        End If
                        'Health_Card_Renewal_Date.Value = reader("Health_Card_Renewal_Date").ToString()
                        If IsDBNull(reader("Health_Card_Renewal_Date")) OrElse String.IsNullOrEmpty(reader("Health_Card_Renewal_Date").ToString()) Then
                            Health_Card_Renewal_Date.Value = New DateTime(1900, 1, 1)
                        Else
                            Health_Card_Renewal_Date.Value = Convert.ToDateTime(reader("Health_Card_Renewal_Date"))
                        End If

                        'Date_Resignation.Value = reader("Date_Resignation").ToString()
                        If IsDBNull(reader("Date_Resignation")) OrElse String.IsNullOrEmpty(reader("Date_Resignation").ToString()) Then
                            Date_Resignation.Value = New DateTime(1900, 1, 1)
                        Else
                            Date_Resignation.Value = Convert.ToDateTime(reader("Date_Resignation"))
                        End If
                        Reason_Resignation.Text = reader("Reason_Resignation").ToString()
                        'Heel_Work_Registration_Date.Value = reader("Heel_Work_Registration_Date").ToString()
                        If IsDBNull(reader("Heel_Work_Registration_Date")) OrElse String.IsNullOrEmpty(reader("Heel_Work_Registration_Date").ToString()) Then
                            Heel_Work_Registration_Date.Value = New DateTime(1900, 1, 1)
                        Else
                            Heel_Work_Registration_Date.Value = Convert.ToDateTime(reader("Heel_Work_Registration_Date"))
                        End If
                        'Health_Card_Expiration_Date.Value = reader("Health_Card_Expiration_Date").ToString()
                        If IsDBNull(reader("Health_Card_Expiration_Date")) OrElse String.IsNullOrEmpty(reader("Health_Card_Expiration_Date").ToString()) Then
                            Health_Card_Expiration_Date.Value = New DateTime(1900, 1, 1)
                        Else
                            Health_Card_Expiration_Date.Value = Convert.ToDateTime(reader("Health_Card_Expiration_Date"))
                        End If
                        'Hiring_Date_Health_Card.Value = reader("Hiring_Date_Health_Card").ToString()
                        If IsDBNull(reader("Hiring_Date_Health_Card")) OrElse String.IsNullOrEmpty(reader("Hiring_Date_Health_Card").ToString()) Then
                            Hiring_Date_Health_Card.Value = New DateTime(1900, 1, 1)
                        Else
                            Hiring_Date_Health_Card.Value = Convert.ToDateTime(reader("Hiring_Date_Health_Card"))
                        End If
                        The_health_card_remains_expire.Text = reader("The_health_card_remains_expire").ToString()
                        'End_date_probationary_period.Value = reader("End_date_probationary_period").ToString()
                        If IsDBNull(reader("End_date_probationary_period")) OrElse String.IsNullOrEmpty(reader("End_date_probationary_period").ToString()) Then
                            End_date_probationary_period.Value = New DateTime(1900, 1, 1)
                        Else
                            End_date_probationary_period.Value = Convert.ToDateTime(reader("End_date_probationary_period"))
                        End If

                        If Not IsDBNull(reader("Confirm_Exit_Insurance")) Then
                            Confirm_Exit_Insurance.Checked = CType(reader("Confirm_Exit_Insurance"), Boolean)
                        End If
                        Governorate.Text = reader("Governorate").ToString()
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

    Public Sub Update_Emp_Full_Name(ByVal Emp_Full_Name As String, ByVal Emp_IDW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_Employee Set Emp_Full_Name = @Emp_Full_Name Where Emp_ID = @Emp_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Emp_Full_Name", SqlDbType.VarChar).Value = Emp_Full_Name
            .Parameters.AddWithValue("@Emp_ID", SqlDbType.Int).Value = Emp_IDW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        'MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Private Sub Emp_ID_KeyDown(sender As Object, e As KeyEventArgs) Handles Emp_ID.KeyDown
        ' التأكد من أن المفتاح المضغوط هو مفتاح Enter
        If e.KeyCode = Keys.Enter Then
            ' تنفيذ الكود لاسترداد بيانات الموظف
            RetrieveEmployeeData(Emp_ID.Text)
            Emp_ID.SelectAll()
        End If
    End Sub

    Public Sub Update_Place_Birth(ByVal Place_Birth As String, ByVal Emp_IDW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_Employee Set Place_Birth = @Place_Birth Where Emp_ID = @Emp_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Place_Birth", SqlDbType.VarChar).Value = Place_Birth
            .Parameters.AddWithValue("@Emp_ID", SqlDbType.Int).Value = Emp_IDW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        'MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Public Sub Update_Birth_Certificate(ByVal Birth_Certificate As Boolean, ByVal Emp_IDW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_Employee Set Birth_Certificate = @Birth_Certificate Where Emp_ID = @Emp_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Birth_Certificate", SqlDbType.Decimal).Value = Birth_Certificate
            .Parameters.AddWithValue("@Emp_ID", SqlDbType.Int).Value = Emp_IDW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        'MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Private Sub Birth_Certificate_Click(sender As Object, e As EventArgs) Handles Birth_Certificate.Click
        Update_Birth_Certificate(Birth_Certificate.Checked, Emp_ID.Text)
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


    Private Sub BtnNewAdd_Click(sender As Object, e As EventArgs) Handles BtnNewAdd.Click
        Frm_Car.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Add_CarBoint.Click
        Frm_Waiting_Point.ShowDialog()
    End Sub

    Private Sub Emp_Full_Name_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles Emp_Full_Name.Enter, Emp_First_Name.Enter, Emp_Second_Name.Enter, Emp_Address.Enter, Txt_Search.Enter
        'هذا الحدث لتغيير لغة الكتابة الى العربية فى اى تيكست بوكس اريده
        Arabic(DirectCast(sender, TextBox))
    End Sub

    Private Sub Emp_Name_English_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles Emp_Name_English.Enter
        'هذا الحدث لتغيير لغة الكتابة الى الانجليزية فى اى تيكست بوكس اريده
        English(DirectCast(sender, TextBox))
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        '-------------------------------------------------------------------------------------------------------
        'خاص بتطبيق الصلاحيات
        If Not CanEdit Then
            MessageBox.Show("ليس لديك صلاحية التعديل.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        '-------------------------------------------------------------------------------------------------------

        Try
            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If
            Dim Command As New SqlCommand("CalculateDueInsuranceAmountForAllRows", Con)
            Command.CommandType = CommandType.StoredProcedure
            Command.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("خطأ: " & ex.Message)
        End Try
        If Emp_ID.Text = vbNullString OrElse Emp_Full_Name.Text = vbNullString Then
            If Emp_ID.Text = vbNullString Then
                MessageBox.Show("قم باختيار الموظف أولاً", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Else
                MessageBox.Show("قم بكتابة اسم الموظف أولاً", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            End If
            Exit Sub
        End If

        Dim Date_BirthValue As Date = GetDateValueFor_date_Birth(Date_Birth.Value)
        Dim Emp_Date_HiringValue As Date = GetDateValue(Emp_Date_Hiring.Value)
        Dim Personal_ID_Expiry_Date_Value As Date = GetDateValueFor_date_Birth(Personal_ID_Expiry_Date.Value)
        Dim numberInsuranceValue As Integer = GetIntegerValue(Number_Insurance.Text)
        Dim insuranceSalaryValue As Double = GetDoubleValue(Insurance_Salary.Text)
        Dim Percentage_Insurance_PayableValue As Double = (GetDoubleValue(Percentage_Insurance_Payable.Text))
        Dim Entrance_NumberValue As Integer = GetIntegerValue(Entrance_Number_S1.Text)
        Dim Jop_Code_insuranceValue As Integer = GetIntegerValue(Jop_Code_insurance.Text)
        Dim Contract_Renewal_MonthValue As Integer = GetIntegerValue(Contract_Renewal_Month.Text)
        Dim Entrance_Number_S6Value As Integer = GetIntegerValue(Entrance_Number_S6.Text)
        Dim Heel_Work_NumberValue As Integer = GetIntegerValue(Heel_Work_Number.Text)
        Dim Health_Card_Number_Value As Integer = GetIntegerValue(Health_Card_Number.Text)
        Dim MovementDescription As String = " تم تعديل بيانات " + Emp_Full_Name.Text
        Dim DeviceName As String = Environ$("computername")
        Try
            Update_Personal(Emp_First_Name.Text, Emp_Second_Name.Text, Emp_Full_Name.Text, Emp_Name_English.Text, Emp_Phone1.Text, Emp_Phone2.Text, Emp_Address.Text, Emp_Marital_Status.Text, Emp_Nationality.Text, People_With_Special_Needs.Checked, National_ID.Text, Date_BirthValue, Place_Birth.Text, Personal_ID_Expiry_Date_Value, Emp_Type.Text, Mother_Name.Text, Governorate.Text, Emp_ID.Text)
            'End_date_probationary_period.Value
            Update_Work(Working_Condition.Text, Int(Dept_Code.SelectedValue), Dept_Code.Text, Int(Jop_Code.SelectedValue), Jop_Code.Text, Emp_Date_HiringValue, Emp_ID.Text)
            Update_Shift_Car(Emp_Car.Text, Car_Ride_Time.Value, Car_Pick_Up_Point.Text, CurrentWeekShift.Text, Friday_Operation.Text, Shift_Type.Text, Shift_paper.Text, Emp_ID.Text)
            Update_Insurance_Status(Insurance_Status.Text, Jop_Code_insuranceValue, Jop_Name_insurance.Text, numberInsuranceValue, Date_Insurance_Start.Value, insuranceSalaryValue, Percentage_Insurance_PayableValue, Form_S1.Checked, Confirmation_Insurance_Entry.Checked, Delivery_Date_S1.Value, Receive_Date_S1.Value, Form_S6.Checked, Delivery_Date_S6.Value, Receive_Date_S6.Value, Entrance_Date_S1.Value, Entrance_NumberValue, Contract_Renewal_Date.Value, Contract_Renewal_MonthValue, Entrance_Number_S6Value, Entrance_Date_S6.Value, Confirm_Exit_Insurance.Checked, Emp_ID.Text)
            'Heel_Work_Registration_Date.Value
            Update_Employee_papers(Military_Service_Certificate.Text, Qualification_Certificate.Text, Birth_Certificate.Checked, Insurance_Printout.Checked, ID_Card_Photo.Checked, Personal_Photos.Checked, Employment_Contract.Checked, Medical_Exam_Form.Checked, Criminal_Record_Check.Checked, Social_Status_Report.Checked, Work_Heel.Checked, Heel_Work_NumberValue, Heel_Work_Recipient.Text, Heel_Work_Recipient_Address.Text, Skill_level_measurement_certificate.Checked, Emp_ID.Text)
            'Hiring_Date_Health_Card.Value
            'Health_Card_Expiration_Date.Value
            Update_Health_Card(Health_Card.Text, Health_Card_Number_Value, Health_Card_Start_Date.Value, Health_Card_Renewal_Date.Value, Medical_Exam_Form_Submission.Checked, Emp_ID.Text)
            SelectAll_Tbl_EmployeeAsync(dgv_Tbl_Employee)
            Insert_MovementHistory(MovementDescription, DateTime.Now, loggedInUserName, DeviceName, Me.Name, "BtnEdit")
        Catch ex As Exception
            MessageBox.Show("خطأ: " & ex.Message)
        End Try
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
    End Sub

    Public Sub Update_People_With_Special_Needs(ByVal People_With_Special_Needs As Boolean, ByVal Emp_IDW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_Employee Set People_With_Special_Needs = @People_With_Special_Needs Where Emp_ID = @Emp_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@People_With_Special_Needs", SqlDbType.Decimal).Value = People_With_Special_Needs
            .Parameters.AddWithValue("@Emp_ID", SqlDbType.Int).Value = Emp_IDW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        'MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Private Sub People_With_Special_Needs_Click(sender As Object, e As EventArgs) Handles People_With_Special_Needs.Click
        Update_People_With_Special_Needs(People_With_Special_Needs.Checked, Emp_ID.Text)
    End Sub

    Private Sub Emp_IDlbl_Click(sender As Object, e As EventArgs) Handles Emp_IDlbl.Click
        ClearControls()
    End Sub


    Public Sub Update_Personal_ID_Expiry_Date(ByVal Personal_ID_Expiry_Date As DateTime, ByVal Emp_IDW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_Employee Set Personal_ID_Expiry_Date = @Personal_ID_Expiry_Date Where Emp_ID = @Emp_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Personal_ID_Expiry_Date", SqlDbType.Date).Value = Personal_ID_Expiry_Date
            .Parameters.AddWithValue("@Emp_ID", SqlDbType.Int).Value = Emp_IDW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        'MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Private Sub Personal_ID_Expiry_Date_KeyDown(sender As Object, e As KeyEventArgs) Handles Personal_ID_Expiry_Date.KeyDown
        If e.KeyCode = Keys.Enter Then
            Update_Personal_ID_Expiry_Date(Personal_ID_Expiry_Date.Value, Emp_ID.Text)
        End If
    End Sub

    Public Sub Update_Emp_Type(ByVal Emp_Type As String, ByVal Emp_IDW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_Employee Set Emp_Type = @Emp_Type Where Emp_ID = @Emp_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Emp_Type", SqlDbType.VarChar).Value = Emp_Type
            .Parameters.AddWithValue("@Emp_ID", SqlDbType.Int).Value = Emp_IDW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Private Sub Emp_Type_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Update_Emp_Type(Emp_Type.Text, Emp_ID.Text)
        End If
    End Sub

    Public Sub Update_Working_Condition(ByVal Working_Condition As String, ByVal Emp_IDW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_Employee Set Working_Condition = @Working_Condition Where Emp_ID = @Emp_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Working_Condition", SqlDbType.VarChar).Value = Working_Condition
            .Parameters.AddWithValue("@Emp_ID", SqlDbType.Int).Value = Emp_IDW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Public Sub Update_Dept_Code(ByVal Dept_Code As Int32, ByVal Dept_Name As String, ByVal Emp_IDW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_Employee Set Dept_Code = @Dept_Code,Dept_Name = @Dept_Name Where Emp_ID = @Emp_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Dept_Code", SqlDbType.Int).Value = Dept_Code
            .Parameters.AddWithValue("@Dept_Name", SqlDbType.VarChar).Value = Dept_Name
            .Parameters.AddWithValue("@Emp_ID", SqlDbType.Int).Value = Emp_IDW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Private Sub Dept_Code_KeyDown(sender As Object, e As KeyEventArgs) Handles Dept_Code.KeyDown
        If e.KeyCode = Keys.Enter Then
            Update_Dept_Code(Int(Dept_Code.SelectedValue), Dept_Code.Text, Emp_ID.Text)
        End If
    End Sub

    Public Sub Update_Jop_Code(ByVal Jop_Code As Int32, ByVal Jop_Name As String, ByVal Emp_IDW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_Employee Set Jop_Code = @Jop_Code,Jop_Name = @Jop_Name Where Emp_ID = @Emp_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Jop_Code", SqlDbType.Int).Value = Jop_Code
            .Parameters.AddWithValue("@Jop_Name", SqlDbType.VarChar).Value = Jop_Name
            .Parameters.AddWithValue("@Emp_ID", SqlDbType.Int).Value = Emp_IDW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Private Sub Jop_Code_KeyDown(sender As Object, e As KeyEventArgs) Handles Jop_Code.KeyDown
        If e.KeyCode = Keys.Enter Then
            Update_Jop_Code(Int(Jop_Code.SelectedValue), Jop_Code.Text, Emp_ID.Text)
        End If
    End Sub

    Public Sub Update_Emp_Date_Hiring(ByVal Emp_Date_Hiring As DateTime, ByVal Emp_IDW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_Employee Set Emp_Date_Hiring = @Emp_Date_Hiring Where Emp_ID = @Emp_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Emp_Date_Hiring", SqlDbType.Date).Value = Emp_Date_Hiring
            .Parameters.AddWithValue("@Emp_ID", SqlDbType.Int).Value = Emp_IDW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        'End_date_probationary_period.Value
        Update_Work(Working_Condition.Text, Int(Dept_Code.SelectedValue), Dept_Code.Text, Int(Jop_Code.SelectedValue), Jop_Code.Text, Emp_Date_Hiring.Value, Emp_ID.Text)
    End Sub

    Private Sub PopulateTextBox(textBox As TextBox, columnName As String)
        Dim value = dgv_Tbl_Employee.CurrentRow.Cells(columnName).Value
        textBox.Text = If(Not IsDBNull(value), value.ToString(), "")
    End Sub

    Private Sub dgv_Tbl_Employee_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim CurrentRow As DataGridViewRow = dgv_Tbl_Employee.CurrentRow
        Try
            If Con.State = 1 Then Con.Close()
            Con.Open()
            PopulateTextBox(Me.Emp_ID, "Emp_ID")
            RetrieveEmployeeData(Emp_ID.Text)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Txt_Search_TextChanged(sender As Object, e As EventArgs) Handles Txt_Search.TextChanged
        Try
            Dim dv As DataView = dt_Tbl_Employee.DefaultView
            Select Case ComboSearch.Text
                Case "اسم الموظف"
                    dv.RowFilter = " Emp_Full_Name LIKE '%" & Txt_Search.Text & "%' "
                Case "رقم التليفون"
                    dv.RowFilter = " Emp_Phone1 LIKE '%" & Txt_Search.Text & "%' "
                Case "رقم البطاقة الشخصية"
                    dv.RowFilter = " National_ID LIKE '%" & Txt_Search.Text & "%' "
                Case "الرقم التأمينى"
                    dv.RowFilter = "Convert(Number_Insurance, 'System.String') LIKE '%" & Txt_Search.Text & "%' "
                Case "الجنسية"
                    dv.RowFilter = " Emp_Nationality LIKE '%" & Txt_Search.Text & "%' "
                Case "تاريخ التعيين"
                    dv.RowFilter = " Emp_Date_Hiring LIKE '%" & Txt_Search.Text & "%' "
                Case "القسم"
                    dv.RowFilter = " Dept_Name LIKE '%" & Txt_Search.Text & "%' "
                Case "الوظيفة"
                    dv.RowFilter = " Jop_Name LIKE '%" & Txt_Search.Text & "%' "
                Case "الوظيفة"
                    dv.RowFilter = " Jop_Name LIKE '%" & Txt_Search.Text & "%' "
                Case "النوع"
                    dv.RowFilter = " Emp_Type LIKE '%" & Txt_Search.Text & "%' "
                Case "الحالة التأمينة"
                    dv.RowFilter = " Insurance_Status LIKE '%" & Txt_Search.Text & "%' "
                Case "البطاقة الصحية"
                    dv.RowFilter = " Health_Card LIKE '%" & Txt_Search.Text & "%' "
                Case "ذوى الاحتياجات الخاصة"
                    dv.RowFilter = " People_With_Special_Needs LIKE '%" & Txt_Search.Text & "%' "
                Case "حالة الموظف"
                    dv.RowFilter = " Working_Condition LIKE '%" & Txt_Search.Text & "%' "
                Case "السيارة"
                    dv.RowFilter = " Emp_Car LIKE '%" & Txt_Search.Text & "%' "
                Case "نقطة تجمع السيارة"
                    dv.RowFilter = " Car_Pick_Up_Point LIKE '%" & Txt_Search.Text & "%' "
                Case "الوردية للاسبوع الحالى"
                    dv.RowFilter = " CurrentWeekShift LIKE '%" & Txt_Search.Text & "%' "
                Case "الوردية للاسبوع القادم"
                    dv.RowFilter = " NextWeekShift LIKE '%" & Txt_Search.Text & "%' "
            End Select
        Catch ex As Exception
        End Try
        Txt_Count.Text = dgv_Tbl_Employee.RowCount.ToString()
    End Sub

    Private Sub SetExcelColumnHeaders(filePath As String, columnNames As List(Of String))
        Using workbook As New XLWorkbook(filePath)
            Dim worksheet = workbook.Worksheets(0)
            For i As Integer = 0 To columnNames.Count - 1
                worksheet.Cell(1, i + 1).Value = columnNames(i)
            Next
            workbook.Save()
        End Using
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Dim numberInsuranceValue As Integer = GetIntegerValue(Number_Insurance.Text)
        Dim insuranceSalaryValue As Double = GetDoubleValue(Insurance_Salary.Text)
        Dim Percentage_Insurance_PayableValue As Double = GetDoubleValue(Due_Insurance_Amount.Text)
        Dim Entrance_NumberValue As Integer = GetIntegerValue(Entrance_Number_S1.Text)
        Dim Jop_Code_insuranceValue As Integer = GetIntegerValue(Jop_Code_insurance.Text)
        Dim Contract_Renewal_MonthValue As Integer = GetIntegerValue(Contract_Renewal_Month.Text)
        Dim Entrance_Number_S6Value As Integer = GetIntegerValue(Entrance_Number_S6.Text)
        ' الآن يمكنك استخدام numberInsuranceValue و insuranceSalaryValue في الدالة Update_Insurance_Status
        Update_Insurance_Status(Insurance_Status.Text, Jop_Code_insuranceValue, Jop_Name_insurance.DisplayMember, numberInsuranceValue, Date_Insurance_Start.Value, insuranceSalaryValue, Percentage_Insurance_PayableValue, Form_S1.Checked, Confirmation_Insurance_Entry.Checked, Delivery_Date_S1.Value, Receive_Date_S1.Value, Form_S6.Checked, Delivery_Date_S6.Value, Receive_Date_S6.Value, Entrance_Date_S1.Value, Entrance_NumberValue, Contract_Renewal_Date.Value, Contract_Renewal_MonthValue, Entrance_Number_S6Value, Entrance_Date_S6.Value, Confirm_Exit_Insurance.Checked, Emp_ID.Text)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        Dim Health_Card_Number_Value As Integer = GetIntegerValue(Health_Card_Number.Text)
        'Hiring_Date_Health_Card.Value
        'Health_Card_Expiration_Date.Value
        Update_Health_Card(Health_Card.Text, Health_Card_Number_Value, Health_Card_Start_Date.Value, Health_Card_Renewal_Date.Value, Medical_Exam_Form_Submission.Checked, Emp_ID.Text)
    End Sub

    Private Sub Health_Card_TextChanged(sender As Object, e As EventArgs) Handles Health_Card.TextChanged
        Select Case Me.Health_Card.Text
            Case "موجودة"
                Me.Health_Card.BackColor = Color.Green
            Case "غير موجودة"
                Me.Health_Card.BackColor = Color.Red
        End Select
    End Sub

    Private Sub Insurance_Status_TextChanged(sender As Object, e As EventArgs) Handles Insurance_Status.TextChanged
        Select Case Me.Insurance_Status.Text
            Case "مؤمن عليه"
                Me.Insurance_Status.BackColor = Color.Green
            Case "غير مؤمن"
                Me.Insurance_Status.BackColor = Color.Red
        End Select
    End Sub

    Private Sub Working_Condition_TextChanged(sender As Object, e As EventArgs) Handles Working_Condition.TextChanged, Reason_Resignation.TextChanged
        Select Case Me.Working_Condition.Text
            Case "سارى"
                Me.Working_Condition.BackColor = Color.Green
                Me.GroupBox3.Visible = False
                Me.Btn_Resignation.Visible = False
                Me.Date_Resignation.Visible = False
                Me.Reason_Resignation.Visible = False
                Me.Date_Resignation_Lbl.Visible = False
                Me.Reason_Resignation_Lbl.Visible = False
                Me.Date_Resignation.Value = New DateTime(1900, 1, 1)
            Case "استقالة"
                Me.Working_Condition.BackColor = Color.Red
                Me.GroupBox3.Visible = True
                Me.Btn_Resignation.Visible = True
                Me.Date_Resignation.Visible = True
                Me.Reason_Resignation.Visible = True
                Me.Date_Resignation_Lbl.Visible = True
                Me.Reason_Resignation_Lbl.Visible = True
                Me.Shift_paper.Text = "لا"
            Case "موقوف"
                Me.Working_Condition.BackColor = Color.Yellow
                Me.GroupBox3.Visible = False
                Me.Btn_Resignation.Visible = False
                Me.Date_Resignation.Visible = False
                Me.Reason_Resignation.Visible = False
                Me.Date_Resignation_Lbl.Visible = False
                Me.Reason_Resignation_Lbl.Visible = False
                Me.Shift_paper.Text = "لا"
                Me.Date_Resignation.Value = New DateTime(1900, 1, 1)
        End Select
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Frm_Add_Jop.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Frm_Add_Department.Show()
    End Sub

    Private Sub Btn_ExportTo_Excel_Click(sender As Object, e As EventArgs) Handles Btn_ExportTo_Excel.Click
        '------------------------------------------------------------------------------------------------------
        'خاص بالصلاحيات للفورم
        If Not CanPrint Then
            MessageBox.Show("ليس لديك صلاحية التصدير.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        '------------------------------------------------------------------------------------------------------
        Dim saveDialog As New SaveFileDialog()
        saveDialog.Filter = "Excel Files|*.xlsx;*.xls"
        saveDialog.Title = "E:\El Dawliya International System\Excel"

        Select Case Me.Combo_Report.Text
            Case "التأمين الأجتماعى"
                Dim columnsToExport As New List(Of String)
                If saveDialog.ShowDialog() = DialogResult.OK Then
                    ' قائمة بأسماء الأعمدة التي تريد تصديرها
                    ' اضف أسماء الأعمدة التي تريد تصديرها إلى القائمة
                    columnsToExport.Add("مسلسل")
                    columnsToExport.Add("Emp_ID")
                    columnsToExport.Add("Emp_Full_Name")
                    columnsToExport.Add("Emp_Date_Hiring")
                    columnsToExport.Add("Dept_Name")
                    columnsToExport.Add("Insurance_Status")
                    columnsToExport.Add("Jop_Code_insurance")
                    columnsToExport.Add("Jop_Name_insurance")
                    columnsToExport.Add("Number_Insurance")
                    columnsToExport.Add("Date_Insurance_Start")
                    columnsToExport.Add("Form_S1")
                    columnsToExport.Add("Confirmation_Insurance_Entry")
                    'columnsToExport.Add("CurrentWeekShift")
                    'columnsToExport.Add("NextWeekShift")
                    'columnsToExport.Add("Shift_Type")
                    ' استدعاء الدالة ExportToExcel مع تمرير قائمة الأعمدة المرغوب تصديرها
                    ExportToExcel(dgv_Tbl_Employee, saveDialog.FileName, columnsToExport)
                End If
            'Case "التأمين الصحى"
            Case "الوردية"
                Dim columnsToExport As New List(Of String)
                If saveDialog.ShowDialog() = DialogResult.OK Then
                    ' قائمة بأسماء الأعمدة التي تريد تصديرها
                    ' اضف أسماء الأعمدة التي تريد تصديرها إلى القائمة
                    'columnsToExport.Add("مسلسل")
                    columnsToExport.Add("Emp_ID")
                    columnsToExport.Add("Emp_Full_Name")
                    columnsToExport.Add("Dept_Name")
                    columnsToExport.Add("Emp_Car")
                    columnsToExport.Add("CurrentWeekShift")
                    'columnsToExport.Add("NextWeekShift")
                    columnsToExport.Add("Shift_Type")
                    columnsToExport.Add("Shift_paper")
                    ' استدعاء الدالة ExportToExcel مع تمرير قائمة الأعمدة المرغوب تصديرها
                    ExportToExcel(dgv_Tbl_Employee, saveDialog.FileName, columnsToExport)
                End If
            Case "الربط الشهرى للتأمينات"
                Select_All_Employee_Reviewing_Monthly_Insurance(dgv_Tbl_Employee)
                '"Insurance_Status","Insurance_Salary","Percentage_Insurance_Payable","Due_Insurance_Amount","Number_Insurance",
                Dim columnsToExport As New List(Of String)
                If saveDialog.ShowDialog() = DialogResult.OK Then
                    ' قائمة بأسماء الأعمدة التي تريد تصديرها
                    ' اضف أسماء الأعمدة التي تريد تصديرها إلى القائمة
                    'columnsToExport.Add("مسلسل")
                    columnsToExport.Add("Emp_ID")
                    columnsToExport.Add("Emp_Full_Name")
                    columnsToExport.Add("Insurance_Status")
                    columnsToExport.Add("Number_Insurance")
                    columnsToExport.Add("Insurance_Salary")
                    columnsToExport.Add("Percentage_Insurance_Payable")
                    columnsToExport.Add("Due_Insurance_Amount")

                    ' استدعاء الدالة ExportToExcel مع تمرير قائمة الأعمدة المرغوب تصديرها
                    ExportToExcel(dgv_Tbl_Employee, saveDialog.FileName, columnsToExport)
                End If

            Case Nothing
                Dim columnsToExport As New List(Of String)
                If saveDialog.ShowDialog() = DialogResult.OK Then
                    ' قائمة بأسماء الأعمدة التي تريد تصديرها
                    ' اضف أسماء الأعمدة التي تريد تصديرها إلى القائمة
                    columnsToExport.Add("مسلسل")
                    columnsToExport.Add("Emp_ID")
                    columnsToExport.Add("Emp_Full_Name")
                    columnsToExport.Add("Emp_Date_Hiring")
                    columnsToExport.Add("Dept_Name")
                    columnsToExport.Add("Insurance_Status")
                    columnsToExport.Add("Jop_Code_insurance")
                    columnsToExport.Add("Jop_Name_insurance")
                    columnsToExport.Add("Number_Insurance")
                    columnsToExport.Add("Date_Insurance_Start")
                    columnsToExport.Add("Form_S1")
                    columnsToExport.Add("Confirmation_Insurance_Entry")
                    columnsToExport.Add("CurrentWeekShift")
                    columnsToExport.Add("NextWeekShift")
                    columnsToExport.Add("Shift_Type")
                    ' استدعاء الدالة ExportToExcel مع تمرير قائمة الأعمدة المرغوب تصديرها
                    ExportToExcel(dgv_Tbl_Employee, saveDialog.FileName, columnsToExport)
                End If
        End Select
    End Sub

    Private Sub Btn_Last_Record_Click(sender As Object, e As EventArgs) Handles Btn_Last_Record.Click
        If Me.Rad_Working_Active.Checked = True Then
            ds.Clear()
            Dim da As New SqlDataAdapter
            da = New SqlDataAdapter("Select_All_Employee", Con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.Fill(ds, "ds_Tbl_Employee")
            SelectAll_Tbl_EmployeeAsync(dgv_Tbl_Employee)
        ElseIf Me.Rad_Working_Resignation.Checked = True Then
            ds.Clear()
            Dim da As New SqlDataAdapter
            da = New SqlDataAdapter("Select_All_Employee_Resignation", Con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.Fill(ds, "ds_Tbl_Employee")
            SelectAll_Tbl_Employee_Resignation(dgv_Tbl_Employee)
        End If
        Dim i As Integer
        i = ds.Tables("ds_Tbl_Employee").Rows.Count - 1
        Emp_ID.Text = ds.Tables("ds_Tbl_Employee").Rows(i)(0).ToString()
        RetrieveEmployeeData(Emp_ID.Text)

    End Sub

    Private Sub Btn_First_Record_Click(sender As Object, e As EventArgs) Handles Btn_First_Record.Click
        If Me.Rad_Working_Active.Checked = True Then
            ds.Clear()
            Dim da As New SqlDataAdapter
            da = New SqlDataAdapter("Select_All_Employee", Con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.Fill(ds, "ds_Tbl_Employee")
            SelectAll_Tbl_EmployeeAsync(dgv_Tbl_Employee)
        ElseIf Me.Rad_Working_Resignation.Checked = True Then
            ds.Clear()
            Dim da As New SqlDataAdapter
            da = New SqlDataAdapter("Select_All_Employee_Resignation", Con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.Fill(ds, "ds_Tbl_Employee")
            SelectAll_Tbl_Employee_Resignation(dgv_Tbl_Employee)
        End If
        Dim i As Integer
        i = 0
        Emp_ID.Text = ds.Tables("ds_Tbl_Employee").Rows(i)(0).ToString()
        RetrieveEmployeeData(Emp_ID.Text)
    End Sub

    Private Sub Btn_Next_Record_Click(sender As Object, e As EventArgs) Handles Btn_Next_Record.Click
        If String.IsNullOrEmpty(Emp_ID.Text) Then
            ' إذا كانت قيمة "Emp_ID" فارغة، فجلب السجل الأول
            Emp_ID.Text = ds.Tables("ds_Tbl_Employee").Rows(0)(0).ToString()
        Else
            ' إذا كانت "Emp_ID" تحتوي على قيمة، قم بالبحث عن هذه القيمة في العمود الأول من "ds_Tbl_Employee"
            Dim rowIndex As Integer = -1
            For Each row As DataRow In ds.Tables("ds_Tbl_Employee").Rows
                If row(0).ToString() = Emp_ID.Text Then
                    ' إذا تم العثور على القيمة، احفظ موقع السطر
                    rowIndex = ds.Tables("ds_Tbl_Employee").Rows.IndexOf(row)
                    Exit For
                End If
            Next
            If rowIndex <> -1 AndAlso rowIndex < ds.Tables("ds_Tbl_Employee").Rows.Count - 1 Then
                ' إذا تم العثور على القيمة وليس السطر الأخير، جلب السطر التالي
                Emp_ID.Text = ds.Tables("ds_Tbl_Employee").Rows(rowIndex + 1)(0).ToString()
            End If
        End If
        RetrieveEmployeeData(Emp_ID.Text)
    End Sub

    Private Sub Btn_Previous_Record_Click(sender As Object, e As EventArgs) Handles Btn_Previous_Record.Click
        If String.IsNullOrEmpty(Emp_ID.Text) Then
            ' إذا كانت قيمة "Emp_ID" فارغة، فجلب السجل الأول
            'Emp_ID.Text = ds.Tables("ds_Tbl_Employee").Rows(0)(0).ToString()
            Emp_ID.Text = ds.Tables("ds_Tbl_Employee").Rows(ds.Tables("ds_Tbl_Employee").Rows.Count - 1)(0).ToString()

        Else
            ' إذا كانت "Emp_ID" تحتوي على قيمة، قم بالبحث عن هذه القيمة في العمود الأول من "ds_Tbl_Employee"
            Dim rowIndex As Integer = -1
            For Each row As DataRow In ds.Tables("ds_Tbl_Employee").Rows
                If row(0).ToString() = Emp_ID.Text Then
                    ' إذا تم العثور على القيمة، احفظ موقع السطر
                    rowIndex = ds.Tables("ds_Tbl_Employee").Rows.IndexOf(row)
                    Exit For
                End If
            Next

            If rowIndex > 0 Then
                ' إذا تم العثور على القيمة وليس السطر الأول، جلب السطر السابق
                Emp_ID.Text = ds.Tables("ds_Tbl_Employee").Rows(rowIndex - 1)(0).ToString()
            End If
        End If
        RetrieveEmployeeData(Emp_ID.Text)
    End Sub

    Private Sub Confirmation_Insurance_Entry_CheckedChanged(sender As Object, e As EventArgs) Handles Confirmation_Insurance_Entry.CheckedChanged
        If Me.Confirmation_Insurance_Entry.Checked = True Then
            Me.Confirmation_Insurance_Entry.Text = "تم التأكيد"
            Me.Confirmation_Insurance_Entry.BackColor = Color.Green
        Else
            Me.Confirmation_Insurance_Entry.Text = vbNullString
            Me.Confirmation_Insurance_Entry.BackColor = Color.Red
        End If
    End Sub

    Private Sub Form_S1_CheckedChanged(sender As Object, e As EventArgs) Handles Form_S1.CheckedChanged
        If Me.Form_S1.Checked = True Then
            Me.Form_S1.Text = "موجودة"
            Me.Form_S1.BackColor = Color.Green
        Else
            Me.Form_S1.Text = "غير موجودة"
            Me.Form_S1.BackColor = Color.Red
        End If
    End Sub

    Private Sub Form_S6_CheckedChanged(sender As Object, e As EventArgs) Handles Form_S6.CheckedChanged
        If Me.Form_S6.Checked = True Then
            Me.Form_S6.Text = "موجودة"
            Me.Form_S6.BackColor = Color.Green
        Else
            Me.Form_S6.Text = "غير موجودة"
            Me.Form_S6.BackColor = Color.Red
        End If
    End Sub

    Private Sub Medical_Exam_Form_Submission_CheckedChanged(sender As Object, e As EventArgs) Handles Medical_Exam_Form_Submission.CheckedChanged
        If Me.Medical_Exam_Form_Submission.Checked = True Then
            Me.Medical_Exam_Form_Submission.Text = "موجودة"
            Me.Medical_Exam_Form_Submission.BackColor = Color.Green
        Else
            Me.Medical_Exam_Form_Submission.Text = "غير موجودة"
            Me.Medical_Exam_Form_Submission.BackColor = Color.Red
        End If
    End Sub

    Private Sub Birth_Certificate_CheckedChanged(sender As Object, e As EventArgs) Handles Birth_Certificate.CheckedChanged
        If Me.Birth_Certificate.Checked = True Then
            Me.Birth_Certificate.Text = "موجودة"
            Me.Birth_Certificate.BackColor = Color.Green
        Else
            Me.Birth_Certificate.Text = "غير موجودة"
            Me.Birth_Certificate.BackColor = Color.Red
        End If
    End Sub

    Private Sub Insurance_Printout_CheckedChanged(sender As Object, e As EventArgs) Handles Insurance_Printout.CheckedChanged
        If Me.Insurance_Printout.Checked = True Then
            Me.Insurance_Printout.Text = "موجود"
            Me.Insurance_Printout.BackColor = Color.Green
        Else
            Me.Insurance_Printout.Text = "غير موجود"
            Me.Insurance_Printout.BackColor = Color.Red
        End If
    End Sub

    Private Sub ID_Card_Photo_CheckedChanged(sender As Object, e As EventArgs) Handles ID_Card_Photo.CheckedChanged
        If Me.ID_Card_Photo.Checked = True Then
            Me.ID_Card_Photo.Text = "موجودة"
            Me.ID_Card_Photo.BackColor = Color.Green
        Else
            Me.ID_Card_Photo.Text = "غير موجودة"
            Me.ID_Card_Photo.BackColor = Color.Red
        End If
    End Sub

    Private Sub Personal_Photos_CheckedChanged(sender As Object, e As EventArgs) Handles Personal_Photos.CheckedChanged
        If Me.Personal_Photos.Checked = True Then
            Me.Personal_Photos.Text = "موجودة"
            Me.Personal_Photos.BackColor = Color.Green
        Else
            Me.Personal_Photos.Text = "غير موجودة"
            Me.Personal_Photos.BackColor = Color.Red
        End If
    End Sub

    Private Sub Employment_Contract_CheckedChanged(sender As Object, e As EventArgs) Handles Employment_Contract.CheckedChanged
        If Me.Employment_Contract.Checked = True Then
            Me.Employment_Contract.Text = "موجود"
            Me.Employment_Contract.BackColor = Color.Green
        Else
            Me.Employment_Contract.Text = "غير موجود"
            Me.Employment_Contract.BackColor = Color.Red
        End If
    End Sub

    Private Sub Skill_level_measurement_certificate_CheckedChanged(sender As Object, e As EventArgs) Handles Skill_level_measurement_certificate.CheckedChanged
        If Me.Skill_level_measurement_certificate.Checked = True Then
            Me.Skill_level_measurement_certificate.Text = "موجودة"
            Me.Skill_level_measurement_certificate.BackColor = Color.Green
        Else
            Me.Skill_level_measurement_certificate.Text = "غير موجودة"
            Me.Skill_level_measurement_certificate.BackColor = Color.Red
        End If
    End Sub

    Private Sub Social_Status_Report_CheckedChanged(sender As Object, e As EventArgs) Handles Social_Status_Report.CheckedChanged
        If Me.Social_Status_Report.Checked = True Then
            Me.Social_Status_Report.Text = "موجودة"
            Me.Social_Status_Report.BackColor = Color.Green
        Else
            Me.Social_Status_Report.Text = "غير موجودة"
            Me.Social_Status_Report.BackColor = Color.Red
        End If
    End Sub

    Private Sub Work_Heel_CheckedChanged(sender As Object, e As EventArgs) Handles Work_Heel.CheckedChanged
        If Me.Work_Heel.Checked = True Then
            Me.Work_Heel.Text = "موجود"
            Me.Work_Heel.BackColor = Color.Green
        Else
            Me.Work_Heel.Text = "غير موجود"
            Me.Work_Heel.BackColor = Color.Red
        End If
    End Sub

    Private Sub Medical_Exam_Form_CheckedChanged(sender As Object, e As EventArgs) Handles Medical_Exam_Form.CheckedChanged
        If Me.Medical_Exam_Form.Checked = True Then
            Me.Medical_Exam_Form.Text = "موجود"
            Me.Medical_Exam_Form.BackColor = Color.Green
        Else
            Me.Medical_Exam_Form.Text = "غير موجود"
            Me.Medical_Exam_Form.BackColor = Color.Red
        End If
    End Sub

    Private Sub Criminal_Record_Check_CheckedChanged(sender As Object, e As EventArgs) Handles Criminal_Record_Check.CheckedChanged
        If Me.Criminal_Record_Check.Checked = True Then
            Me.Criminal_Record_Check.Text = "موجود"
            Me.Criminal_Record_Check.BackColor = Color.Green
        Else
            Me.Criminal_Record_Check.Text = "غير موجود"
            Me.Criminal_Record_Check.BackColor = Color.Red
        End If
    End Sub

    Private Sub dgv_Tbl_Employee_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Tbl_Employee.CellContentClick
        Dim CurrentRow As DataGridViewRow = dgv_Tbl_Employee.CurrentRow
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Try
            PopulateTextBox(Me.Emp_ID, "Emp_ID")
            RetrieveEmployeeData(Emp_ID.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            'Con.Close()
        End Try
        Con.Close()
    End Sub

    Private Sub dgv_Tbl_Employee_FilterStringChanged(sender As Object, e As EventArgs) Handles dgv_Tbl_Employee.FilterStringChanged
        BindingSource1.Filter = dgv_Tbl_Employee.FilterString
        dgv_Tbl_Employee.DataSource = BindingSource1
    End Sub

    Private Sub dgv_Tbl_Employee_SortStringChanged(sender As Object, e As EventArgs) Handles dgv_Tbl_Employee.SortStringChanged
        BindingSource1.Sort = dgv_Tbl_Employee.SortString
        dgv_Tbl_Employee.DataSource = BindingSource1
    End Sub

    Private Sub Dept_Code_DropDown(sender As Object, e As EventArgs) Handles Dept_Code.DropDown
        fillcmb_Tbl_Department(Dept_Code)
    End Sub

    Private Sub Jop_Code_DropDown(sender As Object, e As EventArgs) Handles Jop_Code.DropDown
        fillcmb_Tbl_Jop(Jop_Code)
    End Sub

    Private Sub Btn_ShiftChange_ForEmp_Click(sender As Object, e As EventArgs) Handles Btn_ShiftChange_ForEmp.Click
        Update_CurrentWeekShift(CurrentWeekShift.Text, Int(Emp_ID.Text))
        RetrieveEmployeeData(Emp_ID.Text)
    End Sub

    Private Sub CurrentWeekShift_TextChanged(sender As Object, e As EventArgs) Handles CurrentWeekShift.TextChanged
        Select Case Me.CurrentWeekShift.Text
            Case "الوردية الاولى"
                Me.CurrentWeekShift.BackColor = Color.Green

            Case "الوردية الثانية"
                Me.CurrentWeekShift.BackColor = Color.Red
            Case "الوردية الثالثة"
                Me.CurrentWeekShift.BackColor = Color.Black
                Me.CurrentWeekShift.ForeColor = Color.Red
            Case "الوردية الاولى 12 صباحى"
                Me.CurrentWeekShift.BackColor = Color.Green
            Case "الوردية الثانية 12 مسائى"
                Me.CurrentWeekShift.BackColor = Color.Red
            Case Nothing
                Me.CurrentWeekShift.BackColor = Color.White
                Me.CurrentWeekShift.ForeColor = Color.Black
        End Select
    End Sub

    Private Sub NextWeekShift_TextChanged(sender As Object, e As EventArgs) Handles NextWeekShift.TextChanged
        Select Case Me.NextWeekShift.Text
            Case "الوردية الاولى"
                Me.NextWeekShift.BackColor = Color.Green
            Case "الوردية الثانية"
                Me.NextWeekShift.BackColor = Color.Red
            Case "الوردية الثالثة"
                Me.NextWeekShift.BackColor = Color.Black
                Me.NextWeekShift.ForeColor = Color.White
            Case "الوردية الاولى 12 صباحى"
                Me.NextWeekShift.BackColor = Color.Green
            Case "الوردية الثانية 12 مسائى"
                Me.NextWeekShift.BackColor = Color.Red
            Case Nothing
                Me.NextWeekShift.BackColor = Color.White
                Me.NextWeekShift.ForeColor = Color.Black
        End Select
    End Sub

    Private Sub Btn_AddNewEmp_Click(sender As Object, e As EventArgs) Handles Btn_AddNewEmp.Click
        If Not CanAdd Then
            MessageBox.Show("ليس لديك صلاحية الإضافة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Frm_Add_Employee.Show()
    End Sub

    Private Sub Car_Pick_Up_Point_DropDown(sender As Object, e As EventArgs) Handles Car_Pick_Up_Point.DropDown
        'fillcmb_Tbl_Waiting_Point(Car_Pick_Up_Point)
        Try
            Dim dt As New DataTable
            Dim adapter As SqlDataAdapter

            ' تحقق من أن النص في الكمبوبوكس ليس فارغًا
            If Not String.IsNullOrEmpty(Emp_Car.Text) Then
                ' استخدم استعلام SQL يستخدم LIKE للبحث عن النص المدخل
                adapter = New SqlDataAdapter("SELECT * FROM Tbl_Waiting_Point WHERE Car_ID LIKE @CarID", Con)
                'adapter.SelectCommand.Parameters.AddWithValue("@CarID", "%" & Emp_Car.SelectedValue.ToString() & "%")
                adapter.SelectCommand.Parameters.AddWithValue("@CarID", Emp_Car.SelectedValue)
                adapter.Fill(dt)
                Car_Pick_Up_Point.DataSource = dt
                Car_Pick_Up_Point.DisplayMember = "Waiting_Point_Name"
                Car_Pick_Up_Point.ValueMember = "Waiting_Point_ID"
            End If
        Catch ex As Exception
            ' يمكنك تسجيل الخطأ هنا إذا لزم الأمر
            Exit Sub
        End Try
    End Sub

    Private Sub Percentage_Insurance_Payable_Leave(sender As Object, e As EventArgs) Handles Percentage_Insurance_Payable.Leave
        Dim inputValue As String = Percentage_Insurance_Payable.Text
        Dim percentageValue As Double
        If Double.TryParse(inputValue, percentageValue) Then
            Dim percentageText As String = (percentageValue / 100).ToString()
            Me.Percentage_Insurance_Payable.Text = percentageText
        Else
            ' يمكنك هنا التعامل مع حالة فشل التحويل
        End If

    End Sub

    Public Sub Update_Tbl_Employee(ByVal Date_Resignation As Date, ByVal Reason_Resignation As String, ByVal Emp_IDW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_Employee Set Date_Resignation = @Date_Resignation,Reason_Resignation = @Reason_Resignation Where Emp_ID = @Emp_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Date_Resignation", SqlDbType.Date).Value = Date_Resignation
            .Parameters.AddWithValue("@Reason_Resignation", SqlDbType.VarChar).Value = Reason_Resignation
            .Parameters.AddWithValue("@Emp_ID", SqlDbType.Int).Value = Emp_IDW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Private Sub Btn_Resignation_Click(sender As Object, e As EventArgs) Handles Btn_Resignation.Click
        Update_Tbl_Employee(Date_Resignation.Value, Reason_Resignation.Text, Emp_ID.Text)
        Dim MovementDescription As String = " تم تعديل بيانات الاستقالة " + Emp_Full_Name.Text + Date_Resignation.Text.ToString()
        Dim DeviceName As String = Environ$("computername")
        Insert_MovementHistory(MovementDescription, DateTime.Now, loggedInUserName, DeviceName, Me.Name, "Btn_Resignation")
    End Sub

    Private Sub Rad_Working_Active_CheckedChanged(sender As Object, e As EventArgs) Handles Rad_Working_Active.CheckedChanged
        If Me.Rad_Working_Active.Checked = True Then
            ds.Clear()
            Dim da As New SqlDataAdapter
            da = New SqlDataAdapter("Select_All_Employee", Con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.Fill(ds, "ds_Tbl_Employee")
            SelectAll_Tbl_EmployeeAsync(dgv_Tbl_Employee)
            Txt_Count.Text = dgv_Tbl_Employee.RowCount.ToString()
        End If
    End Sub

    Private Sub Rad_Working_Resignation_CheckedChanged(sender As Object, e As EventArgs) Handles Rad_Working_Resignation.CheckedChanged
        If Me.Rad_Working_Resignation.Checked = True Then
            ds.Clear()
            Dim da As New SqlDataAdapter
            da = New SqlDataAdapter("Select_All_Employee_Resignation", Con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.Fill(ds, "ds_Tbl_Employee")
            SelectAll_Tbl_Employee_Resignation(dgv_Tbl_Employee)
            Txt_Count.Text = dgv_Tbl_Employee.RowCount.ToString()
        End If
    End Sub

    Public Sub Update_Friday_Operation(ByVal Friday_Operation As String, ByVal Emp_IDW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_Employee Set Friday_Operation = @Friday_Operation Where Emp_ID = @Emp_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Friday_Operation", SqlDbType.VarChar).Value = Friday_Operation
            .Parameters.AddWithValue("@Emp_ID", SqlDbType.Int).Value = Emp_IDW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        Cmd = Nothing
    End Sub

    Private Sub Btn_Friday_Operation_Click(sender As Object, e As EventArgs) Handles Btn_Friday_Operation.Click
        Update_Friday_Operation(Friday_Operation.Text, Int(Emp_ID.Text))
        Emp_ID.Focus()
        Emp_ID.SelectAll()
    End Sub

    Private Function CalcDateDiff(ByVal Date1 As Date, ByVal Date2 As Date) As String
        ' تحقق إذا كان Date2 أقدم من Date1
        If Date2 < Date1 Then
            Dim tempDate As Date = Date1
            Date1 = Date2
            Date2 = tempDate
        End If

        ' حساب عدد السنين
        Dim years As Integer = DateDiff(DateInterval.Year, Date1, Date2)
        If DateAdd(DateInterval.Year, years, Date1) > Date2 Then
            years -= 1
        End If

        ' حساب عدد الشهور بعد حساب السنين
        Dim months As Integer = DateDiff(DateInterval.Month, DateAdd(DateInterval.Year, years, Date1), Date2)
        If DateAdd(DateInterval.Month, months, DateAdd(DateInterval.Year, years, Date1)) > Date2 Then
            months -= 1
        End If

        ' حساب عدد الأيام بعد حساب السنين والشهور
        Dim remainingDays As Integer = DateDiff(DateInterval.Day, DateAdd(DateInterval.Month, months, DateAdd(DateInterval.Year, years, Date1)), Date2)

        ' إرجاع النتيجة بتنسيق "سنين، شهور، أيام"
        Return String.Format("{0} سنة, {1} شهر, {2} يوم", years, months, remainingDays)
    End Function


    Private Sub ExecuteStoredProcedure(ByVal procedureName As String, ByVal connection As SqlConnection)
        Using command As New SqlCommand(procedureName, connection)
            command.CommandType = CommandType.StoredProcedure
            command.ExecuteNonQuery()
        End Using
    End Sub

    Private Sub Frm_Emp_Info_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                Btn_First_Record_Click(sender, New EventArgs())
            Case Keys.Down
                Btn_Last_Record_Click(sender, New EventArgs())
            Case Keys.Left
                Btn_Previous_Record_Click(sender, New EventArgs())
            Case Keys.Right
                Btn_Next_Record_Click(sender, New EventArgs())
            Case Keys.S
                If e.Control Then
                    BtnEdit_Click(sender, New EventArgs())
                End If
            Case Keys.N
                If e.Control Then
                    Frm_Add_Employee.Show()
                End If
            Case Keys.P
                If e.Control Then
                    Btn_ExportTo_Excel_Click(sender, New EventArgs())
                End If
            Case Keys.F
                If e.Control Then
                    Txt_Search.Focus()
                End If
        End Select
    End Sub

    Private Sub Btn_Add_File_Click_1(sender As Object, e As EventArgs) Handles Btn_Add_File.Click
        Pdf_View.Show()
        Pdf_View.bn.PerformClick()
        Pdf_View.t2.Text = Me.Emp_Full_Name.Text
        Pdf_View.t4.Text = Me.Emp_ID.Text
        Pdf_View.ts.Text = Me.Emp_ID.Text

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


    Private Sub Emp_Car_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Emp_Car.SelectedIndexChanged
        'fillcmb_Tbl_Waiting_Point(Car_Pick_Up_Point)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Frm_Add_Department.Show()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Frm_Add_Jop.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        Frm_Car.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Frm_Waiting_Point.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Btn_Friday_Operation.Click
        Update_Friday_Operation(Friday_Operation.Text, Emp_ID.Text)

    End Sub

End Class

