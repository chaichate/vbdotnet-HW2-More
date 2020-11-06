Public Class Form6
    Dim RndValue As Integer
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RndValue = Int((100 * Rnd()) + 1)

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        Dim num As Integer = Val(txtInput.Text)

        If num > RndValue Then
            MessageBox.Show("จำนวนที่คุณเลือกมากเกินไป", "ผลลัพธ์")
        ElseIf num < RndValue Then
            MessageBox.Show("จำนวนที่คุณเลือกน้อยเกินไป", "ผลลัพธ์")
        Else
            MessageBox.Show("จำนวน " & num & " คือ Lucky number", "ผลลัพธ์")
        End If

    End Sub
End Class