Module Module1

    Sub Main()
        Dim Mark As Integer
        'CONSOLE
        Console.Write("Hi I am Ishaan ") ' outputs text on screen 
        Console.BackgroundColor = ConsoleColor.Black ' Sets background color
        Console.ForegroundColor = ConsoleColor.Cyan ' sets foreground color
        Console.WriteLine("Hello World!") ' Outputs text on screen and then goes to next line
        Console.ReadLine() ' Takes an input 
        Console.Clear() 'Clears console 
        Console.SetCursorPosition(30, 11)
        Console.WriteLine(" This is freaking Awesome")
        ' Console.ReadLine()

        'VARIABLES
        Dim No As Integer = 2
        Dim Name As String = "Ishaan Zaveri"
        Dim Mass As Single = 12.3
        Dim num As Integer = 5
        Dim Overage As Boolean = vbYes
        'Console.WriteLine("Hello {0}, your number is {1}, your mass is {3} ", Name, No, Mass)

        'Array
        Dim Marks As Integer() = {1, 2, 3, 4, 5}
        Console.WriteLine(Marks)
        'Console.ReadLine()

        'For Loop
        For i = 0 To 10 Step 2
            Console.WriteLine(i)
        Next i

        For i = 1 To 10
            Console.Write(i)
            Console.Write(" ")
        Next

        'Constants 
        Const PI As Double = 3.14
        Console.WriteLine(PI)

        'Operators 
        Dim sum As Integer
        Dim minus As Integer
        Dim Div As Double
        Dim intDiv As Integer
        Dim mul As Integer
        Dim power As Integer
        ' Dim modnum As Double
        sum = No + num
        minus = No - num
        Div = No / num
        mul = No * num
        power = No ^ num
        'intDiv = No \ num
        'modnum =  No Mod num
        Console.WriteLine(power & " " & mul & " " & Div & " " & minus & " " & sum & " " & intDiv) ' to concatinate use the & symbol

        ' IF Statement

        If (1 + 1) = 2 Then
            Console.WriteLine("Hello Ishaan")
        End If

        Mark = 90
        If Mark < 30 Then
            Console.WriteLine("Fail")
        ElseIf Mark < 60 Then
            Console.WriteLine("D grade")
        ElseIf Mark < 80 Then
            Console.WriteLine("B grade")
        Else
            Console.WriteLine("A grade")
        End If
        Console.ReadLine()

        'String functions
        Dim Str As String = "I Study in grade 11"
        Console.WriteLine(Left(Str, 3))
        Console.WriteLine(Right(Str, 3))
        Console.WriteLine(Mid(Str, 3, 5))
        Console.WriteLine(Str.Length)

        Console.ReadLine()
    End Sub

End Module
