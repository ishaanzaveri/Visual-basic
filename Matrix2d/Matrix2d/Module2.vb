Module Module1

    Sub Main()
        'Magic square, Arrowhead, binary, identity, inverse 

        Dim n, Choice As Integer

        Console.WriteLine("Enter number of matrix size")
        n = Console.ReadLine()
        'n = 3
        Dim Matrix(n, n) As Integer
        For i = 1 To n
            For j = 1 To n
                Console.WriteLine("enter element " & i & " " & j)
                Matrix(i, j) = Console.ReadLine()
            Next
        Next
        Console.WriteLine("press 1 for checking if it is a binary matrix, 2 for checking for magic square, 3 for checking arrowhead and 4 for transposing the matrix")
        Choice = Console.ReadLine()
        Select Case Choice
            Case 1
                Binary(n, Matrix) 'Binary Matrix
            Case 2
                MagicS(n, Matrix) 'Magic square
            Case 3
                Arrow(n, Matrix) 'Arrowhead matrix
            Case 4
                Transpose(n, Matrix) 'Transpose matrix
            Case Else
                Console.WriteLine("Invalid input")
        End Select

    End Sub
    Sub MagicS(ByVal n, ByVal Matrix)
        Dim isMagic = vbTrue
        Dim tempC As Integer
        Dim tempR As Integer
        Dim tempDi As Integer
        Dim temp As Integer
        For i = 1 To n
            temp = temp + Matrix(i, i)
            tempDi = tempDi + Matrix(n - i, i)
        Next
        If temp <> tempDi Then
            isMagic = vbFalse
        Else
            For i = 1 To n
                For j = 1 To n
                    tempC = tempC + Matrix(i, j)
                    tempR = tempR + Matrix(j, i)
                Next
                If temp <> tempC Or temp <> tempR Then
                    isMagic = vbFalse

                End If
            Next
        End If
        If isMagic Then
            Console.WriteLine("Magic Square")
        Else
            Console.WriteLine("Magic Square")
        End If
        Console.ReadLine()
    End Sub
    Sub Arrow(ByVal n, ByVal Matrix)
        Dim isArrow As Boolean = vbTrue
        For i = 1 To n
            For j = 1 To n
                If Matrix(1, j) = 0 Then
                    isArrow = vbFalse
                End If
                If Matrix(j, 1) = 0 Then
                    isArrow = vbFalse
                End If
                If Matrix(j, j) = 0 Then
                    isArrow = vbFalse
                End If
                If i <> 1 And j <> 1 And i <> j Then
                    If Matrix(i, j) <> 0 Then
                        isArrow = vbFalse
                    End If
                End If
            Next
        Next
        If isArrow Then
            Console.WriteLine("Arrow matrix")
        Else
            Console.WriteLine("Not an Arrow matrix")
        End If
        Console.ReadLine()
    End Sub
    Sub Transpose(ByRef n, ByRef Matrix)
        For i = 1 To n
            For j = 1 To n
                Console.Write(Matrix(j, i) & " ")
            Next
            Console.WriteLine()
        Next
        Console.ReadLine()
    End Sub
    Sub Binary(ByRef n, ByRef Matrix)
        Dim IsBinary As Boolean = vbTrue
        Dim i, j As Integer
        i = 1
        j = 1
        Do While IsBinary And i <= n
            Do While j <= n
                If Matrix(i, j) Then
                    IsBinary = vbFalse
                End If
                j = j + 1
            Loop
            i = i + 1
        Loop
        If IsBinary Then
            Console.WriteLine("Binary matrix")
        Else
            Console.WriteLine("Not an Binary matrix")
        End If
        Console.ReadLine()
    End Sub
End Module
