Public Class Form1


    Private Sub radGray_CheckedChanged(sender As Object, e As EventArgs) Handles radGray.CheckedChanged
        Me.BackColor = Color.Gray
    End Sub

    Private Sub radBlue_CheckedChanged(sender As Object, e As EventArgs) Handles radBlue.CheckedChanged
        Me.BackColor = Color.Blue
    End Sub

    Private Sub radGreen_CheckedChanged(sender As Object, e As EventArgs) Handles radGreen.CheckedChanged
        Me.BackColor = Color.Green
    End Sub

    Private Sub radPink_CheckedChanged(sender As Object, e As EventArgs) Handles radPink.CheckedChanged
        Me.BackColor = Color.Pink
    End Sub

    Private Sub radYellow_CheckedChanged(sender As Object, e As EventArgs) Handles radYellow.CheckedChanged
        Me.BackColor = Color.Yellow
    End Sub

    Private Sub radOrange_CheckedChanged(sender As Object, e As EventArgs) Handles radOrange.CheckedChanged
        Me.BackColor = Color.Orange
    End Sub
End Class
