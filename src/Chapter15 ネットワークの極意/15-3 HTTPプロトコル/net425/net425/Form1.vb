Imports System.Net.Http

Public Class Form1
    Private Async Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        ' HTTPサーバーへ接続する
        Dim client As New HttpClient()
        Try
            ' HTTPサーバーへ接続しストリームを取得する
            Dim stream = Await client.GetStreamAsync(textBox1.Text)
            ' テキストボックスへ結果を書き出す
            Dim reader As New System.IO.StreamReader(stream)
            textBox2.Text = reader.ReadToEnd()
            reader.Close()
            stream.Close()
        Catch ex As Exception
            ' URLが不正の場合は例外が発生する
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
