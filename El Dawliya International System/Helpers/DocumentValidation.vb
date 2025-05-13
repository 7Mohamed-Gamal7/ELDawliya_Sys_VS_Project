Public Class DocumentValidation
    Private ReadOnly _dbManager As DatabaseManager

    Public Sub New()
        _dbManager = DatabaseManager.Instance
    End Sub

    Public Function IsDocumentNumberUnique(documentNumber As String) As Boolean
        Try
            Dim count = _dbManager.ExecuteScalar(Of Integer)(
                "SELECT COUNT(*) FROM Tbl_Invoices WHERE txt_Invoice_Number = @DocumentNumber",
                Sub(cmd)
                    cmd.Parameters.AddWithValue("@DocumentNumber", documentNumber)
                End Sub)
            Return count = 0
        Catch ex As Exception
            Throw New Exception("خطأ في التحقق من رقم المستند: " & ex.Message)
        End Try
    End Function

    Public Function IsValidDate(documentDate As Date) As Boolean
        ' التحقق من أن التاريخ ليس في المستقبل وليس أقدم من سنة
        Return documentDate.Date <= Date.Today AndAlso
               documentDate.Date >= Date.Today.AddYears(-1)
    End Function

    Public Function IsValidParty(partyId As Integer, documentType As String) As Boolean
        Try
            Dim tableName, idColumn As String
            Select Case documentType
                Case "اذن صرف", "اذن مرتجع عميل"
                    tableName = "Tbl_Customers"
                    idColumn = "Customer_ID"
                Case "اذن وارد", "اذن مرتجع مورد"
                    tableName = "Tbl_Suppliers"
                    idColumn = "Supplier_ID"
                Case Else
                    Return False
            End Select

            Dim count = _dbManager.ExecuteScalar(Of Integer)(
                $"SELECT COUNT(*) FROM {tableName} WHERE {idColumn} = @PartyId",
                Sub(cmd)
                    cmd.Parameters.AddWithValue("@PartyId", partyId)
                End Sub)
            Return count > 0
        Catch ex As Exception
            Throw New Exception("خطأ في التحقق من العميل/المورد: " & ex.Message)
        End Try
    End Function

    Public Function ValidateQuantityAndPrice(quantity As Decimal, price As Decimal) As (IsValid As Boolean, Message As String)
        If quantity <= 0 Then
            Return (False, "يجب أن تكون الكمية أكبر من صفر")
        End If

        If price < 0 Then
            Return (False, "لا يمكن أن يكون السعر سالباً")
        End If

        Return (True, String.Empty)
    End Function

    Public Function ValidateCompleteDocument(document As DocumentData) As (IsValid As Boolean, Message As String)
        ' التحقق من رقم المستند
        If String.IsNullOrEmpty(document.DocumentNumber) Then
            Return (False, "يجب إدخال رقم المستند")
        End If

        If Not IsDocumentNumberUnique(document.DocumentNumber) Then
            Return (False, "رقم المستند مكرر")
        End If

        ' التحقق من التاريخ
        If Not IsValidDate(document.DocumentDate) Then
            Return (False, "تاريخ المستند غير صالح")
        End If

        ' التحقق من العميل/المورد
        If Not IsValidParty(document.PartyId, document.DocumentType) Then
            Return (False, "بيانات العميل/المورد غير صحيحة")
        End If

        ' التحقق من وجود أصناف
        If document.Items.Count = 0 Then
            Return (False, "يجب إدخال صنف واحد على الأقل")
        End If

        ' التحقق من الكميات والأسعار
        For Each item In document.Items
            Dim validation = ValidateQuantityAndPrice(item.Quantity, item.Price)
            If Not validation.IsValid Then
                Return (False, $"خطأ في الصنف {item.ProductName}: {validation.Message}")
            End If
        Next

        Return (True, String.Empty)
    End Function
End Class

Public Class DocumentData
    Public Property DocumentNumber As String
    Public Property DocumentDate As Date
    Public Property DocumentType As String
    Public Property PartyId As Integer
    Public Property Items As List(Of DocumentItem)
End Class

Public Class DocumentItem
    Public Property ProductId As String
    Public Property ProductName As String
    Public Property Quantity As Decimal
    Public Property Price As Decimal
End Class
