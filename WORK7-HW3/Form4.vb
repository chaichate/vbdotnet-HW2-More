Public Class Form4

    Dim channel As String
    Dim show As String
    Private Sub rdoC1_CheckedChanged(sender As Object, e As EventArgs) Handles rdoC1.CheckedChanged
        channel = "ช่อง 3"
    End Sub
    Private Sub rrdoC2_CheckedChanged(sender As Object, e As EventArgs) Handles rrdoC2.CheckedChanged
        channel = "ช่อง 5"
    End Sub
    Private Sub rdoC3_CheckedChanged(sender As Object, e As EventArgs) Handles rdoC3.CheckedChanged
        channel = "ช่อง 7"
    End Sub
    Private Sub rdoC4_CheckedChanged(sender As Object, e As EventArgs) Handles rdoC4.CheckedChanged
        channel = "ช่อง 9"
    End Sub

    Private Sub rdoS1_CheckedChanged(sender As Object, e As EventArgs) Handles rdoS1.CheckedChanged
        show = "ละคร"
    End Sub

    Private Sub rdoS2_CheckedChanged(sender As Object, e As EventArgs) Handles rdoS2.CheckedChanged
        show = "เกมส์โชว์"
    End Sub

    Private Sub rdoS3_CheckedChanged(sender As Object, e As EventArgs) Handles rdoS3.CheckedChanged
        show = "สารคดี"
    End Sub
    Private Sub rdoS4_CheckedChanged(sender As Object, e As EventArgs) Handles rdoS4.CheckedChanged
        show = "การ์ตูน"
    End Sub
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Label1.Text = "คุณชอบรายการ " & show & vbCrLf & " ทางสถานีโทรทัศน์ " & channel
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class