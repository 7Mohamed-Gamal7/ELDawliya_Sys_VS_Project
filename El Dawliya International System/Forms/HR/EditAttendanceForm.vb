Imports System.Data.SqlClient
Imports System

Public Class Editattendanceform
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Private attendanceID As Integer

    ' المُنشئ لتمرير Attendance_ID
    Public Sub New(attendanceID As Integer)
            InitializeComponent()
            Me.attendanceID = attendanceID
            LoadData()
        End Sub

        ' تحميل البيانات الحالية للسجل المحدد
        Private Sub LoadData()
        'Dim query As String = "SELECT Check_In, Check_Out,Delay_Type,Manual_Deduction,Attendance_Code, Notes FROM Tbl_Car_Attendance WHERE Attendance_ID = @AttendanceID"
        Dim query As String = "SELECT * From tbl_Car_Attendance WHERE Attendance_ID = @AttendanceID"
        Using conn As New SqlConnection(ConStr)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@AttendanceID", attendanceID)
                conn.Open()
                Dim reader As SqlDataReader = cmd.ExecuteReader()
                If reader.Read() Then
                    txtCheckIn.Text = If(reader("Check_In") Is DBNull.Value, "", reader("Check_In").ToString())
                    txtCheckOut.Text = If(reader("Check_Out") Is DBNull.Value, "", reader("Check_Out").ToString())
                    txtNotes.Text = If(reader("Notes") Is DBNull.Value, "", reader("Notes").ToString())
                    txtDelayType.Text = If(reader("Delay_Type") Is DBNull.Value, "", reader("Delay_Type").ToString())
                    txtManualDeduction.Text = If(reader("Manual_Deduction") Is DBNull.Value, "", reader("Manual_Deduction").ToString())
                    'txtShiftType.Text = If(reader("Shift_Type") Is DBNull.Value, "", reader("Shift_Type").ToString())
                    'txtSalary.Text = If(reader("Salary") Is DBNull.Value, "", reader("Salary").ToString())
                    txtCarName.Text = If(reader("Car_Name") Is DBNull.Value, "", reader("Car_Name").ToString())
                    'txtSupplier.Text = If(reader("Supplier") Is DBNull.Value, "", reader("Supplier").ToString())
                    'txtCarID.Text = If(reader("Car_ID") Is DBNull.Value, "", reader("Car_ID").ToString())
                    'txtAttendanceDate.Text = If(reader("Attendance_Date") Is DBNull.Value, "", reader("Attendance_Date").ToString())
                    'txtAttendanceID.Text = If(reader("Attendance_ID") Is DBNull.Value, "", reader("Attendance_ID").ToString())
                    'txtCarID.Text = If(reader("Car_ID") Is DBNull.Value, "", reader("Car_ID").ToString())
                    'txtAttendanceDate.Text = If(reader("Attendance_Date") Is DBNull.Value, "", reader("Attendance_Date").ToString())
                    'txtShiftType.Text = If(reader("Shift_Type") Is DBNull.Value, "", reader("Shift_Type").ToString())
                    'txtSalary.Text = If(reader("Salary") Is DBNull.Value, "", reader("Salary").ToString())
                    'txtSupplier.Text = If(reader("Supplier") Is DBNull.Value, "", reader("Supplier").ToString())
                    'txtCarName.Text = If(reader("Car_Name") Is DBNull.Value, "", reader("Car_Name").ToString())
                    txtAttendanceCode.Text = If(reader("Attendance_Code") Is DBNull.Value, "", reader("Attendance_Code").ToString())
                End If
            End Using
        End Using
    End Sub

        ' حفظ التعديلات عند الضغط على زر الحفظ
        Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim query As String = "UPDATE Tbl_Car_Attendance SET Check_In = @CheckIn, Check_Out = @CheckOut, Notes = @Notes,Delay_Type = @DelayType, Manual_Deduction = @ManualDeduction, Attendance_Code = @AttendanceCode WHERE Attendance_ID = @AttendanceID"
        Using conn As New SqlConnection(ConStr)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@CheckIn", If(String.IsNullOrEmpty(txtCheckIn.Text), DBNull.Value, TimeSpan.Parse(txtCheckIn.Text)))
                cmd.Parameters.AddWithValue("@CheckOut", If(String.IsNullOrEmpty(txtCheckOut.Text), DBNull.Value, TimeSpan.Parse(txtCheckOut.Text)))
                cmd.Parameters.AddWithValue("@Notes", If(String.IsNullOrEmpty(txtNotes.Text), DBNull.Value, txtNotes.Text))
                cmd.Parameters.AddWithValue("@DelayType", If(String.IsNullOrEmpty(txtDelayType.Text), DBNull.Value, txtDelayType.Text))
                cmd.Parameters.AddWithValue("@ManualDeduction", If(String.IsNullOrEmpty(txtManualDeduction.Text), DBNull.Value, txtManualDeduction.Text))
                cmd.Parameters.AddWithValue("@AttendanceCode", If(String.IsNullOrEmpty(txtAttendanceCode.Text), DBNull.Value, txtAttendanceCode.Text))
                cmd.Parameters.AddWithValue("@AttendanceID", attendanceID)
                conn.Open()
                cmd.ExecuteNonQuery()
            End Using
        End Using
        Me.DialogResult = DialogResult.OK
            Me.Close()
        End Sub

End Class
