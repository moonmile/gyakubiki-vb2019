Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim x = 100

        label1.Text = (x / 20).ToString()   ' 100÷20
        x += 20                             ' 100に20を加算
        label2.Text = x.ToString()

    End Sub
End Class
