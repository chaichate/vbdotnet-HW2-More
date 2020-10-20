<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.radGray = New System.Windows.Forms.RadioButton()
        Me.radBlue = New System.Windows.Forms.RadioButton()
        Me.radGreen = New System.Windows.Forms.RadioButton()
        Me.radPink = New System.Windows.Forms.RadioButton()
        Me.radYellow = New System.Windows.Forms.RadioButton()
        Me.radOrange = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(144, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ปรัปแต่งพื้นหลังฟอร์ม"
        '
        'radGray
        '
        Me.radGray.AutoSize = True
        Me.radGray.Checked = True
        Me.radGray.Location = New System.Drawing.Point(60, 122)
        Me.radGray.Name = "radGray"
        Me.radGray.Size = New System.Drawing.Size(48, 17)
        Me.radGray.TabIndex = 1
        Me.radGray.TabStop = True
        Me.radGray.Text = "สีเทา"
        Me.radGray.UseVisualStyleBackColor = True
        '
        'radBlue
        '
        Me.radBlue.AutoSize = True
        Me.radBlue.Location = New System.Drawing.Point(60, 171)
        Me.radBlue.Name = "radBlue"
        Me.radBlue.Size = New System.Drawing.Size(62, 17)
        Me.radBlue.TabIndex = 2
        Me.radBlue.TabStop = True
        Me.radBlue.Text = "สีน้ำเงิน"
        Me.radBlue.UseVisualStyleBackColor = True
        '
        'radGreen
        '
        Me.radGreen.AutoSize = True
        Me.radGreen.Location = New System.Drawing.Point(60, 236)
        Me.radGreen.Name = "radGreen"
        Me.radGreen.Size = New System.Drawing.Size(55, 17)
        Me.radGreen.TabIndex = 3
        Me.radGreen.TabStop = True
        Me.radGreen.Text = "สีเขียว"
        Me.radGreen.UseVisualStyleBackColor = True
        '
        'radPink
        '
        Me.radPink.AutoSize = True
        Me.radPink.Location = New System.Drawing.Point(219, 122)
        Me.radPink.Name = "radPink"
        Me.radPink.Size = New System.Drawing.Size(53, 17)
        Me.radPink.TabIndex = 1
        Me.radPink.TabStop = True
        Me.radPink.Text = "สีชมพู"
        Me.radPink.UseVisualStyleBackColor = True
        '
        'radYellow
        '
        Me.radYellow.AutoSize = True
        Me.radYellow.Location = New System.Drawing.Point(219, 171)
        Me.radYellow.Name = "radYellow"
        Me.radYellow.Size = New System.Drawing.Size(60, 17)
        Me.radYellow.TabIndex = 2
        Me.radYellow.TabStop = True
        Me.radYellow.Text = "สีเหลือง"
        Me.radYellow.UseVisualStyleBackColor = True
        '
        'radOrange
        '
        Me.radOrange.AutoSize = True
        Me.radOrange.Location = New System.Drawing.Point(219, 236)
        Me.radOrange.Name = "radOrange"
        Me.radOrange.Size = New System.Drawing.Size(44, 17)
        Me.radOrange.TabIndex = 3
        Me.radOrange.TabStop = True
        Me.radOrange.Text = "สีส้ม"
        Me.radOrange.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 439)
        Me.Controls.Add(Me.radOrange)
        Me.Controls.Add(Me.radYellow)
        Me.Controls.Add(Me.radGreen)
        Me.Controls.Add(Me.radPink)
        Me.Controls.Add(Me.radBlue)
        Me.Controls.Add(Me.radGray)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "การใช้ RadioButton"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents radGray As RadioButton
    Friend WithEvents radBlue As RadioButton
    Friend WithEvents radGreen As RadioButton
    Friend WithEvents radPink As RadioButton
    Friend WithEvents radYellow As RadioButton
    Friend WithEvents radOrange As RadioButton
End Class
