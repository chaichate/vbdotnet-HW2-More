<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Me.btnOpenInput = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnOpenInput
        '
        Me.btnOpenInput.Location = New System.Drawing.Point(87, 102)
        Me.btnOpenInput.Name = "btnOpenInput"
        Me.btnOpenInput.Size = New System.Drawing.Size(125, 36)
        Me.btnOpenInput.TabIndex = 0
        Me.btnOpenInput.Text = "ป้อนอายุ"
        Me.btnOpenInput.UseVisualStyleBackColor = True
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 297)
        Me.Controls.Add(Me.btnOpenInput)
        Me.Name = "Form9"
        Me.Text = "กรุณากดปุ่มป้อนอายุ"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnOpenInput As Button
End Class
