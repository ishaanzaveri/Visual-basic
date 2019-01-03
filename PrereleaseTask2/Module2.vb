Module Module1

    Sub Main()
        Dim FileWriter As System.IO.StreamWriter
        Dim FileReader As System.IO.StreamReader
        Inputting(FileWriter)
        NameSearch(FileReader)
        Console.ReadLine()

    End Sub
    Sub Inputting(ByRef FileWriter As IO.StreamWriter)
        FileWriter = New System.IO.StreamWriter("Log.txt")
        Dim Name As String
        Dim Email As String

        'Task 1.1
        For i = 1 To 3
            Console.WriteLine("Enter Name")
            Name = Console.ReadLine()
            Console.WriteLine("Enter Email")
            Email = Console.ReadLine()
            FileWriter.WriteLine(Name & "#" & Email)
        Next
        FileWriter.Close()
    End Sub

End Module
