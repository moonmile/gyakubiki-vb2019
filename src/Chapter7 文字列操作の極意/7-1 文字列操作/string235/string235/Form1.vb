Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim Text = textBox1.Text
        textBox2.Text = Text.Replace("カキ", "牡蠣")
    End Sub
End Class
