Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim a(,) As Integer = {{0, 0}, {1, 2}, {2, 4}, {3, 6}, {4, 8}}

        'Dim i, j As Integer


        For Each i In a
            lst1.Items.Add(i)
        Next i

    End Sub
End Class