Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim path = textBox1.Text
        If System.IO.File.Exists(path) = False Then
            Return
        End If
        Dim attr = System.IO.File.GetAttributes(path)
        checkBox1.Checked =
            (attr And System.IO.FileAttributes.ReadOnly) <> 0
        checkBox2.Checked =
            (attr And System.IO.FileAttributes.Hidden) <> 0
        checkBox3.Checked =
            (attr And System.IO.FileAttributes.Compressed) <> 0
        checkBox4.Checked =
            (attr And System.IO.FileAttributes.System) <> 0
    End Sub
End Class
