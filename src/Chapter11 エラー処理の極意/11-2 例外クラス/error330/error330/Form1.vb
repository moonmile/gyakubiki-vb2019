Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim path = textBox1.Text
        Try
            Dim img = Image.FromFile(path)
        Catch ex As System.IO.FileNotFoundException
            MessageBox.Show(ex.Message, "エラー発生")
        End Try
    End Sub
End Class
