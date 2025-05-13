Imports System.Data.SqlClient

Public Class EditTaskForm
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Private TaskID As Integer
    Private MeetingID As Integer

    Public Sub New(taskID As Integer, meetingID As Integer, currentAssignee As String, currentDueDate As Date)
        InitializeComponent()
        Me.TaskID = taskID
        Me.MeetingID = meetingID
        Due_Date.Value = currentDueDate
        FillEmployeeCombo()
        ' تحديد الموظف الحالي في القائمة
        For i As Integer = 0 To cmb_Employee.Items.Count - 1
            If cmb_Employee.GetItemText(cmb_Employee.Items(i)) = currentAssignee Then
                cmb_Employee.SelectedIndex = i
                Exit For
            End If
        Next
    End Sub

    Private Sub FillEmployeeCombo()
        Try
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter
            dt.Clear()
            ' جلب الموظفين الذين حضروا الاجتماع فقط
            da = New SqlDataAdapter("SELECT DISTINCT e.Emp_ID, e.Emp_Full_Name " &
                                  "FROM Tbl_Employee e " &
                                  "INNER JOIN Tbl_Meeting_Attendees ma ON e.Emp_ID = ma.Emp_ID " &
                                  "WHERE ma.Meeting_ID = @MeetingID AND e.Working_Condition = 'سارى'", Con)
            da.SelectCommand.Parameters.AddWithValue("@MeetingID", MeetingID)
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                With cmb_Employee
                    .DataSource = dt
                    .ValueMember = "Emp_ID"
                    .DisplayMember = "Emp_Full_Name"
                End With
            Else
                cmb_Employee.DataSource = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("حدث خطأ أثناء تحميل بيانات الموظفين: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        Try
            If cmb_Employee.SelectedValue Is Nothing Then
                MessageBox.Show("الرجاء اختيار الموظف المسند إليه المهمة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If Con.State = 1 Then Con.Close()
            Con.Open()

            ' تحديث بيانات المهمة
            Dim cmd As New SqlCommand("UPDATE Tbl_Meeting_Tasks " &
                                    "SET Assigned_To = @AssignedTo, Due_Date = @DueDate " &
                                    "WHERE Task_ID = @TaskID", Con)
            With cmd.Parameters
                .AddWithValue("@AssignedTo", cmb_Employee.SelectedValue)
                .AddWithValue("@DueDate", Due_Date.Value.Date)
                .AddWithValue("@TaskID", TaskID)
            End With

            cmd.ExecuteNonQuery()
            MessageBox.Show("تم تحديث بيانات المهمة بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DialogResult = DialogResult.OK
            Close()

        Catch ex As Exception
            MessageBox.Show("حدث خطأ أثناء تحديث بيانات المهمة: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If Con.State = ConnectionState.Open Then Con.Close()
        End Try
    End Sub

    Private Sub btn_Cancel_Click(sender As Object, e As EventArgs) Handles btn_Cancel.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub
End Class
