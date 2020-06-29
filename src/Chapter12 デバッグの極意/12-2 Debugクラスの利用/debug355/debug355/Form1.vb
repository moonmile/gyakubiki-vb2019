Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim eLog As New EventLogTraceListener("Debug355")
        Debug.Listeners.Add(eLog) ' 出力先を追加する
        Debug.WriteLine("button1がクリックされました。")
        Debug.Flush()
        MessageBox.Show("イベントログに出力しました。", "通知")
    End Sub
End Class
