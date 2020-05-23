Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim i As Integer

        ' 行頭に 「'」を記述する
        i = 100 * 2 ' 行の途中からもコメントにできます
        ' 次の行は行頭に「'」があるので実行されません
        ' i += 100

        '
        ' 複数コメントの例です
        '
        MessageBox.Show($"i = {i}", "確認")
    End Sub
End Class
