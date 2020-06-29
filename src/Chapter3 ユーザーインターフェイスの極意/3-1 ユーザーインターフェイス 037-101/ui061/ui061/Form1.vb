Public Class Form1
    Private Sub CheckBox1_CheckedChanged(sender As Object,
            e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox1.ReadOnly = True   '読み取り専用に設定
            TextBox2.Enabled = False　　'使用不可に設定
        Else
            TextBox1.ReadOnly = False　'読み取り専用を解除
            TextBox2.Enabled = True　 '使用可に設定
        End If
    End Sub


End Class
