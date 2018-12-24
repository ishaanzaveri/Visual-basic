Module Module1

    Sub Main()
        Dim Name As String
        Dim Email As String
        Dim ArrNameEmail(3) As String


        'Task 1.1
        For i = 1 To 3
            Console.WriteLine("Enter Name")
            Name = Console.ReadLine()
            Console.WriteLine("Enter Email")
            Email = Console.ReadLine()
            ArrNameEmail(i) = Name & "#" & Email
        Next

        outputting(ArrNameEmail)
        NameSearch(ArrNameEmail)
        SubStrings(ArrNameEmail)



        Console.ReadLine()
    End Sub

    Sub outputting(ByVal arrNameEmail) 'task 1.2 
        Dim hashno As Integer = 0
        Console.WriteLine("Name                    Email") '10+5=25
        For i = 1 To 3
            If arrNameEmail(i) <> "" Then
                hashno = HashNoFinder(arrNameEmail(i))
                Console.Write(Left(arrNameEmail(i), hashno - 1) & Space(25 - hashno))
                Console.Write(Right(arrNameEmail(i), Len(arrNameEmail(i)) - hashno))
                Console.WriteLine()
            End If
        Next
    End Sub

    Sub NameSearch(ByVal arrNameEmail) 'task 1.3
        Dim Name As String
        Dim found As Boolean = False
        Console.WriteLine("Enter the Name you want to find")
        Name = Console.ReadLine()
        For i = 1 To 3
            If Left(arrNameEmail(i), Len(Name)) = Name Then
                Console.WriteLine(Name & "'s email is " & Right(arrNameEmail(i), Len(arrNameEmail(i)) - Len(Name) - 1))
                found = True
            End If
        Next
        If Not found Then
            Console.WriteLine("Name not found ")
        End If
    End Sub

    Sub SubStrings(ByRef arrNameEmail) 'task 1.4
        Dim subStr As String
        Dim frequency As Integer = 0
        Dim found As Boolean = False
        Console.WriteLine("Enter Substring")
        subStr = Console.ReadLine()

        For i = 1 To 3
            found = False
            For j = 1 To Len(arrNameEmail(i)) - Len(subStr)
                If subStr = Mid(arrNameEmail(i), j, Len(subStr)) Then
                    frequency = frequency + 1
                    found = True
                End If
            Next
            If found Then
                Console.WriteLine(Left(arrNameEmail(i), HashNoFinder(arrNameEmail(i)) - 1))
            ElseIf frequency < 1 Then
                Console.WriteLine("Not found")
            End If
        Next
    End Sub

    Function HashNoFinder(ByRef str) As Integer
        Dim hash As Integer
        For j = 1 To Len(str)
            If Mid(str, j, 1) = "#" Then
                hash = j
            End If
        Next
        Return hash
    End Function

End Module
