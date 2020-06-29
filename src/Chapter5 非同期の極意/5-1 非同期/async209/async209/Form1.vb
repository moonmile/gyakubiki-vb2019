Public Class Form1
    Private Async Function onWork() As Task(Of Integer)
        Dim sum = 0
        For i = 1 To 100
            sum += i
            Me.Invoke(
        Sub()
            label1.Text = DateTime.Now.ToString("HH:MM:ss.fff")
        End Sub)
            Await Task.Delay(100)
        Next
        Return sum
    End Function

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        ' 非同期でタスクを実行
        ' UI スレッドを占有しない
        Task.Run(Of Integer)(
    Function()
        Return onWork()
    End Function).ContinueWith(
    Sub(t)
        Dim sum = t.Result
        Me.Invoke(
        Sub()
            label2.Text = $"合計値: {sum}"
        End Sub)
    End Sub)
    End Sub


End Class
