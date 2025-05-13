Imports System.Data.SqlClient

Public Class Frm_Add_details
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Public Sub Update_Initial_Balance(ByVal Initial_Balance As Int32, ByVal Product_IDW As String)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_Products Set Initial_Balance = @Initial_Balance Where Product_ID = @Product_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Initial_Balance", SqlDbType.Int).Value = Initial_Balance
            .Parameters.AddWithValue("@Product_ID", SqlDbType.VarChar).Value = Product_IDW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Public Sub Update_QTE_IN_STOCK(ByVal QTE_IN_STOCK As Double, ByVal Product_IDW As String)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_Products Set QTE_IN_STOCK = @QTE_IN_STOCK Where Product_ID = @Product_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@QTE_IN_STOCK", SqlDbType.Decimal).Value = QTE_IN_STOCK
            .Parameters.AddWithValue("@Product_ID", SqlDbType.VarChar).Value = Product_IDW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub
    Public Sub Update_Unit_Price(ByVal Unit_Price As Double, ByVal Product_IDW As String)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_Products Set Unit_Price = @Unit_Price Where Product_ID = @Product_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Unit_Price", SqlDbType.Decimal).Value = Unit_Price
            .Parameters.AddWithValue("@Product_ID", SqlDbType.VarChar).Value = Product_IDW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub


    Private Sub Txt_Password_KeyDown(sender As Object, e As KeyEventArgs) Handles Txt_Password.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Me.Txt_Password.Text = "7777" Then
                Me.Panel4.Visible = True
                Me.BtnSave.Visible = True
            Else
                MessageBox.Show("الرقم السرى غير صحيح", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
            End If
        End If
    End Sub

    Private Sub Frm_Add_details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Txt_Password.PasswordChar = "*"
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Try
            Dim valueToUpdate As String = Txt_Value.Text
            Dim productId As String = Product_ID.Text

            Select Case Txt_Help.Text
                Case "1"
                    Update_QTE_IN_STOCK(valueToUpdate, productId)
                Case "2"
                    Update_Initial_Balance(valueToUpdate, productId)
                Case "3"
                    Update_Unit_Price(valueToUpdate, productId)
                Case Else
                    MessageBox.Show("قيمة غير صالحة في الحقل المساعد (Txt_Help).", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select
        Catch ex As Exception
            MessageBox.Show("حدث خطأ أثناء تنفيذ العملية: " & ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Dim FrmProducts As Frm_Products = DirectCast(Application.OpenForms("Frm_Products"), Frm_Products)
        FrmProducts.SelectAll_ProductsALL(FrmProducts.dgv_Products)
        Me.Close()
    End Sub

End Class