Option Explicit On
Option Strict On

Public Class UnserInputForm
    Private Sub GetInputButton_Click(sender As Object, e As EventArgs) Handles GetInputButton.Click
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim resultNumber As Integer

        secondNumber = 7

        'firstNumber = Convert.ToInt32(NumberTextBox.Text)



        Try
            Console.WriteLine("In the Try code")
            firstNumber = Integer.Parse(NumberTextBox.Text)
        Catch ex As Exception
            Console.WriteLine("In the Catch code")
            Console.WriteLine(ex.Message)
            NumberTextBox.Text = ""
            MsgBox("Please Enter A Valid Number")
            NumberTextBox.Select()
        Finally
            Console.WriteLine("In the Finaly code")
        End Try


        resultNumber = firstNumber + secondNumber
        Console.WriteLine(resultNumber)

    End Sub

End Class
