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
        Me.txtScore = New System.Windows.Forms.TextBox()
        Me.lblGrad = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnGrad = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtScore
        '
        Me.txtScore.Location = New System.Drawing.Point(130, 67)
        Me.txtScore.Name = "txtScore"
        Me.txtScore.Size = New System.Drawing.Size(100, 20)
        Me.txtScore.TabIndex = 8
        '
        'lblGrad
        '
        Me.lblGrad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGrad.Location = New System.Drawing.Point(128, 113)
        Me.lblGrad.Name = "lblGrad"
        Me.lblGrad.Size = New System.Drawing.Size(103, 21)
        Me.lblGrad.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "เกรด"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "คะแนน"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(166, 182)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnGrad
        '
        Me.btnGrad.Location = New System.Drawing.Point(71, 182)
        Me.btnGrad.Name = "btnGrad"
        Me.btnGrad.Size = New System.Drawing.Size(75, 23)
        Me.btnGrad.TabIndex = 4
        Me.btnGrad.Text = "ตัดเกรด"
        Me.btnGrad.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(278, 272)
        Me.Controls.Add(Me.txtScore)
        Me.Controls.Add(Me.lblGrad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnGrad)
        Me.Name = "Form2"
        Me.Text = "โปรแกรมตัดเกรด"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtScore As TextBox
    Friend WithEvents lblGrad As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnGrad As Button
End Class
