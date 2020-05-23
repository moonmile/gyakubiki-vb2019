Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim path = textBox1.Text
        textBox2.Text = System.IO.Path.GetDirectoryName(path)
        textBox3.Text = System.IO.Path.GetFileName(path)
    End Sub
End Class
