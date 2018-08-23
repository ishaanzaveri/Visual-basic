Module Module1

    Sub Main()
        Dim n As Integer
        Dim Arrow As Boolean = vbTrue
        'Console.WriteLine("Enter number of matrix size")
        'n = Console.ReadLine()
        n = 3
        Dim Matrix(n, n) As Integer
        For i = 1 To n
            For j = 1 To n
                Console.WriteLine("enter element " & i & " " & j)
                Matrix(i, j) = Console.ReadLine()
            Next
        Next

        For i = 1 To n
            For j = 1 To n
                If Matrix(1, j) = 0 Then
                    Arrow = vbFalse
                End If
                If Matrix(j, 1) = 0 Then
                    Arrow = vbFalse
                End If
                If Matrix(j, j) = 0 Then
                    Arrow = vbFalse
                End If
                If i <= n - 2 Then
                    If Matrix(i + 2, j + 1) <> 0 Then
                        Arrow = vbFalse
                    End If
                End If
                If j <= n - 2 Then
                    If Matrix(j + 2, i + 1) <> 0 Then
                        Arrow = vbFalse
                    End If
            Next
        Next
        If Arrow Then
            Console.WriteLine("Arrow matrix")
        Else
            Console.WriteLine("Not an Arrow matrix")
        End If
    End Sub

End Module
