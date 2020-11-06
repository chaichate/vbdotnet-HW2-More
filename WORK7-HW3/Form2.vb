Public Class Form2

    Dim CPU As String
    Dim OS As String

    Function EnabledCPUChkbox(sender As Object)
        If sender Is chkCPU1 And DirectCast(sender, CheckBox).Checked = True Then
            CPU = "Celeron"
            chkCPU1.Enabled = True
            chkCPU2.Enabled = False
            chkCPU3.Enabled = False

        ElseIf sender Is chkCPU2 And DirectCast(sender, CheckBox).Checked = True Then
            CPU = "Pentium IV"
            chkCPU1.Enabled = False
            chkCPU2.Enabled = True
            chkCPU3.Enabled = False

        ElseIf sender Is chkCPU3 And DirectCast(sender, CheckBox).Checked = True Then
            CPU = "Core 2 Duo"
            chkCPU1.Enabled = False
            chkCPU2.Enabled = False
            chkCPU3.Enabled = True

        ElseIf DirectCast(sender, CheckBox).Checked = False Then
            CPU = ""
            chkCPU1.Enabled = True
            chkCPU2.Enabled = True
            chkCPU3.Enabled = True
        End If

    End Function

    Function EnabledOSChkbox(sender As Object)
        If sender Is chkOS1 And DirectCast(sender, CheckBox).Checked = True Then
            OS = "Windows XP"
            chkOS1.Enabled = True
            chkOS2.Enabled = False
            chkOS3.Enabled = False

        ElseIf sender Is chkOS2 And DirectCast(sender, CheckBox).Checked = True Then
            OS = "Windows Vista"
            chkOS1.Enabled = False
            chkOS2.Enabled = True
            chkOS3.Enabled = False

        ElseIf sender Is chkOS3 And DirectCast(sender, CheckBox).Checked = True Then
            OS = "Linux/Unix"
            chkOS1.Enabled = False
            chkOS2.Enabled = False
            chkOS3.Enabled = True
        ElseIf DirectCast(sender, CheckBox).Checked = False Then
            OS = ""
            chkOS1.Enabled = True
            chkOS2.Enabled = True
            chkOS3.Enabled = True
        End If

    End Function

    Private Sub chkCPU1_CheckedChanged(sender As Object, e As EventArgs) Handles chkCPU1.CheckedChanged
        EnabledCPUChkbox(sender)
    End Sub
    Private Sub chkCPU2_CheckedChanged(sender As Object, e As EventArgs) Handles chkCPU2.CheckedChanged
        EnabledCPUChkbox(sender)
    End Sub

    Private Sub chkCPU3_CheckedChanged(sender As Object, e As EventArgs) Handles chkCPU3.CheckedChanged
        EnabledCPUChkbox(sender)
    End Sub

    Private Sub chkOS1_CheckedChanged(sender As Object, e As EventArgs) Handles chkOS1.CheckedChanged
        EnabledOSChkbox(sender)
    End Sub

    Private Sub chkOS2_CheckedChanged(sender As Object, e As EventArgs) Handles chkOS2.CheckedChanged
        EnabledOSChkbox(sender)
    End Sub

    Private Sub chkOS3_CheckedChanged(sender As Object, e As EventArgs) Handles chkOS3.CheckedChanged
        EnabledOSChkbox(sender)
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Label1.Text = "คุณใช้หน่วยประมวลผลกลาง " & CPU & vbCrLf & "คุณใช้ระบบปฏิบัติการ  " & OS
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class