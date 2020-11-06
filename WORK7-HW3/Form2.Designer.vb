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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkOS3 = New System.Windows.Forms.CheckBox()
        Me.chkOS2 = New System.Windows.Forms.CheckBox()
        Me.chkOS1 = New System.Windows.Forms.CheckBox()
        Me.gb1 = New System.Windows.Forms.GroupBox()
        Me.chkCPU3 = New System.Windows.Forms.CheckBox()
        Me.chkCPU2 = New System.Windows.Forms.CheckBox()
        Me.chkCPU1 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.gb1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(233, 290)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(143, 290)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 9
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkOS3)
        Me.GroupBox1.Controls.Add(Me.chkOS2)
        Me.GroupBox1.Controls.Add(Me.chkOS1)
        Me.GroupBox1.Location = New System.Drawing.Point(233, 108)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 117)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ระบบปฏิบัติการ"
        '
        'chkOS3
        '
        Me.chkOS3.AutoSize = True
        Me.chkOS3.Location = New System.Drawing.Point(16, 80)
        Me.chkOS3.Name = "chkOS3"
        Me.chkOS3.Size = New System.Drawing.Size(77, 17)
        Me.chkOS3.TabIndex = 0
        Me.chkOS3.Text = "Linux/Unix"
        Me.chkOS3.UseVisualStyleBackColor = True
        '
        'chkOS2
        '
        Me.chkOS2.AutoSize = True
        Me.chkOS2.Location = New System.Drawing.Point(16, 57)
        Me.chkOS2.Name = "chkOS2"
        Me.chkOS2.Size = New System.Drawing.Size(96, 17)
        Me.chkOS2.TabIndex = 0
        Me.chkOS2.Text = "Windows Vista"
        Me.chkOS2.UseVisualStyleBackColor = True
        '
        'chkOS1
        '
        Me.chkOS1.AutoSize = True
        Me.chkOS1.Location = New System.Drawing.Point(16, 34)
        Me.chkOS1.Name = "chkOS1"
        Me.chkOS1.Size = New System.Drawing.Size(87, 17)
        Me.chkOS1.TabIndex = 0
        Me.chkOS1.Text = "Windows XP"
        Me.chkOS1.UseVisualStyleBackColor = True
        '
        'gb1
        '
        Me.gb1.Controls.Add(Me.chkCPU3)
        Me.gb1.Controls.Add(Me.chkCPU2)
        Me.gb1.Controls.Add(Me.chkCPU1)
        Me.gb1.Location = New System.Drawing.Point(18, 108)
        Me.gb1.Name = "gb1"
        Me.gb1.Size = New System.Drawing.Size(200, 117)
        Me.gb1.TabIndex = 7
        Me.gb1.TabStop = False
        Me.gb1.Text = "CPU"
        '
        'chkCPU3
        '
        Me.chkCPU3.AutoSize = True
        Me.chkCPU3.Location = New System.Drawing.Point(16, 80)
        Me.chkCPU3.Name = "chkCPU3"
        Me.chkCPU3.Size = New System.Drawing.Size(80, 17)
        Me.chkCPU3.TabIndex = 0
        Me.chkCPU3.Text = "Core 2 Duo"
        Me.chkCPU3.UseVisualStyleBackColor = True
        '
        'chkCPU2
        '
        Me.chkCPU2.AutoSize = True
        Me.chkCPU2.Location = New System.Drawing.Point(16, 57)
        Me.chkCPU2.Name = "chkCPU2"
        Me.chkCPU2.Size = New System.Drawing.Size(77, 17)
        Me.chkCPU2.TabIndex = 0
        Me.chkCPU2.Text = "Pentium IV"
        Me.chkCPU2.UseVisualStyleBackColor = True
        '
        'chkCPU1
        '
        Me.chkCPU1.AutoSize = True
        Me.chkCPU1.Location = New System.Drawing.Point(16, 34)
        Me.chkCPU1.Name = "chkCPU1"
        Me.chkCPU1.Size = New System.Drawing.Size(62, 17)
        Me.chkCPU1.TabIndex = 0
        Me.chkCPU1.Text = "Celeron"
        Me.chkCPU1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(18, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(415, 68)
        Me.Label1.TabIndex = 10
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 322)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gb1)
        Me.Name = "Form2"
        Me.Text = "หน่วยประมวลผลกลางและระบบปฏิบัติการ"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gb1.ResumeLayout(False)
        Me.gb1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkOS3 As CheckBox
    Friend WithEvents chkOS2 As CheckBox
    Friend WithEvents chkOS1 As CheckBox
    Friend WithEvents gb1 As GroupBox
    Friend WithEvents chkCPU3 As CheckBox
    Friend WithEvents chkCPU2 As CheckBox
    Friend WithEvents chkCPU1 As CheckBox
    Friend WithEvents Label1 As Label
End Class
