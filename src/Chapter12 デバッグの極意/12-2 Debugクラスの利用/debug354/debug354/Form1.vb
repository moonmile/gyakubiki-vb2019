Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        For i = 1 To 30
            ' iが25を超えたら警告メッセージを表示する
            Debug.Assert(i <= 25, "{i} : 定員オーバーです。")
        Next
    End Sub
End Class
