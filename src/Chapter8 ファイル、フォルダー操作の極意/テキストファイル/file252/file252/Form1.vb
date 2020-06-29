Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim fname = System.IO.Directory.GetCurrentDirectory()
        textBox1.Text = fname
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim fname = textBox1.Text
        System.IO.Directory.SetCurrentDirectory(fname)
        MessageBox.Show("カレントフォルダーを設定しました")
    End Sub
End Class
