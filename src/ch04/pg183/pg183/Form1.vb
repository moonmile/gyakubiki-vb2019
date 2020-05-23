Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        label1.Text = add(10, 20).ToString()
        label2.Text = add("masuda", "tomoaki")
        label3.Text = add("ABC", 5)
    End Sub

    ' 数値を加算する
    Function add(x As Integer, y As Integer) As Integer
        Return x + y
    End Function

    ' 文字列を結合する
    Function add(x As String, y As String) As String
        Return x + " " + y
    End Function

    ' 指定した数だけ文字列を結合する
    Function add(x As String, n As Integer) As String
        Dim result = ""
        For i = 0 To n - 1
            result += x + " "
        Next
        Return result
    End Function

End Class
