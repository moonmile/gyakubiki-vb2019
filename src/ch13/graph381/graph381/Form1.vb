Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim dlg As New OpenFileDialog() With {
            .Title = "画像を選択",
            .Filter = "画像ファイル(*.jpg)|*.jpg|画像ファイル(*.png)|*.png"
        }
        If dlg.ShowDialog() <> DialogResult.OK Then
            Return
        End If
        Dim path = dlg.FileName
        Dim img = Image.FromFile(path)
        If img Is Nothing Then
            MessageBox.Show("ファイルが開けませんでした")
            Return
        End If
        pictureBox1.Image = img
    End Sub
End Class
