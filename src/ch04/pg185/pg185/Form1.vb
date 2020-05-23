Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim text = ""
        Dim lst As new List(Of Integer)(
                { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 })

        ' ForEachメソッドでラムダ式を使用
        lst.ForEach(Function(x)
                        text += $"{x * x},"
                        Return text
                    End Function)
        label1.Text = text
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim text = ""
        Dim lst As New List(Of Integer)(
                {1, 2, 3, 4, 5, 6, 7, 8, 9, 10})

        ' For Eachステートメントで繰り返し処理
        For Each x In lst
            text += $"{x * x},"
        Next
        label1.Text = text
    End Sub
End Class
