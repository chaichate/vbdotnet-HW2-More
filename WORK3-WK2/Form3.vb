Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim result As MsgBoxResult
        Dim msg As String

        result = MessageBox.Show("Are you sure ?", "Please answer me", MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

        If result = MsgBoxResult.Yes Then
            msg = "YOU Click Button Yes"
        Else
            msg = "YOU Click Button No"
        End If

        MessageBox.Show(msg)

    End Sub
End Class