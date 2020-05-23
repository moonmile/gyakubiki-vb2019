Public Class Form1
    Private page As Integer = -1

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim g = pictureBox1.CreateGraphics()
        Dim img = My.Resources.パノラマ
        ' ページを進める
        page = page + 1
        If page >= 5 Then
            page = 0
        End If
        ' 部分を表示する
        Dim pt As New Point(0, page * 208)
        g.DrawImage(img, New Rectangle(0, 0, 277, 208),
            New Rectangle(0, page * 208, 277, 208), GraphicsUnit.Pixel)
    End Sub
End Class
