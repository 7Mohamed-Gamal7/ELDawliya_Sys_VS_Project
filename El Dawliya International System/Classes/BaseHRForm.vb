Imports System.Data.SqlClient
Public Class BaseHRForm
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    ' هنا تقوم بإنشاء كائن من الفورم
    'Private frmAddEmployee As New Frm_Add_Employee()
    'Private NotificationsScreen As New Notifications_Screen()
    'Private FrmRebortHR As New Frm_Rebort_HR()
    'Private FrmQuiryPrint As New Frm_Quiry_Print()
    'Private FrmNoteEmployee As New Frm_Note_Employee()
    'Private FrmEmpInfo As New Frm_Emp_Info()
    'Private FrmCar As New Frm_Car()
    'Private FrmAlerts As New Frm_Alerts()
    'Private FrmAddJop As New Frm_Add_Jop()
    'Private FrmAddDepartment As New Frm_Add_Department()

    Private Sub موظفجديدToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles موظفجديدToolStripMenuItem.Click
        '' التأكد من أن الفورم غير مفتوح بالفعل
        'If frmAddEmployee.IsDisposed Then
        '    frmAddEmployee = New Frm_Add_Employee()
        'End If

        'frmAddEmployee.Show()
        'frmAddEmployee.BringToFront()
    End Sub

    Private Sub ملاحظةعنموظفToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ملاحظةعنموظفToolStripMenuItem.Click
        '' التأكد من أن الفورم غير مفتوح بالفعل
        'If FrmNoteEmployee.IsDisposed Then
        '    FrmNoteEmployee = New Frm_Note_Employee()
        'End If

        'FrmNoteEmployee.Show()
        'FrmNoteEmployee.BringToFront()
    End Sub

    Private Sub قسمجديدToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles قسمجديدToolStripMenuItem.Click
        '' التأكد من أن الفورم غير مفتوح بالفعل
        'If FrmAddDepartment.IsDisposed Then
        '    FrmAddDepartment = New Frm_Add_Department()
        'End If

        'FrmAddDepartment.Show()
        'FrmAddDepartment.BringToFront()
    End Sub

    Private Sub وظيفةجديدةToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles وظيفةجديدةToolStripMenuItem.Click
        '' التأكد من أن الفورم غير مفتوح بالفعل
        'If FrmAddJop.IsDisposed Then
        '    FrmAddJop = New Frm_Add_Jop()
        'End If

        'FrmAddJop.Show()
        'FrmAddJop.BringToFront()
    End Sub

    Private Sub سيارةجديدةToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles سيارةجديدةToolStripMenuItem.Click
        ' التأكد من أن الفورم غير مفتوح بالفعل
        'If Frm_Add_Employee.IsDisposed Then
        Frm_Add_Employee.Show()
        Frm_Add_Employee.BringToFront()
        'End If
    End Sub

    Private Sub مسمىفىالتأميناتToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles مسمىفىالتأميناتToolStripMenuItem.Click
        Frm_Add_Employee.Show()
        Frm_Add_Employee.BringToFront()
    End Sub

    Private Sub مهمةجديدةToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles مهمةجديدةToolStripMenuItem.Click

    End Sub

    Private Sub مواصلاتالموظفينToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles مواصلاتالموظفينToolStripMenuItem.Click

    End Sub

    Private Sub بياناتموظفToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles بياناتموظفToolStripMenuItem.Click

    End Sub

    Private Sub تبيهاتToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تبيهاتToolStripMenuItem.Click

    End Sub

    Private Sub btn_report_Click(sender As Object, e As EventArgs) Handles btn_report.Click

    End Sub

    Private Sub BaseHRForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'خاص بتطبيق الصلاحيات
        'ApplyPermissions(Me.Name)
    End Sub
End Class
