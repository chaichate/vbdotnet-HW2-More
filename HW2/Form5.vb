Public Class Form5
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click

        Dim charecter As String = txtInput.Text

        Select Case Asc(charecter)
            Case 65, 69, 73, 79, 85, 97, 101, 105, 111, 117
                txtShow.Text = "yes"
            Case Else
                txtShow.Text = "no"
        End Select


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class