Module Module3

    Sub Main()
        Dim n, i, j As Integer
        Console.WriteLine("enter number of elements in magic square")
        Do
            n = Console.ReadLine()
        Loop Until (n + 1) <> 2 = 0
        Dim Matrix(n, n) As Integer
        i = 1
        j = n + 1 / 2
        For i = 1 To n ^ 2
            Matrix(i, j) = i
            If i < 0 Then
                i = n
            End If
            If j = n Then
                j = 1
            End If
            If Matrix(i, j) >= 1 Or (i = 1 And j = n) Then
                i = i + 2
                j = j - 1
            End If
        Next
    End Sub
End Module
