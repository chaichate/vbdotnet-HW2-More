Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim n(10), i, j As Integer

        For i = 0 To n.Length - 1
            n(i) = i + 100
        Next i


        For Each i In n
            lst1.Items.Add(i)
        Next i


    End Sub
End Class
