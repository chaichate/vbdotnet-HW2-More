<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoS4 = New System.Windows.Forms.RadioButton()
        Me.rdoS3 = New System.Windows.Forms.RadioButton()
        Me.rdoS1 = New System.Windows.Forms.RadioButton()
        Me.rdoS2 = New System.Windows.Forms.RadioButton()
        Me.gb1 = New System.Windows.Forms.GroupBox()
        Me.rdoC4 = New System.Windows.Forms.RadioButton()
        Me.rdoC3 = New System.Windows.Forms.RadioButton()
        Me.rrdoC2 = New System.Windows.Forms.RadioButton()
        Me.rdoC1 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.gb1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(241, 287)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(151, 287)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 17
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoS4)
        Me.GroupBox1.Controls.Add(Me.rdoS3)
        Me.GroupBox1.Controls.Add(Me.rdoS1)
        Me.GroupBox1.Controls.Add(Me.rdoS2)
        Me.GroupBox1.Location = New System.Drawing.Point(241, 90)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 154)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "รายการโทรทัศน์"
        '
        'rdoS4
        '
        Me.rdoS4.AutoSize = True
        Me.rdoS4.Location = New System.Drawing.Point(17, 103)
        Me.rdoS4.Name = "rdoS4"
        Me.rdoS4.Size = New System.Drawing.Size(58, 17)
        Me.rdoS4.TabIndex = 0
        Me.rdoS4.TabStop = True
        Me.rdoS4.Text = "การ์ตูน"
        Me.rdoS4.UseVisualStyleBackColor = True
        '
        'rdoS3
        '
        Me.rdoS3.AutoSize = True
        Me.rdoS3.Location = New System.Drawing.Point(17, 75)
        Me.rdoS3.Name = "rdoS3"
        Me.rdoS3.Size = New System.Drawing.Size(56, 17)
        Me.rdoS3.TabIndex = 0
        Me.rdoS3.TabStop = True
        Me.rdoS3.Text = "สารคดี"
        Me.rdoS3.UseVisualStyleBackColor = True
        '
        'rdoS1
        '
        Me.rdoS1.AutoSize = True
        Me.rdoS1.Location = New System.Drawing.Point(17, 20)
        Me.rdoS1.Name = "rdoS1"
        Me.rdoS1.Size = New System.Drawing.Size(49, 17)
        Me.rdoS1.TabIndex = 0
        Me.rdoS1.TabStop = True
        Me.rdoS1.Text = "ละคร"
        Me.rdoS1.UseVisualStyleBackColor = True
        '
        'rdoS2
        '
        Me.rdoS2.AutoSize = True
        Me.rdoS2.Location = New System.Drawing.Point(17, 48)
        Me.rdoS2.Name = "rdoS2"
        Me.rdoS2.Size = New System.Drawing.Size(68, 17)
        Me.rdoS2.TabIndex = 0
        Me.rdoS2.TabStop = True
        Me.rdoS2.Text = "เกมส์โชว์"
        Me.rdoS2.UseVisualStyleBackColor = True
        '
        'gb1
        '
        Me.gb1.Controls.Add(Me.rdoC4)
        Me.gb1.Controls.Add(Me.rdoC3)
        Me.gb1.Controls.Add(Me.rrdoC2)
        Me.gb1.Controls.Add(Me.rdoC1)
        Me.gb1.Location = New System.Drawing.Point(26, 90)
        Me.gb1.Name = "gb1"
        Me.gb1.Size = New System.Drawing.Size(200, 154)
        Me.gb1.TabIndex = 15
        Me.gb1.TabStop = False
        Me.gb1.Text = "สถานีโทรทัศน์"
        '
        'rdoC4
        '
        Me.rdoC4.AutoSize = True
        Me.rdoC4.Location = New System.Drawing.Point(18, 103)
        Me.rdoC4.Name = "rdoC4"
        Me.rdoC4.Size = New System.Drawing.Size(52, 17)
        Me.rdoC4.TabIndex = 0
        Me.rdoC4.TabStop = True
        Me.rdoC4.Text = "ช่อง 9"
        Me.rdoC4.UseVisualStyleBackColor = True
        '
        'rdoC3
        '
        Me.rdoC3.AutoSize = True
        Me.rdoC3.Location = New System.Drawing.Point(18, 75)
        Me.rdoC3.Name = "rdoC3"
        Me.rdoC3.Size = New System.Drawing.Size(52, 17)
        Me.rdoC3.TabIndex = 0
        Me.rdoC3.TabStop = True
        Me.rdoC3.Text = "ช่อง 7"
        Me.rdoC3.UseVisualStyleBackColor = True
        '
        'rrdoC2
        '
        Me.rrdoC2.AutoSize = True
        Me.rrdoC2.Location = New System.Drawing.Point(18, 48)
        Me.rrdoC2.Name = "rrdoC2"
        Me.rrdoC2.Size = New System.Drawing.Size(52, 17)
        Me.rrdoC2.TabIndex = 0
        Me.rrdoC2.TabStop = True
        Me.rrdoC2.Text = "ช่อง 5"
        Me.rrdoC2.UseVisualStyleBackColor = True
        '
        'rdoC1
        '
        Me.rdoC1.AutoSize = True
        Me.rdoC1.Location = New System.Drawing.Point(18, 20)
        Me.rdoC1.Name = "rdoC1"
        Me.rdoC1.Size = New System.Drawing.Size(52, 17)
        Me.rdoC1.TabIndex = 0
        Me.rdoC1.TabStop = True
        Me.rdoC1.Text = "ช่อง 3"
        Me.rdoC1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(26, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(415, 61)
        Me.Label1.TabIndex = 18
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 324)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gb1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gb1.ResumeLayout(False)
        Me.gb1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdoS3 As RadioButton
    Friend WithEvents rdoS1 As RadioButton
    Friend WithEvents rdoS2 As RadioButton
    Friend WithEvents gb1 As GroupBox
    Friend WithEvents rdoC3 As RadioButton
    Friend WithEvents rrdoC2 As RadioButton
    Friend WithEvents rdoC1 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents rdoC4 As RadioButton
    Friend WithEvents rdoS4 As RadioButton
End Class
