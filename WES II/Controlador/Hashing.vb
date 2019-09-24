Public Class Hashing

    Public Shared Function sha1(ByVal cadenaEntrada As String) As String
        Dim encriptador As New Security.Cryptography.SHA1CryptoServiceProvider
        Dim arregloBytes() As Byte = System.Text.Encoding.ASCII.GetBytes(cadenaEntrada)

        arregloBytes = encriptador.ComputeHash(arregloBytes)

        Dim resultado As String = ""

        For Each b As Byte In arregloBytes
            resultado += b.ToString("x2")
        Next

        Return resultado
    End Function

End Class
