Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click

    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        label1.Text = "イベントで実行しました"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler button1.Click,
            Sub(s, ee)
                label1.Text = "ラムダ式で実行しました"
            End Sub
    End Sub
End Class
