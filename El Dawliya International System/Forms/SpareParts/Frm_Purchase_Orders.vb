Imports System.Data.SqlClient
Imports El_Dawliya_International_System.El_Dawliya_International_System.Forms.Report

Public Class Frm_Purchase_Orders
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Public dt_PurchaseOrders As New DataTable

    Public Sub ClearControls()
        Me.Order_Number.Text = vbNullString
        Me.OrderDate.Value = Today
        Me.OrderStatus.Text = vbNullString
        dgv_PurchaseOrders.Rows.Clear()
    End Sub

    Public Sub SelectAll_PurchaseOrders()
        Dim da As New SqlDataAdapter
        dt_PurchaseOrders.Clear()
        Dim query As String = "SELECT * FROM PurchaseOrders WHERE Order_Number = @OrderNumber"
        Dim orderNumberValue As String = Order_Number.Text
        Dim command As New SqlCommand(query, Con)
        command.Parameters.AddWithValue("@OrderNumber", orderNumberValue)
        da = New SqlDataAdapter(command)
        da.Fill(dt_PurchaseOrders)
        ' قم بمسح الصفوف القديمة في dgv_PurchaseOrders قبل إضافة الصفوف الجديدة
        dgv_PurchaseOrders.Rows.Clear()
        ' إضافة البيانات من dt_PurchaseOrders إلى dgv_PurchaseOrders
        For Each row As DataRow In dt_PurchaseOrders.Rows
            Dim productID As String = row("Product_ID").ToString()
            Dim productName As String = row("Product_Name").ToString()
            Dim QTE_IN_STOCK As String = row("QTE_IN_STOCK").ToString()
            Dim Unit_ID As String = row("Unit_ID").ToString()
            Dim Unit_Name As String = row("Unit_Name").ToString()
            Dim Cat_ID As String = row("Cat_ID").ToString()
            Dim Cat_Name As String = row("Cat_Name").ToString()
            Dim Initial_Balance As String = row("Initial_Balance").ToString()
            Dim Unit_Price As String = row("Unit_Price").ToString()
            Dim Minimum_Threshold As String = row("Minimum_Threshold").ToString()
            Dim Maximum_Threshold As String = row("Maximum_Threshold").ToString()
            Dim Required_Quantity As String = row("Required_Quantity").ToString()
            Dim Purpose As String = row("Purpose").ToString()
            Dim Total_Unit_Price As String = row("TotalAmount").ToString()
            Dim OrderDate As String = row("OrderDate").ToString()
            Me.OrderDate.Value = OrderDate
            Dim Request_Side As String = row("Request_Side").ToString()
            Me.Request_Side.Text = Request_Side
            Dim OrderStatus As String = row("OrderStatus").ToString()
            Me.OrderStatus.Text = OrderStatus
            dgv_PurchaseOrders.Rows.Add(productID, productName, Unit_Name, QTE_IN_STOCK, Minimum_Threshold, Required_Quantity, Purpose, Unit_Price, Total_Unit_Price, Maximum_Threshold, Unit_ID, Cat_ID, Cat_Name, Initial_Balance)
        Next
    End Sub

    Private Sub fillDataGrid()
        'الكود ده عشان الكمبوبوكس اللى بداخل الداتا جريد يقرأ البيانات من حقل معين فى قاعدة البيانات
        If Con.State <> ConnectionState.Open Then
            Con.Open()
        End If
        Dim str As String = "Select Product_Name FROM Tbl_Products"
        Dim C2 As DataGridViewComboBoxColumn = CType(dgv_PurchaseOrders.Columns("DGV_Product_Name"), DataGridViewComboBoxColumn)
        Dim cmd As New SqlCommand(str, Con)
        Dim dr As SqlDataReader = cmd.ExecuteReader()
        C2.Items.Clear()
        While (dr.Read)
            C2.Items.Add(dr(0).ToString())
            C2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End While
        dr.Close() ' يجب إغلاق SqlDataReader بعد الانتهاء من استخدامه
        dgv_PurchaseOrders.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
    End Sub

    Private Sub Frm_Purchase_Orders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillDataGrid()
    End Sub

    Private Sub dgv_PurchaseOrders_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_PurchaseOrders.CellValueChanged
        Try
            If e.RowIndex >= 0 AndAlso e.ColumnIndex = dgv_PurchaseOrders.Columns("DGV_Add_Balance").Index Then
                Dim rowIndex As Integer = e.RowIndex
                If dgv_PurchaseOrders.Rows.Count > 0 AndAlso rowIndex <> dgv_PurchaseOrders.NewRowIndex Then
                    If dgv_PurchaseOrders.Rows(rowIndex).Cells("DGV_Unit_Price").Value IsNot Nothing AndAlso dgv_PurchaseOrders.Rows(rowIndex).Cells("DGV_Add_Balance").Value IsNot Nothing Then
                        Dim unitPrice As Double
                        Dim addBalance As Double
                        If Double.TryParse(dgv_PurchaseOrders.Rows(rowIndex).Cells("DGV_Unit_Price").Value.ToString(), unitPrice) AndAlso Double.TryParse(dgv_PurchaseOrders.Rows(rowIndex).Cells("DGV_Add_Balance").Value.ToString(), addBalance) Then
                            dgv_PurchaseOrders.Rows(rowIndex).Cells("DGV_Total_Unit_Price").Value = unitPrice * addBalance
                            Dim totalInvoiceValue As Double = 0.0
                            For Each row As DataGridViewRow In dgv_PurchaseOrders.Rows
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
                            'Total_Invoice_Value.Text = totalInvoiceValue.ToString()
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

    Private Sub dgv_PurchaseOrders_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_PurchaseOrders.CellEndEdit
        If e.ColumnIndex = dgv_PurchaseOrders.Columns("DGV_Product_ID").Index AndAlso e.RowIndex >= 0 Then
            Dim selectedProduct As String = dgv_PurchaseOrders.Rows(e.RowIndex).Cells("DGV_Product_ID").Value.ToString()
            dgv_PurchaseOrders.Rows(e.RowIndex).Cells("DGV_Product_ID").Value = selectedProduct
            Dim query As String = "SELECT * FROM Tbl_Products WHERE Product_ID = @Product_ID "
            Using con As New SqlConnection(ConStr),
                  Command As New SqlCommand(query, con)
                Command.Parameters.AddWithValue("@Product_ID", selectedProduct)
                Try
                    con.Open()
                    Dim reader As SqlDataReader = Command.ExecuteReader()
                    If reader.Read() Then
                        dgv_PurchaseOrders.Rows(e.RowIndex).Cells("DGV_Product_Name").Value = reader("Product_Name").ToString()
                        dgv_PurchaseOrders.Rows(e.RowIndex).Cells("DGV_QTE_IN_STOCK").Value = reader("QTE_IN_STOCK").ToString()
                        dgv_PurchaseOrders.Rows(e.RowIndex).Cells("DGV_CAT_ID").Value = reader("CAT_ID").ToString()
                        dgv_PurchaseOrders.Rows(e.RowIndex).Cells("DGV_CAT_Name").Value = reader("CAT_Name").ToString()
                        dgv_PurchaseOrders.Rows(e.RowIndex).Cells("DGV_Unit_ID").Value = reader("Unit_ID").ToString()
                        dgv_PurchaseOrders.Rows(e.RowIndex).Cells("DGV_Unit_Name").Value = reader("Unit_Name").ToString()
                        dgv_PurchaseOrders.Rows(e.RowIndex).Cells("DGV_Initial_Balance").Value = reader("Initial_Balance").ToString()
                        dgv_PurchaseOrders.Rows(e.RowIndex).Cells("DGV_Unit_Price").Value = reader("Unit_Price").ToString()
                        dgv_PurchaseOrders.Rows(e.RowIndex).Cells("DGV_Minimum_Threshold").Value = reader("Minimum_Threshold").ToString()
                        dgv_PurchaseOrders.Rows(e.RowIndex).Cells("DGV_Maximum_Threshold").Value = reader("Maximum_Threshold").ToString()
                    End If
                    reader.Close()
                Catch ex As Exception
                    MessageBox.Show("حدث خطأ: " & ex.Message)
                End Try
            End Using
            NumberOfItems.Text = dgv_PurchaseOrders.Rows.Count - 1
        End If
        Con.Close()
    End Sub

    '''Private Function GetCellValueOrDefault(row As DataGridViewRow, cellName As String) As Object
    '''    Dim value = row.Cells(cellName).Value

    '''    If value Is Nothing OrElse IsDBNull(value) Then
    '''        Return 0.0
    '''    Else
    '''        Return Convert.ToDouble(value)
    '''    End If
    '''End Function

    '''Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
    '''    Try
    '''        If String.IsNullOrWhiteSpace(Order_Number.Text) Then
    '''            MessageBox.Show("يرجى إدخال رقم الفاتورة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
    '''            Exit Sub
    '''        End If
    '''        ' التحقق من وجود صفوف
    '''        If dgv_PurchaseOrders.Rows.Count <= 1 Then
    '''            MessageBox.Show("يرجى اختيار صنف واحد على الاقل فى الاذن", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
    '''            Exit Sub
    '''        End If
    '''        If Con.State = ConnectionState.Closed Then
    '''            Con.Open()
    '''        End If
    '''        ' حلقة لإدراج بيانات الأصناف
    '''        For Each row As DataGridViewRow In dgv_PurchaseOrders.Rows
    '''            If Not row.IsNewRow Then
    '''                Using cmd As New SqlCommand("Insert Into PurchaseOrders (Order_Number,OrderDate,Product_ID,Product_Name,Initial_Balance,Required_Quantity,Unit_Price,Unit_ID,Unit_Name,CAT_ID,CAT_Name,TotalAmount,QTE_IN_STOCK,Purpose,OrderStatus,Request_Side,Minimum_Threshold,Maximum_Threshold)values(@Order_Number,@OrderDate,@Product_ID,@Product_Name,@Initial_Balance,@Required_Quantity,@Unit_Price,@Unit_ID,@Unit_Name,@CAT_ID,@CAT_Name,@TotalAmount,@QTE_IN_STOCK,@Purpose,@OrderStatus,@Request_Side,@Minimum_Threshold,@Maximum_Threshold)", Con)
    '''                    cmd.Parameters.AddWithValue("@Order_Number", Order_Number.Text)
    '''                    ' التحقق من وجود قيمة لـ Product_ID
    '''                    If Not row.Cells("DGV_Product_ID").Value Is DBNull.Value Then
    '''                        cmd.Parameters.AddWithValue("@Product_ID", row.Cells("DGV_Product_ID").Value)
    '''                    Else
    '''                        MessageBox.Show("حدث خطأ: لم يتم توفير Product_Name")
    '''                        Exit Sub
    '''                    End If
    '''                    cmd.Parameters.AddWithValue("@Product_Name", row.Cells("DGV_Product_Name").Value)
    '''                    cmd.Parameters.AddWithValue("@Initial_Balance", row.Cells("DGV_Initial_Balance").Value)
    '''                    cmd.Parameters.AddWithValue("@Required_Quantity", row.Cells("DGV_Add_Balance").Value)

    '''                    'cmd.Parameters.AddWithValue("@Unit_Price", GetCellValueOrDefault(row, "DGV_Unit_Price"))
    '''                    If Not row.Cells("DGV_Unit_Price").Value Is DBNull.Value Then
    '''                        cmd.Parameters.AddWithValue("@Unit_Price", row.Cells("DGV_Unit_Price").Value)
    '''                    Else
    '''                        cmd.Parameters.AddWithValue("@Unit_Price", "") ' أو أي قيمة افتراضية ترغب بها
    '''                    End If


    '''                    If Not row.Cells("DGV_Unit_ID").Value Is DBNull.Value Then
    '''                        cmd.Parameters.AddWithValue("@Unit_ID", row.Cells("DGV_Unit_ID").Value)
    '''                    Else
    '''                        cmd.Parameters.AddWithValue("@Unit_ID", "") ' أو أي قيمة افتراضية ترغب بها
    '''                    End If

    '''                    If Not row.Cells("DGV_Unit_Name").Value Is DBNull.Value Then
    '''                        cmd.Parameters.AddWithValue("@Unit_Name", row.Cells("DGV_Unit_Name").Value)
    '''                    Else
    '''                        cmd.Parameters.AddWithValue("@Unit_Name", "") ' أو أي قيمة افتراضية ترغب بها
    '''                    End If
    '''                    If Not row.Cells("DGV_CAT_ID").Value Is DBNull.Value Then
    '''                        cmd.Parameters.AddWithValue("@CAT_ID", row.Cells("DGV_CAT_ID").Value)
    '''                    Else
    '''                        cmd.Parameters.AddWithValue("@CAT_ID", "") ' أو أي قيمة افتراضية ترغب بها
    '''                    End If
    '''                    If Not row.Cells("DGV_CAT_Name").Value Is DBNull.Value Then
    '''                        cmd.Parameters.AddWithValue("@CAT_Name", row.Cells("DGV_CAT_Name").Value)
    '''                    Else
    '''                        cmd.Parameters.AddWithValue("@CAT_Name", "") ' أو أي قيمة افتراضية ترغب بها
    '''                    End If
    '''                    cmd.Parameters.AddWithValue("@OrderDate", OrderDate.Value)
    '''                    cmd.Parameters.AddWithValue("@QTE_IN_STOCK", row.Cells("DGV_QTE_IN_STOCK").Value)

    '''                    If Not row.Cells("DGV_Total_Unit_Price").Value Is DBNull.Value Then
    '''                        cmd.Parameters.AddWithValue("@TotalAmount", row.Cells("DGV_Total_Unit_Price").Value)
    '''                    Else
    '''                        cmd.Parameters.AddWithValue("@TotalAmount", "") ' أو أي قيمة افتراضية ترغب بها
    '''                    End If

    '''                    If Not row.Cells("DGV_Purpose").Value Is DBNull.Value Then
    '''                        cmd.Parameters.AddWithValue("@Purpose", row.Cells("DGV_Purpose").Value)
    '''                    Else
    '''                        cmd.Parameters.AddWithValue("@Purpose", "") ' أو أي قيمة افتراضية ترغب بها
    '''                    End If

    '''                    cmd.Parameters.AddWithValue("@OrderStatus", OrderStatus.Text)
    '''                    cmd.Parameters.AddWithValue("@Request_Side", Request_Side.Text)

    '''                    'cmd.Parameters.AddWithValue("@Minimum_Threshold", row.Cells("DGV_Minimum_Threshold").Value)
    '''                    If Not row.Cells("DGV_Minimum_Threshold").Value Is DBNull.Value Then
    '''                        cmd.Parameters.AddWithValue("@Minimum_Threshold", row.Cells("DGV_Minimum_Threshold").Value)
    '''                    Else
    '''                        cmd.Parameters.AddWithValue("@Minimum_Threshold", "") ' أو أي قيمة افتراضية ترغب بها
    '''                    End If

    '''                    'cmd.Parameters.AddWithValue("@Maximum_Threshold", row.Cells("DGV_Maximum_Threshold").Value)
    '''                    If Not row.Cells("DGV_Maximum_Threshold").Value Is DBNull.Value Then
    '''                        cmd.Parameters.AddWithValue("@Maximum_Threshold", row.Cells("DGV_Maximum_Threshold").Value)
    '''                    Else
    '''                        cmd.Parameters.AddWithValue("@Maximum_Threshold", "") ' أو أي قيمة افتراضية ترغب بها
    '''                    End If
    '''                    cmd.CommandType = CommandType.Text
    '''                    cmd.CommandTimeout = 420
    '''                    cmd.ExecuteNonQuery()
    '''                End Using
    '''            End If
    '''        Next
    '''        'MessageBox.Show("تم الحفظ بنجاح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
    '''        Con.Close()
    '''        Con.Open()
    '''        Dim result As DialogResult = MessageBox.Show("هل تريد طباعة أمر الشراء ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
    '''        If result = DialogResult.Yes Then
    '''            ' إذا كانت الإجابة نعم، قم بتنفيذ الإجراء SelectAll_PurchaseOrders
    '''            SelectAll_PurchaseOrders()
    '''            ' بعد ذلك، قم بتنفيذ FillReportAndPrint 
    '''            FillReportAndPrint()
    '''        Else
    '''            ClearControls()
    '''        End If
    '''    Catch ex As Exception
    '''        MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
    '''    End Try
    '''    Con.Close()
    '''End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Try
            If Not ValidateInput() Then Exit Sub

            Using connection As New SqlConnection(ConStr)
                Con.Open()

                For Each row As DataGridViewRow In dgv_PurchaseOrders.Rows
                    If Not row.IsNewRow Then
                        InsertPurchaseOrder(connection, row)
                    End If
                Next
            End Using

            Dim result As DialogResult = MessageBox.Show("هل تريد طباعة أمر الشراء ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            If result = DialogResult.Yes Then
                SelectAll_PurchaseOrders()
                FillReportAndPrint()
            Else
                ClearControls()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
        End Try
    End Sub

    Private Function ValidateInput() As Boolean
        If String.IsNullOrWhiteSpace(Order_Number.Text) Then
            MessageBox.Show("يرجى إدخال رقم الفاتورة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Return False
        End If

        If dgv_PurchaseOrders.Rows.Count <= 1 Then
            MessageBox.Show("يرجى اختيار صنف واحد على الاقل فى الاذن", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            Return False
        End If

        Return True
    End Function

    Private Sub InsertPurchaseOrder(connection As SqlConnection, row As DataGridViewRow)
        Using cmd As New SqlCommand("Insert Into PurchaseOrders (Order_Number, OrderDate, Product_ID, Product_Name, Initial_Balance, Required_Quantity, Unit_Price, Unit_ID, Unit_Name, CAT_ID, CAT_Name, TotalAmount, QTE_IN_STOCK, Purpose, OrderStatus, Request_Side, Minimum_Threshold, Maximum_Threshold) values (@Order_Number, @OrderDate, @Product_ID, @Product_Name, @Initial_Balance, @Required_Quantity, @Unit_Price, @Unit_ID, @Unit_Name, @CAT_ID, @CAT_Name, @TotalAmount, @QTE_IN_STOCK, @Purpose, @OrderStatus, @Request_Side, @Minimum_Threshold, @Maximum_Threshold)", Con)
            cmd.Parameters.AddWithValue("@Order_Number", Order_Number.Text)
            cmd.Parameters.AddWithValue("@OrderDate", OrderDate.Value)
            cmd.Parameters.AddWithValue("@Product_ID", GetDbValue(row, "DGV_Product_ID"))
            cmd.Parameters.AddWithValue("@Product_Name", row.Cells("DGV_Product_Name").Value)
            cmd.Parameters.AddWithValue("@Initial_Balance", GetDbValue(row, "DGV_Initial_Balance"))
            cmd.Parameters.AddWithValue("@Required_Quantity", GetDbValue(row, "DGV_Add_Balance"))
            cmd.Parameters.AddWithValue("@Unit_Price", GetDbValue(row, "DGV_Unit_Price"))
            cmd.Parameters.AddWithValue("@Unit_ID", GetDbValue(row, "DGV_Unit_ID"))
            cmd.Parameters.AddWithValue("@Unit_Name", GetDbValue(row, "DGV_Unit_Name"))
            cmd.Parameters.AddWithValue("@CAT_ID", GetDbValue(row, "DGV_CAT_ID"))
            cmd.Parameters.AddWithValue("@CAT_Name", GetDbValue(row, "DGV_CAT_Name"))
            cmd.Parameters.AddWithValue("@TotalAmount", GetDbValue(row, "DGV_Total_Unit_Price"))
            cmd.Parameters.AddWithValue("@QTE_IN_STOCK", GetDbValue(row, "DGV_QTE_IN_STOCK"))
            cmd.Parameters.AddWithValue("@Purpose", GetDbValue(row, "DGV_Purpose"))
            cmd.Parameters.AddWithValue("@OrderStatus", OrderStatus.Text)
            cmd.Parameters.AddWithValue("@Request_Side", Request_Side.Text)
            cmd.Parameters.AddWithValue("@Minimum_Threshold", GetDbValue(row, "DGV_Minimum_Threshold"))
            cmd.Parameters.AddWithValue("@Maximum_Threshold", GetDbValue(row, "DGV_Maximum_Threshold"))
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 420
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Private Function GetDbValue(row As DataGridViewRow, columnName As String) As Object
        If row.Cells(columnName).Value Is DBNull.Value OrElse String.IsNullOrWhiteSpace(row.Cells(columnName).Value.ToString()) Then
            Return DBNull.Value
        ElseIf IsNumeric(row.Cells(columnName).Value) Then
            Return Convert.ToDecimal(row.Cells(columnName).Value)
        Else
            Return row.Cells(columnName).Value
        End If
    End Function

    Private Sub FillReportAndPrint()
        Dim OrderDateValue As String = OrderDate.Value.ToShortDateString
        Dim rep As New Rep_Purchase_Orders
        rep.SetDataSource(dt_PurchaseOrders.DefaultView)
        Frm_Report.CrystalReportViewer1.ReportSource = rep
        rep.SetParameterValue("Par_Order_Number", (Me.Order_Number.Text))
        rep.SetParameterValue("Par_Date", OrderDateValue)
        Frm_Report.CrystalReportViewer1.Refresh()
        Frm_Report.ShowDialog()
    End Sub

    Private Sub btn_Report_Click(sender As Object, e As EventArgs) Handles btn_Report.Click
        FillReportAndPrint()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        SelectAll_PurchaseOrders()
    End Sub

End Class