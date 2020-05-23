Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        listBox1.Items.Clear()
        Dim i = 100
        Do
            listBox1.Items.Add($"No. {i}")
            i += 1
        Loop While i < 10
    End Sub
End Class
