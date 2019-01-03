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
    Sub NameSearch(ByRef FileReader)
        FileReader = New System.IO.StreamReader("Log.txt")
        Dim FileLine As String
        Dim Name As String
        Dim found As Boolean = False
        Console.WriteLine("Enter the Name you want to find")
        Name = Console.ReadLine()
        For i = 1 To 3
            FileLine = FileReader.ReadLine()
            If Left(FileLine, Len(Name)) = Name Then
                Console.WriteLine(Name & "'s email is " & Right(FileLine, Len(FileLine) - Len(Name) - 1))
                found = True
            End If
        Next
        If Not found Then
            Console.WriteLine("Name not found")
        End If
        FileReader.Close()
    End Sub
End Module
