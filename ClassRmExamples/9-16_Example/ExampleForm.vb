Option Explicit On
Option Strict On
Public Class Form

    'PascalCase FirstLetterOfEachWordCapital no spaces
    'Objects

    'camelCase
    'variablesUseCamelCase

    'ALLCAPS
    'CONSTANTS

    'snake_case
    'used in python havn't seen in .NET

    Sub VariablesAndConstants()
        'Variables can be changed
        Dim someNumber As Integer
        Dim result As Integer

        'Constants can not change
        Const SOMECONSTANT = 7D

        someNumber = 5
        'Console.WriteLine(someNumber)
        'someNumber = 6
        'Console.WriteLine(someNumber)

        'result = someNumber + Convert.ToInt32(SOMECONSTANT)
        result = someNumber + CInt(SOMECONSTANT)


        Console.WriteLine()
    End Sub

    Private Sub RunButton_Click(sender As Object, e As EventArgs) Handles RunButton.Click
        VariablesAndConstants()
    End Sub
End Class
