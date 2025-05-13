Imports System.Data.SqlClient
Public Class Frm_Search_Item_Movement
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Public dt_Tbl_InvoiceItems As New DataTable
    Public dt_Products As New DataTable

    Private Sub ConfigureDataGridViewColumnsEznCustomer(dgv As DataGridView, Ta As DataTable)
        With dgv
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            For Each col As DataColumn In Ta.Columns
                Dim columnIndex As Integer = Ta.Columns.IndexOf(col)
                .Columns(columnIndex).HeaderText = GetColumnHeaderName(col.ColumnName)
                ' Set other column properties based on column name
                Select Case col.ColumnName
                    Case "Serial_Count", "Invoice_Date", "Invoice_Number", "Invoice_Type", "Unit_Name", "Quantity_ElWarad", "Quantity_ElMonsarf", "Quantity_MortagaaElMawarden", "Quantity_MortagaaOmalaa", "Balance_Time_Entry", "Customer_Name"
                    Case "Invoice_Code_Programing", "Invoice_ID", "Product_ID", "Product_Name", "Unit_ID", "Unit_Price", "ReturnInvoiceNumber", "Total_Invoice_Value", "Data_Entry_Date", "Data_Entry_By", "Received_Machine", "Customer_ID", "Supplier_ID", "Supplier_Name", "Recipient", "Machine_Unit", "Notes"
                        .Columns(columnIndex).Visible = False
                End Select
            Next
        End With
    End Sub

    Private Function GetColumnHeaderName(columnName As String) As String
        Select Case columnName
            Case "Serial_Count" : Return "م"
            Case "Invoice_Code_Programing" : Return "الكود البرمجى"
            Case "Invoice_ID" : Return "كود المستند"
            Case "Invoice_Number" : Return "رقم المستند"
            Case "Product_ID" : Return "كود الصنف"
            Case "Product_Name" : Return "اسم الصنف"
            Case "Quantity_ElWarad" : Return "الوراد"
            Case "Quantity_ElMonsarf" : Return "المنصرف"
            Case "Quantity_MortagaaElMawarden" : Return "مرتجع الموردين"
            Case "Quantity_MortagaaOmalaa" : Return "مرتجع العملاء"
            Case "Unit_ID" : Return "كود الوحدة"
            Case "Unit_Name" : Return "الوحدة"
            Case "Unit_Price" : Return "سعر الوحدة"
            Case "Invoice_Date" : Return "التاريخ"
            Case "Invoice_Type" : Return "نوع المستند"
            Case "ReturnInvoiceNumber" : Return "رقم مستند المرتجع"
            Case "Recipient" : Return "المستلم"
            Case "Total_Invoice_Value" : Return "الاجمالى الكلى"
            Case "Balance_Time_Entry" : Return "رصيد"
            Case "Data_Entry_Date" : Return "تاريخ الادخال"
            Case "Data_Entry_By" : Return "اسم المُدخل"
            Case "Customer_Name" : Return "القسم"
            Case "Supplier_Name" : Return "المورد"
            Case "Received_Machine" : Return "الماكينة"
            Case "Machine_Unit" : Return "جزء الماكينة"
            Case "Notes" : Return "بيان"
            Case Else : Return columnName
        End Select
    End Function

    Private Sub Retrieve_Item_Movement(ByVal Product_ID As String)
        'Dim query As String = "SELECT Tbl_InvoiceItems.*, Tbl_Products.Initial_Balance, Tbl_Products.QTE_IN_STOCK
        '            FROM  Tbl_InvoiceItems INNER JOIN
        '              Tbl_Invoices ON Tbl_InvoiceItems.Invoice_ID = Tbl_Invoices.Invoice_ID INNER JOIN
        '              Tbl_Products ON Tbl_InvoiceItems.Product_ID = Tbl_Products.Product_ID WHERE Tbl_InvoiceItems.Product_ID = @Product_ID"
        Dim query As String = "SELECT ROW_NUMBER() OVER(ORDER BY Tbl_InvoiceItems.Invoice_Date) AS Serial_Count, Tbl_InvoiceItems.*, Tbl_Products.Initial_Balance, Tbl_Products.QTE_IN_STOCK
                                FROM  Tbl_InvoiceItems INNER JOIN
                                Tbl_Invoices ON Tbl_InvoiceItems.Invoice_ID = Tbl_Invoices.Invoice_ID INNER JOIN
                                Tbl_Products ON Tbl_InvoiceItems.Product_ID = Tbl_Products.Product_ID 
                      WHERE Tbl_InvoiceItems.Product_ID = @Product_ID
                       ORDER BY Tbl_InvoiceItems.Invoice_Number,Tbl_InvoiceItems.Invoice_Date;"

        Using connection As New SqlConnection(ConStr)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Product_ID", Product_ID)
                Try
                    connection.Open()
                    Dim reader As SqlDataReader = command.ExecuteReader()
                    If reader.HasRows Then
                        While reader.Read()
                            Product_Name.Text = reader("Product_Name").ToString()
                            Balance.Text = reader("QTE_IN_STOCK").ToString()
                            Initial_Balance.Text = reader("Initial_Balance").ToString
                        End While
                    Else
                        MessageBox.Show("لم يتم العثور على معلومات لهذا الصنف")
                    End If
                Catch ex As Exception
                    MessageBox.Show("خطأ: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Public Sub SelectAll_Tbl_InvoiceItems(dgv As DataGridView)
        dt_Tbl_InvoiceItems.Clear()
        Dim commandText As String = "SELECT ROW_NUMBER() OVER(ORDER BY Tbl_InvoiceItems.Invoice_ID) AS Serial_Count, Tbl_InvoiceItems.*, 
                   Tbl_Invoices.Customer_ID, 
                   Tbl_Invoices.Supplier_ID,
                   Tbl_Customers.Customer_Name,
                   Tbl_Suppliers.Supplier_Name,
                   Tbl_Units_SpareParts.Unit_Name
                    FROM Tbl_Invoices 
                    INNER JOIN Tbl_InvoiceItems ON Tbl_Invoices.Invoice_ID = Tbl_InvoiceItems.Invoice_ID
                    LEFT JOIN Tbl_Customers ON Tbl_Invoices.Customer_ID = Tbl_Customers.Customer_ID
                    LEFT JOIN Tbl_Suppliers ON Tbl_Invoices.Supplier_ID = Tbl_Suppliers.Supplier_ID
                    LEFT JOIN Tbl_Units_SpareParts ON Tbl_InvoiceItems.Unit_ID = Tbl_Units_SpareParts.Unit_ID
                    WHERE Tbl_InvoiceItems.Product_ID = @Product_ID
                    ORDER BY Tbl_InvoiceItems.Invoice_Date"
        'Dim commandText As String = "SELECT ROW_NUMBER() OVER(ORDER BY Tbl_InvoiceItems.Invoice_ID) AS Serial_Count, Tbl_InvoiceItems.*,                                      
        '           Tbl_Units_SpareParts.Unit_Name
        '            FROM Tbl_Invoices 
        '            INNER JOIN Tbl_InvoiceItems ON Tbl_Invoices.Invoice_ID = Tbl_InvoiceItems.Invoice_ID        
        '            INNER JOIN Tbl_Units_SpareParts ON Tbl_InvoiceItems.Unit_ID = Tbl_Units_SpareParts.Unit_ID
        '            WHERE Tbl_InvoiceItems.Product_ID = @Product_ID
        '            ORDER BY Tbl_InvoiceItems.Invoice_Date;"
        Dim command As New SqlCommand(commandText, Con)
        command.Parameters.AddWithValue("@Product_ID", Product_ID.Text)
        Dim da As New SqlDataAdapter(command)
        da.Fill(dt_Tbl_InvoiceItems)

        ' تحديد ترتيب الحقول كما تريد
        dt_Tbl_InvoiceItems.Columns("Serial_Count").SetOrdinal(0)
        dt_Tbl_InvoiceItems.Columns("Invoice_Date").SetOrdinal(1)
        dt_Tbl_InvoiceItems.Columns("Invoice_Number").SetOrdinal(2)
        dt_Tbl_InvoiceItems.Columns("Invoice_Type").SetOrdinal(3)
        dt_Tbl_InvoiceItems.Columns("Unit_Name").SetOrdinal(4)
        dt_Tbl_InvoiceItems.Columns("Quantity_ElWarad").SetOrdinal(5)
        dt_Tbl_InvoiceItems.Columns("Quantity_ElMonsarf").SetOrdinal(6)
        dt_Tbl_InvoiceItems.Columns("Quantity_MortagaaElMawarden").SetOrdinal(7)
        dt_Tbl_InvoiceItems.Columns("Quantity_MortagaaOmalaa").SetOrdinal(8)
        dt_Tbl_InvoiceItems.Columns("Balance_Time_Entry").SetOrdinal(9)
        dt_Tbl_InvoiceItems.Columns("Customer_Name").SetOrdinal(10)
        ''''الكود ده عشان يخلى الدتا جريد لو اى خلية فارغة يخلى قيمهتها 0
        '''Dim Marker As Double = 0
        '''For Each row As DataRow In dt_Tbl_InvoiceItems.Rows
        '''    For Each column As DataColumn In dt_Tbl_InvoiceItems.Columns
        '''        If row(column.ColumnName) Is DBNull.Value OrElse String.IsNullOrWhiteSpace(row(column.ColumnName).ToString()) Then
        '''            row(column.ColumnName) = Marker
        '''        ElseIf column.ColumnName = "Quantity_ElWarad" OrElse column.ColumnName = "Quantity_ElMonsarf" OrElse column.ColumnName = "Quantity_MortagaaElMawarden" OrElse column.ColumnName = "Quantity_MortagaaOmalaa" OrElse column.ColumnName = "Unit_Price" OrElse column.ColumnName = "Total_Invoice_Value" OrElse column.ColumnName = "Balance_Time_Entry" Then
        '''            If row(column.ColumnName) Is DBNull.Value Then
        '''                row(column.ColumnName) = DBNull.Value
        '''            End If
        '''        End If
        '''    Next
        '''Next
        dgv.DataSource = dt_Tbl_InvoiceItems
        ConfigureDataGridViewColumnsEznCustomer(dgv_Tbl_InvoiceItems, dt_Tbl_InvoiceItems)
    End Sub

    Public Sub SelectAll_Tbl_InvoiceItemsDate(dgv As DataGridView)
        Try
            dt_Tbl_InvoiceItems.Clear()
            Dim startDate As Date = Txt_Date_From.Text
            Dim endDate As Date = Txt_Date_To.Text
            Dim commandText As String = "SELECT ROW_NUMBER() OVER(ORDER BY Tbl_InvoiceItems.Invoice_ID) AS Serial_Count, Tbl_InvoiceItems.*, 
               Tbl_Invoices.Customer_ID, 
               Tbl_Invoices.Supplier_ID,
               Tbl_Customers.Customer_Name,
               Tbl_Suppliers.Supplier_Name,
               Tbl_Units_SpareParts.Unit_Name
                FROM Tbl_Invoices 
                INNER JOIN Tbl_InvoiceItems ON Tbl_Invoices.Invoice_ID = Tbl_InvoiceItems.Invoice_ID
                LEFT JOIN Tbl_Customers ON Tbl_Invoices.Customer_ID = Tbl_Customers.Customer_ID
                LEFT JOIN Tbl_Suppliers ON Tbl_Invoices.Supplier_ID = Tbl_Suppliers.Supplier_ID
                LEFT JOIN Tbl_Units_SpareParts ON Tbl_InvoiceItems.Unit_ID = Tbl_Units_SpareParts.Unit_ID
                WHERE Tbl_InvoiceItems.Product_ID = @Product_ID AND Tbl_InvoiceItems.Invoice_Date BETWEEN @StartDate AND @EndDate"

            Dim command As New SqlCommand(commandText, Con)
            command.Parameters.AddWithValue("@Product_ID", Product_ID.Text)
            command.Parameters.AddWithValue("@StartDate", startDate)
            command.Parameters.AddWithValue("@EndDate", endDate)
            Dim da As New SqlDataAdapter(command)
            da.Fill(dt_Tbl_InvoiceItems)

            ' جمع القيم في الأعمدة المحددة
            'Sum_ElWarad.Text = dt_Tbl_InvoiceItems.AsEnumerable().Sum(Function(row) If(row.Field(Of Double?)("Quantity_ElWarad"), 0))
            'Sum_ElMonsarf.Text = dt_Tbl_InvoiceItems.AsEnumerable().Sum(Function(row) If(row.Field(Of Double?)("Quantity_ElMonsarf"), 0))
            'Sum_MortagaaElMawarden.Text = dt_Tbl_InvoiceItems.AsEnumerable().Sum(Function(row) If(row.Field(Of Double?)("Quantity_MortagaaElMawarden"), 0))
            'Sum_MortagaaOmalaa.Text = dt_Tbl_InvoiceItems.AsEnumerable().Sum(Function(row) If(row.Field(Of Double?)("Quantity_MortagaaOmalaa"), 0))
            'Sum_ElWarad.Text = Var_ElWarad.ToString()
            'Sum_ElMonsarf.Text = Var_ElMonsarf.ToString()
            'Sum_MortagaaElMawarden.Text = Var_MortagaaElMawarden.ToString()
            'Sum_MortagaaOmalaa.Text = Var_MortagaaOmalaa.ToString()
            ' تحديد ترتيب الحقول كما تريد
            'dt_Tbl_InvoiceItems.Columns("Serial_Count").SetOrdinal(0)
            'dt_Tbl_InvoiceItems.Columns("Invoice_Date").SetOrdinal(1)
            'dt_Tbl_InvoiceItems.Columns("Invoice_Number").SetOrdinal(2)
            'dt_Tbl_InvoiceItems.Columns("Invoice_Type").SetOrdinal(3)
            'dt_Tbl_InvoiceItems.Columns("Unit_Name").SetOrdinal(4)
            'dt_Tbl_InvoiceItems.Columns("Quantity_ElWarad").SetOrdinal(5)
            'dt_Tbl_InvoiceItems.Columns("Quantity_ElMonsarf").SetOrdinal(6)
            'dt_Tbl_InvoiceItems.Columns("Quantity_MortagaaElMawarden").SetOrdinal(7)
            'dt_Tbl_InvoiceItems.Columns("Quantity_MortagaaOmalaa").SetOrdinal(8)

            dt_Tbl_InvoiceItems.Columns("Serial_Count").SetOrdinal(0)
            dt_Tbl_InvoiceItems.Columns("Invoice_Date").SetOrdinal(1)
            dt_Tbl_InvoiceItems.Columns("Invoice_Number").SetOrdinal(2)
            dt_Tbl_InvoiceItems.Columns("Invoice_Type").SetOrdinal(3)
            dt_Tbl_InvoiceItems.Columns("Unit_Name").SetOrdinal(4)
            dt_Tbl_InvoiceItems.Columns("Quantity_ElWarad").SetOrdinal(5)
            dt_Tbl_InvoiceItems.Columns("Quantity_ElMonsarf").SetOrdinal(6)
            dt_Tbl_InvoiceItems.Columns("Quantity_MortagaaElMawarden").SetOrdinal(7)
            dt_Tbl_InvoiceItems.Columns("Quantity_MortagaaOmalaa").SetOrdinal(8)
            dt_Tbl_InvoiceItems.Columns("Balance_Time_Entry").SetOrdinal(9)
            dt_Tbl_InvoiceItems.Columns("Customer_Name").SetOrdinal(10)

            ''''الكود ده عشان يخلى الدتا جريد لو اى خلية فارغة يخلى قيمهتها 0
            '''Dim Marker As Double = 0
            '''For Each row As DataRow In dt_Tbl_InvoiceItems.Rows
            '''    For Each column As DataColumn In dt_Tbl_InvoiceItems.Columns
            '''        If row(column.ColumnName) Is DBNull.Value OrElse String.IsNullOrWhiteSpace(row(column.ColumnName).ToString()) Then
            '''            row(column.ColumnName) = Marker
            '''        ElseIf column.ColumnName = "Quantity_ElWarad" OrElse column.ColumnName = "Quantity_ElMonsarf" OrElse column.ColumnName = "Quantity_MortagaaElMawarden" OrElse column.ColumnName = "Quantity_MortagaaOmalaa" OrElse column.ColumnName = "Unit_Price" OrElse column.ColumnName = "Total_Invoice_Value" OrElse column.ColumnName = "Balance_Time_Entry" Then
            '''            If row(column.ColumnName) Is DBNull.Value Then
            '''                row(column.ColumnName) = DBNull.Value
            '''            End If
            '''        End If
            '''    Next
            '''Next

            dgv.DataSource = dt_Tbl_InvoiceItems

            ConfigureDataGridViewColumnsEznCustomer(dgv_Tbl_InvoiceItems, dt_Tbl_InvoiceItems)

        Catch ex As Exception
            MessageBox.Show("خطأ: " & ex.Message)
        End Try
    End Sub

    Private Sub Frm_Search_Item_Movement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Product_ID.Focus()
        SelectAll_Tbl_InvoiceItems(dgv_Tbl_InvoiceItems)
        GotFoucs_LostFocus_For_GroupBox(GroupBox1)
        GotFoucs_LostFocus_For_TextBoxes(Me)
        BindingSource1.DataSource = dt_Tbl_InvoiceItems.DefaultView
    End Sub

    'Private Sub Product_ID_KeyDown(sender As Object, e As KeyEventArgs) Handles Product_ID.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        If Txt_Date_From.Text = vbNullString Or Txt_Date_To.Text = vbNullString Then
    '            Retrieve_Item_Movement(Product_ID.Text)
    '            SelectAll_Tbl_InvoiceItems(dgv_Tbl_InvoiceItems)
    '            NumberOfItems.Text = dgv_Tbl_InvoiceItems.Rows.Count
    '        Else
    '            Retrieve_Item_Movement(Product_ID.Text)
    '            SelectAll_Tbl_InvoiceItemsDate(dgv_Tbl_InvoiceItems)
    '            NumberOfItems.Text = dgv_Tbl_InvoiceItems.Rows.Count
    '        End If
    '        Me.Sum_ElMonsarf.Text = dgv_Tbl_InvoiceItems.Columns("Quantity_ElMonsarf")
    '        Me.Sum_ElWarad.Text = dgv_Tbl_InvoiceItems.Columns("Quantity_ElWarad")
    '        Me.Sum_MortagaaElMawarden.Text = dgv_Tbl_InvoiceItems.Columns("Quantity_MortagaaElMawarden")
    '        Me.Sum_MortagaaOmalaa.Text = dgv_Tbl_InvoiceItems.Columns("Quantity_MortagaaOmalaa")

    '    End If
    'End Sub

    Private Sub Product_ID_KeyDown(sender As Object, e As KeyEventArgs) Handles Product_ID.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Txt_Date_From.Text = vbNullString Or Txt_Date_To.Text = vbNullString Then
                Retrieve_Item_Movement(Product_ID.Text)
                SelectAll_Tbl_InvoiceItems(dgv_Tbl_InvoiceItems)
            Else
                Retrieve_Item_Movement(Product_ID.Text)
                SelectAll_Tbl_InvoiceItemsDate(dgv_Tbl_InvoiceItems)
            End If

            NumberOfItems.Text = dgv_Tbl_InvoiceItems.Rows.Count.ToString()

            ' جمع القيم في الأعمدة المحددة
            Dim Var_ElWarad As Double = dgv_Tbl_InvoiceItems.Rows.Cast(Of DataGridViewRow).Sum(Function(row) Convert.ToDouble(row.Cells("Quantity_ElWarad").Value))
            Dim Var_ElMonsarf As Double = dgv_Tbl_InvoiceItems.Rows.Cast(Of DataGridViewRow).Sum(Function(row) Convert.ToDouble(row.Cells("Quantity_ElMonsarf").Value))
            Dim Var_MortagaaElMawarden As Double = dgv_Tbl_InvoiceItems.Rows.Cast(Of DataGridViewRow).Sum(Function(row) Convert.ToDouble(row.Cells("Quantity_MortagaaElMawarden").Value))
            Dim Var_MortagaaOmalaa As Double = dgv_Tbl_InvoiceItems.Rows.Cast(Of DataGridViewRow).Sum(Function(row) Convert.ToDouble(row.Cells("Quantity_MortagaaOmalaa").Value))

            ' تعيين القيم المجمعة إلى مربعات النص
            Me.Sum_ElMonsarf.Text = Var_ElMonsarf.ToString()
            Me.Sum_ElWarad.Text = Var_ElWarad.ToString()
            Me.Sum_MortagaaElMawarden.Text = Var_MortagaaElMawarden.ToString()
            Me.Sum_MortagaaOmalaa.Text = Var_MortagaaOmalaa.ToString()
        End If
    End Sub

    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click
        If Txt_Date_From.Text = vbNullString Or Txt_Date_To.Text = vbNullString Then
            Retrieve_Item_Movement(Product_ID.Text)
            SelectAll_Tbl_InvoiceItems(dgv_Tbl_InvoiceItems)
            NumberOfItems.Text = dgv_Tbl_InvoiceItems.Rows.Count
        Else
            Retrieve_Item_Movement(Product_ID.Text)
            SelectAll_Tbl_InvoiceItemsDate(dgv_Tbl_InvoiceItems)
            NumberOfItems.Text = dgv_Tbl_InvoiceItems.Rows.Count
        End If
    End Sub

    Private Sub Txt_Date_From_Leave(sender As Object, e As EventArgs) Handles Txt_Date_From.Leave
        If Me.Txt_Date_From.Text = vbNullString Then
            Me.Txt_Date_From.Text = vbNullString
        Else
            Dim day As Integer
            Dim month As Integer
            Dim yearr As Integer
            ' تحويل النص المدخل في TextBox إلى أرقام
            day = Val(Mid(Txt_Date_From.Text, 1, 2))
            month = Val(Mid(Txt_Date_From.Text, 3, 2))
            ' تحديد السنة
            If Len(Txt_Date_From.Text) > 5 Then
                If Year(Now) Mod 100 < 50 Then
                    yearr = 2000 + Val(Mid(Txt_Date_From.Text, 5, 6))
                Else
                    yearr = 1900 + Val(Mid(Txt_Date_From.Text, 5, 6))
                End If
            Else
                yearr = Year(Now)
            End If
            ' عرض التاريخ بالتنسيق المطلوب
            Txt_Date_From.Text = Format(day, "00") & "-" & Format(month, "00") & "-" & yearr
        End If
    End Sub

    Private Sub Txt_Date_To_Leave(sender As Object, e As EventArgs) Handles Txt_Date_To.Leave
        If Me.Txt_Date_To.Text = vbNullString Then
            Me.Txt_Date_To.Text = vbNullString
        Else
            Dim day As Integer
            Dim month As Integer
            Dim yearr As Integer
            ' تحويل النص المدخل في TextBox إلى أرقام
            day = Val(Mid(Txt_Date_To.Text, 1, 2))
            month = Val(Mid(Txt_Date_To.Text, 3, 2))
            ' تحديد السنة
            If Len(Txt_Date_To.Text) > 5 Then
                If Year(Now) Mod 100 < 50 Then
                    yearr = 2000 + Val(Mid(Txt_Date_To.Text, 5, 6))
                Else
                    yearr = 1900 + Val(Mid(Txt_Date_To.Text, 5, 6))
                End If
            Else
                yearr = Year(Now)
            End If
            ' عرض التاريخ بالتنسيق المطلوب
            Txt_Date_To.Text = Format(day, "00") & "-" & Format(month, "00") & "-" & yearr
        End If
    End Sub

    'Public Sub SelectAll_ProductsALL(dgv As DataGridView)
    '    Dim da As New SqlDataAdapter
    '    dt_Products.Clear()
    '    'da = New SqlDataAdapter("SELECT dbo.Tbl_Products.*, dbo.Tbl_Units_SpareParts.Unit_Name, dbo.Tbl_Categories.CAT_Name
    '    '                FROM dbo.Tbl_Products
    '    '                INNER JOIN dbo.Tbl_Units_SpareParts ON dbo.Tbl_Products.Unit_ID = dbo.Tbl_Units_SpareParts.Unit_ID
    '    '                INNER JOIN dbo.Tbl_Categories ON dbo.Tbl_Products.CAT_ID = dbo.Tbl_Categories.CAT_ID", Con)
    '    da = New SqlDataAdapter("SELECT * FROM Tbl_Products", Con)
    '    da.Fill(dt_Products)
    '    dt_Products.Columns("Product_ID").SetOrdinal(0)
    '    dt_Products.Columns("Product_Name").SetOrdinal(1)
    '    dt_Products.Columns("Initial_Balance").SetOrdinal(2)
    '    dt_Products.Columns("ElWarad").SetOrdinal(3)
    '    dt_Products.Columns("MortagaaOmalaa").SetOrdinal(4)
    '    dt_Products.Columns("ElMonsarf").SetOrdinal(5)
    '    dt_Products.Columns("MortagaaElMawarden").SetOrdinal(6)
    '    dt_Products.Columns("QTE_IN_STOCK").SetOrdinal(7)
    '    dt_Products.Columns("IMAGE_PRODUCT").SetOrdinal(8)
    '    dt_Products.Columns("Unit_Price").SetOrdinal(9)
    '    dt_Products.Columns("CAT_ID").SetOrdinal(10)
    '    dt_Products.Columns("CAT_Name").SetOrdinal(11)
    '    dt_Products.Columns("Unit_ID").SetOrdinal(12)
    '    dt_Products.Columns("Unit_Name").SetOrdinal(13)
    '    dt_Products.Columns("Minimum_Threshold").SetOrdinal(14)
    '    dt_Products.Columns("Maximum_Threshold").SetOrdinal(15)
    '    dt_Products.Columns("Location").SetOrdinal(16)
    '    dgv.DataSource = dt_Products
    '    With dgv
    '        .Columns("Product_ID").HeaderText = "كود الصنف"
    '        .Columns("Product_Name").HeaderText = "اسم الصنف"
    '        .Columns("Product_Name").Width = 220
    '        .Columns("Initial_Balance").HeaderText = "رصيد بداية المدة"
    '        .Columns("Initial_Balance").Visible = False
    '        .Columns("ElWarad").HeaderText = "الوراد"
    '        .Columns("ElWarad").Visible = False
    '        .Columns("MortagaaOmalaa").HeaderText = "مرتجع العملاء"
    '        .Columns("MortagaaOmalaa").Visible = False
    '        .Columns("ElMonsarf").HeaderText = "المنصرف"
    '        .Columns("ElMonsarf").Visible = False
    '        .Columns("MortagaaElMawarden").HeaderText = "مرتجع الموردين"
    '        .Columns("MortagaaElMawarden").Visible = False
    '        .Columns("QTE_IN_STOCK").HeaderText = "الرصيد الحالى"
    '        .Columns("QTE_IN_STOCK").Visible = False
    '        .Columns("IMAGE_PRODUCT").HeaderText = "IMAGE_PRODUCT"
    '        .Columns("IMAGE_PRODUCT").Visible = False
    '        .Columns("Unit_Price").HeaderText = "Unit_Price"
    '        .Columns("Unit_Price").Visible = False
    '        .Columns("CAT_ID").HeaderText = "كود التصنيف"
    '        .Columns("CAT_ID").Visible = False
    '        .Columns("CAT_Name").HeaderText = "اسم التصنيف"
    '        .Columns("CAT_Name").Visible = False
    '        .Columns("Unit_ID").HeaderText = "كود الوحدة"
    '        .Columns("Unit_ID").Visible = False
    '        .Columns("Unit_Name").HeaderText = "الوحدة"
    '        .Columns("Unit_Name").Visible = False
    '        .Columns("Minimum_Threshold").HeaderText = "اقل رصيد"
    '        .Columns("Minimum_Threshold").Visible = False
    '        .Columns("Maximum_Threshold").HeaderText = "اكبر رصيد"
    '        .Columns("Maximum_Threshold").Visible = False
    '        .Columns("Location").HeaderText = "التواجد"
    '    End With
    'End Sub

    Private Sub Btn_Search_Products_Click(sender As Object, e As EventArgs) Handles Btn_Search_Products.Click
        Frm_Search_Product.Show()
    End Sub

    Private Sub Btn_Search_FromDate_Click(sender As Object, e As EventArgs) Handles Btn_Search_FromDate.Click
        If Txt_Date_From.Text = vbNullString Or Txt_Date_To.Text = vbNullString Then
            ' التحقق ما إذا كانت قيمة Product_ID فارغة
            If String.IsNullOrEmpty(Product_ID.Text) Then
                MsgBox("يرجى كتابة كود الصنف أولاً", MsgBoxStyle.Exclamation)
            Else
                Retrieve_Item_Movement(Product_ID.Text)
                SelectAll_Tbl_InvoiceItems(dgv_Tbl_InvoiceItems)
                NumberOfItems.Text = dgv_Tbl_InvoiceItems.Rows.Count
            End If
        Else
            ' التحقق ما إذا كانت قيمة Product_ID فارغة
            If String.IsNullOrEmpty(Product_ID.Text) Then
                MsgBox("يرجى كتابة كود الصنف أولاً", MsgBoxStyle.Exclamation)
            Else
                Retrieve_Item_Movement(Product_ID.Text)
                SelectAll_Tbl_InvoiceItemsDate(dgv_Tbl_InvoiceItems)
                NumberOfItems.Text = dgv_Tbl_InvoiceItems.Rows.Count
            End If
        End If
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


    Private Sub dgv_Tbl_InvoiceItems_FilterStringChanged(sender As Object, e As EventArgs) Handles dgv_Tbl_InvoiceItems.FilterStringChanged
        BindingSource1.Filter = dgv_Tbl_InvoiceItems.FilterString
        dgv_Tbl_InvoiceItems.DataSource = BindingSource1
    End Sub

    Private Sub dgv_Tbl_InvoiceItems_SortStringChanged(sender As Object, e As EventArgs) Handles dgv_Tbl_InvoiceItems.SortStringChanged
        BindingSource1.Sort = dgv_Tbl_InvoiceItems.SortString
        dgv_Tbl_InvoiceItems.DataSource = BindingSource1
    End Sub

End Class