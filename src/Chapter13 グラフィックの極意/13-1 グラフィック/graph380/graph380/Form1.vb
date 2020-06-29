Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim img As New Bitmap(My.Resources.book)
        Dim g = Graphics.FromImage(img)
        Dim mx = New System.Drawing.Drawing2D.Matrix()
        g.DrawImage(img, New Point(0, 0))
        g.DrawString(DateTime.Now.ToString("HH:mm"),
                New Font("Meiryo", 30.0F),
                New SolidBrush(Color.Red),
                New Point(0, 0))
        pictureBox1.Image = img
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim img = pictureBox1.Image
        img.Save(System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +
        "\" + DateTime.Now.ToString("yyyy-MM-dd") + ".png",
        System.Drawing.Imaging.ImageFormat.Png)
        MessageBox.Show("画像を保存しました")
    End Sub
End Class
