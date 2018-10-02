Module Module1

    Sub Main()
        'Working with files 
        '   1) open the file 
        '   2) do your stuff 
        '   3) Close your files

        Dim fileHandle As IO.StreamWriter ' define it as an object of class IO
        Dim str As String
        Dim fileRead As IO.StreamReader
        fileRead = New IO.StreamReader("sample.txt")
        For i = 1 To 30
            str = fileRead.ReadLine()
            Console.WriteLine(str)
        Next
        fileRead.Close()

        fileHandle = New IO.StreamWriter("sample.txt", True) ' create object and file 
        For i = 1 To 10
            fileHandle.WriteLine("Ishaan Zaveri") ' write to file 
        Next

        fileHandle.Close() ' close file

        Console.ReadLine()

    End Sub

End Module
