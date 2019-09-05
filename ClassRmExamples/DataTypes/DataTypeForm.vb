Option Strict Off
Public Class DataTypeForm
    Sub AssignString()
        ' Initialize the name variable to "Monday".
        Dim weekday As String
        Dim someCrazyString As String

        weekday = "Monday"
        'Console.WriteLine(weekday.Length())
    End Sub

    Sub Numbers()
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim result As Integer
        'Dim userInput As String

        firstNumber = Convert.ToDecimal(FirstNumberTextBox.Text)
        secondNumber = Convert.ToDecimal(SecondNumberTextBox.Text)
        result = firstNumber + secondNumber
        ResultTextBox.Text = result
        Console.WriteLine(result)


    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        AssignString()
        Numbers()
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub CalculateButton_Click(sender As Object, e As EventArgs) Handles CalculateButton.Click
        Numbers()
    End Sub
End Class
