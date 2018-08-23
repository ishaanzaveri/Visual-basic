Module Module1

    Sub Main()
        Dim n As Integer
        Dim array(30) As Integer
        Console.WriteLine("how long is your array")
        n = Console.ReadLine()
        For i = 1 To n
            array(i) = Console.ReadLine()
        Next
        Console.WriteLine("max = " & Max(array, n) & " min = " & Min(array, n) & " avg = " & Avg(array, n))
        Console.ReadLine()
    End Sub


    Function Max(ByVal array, ByVal n) As Integer
        Dim maxN As Integer
        maxN = array(1)
        For i = 2 To n
            If array(i) > maxN Then
                maxN = array(i)
            End If
        Next
        Return maxN
    End Function

    Function Min(ByVal array, ByVal n) As Integer
        Dim minN As Integer
        minN = array(1)
        For i = 2 To n
            If array(i) < minN Then
                minN = array(i)
            End If
        Next
        Return minN
    End Function
    Function Avg(ByVal array, ByVal n) As Integer
        Dim sum As Integer = 0
        For i = 1 To n
            sum = sum + array(i)
        Next
        Return sum / n
    End Function
End Module
