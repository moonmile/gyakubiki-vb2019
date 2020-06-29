Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim text = textBox1.Text
        textBox2.Text = text.ToUpper() '大文字に変換
        textBox3.Text = text.ToLower() '小文字に変換
    End Sub
End Class
