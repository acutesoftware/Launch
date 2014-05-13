Module Module1

    Sub Main()

        Dim FILE_NAME As String = Environment.CurrentDirectory & "\launch.cfg"
        Dim launchString As String = ""

        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objReader As New System.IO.StreamReader(FILE_NAME)
            launchString = objReader.ReadLine()
            System.Diagnostics.Process.Start(launchString)

        End If
    End Sub

End Module
