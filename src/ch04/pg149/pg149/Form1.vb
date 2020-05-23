Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim dt As DateTime
        Dim ret = DateTime.TryParse(textBox1.Text, dt)
        If ret Then
            label1.Text = dt.ToString()
        Else
            label1.Text = "DateTime型の値に変換できません。"
        End If
    End Sub
End Class
