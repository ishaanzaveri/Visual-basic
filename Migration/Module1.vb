Module Module1

    Sub Main()
        Dim CurPop() As Double = {2, 3.2, 4}
        Dim CurPopMig() As Double = {2, 3.2, 4}
        Dim Data(,) As Double = {{0.1, 0.3, 0.2},
                                   {0.3, 0.5, 0.2},
                                   {0.2, 0.2, 0.9}}
        For z = 1 To 10
            For i = 0 To 2
                CurPopMig(i) = Data(i, i) * CurPop(i) + CurPop(i)
                For j = 0 To 2
                    If i <> j Then
                        CurPopMig(i) = CurPop(i) - Data(i, j) * CurPop(i) + Data(j, i) * CurPop(i)
                    End If
                Next
            Next
            For i = 0 To 2
                CurPop(i) = CurPopMig(i)
            Next
        Next

        For i = 0 To 2
            Console.Write(CurPopMig(i) & " ")
        Next
        Console.ReadLine()
    End Sub

End Module
