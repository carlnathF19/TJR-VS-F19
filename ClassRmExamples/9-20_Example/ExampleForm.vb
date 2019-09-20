Public Class ExampleForm


    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click
        RunLoop()
    End Sub

    Private Sub RunLoop()
        Dim i As Integer 'Loop counter: index, Column, row counter -- Whatever your looping on
        Dim j As Integer 'Nested Loop counter
        Dim outterLoopMax As Integer
        Dim innerLoopMax As Integer
        Dim outterStep As Integer
        Dim innerStep As Integer
        Dim loopStart As Integer

        outterLoopMax = 100
        innerLoopMax = 10
        loopStart = 0
        i = loopStart
        j = loopStart
        outterStep = 1
        innerStep = 1

        'from 1 to 100 increments of 1
        'i or loopcounter variable gets assigned by and incrimented by the loop structure
        For i = loopStart To outterLoopMax Step outterStep 'outter loop
            For j = loopStart To innerLoopMax Step innerStep 'inner loop
                Console.WriteLine("outter loop: i = " & Str(i) & "    " & "inner loop: j = " & Str(j))
            Next
        Next
    End Sub

    Sub HundredBoard()
        'TODO use loops to print 100 board
    End Sub


End Class
