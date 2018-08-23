Module Module1

    Sub Main()
        Dim number As Integer
        Console.WriteLine("Please enter a number")
        number = Console.ReadLine()
        Triangle()
        rhombus()
        ' Is Automorphic ?
        Console.WriteLine(number & " is a Automorphic number " & Automorphic(number))
        Console.WriteLine()
        ' Numbers till that automorphic
        Console.WriteLine("numbers that are automorphic till " & number)
        For i = 1 To number
            If Automorphic(i) Then
                Console.WriteLine(i)
            End If
        Next
        'Reverse 
        Reverse(number)
        'tables
        Tables(number)
        ' Fibonacci
        Fibonacci(number)
        Console.WriteLine()
        Console.ReadLine()
    End Sub
    Sub Triangle()
        Dim n As Integer = 3
        For i = 1 To n
            For j = 1 To n - i
                Console.Write(" ")
            Next
            For j = 1 To (2 * i - 1)
                Console.Write("*")
            Next
            Console.WriteLine()
        Next
    End Sub
    Sub rhombus()
        Dim n As Integer = 5
        For i = 1 To (n + 1) / 2
            For j = 1 To n - i
                Console.Write(" ")
            Next
            For j = 1 To (2 * i - 1)
                Console.Write("*")
            Next
            Console.WriteLine()
        Next
        For i = ((n + 1) / 2) - 1 To 1 Step -1
            For j = 1 To n - i
                Console.Write(" ")
            Next
            For j = 1 To (2 * i - 1)
                Console.Write("*")
            Next
            Console.WriteLine()
        Next
    End Sub
    Sub Fibonacci(ByVal number)
        Dim a As Integer = 1
        Dim b As Integer = 1
        Dim temp As Integer
        Console.Write(a & " " & b & " ")
        For i = 1 To number
            temp = b
            b = a + b
            a = temp
            Console.Write(b & " ")

        Next
    End Sub
    Sub Tables(ByVal number)
        For i = 1 To 12
            Console.WriteLine(i & " x " & number & " = " & i * number)
        Next
    End Sub
    Sub Reverse(ByVal number)
        Dim x As Integer
        While number > 0
            x = number Mod 10
            Console.Write(x)
            number = number \ 10 'Use \ instead of / as \ is division for integers
        End While
        Console.WriteLine()
    End Sub
    Function Automorphic(ByRef number) As Boolean
        Dim isAuto As Boolean = vbFalse
        Dim x As Integer = number
        Dim i As Integer = 0
        While x > 0
            x = x / 10
            i = i + 1
        End While
        If (number ^ 2) Mod 10 ^ i = number Then
            isAuto = vbTrue
        End If
        Return isAuto
    End Function
End Module
