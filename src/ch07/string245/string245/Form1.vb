Imports System.Text.RegularExpressions

Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim Text = textBox1.Text

        textBox2.Text = Regex.Match(Text, "[A-Z]:\\").Value
        textBox3.Text = Regex.Match(Text, "\..*$").Value
    End Sub
End Class
