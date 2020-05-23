Imports System.Text.RegularExpressions

Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim Text = textBox1.Text
        Dim rx As New Regex(".+[都道府県]")
        If rx.IsMatch(Text) Then
            textBox2.Text = $"県名は {Text} です"
        Else
            textBox2.Text = "都道府県名を入力してください"
        End If
    End Sub
End Class
