Module SqlConect
    Public Function GetConnectionString() As String
        ' يمكنك تعيين نص الاتصال هنا أو استرجاعه من مكان آخر
        'نص الاتصال بسيرفر الدولية
        'Return "Data Source=192.168.1.10;Initial Catalog=El_Dawliya_International;User ID=admin;Password=hgslduhgfwdv"
        'نص الاتصال بجهازى
        'Return "Data Source= DESKTOP-H361157\SQLEXPRESS;Initial Catalog = El_Dawliya_International;integrated security=true"
        'Return "Data Source= DESKTOP-6D30683\SQLEXPRESS;Initial Catalog = El_Dawliya_International;integrated security=true"
        'Return "Server=" + My.Settings.server + ";Database=" + My.Settings.database + ";Integrated Security=True;"
        'Return "Server=" + My.Settings.server + ";Database=" + My.Settings.database + ";User Id=" + My.Settings.id + ";Password=" + My.Settings.Passowrd
        If My.Settings.model = "SQL" Then
            Return "Server=" + My.Settings.server + ";Database=" + My.Settings.database + ";User Id=" + My.Settings.id + ";Password=" + My.Settings.Password + ";Connect Timeout=60;"
        Else
            Return "Server=" + My.Settings.server + ";Database=" + My.Settings.database + ";Integrated Security=True;"
        End If
    End Function

End Module
