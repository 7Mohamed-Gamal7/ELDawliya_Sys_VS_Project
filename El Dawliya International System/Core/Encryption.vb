Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class Encryption
    Private Shared _instance As Encryption
    Private ReadOnly _key As Byte()
    Private ReadOnly _iv As Byte()
    Private ReadOnly _logger As Logger

    Private Sub New()
        _logger = Logger.GetInstance()
        ' يجب تغيير هذه المفاتيح في الإنتاج واستخدام طريقة آمنة لتخزينها
        _key = Encoding.UTF8.GetBytes("YourSecretKey123") ' 16 bytes for AES-128
        _iv = Encoding.UTF8.GetBytes("YourInitVector16") ' 16 bytes
    End Sub

    Public Shared Function GetInstance() As Encryption
        If _instance Is Nothing Then
            _instance = New Encryption()
        End If
        Return _instance
    End Function

    Public Function EncryptString(plainText As String) As String
        Try
            Using aes As Aes = Aes.Create()
                aes.Key = _key
                aes.IV = _iv

                Dim encryptor As ICryptoTransform = aes.CreateEncryptor(aes.Key, aes.IV)

                Using msEncrypt As New MemoryStream()
                    Using csEncrypt As New CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write)
                        Using swEncrypt As New StreamWriter(csEncrypt)
                            swEncrypt.Write(plainText)
                        End Using
                    End Using

                    Return Convert.ToBase64String(msEncrypt.ToArray())
                End Using
            End Using
        Catch ex As Exception
            _logger.LogError("Encryption failed", ex)
            Throw New Exception("Encryption failed", ex)
        End Try
    End Function

    Public Function DecryptString(cipherText As String) As String
        Try
            Dim cipherBytes = Convert.FromBase64String(cipherText)

            Using aes As Aes = Aes.Create()
                aes.Key = _key
                aes.IV = _iv

                Dim decryptor As ICryptoTransform = aes.CreateDecryptor(aes.Key, aes.IV)

                Using msDecrypt As New MemoryStream(cipherBytes)
                    Using csDecrypt As New CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read)
                        Using srDecrypt As New StreamReader(csDecrypt)
                            Return srDecrypt.ReadToEnd()
                        End Using
                    End Using
                End Using
            End Using
        Catch ex As Exception
            _logger.LogError("Decryption failed", ex)
            Throw New Exception("Decryption failed", ex)
        End Try
    End Function

    Public Function HashPassword(password As String) As String
        Try
            Using sha256 As SHA256 = SHA256.Create()
                Dim hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password))
                Return Convert.ToBase64String(hashedBytes)
            End Using
        Catch ex As Exception
            _logger.LogError("Password hashing failed", ex)
            Throw New Exception("Password hashing failed", ex)
        End Try
    End Function

    Public Function VerifyPassword(password As String, hashedPassword As String) As Boolean
        Try
            Dim newHash = HashPassword(password)
            Return newHash = hashedPassword
        Catch ex As Exception
            _logger.LogError("Password verification failed", ex)
            Return False
        End Try
    End Function

    Public Function GenerateRandomKey(length As Integer) As String
        Try
            Using rng As New RNGCryptoServiceProvider()
                Dim randomBytes(length - 1) As Byte
                rng.GetBytes(randomBytes)
                Return Convert.ToBase64String(randomBytes)
            End Using
        Catch ex As Exception
            _logger.LogError("Random key generation failed", ex)
            Throw New Exception("Random key generation failed", ex)
        End Try
    End Function
End Class
