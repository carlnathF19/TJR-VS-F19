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

        'Setting an image like this works but it is hard coded to the file location of the current system
        PictureBox2.Image = Image.FromFile("C:\Users\rosstimo\Documents\GitHub\TJR-VS-F19\ClassRmExamples\9-10_Example\Resources\kitten-report.jpg")

        'useing the resource manager allows the IDE to bundle all the resources with the application for deployment
        'learn more here: https://docs.microsoft.com/en-us/dotnet/visual-basic/language-reference/objects/my-resources-object
        PictureBox2.Image = My.Resources.kitten_report

    End sub

End Class
