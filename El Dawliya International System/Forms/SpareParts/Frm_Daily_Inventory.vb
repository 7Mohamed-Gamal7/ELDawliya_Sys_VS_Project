Imports System.Data.SqlClient

Public Class Frm_Daily_Inventory
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Public dt_Products As New DataTable
    Public Sub SelectAll_Products(dgv As DataGridView)
        Dim da As New SqlDataAdapter
        dt_Products.Clear()
        ' استدعاء الإجراء المخزن بدلاً من الاستعلام المباشر
        Dim cmd As New SqlCommand("GetAllProducts_SpareParts", Con)
        cmd.CommandType = CommandType.StoredProcedure
        da.SelectCommand = cmd
        da.Fill(dt_Products)
        dt_Products.Columns("Product_ID").SetOrdinal(0)
        dt_Products.Columns("Product_Name").SetOrdinal(1)
        dt_Products.Columns("Initial_Balance").SetOrdinal(2)
        dt_Products.Columns("ElWarad").SetOrdinal(3)
        dt_Products.Columns("MortagaaOmalaa").SetOrdinal(4)
        dt_Products.Columns("ElMonsarf").SetOrdinal(5)
        dt_Products.Columns("MortagaaElMawarden").SetOrdinal(6)
        dt_Products.Columns("QTE_IN_STOCK").SetOrdinal(7)
        dt_Products.Columns("IMAGE_PRODUCT").SetOrdinal(8)
        dt_Products.Columns("Unit_Price").SetOrdinal(9)
        dt_Products.Columns("CAT_ID").SetOrdinal(10)
        dt_Products.Columns("CAT_Name").SetOrdinal(11)
        dt_Products.Columns("Unit_ID").SetOrdinal(12)
        dt_Products.Columns("Unit_Name").SetOrdinal(13)
        dt_Products.Columns("Minimum_Threshold").SetOrdinal(14)
        dt_Products.Columns("Maximum_Threshold").SetOrdinal(15)
        dt_Products.Columns("Location").SetOrdinal(16)

        dgv.DataSource = dt_Products
        ' تعيين اسماء الأعمدة باللغة العربية
        With dgv
            .Columns("Product_ID").HeaderText = "كود الصنف"
            .Columns("Product_Name").HeaderText = "اسم الصنف"
            .Columns("Product_Name").Width = 300
            .Columns("Initial_Balance").HeaderText = "رصيد بداية المدة"
            .Columns("ElWarad").HeaderText = "الوراد"
            .Columns("MortagaaOmalaa").HeaderText = "مرتجع العملاء"
            .Columns("ElMonsarf").HeaderText = "المنصرف"
            .Columns("MortagaaElMawarden").HeaderText = "مرتجع الموردين"
            .Columns("QTE_IN_STOCK").HeaderText = "الرصيد الحالى"
            .Columns("IMAGE_PRODUCT").HeaderText = "صورة الصنف"
            .Columns("IMAGE_PRODUCT").Visible = False
            .Columns("Unit_Price").HeaderText = "سعر الصنف"
            .Columns("Unit_Price").Visible = False
            .Columns("CAT_ID").HeaderText = "كود التصنيف"
            .Columns("CAT_ID").Visible = False
            .Columns("CAT_Name").HeaderText = "اسم التصنيف"
            .Columns("Unit_ID").HeaderText = "كود الوحدة"
            .Columns("Unit_ID").Visible = False
            .Columns("Unit_Name").HeaderText = "الوحدة"
            .Columns("Minimum_Threshold").HeaderText = "اقل رصيد"
            .Columns("Maximum_Threshold").HeaderText = "اكبر رصيد"
            .Columns("Location").HeaderText = "التواجد"
            .Columns("Expiry_Warning").HeaderText = "يظهر فى التنبيهات"
            .Columns("Expiry_Warning").Visible = False
        End With
    End Sub
    Private Sub Frm_Daily_Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindingSource1.DataSource = dt_Products.DefaultView
        SelectAll_Products(dgv_Products)
        Lbl_Count_Product.Text = dgv_Products.Rows.Count.ToString()
    End Sub

    Private Sub dgv_Products_FilterStringChanged(sender As Object, e As EventArgs) Handles dgv_Products.FilterStringChanged
        BindingSource1.Filter = dgv_Products.FilterString
        dgv_Products.DataSource = BindingSource1
    End Sub

    Private Sub dgv_Products_SortStringChanged(sender As Object, e As EventArgs) Handles dgv_Products.SortStringChanged
        BindingSource1.Sort = dgv_Products.SortString
        dgv_Products.DataSource = BindingSource1
    End Sub

    Private Sub BtnExport_Excel_Click(sender As Object, e As EventArgs) Handles BtnExport_Excel.Click
        Dim saveDialog As New SaveFileDialog()
        saveDialog.Filter = "Excel Files|*.xlsx;*.xls"
        saveDialog.Title = "E:\El Dawliya International System\Excel"
        If saveDialog.ShowDialog() = DialogResult.OK Then
            ProgressBar1.Visible = True
            TextBox1.Visible = True
            ' قائمة بأسماء الأعمدة التي تريد تصديرها
            Dim columnsToExport As New List(Of String)
            ' اضف أسماء الأعمدة التي تريد تصديرها إلى القائمة
            columnsToExport.Add("Product_ID")
            columnsToExport.Add("Product_Name")
            columnsToExport.Add("Initial_Balance")
            columnsToExport.Add("ElWarad")
            columnsToExport.Add("MortagaaOmalaa")
            columnsToExport.Add("ElMonsarf")
            columnsToExport.Add("MortagaaElMawarden")
            columnsToExport.Add("QTE_IN_STOCK")
            columnsToExport.Add("CAT_Name")
            columnsToExport.Add("Unit_Name")
            columnsToExport.Add("Minimum_Threshold")
            columnsToExport.Add("Maximum_Threshold")
            columnsToExport.Add("Location")
            ' استدعاء الدالة ExportToExcel مع تمرير قائمة الأعمدة المرغوب تصديرها
            ExportToExcel(dgv_Products, saveDialog.FileName, columnsToExport)
        End If
        ProgressBar1.Visible = False
        TextBox1.Visible = False
    End Sub


End Class