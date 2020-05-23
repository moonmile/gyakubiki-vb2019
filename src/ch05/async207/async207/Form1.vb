Public Class Form1
    Private Async Function button1_Click(sender As Object, e As EventArgs) As Task Handles button1.Click
        ' 順番にタスクを実行
        Await Task.Run(Async Function()
                           Await onWork(label1)
                       End Function)
        Await Task.Run(Async Function()
                           Await onWork(label2)
                       End Function)
    End Function

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        ' 同時ににタスクを実行
        Task.Run(Sub()
                     onWork(label1)
                 End Sub)
        Task.Run(Sub()
                     onWork(label2)
                 End Sub)

    End Sub

    Private Async Function onWork(Label As Label) As Task
        Dim time = DateTime.Now.AddSeconds(10)
        While DateTime.Now < time
            Me.Invoke(
            Sub()
                Label.Text = DateTime.Now.ToString("HH:MM:ss.fff")
            End Sub)
            Await Task.Delay(100)
        End While
    End Function



End Class
