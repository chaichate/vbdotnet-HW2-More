Public Class Form3


    Private Sub txtInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtInput.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "-")
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim NumberInput As Integer = Integer.Parse(txtInput.Text)

        If (NumberInput > 0) Then
            txtShow.Text = "Positive"
        ElseIf (NumberInput < 0) Then
            txtShow.Text = "Negative Value"
        Else
            txtShow.Text = "Equal Zero"
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class