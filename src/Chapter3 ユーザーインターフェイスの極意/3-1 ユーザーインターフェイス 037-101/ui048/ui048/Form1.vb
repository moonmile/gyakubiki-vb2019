Public Class Form1
    Private Sub Button1_Click(sender As Object,
            e As EventArgs) Handles Button1.Click
        Opacity += 0.02
        Label1.Text = "不透明度：" + Opacity.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object,
            e As EventArgs) Handles Button2.Click

        If Opacity >= 0.3 Then
            Opacity -= 0.02
            Label1.Text = "不透明度：" + Opacity.ToString()
        Else
            MessageBox.Show("これ以上透明にできません")
        End If
    End Sub
End Class
