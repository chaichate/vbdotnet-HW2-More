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
        Me.grb3 = New System.Windows.Forms.CheckBox()
        Me.grb2 = New System.Windows.Forms.CheckBox()
        Me.grb1 = New System.Windows.Forms.CheckBox()
        Me.gb1 = New System.Windows.Forms.GroupBox()
        Me.chk3 = New System.Windows.Forms.CheckBox()
        Me.chk2 = New System.Windows.Forms.CheckBox()
        Me.chk1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.gb1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(265, 242)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(175, 242)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 5
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.grb3)
        Me.GroupBox1.Controls.Add(Me.grb2)
        Me.GroupBox1.Controls.Add(Me.grb1)
        Me.GroupBox1.Location = New System.Drawing.Point(265, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 148)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "อาหารอีสาน"
        '
        'grb3
        '
        Me.grb3.AutoSize = True
        Me.grb3.Location = New System.Drawing.Point(16, 80)
        Me.grb3.Name = "grb3"
        Me.grb3.Size = New System.Drawing.Size(107, 17)
        Me.grb3.TabIndex = 0
        Me.grb3.Text = "คอหมูย่าง 50 บาท"
        Me.grb3.UseVisualStyleBackColor = True
        '
        'grb2
        '
        Me.grb2.AutoSize = True
        Me.grb2.Location = New System.Drawing.Point(16, 57)
        Me.grb2.Name = "grb2"
        Me.grb2.Size = New System.Drawing.Size(108, 17)
        Me.grb2.TabIndex = 0
        Me.grb2.Text = "ส้มตำไทย 20 บาท"
        Me.grb2.UseVisualStyleBackColor = True
        '
        'grb1
        '
        Me.grb1.AutoSize = True
        Me.grb1.Location = New System.Drawing.Point(16, 34)
        Me.grb1.Name = "grb1"
        Me.grb1.Size = New System.Drawing.Size(73, 17)
        Me.grb1.TabIndex = 0
        Me.grb1.Text = "ส้มตำปู 20"
        Me.grb1.UseVisualStyleBackColor = True
        '
        'gb1
        '
        Me.gb1.Controls.Add(Me.chk3)
        Me.gb1.Controls.Add(Me.chk2)
        Me.gb1.Controls.Add(Me.chk1)
        Me.gb1.Location = New System.Drawing.Point(50, 60)
        Me.gb1.Name = "gb1"
        Me.gb1.Size = New System.Drawing.Size(200, 148)
        Me.gb1.TabIndex = 3
        Me.gb1.TabStop = False
        Me.gb1.Text = "อาหารจานด่วน"
        '
        'chk3
        '
        Me.chk3.AutoSize = True
        Me.chk3.Location = New System.Drawing.Point(16, 80)
        Me.chk3.Name = "chk3"
        Me.chk3.Size = New System.Drawing.Size(114, 17)
        Me.chk3.TabIndex = 0
        Me.chk3.Text = "ข้าวหมูแดง 25 บาท"
        Me.chk3.UseVisualStyleBackColor = True
        '
        'chk2
        '
        Me.chk2.AutoSize = True
        Me.chk2.Location = New System.Drawing.Point(16, 57)
        Me.chk2.Name = "chk2"
        Me.chk2.Size = New System.Drawing.Size(112, 17)
        Me.chk2.TabIndex = 0
        Me.chk2.Text = "ข้าวต้มปลา 25 บาท"
        Me.chk2.UseVisualStyleBackColor = True
        '
        'chk1
        '
        Me.chk1.AutoSize = True
        Me.chk1.Location = New System.Drawing.Point(16, 34)
        Me.chk1.Name = "chk1"
        Me.chk1.Size = New System.Drawing.Size(124, 17)
        Me.chk1.TabIndex = 0
        Me.chk1.Text = "ราดหน้าทะเล 35 บาท"
        Me.chk1.UseVisualStyleBackColor = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 346)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gb1)
        Me.Name = "Form4"
        Me.Text = "ร้านอาหาร"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gb1.ResumeLayout(False)
        Me.gb1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents grb3 As CheckBox
    Friend WithEvents grb2 As CheckBox
    Friend WithEvents grb1 As CheckBox
    Friend WithEvents gb1 As GroupBox
    Friend WithEvents chk3 As CheckBox
    Friend WithEvents chk2 As CheckBox
    Friend WithEvents chk1 As CheckBox
End Class
