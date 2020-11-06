Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim numbers() = {2, 3, 5, 7}

        For Each i In numbers
            lst1.Items.Add(i)
        Next i


        numbers(0) = 9

        For Each i In numbers
            lst2.Items.Add(i)
        Next i


    End Sub
End Class