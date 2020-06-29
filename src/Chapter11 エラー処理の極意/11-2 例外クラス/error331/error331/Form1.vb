Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim path = textBox1.Text
        Try
            ' ファイル名を指定する
            For Each it In System.IO.Directory.GetFiles(path)
                System.Diagnostics.Debug.WriteLine(it)
            Next
        Catch ex As System.IO.DirectoryNotFoundException
            MessageBox.Show(ex.Message, "エラー発生")
        End Try

    End Sub
End Class
