<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListBox
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
        Me.lstFaculty = New System.Windows.Forms.ListBox()
        Me.lstPrograme = New System.Windows.Forms.ListBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstFaculty
        '
        Me.lstFaculty.FormattingEnabled = True
        Me.lstFaculty.Location = New System.Drawing.Point(17, 23)
        Me.lstFaculty.Name = "lstFaculty"
        Me.lstFaculty.Size = New System.Drawing.Size(163, 82)
        Me.lstFaculty.TabIndex = 0
        '
        'lstPrograme
        '
        Me.lstPrograme.FormattingEnabled = True
        Me.lstPrograme.Location = New System.Drawing.Point(198, 23)
        Me.lstPrograme.Name = "lstPrograme"
        Me.lstPrograme.Size = New System.Drawing.Size(177, 82)
        Me.lstPrograme.TabIndex = 0
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(17, 128)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(155, 128)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(275, 128)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmListBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(401, 176)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lstPrograme)
        Me.Controls.Add(Me.lstFaculty)
        Me.Name = "frmListBox"
        Me.Text = "ListBox"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstFaculty As ListBox
    Friend WithEvents lstPrograme As ListBox
    Friend WithEvents btnOK As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
