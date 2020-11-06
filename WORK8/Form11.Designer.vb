<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTabControl
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
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.mtbPhone = New System.Windows.Forms.MaskedTextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.dtpBirthday = New System.Windows.Forms.DateTimePicker()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtBranch = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radf6 = New System.Windows.Forms.RadioButton()
        Me.radf5 = New System.Windows.Forms.RadioButton()
        Me.radf4 = New System.Windows.Forms.RadioButton()
        Me.radf3 = New System.Windows.Forms.RadioButton()
        Me.radf2 = New System.Windows.Forms.RadioButton()
        Me.radf1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rad3 = New System.Windows.Forms.RadioButton()
        Me.rad2 = New System.Windows.Forms.RadioButton()
        Me.rad1 = New System.Windows.Forms.RadioButton()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMoral = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.tabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabControl1
        '
        Me.tabControl1.Controls.Add(Me.TabPage1)
        Me.tabControl1.Controls.Add(Me.TabPage2)
        Me.tabControl1.Controls.Add(Me.TabPage3)
        Me.tabControl1.Location = New System.Drawing.Point(12, 12)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(406, 313)
        Me.tabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.mtbPhone)
        Me.TabPage1.Controls.Add(Me.txtAddress)
        Me.TabPage1.Controls.Add(Me.dtpBirthday)
        Me.TabPage1.Controls.Add(Me.txtName)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(398, 287)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "ข้อมูลส่วนตัว"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'mtbPhone
        '
        Me.mtbPhone.Location = New System.Drawing.Point(91, 242)
        Me.mtbPhone.Mask = "0-000-0000"
        Me.mtbPhone.Name = "mtbPhone"
        Me.mtbPhone.Size = New System.Drawing.Size(100, 20)
        Me.mtbPhone.TabIndex = 4
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(91, 124)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtAddress.Size = New System.Drawing.Size(200, 91)
        Me.txtAddress.TabIndex = 3
        '
        'dtpBirthday
        '
        Me.dtpBirthday.Location = New System.Drawing.Point(91, 77)
        Me.dtpBirthday.Name = "dtpBirthday"
        Me.dtpBirthday.Size = New System.Drawing.Size(200, 20)
        Me.dtpBirthday.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(91, 31)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(2, 245)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "เบอร์โทรศัพท์"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ที่อยู่"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "วันเดือนปีเกิด"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ชื่อ-นามสกุล"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(398, 287)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "การศึกษา"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtBranch)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 224)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(363, 57)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "สาขา"
        '
        'txtBranch
        '
        Me.txtBranch.Location = New System.Drawing.Point(11, 20)
        Me.txtBranch.Name = "txtBranch"
        Me.txtBranch.Size = New System.Drawing.Size(335, 20)
        Me.txtBranch.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radf6)
        Me.GroupBox2.Controls.Add(Me.radf5)
        Me.GroupBox2.Controls.Add(Me.radf4)
        Me.GroupBox2.Controls.Add(Me.radf3)
        Me.GroupBox2.Controls.Add(Me.radf2)
        Me.GroupBox2.Controls.Add(Me.radf1)
        Me.GroupBox2.Location = New System.Drawing.Point(179, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 185)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "คณะ"
        '
        'radf6
        '
        Me.radf6.AutoSize = True
        Me.radf6.Location = New System.Drawing.Point(21, 134)
        Me.radf6.Name = "radf6"
        Me.radf6.Size = New System.Drawing.Size(114, 17)
        Me.radf6.TabIndex = 0
        Me.radf6.TabStop = True
        Me.radf6.Text = "รัฐประศาสนศาสตร์"
        Me.radf6.UseVisualStyleBackColor = True
        '
        'radf5
        '
        Me.radf5.AutoSize = True
        Me.radf5.Location = New System.Drawing.Point(21, 111)
        Me.radf5.Name = "radf5"
        Me.radf5.Size = New System.Drawing.Size(72, 17)
        Me.radf5.TabIndex = 0
        Me.radf5.TabStop = True
        Me.radf5.Text = "นิติศาสตร์"
        Me.radf5.UseVisualStyleBackColor = True
        '
        'radf4
        '
        Me.radf4.AutoSize = True
        Me.radf4.Location = New System.Drawing.Point(21, 88)
        Me.radf4.Name = "radf4"
        Me.radf4.Size = New System.Drawing.Size(78, 17)
        Me.radf4.TabIndex = 0
        Me.radf4.TabStop = True
        Me.radf4.Text = "ศิลปศาสตร์"
        Me.radf4.UseVisualStyleBackColor = True
        '
        'radf3
        '
        Me.radf3.AutoSize = True
        Me.radf3.Location = New System.Drawing.Point(21, 65)
        Me.radf3.Name = "radf3"
        Me.radf3.Size = New System.Drawing.Size(70, 17)
        Me.radf3.TabIndex = 0
        Me.radf3.TabStop = True
        Me.radf3.Text = "คุรุศาสตร์"
        Me.radf3.UseVisualStyleBackColor = True
        '
        'radf2
        '
        Me.radf2.AutoSize = True
        Me.radf2.Location = New System.Drawing.Point(21, 42)
        Me.radf2.Name = "radf2"
        Me.radf2.Size = New System.Drawing.Size(81, 17)
        Me.radf2.TabIndex = 0
        Me.radf2.TabStop = True
        Me.radf2.Text = "บริหารธุรกิจ"
        Me.radf2.UseVisualStyleBackColor = True
        '
        'radf1
        '
        Me.radf1.AutoSize = True
        Me.radf1.Location = New System.Drawing.Point(21, 18)
        Me.radf1.Name = "radf1"
        Me.radf1.Size = New System.Drawing.Size(74, 17)
        Me.radf1.TabIndex = 0
        Me.radf1.TabStop = True
        Me.radf1.Text = "วิทยาสาตร์"
        Me.radf1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rad3)
        Me.GroupBox1.Controls.Add(Me.rad2)
        Me.GroupBox1.Controls.Add(Me.rad1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(153, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "วุฒการศึกษาสูงสุด"
        '
        'rad3
        '
        Me.rad3.AutoSize = True
        Me.rad3.Location = New System.Drawing.Point(23, 65)
        Me.rad3.Name = "rad3"
        Me.rad3.Size = New System.Drawing.Size(70, 17)
        Me.rad3.TabIndex = 0
        Me.rad3.TabStop = True
        Me.rad3.Text = "ปริญาเอก"
        Me.rad3.UseVisualStyleBackColor = True
        '
        'rad2
        '
        Me.rad2.AutoSize = True
        Me.rad2.Location = New System.Drawing.Point(23, 42)
        Me.rad2.Name = "rad2"
        Me.rad2.Size = New System.Drawing.Size(64, 17)
        Me.rad2.TabIndex = 0
        Me.rad2.TabStop = True
        Me.rad2.Text = "ปริญาโท"
        Me.rad2.UseVisualStyleBackColor = True
        '
        'rad1
        '
        Me.rad1.AutoSize = True
        Me.rad1.Location = New System.Drawing.Point(23, 19)
        Me.rad1.Name = "rad1"
        Me.rad1.Size = New System.Drawing.Size(65, 17)
        Me.rad1.TabIndex = 0
        Me.rad1.TabStop = True
        Me.rad1.Text = "ปริญาตรี"
        Me.rad1.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Controls.Add(Me.txtMoral)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(398, 287)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "คติเตือนใจ"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "คติเตือนใจ"
        '
        'txtMoral
        '
        Me.txtMoral.Location = New System.Drawing.Point(24, 42)
        Me.txtMoral.Multiline = True
        Me.txtMoral.Name = "txtMoral"
        Me.txtMoral.Size = New System.Drawing.Size(350, 227)
        Me.txtMoral.TabIndex = 0
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(12, 346)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 1
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(339, 346)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmTabControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 380)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.tabControl1)
        Me.Name = "frmTabControl"
        Me.Text = "กํารใช้งําน TabControl"
        Me.tabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents btnOK As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents mtbPhone As MaskedTextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents dtpBirthday As DateTimePicker
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMoral As TextBox
    Friend WithEvents rad3 As RadioButton
    Friend WithEvents rad2 As RadioButton
    Friend WithEvents rad1 As RadioButton
    Friend WithEvents txtBranch As TextBox
    Friend WithEvents radf6 As RadioButton
    Friend WithEvents radf5 As RadioButton
    Friend WithEvents radf4 As RadioButton
    Friend WithEvents radf3 As RadioButton
    Friend WithEvents radf2 As RadioButton
    Friend WithEvents radf1 As RadioButton
End Class
