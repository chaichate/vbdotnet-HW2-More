Public Class Form2
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim hours As Integer = txtShow.Text

        Dim minute As Integer = hours * 60


        Dim Msg, Style, Title, Response
        Msg = "เวลา " & hours & " ชัวโมง เท่ากับ" & minute & " นาที"
        Style = vbOK + MsgBoxStyle.Information

        Title = "ชัวโมงเป็นนาที"
        Response = MsgBox(Msg, Style, Title)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class