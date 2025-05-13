Imports System.Data.SqlClient

Public Class Notifications_Screen
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Public dt_Notifications As New DataTable
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
            Case "Health_Card" : Return "بطاقة الصحية"
            Case "Health_Card_Number" : Return "رقم بطاقة الصحية"
            Case "Health_Card_Start_Date" : Return "تاريخ بدء بطاقة الصحية"
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
            Case Else : Return columnName
        End Select
    End Function

    Public Sub Select_Personal_ID_Expiry_Date(dgv As DataGridView)
        Dim da As New SqlDataAdapter
        dt_Notifications.Clear()
        da = New SqlDataAdapter("Select_Personal_ID_Expiry_Date", Con)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        Dim daysParam As New SqlParameter("@Days", SqlDbType.Int)
        daysParam.Value = Convert.ToInt32(Txt_Days.Text)
        da.SelectCommand.Parameters.Add(daysParam)
        da.Fill(dt_Notifications)
        dgv.DataSource = dt_Notifications
        Try
            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If

            For Each column As DataGridViewColumn In dgv.Columns
                column.HeaderText = GetColumnHeaderName(column.Name)
            Next
            dgv.Columns("Emp_Full_Name").AutoSizeMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MessageBox.Show("خطأ: " & ex.Message)
        End Try
        Con.Close()
    End Sub

    Public Sub Select_Health_Card_Expiration_Date(dgv As DataGridView)
        Dim da As New SqlDataAdapter
        dt_Notifications.Clear()
        da = New SqlDataAdapter("Select_Health_Card_Expiration_Date", Con)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        Dim daysParam As New SqlParameter("@Days", SqlDbType.Int)
        daysParam.Value = Convert.ToInt32(Txt_Days.Text)
        da.SelectCommand.Parameters.Add(daysParam)
        da.Fill(dt_Notifications)
        dgv.DataSource = dt_Notifications
        Try
            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If

            For Each column As DataGridViewColumn In dgv.Columns
                column.HeaderText = GetColumnHeaderName(column.Name)
            Next
            dgv.Columns("Emp_Full_Name").AutoSizeMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch ex As Exception
            MessageBox.Show("خطأ: " & ex.Message)
        End Try
        Con.Close()
    End Sub
    Private Sub Btn_Export_Excel_Click(sender As Object, e As EventArgs) Handles Btn_Export_Excel.Click
        Dim saveDialog As New SaveFileDialog()
        saveDialog.Filter = "Excel Files|*.xlsx;*.xls"
        saveDialog.Title = "E:\El Dawliya International System\Excel"

        Select Case Me.Combo_Notifications.Text
            Case "انتهاء الشهادة الصحية"
                Dim columnsToExport As New List(Of String)
                If saveDialog.ShowDialog() = DialogResult.OK Then
                    ' قائمة بأسماء الأعمدة التي تريد تصديرها
                    ' اضف أسماء الأعمدة التي تريد تصديرها إلى القائمة
                    columnsToExport.Add("Emp_ID")
                    columnsToExport.Add("Emp_Full_Name")
                    columnsToExport.Add("Health_Card")
                    columnsToExport.Add("Health_Card_Start_Date")
                    columnsToExport.Add("Health_Card_Number")
                    columnsToExport.Add("Health_Card_Renewal_Date")
                    columnsToExport.Add("Health_Card_Expiration_Date")
                    ' استدعاء الدالة ExportToExcel مع تمرير قائمة الأعمدة المرغوب تصديرها
                    ExportToExcel(dgv_Notifications, saveDialog.FileName, columnsToExport)
                End If
            Case "انتهاء بطاقة الرقم القومى"
                Dim columnsToExport As New List(Of String)
                If saveDialog.ShowDialog() = DialogResult.OK Then
                    ' قائمة بأسماء الأعمدة التي تريد تصديرها
                    ' اضف أسماء الأعمدة التي تريد تصديرها إلى القائمة
                    columnsToExport.Add("Emp_ID")
                    columnsToExport.Add("Emp_Full_Name")
                    columnsToExport.Add("Personal_ID_Expiry_Date")
                    columnsToExport.Add("Emp_Nationality")
                    ' استدعاء الدالة ExportToExcel مع تمرير قائمة الأعمدة المرغوب تصديرها
                    ExportToExcel(dgv_Notifications, saveDialog.FileName, columnsToExport)
                End If
        End Select
    End Sub

    Private Sub Notifications_Screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindingSource1.DataSource = dt_Notifications.DefaultView
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Select Case Combo_Notifications.Text
            Case "انتهاء الشهادة الصحية"
                Lbl_Notifications_Name.Text = "انتهاء الشهادة الصحية"
                dt_Notifications.Clear()
                dt_Notifications.Columns.Clear()
                Select_Health_Card_Expiration_Date(dgv_Notifications)
                Lbl_Count.Text = dgv_Notifications.RowCount.ToString()
            Case "انتهاء بطاقة الرقم القومى"
                Lbl_Notifications_Name.Text = "انتهاء بطاقة الرقم القومى"
                dt_Notifications.Clear()
                dt_Notifications.Columns.Clear()
                Select_Personal_ID_Expiry_Date(dgv_Notifications)
                Lbl_Count.Text = dgv_Notifications.RowCount.ToString()
        End Select
    End Sub
    Private Sub dgv_Tbl_Employee_FilterStringChanged(sender As Object, e As EventArgs) Handles dgv_Notifications.FilterStringChanged
        BindingSource1.Filter = dgv_Notifications.FilterString
        dgv_Notifications.DataSource = BindingSource1
        Lbl_Count.Text = dgv_Notifications.RowCount.ToString()
    End Sub

    Private Sub dgv_Tbl_Employee_SortStringChanged(sender As Object, e As EventArgs) Handles dgv_Notifications.SortStringChanged
        BindingSource1.Sort = dgv_Notifications.SortString
        dgv_Notifications.DataSource = BindingSource1
        Lbl_Count.Text = dgv_Notifications.RowCount.ToString()
    End Sub
End Class