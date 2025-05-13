Imports System.Data.SqlClient
Imports El_Dawliya_International_System.El_Dawliya_International_System.Forms.Report

Public Class Frm_Quiry_Print
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Public dt_Tbl_Employee As New DataTable
    Dim ds As New DataSet

    Public Sub SelectAll_Tbl_Employee_Hiring(dgv As DataGridView)
        Dim da As New SqlDataAdapter
        dt_Tbl_Employee.Clear()
        da = New SqlDataAdapter("SELECT *,CASE 
        WHEN DATEPART(dw, Date_Insurance_Start) = 1 THEN 'الأحد'
        WHEN DATEPART(dw, Date_Insurance_Start) = 2 THEN 'الاثنين'
        WHEN DATEPART(dw, Date_Insurance_Start) = 3 THEN 'الثلاثاء'
        WHEN DATEPART(dw, Date_Insurance_Start) = 4 THEN 'الأربعاء'
        WHEN DATEPART(dw, Date_Insurance_Start) = 5 THEN 'الخميس'
        WHEN DATEPART(dw, Date_Insurance_Start) = 6 THEN 'الجمعة'
        WHEN DATEPART(dw, Date_Insurance_Start) = 7 THEN 'السبت'
            END AS DayOfWeek,
            DATEADD(day, -1, DATEADD(year, 1, Date_Insurance_Start)) AS Date_Insurance_End
            FROM Tbl_Employee where Working_Condition = 'سارى' ", Con)
        da.Fill(dt_Tbl_Employee)
        dgv.DataSource = dt_Tbl_Employee
        Try
            Con.Open()
            With dgv
                .Columns("Emp_ID").HeaderText = "الكود"
                .Columns("Emp_First_Name").HeaderText = "Emp_First_Name"
                .Columns("Emp_First_Name").Visible = False
                .Columns("Emp_Second_Name").HeaderText = "Emp_Second_Name"
                .Columns("Emp_Second_Name").Visible = False
                .Columns("Emp_Full_Name").HeaderText = "اسم الموظف"
                .Columns("Emp_Full_Name").Width = 250
                .Columns("Emp_Name_English").HeaderText = "Emp_Name_English"
                .Columns("Emp_Name_English").Visible = False
                .Columns("Emp_Phone1").HeaderText = "التليفون"
                '.Columns("Emp_Phone1").Visible = False
                .Columns("Emp_Phone2").HeaderText = "Emp_Phone2"
                .Columns("Emp_Phone2").Visible = False
                .Columns("Emp_Address").HeaderText = "العنوان"
                .Columns("Emp_Address").Width = 250
                '.Columns("Emp_Address").Visible = False
                .Columns("Emp_Marital_Status").HeaderText = "Emp_Marital_Status"
                .Columns("Emp_Marital_Status").Visible = False
                .Columns("Emp_Nationality").HeaderText = "الجنسية"
                '.Columns("Emp_Nationality").Visible = False
                .Columns("People_With_Special_Needs").HeaderText = "5 %"
                '.Columns("People_With_Special_Needs").Visible = False
                .Columns("National_ID").HeaderText = "الرقم القومى"
                '.Columns("National_ID").Visible = False
                .Columns("Date_Birth").HeaderText = "تاريخ الميلاد"
                '.Columns("Date_Birth").Visible = False
                .Columns("Place_Birth").HeaderText = "Place_Birth"
                .Columns("Place_Birth").Visible = False
                .Columns("Emp_Image").HeaderText = "Emp_Image"
                .Columns("Emp_Image").Visible = False
                .Columns("Emp_Type").HeaderText = "النوع"
                '.Columns("Emp_Type").Visible = False
                .Columns("Working_Condition").HeaderText = "حالة العمل"
                '.Columns("Working_Condition").Visible = False
                .Columns("Dept_Code").HeaderText = "Dept_Code"
                .Columns("Dept_Code").Visible = False
                .Columns("Dept_Name").HeaderText = "القسم"
                '.Columns("Dept_Name").Visible = False
                .Columns("Jop_Code").HeaderText = "Jop_Code"
                .Columns("Jop_Code").Visible = False
                .Columns("Jop_Name").HeaderText = "الوظيفة"
                '.Columns("Jop_Name").Visible = False
                .Columns("Emp_Date_Hiring").HeaderText = "تاريخ التعيين"
                '.Columns("Emp_Date_Hiring").Visible = False
                .Columns("Emp_Car").HeaderText = "السيارة"
                '.Columns("Emp_Car").Visible = False
                .Columns("Car_Ride_Time").HeaderText = "Car_Ride_Time"
                .Columns("Car_Ride_Time").Visible = False
                .Columns("Car_Pick_Up_Point").HeaderText = "Car_Pick_Up_Point"
                .Columns("Car_Pick_Up_Point").Visible = False
                .Columns("Insurance_Status").HeaderText = "Insurance_Status"
                .Columns("Insurance_Status").Visible = False
                .Columns("Jop_Code_insurance").HeaderText = "Jop_Code_insurance"
                .Columns("Jop_Code_insurance").Visible = False
                .Columns("Jop_Name_insurance").HeaderText = "Jop_Name_insurance"
                .Columns("Jop_Name_insurance").Visible = False
                .Columns("Health_Card").HeaderText = "Health_Card"
                .Columns("Health_Card").Visible = False
                .Columns("Health_Card_Number").HeaderText = "Health_Card_Number"
                .Columns("Health_Card_Number").Visible = False
                .Columns("Health_Card_Start_Date").HeaderText = "Health_Card_Start_Date"
                .Columns("Health_Card_Start_Date").Visible = False
                .Columns("Health_Card_Expiration_Date").HeaderText = "Health_Card_Expiration_Date"
                .Columns("Health_Card_Expiration_Date").Visible = False
                .Columns("Number_Insurance").HeaderText = "Number_Insurance"
                .Columns("Number_Insurance").Visible = False
                .Columns("Date_Insurance_Start").HeaderText = "Date_Insurance_Start"
                .Columns("Date_Insurance_Start").Visible = False
                .Columns("Insurance_Salary").HeaderText = "Insurance_Salary"
                .Columns("Insurance_Salary").Visible = False
                .Columns("Form_S1").HeaderText = "Form_S1"
                .Columns("Form_S1").Visible = False
                .Columns("Confirmation_Insurance_Entry").HeaderText = "Confirmation_Insurance_Entry"
                .Columns("Confirmation_Insurance_Entry").Visible = False
                .Columns("Delivery_Date_S1").HeaderText = "Delivery_Date_S1"
                .Columns("Delivery_Date_S1").Visible = False
                .Columns("Receive_Date_S1").HeaderText = "Receive_Date_S1"
                .Columns("Receive_Date_S1").Visible = False
                .Columns("Form_S6").HeaderText = "Form_S6"
                .Columns("Form_S6").Visible = False
                .Columns("Delivery_Date_S6").HeaderText = "Delivery_Date_S6"
                .Columns("Delivery_Date_S6").Visible = False
                .Columns("Receive_Date_S6").HeaderText = "Receive_Date_S6"
                .Columns("Receive_Date_S6").Visible = False
                .Columns("Hiring_Date_Health_Card").HeaderText = "Hiring_Date_Health_Card"
                .Columns("Hiring_Date_Health_Card").Visible = False
                .Columns("Skill_level_measurement_certificate").HeaderText = "Skill_level_measurement_certificate"
                .Columns("Skill_level_measurement_certificate").Visible = False
                .Columns("The_health_card_remains_expire").HeaderText = "The_health_card_remains_expire"
                .Columns("The_health_card_remains_expire").Visible = False
                .Columns("End_date_probationary_period").HeaderText = "End_date_probationary_period"
                .Columns("End_date_probationary_period").Visible = False
                .Columns("CurrentWeekShift").HeaderText = "CurrentWeekShift"
                .Columns("CurrentWeekShift").Visible = False
                .Columns("NextWeekShift").HeaderText = "NextWeekShift"
                .Columns("NextWeekShift").Visible = False
                .Columns("Friday_Operation").HeaderText = "Friday_Operation"
                .Columns("Friday_Operation").Visible = False
                .Columns("Shift_Type").HeaderText = "Shift_Type"
                .Columns("Shift_Type").Visible = False
                .Columns("Entrance_Date_S1").HeaderText = "Entrance_Date_S1"
                .Columns("Entrance_Date_S1").Visible = False
                .Columns("Entrance_Number_S1").HeaderText = "Entrance_Number_S1"
                .Columns("Entrance_Number_S1").Visible = False
                .Columns("Remaining_Contract_Renewal").HeaderText = "Remaining_Contract_Renewal"
                .Columns("Remaining_Contract_Renewal").Visible = False
                .Columns("Medical_Exam_Form_Submission").HeaderText = "Medical_Exam_Form_Submission"
                .Columns("Medical_Exam_Form_Submission").Visible = False
                .Columns("Years_Since_Contract_Start").HeaderText = "Years_Since_Contract_Start"
                .Columns("Years_Since_Contract_Start").Visible = False
                .Columns("Contract_Renewal_Date").HeaderText = "Contract_Renewal_Date"
                .Columns("Contract_Renewal_Date").Visible = False
                .Columns("Contract_Expiry_Date").HeaderText = "Contract_Expiry_Date"
                .Columns("Contract_Expiry_Date").Visible = False
                .Columns("Insurance_Code").HeaderText = "Insurance_Code"
                .Columns("Insurance_Code").Visible = False
                .Columns("Due_Insurance_Amount").HeaderText = "Due_Insurance_Amount"
                .Columns("Due_Insurance_Amount").Visible = False
                .Columns("Personal_ID_Expiry_Date").HeaderText = "Personal_ID_Expiry_Date"
                .Columns("Personal_ID_Expiry_Date").Visible = False
                .Columns("Contract_Renewal_Month").HeaderText = "Contract_Renewal_Month"
                .Columns("Contract_Renewal_Month").Visible = False
                .Columns("Military_Service_Certificate").HeaderText = "Military_Service_Certificate"
                .Columns("Military_Service_Certificate").Visible = False
                .Columns("Qualification_Certificate").HeaderText = "Qualification_Certificate"
                .Columns("Qualification_Certificate").Visible = False
                .Columns("Birth_Certificate").HeaderText = "Birth_Certificate"
                .Columns("Birth_Certificate").Visible = False
                .Columns("Insurance_Printout").HeaderText = "Insurance_Printout"
                .Columns("Insurance_Printout").Visible = False
                .Columns("ID_Card_Photo").HeaderText = "ID_Card_Photo"
                .Columns("ID_Card_Photo").Visible = False
                .Columns("Personal_Photos").HeaderText = "Personal_Photos"
                .Columns("Personal_Photos").Visible = False
                .Columns("Employment_Contract").HeaderText = "Employment_Contract"
                .Columns("Employment_Contract").Visible = False
                .Columns("Medical_Exam_Form").HeaderText = "Medical_Exam_Form"
                .Columns("Medical_Exam_Form").Visible = False
                .Columns("Criminal_Record_Check").HeaderText = "Criminal_Record_Check"
                .Columns("Criminal_Record_Check").Visible = False
                .Columns("Social_Status_Report").HeaderText = "Social_Status_Report"
                .Columns("Social_Status_Report").Visible = False
                .Columns("Work_Heel").HeaderText = "Work_Heel"
                .Columns("Work_Heel").Visible = False
                .Columns("Heel_Work_Number").HeaderText = "Heel_Work_Number"
                .Columns("Heel_Work_Number").Visible = False
                .Columns("Heel_Work_Registration_Date").HeaderText = "Heel_Work_Registration_Date"
                .Columns("Heel_Work_Registration_Date").Visible = False
                .Columns("Heel_Work_Recipient").HeaderText = "Heel_Work_Recipient"
                .Columns("Heel_Work_Recipient").Visible = False
                .Columns("Heel_Work_Recipient_Address").HeaderText = "Heel_Work_Recipient_Address"
                .Columns("Heel_Work_Recipient_Address").Visible = False
                .Columns("Entrance_Number_S6").HeaderText = "Entrance_Number_S6"
                .Columns("Entrance_Number_S6").Visible = False
                .Columns("Entrance_Date_S6").HeaderText = "Entrance_Date_S6"
                .Columns("Entrance_Date_S6").Visible = False
                .Columns("Shift_paper").HeaderText = "ورق الورادى"
                '.Columns("Shift_paper").Visible = False
                .Columns("Age").HeaderText = "العمر"
                .Columns("Date_Resignation").HeaderText = "تاريخ الاستقالة"
                .Columns("Date_Resignation").Visible = False
                .Columns("Reason_Resignation").HeaderText = "سبب الاستقالة"
                .Columns("Reason_Resignation").Visible = False
                .Columns("DayOfWeek").HeaderText = "اليوم"
                .Columns("DayOfWeek").Visible = False
                .Columns("Date_Insurance_End").HeaderText = "تاريخ انتهاء العقد"
                .Columns("Date_Insurance_End").Visible = False
                .Columns("Percentage_Insurance_Payable").HeaderText = "نسبة التأمينات"
                .Columns("Mother_Name").HeaderText = "اسم الأم"
                .Columns("Mother_Name").Visible = False

                '.Columns("Age").Visible = False
            End With
            'End If
        Catch ex As Exception

        End Try
    End Sub


    Public Sub SelectAll_Tbl_Employee_Resignations(dgv As DataGridView)
        Dim da As New SqlDataAdapter
        dt_Tbl_Employee.Clear()
        da = New SqlDataAdapter("SELECT *,CASE 
        WHEN DATEPART(dw, Date_Insurance_Start) = 1 THEN 'الأحد'
        WHEN DATEPART(dw, Date_Insurance_Start) = 2 THEN 'الاثنين'
        WHEN DATEPART(dw, Date_Insurance_Start) = 3 THEN 'الثلاثاء'
        WHEN DATEPART(dw, Date_Insurance_Start) = 4 THEN 'الأربعاء'
        WHEN DATEPART(dw, Date_Insurance_Start) = 5 THEN 'الخميس'
        WHEN DATEPART(dw, Date_Insurance_Start) = 6 THEN 'الجمعة'
        WHEN DATEPART(dw, Date_Insurance_Start) = 7 THEN 'السبت'
            END AS DayOfWeek,
            DATEADD(day, -1, DATEADD(year, 1, Date_Insurance_Start)) AS Date_Insurance_End
            FROM Tbl_Employee where Working_Condition = 'استقالة' or Working_Condition = 'انقطاع عن العمل' ", Con)
        da.Fill(dt_Tbl_Employee)
        dgv.DataSource = dt_Tbl_Employee
        Try
            Con.Open()
            With dgv
                .Columns("Emp_ID").HeaderText = "الكود"
                .Columns("Emp_First_Name").HeaderText = "Emp_First_Name"
                .Columns("Emp_First_Name").Visible = False
                .Columns("Emp_Second_Name").HeaderText = "Emp_Second_Name"
                .Columns("Emp_Second_Name").Visible = False
                .Columns("Emp_Full_Name").HeaderText = "اسم الموظف"
                .Columns("Emp_Full_Name").Width = 250
                .Columns("Emp_Name_English").HeaderText = "Emp_Name_English"
                .Columns("Emp_Name_English").Visible = False
                .Columns("Emp_Phone1").HeaderText = "التليفون"
                '.Columns("Emp_Phone1").Visible = False
                .Columns("Emp_Phone2").HeaderText = "Emp_Phone2"
                .Columns("Emp_Phone2").Visible = False
                .Columns("Emp_Address").HeaderText = "العنوان"
                .Columns("Emp_Address").Width = 250
                '.Columns("Emp_Address").Visible = False
                .Columns("Emp_Marital_Status").HeaderText = "Emp_Marital_Status"
                .Columns("Emp_Marital_Status").Visible = False
                .Columns("Emp_Nationality").HeaderText = "الجنسية"
                '.Columns("Emp_Nationality").Visible = False
                .Columns("People_With_Special_Needs").HeaderText = "5 %"
                '.Columns("People_With_Special_Needs").Visible = False
                .Columns("National_ID").HeaderText = "الرقم القومى"
                '.Columns("National_ID").Visible = False
                .Columns("Date_Birth").HeaderText = "تاريخ الميلاد"
                '.Columns("Date_Birth").Visible = False
                .Columns("Place_Birth").HeaderText = "Place_Birth"
                .Columns("Place_Birth").Visible = False
                .Columns("Emp_Image").HeaderText = "Emp_Image"
                .Columns("Emp_Image").Visible = False
                .Columns("Emp_Type").HeaderText = "النوع"
                '.Columns("Emp_Type").Visible = False
                .Columns("Working_Condition").HeaderText = "حالة العمل"
                '.Columns("Working_Condition").Visible = False
                .Columns("Dept_Code").HeaderText = "Dept_Code"
                .Columns("Dept_Code").Visible = False
                .Columns("Dept_Name").HeaderText = "القسم"
                '.Columns("Dept_Name").Visible = False
                .Columns("Jop_Code").HeaderText = "Jop_Code"
                .Columns("Jop_Code").Visible = False
                .Columns("Jop_Name").HeaderText = "الوظيفة"
                '.Columns("Jop_Name").Visible = False
                .Columns("Emp_Date_Hiring").HeaderText = "تاريخ التعيين"
                '.Columns("Emp_Date_Hiring").Visible = False
                .Columns("Emp_Car").HeaderText = "السيارة"
                '.Columns("Emp_Car").Visible = False
                .Columns("Car_Ride_Time").HeaderText = "Car_Ride_Time"
                .Columns("Car_Ride_Time").Visible = False
                .Columns("Car_Pick_Up_Point").HeaderText = "Car_Pick_Up_Point"
                .Columns("Car_Pick_Up_Point").Visible = False
                .Columns("Insurance_Status").HeaderText = "Insurance_Status"
                .Columns("Insurance_Status").Visible = False
                .Columns("Jop_Code_insurance").HeaderText = "Jop_Code_insurance"
                .Columns("Jop_Code_insurance").Visible = False
                .Columns("Jop_Name_insurance").HeaderText = "Jop_Name_insurance"
                .Columns("Jop_Name_insurance").Visible = False
                .Columns("Health_Card").HeaderText = "Health_Card"
                .Columns("Health_Card").Visible = False
                .Columns("Health_Card_Number").HeaderText = "Health_Card_Number"
                .Columns("Health_Card_Number").Visible = False
                .Columns("Health_Card_Start_Date").HeaderText = "Health_Card_Start_Date"
                .Columns("Health_Card_Start_Date").Visible = False
                .Columns("Health_Card_Expiration_Date").HeaderText = "Health_Card_Expiration_Date"
                .Columns("Health_Card_Expiration_Date").Visible = False
                .Columns("Number_Insurance").HeaderText = "Number_Insurance"
                .Columns("Number_Insurance").Visible = False
                .Columns("Date_Insurance_Start").HeaderText = "Date_Insurance_Start"
                .Columns("Date_Insurance_Start").Visible = False
                .Columns("Insurance_Salary").HeaderText = "Insurance_Salary"
                .Columns("Insurance_Salary").Visible = False
                .Columns("Form_S1").HeaderText = "Form_S1"
                .Columns("Form_S1").Visible = False
                .Columns("Confirmation_Insurance_Entry").HeaderText = "Confirmation_Insurance_Entry"
                .Columns("Confirmation_Insurance_Entry").Visible = False
                .Columns("Delivery_Date_S1").HeaderText = "Delivery_Date_S1"
                .Columns("Delivery_Date_S1").Visible = False
                .Columns("Receive_Date_S1").HeaderText = "Receive_Date_S1"
                .Columns("Receive_Date_S1").Visible = False
                .Columns("Form_S6").HeaderText = "Form_S6"
                .Columns("Form_S6").Visible = False
                .Columns("Delivery_Date_S6").HeaderText = "Delivery_Date_S6"
                .Columns("Delivery_Date_S6").Visible = False
                .Columns("Receive_Date_S6").HeaderText = "Receive_Date_S6"
                .Columns("Receive_Date_S6").Visible = False
                .Columns("Hiring_Date_Health_Card").HeaderText = "Hiring_Date_Health_Card"
                .Columns("Hiring_Date_Health_Card").Visible = False
                .Columns("Skill_level_measurement_certificate").HeaderText = "Skill_level_measurement_certificate"
                .Columns("Skill_level_measurement_certificate").Visible = False
                .Columns("The_health_card_remains_expire").HeaderText = "The_health_card_remains_expire"
                .Columns("The_health_card_remains_expire").Visible = False
                .Columns("End_date_probationary_period").HeaderText = "End_date_probationary_period"
                .Columns("End_date_probationary_period").Visible = False
                .Columns("CurrentWeekShift").HeaderText = "CurrentWeekShift"
                .Columns("CurrentWeekShift").Visible = False
                .Columns("NextWeekShift").HeaderText = "NextWeekShift"
                .Columns("NextWeekShift").Visible = False
                .Columns("Friday_Operation").HeaderText = "Friday_Operation"
                .Columns("Friday_Operation").Visible = False
                .Columns("Shift_Type").HeaderText = "Shift_Type"
                .Columns("Shift_Type").Visible = False
                .Columns("Entrance_Date_S1").HeaderText = "Entrance_Date_S1"
                .Columns("Entrance_Date_S1").Visible = False
                .Columns("Entrance_Number_S1").HeaderText = "Entrance_Number_S1"
                .Columns("Entrance_Number_S1").Visible = False
                .Columns("Remaining_Contract_Renewal").HeaderText = "Remaining_Contract_Renewal"
                .Columns("Remaining_Contract_Renewal").Visible = False
                .Columns("Medical_Exam_Form_Submission").HeaderText = "Medical_Exam_Form_Submission"
                .Columns("Medical_Exam_Form_Submission").Visible = False
                .Columns("Years_Since_Contract_Start").HeaderText = "Years_Since_Contract_Start"
                .Columns("Years_Since_Contract_Start").Visible = False
                .Columns("Contract_Renewal_Date").HeaderText = "Contract_Renewal_Date"
                .Columns("Contract_Renewal_Date").Visible = False
                .Columns("Contract_Expiry_Date").HeaderText = "Contract_Expiry_Date"
                .Columns("Contract_Expiry_Date").Visible = False
                .Columns("Insurance_Code").HeaderText = "Insurance_Code"
                .Columns("Insurance_Code").Visible = False
                .Columns("Due_Insurance_Amount").HeaderText = "Due_Insurance_Amount"
                .Columns("Due_Insurance_Amount").Visible = False
                .Columns("Personal_ID_Expiry_Date").HeaderText = "Personal_ID_Expiry_Date"
                .Columns("Personal_ID_Expiry_Date").Visible = False
                .Columns("Contract_Renewal_Month").HeaderText = "Contract_Renewal_Month"
                .Columns("Contract_Renewal_Month").Visible = False
                .Columns("Military_Service_Certificate").HeaderText = "Military_Service_Certificate"
                .Columns("Military_Service_Certificate").Visible = False
                .Columns("Qualification_Certificate").HeaderText = "Qualification_Certificate"
                .Columns("Qualification_Certificate").Visible = False
                .Columns("Birth_Certificate").HeaderText = "Birth_Certificate"
                .Columns("Birth_Certificate").Visible = False
                .Columns("Insurance_Printout").HeaderText = "Insurance_Printout"
                .Columns("Insurance_Printout").Visible = False
                .Columns("ID_Card_Photo").HeaderText = "ID_Card_Photo"
                .Columns("ID_Card_Photo").Visible = False
                .Columns("Personal_Photos").HeaderText = "Personal_Photos"
                .Columns("Personal_Photos").Visible = False
                .Columns("Employment_Contract").HeaderText = "Employment_Contract"
                .Columns("Employment_Contract").Visible = False
                .Columns("Medical_Exam_Form").HeaderText = "Medical_Exam_Form"
                .Columns("Medical_Exam_Form").Visible = False
                .Columns("Criminal_Record_Check").HeaderText = "Criminal_Record_Check"
                .Columns("Criminal_Record_Check").Visible = False
                .Columns("Social_Status_Report").HeaderText = "Social_Status_Report"
                .Columns("Social_Status_Report").Visible = False
                .Columns("Work_Heel").HeaderText = "Work_Heel"
                .Columns("Work_Heel").Visible = False
                .Columns("Heel_Work_Number").HeaderText = "Heel_Work_Number"
                .Columns("Heel_Work_Number").Visible = False
                .Columns("Heel_Work_Registration_Date").HeaderText = "Heel_Work_Registration_Date"
                .Columns("Heel_Work_Registration_Date").Visible = False
                .Columns("Heel_Work_Recipient").HeaderText = "Heel_Work_Recipient"
                .Columns("Heel_Work_Recipient").Visible = False
                .Columns("Heel_Work_Recipient_Address").HeaderText = "Heel_Work_Recipient_Address"
                .Columns("Heel_Work_Recipient_Address").Visible = False
                .Columns("Entrance_Number_S6").HeaderText = "Entrance_Number_S6"
                .Columns("Entrance_Number_S6").Visible = False
                .Columns("Entrance_Date_S6").HeaderText = "Entrance_Date_S6"
                .Columns("Entrance_Date_S6").Visible = False
                .Columns("Shift_paper").HeaderText = "ورق الورادى"
                '.Columns("Shift_paper").Visible = False
                .Columns("Age").HeaderText = "العمر"
                .Columns("Date_Resignation").HeaderText = "تاريخ الاستقالة"
                .Columns("Date_Resignation").Visible = False
                .Columns("Reason_Resignation").HeaderText = "سبب الاستقالة"
                .Columns("Reason_Resignation").Visible = False
                .Columns("DayOfWeek").HeaderText = "اليوم"
                .Columns("DayOfWeek").Visible = False
                .Columns("Date_Insurance_End").HeaderText = "تاريخ انتهاء العقد"
                .Columns("Date_Insurance_End").Visible = False
                .Columns("Percentage_Insurance_Payable").HeaderText = "نسبة التأمينات"
                .Columns("Mother_Name").HeaderText = "اسم الأم"
                .Columns("Mother_Name").Visible = False

                '.Columns("Age").Visible = False
            End With
            'End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub Frm_Quiry_Print_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomizeForm(Me)
        Me.KeyPreview = True
        SelectAll_Tbl_Employee_Hiring(dgv_Tbl_Employee)
        BindingSource1.DataSource = dt_Tbl_Employee.DefaultView
        Check_Hiring.Checked = False
        Check_Resignations.Checked = False
        Lbl_Count.Text = dgv_Tbl_Employee.Rows.Count.ToString()
    End Sub

    Private Sub dgv_Tbl_Employee_FilterStringChanged(sender As Object, e As EventArgs)
        BindingSource1.Filter = dgv_Tbl_Employee.FilterString
        dgv_Tbl_Employee.DataSource = BindingSource1
        Lbl_Count.Text = dgv_Tbl_Employee.Rows.Count.ToString()
    End Sub

    Private Sub dgv_Tbl_Employee_SortStringChanged(sender As Object, e As EventArgs)
        BindingSource1.Sort = dgv_Tbl_Employee.SortString
        dgv_Tbl_Employee.DataSource = BindingSource1
        Lbl_Count.Text = dgv_Tbl_Employee.Rows.Count.ToString()
    End Sub

    Private Sub Btn_Print_Click(sender As Object, e As EventArgs) Handles Btn_Print.Click
        If Cmb_Report.Text = "ورق الورادى" Then
            dt_Tbl_Employee.Clear()
            Dim da As New SqlDataAdapter
            da = New SqlDataAdapter("Select * From Tbl_Employee Where Shift_paper = 'نعم' and Working_Condition = 'سارى' ", Con)
            da.Fill(dt_Tbl_Employee)
            Dim rep As New Rep_Print_Shift_Report
            rep.SetDataSource(dt_Tbl_Employee.DefaultView)
            rep.Section2.SectionFormat.BackgroundColor = Color.FromArgb(0, 167, 131)
            Frm_Report.CrystalReportViewer1.ReportSource = rep
            Frm_Report.CrystalReportViewer1.Refresh()
            Frm_Report.ShowDialog()
        ElseIf Cmb_Report.Text = "عقد العمل" Then
            Dim rep As New Rep_Contract_Main
            rep.SetDataSource(dt_Tbl_Employee.DefaultView)
            Frm_Report.CrystalReportViewer1.ReportSource = rep
            Frm_Report.CrystalReportViewer1.Refresh()
            Frm_Report.ShowDialog()
        ElseIf Cmb_Report.Text = "س1" Then
            Dim da As New SqlDataAdapter
            da = New SqlDataAdapter("Select * From S1", Con)
            dt_Tbl_Employee.Clear()
            da.Fill(dt_Tbl_Employee)
            Dim rep As New FormS1
            rep.SetDataSource(dt_Tbl_Employee.DefaultView)
            Frm_Report.CrystalReportViewer1.ReportSource = rep
            Frm_Report.CrystalReportViewer1.Refresh()
            Frm_Report.ShowDialog()
        ElseIf Cmb_Report.Text = "س6" Then
            Dim da As New SqlDataAdapter
            da = New SqlDataAdapter("Select * From S6", Con)
            dt_Tbl_Employee.Clear()
            da.Fill(dt_Tbl_Employee)
            Dim rep As New FormS6
            rep.SetDataSource(dt_Tbl_Employee.DefaultView)
            Frm_Report.CrystalReportViewer1.ReportSource = rep
            Frm_Report.CrystalReportViewer1.Refresh()
            Frm_Report.ShowDialog()
        ElseIf Cmb_Report.Text = "بطاقة تعريف موظف" Then
            Dim rep As New Employee_Card
            rep.SetDataSource(dt_Tbl_Employee.DefaultView)
            Frm_Report.CrystalReportViewer1.ReportSource = rep
            Frm_Report.CrystalReportViewer1.Refresh()
            Frm_Report.ShowDialog()
        ElseIf Cmb_Report.Text = "صحيفة الحالة الاجتماعية" Then
            Dim rep As New Social_Status
            rep.SetDataSource(dt_Tbl_Employee.DefaultView)
            Frm_Report.CrystalReportViewer1.ReportSource = rep
            Frm_Report.CrystalReportViewer1.Refresh()
            Frm_Report.ShowDialog()
        ElseIf Cmb_Report.Text = "صحيفة الاجازات المرضية" Then
            Dim rep As New Sick_Newspaper
            rep.SetDataSource(dt_Tbl_Employee.DefaultView)
            Frm_Report.CrystalReportViewer1.ReportSource = rep
            Frm_Report.CrystalReportViewer1.Refresh()
            Frm_Report.ShowDialog()
        ElseIf Cmb_Report.Text = "صحيفة الجزءات" Then
            Dim rep As New Penalties_Newspaper
            rep.SetDataSource(dt_Tbl_Employee.DefaultView)
            Frm_Report.CrystalReportViewer1.ReportSource = rep
            Frm_Report.CrystalReportViewer1.Refresh()
            Frm_Report.ShowDialog()
        ElseIf Cmb_Report.Text = "صحيفة تدرج الاجر" Then
            Dim rep As New Salary_Newspaper
            rep.SetDataSource(dt_Tbl_Employee.DefaultView)
            Frm_Report.CrystalReportViewer1.ReportSource = rep
            Frm_Report.CrystalReportViewer1.Refresh()
            Frm_Report.ShowDialog()
        End If
    End Sub

    Private Sub Txt_Search1_TextChanged(sender As Object, e As EventArgs) Handles Txt_Search1.TextChanged
        If Check_Hiring.Checked = True Then
            SelectAll_Tbl_Employee_Hiring(dgv_Tbl_Employee)
        ElseIf Check_Resignations.Checked = True Then
            SelectAll_Tbl_Employee_Resignations(dgv_Tbl_Employee)
        Else
            SelectAll_Tbl_Employee_Hiring(dgv_Tbl_Employee)
        End If
        Try
            Dim dv As DataView = dt_Tbl_Employee.DefaultView
            Select Case ComboSearch1.Text
                Case "كود الموظف"
                    'dv.RowFilter = " Emp_ID LIKE '%" & Txt_Search1.Text & "%' "
                    dv.RowFilter = "Emp_ID = " & Txt_Search1.Text
                Case "اسم الموظف"
                    dv.RowFilter = " Emp_Full_Name LIKE '%" & Txt_Search1.Text & "%' "
                Case "رقم التليفون"
                    dv.RowFilter = " Emp_Phone1 LIKE '%" & Txt_Search1.Text & "%' "
                Case "رقم البطاقة الشخصية"
                    dv.RowFilter = " National_ID LIKE '%" & Txt_Search1.Text & "%' "
                Case "الجنسية"
                    dv.RowFilter = " Emp_Nationality LIKE '%" & Txt_Search1.Text & "%' "
                Case "تاريخ التعيين"
                    dv.RowFilter = " Emp_Date_Hiring LIKE '%" & Txt_Search1.Text & "%' "
                Case "القسم"
                    dv.RowFilter = " Dept_Name LIKE '%" & Txt_Search1.Text & "%' "
                Case "الوظيفة"
                    dv.RowFilter = " Jop_Name LIKE '%" & Txt_Search1.Text & "%' "
                Case "الوظيفة"
                    dv.RowFilter = " Jop_Name LIKE '%" & Txt_Search1.Text & "%' "
                Case "النوع"
                    dv.RowFilter = " Emp_Type LIKE '%" & Txt_Search1.Text & "%' "
                Case "الحالة التأمينة"
                    dv.RowFilter = " Insurance_Status LIKE '%" & Txt_Search1.Text & "%' "
                Case "البطاقة الصحية"
                    dv.RowFilter = " Health_Card LIKE '%" & Txt_Search1.Text & "%' "
                Case "ذوى الاحتياجات الخاصة"
                    dv.RowFilter = " People_With_Special_Needs LIKE '%" & Txt_Search1.Text & "%' "
                Case "حالة الموظف"
                    dv.RowFilter = " Working_Condition LIKE '%" & Txt_Search1.Text & "%' "
                Case "السيارة"
                    dv.RowFilter = " Emp_Car LIKE '%" & Txt_Search1.Text & "%' "
                Case "نقطة تجمع السيارة"
                    dv.RowFilter = " Car_Pick_Up_Point LIKE '%" & Txt_Search1.Text & "%' "
                Case "الوردية للاسبوع الحالى"
                    dv.RowFilter = " CurrentWeekShift LIKE '%" & Txt_Search1.Text & "%' "
                Case "الوردية للاسبوع القادم"
                    dv.RowFilter = " NextWeekShift LIKE '%" & Txt_Search1.Text & "%' "
            End Select
        Catch ex As Exception
        End Try
        Lbl_Count.Text = dgv_Tbl_Employee.Rows.Count.ToString()
    End Sub

    Private Sub Check_Resignations_CheckedChanged(sender As Object, e As EventArgs) Handles Check_Resignations.CheckedChanged
        If Check_Resignations.Checked = True Then
            Check_Hiring.Checked = False
            Cmb_Report.Items.Clear()
            Cmb_Report.Items.Add("س6")
            SelectAll_Tbl_Employee_Resignations(dgv_Tbl_Employee)
            Lbl_Count.Text = dgv_Tbl_Employee.Rows.Count.ToString()
        End If
    End Sub

    Private Sub Check_Hiring_CheckedChanged(sender As Object, e As EventArgs) Handles Check_Hiring.CheckedChanged
        If Check_Hiring.Checked = True Then
            Check_Resignations.Checked = False
            Cmb_Report.Items.Clear()
            Cmb_Report.Items.Add("ورق الورادى")
            Cmb_Report.Items.Add("عقد العمل")
            Cmb_Report.Items.Add("س1")
            Cmb_Report.Items.Add("بطاقة تعريف موظف")
            Cmb_Report.Items.Add("صحيفة الحالة الاجتماعية")
            Cmb_Report.Items.Add("صحيفة الاجازات")
            Cmb_Report.Items.Add("صحيفة الاجازات المرضية")
            Cmb_Report.Items.Add("صحيفة الجزءات")
            Cmb_Report.Items.Add("صحيفة تدرج الاجر")
            SelectAll_Tbl_Employee_Hiring(dgv_Tbl_Employee)
            Lbl_Count.Text = dgv_Tbl_Employee.Rows.Count.ToString()
        End If
    End Sub

    Private Sub Txt_Search1_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles Txt_Search1.Enter
        ' هذا الحدث لتغيير لغة الكتابة الى العربية فى اى تيكست بوكس اريده
        ArabicToolStrip(DirectCast(sender, ToolStripTextBox))
    End Sub

    Private Sub Frm_Quiry_Print_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.F
                If e.Control Then
                    Txt_Search1.Focus()
                End If
        End Select
    End Sub


End Class