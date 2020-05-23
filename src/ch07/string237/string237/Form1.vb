Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim Text = textBox1.Text
        If String.IsNullOrEmpty(Text) Then
            Return
        End If
        label1.Text = "「" + Text.Trim() + "」"
        label2.Text = "「" + Text.TrimStart() + "」"
        label3.Text = "「" + Text.TrimEnd() + "」"
    End Sub
End Class
