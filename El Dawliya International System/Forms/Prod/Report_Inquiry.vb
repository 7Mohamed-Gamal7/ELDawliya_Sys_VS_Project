Imports System.Data.SqlClient
Imports El_Dawliya_International_System.El_Dawliya_International_System.Forms.Report

Public Class Report_Inquiry
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Public dt_Problems As New DataTable

    Public Sub SelectFilteredProblems(dgv As DataGridView, Dept_Code As Object, MachineID As Object, ReportDate As Object)
        ' إنشاء استعلام SQL مع المعلمات
        Dim query As String = "
                   SELECT 
                dbo.Problems.*, 
                dbo.ProblemParticipants.ProblemParticipantID,
                dbo.ProblemParticipants.Emp_ID,
                dbo.Reports_Machine_Problems.ReportTitle,
                dbo.Reports_Machine_Problems.Report_Writer,
                dbo.Tbl_Department.Dept_Name,
                dbo.Tbl_Employee.Emp_Full_Name
            FROM 
                dbo.Machine 
            INNER JOIN
                dbo.Problems ON dbo.Machine.MachineID = dbo.Problems.MachineID 
            INNER JOIN
                dbo.ProblemParticipants ON dbo.Problems.ProblemID = dbo.ProblemParticipants.ProblemID 
            INNER JOIN
                dbo.Tbl_Department ON dbo.Problems.Dept_Code = dbo.Tbl_Department.Dept_Code
            INNER JOIN
                dbo.Reports_Machine_Problems ON dbo.Problems.ReportID = dbo.Reports_Machine_Problems.ReportID
            INNER JOIN
                dbo.Tbl_Employee ON dbo.ProblemParticipants.Emp_ID = dbo.Tbl_Employee.Emp_ID
        WHERE 
            (@Dept_Code IS NULL OR dbo.Problems.Dept_Code = @Dept_Code) 
            AND (@MachineID IS NULL OR dbo.Problems.MachineID = @MachineID)
            AND (@ReportDate IS NULL OR dbo.Problems.ProblemDate = @ReportDate);"

        ' التحقق من حالة الاتصال
        If Con.State = ConnectionState.Closed Then
            Con.Open()
        End If

        ' إنشاء SqlCommand وربط المعلمات
        Dim cmd As New SqlCommand(query, Con)
        cmd.Parameters.AddWithValue("@Dept_Code", If(Dept_Code Is Nothing OrElse Dept_Code.ToString() = "", DBNull.Value, Dept_Code))
        cmd.Parameters.AddWithValue("@MachineID", If(MachineID Is Nothing OrElse MachineID.ToString() = "", DBNull.Value, MachineID))
        cmd.Parameters.AddWithValue("@ReportDate", If(ReportDate Is Nothing, DBNull.Value, CType(ReportDate, DateTime).ToString("yyyy-MM-dd")))
        ' إنشاء SqlDataAdapter لملء البيانات
        Dim da As New SqlDataAdapter(cmd)
        ' مسح وإعادة ملء DataTable
        dt_Problems.Clear()
        da.Fill(dt_Problems)
        Dim columnsOrder() As String = {"ReportID", "ReportTitle", "ProblemID", "ProblemDescription", "ProblemDate", "Emp_Full_Name", "MachineID", "Dept_Code", "Dept_Name", "Report_Writer"}
        For i As Integer = 0 To columnsOrder.Length - 1
            dt_Problems.Columns(columnsOrder(i)).SetOrdinal(i)
        Next

        ' ربط DataTable بـ DataGridView
        dgv.DataSource = dt_Problems
        With dgv
            .Columns("ProblemID").HeaderText = "رقم المشكلة"
            .Columns("ProblemID").Width = 100

            .Columns("ProblemDescription").HeaderText = "وصف المشكلة"
            .Columns("ProblemDescription").Width = 600

            .Columns("ProblemDate").HeaderText = "تاريخ المشكلة"
            .Columns("ProblemDate").Visible = False

            .Columns("MachineID").HeaderText = "رقم الماكينة"
            .Columns("MachineID").Visible = False

            .Columns("ReportID").HeaderText = "رقم التقرير"
            .Columns("ReportID").Width = 100

            .Columns("ReportTitle").HeaderText = "عنوان التقرير"
            .Columns("ReportTitle").Width = 300

            .Columns("Dept_Code").HeaderText = "كود القسم"
            .Columns("Dept_Code").Visible = False

            .Columns("Dept_Name").HeaderText = "اسم القسم"
            .Columns("Dept_Name").Visible = False

            .Columns("Report_Writer").HeaderText = "كاتب التقرير"
            .Columns("Report_Writer").Visible = False

            .Columns("Emp_ID").HeaderText = " كود الموظف"
            .Columns("Emp_ID").Visible = False

            .Columns("Emp_Full_Name").HeaderText = " اسم الموظف"
            .Columns("Emp_Full_Name").Width = 400

            .Columns("ProblemParticipantID").HeaderText = "كود المشارك"
            .Columns("ProblemParticipantID").Visible = False

        End With
    End Sub

    Public Sub fillcmb_Machine(ByVal cmb As ComboBox)
        Dim DT As New DataTable
        Dim DA As New SqlDataAdapter
        DT.Clear()
        DA = New SqlDataAdapter("Select * FROM Machine ", Con)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            cmb.DataSource = DT
            cmb.ValueMember = "MachineID"
            cmb.DisplayMember = "MachineName"
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
        Else
            cmb.DataSource = Nothing
        End If
    End Sub

    Private Sub Report_Inquiry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyPermissions(Me.Name)
        CustomizeForm(Me)
        fillcmb_Machine(MachineID)
        fillcmb_Tbl_Department(Dept_Code)
    End Sub

    Private Sub Btn_Edit_Click(sender As Object, e As EventArgs) Handles Btn_Fetch_Data.Click
        Try
            SelectFilteredProblems(dgv_Report_Inquiry, Dept_Code.SelectedValue, MachineID.SelectedValue, ReportDate.Value)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btn_Print_Click(sender As Object, e As EventArgs) Handles btn_Print.Click
        Dim rep As New Reports_Machine_Problems
        rep.SetDataSource(dt_Problems.DefaultView)
        'rep.Section2.SectionFormat.BackgroundColor = Color.FromArgb(0, 167, 131)
        Frm_Report.CrystalReportViewer1.ReportSource = rep
        Frm_Report.CrystalReportViewer1.Refresh()
        Frm_Report.ShowDialog()
    End Sub
End Class







