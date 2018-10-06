Module Module1

    Sub Main()
        Dim fileReaderA, fileReaderB As IO.StreamReader
        Dim filewriter As IO.StreamWriter

        fileReaderA = New IO.StreamReader("fileA.txt")
        fileReaderB = New IO.StreamReader("fileB.txt")
        filewriter = New IO.StreamWriter("fileAB.txt")
        For i = 1 To 100
            filewriter.WriteLine(fileReaderA.ReadLine() & " : " & fileReaderB.ReadLine())
        Next

            filewriter.Close()
    End Sub

End Module
