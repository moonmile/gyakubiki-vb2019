Imports System.Runtime.InteropServices

Public Class Form1
    Private Function add(x As Integer, y As Integer) As Integer
        Return x + y
    End Function

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        ' 内部定義された関数
        Dim a = Integer.Parse(textBox1.Text)
        Dim b = Integer.Parse(textBox2.Text)

        Dim ans As Integer = add(a, b)
        label1.Text = ans.ToString()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        ' 内部定義されたラムダ式
        Dim add = Function(x, y)
                      Return x + y
                  End Function
        Dim a = Integer.Parse(textBox1.Text)
        Dim b = Integer.Parse(textBox2.Text)
        Dim ans As Integer = add(a, b)
        label1.Text = ans.ToString()
    End Sub
End Class
