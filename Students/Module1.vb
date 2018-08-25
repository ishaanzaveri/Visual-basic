Module Module1

    Sub Main()
        Dim StudentGrades(3, 4) As Integer
        Dim sum = 0
        For i = 1 To 3
            For j = 1 To 4
                Console.WriteLine("Enter grades for Student " & i & " Subject " & j)
                StudentGrades(i, j) = Console.ReadLine()
            Next
        Next
        For i = 1 To 3
            sum = 0
            For j = 1 To 4
                sum = sum + StudentGrades(i, j)
            Next
            Console.WriteLine("avg for student " & i & " is " & sum / 4)
        Next
        Console.ReadLine()
    End Sub

End Module
