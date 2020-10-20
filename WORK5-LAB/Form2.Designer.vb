<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOS
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
        Me.chkWin95 = New System.Windows.Forms.CheckBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.chkWin98 = New System.Windows.Forms.CheckBox()
        Me.chkWinVista = New System.Windows.Forms.CheckBox()
        Me.chkWinXP = New System.Windows.Forms.CheckBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'chkWin95
        '
        Me.chkWin95.AutoSize = True
        Me.chkWin95.Location = New System.Drawing.Point(37, 71)
        Me.chkWin95.Name = "chkWin95"
        Me.chkWin95.Size = New System.Drawing.Size(85, 17)
        Me.chkWin95.TabIndex = 0
        Me.chkWin95.Text = "Windows 95"
        Me.chkWin95.UseVisualStyleBackColor = True
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(37, 31)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(224, 13)
        Me.lbl1.TabIndex = 1
        Me.lbl1.Text = "เครื่องคอมพิวเตอร์ของคุณใช้ระบบปฏิบัติการใด"
        '
        'chkWin98
        '
        Me.chkWin98.AutoSize = True
        Me.chkWin98.Location = New System.Drawing.Point(37, 137)
        Me.chkWin98.Name = "chkWin98"
        Me.chkWin98.Size = New System.Drawing.Size(85, 17)
        Me.chkWin98.TabIndex = 0
        Me.chkWin98.Text = "Windows 98"
        Me.chkWin98.UseVisualStyleBackColor = True
        '
        'chkWinVista
        '
        Me.chkWinVista.AutoSize = True
        Me.chkWinVista.Location = New System.Drawing.Point(161, 137)
        Me.chkWinVista.Name = "chkWinVista"
        Me.chkWinVista.Size = New System.Drawing.Size(96, 17)
        Me.chkWinVista.TabIndex = 0
        Me.chkWinVista.Text = "Windows Vista"
        Me.chkWinVista.UseVisualStyleBackColor = True
        '
        'chkWinXP
        '
        Me.chkWinXP.AutoSize = True
        Me.chkWinXP.Location = New System.Drawing.Point(161, 71)
        Me.chkWinXP.Name = "chkWinXP"
        Me.chkWinXP.Size = New System.Drawing.Size(87, 17)
        Me.chkWinXP.TabIndex = 0
        Me.chkWinXP.Text = "Windows XP"
        Me.chkWinXP.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(66, 190)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(161, 190)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(307, 236)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.chkWinXP)
        Me.Controls.Add(Me.chkWinVista)
        Me.Controls.Add(Me.chkWin98)
        Me.Controls.Add(Me.chkWin95)
        Me.Name = "frmOS"
        Me.Text = "Operationg System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkWin95 As CheckBox
    Friend WithEvents lbl1 As Label
    Friend WithEvents chkWin98 As CheckBox
    Friend WithEvents chkWinVista As CheckBox
    Friend WithEvents chkWinXP As CheckBox
    Friend WithEvents btnOK As Button
    Friend WithEvents btnExit As Button
End Class
