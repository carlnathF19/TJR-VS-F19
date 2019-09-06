Option Explicit On
Public Class FridayForm



    Private Sub DoStuffButton_Click(sender As Object, e As EventArgs) Handles DoStuffButton.Click
        FridayExample() 'Call the FridayExample sub
    End Sub
    Sub FridayExample()
        Dim statementOne As String
        Dim statementTwo As String
        Dim statementThree As String
        'Dim currentString As String
        Dim rndNumber As Integer

        Dim randomNumberExample As New Random 'instantiate new Random number object

        statementOne = "The greatest wisdom ever is..." '& vbNewLine & "stuff on next line"
        statementTwo = "The second mouse gets the cheese"
        statementThree = "Don't spit into the wind"

        'For i = 0 To 1000
        '    rndNumber = randomNumberExample.Next(1, 4)
        '    Console.WriteLine("The current i is: " & Str(i) & "    " & "The random number is: " & Str(rndNumber))
        'Next


        'currentString = "Other info"

        rndNumber = randomNumberExample.Next(1, 4)
        If rndNumber = 1 Then
            Console.WriteLine(statementOne)
        ElseIf rndNumber = 2 Then
            Console.WriteLine(statementTwo)
        ElseIf rndNumber = 3 Then
            Console.WriteLine(statementThree)
        Else
            Console.WriteLine("I got nothin'")
        End If

        'Console.ReadLine()

    End Sub

End Class
