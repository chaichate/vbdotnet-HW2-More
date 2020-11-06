Public Class frmSoftware

    Dim sw As String
    Dim language As String

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        MessageBox.Show("คุณถนัดใช้โปรแกรม " & sw & vbCrLf & "คุณถนัดเขียนโปรแกรม  " & language, "ผลการเลือก")
    End Sub

    Function EnabledSWChkbox(sender As Object)
        If sender Is chkWord And DirectCast(sender, CheckBox).Checked = True Then
            sw = "Microsoft word"
            chkWord.Enabled = True
            chkExcel.Enabled = False
            chkPowerpoint.Enabled = False
            chkAccess.Enabled = False

        ElseIf sender Is chkExcel And DirectCast(sender, CheckBox).Checked = True Then
            sw = "Microsoft Excel"
            chkWord.Enabled = False
            chkExcel.Enabled = True
            chkPowerpoint.Enabled = False
            chkAccess.Enabled = False

        ElseIf sender Is chkPowerpoint And DirectCast(sender, CheckBox).Checked = True Then
            sw = "Microsoft Powerpoint"
            chkWord.Enabled = False
            chkExcel.Enabled = False
            chkPowerpoint.Enabled = True
            chkAccess.Enabled = False

        ElseIf sender Is chkAccess And DirectCast(sender, CheckBox).Checked = True Then
            sw = "Microsoft Access"
            chkWord.Enabled = False
            chkExcel.Enabled = False
            chkPowerpoint.Enabled = False
            chkAccess.Enabled = True

        ElseIf DirectCast(sender, CheckBox).Checked = False Then
            sw = ""
            chkWord.Enabled = True
            chkExcel.Enabled = True
            chkPowerpoint.Enabled = True
            chkAccess.Enabled = True
        End If
    End Function

    Function EnabledLangChkbox(sender As Object)
        If sender Is chkC And DirectCast(sender, CheckBox).Checked = True Then
            language = "C\C++"
            chkC.Enabled = True
            chkVB.Enabled = False
            chlJava.Enabled = False
            chkPHP.Enabled = False

        ElseIf sender Is chkVB And DirectCast(sender, CheckBox).Checked = True Then
            language = "VB"
            chkC.Enabled = False
            chkVB.Enabled = True
            chlJava.Enabled = False
            chkPHP.Enabled = False

        ElseIf sender Is chlJava And DirectCast(sender, CheckBox).Checked = True Then
            language = "JAVA"
            chkC.Enabled = False
            chkVB.Enabled = False
            chlJava.Enabled = True
            chkPHP.Enabled = False

        ElseIf sender Is chkPHP  And DirectCast(sender, CheckBox).Checked = True Then
            language = "PHP"
            chkC.Enabled = False
            chkVB.Enabled = False
            chlJava.Enabled = False
            chkPHP.Enabled = True

        ElseIf DirectCast(sender, CheckBox).Checked = False Then
            language = ""
            chkC.Enabled = True
            chkVB.Enabled = True
            chlJava.Enabled = True
            chkPHP.Enabled = True
        End If
    End Function

    Private Sub chkWord_CheckedChanged(sender As Object, e As EventArgs) Handles chkWord.CheckedChanged
        EnabledSWChkbox(sender)
    End Sub

    Private Sub chkExcel_CheckedChanged(sender As Object, e As EventArgs) Handles chkExcel.CheckedChanged
        EnabledSWChkbox(sender)
    End Sub

    Private Sub chkPowerpoint_CheckedChanged(sender As Object, e As EventArgs) Handles chkPowerpoint.CheckedChanged
        EnabledSWChkbox(sender)
    End Sub

    Private Sub chkAccess_CheckedChanged(sender As Object, e As EventArgs) Handles chkAccess.CheckedChanged
        EnabledSWChkbox(sender)
    End Sub

    Private Sub chkC_CheckedChanged(sender As Object, e As EventArgs) Handles chkC.CheckedChanged
        EnabledLangChkbox(sender)
    End Sub

    Private Sub chkVB_CheckedChanged(sender As Object, e As EventArgs) Handles chkVB.CheckedChanged
        EnabledLangChkbox(sender)
    End Sub

    Private Sub chlJava_CheckedChanged(sender As Object, e As EventArgs) Handles chlJava.CheckedChanged
        EnabledLangChkbox(sender)
    End Sub

    Private Sub chkPHP_CheckedChanged(sender As Object, e As EventArgs) Handles chkPHP.CheckedChanged
        EnabledLangChkbox(sender)
    End Sub
End Class