Module Module1

    Sub Main()
        Dim fileReaderA, fileReaderB As IO.StreamReader
        Dim names(100) As String
        Dim rollNo(100) As Integer
        fileReaderA = New IO.StreamReader("NamesArr.txt")
        fileReaderB = New IO.StreamReader("RollNoArr.txt")
        'fileWriterA = New IO.StreamWriter("NamesArr.txt")
        'fileWriterB = New IO.StreamWriter("RollNoArr.txt")
        For i = 1 To 100
            'fileWriterB.WriteLine(i)
            'For j = 1 To 6
            'fileWriterA.Write(Chr(((i * j) Mod 36) + 97))
            'Next
            'fileWriterA.WriteLine()
            names(i) = fileReaderA.ReadLine()
            rollNo(i) = CInt(fileReaderB.ReadLine())
        Next
        'fileWriterA.Close()
        'fileWriterB.Close()
        fileReaderA.Close()
        fileReaderB.Close()
        For i = 1 To 100
            Console.WriteLine(names(i) & " " & rollNo(i))
        Next
        Console.ReadLine()
    End Sub

End Module
