Public Class Form1
    Dim Score_arr() As Double
    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click

        Try
            Dim input_score As Double = InputBox("input Score", "Array")

            If Score_arr IsNot Nothing Then
                ReDim Preserve Score_arr(Score_arr.Length)
                Score_arr(Score_arr.Length - 1) = input_score

            Else
                ReDim Preserve Score_arr(0)
                Score_arr(0) = input_score
            End If

        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        lst1.Items.Clear()
        For Each i In Score_arr
            lst1.Items.Add(i & " ได้เกรด " & evaluate(i))
        Next
    End Sub
    Private Function evaluate(ByVal score As Single) As String
        If score >= 0 And score < 50 Then
            Return "E"
        ElseIf score >= 50 And score < 60 Then
            Return "D"
        ElseIf score >= 60 And score < 70 Then
            Return "C"
        ElseIf score >= 70 And score < 80 Then
            Return "B"
        ElseIf score >= 80 And score <= 100 Then
            Return "A"
        Else
            Return "ระบุุคะแนนไม่ถูกต้อง"
        End If
    End Function

End Class
