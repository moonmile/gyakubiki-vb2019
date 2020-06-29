Public Class Form1
    Private Sub Button1_Click(sender As Object,
          e As EventArgs) Handles Button1.Click
        Dim myButton As New Button
        'ボタンの設定をしてフォームに追加
        myButton.Text = "マイボタン"
        myButton.Size = New Size(90, 40)
        myButton.Location = New Point(90, 85)
        Controls.Add(myButton)
        'イベントとイベントハンドラーを関連付ける
        AddHandler myButton.Click, AddressOf myHandler

    End Sub

    Private Sub myHandler(sender As Object, e As EventArgs)
        MessageBox.Show("マイボタンがクリックされました", "結果")
    End Sub
End Class
