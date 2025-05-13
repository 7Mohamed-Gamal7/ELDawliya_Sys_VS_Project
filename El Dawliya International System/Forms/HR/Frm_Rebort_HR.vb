Imports System.Data.SqlClient
Public Class Frm_Rebort_HR
    'Public ConStr As String = GetConnectionString()
    'Public Con As New SqlConnection(ConStr)
    Public dt_Tbl_Employee As New DataTable
    Public dt_Tbl_Employee_Select As New DataTable
    Dim ds As New DataSet
    Private columnsToExport As Object

    Public Sub SelectAll_Tbl_Employee(dgv As DataGridView)
        Dim da As New SqlDataAdapter
        dt_Tbl_Employee.Clear()
        da = New SqlDataAdapter("Select_All_Employee", Con)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.Fill(dt_Tbl_Employee)
        dgv.DataSource = dt_Tbl_Employee
        Try
            If Con.State = 1 Then
                Con.Close()
                Con.Open()
            End If
            Dim selectedFields As New List(Of String)
            ' تعيين العمود بناء على الاختيارات
            For Each column As DataGridViewColumn In dgv_Tbl_Employee.Columns
                column.Visible = False ' جعل كل الأعمدة مخفية بشكل افتراضي
                selectedFields.Add(column.Name)
            Next
        Catch ex As Exception
            MessageBox.Show("خطأ: " & ex.Message)
        End Try
        Con.Close()
    End Sub

    Public Sub SelectAll_Tbl_Employee_Resignation(dgv As DataGridView)
        Dim da As New SqlDataAdapter
        dt_Tbl_Employee.Clear()
        da = New SqlDataAdapter("Select_All_Employee_Resignation", Con)
        da.SelectCommand.CommandType = CommandType.StoredProcedure
        da.Fill(dt_Tbl_Employee)
        dgv.DataSource = dt_Tbl_Employee
        Try
            If Con.State = 1 Then
                Con.Close()
                Con.Open()
            End If
            Dim selectedFields As New List(Of String)
            ' تعيين العمود بناء على الاختيارات
            For Each column As DataGridViewColumn In dgv_Tbl_Employee.Columns
                column.Visible = False ' جعل كل الأعمدة مخفية بشكل افتراضي
                selectedFields.Add(column.Name)
            Next
        Catch ex As Exception
            MessageBox.Show("خطأ: " & ex.Message)
        End Try
        Con.Close()
    End Sub

    Private Sub Frm_Rebort_HR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If
            Dim da As New SqlDataAdapter
            da = New SqlDataAdapter("select * from Tbl_Employee", Con)
            da.Fill(ds, "ds_Tbl_Employee")
            SelectAll_Tbl_Employee(dgv_Tbl_Employee)
            'UpdateDataGridView()
            BindingSource1.DataSource = dt_Tbl_Employee.DefaultView
            GotFoucs_LostFocus_For_Control_On_Panal(BasePanal)
            GotFoucs_LostFocus_For_Control_On_Panal(Panel2)
            GotFoucs_LostFocus_For_Control_On_Panal(Panel3)
            GotFoucs_LostFocus_For_Control_On_Panal(Panel5)
            GotFoucs_LostFocus_For_Control_On_Panal(Panel2)
            'GotFoucs_LostFocus_For_TabControl(TabControl1)
            Con.Close()
        Catch ex As Exception
            MessageBox.Show("خطأ: " & ex.Message)
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

    Private Sub dgv_Tbl_Employee_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Tbl_Employee.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            If dgv_Tbl_Employee.Rows(e.RowIndex).Cells("Emp_ID").Value IsNot Nothing Then
                Dim selectedEmpID As String = dgv_Tbl_Employee.Rows(e.RowIndex).Cells("Emp_ID").Value.ToString()

                If Not IsEmpIDExist(selectedEmpID) Then
                    If dgv_To.Columns.Count = 0 Then
                        For Each column As DataGridViewColumn In dgv_Tbl_Employee.Columns
                            ' استنساخ العمود من dgv_Tbl_Employee وإضافته إلى AdvancedDataGridView1
                            Dim newColumn As DataGridViewColumn = CType(column.Clone(), DataGridViewColumn)
                            newColumn.HeaderText = column.HeaderText
                            newColumn.Name = column.Name
                            newColumn.DataPropertyName = column.DataPropertyName
                            dgv_To.Columns.Add(newColumn)
                        Next
                    End If

                    Dim columnCount As Integer = dgv_To.Columns.Count
                    Dim dv As New DataView(dt_Tbl_Employee)
                    dv.RowFilter = "Emp_ID = '" + selectedEmpID + "'"

                    For Each dr As DataRowView In dv
                        Dim newRow As New DataGridViewRow()
                        newRow.CreateCells(dgv_To)

                        If dr.Row.ItemArray.Length = columnCount Then
                            For i As Integer = 0 To columnCount - 1
                                newRow.Cells(i).Value = dr(i).ToString()
                            Next
                            dgv_To.Rows.Add(newRow)
                        Else
                            MessageBox.Show("عدد الأعمدة في الصف غير متطابق مع عدد الأعمدة في الجدول المتقدم.")
                        End If
                    Next
                End If
            End If
        End If
    End Sub

    Private Function IsEmpIDExist(empID As String) As Boolean
        For Each row As DataGridViewRow In dgv_To.Rows
            If row.Cells("Emp_ID").Value IsNot Nothing AndAlso row.Cells("Emp_ID").Value.ToString() = empID Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub AdvancedDataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_To.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = dgv_To.Rows(e.RowIndex)
            ' التحقق مما إذا كان الصف الذي تحاول حذفه جديدًا أم لا
            If Not selectedRow.IsNewRow Then
                dgv_To.Rows.RemoveAt(e.RowIndex)
                ' يمكنك أيضًا تنفيذ الإجراء الخاص بمسح البيانات من قاعدة البيانات هنا.
            End If
        End If
    End Sub

    Private Sub UpdateDataGridView()
        dt_Tbl_Employee_Select.Clear()
        ' إنشاء قائمة لتخزين أسماء الحقول المحددة
        Dim selectedFields As New List(Of String)
        ' التحقق من كل CheckBox وإضافة اسم الحقل إلى القائمة إذا تم تحديده
        If Emp_ID.Checked = True Then selectedFields.Add("Emp_ID")
        If Emp_ID.Checked = False Then selectedFields.Add("Emp_ID")
        If Emp_Full_Name.Checked = True Then selectedFields.Add("Emp_Full_Name")
        If Emp_Full_Name.Checked = False Then selectedFields.Add("Emp_Full_Name")
        If Emp_Phone1.Checked = True Then selectedFields.Add("Emp_Phone1")
        If Emp_Address.Checked = True Then selectedFields.Add("Emp_Address")
        If Emp_Marital_Status.Checked = True Then selectedFields.Add("Emp_Marital_Status")
        If Emp_Nationality.Checked = True Then selectedFields.Add("Emp_Nationality")

        ' تعيين العمود بناء على الاختيارات
        For Each column As DataGridViewColumn In dgv_Tbl_Employee.Columns
            column.Visible = False
        Next

        For Each fieldName As String In selectedFields
            Dim column As DataGridViewColumn = dgv_Tbl_Employee.Columns(fieldName)
            If column IsNot Nothing Then
                column.Visible = True
                column.HeaderText = GetHeaderTranslation(fieldName) ' استبدال اسم العمود بالترجمة إذا لزم الأمر
            End If
        Next

        Dim query As String
        If selectedFields.Count > 0 Then
            query = "SELECT " & String.Join(", ", selectedFields) & " FROM tbl_Employee"
        Else
            query = "SELECT * FROM tbl_Employee" ' إذا لم يتم تحديد أي CheckBox، جلب كل الحقول
        End If
        Dim da As New SqlDataAdapter
        da = New SqlDataAdapter(query, Con)
        da.Fill(dt_Tbl_Employee_Select)
        dgv_Tbl_Employee.DataSource = dt_Tbl_Employee_Select
    End Sub

    Private Function GetHeaderTranslation(fieldName As String) As String
        ' يمكنك استبدال أسماء الأعمدة بالترجمة المناسبة هنا
        Select Case fieldName
            Case "Emp_ID"
                Return "الكود"
            Case "Emp_Full_Name"
                Return "الاسم الكامل"
            Case "Emp_Phone1"
                Return "الهاتف"
            Case "Emp_Address"
                Return "العنوان"
            Case "Emp_Marital_Status"
                Return "الحالة الاجتماعية"
            Case "Emp_Nationality"
                Return "الجنسية"
            Case "People_With_Special_Needs"
                Return "أشخاص ذوي احتياجات خاصة"
            Case "National_ID"
                Return "الرقم القومي"
            Case "Date_Birth"
                Return "تاريخ الميلاد"
            Case "Place_Birth"
                Return "مكان الميلاد"
            Case "Emp_Type"
                Return "نوع الموظف"
            Case "Working_Condition"
                Return "حالة العمل"
            Case "Dept_Name"
                Return "اسم القسم"
            Case "Jop_Name"
                Return "اسم الوظيفة"
            Case "Emp_Date_Hiring"
                Return "تاريخ التوظيف"
            Case "Emp_Car"
                Return "السيارة"
            Case "Car_Ride_Time"
                Return "وقت الركوب"
            Case "Car_Pick_Up_Point"
                Return "نقطة الانطلاق"
            Case "Insurance_Status"
                Return "حالة التأمين"
            Case "Jop_Code_insurance"
                Return "كود الوظيفة بالتأمين"
            Case "Jop_Name_insurance"
                Return "اسم الوظيفة بالتأمين"
            Case "Health_Card"
                Return "البطاقة الصحية"
            Case "Health_Card_Number"
                Return "رقم البطاقة الصحية"
            Case "Health_Card_Start_Date"
                Return "تاريخ بدء البطاقة الصحية"
            Case "Health_Card_Expiration_Date"
                Return "تاريخ انتهاء البطاقة الصحية"
            Case "Number_Insurance"
                Return "رقم التأمين"
            Case "Date_Insurance_Start"
                Return "تاريخ بدء التأمين"
            Case "Insurance_Salary"
                Return "مرتب التأمين"
            Case "Form_S1"
                Return "استمارة S1"
            Case "Confirmation_Insurance_Entry"
                Return "تأكيد دخول التأمين"
            Case "Delivery_Date_S1"
                Return "تاريخ تسليم S1"
            Case "Receive_Date_S1"
                Return "تاريخ استلام S1"
            Case "Form_S6"
                Return "استمارة S6"
            Case "Delivery_Date_S6"
                Return "تاريخ تسليم S6"
            Case "Receive_Date_S6"
                Return "تاريخ استلام S6"
            Case "Hiring_Date_Health_Card"
                Return "تاريخ التعيين للبطاقة الصحية"
            Case "Skill_level_measurement_certificate"
                Return "شهادة قياس مستوى المهارة"
            Case "The_health_card_remains_expire"
                Return "تاريخ انتهاء صلاحية البطاقة الصحية"
            Case "CurrentWeekShift"
                Return "النوبة الحالية"
            Case "NextWeekShift"
                Return "النوبة القادمة"
            Case "Friday_Operation"
                Return "عمل يوم الجمعة"
            Case "Shift_Type"
                Return "نوع النوبة"
            Case "Entrance_Date_S1"
                Return "تاريخ دخول S1"
            Case "Entrance_Number_S1"
                Return "رقم دخول S1"
            Case "Remaining_Contract_Renewal"
                Return "تجديد العقد المتبقي"
            Case "Medical_Exam_Form_Submission"
                Return "تقديم نموذج الفحص الطبي"
            Case "Contract_Renewal_Date"
                Return "تاريخ تجديد العقد"
            Case "Contract_Expiry_Date"
                Return "تاريخ انتهاء العقد"
            Case "Insurance_Code"
                Return "كود التأمين"
            Case "Due_Insurance_Amount"
                Return "قيمة التأمين المستحقة"
            Case "Military_Service_Certificate"
                Return "شهادة الخدمة العسكرية"
            Case "Qualification_Certificate"
                Return "شهادة التخرج"
            Case "Birth_Certificate"
                Return "شهادة الميلاد"
            Case "Insurance_Printout"
                Return "طباعة التأمين"
            Case "ID_Card_Photo"
                Return "صورة البطاقة الشخصية"
            Case "Personal_Photos"
                Return "صور الشخصية"
            Case "Employment_Contract"
                Return "عقد العمل"
            Case "Medical_Exam_Form"
                Return "نموذج الفحص الطبي"
            Case "Criminal_Record_Check"
                Return "تقييد سجني"
            Case "Social_Status_Report"
                Return "تقرير الحالة الاجتماعية"
            Case "Work_Heel"
                Return "العمل في الصف"
            Case "Heel_Work_Number"
                Return "رقم العمل في الصف"
            Case "Heel_Work_Recipient"
                Return "المستلم في العمل في الصف"
            Case "Heel_Work_Recipient_Address"
                Return "عنوان المستلم في العمل في الصف"
            Case "Entrance_Number_S6"
                Return "رقم دخول S6"
            Case "Entrance_Date_S6"
                Return "تاريخ دخول S6"
            Case "Shift_paper"
                Return "ورقة النوبة"
            Case "Age"
                Return "العمر"
            Case "Mother_Name"
                Return "اسم الأم"
            Case "Date_Resignation"
                Return "تاريخ الاستقالة"
            Case Else
                Return fieldName
        End Select
    End Function

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim saveDialog As New SaveFileDialog()
        saveDialog.Filter = "Excel Files|*.xlsx;*.xls"
        saveDialog.Title = "E:\El Dawliya International System\Excel"
        Dim columnsToExport As New List(Of String)

        ' جمع أسماء الأعمدة من DataGridView ووضعها في قائمة
        'For Each column As DataGridViewColumn In dgv_Tbl_Employee.Columns
        '    columnsToExport.Add(column.Name)
        'Next

        If saveDialog.ShowDialog() = DialogResult.OK Then
            ' استدعاء الدالة ExportToExcel مع تمرير قائمة الأعمدة المرغوب تصديرها
            ExportVisibleColumnsToExcel(dgv_Tbl_Employee, saveDialog.FileName)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim saveDialog As New SaveFileDialog()
        saveDialog.Filter = "Excel Files|*.xlsx;*.xls"
        saveDialog.Title = "E:\El Dawliya International System\Excel"


        If saveDialog.ShowDialog() = DialogResult.OK Then
            ' استدعاء الدالة ExportToExcel مع تمرير قائمة الأعمدة المرغوب تصديرها
            ExportVisibleColumnsToExcel(dgv_To, saveDialog.FileName)
        End If
    End Sub

    Private Sub CheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles Emp_ID.CheckedChanged, Emp_Full_Name.CheckedChanged, Emp_Phone1.CheckedChanged, Emp_Address.CheckedChanged, Emp_Marital_Status.CheckedChanged, Emp_Nationality.CheckedChanged, People_With_Special_Needs.CheckedChanged, National_ID.CheckedChanged, Date_Birth.CheckedChanged, Place_Birth.CheckedChanged, Emp_Type.CheckedChanged, Working_Condition.CheckedChanged, Dept_Name.CheckedChanged, Jop_Name.CheckedChanged, Emp_Date_Hiring.CheckedChanged, Emp_Car.CheckedChanged, Car_Ride_Time.CheckedChanged, Car_Pick_Up_Point.CheckedChanged, Jop_Code_insurance.CheckedChanged, Health_Card.CheckedChanged, Health_Card_Number.CheckedChanged, Health_Card_Start_Date.CheckedChanged, Health_Card_Expiration_Date.CheckedChanged, Hiring_Date_Health_Card.CheckedChanged, Skill_level_measurement_certificate.CheckedChanged, The_health_card_remains_expire.CheckedChanged, CurrentWeekShift.CheckedChanged, NextWeekShift.CheckedChanged, Friday_Operation.CheckedChanged, Shift_Type.CheckedChanged, Entrance_Date_S1.CheckedChanged, Entrance_Number_S1.CheckedChanged, Remaining_Contract_Renewal.CheckedChanged, Medical_Exam_Form_Submission.CheckedChanged, Contract_Expiry_Date.CheckedChanged, Due_Insurance_Amount.CheckedChanged, Military_Service_Certificate.CheckedChanged, Qualification_Certificate.CheckedChanged, Birth_Certificate.CheckedChanged, Insurance_Printout.CheckedChanged, ID_Card_Photo.CheckedChanged, Personal_Photos.CheckedChanged, Employment_Contract.CheckedChanged, Medical_Exam_Form.CheckedChanged, Criminal_Record_Check.CheckedChanged, Social_Status_Report.CheckedChanged, Work_Heel.CheckedChanged, Heel_Work_Number.CheckedChanged, Entrance_Number_S6.CheckedChanged, Entrance_Date_S6.CheckedChanged, Shift_paper.CheckedChanged, Age.CheckedChanged, Insurance_Status.CheckedChanged, Number_Insurance.CheckedChanged, Insurance_Salary.CheckedChanged, Confirmation_Insurance_Entry.CheckedChanged, Jop_Name_insurance.CheckedChanged, Contract_Renewal_Date.CheckedChanged, Date_Insurance_Start.CheckedChanged, Form_S1.CheckedChanged, Delivery_Date_S1.CheckedChanged, Receive_Date_S1.CheckedChanged, Form_S6.CheckedChanged, Delivery_Date_S6.CheckedChanged, Receive_Date_S6.CheckedChanged, Mother_Name.CheckedChanged, Date_Resignation.CheckedChanged
        Dim checkBox As CheckBox = CType(sender, CheckBox)
        Dim columnName As String = checkBox.Name
        Dim headerText As String = GetHeaderTranslation(columnName)
        With dgv_Tbl_Employee.Columns(columnName)
            .Visible = checkBox.Checked
            If checkBox.Checked Then .HeaderText = headerText
        End With

    End Sub

    Private Sub Rad_Working_Active_CheckedChanged(sender As Object, e As EventArgs) Handles Rad_Working_Active.CheckedChanged
        If Me.Rad_Working_Active.Checked = True Then
            ds.Clear()
            Dim da As New SqlDataAdapter
            da = New SqlDataAdapter("Select_All_Employee", Con)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.Fill(ds, "ds_Tbl_Employee")
            SelectAll_Tbl_Employee(dgv_Tbl_Employee)
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
        End If
    End Sub

    '=========================================================================================================================================

    Private Sub txt_Emp_Code_TextChanged(sender As Object, e As EventArgs) Handles txt_Emp_Code.TextChanged
        If Not String.IsNullOrEmpty(txt_Emp_Code.Text) Then
            Dim empID As String = txt_Emp_Code.Text
            Dim empName As String = GetEmployeeName(empID)
            If Not String.IsNullOrEmpty(empName) Then
                cmb_Emp_Name.Text = empName
            Else
                cmb_Emp_Name.Text = "" ' تفريغ المربع إذا لم يتم العثور على الموظف
            End If
        Else
            cmb_Emp_Name.Text = "" ' تفريغ المربع إذا كان الحقل فارغًا
        End If
    End Sub

    Private Function GetEmployeeName(empID As String) As String
        Dim empName As String = ""
        Try
            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If
            Dim cmd As New SqlCommand("SELECT Emp_Full_Name FROM Tbl_Employee WHERE Emp_ID = @Emp_ID", Con)
            cmd.Parameters.AddWithValue("@Emp_ID", empID)
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                empName = reader("Emp_Full_Name").ToString()
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("خطأ: " & ex.Message)
        Finally
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
        Return empName
    End Function

    Private Sub Btn_Tarhel_Click(sender As Object, e As EventArgs) Handles Btn_Tarhel.Click
        If Not String.IsNullOrEmpty(txt_Emp_Code.Text) Then
            Dim empID As String = txt_Emp_Code.Text
            If Not IsEmpIDExistInDgvTo(empID) Then
                AddEmployeeToDgvTo(empID)
            Else
                MessageBox.Show("الموظف موجود بالفعل في الجدول.")
            End If
        Else
            MessageBox.Show("يرجى إدخال رقم الموظف.")
        End If
    End Sub


    Private Sub AddEmployeeToDgvTo(empID As String)
        Try
            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If

            ' 1. إنشاء أعمدة dgv_To بناءً على الأعمدة المرئية في dgv_Tbl_Employee
            If dgv_To.Columns.Count = 0 Then
                For Each srcColumn As DataGridViewColumn In dgv_Tbl_Employee.Columns
                    If srcColumn.Visible Then
                        Dim newColumn As New DataGridViewTextBoxColumn()
                        newColumn.Name = srcColumn.Name
                        newColumn.HeaderText = srcColumn.HeaderText
                        newColumn.DataPropertyName = srcColumn.DataPropertyName
                        dgv_To.Columns.Add(newColumn)
                    End If
                Next
            End If

            ' 2. جلب بيانات الموظف مع الأعمدة المرئية فقط
            Dim selectedFields As New List(Of String)
            For Each column As DataGridViewColumn In dgv_Tbl_Employee.Columns
                If column.Visible Then
                    selectedFields.Add(column.Name)
                End If
            Next

            If selectedFields.Count = 0 Then
                MessageBox.Show("يرجى تحديد الأعمدة المراد عرضها.")
                Return
            End If

            Dim query As String = "SELECT " & String.Join(", ", selectedFields) & " FROM Tbl_Employee WHERE Emp_ID = @Emp_ID"
            Dim cmd As New SqlCommand(query, Con)
            cmd.Parameters.AddWithValue("@Emp_ID", empID)
            Dim da As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                ' 3. إضافة الصف إلى dgv_To
                Dim newRow As DataGridViewRow = CType(dgv_To.Rows(0).Clone(), DataGridViewRow)
                For Each field In selectedFields
                    newRow.Cells(field).Value = dt.Rows(0)(field).ToString()
                Next
                dgv_To.Rows.Add(newRow)
            Else
                MessageBox.Show("لم يتم العثور على الموظف.")
            End If
        Catch ex As Exception
            MessageBox.Show("خطأ: " & ex.Message)
        Finally
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Sub


    Private Function IsEmpIDExistInDgvTo(empID As String) As Boolean
        For Each row As DataGridViewRow In dgv_To.Rows
            If Not row.IsNewRow AndAlso row.Cells("Emp_ID").Value?.ToString() = empID Then
                Return True
            End If
        Next
        Return False
    End Function


End Class


