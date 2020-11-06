Public Class Form3
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        lst1.Items.Add("Date Now = " & Date.Now)
        lst1.Items.Add("CDate = " & CDate("1 June 2020"))
        lst1.Items.Add("DateSerial = " & DateSerial(2020, 6, 1))
        lst1.Items.Add("DateValue = " & DateValue("1/6/2020"))


        lst1.Items.Add("***************************************************")

        lst1.Items.Add("Today = " & Today)
        lst1.Items.Add("Date Now = " & Date.Now)
        lst1.Items.Add("Day = " & Date.Now.Day)
        lst1.Items.Add("DayOfWeek = " & Date.Now.DayOfWeek)
        lst1.Items.Add("Month = " & Date.Now.Month)
        lst1.Items.Add("Year = " & Date.Now.Year)

        lst1.Items.Add("***************************************************")

        lst1.Items.Add("TimeOfDay = " & Date.Now.TimeOfDay.ToString)
        lst1.Items.Add("TimeSerial = " & TimeSerial(14, 6, 30))

    End Sub
End Class