Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
            Handles Button1.Click
        'TextBox1にTextBox2の文字列と改行記号を追加する
        '引数のあるメソッド
        TextBox2.AppendText(TextBox1.Text + Environment.NewLine)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) _
            Handles Button2.Click
        'TextBox2の文字列を消去する
        '引数のないメソッド
        TextBox2.Clear()
    End Sub
End Class
