Module Module1

    Sub Main()
        Dim reader As IO.StreamReader
        Dim Line As String
        Dim number As Integer = 0

        reader = New IO.StreamReader("sentences.txt")
        Do While Not reader.EndOfStream
            Line = reader.ReadLine()
            number = words(Line) + number
        Loop
        reader.Close()
        Console.WriteLine(number & " words in file")
        Console.ReadLine()
    End Sub
    Function words(ByVal sentence As String) As Integer
        Dim number As Integer = 0
        For i = 1 To sentence.Length
            If Mid(sentence, i, 1) = " " Then
                number = number + 1
            End If
        Next
        number = number - 1
        Return number
    End Function
End Module
