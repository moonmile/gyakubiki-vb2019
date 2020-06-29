Public Class Form1
    Private _task As Task
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        _task = New Task(
        Async Sub()
            Dim time = DateTime.Now.AddSeconds(10)
            While DateTime.Now < time
                Me.Invoke(
                    Sub()
                        label1.Text = DateTime.Now.ToString("HH:MM:ss.fff")
                    End Sub)
                Await Task.Delay(100)
            End While
        End Sub)
        _task.Start()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        _task = New Task(AddressOf onWork)
        _task.Start()
    End Sub
    Private Async Sub onWork()
        Dim time = DateTime.Now.AddSeconds(10)
        While DateTime.Now < time
            Me.Invoke(
            Sub()
                label1.Text = DateTime.Now.ToString("HH:MM:ss.fff")
            End Sub)
            Await Task.Delay(100)
        End While
    End Sub
End Class
