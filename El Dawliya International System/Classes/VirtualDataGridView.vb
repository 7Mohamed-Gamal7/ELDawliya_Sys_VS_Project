Imports System.Windows.Forms
Imports System.Data

Public Class VirtualDataGridView
    Private _dataGridView As DataGridView
    Private _dataTable As DataTable

    Public Sub New(dataGridView As DataGridView)
        _dataGridView = dataGridView
        InitializeGrid()
    End Sub

    Private Sub InitializeGrid()
        With _dataGridView
            .VirtualMode = True
            .AllowUserToAddRows = True
            .AllowUserToDeleteRows = True
            .RightToLeft = RightToLeft.Yes
            AddHandler .CellValueNeeded, AddressOf DataGridView_CellValueNeeded
        End With
    End Sub

    Private Sub DataGridView_CellValueNeeded(sender As Object, e As DataGridViewCellValueEventArgs)
        Try
            If _dataTable IsNot Nothing AndAlso e.RowIndex < _dataTable.Rows.Count Then
                Dim row = _dataTable.Rows(e.RowIndex)
                e.Value = row(_dataGridView.Columns(e.ColumnIndex).DataPropertyName)
            End If
        Catch ex As Exception
            MessageBox.Show("خطأ في عرض قيمة الخلية: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub SetDataSource(dataTable As DataTable)
        _dataTable = dataTable
        _dataGridView.RowCount = If(_dataTable IsNot Nothing, _dataTable.Rows.Count, 0)
    End Sub

    Public Sub RefreshData()
        If _dataGridView IsNot Nothing Then
            _dataGridView.Invalidate()
        End If
    End Sub

    Public Sub ClearData()
        _dataTable = Nothing
        _dataGridView.RowCount = 0
    End Sub
End Class
