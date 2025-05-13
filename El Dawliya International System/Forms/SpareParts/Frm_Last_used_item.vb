Imports System.Data.SqlClient
Imports El_Dawliya_International_System.El_Dawliya_International_System.Forms.Report

Public Class Frm_Last_used_item
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Public dt_Products As New DataTable


    Private Sub btn_UpdateStatus_Click(sender As Object, e As EventArgs) Handles btn_UpdateStatus.Click
        Me.Close()
    End Sub

    Private Sub Frm_Last_used_item_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomizeForm(Me)
        SelectAll_ProductsALL(dgv_Last_used_item)
        BindingSource1.DataSource = dt_Products.DefaultView
    End Sub

    Public Sub SelectAll_ProductsALL(dgv As DataGridView)
        Dim da As New SqlDataAdapter
        dt_Products.Clear()
        da = New SqlDataAdapter("SELECT 
        p.Product_ID, 
        p.Product_Name, 
        p.QTE_IN_STOCK,
        CASE 
        WHEN (SELECT MAX(t.Invoice_Date) 
              FROM Tbl_InvoiceItems t 
              WHERE t.Product_ID = p.Product_ID) IS NULL 
        THEN 'لم يتم استخدامه إلى الآن'
        ELSE CONVERT(VARCHAR, (SELECT MAX(t.Invoice_Date) 
                               FROM Tbl_InvoiceItems t 
                               WHERE t.Product_ID = p.Product_ID), 120)
            END AS Last_Operation
        FROM Tbl_Products p
        LEFT JOIN Tbl_InvoiceItems t
        ON p.Product_ID = t.Product_ID
        AND t.Invoice_Date >= DATEADD(MONTH, -3, GETDATE())
        WHERE t.Product_ID IS NULL;
        ", Con)
        da.Fill(dt_Products)
        dt_Products.Columns("Product_ID").SetOrdinal(0)
        dt_Products.Columns("Product_Name").SetOrdinal(1)
        dt_Products.Columns("Last_Operation").SetOrdinal(2)
        dt_Products.Columns("QTE_IN_STOCK").SetOrdinal(3)
        dgv.DataSource = dt_Products
        With dgv
            .Columns("Product_ID").HeaderText = "كود الصنف"
            .Columns("Product_Name").Width = 250
            .Columns("Product_Name").HeaderText = "اسم الصنف"
            .Columns("Product_Name").Width = 500
            .Columns("QTE_IN_STOCK").HeaderText = "الرصيد الحالى"
            .Columns("Product_Name").Width = 250
            .Columns("Last_Operation").HeaderText = "تاريخ اخر عملية تمت"
            .Columns("Product_Name").Width = 250
            '.Columns("IMAGE_PRODUCT").HeaderText = "صورة الصنف"
        End With
        lbl_TaskCount.Text = dgv_Last_used_item.RowCount.ToString()
    End Sub
    Private Sub dgv_Last_used_item_FilterStringChanged(sender As Object, e As EventArgs) Handles dgv_Last_used_item.FilterStringChanged
        BindingSource1.Filter = dgv_Last_used_item.FilterString
        dgv_Last_used_item.DataSource = BindingSource1
        lbl_TaskCount.Text = dgv_Last_used_item.RowCount.ToString()
    End Sub

    Private Sub dgv_Last_used_item_SortStringChanged(sender As Object, e As EventArgs) Handles dgv_Last_used_item.SortStringChanged
        BindingSource1.Sort = dgv_Last_used_item.SortString
        dgv_Last_used_item.DataSource = BindingSource1
        lbl_TaskCount.Text = dgv_Last_used_item.RowCount.ToString()
    End Sub

    Private Sub btn_Print_Report_Click(sender As Object, e As EventArgs) Handles btn_Print_Report.Click
        Dim rep As New Rep_Last_used_item
        rep.SetDataSource(dt_Products.DefaultView)
        Frm_Report.CrystalReportViewer1.ReportSource = rep
        Frm_Report.CrystalReportViewer1.Refresh()
        Frm_Report.ShowDialog()
    End Sub
End Class