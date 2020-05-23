Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        ' 最初の引数のみ指定
        label1.Text = checkTest(True)
        ' ２番目の引数を１つ指定
        label2.Text = checkTest(False, "国語")
        ' ２番目の引数を３つ指定
        label3.Text = checkTest(False, "国語", "数学", "英語")
    End Sub

    Private Function checkTest(result As Boolean, ParamArray kamoku As String()) As String
        If result = True Then
            Return "合格"
        Else
            Dim gouhi = "追試 -> "
            For Each it In kamoku
                gouhi += it + ", "
            Next
            Return gouhi
        End If
    End Function
End Class
