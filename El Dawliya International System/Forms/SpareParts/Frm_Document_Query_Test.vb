Imports System.Data.SqlClient
Imports El_Dawliya_International_System.El_Dawliya_International_System.Forms.Report

Public Class Frm_Document_Query_Test
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

    Private Sub ConfigureDataGridViewColumns(dgv As DataGridView, dt As DataTable)
        Try
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
                        Case "Quantity_ElWarad", "Quantity_ElMonsarf", "Quantity_MortagaaElMawarden", "Quantity_MortagaaOmalaa", "Recipient"
                            .Columns(columnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        Case "Unit_Name"
                            .Columns(columnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                        Case "Invoice_Code_Programing", "Invoice_ID", "Invoice_Number", "Invoice_Date", "Invoice_Type", "Unit_ID", "ReturnInvoiceNumber", "Balance_Time_Entry", "Data_Entry_Date", "Data_Entry_By", "Machine_Unit", "Notes", "Unit_Price", "Total_Invoice_Value"
                            .Columns(columnIndex).Visible = False
                    End Select
                Next
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Frm_Document_Query_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyPermissions(Me.Name)
        CustomizeForm(Me)
        Me.Txt_UserID.Text = loggedInUserID
        Me.Txt_User.Text = loggedInUserName

        If Me.Txt_UserID.Text = 1 Or Me.Txt_UserID.Text = 7 Or Me.Txt_UserID.Text = 9 Then
            Btn_Show_Edit_Price.Visible = True
        Else
            Btn_Show_Edit_Price.Visible = False
        End If

        SelectAll_Tbl_InvoiceItems(dgv_Tbl_InvoiceItems)
        fillcmb_Tbl_Customers(Customer_ID)
        fillcmb_Tbl_Suppliers(Supplier_ID)
        Invoice_Number.Focus()
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
        SelectAll_Tbl_InvoiceItems(dgv_Tbl_InvoiceItems)
        Select Case Invoice_Type.Text
            Case "اذن صرف"
                ConfigureDataGridViewColumnsEznCustomer(dgv_Tbl_InvoiceItems, dt_Tbl_InvoiceItems)
                'Supplier_IDlbl.Visible = False
                'Supplier_ID.Visible = False
                'Customer_IDLbl.Visible = True
                'Customer_ID.Visible = True

                Supplier_IDlbl.Enabled = False
                Supplier_ID.Enabled = False
                Customer_IDLbl.Enabled = True
                Customer_ID.Enabled = True
            Case "اذن وارد"
                ConfigureDataGridViewColumnsEznSuppliers(dgv_Tbl_InvoiceItems, dt_Tbl_InvoiceItems)
                'Supplier_IDlbl.Visible = True
                'Supplier_ID.Visible = True
                'Customer_IDLbl.Visible = False
                'Customer_ID.Visible = False

                Supplier_IDlbl.Enabled = True
                Supplier_ID.Enabled = True
                Customer_IDLbl.Enabled = False
                Customer_ID.Enabled = False

            Case "اذن مرتجع عميل"
                ConfigureDataGridViewColumnsMortagaaCustomer(dgv_Tbl_InvoiceItems, dt_Tbl_InvoiceItems)
                'Supplier_IDlbl.Visible = False
                'Supplier_ID.Visible = False
                'Customer_IDLbl.Visible = True
                'Customer_ID.Visible = True

                Supplier_IDlbl.Enabled = False
                Supplier_ID.Enabled = False
                Customer_IDLbl.Enabled = True
                Customer_ID.Enabled = True

            Case "اذن مرتجع مورد"
                ConfigureDataGridViewColumnsMortagaaSuppliers(dgv_Tbl_InvoiceItems, dt_Tbl_InvoiceItems)
                'Supplier_IDlbl.Visible = True
                'Supplier_ID.Visible = True
                'Customer_IDLbl.Visible = False
                'Customer_ID.Visible = False


                Supplier_IDlbl.Enabled = True
                Supplier_ID.Enabled = True
                Customer_IDLbl.Enabled = False
                Customer_ID.Enabled = False
        End Select
        Me.Invoice_Number.Location = New Point(1256, 43)

    End Sub

    'Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
    '    clearControls()
    'End Sub

    Private Sub Invoice_Type_Search_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Invoice_Type_Search.SelectedIndexChanged
        Select Case Invoice_Type_Search.Text
            Case "اذن صرف"
                Label1.Text = "استعلام اذون صرف الى العملاء"
                dgv_Tbl_InvoiceItems.DataSource = Nothing
                SelectAll_Ezn_Customer(dgv_Tbl_InvoiceItems)
                ConfigureDataGridViewColumnsEznCustomer(dgv_Tbl_InvoiceItems, dt_Tbl_Ezn_Customer)
                'Supplier_IDlbl.Visible = False
                'Supplier_ID.Visible = False
                'Customer_IDLbl.Visible = True
                'Customer_ID.Visible = True

                Supplier_IDlbl.Enabled = False
                Supplier_ID.Enabled = False
                Customer_IDLbl.Enabled = True
                Customer_ID.Enabled = True

            Case "اذن وارد"
                Label1.Text = "استعلام اذون وراد من الموردين"
                dgv_Tbl_InvoiceItems.DataSource = Nothing
                SelectAll_Ezn_Suppliers(dgv_Tbl_InvoiceItems)
                ConfigureDataGridViewColumnsEznSuppliers(dgv_Tbl_InvoiceItems, dt_Tbl_Ezn_Customer)
                'Supplier_IDlbl.Visible = True
                'Supplier_ID.Visible = True
                'Customer_IDLbl.Visible = False
                'Customer_ID.Visible = False

                Supplier_IDlbl.Enabled = True
                Supplier_ID.Enabled = True
                Customer_IDLbl.Enabled = False
                Customer_ID.Enabled = False
            Case "اذن مرتجع عميل"
                Label1.Text = "استعلام اذون مرتجعات من العملاء"
                dgv_Tbl_InvoiceItems.DataSource = Nothing
                SelectAll_Ezn_Customer(dgv_Tbl_InvoiceItems)
                ConfigureDataGridViewColumnsMortagaaCustomer(dgv_Tbl_InvoiceItems, dt_Tbl_Ezn_Customer)
                'Supplier_IDlbl.Visible = False
                'Supplier_ID.Visible = False
                'Customer_IDLbl.Visible = True
                'Customer_ID.Visible = True

                Supplier_IDlbl.Enabled = False
                Supplier_ID.Enabled = False
                Customer_IDLbl.Enabled = True
                Customer_ID.Enabled = True

            Case "اذن مرتجع مورد"
                Label1.Text = "استعلام اذون مرتجعات من الموردين"
                dgv_Tbl_InvoiceItems.DataSource = Nothing
                SelectAll_Ezn_Suppliers(dgv_Tbl_InvoiceItems)
                ConfigureDataGridViewColumnsMortagaaSuppliers(dgv_Tbl_InvoiceItems, dt_Tbl_Ezn_Customer)
                'Supplier_IDlbl.Visible = True
                'Supplier_ID.Visible = True
                'Customer_IDLbl.Visible = False
                'Customer_ID.Visible = False

                Supplier_IDlbl.Enabled = True
                Supplier_ID.Enabled = True
                Customer_IDLbl.Enabled = False
                Customer_ID.Enabled = False
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
        'dt_Tbl_Ezn_Customer.Clear()
        'Dim commandText As String = "SELECT ROW_NUMBER() OVER (ORDER BY Tbl_InvoiceItems.Invoice_Date) AS RowNumber,
        ' Tbl_InvoiceItems.*,
        ' Tbl_Units_SpareParts.Unit_Name,
        ' Tbl_Customers.Customer_Name
        ' FROM Tbl_InvoiceItems 
        '    INNER JOIN Tbl_Invoices ON Tbl_InvoiceItems.Invoice_Number = Tbl_Invoices.Invoice_Number 
        '    INNER JOIN Tbl_Customers ON Tbl_Invoices.Customer_ID = Tbl_Customers.Customer_ID 
        '    INNER JOIN Tbl_Units_SpareParts ON Tbl_InvoiceItems.Unit_ID = Tbl_Units_SpareParts.Unit_ID
        '         WHERE Tbl_InvoiceItems.Invoice_Type = @Invoice_Type"

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

    Private Sub ConfigureDataGridViewColumnsEznSuppliers_Admin(dgv As DataGridView, Ta As DataTable)
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
                    Case "RowNumber", "Invoice_Date", "Invoice_Number", "Product_ID", "Quantity_ElWarad", "Unit_Name", "Unit_Price", "Total_Invoice_Value"
                        .Columns(columnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    Case "Quantity_MortagaaElMawarden", "Quantity_MortagaaOmalaa", "Quantity_ElMonsarf", "Invoice_Type", "Unit_ID", "Recipient", "Customer_Name", "ReturnInvoiceNumber", "Data_Entry_Date", "Data_Entry_By", "Invoice_Code_Programing", "Invoice_ID", "Received_Machine", "Balance_Time_Entry", "Machine_Unit", "Notes"
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
                    Case "Quantity_MortagaaElMawarden", "Quantity_MortagaaOmalaa", "Quantity_ElWarad", "Invoice_Type", "Unit_Price", "Unit_ID", "Customer_Name", "ReturnInvoiceNumber", "Total_Invoice_Value", "Data_Entry_Date", "Data_Entry_By", "Invoice_Code_Programing", "Invoice_ID", "Received_Machine", "Balance_Time_Entry"
                        .Columns(columnIndex).Visible = False
                End Select
            Next
        End With
    End Sub

    Private Sub ConfigureDataGridViewColumnsEznCustomer_Admin(dgv As DataGridView, Ta As DataTable)
        With dgv
            For Each col As DataColumn In Ta.Columns
                Dim columnIndex As Integer = Ta.Columns.IndexOf(col)
                .Columns(columnIndex).HeaderText = GetColumnHeaderName(col.ColumnName)
                ' Set other column properties based on column name
                Select Case col.ColumnName
                    Case "Product_Name"
                        .Columns(columnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    Case "RowNumber", "Invoice_Date", "Invoice_Number", "Product_ID", "Quantity_ElMonsarf", "Unit_Name", "Recipient", "Unit_Price", "Total_Invoice_Value"
                        .Columns(columnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    Case "Quantity_MortagaaElMawarden", "Quantity_MortagaaOmalaa", "Quantity_ElWarad", "Invoice_Type", "Unit_ID", "Customer_Name", "ReturnInvoiceNumber", "Data_Entry_Date", "Data_Entry_By", "Invoice_Code_Programing", "Invoice_ID", "Received_Machine", "Balance_Time_Entry"
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

    Private Sub ConfigureDataGridViewColumnsMortagaaCustomer_Admin(dgv As DataGridView, Ta As DataTable)
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
                    Case "RowNumber", "Invoice_Date", "Invoice_Number", "Product_ID", "Quantity_MortagaaOmalaa", "Unit_Name", "Unit_Price", "Total_Invoice_Value"
                        .Columns(columnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    Case "Quantity_MortagaaElMawarden", "Quantity_ElWarad", "Quantity_ElMonsarf", "Invoice_Type", "Unit_ID", "Customer_Name", "ReturnInvoiceNumber", "Data_Entry_Date", "Data_Entry_By", "Invoice_Code_Programing", "Invoice_ID", "Received_Machine", "Balance_Time_Entry", "Recipient", "Machine_Unit", "Notes"
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

    Private Sub ConfigureDataGridViewColumnsMortagaaSuppliers_Admin(dgv As DataGridView, Ta As DataTable)
        With dgv
            For Each col As DataColumn In Ta.Columns
                Dim columnIndex As Integer = Ta.Columns.IndexOf(col)
                .Columns(columnIndex).HeaderText = GetColumnHeaderName(col.ColumnName)
                ' Set other column properties based on column name
                Select Case col.ColumnName
                    Case "Product_Name"
                        .Columns(columnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    Case "RowNumber", "Invoice_Date", "Invoice_Number", "Product_ID", "Quantity_MortagaaElMawarden", "Unit_Name", "Unit_Price", "Total_Invoice_Value"
                        .Columns(columnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    Case "Quantity_MortagaaOmalaa", "Quantity_ElWarad", "Quantity_ElMonsarf", "Invoice_Type", "Unit_ID", "Customer_Name", "ReturnInvoiceNumber", "Data_Entry_Date", "Data_Entry_By", "Invoice_Code_Programing", "Invoice_ID", "Received_Machine", "Balance_Time_Entry", "Recipient", "Machine_Unit", "Notes"
                        .Columns(columnIndex).Visible = False
                End Select
            Next
        End With
    End Sub

    Private Sub Invoice_Number_Enter(sender As Object, e As EventArgs) Handles Invoice_Number.Enter
        Label1.Text = "استعلام مستند"
    End Sub

    Private Sub dgv_Tbl_InvoiceItems_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Tbl_InvoiceItems.CellContentClick
        Invoice_Number.Text = dgv_Tbl_InvoiceItems.CurrentRow.Cells("Invoice_Number").Value
        Invoice_Number_KeyDown(sender, New KeyEventArgs(Keys.Enter))
    End Sub

    Private Sub FillReportAndPrint()
        Dim rep As New Rep_EznSarf_Document_Query
        rep.SetDataSource(dt_Tbl_InvoiceItems.DefaultView)
        Frm_Report.CrystalReportViewer1.ReportSource = rep
        rep.Section2.SectionFormat.BackgroundColor = Color.Fuchsia
        Frm_Report.CrystalReportViewer1.Refresh()
        Frm_Report.ShowDialog()
    End Sub

    Private Sub Btn_Print_Click(sender As Object, e As EventArgs) Handles Btn_Print.Click
        '-------------------------------------------------------------------------------------------------------
        'خاص بتطبيق الصلاحيات
        If Not CanPrint Then
            MessageBox.Show("ليس لديك صلاحية الطباعة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        '-------------------------------------------------------------------------------------------------------

        FillReportAndPrint()
    End Sub

    Private Sub Btn_ExportToExcel_Click(sender As Object, e As EventArgs) Handles Btn_ExportToExcel.Click

        '-------------------------------------------------------------------------------------------------------
        'خاص بتطبيق الصلاحيات
        If Not CanPrint Then
            MessageBox.Show("ليس لديك صلاحية الطباعة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        '-------------------------------------------------------------------------------------------------------
        Dim saveDialog As New SaveFileDialog()
        saveDialog.Filter = "Excel Files|*.xlsx;*.xls"
        saveDialog.Title = "E:\El Dawliya International System\Excel"
        If saveDialog.ShowDialog() = DialogResult.OK Then
            ' استدعاء الدالة ExportToExcel مع تمرير قائمة الأعمدة المرغوب تصديرها
            ExportVisibleColumnsToExcel(dgv_Tbl_InvoiceItems, saveDialog.FileName)
        End If
    End Sub

    Private Sub Btn_Show_Edit_Price_Click(sender As Object, e As EventArgs) Handles Btn_Show_Edit_Price.Click
        Frm_Document_Query_Admin.Show()
        Me.Close()
    End Sub
End Class