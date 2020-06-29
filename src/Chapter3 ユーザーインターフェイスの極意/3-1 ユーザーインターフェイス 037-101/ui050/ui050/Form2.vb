Public Class Form2
    Private Sub Button1_Click(sender As Object,
        e As EventArgs) Handles Button1.Click
        'Button1のプロパティウィンドウのDialogResultプロパティに
        'Yesが設定されているため、結果を設定するコードを省略
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object,
            e As EventArgs) Handles Button2.Click
        '「NO」がクリックされたとき、
        'フォームのDialogResultプロパティにOKを設定する
        DialogResult = DialogResult.No
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object,
            e As EventArgs) Handles Button3.Click
        '「Cancel」がクリックされたとき、
        'フォームのDialogResultプロパティにOKを設定する
        DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class