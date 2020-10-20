Public Class Form1



    Private Sub btnWaning_Click(sender As Object, e As EventArgs) Handles btnWaning.Click
        Dim Msg, Style, Title, Response
        Msg = "the text in the Untitled file change. Do you want to save the change ?"    ' Define message.
        Style = vbYesNoCancel + MsgBoxStyle.Exclamation
        Title = "Noteped"    ' Define title.
        Response = MsgBox(Msg, Style, Title)

    End Sub

    Private Sub btnQuestion_Click(sender As Object, e As EventArgs) Handles btnQuestion.Click
        Dim Msg, Style, Title, Response
        Msg = "คุณต้องการทำงานต่อหรือไม่"    ' Define message.
        Style = vbYesNo + MsgBoxStyle.Question
        Title = "ยินดีตอนรับสู่โปรแกรมดูดวง 2017 " 'dine title.
        Response = MsgBox(Msg, Style, Title)
    End Sub

    Private Sub btnError_Click(sender As Object, e As EventArgs) Handles btnError.Click
        Dim Msg, Style, Title, Response
        Msg = "Error in Momory address F0002A"  ' Define message.
        Style = vbYesNo + MsgBoxStyle.Critical
        Title = "Microsoft Visual Basic 2005 "
        Response = MsgBox(Msg, Style, Title)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
