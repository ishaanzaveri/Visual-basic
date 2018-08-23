Module Module1

    Sub Main()
        Dim Str As String = "hello"
        Dim sentence As String = "Ishaan Zaveri is my name."
        Dim pani As String = "i"
        Dim ArrStr(Str.Length) As Char
        Dim temp As Char
        Console.WriteLine("number of chars = " & Str.Length)
        For i = 1 To Str.Length
            ArrStr(i) = Mid(Str, i, 1)
        Next
        For i = 1 To (Str.Length + 1) / 2
            temp = ArrStr(i)
            ArrStr(i) = ArrStr(Str.Length + 1 - i)
            ArrStr(Str.Length + 1 - i) = temp
        Next
        For i = 1 To Str.Length
            Console.Write(ArrStr(i))
        Next
        Console.WriteLine()
        Console.WriteLine("number of words in sentence = " & sentenceWords(sentence))
        Console.WriteLine(pani & " is a panidrome? " & Panidrome(pani))
        Console.WriteLine()
        Console.WriteLine("number of times " & pani & " appears in " & sentence & " " & SubStrings(pani, sentence) & " times")
        Console.ReadLine()
    End Sub
    Function sentenceWords(ByVal str) As Integer
        Dim words As Integer
        Dim spaces As Integer = 0
        For i = 1 To str.length
            If Mid(str, i, 1) = " " Then
                spaces = spaces + 1
            End If
        Next
        words = spaces + 1
        Return words
    End Function
    Function Panidrome(ByVal str) As Boolean
        Dim isPanidrome As Boolean = vbTrue
        For i = 1 To (str.length / 2) + 1
            If Mid(str, i, 1) <> Mid(str, str.length - i + 1, 1) Then
                isPanidrome = vbFalse
            End If
        Next
        Return isPanidrome
    End Function
    Function SubStrings(ByRef subStr, ByRef mainStr) As Integer
        Dim frequency As Integer = 0
        For i = 1 To mainStr.length - subStr.length
            If subStr = Mid(mainStr, i, subStr.length) Then
                frequency = frequency + 1
            End If
        Next
        Return frequency
    End Function
End Module
