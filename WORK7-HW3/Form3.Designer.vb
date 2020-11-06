<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.rdoD3 = New System.Windows.Forms.RadioButton()
        Me.rdoD1 = New System.Windows.Forms.RadioButton()
        Me.rdoD2 = New System.Windows.Forms.RadioButton()
        Me.gb1 = New System.Windows.Forms.GroupBox()
        Me.rdoF3 = New System.Windows.Forms.RadioButton()
        Me.rdoF2 = New System.Windows.Forms.RadioButton()
        Me.rdoF1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.gb1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(268, 168)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(178, 168)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 13
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoD3)
        Me.GroupBox1.Controls.Add(Me.rdoD1)
        Me.GroupBox1.Controls.Add(Me.rdoD2)
        Me.GroupBox1.Location = New System.Drawing.Point(268, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 117)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "เครื่องดิม"
        '
        'rdoD3
        '
        Me.rdoD3.AutoSize = True
        Me.rdoD3.Location = New System.Drawing.Point(17, 75)
        Me.rdoD3.Name = "rdoD3"
        Me.rdoD3.Size = New System.Drawing.Size(93, 17)
        Me.rdoD3.TabIndex = 0
        Me.rdoD3.TabStop = True
        Me.rdoD3.Text = "น้ำปล่า 10 บาท"
        Me.rdoD3.UseVisualStyleBackColor = True
        '
        'rdoD1
        '
        Me.rdoD1.AutoSize = True
        Me.rdoD1.Location = New System.Drawing.Point(17, 20)
        Me.rdoD1.Name = "rdoD1"
        Me.rdoD1.Size = New System.Drawing.Size(90, 17)
        Me.rdoD1.TabIndex = 0
        Me.rdoD1.TabStop = True
        Me.rdoD1.Text = "กาแฟ 35 บาท"
        Me.rdoD1.UseVisualStyleBackColor = True
        '
        'rdoD2
        '
        Me.rdoD2.AutoSize = True
        Me.rdoD2.Location = New System.Drawing.Point(17, 48)
        Me.rdoD2.Name = "rdoD2"
        Me.rdoD2.Size = New System.Drawing.Size(101, 17)
        Me.rdoD2.TabIndex = 0
        Me.rdoD2.TabStop = True
        Me.rdoD2.Text = "น้ำอัดลม 20 บาท"
        Me.rdoD2.UseVisualStyleBackColor = True
        '
        'gb1
        '
        Me.gb1.Controls.Add(Me.rdoF3)
        Me.gb1.Controls.Add(Me.rdoF2)
        Me.gb1.Controls.Add(Me.rdoF1)
        Me.gb1.Location = New System.Drawing.Point(53, 25)
        Me.gb1.Name = "gb1"
        Me.gb1.Size = New System.Drawing.Size(200, 117)
        Me.gb1.TabIndex = 11
        Me.gb1.TabStop = False
        Me.gb1.Text = "อาหาร"
        '
        'rdoF3
        '
        Me.rdoF3.AutoSize = True
        Me.rdoF3.Location = New System.Drawing.Point(18, 75)
        Me.rdoF3.Name = "rdoF3"
        Me.rdoF3.Size = New System.Drawing.Size(107, 17)
        Me.rdoF3.TabIndex = 0
        Me.rdoF3.TabStop = True
        Me.rdoF3.Text = "ข้าวมันไก่ 25 บาท"
        Me.rdoF3.UseVisualStyleBackColor = True
        '
        'rdoF2
        '
        Me.rdoF2.AutoSize = True
        Me.rdoF2.Location = New System.Drawing.Point(18, 48)
        Me.rdoF2.Name = "rdoF2"
        Me.rdoF2.Size = New System.Drawing.Size(100, 17)
        Me.rdoF2.TabIndex = 0
        Me.rdoF2.TabStop = True
        Me.rdoF2.Text = "ข้าวผัดปู 35 บาท"
        Me.rdoF2.UseVisualStyleBackColor = True
        '
        'rdoF1
        '
        Me.rdoF1.AutoSize = True
        Me.rdoF1.Location = New System.Drawing.Point(18, 20)
        Me.rdoF1.Name = "rdoF1"
        Me.rdoF1.Size = New System.Drawing.Size(100, 17)
        Me.rdoF1.TabIndex = 0
        Me.rdoF1.TabStop = True
        Me.rdoF1.Text = "ราดหน้า 25 บาท"
        Me.rdoF1.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(515, 211)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gb1)
        Me.Name = "Form3"
        Me.Text = "Food & Drink"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gb1.ResumeLayout(False)
        Me.gb1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents gb1 As GroupBox
    Friend WithEvents rdoF3 As RadioButton
    Friend WithEvents rdoF2 As RadioButton
    Friend WithEvents rdoF1 As RadioButton
    Friend WithEvents rdoD3 As RadioButton
    Friend WithEvents rdoD1 As RadioButton
    Friend WithEvents rdoD2 As RadioButton
End Class
