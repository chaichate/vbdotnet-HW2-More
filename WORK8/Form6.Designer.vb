<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComboBox
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
        Me.cboEdu = New System.Windows.Forms.ComboBox()
        Me.cboWork = New System.Windows.Forms.ComboBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboEdu
        '
        Me.cboEdu.FormattingEnabled = True
        Me.cboEdu.Location = New System.Drawing.Point(29, 30)
        Me.cboEdu.Name = "cboEdu"
        Me.cboEdu.Size = New System.Drawing.Size(121, 21)
        Me.cboEdu.TabIndex = 0
        '
        'cboWork
        '
        Me.cboWork.FormattingEnabled = True
        Me.cboWork.Location = New System.Drawing.Point(29, 86)
        Me.cboWork.Name = "cboWork"
        Me.cboWork.Size = New System.Drawing.Size(121, 21)
        Me.cboWork.TabIndex = 0
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(194, 27)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(194, 86)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmComboBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 135)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.cboWork)
        Me.Controls.Add(Me.cboEdu)
        Me.Name = "frmComboBox"
        Me.Text = "การใช้งาน ComboBox"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cboEdu As ComboBox
    Friend WithEvents cboWork As ComboBox
    Friend WithEvents btnOK As Button
    Friend WithEvents btnExit As Button
End Class
