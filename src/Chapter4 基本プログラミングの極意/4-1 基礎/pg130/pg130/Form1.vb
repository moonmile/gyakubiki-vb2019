Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim s1 = "ワイン"
        Dim s2 = "チーズ"

        label3.Text = "C:\VB2019\Sample.txt"
        label4.Text = s1 + vbCrLf + s2
    End Sub
End Class
