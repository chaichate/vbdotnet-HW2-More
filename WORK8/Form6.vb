Public Class frmComboBox
    Dim edu, work As String
    Private Sub frmComboBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboEdu.Items.Add("ต่ำกว่าปริญญา")
        cboEdu.Items.Add("ปริญญาตรี")
        cboEdu.Items.Add("ปริญญาโท")
        cboEdu.Items.Add("ปริญญาเอก")

        cboWork.Items.Add("ข้าราชการ")
        cboWork.Items.Add("พนักงานเอกชน")
        cboWork.Items.Add("ธุรกิจส่วนตัว")
        cboWork.Items.Add("รับจ้าง")


    End Sub

    Private Sub cboEdu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEdu.SelectedIndexChanged
        edu = cboEdu.SelectedItem
    End Sub
    Private Sub cboWork_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboWork.SelectedIndexChanged
        work = cboWork.SelectedItem
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        MessageBox.Show("คุณจบการศึกษา" & edu & vbCrLf & "คุณประกอบอาชีพ " & work, "ผลการประเมิน")
    End Sub
End Class