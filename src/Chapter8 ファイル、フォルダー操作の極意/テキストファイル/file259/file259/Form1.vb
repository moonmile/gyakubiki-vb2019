Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim path = textBox1.Text
        If System.IO.File.Exists(path) = False Then
            Return
        End If
        System.IO.File.SetAttributes(path,
            System.IO.FileAttributes.ReadOnly)
        MessageBox.Show($"{path}を読み取り専用に設定しました。")
    End Sub
End Class
