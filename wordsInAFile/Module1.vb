Module Module1

    Sub Main()
        Dim reader As IO.StreamReader
        Dim counter As Integer = 0
        Dim word, str As String
        Console.WriteLine("please enter word to find")
        word = Console.ReadLine()
        reader = New IO.StreamReader("words.txt")
        For i = 1 To 10
            str = reader.ReadLine()
            For j = 1 To str.Length - 3
                If word = Mid(str, j, word.Length) Then
                    Console.WriteLine(i & " " & j)
                    counter = counter + 1
                End If
            Next
        Next
        reader.Close()
        Console.WriteLine(word & " was found " & counter & " times")
        Console.ReadLine()
    End Sub
    ' Function SubStrings(ByRef subStr, ByRef mainStr) As Integer
    'Dim frequency As Integer = 0
    'For i = 1 To mainStr.length - subStr.length
    'If subStr = Mid(mainStr, i, subStr.length) Then
    '           frequency = frequency + 1
    'End If
    'Next
    'Return frequency
    'End Function

End Module
