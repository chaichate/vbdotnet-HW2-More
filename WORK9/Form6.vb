Public Class Form6

    Sub Mysub1(ByVal x As Integer)
        x = x + 10
    End Sub

    Sub Mysub2(ByRef x As Integer)
        x = x + 10
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim x As Integer
        x = 10
        Mysub1(x)
        lblByVal.Text = x

        Mysub2(x)
        lblByRef.Text = x
    End Sub
End Class