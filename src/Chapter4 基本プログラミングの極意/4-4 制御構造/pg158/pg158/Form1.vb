Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim s1 = ""
        Dim s2 = ""
        ' チェックボックスを調べる
        For Each chk As CheckBox In groupBox1.Controls
            If chk.Checked Then
                s1 += chk.Text + "、"
                Continue For
            End If
            ' 残りの項目
            s2 += chk.Text + "、"
        Next
        label1.Text = $"{s1} を選択しました"
        label2.Text = $"{s2} が未選択でした"
    End Sub
End Class
