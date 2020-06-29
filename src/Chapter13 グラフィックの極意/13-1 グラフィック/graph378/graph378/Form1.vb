Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim g = pictureBox1.CreateGraphics()
        ' 画像の大きさを変える
        Dim img = My.Resources.book
        Dim mx = New System.Drawing.Drawing2D.Matrix()
        mx.Scale(2.0F, 2.0F)
        g.Transform = mx
        g.DrawImage(img, New Point(0, 0))
    End Sub
End Class
