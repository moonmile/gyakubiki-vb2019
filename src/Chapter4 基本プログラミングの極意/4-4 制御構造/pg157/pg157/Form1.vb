Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim s = ""
        ' チェック済みを調べる
        For Each chk As CheckBox In groupBox1.Controls
            If chk.Checked Then
                s += chk.Text + "、"
            End If
            label1.Text = $"{s} を選択しました"
        Next
    End Sub
End Class
