Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        listBox1.Items.Clear()
        Dim i = 0
        While i < 10
            listBox1.Items.Add($"No. {i + 1}")
            i += 1
        End While
    End Sub
End Class
