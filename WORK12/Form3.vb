Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim numbers() As Integer

        ReDim numbers(2)
        numbers(0) = 1
        numbers(1) = 2
        numbers(2) = 3

        For Each i In numbers
            lst1.Items.Add(i)
        Next i

        ReDim Preserve numbers(10)
        numbers(3) = 12
        For Each i In numbers
            lst2.Items.Add(i)
        Next i

    End Sub
End Class