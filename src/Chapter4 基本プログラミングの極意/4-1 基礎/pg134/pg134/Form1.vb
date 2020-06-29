Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim x As Integer?
        If textBox1.Text = "" Then
            x = Nothing
        Else
            x = Integer.Parse(textBox1.Text)
        End If

        If x Is Nothing Then
            label1.Text = "値がありません"
            label2.Text = ""
        Else
            label1.Text = "値があります"
            label2.Text = x.ToString()
        End If
    End Sub
End Class
