Public Class Form6
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click


        Dim Score As Integer = Integer.Parse(txtInput.Text)
        Dim Grad As String = ""


        Select Case Score
            Case 80 To 100
                Grad = "A"
            Case 75 To 79
                Grad = "B+"
            Case 70 To 74
                Grad = "B"
            Case 65 To 69
                Grad = "C+"
            Case 60 To 64
                Grad = "C"
            Case 55 To 59
                Grad = "D+"
            Case 50 To 54
                Grad = "D"
            Case 0 - 59
                Grad = "E"
            Case Else
                Grad = "ERROR"


        End Select

        txtShow.Text = Grad

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtInput.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = Not (Char.IsDigit(e.KeyChar))
        End If
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class