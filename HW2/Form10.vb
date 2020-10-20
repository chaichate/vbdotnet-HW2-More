Public Class Form10
    Enum OperaterEnum
        plush  'บวก
        minus 'ลบ
        multiple 'คูณ
        divid 'หาร
    End Enum

    Dim CurrentNumber As Double = 0.0
    Dim OldNumber As Double = 0.0
    Dim CurOperater As OperaterEnum


    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        addNumber(1)
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        addNumber(2)
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        addNumber(3)
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        addNumber(4)
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        addNumber(5)
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        addNumber(6)
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        addNumber(7)
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        addNumber(8)
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        addNumber(9)
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        addNumber(0)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtShow.Text = ""
        CurrentNumber = 0
        OldNumber = 0
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        CurOperater = OperaterEnum.divid
        AddOperater()
    End Sub

    Private Sub btnMultiplied_Click(sender As Object, e As EventArgs) Handles btnMultiplied.Click
        CurOperater = OperaterEnum.multiple
        AddOperater()
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        CurOperater = OperaterEnum.minus
        AddOperater()
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        CurOperater = OperaterEnum.plush
        AddOperater()
    End Sub

    Function addNumber(ByVal number As Integer)
        Try

            CurrentNumber = Double.Parse(CurrentNumber.ToString + number.ToString)
            txtShow.Text = CurrentNumber

        Catch ex As Exception
            txtShow.Text = "Error"
        End Try

    End Function

    Function AddOperater()
        OldNumber = CurrentNumber
        CurrentNumber = 0
        txtShow.Text = ""
    End Function


    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click

        Dim Result As Double
        Select Case CurOperater
            Case OperaterEnum.plush
                Result = OldNumber + CurrentNumber
            Case OperaterEnum.minus
                Result = OldNumber - CurrentNumber
            Case OperaterEnum.multiple
                Result = OldNumber * CurrentNumber
            Case OperaterEnum.divid
                Result = OldNumber / CurrentNumber
        End Select


        txtShow.Text = Result
        CurrentNumber = Result



    End Sub
End Class