Public Class Form1
    Private Async Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        progressBar1.Minimum = 0
        progressBar1.Maximum = 100
        ' 完了フラグ
        Dim complete = False
        ' 進捗率
        Dim raito = 0
        ' タスクバーを更新する
        Dim t = New Task(
    Async Sub()
        While complete = False
            Me.Invoke(
            Sub()
                label1.Text = $"進捗率：{raito} %"
                progressBar1.Value = raito
            End Sub)
            Await Task.Delay(100)
        End While
    End Sub)
        t.Start()

        ' 計算タスク
        Dim result = Await Task.Run(Of Integer)(
    Async Function()
        Dim sum = 0
        For i = 1 To 100
            raito = i
            sum += i
            Await Task.Delay(100)
        Next
        complete = True
        Return sum
    End Function)
        label2.Text = $"合計値: {result}"
    End Sub
End Class
