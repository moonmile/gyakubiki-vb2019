Public Class Form1
    Private Async Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Await Task.Run(
        Sub()
            For i = 0 To 10 - 1
                Me.Invoke(
                Sub()
                    label1.Text = $"{i} 秒経過"
                End Sub)
                System.Threading.Thread.Sleep(1000)
            Next
        End Sub)
        label1.Text = "完了"
    End Sub

    Private Async Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Await Task.Run(
        Async Function()
            For i = 0 To 10 - 1
                Me.Invoke(
                Sub()
                    label1.Text = $"{i} 秒経過"
                End Sub)
                Await Task.Delay(1000)
            Next
        End Function)
        label1.Text = "完了"
    End Sub
End Class
