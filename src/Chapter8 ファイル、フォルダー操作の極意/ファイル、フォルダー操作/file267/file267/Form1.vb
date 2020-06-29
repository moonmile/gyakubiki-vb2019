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
        listBox1.Items.Clear()
        Dim sr As New System.IO.StreamReader(path)
        While sr.Peek() <> -1
            Dim line = sr.ReadLine()
            listBox1.Items.Add(line)
        End While
        sr.Close()
    End Sub
End Class
