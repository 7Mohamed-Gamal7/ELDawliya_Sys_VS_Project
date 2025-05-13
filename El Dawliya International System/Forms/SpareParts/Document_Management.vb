Imports System.Data.SqlClient

Public Class Document_Management
    Private ReadOnly _dbManager As DatabaseManager
    Private ReadOnly _documentValidation As DocumentValidation
    Private ReadOnly _virtualGridView As VirtualDataGridView
    Private ReadOnly _documentRepository As New DocumentRepository
    Private _currentDocument As DocumentData
    Private dt_Tbl_InvoiceItems As New DataTable
    Private dt_Tbl_Ezn_Customer As New DataTable

    Public Sub New()
        InitializeComponent()
        _dbManager = DatabaseManager.Instance
        _documentValidation = New DocumentValidation()
        _virtualGridView = New VirtualDataGridView(dgv_Tbl_InvoiceItems)
        _currentDocument = New DocumentData()
        InitializeForm()
    End Sub

    Private Sub InitializeForm()
        SetupDataGridView()
        LoadDocumentTypes()
        ClearForm()
    End Sub

    Private Function GetColumnHeaderName(columnName As String) As String
        Select Case columnName
            Case "RowNumber" : Return "مسلسل"
            Case "Invoice_Code_Programing" : Return "الكود البرمجى"
            Case "Invoice_ID" : Return "كود المستند"
            Case "txt_Invoice_Number" : Return "رقم الأذن"
            Case "Product_ID" : Return "كود الصنف"
            Case "Product_Name" : Return "اسم الصنف"
            Case "Quantity_ElWarad" : Return "الكمية الواردة"
            Case "Quantity_ElMonsarf" : Return "الكمية المنصرفة"
            Case "Quantity_MortagaaElMawarden" : Return "كمية مرتجع الموردين"
            Case "Quantity_MortagaaOmalaa" : Return "كمية مرتجع العملاء"
            Case "Unit_ID" : Return "كود الوحدة"
            Case "Unit_Name" : Return "الوحدة"
            Case "Unit_Price" : Return "السعر"
            Case "Balance_Time_Entry" : Return "الرصيد"
            Case Else : Return columnName
        End Select
    End Function

    Private Sub SetupDataGridView()
        With dgv_Tbl_InvoiceItems
            .Columns.Clear()

            ' إضافة أعمدة البيانات
            .Columns.Add(New DataGridViewTextBoxColumn With {
                .Name = "Product_ID",
                .HeaderText = "كود الصنف",
                .DataPropertyName = "Product_ID"
            })
            .Columns.Add(New DataGridViewTextBoxColumn With {
                .Name = "Product_Name",
                .HeaderText = "اسم الصنف",
                .DataPropertyName = "Product_Name",
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            })
            ' إضافة باقي الأعمدة
            .Columns.Add(New DataGridViewTextBoxColumn With {
                .Name = "Quantity_ElWarad",
                .HeaderText = GetColumnHeaderName("Quantity_ElWarad"),
                .DataPropertyName = "Quantity_ElWarad"
            })
            .Columns.Add(New DataGridViewTextBoxColumn With {
                .Name = "Quantity_ElMonsarf",
                .HeaderText = GetColumnHeaderName("Quantity_ElMonsarf"),
                .DataPropertyName = "Quantity_ElMonsarf"
            })
            .Columns.Add(New DataGridViewTextBoxColumn With {
                .Name = "Quantity_MortagaaElMawarden",
                .HeaderText = GetColumnHeaderName("Quantity_MortagaaElMawarden"),
                .DataPropertyName = "Quantity_MortagaaElMawarden"
            })
            .Columns.Add(New DataGridViewTextBoxColumn With {
                .Name = "Quantity_MortagaaOmalaa",
                .HeaderText = GetColumnHeaderName("Quantity_MortagaaOmalaa"),
                .DataPropertyName = "Quantity_MortagaaOmalaa"
            })
            .Columns.Add(New DataGridViewTextBoxColumn With {
                .Name = "Unit_ID",
                .HeaderText = GetColumnHeaderName("Unit_ID"),
                .DataPropertyName = "Unit_ID"
            })
            .Columns.Add(New DataGridViewTextBoxColumn With {
                .Name = "Unit_Name",
                .HeaderText = GetColumnHeaderName("Unit_Name"),
                .DataPropertyName = "Unit_Name"
            })
            .Columns.Add(New DataGridViewTextBoxColumn With {
                .Name = "Unit_Price",
                .HeaderText = GetColumnHeaderName("Unit_Price"),
                .DataPropertyName = "Unit_Price"
            })
            .Columns.Add(New DataGridViewTextBoxColumn With {
                .Name = "Balance_Time_Entry",
                .HeaderText = GetColumnHeaderName("Balance_Time_Entry"),
                .DataPropertyName = "Balance_Time_Entry"
            })

            ' إضافة أزرار التعديل والحذف
            Dim editColumn As New DataGridViewButtonColumn With {
                .Name = "EditButton",
                .HeaderText = "تعديل",
                .Text = "تعديل",
                .UseColumnTextForButtonValue = True
            }
            .Columns.Add(editColumn)

            Dim deleteColumn As New DataGridViewButtonColumn With {
                .Name = "DeleteButton",
                .HeaderText = "حذف",
                .Text = "حذف",
                .UseColumnTextForButtonValue = True
            }
            .Columns.Add(deleteColumn)

            ' تنسيق الجدول
            .RightToLeft = RightToLeft.Yes
            .AllowUserToAddRows = True
            .AllowUserToDeleteRows = True

            ' إضافة معالج حدث النقر على الخلايا
            AddHandler .CellClick, AddressOf DataGridView_CellClick
        End With
    End Sub

    Private Sub DataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex < 0 Then Return

        ' التحقق من النقر على زر التعديل
        If e.ColumnIndex = dgv_Tbl_InvoiceItems.Columns("EditButton").Index Then
            EditRow(e.RowIndex)
        End If

        ' التحقق من النقر على زر الحذف
        If e.ColumnIndex = dgv_Tbl_InvoiceItems.Columns("DeleteButton").Index Then
            DeleteRow(e.RowIndex)
        End If
    End Sub

    Private Sub EditRow(rowIndex As Integer)
        Try
            Dim row = dt_Tbl_InvoiceItems.Rows(rowIndex)
            Dim invoiceType = cmb_Invoice_Type.Text
            Dim oldQuantity As Decimal = 0
            Dim newQuantity As Decimal = 0

            ' فتح نموذج التعديل
            Using editForm As New Form
                editForm.Text = "تعديل الصنف"
                editForm.RightToLeft = RightToLeft.Yes
                editForm.Size = New Size(400, 300)
                editForm.StartPosition = FormStartPosition.CenterParent

                ' تحديد نوع الكمية حسب نوع المستند
                Dim quantityLabel As String
                Dim quantityField As String
                Dim productField As String
                Select Case invoiceType
                    Case "اذن صرف"
                        quantityLabel = "الكمية المنصرفة:"
                        quantityField = "Quantity_ElMonsarf"
                        productField = "ElMonsarf"
                    Case "اذن وارد"
                        quantityLabel = "الكمية الواردة:"
                        quantityField = "Quantity_ElWarad"
                        productField = "ElWarad"
                    Case "اذن مرتجع عميل"
                        quantityLabel = "كمية المرتجع:"
                        quantityField = "Quantity_MortagaaOmalaa"
                        productField = "MortagaaOmalaa"
                    Case "اذن مرتجع مورد"
                        quantityLabel = "كمية المرتجع:"
                        quantityField = "Quantity_MortagaaElMawarden"
                        productField = "MortagaaElMawarden"
                    Case Else
                        MessageBox.Show("نوع المستند غير معروف", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                End Select

                oldQuantity = If(IsDBNull(row(quantityField)), 0D, Convert.ToDecimal(row(quantityField)))

                ' إنشاء عناصر التحكم
                Dim lblQuantity As New Label With {
                    .Text = quantityLabel,
                    .Location = New Point(300, 20)
                }

                Dim txtQuantity As New TextBox With {
                    .Text = oldQuantity.ToString(),
                    .Location = New Point(100, 20),
                    .Width = 150
                }

                Dim lblPrice As New Label With {
                    .Text = "السعر:",
                    .Location = New Point(300, 60)
                }

                Dim txtPrice As New TextBox With {
                    .Text = If(IsDBNull(row("Unit_Price")), "0", row("Unit_Price").ToString()),
                    .Location = New Point(100, 60),
                    .Width = 150
                }

                ' تعطيل حقل السعر إذا لم يكن المستند إذن وارد
                txtPrice.Enabled = (invoiceType = "اذن وارد")

                Dim btnSave As New Button With {
                    .Text = "حفظ",
                    .Location = New Point(150, 200),
                    .DialogResult = DialogResult.OK
                }

                ' إضافة عناصر التحكم للنموذج
                editForm.Controls.AddRange({lblQuantity, txtQuantity, lblPrice, txtPrice, btnSave})

                ' عرض النموذج
                If editForm.ShowDialog() = DialogResult.OK Then
                    newQuantity = Convert.ToDecimal(txtQuantity.Text)

                    Using conn = _dbManager.GetConnection()
                        conn.Open()
                        Using transaction As SqlTransaction = conn.BeginTransaction()
                            Try
                                ' تحديث المستند
                                Dim updateInvoiceQuery As String = $"UPDATE Tbl_InvoiceItems SET {quantityField} = @Quantity"
                                If invoiceType = "اذن وارد" Then
                                    updateInvoiceQuery &= ", Unit_Price = @Price"
                                End If
                                updateInvoiceQuery &= " WHERE Invoice_Number = @InvoiceNumber AND Product_ID = @ProductID"

                                Using cmdInvoice As New SqlCommand(updateInvoiceQuery, conn, transaction)
                                    cmdInvoice.Parameters.AddWithValue("@Quantity", newQuantity)
                                    If invoiceType = "اذن وارد" Then
                                        cmdInvoice.Parameters.AddWithValue("@Price", Convert.ToDecimal(txtPrice.Text))
                                    End If
                                    cmdInvoice.Parameters.AddWithValue("@InvoiceNumber", row("Invoice_Number"))
                                    cmdInvoice.Parameters.AddWithValue("@ProductID", row("Product_ID"))
                                    cmdInvoice.ExecuteNonQuery()
                                End Using

                                ' تحديث رصيد المنتج
                                Dim difference As Decimal = newQuantity - oldQuantity
                                Dim updateProductQuery As String = $"UPDATE Tbl_Products SET {productField} = {productField} + @Difference, "

                                ' تحديث الرصيد الحالي
                                Select Case invoiceType
                                    Case "اذن صرف"
                                        updateProductQuery &= "QTE_IN_STOCK = QTE_IN_STOCK - @Difference"
                                    Case "اذن وارد"
                                        updateProductQuery &= "QTE_IN_STOCK = QTE_IN_STOCK + @Difference"
                                    Case "اذن مرتجع عميل"
                                        updateProductQuery &= "QTE_IN_STOCK = QTE_IN_STOCK + @Difference"
                                    Case "اذن مرتجع مورد"
                                        updateProductQuery &= "QTE_IN_STOCK = QTE_IN_STOCK - @Difference"
                                End Select

                                updateProductQuery &= " WHERE Product_ID = @ProductID"

                                Using cmdProduct As New SqlCommand(updateProductQuery, conn, transaction)
                                    cmdProduct.Parameters.AddWithValue("@Difference", difference)
                                    cmdProduct.Parameters.AddWithValue("@ProductID", row("Product_ID"))
                                    cmdProduct.ExecuteNonQuery()
                                End Using

                                ' تحديث البيانات في الجدول المحلي
                                row(quantityField) = newQuantity
                                If invoiceType = "اذن وارد" Then
                                    row("Unit_Price") = Convert.ToDecimal(txtPrice.Text)
                                End If

                                transaction.Commit()
                                dt_Tbl_InvoiceItems.AcceptChanges()
                                MessageBox.Show("تم تحديث البيانات بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            Catch ex As Exception
                                transaction.Rollback()
                                Throw
                            End Try
                        End Using
                    End Using
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("خطأ في تعديل البيانات: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DeleteRow(rowIndex As Integer)
        Try
            If MessageBox.Show("هل أنت متأكد من حذف هذا السجل؟", "تأكيد الحذف",
                             MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

                ' حذف السجل من قاعدة البيانات
                Dim row = dt_Tbl_InvoiceItems.Rows(rowIndex)
                Using conn = _dbManager.GetConnection()
                    conn.Open()
                    Using transaction As SqlTransaction = conn.BeginTransaction()
                        Try
                            Using cmd As New SqlCommand("DELETE FROM Tbl_InvoiceItems WHERE Product_ID = @ProductID AND Invoice_Number = @InvoiceNumber", conn, transaction)
                                cmd.Parameters.AddWithValue("@ProductID", row("Product_ID"))
                                cmd.Parameters.AddWithValue("@InvoiceNumber", row("Invoice_Number"))
                                cmd.ExecuteNonQuery()
                            End Using

                            ' تحديث رصيد المنتج
                            Dim updateProductQuery As String = "UPDATE Tbl_Products SET QTE_IN_STOCK = QTE_IN_STOCK - (SELECT Quantity_ElWarad FROM Tbl_InvoiceItems WHERE Product_ID = @ProductID AND Invoice_Number = @InvoiceNumber) WHERE Product_ID = @ProductID"

                            Using cmdProduct As New SqlCommand(updateProductQuery, conn, transaction)
                                cmdProduct.Parameters.AddWithValue("@ProductID", row("Product_ID"))
                                cmdProduct.Parameters.AddWithValue("@InvoiceNumber", row("Invoice_Number"))
                                cmdProduct.ExecuteNonQuery()
                            End Using

                            transaction.Commit()
                            dt_Tbl_InvoiceItems.Rows(rowIndex).Delete()
                            dt_Tbl_InvoiceItems.AcceptChanges()
                            MessageBox.Show("تم حذف السجل بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Catch ex As Exception
                            transaction.Rollback()
                            Throw
                        End Try
                    End Using
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("خطأ في حذف السجل: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadDocumentData(documentNumber As String)
        Try
            Using conn = _dbManager.GetConnection()
                conn.Open()
                Using cmd As New SqlCommand("SELECT * FROM Tbl_Invoices WHERE Invoice_Number = @InvoiceNumber", conn)
                    cmd.Parameters.AddWithValue("@InvoiceNumber", documentNumber)
                    Using reader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' تعبئة بيانات المستند
                            txt_Invoice_Number.Text = reader("Invoice_Number").ToString()
                            If Not IsDBNull(reader("Invoice_Date")) Then
                                dtp_Invoice_Date.Value = Convert.ToDateTime(reader("Invoice_Date"))
                            End If
                            cmb_Invoice_Type.Text = If(IsDBNull(reader("Invoice_Type")), "", reader("Invoice_Type").ToString())
                        End If
                    End Using
                End Using

                ' تحميل تفاصيل المستند
                LoadDocumentItems(documentNumber)
            End Using
        Catch ex As Exception
            MessageBox.Show("خطأ في تحميل بيانات المستند: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadDocumentItems(invoiceNumber As String)
        Try
            Using conn = _dbManager.GetConnection()
                conn.Open()
                Using cmd As New SqlCommand(
                    "SELECT i.*, p.Product_Name, u.Unit_Name " &
                    "FROM Tbl_InvoiceItems i " &
                    "INNER JOIN Tbl_Products p ON i.Product_ID = p.Product_ID " &
                    "INNER JOIN Tbl_Units_SpareParts u ON i.Unit_ID = u.Unit_ID " &
                    "WHERE i.Invoice_Number = @InvoiceNumber", conn)

                    cmd.Parameters.AddWithValue("@InvoiceNumber", invoiceNumber)

                    Dim adapter As New SqlDataAdapter(cmd)
                    dt_Tbl_InvoiceItems.Clear()
                    adapter.Fill(dt_Tbl_InvoiceItems)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("خطأ في تحميل تفاصيل المستند: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SaveInvoice()
        Try
            Using conn = _dbManager.GetConnection()
                conn.Open()
                Using transaction As SqlTransaction = conn.BeginTransaction()
                    Try
                        ' حفظ رأس المستند
                        Using cmdHeader As New SqlCommand("INSERT INTO Tbl_Invoices (Invoice_Number, Invoice_Date, Invoice_Type, Recipient) VALUES (@InvoiceNumber, @InvoiceDate, @InvoiceType, @Recipient)", conn, transaction)
                            cmdHeader.Parameters.AddWithValue("@InvoiceNumber", txt_Invoice_Number.Text)
                            cmdHeader.Parameters.AddWithValue("@InvoiceDate", dtp_Invoice_Date.Value)
                            cmdHeader.Parameters.AddWithValue("@InvoiceType", cmb_Invoice_Type.Text)
                            cmdHeader.Parameters.AddWithValue("@Recipient", txt_Recipient.Text)
                            cmdHeader.ExecuteNonQuery()
                        End Using

                        ' حفظ تفاصيل المستند
                        For Each row As DataRow In dt_Tbl_InvoiceItems.Rows
                            Using cmdItems As New SqlCommand("INSERT INTO Tbl_InvoiceItems (Invoice_Number, Product_ID, Product_Name, Unit_ID, Unit_Price, Invoice_Date, Invoice_Type, Recipient) VALUES (@InvoiceNumber, @ProductID, @ProductName, @UnitID, @UnitPrice, @InvoiceDate, @InvoiceType, @Recipient)", conn, transaction)
                                cmdItems.Parameters.AddWithValue("@InvoiceNumber", txt_Invoice_Number.Text)
                                cmdItems.Parameters.AddWithValue("@ProductID", row("Product_ID"))
                                cmdItems.Parameters.AddWithValue("@ProductName", row("Product_Name"))
                                cmdItems.Parameters.AddWithValue("@UnitID", row("Unit_ID"))
                                cmdItems.Parameters.AddWithValue("@UnitPrice", row("Unit_Price"))
                                cmdItems.Parameters.AddWithValue("@InvoiceDate", dtp_Invoice_Date.Value)
                                cmdItems.Parameters.AddWithValue("@InvoiceType", cmb_Invoice_Type.Text)
                                cmdItems.Parameters.AddWithValue("@Recipient", txt_Recipient.Text)
                                cmdItems.ExecuteNonQuery()
                            End Using
                        Next

                        transaction.Commit()
                        MessageBox.Show("تم حفظ المستند بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception
                        transaction.Rollback()
                        Throw
                    End Try
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("خطأ في حفظ المستند: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ValidateAndSaveDocument()
        Try
            ' تجهيز بيانات المستند
            PrepareDocumentData()

            ' التحقق من صحة البيانات
            Dim validation = _documentValidation.ValidateCompleteDocument(_currentDocument)
            If Not validation.IsValid Then
                MessageBox.Show(validation.Message, "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            ' حفظ المستند
            Using connection = _dbManager.GetConnection()
                connection.Open()
                Using transaction = connection.BeginTransaction()
                    Try
                        SaveDocumentWithTransaction(transaction)
                        transaction.Commit()
                        MessageBox.Show("تم حفظ المستند بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ClearForm()
                    Catch ex As Exception
                        transaction.Rollback()
                        Throw
                    End Try
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("حدث خطأ أثناء حفظ المستند: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PrepareDocumentData()
        _currentDocument = New DocumentData With {
            .DocumentNumber = txt_Invoice_Number.Text.Trim(),
            .DocumentDate = dtp_Invoice_Date.Value,
            .DocumentType = cmb_Invoice_Type.Text,
            .PartyId = If(cmb_Invoice_Type.Text.Contains("مورد"),
                         Convert.ToInt32(Supplier_ID.SelectedValue),
                         Convert.ToInt32(Customer_ID.SelectedValue)),
            .Items = New List(Of DocumentItem)
        }

        ' إضافة الأصناف
        For Each row As DataGridViewRow In dgv_Tbl_InvoiceItems.Rows
            If row.IsNewRow Then Continue For

            _currentDocument.Items.Add(New DocumentItem With {
                .ProductId = row.Cells("Product_ID").Value.ToString(),
                .ProductName = row.Cells("Product_Name").Value.ToString(),
                .Quantity = Convert.ToDecimal(row.Cells("Quantity_ElWarad").Value),
                .Price = Convert.ToDecimal(row.Cells("Unit_Price").Value)
            })
        Next
    End Sub

    Private Sub SaveDocumentWithTransaction(transaction As SqlTransaction)
        ' حفظ رأس المستند
        Dim documentId = SaveDocumentHeader(transaction)

        ' حفظ تفاصيل المستند
        SaveDocumentItems(documentId, transaction)

        ' تحديث أرصدة المخزون
        UpdateInventoryBalances(transaction)
    End Sub

    Private Function SaveDocumentHeader(transaction As SqlTransaction) As Integer
        Try
            Using cmd As New SqlCommand("INSERT INTO Tbl_Invoices (Invoice_Number, Invoice_Date, Invoice_Type, Party_ID) VALUES (@DocumentNumber, @DocumentDate, @DocumentType, @PartyId)", _dbManager.GetConnection(), transaction)
                cmd.Parameters.AddWithValue("@DocumentNumber", _currentDocument.DocumentNumber)
                cmd.Parameters.AddWithValue("@DocumentDate", _currentDocument.DocumentDate)
                cmd.Parameters.AddWithValue("@DocumentType", _currentDocument.DocumentType)
                cmd.Parameters.AddWithValue("@PartyId", _currentDocument.PartyId)
                Return Convert.ToInt32(cmd.ExecuteScalar())
            End Using
        Catch ex As Exception
            Throw
        End Try
    End Function

    Private Sub SaveDocumentItems(documentId As Integer, transaction As SqlTransaction)
        Try
            For Each item As DocumentItem In _currentDocument.Items
                Using cmd As New SqlCommand("INSERT INTO Tbl_InvoiceItems (Document_ID, Product_ID, Quantity, Price) VALUES (@DocumentId, @ProductId, @Quantity, @Price)", _dbManager.GetConnection(), transaction)
                    cmd.Parameters.AddWithValue("@DocumentId", documentId)
                    cmd.Parameters.AddWithValue("@ProductId", item.ProductId)
                    cmd.Parameters.AddWithValue("@Quantity", item.Quantity)
                    cmd.Parameters.AddWithValue("@Price", item.Price)
                    cmd.ExecuteNonQuery()
                End Using
            Next
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub UpdateInventoryBalances(transaction As SqlTransaction)
        Try
            For Each item As DocumentItem In _currentDocument.Items
                Using cmd As New SqlCommand("UPDATE Tbl_Inventory SET Balance = Balance + @Quantity WHERE Product_ID = @ProductId", _dbManager.GetConnection(), transaction)
                    cmd.Parameters.AddWithValue("@ProductId", item.ProductId)
                    cmd.Parameters.AddWithValue("@Quantity", item.Quantity)
                    cmd.ExecuteNonQuery()
                End Using
            Next
        Catch ex As Exception
            Throw
        End Try
    End Sub

    Private Sub ClearForm()
        txt_Invoice_Number.Clear()
        cmb_Invoice_Type.SelectedIndex = -1
        dtp_Invoice_Date.Value = Date.Today
        dgv_Tbl_InvoiceItems.Rows.Clear()
    End Sub

    Private Sub LoadDocumentTypes()
        Try
            cmb_Invoice_Type.Items.Clear()

            ' إضافة أنواع المستندات
            cmb_Invoice_Type.Items.AddRange(New String() {
                "اذن صرف",
                "اذن وارد",
                "اذن مرتجع عميل",
                "اذن مرتجع مورد"})

            ' يمكن أيضاً تحميل الأنواع من قاعدة البيانات إذا كانت موجودة
            'Using cmd As New SqlCommand("SELECT DISTINCT Invoice_Type FROM Tbl_InvoiceTypes ORDER BY Invoice_Type", Con)
            '    If Con.State = ConnectionState.Closed Then Con.Open()
            '    Using reader As SqlDataReader = cmd.ExecuteReader()
            '        While reader.Read()
            '            cmb_Invoice_Type.Items.Add(reader("Invoice_Type").ToString())
            '        End While
            '    End Using
            'End Try

        Catch ex As Exception
            MessageBox.Show("خطأ في تحميل أنواع المستندات: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If _dbManager.GetConnection().State = ConnectionState.Open Then _dbManager.GetConnection().Close()
        End Try
    End Sub

    Private Sub RetrieveInvoiceData(ByVal txt_Invoice_Number As String)
        Try
            Dim documentData = _documentRepository.GetDocumentByNumber(txt_Invoice_Number)
            If documentData.Rows.Count > 0 Then
                ' Populate form with document data
                PopulateFormWithDocumentData(documentData.Rows(0))

                ' Load document items
                Dim items = _documentRepository.GetDocumentItems(documentData.Rows(0)("txt_Invoice_Number"))
                dgv_Tbl_InvoiceItems.DataSource = items
            End If
        Catch ex As Exception
            MessageBox.Show("حدث خطأ أثناء استرجاع بيانات المستند: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub PopulateFormWithDocumentData(row As DataRow)
        Try
            txt_Invoice_Number.Text = row("txt_Invoice_Number").ToString()
            dtp_Invoice_Date.Value = Convert.ToDateTime(row("Invoice_Date"))
            cmb_Invoice_Type.Text = row("Invoice_Type").ToString()
            ' تعبئة باقي البيانات حسب هيكل الجدول
        Catch ex As Exception
            MessageBox.Show("خطأ في تعبئة بيانات النموذج: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txt_Invoice_Number_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Invoice_Number.KeyDown
        ' التأكد من أن المفتاح المضغوط هو مفتاح Enter
        If e.KeyCode = Keys.Enter Then
            ' تنفيذ الكود لاسترداد بيانات الفاتورة
            RetrieveInvoiceData(txt_Invoice_Number.Text)
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

    Public Sub SelectAll_Tbl_InvoiceItems(dgv As DataGridView)
        dt_Tbl_InvoiceItems.Clear()
        dgv_Tbl_InvoiceItems.DataSource = Nothing

        ' تنفيذ الاستعلام وملء DataTable بالبيانات
        Dim commandText As String = "SELECT Tbl_InvoiceItems.*, Tbl_Units_SpareParts.Unit_Name 
                                 FROM Tbl_InvoiceItems 
                                 INNER JOIN Tbl_Units_SpareParts ON Tbl_InvoiceItems.Unit_ID = Tbl_Units_SpareParts.Unit_ID
                                 WHERE Tbl_InvoiceItems.Invoice_Number = @InvoiceNumber
                                 ORDER BY Tbl_InvoiceItems.Invoice_Date;"
        Dim command As New SqlCommand(commandText, _dbManager.GetConnection())
        command.Parameters.AddWithValue("@InvoiceNumber", txt_Invoice_Number.Text)
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
    Private Function GetValueOrDefault(ByVal value As Object) As String
        If Not IsDBNull(value) Then
            Return value.ToString()
        Else
            Return String.Empty
        End If
    End Function

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

    Private Sub Document_Management_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim formatter As New Format_Any_Form()
        formatter.FormatForm(Me)
    End Sub
End Class
