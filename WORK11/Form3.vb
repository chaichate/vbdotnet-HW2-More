Public Class Form3

    Function PrimeNumbers(ByVal Number As Integer) As Boolean
        Dim count As Integer = 0

        For i As Integer = 1 To Number

            If Number Mod i = 0 Then
                count += 1
            End If
        Next

        If count = 2 Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        If PrimeNumbers(Val(txtInput.Text)) Then
            lblResult.Text = "เป็นจำนวนเฉพาะ"
        Else
            lblResult.Text = "ไม่เป็นจำนวนเฉพาะ"
        End If


    End Sub
End Class