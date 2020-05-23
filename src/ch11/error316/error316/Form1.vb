Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim Text = textBox1.Text
        Dim a As Integer = 0
        Try
            a = Integer.Parse(Text)
        Catch ex As ArgumentException
            MessageBox.Show("引数が無効です", "エラー発生")
        Catch ex As Exception
            MessageBox.Show("予期しないエラーが発生しました", "エラー発生")
        End Try
    End Sub
End Class
