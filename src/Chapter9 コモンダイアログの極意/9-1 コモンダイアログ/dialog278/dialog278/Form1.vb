Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim dlg As New FolderBrowserDialog()
        '［新しいフォルダを作成］ボタンを表示しない
        dlg.ShowNewFolderButton = False

        If dlg.ShowDialog() = DialogResult.OK Then
            textBox1.Text = dlg.SelectedPath
        End If
    End Sub
End Class
