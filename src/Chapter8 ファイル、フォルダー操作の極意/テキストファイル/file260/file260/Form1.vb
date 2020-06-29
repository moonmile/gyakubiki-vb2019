Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim path = System.Environment.GetFolderPath(
            Environment.SpecialFolder.MyDocuments)
        textBox1.Text = path
    End Sub
End Class
