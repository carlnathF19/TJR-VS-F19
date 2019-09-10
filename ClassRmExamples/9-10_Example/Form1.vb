Public Class Form1
    Private Sub RadioButton1To3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.Click, RadioButton2.Click, RadioButton3.Click

        If RadioButton1.Checked = True Then
            Console.WriteLine("Radio 1")
        ElseIf RadioButton2.Checked = True Then
            Console.WriteLine("Radio 2")
        ElseIf RadioButton3.Checked = True Then
            Console.WriteLine("Radio 3")
        End If

        'Button1.Enabled = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Button1.Enabled = False

        PictureBox2.Image = "Resources\kitten-report.jpg"
    End sub

End Class
