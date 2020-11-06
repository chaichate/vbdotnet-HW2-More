Public Class Form3

    Public Sub CircleArea(ByVal r As Single)
        Dim cArea As Double
        cArea = 3.14 * r * r
        lblResult.Text = cArea
    End Sub
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        CircleArea(txtRaduis.Text)
    End Sub
End Class