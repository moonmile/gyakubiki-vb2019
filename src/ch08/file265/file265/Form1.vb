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
        Dim sr = New System.IO.StreamReader(path)
        Do
            Dim ch As Integer = sr.Read()
            If ch = -1 Then
                Exit Do
            End If
            listBox1.Items.Add(ChrW(ch))
        Loop
        sr.Close()
    End Sub
End Class
