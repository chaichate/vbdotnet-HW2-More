Public Class Form12
    Private Sub mnuForNext_Click(sender As Object, e As EventArgs) Handles mnuForNext.Click
        Dim box = New Form1()
        box.Show()
    End Sub
    Private Sub DoWhileLoopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DoWhileLoopToolStripMenuItem.Click
        Dim box = New Form2()
        box.Show()
    End Sub
    Private Sub DoLoopWhileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DoLoopWhileToolStripMenuItem.Click
        Dim box = New Form3()
        box.Show()
    End Sub
    Private Sub ListboxToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ListboxToolStripMenuItem1.Click
        Dim box = New frmListBox()
        box.Show()
    End Sub
    Private Sub การใชงานListBoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles การใชงานListBoxToolStripMenuItem.Click
        Dim box = New frmUseListBox()
        box.Show()
    End Sub
    Private Sub ComboboxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComboboxToolStripMenuItem.Click
        Dim box = New frmComboBox()
        box.Show()
    End Sub
    Private Sub NumericUpDownToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NumericUpDownToolStripMenuItem.Click
        Dim box = New frmNumericUpDrown()
        box.Show()
    End Sub
    Private Sub DateTimePickToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DateTimePickToolStripMenuItem.Click
        Dim box = New frmParttime()
        box.Show()
    End Sub
    Private Sub MonthCalendarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonthCalendarToolStripMenuItem.Click
        Dim box = New frmMonrhCalendar()
        box.Show()
    End Sub
    Private Sub MaskedTaskBoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaskedTaskBoxToolStripMenuItem.Click
        Dim box = New Form10()
        box.Show()
    End Sub
    Private Sub TabControlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TabControlToolStripMenuItem.Click
        Dim box = New frmTabControl()
        box.Show()
    End Sub
    Private Sub ExitMenuItem_Click(sender As Object, e As EventArgs) Handles ExitMenuItem.Click
        Me.Close()
    End Sub
End Class