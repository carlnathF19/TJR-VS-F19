Option Explicit On
Option Strict Off 'https://docs.microsoft.com/en-us/dotnet/visual-basic/language-reference/statements/option-strict-statement

Public Class DataConversionForm
    Private Sub RunButton_Click(sender As Object, e As EventArgs) Handles RunButton.Click
        ConvertStringToNumbers()
        'WhatDataType()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        FirstTextBox.Text = ""
        SecondTextBox.Text = ""
        ResultTextBox.Text = ""
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
    Sub ConvertStringToNumbers()
        Dim myData As String
        'Dim value As Integer

        myData = "34"

        Console.WriteLine("myData is: " & myData)
        Console.WriteLine("The data type of myData is " & myData.GetType().ToString)
        Console.WriteLine("Use Integer.Parse(myData) to convert myData from String to Int32")
        Console.WriteLine("myData as Int32 looks like: " & Integer.Parse(myData))
        Console.WriteLine("Now the data type of myData is " & Integer.Parse(myData).GetType().ToString)
        Console.WriteLine("Use Double.Parse(myData) to convert myData from String to a double floating point number")
        Console.WriteLine("myData as Double looks like: " & Double.Parse(myData))
        Console.WriteLine("Now the data type of myData is " & Double.Parse(myData).GetType().ToString)

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
