Public Class Form2

    Private Sub calculate()

        Dim Num = Val(txtPrice.Text)

        If Num Mod 2 = 0 Then
            lblResult.Text = "เลขคู่"
        Else
            lblResult.Text = "เลขคี่"
        End If


    End Sub
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        calculate()
    End Sub
End Class