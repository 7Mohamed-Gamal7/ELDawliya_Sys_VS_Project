Imports Microsoft.Office.Interop
Module Excel_Mod

    '''Public Sub ExportToExcel(ByVal dataGridView As DataGridView, ByVal filePath As String, columnsToExport As List(Of String))
    '''    Dim xlApp As Excel.Application = Nothing
    '''    Dim xlWorkBook As Excel.Workbook = Nothing
    '''    Dim xlWorkSheet As Excel.Worksheet = Nothing
    '''    Dim xlRange As Excel.Range = Nothing

    '''    Try
    '''        xlApp = New Excel.Application()
    '''        xlWorkBook = xlApp.Workbooks.Add()
    '''        xlWorkSheet = CType(xlWorkBook.Worksheets(1), Excel.Worksheet)

    '''        ' Copy DataGridView headers to Excel
    '''        For columnIndex As Integer = 0 To dataGridView.Columns.Count - 1
    '''            xlWorkSheet.Cells(1, columnIndex + 1) = dataGridView.Columns(columnIndex).HeaderText
    '''        Next

    '''        ' Copy DataGridView rows to Excel
    '''        Dim rowIndex As Integer = 1
    '''        For i As Integer = 0 To dataGridView.Rows.Count - 1
    '''            Dim isEmptyRow As Boolean = True
    '''            For j As Integer = 0 To dataGridView.Columns.Count - 1
    '''                If Not String.IsNullOrEmpty(dataGridView.Rows(i).Cells(j).Value?.ToString()) Then
    '''                    isEmptyRow = False
    '''                    Exit For
    '''                End If
    '''            Next

    '''            If Not isEmptyRow Then
    '''                rowIndex += 1
    '''                For j As Integer = 0 To dataGridView.Columns.Count - 1
    '''                    xlWorkSheet.Cells(rowIndex, j + 1) = dataGridView.Rows(i).Cells(j).Value?.ToString()
    '''                Next
    '''            End If
    '''        Next
    '''        ' Define range for the table
    '''        xlRange = xlWorkSheet.Range("A1").Resize(rowIndex, dataGridView.Columns.Count)
    '''        ' Create table
    '''        Dim xlTable As Excel.ListObject = xlWorkSheet.ListObjects.AddEx(Excel.XlListObjectSourceType.xlSrcRange, xlRange, , Excel.XlYesNoGuess.xlYes)
    '''        xlTable.TableStyle = "TableStyleMedium9"
    '''        xlWorkSheet.Application.Selection.CurrentRegion.Select()
    '''        xlWorkSheet.Application.Selection.CurrentRegion.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
    '''        xlWorkSheet.Application.ActiveWindow.DisplayRightToLeft = True ' تعيين الصفحة لعرض من اليمين
    '''        ' Save the Excel file
    '''        xlWorkBook.SaveAs(filePath)
    '''        MessageBox.Show("تم تصدير البيانات بنجاح إلى ملف Excel")
    '''    Catch ex As Exception
    '''        MessageBox.Show("حدث خطأ أثناء تصدير البيانات إلى ملف Excel: " & ex.Message)
    '''    Finally
    '''        ' Close and release Excel objects
    '''        If xlRange IsNot Nothing Then ReleaseObject(xlRange)
    '''        If xlWorkBook IsNot Nothing Then xlWorkBook.Close()
    '''        If xlApp IsNot Nothing Then
    '''            xlApp.Quit()
    '''            ReleaseObject(xlApp)
    '''        End If
    '''    End Try
    '''End Sub

    Private Sub ReleaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Public Sub ExportToExcel(ByVal dataGridView As DataGridView, ByVal filePath As String, columnsToExport As List(Of String))
        Dim xlApp As Excel.Application = Nothing
        Dim xlWorkBook As Excel.Workbook = Nothing
        Dim xlWorkSheet As Excel.Worksheet = Nothing
        Dim xlRange As Excel.Range = Nothing

        Try
            xlApp = New Excel.Application()
            xlWorkBook = xlApp.Workbooks.Add()
            xlWorkSheet = CType(xlWorkBook.Worksheets(1), Excel.Worksheet)

            ' Copy DataGridView headers to Excel
            For columnIndex As Integer = 0 To columnsToExport.Count - 1
                xlWorkSheet.Cells(1, columnIndex + 1) = dataGridView.Columns(columnsToExport(columnIndex)).HeaderText
            Next

            ' Copy specified DataGridView rows to Excel
            Dim rowIndex As Integer = 1
            For i As Integer = 0 To dataGridView.Rows.Count - 1
                Dim isEmptyRow As Boolean = True
                For Each columnName As String In columnsToExport
                    Dim columnIndex As Integer = dataGridView.Columns(columnName).Index
                    If Not String.IsNullOrEmpty(dataGridView.Rows(i).Cells(columnIndex).Value?.ToString()) Then
                        isEmptyRow = False
                        Exit For
                    End If
                Next

                If Not isEmptyRow Then
                    rowIndex += 1
                    For Each columnName As String In columnsToExport
                        Dim columnIndex As Integer = dataGridView.Columns(columnName).Index
                        Dim cellValue As Object = dataGridView.Rows(i).Cells(columnIndex).Value
                        Dim xlCell = xlWorkSheet.Cells(rowIndex, Array.IndexOf(columnsToExport.ToArray(), columnName) + 1)

                        ' Set cell value
                        xlCell.Value = cellValue

                        ' Apply date format if the cell value is a date
                        If TypeOf cellValue Is DateTime Then
                            xlCell.NumberFormat = "yyyy-mm-dd" ' تنسيق التاريخ
                        End If
                    Next
                End If
            Next

            ' Define range for the table
            xlRange = xlWorkSheet.Range("A1").Resize(rowIndex, columnsToExport.Count)
            ' Create table
            Dim xlTable As Excel.ListObject = xlWorkSheet.ListObjects.AddEx(Excel.XlListObjectSourceType.xlSrcRange, xlRange, , Excel.XlYesNoGuess.xlYes)
            xlTable.TableStyle = "TableStyleMedium9"
            xlWorkSheet.Application.Selection.CurrentRegion.Select()
            xlWorkSheet.Application.Selection.CurrentRegion.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            xlWorkSheet.Application.ActiveWindow.DisplayRightToLeft = True ' تعيين الصفحة لعرض من اليمين
            ' Save the Excel file
            xlWorkBook.SaveAs(filePath)
            MessageBox.Show("تم تصدير البيانات بنجاح إلى ملف Excel")
        Catch ex As Exception
            MessageBox.Show("حدث خطأ أثناء تصدير البيانات إلى ملف Excel: " & ex.Message)
        Finally
            ' Close and release Excel objects
            If xlRange IsNot Nothing Then ReleaseObject(xlRange)
            If xlWorkBook IsNot Nothing Then xlWorkBook.Close()
            If xlApp IsNot Nothing Then
                xlApp.Quit()
                ReleaseObject(xlApp)
            End If
        End Try
    End Sub


    '''Public Sub ExportToExcel(ByVal dataGridView As DataGridView, ByVal filePath As String, columnsToExport As List(Of String))
    '''    Dim xlApp As Excel.Application = Nothing
    '''    Dim xlWorkBook As Excel.Workbook = Nothing
    '''    Dim xlWorkSheet As Excel.Worksheet = Nothing
    '''    Dim xlRange As Excel.Range = Nothing

    '''    Try
    '''        xlApp = New Excel.Application()
    '''        xlWorkBook = xlApp.Workbooks.Add()
    '''        xlWorkSheet = CType(xlWorkBook.Worksheets(1), Excel.Worksheet)

    '''        ' Copy DataGridView headers to Excel
    '''        For columnIndex As Integer = 0 To columnsToExport.Count - 1
    '''            xlWorkSheet.Cells(1, columnIndex + 1) = dataGridView.Columns(columnsToExport(columnIndex)).HeaderText
    '''        Next

    '''        ' Copy specified DataGridView rows to Excel
    '''        Dim rowIndex As Integer = 1
    '''        For i As Integer = 0 To dataGridView.Rows.Count - 1
    '''            Dim isEmptyRow As Boolean = True
    '''            For Each columnName As String In columnsToExport
    '''                Dim columnIndex As Integer = dataGridView.Columns(columnName).Index
    '''                If Not String.IsNullOrEmpty(dataGridView.Rows(i).Cells(columnIndex).Value?.ToString()) Then
    '''                    isEmptyRow = False
    '''                    Exit For
    '''                End If
    '''            Next

    '''            If Not isEmptyRow Then
    '''                rowIndex += 1
    '''                For Each columnName As String In columnsToExport
    '''                    Dim columnIndex As Integer = dataGridView.Columns(columnName).Index
    '''                    xlWorkSheet.Cells(rowIndex, Array.IndexOf(columnsToExport.ToArray(), columnName) + 1) = dataGridView.Rows(i).Cells(columnIndex).Value?.ToString()
    '''                Next
    '''            End If
    '''        Next

    '''        ' Define range for the table
    '''        xlRange = xlWorkSheet.Range("A1").Resize(rowIndex, columnsToExport.Count)
    '''        ' Create table
    '''        Dim xlTable As Excel.ListObject = xlWorkSheet.ListObjects.AddEx(Excel.XlListObjectSourceType.xlSrcRange, xlRange, , Excel.XlYesNoGuess.xlYes)
    '''        xlTable.TableStyle = "TableStyleMedium9"
    '''        xlWorkSheet.Application.Selection.CurrentRegion.Select()
    '''        xlWorkSheet.Application.Selection.CurrentRegion.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
    '''        xlWorkSheet.Application.ActiveWindow.DisplayRightToLeft = True ' تعيين الصفحة لعرض من اليمين
    '''        ' Save the Excel file
    '''        xlWorkBook.SaveAs(filePath)
    '''        MessageBox.Show("تم تصدير البيانات بنجاح إلى ملف Excel")
    '''    Catch ex As Exception
    '''        MessageBox.Show("حدث خطأ أثناء تصدير البيانات إلى ملف Excel: " & ex.Message)
    '''    Finally
    '''        ' Close and release Excel objects
    '''        If xlRange IsNot Nothing Then ReleaseObject(xlRange)
    '''        If xlWorkBook IsNot Nothing Then xlWorkBook.Close()
    '''        If xlApp IsNot Nothing Then
    '''            xlApp.Quit()
    '''            ReleaseObject(xlApp)
    '''        End If
    '''    End Try
    '''End Sub

    '''Public Sub ExportVisibleColumnsToExcel(ByVal dataGridView As DataGridView, ByVal filePath As String)
    '''    Dim columnsToExport As New List(Of String)()

    '''    ' Get list of visible column names
    '''    For Each column As DataGridViewColumn In dataGridView.Columns
    '''        If column.Visible Then
    '''            columnsToExport.Add(column.Name)
    '''        End If
    '''    Next

    '''    ' Call ExportToExcel function with the list of visible columns
    '''    Dim xlApp As Excel.Application = Nothing
    '''    Dim xlWorkBook As Excel.Workbook = Nothing
    '''    Dim xlWorkSheet As Excel.Worksheet = Nothing
    '''    Dim xlRange As Excel.Range = Nothing

    '''    Try
    '''        xlApp = New Excel.Application()
    '''        xlWorkBook = xlApp.Workbooks.Add()
    '''        xlWorkSheet = CType(xlWorkBook.Worksheets(1), Excel.Worksheet)

    '''        ' Copy DataGridView headers to Excel
    '''        For columnIndex As Integer = 0 To columnsToExport.Count - 1
    '''            xlWorkSheet.Cells(1, columnIndex + 1) = dataGridView.Columns(columnsToExport(columnIndex)).HeaderText
    '''        Next

    '''        ' Copy specified DataGridView rows to Excel
    '''        Dim rowIndex As Integer = 1
    '''        For i As Integer = 0 To dataGridView.Rows.Count - 1
    '''            Dim isEmptyRow As Boolean = True
    '''            For Each columnName As String In columnsToExport
    '''                Dim columnIndex As Integer = dataGridView.Columns(columnName).Index
    '''                If Not String.IsNullOrEmpty(dataGridView.Rows(i).Cells(columnIndex).Value?.ToString()) Then
    '''                    isEmptyRow = False
    '''                    Exit For
    '''                End If
    '''            Next

    '''            If Not isEmptyRow Then
    '''                rowIndex += 1
    '''                For Each columnName As String In columnsToExport
    '''                    Dim columnIndex As Integer = dataGridView.Columns(columnName).Index
    '''                    xlWorkSheet.Cells(rowIndex, Array.IndexOf(columnsToExport.ToArray(), columnName) + 1) = dataGridView.Rows(i).Cells(columnIndex).Value?.ToString()
    '''                Next
    '''            End If
    '''        Next

    '''        ' Define range for the table
    '''        xlRange = xlWorkSheet.Range("A1").Resize(rowIndex, columnsToExport.Count)
    '''        ' Create table
    '''        Dim xlTable As Excel.ListObject = xlWorkSheet.ListObjects.AddEx(Excel.XlListObjectSourceType.xlSrcRange, xlRange, , Excel.XlYesNoGuess.xlYes)
    '''        xlTable.TableStyle = "TableStyleMedium9"
    '''        xlWorkSheet.Application.Selection.CurrentRegion.Select()
    '''        xlWorkSheet.Application.Selection.CurrentRegion.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
    '''        xlWorkSheet.Application.ActiveWindow.DisplayRightToLeft = True ' تعيين الصفحة لعرض من اليمين
    '''        ' Save the Excel file
    '''        xlWorkBook.SaveAs(filePath)
    '''        MessageBox.Show("تم تصدير البيانات بنجاح إلى ملف Excel")
    '''    Catch ex As Exception
    '''        MessageBox.Show("حدث خطأ أثناء تصدير البيانات إلى ملف Excel: " & ex.Message)
    '''    Finally
    '''        ' Close and release Excel objects
    '''        If xlRange IsNot Nothing Then ReleaseObject(xlRange)
    '''        If xlWorkBook IsNot Nothing Then xlWorkBook.Close()
    '''        If xlApp IsNot Nothing Then
    '''            xlApp.Quit()
    '''            ReleaseObject(xlApp)
    '''        End If
    '''    End Try
    '''End Sub

    Public Sub ExportVisibleColumnsToExcel(ByVal dataGridView As DataGridView, ByVal filePath As String)
        Dim columnsToExport As New List(Of String)()

        ' Get list of visible column names
        For Each column As DataGridViewColumn In dataGridView.Columns
            If column.Visible Then
                columnsToExport.Add(column.Name)
            End If
        Next

        ' Call ExportToExcel function with the list of visible columns
        Dim xlApp As Excel.Application = Nothing
        Dim xlWorkBook As Excel.Workbook = Nothing
        Dim xlWorkSheet As Excel.Worksheet = Nothing
        Dim xlRange As Excel.Range = Nothing

        Try
            xlApp = New Excel.Application()
            xlWorkBook = xlApp.Workbooks.Add()
            xlWorkSheet = CType(xlWorkBook.Worksheets(1), Excel.Worksheet)

            ' Copy DataGridView headers to Excel
            For columnIndex As Integer = 0 To columnsToExport.Count - 1
                xlWorkSheet.Cells(1, columnIndex + 1) = dataGridView.Columns(columnsToExport(columnIndex)).HeaderText
            Next

            ' Copy specified DataGridView rows to Excel
            Dim rowIndex As Integer = 1
            For i As Integer = 0 To dataGridView.Rows.Count - 1
                Dim isEmptyRow As Boolean = True
                For Each columnName As String In columnsToExport
                    Dim columnIndex As Integer = dataGridView.Columns(columnName).Index
                    If Not String.IsNullOrEmpty(dataGridView.Rows(i).Cells(columnIndex).Value?.ToString()) Then
                        isEmptyRow = False
                        Exit For
                    End If
                Next

                If Not isEmptyRow Then
                    rowIndex += 1
                    For Each columnName As String In columnsToExport
                        Dim columnIndex As Integer = dataGridView.Columns(columnName).Index
                        Dim cellValue As Object = dataGridView.Rows(i).Cells(columnIndex).Value
                        Dim xlCell = xlWorkSheet.Cells(rowIndex, Array.IndexOf(columnsToExport.ToArray(), columnName) + 1)

                        ' Set cell value
                        xlCell.Value = cellValue

                        ' Apply date format if the cell value is a date
                        If TypeOf cellValue Is DateTime Then
                            xlCell.NumberFormat = "yyyy-mm-dd" ' تنسيق التاريخ
                        End If
                    Next
                End If
            Next

            ' Define range for the table
            xlRange = xlWorkSheet.Range("A1").Resize(rowIndex, columnsToExport.Count)
            ' Create table
            Dim xlTable As Excel.ListObject = xlWorkSheet.ListObjects.AddEx(Excel.XlListObjectSourceType.xlSrcRange, xlRange, , Excel.XlYesNoGuess.xlYes)
            xlTable.TableStyle = "TableStyleMedium9"
            xlWorkSheet.Application.Selection.CurrentRegion.Select()
            xlWorkSheet.Application.Selection.CurrentRegion.Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            xlWorkSheet.Application.ActiveWindow.DisplayRightToLeft = True ' تعيين الصفحة لعرض من اليمين
            ' Save the Excel file
            xlWorkBook.SaveAs(filePath)
            MessageBox.Show("تم تصدير البيانات بنجاح إلى ملف Excel")
        Catch ex As Exception
            MessageBox.Show("حدث خطأ أثناء تصدير البيانات إلى ملف Excel: " & ex.Message)
        Finally
            ' Close and release Excel objects
            If xlRange IsNot Nothing Then ReleaseObject(xlRange)
            If xlWorkBook IsNot Nothing Then xlWorkBook.Close()
            If xlApp IsNot Nothing Then
                xlApp.Quit()
                ReleaseObject(xlApp)
            End If
        End Try
    End Sub

End Module
