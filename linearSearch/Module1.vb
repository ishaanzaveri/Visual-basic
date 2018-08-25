Module Module1

    Sub Main()
        Dim array(50) As Integer
        Dim n, SearchNum As Integer
        Console.WriteLine("enter number of elements in array")
        n = Console.ReadLine()
        For i = 1 To n
            Console.WriteLine("Enter element " & i)
            array(i) = Console.ReadLine()
        Next
        Console.WriteLine("please enter term to search for ")
        SearchNum = Console.ReadLine()
        Console.WriteLine(SearchNum & " is present at element " & linSearch(array, n, SearchNum))
        Console.ReadLine()
    End Sub
    Function linSearch(ByRef array, ByRef n, ByRef searchNum) As Integer
        Dim element As Integer = -1
        For i = 1 To n
            If searchNum = array(i) Then
                element = i
            End If
        Next
        If element = -1 Then Return -1
        Return element
    End Function
End Module
