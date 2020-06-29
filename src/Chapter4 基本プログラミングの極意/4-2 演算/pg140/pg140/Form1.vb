Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim x As Integer?

        If textBox1.Text = "" Then
            x = Nothing
        Else
            x = Integer.Parse(textBox1.Text)
        End If
        label2.Text = "変数 x = " + If(x.HasValue, x, 0).ToString()
    End Sub
End Class
