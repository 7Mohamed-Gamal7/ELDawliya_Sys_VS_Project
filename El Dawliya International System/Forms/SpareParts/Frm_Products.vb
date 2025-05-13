Imports System.Data.SqlClient
Imports System.IO
Public Class Frm_Products
    Public ConStr As String = GetConnectionString()
    Public Con As New SqlConnection(ConStr)
    Public dt_Products As New DataTable

    Private Sub PopulateComboBoxSelectValue(ComboBox As ComboBox, columnName As String)
        Dim cellValue = dgv_Products.CurrentRow.Cells(columnName).Value
        If Not IsDBNull(cellValue) Then
            ComboBox.SelectedValue = cellValue.ToString()
        Else
            ComboBox.SelectedValue = -1
        End If
    End Sub

    Private Sub PopulateComboBox(ComboBox As ComboBox, columnName As String)
        Dim value = dgv_Products.CurrentRow.Cells(columnName).Value
        ComboBox.Text = If(Not IsDBNull(value), value.ToString(), "")
    End Sub

    Private Sub PopulateDateTimePicker(DateTimePicker As DateTimePicker, columnName As String)
        Dim value = dgv_Products.CurrentRow.Cells(columnName).Value
        DateTimePicker.Value = If(Not IsDBNull(value), value.ToString(), "")
    End Sub

    Public Sub fillcmb_Tbl_Categories(ByVal cmb As ComboBox)
        'صح
        Dim DT As New DataTable
        Dim DA As New SqlDataAdapter
        DT.Clear()
        DA = New SqlDataAdapter("Select * FROM Tbl_Categories ", Con)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            cmb.DataSource = DT
            cmb.ValueMember = "CAT_ID"
            cmb.DisplayMember = "CAT_Name"
            cmb.SelectedIndex = 0
        Else
            cmb.DataSource = Nothing
        End If
    End Sub

    Public Sub fillcmb_Tbl_Units_SpareParts(ByVal cmb As ComboBox)
        Dim DT As New DataTable
        Dim DA As New SqlDataAdapter
        DT.Clear()
        DA = New SqlDataAdapter("Select * FROM Tbl_Units_SpareParts ", Con)
        DA.Fill(DT)
        If DT.Rows.Count > 0 Then
            cmb.DataSource = DT
            cmb.DisplayMember = "Unit_Name"
            cmb.ValueMember = "Unit_ID"
            cmb.SelectedIndex = 0
        Else
            cmb.DataSource = Nothing
        End If
    End Sub

    Public Sub ClearControls()
        Me.Product_ID.Text = vbNullString
        Me.Product_Name.Text = vbNullString
        Me.QTE_IN_STOCK.Text = 0.00
        Me.IMAGE_PRODUCT.Image = My.Resources.icons8_add_image_96
        Me.CAT_ID.SelectedValue = 0
        Me.Unit_ID.SelectedValue = 0
        Me.Initial_Balance.Text = 0.00
        Me.Minimum_Threshold.Text = 0.00
        Me.Maximum_Threshold.Text = 0.00
        Location.Text = vbNullString
        Expiry_Warning.Text = "نعم"
    End Sub

    '''Public Sub SelectAll_Products(dgv As DataGridView)
    '''    Dim da As New SqlDataAdapter
    '''    dt_Products.Clear()
    '''    'da = New SqlDataAdapter("SELECT dbo.Tbl_Products.*, dbo.Tbl_Units_SpareParts.Unit_Name, dbo.Tbl_Categories.CAT_Name
    '''    '                FROM dbo.Tbl_Products
    '''    '                INNER JOIN dbo.Tbl_Units_SpareParts ON dbo.Tbl_Products.Unit_ID = dbo.Tbl_Units_SpareParts.Unit_ID
    '''    '                INNER JOIN dbo.Tbl_Categories ON dbo.Tbl_Products.CAT_ID = dbo.Tbl_Categories.CAT_ID", Con)
    '''    da = New SqlDataAdapter("SELECT *
    '''                FROM Tbl_Products
    '''                ORDER BY Product_ID
    '''                OFFSET 100 * (1 - 1) ROWS
    '''                FETCH NEXT 100 ROWS ONLY;", Con)
    '''    da.Fill(dt_Products)
    '''    dt_Products.Columns("Product_ID").SetOrdinal(0)
    '''    dt_Products.Columns("Product_Name").SetOrdinal(1)
    '''    dt_Products.Columns("Initial_Balance").SetOrdinal(2)
    '''    dt_Products.Columns("ElWarad").SetOrdinal(3)
    '''    dt_Products.Columns("MortagaaOmalaa").SetOrdinal(4)
    '''    dt_Products.Columns("ElMonsarf").SetOrdinal(5)
    '''    dt_Products.Columns("MortagaaElMawarden").SetOrdinal(6)
    '''    dt_Products.Columns("QTE_IN_STOCK").SetOrdinal(7)
    '''    dt_Products.Columns("IMAGE_PRODUCT").SetOrdinal(8)
    '''    dt_Products.Columns("Unit_Price").SetOrdinal(9)
    '''    dt_Products.Columns("CAT_ID").SetOrdinal(10)
    '''    dt_Products.Columns("CAT_Name").SetOrdinal(11)
    '''    dt_Products.Columns("Unit_ID").SetOrdinal(12)
    '''    dt_Products.Columns("Unit_Name").SetOrdinal(13)
    '''    dt_Products.Columns("Minimum_Threshold").SetOrdinal(14)
    '''    dt_Products.Columns("Maximum_Threshold").SetOrdinal(15)
    '''    dt_Products.Columns("Location").SetOrdinal(16)
    '''    dgv.DataSource = dt_Products
    '''    With dgv
    '''        '.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    '''        '.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
    '''        .Columns("Product_ID").HeaderText = "كود الصنف"
    '''        '.Columns("Product_ID").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    '''        .Columns("Product_Name").HeaderText = "اسم الصنف"
    '''        .Columns("Product_Name").Width = 250
    '''        '.Columns("Product_Name").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    '''        .Columns("Initial_Balance").HeaderText = "رصيد بداية المدة"
    '''        '.Columns("Initial_Balance").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    '''        .Columns("ElWarad").HeaderText = "الوراد"
    '''        '.Columns("ElWarad").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    '''        .Columns("MortagaaOmalaa").HeaderText = "مرتجع العملاء"
    '''        '.Columns("MortagaaOmalaa").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    '''        .Columns("ElMonsarf").HeaderText = "المنصرف"
    '''        '.Columns("ElMonsarf").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    '''        .Columns("MortagaaElMawarden").HeaderText = "مرتجع الموردين"
    '''        '.Columns("MortagaaElMawarden").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    '''        .Columns("QTE_IN_STOCK").HeaderText = "الرصيد الحالى"
    '''        '.Columns("QTE_IN_STOCK").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    '''        .Columns("IMAGE_PRODUCT").HeaderText = "IMAGE_PRODUCT"
    '''        .Columns("IMAGE_PRODUCT").Visible = False
    '''        .Columns("Unit_Price").HeaderText = "Unit_Price"
    '''        .Columns("Unit_Price").Visible = False
    '''        .Columns("CAT_ID").HeaderText = "كود التصنيف"
    '''        .Columns("CAT_ID").Visible = False
    '''        .Columns("CAT_Name").HeaderText = "اسم التصنيف"
    '''        '.Columns("CAT_Name").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    '''        .Columns("Unit_ID").HeaderText = "كود الوحدة"
    '''        .Columns("Unit_ID").Visible = False
    '''        .Columns("Unit_Name").HeaderText = "الوحدة"
    '''        '.Columns("Unit_Name").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    '''        .Columns("Minimum_Threshold").HeaderText = "اقل رصيد"
    '''        '.Columns("Minimum_Threshold").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    '''        .Columns("Maximum_Threshold").HeaderText = "اكبر رصيد"
    '''        '.Columns("Maximum_Threshold").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    '''        .Columns("Location").HeaderText = "التواجد"
    '''        '.Columns("Location").AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
    '''    End With
    '''End Sub

    Public Sub Insert_Products(ByVal Product_ID As String, ByVal Product_Name As String, ByVal Initial_Balance As Double, ByVal ElWarad As Double, ByVal MortagaaOmalaa As Double, ByVal ElMonsarf As Double, ByVal MortagaaElMawarden As Double, ByVal QTE_IN_STOCK As Double, ByVal CAT_ID As Int32, ByVal CAT_Name As String, ByVal Unit_ID As Int32, ByVal Unit_Name As String, ByVal Minimum_Threshold As Double, ByVal Maximum_Threshold As Double, ByVal Location As String, ByVal Expiry_Warning As String, ByVal Unit_Price As Double)
        Try
            Dim Cmd As New SqlCommand
            With Cmd
                .Connection = Con
                .CommandType = CommandType.Text
                '.CommandText = "Insert Into Tbl_Products ( Product_ID,Product_Name,ElWarad,MortagaaOmalaa,ElMonsarf,MortagaaElMawarden,CAT_ID,Unit_ID,Minimum_Threshold,Maximum_Threshold,Location)values(@Product_ID,@Product_Name,@CAT_ID,@Unit_ID,@Minimum_Threshold,@Maximum_Threshold,@Location)"
                .CommandText = "INSERT INTO Tbl_Products (Product_ID, Product_Name,Initial_Balance, ElWarad, MortagaaOmalaa, ElMonsarf, MortagaaElMawarden,QTE_IN_STOCK, CAT_ID,CAT_Name, Unit_ID,Unit_Name, Minimum_Threshold, Maximum_Threshold, Location,Expiry_Warning,Unit_Price) VALUES (@Product_ID, @Product_Name,@Initial_Balance, @ElWarad, @MortagaaOmalaa, @ElMonsarf, @MortagaaElMawarden,@QTE_IN_STOCK, @CAT_ID,@CAT_Name, @Unit_ID,@Unit_Name, @Minimum_Threshold, @Maximum_Threshold, @Location,@Expiry_Warning,@Unit_Price)"
                .Parameters.Clear()
                .Parameters.AddWithValue("@Product_ID", SqlDbType.VarChar).Value = Product_ID
                .Parameters.AddWithValue("@Product_Name", SqlDbType.VarChar).Value = Product_Name
                .Parameters.AddWithValue("@Initial_Balance", SqlDbType.Decimal).Value = Initial_Balance
                .Parameters.AddWithValue("@ElWarad", SqlDbType.Decimal).Value = ElWarad
                .Parameters.AddWithValue("@MortagaaOmalaa", SqlDbType.Decimal).Value = MortagaaOmalaa
                .Parameters.AddWithValue("@ElMonsarf", SqlDbType.Decimal).Value = ElMonsarf
                .Parameters.AddWithValue("@MortagaaElMawarden", SqlDbType.Decimal).Value = MortagaaElMawarden
                .Parameters.AddWithValue("@QTE_IN_STOCK", SqlDbType.Decimal).Value = QTE_IN_STOCK
                .Parameters.AddWithValue("@CAT_ID", SqlDbType.Int).Value = CAT_ID
                .Parameters.AddWithValue("@CAT_Name", SqlDbType.VarChar).Value = CAT_Name
                .Parameters.AddWithValue("@Unit_ID", SqlDbType.Int).Value = Unit_ID
                .Parameters.AddWithValue("@Unit_Name", SqlDbType.VarChar).Value = Unit_Name
                .Parameters.AddWithValue("@Minimum_Threshold", SqlDbType.Decimal).Value = Minimum_Threshold
                .Parameters.AddWithValue("@Maximum_Threshold", SqlDbType.Decimal).Value = Maximum_Threshold
                .Parameters.AddWithValue("@Location", SqlDbType.VarChar).Value = Location
                .Parameters.AddWithValue("@Expiry_Warning", SqlDbType.VarChar).Value = Expiry_Warning
                .Parameters.AddWithValue("@Unit_Price", SqlDbType.Decimal).Value = Unit_Price
            End With
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Cmd.ExecuteNonQuery()
            Con.Close()
            MsgBox("تم إضافة السجل بنجاح", MsgBoxStyle.Information, "حفظ")
            Cmd = Nothing
        Catch ex As Exception
            MsgBox("هذا الكود تم اضافتة مسبقاً: " & ex.Message, MsgBoxStyle.Critical, "خطأ")
        End Try
    End Sub

    Public Sub Update_Products(ByVal Product_Name As String, ByVal CAT_ID As Int32, ByVal CAT_Name As String, ByVal Unit_ID As Int32, ByVal Unit_Name As String, ByVal Minimum_Threshold As Double, ByVal Maximum_Threshold As Double, ByVal Location As String, ByVal Product_IDW As String)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_Products Set Product_Name = @Product_Name,CAT_ID = @CAT_ID,CAT_Name = @CAT_Name,Unit_ID = @Unit_ID,Unit_Name = @Unit_Name,Minimum_Threshold = @Minimum_Threshold,Maximum_Threshold = @Maximum_Threshold,Location = @Location Where Product_ID = @Product_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Product_Name", SqlDbType.VarChar).Value = Product_Name
            .Parameters.AddWithValue("@CAT_ID", SqlDbType.Int).Value = CAT_ID
            .Parameters.AddWithValue("@CAT_Name", SqlDbType.VarChar).Value = CAT_Name
            .Parameters.AddWithValue("@Unit_ID", SqlDbType.Int).Value = Unit_ID
            .Parameters.AddWithValue("@Unit_Name", SqlDbType.VarChar).Value = Unit_Name
            .Parameters.AddWithValue("@Minimum_Threshold", SqlDbType.Decimal).Value = Minimum_Threshold
            .Parameters.AddWithValue("@Maximum_Threshold", SqlDbType.Decimal).Value = Maximum_Threshold
            .Parameters.AddWithValue("@Location", SqlDbType.VarChar).Value = Location
            .Parameters.AddWithValue("@Product_ID", SqlDbType.VarChar).Value = Product_IDW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub

    Public Sub Update_Image(ByVal Image_Product As PictureBox, ByVal Product_IDW As String)
        If Image_Product.Image Is Nothing Then
            MsgBox("يرجى اختيار صورة قبل الحفظ", MsgBoxStyle.Information, "تنبيه")
            Return
        End If

        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_Products Set Image_Product = @Image_Product Where Product_ID = @Product_ID"
            .Parameters.Clear()
            Dim ms As New MemoryStream()
            Dim bmpImage As New Bitmap(Image_Product.Image)
            bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim data As Byte() = ms.GetBuffer()
            Dim p As New SqlParameter("@Image_Product", SqlDbType.Image)
            p.Value = data
            .Parameters.Add(p)
            .Parameters.AddWithValue("@Product_ID", SqlDbType.VarChar).Value = Product_IDW
        End With
        Try
            If Con.State = ConnectionState.Closed Then
                Con.Open()
            End If
            Cmd.ExecuteNonQuery()
            MsgBox("تم تعديل الصورة بنجاح", MsgBoxStyle.Information, "تعديل")
        Catch ex As Exception
            MsgBox("حدث خطأ أثناء تحديث الصورة: " & ex.Message, MsgBoxStyle.Critical, "خطأ")
        Finally
            Con.Close()
            Cmd = Nothing
        End Try
    End Sub

    Public Sub Update_Tbl_Products(ByVal Product_Name As String, ByVal Initial_Balance As Double, ByVal QTE_IN_STOCK As Double, ByVal CAT_ID As Int32, ByVal CAT_Name As String, ByVal Unit_ID As Int32, ByVal Unit_Name As String, ByVal Minimum_Threshold As Double, ByVal Maximum_Threshold As Double, ByVal Unit_Price As Double, ByVal Location As String, ByVal Expiry_Warning As String, ByVal Product_IDW As String)
        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Update Tbl_Products Set Product_Name = @Product_Name,Initial_Balance = @Initial_Balance,QTE_IN_STOCK = @QTE_IN_STOCK,CAT_ID = @CAT_ID,CAT_Name = @CAT_Name,Unit_ID = @Unit_ID,Unit_Name = @Unit_Name,Minimum_Threshold = @Minimum_Threshold,Maximum_Threshold = @Maximum_Threshold,Unit_Price = @Unit_Price,Location = @Location,Expiry_Warning = @Expiry_Warning Where Product_ID = @Product_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Product_Name", SqlDbType.VarChar).Value = Product_Name
            .Parameters.AddWithValue("@Initial_Balance", SqlDbType.Decimal).Value = Initial_Balance
            .Parameters.AddWithValue("@QTE_IN_STOCK", SqlDbType.Int).Value = QTE_IN_STOCK
            .Parameters.AddWithValue("@CAT_ID", SqlDbType.Int).Value = CAT_ID
            .Parameters.AddWithValue("@CAT_Name", SqlDbType.VarChar).Value = CAT_Name
            .Parameters.AddWithValue("@Unit_ID", SqlDbType.Int).Value = Unit_ID
            .Parameters.AddWithValue("@Unit_Name", SqlDbType.VarChar).Value = Unit_Name
            .Parameters.AddWithValue("@Minimum_Threshold", SqlDbType.Decimal).Value = Minimum_Threshold
            .Parameters.AddWithValue("@Maximum_Threshold", SqlDbType.Decimal).Value = Maximum_Threshold
            .Parameters.AddWithValue("@Unit_Price", SqlDbType.Decimal).Value = Unit_Price
            .Parameters.AddWithValue("@Location", SqlDbType.VarChar).Value = Location
            .Parameters.AddWithValue("@Expiry_Warning", SqlDbType.VarChar).Value = Expiry_Warning
            .Parameters.AddWithValue("@Product_ID", SqlDbType.VarChar).Value = Product_IDW
        End With
        If Con.State = 1 Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم تعديل السجل بنجاح", MsgBoxStyle.Information, "تعديل")
        Cmd = Nothing
    End Sub



    Public Sub Delete_Products(ByVal dgv_Products As DataGridView)
        Dim Position As Integer = dgv_Products.CurrentRow.Index
        Dim ID_Position As String = dgv_Products.Rows(Position).Cells("Product_ID").Value.ToString() ' تأكد من استخدام ToString() لتحويل القيمة إلى نص

        Dim Cmd As New SqlCommand
        With Cmd
            .Connection = Con
            .CommandType = CommandType.Text
            .CommandText = "Delete From Tbl_Products Where Product_ID = @Product_ID"
            .Parameters.Clear()
            .Parameters.AddWithValue("@Product_ID", ID_Position) ' لا حاجة لتحديد SqlDbType
        End With

        If Con.State = ConnectionState.Open Then Con.Close()
        Con.Open()
        Cmd.ExecuteNonQuery()
        Con.Close()
        MsgBox("تم حذف السجل.", MsgBoxStyle.Information, "حذف")
        Cmd = Nothing
    End Sub




    Private Sub Frm_Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CustomizeForm(Me)
        ClearControls()
        fillcmb_Tbl_Categories(CAT_ID)
        fillcmb_Tbl_Units_SpareParts(Unit_ID)
        SelectAll_ProductsALL(dgv_Products)
        Product_ID.Focus()
        BtnEdit.Enabled = False
        BtnDelete.Enabled = False
        Lbl_Count_Product.Text = dgv_Products.RowCount.ToString()
        GotFoucs_LostFocus_For_Control_On_Panal(Panel1)
        GotFoucs_LostFocus_For_Control_On_Panal(Panel3)
        GotFoucs_LostFocus_For_Control_On_Panal(Panel4)
        GotFoucs_LostFocus_For_Control_On_Panal(Panel5)
    End Sub

    Public Function GetDoubleValueForProduct(valueString As String) As Double
        Dim doubleValue As Double
        If String.IsNullOrWhiteSpace(valueString) Then
            Return 0.00
        End If
        If Double.TryParse(valueString, doubleValue) Then
            Return doubleValue
        End If
        ' يمكنك إضافة مزيد من المنطق هنا، مثل إظهار رسالة خطأ
        Return 0.00 ' أو القيمة الافتراضية التي تناسب تطبيقك
    End Function

    Public Function GetIntegrValueForProduct(valueString As String) As Integer
        Dim IntegerValue As Integer
        If String.IsNullOrWhiteSpace(valueString) Then
            Return 0
        End If
        If Integer.TryParse(valueString, IntegerValue) Then
            Return IntegerValue
        End If
        ' يمكنك إضافة مزيد من المنطق هنا، مثل إظهار رسالة خطأ
        Return 0 ' أو القيمة الافتراضية التي تناسب تطبيقك
    End Function

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Try
            If Product_ID.Text = vbNullString OrElse Product_Name.Text = vbNullString Then
                If Product_ID.Text = vbNullString Then
                    MessageBox.Show("قم بكتابة كود الصنف اولا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                Else
                    MessageBox.Show("قم بكتابة اسم الصنف أولاً", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                End If
                Exit Sub
            End If
            Dim Initial_BalanceValue As Integer = GetDoubleValueForProduct(Initial_Balance.Text)
            Dim Minimum_ThresholdValue As Double = GetDoubleValueForProduct(Minimum_Threshold.Text)
            Dim Maximum_ThresholdValue As Double = GetDoubleValueForProduct(Maximum_Threshold.Text)
            Dim QTE_IN_STOCKValue As Double = GetDoubleValueForProduct(QTE_IN_STOCK.Text)
            Dim Unit_PriceValue As Double = GetDoubleValueForProduct(Unit_Price.Text)
            Dim doublevalue As Double = 0.00
            Dim CATid_Value As Integer = GetIntegrValueForProduct(CAT_ID.SelectedValue)
            Dim UnitID_Value As Integer = GetIntegrValueForProduct(Unit_ID.SelectedValue)
            Dim MovementDescription As String = "  تم حفظ صنف  " + Product_Name.Text
            Dim DeviceName As String = Environ$("computername")
            Insert_Products(Product_ID.Text, Product_Name.Text, Initial_BalanceValue, doublevalue, doublevalue, doublevalue, doublevalue, QTE_IN_STOCKValue, Int(CATid_Value), CAT_ID.Text, Int(UnitID_Value), Unit_ID.Text, Minimum_ThresholdValue, Maximum_ThresholdValue, Location.Text, Expiry_Warning.Text, Unit_PriceValue)
            Insert_MovementHistory(MovementDescription, DateTime.Now, loggedInUserName, DeviceName, Me.Name, "BtnSave")
            ClearControls()
            fillcmb_Tbl_Categories(CAT_ID)
            fillcmb_Tbl_Units_SpareParts(Unit_ID)
            ClearControls()
            SelectAll_ProductsALL(dgv_Products)
            Product_ID.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Try
            If Product_Name.Text = vbNullString Then
                MessageBox.Show("عفواً ، قم بكتابة اسم الصنف", "تنبيه ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign)
                Exit Sub
            End If
            Dim Initial_BalanceValue As Double = GetDecimalValue(Initial_Balance.Text)
            Dim Minimum_ThresholdValue As Double = GetDoubleValue(Minimum_Threshold.Text)
            Dim Maximum_ThresholdValue As Double = GetDoubleValue(Maximum_Threshold.Text)
            Dim QTE_IN_STOCKValue As Double = GetDecimalValue(QTE_IN_STOCK.Text)
            Dim Unit_PriceValue As Double = GetDoubleValue(Unit_Price.Text)
            Dim CATid_Value As Integer = GetIntegrValueForProduct(CAT_ID.SelectedValue)
            Dim UnitID_Value As Integer = GetIntegrValueForProduct(Unit_ID.SelectedValue)
            Dim MovementDescription As String = "  تم تعديل صنف  " + Product_Name.Text
            Dim DeviceName As String = Environ$("computername")
            Update_Tbl_Products(Product_Name.Text, Initial_BalanceValue, QTE_IN_STOCKValue, Int(CATid_Value), CAT_ID.Text, Int(UnitID_Value), Unit_ID.Text, Minimum_ThresholdValue, Maximum_ThresholdValue, Unit_PriceValue, Location.Text, Expiry_Warning.Text, Product_ID.Text)
            Insert_MovementHistory(MovementDescription, DateTime.Now, loggedInUserName, DeviceName, Me.Name, "BtnEdit")
            ClearControls()
            fillcmb_Tbl_Categories(CAT_ID)
            fillcmb_Tbl_Units_SpareParts(Unit_ID)
            ClearControls()
            SelectAll_ProductsALL(dgv_Products)
            Product_ID.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Try
            If MessageBox.Show("هل أنت متأكد من مواصلة عملية الحذف؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.No Then
                Exit Sub
            Else
                Delete_Products(dgv_Products)
            End If
            ClearControls()
            fillcmb_Tbl_Categories(CAT_ID)
            fillcmb_Tbl_Units_SpareParts(Unit_ID)
            SelectAll_ProductsALL(dgv_Products)
            Product_ID.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BtnNewAdd_Click(sender As Object, e As EventArgs) Handles BtnNewAdd.Click
        ClearControls()
        fillcmb_Tbl_Categories(CAT_ID)
        fillcmb_Tbl_Units_SpareParts(Unit_ID)
        SelectAll_ProductsALL(dgv_Products)
        Product_ID.Focus()
        Me.BtnSave.Enabled = True
        Me.BtnEdit.Enabled = False
        BtnDelete.Enabled = False
    End Sub

    Private Sub IMAGE_PRODUCT_Click(sender As Object, e As EventArgs) Handles IMAGE_PRODUCT.Click
        ChoosePicture(IMAGE_PRODUCT)
        Update_Image(IMAGE_PRODUCT, Product_ID.Text)
    End Sub

    Private Sub dgv_Products_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Products.CellContentClick
        Try

            PopulateComboBoxSelectValue(Unit_ID, "Unit_ID")
            PopulateComboBoxSelectValue(CAT_ID, "CAT_ID")
            With dgv_Products
                Me.Product_ID.Text = .CurrentRow.Cells("Product_ID").Value.ToString()
                Me.Product_Name.Text = .CurrentRow.Cells("Product_Name").Value.ToString()
                Me.QTE_IN_STOCK.Text = .CurrentRow.Cells("QTE_IN_STOCK").Value.ToString()
                'Me.CAT_ID.SelectedValue = .CurrentRow.Cells("CAT_ID").Value.ToString()
                'Me.Unit_ID.SelectedValue = .CurrentRow.Cells("Unit_ID").Value.ToString()
                Me.Initial_Balance.Text = .CurrentRow.Cells("Initial_Balance").Value.ToString()
                Me.Minimum_Threshold.Text = .CurrentRow.Cells("Minimum_Threshold").Value.ToString()
                Me.Maximum_Threshold.Text = .CurrentRow.Cells("Maximum_Threshold").Value.ToString()
                Dim empImageValue As Object = .CurrentRow.Cells("IMAGE_PRODUCT").Value
                If Not IsDBNull(empImageValue) AndAlso empImageValue IsNot Nothing Then
                    Me.IMAGE_PRODUCT.Image = DGVCurrentImageView(empImageValue)
                Else
                    Me.IMAGE_PRODUCT.Image = Nothing
                End If
                Me.Location.Text = .CurrentRow.Cells("Location").Value.ToString()
                Me.Expiry_Warning.Text = .CurrentRow.Cells("Expiry_Warning").Value.ToString()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Me.BtnSave.Enabled = False
        Me.BtnEdit.Enabled = True
        BtnDelete.Enabled = True
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Frm_Categories.Show()
    End Sub

    Private Sub CAT_ID_DropDown(sender As Object, e As EventArgs) Handles CAT_ID.DropDown
        fillcmb_Tbl_Categories(CAT_ID)
    End Sub

    Private Sub Unit_ID_DropDown(sender As Object, e As EventArgs) Handles Unit_ID.DropDown
        fillcmb_Tbl_Units_SpareParts(Unit_ID)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        Frm_Add_details.Label1.Text = "اضافة الرصيد الحالى للصنف"
        Frm_Add_details.Txt_Help.Text = "1"
        Frm_Add_details.Product_ID.Text = Me.Product_ID.Text
        Frm_Add_details.Product_Name.Text = Me.Product_Name.Text
        Frm_Add_details.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Frm_Add_details.Label1.Text = "اضافة رصيد بداية المدة للصنف"
        Frm_Add_details.Txt_Help.Text = "2"
        Frm_Add_details.Product_ID.Text = Me.Product_ID.Text
        Frm_Add_details.Product_Name.Text = Me.Product_Name.Text
        Frm_Add_details.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Frm_Add_details.Label1.Text = "اضافة سعر للصنف"
        Frm_Add_details.Txt_Help.Text = "3"
        Frm_Add_details.Product_ID.Text = Me.Product_ID.Text
        Frm_Add_details.Product_Name.Text = Me.Product_Name.Text
        Frm_Add_details.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Frm_Units_SpareParts.Show()
    End Sub

    Private Sub Txt_Search_TextChanged(sender As Object, e As EventArgs) Handles Txt_Search.TextChanged
        Try
            Dim dv As DataView = dt_Products.DefaultView
            Select Case True
                Case Me.Radio_Product_ID.Checked
                    dv.RowFilter = If(Txt_Search.Text = "", "", "Product_ID = '" & Txt_Search.Text & "'")
                Case Me.Radio_Product_Name.Checked
                    dv.RowFilter = " Product_Name LIKE '%" & Txt_Search.Text & "%' "
            End Select
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
        Lbl_Count_Product.Text = dgv_Products.RowCount.ToString()
    End Sub

    Private Sub Product_Name_Enter(sender As Object, e As EventArgs) Handles Product_Name.Enter
        Arabic()
    End Sub

    Public Sub SelectAll_ProductsALL(dgv As DataGridView)
        Dim da As New SqlDataAdapter
        dt_Products.Clear()
        'da = New SqlDataAdapter("SELECT dbo.Tbl_Products.*, dbo.Tbl_Units_SpareParts.Unit_Name, dbo.Tbl_Categories.CAT_Name
        '                FROM dbo.Tbl_Products
        '                INNER JOIN dbo.Tbl_Units_SpareParts ON dbo.Tbl_Products.Unit_ID = dbo.Tbl_Units_SpareParts.Unit_ID
        '                INNER JOIN dbo.Tbl_Categories ON dbo.Tbl_Products.CAT_ID = dbo.Tbl_Categories.CAT_ID", Con)

        da = New SqlDataAdapter("SELECT * FROM Tbl_Products", Con)
        da.Fill(dt_Products)
        dt_Products.Columns("Product_ID").SetOrdinal(0)
        dt_Products.Columns("Product_Name").SetOrdinal(1)
        dt_Products.Columns("Initial_Balance").SetOrdinal(2)
        dt_Products.Columns("ElWarad").SetOrdinal(3)
        dt_Products.Columns("MortagaaOmalaa").SetOrdinal(4)
        dt_Products.Columns("ElMonsarf").SetOrdinal(5)
        dt_Products.Columns("MortagaaElMawarden").SetOrdinal(6)
        dt_Products.Columns("QTE_IN_STOCK").SetOrdinal(7)
        dt_Products.Columns("IMAGE_PRODUCT").SetOrdinal(8)
        dt_Products.Columns("Unit_Price").SetOrdinal(9)
        dt_Products.Columns("CAT_ID").SetOrdinal(10)
        dt_Products.Columns("CAT_Name").SetOrdinal(11)
        dt_Products.Columns("Unit_ID").SetOrdinal(12)
        dt_Products.Columns("Unit_Name").SetOrdinal(13)
        dt_Products.Columns("Minimum_Threshold").SetOrdinal(14)
        dt_Products.Columns("Maximum_Threshold").SetOrdinal(15)
        dt_Products.Columns("Location").SetOrdinal(16)
        dgv.DataSource = dt_Products
        With dgv
            .Columns("Product_ID").HeaderText = "كود الصنف"
            .Columns("Product_Name").HeaderText = "اسم الصنف"
            .Columns("Product_Name").Width = 250
            .Columns("Initial_Balance").HeaderText = "رصيد بداية المدة"
            .Columns("ElWarad").HeaderText = "الوراد"
            .Columns("MortagaaOmalaa").HeaderText = "مرتجع العملاء"
            .Columns("ElMonsarf").HeaderText = "المنصرف"
            .Columns("MortagaaElMawarden").HeaderText = "مرتجع الموردين"
            .Columns("QTE_IN_STOCK").HeaderText = "الرصيد الحالى"
            .Columns("IMAGE_PRODUCT").HeaderText = "صورة الصنف"
            .Columns("IMAGE_PRODUCT").Visible = False
            .Columns("Unit_Price").HeaderText = "سعر الصنف"
            .Columns("Unit_Price").Visible = False
            .Columns("CAT_ID").HeaderText = "كود التصنيف"
            .Columns("CAT_ID").Visible = False
            .Columns("CAT_Name").HeaderText = "اسم التصنيف"
            .Columns("Unit_ID").HeaderText = "كود الوحدة"
            .Columns("Unit_ID").Visible = False
            .Columns("Unit_Name").HeaderText = "الوحدة"
            .Columns("Minimum_Threshold").HeaderText = "اقل رصيد"
            .Columns("Maximum_Threshold").HeaderText = "اكبر رصيد"
            .Columns("Location").HeaderText = "التواجد"
            .Columns("Expiry_Warning").HeaderText = "يظهر فى التنبيهات"
            .Columns("Expiry_Warning").Visible = False
        End With
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        SelectAll_ProductsALL(dgv_Products)
        Lbl_Count_Product.Text = dgv_Products.RowCount.ToString()
    End Sub

    Private Sub Button_Item_Alert_Click(sender As Object, e As EventArgs) Handles Btn_Item_Alert.Click
        Frm_Expiry_Notification.Show()
    End Sub

    Private Function GetValueforCombobox(ByVal value As Object) As String
        'الكود ده للكمبوبوكس عشان لو فاضى ميدنيش خطأ
        If Not IsDBNull(value) Then
            Return value.ToString()
        Else
            Return vbNullString
        End If
    End Function
    Private Sub RetrieveProductData(ByVal ProductID As Integer)
        Using command As New SqlCommand("GetProduct_BY_Product_ID", Con)
            command.CommandType = CommandType.StoredProcedure
            command.Parameters.AddWithValue("@Product_ID", ProductID)
            If Con.State = 1 Then Con.Close()
            Con.Open()
            Try
                Dim reader As SqlDataReader = command.ExecuteReader()
                If reader.HasRows Then
                    While reader.Read()
                        ' استرداد البيانات الأساسية
                        'Product_ID.Text = reader("Product_ID").ToString()
                        Product_Name.Text = reader("Product_Name").ToString()
                        Initial_Balance.Text = reader("Initial_Balance").ToString()
                        'ElWarad.Text = reader("ElWarad").ToString()
                        'MortagaaOmalaa.Text = reader("MortagaaOmalaa").ToString()
                        'ElMonsarf.Text = reader("ElMonsarf").ToString()
                        'MortagaaElMawarden.Text = reader("MortagaaElMawarden").ToString()
                        QTE_IN_STOCK.Text = reader("QTE_IN_STOCK").ToString()
                        Minimum_Threshold.Text = reader("Minimum_Threshold").ToString()
                        Maximum_Threshold.Text = reader("Maximum_Threshold").ToString()
                        Location.Text = reader("Location").ToString()
                        'Unit_ID.SelectedValue = (reader("Unit_ID").ToString())
                        Unit_ID.Text = reader("Unit_Name").ToString()
                        'CAT_ID.SelectedValue = ("CAT_ID").ToString()
                        CAT_ID.Text = reader("CAT_Name").ToString()
                        ' استرداد الصورة إذا كانت متاحة
                        If Not IsDBNull(reader("Image_Product")) Then
                            Dim imageData As Byte() = DirectCast(reader("Image_Product"), Byte())
                            Using ms As New System.IO.MemoryStream(imageData)
                                IMAGE_PRODUCT.Image = Image.FromStream(ms)
                            End Using
                        Else
                            IMAGE_PRODUCT.Image = My.Resources.No_Picture

                        End If
                        Expiry_Warning.Text = reader("Expiry_Warning").ToString()
                    End While
                Else
                    MessageBox.Show("لم يتم العثور على معلومات لهذا الصنف")
                End If
            Catch ex As Exception
                MessageBox.Show("خطأ: " & ex.Message)
            End Try
        End Using
        Con.Close()
    End Sub

    Private Sub Product_ID_KeyDown(sender As Object, e As KeyEventArgs) Handles Product_ID.KeyDown
        Try
            ' التأكد من أن المفتاح المضغوط هو مفتاح Enter
            If e.KeyCode = Keys.Enter Then
                ' تنفيذ الكود لاسترداد بيانات الموظف
                RetrieveProductData(Product_ID.Text)
            End If
        Catch ex As Exception
            MessageBox.Show("خطأ: " & ex.Message)
        End Try

    End Sub


End Class