Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Clipboard.Clear()
        Clipboard.SetText(textBox1.Text)
        MessageBox.Show("クリップボードにコピーしました。", "確認")
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Clipboard.Clear()
        Clipboard.SetImage(pictureBox1.Image)
        MessageBox.Show("クリップボードにコピーしました。", "確認")
    End Sub
End Class
