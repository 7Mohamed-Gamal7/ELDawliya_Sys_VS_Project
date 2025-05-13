Imports System.Data.SqlClient
Imports System.IO
Public Class Frm_Customer_Return
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Public dt_Products As New DataTable

    Public Sub ClearControls()
        Invoice_Number.Text = vbNullString
        Invoice_Date.Value = Today
        Customer_ID.Text = vbNullString
        Total_Invoice_Value.Text = vbNullString
        ReturnInvoiceNumber.Text = vbNullString
        dgv_Tbl_InvoiceItems.Rows.Clear()
        Invoice_ID.Text = Max_Tbl_Invoices() + 1
    End Sub

    Public Function Max_Tbl_Invoices()
        Dim Number As Integer
        Try
            Dim cmd As New SqlCommand("Select Max(Invoice_ID) From Tbl_Invoices ", Con)
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Number = cmd.ExecuteScalar
            Con.Close()
        Catch ex As Exception
            Number = 0
            Con.Close()
        End Try
        Return Number
    End Function

    Public Sub fillCmb_Products(ByVal cmb As ComboBox)
        Dim DT As New DataTable
        Dim DA As New SqlDataAdapter
        DT.Clear()
        DA = New SqlDataAdapter("Select * FROM Tbl_Products ", Con)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            cmb.DataSource = DT
            cmb.ValueMember = "Product_ID"
            cmb.DisplayMember = "Product_Name"
            cmb.SelectedIndex = -1
        Else
            cmb.DataSource = Nothing
        End If
    End Sub

    Public Sub fillCmb_Tbl_Customers(ByVal cmb As ComboBox)
        Dim DT As New DataTable
        Dim DA As New SqlDataAdapter
        DT.Clear()
        DA = New SqlDataAdapter("Select * FROM Tbl_Customers ", Con)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            cmb.DataSource = DT
            cmb.DisplayMember = "Customer_Name"
            cmb.ValueMember = "Customer_ID"
            cmb.SelectedIndex = -1
        Else
            cmb.DataSource = Nothing
        End If
    End Sub

    Private Sub Frm_invoice_items_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Invoice_ID.Text = Max_Tbl_Invoices() + 1
        fillCmb_Tbl_Customers(Customer_ID)
        'fillDataGrid()
        GotFoucs_LostFocus_For_Control_On_Panal(Panel1)
        GotFoucs_LostFocus_For_GroupBox(GroupBox1)
    End Sub

    Private Sub fillDataGrid()
        'الكود ده عشان الكمبوبوكس اللى بداخل الداتا جريد يقرأ البيانات من حقل معين فى قاعدة البيانات
        If Con.State <> ConnectionState.Open Then
            Con.Open()
        End If
        Dim str As String = "Select Product_Name FROM Tbl_Products"
        Dim C2 As DataGridViewComboBoxColumn = CType(dgv_Tbl_InvoiceItems.Columns("DGV_Product_Name"), DataGridViewComboBoxColumn)
        Dim cmd As New SqlCommand(str, Con)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        C2.Items.Clear()
        While (dr.Read)
            C2.Items.Add(dr(0).ToString())
            C2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End While
        dr.Close() ' يجب إغلاق SqlDataReader بعد الانتهاء من استخدامه
        dgv_Tbl_InvoiceItems.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
    End Sub

    'Private Sub dgv_Tbl_InvoiceItems_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Tbl_InvoiceItems.CellEndEdit
    '    Try
    '        If e.ColumnIndex = dgv_Tbl_InvoiceItems.Columns("DGV_Product_ID").Index AndAlso e.RowIndex >= 0 Then
    '            'Dim selectedProduct As String = dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("DGV_Product_ID").Value.ToString()
    '            Dim selectedProduct As String = ""
    '            If dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("DGV_Product_ID").Value IsNot Nothing Then
    '                selectedProduct = dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("DGV_Product_ID").Value.ToString()
    '            End If
    '            ' هنا يمكنك استخدام selectedProduct في الشيفرة الأخرى
    '            dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("DGV_Product_ID").Value = selectedProduct
    '            Dim query As String = "SELECT * FROM Tbl_Products WHERE Product_ID = @Product_ID "
    '            Using con As New SqlConnection(ConStr),
    '                  Command As New SqlCommand(query, con)
    '                Command.Parameters.AddWithValue("@Product_ID", selectedProduct)
    '                Try
    '                    con.Open()
    '                    Dim reader As SqlDataReader = Command.ExecuteReader()
    '                    If reader.Read() Then
    '                        dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("DGV_Product_Name").Value = reader("Product_Name").ToString()
    '                        dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("DGV_QTE_IN_STOCK").Value = reader("QTE_IN_STOCK").ToString()
    '                        dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("DGV_ID_CAT").Value = reader("CAT_Name").ToString()
    '                        dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("DGV_Unit_ID").Value = reader("Unit_ID").ToString()
    '                        dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("DGV_Unit_Name").Value = reader("Unit_Name").ToString()
    '                        dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("DGV_Initial_Balance").Value = reader("Initial_Balance").ToString()
    '                        dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("DGV_Unit_Price").Value = reader("Unit_Price").ToString()
    '                        dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("DGV_Minimum_Threshold").Value = reader("Minimum_Threshold").ToString()
    '                        dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("DGV_Maximum_Threshold").Value = reader("Maximum_Threshold").ToString()
    '                    End If
    '                    reader.Close()
    '                Catch ex As Exception
    '                    MessageBox.Show("حدث خطأ: " & ex.Message)
    '                End Try
    '            End Using
    '            Lbl_Count_Product.Text = dgv_Tbl_InvoiceItems.Rows.Count - 1
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show("حدث خطأ: " & ex.Message)
    '    End Try
    'End Sub


    Private Sub dgv_Tbl_InvoiceItems_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Tbl_InvoiceItems.CellEndEdit
        Try
            If e.ColumnIndex = dgv_Tbl_InvoiceItems.Columns("DGV_Product_ID").Index AndAlso e.RowIndex >= 0 Then
                Dim selectedProduct As String = ""
                If dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("DGV_Product_ID").Value IsNot Nothing Then
                    selectedProduct = dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells("DGV_Product_ID").Value.ToString()
                End If

                Dim query As String = "SELECT * FROM Tbl_Products WHERE Product_ID = @Product_ID "
                Using con As New SqlConnection(ConStr),
                  Command As New SqlCommand(query, con)
                    Command.Parameters.AddWithValue("@Product_ID", selectedProduct)
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
                        Else
                            Dim result As DialogResult = MessageBox.Show("الكود غير موجود. هل تريد إضافة المنتج؟", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                            If result = DialogResult.Yes Then
                                ' فتح النموذج Frm_Products لإضافة المنتج الجديد
                                Frm_Products.Show()
                            Else
                                ' مسح بيانات الصف
                                For Each cell As DataGridViewCell In dgv_Tbl_InvoiceItems.Rows(e.RowIndex).Cells
                                    cell.Value = Nothing
                                Next
                            End If
                        End If
                        reader.Close()
                    Catch ex As Exception
                        MessageBox.Show("حدث خطأ: " & ex.Message)
                    End Try
                End Using
                Lbl_Count_Product.Text = dgv_Tbl_InvoiceItems.Rows.Count - 1
            End If
        Catch ex As Exception
            MessageBox.Show("حدث خطأ: " & ex.Message)
        End Try
    End Sub







    Private Sub dgv_Tbl_InvoiceItems_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Tbl_InvoiceItems.CellValueChanged
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = dgv_Tbl_InvoiceItems.Columns("DGV_Add_Balance").Index Then
            Dim rowIndex As Integer = e.RowIndex
            If dgv_Tbl_InvoiceItems.Rows.Count > 0 AndAlso rowIndex <> dgv_Tbl_InvoiceItems.NewRowIndex Then
                If dgv_Tbl_InvoiceItems.Rows(rowIndex).Cells("DGV_Unit_Price").Value IsNot Nothing AndAlso dgv_Tbl_InvoiceItems.Rows(rowIndex).Cells("DGV_Add_Balance").Value IsNot Nothing Then
                    Dim unitPrice As Double
                    Dim addBalance As Double
                    If Double.TryParse(dgv_Tbl_InvoiceItems.Rows(rowIndex).Cells("DGV_Unit_Price").Value.ToString(), unitPrice) AndAlso Double.TryParse(dgv_Tbl_InvoiceItems.Rows(rowIndex).Cells("DGV_Add_Balance").Value.ToString(), addBalance) Then
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
                        Total_Invoice_Value.Text = totalInvoiceValue.ToString()
                    Else
                        ' في حالة وجود قيم غير صالحة، يمكنك اتخاذ إجراء مناسب هنا، مثل عرض رسالة خطأ
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub Insert_Tbl_Invoices(ByVal Invoice_ID As Int32, ByVal Invoice_Number As String, ByVal Invoice_Date As Date, ByVal Invoice_Type As String, ByVal NumberOfItems As Int32, ByVal Customer_ID As Int32, ByVal Customer_Invoice_Number As String, ByVal Total_Invoice_Value As Double)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Insert Into Tbl_Invoices (Invoice_ID,Invoice_Number,Invoice_Date,Invoice_Type,NumberOfItems,Customer_ID,Customer_Invoice_Number,Total_Invoice_Value)values(@Invoice_ID,@Invoice_Number,@Invoice_Date,@Invoice_Type,@NumberOfItems,@Customer_ID,@Customer_Invoice_Number,@Total_Invoice_Value)"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Invoice_ID", SqlDbType.Int).Value = Invoice_ID
            .Parameters.AddWithValue("@Invoice_Number", SqlDbType.VarChar).Value = Invoice_Number
            .Parameters.AddWithValue("@Invoice_Date", SqlDbType.Date).Value = Invoice_Date
            .Parameters.AddWithValue("@Invoice_Type", SqlDbType.VarChar).Value = Invoice_Type
            .Parameters.AddWithValue("@NumberOfItems", SqlDbType.Int).Value = NumberOfItems
            .Parameters.AddWithValue("@Customer_ID", SqlDbType.Int).Value = Customer_ID
            .Parameters.AddWithValue("@Customer_Invoice_Number", SqlDbType.VarChar).Value = Customer_Invoice_Number
            .Parameters.AddWithValue("@Total_Invoice_Value", SqlDbType.Decimal).Value = Total_Invoice_Value
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
        Cmd = Nothing
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim MovementDescription As String = " تم حفظ بيانات الفاتورة رقم  " + Invoice_Number.Text
        Dim DeviceName As String = Environ$("computername")
        Try
            ' التحقق من صحة البيانات المُدخلة مبكرًا
            If String.IsNullOrWhiteSpace(Invoice_Number.Text) Then
                MessageBox.Show("يرجى إدخال رقم الفاتورة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                Exit Sub
            End If
            ' التحقق من وجود صفوف
            If dgv_Tbl_InvoiceItems.Rows.Count <= 1 Then
                MessageBox.Show("يرجى اختيار صنف واحد على الاقل فى الاذن", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                Exit Sub
            End If
            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If
            Dim Invoice_Type As String = "اذن مرتجع عميل"
            ' إدراج بيانات الفاتورة الرئيسية
            Dim Customer_ID_Value = GetIntegerValue(Customer_ID.SelectedValue)
            Insert_Tbl_Invoices(Invoice_ID.Text, Invoice_Number.Text, Invoice_Date.Value, Invoice_Type, Lbl_Count_Product.Text, Customer_ID_Value, (ReturnInvoiceNumber.Text).ToString(), Total_Invoice_Value.Text)
            Con.Open()
            ' حلقة لإدراج بيانات الأصناف
            For Each row As DataGridViewRow In dgv_Tbl_InvoiceItems.Rows
                If Not row.IsNewRow Then
                    Using cmd As New SqlCommand("Insert Into Tbl_InvoiceItems (Invoice_ID,Invoice_Number,Product_ID,Product_Name,Quantity_ElWarad,Quantity_ElMonsarf,Quantity_MortagaaElMawarden,Quantity_MortagaaOmalaa,Unit_ID,Unit_Price,Invoice_Date,Invoice_Type,Total_Invoice_Value,Balance_Time_Entry,Data_Entry_Date,Data_Entry_By)values(@Invoice_ID,@Invoice_Number,@Product_ID,@Product_Name,@Quantity_ElWarad,@Quantity_ElMonsarf,@Quantity_MortagaaElMawarden,@Quantity_MortagaaOmalaa,@Unit_ID,@Unit_Price,@Invoice_Date,@Invoice_Type,@Total_Invoice_Value,@Balance_Time_Entry,@Data_Entry_Date,@Data_Entry_By)", Con)
                        cmd.Parameters.AddWithValue("@Invoice_ID", Invoice_ID.Text)
                        cmd.Parameters.AddWithValue("@Invoice_Number", Invoice_Number.Text)
                        ' التحقق من وجود قيمة لـ Product_ID
                        If Not row.Cells("DGV_Product_ID").Value Is DBNull.Value Then
                            cmd.Parameters.AddWithValue("@Product_ID", row.Cells("DGV_Product_ID").Value)
                        Else
                            MessageBox.Show("حدث خطأ: لم يتم توفير Product_ID")
                            Exit Sub ' يمكنك استخدام Exit Sub أو أي معالجة خطأ أخرى ترغب بها
                        End If
                        cmd.Parameters.AddWithValue("@Product_Name", row.Cells("DGV_Product_Name").Value)
                        cmd.Parameters.AddWithValue("@Quantity_ElWarad", 0.00)
                        cmd.Parameters.AddWithValue("@Quantity_ElMonsarf", 0.00)
                        cmd.Parameters.AddWithValue("@Quantity_MortagaaElMawarden", 0.00)
                        cmd.Parameters.AddWithValue("@Quantity_MortagaaOmalaa", row.Cells("DGV_Add_Balance").Value)
                        cmd.Parameters.AddWithValue("@Unit_ID", row.Cells("DGV_Unit_ID").Value)
                        cmd.Parameters.AddWithValue("@Unit_Price", row.Cells("DGV_Unit_Price").Value)
                        cmd.Parameters.AddWithValue("@Invoice_Date", Invoice_Date.Value)
                        cmd.Parameters.AddWithValue("@Invoice_Type", Invoice_Type)
                        cmd.Parameters.AddWithValue("@Total_Invoice_Value", Total_Invoice_Value.Text)
                        cmd.Parameters.AddWithValue("@Balance_Time_Entry", row.Cells("DGV_QTE_IN_STOCK").Value)
                        cmd.Parameters.AddWithValue("@Data_Entry_Date", Date.Today)
                        cmd.Parameters.AddWithValue("@Data_Entry_By", loggedInUserName)
                        cmd.CommandType = CommandType.Text
                        cmd.CommandTimeout = 420
                        cmd.ExecuteNonQuery()
                    End Using
                End If
            Next
            Con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        End Try
        'دى اخر حاجه وقفت عندها لسه عليها شغل 
        AddQtyMortagaaOmalaa()
        Insert_MovementHistory(MovementDescription, DateTime.Now, loggedInUserName, DeviceName, Me.Name, "BtnSave")
        ClearControls()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Frm_Add_Suppliers.Show()
    End Sub

    Private Sub Supplier_ID_DropDown(sender As Object, e As EventArgs) Handles Customer_ID.DropDown
        fillCmb_Tbl_Customers(Customer_ID)
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
    End Sub

    Private Sub BtnNewAdd_Click(sender As Object, e As EventArgs) Handles BtnNewAdd.Click
        ClearControls()
    End Sub

    Public Sub LosQty()
        If Con.State = ConnectionState.Closed Then
            Con.Open()
        End If
        For I As Integer = 0 To dgv_Tbl_InvoiceItems.Rows.Count - 1
            Dim row As DataGridViewRow = dgv_Tbl_InvoiceItems.Rows(I)
            If Not row.IsNewRow Then
                Dim A As Decimal = row.Cells("DGV_Add_Balance").Value
                Dim CmdUpdate As New SqlCommand
                With CmdUpdate
                    .Connection = Con
                    .CommandType = CommandType.Text
                    '.CommandText = "UPDATE Tbl_Products SET QTE_IN_STOCK = QTE_IN_STOCK - @Quantity and ElMonsarf = ElMonsarf + @Quantity  WHERE Product_ID = @ProductID"
                    .CommandText = "UPDATE Tbl_Products 
                                    SET QTE_IN_STOCK = QTE_IN_STOCK - @Quantity_MortagaaOmalaa, ElMonsarf = ElMonsarf + @Quantity_MortagaaOmalaa 
                                    WHERE Product_ID = @ProductID"
                    .Parameters.AddWithValue("@Quantity_MortagaaOmalaa", A)
                    .Parameters.AddWithValue("@ProductID", row.Cells(0).Value)
                    .ExecuteNonQuery()
                End With
            End If
        Next
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If
    End Sub

    Public Sub AddQtyMortagaaOmalaa()
        If Con.State = ConnectionState.Closed Then
            Con.Open()
        End If
        For I As Integer = 0 To dgv_Tbl_InvoiceItems.Rows.Count - 1
            Dim row As DataGridViewRow = dgv_Tbl_InvoiceItems.Rows(I)
            If Not row.IsNewRow Then
                Dim A As Decimal = row.Cells("DGV_Add_Balance").Value
                Dim CmdUpdate As New SqlCommand
                With CmdUpdate
                    .Connection = Con
                    .CommandType = CommandType.Text
                    .CommandText = "UPDATE Tbl_Products 
                                    SET QTE_IN_STOCK = (QTE_IN_STOCK + @Quantity_MortagaaOmalaa), MortagaaOmalaa = (MortagaaOmalaa + @Quantity_MortagaaOmalaa)
                                    WHERE Product_ID = @ProductID"
                    .Parameters.AddWithValue("@Quantity_MortagaaOmalaa", A)
                    .Parameters.AddWithValue("@ProductID", row.Cells(0).Value)
                    .Parameters("@Quantity_MortagaaOmalaa").SqlDbType = SqlDbType.Decimal ' تحديد نوع البيانات
                    .ExecuteNonQuery()
                End With
            End If
        Next
        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If
    End Sub

    Public Sub SelectAll_ProductsALL(dgv As DataGridView)
        Dim da As New SqlDataAdapter
        dt_Products.Clear()
        'da = New SqlDataAdapter("SELECT dbo.Tbl_Products.*, dbo.Tbl_Units_SpareParts.Unit_Name, dbo.Tbl_Categories.CAT_Name
        '                FROM dbo.Tbl_Products
        '                INNER JOIN dbo.Tbl_Units_SpareParts ON dbo.Tbl_Products.Unit_ID = dbo.Tbl_Units_SpareParts.Unit_ID
        '                INNER JOIN dbo.Tbl_Categories ON dbo.Tbl_Products.CAT_ID = dbo.Tbl_Categories.CAT_ID", Con)

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

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Frm_Search_Product.Show()
    End Sub

    Private Sub Btn_Add_Group_Codes_Click(sender As Object, e As EventArgs) Handles Btn_Add_Group_Codes.Click

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
                        dgv_Tbl_InvoiceItems.Rows(rowIndex).Cells("DGV_Unit_Price").Value = reader("Unit_Price").ToString()
                        dgv_Tbl_InvoiceItems.Rows(rowIndex).Cells("DGV_Minimum_Threshold").Value = reader("Minimum_Threshold").ToString()
                        dgv_Tbl_InvoiceItems.Rows(rowIndex).Cells("DGV_Maximum_Threshold").Value = reader("Maximum_Threshold").ToString()
                    End If
                    reader.Close()
                Catch ex As Exception
                    MessageBox.Show("حدث خطأ: " & ex.Message)
                End Try
            End Using
        Catch ex As Exception
            MessageBox.Show("حدث خطأ: " & ex.Message)
        End Try
    End Sub

    Private Sub Btn_Add_Products_Click(sender As Object, e As EventArgs) Handles Btn_Add_Products.Click
        Frm_Products.Show()
    End Sub

End Class