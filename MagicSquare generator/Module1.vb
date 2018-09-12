Module Module1

    Sub Main()
        Dim Array(5, 5) As Integer
        Dim i As Integer = 1
        Dim j As Integer = 3
        Array(i, j) = 1
        'Console.WriteLine("i j n")
        For k = 2 To 25
            If (i = 1 And j = 5) Then
                i = i + 1
            ElseIf j = 5 Then
                i = i - 1
                j = 1
            ElseIf i = 1 Then
                i = 5
                j = j + 1
                ' ElseIf Array(i, j) <> 0 Then
                '    i = i + 1
            Else
                i = i - 1
                j = j + 1
            End If
            If Array(i, j) <> 0 Then
                i = i + 2
                j = j - 1
            End If
            Array(i, j) = k
            'Console.WriteLine(i & " " & j & " " & Array(i, j))
        Next
        For i = 1 To 5
            For j = 1 To 5
                Console.Write(Array(i, j) & " ")
            Next
            Console.WriteLine()
        Next
        Console.ReadLine()
    End Sub

End Module
