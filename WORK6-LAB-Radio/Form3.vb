Public Class Form3


    Function showDog(name As String)

        Dim folder As String = "c:\dog\"
        Dim filename As String = System.IO.Path.Combine(folder, name)
        picgog.Image = Image.FromFile(filename)
        'picgog.ImageLocation = "C:\dog\golden.jpg"
        'picgog.Load()
    End Function


    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        showDog("golden.jpg")
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        showDog("bernhard.jpg")
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        showDog("rootweiler.jpg")
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        showDog("pugs.jpg")
    End Sub
End Class