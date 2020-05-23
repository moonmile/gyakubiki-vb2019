Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim Text = textBox1.Text
        ' カンマ区切りで分割
        Dim ary = Text.Split(",")
        Try
            ' 11番目の要素を取得
            Dim n = ary(10)
        Catch ex As IndexOutOfRangeException
            MessageBox.Show(ex.Message, "エラー発生")
        End Try
    End Sub
End Class
