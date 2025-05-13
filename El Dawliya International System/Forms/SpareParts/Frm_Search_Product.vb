Imports System.Data.SqlClient

Public Class Frm_Search_Product
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Public dt_Products As New DataTable

    Private Sub Frm_Search_Product_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SelectAll_ProductsALL(dgv_Products)
        Lbl_Count_Product.Text = dgv_Products.Rows.Count.ToString()
        GotFoucs_LostFocus_For_Control_On_Panal(Panel4)
        BindingSource1.DataSource = dt_Products.DefaultView
    End Sub

    Public Sub SelectAll_ProductsALL(dgv As DataGridView)
        Dim da As New SqlDataAdapter
        dt_Products.Clear()
        da = New SqlDataAdapter("SELECT * FROM Tbl_Products", Con)
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
        With dgv
            .Columns("Product_ID").HeaderText = "كود الصنف"
            .Columns("Product_Name").HeaderText = "اسم الصنف"
            .Columns("Product_Name").Width = 390
            .Columns("Initial_Balance").HeaderText = "رصيد بداية المدة"
            '.Columns("Initial_Balance").Visible = False
            .Columns("ElWarad").HeaderText = "الوراد"
            .Columns("ElWarad").Visible = False
            .Columns("MortagaaOmalaa").HeaderText = "مرتجع العملاء"
            .Columns("MortagaaOmalaa").Visible = False
            .Columns("ElMonsarf").HeaderText = "المنصرف"
            .Columns("ElMonsarf").Visible = False
            .Columns("MortagaaElMawarden").HeaderText = "مرتجع الموردين"
            .Columns("MortagaaElMawarden").Visible = False
            .Columns("QTE_IN_STOCK").HeaderText = "الرصيد الحالى"
            '.Columns("QTE_IN_STOCK").Visible = False
            .Columns("IMAGE_PRODUCT").HeaderText = "IMAGE_PRODUCT"
            .Columns("IMAGE_PRODUCT").Visible = False
            .Columns("Unit_Price").HeaderText = "Unit_Price"
            .Columns("Unit_Price").Visible = False
            .Columns("CAT_ID").HeaderText = "كود التصنيف"
            .Columns("CAT_ID").Visible = False
            .Columns("CAT_Name").HeaderText = "اسم التصنيف"
            .Columns("CAT_Name").Visible = False
            .Columns("Unit_ID").HeaderText = "كود الوحدة"
            .Columns("Unit_ID").Visible = False
            .Columns("Unit_Name").HeaderText = "الوحدة"
            .Columns("Unit_Name").Visible = False
            .Columns("Minimum_Threshold").HeaderText = "اقل رصيد"
            .Columns("Minimum_Threshold").Visible = False
            .Columns("Maximum_Threshold").HeaderText = "اكبر رصيد"
            .Columns("Maximum_Threshold").Visible = False
            .Columns("Location").HeaderText = "التواجد"
            .Columns("Expiry_Warning").HeaderText = "يظهر فى التنبيهات"
            .Columns("Expiry_Warning").Visible = False
        End With
    End Sub

    Private Sub Txt_Search_TextChanged(sender As Object, e As EventArgs) Handles Txt_Search.TextChanged
        Try
            Dim dv As DataView = dt_Products.DefaultView
            Select Case True
                Case Me.Radio_Product_ID.Checked
                    dv.RowFilter = If(Txt_Search.Text = "", "", "Product_ID = '" & Txt_Search.Text & "'")
                Case Me.Radio_Product_Name.Checked
                    dv.RowFilter = " Product_Name LIKE '%" & Txt_Search.Text & "%' "
                Case Me.Radio_CAT_Name.Checked
                    dv.RowFilter = " CAT_Name LIKE '%" & Txt_Search.Text & "%' "
            End Select
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
        Lbl_Count_Product.Text = dgv_Products.RowCount.ToString()
    End Sub

    Private Sub dgv_Products_FilterStringChanged(sender As Object, e As EventArgs) Handles dgv_Products.FilterStringChanged
        BindingSource1.Filter = dgv_Products.FilterString
        dgv_Products.DataSource = BindingSource1
    End Sub

    Private Sub DGV_Expiry_Notification_SortStringChanged(sender As Object, e As EventArgs) Handles dgv_Products.SortStringChanged
        BindingSource1.Sort = dgv_Products.SortString
        dgv_Products.DataSource = BindingSource1
    End Sub

End Class