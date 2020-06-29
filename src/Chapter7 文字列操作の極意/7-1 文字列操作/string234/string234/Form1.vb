Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim text1 = textBox1.Text
        Dim text2 = textBox2.Text
        Dim ret = text1.CompareTo(text2) ' 比較
        If ret = 0 Then
            textBox3.Text = "同じです。"
        ElseIf ret < 0 Then
            textBox3.Text = text1 + "の方が小さいです。"
        Else
            textBox3.Text = text1 + "の方が大きいです。"
        End If
    End Sub
End Class
