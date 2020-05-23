Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim dlg As New SaveFileDialog() With {
            .Title = "保存する画像ファイルの選択",
            .Filter = "画像ファイル(*.jpg)|*.jpg|画像ファイル(*.png)|*.png"
        }
        If dlg.ShowDialog() = DialogResult.Cancel Then
            Return
        End If
        textBox1.Text = System.IO.Path.GetFileName(dlg.FileName)
        If dlg.FilterIndex = 1 Then
            pictureBox1.Image.Save(dlg.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
        Else
            pictureBox1.Image.Save(dlg.FileName, System.Drawing.Imaging.ImageFormat.Png)
        End If
        textBox2.Text = "保存しました"
    End Sub
End Class
