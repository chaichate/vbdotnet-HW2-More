Public Class Form5

    Dim discount As Double
    Dim disPer As Integer = 0
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        disPer = 10
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        disPer = 15
    End Sub
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        disPer = 20
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        Dim price As Double = txtInput.Text

        Dim discountPrice = disPer * price / 100

        MessageBox.Show("ตุณได้รับส่วนลด  " & discountPrice & vbCrLf & " ยอดชำระ  " & price - discountPrice)


    End Sub
End Class