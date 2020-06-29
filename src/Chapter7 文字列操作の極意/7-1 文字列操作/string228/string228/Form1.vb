Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim code As Integer = Asc("A")  '文字をinteger型に変換
        textBox1.Text = code.ToString()
    End Sub
End Class
