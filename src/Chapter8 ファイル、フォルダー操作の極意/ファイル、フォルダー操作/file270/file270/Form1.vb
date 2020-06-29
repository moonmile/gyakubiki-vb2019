Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim path = textBox1.Text
        If path = String.Empty Then
            Return
        End If
        Dim fs As New System.IO.StreamWriter(path)
        fs.WriteLine(DateTime.Now.ToString())  ' 日付
        fs.Write(textBox2.Text)                ' 出力データ
        fs.WriteLine("")                       ' 改行
        fs.Close()
        MessageBox.Show("ファイルに出力しました")
    End Sub
End Class
