Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class Frm_Car_Attendance_Search
    Private conStr As String = GetConnectionString()
    Private con As New SqlConnection(conStr)

    Private Sub OpenConnection()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub

    Private Sub CloseConnection()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
    End Sub

    Private Sub Frm_Car_Attendance_Search_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadSuppliers()
        AddEditAndDeleteButtonColumns() ' تعديل الدالة لتشمل زر الحذف
    End Sub

    Private Sub LoadSuppliers()
        Dim query As String = "SELECT DISTINCT Supplier FROM Tbl_Car"
        Using cmd As New SqlCommand(query, con)
            OpenConnection()
            Dim reader As SqlDataReader = cmd.ExecuteReader()
            While reader.Read()
                cmbSupplier.Items.Add(reader("Supplier").ToString())
            End While
            CloseConnection()
        End Using
    End Sub

    Private Sub AddEditAndDeleteButtonColumns()
        ' إضافة عمود زر "تعديل"
        Dim editButtonColumn As New DataGridViewButtonColumn()
        editButtonColumn.Name = "EditColumn"
        editButtonColumn.HeaderText = "تعديل"
        editButtonColumn.Text = "تعديل"
        editButtonColumn.UseColumnTextForButtonValue = True
        dgvResults.Columns.Add(editButtonColumn)

        ' إضافة عمود زر "حذف"
        Dim deleteButtonColumn As New DataGridViewButtonColumn()
        deleteButtonColumn.Name = "DeleteColumn"
        deleteButtonColumn.HeaderText = "حذف"
        deleteButtonColumn.Text = "حذف"
        deleteButtonColumn.UseColumnTextForButtonValue = True
        dgvResults.Columns.Add(deleteButtonColumn)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Try
            Dim carID As Integer?
            If Not String.IsNullOrEmpty(txtCarID.Text) Then
                If Integer.TryParse(txtCarID.Text, carID) Then
                    ' تم التحويل بنجاح
                Else
                    MessageBox.Show("كود السيارة يجب أن يكون رقمًا صحيحًا.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            End If

            Dim startDate As Date = dtpStart.Value.Date
            Dim endDate As Date = dtpEnd.Value.Date.AddDays(1).AddTicks(-1) ' لتضمين اليوم بأكمله
            Dim supplier As String = If(cmbSupplier.SelectedItem Is Nothing, Nothing, cmbSupplier.SelectedItem.ToString())

            Dim query As String = "SELECT ca.Attendance_ID,ca.Car_ID,ca.Attendance_Code,c.Car_Name,ca.Attendance_Date, " &
                                  "ca.Check_In,ca.Check_Out, ca.Shift_Type,ca.Salary,c.Supplier, ca.Notes, " &
                                  "ca.Delay_Type,ca.Manual_Deduction " &
                                  "FROM Tbl_Car_Attendance ca " &
                                  "JOIN Tbl_Car c ON ca.Car_ID = c.Car_ID " &
                                  "WHERE (@CarID IS NULL OR ca.Car_ID = @CarID) " &
                                  "AND ca.Attendance_Date BETWEEN @StartDate AND @EndDate " &
                                  "AND (@Supplier IS NULL OR c.Supplier = @Supplier)"

            Using conn As New SqlConnection(conStr)
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@CarID", If(carID.HasValue, carID.Value, DBNull.Value))
                    cmd.Parameters.AddWithValue("@StartDate", startDate)
                    cmd.Parameters.AddWithValue("@EndDate", endDate)
                    cmd.Parameters.AddWithValue("@Supplier", If(supplier Is Nothing, DBNull.Value, supplier))



                    Dim da As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    dgvResults.DataSource = dt

                    ' تسمية عناوين رؤوس الأعمدة
                    If dgvResults.Columns.Count > 0 Then
                        dgvResults.Columns("Attendance_ID").HeaderText = "كود الحضور"
                        dgvResults.Columns("Attendance_ID").Visible = False
                        dgvResults.Columns("Car_ID").HeaderText = "كود السيارة"
                        dgvResults.Columns("Attendance_Code").HeaderText = "كود الحضور"
                        dgvResults.Columns("Car_Name").HeaderText = "اسم السيارة"
                        dgvResults.Columns("Attendance_Date").HeaderText = "تاريخ الحضور"
                        dgvResults.Columns("Check_In").HeaderText = "وقت الدخول"
                        dgvResults.Columns("Check_Out").HeaderText = "وقت الخروج"
                        dgvResults.Columns("Shift_Type").HeaderText = "نوع الشيفت"
                        dgvResults.Columns("Delay_Type").HeaderText = "نوع التأخير"
                        dgvResults.Columns("Manual_Deduction").HeaderText = "الخصم اليدوي"
                        dgvResults.Columns("Salary").HeaderText = "الراتب"
                        dgvResults.Columns("Supplier").HeaderText = "المورد"
                        dgvResults.Columns("Notes").HeaderText = "ملاحظات"

                    End If
                End Using
            End Using
        Catch ex As Exception

            MessageBox.Show("حدث خطأ أثناء تنفيذ البحث: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' تأكد من إغلاق الاتصال في النهاية
            CloseConnection()
        End Try

    End Sub

    Private Sub dgvResults_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvResults.CellContentClick
        If e.RowIndex >= 0 Then
            Dim attendanceID As Integer = CInt(dgvResults.Rows(e.RowIndex).Cells("Attendance_ID").Value)

            ' التعامل مع زر التعديل
            If e.ColumnIndex = dgvResults.Columns("EditColumn").Index Then
                Dim editForm As New Editattendanceform(attendanceID)
                If editForm.ShowDialog() = DialogResult.OK Then
                    btnSearch.PerformClick() ' إعادة تحميل البيانات بعد التعديل
                End If
                ' التعامل مع زر الحذف
            ElseIf e.ColumnIndex = dgvResults.Columns("DeleteColumn").Index Then
                If MessageBox.Show("هل أنت متأكد من حذف هذا السجل؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                    DeleteAttendanceRecord(attendanceID)
                    btnSearch.PerformClick() ' إعادة تحميل البيانات بعد الحذف
                End If
            End If
        End If
    End Sub

    Private Sub DeleteAttendanceRecord(attendanceID As Integer)
        Dim query As String = "DELETE FROM Tbl_Car_Attendance WHERE Attendance_ID = @AttendanceID"
        Using conn As New SqlConnection(conStr)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@AttendanceID", attendanceID)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub btnExportToExcel_Click(sender As Object, e As EventArgs) Handles btnExportToExcel.Click
        If dgvResults.Rows.Count = 0 Then
            MessageBox.Show("لا توجد بيانات للتصدير.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Excel Files|*.xlsx"
        saveFileDialog.Title = "اختر مكان حفظ الملف"
        saveFileDialog.FileName = "Attendance_Data.xlsx"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim excelApp As New Microsoft.Office.Interop.Excel.Application()
            Dim workbook As Microsoft.Office.Interop.Excel.Workbook = excelApp.Workbooks.Add()
            Dim worksheet As Microsoft.Office.Interop.Excel.Worksheet = workbook.Sheets(1)

            For colIndex As Integer = 0 To dgvResults.Columns.Count - 1
                worksheet.Cells(1, colIndex + 1).Value = dgvResults.Columns(colIndex).HeaderText
            Next

            For rowIndex As Integer = 0 To dgvResults.Rows.Count - 1
                For colIndex As Integer = 0 To dgvResults.Columns.Count - 1
                    worksheet.Cells(rowIndex + 2, colIndex + 1).Value = dgvResults.Rows(rowIndex).Cells(colIndex).Value?.ToString()
                Next
            Next

            workbook.SaveAs(saveFileDialog.FileName)
            workbook.Close()
            excelApp.Quit()

            ReleaseObject(worksheet)
            ReleaseObject(workbook)
            ReleaseObject(excelApp)

            MessageBox.Show("تم تصدير البيانات بنجاح إلى Excel.", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ReleaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
End Class