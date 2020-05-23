Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim hostname = System.Net.Dns.GetHostName()
        textBox1.Text = hostname
    End Sub
End Class
