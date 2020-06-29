Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim Text = textBox1.Text
        If Text.StartsWith("My") Then
            label1.Text = "My で始まっている"
        Else
            label1.Text = "My で始まっていない"
        End If
    End Sub
End Class
