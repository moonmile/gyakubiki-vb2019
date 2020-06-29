Public Class Form1
    Private Sub Button1_Click(sender As Object,
            e As EventArgs) Handles Button1.Click
        Dim i As Integer
        For i = 0 To 1000
            System.Threading.Thread.Sleep(10) '1/100秒処理を待機
            ProgressBar1.Value = i
            ProgressBar1.Refresh()
        Next

    End Sub

    Private Sub Form1_Load(sender As Object,
            e As EventArgs) Handles MyBase.Load
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 1000
        ProgressBar1.Value = 0
    End Sub
End Class
