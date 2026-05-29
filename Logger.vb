Imports System.IO
Module Logger

    Public Sub LogError(message As String)

        Dim path As String =
            "error_log.txt"

        Dim log As String =
            DateTime.Now.ToString() &
            " | ERROR | " &
            message

        File.AppendAllText(
            path,
            log & Environment.NewLine
        )

    End Sub

End Module