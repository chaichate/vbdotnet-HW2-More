Public Class Form7
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim unit As Double = Double.Parse(txtInput.Text)
        Dim pricePerUnit As Double

        Select Case unit
            Case 1 To 10
                pricePerUnit = 10.0
            Case 11 To 20
                pricePerUnit = 9.5
            Case 21 To 50
                pricePerUnit = 9.0
            Case 51 To 100
                pricePerUnit = 8.5
            Case 101 To 1000
                pricePerUnit = 8.0
            Case > 1000
                pricePerUnit = 7.0
            Case Else
                pricePerUnit = 0
        End Select

        txtShow.Text = pricePerUnit * unit


        Select Case unit
            Case 1 To 100
                txtType.Text = "ที่อยู่อาศัย"
            Case 101 To 1000
                txtType.Text = "ราชการหรือธุรกิจขนาดเล็ก"
            Case > 1000
                txtType.Text = "อุตสาหกรรมหรือธุรกิจขนาดใหญ่"
        End Select

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class