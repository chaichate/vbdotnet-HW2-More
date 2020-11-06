Public Class Form4
    Dim total As Integer
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If total > 0 Then
            MessageBox.Show("คุณต้องชำระเงิน " & total & " บาท", "ผลการเลือก", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("คุณยังไม่ได้เลือกอาหาร", "ผลการเลือก", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub chk1_CheckedChanged(sender As Object, e As EventArgs) Handles chk1.CheckedChanged
        If DirectCast(sender, CheckBox).Checked = True Then
            total += 35
        Else
            total -= 35
        End If
    End Sub
    Private Sub chk2_CheckedChanged(sender As Object, e As EventArgs) Handles chk2.CheckedChanged
        If DirectCast(sender, CheckBox).Checked = True Then
            total += 25
        Else
            total -= 25
        End If
    End Sub
    Private Sub chk3_CheckedChanged(sender As Object, e As EventArgs) Handles chk3.CheckedChanged
        If DirectCast(sender, CheckBox).Checked = True Then
            total += 25
        Else
            total -= 25
        End If
    End Sub
    Private Sub grb1_CheckedChanged(sender As Object, e As EventArgs) Handles grb1.CheckedChanged
        If DirectCast(sender, CheckBox).Checked = True Then
            total += 20
        Else
            total -= 20
        End If
    End Sub
    Private Sub grb2_CheckedChanged(sender As Object, e As EventArgs) Handles grb2.CheckedChanged
        If DirectCast(sender, CheckBox).Checked = True Then
            total += 20
        Else
            total -= 20
        End If
    End Sub
    Private Sub grb3_CheckedChanged(sender As Object, e As EventArgs) Handles grb3.CheckedChanged
        If DirectCast(sender, CheckBox).Checked = True Then
            total += 50
        Else
            total -= 50
        End If
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class