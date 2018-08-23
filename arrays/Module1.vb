Module Module1

    Sub Main()
        Dim n As Integer
        Console.WriteLine("how long is your array")
        n = Console.ReadLine()
        Dim array(n) As Integer
        For i = 1 To n
            Console.ReadLine()
        Next
        Console.WriteLine("max = " & Max(array) & " min = " & Min(array) & " avg = " & Avg(array))
        Console.ReadLine()
    End Sub


    Function Max(ByVal array) As Integer
        Dim maxN As Integer
        maxN = array(1)
        For i = 2 To array.length() - 1
            If array(i) > maxN Then
                maxN = array(i)
            End If
        Next
        Return maxN
    End Function

    Function Min(ByVal array) As Integer
        Dim minN As Integer
        minN = array(1)
        For i = 2 To array.length - 1
            If array(i) < minN Then
                minN = array(i)
            End If
        Next
        Return minN
    End Function
    Function Avg(ByVal array) As Integer
        Dim sum As Integer = 0
        For i = 1 To array.length - 1
            sum = sum + array(i)
        Next
        Return sum / array.length
    End Function
End Module
