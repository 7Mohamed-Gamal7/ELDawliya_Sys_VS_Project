Imports System.Data.SqlClient
Public Class BaseForm
    Inherits Form

    ' تعريف متغيرات الصلاحيات
    Protected CanView As Boolean = False
    Protected CanAdd As Boolean = False
    Protected CanEdit As Boolean = False
    Protected CanDelete As Boolean = False
    Protected CanReadOnly As Boolean = False
    Protected CanPrint As Boolean = False

    ' استدعاء الصلاحيات
    Protected Sub ApplyPermissions(formName As String)
            Try
                ' جلب معرف المستخدم الحالي (يمكنك تعديل الطريقة حسب مشروعك)
                Dim userID As Integer = loggedInUserID
                Dim permissions As DataRow = PermissionHelper.GetPermissions(userID, formName)

                If permissions IsNot Nothing Then
                    ' تعيين الصلاحيات بناءً على البيانات المسترجعة
                    CanView = Convert.ToBoolean(permissions("CanView"))
                    CanAdd = Convert.ToBoolean(permissions("CanAdd"))
                    CanEdit = Convert.ToBoolean(permissions("CanEdit"))
                    CanDelete = Convert.ToBoolean(permissions("CanDelete"))
                CanReadOnly = Convert.ToBoolean(permissions("CanReadOnly"))
                CanPrint = Convert.ToBoolean(permissions("CanPrint"))
            Else
                    Throw New Exception("لا توجد صلاحيات مخصصة لهذا النموذج.")
                End If

                ' تطبيق الصلاحيات
                If Not CanView Then
                    MessageBox.Show("ليس لديك صلاحية عرض هذا النموذج.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Me.Close()
                    Return
                End If

                If CanReadOnly Then
                    DisableAllControls()
                End If
            Catch ex As Exception
                MessageBox.Show("خطأ في تطبيق الصلاحيات: " & ex.Message)
                Me.Close()
            End Try
        End Sub

        ' تعطيل جميع الحقول للتحويل إلى وضع القراءة فقط
        Protected Sub DisableAllControls()
            For Each control As Control In Me.Controls
                If TypeOf control Is TextBox Then
                    DirectCast(control, TextBox).ReadOnly = True
                ElseIf TypeOf control Is Button Then
                    DirectCast(control, Button).Enabled = False
                End If
            Next
        End Sub

    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'BaseForm
        '
        Me.ClientSize = New System.Drawing.Size(1469, 709)
        Me.Name = "BaseForm"
        Me.ResumeLayout(False)

    End Sub

    Private Sub BaseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
