Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim Text = textBox1.Text
        Try
            ' null文字を追加する
            Dim t = Text.Insert(2, Nothing)
        Catch ex As ArgumentNullException
            MessageBox.Show(ex.Message, "エラー発生")
        End Try

    End Sub
End Class
