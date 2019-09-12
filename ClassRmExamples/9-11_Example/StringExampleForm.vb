'Tim Rossiter
'RCET0265
'Example
'String Form Example Program
'Repo url here


Public Class StringExampleForm
    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        'concatinate first and last name then display properly
        DisplayLabel.Text = FirstNameTextBox.Text & " " & LastNamtTextBox.Text
        BigString()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        DisplayLabel.Text = ""
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Sub BigString()
        Dim longString As String
        longString =
             " " & "This is a very long string..." & vbNewLine _
            & " " & "This is a very long string..." & vbNewLine _
            & " " & "This is a very long string..." & vbNewLine _
            & " " & "This is a very long string..." & vbNewLine _
            & " " & "This is a very long string..." & vbNewLine _
            & " " & "This is a very long string..." & vbNewLine _
            & " " & "This is a very long string..." & vbNewLine _
            & " " & "This is a very long string..." & vbNewLine _
            & " " & "This is a very long string..." & vbNewLine _
            & " " & "This is a very long string..." & vbNewLine _
            & " " & "This is a very long string..."
        Console.WriteLine(longString)

    End Sub


End Class
