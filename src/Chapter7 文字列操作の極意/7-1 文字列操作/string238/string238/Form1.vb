Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim Text = textBox1.Text
        If Text.Length < 4 Then
            MessageBox.Show("4文字以上入力してください")
            Return
        End If
        textBox2.Text = Text.Remove(1, 3)
    End Sub
End Class
