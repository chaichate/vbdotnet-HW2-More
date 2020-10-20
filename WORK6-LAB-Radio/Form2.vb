Public Class frmSport

    Dim sport As String


    Function Showdialog(isChecked As Boolean)

        If isChecked = True Then
            MessageBox.Show("คุนชอบเล่นกีฬา " & sport, "ผลการสำรวจ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Function


    Private Sub radFootball_CheckedChanged(sender As Object, e As EventArgs) Handles radFootball.CheckedChanged
        sport = "ฟุตบอล"
        Showdialog(radFootball.Checked)
    End Sub

    Private Sub radSwim_CheckedChanged(sender As Object, e As EventArgs) Handles radSwim.CheckedChanged
        sport = "ว่ายน้ำ"
        Showdialog(radSwim.Checked)
    End Sub

    Private Sub radTennis_CheckedChanged(sender As Object, e As EventArgs) Handles radTennis.CheckedChanged
        sport = "เทนนิส"
        Showdialog(radTennis.Checked)

    End Sub

    Private Sub radTTennis_CheckedChanged(sender As Object, e As EventArgs) Handles radTTennis.CheckedChanged
        sport = "ปิงปอง"
        Showdialog(radTTennis.Checked)
    End Sub
End Class