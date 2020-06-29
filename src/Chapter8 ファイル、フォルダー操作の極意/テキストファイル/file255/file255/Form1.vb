Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim fname = textBox1.Text
        If System.IO.Directory.Exists(fname) = False Then
            MessageBox.Show($"{fname}が見つかりません")
            Return
        End If
        listBox1.Items.Clear()
        For Each it In System.IO.Directory.GetDirectories(fname)
            listBox1.Items.Add(it)
        Next
    End Sub
End Class
