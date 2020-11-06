Public Class Form1
    Private Sub calculateVat()
        Dim vat As Double
        vat = Val(txtPrice.Text) * 0.07
        lblVat.Text = Format(vat, "0.00")
    End Sub
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        calculateVat()
    End Sub
End Class
