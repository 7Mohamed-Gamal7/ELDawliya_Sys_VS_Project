Imports System.Collections.Concurrent
Imports System.Threading

Public Class PerformanceEnhancer
    Private Shared _instance As PerformanceEnhancer
    Private ReadOnly _cache As New ConcurrentDictionary(Of String, Object)
    Private ReadOnly _performanceCounters As New ConcurrentDictionary(Of String, Stopwatch)

    Private Sub New()
    End Sub

    ' الحصول على نسخة واحدة من الكلاس (Singleton)
    Public Shared Function GetInstance() As PerformanceEnhancer
        If _instance Is Nothing Then
            _instance = New PerformanceEnhancer()
        End If
        Return _instance
    End Function

    ' بدء قياس الزمن
    Public Sub StartMeasurement(operationName As String)
        Dim stopwatch = _performanceCounters.GetOrAdd(operationName, Function() New Stopwatch())
        stopwatch.Restart()
    End Sub

    ' إيقاف القياس وإرجاع الزمن المستغرق
    Public Function StopMeasurement(operationName As String) As TimeSpan
        Dim stopwatch As Stopwatch
        If _performanceCounters.TryGetValue(operationName, stopwatch) Then
            stopwatch.Stop()
            Return stopwatch.Elapsed
        End If
        Return TimeSpan.Zero
    End Function

    ' تخزين النتائج في الذاكرة لتقليل الحسابات المتكررة (التخزين المؤقت)
    Public Function CacheResults(Of T)(key As String, fetchData As Func(Of T)) As T
        ' إذا كانت النتيجة موجودة بالفعل في الذاكرة، استخدمها مباشرة
        If _cache.ContainsKey(key) Then
            Return CType(_cache(key), T)
        End If
        ' خلاف ذلك، احصل على النتيجة وحفظها في الذاكرة
        Dim result = fetchData()
        _cache(key) = result
        Return result
    End Function

    ' تحسين العمليات باستخدام التخزين المؤقت وتنفيذ العمليات في الخلفية إذا لزم الأمر
    Public Sub OptimizeOperation(action As Action, Optional retryCount As Integer = 3)
        Dim attempt As Integer = 0
        Dim lastException As Exception = Nothing

        While attempt < retryCount
            Try
                StartMeasurement($"Operation_Attempt_{attempt + 1}")
                action.Invoke()
                Dim elapsed = StopMeasurement($"Operation_Attempt_{attempt + 1}")
                Console.WriteLine($"Operation completed successfully in {elapsed.TotalMilliseconds:F2} ms")
                Return
            Catch ex As Exception
                lastException = ex
                Console.WriteLine($"Operation failed on attempt {attempt + 1}. Retrying...")
                Thread.Sleep(1000 * (attempt + 1)) ' Exponential backoff
                attempt += 1
            End Try
        End While

        If lastException IsNot Nothing Then
            Throw New Exception($"Operation failed after {retryCount} attempts", lastException)
        End If
    End Sub

    ' مراقبة الذاكرة، إذا تجاوزت حد معين يظهر تحذير
    Public Sub MonitorMemoryUsage(Optional threshold As Long = 500 * 1024 * 1024)
        Try
            Dim currentProcess = Process.GetCurrentProcess()
            Dim memoryUsed = currentProcess.PrivateMemorySize64

            If memoryUsed > threshold Then
                Console.WriteLine($"High memory usage detected: {memoryUsed / (1024 * 1024)} MB")
            End If
        Catch ex As Exception
            Console.WriteLine("Error monitoring memory usage: " & ex.Message)
        End Try
    End Sub

    ' استخدام التحميل المؤجل (Lazy Loading) لتقليل استهلاك الذاكرة
    Public Function LazyLoad(Of T)(key As String, fetchData As Func(Of T)) As T
        Return CacheResults(key, fetchData)
    End Function
End Class
