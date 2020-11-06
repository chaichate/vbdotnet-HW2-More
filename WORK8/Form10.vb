Public Class Form10
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim strOut As String
        strOut = ""
        strOut = strOut & "เบอร์โทรศัพท์ : " & mtbPhone.Text & vbCrLf
        strOut = strOut & "วันเกิด : " & mtbBirthDay.Text & vbCrLf
        strOut = strOut & "รหัสประจำตัวประชาชน 13 หลัก : " & mtbId.Text & vbCrLf
        strOut = strOut & "ทะเบียนรถยนต์ : " & mtbCar.Text & vbCrLf

        MessageBox.Show(strOut)

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        mtbBirthDay.Text = ""
        mtbId.Text = ""
        mtbCar.Text = ""
        mtbPhone.Text = ""
    End Sub
End Class