Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim g = pictureBox1.CreateGraphics()
        ' 普通の直線
        g.DrawLine(Pens.Black, 0, 0, pictureBox1.Width, 0)
        ' 太い線
        Dim bold As New Pen(Color.Black, 5)
        g.DrawLine(bold, 0, 50, pictureBox1.Width, 50)
        ' 点線
        Dim dot As New Pen(Color.Black) With {
            .DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
        }
        g.DrawLine(dot, 0, 100, pictureBox1.Width, 100)
    End Sub
End Class
