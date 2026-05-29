Imports System.Security.Cryptography
Imports System.Text

Public Module SecurityHelper

    Public Function HashPassword(password As String) As String

        Dim bytes As Byte() =
            Encoding.UTF8.GetBytes(password)

        Dim hash As Byte() =
            SHA256.HashData(bytes)

        Dim builder As New StringBuilder()

        For Each b As Byte In hash
            builder.Append(b.ToString("x2"))
        Next

        Return builder.ToString()

    End Function

End Module