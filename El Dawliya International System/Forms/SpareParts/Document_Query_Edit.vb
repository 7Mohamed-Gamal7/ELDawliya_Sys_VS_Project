Imports System.Data.SqlClient
Public Class Document_Query_Edit
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Public dt_Tbl_InvoiceItems As New DataTable
    Public dt_Tbl_Ezn_Customer As New DataTable

    ' إضافة أعمدة الأزرار مرة واحدة فقط
    Private buttonsAdded As Boolean = False

    Private Sub AddActionButtons()
        If Not buttonsAdded Then
            Dim btnEdit As New DataGridViewButtonColumn()
            btnEdit.Name = "EditButton"
            btnEdit.HeaderText = "تعديل"
            btnEdit.Text = "تعديل"
            btnEdit.UseColumnTextForButtonValue = True
            dgv_Tbl_InvoiceItems.Columns.Add(btnEdit)

            Dim btnDelete As New DataGridViewButtonColumn()
            btnDelete.Name = "DeleteButton"
            btnDelete.HeaderText = "حذف"
            btnDelete.Text = "حذف"
            btnDelete.UseColumnTextForButtonValue = True
            dgv_Tbl_InvoiceItems.Columns.Add(btnDelete)

            buttonsAdded = True
        End If
    End Sub

    Private Sub ConfigureDataGridViewColumns(dgv As DataGridView)
        With dgv
            .Columns("Invoice_Code_Programing").Visible = False
            .Columns("Invoice_ID").Visible = False
            .Columns("Unit_ID").Visible = False
            .Columns("Balance_Time_Entry").Visible = False

            .Columns("Product_Name").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            .Columns("Unit_Name").Width = 120
            .Columns("Quantity_ElWarad").Width = 150
            .Columns("Quantity_ElMonsarf").Width = 150
        End With
    End Sub

    Private Sub Invoice_Number_KeyDown(sender As Object, e As KeyEventArgs) Handles Invoice_Number.KeyDown
        If e.KeyCode = Keys.Enter Then
            Try
                'RetrieveInvoiceData(Invoice_Number.Text)
                'SelectAll_Tbl_InvoiceItems(dgv_Tbl_InvoiceItems)
                AddActionButtons()
                ConfigureDataGridViewColumns(dgv_Tbl_InvoiceItems)
            Catch ex As Exception
                MessageBox.Show("خطأ في تحميل البيانات: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub EditRow(row As DataGridViewRow)
        Try
            Using cmd As New SqlCommand("UPDATE Tbl_InvoiceItems SET 
                Product_ID = @ProductID, 
                Quantity_ElWarad = @QtyWarad,
                Quantity_ElMonsarf = @QtyMonsarf
                WHERE Invoice_Code_Programing = @Code", Con)

                cmd.Parameters.AddWithValue("@ProductID", row.Cells("Product_ID").Value)
                cmd.Parameters.AddWithValue("@QtyWarad", row.Cells("Quantity_ElWarad").Value)
                cmd.Parameters.AddWithValue("@QtyMonsarf", row.Cells("Quantity_ElMonsarf").Value)
                cmd.Parameters.AddWithValue("@Code", row.Cells("Invoice_Code_Programing").Value)

                Con.Open()
                cmd.ExecuteNonQuery()
                Con.Close()

                MessageBox.Show("تم التحديث بنجاح")
            End Using
        Catch ex As Exception
            MessageBox.Show("خطأ في التعديل: " & ex.Message)
        End Try
    End Sub

    Private Sub DeleteRow(row As DataGridViewRow)
        Try
            If MessageBox.Show("هل تريد حذف هذا السجل؟", "تأكيد", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Using cmd As New SqlCommand("DELETE FROM Tbl_InvoiceItems 
                                            WHERE Invoice_Code_Programing = @Code", Con)

                    cmd.Parameters.AddWithValue("@Code", row.Cells("Invoice_Code_Programing").Value)

                    Con.Open()
                    cmd.ExecuteNonQuery()
                    Con.Close()

                    dt_Tbl_InvoiceItems.Rows.RemoveAt(row.Index)
                    MessageBox.Show("تم الحذف بنجاح")
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("خطأ في الحذف: " & ex.Message)
        End Try
    End Sub

    Private Sub UpdateProductStock(productID As String, quantityChange As Decimal, operationType As String)
        Try
            Using cmd As New SqlCommand("UPDATE Tbl_Products SET 
                QTE_IN_STOCK = QTE_IN_STOCK + @Change,
                " & operationType & " = " & operationType & " + @Change
                WHERE Product_ID = @ProductID", Con)

                cmd.Parameters.AddWithValue("@Change", quantityChange)
                cmd.Parameters.AddWithValue("@ProductID", productID)

                Con.Open()
                cmd.ExecuteNonQuery()
                Con.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("خطأ في تحديث المخزون: " & ex.Message)
        End Try
    End Sub

    Private Sub dgv_Tbl_InvoiceItems_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Tbl_InvoiceItems.CellEndEdit
        Try
            Dim row = dgv_Tbl_InvoiceItems.Rows(e.RowIndex)
            Dim columnName = dgv_Tbl_InvoiceItems.Columns(e.ColumnIndex).Name

            If columnName.StartsWith("Quantity_") Then
                Dim oldValue = CDec(row.Cells(columnName).Tag)
                Dim newValue = CDec(row.Cells(columnName).Value)
                Dim productID = row.Cells("Product_ID").Value.ToString()

                ' تحديث المخزون
                UpdateProductStock(productID, newValue - oldValue, columnName)

                ' تحديث القيمة الإجمالية
                CalculateTotal()
            End If
        Catch ex As Exception
            MessageBox.Show("خطأ في التحرير: " & ex.Message)
        End Try
    End Sub

    Private Sub CalculateTotal()
        Try
            Dim total As Decimal = 0
            For Each row As DataGridViewRow In dgv_Tbl_InvoiceItems.Rows
                If Not row.IsNewRow Then
                    total += CDec(row.Cells("Unit_Price").Value) *
                            (CDec(row.Cells("Quantity_ElWarad").Value) +
                            CDec(row.Cells("Quantity_ElMonsarf").Value))
                End If
            Next
            Total_Invoice_Value.Text = total.ToString("N2")
        Catch ex As Exception
            MessageBox.Show("خطأ في حساب الإجمالي: " & ex.Message)
        End Try
    End Sub

    'Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
    '    Try
    '        Using cmd As New SqlCommand("UPDATE Tbl_Invoices SET 
    '            Invoice_Date = @Date,
    '            Total_Invoice_Value = @Total
    '            WHERE Invoice_Number = @Num", Con)

    '            cmd.Parameters.AddWithValue("@Date", Invoice_Date.Value)
    '            cmd.Parameters.AddWithValue("@Total", CDec(Total_Invoice_Value.Text))
    '            cmd.Parameters.AddWithValue("@Num", Invoice_Number.Text)

    '            Con.Open()
    '            cmd.ExecuteNonQuery()
    '            Con.Close()

    '            MessageBox.Show("تم حفظ التعديلات بنجاح")
    '        End Using
    '    Catch ex As Exception
    '        MessageBox.Show("خطأ في الحفظ: " & ex.Message)
    '    End Try
    'End Sub
End Class