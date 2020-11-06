Public Class Form3

    Dim foodPrice As Integer
    Dim drinkPrice As Integer

    Dim food As String
    Dim drink As String
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        MessageBox.Show("คุณเลือกรับประทานอาหาร " & food & vbCrLf & "คุณเลือกเครื่องดิม  " & drink & vbCrLf & "ราคารวม " & (foodPrice + drinkPrice) & " บาท", "ผลการเลือก")
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close 
    End Sub

    Private Sub rdoF1_CheckedChanged(sender As Object, e As EventArgs) Handles rdoF1.CheckedChanged
        foodPrice = 25
        food = "ราดหน้า"

    End Sub

    Private Sub rdoF2_CheckedChanged(sender As Object, e As EventArgs) Handles rdoF2.CheckedChanged
        foodPrice = 35
        food = "ข้าวผัดปู"
    End Sub

    Private Sub rdoF3_CheckedChanged(sender As Object, e As EventArgs) Handles rdoF3.CheckedChanged
        foodPrice = 25
        food = "ข้าวมันไก่"
    End Sub

    Private Sub rdoD1_CheckedChanged(sender As Object, e As EventArgs) Handles rdoD1.CheckedChanged
        drinkPrice = 35
        drink = "กาแฟ"
    End Sub

    Private Sub rdoD2_CheckedChanged(sender As Object, e As EventArgs) Handles rdoD2.CheckedChanged
        drinkPrice = 20
        drink = "น้ำอัดลม"
    End Sub

    Private Sub rdoD3_CheckedChanged(sender As Object, e As EventArgs) Handles rdoD3.CheckedChanged
        drinkPrice = 10
        drink = "น้ำเปล่า"
    End Sub
End Class