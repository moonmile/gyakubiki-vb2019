Public Class Form1

    Private cts As System.Threading.CancellationTokenSource

    Private Async Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        cts = New System.Threading.CancellationTokenSource()
        Dim result = Await Task.Run(Of Boolean)(
        Async Function()
            Dim time = DateTime.Now.AddSeconds(10)
            While DateTime.Now < time
                If cts.Token.IsCancellationRequested Then
                    Return False
                End If
                Me.Invoke(
                Sub()
                    label1.Text = DateTime.Now.ToString("HH:MM:ss.fff")
                End Sub)
                Await Task.Delay(100)
            End While
            Return True
        End Function, cts.Token)
        label1.Text = $"タスク結果：{result}"
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        ' タスクをキャンセルする
        cts.Cancel()
    End Sub
End Class
