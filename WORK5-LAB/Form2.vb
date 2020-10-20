Public Class frmOS

    Dim os As String
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        MessageBox.Show("คุณใช้ระบบปฏิบัติการ " & os, "ผลการเลือก")
    End Sub
    Function EbabledChkbox(sender As Object)
        If sender Is chkWin95 And DirectCast(sender, CheckBox).Checked = True Then
            os = "Windows 95"
            chkWin95.Enabled = True
            chkWin98.Enabled = False
            chkWinXP.Enabled = False
            chkWinVista.Enabled = False

        ElseIf sender Is chkWin98 And DirectCast(sender, CheckBox).Checked = True Then
            os = "Windows 98"
            chkWin95.Enabled = False
            chkWin98.Enabled = True
            chkWinXP.Enabled = False
            chkWinVista.Enabled = False

        ElseIf sender Is chkWinXP And DirectCast(sender, CheckBox).Checked = True Then
            os = "Windows XP"
            chkWin95.Enabled = False
            chkWin98.Enabled = False
            chkWinXP.Enabled = True
            chkWinVista.Enabled = False

        ElseIf sender Is chkWinVista And DirectCast(sender, CheckBox).Checked = True Then
            os = "Windows Vista"
            chkWin95.Enabled = False
            chkWin98.Enabled = False
            chkWinXP.Enabled = False
            chkWinVista.Enabled = True

        ElseIf DirectCast(sender, CheckBox).Checked = False Then
            os = ""
            chkWin95.Enabled = True
            chkWin98.Enabled = True
            chkWinXP.Enabled = True
            chkWinVista.Enabled = True
        End If
    End Function
    Private Sub chkWin95_CheckedChanged(sender As Object, e As EventArgs) Handles chkWin95.CheckedChanged
        EbabledChkbox(sender)
    End Sub

    Private Sub chkWinXP_CheckedChanged(sender As Object, e As EventArgs) Handles chkWinXP.CheckedChanged
        EbabledChkbox(sender)
    End Sub

    Private Sub chkWin98_CheckedChanged(sender As Object, e As EventArgs) Handles chkWin98.CheckedChanged
        EbabledChkbox(sender)
    End Sub

    Private Sub chkWinVista_CheckedChanged(sender As Object, e As EventArgs) Handles chkWinVista.CheckedChanged
        EbabledChkbox(sender)
    End Sub
End Class