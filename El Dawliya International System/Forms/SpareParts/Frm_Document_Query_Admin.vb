Imports System.Data.SqlClient
Imports El_Dawliya_International_System.El_Dawliya_International_System.Forms.Report
Public Class Frm_Document_Query_Admin
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Public dt_Tbl_InvoiceItems As New DataTable
    Public dt_Tbl_Ezn_Customer As New DataTable

    Public Sub clearControls()
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
            WHERE Tbl_InvoiceItems.Invoice_Number = @InvoiceNumber
            ORDER BY Tbl_InvoiceItems.Invoice_Date;"
        Dim command As New SqlCommand(commandText, Con)
        command.Parameters.AddWithValue("@InvoiceNumber", Invoice_Number.Text)
        Dim da As New SqlDataAdapter(command)
        da.Fill(dt_Tbl_InvoiceItems)
        ' تحديد ترتيب الأعمدة باستخدام الاسم النصي
        Dim columnsOrder() As String = {"RowNumber", "Invoice_Code_Programing", "Invoice_ID", "Invoice_Number", "Product_ID", "Product_Name", "Unit_ID", "Unit_Name", "Quantity_ElWarad", "Quantity_ElMonsarf", "Quantity_MortagaaElMawarden", "Quantity_MortagaaOmalaa", "Invoice_Date", "Invoice_Type", "ReturnInvoiceNumber", "Unit_Price", "Total_Invoice_Value", "Balance_Time_Entry", "Data_Entry_Date", "Data_Entry_By"}
        For i As Integer = 0 To columnsOrder.Length - 1
            dt_Tbl_InvoiceItems.Columns(columnsOrder(i)).SetOrdinal(i)
        Next
        dgv.DataSource = dt_Tbl_InvoiceItems
        With dgv
            For Each col As DataGridViewColumn In .Columns
                col.HeaderText = GetColumnHeaderName(col.Name)
            Next
        End With
        ConfigureDataGridViewColumns(dgv_Tbl_InvoiceItems, dt_Tbl_InvoiceItems)
    End Sub

    Private Sub ConfigureDataGridViewColumns(dgv As DataGridView, dt As DataTable)
        With dgv
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
                    Case "Quantity_ElWarad", "Quantity_ElMonsarf", "Quantity_MortagaaElMawarden", "Quantity_MortagaaOmalaa", "Recipient", "Invoice_Code_Programing"
                        .Columns(columnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    Case "Unit_Name"
                        .Columns(columnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    Case "Invoice_ID", "Invoice_Number", "Invoice_Date", "Invoice_Type", "Unit_ID", "ReturnInvoiceNumber", "Balance_Time_Entry", "Data_Entry_Date", "Data_Entry_By", "Machine_Unit", "Notes"
                        .Columns(columnIndex).Visible = False
                End Select
            Next
        End With
    End Sub

    Private Function GetColumnHeaderName(columnName As String) As String
        Select Case columnName
            Case "RowNumber" : Return "مسلسل"
            Case "Invoice_Code_Programing" : Return "الكود البرمجى"
            Case "Invoice_ID" : Return "كود المستند"
            Case "Invoice_Number" : Return "رقم الأذن"
            Case "Product_ID" : Return "كود الصنف"
            Case "Product_Name" : Return "اسم الصنف"
            Case "Quantity_ElWarad" : Return "الكمية الواردة"
            Case "Quantity_ElMonsarf" : Return "الكمية المنصرفة"
            Case "Quantity_MortagaaElMawarden" : Return "كمية مرتجع الموردين"
            Case "Quantity_MortagaaOmalaa" : Return "كمية مرتجع العملاء"
            Case "Unit_ID" : Return "كود الوحدة"
            Case "Unit_Name" : Return "الوحدة"
            Case "Unit_Price" : Return "السعر"
            Case "Invoice_Date" : Return "التاريخ"
            Case "Invoice_Type" : Return "نوع المستند"
            Case "ReturnInvoiceNumber" : Return "رقم مستند المرتجع"
            Case "Recipient" : Return "المستلم"
            Case "Total_Invoice_Value" : Return "الاجمالى"
            Case "Balance_Time_Entry" : Return "الرصيد قبل العملية"
            Case "Data_Entry_Date" : Return "تاريخ الادخال"
            Case "Data_Entry_By" : Return "اسم المُدخل"
            Case "Customer_Name" : Return "العميل"
            Case "Received_Machine" : Return "الماكينة"
            Case "Machine_Unit" : Return "جزء الماكينة"
            Case "Notes" : Return "بيان"
            Case Else : Return columnName
        End Select
    End Function

    Private Sub Frm_Document_Query_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Txt_UserID.Text = loggedInUserName
        Me.Txt_User.Text = loggedInUserID
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
        Dim query As String = "Select * from Tbl_Invoices WHERE Tbl_Invoices.Invoice_Number = @Invoice_Number"
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
        'If Txt_UserID.Text = "1" Or Txt_UserID.Text = "7" Or Txt_UserID.Text = "9" Then
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

        'End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        clearControls()
    End Sub

    Private Sub Invoice_Type_Search_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Invoice_Type_Search.SelectedIndexChanged
        Select Case Invoice_Type_Search.Text
            Case "اذن صرف"
                Label1.Text = "استعلام اذون صرف الى العملاء"
                dgv_Tbl_InvoiceItems.DataSource = Nothing
                SelectAll_Ezn_Customer(dgv_Tbl_InvoiceItems)
                ConfigureDataGridViewColumnsEznCustomer(dgv_Tbl_InvoiceItems, dt_Tbl_Ezn_Customer)
                Supplier_IDlbl.Visible = False
                Supplier_ID.Visible = False
                Customer_IDLbl.Visible = True
                Customer_ID.Visible = True
            Case "اذن وارد"
                Label1.Text = "استعلام اذون وراد من الموردين"
                dgv_Tbl_InvoiceItems.DataSource = Nothing
                SelectAll_Ezn_Suppliers(dgv_Tbl_InvoiceItems)
                ConfigureDataGridViewColumnsEznSuppliers(dgv_Tbl_InvoiceItems, dt_Tbl_Ezn_Customer)
                Supplier_IDlbl.Visible = True
                Supplier_ID.Visible = True
                Customer_IDLbl.Visible = False
                Customer_ID.Visible = False
            Case "اذن مرتجع عميل"
                Label1.Text = "استعلام اذون مرتجعات من العملاء"
                dgv_Tbl_InvoiceItems.DataSource = Nothing
                SelectAll_Ezn_Customer(dgv_Tbl_InvoiceItems)
                ConfigureDataGridViewColumnsMortagaaCustomer(dgv_Tbl_InvoiceItems, dt_Tbl_Ezn_Customer)
                Supplier_IDlbl.Visible = False
                Supplier_ID.Visible = False
                Customer_IDLbl.Visible = True
                Customer_ID.Visible = True
            Case "اذن مرتجع مورد"
                Label1.Text = "استعلام اذون مرتجعات من الموردين"
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
                 WHERE Tbl_InvoiceItems.Invoice_Type = @Invoice_Type
                        ORDER BY Tbl_InvoiceItems.Invoice_Number"
        Dim command As New SqlCommand(commandText, Con)
        command.Parameters.AddWithValue("@Invoice_Type", Invoice_Type_Search.Text)
        Dim daa As New SqlDataAdapter(command)
        daa.Fill(dt_Tbl_Ezn_Customer)
        ' تحديد ترتيب الأعمدة باستخدام الاسم النصي
        Dim columnsOrder() As String = {"RowNumber", "Invoice_Code_Programing", "Invoice_Date", "Invoice_Number", "Product_ID", "Product_Name", "Unit_ID", "Unit_Name", "Quantity_ElMonsarf", "Quantity_ElWarad", "Quantity_MortagaaElMawarden", "Quantity_MortagaaOmalaa", "Unit_Price", "Invoice_Type", "ReturnInvoiceNumber", "Balance_Time_Entry", "Data_Entry_Date", "Data_Entry_By", "Invoice_ID", "Total_Invoice_Value"}
        For i As Integer = 0 To columnsOrder.Length - 1
            dt_Tbl_Ezn_Customer.Columns(columnsOrder(i)).SetOrdinal(i)
        Next
        dgv.DataSource = dt_Tbl_Ezn_Customer
        With dgv
            For Each col As DataGridViewColumn In .Columns
                col.HeaderText = GetColumnHeaderName(col.Name)
            Next
        End With

    End Sub

    Public Sub SelectAll_Ezn_Customer(dgv As DataGridView)
        dt_Tbl_Ezn_Customer.Clear()
        Dim commandText As String = "SELECT ROW_NUMBER() OVER (ORDER BY Tbl_InvoiceItems.Invoice_Date) AS RowNumber,
         Tbl_InvoiceItems.*,
                 Tbl_Units_SpareParts.Unit_Name
                 FROM Tbl_InvoiceItems 
                 INNER JOIN Tbl_Units_SpareParts ON Tbl_InvoiceItems.Unit_ID = Tbl_Units_SpareParts.Unit_ID
                 WHERE Tbl_InvoiceItems.Invoice_Type = @Invoice_Type
                 ORDER BY Tbl_InvoiceItems.Invoice_Number;"
        Dim command As New SqlCommand(commandText, Con)
        command.Parameters.AddWithValue("@Invoice_Type", Invoice_Type_Search.Text)
        Dim daa As New SqlDataAdapter(command)
        daa.Fill(dt_Tbl_Ezn_Customer)
        ' تحديد ترتيب الأعمدة باستخدام الاسم النصي
        Dim columnsOrder() As String = {"RowNumber", "Invoice_Code_Programing", "Invoice_Date", "Invoice_Number", "Product_ID", "Product_Name", "Unit_ID", "Unit_Name", "Quantity_ElMonsarf", "Quantity_ElWarad", "Quantity_MortagaaElMawarden", "Quantity_MortagaaOmalaa", "Unit_Price", "Invoice_Type", "Recipient", "ReturnInvoiceNumber", "Balance_Time_Entry", "Data_Entry_Date", "Data_Entry_By", "Invoice_ID", "Total_Invoice_Value"}
        For i As Integer = 0 To columnsOrder.Length - 1
            dt_Tbl_Ezn_Customer.Columns(columnsOrder(i)).SetOrdinal(i)
        Next
        dgv.DataSource = dt_Tbl_Ezn_Customer
        With dgv
            For Each col As DataGridViewColumn In .Columns
                col.HeaderText = GetColumnHeaderName(col.Name)
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
                    Case "RowNumber", "Invoice_Date", "Invoice_Number", "Product_ID", "Quantity_ElWarad", "Unit_Name", "Unit_Price", "Total_Invoice_Value", "Invoice_Code_Programing"
                        .Columns(columnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    Case "Quantity_MortagaaElMawarden", "Quantity_MortagaaOmalaa", "Quantity_ElMonsarf", "Invoice_Type", "Unit_ID", "Recipient", "Customer_Name", "ReturnInvoiceNumber", "Data_Entry_Date", "Data_Entry_By", "Invoice_ID", "Received_Machine", "Balance_Time_Entry", "Machine_Unit", "Notes"
                        .Columns(columnIndex).Visible = False
                End Select
            Next
        End With
    End Sub

    Private Sub ConfigureDataGridViewColumnsEznCustomer(dgv As DataGridView, Ta As DataTable)
        With dgv
            For Each col As DataColumn In Ta.Columns
                Dim columnIndex As Integer = Ta.Columns.IndexOf(col)
                .Columns(columnIndex).HeaderText = GetColumnHeaderName(col.ColumnName)
                ' Set other column properties based on column name
                Select Case col.ColumnName
                    Case "Product_Name"
                        .Columns(columnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    Case "RowNumber", "Invoice_Date", "Invoice_Number", "Product_ID", "Quantity_ElMonsarf", "Unit_Name", "Recipient", "Unit_Price", "Total_Invoice_Value", "Invoice_Code_Programing"
                        .Columns(columnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    Case "Quantity_MortagaaElMawarden", "Quantity_MortagaaOmalaa", "Quantity_ElWarad", "Invoice_Type", "Unit_ID", "Customer_Name", "ReturnInvoiceNumber", "Data_Entry_Date", "Data_Entry_By", "Invoice_ID", "Received_Machine", "Balance_Time_Entry"
                        .Columns(columnIndex).Visible = False
                End Select
            Next
        End With
    End Sub

    Private Sub ConfigureDataGridViewColumnsMortagaaCustomer(dgv As DataGridView, Ta As DataTable)
        With dgv
            For Each col As DataColumn In Ta.Columns
                Dim columnIndex As Integer = Ta.Columns.IndexOf(col)
                .Columns(columnIndex).HeaderText = GetColumnHeaderName(col.ColumnName)
                ' Set other column properties based on column name
                Select Case col.ColumnName
                    Case "Product_Name"
                        .Columns(columnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    Case "RowNumber", "Invoice_Date", "Invoice_Number", "Product_ID", "Quantity_MortagaaOmalaa", "Unit_Name", "Unit_Price", "Total_Invoice_Value", "Invoice_Code_Programing"
                        .Columns(columnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    Case "Quantity_MortagaaElMawarden", "Quantity_ElWarad", "Quantity_ElMonsarf", "Invoice_Type", "Unit_ID", "Customer_Name", "ReturnInvoiceNumber", "Data_Entry_Date", "Data_Entry_By", "Invoice_ID", "Received_Machine", "Balance_Time_Entry", "Recipient", "Machine_Unit", "Notes"
                        .Columns(columnIndex).Visible = False
                End Select
            Next
        End With
    End Sub

    Private Sub ConfigureDataGridViewColumnsMortagaaSuppliers(dgv As DataGridView, Ta As DataTable)
        With dgv
            For Each col As DataColumn In Ta.Columns
                Dim columnIndex As Integer = Ta.Columns.IndexOf(col)
                .Columns(columnIndex).HeaderText = GetColumnHeaderName(col.ColumnName)
                ' Set other column properties based on column name
                Select Case col.ColumnName
                    Case "Product_Name"
                        .Columns(columnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    Case "RowNumber", "Invoice_Date", "Invoice_Number", "Product_ID", "Quantity_MortagaaElMawarden", "Unit_Name", "Unit_Price", "Total_Invoice_Value", "Invoice_Code_Programing"
                        .Columns(columnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    Case "Quantity_MortagaaOmalaa", "Quantity_ElWarad", "Quantity_ElMonsarf", "Invoice_Type", "Unit_ID", "Customer_Name", "ReturnInvoiceNumber", "Data_Entry_Date", "Data_Entry_By", "Invoice_ID", "Received_Machine", "Balance_Time_Entry", "Recipient", "Machine_Unit", "Notes"
                        .Columns(columnIndex).Visible = False
                End Select
            Next
        End With
    End Sub

    Private Sub Invoice_Number_Enter(sender As Object, e As EventArgs) Handles Invoice_Number.Enter
        Label1.Text = "استعلام مستند"
    End Sub

    Private Sub FillReportAndPrint()
        Dim rep As New Rep_EznSarf_Document_Query
        rep.SetDataSource(dt_Tbl_InvoiceItems.DefaultView)
        Frm_Report.CrystalReportViewer1.ReportSource = rep
        'rep.Section2.SectionFormat.BackgroundColor = Color.Fuchsia
        Frm_Report.CrystalReportViewer1.Refresh()
        Frm_Report.ShowDialog()
    End Sub

    Private Sub Btn_Print_Click(sender As Object, e As EventArgs) Handles Btn_Print.Click
        FillReportAndPrint()
    End Sub

    Private Sub Btn_ExportToExcel_Click(sender As Object, e As EventArgs) Handles Btn_ExportToExcel.Click
        Dim saveDialog As New SaveFileDialog()
        saveDialog.Filter = "Excel Files|*.xlsx;*.xls"
        saveDialog.Title = "E:\El Dawliya International System\Excel"
        If saveDialog.ShowDialog() = DialogResult.OK Then
            ' استدعاء الدالة ExportToExcel مع تمرير قائمة الأعمدة المرغوب تصديرها
            ExportVisibleColumnsToExcel(dgv_Tbl_InvoiceItems, saveDialog.FileName)
        End If
    End Sub

    Private Sub dgv_Tbl_InvoiceItems_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Tbl_InvoiceItems.CellValueChanged
        Try
            ' التحقق من أن الخلية التي تغيرت قيمتها تقع في العمود Unit_Price
            If e.RowIndex >= 0 AndAlso e.ColumnIndex = dgv_Tbl_InvoiceItems.Columns("Unit_Price").Index Then
                Dim rowIndex As Integer = e.RowIndex
                If dgv_Tbl_InvoiceItems.Rows.Count > 0 AndAlso rowIndex <> dgv_Tbl_InvoiceItems.NewRowIndex Then
                    If dgv_Tbl_InvoiceItems.Rows(rowIndex).Cells("Unit_Price").Value IsNot Nothing Then
                        Dim unitPrice As Double
                        If Double.TryParse(dgv_Tbl_InvoiceItems.Rows(rowIndex).Cells("Unit_Price").Value.ToString(), unitPrice) Then
                            ' تعريف الأعمدة الأربعة الخاصة بالكميات
                            Dim quantityColumns() As String = {"Quantity_ElWarad", "Quantity_ElMonsarf", "Quantity_MortagaaElMawarden", "Quantity_MortagaaOmalaa"}
                            Dim validQuantity As Double = 0.0

                            ' العثور على الكمية الأكبر من 0.00 وضربها في سعر الوحدة
                            For Each column As String In quantityColumns
                                If dgv_Tbl_InvoiceItems.Rows(rowIndex).Cells(column).Value IsNot Nothing Then
                                    Dim quantity As Double
                                    If Double.TryParse(dgv_Tbl_InvoiceItems.Rows(rowIndex).Cells(column).Value.ToString(), quantity) AndAlso quantity > 0.0 Then
                                        validQuantity = quantity
                                        Exit For ' الخروج من الحلقة بعد العثور على الكمية الصحيحة
                                    End If
                                End If
                            Next

                            ' حساب قيمة الفاتورة الإجمالية لهذا الصف
                            dgv_Tbl_InvoiceItems.Rows(rowIndex).Cells("Total_Invoice_Value").Value = unitPrice * validQuantity

                            ' حساب القيمة الإجمالية لجميع الفواتير
                            Dim totalInvoiceValue As Double = 0.0
                            For Each row As DataGridViewRow In dgv_Tbl_InvoiceItems.Rows
                                If Not row.IsNewRow Then
                                    If row.Cells("Total_Invoice_Value").Value IsNot Nothing Then
                                        Dim totalUnitPrice As Double
                                        If Double.TryParse(row.Cells("Total_Invoice_Value").Value.ToString(), totalUnitPrice) Then
                                            totalInvoiceValue += totalUnitPrice
                                        Else
                                            ' في حالة وجود قيم غير صالحة، يمكنك اتخاذ إجراء مناسب هنا، مثل عرض رسالة خطأ
                                        End If
                                    End If
                                End If
                            Next
                            Total_Invoice_Value.Text = totalInvoiceValue.ToString()
                        Else
                            ' في حالة وجود قيم غير صالحة، يمكنك اتخاذ إجراء مناسب هنا، مثل عرض رسالة خطأ
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("حدث خطأ: " & ex.Message)
        End Try
    End Sub

    Public Sub Update_Tbl_Invoices(ByVal Total_Invoice_Value As Double, ByVal Invoice_NumberW As String)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_Invoices Set Total_Invoice_Value = @Total_Invoice_Value Where Invoice_Number = @Invoice_Number"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Total_Invoice_Value", SqlDbType.Decimal).Value = Total_Invoice_Value
            .Parameters.AddWithValue("@Invoice_Number", SqlDbType.VarChar).Value = Invoice_NumberW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    'Private Sub Btn_Edit_UnitPrise_Click(sender As Object, e As EventArgs) Handles Btn_Edit_UnitPrise.Click
    '    Try
    '        ' التحقق من صحة البيانات المُدخلة مبكرًا
    '        If String.IsNullOrWhiteSpace(Invoice_Number.Text) Then
    '            MessageBox.Show("يرجى إدخال رقم الفاتورة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
    '            Exit Sub
    '        End If
    '        ' التحقق من وجود صفوف
    '        If dgv_Tbl_InvoiceItems.Rows.Count <= 1 Then
    '            MessageBox.Show("يرجى اختيار صنف واحد على الاقل فى الاذن", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
    '            Exit Sub
    '        End If
    '        If Con.State = ConnectionState.Closed Then
    '            Con.Open()
    '        End If
    '        Dim Total_InvoiceValue As Double = GetDecimalValue(Total_Invoice_Value.Text)
    '        ' إدراج بيانات الفاتورة الرئيسية
    '        Dim Invoice_Type As String = "اذن صرف"
    '        Dim Customer_IDValue As Integer = GetIntegerValue(Customer_ID.SelectedValue)
    '        Update_Tbl_Invoices(Total_Invoice_Value.Text, Invoice_Number.Text)
    '        Con.Open()
    '        ' حلقة لإدراج بيانات الأصناف
    '        For Each row As DataGridViewRow In dgv_Tbl_InvoiceItems.Rows
    '            If Not row.IsNewRow Then
    '                'عاوز اضيف هنا الحقول الجديدة اللى ضفتها فى قاعدة البيانات
    '                Using cmd As New SqlCommand("Update Tbl_InvoiceItems Set Unit_Price = @Unit_Price , Total_Invoice_Value = @Total_Invoice_Value where Invoice_Code_Programing = @Invoice_Code_Programing ", Con)

    '                    ' التحقق من وجود قيمة لـ Product_ID
    '                    If Not row.Cells("Invoice_Code_Programing").Value Is DBNull.Value Then
    '                        cmd.Parameters.AddWithValue("@Invoice_Code_Programing", row.Cells("Invoice_Code_Programing").Value)
    '                    Else
    '                        MessageBox.Show("حدث خطأ: لم يتم توفير Product_ID")
    '                        Exit Sub
    '                    End If
    '                    If Not row.Cells("Product_ID").Value Is DBNull.Value Then
    '                        cmd.Parameters.AddWithValue("@Product_ID", row.Cells("Product_ID").Value)
    '                    Else
    '                        MessageBox.Show("حدث خطأ: لم يتم توفير Product_ID")
    '                        Exit Sub
    '                    End If

    '                    If String.IsNullOrEmpty(row.Cells("Unit_Price").Value) Then
    '                        cmd.Parameters.AddWithValue("@Unit_Price", 0.00)
    '                    Else
    '                        cmd.Parameters.AddWithValue("@Unit_Price", row.Cells("Unit_Price").Value)
    '                    End If
    '                    cmd.CommandType = CommandType.Text
    '                    cmd.CommandTimeout = 420
    '                    cmd.ExecuteNonQuery()
    '                End Using
    '            End If
    '        Next
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
    '    End Try
    '    'دى اخر حاجه وقفت عندها لسه عليها شغل 

    '    clearControls()
    'End Sub


    Private Sub Btn_Edit_UnitPrise_Click(sender As Object, e As EventArgs) Handles Btn_Edit_UnitPrise.Click
        Try
            ' التحقق من صحة البيانات المُدخلة
            If String.IsNullOrWhiteSpace(Invoice_Number.Text) Then
                MessageBox.Show("يرجى إدخال رقم الفاتورة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                Exit Sub
            End If

            ' التحقق من وجود صفوف
            If dgv_Tbl_InvoiceItems.Rows.Count <= 1 Then
                MessageBox.Show("يرجى اختيار صنف واحد على الاقل فى الاذن", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                Exit Sub
            End If
            Con.Open()
            ' إدراج بيانات الفاتورة الرئيسية
            Dim Total_InvoiceValue As Double = GetDecimalValue(Total_Invoice_Value.Text)
            Dim Invoice_Type As String = "اذن صرف"
            Dim Customer_IDValue As Integer = GetIntegerValue(Customer_ID.SelectedValue)
            Update_Tbl_Invoices(Total_Invoice_Value.Text, Invoice_Number.Text)
            Con.Open()
            ' حلقة لإدراج بيانات الأصناف
            For Each row As DataGridViewRow In dgv_Tbl_InvoiceItems.Rows
                If Not row.IsNewRow Then
                    ' التحقق من وجود قيمة لـ Invoice_Code_Programing و Product_ID
                    If IsDBNull(row.Cells("Invoice_Code_Programing").Value) Then
                        MessageBox.Show("حدث خطأ: لم يتم توفير Invoice_Code_Programing")
                        Exit Sub
                    End If
                    If IsDBNull(row.Cells("Product_ID").Value) Then
                        MessageBox.Show("حدث خطأ: لم يتم توفير Product_ID")
                        Exit Sub
                    End If

                    ' استخدام Using لإدارة أمر SQL
                    Using cmd As New SqlCommand("Update Tbl_InvoiceItems Set Unit_Price = @Unit_Price, Total_Invoice_Value = @Total_Invoice_Value WHERE Invoice_Code_Programing = @Invoice_Code_Programing", Con)
                        ' إعداد المعلمات للأمر
                        cmd.Parameters.Add("@Invoice_Code_Programing", SqlDbType.VarChar).Value = row.Cells("Invoice_Code_Programing").Value
                        cmd.Parameters.Add("@Product_ID", SqlDbType.Int).Value = row.Cells("Product_ID").Value

                        ' تحقق من وحدة السعر وتعيينها كـ 0.00 إذا كانت فارغة
                        Dim unitPrice As Object = If(IsDBNull(row.Cells("Unit_Price").Value), 0.00, row.Cells("Unit_Price").Value)
                        cmd.Parameters.Add("@Unit_Price", SqlDbType.Decimal).Value = unitPrice

                        Dim TotalInvoiceValue As Object = If(IsDBNull(row.Cells("Total_Invoice_Value").Value), 0.00, row.Cells("Total_Invoice_Value").Value)
                        cmd.Parameters.Add("@Total_Invoice_Value", SqlDbType.Decimal).Value = TotalInvoiceValue
                        ' تعيين نوع الأمر وتنفيذه
                        cmd.CommandType = CommandType.Text
                        cmd.CommandTimeout = 420
                        cmd.ExecuteNonQuery()
                    End Using
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        End Try
        Con.Close()
        ' تنظيف الحقول بعد الانتهاء
        clearControls()
    End Sub




End Class