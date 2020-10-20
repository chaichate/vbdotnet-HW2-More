Public Class Form8
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim kilomater As Integer = Integer.Parse(txtInput.Text)
        Dim tripprice As Integer


        If (kilomater > 5) Then
            tripprice = 5 * 1000
        Else
            tripprice = kilomater * 1000
        End If


        If (kilomater > 10) Then
            tripprice += 5 * 50

            tripprice += (kilomater - 10) * 40
        Else
            tripprice += (kilomater - 5) * 50
        End If

        txtShow.Text = tripprice

    End Sub
End Class