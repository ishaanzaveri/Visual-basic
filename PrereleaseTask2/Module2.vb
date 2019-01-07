Module Module1
    Dim NumOfStudents As Integer
    Sub Main()
        Dim FileWriter As System.IO.StreamWriter
        Dim FileReader As System.IO.StreamReader
        Inputting(FileWriter)
        NameSearch(FileReader)
        SubStrMatch(FileReader)
        Appened(FileWriter)
        Console.ReadLine()

    End Sub
    Sub Inputting(ByRef FileWriter As IO.StreamWriter) '2.1
        FileWriter = New System.IO.StreamWriter("Log.txt")
        Dim StdId As String
        Dim Email As String
        Dim HomeAdd As String
        Dim Tutor As String

        Console.WriteLine("Enter Number of Students")
        NumOfStudents = Console.ReadLine()

        'Task 1.1
        For i = 1 To NumOfStudents
            Console.WriteLine("Enter Student ID")
            StdId = Console.ReadLine()
            FileWriter.WriteLine(StdId)
            Console.WriteLine("Enter Email")
            Email = Console.ReadLine()
            FileWriter.WriteLine(Email)
            Console.WriteLine("Enter Home Adress")
            HomeAdd = Console.ReadLine()
            FileWriter.WriteLine(HomeAdd)
            Console.WriteLine("Enter tutor")
            Tutor = Console.ReadLine()
            FileWriter.WriteLine(Tutor)
            'FileWriter.WriteLine(Name & "#" & Email)
            FileWriter.WriteLine() ' 5 lines per person
        Next
        FileWriter.Close()
    End Sub
    Sub NameSearch(ByRef FileReader) '2.2
        FileReader = New System.IO.StreamReader("Log.txt")
        Dim FileLine As String
        Dim StdId As String
        Dim found As Boolean = False
        Console.WriteLine("Enter the Name you want to find")
        StdID = Console.ReadLine()
        For i = 1 To NumOfStudents
            FileLine = FileReader.ReadLine()
            If FileLine = StdId Then
                FileLine = FileReader.ReadLine()
                Console.WriteLine(FileLine)
                'Console.WriteLine(Name & "'s email is " & Right(FileLine, Len(FileLine) - Len(Name) - 1))
                found = True
            Else
                FileReader.ReadLine()
            End If
            For j = 3 To 5
                FileReader.ReadLine()
            Next
        Next
        If Not found Then
            Console.WriteLine("Name not found")
        End If
        FileReader.Close()
    End Sub
    Sub SubStrMatch(ByRef FileReader) '2.3
        FileReader = New System.IO.StreamReader("Log.txt")
        Dim subStr As String
        Dim FileLine As String
        Dim frequency As Integer = 0
        Dim found As Boolean = False
        Console.WriteLine("Enter Substring")
        subStr = Console.ReadLine()

        For i = 1 To NumOfStudents
            FileLine = FileReader.ReadLine()
            found = False
            For j = 1 To Len(FileLine) - Len(subStr)
                If subStr = Mid(FileLine, j, Len(subStr)) Then
                    frequency = frequency + 1
                    found = True
                End If
            Next
            If found Then
                Console.WriteLine(FileLine)
            ElseIf frequency < 1 Then
                Console.WriteLine("Not found")
            End If
            For j = 2 To 5
                FileReader.ReadLine()
            Next
        Next
        FileReader.Close()
    End Sub
    'Function HashNoFinder(ByRef str) As Integer
    'Dim hash As Integer
    'For j = 1 To Len(str)
    'If Mid(str, j, 1) = "#" Then
    '           hash = j
    'End If
    'Next
    'Return hash
    'End Function
    Sub Appened(ByRef FileWriter) ' 2.4
        FileWriter = New System.IO.StreamWriter("Log.txt", True)
        Dim Name As String
        Dim Email As String
        Dim HomeAdd As String
        Dim Tutor As String
        Dim append As Boolean = True
        Console.WriteLine("Do you want to append your File, if yes enter the appended data.After you are done appending enter a . as a rouge Values for name and email")
        Do While append
            Console.WriteLine("Enter Name")
            Name = Console.ReadLine()
            Console.WriteLine("Enter Email")
            Email = Console.ReadLine()
            Console.WriteLine("Enter Home address")
            HomeAdd = Console.ReadLine()
            Console.WriteLine("Enter tutor")
            Tutor = Console.ReadLine()
            If Name <> "." And Email <> "." And HomeAdd <> "." And Tutor <> "." Then
                FileWriter.WriteLine(Name)
                FileWriter.WriteLine(Email)
                FileWriter.WriteLine(HomeAdd)
                FileWriter.WriteLine(Tutor)
            Else
                append = False
            End If
        Loop

        FileWriter.Close()
    End Sub
End Module
