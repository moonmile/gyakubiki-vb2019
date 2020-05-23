Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim path = textBox1.Text
        If path = String.Empty Then
            Return
        End If
        If System.IO.File.Exists(path) = False Then
            MessageBox.Show("ファイルが見つかりません")
            Return
        End If
        Dim fs = System.IO.File.OpenRead(path)
        MessageBox.Show("読み取り専用でファイルを開きました")
        fs.Close()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim path = textBox1.Text
        If path = String.Empty Then
            Return
        End If
        If System.IO.File.Exists(path) = False Then
            MessageBox.Show("ファイルが見つかりません")
            Return
        End If
        Dim fs = System.IO.File.OpenWrite(path)
        MessageBox.Show("書き込み用にファイルを開きました")
        fs.Close()
    End Sub
End Class
