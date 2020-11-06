Public Class Form5
    Private Sub Calculate(ByVal x As Single, ByVal y As Single)
        lblsum.Text = x + y
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim i, j As Single
        i = txtNum1.Text
        j = txtNum2.Text
        Calculate(i, j)
    End Sub
End Class