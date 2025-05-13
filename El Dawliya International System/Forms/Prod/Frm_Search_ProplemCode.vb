Imports System.Data.SqlClient
Public Class Frm_Search_ProplemCode
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
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
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub RetrieveMachineProblems(ByVal Problem_Code As String)
        Using command As New SqlCommand("SelectAll_Tbl_MachineProblems_Time", Con)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@Problem_Code", Problem_Code)
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Try
                Dim reader As SqlDataReader = command.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read()
                        Txt_StopMachineTime.Text = reader("Machine_stop_time").ToString()
                        Txt_Who_identified_problem.Text = reader("PressedProductionButtonBy").ToString()
                        Txt_Time_identify_problem.Text = reader("PressProductionButtonTime").ToString()
                        Section_Production.Text = reader("Section_Production").ToString()
                        Machine_Name.Text = reader("Machine_Name").ToString()
                        Txt_Who_Note_writer.Text = reader("NotesAuthor_Production").ToString()
                        Txt_Machine_running_time.Text = reader("FinalMachineRunningTime").ToString()
                        Txt_Notes.Text = reader("ProductionNotes").ToString()
                        'TotalProblemTime.Text = reader("TotalProblemTime").ToString()
                        Txt_Unity_problem.Text = reader("BreakdownUnit_Production").ToString()
                        Txt_Part_problem.Text = reader("FailurePartForProduction").ToString()
                        Txt_Problem_status.Text = reader("ProductionFailureSituation").ToString()
                        Try
                            Dim totalTime As TimeSpan = TimeSpan.Zero
                            Dim timeValue As String = reader("TotalProblemTime").ToString()
                            ' قم بتحويل النص إلى DateTime
                            Dim dateTimeValue As DateTime
                            If DateTime.TryParse(timeValue, dateTimeValue) Then
                                ' قم بتحويل DateTime إلى TimeSpan وإضافته إلى المجموع
                                totalTime = totalTime.Add(dateTimeValue.TimeOfDay)
                            End If
                            TotalProblemTime.Text = dateTimeValue.ToString("HH\: mm\: ss")
                        Catch ex As FormatException
                            MessageBox.Show("قيمة الوقت غير صحيحة. يرجى التأكد من التنسيق الصحيح.")
                        End Try
                    End While
                Else
                    MessageBox.Show("لم يتم العثور على معلومات لهذا الموظف")
                End If
            Catch ex As Exception
                MessageBox.Show("خطأ: " & ex.Message)
            End Try
        End Using
        Con.Close()
    End Sub

    Private Sub Txt_Proplem_Code_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Proplem_Code.KeyDown
        ' التأكد من أن المفتاح المضغوط هو مفتاح Enter
        If e.KeyCode = Keys.Enter Then
            ' تنفيذ الكود لاسترداد بيانات الموظف
            RetrieveMachineProblems(Txt_Proplem_Code.Text)
        End If
    End Sub
End Class
