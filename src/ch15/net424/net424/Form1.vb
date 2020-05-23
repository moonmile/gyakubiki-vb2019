Imports System.Net
Imports System.Net.Sockets

Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Task.Run(
        Sub()
            DoWork()
        End Sub)
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Me.server.Stop()
    End Sub


    ' ワーカースレッド
    Private server As TcpListener
    Public Sub DoWork()
        ' リスナーを作成する
        server = New TcpListener(IPAddress.Loopback, 9000)
        ' リスナーを開始する
        server.Start()
        Invoke(
        Sub()
            textBox1.Text = "サーバー開始"
        End Sub)
        Try
            While True
                ' クライアントからの接続を受け付ける
                Dim client = server.AcceptTcpClient()
                Dim stream = client.GetStream()
                ' 受信データの読み出し
                Dim data = New Byte(101) {}
                Dim len = stream.Read(data, 0, data.Length)
                Dim s = System.Text.Encoding.ASCII.GetString(data, 0, len)
                Invoke(
                Sub()
                    textBox1.Text = "受信データ:" + s
                End Sub)
                client.Close()
            End While
        Catch ex As Exception
            Invoke(New Action(
                Sub()
                    textBox1.Text = "サーバー終了"
                End Sub))
        End Try
    End Sub
End Class
