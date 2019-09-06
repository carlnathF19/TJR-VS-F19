<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FridayForm
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
        Me.DoStuffButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DoStuffButton
        '
        Me.DoStuffButton.Location = New System.Drawing.Point(213, 144)
        Me.DoStuffButton.Name = "DoStuffButton"
        Me.DoStuffButton.Size = New System.Drawing.Size(360, 165)
        Me.DoStuffButton.TabIndex = 0
        Me.DoStuffButton.Text = "Do Stuff"
        Me.DoStuffButton.UseVisualStyleBackColor = True
        '
        'FridayForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DoStuffButton)
        Me.Name = "FridayForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DoStuffButton As Button
End Class
