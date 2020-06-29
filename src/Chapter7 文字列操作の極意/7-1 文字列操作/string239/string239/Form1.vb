Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim text1 = textBox1.Text
        Dim text2 = textBox2.Text
        If text1.Length < 2 Then
            ' 2文字未満ならば終了する
            Return
        End If
        textBox3.Text = text1.Insert(2, text2)
    End Sub
End Class
