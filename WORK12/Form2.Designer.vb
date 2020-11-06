<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.lst1 = New System.Windows.Forms.ListBox()
        Me.lst2 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lst1
        '
        Me.lst1.FormattingEnabled = True
        Me.lst1.Location = New System.Drawing.Point(29, 33)
        Me.lst1.Name = "lst1"
        Me.lst1.Size = New System.Drawing.Size(242, 316)
        Me.lst1.TabIndex = 5
        '
        'lst2
        '
        Me.lst2.FormattingEnabled = True
        Me.lst2.Location = New System.Drawing.Point(291, 33)
        Me.lst2.Name = "lst2"
        Me.lst2.Size = New System.Drawing.Size(242, 316)
        Me.lst2.TabIndex = 6
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 362)
        Me.Controls.Add(Me.lst2)
        Me.Controls.Add(Me.lst1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lst1 As ListBox
    Friend WithEvents lst2 As ListBox
End Class
