Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        ' テキスト形式でペーストする
        If Clipboard.ContainsText() Then
            Dim Text = Clipboard.GetText()
            textBox1.Text = Text
        End If
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        ' 画像形式でペーストする
        If Clipboard.ContainsImage() Then
            Dim Image = Clipboard.GetImage()
            pictureBox1.Image = Image
        End If
    End Sub
End Class
