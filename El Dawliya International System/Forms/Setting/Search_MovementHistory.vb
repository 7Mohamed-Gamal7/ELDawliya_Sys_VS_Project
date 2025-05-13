Imports System.Data.SqlClient
Public Class Search_MovementHistory
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Public dt_MovementHistory As New DataTable

    Public Sub ClearControls()
        Me.MovementID.Text = vbNullString
        Me.MovementDescription.Text = vbNullString
        Me.MovementDate.Value = Today
        Me.PerformedBy.Text = vbNullString
        Me.DeviceName.Text = vbNullString
        Me.Frm_Name.Text = vbNullString
        Me.BTN.Text = vbNullString
    End Sub

    Private Sub dgv_MovementHistory_FilterStringChanged(sender As Object, e As EventArgs) Handles dgv_MovementHistory.FilterStringChanged
        BindingSource1.Filter = dgv_MovementHistory.FilterString
        dgv_MovementHistory.DataSource = BindingSource1
    End Sub

    Private Sub dgv_MovementHistory_SortStringChanged(sender As Object, e As EventArgs) Handles dgv_MovementHistory.SortStringChanged
        BindingSource1.Sort = dgv_MovementHistory.SortString
        dgv_MovementHistory.DataSource = BindingSource1
    End Sub

    Public Sub SelectAll_MovementHistory(dgv As DataGridView)
        Dim da As New SqlDataAdapter
        dt_MovementHistory.Clear()
        da = New SqlDataAdapter("Select * from Search_MovementHistory", Con)
        da.Fill(dt_MovementHistory)
        dgv.DataSource = dt_MovementHistory

        dgv.Columns("الوصف").AutoSizeMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub


    Private Sub Search_MovementHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearControls()
        SelectAll_MovementHistory(dgv_MovementHistory)
        BindingSource1.DataSource = dt_MovementHistory.DefaultView
    End Sub

    Private Sub Txt_Search_TextChanged(sender As Object, e As EventArgs) Handles Txt_Search.TextChanged
        Try
            Dim dv As DataView = dt_MovementHistory.DefaultView
            Select Case True
                Case Me.Radio_PerformedBy.Checked
                    dv.RowFilter = " [بواسطة] LIKE '%" & Txt_Search.Text & "%' "
                Case Me.Radio_Frm_Name.Checked
                    dv.RowFilter = " [اسم الشاشة] LIKE '%" & Txt_Search.Text & "%' "
                Case Me.Radio_Btn.Checked
                    dv.RowFilter = " [الزر] LIKE '%" & Txt_Search.Text & "%' "
            End Select
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ClearControls()
        SelectAll_MovementHistory(dgv_MovementHistory)
    End Sub

    Private Sub dgv_MovementHistory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_MovementHistory.CellContentClick
        Try
            With dgv_MovementHistory
                Me.MovementID.Text = .CurrentRow.Cells("الكود").Value.ToString()
                Me.MovementDescription.Text = .CurrentRow.Cells("الوصف").Value.ToString()
                Me.MovementDate.Value = .CurrentRow.Cells("تاريخ الحركة").Value.ToString()
                Me.PerformedBy.Text = .CurrentRow.Cells("بواسطة").Value.ToString()
                Me.DeviceName.Text = .CurrentRow.Cells("اسم الجهاز").Value.ToString()
                Me.Frm_Name.Text = .CurrentRow.Cells("اسم الشاشة").Value.ToString()
                Me.BTN.Text = .CurrentRow.Cells("الزر").Value.ToString()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Dim saveDialog As New SaveFileDialog()
        saveDialog.Filter = "Excel Files|*.xlsx;*.xls"
        saveDialog.Title = "E:\El Dawliya International System\Excel"
        If saveDialog.ShowDialog() = DialogResult.OK Then
            Dim columnsToExport As New List(Of String)
            ' قائمة بأسماء الأعمدة التي تريد تصديرها
            ' اضف أسماء الأعمدة التي تريد تصديرها إلى القائمة
            columnsToExport.Add("الكود")
            columnsToExport.Add("الوصف")
            columnsToExport.Add("تاريخ الحركة")
            columnsToExport.Add("بواسطة")
            columnsToExport.Add("اسم الجهاز")
            columnsToExport.Add("اسم الشاشة")
            columnsToExport.Add("الزر")
            ' استدعاء الدالة ExportToExcel مع تمرير قائمة الأعمدة المرغوب تصديرها
            ExportToExcel(dgv_MovementHistory, saveDialog.FileName, columnsToExport)
        End If
    End Sub
End Class