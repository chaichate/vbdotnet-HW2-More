Public Class Form1
    Private Sub btnGrad_Click(sender As Object, e As EventArgs) Handles btnGrad.Click
        Dim score As Integer
        score = txtScore.Text


        If score > 100 Or score < 0 Then
            lblGrad.Text = "ERROR"
        ElseIf score >= 80 Then
            lblGrad.Text = "Good"
        ElseIf score > 60 Then
            lblGrad.Text = "Pass"
        Else
            lblGrad.Text = "Fail"
        End If

    End Sub
End Class
