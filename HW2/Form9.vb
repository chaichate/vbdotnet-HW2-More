Public Class Form9
    Private Sub btnOpenInput_Click(sender As Object, e As EventArgs) Handles btnOpenInput.Click

        Dim Message, Title
        Dim Age As Integer
        Message = "กรุณาป้อนอายุ"    ' Set prompt.
        Title = "ตัวอย่างการใช้ input Box"    ' Set title.

        Try

            Age = Val(InputBox(Message, Title, 0, 100, 100))

            Dim Msg, Style
            Style = MsgBoxStyle.OkOnly

            Select Case Age
                Case 1 To 12
                    Msg = "อยู่ในวัยเด็ก"
                Case 13 To 24
                    Msg = "อยู่ในวัยรุ่น"
                Case 25 To 60
                    Msg = "อยู่ในวัยทำงาน"
                Case > 60
                    Msg = "อยู่ในวัยผู้สูงอายุ"
                Case Else
                    Msg = "เกิดข้อผิดพลาด"
            End Select
            MsgBox(Msg, Style, "ผลการประเมิน")
        Catch ex As Exception
            Console.WriteLine("เกิดข้อผิดพลาด")
        End Try
    End Sub
End Class