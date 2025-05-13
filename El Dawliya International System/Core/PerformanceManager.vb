Imports System.Collections.Concurrent
Imports System.Threading

Public Class PerformanceManager
    Private Shared _instance As PerformanceManager
    Private ReadOnly _performanceCounters As New ConcurrentDictionary(Of String, Stopwatch)
    Private _memoryThreshold As Long = 500 * 1024 * 1024 ' 500 MB
    Private ReadOnly _logger As Logger

    Private Sub New()
        _logger = Logger.GetInstance()
    End Sub

    Public Shared Function GetInstance() As PerformanceManager
        If _instance Is Nothing Then
            _instance = New PerformanceManager()
        End If
        Return _instance
    End Function

    '  ⁄ÌÌ‰ ⁄ »… «·–«ﬂ—… »‘ﬂ· œÌ‰«„ÌﬂÌ
    Public Sub SetMemoryThreshold(newThreshold As Long)
        _memoryThreshold = newThreshold
        _logger.LogInfo($"Memory threshold updated to: {newThreshold / (1024 * 1024)} MB")
    End Sub

    Public Sub StartMeasurement(operationName As String)
        Dim stopwatch = _performanceCounters.GetOrAdd(operationName, Function() New Stopwatch())
        stopwatch.Restart()
    End Sub

    Public Function StopMeasurement(operationName As String) As TimeSpan
        Dim stopwatch As Stopwatch
        If _performanceCounters.TryGetValue(operationName, stopwatch) Then ' «·Õ’Ê· ⁄·Ï «·ﬂ«∆‰ „‰ «·ﬁ«„Ê”
            stopwatch.Stop() ' «” œ⁄«¡ Stop ⁄·Ï «·ﬂ«∆‰ stopwatch
            Dim elapsed = stopwatch.Elapsed ' ﬁ—«¡… «·ﬁÌ„… «·„” €—ﬁ…
            _logger.LogInfo($"Operation '{operationName}' took {elapsed.TotalMilliseconds:F2} ms")
            Return elapsed
        End If
        Return TimeSpan.Zero ' ›Ì Õ«· ·„ Ì „ «·⁄ÀÊ— ⁄·Ï «·⁄„·Ì…
    End Function

    Public Sub MonitorMemoryUsage()
        Try
            Dim currentProcess = Process.GetCurrentProcess()
            Dim memoryUsed = currentProcess.PrivateMemorySize64

            If memoryUsed > _memoryThreshold Then
                _logger.LogWarning($"High memory usage detected: {memoryUsed / (1024 * 1024):F2} MB. Consider optimizing memory usage.")
            End If

        Catch ex As Exception
            _logger.LogError("Error monitoring memory usage", ex)
        End Try
    End Sub

    Public Function GetOperationStatistics(operationName As String) As String
        Dim stopwatch As Stopwatch
        If _performanceCounters.TryGetValue(operationName, stopwatch) Then ' «” Œœ„ «·„ €Ì— stopwatch ﬂ„—Ã⁄
            Return $"Operation: {operationName}, Last execution time: {stopwatch.Elapsed.TotalMilliseconds:F2} ms" ' «” Œœ„ «·ﬂ«∆‰ stopwatch
        End If
        Return $"No statistics available for operation: {operationName}"
    End Function


    Public Sub OptimizeOperation(action As Action, Optional retryCount As Integer = 3)
        Dim attempt As Integer = 0
        Dim lastException As Exception = Nothing

        While attempt < retryCount
            Try
                StartMeasurement($"Operation_Attempt_{attempt + 1}")
                action.Invoke()
                Dim elapsed = StopMeasurement($"Operation_Attempt_{attempt + 1}")
                _logger.LogInfo($"Operation completed successfully on attempt {attempt + 1} in {elapsed.TotalMilliseconds:F2} ms")
                Return
            Catch ex As Exception
                lastException = ex
                _logger.LogError($"Operation failed on attempt {attempt + 1}", ex)
                Thread.Sleep(1000 * (attempt + 1)) ' Exponential backoff
                attempt += 1
            End Try
        End While

        If lastException IsNot Nothing Then
            Throw New Exception($"Operation failed after {retryCount} attempts", lastException)
        End If
    End Sub

    Public Sub ClearPerformanceCounters()
        _performanceCounters.Clear()
        _logger.LogInfo("All performance counters have been cleared.")
    End Sub
End Class
