Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim num = 0
        num = Integer.Parse(textBox1.Text)
        Dim x = If(num < 0 Or num > 100, -1, num)
        ' 以下と同じ
        'Dim x
        'If num < 0 Or num > 100 Then
        '    x = -1
        'Else
        '    x = num
        'End If
        label1.Text = $"入力した数値は {num} です。"
        label2.Text = $"補正した数値は {x} です。"
    End Sub
End Class
