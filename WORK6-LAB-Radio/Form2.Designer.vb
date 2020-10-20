<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSport
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radTTennis = New System.Windows.Forms.RadioButton()
        Me.radTennis = New System.Windows.Forms.RadioButton()
        Me.radSwim = New System.Windows.Forms.RadioButton()
        Me.radFootball = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radTTennis)
        Me.GroupBox1.Controls.Add(Me.radTennis)
        Me.GroupBox1.Controls.Add(Me.radSwim)
        Me.GroupBox1.Controls.Add(Me.radFootball)
        Me.GroupBox1.Location = New System.Drawing.Point(101, 98)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(282, 258)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "กีฬา"
        '
        'radTTennis
        '
        Me.radTTennis.AutoSize = True
        Me.radTTennis.Location = New System.Drawing.Point(37, 192)
        Me.radTTennis.Name = "radTTennis"
        Me.radTTennis.Size = New System.Drawing.Size(55, 17)
        Me.radTTennis.TabIndex = 0
        Me.radTTennis.Text = "ปิงปอง"
        Me.radTTennis.UseVisualStyleBackColor = True
        '
        'radTennis
        '
        Me.radTennis.AutoSize = True
        Me.radTennis.Location = New System.Drawing.Point(37, 135)
        Me.radTennis.Name = "radTennis"
        Me.radTennis.Size = New System.Drawing.Size(59, 17)
        Me.radTennis.TabIndex = 0
        Me.radTennis.Text = "เทนนิส"
        Me.radTennis.UseVisualStyleBackColor = True
        '
        'radSwim
        '
        Me.radSwim.AutoSize = True
        Me.radSwim.Location = New System.Drawing.Point(37, 81)
        Me.radSwim.Name = "radSwim"
        Me.radSwim.Size = New System.Drawing.Size(56, 17)
        Me.radSwim.TabIndex = 0
        Me.radSwim.Text = "ว่ายน้ำ"
        Me.radSwim.UseVisualStyleBackColor = True
        '
        'radFootball
        '
        Me.radFootball.AutoSize = True
        Me.radFootball.Checked = True
        Me.radFootball.Location = New System.Drawing.Point(37, 28)
        Me.radFootball.Name = "radFootball"
        Me.radFootball.Size = New System.Drawing.Size(59, 17)
        Me.radFootball.TabIndex = 0
        Me.radFootball.TabStop = True
        Me.radFootball.Text = "ฟุตบอล"
        Me.radFootball.UseVisualStyleBackColor = True
        '
        'frmSport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmSport"
        Me.Text = "งานอดิเรก"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radTTennis As RadioButton
    Friend WithEvents radSwim As RadioButton
    Friend WithEvents radFootball As RadioButton
    Friend WithEvents radTennis As RadioButton
End Class
