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
        Me.lst1 = New System.Windows.Forms.ListBox()
        Me.lbl = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lst1
        '
        Me.lst1.FormattingEnabled = True
        Me.lst1.Location = New System.Drawing.Point(65, 70)
        Me.lst1.Name = "lst1"
        Me.lst1.Size = New System.Drawing.Size(242, 316)
        Me.lst1.TabIndex = 0
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Location = New System.Drawing.Point(8, 21)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(56, 13)
        Me.lbl.TabIndex = 1
        Me.lbl.Text = "ใส่ข้อความ"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(232, 21)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "แสดงผล"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(70, 21)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(155, 20)
        Me.txtInput.TabIndex = 3
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 405)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.lst1)
        Me.Name = "Form2"
        Me.Text = "ฟังก์ชั่นเกี่ยวกับ String"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lst1 As ListBox
    Friend WithEvents lbl As Label
    Friend WithEvents btnOK As Button
    Friend WithEvents txtInput As TextBox
End Class
