Module Module1
    Sub outputting(ByVal arrNameEmail)
        Dim hashno As Integer = 0
        Console.WriteLine("Name                    Email") '10+5=25
        For i = 1 To 3
            If arrNameEmail(i) <> "" Then
                For j = 1 To Len(arrNameEmail(i))
                    If Mid(arrNameEmail(i), j, 1) = "#" Then
                        hashno = j
                    End If
                Next
                Console.Write(Left(arrNameEmail(i), hashno - 1) & Space(25 - hashno))
                Console.Write(Right(arrNameEmail(i), Len(arrNameEmail(i)) - hashno))
                Console.WriteLine()
            End If
        Next
    End Sub

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


        Console.ReadLine()
    End Sub

End Module
