Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim answer As Double      ' 数値型で宣言

        'テキストボックスの文字列をDouble型に変換して計算する
        answer = Double.Parse(textBox1.Text) +
                Double.Parse(textBox2.Text)

        ' Double型の数値を文字列に変換して表示する
        textBox3.Text = answer.ToString()

    End Sub
End Class
