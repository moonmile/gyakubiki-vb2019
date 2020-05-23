Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim fname = textBox1.Text
        If System.IO.Directory.Exists(fname) = True Then
            System.IO.Directory.Delete(fname)
            textBox2.Text = $"{fname}を削除しました"
        ElseIf System.IO.File.Exists(fname) = True Then
            System.IO.File.Delete(fname)
            textBox2.Text = $"{fname}を削除しました"
        Else
            textBox2.Text = $"{fname}が見つかりませんでした"
        End If
    End Sub
End Class
