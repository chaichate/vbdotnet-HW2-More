Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer = 1

        Do
            TextBox1.Text = TextBox1.Text & i & vbCrLf
            i = i + 1
        Loop While i <= 10

    End Sub
End Class