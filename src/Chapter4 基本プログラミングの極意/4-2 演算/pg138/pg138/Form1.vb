Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim ret = checkBox1.Checked And checkBox2.Checked
        textBox1.Text = $"And 演算子の結果：{ret}"
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim ret = checkBox1.Checked Or checkBox2.Checked
        textBox1.Text = $"Or 演算子の結果：{ret}"
    End Sub
End Class
