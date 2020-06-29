Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim g = pictureBox1.CreateGraphics()
        ' 透明色を指定する
        Dim ia As New System.Drawing.Imaging.ImageAttributes()
        ia.SetColorKey(Color.White, Color.White)
        ' 画像を描画する
        Dim img = My.Resources.book
        Dim rect = New Rectangle(0, 0, img.Width, img.Height)
        g.DrawImage(img, rect, 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia)
    End Sub
End Class
