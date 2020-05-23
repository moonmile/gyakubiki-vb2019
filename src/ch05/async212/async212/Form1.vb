Public Class Form1
    Private mre As System.Threading.ManualResetEvent

    Private Async Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Await Task.Run(
        Sub()
            mre = New System.Threading.ManualResetEvent(False)
            For i = 1 To 20
                If i = 10 Then
                    ' 10秒後にイベント待ちになる
                    Me.Invoke(
                    Sub()
                        label1.Text = "解除イベント待ち"
                    End Sub)
                    mre.Reset()
                    mre.WaitOne()
                End If
                Me.Invoke(
                Sub()
                    label1.Text = $"{i} 秒経過"
                End Sub)
                System.Threading.Thread.Sleep(1000)
            Next
        End Sub)
        label1.Text = "タスク終了"
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        ' イベント待ちを解除
        mre.Set()
    End Sub
End Class
