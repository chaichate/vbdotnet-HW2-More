Public Class frmNumericUpDrown
    Dim edu, work As String

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim Year As Integer
        Year = nudYear.Value
        lblDay.Text = Year * 365
        lblHour.Text = lblDay.Text * 24
    End Sub
End Class