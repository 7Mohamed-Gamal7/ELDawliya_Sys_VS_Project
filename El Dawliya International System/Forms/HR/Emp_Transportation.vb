Imports System.Data.SqlClient
Imports DocumentFormat.OpenXml.Wordprocessing
Public Class Emp_Transportation
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Dim currentID As Integer = -1
    Dim table As New DataTable()
    '================================================================================================
    Sub ClearFields()
        currentID = -1
        Txt_Adress_Period.Clear()
        cmbEmployees.SelectedIndex = -1
        txtAmount.Clear()
        txtRoute.Value = 1
        txtNotes.Clear()
        Txt_Total.Text = "0"
        dtpTransportDate.Value = DateTime.Now
    End Sub


    Private Sub TransportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadEmployees()
        LoadTransportData()
        dtpPeriodFrom.Value = DateTime.Now
        dtpPeriodTo.Value = DateTime.Now
        ' تحديد ترتيب الأعمدة باستخدام الاسم النصي
        Dim columnsOrder() As String = {"Transport_ID", "Emp_ID", "Emp_Full_Name"}
        For i As Integer = 0 To columnsOrder.Length - 1
            table.Columns(columnsOrder(i)).SetOrdinal(i)
        Next
        dgvTransport.DataSource = table
        With dgvTransport
            DataGridViewHeaderText(dgvTransport)
        End With
    End Sub

    Sub LoadEmployees()
        Using conn As New SqlConnection(ConStr)
            Dim query As String = "SELECT Emp_ID, Emp_Full_Name FROM Tbl_Employee Where Working_Condition = 'سارى'"
        Dim adapter As New SqlDataAdapter(query, conn)
            Dim table As New DataTable()
            adapter.Fill(table)
            cmbEmployees.DataSource = table
            cmbEmployees.DisplayMember = "Emp_Full_Name"
            cmbEmployees.ValueMember = "Emp_ID"
        End Using
    End Sub

    Sub LoadTransportData()
        Using conn As New SqlConnection(ConStr)
            Dim query As String = "SELECT t.*, e.Emp_Full_Name 
                                  FROM Transportation t
                                  INNER JOIN Tbl_Employee e ON t.Emp_ID = e.Emp_ID"
            Dim adapter As New SqlDataAdapter(query, conn)
            Dim table As New DataTable()
            adapter.Fill(table)
            dgvTransport.DataSource = table
        End Using
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            If Not ValidateInput() Then Return
            Using conn As New SqlConnection(ConStr)
                conn.Open()
                Dim query As String = "INSERT INTO Transportation 
                                    (Emp_ID, Transport_Date, Period_From, Period_To, Amount, Route,Adress_Period)
                                    VALUES (@empID, @date, @from, @to, @amount, @route,@Adress_Period)"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@empID", cmbEmployees.SelectedValue)
                    cmd.Parameters.AddWithValue("@date", dtpTransportDate.Value)
                    cmd.Parameters.AddWithValue("@from", dtpPeriodFrom.Value)
                    cmd.Parameters.AddWithValue("@to", dtpPeriodTo.Value)
                    cmd.Parameters.AddWithValue("@amount", Decimal.Parse(txtAmount.Text))
                    cmd.Parameters.AddWithValue("@route", Decimal.Parse(txtRoute.Text))
                    cmd.Parameters.AddWithValue("@Adress_Period", Txt_Adress_Period.Text)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            LoadTransportData()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub dgvTransport_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransport.CellClick
        If e.RowIndex >= 0 Then
            currentID = Integer.Parse(dgvTransport.Rows(e.RowIndex).Cells("Transport_ID").Value.ToString())
            cmbEmployees.SelectedValue = dgvTransport.Rows(e.RowIndex).Cells("Emp_ID").Value
            dtpTransportDate.Value = DateTime.Parse(dgvTransport.Rows(e.RowIndex).Cells("Transport_Date").Value.ToString())
            dtpPeriodFrom.Value = DateTime.Parse(dgvTransport.Rows(e.RowIndex).Cells("Period_From").Value.ToString())
            dtpPeriodTo.Value = DateTime.Parse(dgvTransport.Rows(e.RowIndex).Cells("Period_To").Value.ToString())
            txtAmount.Text = dgvTransport.Rows(e.RowIndex).Cells("Amount").Value.ToString()
            txtRoute.Text = dgvTransport.Rows(e.RowIndex).Cells("Route").Value.ToString()
            Txt_Adress_Period.Text = dgvTransport.Rows(e.RowIndex).Cells("Adress_Period").Value.ToString()
        End If
    End Sub

    Private Function ValidateInput() As Boolean
        If dtpPeriodFrom.Value > dtpPeriodTo.Value Then
            MessageBox.Show("تاريخ البداية يجب أن يكون قبل تاريخ النهاية")
            Return False
        End If
        If Not Decimal.TryParse(txtRoute.Text, Nothing) Then
            MessageBox.Show("عدد الرحلات يجب أن يكون رقماً")
            Return False
        End If
        Return True
    End Function

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If currentID = -1 Then Return

        If MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete",
                         MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                Using conn As New SqlConnection(ConStr)
                    conn.Open()
                    Dim query As String = "DELETE FROM Transportation WHERE Transport_ID = @id"
                    Using cmd As New SqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@id", currentID)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
                LoadTransportData()
                ClearFields()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnGenerateReport_Click(sender As Object, e As EventArgs) Handles btnGenerateReport.Click
        Try
            Using conn As New SqlConnection(ConStr)
                Dim query As String = "SELECT e.Emp_Full_Name, SUM(t.Amount) AS Total 
                                      FROM Transportation t
                                      INNER JOIN Tbl_Employee e ON t.Emp_ID = e.Emp_ID
                                      GROUP BY e.Emp_Full_Name"
                Dim adapter As New SqlDataAdapter(query, conn)
                Dim table As New DataTable()
                adapter.Fill(table)
                'ReportViewer.DataSource = table
                'ReportViewer.Refresh()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error generating report: " & ex.Message)
        End Try
    End Sub

    Private Sub Txt_Total_Click(sender As Object, e As EventArgs) Handles Txt_Total.Click
        Me.Txt_Total.Text = (Val(Me.txtAmount.Text) * Val(Me.txtRoute.Text)).ToString
    End Sub

    Public Sub DataGridViewHeaderText(ByVal DGV As DataGridView)
        If DGV.RowCount > 0 Then
            With DGV
                .Columns("Transport_ID").HeaderText = "كود المواصلات"
                .Columns("Transport_ID").Visible = False
                .Columns("Emp_ID").HeaderText = "كود الموظف"
                .Columns("Emp_ID").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns("Adress_Period").HeaderText = "عنوان الفترة"
                .Columns("Adress_Period").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns("Transport_Date").HeaderText = "تاريخ المواصلات"
                .Columns("Transport_Date").Width = 100
                .Columns("Period_From").HeaderText = "بداية الفترة"
                .Columns("Period_From").Width = 100
                .Columns("Period_To").HeaderText = "نهاية الفترة"
                .Columns("Period_To").Width = 100
                .Columns("Transport_Type").HeaderText = "نوع المواصلات"
                .Columns("Transport_Type").Width = 100
                .Columns("Amount").HeaderText = "القيمة"
                .Columns("Amount").Width = 100
                .Columns("Route").HeaderText = "العدد"
                .Columns("Route").Width = 100
                .Columns("Total").HeaderText = "المجموع"
                .Columns("Total").Width = 100
                .Columns("Notes").HeaderText = "ملاحظات"
                .Columns("Notes").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                .Columns("Emp_Full_Name").HeaderText = "اسم الموظف"
                .Columns("Emp_Full_Name").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill

            End With
        End If
    End Sub



End Class