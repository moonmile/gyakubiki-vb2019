Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim g = pictureBox1.CreateGraphics()
        ' グラデーションを作成
        Dim br As New System.Drawing.Drawing2D.LinearGradientBrush(
            New Point(0, 0), New Point(0, Me.pictureBox1.Height),
            Color.Green, Color.White)
        ' グラデーションで塗り潰し
        g.FillRectangle(br, 0, 0, Me.pictureBox1.Width, Me.pictureBox1.Height)
    End Sub
End Class
