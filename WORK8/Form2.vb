Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer = 1

        Do While i <= 10
            TextBox1.Text = TextBox1.Text & i & vbCrLf
            i = i + 1
        Loop

    End Sub
End Class