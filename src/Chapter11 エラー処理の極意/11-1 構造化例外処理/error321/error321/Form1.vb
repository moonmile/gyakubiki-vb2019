Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim Text = textBox1.Text
        Try
            Dim a = sample(Text)
        Catch ex As FormatException
            MessageBox.Show(ex.Message, "エラー発生")
        End Try
    End Sub

    Function sample(text As String) As Integer
        Dim a = Integer.Parse(text)
        Return a
    End Function

End Class
