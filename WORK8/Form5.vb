Public Class frmUseListBox
    Dim isSelect As Integer
    Private Sub frmUseListBox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lst1.Items.Add("Item 1")
        lst1.Items.Add("Item 2")
        lst1.Items.Add("Item 3")
        lst1.Items.Add("Item 4")

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        lst1.Items.Add(txt1.Text)
        txt1.Text = ""

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        lst1.Items.RemoveAt(isSelect)
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        lst1.Items(isSelect) = txt1.Text
        txt1.Text = ""
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        lst1.Items.Insert(isSelect, txt1.Text)
        txt1.Text = ""
    End Sub

    Private Sub lst1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst1.SelectedIndexChanged
        isSelect = lst1.SelectedIndex
        txt1.Text = lst1.SelectedItem
    End Sub
End Class