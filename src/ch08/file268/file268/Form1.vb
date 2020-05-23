Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim path = textBox1.Text
        If path = String.Empty Then
            Return
        End If
        Dim fs = System.IO.File.CreateText(path)
        fs.Close()
        MessageBox.Show("ファイルを作成しました")
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim path = textBox1.Text
        If path = String.Empty Then
            Return
        End If
        Dim fs = New System.IO.StreamWriter(path, False,
        System.Text.Encoding.GetEncoding("shift_jis"))
        fs.Close()
        MessageBox.Show("ファイルを作成しました")
    End Sub
End Class
