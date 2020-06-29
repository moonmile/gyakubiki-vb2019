Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim path = textBox1.Text
        If path = String.Empty Then
            Return
        End If
        Dim data = New Byte(1024) {}
        For i = 0 To data.Length - 1
            data(i) = &HFF
        Next
        Dim fs = System.IO.File.Create(path)
        For i = 0 To 1024 * 100 - 1
            fs.Write(data, 0, data.Length)
        Next
        fs.Close()
        MessageBox.Show("100MBのファイルを作成しました")
    End Sub
End Class
