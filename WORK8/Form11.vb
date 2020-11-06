Public Class frmTabControl
    Dim level, faculty As String
    Private Sub rad1_CheckedChanged(sender As Object, e As EventArgs) Handles rad1.CheckedChanged
        level = "ปริญญาตรี"
    End Sub
    Private Sub rad2_CheckedChanged(sender As Object, e As EventArgs) Handles rad2.CheckedChanged
        level = "ปริญญาโท"
    End Sub
    Private Sub rad3_CheckedChanged(sender As Object, e As EventArgs) Handles rad3.CheckedChanged
        level = "ปริญญาเอก"
    End Sub
    Private Sub radf1_CheckedChanged(sender As Object, e As EventArgs) Handles radf1.CheckedChanged
        faculty = "วิทยาศาสตร์"
    End Sub
    Private Sub radf2_CheckedChanged(sender As Object, e As EventArgs) Handles radf2.CheckedChanged
        faculty = "บริหารธุรกิจ"
    End Sub
    Private Sub radf3_CheckedChanged(sender As Object, e As EventArgs) Handles radf3.CheckedChanged
        faculty = "คุรุศาสตร์"
    End Sub
    Private Sub radf4_CheckedChanged(sender As Object, e As EventArgs) Handles radf4.CheckedChanged
        faculty = "ศิลปศาสตร์"
    End Sub
    Private Sub radf5_CheckedChanged(sender As Object, e As EventArgs) Handles radf5.CheckedChanged
        faculty = "นิติศาสตร์"
    End Sub
    Private Sub radf6_CheckedChanged(sender As Object, e As EventArgs) Handles radf6.CheckedChanged
        faculty = "รัฐประศาสนศาตร์"
    End Sub
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim StrOut As String
        StrOut = ""
        StrOut = StrOut & "คุณ" & txtName.Text & vbCrLf
        StrOut = StrOut & "เกิดวันที่" & dtpBirthday.Value.ToLongDateString & vbCrLf
        StrOut = StrOut & "ที่อยู่" & txtAddress.Text & vbCrLf
        StrOut = StrOut & "เบอร์โทรศัพท์" & mtbPhone.Text & vbCrLf
        StrOut = StrOut & "---------------------------" & vbCrLf
        StrOut = StrOut & "ระบบการศึกษา" & level & vbCrLf
        StrOut = StrOut & "คณะ" & faculty & vbCrLf
        StrOut = StrOut & "สาขา" & txtBranch.Text & vbCrLf
        StrOut = StrOut & "---------------------------" & vbCrLf
        StrOut = StrOut & "คติเตือนใจ" & txtMoral.Text & vbCrLf
        MessageBox.Show(StrOut)
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class