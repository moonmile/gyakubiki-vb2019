Public Class Form1
    Private Sub Button1_Click(sender As Object,
            e As EventArgs) Handles Button1.Click
        Dim newForm As New Form2 'Form2のインスタンスを作成
        'フォームをモーダルで表示
        'フォーム表示中は別のフォームを選択できない
        newForm.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object,
            e As EventArgs) Handles Button2.Click
        Dim newForm As New Form2 'Form2のインスタンスを作成
        'フォームをモードレスで表示
        'フォーム表示中でも別のフォームを選択できる
        newForm.Show()
    End Sub
End Class
