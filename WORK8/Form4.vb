Public Class frmListBox
    Dim Faculty, Programe As String

    Private Sub lstFaculty_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstFaculty.SelectedIndexChanged
        Faculty = lstFaculty.SelectedItem
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        MessageBox.Show("คุณเลือกคณะ " & Faculty & vbCrLf & "โปรแกรมวิชา " & Programe, "ผลทางเลือก")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstFaculty.ClearSelected()
        lstPrograme.ClearSelected()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub lstPrograme_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPrograme.SelectedIndexChanged
        Programe = lstPrograme.SelectedItem
    End Sub

    Private Sub frmListBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstFaculty.Items.Add("วิทยาศาสตร์")
        lstFaculty.Items.Add("ครุศาตร์")
        lstFaculty.Items.Add("มนุษยศาตร์")
        lstFaculty.Items.Add("วิทยาการจัดการ")
        lstFaculty.Items.Add("เทคโนโลยีอุตสาหกรรม")

        lstPrograme.Items.Add("คอมพิวเตอร์ธุรกิจ")
        lstPrograme.Items.Add("คอมศึกษา")
        lstPrograme.Items.Add("วิทยาการคอมพิวเตอร์")
        lstPrograme.Items.Add("เทคโนโลยีสารสนเทศ")
        lstPrograme.Items.Add("คอมพิวเตอร์อุตสาหกรรม")
        lstPrograme.Items.Add("ภาษาอังกฤษ")
        lstPrograme.Items.Add("รัฐประศาสนศาสตร์")
        lstPrograme.Items.Add("อุตสาหกรรมท่องเที่ยว")
    End Sub
End Class