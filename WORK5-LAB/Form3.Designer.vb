<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSoftware
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
        Me.gb1 = New System.Windows.Forms.GroupBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.chkWord = New System.Windows.Forms.CheckBox()
        Me.chkExcel = New System.Windows.Forms.CheckBox()
        Me.chkPowerpoint = New System.Windows.Forms.CheckBox()
        Me.chkAccess = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkPHP = New System.Windows.Forms.CheckBox()
        Me.chlJava = New System.Windows.Forms.CheckBox()
        Me.chkVB = New System.Windows.Forms.CheckBox()
        Me.chkC = New System.Windows.Forms.CheckBox()
        Me.gb1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb1
        '
        Me.gb1.Controls.Add(Me.chkAccess)
        Me.gb1.Controls.Add(Me.chkPowerpoint)
        Me.gb1.Controls.Add(Me.chkExcel)
        Me.gb1.Controls.Add(Me.chkWord)
        Me.gb1.Location = New System.Drawing.Point(23, 33)
        Me.gb1.Name = "gb1"
        Me.gb1.Size = New System.Drawing.Size(200, 148)
        Me.gb1.TabIndex = 0
        Me.gb1.TabStop = False
        Me.gb1.Text = "คุณถนัดใช้โปรแกรมใด"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(148, 215)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(238, 215)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'chkWord
        '
        Me.chkWord.AutoSize = True
        Me.chkWord.Location = New System.Drawing.Point(16, 34)
        Me.chkWord.Name = "chkWord"
        Me.chkWord.Size = New System.Drawing.Size(98, 17)
        Me.chkWord.TabIndex = 0
        Me.chkWord.Text = "Microsoft Word"
        Me.chkWord.UseVisualStyleBackColor = True
        '
        'chkExcel
        '
        Me.chkExcel.AutoSize = True
        Me.chkExcel.Location = New System.Drawing.Point(16, 57)
        Me.chkExcel.Name = "chkExcel"
        Me.chkExcel.Size = New System.Drawing.Size(98, 17)
        Me.chkExcel.TabIndex = 0
        Me.chkExcel.Text = "Microsoft Excel"
        Me.chkExcel.UseVisualStyleBackColor = True
        '
        'chkPowerpoint
        '
        Me.chkPowerpoint.AutoSize = True
        Me.chkPowerpoint.Location = New System.Drawing.Point(16, 80)
        Me.chkPowerpoint.Name = "chkPowerpoint"
        Me.chkPowerpoint.Size = New System.Drawing.Size(129, 17)
        Me.chkPowerpoint.TabIndex = 0
        Me.chkPowerpoint.Text = "Microsoft Power Point"
        Me.chkPowerpoint.UseVisualStyleBackColor = True
        '
        'chkAccess
        '
        Me.chkAccess.AutoSize = True
        Me.chkAccess.Location = New System.Drawing.Point(16, 103)
        Me.chkAccess.Name = "chkAccess"
        Me.chkAccess.Size = New System.Drawing.Size(107, 17)
        Me.chkAccess.TabIndex = 0
        Me.chkAccess.Text = "Microsoft Access"
        Me.chkAccess.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkPHP)
        Me.GroupBox1.Controls.Add(Me.chlJava)
        Me.GroupBox1.Controls.Add(Me.chkVB)
        Me.GroupBox1.Controls.Add(Me.chkC)
        Me.GroupBox1.Location = New System.Drawing.Point(238, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 148)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "คุณถนัดใช้โปรแกรมใด"
        '
        'chkPHP
        '
        Me.chkPHP.AutoSize = True
        Me.chkPHP.Location = New System.Drawing.Point(16, 103)
        Me.chkPHP.Name = "chkPHP"
        Me.chkPHP.Size = New System.Drawing.Size(48, 17)
        Me.chkPHP.TabIndex = 0
        Me.chkPHP.Text = "PHP"
        Me.chkPHP.UseVisualStyleBackColor = True
        '
        'chlJava
        '
        Me.chlJava.AutoSize = True
        Me.chlJava.Location = New System.Drawing.Point(16, 80)
        Me.chlJava.Name = "chlJava"
        Me.chlJava.Size = New System.Drawing.Size(49, 17)
        Me.chlJava.TabIndex = 0
        Me.chlJava.Text = "Java"
        Me.chlJava.UseVisualStyleBackColor = True
        '
        'chkVB
        '
        Me.chkVB.AutoSize = True
        Me.chkVB.Location = New System.Drawing.Point(16, 57)
        Me.chkVB.Name = "chkVB"
        Me.chkVB.Size = New System.Drawing.Size(83, 17)
        Me.chkVB.TabIndex = 0
        Me.chkVB.Text = "Visual Basic"
        Me.chkVB.UseVisualStyleBackColor = True
        '
        'chkC
        '
        Me.chkC.AutoSize = True
        Me.chkC.Location = New System.Drawing.Point(16, 34)
        Me.chkC.Name = "chkC"
        Me.chkC.Size = New System.Drawing.Size(57, 17)
        Me.chkC.TabIndex = 0
        Me.chkC.Text = "C/C++"
        Me.chkC.UseVisualStyleBackColor = True
        '
        'frmSoftware
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(468, 296)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gb1)
        Me.Name = "frmSoftware"
        Me.Text = "Software"
        Me.gb1.ResumeLayout(False)
        Me.gb1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gb1 As GroupBox
    Friend WithEvents chkAccess As CheckBox
    Friend WithEvents chkPowerpoint As CheckBox
    Friend WithEvents chkExcel As CheckBox
    Friend WithEvents chkWord As CheckBox
    Friend WithEvents btnOK As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkPHP As CheckBox
    Friend WithEvents chlJava As CheckBox
    Friend WithEvents chkVB As CheckBox
    Friend WithEvents chkC As CheckBox
End Class
