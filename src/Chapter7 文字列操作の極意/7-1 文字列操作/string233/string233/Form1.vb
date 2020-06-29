Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim Text = textBox1.Text
        Dim pos = -1

        listBox1.Items.Clear()
        While True
            pos = Text.IndexOf("カキ", pos + 1)
            If pos = -1 Then
                Exit While
            End If
            listBox1.Items.Add($"{pos + 1}文字目")
        End While
    End Sub
End Class
