Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim path = textBox1.Text
        If path = String.Empty Then
            Return
        End If
        Dim fs = System.IO.File.AppendText(path)
        fs.WriteLine(textBox2.Text)
        fs.Close()
        MessageBox.Show("ファイルに追加しました")
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim path = textBox1.Text
        If path = String.Empty Then
            Return
        End If
        Dim fs As New System.IO.StreamWriter(path, True,
            System.Text.Encoding.GetEncoding("shift_jis"))
        fs.WriteLine(textBox2.Text)
        fs.Close()
        MessageBox.Show("ファイルに追加しました")
    End Sub
End Class
