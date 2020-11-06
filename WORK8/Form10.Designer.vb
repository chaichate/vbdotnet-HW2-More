<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mtbPhone = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.mtbBirthDay = New System.Windows.Forms.MaskedTextBox()
        Me.mtbId = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mtbCar = New System.Windows.Forms.MaskedTextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โทรศัพท์พร้อมเบอร์ต่อ"
        '
        'mtbPhone
        '
        Me.mtbPhone.Location = New System.Drawing.Point(145, 28)
        Me.mtbPhone.Mask = "000-0000-000 Ext 9999"
        Me.mtbPhone.Name = "mtbPhone"
        Me.mtbPhone.Size = New System.Drawing.Size(223, 20)
        Me.mtbPhone.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(99, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "วันเกิด"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "รหัสประจำตัว  13 หลัก"
        '
        'mtbBirthDay
        '
        Me.mtbBirthDay.Location = New System.Drawing.Point(145, 86)
        Me.mtbBirthDay.Mask = "00/00/0000"
        Me.mtbBirthDay.Name = "mtbBirthDay"
        Me.mtbBirthDay.Size = New System.Drawing.Size(125, 20)
        Me.mtbBirthDay.TabIndex = 1
        Me.mtbBirthDay.ValidatingType = GetType(Date)
        '
        'mtbId
        '
        Me.mtbId.Location = New System.Drawing.Point(145, 145)
        Me.mtbId.Mask = "0 0000 00000 00 0"
        Me.mtbId.Name = "mtbId"
        Me.mtbId.Size = New System.Drawing.Size(223, 20)
        Me.mtbId.TabIndex = 1
        Me.mtbId.ValidatingType = GetType(Integer)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(58, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "ทะเบียนรถยนต์"
        '
        'mtbCar
        '
        Me.mtbCar.Location = New System.Drawing.Point(145, 201)
        Me.mtbCar.Mask = "LL-9990"
        Me.mtbCar.Name = "mtbCar"
        Me.mtbCar.Size = New System.Drawing.Size(223, 20)
        Me.mtbCar.TabIndex = 1
        Me.mtbCar.ValidatingType = GetType(Integer)
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(145, 246)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(245, 246)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 281)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.mtbCar)
        Me.Controls.Add(Me.mtbId)
        Me.Controls.Add(Me.mtbBirthDay)
        Me.Controls.Add(Me.mtbPhone)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form10"
        Me.Text = "การใช้ MaskedTextBox"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents mtbPhone As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents mtbBirthDay As MaskedTextBox
    Friend WithEvents mtbId As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents mtbCar As MaskedTextBox
    Friend WithEvents btnOK As Button
    Friend WithEvents btnClear As Button
End Class
