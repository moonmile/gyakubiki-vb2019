Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim tLis As New TextWriterTraceListener("C:\VB2019\Debug.txt")
        Debug.Listeners.Add(tLis) ' 出力先を追加する
        For i = 0 To 9
            Debug.WriteLine($"{i}回目")
        Next
        Debug.Flush() ' 出力バッファをフラッシュ
        MessageBox.Show("ファイルに出力しました。", "通知")
    End Sub
End Class
