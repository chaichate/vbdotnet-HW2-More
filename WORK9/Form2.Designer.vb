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
        Me.btnOK = New System.Windows.Forms.Button()
        Me.cmbScale = New System.Windows.Forms.ComboBox()
        Me.txtScore = New System.Windows.Forms.TextBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.ผลการประเมิน = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(339, 67)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 10
        Me.btnOK.Text = "ประมวลผล"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'cmbScale
        '
        Me.cmbScale.FormattingEnabled = True
        Me.cmbScale.Location = New System.Drawing.Point(144, 69)
        Me.cmbScale.Name = "cmbScale"
        Me.cmbScale.Size = New System.Drawing.Size(175, 21)
        Me.cmbScale.TabIndex = 9
        '
        'txtScore
        '
        Me.txtScore.Location = New System.Drawing.Point(144, 20)
        Me.txtScore.Name = "txtScore"
        Me.txtScore.Size = New System.Drawing.Size(175, 20)
        Me.txtScore.TabIndex = 8
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(148, 117)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(10, 13)
        Me.lblResult.TabIndex = 4
        Me.lblResult.Text = "-"
        '
        'ผลการประเมิน
        '
        Me.ผลการประเมิน.AutoSize = True
        Me.ผลการประเมิน.Location = New System.Drawing.Point(12, 117)
        Me.ผลการประเมิน.Name = "ผลการประเมิน"
        Me.ผลการประเมิน.Size = New System.Drawing.Size(126, 13)
        Me.ผลการประเมิน.TabIndex = 5
        Me.ผลการประเมิน.Text = "เกณฑ์ในการประมเมินผล"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "เกณฑ์ในการประมเมินผล"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "คะแนนสอบ"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 144)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.cmbScale)
        Me.Controls.Add(Me.txtScore)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.ผลการประเมิน)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "ตัดเกรด"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOK As Button
    Friend WithEvents cmbScale As ComboBox
    Friend WithEvents txtScore As TextBox
    Friend WithEvents lblResult As Label
    Friend WithEvents ผลการประเมิน As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
