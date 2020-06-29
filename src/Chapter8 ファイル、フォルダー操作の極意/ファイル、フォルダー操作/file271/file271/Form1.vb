Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim path = textBox1.Text
        If path = String.Empty Then
            Return
        End If
        Dim fs As New System.IO.StreamWriter(
            New System.IO.FileStream(path, System.IO.FileMode.Create))
        fs.Write(textBox2.Text)
        fs.Close()
        MessageBox.Show("ファイルに出力しました")
    End Sub
End Class
