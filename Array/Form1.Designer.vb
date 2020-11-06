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
        Me.lst1 = New System.Windows.Forms.ListBox()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lst1
        '
        Me.lst1.FormattingEnabled = True
        Me.lst1.Location = New System.Drawing.Point(24, 84)
        Me.lst1.Name = "lst1"
        Me.lst1.Size = New System.Drawing.Size(242, 316)
        Me.lst1.TabIndex = 5
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(24, 30)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(75, 23)
        Me.btnInput.TabIndex = 6
        Me.btnInput.Text = "ป้อนข้อมูล"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(191, 30)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 23)
        Me.btnShow.TabIndex = 6
        Me.btnShow.Text = "แสดงผล"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 450)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.btnInput)
        Me.Controls.Add(Me.lst1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lst1 As ListBox
    Friend WithEvents btnInput As Button
    Friend WithEvents btnShow As Button
End Class
