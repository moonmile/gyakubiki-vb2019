Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim path = textBox1.Text
        If path = String.Empty Then
            Return
        End If
        If System.IO.File.Exists(path) = False Then
            MessageBox.Show("ファイルが見つかりませんでした")
            Return
        End If
        Dim sr As New System.IO.StreamReader(path)
        Dim Text = sr.ReadToEnd()
        sr.Close()
        textBox2.Text = Text
    End Sub
End Class
