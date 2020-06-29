Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim text = textBox1.Text
        textBox2.Text = text.Length.ToString()
    End Sub
End Class
