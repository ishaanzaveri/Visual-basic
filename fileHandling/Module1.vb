Module Module1

    Sub Main()
        Dim fileHandle As IO.StreamWriter ' define it as an object of class IO
        Dim str As String
        fileHandle = New IO.StreamWriter("sample.txt") ' create object and file 
        fileHandle.WriteLine("Hello World!") ' write to file 
        fileHandle.Close() ' close file

        Dim fileRead As IO.StreamReader
        fileRead = New IO.StreamReader("sample.txt")
        str = fileRead.ReadLine()
        Console.WriteLine(str)
        fileRead.Close()

        Console.ReadLine()

    End Sub

End Module
