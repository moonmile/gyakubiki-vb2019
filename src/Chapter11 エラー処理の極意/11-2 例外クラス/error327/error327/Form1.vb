Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim Text = textBox1.Text
        Try
            ' 7文字目から2文字分取得する
            Dim t = Text.Substring(7, 2)
        Catch ex As ArgumentException
            MessageBox.Show(ex.Message, "エラー発生")
        End Try

    End Sub
End Class
