Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        If textBox1.Text.Contains("リス") = True Then
            textBox2.Text = "含まれています。"
        Else
            textBox2.Text = "含まれていません。"
        End If
    End Sub
End Class
