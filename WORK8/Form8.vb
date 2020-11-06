Public Class frmParttime
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim fullname, strOut As String
        Dim hour As Integer
        fullname = txtName.Text
        hour = dtpEnd.Value.Hour - dtpStart.Value.Hour
        strOut = ""

        strOut = strOut & "คุณ " & fullname & vbCrLf
        strOut = strOut & "วันที่ " & dtpWorkDate.Value.ToLongDateString & vbCrLf
        strOut = strOut & "เริ่มทำงานล่วงเวลา " & dtpStart.Value.ToShortTimeString & vbCrLf
        strOut = strOut & "สิ้นสุดทำงานเวลา " & dtpEnd.Value.ToShortTimeString & vbCrLf
        strOut = strOut & "สรุปการทำงานล่วงเวลา " & hour & " ชัวโมง" & vbCrLf


        MessageBox.Show(strOut)
    End Sub
End Class