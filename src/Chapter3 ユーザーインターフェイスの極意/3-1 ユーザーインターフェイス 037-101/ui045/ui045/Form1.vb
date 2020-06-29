Public Class Form1

    Private Sub Form1_Load(sender As Object,
            e As EventArgs) Handles MyBase.Load
        'フォーム表示時に幅250ピクセル、高さ150ピクセルに設定
        Size = New Size(250, 150)
    End Sub

    Private Sub Button1_Click(sender As Object,
            e As EventArgs) Handles Button1.Click
        Width += 10     'フォームの幅を現在の値に10ピクセル加算する
        Height += 10    'フォームの高さを現在の値に10ピクセル加算する
    End Sub
End Class
