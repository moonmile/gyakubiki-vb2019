Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim fname = textBox1.Text
        If System.IO.Directory.Exists(fname) = True Then
            textBox2.Text = System.IO.Directory.GetCreationTime(fname).ToString()
        ElseIf System.IO.File.Exists(fname) = True Then
            textBox2.Text = System.IO.File.GetCreationTime(fname).ToString()
        Else
            textBox2.Text = $"{fname}が見つかりませんでした。"
        End If
    End Sub
End Class
