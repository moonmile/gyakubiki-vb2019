Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim proc = New System.Diagnostics.Process()
        ' メモ帳を起動する
        proc.StartInfo.FileName = "notepad.exe"
        proc.Start()
    End Sub
End Class
