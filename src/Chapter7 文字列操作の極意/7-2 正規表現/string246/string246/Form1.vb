Imports System.Text.RegularExpressions

Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim Text = textBox1.Text
        Dim rx As New Regex("/\w+[都道府県]")
        Dim coll = rx.Matches(Text)
        listBox1.Items.Clear()
        For Each it In coll
            listBox1.Items.Add(it)
        Next
    End Sub
End Class
