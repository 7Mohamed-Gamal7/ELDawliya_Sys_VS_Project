Imports System.Reflection
Module Get_All_Forms_Names
    Public Sub Main2()
        ' الحصول على جميع الأنواع في التجميع الحالي (المشروع الحالي)
        Dim currentAssembly As Assembly = Assembly.GetExecutingAssembly()
        Dim types As Type() = currentAssembly.GetTypes()

        ' عرض أسماء النماذج في نافذة الـ Console
        Console.WriteLine("أسماء النماذج في المشروع:")
        For Each t As Type In types
            ' التحقق من أن النوع يرث من System.Windows.Forms.Form
            If t.IsSubclassOf(GetType(System.Windows.Forms.Form)) Then
                Console.WriteLine(t.Name)
            End If
        Next

        ' بعد عرض الأسماء، يتم تشغيل الفورم الرئيسي
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New Frm_Login()) ' استبدل LoginForm بالفورم الذي تريد تحميله أولاً
    End Sub
End Module
