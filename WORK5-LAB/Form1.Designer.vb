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
        Me.chkBold = New System.Windows.Forms.CheckBox()
        Me.chkItalic = New System.Windows.Forms.CheckBox()
        Me.chkUnderLine = New System.Windows.Forms.CheckBox()
        Me.ChkStrike = New System.Windows.Forms.CheckBox()
        Me.txtShow = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'chkBold
        '
        Me.chkBold.AutoSize = True
        Me.chkBold.Location = New System.Drawing.Point(36, 83)
        Me.chkBold.Name = "chkBold"
        Me.chkBold.Size = New System.Drawing.Size(59, 17)
        Me.chkBold.TabIndex = 0
        Me.chkBold.Text = "ตัวหนา"
        Me.chkBold.UseVisualStyleBackColor = True
        '
        'chkItalic
        '
        Me.chkItalic.AutoSize = True
        Me.chkItalic.Location = New System.Drawing.Point(36, 153)
        Me.chkItalic.Name = "chkItalic"
        Me.chkItalic.Size = New System.Drawing.Size(62, 17)
        Me.chkItalic.TabIndex = 1
        Me.chkItalic.Text = "ตัวเอียง"
        Me.chkItalic.UseVisualStyleBackColor = True
        '
        'chkUnderLine
        '
        Me.chkUnderLine.AutoSize = True
        Me.chkUnderLine.Location = New System.Drawing.Point(156, 83)
        Me.chkUnderLine.Name = "chkUnderLine"
        Me.chkUnderLine.Size = New System.Drawing.Size(84, 17)
        Me.chkUnderLine.TabIndex = 2
        Me.chkUnderLine.Text = "ตัวขีดเส้นใต้"
        Me.chkUnderLine.UseVisualStyleBackColor = True
        '
        'ChkStrike
        '
        Me.ChkStrike.AutoSize = True
        Me.ChkStrike.Location = New System.Drawing.Point(156, 153)
        Me.ChkStrike.Name = "ChkStrike"
        Me.ChkStrike.Size = New System.Drawing.Size(66, 17)
        Me.ChkStrike.TabIndex = 3
        Me.ChkStrike.Text = "ตัวขีดทับ"
        Me.ChkStrike.UseVisualStyleBackColor = True
        '
        'txtShow
        '
        Me.txtShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtShow.Location = New System.Drawing.Point(36, 30)
        Me.txtShow.Name = "txtShow"
        Me.txtShow.Size = New System.Drawing.Size(204, 32)
        Me.txtShow.TabIndex = 4
        Me.txtShow.Text = "Business Computer"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 225)
        Me.Controls.Add(Me.txtShow)
        Me.Controls.Add(Me.ChkStrike)
        Me.Controls.Add(Me.chkUnderLine)
        Me.Controls.Add(Me.chkItalic)
        Me.Controls.Add(Me.chkBold)
        Me.Name = "Form1"
        Me.Text = "ตัวอย่างการใช้ Checkbox"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkBold As CheckBox
    Friend WithEvents chkItalic As CheckBox
    Friend WithEvents chkUnderLine As CheckBox
    Friend WithEvents ChkStrike As CheckBox
    Friend WithEvents txtShow As TextBox
End Class
