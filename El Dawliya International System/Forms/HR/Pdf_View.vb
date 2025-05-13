Imports System.Data.SqlClient
Imports System.IO
Public Class Pdf_View
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Dim op As New OpenFileDialog
    Dim Fol As String = Application.StartupPath & "\Folder pdf\"

    Private Sub INS_PDF()
        Try
            Con.Open()
            If t1.Text = "" Then MessageBox.Show("يجب تعبئة كافة الحقول قبل الحفظ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning) : Exit Sub
            If t2.Text = "" Then MessageBox.Show("يجب تعبئة كافة الحقول قبل الحفظ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning) : Exit Sub
            If t3.Text = "" Then MessageBox.Show("يجب تعبئة كافة الحقول قبل الحفظ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning) : Exit Sub
            Dim sql As String = "insert into PD_T (NAME,RG,ml,ty,PDF_PDF) values (@NAME,@RG,@ml,@ty,@PDF_PDF) "
            Dim cmd As SqlCommand = New SqlCommand(sql, Con)
            cmd.Parameters.Add(New SqlParameter("@NAME", t1.Text))
            cmd.Parameters.Add(New SqlParameter("@RG", t2.Text))
            cmd.Parameters.Add(New SqlParameter("@ml", t4.Text))
            'cmd.Parameters.Add(New SqlParameter("@ty", TextBox2.Text))
            cmd.Parameters.Add(New SqlParameter("@ty", TextBox2.Text.ToLower()))
            cmd.Parameters.Add(New SqlParameter("@PDF_PDF", File.ReadAllBytes(t3.Text)))
            cmd.ExecuteNonQuery()
            Dim FilePath As String = t3.Text
            File.Copy(FilePath, Fol & TextBox1.Text, True)
            MessageBox.Show("تم حفظ الملف بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information)
            t1.Text = ""
            t2.Text = ""
            t3.Text = ""
            t4.Text = ""
            PictureBox1.Image = Nothing
            pp5()
        Catch ex As Exception
        Finally
            Con.Close()
        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Directory.Exists(Fol) Then
            Directory.CreateDirectory(Fol)
        End If
        pp5()
    End Sub

    Private Sub bn_Click(sender As Object, e As EventArgs) Handles bn.Click
        bs.Enabled = True
        Btn_Edit.Enabled = False
        Btn_Delete.Enabled = False
        t1.Text = ""
        t2.Text = ""
        t3.Text = ""
        t4.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        t1.Enabled = True
        t2.Enabled = True
        t3.Enabled = True
        t4.Enabled = True
    End Sub

    Private Sub Btn_Delete_Click(sender As Object, e As EventArgs) Handles Btn_Delete.Click
        Dim MovementDescription As String = " تم حذف ملف " + t2.Text + " " + " الملف " + t1.Text
        Dim DeviceName As String = Environ$("computername")
        If (dgv1.SelectedRows.Count = 0) Then MessageBox.Show("يجب أختيار أسم الملف أولاً ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning) : Exit Sub
        Dim msg As String = String.Format("{1}{0} هل أنت متأكد من حذف الملف بشكل نهائي ", Environment.NewLine, dgv1(1, dgv1.SelectedRows(0).Index).Value.ToString())
        If (MessageBox.Show(msg, "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RightAlign) <> DialogResult.Yes) Then Return
        Dim str As String = String.Format("Delete from [PD_T] where ID = {0}", dgv1(0, dgv1.SelectedRows(0).Index).Value.ToString())
        Dim cmd As New SqlCommand(str, Con)
        If Con.State = ConnectionState.Closed Then
            Con.Open()
        End If
        cmd.ExecuteNonQuery()
        MessageBox.Show("تم حذف الملف بنجاح ", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Con.Close()
        pp5()
        Insert_MovementHistory(MovementDescription, DateTime.Now, loggedInUserName, DeviceName, Me.Name, "BtnDelete")
        t1.Text = ""
        t2.Text = ""
        t3.Text = ""
        t4.Text = ""
        PictureBox1.Image = Nothing
    End Sub

    Private Sub dgv1_Click(sender As Object, e As EventArgs) Handles dgv1.Click
        se()
        bs.Enabled = False
        Btn_Edit.Enabled = True
        Btn_Delete.Enabled = True
    End Sub

    Private Sub dgv1_KeyDown(sender As Object, e As KeyEventArgs) Handles dgv1.KeyDown
        se()
    End Sub

    Private Sub dgv1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dgv1.KeyPress
        se()
    End Sub

    Private Sub dgv1_KeyUp(sender As Object, e As KeyEventArgs) Handles dgv1.KeyUp
        se()
    End Sub

    Private Sub Btn_Edit_Click(sender As Object, e As EventArgs) Handles Btn_Edit.Click
        Dim MovementDescription As String = " تم تعديل ملف " + t2.Text + " " + " الملف " + t1.Text
        Dim DeviceName As String = Environ$("computername")
        If Con.State = 1 Then
            Con.Close()
        End If
        Con.Open()
        If t1.Enabled = False Then
            t1.Enabled = True
            t2.Enabled = True
            t3.Enabled = True
            t4.Enabled = True
            Return
        End If
        If t1.Text = "" Or t2.Text = "" Or t4.Text = "" Or t3.Text = "" Then MessageBox.Show("جميع الحقول مطلوبة ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning) : Exit Sub
        ID = (dgv1(0, dgv1.SelectedRows(0).Index).Value.ToString())
        Dim str As String = ("Update [PD_T] set [NAME]=@NAME,[RG]=@RG,[ty]=@ty,[PDF_PDF]=@PDF_PDF,[ml]=@ml where [ID] =" & Val(ID))
        Dim cmd As New SqlCommand(str, Con)
        cmd.Parameters.AddWithValue("@NAME", t1.Text)
        cmd.Parameters.AddWithValue("@ml", t4.Text)
        cmd.Parameters.AddWithValue("@PDF_PDF", File.ReadAllBytes(t3.Text))
        cmd.Parameters.AddWithValue("@RG", t2.Text)
        cmd.Parameters.AddWithValue("@ty", TextBox2.Text.ToLower())
        cmd.ExecuteNonQuery()
        Dim FilePath As String = t3.Text
        File.Copy(FilePath, Fol & TextBox1.Text, True)
        MessageBox.Show("تم تعديل الملف بنجاح ", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Con.Close()
        pp5()
        Insert_MovementHistory(MovementDescription, DateTime.Now, loggedInUserName, DeviceName, Me.Name, "BtnEdit")
        t1.Text = ""
        t2.Text = ""
        t3.Text = ""
        t4.Text = ""
        PictureBox1.Image = Nothing
    End Sub

    Private Sub ts_Click(sender As Object, e As EventArgs) Handles ts.Click
        PictureBox2.Visible = False
    End Sub

    Private Sub ts_Validated(sender As Object, e As EventArgs) Handles ts.Validated
        PictureBox2.Visible = True
    End Sub

    Private Sub ts_TextChanged(sender As Object, e As EventArgs) Handles ts.TextChanged
        Try
            Dim DA As New SqlDataAdapter
            Dim DT As New DataTable
            DT.Clear()
            DA = New SqlDataAdapter("select * from PD_T where NAME+ml+RG  like '%" + ts.Text + "%'", Con)
            DA.Fill(DT)
            dgv1.DataSource = DT
            dgv1.Columns.Item(4).Visible = False
            dgv1.Columns.Item(5).Visible = False
            dgv1.Columns(0).HeaderText = "رقم الملف"
            dgv1.Columns(1).HeaderText = "اسم الملف"
            dgv1.Columns(3).HeaderText = "رقم الموظف"
            dgv1.Columns(2).HeaderText = "اسم الموظف"
            cty()
            Con.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        op.Title = "اضافة الملفات"
        op.Filter = "All Files|*.*"
        If op.ShowDialog() = DialogResult.OK Then
            t3.Text = op.FileName
            TextBox1.Text = Path.GetFileName(op.FileName)
            TextBox2.Text = Path.GetExtension(op.FileName)
        End If
        Try
            t3.Text = op.FileName
            If t3.Text = Nothing Then
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Show.Click
        SEPDF()
    End Sub

    Private Sub bs_Click(sender As Object, e As EventArgs) Handles bs.Click
        Dim MovementDescription As String = " تم حفظ بيانات " + t2.Text + " " + t1.Text
        Dim DeviceName As String = Environ$("computername")
        Me.Cursor = Cursors.WaitCursor
        Insert_MovementHistory(MovementDescription, DateTime.Now, loggedInUserName, DeviceName, Me.Name, "BtnSave")

        INS_PDF()
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub t1_TextChanged(sender As Object, e As EventArgs) Handles t1.TextChanged
        If String.IsNullOrEmpty(Me.t1.Text) Then
            Label6.ForeColor = System.Drawing.Color.Red
        Else
            Label6.ForeColor = System.Drawing.Color.Black
        End If
    End Sub
    Private Sub t2_TextChanged(sender As Object, e As EventArgs) Handles t2.TextChanged
        If String.IsNullOrEmpty(Me.t2.Text) Then
            Label7.ForeColor = System.Drawing.Color.Red
        Else
            Label7.ForeColor = System.Drawing.Color.Black
        End If
    End Sub

    Private Sub t3_TextChanged(sender As Object, e As EventArgs) Handles t3.TextChanged
        If String.IsNullOrEmpty(Me.t3.Text) Then
            Label9.ForeColor = System.Drawing.Color.Red
        Else
            Label9.ForeColor = System.Drawing.Color.Black
        End If
    End Sub
    Private Sub t4_TextChanged(sender As Object, e As EventArgs) Handles t4.TextChanged
        If String.IsNullOrEmpty(Me.t4.Text) Then
            Label8.ForeColor = System.Drawing.Color.Red
        Else
            Label8.ForeColor = System.Drawing.Color.Black
        End If
    End Sub

    Private Sub Pdf_View_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.S
                If e.Control Then
                    bs_Click(sender, New EventArgs())
                End If
            Case Keys.N
                If e.Control Then
                    bn_Click(sender, New EventArgs())
                End If
            Case Keys.F
                If e.Control Then
                    ts.Focus()
                End If
            Case Keys.Delete
                If e.Control Then
                    Btn_Delete_Click(sender, New EventArgs())
                End If
        End Select
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If Me.CheckBox1.Checked = True Then
            Me.t1.Text = "بيانات ملف عمل"
        Else
            Me.t1.Text = vbNullString
        End If
    End Sub

End Class