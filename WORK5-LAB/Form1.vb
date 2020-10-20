Public Class Form1


    Private Sub chkBold_CheckedChanged(sender As Object, e As EventArgs) Handles chkBold.CheckedChanged

        If chkBold.Checked = True Then
            txtShow.Font = New Font("", 16, FontStyle.Bold)
        Else
            txtShow.Font = New Font("", 16, FontStyle.Regular)
        End If
    End Sub

    Private Sub chkItalic_CheckedChanged(sender As Object, e As EventArgs) Handles chkItalic.CheckedChanged
        If sender.Checked = True Then
            txtShow.Font = New Font("", 16, FontStyle.Italic)
        Else
            txtShow.Font = New Font("", 16, FontStyle.Regular)
        End If
    End Sub

    Private Sub chkUnderLine_CheckedChanged(sender As Object, e As EventArgs) Handles chkUnderLine.CheckedChanged
        If sender.Checked = True Then
            txtShow.Font = New Font("", 16, FontStyle.Underline)
        Else
            txtShow.Font = New Font("", 16, FontStyle.Regular)
        End If
    End Sub

    Private Sub ChkStrike_CheckedChanged(sender As Object, e As EventArgs) Handles ChkStrike.CheckedChanged
        If sender.Checked = True Then
            txtShow.Font = New Font("", 16, FontStyle.Strikeout)
        Else
            txtShow.Font = New Font("", 16, FontStyle.Regular)
        End If
    End Sub
End Class

