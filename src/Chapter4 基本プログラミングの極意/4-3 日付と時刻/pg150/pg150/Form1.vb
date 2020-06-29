Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim dt = DateTime.Now ' 現在の日時を取得
        label1.Text = dt.ToString()
        label2.Text = dt.ToShortDateString()
        label3.Text = dt.ToString("yyyy年MM月dd日(ddd)")
    End Sub
End Class
