Public Class Form4
    Public Function CircleArea(ByVal r As Single) As Double
        Dim cArea As Double
        cArea = 3.14 * r * r
        Return cArea
    End Function
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        lblResult.Text = CircleArea(txtRaduis.Text)
    End Sub
End Class