Public Class Form1

    Dim startTime As New TimeSpan(0, 0, 0) '開始時間の設定
    Dim addSecond As New TimeSpan(0, 0, 1)

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        startTime = startTime + addSecond
        Label1.Text = startTime.ToString
        '1分経過したらタイマーを止める
        If startTime = New TimeSpan(1, 0, 0) Then
            Timer1.Stop()
            MessageBox.Show("1分経過")
            Label1.Text = New TimeSpan(0, 0, 0).ToString
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Enabled = Not Timer1.Enabled
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Enabled = False
        startTime = New TimeSpan(0, 0, 0)
        Label1.Text = startTime.ToString
    End Sub
End Class
