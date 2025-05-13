Imports System.Data.SqlClient
Imports El_Dawliya_International_System.El_Dawliya_International_System.Forms.Report
Public Class Document_Query_Delete
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Public dt_Tbl_InvoiceItems As New DataTable
    Public dt_Tbl_Ezn_Customer As New DataTable

    Public Sub ClearControls()
        Invoice_Number.Text = vbNullString
        Invoice_Type.Text = vbNullString
        Invoice_Date.Value = Today
        Supplier_ID.SelectedValue = -1
        Supplier_Invoice_Number.Text = vbNullString
        Customer_ID.SelectedValue = -1
        Total_Invoice_Value.Text = vbNullString
        NumberOfItems.Text = vbNullString
        dgv_Tbl_InvoiceItems.DataSource = Nothing
        Invoice_Number.Focus()
    End Sub

    Public Sub fillcmb_Tbl_Customers(ByVal cmb As ComboBox)
        Dim DT As New DataTable
        Dim DA As New SqlDataAdapter
        DT.Clear()
        DA = New SqlDataAdapter("Select * FROM Tbl_Customers ", Con)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            cmb.DataSource = DT
            cmb.DisplayMember = "Customer_Name"
            cmb.ValueMember = "Customer_ID"
            cmb.SelectedValue = -1
        Else
            cmb.DataSource = Nothing
        End If
    End Sub

    Public Sub fillcmb_Tbl_Suppliers(ByVal cmb As ComboBox)
        Dim DT As New DataTable
        Dim DA As New SqlDataAdapter
        DT.Clear()
        DA = New SqlDataAdapter("Select * FROM Tbl_Suppliers ", Con)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            cmb.DataSource = DT
            cmb.DisplayMember = "Supplier_Name"
            cmb.ValueMember = "Supplier_ID"
            cmb.SelectedValue = -1
        Else
            cmb.DataSource = Nothing
        End If
    End Sub

    Public Sub SelectAll_Tbl_InvoiceItems(dgv As DataGridView)
        dt_Tbl_InvoiceItems.Clear()
        dgv_Tbl_InvoiceItems.DataSource = Nothing
        Dim commandText As String = "SELECT ROW_NUMBER() OVER (ORDER BY Invoice_Date) AS RowNumber,
        Tbl_InvoiceItems.*,
        Tbl_Units_SpareParts.Unit_Name 
        FROM Tbl_InvoiceItems 
        INNER JOIN Tbl_Units_SpareParts ON Tbl_InvoiceItems.Unit_ID = Tbl_Units_SpareParts.Unit_ID
        WHERE Tbl_InvoiceItems.Invoice_Number = @InvoiceNumber"
        Dim command As New SqlCommand(commandText, Con)
        command.Parameters.AddWithValue("@InvoiceNumber", Invoice_Number.Text)
        Dim da As New SqlDataAdapter(command)
        da.Fill(dt_Tbl_InvoiceItems)
        ' تحديد ترتيب الأعمدة باستخدام الاسم النصي
        Dim columnsOrder() As String = {"RowNumber", "Invoice_Code_Programing", "Invoice_ID", "Invoice_Number", "Product_ID", "Product_Name", "Unit_ID", "Unit_Name", "Quantity_ElWarad", "Quantity_ElMonsarf", "Quantity_MortagaaElMawarden", "Quantity_MortagaaOmalaa", "Unit_Price", "Invoice_Date", "Invoice_Type", "ReturnInvoiceNumber", "Total_Invoice_Value", "Balance_Time_Entry", "Data_Entry_Date", "Data_Entry_By"}
        For i As Integer = 0 To columnsOrder.Length - 1
            dt_Tbl_InvoiceItems.Columns(columnsOrder(i)).SetOrdinal(i)
        Next
        dgv.DataSource = dt_Tbl_InvoiceItems
        With dgv
            '.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            '.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            For Each col As DataGridViewColumn In .Columns
                col.HeaderText = GetColumnHeaderName(col.Name)
            Next
        End With
        ConfigureDataGridViewColumns(dgv_Tbl_InvoiceItems, dt_Tbl_InvoiceItems)
    End Sub

    Public Class Save_invoice_data
        ' تعريف متغيرات عامة
        Public Shared Invoice_Number_Save As String
        Public Shared Product_ID_Save As New List(Of String)()
        Public Shared Product_Name_Save As New List(Of String)()
        Public Shared Unit_ID_Save As New List(Of Integer)()
        Public Shared Unit_Name_Save As New List(Of String)()
        Public Shared Quantity_ElWarad_Save As New List(Of Decimal)()
        Public Shared Quantity_ElMonsarf_Save As New List(Of Decimal)()
        Public Shared Quantity_MortagaaElMawarden_Save As New List(Of Decimal)()
        Public Shared Quantity_MortagaaOmalaa_Save As New List(Of Decimal)()
        Public Shared Unit_Price_Save As New List(Of Decimal)()
    End Class

    Private Function GetColumnHeaderName(columnName As String) As String
        Select Case columnName
            Case "RowNumber" : Return "مسلسل"
            Case "Invoice_Code_Programing" : Return "الكود البرمجى"
            Case "Invoice_ID" : Return "كود المستند"
            Case "Invoice_Number" : Return "رقم المستند"
            Case "Product_ID" : Return "كود الصنف"
            Case "Product_Name" : Return "اسم الصنف"
            Case "Quantity_ElWarad" : Return "الكمية الورادة"
            Case "Quantity_ElMonsarf" : Return "الكمية المنصرفة"
            Case "Quantity_MortagaaElMawarden" : Return "كمية مرتجع الموردين"
            Case "Quantity_MortagaaOmalaa" : Return "كمية مرتجع العملاء"
            Case "Unit_ID" : Return "كود الوحدة"
            Case "Unit_Name" : Return "الوحدة"
            Case "Unit_Price" : Return "سعر الوحدة"
            Case "Invoice_Date" : Return "التاريخ"
            Case "Invoice_Type" : Return "نوع المستند"
            Case "ReturnInvoiceNumber" : Return "رقم مستند المرتجع"
            Case "Recipient" : Return "المستلم"
            Case "Total_Invoice_Value" : Return "الاجمالى الكلى"
            Case "Balance_Time_Entry" : Return "الرصيد قبل العملية"
            Case "Data_Entry_Date" : Return "تاريخ الادخال"
            Case "Data_Entry_By" : Return "اسم المُدخل"
            Case "Customer_Name" : Return "العميل"
            Case "Received_Machine" : Return "الماكينة"
            Case Else : Return columnName
        End Select
    End Function

    Private Sub Frm_Document_Query_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim formatter As New Format_Any_Form()
        'formatter.FormatForm(Me)

        SelectAll_Tbl_InvoiceItems(dgv_Tbl_InvoiceItems)
        fillcmb_Tbl_Customers(Customer_ID)
        fillcmb_Tbl_Suppliers(Supplier_ID)
        Invoice_Number.Focus()
        GotFoucs_LostFocus_For_GroupBox(GroupBox1)
    End Sub

    Private Function GetValueOrDefault(ByVal value As Object) As String
        If Not IsDBNull(value) Then
            Return value.ToString()
        Else
            Return String.Empty
        End If
    End Function

    Private Function GetValueforCombobox(ByVal value As Object) As String
        'الكود ده للكمبوبوكس عشان لو فاضى ميدنيش خطأ
        If Not IsDBNull(value) Then
            Return value.ToString()
        Else
            Return -1
        End If
    End Function

    Private Sub RetrieveInvoiceData(ByVal Invoice_Number As String)
        Dim query As String = "select * from Tbl_Invoices WHERE Tbl_Invoices.Invoice_Number = @Invoice_Number"
        Using connection As New SqlConnection(ConStr)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Invoice_Number", Invoice_Number)
                Try
                    connection.Open()
                    Dim reader As SqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read()
                            Invoice_Date.Value = GetValueOrDefault(reader("Invoice_Date"))
                            NumberOfItems.Text = GetValueOrDefault(reader("NumberOfItems"))
                            Total_Invoice_Value.Text = GetValueOrDefault(reader("Total_Invoice_Value"))
                            Invoice_Type.Text = GetValueOrDefault(reader("Invoice_Type"))
                            Supplier_Invoice_Number.Text = GetValueOrDefault(reader("Supplier_Invoice_Number"))
                            Customer_ID.SelectedValue = GetValueforCombobox(reader("Customer_ID"))
                            Supplier_ID.SelectedValue = GetValueforCombobox(reader("Supplier_ID"))
                            Invoice_Date.Value = reader("Invoice_Date").ToString()
                        End While
                    Else
                        MessageBox.Show("لم يتم العثور على معلومات لهذا المستند")
                    End If
                Catch ex As Exception
                    MessageBox.Show("خطأ: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub Invoice_Number_KeyDown(sender As Object, e As KeyEventArgs) Handles Invoice_Number.KeyDown
        ' التأكد من أن المفتاح المضغوط هو مفتاح Enter
        If e.KeyCode = Keys.Enter Then
            ' تنفيذ الكود لاسترداد بيانات الموظف
            RetrieveInvoiceData(Invoice_Number.Text)
        End If
        SelectAll_Tbl_InvoiceItems(dgv_Tbl_InvoiceItems)

        Select Case Invoice_Type.Text
            Case "اذن صرف"
                ConfigureDataGridViewColumnsEznCustomer(dgv_Tbl_InvoiceItems, dt_Tbl_InvoiceItems)
                Supplier_IDlbl.Visible = False
                Supplier_ID.Visible = False
                Customer_IDLbl.Visible = True
                Customer_ID.Visible = True
            Case "اذن وارد"
                ConfigureDataGridViewColumnsEznSuppliers(dgv_Tbl_InvoiceItems, dt_Tbl_InvoiceItems)
                Supplier_IDlbl.Visible = True
                Supplier_ID.Visible = True
                Customer_IDLbl.Visible = False
                Customer_ID.Visible = False
            Case "اذن مرتجع عميل"
                ConfigureDataGridViewColumnsMortagaaCustomer(dgv_Tbl_InvoiceItems, dt_Tbl_InvoiceItems)
                Supplier_IDlbl.Visible = False
                Supplier_ID.Visible = False
                Customer_IDLbl.Visible = True
                Customer_ID.Visible = True
            Case "اذن مرتجع مورد"
                ConfigureDataGridViewColumnsMortagaaSuppliers(dgv_Tbl_InvoiceItems, dt_Tbl_InvoiceItems)
                Supplier_IDlbl.Visible = True
                Supplier_ID.Visible = True
                Customer_IDLbl.Visible = False
                Customer_ID.Visible = False
        End Select
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ClearControls()
    End Sub

    Private Sub Invoice_Type_Search_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Invoice_Type_Search.SelectedIndexChanged
        Select Case Invoice_Type_Search.Text
            Case "اذن صرف"
                dgv_Tbl_InvoiceItems.DataSource = Nothing
                SelectAll_Ezn_Customer(dgv_Tbl_InvoiceItems)
                ConfigureDataGridViewColumnsEznCustomer(dgv_Tbl_InvoiceItems, dt_Tbl_Ezn_Customer)
                Supplier_IDlbl.Visible = False
                Supplier_ID.Visible = False
                Customer_IDLbl.Visible = True
                Customer_ID.Visible = True
            Case "اذن وارد"

                dgv_Tbl_InvoiceItems.DataSource = Nothing
                SelectAll_Ezn_Suppliers(dgv_Tbl_InvoiceItems)
                ConfigureDataGridViewColumnsEznSuppliers(dgv_Tbl_InvoiceItems, dt_Tbl_Ezn_Customer)
                Supplier_IDlbl.Visible = True
                Supplier_ID.Visible = True
                Customer_IDLbl.Visible = False
                Customer_ID.Visible = False
            Case "اذن مرتجع عميل"
                dgv_Tbl_InvoiceItems.DataSource = Nothing
                SelectAll_Ezn_Customer(dgv_Tbl_InvoiceItems)
                ConfigureDataGridViewColumnsMortagaaCustomer(dgv_Tbl_InvoiceItems, dt_Tbl_Ezn_Customer)
                Supplier_IDlbl.Visible = False
                Supplier_ID.Visible = False
                Customer_IDLbl.Visible = True
                Customer_ID.Visible = True
            Case "اذن مرتجع مورد"
                dgv_Tbl_InvoiceItems.DataSource = Nothing
                SelectAll_Ezn_Suppliers(dgv_Tbl_InvoiceItems)
                ConfigureDataGridViewColumnsMortagaaSuppliers(dgv_Tbl_InvoiceItems, dt_Tbl_Ezn_Customer)
                Supplier_IDlbl.Visible = True
                Supplier_ID.Visible = True
                Customer_IDLbl.Visible = False
                Customer_ID.Visible = False
        End Select
    End Sub

    Public Sub SelectAll_Ezn_Suppliers(dgv As DataGridView)
        dt_Tbl_Ezn_Customer.Clear()
        Dim commandText As String = "SELECT ROW_NUMBER() OVER (ORDER BY Tbl_InvoiceItems.Invoice_Date) AS RowNumber,
         Tbl_InvoiceItems.*,
          Tbl_Units_SpareParts.Unit_Name
         FROM Tbl_InvoiceItems 
                 INNER JOIN Tbl_Units_SpareParts ON Tbl_InvoiceItems.Unit_ID = Tbl_Units_SpareParts.Unit_ID
                 WHERE Tbl_InvoiceItems.Invoice_Type = @Invoice_Type"
        Dim command As New SqlCommand(commandText, Con)
        command.Parameters.AddWithValue("@Invoice_Type", Invoice_Type_Search.Text)
        Dim daa As New SqlDataAdapter(command)
        daa.Fill(dt_Tbl_Ezn_Customer)
        ' تحديد ترتيب الأعمدة باستخدام الاسم النصي
        Dim columnsOrder() As String = {"RowNumber", "Invoice_Date", "Invoice_Number", "Product_ID", "Product_Name", "Unit_ID", "Unit_Name", "Quantity_ElMonsarf", "Quantity_ElWarad", "Quantity_MortagaaElMawarden", "Quantity_MortagaaOmalaa", "Unit_Price", "Invoice_Type", "ReturnInvoiceNumber", "Balance_Time_Entry", "Data_Entry_Date", "Data_Entry_By", "Invoice_Code_Programing", "Invoice_ID", "Total_Invoice_Value"}
        For i As Integer = 0 To columnsOrder.Length - 1
            dt_Tbl_Ezn_Customer.Columns(columnsOrder(i)).SetOrdinal(i)
        Next
        dgv.DataSource = dt_Tbl_Ezn_Customer
        With dgv
            '.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            '.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            For Each col As DataGridViewColumn In .Columns
                col.HeaderText = GetColumnHeaderName(col.Name)
            Next
        End With
        'ConfigureDataGridViewColumnsEznCustomer(dgv_Tbl_InvoiceItems, dt_Tbl_Ezn_Customer)
    End Sub

    Public Sub SelectAll_Ezn_Customer(dgv As DataGridView)
        dt_Tbl_Ezn_Customer.Clear()
        Dim commandText As String = "SELECT ROW_NUMBER() OVER (ORDER BY Tbl_InvoiceItems.Invoice_Date) AS RowNumber,
         Tbl_InvoiceItems.*,
                 Tbl_Units_SpareParts.Unit_Name
                 FROM Tbl_InvoiceItems 
                 INNER JOIN Tbl_Units_SpareParts ON Tbl_InvoiceItems.Unit_ID = Tbl_Units_SpareParts.Unit_ID
                 WHERE Tbl_InvoiceItems.Invoice_Type = @Invoice_Type"
        Dim command As New SqlCommand(commandText, Con)
        command.Parameters.AddWithValue("@Invoice_Type", Invoice_Type_Search.Text)
        Dim daa As New SqlDataAdapter(command)
        daa.Fill(dt_Tbl_Ezn_Customer)
        ' تحديد ترتيب الأعمدة باستخدام الاسم النصي
        Dim columnsOrder() As String = {"RowNumber", "Invoice_Date", "Invoice_Number", "Product_ID", "Product_Name", "Unit_ID", "Unit_Name", "Quantity_ElMonsarf", "Quantity_ElWarad", "Quantity_MortagaaElMawarden", "Quantity_MortagaaOmalaa", "Unit_Price", "Invoice_Type", "Recipient", "ReturnInvoiceNumber", "Balance_Time_Entry", "Data_Entry_Date", "Data_Entry_By", "Invoice_Code_Programing", "Invoice_ID", "Total_Invoice_Value"}
        For i As Integer = 0 To columnsOrder.Length - 1
            dt_Tbl_Ezn_Customer.Columns(columnsOrder(i)).SetOrdinal(i)
        Next
        dgv.DataSource = dt_Tbl_Ezn_Customer
        With dgv
            '.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            '.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            For Each col As DataGridViewColumn In .Columns
                col.HeaderText = GetColumnHeaderName(col.Name)
            Next
        End With
        'ConfigureDataGridViewColumnsEznCustomer(dgv_Tbl_InvoiceItems, dt_Tbl_Ezn_Customer)
    End Sub

    Private Sub ConfigureDataGridViewColumns(dgv As DataGridView, dt As DataTable)
        With dgv
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

            For Each col As DataColumn In dt.Columns
                Dim columnIndex As Integer = dt.Columns.IndexOf(col)
                .Columns(columnIndex).HeaderText = GetColumnHeaderName(col.ColumnName)

                ' Set other column properties based on column name
                Select Case col.ColumnName
                    Case "RowNumber"
                        .Columns(columnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    Case "Product_ID"
                        .Columns(columnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    Case "Product_Name"
                        .Columns(columnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    Case "Quantity_ElWarad", "Quantity_ElMonsarf", "Quantity_MortagaaElMawarden", "Quantity_MortagaaOmalaa", "Recipient"
                        .Columns(columnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    Case "Unit_Name"
                        .Columns(columnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    Case "Invoice_Code_Programing", "Invoice_ID", "Invoice_Number", "Unit_Price", "Invoice_Date", "Invoice_Type", "Unit_ID", "ReturnInvoiceNumber", "Total_Invoice_Value", "Balance_Time_Entry", "Data_Entry_Date", "Data_Entry_By"
                        .Columns(columnIndex).Visible = False
                End Select
            Next
        End With
    End Sub

    Private Sub ConfigureDataGridViewColumnsEznSuppliers(dgv As DataGridView, Ta As DataTable)
        With dgv
            '.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            '.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            For Each col As DataColumn In Ta.Columns
                Dim columnIndex As Integer = Ta.Columns.IndexOf(col)
                .Columns(columnIndex).HeaderText = GetColumnHeaderName(col.ColumnName)
                ' Set other column properties based on column name
                Select Case col.ColumnName
                    Case "Product_Name"
                        .Columns(columnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    Case "RowNumber", "Invoice_Date", "Invoice_Number", "Product_ID", "Quantity_ElWarad", "Unit_Name"
                        .Columns(columnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    Case "Quantity_MortagaaElMawarden", "Quantity_MortagaaOmalaa", "Quantity_ElMonsarf", "Invoice_Type", "Unit_Price", "Unit_ID", "Recipient", "Customer_Name", "ReturnInvoiceNumber", "Total_Invoice_Value", "Data_Entry_Date", "Data_Entry_By", "Invoice_Code_Programing", "Invoice_ID", "Received_Machine", "Balance_Time_Entry", "Machine_Unit", "Notes"
                        .Columns(columnIndex).Visible = False
                End Select
            Next
        End With
    End Sub

    Private Sub ConfigureDataGridViewColumnsEznCustomer(dgv As DataGridView, Ta As DataTable)
        With dgv
            '.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            '.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            For Each col As DataColumn In Ta.Columns
                Dim columnIndex As Integer = Ta.Columns.IndexOf(col)
                .Columns(columnIndex).HeaderText = GetColumnHeaderName(col.ColumnName)
                ' Set other column properties based on column name
                Select Case col.ColumnName
                    Case "Product_Name"
                        .Columns(columnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    Case "RowNumber", "Invoice_Date", "Invoice_Number", "Product_ID", "Quantity_ElMonsarf", "Unit_Name", "Recipient"
                        .Columns(columnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    Case "Quantity_MortagaaElMawarden", "Quantity_MortagaaOmalaa", "Quantity_ElWarad", "Invoice_Type", "Unit_Price", "Unit_ID", "Customer_Name", "ReturnInvoiceNumber", "Total_Invoice_Value", "Data_Entry_Date", "Data_Entry_By", "Invoice_Code_Programing", "Invoice_ID", "Received_Machine", "Balance_Time_Entry", "Machine_Unit", "Notes"
                        .Columns(columnIndex).Visible = False
                End Select
            Next
        End With
    End Sub

    Private Sub ConfigureDataGridViewColumnsMortagaaCustomer(dgv As DataGridView, Ta As DataTable)
        With dgv
            '.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            '.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            For Each col As DataColumn In Ta.Columns
                Dim columnIndex As Integer = Ta.Columns.IndexOf(col)
                .Columns(columnIndex).HeaderText = GetColumnHeaderName(col.ColumnName)
                ' Set other column properties based on column name
                Select Case col.ColumnName
                    Case "Product_Name"
                        .Columns(columnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    Case "RowNumber", "Invoice_Date", "Invoice_Number", "Product_ID", "Quantity_MortagaaOmalaa", "Unit_Name"
                        .Columns(columnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    Case "Quantity_MortagaaElMawarden", "Quantity_ElWarad", "Quantity_ElMonsarf", "Invoice_Type", "Unit_Price", "Unit_ID", "Customer_Name", "ReturnInvoiceNumber", "Total_Invoice_Value", "Data_Entry_Date", "Data_Entry_By", "Invoice_Code_Programing", "Invoice_ID", "Received_Machine", "Balance_Time_Entry", "Recipient", "Machine_Unit", "Notes"
                        .Columns(columnIndex).Visible = False
                End Select
            Next
        End With
    End Sub

    Private Sub ConfigureDataGridViewColumnsMortagaaSuppliers(dgv As DataGridView, Ta As DataTable)
        With dgv
            '.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            '.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            For Each col As DataColumn In Ta.Columns
                Dim columnIndex As Integer = Ta.Columns.IndexOf(col)
                .Columns(columnIndex).HeaderText = GetColumnHeaderName(col.ColumnName)
                ' Set other column properties based on column name
                Select Case col.ColumnName
                    Case "Product_Name"
                        .Columns(columnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    Case "RowNumber", "Invoice_Date", "Invoice_Number", "Product_ID", "Quantity_MortagaaElMawarden", "Unit_Name"
                        .Columns(columnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    Case "Quantity_MortagaaOmalaa", "Quantity_ElWarad", "Quantity_ElMonsarf", "Invoice_Type", "Unit_Price", "Unit_ID", "Customer_Name", "ReturnInvoiceNumber", "Total_Invoice_Value", "Data_Entry_Date", "Data_Entry_By", "Invoice_Code_Programing", "Invoice_ID", "Received_Machine", "Balance_Time_Entry", "Recipient", "Machine_Unit", "Notes"
                        .Columns(columnIndex).Visible = False
                End Select
            Next
        End With
    End Sub

    Private Sub dgv_Tbl_InvoiceItems_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Tbl_InvoiceItems.CellContentClick
        Invoice_Number.Text = dgv_Tbl_InvoiceItems.CurrentRow.Cells("Invoice_Number").Value
        Invoice_Number_KeyDown(sender, New KeyEventArgs(Keys.Enter))
    End Sub

    Private Sub FillReportAndPrint()
        Dim rep As New Rep_EznSarf_Document_Query
        rep.SetDataSource(dt_Tbl_Ezn_Customer.DefaultView)
        Frm_Report.CrystalReportViewer1.ReportSource = rep
        'rep.Section2.SectionFormat.BackgroundColor = Color.Fuchsia
        Frm_Report.CrystalReportViewer1.Refresh()
        Frm_Report.ShowDialog()
    End Sub

    Private Sub Btn_Print_Click(sender As Object, e As EventArgs)
        FillReportAndPrint()
    End Sub

    Public Sub Update_Quantity_ElMonsarf()
        If Con.State = ConnectionState.Closed Then
            Con.Open()
        End If
        Try
            For I As Integer = 0 To dgv_Tbl_InvoiceItems.Rows.Count - 1
                Dim row As DataGridViewRow = dgv_Tbl_InvoiceItems.Rows(I)
                If Not row.IsNewRow Then
                    Dim A As Integer = row.Cells("Quantity_ElMonsarf").Value
                    Dim CmdUpdate As New SqlCommand
                    With CmdUpdate
                        .Connection = Con
                        .CommandType = CommandType.Text
                        .CommandText = "UPDATE Tbl_Products 
                         SET QTE_IN_STOCK = QTE_IN_STOCK + @Quantity_ElMonsarf, 
                         ElMonsarf = ElMonsarf - @Quantity_ElMonsarf 
                         WHERE Product_ID = @ProductID"
                        .Parameters.AddWithValue("@Quantity_ElMonsarf", A)
                        .Parameters.AddWithValue("@ProductID", row.Cells(3).Value.ToString())
                        .ExecuteNonQuery()
                    End With
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("خطأ: " & ex.Message)
        End Try
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If
    End Sub

    Public Sub AddQtyQuantity_ElMonsarf()
        If Con.State = ConnectionState.Closed Then
            Con.Open()
        End If
        For I As Integer = 0 To dgv_Tbl_InvoiceItems.Rows.Count - 1
            Dim row As DataGridViewRow = dgv_Tbl_InvoiceItems.Rows(I)
            If Not row.IsNewRow Then
                Dim A As Decimal = Convert.ToDecimal(row.Cells("Quantity_ElMonsarf").Value)

                Dim CmdUpdate As New SqlCommand
                With CmdUpdate
                    .Connection = Con
                    .CommandType = CommandType.Text
                    .CommandText = "UPDATE Tbl_Products 
                                SET QTE_IN_STOCK = (QTE_IN_STOCK + @Quantity_ElMonsarf), 
                                ElMonsarf = (ElMonsarf - @Quantity_ElMonsarf)
                                WHERE Product_ID = @ProductID"
                    .Parameters.AddWithValue("@Quantity_ElMonsarf", A)
                    .Parameters.AddWithValue("@ProductID", row.Cells(4).Value.ToString())
                    .Parameters("@Quantity_ElMonsarf").SqlDbType = SqlDbType.Decimal ' تحديد نوع البيانات
                    .ExecuteNonQuery()
                End With
            End If
        Next
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If
    End Sub

    Public Sub LosQtyQuantity_ElWarad()
        If Con.State = ConnectionState.Closed Then
            Con.Open()
        End If
        For I As Integer = 0 To dgv_Tbl_InvoiceItems.Rows.Count - 1
            Dim row As DataGridViewRow = dgv_Tbl_InvoiceItems.Rows(I)
            If Not row.IsNewRow Then
                'Dim A As Decimal = Convert.ToDecimal(row.Cells("Quantity_ElWarad").Value)
                Dim A As Decimal = Decimal.Parse(row.Cells("Quantity_ElWarad").Value.ToString(), System.Globalization.CultureInfo.InvariantCulture)
                Dim CmdUpdate As New SqlCommand
                With CmdUpdate
                    .Connection = Con
                    .CommandType = CommandType.Text
                    .CommandText = "UPDATE Tbl_Products 
                                SET QTE_IN_STOCK = (QTE_IN_STOCK - @Quantity_ElWarad), 
                                ElWarad = (ElWarad - @Quantity_ElWarad)
                                WHERE Product_ID = @ProductID"
                    .Parameters.AddWithValue("@Quantity_ElWarad", A)
                    .Parameters.AddWithValue("@ProductID", row.Cells(4).Value.ToString())
                    .Parameters("@Quantity_ElWarad").SqlDbType = SqlDbType.Decimal
                    .ExecuteNonQuery()
                End With
            End If
        Next
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If
    End Sub

    Public Sub LosQuantity_MortagaaOmalaa()
        If Con.State = ConnectionState.Closed Then
            Con.Open()
        End If
        For I As Integer = 0 To dgv_Tbl_InvoiceItems.Rows.Count - 1
            Dim row As DataGridViewRow = dgv_Tbl_InvoiceItems.Rows(I)
            If Not row.IsNewRow Then
                Dim A As Decimal = Convert.ToDecimal(row.Cells("Quantity_MortagaaOmalaa").Value)
                Dim CmdUpdate As New SqlCommand
                With CmdUpdate
                    .Connection = Con
                    .CommandType = CommandType.Text
                    .CommandText = "UPDATE Tbl_Products 
                                SET QTE_IN_STOCK = (QTE_IN_STOCK - @Quantity_MortagaaOmalaa), 
                                MortagaaOmalaa = (MortagaaOmalaa - @Quantity_MortagaaOmalaa)
                                WHERE Product_ID = @ProductID"
                    .Parameters.AddWithValue("@Quantity_MortagaaOmalaa", A)
                    .Parameters.AddWithValue("@ProductID", row.Cells(4).Value.ToString())
                    .Parameters("@Quantity_MortagaaOmalaa").SqlDbType = SqlDbType.Decimal ' تحديد نوع البيانات
                    .ExecuteNonQuery()
                End With
            End If
        Next
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If
    End Sub

    Public Sub AddQuantity_MortagaaElMawarden()
        If Con.State = ConnectionState.Closed Then
            Con.Open()
        End If
        For I As Integer = 0 To dgv_Tbl_InvoiceItems.Rows.Count - 1
            Dim row As DataGridViewRow = dgv_Tbl_InvoiceItems.Rows(I)
            If Not row.IsNewRow Then
                Dim A As Decimal = Convert.ToDecimal(row.Cells("Quantity_MortagaaElMawarden").Value)
                Dim CmdUpdate As New SqlCommand
                With CmdUpdate
                    .Connection = Con
                    .CommandType = CommandType.Text
                    .CommandText = "UPDATE Tbl_Products " &
                               "SET QTE_IN_STOCK = QTE_IN_STOCK + @Quantity_MortagaaElMawarden, " &
                               "MortagaaElMawarden = MortagaaElMawarden - @Quantity_MortagaaElMawarden " &
                               "WHERE Product_ID = @ProductID"
                    .Parameters.AddWithValue("@Quantity_MortagaaElMawarden", A)
                    .Parameters.AddWithValue("@ProductID", row.Cells(4).Value.ToString())
                    .Parameters("@Quantity_MortagaaElMawarden").SqlDbType = SqlDbType.Decimal ' تحديد نوع البيانات
                    .ExecuteNonQuery()
                End With
            End If
        Next
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If
    End Sub

    Public Sub Delete_Tbl_InvoiceItems(ByVal Invoice_Number As Integer)
        Dim Cmd As New SqlCommand
        Dim transaction As SqlTransaction = Nothing
        Try
            With Cmd
                .Connection = Con
                .CommandType = CommandType.Text
                .CommandText = "DELETE FROM Tbl_InvoiceItems WHERE Invoice_Number = @Invoice_Number; " &
                                "DELETE FROM Tbl_Invoices WHERE Invoice_Number = @Invoice_Number;"
                .Parameters.Clear()
                .Parameters.AddWithValue("@Invoice_Number", Invoice_Number)
            End With

            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If
            ' بدء المعاملة
            transaction = Con.BeginTransaction()
            Cmd.Transaction = transaction
            ' تنفيذ الأوامر
            Cmd.ExecuteNonQuery()
            ' تأكيد المعاملة
            transaction.Commit()
            MsgBox("تم حذف السجل.", MsgBoxStyle.Information, "حذف")
        Catch ex As Exception
            ' في حالة حدوث خطأ، يتم إلغاء المعاملة
            If transaction IsNot Nothing Then
                transaction.Rollback()
            End If
            MsgBox(ex.Message, MsgBoxStyle.Critical, "خطأ في الحذف")
        Finally
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
            Cmd.Dispose()
        End Try
    End Sub

    Private Function IsInvoiceNumberEmpty() As Boolean
        Return String.IsNullOrEmpty(Invoice_Number.Text)
    End Function

    Private Function IsDuplicateMMInGrid() As Boolean
        For Each row As DataGridViewRow In dgv_Tbl_InvoiceItems.Rows
            If Not row.IsNewRow AndAlso row.Cells("Product_ID").Value IsNot Nothing Then
                For Each innerRow As DataGridViewRow In dgv_Tbl_InvoiceItems.Rows
                    If Not innerRow.IsNewRow AndAlso innerRow.Index <> row.Index AndAlso innerRow.Cells("Product_ID").Value IsNot Nothing Then
                        If row.Cells("Product_ID").Value.ToString() = innerRow.Cells("Product_ID").Value.ToString() Then
                            Return True
                        End If
                    End If
                Next
            End If
        Next
        Return False
    End Function

    Private Sub Btn_Delet_Click(sender As Object, e As EventArgs) Handles Btn_Delet.Click
        Try
            ' التحقق من وجود بيانات في Invoice_Number.Text
            If IsInvoiceNumberEmpty() Then
                MessageBox.Show("يرجى كتابة رقم المستند", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' التحقق من وجود بيانات متشابهة في عمود MM في الداتا جريد فيو
            If IsDuplicateMMInGrid() Then
                MessageBox.Show("يوجد بيانات متشابهة في العمود لكود الصنف", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            ' عرض رسالة تأكيد
            Dim result As DialogResult = MessageBox.Show("هل أنت متأكد أنك تريد حذف البيانات؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            ' التحقق مما إذا كان الاختيار هو "نعم" قبل تنفيذ الحذف
            If result = DialogResult.Yes Then
                If Invoice_Type.Text = "اذن صرف" Then
                    AddQtyQuantity_ElMonsarf()
                    Delete_Tbl_InvoiceItems(Invoice_Number.Text)
                    ClearControls()
                ElseIf Invoice_Type.Text = "اذن وارد" Then
                    LosQtyQuantity_ElWarad()
                    Delete_Tbl_InvoiceItems(Invoice_Number.Text)
                    ClearControls()
                ElseIf Invoice_Type.Text = "اذن مرتجع عميل" Then
                    LosQuantity_MortagaaOmalaa()
                    Delete_Tbl_InvoiceItems(Invoice_Number.Text)
                    ClearControls()
                ElseIf Invoice_Type.Text = "اذن مرتجع مورد" Then
                    AddQuantity_MortagaaElMawarden()
                    Delete_Tbl_InvoiceItems(Invoice_Number.Text)
                    ClearControls()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("خطأ: " & ex.Message)
        End Try
    End Sub

    Public Sub Update_Tbl_Products(ByVal Product_ID As String, ByVal ElWarad As Double, ByVal QTE_IN_STOCK As Double, ByVal Product_IDW As String)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_Products Set Product_ID = @Product_ID,ElWarad = @ElWarad,QTE_IN_STOCK = @QTE_IN_STOCK, Where Product_ID = @Product_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Product_ID", SqlDbType.VarChar).Value = Product_ID
            .Parameters.AddWithValue("@ElWarad", SqlDbType.Decimal).Value = ElWarad
            .Parameters.AddWithValue("@QTE_IN_STOCK", SqlDbType.Decimal).Value = QTE_IN_STOCK
            .Parameters.AddWithValue("@Product_ID", SqlDbType.VarChar).Value = Product_IDW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

End Class