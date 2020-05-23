Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        listBox1.Items.Clear()
        For i = 0 To 10 - 1
            listBox1.Items.Add($"No. {i + 1}")
        Next
    End Sub
End Class
