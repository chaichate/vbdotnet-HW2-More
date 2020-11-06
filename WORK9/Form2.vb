Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbScale.Items.Add("แบบ A (ผ่าน/ไม่ผ่าน)")
        cmbScale.Items.Add("แบบ B (ระบบดับคะแนน A B C D E)")
    End Sub

    Private Function evaluateType_A() As String
        If txtScore.Text >= 50 And txtScore.Text <= 100 Then
            Return "สอบผ่าน"
        ElseIf txtScore.Text >= 0 And txtScore.Text < 50 Then
            Return "สอบไม่ผ่าน"
        Else
            Return "ระบุุคะแนนไม่ถูกต้อง"
        End If
    End Function
    Private Function evaluateType_B() As String
        If txtScore.Text >= 0 And txtScore.Text < 50 Then
            Return "E"
        ElseIf txtScore.Text >= 50 And txtScore.Text < 60 Then
            Return "D"
        ElseIf txtScore.Text >= 60 And txtScore.Text < 70 Then
            Return "C"
        ElseIf txtScore.Text >= 70 And txtScore.Text < 80 Then
            Return "B"
        ElseIf txtScore.Text >= 80 And txtScore.Text <= 100 Then
            Return "A"
        Else
            Return "ระบุุคะแนนไม่ถูกต้อง"
        End If
    End Function
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If cmbScale.SelectedIndex = 0 Then
            lblResult.Text = evaluateType_A()
        Else
            lblResult.Text = evaluateType_B()
        End If
    End Sub
End Class