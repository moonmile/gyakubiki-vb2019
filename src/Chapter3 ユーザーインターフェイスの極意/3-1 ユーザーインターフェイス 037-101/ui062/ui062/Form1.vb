Public Class Form1
    Private Sub Button1_Click(sender As Object,
            e As EventArgs) Handles Button1.Click
        If TextBox1.Text.Length < 4 Then
            Label3.Text = TextBox1.Text.Length & "…4文字以上必要です"
        Else
            Label3.Text = TextBox1.Text.Length
        End If
    End Sub


End Class
