Imports System.Data.SqlClient

Public Class DatabaseManager
    Private Shared _instance As DatabaseManager
    Private Shared _connectionString As String

    Private Sub New()
        _connectionString = GetConnectionString()
    End Sub

    Public Shared ReadOnly Property Instance As DatabaseManager
        Get
            If _instance Is Nothing Then
                _instance = New DatabaseManager()
            End If
            Return _instance
        End Get
    End Property

    Public Function GetConnection() As SqlConnection
        Return New SqlConnection(_connectionString)
    End Function

    Public Function ExecuteQuery(Of T)(query As String, parameterSetup As Action(Of SqlCommand), dataReader As Func(Of SqlDataReader, T)) As T
        Using connection As SqlConnection = GetConnection()
            Using command As New SqlCommand(query, connection)
                If parameterSetup IsNot Nothing Then
                    parameterSetup(command)
                End If

                connection.Open()
                Using reader As SqlDataReader = command.ExecuteReader()
                    Return dataReader(reader)
                End Using
            End Using
        End Using
    End Function

    Public Function ExecuteNonQuery(query As String, parameterSetup As Action(Of SqlCommand)) As Integer
        Using connection As SqlConnection = GetConnection()
            Using command As New SqlCommand(query, connection)
                If parameterSetup IsNot Nothing Then
                    parameterSetup(command)
                End If

                connection.Open()
                Return command.ExecuteNonQuery()
            End Using
        End Using
    End Function

    Public Function ExecuteScalar(Of T)(query As String, parameterSetup As Action(Of SqlCommand)) As T
        Using connection As SqlConnection = GetConnection()
            Using command As New SqlCommand(query, connection)
                If parameterSetup IsNot Nothing Then
                    parameterSetup(command)
                End If

                connection.Open()
                Dim result = command.ExecuteScalar()
                If result Is DBNull.Value Then
                    Return Nothing
                End If
                Return DirectCast(result, T)
            End Using
        End Using
    End Function

    Public Function BeginTransaction() As (Connection As SqlConnection, Transaction As SqlTransaction)
        Dim connection = GetConnection()
        connection.Open()
        Dim transaction = connection.BeginTransaction()
        Return (connection, transaction)
    End Function
End Class
