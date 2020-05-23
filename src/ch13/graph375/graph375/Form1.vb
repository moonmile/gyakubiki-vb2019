Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim g = pictureBox1.CreateGraphics()
        ' 画像を反転する
        Dim img = My.Resources.book
        g.DrawImage(img, img.Width, 0, -img.Width, img.Height)
    End Sub
End Class
