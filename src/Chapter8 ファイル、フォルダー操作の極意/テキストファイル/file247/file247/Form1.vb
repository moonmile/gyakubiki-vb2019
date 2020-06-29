Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim fname = textBox1.Text
        If System.IO.Directory.Exists(fname) = True Then
            textBox2.Text = $"{fname}が見つかりました"
        ElseIf System.IO.File.Exists(fname) = True Then
            textBox2.Text = $"{fname}が見つかりました"
        Else
            textBox2.Text = $"{fname}が見つかりませんでした"
        End If
    End Sub
End Class
