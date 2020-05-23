Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim s1 = "ワイン"
        Dim s2 = "チーズ"

        label3.Text = $"{s1} と {s2}"
        label4.Text = $"{s1} の文字数は {s1.Length} です"
    End Sub
End Class
