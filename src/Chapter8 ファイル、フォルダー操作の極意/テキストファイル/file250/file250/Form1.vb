Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim fname1 = textBox1.Text
        Dim fname2 = textBox2.Text
        ' コピー元ファイル無し、あるいはコピー先ファイルあり
        ' または、コピー先がフォルダーならば終了する
        If System.IO.File.Exists(fname1) = False Then
            textBox3.Text = "コピー元のファイルがありません。"
        ElseIf System.IO.File.Exists(fname2) = True Then
            textBox3.Text = "コピー先のファイルがあります。"
        ElseIf System.IO.Directory.Exists(
        System.IO.Path.GetDirectoryName(fname2)) = False Then
            textBox3.Text = "コピー先はディレクトリです。"
        Else
            System.IO.File.Copy(fname1, fname2)
            textBox3.Text = $"{fname2}にコピーしました。"
        End If

    End Sub
End Class
