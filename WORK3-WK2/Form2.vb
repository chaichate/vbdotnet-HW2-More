Public Class Form2
    Private Sub btnGrad_Click(sender As Object, e As EventArgs) Handles btnGrad.Click
        Dim score As Integer
        score = txtScore.Text

        Select Case score
            Case 80 To 100
                lblGrad.Text = "Good"
            Case 60 To 79
                lblGrad.Text = "Pass"
            Case 0 To 59
                lblGrad.Text = "Fail"
            Case Else
                lblGrad.Text = "ERROR"
        End Select
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class