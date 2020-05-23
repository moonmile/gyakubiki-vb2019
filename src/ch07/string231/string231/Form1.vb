Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim Text = textBox1.Text
        textBox2.Text = ""
        If Text.Length < 7 Then
            MessageBox.Show("7文字以上入力してください")
            Return
        End If
        ' 3文字分取得する
        textBox2.Text = Text.Substring(4, 3)
    End Sub
End Class
