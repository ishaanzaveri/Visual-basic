Module Module1

    Sub Main()
        Dim reader As IO.StreamReader
        Dim str As String
        Dim found As Boolean = False
        reader = New IO.StreamReader("names.txt")
        Console.WriteLine("enter names")
        str = Console.ReadLine()
        For i = 1 To 4945
            If str = reader.ReadLine() Then
                Console.WriteLine(i & ": Found")
                found = True
            End If
        Next
        If Not found Then
            Console.WriteLine("not there in list")
        End If
        reader.Close()
        Console.ReadLine()
    End Sub

End Module
