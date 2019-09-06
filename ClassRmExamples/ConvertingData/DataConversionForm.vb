Option Explicit On
Option Strict Off

Public Class DataConversionForm
    Sub ConvertStringToNumbers()
        Dim myNumber As String
        Dim value As Integer

        myNumber = "34"

        value = Integer.Parse(myNumber) 'hover over Parse and view help doc
    End Sub

    Sub WhatDataType()
        'x = "hello"
        'Console.WriteLine(x.GetType())

        Dim firstNum As Integer
        Dim secondNum As Integer
        Dim result As Double

        firstNum = 15
        secondNum = 7

        Console.WriteLine(Str(firstNum) & " is type " & firstNum.GetType.ToString())
        Console.WriteLine(Str(secondNum) & " is type " & secondNum.GetType.ToString())

        result = firstNum / secondNum
        Console.WriteLine("After ""/"" result = " & Str(result) & " and is type " & result.GetType.ToString())

        result = firstNum \ secondNum
        Console.WriteLine("After ""\"" result = " & Str(result) & " and is type " & result.GetType.ToString())
    End Sub

End Class
