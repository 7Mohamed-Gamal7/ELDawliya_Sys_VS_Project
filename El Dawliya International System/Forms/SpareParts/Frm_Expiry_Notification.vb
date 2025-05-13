Imports System.Data.SqlClient
Imports El_Dawliya_International_System.El_Dawliya_International_System.Forms.Report

Public Class Frm_Expiry_Notification
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Public dt_Tbl_Products As New DataTable

    Public Sub SelectAll_Expiry_Notification(dgv As DataGridView)
        Dim da As New SqlDataAdapter
        dt_Tbl_Products.Clear()
        'da = New SqlDataAdapter("select * from Tbl_Products where Minimum_Threshold >= QTE_IN_STOCK", Con)
        da = New SqlDataAdapter("select * from Tbl_Products where Minimum_Threshold >= QTE_IN_STOCK  and Expiry_Warning ='نعم'", Con)
        da.Fill(dt_Tbl_Products)
        dt_Tbl_Products.Columns("Product_ID").SetOrdinal(0)
        dt_Tbl_Products.Columns("Product_Name").SetOrdinal(1)
        dt_Tbl_Products.Columns("Initial_Balance").SetOrdinal(2)
        dt_Tbl_Products.Columns("ElWarad").SetOrdinal(3)
        dt_Tbl_Products.Columns("MortagaaOmalaa").SetOrdinal(4)
        dt_Tbl_Products.Columns("ElMonsarf").SetOrdinal(5)
        dt_Tbl_Products.Columns("MortagaaElMawarden").SetOrdinal(6)
        dt_Tbl_Products.Columns("QTE_IN_STOCK").SetOrdinal(7)
        dt_Tbl_Products.Columns("IMAGE_PRODUCT").SetOrdinal(8)
        dt_Tbl_Products.Columns("Unit_Price").SetOrdinal(9)
        dt_Tbl_Products.Columns("CAT_ID").SetOrdinal(10)
        'dt_Tbl_Products.Columns("CAT_Name").SetOrdinal(11)
        dt_Tbl_Products.Columns("Unit_ID").SetOrdinal(11)
        'dt_Tbl_Products.Columns("Unit_Name").SetOrdinal(13)
        dt_Tbl_Products.Columns("Minimum_Threshold").SetOrdinal(12)
        dt_Tbl_Products.Columns("Maximum_Threshold").SetOrdinal(13)
        dt_Tbl_Products.Columns("Location").SetOrdinal(14)
        dgv.DataSource = dt_Tbl_Products
        With dgv
            '.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            '.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            .Columns("Product_ID").HeaderText = "كود الصنف"
            .Columns("Product_ID").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns("Product_Name").HeaderText = "اسم الصنف"
            .Columns("Product_Name").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns("Initial_Balance").HeaderText = "رصيد بداية المدة"
            .Columns("Initial_Balance").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns("ElWarad").HeaderText = "الوراد"
            .Columns("ElWarad").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns("MortagaaOmalaa").HeaderText = "مرتجع العملاء"
            .Columns("MortagaaOmalaa").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns("ElMonsarf").HeaderText = "المنصرف"
            .Columns("ElMonsarf").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns("MortagaaElMawarden").HeaderText = "مرتجع الموردين"
            .Columns("MortagaaElMawarden").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns("QTE_IN_STOCK").HeaderText = "الرصيد الحالى"
            .Columns("QTE_IN_STOCK").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns("IMAGE_PRODUCT").HeaderText = "IMAGE_PRODUCT"
            .Columns("IMAGE_PRODUCT").Visible = False
            .Columns("Unit_Price").HeaderText = "Unit_Price"
            .Columns("Unit_Price").Visible = False
            .Columns("CAT_ID").HeaderText = "كود التصنيف"
            .Columns("CAT_ID").Visible = False
            .Columns("CAT_Name").HeaderText = "اسم التصنيف"
            .Columns("CAT_Name").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns("Unit_ID").HeaderText = "كود الوحدة"
            .Columns("Unit_ID").Visible = False
            .Columns("Unit_Name").HeaderText = "الوحدة"
            .Columns("Unit_Name").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns("Minimum_Threshold").HeaderText = "اقل رصيد"
            .Columns("Minimum_Threshold").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns("Maximum_Threshold").HeaderText = "اكبر رصيد"
            .Columns("Maximum_Threshold").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            .Columns("Location").HeaderText = "التواجد"
            .Columns("Location").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        End With
    End Sub

    Private Sub Frm_Expiry_Notification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SelectAll_Expiry_Notification(DGV_Expiry_Notification)
        BindingSource1.DataSource = dt_Tbl_Products.DefaultView
        Lbl_Count_Product.Text = DGV_Expiry_Notification.Rows.Count.ToString()
    End Sub

    Private Sub FillReportAndPrint()
        Dim rep As New Rep_Expiry_Notification
        rep.SetDataSource(dt_Tbl_Products.DefaultView)
        rep.Section2.SectionFormat.BackgroundColor = Color.FromArgb(214, 219, 233)
        Frm_Report.CrystalReportViewer1.ReportSource = rep
        Frm_Report.CrystalReportViewer1.Refresh()
        Frm_Report.ShowDialog()
    End Sub

    Private Sub DGV_Expiry_Notification_FilterStringChanged(sender As Object, e As EventArgs) Handles DGV_Expiry_Notification.FilterStringChanged
        BindingSource1.Filter = DGV_Expiry_Notification.FilterString
        DGV_Expiry_Notification.DataSource = BindingSource1
    End Sub

    Private Sub DGV_Expiry_Notification_SortStringChanged(sender As Object, e As EventArgs) Handles DGV_Expiry_Notification.SortStringChanged
        BindingSource1.Sort = DGV_Expiry_Notification.SortString
        DGV_Expiry_Notification.DataSource = BindingSource1
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
        FillReportAndPrint()
    End Sub
End Class