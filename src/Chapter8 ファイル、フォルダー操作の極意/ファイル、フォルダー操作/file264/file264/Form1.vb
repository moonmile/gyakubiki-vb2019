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
        Do
            Dim line = sr.ReadLine()
            If line Is Nothing Then
                Exit Do
            End If
            listBox1.Items.Add(line)
        Loop
        sr.Close()
    End Sub
End Class
