Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        ' 例外を発生させる
        Dim a = Integer.Parse("間違った値")
    End Sub
End Class
