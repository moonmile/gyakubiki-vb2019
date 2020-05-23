Public Class Form1
    ' 初期のラムダ式を設定しておく
    Private _func As Func(Of Integer, Integer, Integer) =
    Function(x, y)
        Return 0
    End Function


    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        If radioButton1.Checked Then
            _func = Function(x, y)
                        Return x + y
                    End Function
        ElseIf radioButton2.Checked Then
            _func = Function(x, y)
                        Return x * y
                    End Function
        ElseIf radioButton3.Checked Then
            _func = Function(x, y)
                        Return Math.Pow(x, y)
                    End Function
        End If
    End Sub

    ' ラムダ式を実行
    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim a = Integer.Parse(textBox1.Text)
        Dim b = Integer.Parse(textBox2.Text)
        Dim ans = _func(a, b)
        label1.Text = ans.ToString()
    End Sub
End Class
