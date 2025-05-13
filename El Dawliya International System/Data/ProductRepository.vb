Imports System.Data.SqlClient

Public Class ProductRepository
    Private ReadOnly _dbManager As DatabaseManager

    Public Sub New()
        _dbManager = DatabaseManager.Instance
    End Sub

    Public Function GetProductBalance(productId As String) As Decimal
        Try
            Return _dbManager.ExecuteScalar(Of Decimal)(
                "SELECT Current_Balance FROM Tbl_Products WHERE Product_ID = @Product_ID",
                Sub(cmd)
                    cmd.Parameters.AddWithValue("@Product_ID", productId)
                End Sub)
        Catch ex As Exception
            Throw New Exception("Error retrieving product balance: " & ex.Message, ex)
        End Try
    End Function

    Public Sub UpdateProductBalance(productId As String, balanceChange As Decimal, transaction As SqlTransaction)
        Try
            Using cmd As New SqlCommand("UPDATE Tbl_Products SET Current_Balance = Current_Balance + @BalanceChange WHERE Product_ID = @Product_ID", transaction.Connection, transaction)
                cmd.Parameters.AddWithValue("@BalanceChange", balanceChange)
                cmd.Parameters.AddWithValue("@Product_ID", productId)
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Throw New Exception("Error updating product balance: " & ex.Message, ex)
        End Try
    End Sub

    Public Function ValidateProductBalance(productId As String, quantityRequired As Decimal) As (IsValid As Boolean, CurrentBalance As Decimal)
        Try
            Dim currentBalance = GetProductBalance(productId)
            Return (currentBalance >= quantityRequired, currentBalance)
        Catch ex As Exception
            Throw New Exception("Error validating product balance: " & ex.Message, ex)
        End Try
    End Function
End Class
