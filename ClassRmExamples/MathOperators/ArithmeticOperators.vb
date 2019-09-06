'see https://docs.microsoft.com/en-us/dotnet/visual-basic/language-reference/operators/arithmetic-operators'
'see https://docs.microsoft.com/en-us/dotnet/visual-basic/language-reference/operators/operators-listed-by-functionality'

Option Explicit On
Option Strict On

Module ArithmeticOperators
    Public Sub Main()
        Console.WriteLine("Let's do some math!")
        Console.ReadLine()
        AddNumbers()
        Console.ReadLine()
        SubtractNumbers()
        Console.ReadLine()
        MultiplyNumbers()
        Console.ReadLine()
        DivideNumbers()
        Console.ReadLine()
        ExponantOfNumber()
        Console.ReadLine()
    End Sub

    'see https://docs.microsoft.com/en-us/dotnet/visual-basic/language-reference/operators/addition-operator'
    Public Sub AddNumbers()
        Console.WriteLine("Adding 2 + 2")
        Console.WriteLine(2 + 2)
    End Sub

    'see https://docs.microsoft.com/en-us/dotnet/visual-basic/language-reference/operators/subtraction-operator'
    Public Sub SubtractNumbers()
        Console.WriteLine("Subtracting 6 - 4")
        Console.WriteLine(6 - 4)
    End Sub

    'see https://docs.microsoft.com/en-us/dotnet/visual-basic/language-reference/operators/multiplication-operator'
    Public Sub MultiplyNumbers()
        Console.WriteLine("3 x 4 is")
        Console.WriteLine(3 * 4)
    End Sub

    Public Sub DivideNumbers()
        'see https://docs.microsoft.com/en-us/dotnet/visual-basic/language-reference/operators/floating-point-division-operator
        Console.WriteLine("Floating Point Division")
        Console.WriteLine("20 / 6 is")
        Console.WriteLine(20 / 6)

        'see https://docs.microsoft.com/en-us/dotnet/visual-basic/language-reference/operators/integer-division-operator
        Console.WriteLine("Integer Division")
        Console.WriteLine("20 \ 6 is")
        Console.WriteLine(20 \ 6)

        'see: https://docs.microsoft.com/en-us/dotnet/visual-basic/language-reference/operators/mod-operator
        Console.WriteLine("Modulus gives only the remainder")
        Console.WriteLine("20 Mod 6 is")
        Console.WriteLine(20 Mod 6)
    End Sub

    'see https://docs.microsoft.com/en-us/dotnet/visual-basic/language-reference/operators/exponentiation-operator'
    Public Sub ExponantOfNumber()
        Console.WriteLine("5^2 is")
        Console.WriteLine(5 ^ 2)
    End Sub

End Module

