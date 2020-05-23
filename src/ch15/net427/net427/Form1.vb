Imports System.Net.Http

Public Class Form1
    Private Async Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim client As New HttpClient()
        Try
            ' 指定URLのファイルをダウンロードする
            Dim Data = Await client.GetByteArrayAsync("http://localhost/test.zip")
            Dim fs = System.IO.File.OpenWrite("c:\VB2019\test.lzh")
            fs.Write(Data, 0, Data.Length)
            fs.Close()
            MessageBox.Show("ダウンロードが完了しました")
        Catch ex As Exception
            ' URLが不正の場合は例外が発生する
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
