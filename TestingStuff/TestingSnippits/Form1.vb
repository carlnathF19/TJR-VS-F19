Public Class Form1
    Private Sub MySub()
        Dim i As Integer
        For i = 0 To 100 Step 5
            Debug.Print(Str(i))
        Next

        Me.Text = "hello"
    End Sub

    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MySub()
    End Sub
End Class
