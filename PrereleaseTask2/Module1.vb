﻿Module Module1

    Sub Main()
        Dim FileWriter As System.IO.StreamWriter
        Dim FileReader As System.IO.StreamWriter
        FileReader = New System.IO.StreamReader()
        FileWriter = New System.IO.StreamWriter("Log.txt")
        Inputting(FileWriter)
        Console.ReadLine()
        FileWriter.Close()
    End Sub
    Sub Inputting(ByRef FileWriter)
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

    End Sub
    Sub NameSearch(ByRef FileReader)
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
            Console.WriteLine("Name not found ")
        End If
    End Sub
End Module
