Public Class frmMonrhCalendar
    Private Sub frmMonrhCalendar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstBranch.Items.Add("คอมพิวเตอร์ธุรกิจ")
        lstBranch.Items.Add("การบริหารทรัพยากรณ์มนุษย์")
        lstBranch.Items.Add("การบัญชี")
        lstBranch.Items.Add("การตลาด")
        lstBranch.Items.Add("เศรษฐศาสตร์ธุรกิจ")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName.Text = ""
        lstBranch.ClearSelected()
        mnc1.SelectionStart = mnc1.TodayDate
        mnc1.SelectionEnd = mnc1.TodayDate
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim strOut As String
        strOut = ""
        strOut = strOut & "ชื่อ-สกุล : " & txtName.Text & vbCrLf
        strOut = strOut & "สาขาวิชา : " & lstBranch.Items(lstBranch.SelectedIndex).ToString & vbCrLf
        strOut = strOut & "ลาพักร้อนตั้งแต่วันที่ : " & mnc1.SelectionEnd.ToLongDateString & vbCrLf
        strOut = strOut & "  ถึง " & mnc1.SelectionEnd.ToLongTimeString


        MessageBox.Show(strOut)
    End Sub
End Class