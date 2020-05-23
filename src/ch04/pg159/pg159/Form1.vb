Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim ary(5) As Integer
        Dim s = ""
        For i = 0 To ary.Length - 1
            ary(i) = i * 2
            s += $"ary({i}) = {ary(i)}" + vbCrLf
        Next
        textBox1.Text = s
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim ary(2, 3) As Integer
        Dim s = ""
        For i = 0 To 1
            For j = 0 To 2
                ary(i, j) = i + j
                s += $"ary({i}, {j}) = {ary(i, j)}" + vbCrLf
            Next
        Next
        textBox1.Text = s
    End Sub
End Class
