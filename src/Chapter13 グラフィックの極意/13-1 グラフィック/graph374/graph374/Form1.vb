Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim g = pictureBox1.CreateGraphics()
        ' 画像を回転する
        Dim img = My.Resources.book
        Dim mx = New System.Drawing.Drawing2D.Matrix()
        ' 画像の中央で時計回りに45度回転させる
        mx.RotateAt(45, New Point(img.Width / 2, img.Height))
        g.Transform = mx
        g.DrawImage(img, New Point(0, 0))
    End Sub
End Class
