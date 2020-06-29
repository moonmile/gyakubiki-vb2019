Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        ' パスを示す
        label3.Text = "C:\VB2019\Sample.txt"
        'JSON形式
        label4.Text = "{ name: ""masuda"", country: ""Japan"" }"
        ' 改行を含む文字列
        label5.Text = "
このように改行を含めた
文章を書くことができる。
ヒアドキュメントを書くときに使う。
"
    End Sub
End Class
