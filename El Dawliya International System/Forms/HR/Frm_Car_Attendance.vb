Imports System.Data.SqlClient
Imports System

Public Class Frm_Car_Attendance
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)

    '==================================================================================================================================
    ' عند تحميل الفورم
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' إعداد أعمدة الداتا جريد فيو
        SetupDataGridView()
        dtpAttendanceDate.Value = Date.Today
        dtpAttendanceDate.Enabled = False
        Me.CheckBox1.Checked = False
        Me.CheckBox1.BackColor = Color.Red
        ' Debugging: Check if the column is added
        If dgvAttendance.Columns("colAttendanceCode") Is Nothing Then
            MessageBox.Show("Column 'colAttendanceCode' was not added.")
        End If
    End Sub

    '==================================================================================================================================
    ' إعداد أعمدة الداتا جريد فيو
    Sub SetupDataGridView()
        dgvAttendance.Columns.Clear()

        Dim colAttendanceCode As New DataGridViewComboBoxColumn With {.Name = "colAttendanceCode", .HeaderText = "كود الحضور", .ValueType = GetType(String)}
        colAttendanceCode.Items.Add("")
        colAttendanceCode.Items.Add("1")
        colAttendanceCode.Items.Add("2")

        Dim colDelayType As New DataGridViewComboBoxColumn With {.Name = "colDelayType", .HeaderText = "نوع التأخير"}
        colDelayType.Items.Add("")
        colDelayType.Items.Add("تأخير اضطرارى")
        colDelayType.Items.Add("تأخير ذهاب")
        colDelayType.Items.Add("تأخير عودة")

        ' إنشاء الأعمدة المطلوبة
        Dim cols As New List(Of DataGridViewColumn) From {
        New DataGridViewTextBoxColumn With {.Name = "colCarID", .HeaderText = "كود السيارة"},
        New DataGridViewTextBoxColumn With {.Name = "colCarName", .HeaderText = "اسم السيارة", .ReadOnly = True, .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill},
        colAttendanceCode,
        New DataGridViewTextBoxColumn With {.Name = "colCheckIn", .HeaderText = "الحضور"},
        New DataGridViewTextBoxColumn With {.Name = "colCheckOut", .HeaderText = "الانصراف"},
        New DataGridViewTextBoxColumn With {.Name = "colShiftType", .HeaderText = "نوع الوردية", .ReadOnly = True},
        New DataGridViewTextBoxColumn With {.Name = "colSalary", .HeaderText = "التكلفة", .ReadOnly = True},
        colDelayType,
        New DataGridViewTextBoxColumn With {.Name = "colDeduction", .HeaderText = "الخصم", .ReadOnly = True},
        New DataGridViewTextBoxColumn With {.Name = "colManualDeduction", .HeaderText = "خصم إضافي"}, ' New column added
        New DataGridViewTextBoxColumn With {.Name = "colNotes", .HeaderText = "ملاحظات", .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill}
    }

        dgvAttendance.Columns.AddRange(cols.ToArray())
    End Sub

    '==================================================================================================================================
    ' حساب الخصم بناءً على كود الحضور
    Function CalculateDeduction(rowIndex As Integer) As Decimal
        Dim attendanceCode As String = dgvAttendance.Rows(rowIndex).Cells("colAttendanceCode").Value?.ToString()
        Dim salary As Decimal = CDec(dgvAttendance.Rows(rowIndex).Cells("colSalary").Value)

        Dim delayType As String = dgvAttendance.Rows(rowIndex).Cells("colDelayType").Value?.ToString()
        Dim deduction As Decimal = 0

        If String.IsNullOrEmpty(delayType) Then
            ' If delay type is empty: No deduction
            Return 0
        ElseIf delayType = "تأخير اضطرارى" Then
            Return 0
        ElseIf delayType = "تأخير ذهاب" OrElse delayType = "تأخير عودة" Then

            ' If delay type is "تأخير ذهاب" or "تأخير عودة": 0.25% of salary
            deduction = CDec(dgvAttendance.Rows(rowIndex).Cells("colSalary").Value) * 0.25
        End If

        Return deduction
    End Function

    '==================================================================================================================================
    ' عند الضغط على زر تحميل البيانات
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Try
            dgvAttendance.Rows.Clear()

            ' جلب السيارات المفعلة
            Using conn As New SqlConnection(ConStr)
                conn.Open()
                Dim cmd As New SqlCommand("SELECT Car_ID, Car_Name FROM Tbl_Car WHERE Is_Active = 1", conn)
                Dim reader As SqlDataReader = cmd.ExecuteReader()

                While reader.Read()
                    Dim row As New DataGridViewRow()
                    row.CreateCells(dgvAttendance)
                    row.Cells("colCarID").Value = reader("Car_ID")
                    row.Cells("colCarName").Value = reader("Car_Name")
                    dgvAttendance.Rows.Add(row)
                End While
            End Using

            ' تعيين القيم الافتراضية
            For Each row As DataGridViewRow In dgvAttendance.Rows
                If Not row.IsNewRow Then
                    row.Cells("colAttendanceCode").Value = ""
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("حدث خطأ أثناء تحميل البيانات: " & ex.Message)
        End Try
    End Sub

    '==================================================================================================================================
    ' عند الانتهاء من تحرير خلية كود السيارة
    Private Sub dgvAttendance_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAttendance.CellEndEdit
        ' تجاهل الصف الجديد (New Row) والصفوف غير الصالحة
        If e.RowIndex < 0 OrElse e.RowIndex >= dgvAttendance.Rows.Count - 1 Then
            Exit Sub
        End If

        If e.ColumnIndex = dgvAttendance.Columns("colCarID").Index Then
            Dim currentRow As DataGridViewRow = dgvAttendance.Rows(e.RowIndex)

            ' التحقق من وجود القيمة وتجنب NullReference
            If currentRow IsNot Nothing AndAlso currentRow.Cells("colCarID").Value IsNot Nothing Then
                Dim carID As Integer
                If Integer.TryParse(currentRow.Cells("colCarID").Value.ToString(), carID) Then
                    If CarExists(carID) Then
                        FillCarDetails(carID, e.RowIndex)
                        UpdateTimeAndSalary(e.RowIndex)
                    Else
                        MessageBox.Show("كود السيارة غير موجود!")
                        currentRow.Cells("colCarID").Value = Nothing
                    End If
                Else
                    MessageBox.Show("كود السيارة يجب أن يكون رقمًا صحيحًا!")
                    currentRow.Cells("colCarID").Value = Nothing
                End If
            Else
                MessageBox.Show("يرجى إدخال كود السيارة!")
            End If
        End If
    End Sub

    '==================================================================================================================================
    'ملء تفاصيل السيارة بناءً على كود السيارة
    Sub FillCarDetails(carID As Integer, rowIndex As Integer)
        Try
            Using conn As New SqlConnection(ConStr)
                conn.Open()
                Dim cmd As New SqlCommand("SELECT Car_Name, Car_Salary, Car_Salary_Farda, Contract_Type, Shift_Type 
                                      FROM Tbl_Car 
                                      WHERE Car_ID = @CarID", conn)
                cmd.Parameters.AddWithValue("@CarID", carID)

                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        With dgvAttendance.Rows(rowIndex)
                            .Cells("colCarName").Value = reader("Car_Name")
                            .Cells("colCheckIn").Value = "07:25"
                            .Cells("colCheckOut").Value = "15:30"
                            .Cells("colSalary").Value = reader("Car_Salary")
                            .Cells("colShiftType").Value = reader("Contract_Type")
                            .Tag = reader("Shift_Type")
                        End With
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("حدث خطأ أثناء جلب بيانات السيارة: " & ex.Message)
        End Try
    End Sub

    '==================================================================================================================================
    ' تحديث الوقت والراتب عند تغيير كود الحضور
    Private Sub dgvAttendance_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAttendance.CellValueChanged
        If e.ColumnIndex = dgvAttendance.Columns("colAttendanceCode").Index AndAlso e.RowIndex >= 0 Then
            UpdateTimeAndSalary(e.RowIndex)
        End If
    End Sub

    '==================================================================================================================================
    ' تحديث الوقت والراتب بناءً على كود الحضور
    Sub UpdateTimeAndSalary(rowIndex As Integer)
        Dim code As String = dgvAttendance.Rows(rowIndex).Cells("colAttendanceCode").Value?.ToString()
        Dim selectedDate As Date = dtpAttendanceDate.Value.Date
        Dim checkInValue As Object = DBNull.Value
        Dim checkOutValue As Object = DBNull.Value

        Select Case code
            Case "1"
                Dim timeIn As TimeSpan = TimeSpan.Parse("07:30")
                checkInValue = selectedDate.Add(timeIn)
            Case "2"
                Dim timeOut As TimeSpan = TimeSpan.Parse("15:30")
                checkOutValue = selectedDate.Add(timeOut)
            Case Else
                Dim timeIn As TimeSpan = TimeSpan.Parse("07:25")
                Dim timeOut As TimeSpan = TimeSpan.Parse("15:30")
                checkInValue = selectedDate.Add(timeIn)
                checkOutValue = selectedDate.Add(timeOut)
        End Select

        dgvAttendance.Rows(rowIndex).Cells("colCheckIn").Value = checkInValue
        dgvAttendance.Rows(rowIndex).Cells("colCheckOut").Value = checkOutValue

        CalculateSalary(rowIndex)
        SetShiftType(rowIndex)

        ' Update deduction display
        Dim deduction As Decimal = CalculateDeduction(rowIndex)
        dgvAttendance.Rows(rowIndex).Cells("colDeduction").Value = deduction
    End Sub

    '==================================================================================================================================
    ' حساب الراتب بناءً على كود الحضور
    Sub CalculateSalary(rowIndex As Integer)
        Try
            Dim carID As Integer = CInt(dgvAttendance.Rows(rowIndex).Cells("colCarID").Value)
            Dim attendanceCode As String = dgvAttendance.Rows(rowIndex).Cells("colAttendanceCode").Value?.ToString()

            Using conn As New SqlConnection(ConStr)
                conn.Open()
                Dim cmd As New SqlCommand("SELECT Car_Salary, Car_Salary_Farda FROM Tbl_Car WHERE Car_ID = @CarID", conn)
                cmd.Parameters.AddWithValue("@CarID", carID)

                Dim reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    Dim salary As Decimal = If(String.IsNullOrEmpty(attendanceCode),
                                      CDec(reader("Car_Salary")),
                                      CDec(reader("Car_Salary_Farda")))

                    dgvAttendance.Rows(rowIndex).Cells("colSalary").Value = salary
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("حدث خطأ في حساب الراتب: " & ex.Message)
        End Try
    End Sub

    '==================================================================================================================================
    ' تعيين نوع الوردية بناءً على كود الحضور
    Sub SetShiftType(rowIndex As Integer)
        Dim attendanceCode As String = dgvAttendance.Rows(rowIndex).Cells("colAttendanceCode").Value?.ToString()
        Dim carID As Integer

        ' التحقق من وجود كود السيارة وتحويله لرقم
        If Integer.TryParse(dgvAttendance.Rows(rowIndex).Cells("colCarID").Value?.ToString(), carID) Then
            Using conn As New SqlConnection(ConStr)
                conn.Open()

                If String.IsNullOrEmpty(attendanceCode) Then
                    ' جلب Contract_Type إذا كان كود الحضور فارغًا
                    Dim cmdContract As New SqlCommand("SELECT Contract_Type FROM Tbl_Car WHERE Car_ID = @CarID", conn)
                    cmdContract.Parameters.AddWithValue("@CarID", carID)
                    Dim contractType As Object = cmdContract.ExecuteScalar()
                    dgvAttendance.Rows(rowIndex).Cells("colShiftType").Value = If(contractType IsNot DBNull.Value, contractType.ToString(), "")
                Else
                    ' جلب Contract_Type_Farada إذا كان كود الحضور غير فارغ
                    Dim cmdShift As New SqlCommand("SELECT Contract_Type_Farada FROM Tbl_Car WHERE Car_ID = @CarID", conn)
                    cmdShift.Parameters.AddWithValue("@CarID", carID)
                    Dim shiftType As Object = cmdShift.ExecuteScalar()
                    dgvAttendance.Rows(rowIndex).Cells("colShiftType").Value = If(shiftType IsNot DBNull.Value, shiftType.ToString(), "")
                End If
            End Using
        Else
            ' إذا كان كود السيارة غير صالح
            dgvAttendance.Rows(rowIndex).Cells("colShiftType").Value = ""
        End If
    End Sub

    '==================================================================================================================================
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Me.CheckBox1.Checked = False Then
            MsgBox("يرجى تحديد التاريخ")
            Exit Sub
        Else

            Try
                Using conn As New SqlConnection(ConStr)
                    conn.Open()

                    For Each row As DataGridViewRow In dgvAttendance.Rows
                        If Not row.IsNewRow Then
                            ' حساب الخصم التلقائي
                            Dim deduction As Decimal = 0
                            Dim delayType As String = row.Cells("colDelayType").Value?.ToString()
                            If delayType = "تأخير ذهاب" OrElse delayType = "تأخير عودة" Then
                                deduction = (CDec(row.Cells("colSalary").Value) / 2) * 0.25
                            Else
                                deduction = CalculateDeduction(row.Index)
                            End If

                            ' حساب الخصم الإضافي
                            Dim manualDeduction As Decimal = 0
                            If row.Cells("colManualDeduction").Value IsNot Nothing AndAlso
                           Not String.IsNullOrEmpty(row.Cells("colManualDeduction").Value.ToString()) Then
                                Decimal.TryParse(row.Cells("colManualDeduction").Value.ToString(), manualDeduction)
                            End If

                            Using cmd As New SqlCommand("
                    INSERT INTO Tbl_Car_Attendance 
                    (Car_ID, Attendance_Date, Attendance_Code, Check_In, Check_Out, 
                     Shift_Type, Salary, Delay_Type, Deduction, Manual_Deduction, Notes)
                    VALUES (@CarID, @Date, @Code, @In, @Out, @Shift, @Salary, @DelayType, @Deduction, @ManualDeduction, @Notes)", conn)

                                cmd.Parameters.AddWithValue("@CarID", row.Cells("colCarID").Value)
                                cmd.Parameters.AddWithValue("@Date", dtpAttendanceDate.Value.Date)
                                cmd.Parameters.AddWithValue("@Code", If(String.IsNullOrEmpty(row.Cells("colAttendanceCode").Value?.ToString()), DBNull.Value, row.Cells("colAttendanceCode").Value))
                                cmd.Parameters.AddWithValue("@In", If(row.Cells("colCheckIn").Value Is Nothing, DBNull.Value, row.Cells("colCheckIn").Value))
                                cmd.Parameters.AddWithValue("@Out", If(row.Cells("colCheckOut").Value Is Nothing, DBNull.Value, row.Cells("colCheckOut").Value))
                                cmd.Parameters.AddWithValue("@Shift", row.Cells("colShiftType").Value)
                                cmd.Parameters.AddWithValue("@Salary", row.Cells("colSalary").Value)
                                cmd.Parameters.AddWithValue("@DelayType", If(row.Cells("colDelayType").Value Is Nothing, DBNull.Value, row.Cells("colDelayType").Value))
                                cmd.Parameters.AddWithValue("@Deduction", deduction)
                                cmd.Parameters.AddWithValue("@ManualDeduction", manualDeduction)
                                cmd.Parameters.AddWithValue("@Notes", If(row.Cells("colNotes").Value Is Nothing, DBNull.Value, row.Cells("colNotes").Value))

                                cmd.ExecuteNonQuery()
                            End Using
                        End If
                    Next

                    MessageBox.Show("تم الحفظ بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            Catch ex As Exception
                MessageBox.Show("حدث خطأ أثناء الحفظ: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub



    '==================================================================================================================================
    Private Sub dgvAttendance_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgvAttendance.DataError
        MessageBox.Show("الرجاء إدخال قيم صحيحة")
    End Sub

    '==================================================================================================================================
    ' التحقق من وجود السيارة في قاعدة البيانات
    Function CarExists(carID As Integer) As Boolean
        Using conn As New SqlConnection(ConStr)
            Try
                conn.Open()
                Dim cmd As New SqlCommand("SELECT COUNT(*) FROM Tbl_Car WHERE Car_ID = @CarID", conn)
                cmd.Parameters.AddWithValue("@CarID", carID)
                Return CInt(cmd.ExecuteScalar()) > 0
            Catch ex As Exception
                MessageBox.Show("حدث خطأ في التحقق من السيارة: " & ex.Message)
                Return False
            End Try
        End Using
    End Function

    '==================================================================================================================================
    ' التحقق من صحة كود السيارة عند تحرير الخلية
    Private Sub dgvAttendance_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles dgvAttendance.CellValidating
        ' تجاهل الصف الجديد والأعمدة الأخرى
        If e.ColumnIndex <> dgvAttendance.Columns("colCarID").Index OrElse
           e.RowIndex >= dgvAttendance.Rows.Count - 1 Then
            Exit Sub
        End If

        ' التحقق من القيمة المدخلة
        Dim inputValue As String = e.FormattedValue.ToString()
        If String.IsNullOrWhiteSpace(inputValue) Then
            e.Cancel = True
            MessageBox.Show("يرجى إدخال كود السيارة!")
            Return
        End If

        Dim carID As Integer
        If Not Integer.TryParse(inputValue, carID) OrElse Not CarExists(carID) Then
            e.Cancel = True
            MessageBox.Show("كود السيارة غير صحيح!")
        End If
    End Sub


    ' زر لتفريغ البيانات
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Try
            ' تفريغ كل الصفوف ما عدا الصف الجديد (إن وجد)
            For i As Integer = dgvAttendance.Rows.Count - 1 To 0 Step -1
                If Not dgvAttendance.Rows(i).IsNewRow Then
                    dgvAttendance.Rows.RemoveAt(i)
                End If
            Next

            ' إعادة تعيين التاريخ للتاريخ الحالي
            dtpAttendanceDate.Value = Date.Today
            dtpAttendanceDate.Enabled = False
            CheckBox1.Checked = False

            ' رسالة تأكيد
            MessageBox.Show("تم تفريغ البيانات بنجاح", "تفريغ البيانات", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("حدث خطأ أثناء التفريغ: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If Me.CheckBox1.Checked = True Then
            Me.CheckBox1.BackColor = Color.Green
            dtpAttendanceDate.Enabled = True
        Else
            dtpAttendanceDate.Enabled = False
            dtpAttendanceDate.Value = Date.Today
            Me.CheckBox1.BackColor = Color.Red
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
End Class