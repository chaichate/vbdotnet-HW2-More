Public Class Form1

    Dim PricePerMin As Integer

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim amountUse As Double = txt1.Text

        txt2.Text = amountUse * PricePerMin



    End Sub

    Private Sub rb1_CheckedChanged(sender As Object, e As EventArgs) Handles rb1.CheckedChanged
        PricePerMin = 1

    End Sub

    Private Sub rb2_CheckedChanged(sender As Object, e As EventArgs) Handles rb2.CheckedChanged

        PricePerMin = 2

    End Sub

    Private Sub rb3_CheckedChanged(sender As Object, e As EventArgs) Handles rb3.CheckedChanged

        PricePerMin = 5

    End Sub
End Class
