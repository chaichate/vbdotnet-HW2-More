Public Class Form4

    Function Maxi(ByVal num1 As Integer, ByVal num2 As Integer, ByVal num3 As Integer) As Integer

        Dim MaxNum As Integer

        If num1 > num2 Then
            MaxNum = num1
        Else
            MaxNum = num2
        End If

        If num3 > MaxNum Then
            MaxNum = num3
        End If

        Return MaxNum

    End Function

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        lblResult.Text = Maxi(Integer.Parse(txtInput1.Text), Integer.Parse(txtInput2.Text), Integer.Parse(txtInput3.Text))
    End Sub
End Class