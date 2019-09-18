Option Strict On
Option Explicit On
Public Class ExampleForm
    Private Sub RunButton_Click(sender As Object, e As EventArgs) Handles RunButton.Click
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim errorMessage As String
        errorMessage = ""

        'validate user input in reverse tabstop order. first tab stop with an error will be left selected.
        Try
            'try somthing that might throw an exception
            secondNumber = Integer.Parse(TextBox2.Text)
        Catch anyException As Exception
            'Exception thrown so do stuff
            errorMessage = errorMessage & "Please enter an number in the second text box" & vbNewLine
            TextBox2.Select()
            TextBox2.Clear()
        End Try

        Try
            'try somthing that might throw an exception
            firstNumber = Integer.Parse(TextBox1.Text)
        Catch anyException As Exception
            'Exception thrown so do stuff
            errorMessage = errorMessage & "Please enter an number in the first text box" & vbNewLine
            TextBox1.Select()
            TextBox1.Clear()
        End Try

        If errorMessage <> "" Then
            MessageBox.Show(errorMessage, "We Have Problem")
        End If

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
