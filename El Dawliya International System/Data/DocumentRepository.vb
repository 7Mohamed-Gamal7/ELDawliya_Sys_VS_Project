Imports System.Data.SqlClient

Public Class DocumentRepository
    Private ReadOnly _dbManager As DatabaseManager

    Public Sub New()
        _dbManager = DatabaseManager.Instance
    End Sub

    Public Function GetDocumentByNumber(documentNumber As String) As DataTable
        Dim query As String = "SELECT * FROM Tbl_Invoices WHERE txt_Invoice_Number = @txt_Invoice_Number"
        Dim dt As New DataTable()

        _dbManager.ExecuteQuery(Of Boolean)(query,
            Sub(cmd)
                cmd.Parameters.AddWithValue("@txt_Invoice_Number", documentNumber)
            End Sub,
            Function(reader)
                dt.Load(reader)
                Return True
            End Function)

        Return dt
    End Function

    Public Function SaveDocument(document As DataTable, items As DataTable) As Boolean
        Using connection = _dbManager.GetConnection()
            connection.Open()
            Using transaction = connection.BeginTransaction()
                Try
                    ' Save document header
                    SaveDocumentHeader(connection, transaction, document)

                    ' Save document items
                    SaveDocumentItems(connection, transaction, items)

                    transaction.Commit()
                    Return True
                Catch ex As Exception
                    transaction.Rollback()
                    Throw New Exception("Failed to save document: " & ex.Message, ex)
                End Try
            End Using
        End Using
    End Function

    Private Sub SaveDocumentHeader(connection As SqlConnection, transaction As SqlTransaction, document As DataTable)
        ' Implementation for saving document header
        ' This will be implemented based on your specific requirements
    End Sub

    Private Sub SaveDocumentItems(connection As SqlConnection, transaction As SqlTransaction, items As DataTable)
        ' Implementation for saving document items
        ' This will be implemented based on your specific requirements
    End Sub

    Public Function GetDocumentItems(documentId As Integer) As DataTable
        Dim query As String = "SELECT * FROM Tbl_InvoiceItems WHERE Invoice_ID = @Invoice_ID"
        Dim dt As New DataTable()

        _dbManager.ExecuteQuery(Of Boolean)(query,
            Sub(cmd)
                cmd.Parameters.AddWithValue("@Invoice_ID", documentId)
            End Sub,
            Function(reader)
                dt.Load(reader)
                Return True
            End Function)

        Return dt
    End Function
End Class
