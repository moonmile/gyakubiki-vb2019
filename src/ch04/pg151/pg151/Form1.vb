Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim num = 0
        ' 入力されているかどうかをチェック
        If textBox1.Text = "" Then
            label1.Text = "数値を入力してください"
            Return
        End If
        ' 数値かどうかをチェック
        If Integer.TryParse(textBox1.Text, num) = False Then
            label1.Text = "数字で入力してください"
            Return
        End If
        ' 範囲をチェック
        If num < 0 Or num > 100 Then
            label1.Text = "範囲を正しく入力してください"
            Return
        End If
        ' 数値を表示する
        label1.Text = $"入力した数値は {num} です。"
    End Sub
End Class
