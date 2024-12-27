Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Public Class TripleDES
    Private m_des As New TripleDESCryptoServiceProvider
    Private m_utf8 As New UTF8Encoding
    Private m_key() As Byte
    Private m_iv() As Byte
    Public Sub New()
        Me.m_key = New Byte() {46, 26, 21, 65, 20, 14, 70, 64, 32, 20, 41, 17, 97, 84, 16, 6, 1, 94, 19, 47, 69, 14, 87, 99}
        Me.m_iv = New Byte() {65, 69, 74, 42, 1, 64, 98, 23}
    End Sub
    Public Function Encrypt(ByVal input() As Byte) As Byte()
        Return transform(input, m_des.CreateEncryptor(m_key, m_iv))
    End Function
    Public Function Decrypt(ByVal input() As Byte) As Byte()
        Return transform(input, m_des.CreateDecryptor(m_key, m_iv))
    End Function
    Public Function encrypt(ByVal text As String) As String
        Dim input() As Byte = m_utf8.GetBytes(text)
        Dim output() As Byte = transform(input, m_des.CreateEncryptor(m_key, m_iv))
        Return Convert.ToBase64String(output)
    End Function
    Public Function decrypt(ByVal text As String) As String
        Dim input() As Byte = Convert.FromBase64String(text)
        Dim output() As Byte = transform(input, m_des.CreateDecryptor(m_key, m_iv))
        Return m_utf8.GetString(output)
    End Function
    Private Function transform(ByVal input() As Byte, ByVal CryptoTransform As ICryptoTransform) As Byte()
        Dim memstream As MemoryStream = New MemoryStream
        Dim cryptstream As CryptoStream = New CryptoStream(memstream, CryptoTransform, CryptoStreamMode.Write)
        cryptstream.Write(input, 0, input.Length)
        cryptstream.FlushFinalBlock()
        memstream.Position = 0
        Dim result(memstream.Length - 1) As Byte
        memstream.Read(result, 0, result.Length)
        memstream.Close()
        cryptstream.Close()
        Return result
    End Function
End Class
