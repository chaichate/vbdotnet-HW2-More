<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnWaning = New System.Windows.Forms.Button()
        Me.btnQuestion = New System.Windows.Forms.Button()
        Me.btnError = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnWaning
        '
        Me.btnWaning.Location = New System.Drawing.Point(139, 52)
        Me.btnWaning.Name = "btnWaning"
        Me.btnWaning.Size = New System.Drawing.Size(75, 23)
        Me.btnWaning.TabIndex = 0
        Me.btnWaning.Text = "Waning"
        Me.btnWaning.UseVisualStyleBackColor = True
        '
        'btnQuestion
        '
        Me.btnQuestion.Location = New System.Drawing.Point(139, 113)
        Me.btnQuestion.Name = "btnQuestion"
        Me.btnQuestion.Size = New System.Drawing.Size(75, 23)
        Me.btnQuestion.TabIndex = 0
        Me.btnQuestion.Text = "Question"
        Me.btnQuestion.UseVisualStyleBackColor = True
        '
        'btnError
        '
        Me.btnError.Location = New System.Drawing.Point(139, 176)
        Me.btnError.Name = "btnError"
        Me.btnError.Size = New System.Drawing.Size(75, 23)
        Me.btnError.TabIndex = 0
        Me.btnError.Text = "Question"
        Me.btnError.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(138, 235)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 311)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnError)
        Me.Controls.Add(Me.btnQuestion)
        Me.Controls.Add(Me.btnWaning)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnWaning As Button
    Friend WithEvents btnQuestion As Button
    Friend WithEvents btnError As Button
    Friend WithEvents btnExit As Button
End Class
