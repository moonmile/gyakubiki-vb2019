Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim g = pictureBox1.CreateGraphics()
        ' 円を描画する
        g.DrawEllipse(Pens.Black, 0, 0, 100, 100)
        ' 塗り潰した円を描画する
        g.FillEllipse(Brushes.Red, 50, 50, 100, 100)
        ' 作成したBrashオブジェクトを指定
        Dim br As New TextureBrush(My.Resources.book)
        g.FillEllipse(br, 100, 100, 100, 100)
    End Sub
End Class
