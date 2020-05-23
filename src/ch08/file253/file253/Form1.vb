Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim fname = textBox1.Text
        If fname = String.Empty Then
            Return
        End If
        System.IO.Directory.CreateDirectory(fname)
        textBox2.Text = $"{fname}を作成しました。"
    End Sub
End Class
