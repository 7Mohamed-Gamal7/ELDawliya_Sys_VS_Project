Imports System.Data.SqlClient
Imports System.IO
Imports El_Dawliya_International_System.El_Dawliya_International_System.Forms.Report

Public Class Frm_Printing_Items
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Public dt_Products As New DataTable
    Public dt_ForPrint As DataTable

    Private Sub dgv_Tbl_InvoiceItems_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Tbl_InvoiceItems.CellValueChanged
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = dgv_Tbl_InvoiceItems.Columns("DGV_Product_Name").Index Then
            Dim rowIndex As Integer = e.RowIndex
            If dgv_Tbl_InvoiceItems.Rows.Count > 0 AndAlso rowIndex <> dgv_Tbl_InvoiceItems.NewRowIndex Then
                If dgv_Tbl_InvoiceItems.Rows(rowIndex).Cells("DGV_Unit_Price").Value IsNot Nothing AndAlso dgv_Tbl_InvoiceItems.Rows(rowIndex).Cells("DGV_Product_Name").Value IsNot Nothing Then
                    Dim unitPrice As Double
                    Dim addBalance As Double
                    If Double.TryParse(dgv_Tbl_InvoiceItems.Rows(rowIndex).Cells("DGV_Unit_Price").Value.ToString(), unitPrice) AndAlso Double.TryParse(dgv_Tbl_InvoiceItems.Rows(rowIndex).Cells("DGV_Product_Name").Value.ToString(), addBalance) Then
                        dgv_Tbl_InvoiceItems.Rows(rowIndex).Cells("DGV_Total_Unit_Price").Value = unitPrice * addBalance
                        Dim totalInvoiceValue As Double = 0.0
                        For Each row As DataGridViewRow In dgv_Tbl_InvoiceItems.Rows
                            If Not row.IsNewRow Then
                                If row.Cells("DGV_Total_Unit_Price").Value IsNot Nothing Then
                                    Dim totalUnitPrice As Double
                                    If Double.TryParse(row.Cells("DGV_Total_Unit_Price").Value.ToString(), totalUnitPrice) Then
                                        totalInvoiceValue += totalUnitPrice
                                    Else
                                        ' في حالة وجود قيم غير صالحة، يمكنك اتخاذ إجراء مناسب هنا، مثل عرض رسالة خطأ
                                    End If
                                End If
                            End If
                        Next
                    Else
                        ' في حالة وجود قيم غير صالحة، يمكنك اتخاذ إجراء مناسب هنا، مثل عرض رسالة خطأ
                    End If
                End If
            End If
        End If
        NumberOfItems.Text = dgv_Tbl_InvoiceItems.Rows.Count - 1
    End Sub

    '''Private Sub dgv_Tbl_InvoiceItems_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Tbl_InvoiceItems.CellEndEdit
    '''    If e.ColumnIndex = dgv_Tbl_InvoiceItems.Columns("DGV_Product_ID").Index AndAlso e.RowIndex >= 0 Then
    '''        Dim selectedProduct As String = dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("DGV_Product_ID").Value.ToString()
    '''        dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("DGV_Product_ID").Value = selectedProduct
    '''        Dim query As String = "SELECT * FROM Tbl_Products WHERE Product_ID = @Product_ID "
    '''        'Dim query As String = "Select ROW_NUMBER() OVER (ORDER BY Product_ID) As SequenceNumber,* FROM  Tbl_Products WHERE Product_ID = @Product_ID "
    '''        Using con As New SqlConnection(ConStr),
    '''              Command As New SqlCommand(query, con)
    '''            Command.Parameters.AddWithValue("@Product_ID", selectedProduct)
    '''            Try
    '''                con.Open()
    '''                Dim reader As SqlDataReader = Command.ExecuteReader()
    '''                If reader.Read() Then
    '''                    'dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("DGV_SequenceNumber").Value = reader("SequenceNumber").ToString()
    '''                    dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("DGV_Product_Name").Value = reader("Product_Name").ToString()
    '''                    dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("DGV_QTE_IN_STOCK").Value = reader("QTE_IN_STOCK").ToString()
    '''                    dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("DGV_ID_CAT").Value = reader("CAT_Name").ToString()
    '''                    dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("DGV_Unit_ID").Value = reader("Unit_ID").ToString()
    '''                    dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("DGV_Unit_Name").Value = reader("Unit_Name").ToString()
    '''                    dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("DGV_Initial_Balance").Value = reader("Initial_Balance").ToString()
    '''                    dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("DGV_Unit_Price").Value = reader("Unit_Price").ToString()
    '''                    dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("DGV_Minimum_Threshold").Value = reader("Minimum_Threshold").ToString()
    '''                    dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("DGV_Maximum_Threshold").Value = reader("Maximum_Threshold").ToString()
    '''                    dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("DGV_Location").Value = reader("Location").ToString()
    '''                    dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("DGV_ElWarad").Value = reader("ElWarad").ToString()
    '''                    dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("DGV_MortagaaOmalaa").Value = reader("MortagaaOmalaa").ToString()
    '''                    dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("DGV_ElMonsarf").Value = reader("ElMonsarf").ToString()
    '''                    dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("DGV_MortagaaElMawarden").Value = reader("MortagaaElMawarden").ToString()
    '''                    Dim newRow As DataRow = dt_ForPrint.NewRow()
    '''                    newRow("Product_ID") = reader("Product_ID").ToString()
    '''                    newRow("Product_Name") = reader("Product_Name").ToString()
    '''                    newRow("QTE_IN_STOCK") = reader("QTE_IN_STOCK")
    '''                    newRow("CAT_Name") = reader("CAT_Name").ToString()
    '''                    newRow("Unit_ID") = reader("Unit_ID").ToString()
    '''                    newRow("Unit_Name") = reader("Unit_Name").ToString()
    '''                    newRow("Initial_Balance") = reader("Initial_Balance")
    '''                    newRow("Unit_Price") = reader("Unit_Price")
    '''                    newRow("Minimum_Threshold") = reader("Minimum_Threshold")
    '''                    newRow("Maximum_Threshold") = reader("Maximum_Threshold")
    '''                    newRow("Location") = reader("Location").ToString()
    '''                    newRow("ElWarad") = reader("ElWarad")
    '''                    newRow("MortagaaOmalaa") = reader("MortagaaOmalaa")
    '''                    newRow("ElMonsarf") = reader("ElMonsarf")
    '''                    newRow("MortagaaElMawarden") = reader("MortagaaElMawarden")
    '''                    dt_ForPrint.Rows.Add(newRow)
    '''                End If
    '''                reader.Close()
    '''            Catch ex As Exception
    '''                MessageBox.Show("حدث خطأ: " & ex.Message)
    '''            End Try
    '''        End Using
    '''    End If
    '''End Sub

    Private Sub dgv_Tbl_InvoiceItems_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Tbl_InvoiceItems.CellEndEdit
        If e.ColumnIndex = dgv_Tbl_InvoiceItems.Columns("DGV_Product_ID").Index AndAlso e.RowIndex >= 0 Then
            ' التحقق من أن القيمة في الخلية ليست Null أو فارغة
            Dim selectedProduct As Object = dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("DGV_Product_ID").Value
            If selectedProduct Is Nothing OrElse String.IsNullOrEmpty(selectedProduct.ToString()) Then
                Return ' الخروج من الإجراء إذا كانت القيمة Null أو فارغة
            End If

            Dim productID As String = selectedProduct.ToString()
            Dim query As String = "SELECT * FROM Tbl_Products WHERE Product_ID = @Product_ID"

            Using con As New SqlConnection(ConStr),
              Command As New SqlCommand(query, con)
                Command.Parameters.AddWithValue("@Product_ID", productID)
                Try
                    con.Open()
                    Dim reader As SqlDataReader = Command.ExecuteReader()
                    If reader.Read() Then
                        dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("DGV_Product_Name").Value = reader("Product_Name").ToString()
                        dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("DGV_QTE_IN_STOCK").Value = reader("QTE_IN_STOCK").ToString()
                        dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("DGV_ID_CAT").Value = reader("CAT_Name").ToString()
                        dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("DGV_Unit_ID").Value = reader("Unit_ID").ToString()
                        dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("DGV_Unit_Name").Value = reader("Unit_Name").ToString()
                        dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("DGV_Initial_Balance").Value = reader("Initial_Balance").ToString()
                        dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("DGV_Unit_Price").Value = reader("Unit_Price").ToString()
                        dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("DGV_Minimum_Threshold").Value = reader("Minimum_Threshold").ToString()
                        dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("DGV_Maximum_Threshold").Value = reader("Maximum_Threshold").ToString()
                        dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("DGV_Location").Value = reader("Location").ToString()
                        dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("DGV_ElWarad").Value = reader("ElWarad").ToString()
                        dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("DGV_MortagaaOmalaa").Value = reader("MortagaaOmalaa").ToString()
                        dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("DGV_ElMonsarf").Value = reader("ElMonsarf").ToString()
                        dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("DGV_MortagaaElMawarden").Value = reader("MortagaaElMawarden").ToString()
                        ' إضافة البيانات إلى DataTable

                        If Not dt_ForPrint.Columns.Contains("SequenceNumber") Then
                            dt_ForPrint.Columns.Add("SequenceNumber", GetType(Integer))
                        End If

                        Dim newRow As DataRow = dt_ForPrint.NewRow()

                        newRow("Product_ID") = reader("Product_ID").ToString()
                        newRow("Product_Name") = reader("Product_Name").ToString()
                        newRow("QTE_IN_STOCK") = reader("QTE_IN_STOCK")
                        newRow("CAT_Name") = reader("CAT_Name").ToString()
                        newRow("Unit_ID") = reader("Unit_ID").ToString()
                        newRow("Unit_Name") = reader("Unit_Name").ToString()
                        newRow("Initial_Balance") = reader("Initial_Balance")
                        newRow("Unit_Price") = reader("Unit_Price")
                        newRow("Minimum_Threshold") = reader("Minimum_Threshold")
                        newRow("Maximum_Threshold") = reader("Maximum_Threshold")
                        newRow("Location") = reader("Location").ToString()
                        newRow("ElWarad") = reader("ElWarad")
                        newRow("MortagaaOmalaa") = reader("MortagaaOmalaa")
                        newRow("ElMonsarf") = reader("ElMonsarf")
                        newRow("MortagaaElMawarden") = reader("MortagaaElMawarden")

                        newRow("SequenceNumber") = dt_ForPrint.Rows.Count + 1

                        dt_ForPrint.Rows.Add(newRow)
                        UpdateSequenceNumbers()


                    End If
                    reader.Close()
                Catch ex As Exception
                    MessageBox.Show("حدث خطأ: " & ex.Message)
                End Try
            End Using
        End If
    End Sub

    Private Sub Frm_Printing_Items_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '''SelectAll_ProductsALL(dgv_Products)
        GotFoucs_LostFocus_For_TextBoxes(Me)
        dt_ForPrint = New DataTable()
        dt_ForPrint.Columns.Add("Product_ID", GetType(String))
        dt_ForPrint.Columns.Add("Product_Name", GetType(String))
        dt_ForPrint.Columns.Add("QTE_IN_STOCK", GetType(Integer))
        dt_ForPrint.Columns.Add("CAT_Name", GetType(String))
        dt_ForPrint.Columns.Add("Unit_ID", GetType(String))
        dt_ForPrint.Columns.Add("Unit_Name", GetType(String))
        dt_ForPrint.Columns.Add("Initial_Balance", GetType(Decimal))
        dt_ForPrint.Columns.Add("Unit_Price", GetType(Decimal))
        dt_ForPrint.Columns.Add("Minimum_Threshold", GetType(Decimal))
        dt_ForPrint.Columns.Add("Maximum_Threshold", GetType(Decimal))
        dt_ForPrint.Columns.Add("Location", GetType(String))
        dt_ForPrint.Columns.Add("ElWarad", GetType(Decimal))
        dt_ForPrint.Columns.Add("MortagaaOmalaa", GetType(Decimal))
        dt_ForPrint.Columns.Add("ElMonsarf", GetType(Decimal))
        dt_ForPrint.Columns.Add("MortagaaElMawarden", GetType(Decimal))
    End Sub

    Public Sub SelectAll_ProductsALL(dgv As DataGridView)
        Dim da As New SqlDataAdapter
        dt_Products.Clear()

        da = New SqlDataAdapter("SELECT * FROM Tbl_Products", Con)
        'da = New SqlDataAdapter("Select ROW_NUMBER() OVER (ORDER BY Product_ID) As SequenceNumber,* FROM  Tbl_Products ", Con)

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
        dt_Products.Columns("Unit_Price").SetOrdinal(90)
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
            .Columns("Product_Name").Width = 220
            .Columns("Initial_Balance").HeaderText = "رصيد بداية المدة"
            .Columns("Initial_Balance").Visible = False
            .Columns("ElWarad").HeaderText = "الوراد"
            .Columns("ElWarad").Visible = False
            .Columns("MortagaaOmalaa").HeaderText = "مرتجع العملاء"
            .Columns("MortagaaOmalaa").Visible = False
            .Columns("ElMonsarf").HeaderText = "المنصرف"
            .Columns("ElMonsarf").Visible = False
            .Columns("MortagaaElMawarden").HeaderText = "مرتجع الموردين"
            .Columns("MortagaaElMawarden").Visible = False
            .Columns("QTE_IN_STOCK").HeaderText = "الرصيد الحالى"
            .Columns("QTE_IN_STOCK").Visible = False
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
        End With
    End Sub

    Private Sub SyncDataTableWithDataGridView()
        ' مسح جميع الصفوف من DataTable
        dt_ForPrint.Rows.Clear()

        ' إعادة إضافة الصفوف الحالية من DataGridView إلى DataTable
        For Each row As DataGridViewRow In dgv_Tbl_InvoiceItems.Rows
            If Not row.IsNewRow Then
                Dim newRow As DataRow = dt_ForPrint.NewRow()

                ' تأكد من أن القيم ليست فارغة قبل تعيينها
                newRow("Product_ID") = If(row.Cells("DGV_Product_ID").Value?.ToString(), "")
                newRow("Product_Name") = If(row.Cells("DGV_Product_Name").Value?.ToString(), "")

                ' تحويل القيم الرقمية مع التحقق
                Dim qteInStock As Integer
                If Integer.TryParse(row.Cells("DGV_QTE_IN_STOCK").Value?.ToString(), qteInStock) Then
                    newRow("QTE_IN_STOCK") = qteInStock
                Else
                    newRow("QTE_IN_STOCK") = 0 ' أو أي قيمة افتراضية تناسبك
                End If

                newRow("CAT_Name") = If(row.Cells("DGV_ID_CAT").Value?.ToString(), "")
                newRow("Unit_ID") = If(row.Cells("DGV_Unit_ID").Value?.ToString(), "")
                newRow("Unit_Name") = If(row.Cells("DGV_Unit_Name").Value?.ToString(), "")

                ' تحويل القيم الرقمية مع التحقق
                Dim initialBalance As Decimal
                If Decimal.TryParse(row.Cells("DGV_Initial_Balance").Value?.ToString(), initialBalance) Then
                    newRow("Initial_Balance") = initialBalance
                Else
                    newRow("Initial_Balance") = 0 ' أو أي قيمة افتراضية تناسبك
                End If

                Dim unitPrice As Decimal
                If Decimal.TryParse(row.Cells("DGV_Unit_Price").Value?.ToString(), unitPrice) Then
                    newRow("Unit_Price") = unitPrice
                Else
                    newRow("Unit_Price") = 0 ' أو أي قيمة افتراضية تناسبك
                End If

                Dim minThreshold As Decimal
                If Decimal.TryParse(row.Cells("DGV_Minimum_Threshold").Value?.ToString(), minThreshold) Then
                    newRow("Minimum_Threshold") = minThreshold
                Else
                    newRow("Minimum_Threshold") = 0 ' أو أي قيمة افتراضية تناسبك
                End If

                Dim maxThreshold As Decimal
                If Decimal.TryParse(row.Cells("DGV_Maximum_Threshold").Value?.ToString(), maxThreshold) Then
                    newRow("Maximum_Threshold") = maxThreshold
                Else
                    newRow("Maximum_Threshold") = 0 ' أو أي قيمة افتراضية تناسبك
                End If

                newRow("Location") = If(row.Cells("DGV_Location").Value?.ToString(), "")

                Dim elWarad As Decimal
                If Decimal.TryParse(row.Cells("DGV_ElWarad").Value?.ToString(), elWarad) Then
                    newRow("ElWarad") = elWarad
                Else
                    newRow("ElWarad") = 0 ' أو أي قيمة افتراضية تناسبك
                End If

                Dim mortagaaOmalaa As Decimal
                If Decimal.TryParse(row.Cells("DGV_MortagaaOmalaa").Value?.ToString(), mortagaaOmalaa) Then
                    newRow("MortagaaOmalaa") = mortagaaOmalaa
                Else
                    newRow("MortagaaOmalaa") = 0 ' أو أي قيمة افتراضية تناسبك
                End If

                Dim elMonsarf As Decimal
                If Decimal.TryParse(row.Cells("DGV_ElMonsarf").Value?.ToString(), elMonsarf) Then
                    newRow("ElMonsarf") = elMonsarf
                Else
                    newRow("ElMonsarf") = 0 ' أو أي قيمة افتراضية تناسبك
                End If

                Dim mortagaaElMawarden As Decimal
                If Decimal.TryParse(row.Cells("DGV_MortagaaElMawarden").Value?.ToString(), mortagaaElMawarden) Then
                    newRow("MortagaaElMawarden") = mortagaaElMawarden
                Else
                    newRow("MortagaaElMawarden") = 0 ' أو أي قيمة افتراضية تناسبك
                End If

                dt_ForPrint.Rows.Add(newRow)
                UpdateSequenceNumbers()
            End If
        Next
    End Sub

    Private Sub dgv_Tbl_InvoiceItems_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgv_Tbl_InvoiceItems.RowsRemoved
        SyncDataTableWithDataGridView()
        UpdateSequenceNumbers()
        NumberOfItems.Text = dgv_Tbl_InvoiceItems.Rows.Count - 1
    End Sub
    Private Sub UpdateSequenceNumbers()
        Dim sequence As Integer = 1
        For Each row As DataRow In dt_ForPrint.Rows
            row("SequenceNumber") = sequence
            sequence += 1
        Next
    End Sub

    Private Sub BtnNewAdd_Click(sender As Object, e As EventArgs) Handles BtnNewAdd.Click
        dgv_Tbl_InvoiceItems.Rows.Clear()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If Me.dgv_Tbl_InvoiceItems.Rows.Count = 1 Then
            MsgBox("لا يوجد بيان لحذفه")
        Else
            Dim newrow As Integer
            Dim index As Integer
            newrow = dgv_Tbl_InvoiceItems.NewRowIndex
            index = dgv_Tbl_InvoiceItems.CurrentCell.RowIndex
            If newrow = index Then
                MsgBox("لا يمكن حذف ذلك السطر ")
            Else
                dgv_Tbl_InvoiceItems.Rows.RemoveAt(index)
            End If
        End If
        SyncDataTableWithDataGridView()
    End Sub

    Private Sub Btn_Export_Excel_Click(sender As Object, e As EventArgs) Handles Btn_Export_Excel.Click

        Dim saveDialog As New SaveFileDialog()
        saveDialog.Filter = "Excel Files|*.xlsx;*.xls"
        saveDialog.Title = "E:\El Dawliya International System\Excel"
        If saveDialog.ShowDialog() = DialogResult.OK Then
            ' قائمة بأسماء الأعمدة التي تريد تصديرها
            Dim columnsToExport As New List(Of String)
            ' اضف أسماء الأعمدة التي تريد تصديرها إلى القائمة
            columnsToExport.Add("DGV_Product_ID")
            columnsToExport.Add("DGV_Product_Name")
            columnsToExport.Add("DGV_Initial_Balance")
            columnsToExport.Add("DGV_ElWarad")
            columnsToExport.Add("DGV_MortagaaOmalaa")
            columnsToExport.Add("DGV_ElMonsarf")
            columnsToExport.Add("DGV_MortagaaElMawarden")
            columnsToExport.Add("DGV_QTE_IN_STOCK")
            'columnsToExport.Add("DGV_CAT_Name")
            columnsToExport.Add("DGV_Unit_Name")
            columnsToExport.Add("DGV_Minimum_Threshold")
            columnsToExport.Add("DGV_Maximum_Threshold")
            columnsToExport.Add("DGV_Location")
            ' استدعاء الدالة ExportToExcel مع تمرير قائمة الأعمدة المرغوب تصديرها
            ExportToExcel(dgv_Tbl_InvoiceItems, saveDialog.FileName, columnsToExport)
        End If

    End Sub

    Private Sub btn_Report_Click(sender As Object, e As EventArgs) Handles btn_Report.Click
        ' إعداد التقرير
        Dim rep As New Rep_Printing_Items
        rep.SetDataSource(dt_ForPrint.DefaultView)
        ' عرض التقرير
        Frm_Report.CrystalReportViewer1.ReportSource = rep
        Frm_Report.CrystalReportViewer1.Refresh()
        Frm_Report.ShowDialog()
    End Sub

    Private Sub Btn_Sreach_Product_Click(sender As Object, e As EventArgs) Handles Btn_Sreach_Product.Click
        Frm_Search_Product.Show()
    End Sub

    Private Sub Btn_Add_Group_Code_Click(sender As Object, e As EventArgs) Handles Btn_Add_Group_Code.Click
        ' إنشاء مربع حوار OpenFileDialog
        Dim openFileDialog As New OpenFileDialog()
        ' تحديد نوع الملفات المسموح بها
        openFileDialog.Filter = "ملفات النص (*.txt)|*.txt|جميع الملفات (*.*)|*.*"
        ' عرض مربع حوار OpenFileDialog والتأكد من أن المستخدم قام بتحديد ملف
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' فتح الملف للقراءة
            Using reader As New StreamReader(openFileDialog.FileName)
                Dim line As String
                Do
                    line = reader.ReadLine()
                    If line IsNot Nothing Then
                        ' إضافة الكود إلى العمود DGV_Product_ID في DataGridView
                        Dim rowIndex As Integer = dgv_Tbl_InvoiceItems.Rows.Add(line)
                        ' تحديث بيانات المنتج للصف الذي تم إضافته مؤخرًا
                        UpdateProductDataForRow(rowIndex)
                    End If
                Loop Until line Is Nothing
            End Using
        End If
    End Sub

    Public Sub UpdateProductDataForRow(rowIndex As Integer)
        Try
            ' الحصول على الكود الموجود في الصف الجديد
            Dim selectedProduct As String = dgv_Tbl_InvoiceItems.Rows(rowIndex).Cells("DGV_Product_ID").Value.ToString()
            ' استعلام قاعدة البيانات للحصول على بيانات المنتج
            Dim query As String = "SELECT * FROM Tbl_Products WHERE Product_ID = @Product_ID "
            Using con As New SqlConnection(ConStr),
              Command As New SqlCommand(query, con)
                Command.Parameters.AddWithValue("@Product_ID", selectedProduct)
                Try
                    con.Open()
                    Dim reader As SqlDataReader = Command.ExecuteReader()
                    If reader.Read() Then
                        ' تحديث بيانات الصف الجديد
                        dgv_Tbl_InvoiceItems.Rows(rowIndex).Cells("DGV_Product_Name").Value = reader("Product_Name").ToString()
                        dgv_Tbl_InvoiceItems.Rows(rowIndex).Cells("DGV_QTE_IN_STOCK").Value = reader("QTE_IN_STOCK").ToString()
                        dgv_Tbl_InvoiceItems.Rows(rowIndex).Cells("DGV_ID_CAT").Value = reader("CAT_Name").ToString()
                        dgv_Tbl_InvoiceItems.Rows(rowIndex).Cells("DGV_Unit_ID").Value = reader("Unit_ID").ToString()
                        dgv_Tbl_InvoiceItems.Rows(rowIndex).Cells("DGV_Unit_Name").Value = reader("Unit_Name").ToString()
                        dgv_Tbl_InvoiceItems.Rows(rowIndex).Cells("DGV_Initial_Balance").Value = reader("Initial_Balance").ToString()

                        dgv_Tbl_InvoiceItems.Rows(rowIndex).Cells("DGV_ElWarad").Value = reader("ElWarad").ToString()
                        dgv_Tbl_InvoiceItems.Rows(rowIndex).Cells("DGV_MortagaaOmalaa").Value = reader("MortagaaOmalaa").ToString()
                        dgv_Tbl_InvoiceItems.Rows(rowIndex).Cells("DGV_ElMonsarf").Value = reader("ElMonsarf").ToString()
                        dgv_Tbl_InvoiceItems.Rows(rowIndex).Cells("DGV_MortagaaElMawarden").Value = reader("MortagaaElMawarden").ToString()

                        dgv_Tbl_InvoiceItems.Rows(rowIndex).Cells("DGV_Unit_Price").Value = reader("Unit_Price").ToString()
                        dgv_Tbl_InvoiceItems.Rows(rowIndex).Cells("DGV_Minimum_Threshold").Value = reader("Minimum_Threshold").ToString()
                        dgv_Tbl_InvoiceItems.Rows(rowIndex).Cells("DGV_Maximum_Threshold").Value = reader("Maximum_Threshold").ToString()

                    End If
                    reader.Close()
                Catch ex As Exception
                    MessageBox.Show("حدث خطأ: " & ex.Message)
                End Try
            End Using
            NumberOfItems.Text = dgv_Tbl_InvoiceItems.Rows.Count - 1
        Catch ex As Exception
            MessageBox.Show("حدث خطأ: " & ex.Message)
        End Try
    End Sub
End Class