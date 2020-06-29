Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        '追加したリソースの文字列をラベルに表示
        Label1.Text = My.Resources.String1
        '追加したリソースファイルをピクチャーボックスに表示
        PictureBox1.Image = My.Resources.sweet01
        '画像の大きさを縦横の比率を変更せずに枠に合わせる
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
    End Sub
End Class
