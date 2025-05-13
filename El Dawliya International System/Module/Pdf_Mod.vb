Imports System.Data.SqlClient
Imports System.IO
Module Pdf_Mod
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Public ID As Integer
    Public Sub cty()
        Pdf_View.dgv1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Pdf_View.dgv1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Pdf_View.dgv1.AlternatingRowsDefaultCellStyle.BackColor = Color.LightSkyBlue
        'Pdf_View.dgv1.Columns(0).Width = 60
        'Pdf_View.dgv1.Columns(1).Width = 300
        'Pdf_View.dgv1.Columns(2).Width = 100
        'Pdf_View.dgv1.Columns(3).Width = 100
    End Sub
    Public Sub pp5()
        If Con.State = 1 Then
            Con.Close()
        End If

        Try
            Con.Open()
            Dim sql As String = "SELECT ID 'رقم الملف' ,NAME 'اسم الملف',RG 'اسم الموظف',ml 'رقم الموظف ',ty'نوع الملف',PDF_PDF FROM PD_T"
            Dim cmd As SqlCommand = New SqlCommand(sql, Con)
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim dt As DataTable = New DataTable
            da.Fill(dt)
            Pdf_View.dgv1.DataSource = dt
            Pdf_View.dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            Pdf_View.dgv1.Columns.Item(0).Visible = False
            Pdf_View.dgv1.Columns.Item(4).Visible = False
            Pdf_View.dgv1.Columns.Item(5).Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()
        End Try
        con.Close()
        cty()
    End Sub
    Public Sub bn(ByVal sttt)
        Using p As New Process
            p.StartInfo = New ProcessStartInfo(sttt)
            p.Start()
            p.WaitForExit()
            Try
                File.Delete(sttt)
            Catch ex As Exception
            End Try
            con.Close()
        End Using
    End Sub
    Public Sub SEPDF()
        Try
            Dim sttt As String
            Dim sd As Byte()
            Con.Open()
            Dim sql As String = "select PDF_PDF from PD_T where ID=" & Pdf_View.dgv1.CurrentRow().Cells(0).Value
            Dim cmd As SqlCommand = New SqlCommand(sql, Con)
            sd = cmd.ExecuteScalar
            sttt = System.IO.Path.GetTempFileName()

            Dim indx3 As Integer = Pdf_View.dgv1.SelectedRows(0).Index
            If Pdf_View.dgv1(4, indx3).Value = ".pdf" Then
                File.Move(sttt, Path.ChangeExtension(sttt, ".pdf"))
                sttt = System.IO.Path.ChangeExtension(sttt, ".pdf ")
            End If
            If Pdf_View.dgv1(4, indx3).Value = ".docx" Then
                File.Move(sttt, Path.ChangeExtension(sttt, ".doc"))
                sttt = System.IO.Path.ChangeExtension(sttt, ".doc")
            End If
            If Pdf_View.dgv1(4, indx3).Value = ".xlsx" Then
                File.Move(sttt, Path.ChangeExtension(sttt, ".xlsx"))
                sttt = System.IO.Path.ChangeExtension(sttt, ".xlsx")
            End If
            If Pdf_View.dgv1(4, indx3).Value = ".png" Or Pdf_View.dgv1(4, indx3).Value = ".jpg" Or Pdf_View.dgv1(4, indx3).Value = ".gif" Or Pdf_View.dgv1(4, indx3).Value = ".bmp" Then
                File.Move(sttt, Path.ChangeExtension(sttt, ".jpg"))
                sttt = System.IO.Path.ChangeExtension(sttt, ".jpg")
            End If

            File.WriteAllBytes(sttt, sd)
            Dim act As Action(Of String) = New Action(Of String)(AddressOf bn)
            act.BeginInvoke(sttt, Nothing, Nothing)
        Catch ex As Exception
        End Try

    End Sub
    Public Sub se()
        If (Pdf_View.dgv1.SelectedRows.Count = 0) Then MessageBox.Show("يجب أختيار المعاملة المطلوبة ", "تنبية", MessageBoxButtons.OK, MessageBoxIcon.Warning) : Exit Sub
        Dim indx As Integer = Pdf_View.dgv1.SelectedRows(0).Index
        Pdf_View.t1.Text = Pdf_View.dgv1(1, indx).Value.ToString
        Pdf_View.t2.Text = Pdf_View.dgv1(2, indx).Value.ToString
        Pdf_View.t4.Text = Pdf_View.dgv1(3, indx).Value.ToString
        Pdf_View.TextBox2.Text = Pdf_View.dgv1(4, indx).Value.ToString
        Pdf_View.TextBox1.Text = Pdf_View.dgv1(5, indx).Value.ToString
        If Pdf_View.dgv1(4, indx).Value = ".png" Or Pdf_View.dgv1(4, indx).Value = ".jpg" Or Pdf_View.dgv1(4, indx).Value = ".gif" Or Pdf_View.dgv1(4, indx).Value = ".bmp" Then
            Pdf_View.Btn_Show.Text = "عرض الصورة"
            Con.Open()
            Dim reader As SqlDataReader
            Dim cmd As New SqlCommand
            cmd = New SqlCommand("SELECT * FROM PD_T WHERE ID = @id3", Con)
            cmd.Parameters.Add(New SqlParameter("@id3", Pdf_View.dgv1.CurrentRow().Cells(0).Value))
            reader = cmd.ExecuteReader()
            reader.Read()
            Dim sw() As Byte = CType(reader("PDF_PDF"), Byte())
            Dim ms As New MemoryStream(sw)
            Pdf_View.PictureBox1.Image = Image.FromStream(ms)
            reader.Close()
            Con.Close()
        ElseIf Pdf_View.dgv1(4, indx).Value = ".docx" Then
            Pdf_View.Btn_Show.Text = "عرض في الوورد"
            Pdf_View.PictureBox1.Image = Nothing
        ElseIf Pdf_View.dgv1(4, indx).Value = ".pdf" Or Pdf_View.dgv1(4, indx).Value = ".PDF" Then
            Pdf_View.Btn_Show.Text = "Show PDF"
            Pdf_View.PictureBox1.Image = Nothing
        ElseIf Pdf_View.dgv1(4, indx).Value = ".xlsx" Then
            Pdf_View.Btn_Show.Text = "عرض في الاكسيل"
            Pdf_View.PictureBox1.Image = Nothing
        Else
            Pdf_View.Btn_Show.Text = "عرض"
        End If
    End Sub
End Module
