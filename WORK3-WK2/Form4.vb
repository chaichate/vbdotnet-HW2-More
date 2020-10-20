Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Name As String

        Name = InputBox("กรุณาป้อน ชื่อ-สกุล ของท่าน", "ตัวอย่างที่ 1", "xxxx")
        MessageBox.Show("คุณชื่อ" & Name, "ตัวอย่างที่ 2", MessageBoxButtons.OKCancel)
    End Sub
End Class