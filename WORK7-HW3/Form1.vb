Public Class Form1
    Dim north As String
    Dim south As String
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        MessageBox.Show("ถ้าคุณไปภาคเหนือคุณจะไป " & north & vbCrLf & "ถ้าคุณไปภาคใต้คุณจะไป  " & south, "ผลการเลือก")
    End Sub
    Function EnabledNorthChkbox(sender As Object)
        If sender Is chkN1 And DirectCast(sender, CheckBox).Checked = True Then
            north = "ดอยสุเทพ"
            chkN1.Enabled = True
            chkN2.Enabled = False
            chkN3.Enabled = False
            chkN4.Enabled = False

        ElseIf sender Is chkN2 And DirectCast(sender, CheckBox).Checked = True Then
            north = "ดอยสุเทพ"
            chkN1.Enabled = False
            chkN2.Enabled = True
            chkN3.Enabled = False
            chkN4.Enabled = False

        ElseIf sender Is chkN3 And DirectCast(sender, CheckBox).Checked = True Then
            north = "ดอยอินทนนท์"
            chkN1.Enabled = False
            chkN2.Enabled = False
            chkN3.Enabled = True
            chkN4.Enabled = False

        ElseIf sender Is chkN4 And DirectCast(sender, CheckBox).Checked = True Then
            north = "ดอยแม่สลอง"
            chkN1.Enabled = False
            chkN2.Enabled = False
            chkN3.Enabled = False
            chkN4.Enabled = True

        ElseIf DirectCast(sender, CheckBox).Checked = False Then
            north = ""
            chkN1.Enabled = True
            chkN2.Enabled = True
            chkN3.Enabled = True
            chkN4.Enabled = True
        End If

    End Function
    Function EnabledSouthChkbox(sender As Object)
        If sender Is chkW1 And DirectCast(sender, CheckBox).Checked = True Then
            south = "เกาะพีพี"
            chkW1.Enabled = True
            chkW2.Enabled = False
            chkW3.Enabled = False
            chkW4.Enabled = False

        ElseIf sender Is chkW2 And DirectCast(sender, CheckBox).Checked = True Then
            south = "เกาะลันตา"
            chkW1.Enabled = False
            chkW2.Enabled = True
            chkW3.Enabled = False
            chkW4.Enabled = False

        ElseIf sender Is chkW3 And DirectCast(sender, CheckBox).Checked = True Then
            south = "เกาะพงัน"
            chkW1.Enabled = False
            chkW2.Enabled = False
            chkW3.Enabled = True
            chkW4.Enabled = False

        ElseIf sender Is chkW4 And DirectCast(sender, CheckBox).Checked = True Then
            south = "เกาะสมัย"
            chkW1.Enabled = False
            chkW2.Enabled = False
            chkW3.Enabled = False
            chkW4.Enabled = True

        ElseIf DirectCast(sender, CheckBox).Checked = False Then
            south = ""
            chkW1.Enabled = True
            chkW2.Enabled = True
            chkW3.Enabled = True
            chkW4.Enabled = True
        End If

    End Function

    Private Sub chkN1_CheckedChanged(sender As Object, e As EventArgs) Handles chkN1.CheckedChanged
        EnabledNorthChkbox(sender)
    End Sub
    Private Sub chkN2_CheckedChanged(sender As Object, e As EventArgs) Handles chkN2.CheckedChanged
        EnabledNorthChkbox(sender)
    End Sub
    Private Sub chkN3_CheckedChanged(sender As Object, e As EventArgs) Handles chkN3.CheckedChanged
        EnabledNorthChkbox(sender)
    End Sub
    Private Sub chkN4_CheckedChanged(sender As Object, e As EventArgs) Handles chkN4.CheckedChanged
        EnabledNorthChkbox(sender)
    End Sub

    Private Sub chkW1_CheckedChanged(sender As Object, e As EventArgs) Handles chkW1.CheckedChanged
        EnabledSouthChkbox(sender)
    End Sub

    Private Sub chkW2_CheckedChanged(sender As Object, e As EventArgs) Handles chkW2.CheckedChanged
        EnabledSouthChkbox(sender)
    End Sub

    Private Sub chkW3_CheckedChanged(sender As Object, e As EventArgs) Handles chkW3.CheckedChanged
        EnabledSouthChkbox(sender)
    End Sub
    Private Sub chkW4_CheckedChanged(sender As Object, e As EventArgs) Handles chkW4.CheckedChanged
        EnabledSouthChkbox(sender)
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
