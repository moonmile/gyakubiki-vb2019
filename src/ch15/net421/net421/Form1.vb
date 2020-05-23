Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        ' TCP/IP接続を行う
        Dim client As New System.Net.Sockets.TcpClient()
        Try
            client.Connect("localhost", 81)
            ' 正常に接続できた場合
            textBox1.Text = "正常に接続できました"
            client.Close()
        Catch ex As Exception
            ' 接続できなかった場合
            textBox1.Text = ex.Message
        End Try
    End Sub
End Class
