Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim i As Integer

        For i = 1 To 10
            Label1.Text = Label1.Text & i & vbCrLf
        Next

    End Sub
End Class
