Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim a = Integer.Parse(textBox1.Text)
        Dim b = Integer.Parse(textBox2.Text)
        Try
            test(a, b)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "エラー発生")
        End Try
    End Sub

    Public Sub test(a As Integer, b As Integer)
        Try
            If b = 0 Then
                Throw New DivideByZeroException("0で除算はできません")
            End If
            Dim ans = a / b
            MessageBox.Show($"ans: {ans}")
        Catch ex As ArgumentException
            MessageBox.Show(ex.Message, "エラー発生")
        End Try
    End Sub
End Class
