Imports System.Net.Sockets

Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim client As New TcpClient()
        Try
            ' TCP/IP接続を行う
            client.Connect("localhost", 80)
            ' ストリームを取得する
            Dim stream = client.GetStream()
            Dim buffer = System.Text.Encoding.ASCII.GetBytes(
                "GET /start.htm HTTP/1.0" + vbCrLf + vbCrLf)
            stream.Write(buffer, 0, buffer.Length)
            ' 正常に送信できた場合
            textBox1.Text = "正常に送信できました"
            client.Close()
        Catch ex As Exception
            ' 接続できなかった場合
            textBox1.Text = ex.Message
        End Try
    End Sub
End Class
