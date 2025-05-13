Imports System.Data.SqlClient
Public Class Document_Edit
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Public dt_Tbl_InvoiceItems As New DataTable
    Public dt_Tbl_Ezn_Customer As New DataTable
    Private originalQuantityElWarad As Decimal
    Private originalQuantityElMonsarf As Decimal
    Private originalQuantityMortagaaElMawarden As Decimal
    Private originalQuantityMortagaaOmalaa As Decimal

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

        'SelectAll_Tbl_InvoiceItems(dgv_Tbl_InvoiceItems)
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

    Private Function GetDecimalValueFromCell(cell As DataGridViewCell) As Decimal
        If IsDBNull(cell.Value) OrElse cell.Value Is Nothing Then
            Return 0.00
        End If
        Return Convert.ToDecimal(cell.Value)
    End Function

    Private Function GetInt32ValueFromCell(cell As DataGridViewCell) As Integer
        If IsDBNull(cell.Value) OrElse cell.Value Is Nothing Then
            Return 0
        End If
        Return Convert.ToInt32(cell.Value)
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
                            Invoice_ID.Text = GetValueOrDefault(reader("Invoice_ID"))
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

    Private Sub ConfigureDataGridViewColumns(dgv As DataGridView, dt As DataTable)
        With dgv
            For Each col As DataGridViewColumn In .Columns
                Select Case col.Name
                    Case "Product_Name"
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    Case "Quantity_ElWarad", "Quantity_ElMonsarf", "Quantity_MortagaaElMawarden", "Quantity_MortagaaOmalaa", "Recipient", "Product_ID", "Unit_Name", "EditButton", "DeleteButton"
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    Case "Invoice_Code_Programing", "Invoice_ID", "Invoice_Number", "Unit_Price", "Invoice_Date", "Invoice_Type", "Unit_ID", "ReturnInvoiceNumber", "Total_Invoice_Value", "Balance_Time_Entry", "Data_Entry_Date", "Data_Entry_By", "Machine_Unit", "Notes"
                        col.Visible = False
                End Select
            Next
        End With
    End Sub

    Public Sub SelectAll_Tbl_InvoiceItems(dgv As DataGridView)
        dt_Tbl_InvoiceItems.Clear()
        dgv_Tbl_InvoiceItems.DataSource = Nothing

        ' تنفيذ الاستعلام وملء DataTable بالبيانات
        Dim commandText As String = "SELECT Tbl_InvoiceItems.*, Tbl_Units_SpareParts.Unit_Name 
                                 FROM Tbl_InvoiceItems 
                                 INNER JOIN Tbl_Units_SpareParts ON Tbl_InvoiceItems.Unit_ID = Tbl_Units_SpareParts.Unit_ID
                                 WHERE Tbl_InvoiceItems.Invoice_Number = @InvoiceNumber
                                 ORDER BY Tbl_InvoiceItems.Invoice_Date;"
        Dim command As New SqlCommand(commandText, Con)
        command.Parameters.AddWithValue("@InvoiceNumber", Invoice_Number.Text)
        Dim da As New SqlDataAdapter(command)
        da.Fill(dt_Tbl_InvoiceItems)
        dgv.DataSource = dt_Tbl_InvoiceItems
        ' تعيين أسماء العناوين لكل عمود
        ' إضافة أعمدة الأزرار مرة واحدة فقط بعد تعيين مصدر البيانات
        ' تعيين DataTable كمصدر بيانات لـ DataGridView
        If dgv_Tbl_InvoiceItems.Columns("EditButton") Is Nothing Then
            Dim btnEdit As New DataGridViewButtonColumn()
            btnEdit.Name = "EditButton"
            btnEdit.HeaderText = "تعديل"
            btnEdit.Text = "تعديل"
            btnEdit.UseColumnTextForButtonValue = True
            dgv_Tbl_InvoiceItems.Columns.Add(btnEdit)
        End If

        If dgv_Tbl_InvoiceItems.Columns("DeleteButton") Is Nothing Then
            Dim btnDelete As New DataGridViewButtonColumn()
            btnDelete.Name = "DeleteButton"
            btnDelete.HeaderText = "حذف"
            btnDelete.Text = "حذف"
            btnDelete.UseColumnTextForButtonValue = True
            dgv_Tbl_InvoiceItems.Columns.Add(btnDelete)
        End If
        dgv_Tbl_InvoiceItems.Columns("EditButton").DisplayIndex = dgv_Tbl_InvoiceItems.ColumnCount - 1
        dgv_Tbl_InvoiceItems.Columns("DeleteButton").DisplayIndex = dgv_Tbl_InvoiceItems.ColumnCount - 1
        With dgv
            For Each col As DataGridViewColumn In .Columns
                col.HeaderText = GetColumnHeaderName(col.Name)
            Next
        End With
        ' تخصيص إعدادات الأعمدة حسب الحاجة
        ConfigureDataGridViewColumns(dgv_Tbl_InvoiceItems, dt_Tbl_InvoiceItems)
    End Sub

    Private Sub Invoice_Number_KeyDown(sender As Object, e As KeyEventArgs) Handles Invoice_Number.KeyDown
        ' التأكد من أن المفتاح المضغوط هو مفتاح Enter
        If e.KeyCode = Keys.Enter Then
            ' تنفيذ الكود لاسترداد بيانات الفاتورة
            RetrieveInvoiceData(Invoice_Number.Text)
        End If
        ' تعبئة البيانات في DataGridView
        SelectAll_Tbl_InvoiceItems(dgv_Tbl_InvoiceItems)
        ' تخصيص عرض الحقول بناءً على نوع الفاتورة
        Select Case Invoice_Type.Text
            Case "اذن صرف"
                Supplier_IDlbl.Visible = False
                Supplier_ID.Visible = False
                Customer_IDLbl.Visible = True
                Customer_ID.Visible = True
            Case "اذن وارد"
                Supplier_IDlbl.Visible = True
                Supplier_ID.Visible = True
                Customer_IDLbl.Visible = False
                Customer_ID.Visible = False
            Case "اذن مرتجع عميل"
                Supplier_IDlbl.Visible = False
                Supplier_ID.Visible = False
                Customer_IDLbl.Visible = True
                Customer_ID.Visible = True
            Case "اذن مرتجع مورد"
                Supplier_IDlbl.Visible = True
                Supplier_ID.Visible = True
                Customer_IDLbl.Visible = False
                Customer_ID.Visible = False
        End Select

    End Sub


    Private Sub dgv_Tbl_InvoiceItems_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Tbl_InvoiceItems.CellContentClick
        ' التأكد من أن الضغط تم على زر وليس على خلية أخرى
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = dgv_Tbl_InvoiceItems.Rows(e.RowIndex)

            ' التحقق إذا كان الزر المضغوط هو زر التعديل
            If dgv_Tbl_InvoiceItems.Columns(e.ColumnIndex).Name = "EditButton" Then
                ' تنفيذ كود التعديل للسطر المحدد
                EditRow(selectedRow)

                ' التحقق إذا كان الزر المضغوط هو زر الحذف
            ElseIf dgv_Tbl_InvoiceItems.Columns(e.ColumnIndex).Name = "DeleteButton" Then
                ' تنفيذ كود الحذف للسطر المحدد
                DeleteRow(selectedRow)
            End If
        End If
    End Sub

    Private Sub EditRow(row As DataGridViewRow)
        ' هنا يمكنك تنفيذ كود التعديل حسب المطلوب، على سبيل المثال:
        ' عرض نافذة لتعديل البيانات، أو تعديل الخلايا مباشرةً
        ' مثال بسيط لتعديل القيمة في عمود معين
        row.Cells("اسم_العمود").Value = "قيمة جديدة" ' يجب استبدال "اسم_العمود" بالاسم الفعلي للعمود
        ' تأكيد حفظ التعديلات إذا كان هناك قاعدة بيانات
    End Sub

    Private Sub DeleteRow(row As DataGridViewRow)
        ' هنا يمكنك تنفيذ كود الحذف حسب المطلوب
        ' مثال بسيط لحذف السطر من DataGridView
        dgv_Tbl_InvoiceItems.Rows.Remove(row)
        ' تأكيد الحذف من قاعدة البيانات إذا كان ذلك ضرورياً
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
        Dim commandText As String = "SELECT Tbl_InvoiceItems.*,
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
        Dim columnsOrder() As String = {"Invoice_Date", "Invoice_Number", "Product_ID", "Product_Name", "Unit_ID", "Unit_Name", "Quantity_ElMonsarf", "Quantity_ElWarad", "Quantity_MortagaaElMawarden", "Quantity_MortagaaOmalaa", "Unit_Price", "Invoice_Type", "ReturnInvoiceNumber", "Balance_Time_Entry", "Data_Entry_Date", "Data_Entry_By", "Invoice_Code_Programing", "Invoice_ID", "Total_Invoice_Value"}
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
        Dim commandText As String = "SELECT Tbl_InvoiceItems.*,
                 Tbl_Units_SpareParts.Unit_Name
                 FROM Tbl_InvoiceItems 
                 INNER JOIN Tbl_Units_SpareParts ON Tbl_InvoiceItems.Unit_ID = Tbl_Units_SpareParts.Unit_ID
                 WHERE Tbl_InvoiceItems.Invoice_Type = @Invoice_Type
                 ORDER BY Tbl_InvoiceItems.Invoice_Number;"
        Dim command As New SqlCommand(commandText, Con)
        command.Parameters.AddWithValue("@Invoice_Type", Invoice_Type_Search.Text)
        Dim daa As New SqlDataAdapter(command)
        daa.Fill(dt_Tbl_Ezn_Customer)
        'تحديد ترتيب الأعمدة باستخدام الاسم النصي
        Dim columnsOrder() As String = {"Invoice_Date", "Invoice_Number", "Product_ID", "Product_Name", "Unit_ID", "Unit_Name", "Quantity_ElMonsarf", "Quantity_ElWarad", "Quantity_MortagaaElMawarden", "Quantity_MortagaaOmalaa", "Unit_Price", "Invoice_Type", "Recipient", "ReturnInvoiceNumber", "Balance_Time_Entry", "Data_Entry_Date", "Data_Entry_By", "Invoice_Code_Programing", "Invoice_ID", "Total_Invoice_Value"}
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
            For Each col As DataColumn In Ta.Columns
                Dim columnIndex As Integer = Ta.Columns.IndexOf(col)
                .Columns(columnIndex).HeaderText = GetColumnHeaderName(col.ColumnName)
                Select Case col.ColumnName
                    Case "Product_Name"
                        .Columns(columnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    Case "RowNumber", "Invoice_Date", "Invoice_Number", "Product_ID", "Quantity_ElWarad", "Unit_Name", "EditButton", "DeleteButton"
                        .Columns(columnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    Case "Quantity_MortagaaElMawarden", "Quantity_MortagaaOmalaa", "Quantity_ElMonsarf", "Invoice_Type", "Unit_Price", "Unit_ID", "Recipient", "Customer_Name", "ReturnInvoiceNumber", "Total_Invoice_Value", "Data_Entry_Date", "Data_Entry_By", "Invoice_Code_Programing", "Invoice_ID", "Received_Machine", "Balance_Time_Entry", "Machine_Unit", "Notes"
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
                Select Case col.ColumnName
                    Case "Product_Name"
                        .Columns(columnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    Case "RowNumber", "Invoice_Date", "Invoice_Number", "Product_ID", "Quantity_ElMonsarf", "Unit_Name", "Recipient", "EditButton", "DeleteButton"
                        .Columns(columnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    Case "Quantity_MortagaaElMawarden", "Quantity_MortagaaOmalaa", "Quantity_ElWarad", "Invoice_Type", "Unit_Price", "Unit_ID", "Customer_Name", "ReturnInvoiceNumber", "Total_Invoice_Value", "Data_Entry_Date", "Data_Entry_By", "Invoice_Code_Programing", "Invoice_ID", "Received_Machine", "Balance_Time_Entry"
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
                Select Case col.ColumnName
                    Case "Product_Name"
                        .Columns(columnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                    Case "RowNumber", "Invoice_Date", "Invoice_Number", "Product_ID", "Quantity_MortagaaOmalaa", "Unit_Name", "EditButton", "DeleteButton"
                        .Columns(columnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    Case "Quantity_MortagaaElMawarden", "Quantity_ElWarad", "Quantity_ElMonsarf", "Invoice_Type", "Unit_Price", "Unit_ID", "Customer_Name", "ReturnInvoiceNumber", "Total_Invoice_Value", "Data_Entry_Date", "Data_Entry_By", "Invoice_Code_Programing", "Invoice_ID", "Received_Machine", "Balance_Time_Entry", "Recipient", "Machine_Unit", "Notes"
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
                    Case "RowNumber", "Invoice_Date", "Invoice_Number", "Product_ID", "Quantity_MortagaaElMawarden", "Unit_Name", "EditButton", "DeleteButton"
                        .Columns(columnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
                    Case "Quantity_MortagaaOmalaa", "Quantity_ElWarad", "Quantity_ElMonsarf", "Invoice_Type", "Unit_Price", "Unit_ID", "Customer_Name", "ReturnInvoiceNumber", "Total_Invoice_Value", "Data_Entry_Date", "Data_Entry_By", "Invoice_Code_Programing", "Invoice_ID", "Received_Machine", "Balance_Time_Entry", "Recipient", "Machine_Unit", "Notes"
                        .Columns(columnIndex).Visible = False
                End Select
            Next
        End With
    End Sub

    Public Sub Update_Tbl_Invoices(ByVal Invoice_Date As Date, ByVal NumberOfItems As Int32, ByVal Total_Invoice_Value As Double, ByVal Invoice_IDW As Int32)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_Invoices Set Invoice_Date = @Invoice_Date,NumberOfItems = @NumberOfItems,Total_Invoice_Value = @Total_Invoice_Value Where Invoice_ID = @Invoice_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Invoice_Date", SqlDbType.Date).Value = Invoice_Date
            .Parameters.AddWithValue("@NumberOfItems", SqlDbType.Int).Value = NumberOfItems
            '.Parameters.AddWithValue("@Recipient", SqlDbType.VarChar).Value = Recipient
            .Parameters.AddWithValue("@Total_Invoice_Value", SqlDbType.Decimal).Value = Total_Invoice_Value
            .Parameters.AddWithValue("@Invoice_ID", SqlDbType.Int).Value = Invoice_IDW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing

    End Sub

    Public Sub AddQty()
        If Con.State = ConnectionState.Closed Then
            Con.Open()
        End If
        Dim A As Decimal = dgv_Tbl_InvoiceItems.Rows(dgv_Tbl_InvoiceItems.CurrentRow.Index).Cells("Quantity_ElWarad").Value
        If A > originalQuantityElWarad Then
            A = A - originalQuantityElWarad
            Dim CmdUpdate As New SqlCommand
            With CmdUpdate
                .Connection = Con
                .CommandType = CommandType.Text
                .CommandText = "UPDATE Tbl_Products 
                                    SET QTE_IN_STOCK = QTE_IN_STOCK + @Quantity_ElWarad, ElWarad = ElWarad + @Quantity_ElWarad 
                                    WHERE Product_ID = @ProductID"
                .Parameters.AddWithValue("@Quantity_ElWarad", A)
                .Parameters.AddWithValue("@ProductID", dgv_Tbl_InvoiceItems.Rows(dgv_Tbl_InvoiceItems.CurrentRow.Index).Cells("Product_ID").Value)
                .Parameters("@Quantity_ElWarad").SqlDbType = SqlDbType.Decimal ' تحديد نوع البيانات
                .ExecuteNonQuery()
            End With
        ElseIf A < originalQuantityElWarad Then
            A = originalQuantityElWarad - A
            Dim CmdUpdate As New SqlCommand
            With CmdUpdate
                .Connection = Con
                .CommandType = CommandType.Text
                .CommandText = "UPDATE Tbl_Products 
                                    SET QTE_IN_STOCK = QTE_IN_STOCK - @Quantity_ElWarad, ElWarad = ElWarad - @Quantity_ElWarad 
                                    WHERE Product_ID = @ProductID"
                .Parameters.AddWithValue("@Quantity_ElWarad", A)
                .Parameters.AddWithValue("@ProductID", dgv_Tbl_InvoiceItems.Rows(dgv_Tbl_InvoiceItems.CurrentRow.Index).Cells("Product_ID").Value)
                .Parameters("@Quantity_ElWarad").SqlDbType = SqlDbType.Decimal ' تحديد نوع البيانات
                .ExecuteNonQuery()
            End With
        End If
        'End If
        'Next
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If
    End Sub

    Private Sub dgv_Tbl_InvoiceItems_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Tbl_InvoiceItems.CellEndEdit
        Try
            Dim selectedRow As DataGridViewRow = dgv_Tbl_InvoiceItems.Rows(e.RowIndex)

            ' تحقق من العمود Product_ID
            If e.ColumnIndex = dgv_Tbl_InvoiceItems.Columns("Product_ID").Index AndAlso e.RowIndex >= 0 Then
                Dim selectedProduct As String = If(dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("Product_ID").Value IsNot Nothing, dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("Product_ID").Value.ToString(), "")
                dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("Product_ID").Value = selectedProduct
                Dim query As String = "SELECT * FROM Tbl_Products WHERE Product_ID = @Product_ID "
                Using con As New SqlConnection(ConStr),
                  Command As New SqlCommand(query, con)
                    Command.Parameters.AddWithValue("@Product_ID", selectedProduct)
                    Try
                        con.Open()
                        Dim reader As SqlDataReader = Command.ExecuteReader()
                        If reader.Read() Then
                            dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("Product_Name").Value = reader("Product_Name").ToString()
                            dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("Balance_Time_Entry").Value = reader("QTE_IN_STOCK").ToString()
                            dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("Unit_ID").Value = reader("Unit_ID").ToString()
                            dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("Unit_Name").Value = reader("Unit_Name").ToString()
                            dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("Unit_Price").Value = reader("Unit_Price").ToString()
                        End If
                        reader.Close()
                    Catch ex As Exception
                        MessageBox.Show("حدث خطأ: " & ex.Message)
                    End Try
                End Using

                ' استدعاء UpdateDatabase بعد تحديث تفاصيل المنتج
                Dim InvoiceCodePrograming As Integer = CInt(selectedRow.Cells("Invoice_Code_Programing").Value)
                Dim ProductID As String = selectedRow.Cells("Product_ID").Value.ToString()
                Dim ProductName As String = selectedRow.Cells("Product_Name").Value.ToString()
                Dim UnitID As Integer = CInt(selectedRow.Cells("Unit_ID").Value)
                Dim UnitPrice As Decimal = CDec(selectedRow.Cells("Unit_Price").Value)
                'UpdateDatabase("Product_ID", UnitPrice, selectedProduct, ProductName, UnitID, InvoiceCodePrograming)
                UpdateDatabase("Unit_Price", UnitPrice, ProductID, ProductName, UnitID, InvoiceCodePrograming)
            End If

            ' تحقق من الأعمدة الأخرى
            Dim columnName As String = dgv_Tbl_InvoiceItems.Columns(e.ColumnIndex).Name
            If columnName = "Quantity_ElWarad" OrElse columnName = "Quantity_ElMonsarf" OrElse columnName = "Quantity_MortagaaElMawarden" OrElse columnName = "Quantity_MortagaaOmalaa" Then
                Dim row As DataGridViewRow = dgv_Tbl_InvoiceItems.Rows(e.RowIndex)
                If Not row.IsNewRow Then
                    Dim InvoiceCodePrograming As Integer = CInt(row.Cells("Invoice_Code_Programing").Value)
                    Dim oldValue As Decimal = If(row.Cells(columnName).Tag IsNot Nothing, CDec(row.Cells(columnName).Tag), 0) ' حفظ القيمة القديمة
                    Dim newValue As Decimal = CDec(row.Cells(columnName).Value) ' تعيين القيمة الجديدة
                    Dim ProductID As String = row.Cells("Product_ID").Value.ToString()
                    Dim ProductName As String = row.Cells("Product_Name").Value.ToString()
                    Dim UnitID As Integer = CInt(row.Cells("Unit_ID").Value)

                    ' تحديث قاعدة البيانات
                    UpdateDatabase(columnName, newValue, ProductID, ProductName, UnitID, InvoiceCodePrograming)

                    ' تحديث القيمة القديمة بالقيمة الجديدة
                    row.Cells(columnName).Tag = newValue
                End If
            End If
            ' تحديث عدد الأصناف
            NumberOfItems.Text = dgv_Tbl_InvoiceItems.Rows.Count - 1
        Catch ex As Exception
            MessageBox.Show("حدث خطأ: " & ex.Message)
        End Try
    End Sub

    Private Sub dgv_Tbl_InvoiceItems_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Tbl_InvoiceItems.CellValueChanged
        ' تحقق من صحة الفهرس
        If e.RowIndex >= 0 AndAlso e.RowIndex < dgv_Tbl_InvoiceItems.Rows.Count Then
            ' تحقق من الأعمدة المحددة
            Dim columnName As String = dgv_Tbl_InvoiceItems.Columns(e.ColumnIndex).Name
            If columnName = "Quantity_ElWarad" OrElse columnName = "Quantity_ElMonsarf" OrElse columnName = "Quantity_MortagaaElMawarden" OrElse columnName = "Quantity_MortagaaOmalaa" Then
                Dim row As DataGridViewRow = dgv_Tbl_InvoiceItems.Rows(e.RowIndex)
                If row.IsNewRow Then
                    MessageBox.Show("السطر جديد")
                Else
                    Dim InvoiceCodePrograming As Integer = CInt(row.Cells("Invoice_Code_Programing").Value)
                    Dim oldValue As Decimal = row.Cells(columnName).Tag ' حفظ القيمة القديمة
                    Dim newValue As Decimal = row.Cells(columnName).Value
                    Dim ProductID As String = (row.Cells("Product_ID").Value)
                    Dim ProductName As String = (row.Cells("Product_Name").Value)
                    Dim UnitID As Integer = (row.Cells("Unit_ID").Value)
                    UpdateDatabase(columnName, newValue, ProductID, ProductName, UnitID, InvoiceCodePrograming)
                    row.Cells(columnName).Tag = newValue ' تحديث القيمة القديمة بالقيمة الجديدة
                    Me.TextBox1.Text = newValue - oldValue
                End If
            End If
        End If
    End Sub

    Private Sub dgv_Tbl_InvoiceItems_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgv_Tbl_InvoiceItems.CellBeginEdit
        ' حفظ القيمة القديمة عند بدء التعديل
        If e.RowIndex >= 0 AndAlso e.RowIndex < dgv_Tbl_InvoiceItems.Rows.Count Then
            Dim row As DataGridViewRow = dgv_Tbl_InvoiceItems.Rows(e.RowIndex)
            Dim columnName As String = dgv_Tbl_InvoiceItems.Columns(e.ColumnIndex).Name
            If columnName = "Quantity_ElWarad" OrElse columnName = "Quantity_ElMonsarf" OrElse columnName = "Quantity_MortagaaElMawarden" OrElse columnName = "Quantity_MortagaaOmalaa" Then
                row.Cells(columnName).Tag = row.Cells(columnName).Value
            End If
        End If
    End Sub

    Private Sub UpdateDatabase(columnName As String, newValue As Decimal, ProductID As String, ProductName As String, UnitID As Integer, InvoiceCodePrograming As Integer)
        Using cmd As New SqlCommand("UPDATE Tbl_InvoiceItems SET " & columnName & " = @newValue,Product_ID = @ProductID,Product_Name = @ProductName,Unit_ID = @UnitID WHERE Invoice_Code_Programing = @InvoiceCodePrograming", Con)
            cmd.Parameters.AddWithValue("@newValue", newValue)
            cmd.Parameters.AddWithValue("@ProductID", ProductID)
            cmd.Parameters.AddWithValue("@ProductName", ProductName)
            cmd.Parameters.AddWithValue("@UnitID", UnitID)
            cmd.Parameters.AddWithValue("@InvoiceCodePrograming", InvoiceCodePrograming)
            Con.Open()
            cmd.ExecuteNonQuery()
            Con.Close()
        End Using
    End Sub

    Private Sub dgv_Tbl_InvoiceItems_RowValidated(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Tbl_InvoiceItems.RowValidated
        ' التحقق مما إذا كان السطر جديدًا
        Dim row As DataGridViewRow = dgv_Tbl_InvoiceItems.Rows(e.RowIndex)
        If row.IsNewRow Then
            ' جمع القيم من الخلايا
            Dim invoiceId As Integer = CInt(row.Cells("Invoice_ID").Value)
            Dim elWarad As Integer = CInt(row.Cells("Quantity_ElWarad").Value)
            Dim elMonsarf As Integer = CInt(row.Cells("Quantity_ElMonsarf").Value)
            Dim mortagaaElMawarden As Integer = CInt(row.Cells("Quantity_MortagaaElMawarden").Value)
            Dim mortagaaOmalaa As Integer = CInt(row.Cells("Quantity_MortagaaOmalaa").Value)
            ' إضافة السطر الجديد إلى قاعدة البيانات
            AddNewRow(invoiceId, elWarad, elMonsarf, mortagaaElMawarden, mortagaaOmalaa)
        End If
    End Sub

    Private Sub AddNewRow(invoiceId As Integer, elWarad As Integer, elMonsarf As Integer, mortagaaElMawarden As Integer, mortagaaOmalaa As Integer)
        Using cmd As New SqlCommand("INSERT INTO InvoiceItems (Invoice_ID, Quantity_ElWarad, Quantity_ElMonsarf, Quantity_MortagaaElMawarden, Quantity_MortagaaOmalaa) VALUES (@invoiceId, @elWarad, @elMonsarf, @mortagaaElMawarden, @mortagaaOmalaa)", Con)
            cmd.Parameters.AddWithValue("@invoiceId", invoiceId)
            cmd.Parameters.AddWithValue("@elWarad", elWarad)
            cmd.Parameters.AddWithValue("@elMonsarf", elMonsarf)
            cmd.Parameters.AddWithValue("@mortagaaElMawarden", mortagaaElMawarden)
            cmd.Parameters.AddWithValue("@mortagaaOmalaa", mortagaaOmalaa)
            Con.Open()
            cmd.ExecuteNonQuery()
            Con.Close()
        End Using
    End Sub


End Class

