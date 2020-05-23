Public Class Form1
    Private Async Sub button1_Click(sender As Object, e As EventArgs) _
    Handles button1.Click
        Dim ret = Await Task.Run(Of String)(
        Async Function()
            Dim time = DateTime.Now.AddSeconds(10)
            While DateTime.Now < time
                Me.Invoke(
                Sub()
                    label1.Text = DateTime.Now.ToString("HH:MM:ss.fff")
                End Sub)
                Await Task.Delay(100)
            End While
            Return DateTime.Now.ToString() + " に完了"
        End Function)
        label2.Text = ret
    End Sub
End Class
