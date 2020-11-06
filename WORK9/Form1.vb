Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbScale.Items.Add("แบบ A (ผ่าน/ไม่ผ่าน)")
        cmbScale.Items.Add("แบบ B (ระบบดับคะแนน A B C D E)")
    End Sub
    Private Sub evaluateType_A()
        If txtScore.Text >= 50 And txtScore.Text <= 100 Then
            lblResult.Text = "สอบผ่าน"
        ElseIf txtScore.Text >= 0 And txtScore.Text < 50 Then
            lblResult.Text = "สอบไม่ผ่าน"
        Else
            lblResult.Text = "ระบุุคะแนนไม่ถูกต้อง"
        End If
    End Sub
    Private Sub evaluateType_B()
        If txtScore.Text >= 0 And txtScore.Text < 50 Then
            lblResult.Text = "E"
        ElseIf txtScore.Text >= 50 And txtScore.Text < 60 Then
            lblResult.Text = "D"
        ElseIf txtScore.Text >= 60 And txtScore.Text < 70 Then
            lblResult.Text = "C"
        ElseIf txtScore.Text >= 70 And txtScore.Text < 80 Then
            lblResult.Text = "B"
        ElseIf txtScore.Text >= 80 And txtScore.Text <= 100 Then
            lblResult.Text = "A"
        Else
            lblResult.Text = "ระบุุคะแนนไม่ถูกต้อง"
        End If
    End Sub
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If cmbScale.SelectedIndex = 0 Then
            evaluateType_A()
        Else
            evaluateType_B()
        End If
    End Sub
End Class
