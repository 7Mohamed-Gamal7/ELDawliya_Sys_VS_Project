Imports System.IO
Imports System.Text

Public Class Logger
    Private Shared _instance As Logger
    Private ReadOnly _logPath As String
    Private ReadOnly _logLock As New Object()

    Public Enum LogLevel
        Info
        Warning
        [Error]
        Debug
    End Enum

    Private Sub New()
        _logPath = Path.Combine(Application.StartupPath, "Logs")
        If Not Directory.Exists(_logPath) Then
            Directory.CreateDirectory(_logPath)
        End If
    End Sub

    Public Shared Function GetInstance() As Logger
        If _instance Is Nothing Then
            _instance = New Logger()
        End If
        Return _instance
    End Function

    Public Sub Log(message As String, level As LogLevel, Optional exception As Exception = Nothing)
        SyncLock _logLock
            Try
                Dim logFileName As String = $"Log_{DateTime.Now:yyyy-MM-dd}.txt"
                Dim logFilePath As String = Path.Combine(_logPath, logFileName)
                Dim logMessage As New StringBuilder()

                logMessage.AppendLine($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] [{level}]")
                logMessage.AppendLine($"Message: {message}")

                If exception IsNot Nothing Then
                    logMessage.AppendLine($"Exception: {exception.Message}")
                    logMessage.AppendLine($"Stack Trace: {exception.StackTrace}")
                End If

                logMessage.AppendLine("----------------------------------------")

                File.AppendAllText(logFilePath, logMessage.ToString())

            Catch ex As Exception
                ' كتابة رسالة الخطأ في ملف احتياطي إذا فشلت الكتابة في الملف الرئيسي
                Try
                    Dim fallbackPath As String = Path.Combine(_logPath, "fallback_log.txt")
                    Dim fallbackMessage As String = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] Error logging message: {ex.Message}{vbCrLf}"
                    File.AppendAllText(fallbackPath, fallbackMessage)
                Catch
                    ' إذا فشل كل شيء، يتم تجاهل الخطأ
                End Try
            End Try
        End SyncLock
    End Sub

    Public Sub LogInfo(message As String)
        Log(message, LogLevel.Info)
    End Sub

    Public Sub LogWarning(message As String)
        Log(message, LogLevel.Warning)
    End Sub

    Public Sub LogError(message As String, Optional exception As Exception = Nothing)
        Log(message, LogLevel.Error, exception)
    End Sub

    Public Sub LogDebug(message As String)
#If DEBUG Then
        Log(message, LogLevel.Debug)
#End If
    End Sub

    Public Sub ClearOldLogs(daysToKeep As Integer)
        Try
            Dim files As String() = Directory.GetFiles(_logPath, "Log_*.txt")
            Dim cutoffDate = DateTime.Now.AddDays(-daysToKeep)

            For Each file As String In files
                Dim fileInfo = New FileInfo(file)
                If fileInfo.Exists AndAlso fileInfo.CreationTime < cutoffDate Then
                    Try
                        System.IO.File.Delete(file)
                    Catch ex As IOException
                        Log($"Unable to delete file {file}: {ex.Message}", LogLevel.Warning, ex)
                    End Try
                End If
            Next
        Catch ex As Exception
            Log("Error clearing old logs", LogLevel.Error, ex)
        End Try
    End Sub
End Class
