Public Class Form5

    Function Factorial(ByVal n As Integer) As Integer
        Dim f, i As Integer
        f = 1
        For i = 1 To n
            f = f * i
        Next

        Return f
    End Function
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        lblResult.Text = Factorial(Val(txtInput.Text))
    End Sub
End Class