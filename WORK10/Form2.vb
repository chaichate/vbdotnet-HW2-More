Public Class Form2
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim Str As String = txtInput.Text
        Dim trimChars As Char() = {"*"c, "@"c, " "c}


        lst1.Items.Add("Len = " & Len(Str))
        lst1.Items.Add("Len AND L Trim = " & Len(LTrim(Str)))
        lst1.Items.Add("Len AND R Trim = " & Len(RTrim(Str)))
        lst1.Items.Add("Len AND TrimStart = " & Len(Str.TrimStart(trimChars)))
        lst1.Items.Add("Len AND TrimEnd = " & Len(Str.TrimStart(trimChars)))


        lst1.Items.Add("***************************************************")
        lst1.Items.Add("LCase = " & LCase(Str))
        lst1.Items.Add("UCase = " & UCase(Str))

        lst1.Items.Add("***************************************************")


        lst1.Items.Add("StartsWith c = " & Str.StartsWith("c"))
        lst1.Items.Add("EndsWith  c = " & Str.StartsWith("c"))

        lst1.Items.Add("***************************************************")

        lst1.Items.Add("mid = " & Mid(Str, 1, 2))
        lst1.Items.Add("StrReverse = " & StrReverse(Str))
        lst1.Items.Add("Asc = " & Asc(Str))


    End Sub
End Class