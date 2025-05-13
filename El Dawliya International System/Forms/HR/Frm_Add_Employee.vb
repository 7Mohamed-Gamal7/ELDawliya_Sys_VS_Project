Imports System.Data.SqlClient
Imports System.IO

Public Class Frm_Add_Employee
    Private Shared _instance As PerformanceManager
    Private ReadOnly _performanceCounters As New Dictionary(Of String, Stopwatch)
    Private ReadOnly _memoryThreshold As Long = 500 * 1024 * 1024 ' 500 MB
    Private ReadOnly _logger As Logger = Logger.GetInstance() ' إضافة تهيئة للمتغير _logger
    Dim pm As PerformanceManager = PerformanceManager.GetInstance()
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)


    Public Sub ClearControls()
        Me.Emp_ID.Text = vbNullString
        Me.Emp_Full_Name.Text = vbNullString
        Me.Emp_Phone1.Text = vbNullString
        Me.Emp_Address.Text = vbNullString
        Me.Emp_Marital_Status.Text = vbNullString
        Me.Emp_Nationality.Text = vbNullString
        Me.National_ID.Text = vbNullString
        Me.Date_Birth.Value = Today
        Me.Emp_Image.Image = My.Resources.icons8_add_image_96
        Me.Dept_Code.Text = vbNullString
        Me.Jop_Code.Text = vbNullString
        Me.Emp_Date_Hiring.Value = Today
        Me.Emp_Car.Text = vbNullString
        Me.Car_Ride_Time.Value = Today
        Me.Car_Pick_Up_Point.Text = vbNullString
        Me.Place_Birth.Text = vbNullString
    End Sub

    Public Sub fillcmb_Tbl_Car(ByVal cmb As ComboBox)
        pm.StartMeasurement("fillcmb_Tbl_Car")

        Dim DT As New DataTable
        Dim DA As New SqlDataAdapter
        DT.Clear()
        DA = New SqlDataAdapter("Select * FROM Tbl_Car ", Con)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            cmb.DataSource = DT
            cmb.ValueMember = "Car_ID"
            cmb.DisplayMember = "Car_Name"
        Else
            cmb.DataSource = Nothing
        End If
        Dim elapsed = pm.StopMeasurement("fillcmb_Tbl_Car")
        _logger.LogInfo($"fillcmb_Tbl_Car filled in {elapsed.TotalMilliseconds:F2} ms")
    End Sub

    Public Sub fillcmb_Tbl_Waiting_Point(ByVal cmb As ComboBox)
        pm.StartMeasurement("Fill_Waiting_Point_ComboBox")

        Dim DT As New DataTable
        Dim DA As New SqlDataAdapter
        DT.Clear()
        DA = New SqlDataAdapter("Select * FROM Tbl_Waiting_Point ", Con)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            cmb.DataSource = DT
            cmb.ValueMember = "Waiting_Point_ID"
            cmb.DisplayMember = "Waiting_Point_Name"
        Else
            cmb.DataSource = Nothing
        End If

        Dim elapsed = pm.StopMeasurement("Fill_Waiting_Point_ComboBox")
        _logger.LogInfo($"Waiting Point ComboBox filled in {elapsed.TotalMilliseconds:F2} ms")
    End Sub

    Public Sub Insert_Tbl_Employee_Retry(BtnSave)
        ' التحقق من البيانات قبل الإدراج
        If String.IsNullOrWhiteSpace(Emp_ID.Text) Then
            MsgBox("يرجى كتابة كود الموظف أولاً.", MsgBoxStyle.Exclamation, "تنبيه")
            Return
        End If

        If String.IsNullOrWhiteSpace(Emp_Full_Name.Text) Then
            MsgBox("يرجى إدخال اسم الموظف أولاً.", MsgBoxStyle.Exclamation, "تنبيه")
            Return
        End If

        ' إذا كانت البيانات صحيحة، متابعة العملية
        pm.OptimizeOperation(Sub()
                                 Dim Working_Condition_Value As String = "سارى"
                                 Insert_Tbl_Employee(Emp_ID.Text, Emp_Full_Name.Text, Emp_Phone1.Text, Emp_Address.Text, Emp_Marital_Status.Text, Emp_Nationality.Text, National_ID.Text, Date_Birth.Value, Place_Birth.Text, Emp_Image, Int(Dept_Code.SelectedValue), Dept_Code.Text, Int(Jop_Code.SelectedValue), Jop_Code.Text, Emp_Date_Hiring.Value, Emp_Car.Text, Car_Ride_Time.Value, Car_Pick_Up_Point.Text, Working_Condition_Value)
                             End Sub)
        ClearControls()
    End Sub


    Public Sub Insert_Tbl_Employee(ByVal Emp_ID As Int32, ByVal Emp_Full_Name As String, ByVal Emp_Phone1 As String, ByVal Emp_Address As String, ByVal Emp_Marital_Status As String, ByVal Emp_Nationality As String, ByVal National_ID As String, ByVal Date_Birth As DateTime, ByVal Place_Birth As String, ByVal Emp_Image As PictureBox, ByVal Dept_Code As Int32, ByVal Dept_Name As String, ByVal Jop_Code As Int32, ByVal Jop_Name As String, ByVal Emp_Date_Hiring As DateTime, ByVal Emp_Car As String, ByVal Car_Ride_Time As DateTime, ByVal Car_Pick_Up_Point As String, ByVal Working_Condition As String)
        Try
            Dim Cmd As New SqlCommand
            With Cmd
                .Connection = Con
                .CommandType = CommandType.Text
                .CommandText = "Insert Into Tbl_Employee (Emp_ID,Emp_Full_Name,Emp_Phone1,Emp_Address,Emp_Marital_Status,Emp_Nationality,National_ID,Date_Birth,Place_Birth,Emp_Image,Dept_Code,Dept_Name,Jop_Code,Jop_Name,Emp_Date_Hiring,Emp_Car,Car_Ride_Time,Car_Pick_Up_Point,Working_Condition) values(@Emp_ID,@Emp_Full_Name,@Emp_Phone1,@Emp_Address,@Emp_Marital_Status,@Emp_Nationality,@National_ID,@Date_Birth,@Place_Birth,@Emp_Image,@Dept_Code,@Dept_Name,@Jop_Code,@Jop_Name,@Emp_Date_Hiring,@Emp_Car,@Car_Ride_Time,@Car_Pick_Up_Point,@Working_Condition)"
                .Parameters.Clear()
                .Parameters.AddWithValue("@Emp_ID", SqlDbType.Int).Value = Emp_ID
                .Parameters.AddWithValue("@Emp_Full_Name", SqlDbType.VarChar).Value = Emp_Full_Name
                .Parameters.AddWithValue("@Emp_Phone1", SqlDbType.VarChar).Value = Emp_Phone1
                .Parameters.AddWithValue("@Emp_Address", SqlDbType.VarChar).Value = Emp_Address
                .Parameters.AddWithValue("@Emp_Marital_Status", SqlDbType.VarChar).Value = Emp_Marital_Status
                .Parameters.AddWithValue("@Emp_Nationality", SqlDbType.VarChar).Value = Emp_Nationality
                .Parameters.AddWithValue("@National_ID", SqlDbType.VarChar).Value = National_ID
                .Parameters.AddWithValue("@Date_Birth", SqlDbType.Date).Value = Date_Birth
                .Parameters.AddWithValue("@Place_Birth", SqlDbType.VarChar).Value = Place_Birth

                If Emp_Image.Image IsNot Nothing AndAlso Emp_Image.Image IsNot Nothing Then
                    Dim ms As New MemoryStream()
                    Dim bmpImage As New Bitmap(Emp_Image.Image)
                    bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                    Dim data As Byte() = ms.ToArray()
                    Dim p As New SqlParameter("@Emp_Image", SqlDbType.Image)
                    p.Value = data
                    .Parameters.Add(p)
                Else
                    .Parameters.AddWithValue("@Emp_Image", DBNull.Value)
                End If

                .Parameters.AddWithValue("@Dept_Code", SqlDbType.Int).Value = Dept_Code
                .Parameters.AddWithValue("@Dept_Name", SqlDbType.VarChar).Value = Dept_Name
                .Parameters.AddWithValue("@Jop_Code", SqlDbType.Int).Value = Jop_Code
                .Parameters.AddWithValue("@Jop_Name", SqlDbType.VarChar).Value = Jop_Name
                .Parameters.AddWithValue("@Emp_Date_Hiring", SqlDbType.Date).Value = Emp_Date_Hiring
                .Parameters.AddWithValue("@Emp_Car", SqlDbType.VarChar).Value = Emp_Car
                .Parameters.AddWithValue("@Car_Ride_Time", SqlDbType.Date).Value = Car_Ride_Time
                .Parameters.AddWithValue("@Car_Pick_Up_Point", SqlDbType.VarChar).Value = Car_Pick_Up_Point
                .Parameters.AddWithValue("@Working_Condition", SqlDbType.VarChar).Value = Working_Condition
            End With

            pm.StartMeasurement("Insert_Employee")
            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If
            Cmd.ExecuteNonQuery()
            Dim elapsed = pm.StopMeasurement("Insert_Employee")
            _logger.LogInfo($"Employee insertion completed in {elapsed.TotalMilliseconds:F2} ms")
            MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
        Catch ex As Exception
            MsgBox("هذا الكود تم اضافته مسبقاً: " & ex.Message, MsgBoxStyle.Critical, "خطأ")
        Finally
            If Con.State = ConnectionState.Open Then
                Con.Close()
            End If
        End Try
    End Sub

    Private Sub Frm_Add_Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyPermissions(Me.Name)

        ClearControls()
        fillcmb_Tbl_Jop(Jop_Code)
        fillcmb_Tbl_Department(Dept_Code)
        fillcmb_Tbl_Car(Emp_Car)
        fillcmb_Tbl_Waiting_Point(Car_Pick_Up_Point)

        Dim userID As Integer = loggedInUserID ' معرف المستخدم الحالي
        Dim permissions As DataRow = PermissionHelper.GetPermissions(userID, Me.Name)

        If permissions IsNot Nothing Then
            ' تطبيق الصلاحيات
            If Not Convert.ToBoolean(permissions("CanView")) Then
                MessageBox.Show("ليس لديك صلاحية عرض هذا النموذج.")
                Me.Close()
                Return
            End If

            ' التحكم في أزرار العمليات بناءً على الصلاحيات
            BtnSave.Enabled = Convert.ToBoolean(permissions("CanAdd"))
            'btnEdit.Enabled = Convert.ToBoolean(permissions("CanEdit"))
            'btnDelete.Enabled = Convert.ToBoolean(permissions("CanDelete"))
            ' إذا كانت القراءة فقط
            If Convert.ToBoolean(permissions("CanReadOnly")) Then
                DisableAllControls() ' تعطيل جميع الحقول وجعلها قراءة فقط
            End If
        Else
            MessageBox.Show("ليس لديك أي صلاحيات لهذا النموذج.")
            Me.Close()
        End If

    End Sub

    Private Sub DisableAllControls()
        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Then
                DirectCast(control, TextBox).ReadOnly = True
            ElseIf TypeOf control Is Button Then
                DirectCast(control, Button).Enabled = False
            End If
        Next
    End Sub

    Public Sub fillcmb_Tbl_Jop(ByVal cmb As ComboBox)
        Dim DT As New DataTable
        Dim DA As New SqlDataAdapter
        DT.Clear()
        DA = New SqlDataAdapter("Select * FROM Tbl_Jop ", Con)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            cmb.DataSource = DT
            cmb.ValueMember = "Jop_Code"
            cmb.DisplayMember = "Jop_Name"
        Else
            cmb.DataSource = Nothing
        End If
    End Sub
    Public Sub fillcmb_Tbl_Department(ByVal cmb As ComboBox)
        Dim DT As New DataTable
        Dim DA As New SqlDataAdapter
        DT.Clear()
        DA = New SqlDataAdapter("Select * FROM Tbl_Department ", Con)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            cmb.DataSource = DT
            cmb.ValueMember = "Dept_Code"
            cmb.DisplayMember = "Dept_Name"
        Else
            cmb.DataSource = Nothing
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        '------------------------------------------------------------------------------------------------------
        'خاص بالصلاحيات للفورم
        If Not CanAdd Then
            MessageBox.Show("ليس لديك صلاحية الإضافة.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        '------------------------------------------------------------------------------------------------------
        Insert_Tbl_Employee_Retry(BtnSave)
    End Sub
End Class
