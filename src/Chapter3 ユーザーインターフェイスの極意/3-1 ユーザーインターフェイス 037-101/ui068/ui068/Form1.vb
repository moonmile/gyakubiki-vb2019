Public Class Form1
    Private Sub RadioButton1_CheckedChanged(sender As Object,
            e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            PictureBox1.Image = Image.FromFile("C:\VB2019\onomichi01.bmp")
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        Else
            PictureBox1.Image.Dispose()
            PictureBox1.Image = Nothing
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object,
            e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            PictureBox1.Image = My.Resources.onomichi02
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        Else
            PictureBox1.Image.Dispose()
            PictureBox1.Image = Nothing
        End If
    End Sub
End Class
