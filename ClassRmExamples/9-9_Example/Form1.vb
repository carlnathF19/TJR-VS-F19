Option Strict On
Option Explicit On
Public Class Form1
    Dim someOtherVariable As String

    Private Sub ActionButton_Click(sender As Object, e As EventArgs) Handles ActionButton.Click

    End Sub

    Sub methods()
        ExampleTextBox.Clear()
        TextBox1.Text = ""
        TextBox2.Select()
    End Sub

    Sub StringMath()
        Dim result As Integer
        result = 5 + Integer.Parse(ExampleTextBox.Text) 'convert string to Int32
        'result = "7"
        Console.WriteLine(result)
        'someOtherSub()
        'Console.WriteLine(result)
    End Sub
    Sub someOtherSub()
        Dim result As String
        result = "5"
        Console.WriteLine(result)
    End Sub

    Private Sub ActionButton_GotFocus(sender As Object, e As EventArgs) Handles ActionButton.GotFocus

    End Sub

    Private Sub TextBox1_MouseHover(sender As Object, e As EventArgs) Handles TextBox1.MouseHover

    End Sub

    Private Sub ToolTip1_Popup(sender As Object, e As PopupEventArgs)

    End Sub
End Class
