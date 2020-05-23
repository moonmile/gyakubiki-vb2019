Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim dlg As New OpenFileDialog() With {
            .Title = "画像ファイルの選択",
            .CheckFileExists = True,
            .RestoreDirectory = True,
            .Filter = "イメージファイル|*.bmp;*.jpg;*.gif;*.png"
        }
        If dlg.ShowDialog() = DialogResult.OK Then
            textBox1.Text = dlg.FileName
            textBox2.Text = dlg.SafeFileName
            pictureBox1.Image = Image.FromFile(dlg.FileName)
        Else
            textBox1.Text = ""
            textBox2.Text = ""
            pictureBox1.Image = Nothing
        End If
    End Sub
End Class
