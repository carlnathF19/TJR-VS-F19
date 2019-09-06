<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataConversionForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.RunButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.FirstTextBox = New System.Windows.Forms.TextBox()
        Me.SecondTextBox = New System.Windows.Forms.TextBox()
        Me.ResultTextBox = New System.Windows.Forms.TextBox()
        Me.FirstLabel = New System.Windows.Forms.Label()
        Me.SecondLabel = New System.Windows.Forms.Label()
        Me.ResultLabel = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RunButton
        '
        Me.RunButton.Location = New System.Drawing.Point(56, 120)
        Me.RunButton.Name = "RunButton"
        Me.RunButton.Size = New System.Drawing.Size(88, 59)
        Me.RunButton.TabIndex = 0
        Me.RunButton.Text = "&Run"
        Me.RunButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(150, 120)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(88, 59)
        Me.ClearButton.TabIndex = 1
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'FirstTextBox
        '
        Me.FirstTextBox.Location = New System.Drawing.Point(56, 42)
        Me.FirstTextBox.Name = "FirstTextBox"
        Me.FirstTextBox.Size = New System.Drawing.Size(349, 20)
        Me.FirstTextBox.TabIndex = 2
        '
        'SecondTextBox
        '
        Me.SecondTextBox.Location = New System.Drawing.Point(56, 68)
        Me.SecondTextBox.Name = "SecondTextBox"
        Me.SecondTextBox.Size = New System.Drawing.Size(349, 20)
        Me.SecondTextBox.TabIndex = 3
        '
        'ResultTextBox
        '
        Me.ResultTextBox.Location = New System.Drawing.Point(56, 94)
        Me.ResultTextBox.Name = "ResultTextBox"
        Me.ResultTextBox.Size = New System.Drawing.Size(349, 20)
        Me.ResultTextBox.TabIndex = 4
        '
        'FirstLabel
        '
        Me.FirstLabel.AutoSize = True
        Me.FirstLabel.Location = New System.Drawing.Point(24, 45)
        Me.FirstLabel.Name = "FirstLabel"
        Me.FirstLabel.Size = New System.Drawing.Size(26, 13)
        Me.FirstLabel.TabIndex = 5
        Me.FirstLabel.Text = "First"
        '
        'SecondLabel
        '
        Me.SecondLabel.AutoSize = True
        Me.SecondLabel.Location = New System.Drawing.Point(6, 71)
        Me.SecondLabel.Name = "SecondLabel"
        Me.SecondLabel.Size = New System.Drawing.Size(44, 13)
        Me.SecondLabel.TabIndex = 6
        Me.SecondLabel.Text = "Second"
        '
        'ResultLabel
        '
        Me.ResultLabel.AutoSize = True
        Me.ResultLabel.Location = New System.Drawing.Point(13, 97)
        Me.ResultLabel.Name = "ResultLabel"
        Me.ResultLabel.Size = New System.Drawing.Size(37, 13)
        Me.ResultLabel.TabIndex = 7
        Me.ResultLabel.Text = "Result"
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(330, 120)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 59)
        Me.ExitButton.TabIndex = 8
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'DataConversionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 200)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ResultLabel)
        Me.Controls.Add(Me.SecondLabel)
        Me.Controls.Add(Me.FirstLabel)
        Me.Controls.Add(Me.ResultTextBox)
        Me.Controls.Add(Me.SecondTextBox)
        Me.Controls.Add(Me.FirstTextBox)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.RunButton)
        Me.Name = "DataConversionForm"
        Me.Text = "Testing Data Conversions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RunButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents FirstTextBox As TextBox
    Friend WithEvents SecondTextBox As TextBox
    Friend WithEvents ResultTextBox As TextBox
    Friend WithEvents FirstLabel As Label
    Friend WithEvents SecondLabel As Label
    Friend WithEvents ResultLabel As Label
    Friend WithEvents ExitButton As Button
End Class
