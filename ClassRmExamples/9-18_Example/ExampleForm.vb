Option Strict On
Option Explicit On
Public Class ExampleForm
    Private Sub RunButton_Click(sender As Object, e As EventArgs) Handles RunButton.Click
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim result As Integer

        Dim errorMessage As String
        errorMessage = ""

        'LoadTestData() 'load sample data remove for production

        'validate user input in reverse tabstop order. first tab stop with an error will be left selected.
        Try
            'try somthing that might throw an exception
            secondNumber = Integer.Parse(TextBox2.Text)
        Catch anyException As FormatException
            'Exception thrown so do stuff
            errorMessage = errorMessage & "Please enter an number in the second text box" & vbNewLine
            TextBox2.Select()
            TextBox2.Clear()
        Catch ex As Exception 'handle unanticipated exceptions
            'Someting went wrong
            Console.WriteLine(ex.Message)
        End Try

        Try
            'try somthing that might throw an exception
            firstNumber = Integer.Parse(TextBox1.Text)
        Catch anyException As FormatException
            'Exception thrown so do stuff
            errorMessage = errorMessage & "Please enter an number in the first text box" & vbNewLine
            TextBox1.Select()
            TextBox1.Clear()
        Catch ex As Exception 'handle unanticipated exceptions
            'Someting went wrong
            Console.WriteLine(ex.Message)
        End Try

        If errorMessage <> "" Then
            MessageBox.Show(errorMessage, "We Have Problem")
        Else
            result = firstNumber + secondNumber
            TextBox3.Text = result.ToString("C")
        End If

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub LoadTestData()
        Static sample As Integer 'Static variables will fix this

        'By defualt sample will initialize to 0

        Select Case sample
            Case = 0
                TextBox1.Text = "5"
                TextBox2.Text = "6"
            Case = 1
                TextBox1.Text = "bad"
                TextBox2.Text = "6"
            Case = 2
                TextBox1.Text = "5"
                TextBox2.Text = "bad"
            Case = 3
                TextBox1.Text = "bad"
                TextBox2.Text = "bad"
            Case Else
                'some unexpected thing
        End Select

        If sample >= 3 Then
            sample = 0
        Else
            sample += 1
        End If

    End Sub

End Class
