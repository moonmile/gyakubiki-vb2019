Imports System.Text.RegularExpressions

Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim Text = textBox1.Text
        Dim rx As New Regex("[様君殿]$")
        textBox2.Text = rx.Replace(Text, "御中")
    End Sub
End Class
