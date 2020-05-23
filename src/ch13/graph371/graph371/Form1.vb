Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim g = pictureBox1.CreateGraphics()
        ' 透明度を指定する
        Dim cm = New System.Drawing.Imaging.ColorMatrix()
        cm.Matrix00 = 1.0F
        cm.Matrix11 = 1.0F
        cm.Matrix22 = 1.0F
        cm.Matrix33 = 0.5F
        cm.Matrix44 = 1.0F
        Dim ia = New System.Drawing.Imaging.ImageAttributes()
        ia.SetColorMatrix(cm)
        ' 画像を描画する
        Dim img = My.Resources.book
        Dim rect = New Rectangle(0, 0, img.Width, img.Height)
        g.DrawImage(img, rect, 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia)
    End Sub
End Class
