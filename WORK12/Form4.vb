Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim a(2, 3), i, j As Integer

        For i = 0 To 2
            For j = 0 To 3
                a(i, j) = i + j
            Next j
        Next i


        For Each i In a
            lst1.Items.Add(i)
        Next i
    End Sub
End Class