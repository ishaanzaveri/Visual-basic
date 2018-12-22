Module Module1

    Sub Main()
        Dim Name As String
        Dim Email As String
        Dim ArrNameEmail(3) As String
        Dim hashno As Integer

        'Task 1.1
        For i = 1 To 3
            Console.WriteLine("Enter Name")
            Name = Console.ReadLine()
            Console.WriteLine("Enter Email")
            Email = Console.ReadLine()
            ArrNameEmail(i) = Name & "#" & Email
        Next

        Console.WriteLine("Name                    Email") '10+5=25
        For i = 1 To 3
            If ArrNameEmail(i) <> "" Then
                For j = 1 To Len(ArrNameEmail(i))
                    If Mid(ArrNameEmail(i), j, 1) = "#" Then
                        hashno = j
                    End If
                Next
                Console.Write(Left(ArrNameEmail(i), hashno - 1) & Space(25 - hashno))
                Console.Write(Right(ArrNameEmail(i), Len(ArrNameEmail(i)) - hashno))
                Console.WriteLine()
            End If
        Next
        Console.ReadLine()
    End Sub

End Module
