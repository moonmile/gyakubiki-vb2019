Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim g = pictureBox1.CreateGraphics()
        Dim img = My.Resources.book
        g.DrawImage(img, New Point(0, 0))
        ' 画像に文字を入れる
        g.DrawString(DateTime.Now.ToString("yyyy-MM-dd"),
            New Font("Meiryo", 30.0F),
            New SolidBrush(Color.Red),
            New Point(0, 0))
    End Sub
End Class
