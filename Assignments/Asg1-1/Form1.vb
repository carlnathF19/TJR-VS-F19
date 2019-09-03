'Assignment: Asg1-1
'RCET0265
'Tim Rossiter
'Hello World Program


Public Class Form1
    Private Sub UpdateTitle(sender As Object, e As EventArgs) Handles UpdateTitleButton.Click
        Me.Text = "My first windows form"
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub UpdateLabelButton_Click(sender As Object, e As EventArgs) Handles UpdateLabelButton.Click
        Me.DisplayLabel.Text = "Bonjour tout le monde"
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        DisplayLabel.Text = ""
    End Sub
End Class
