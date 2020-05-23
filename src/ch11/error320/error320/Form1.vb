Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim Text = textBox1.Text
        Dim items = Text.ToList()
        Try
            For Each ch In items
                ' コレクションを変更してはいけない
                items.Add("A")
            Next
        Catch ex As InvalidOperationException
            MessageBox.Show(ex.Message, "エラー発生")
        End Try
    End Sub
End Class
