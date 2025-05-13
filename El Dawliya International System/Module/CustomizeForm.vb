Module CustomizeForml
    'Public Sub CustomizeForm(ByRef frm As Form)
    '    ' ضبط الحجم والتكيف
    '    frm.AutoScaleMode = AutoScaleMode.Dpi
    '    frm.WindowState = FormWindowState.Maximized
    '    frm.MinimumSize = New Size(800, 600)
    '    frm.MaximumSize = New Size(1920, 1080)

    '    ' تحسين الألوان
    '    'frm.BackColor = Color.LightSteelBlue
    '    frm.BackColor = Color.FloralWhite
    '    frm.ForeColor = Color.Black

    '    ' تحسين الشكل
    '    frm.FormBorderStyle = FormBorderStyle.FixedSingle
    '    frm.Font = New Font("Segoe UI", 10, FontStyle.Regular)
    'End Sub

    Public Sub CustomizeForm(ByRef frm As Form)
        ' ضبط الحجم والتكيف
        Dim Fonttext As String = "Cairo"
        frm.AutoScaleMode = AutoScaleMode.Dpi
        frm.WindowState = FormWindowState.Maximized
        frm.MinimumSize = New Size(800, 600)
        frm.MaximumSize = New Size(1920, 1080)

        ' تحسين الألوان
        frm.BackColor = Color.Bisque ' اللون الأساسي للفورم
        'frm.BackColor = Color.FromArgb(48, 77, 48)
        frm.ForeColor = Color.Black

        ' تحسين الشكل
        frm.FormBorderStyle = FormBorderStyle.FixedSingle
        frm.Font = New Font(Fonttext, 10, FontStyle.Regular)

        ' تنسيق جميع التكست بوكس
        For Each ctrl As Control In frm.Controls
            If TypeOf ctrl Is TextBox Then
                Dim txtBox As TextBox = CType(ctrl, TextBox)
                txtBox.BackColor = Color.White ' اللون الأبيض للتكست بوكس
                txtBox.ForeColor = Color.Black ' الكتابة باللون الأسود
                txtBox.Font = New Font(Fonttext, 10, FontStyle.Regular) ' الخط الموحد
            End If
        Next

        ' تنسيق جميع الليبل
        For Each ctrl As Control In frm.Controls
            If TypeOf ctrl Is Label Then
                Dim lbl As Label = CType(ctrl, Label)
                lbl.ForeColor = Color.LightGray ' اللون الأساسي لليبل
                lbl.Font = New Font(Fonttext, 10, FontStyle.Regular) ' الخط الموحد
            End If
        Next

        ' تنسيق جميع الداتا جريد فيو
        For Each ctrl As Control In frm.Controls
            If TypeOf ctrl Is DataGridView Then
                Dim dgv As DataGridView = CType(ctrl, DataGridView)

                ' تنسيق الخطوط
                dgv.Font = New Font(Fonttext, 10, FontStyle.Bold)

                ' تنسيق الصفوف
                dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray ' الصف البديل
                dgv.DefaultCellStyle.BackColor = Color.White ' الصف الأساسي
                dgv.DefaultCellStyle.ForeColor = Color.Black ' الكتابة

                ' تنسيق الصف المحدد
                dgv.DefaultCellStyle.SelectionBackColor = Color.Blue ' اللون الأزرق للصف المحدد
                dgv.DefaultCellStyle.SelectionForeColor = Color.White ' الكتابة باللون الأبيض

                ' عرض حدود الخطوط
                dgv.GridColor = Color.Black
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                dgv.RowHeadersVisible = False
            End If
        Next
    End Sub


End Module
