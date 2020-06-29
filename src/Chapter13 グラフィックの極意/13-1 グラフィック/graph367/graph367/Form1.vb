Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim g = pictureBox1.CreateGraphics()
        ' 四角形を描画する
        g.DrawRectangle(Pens.Black, 0, 0, 100, 100)
        ' 塗り潰した四角形を描画する
        g.FillRectangle(Brushes.Red, 50, 50, 100, 100)
    End Sub
End Class
