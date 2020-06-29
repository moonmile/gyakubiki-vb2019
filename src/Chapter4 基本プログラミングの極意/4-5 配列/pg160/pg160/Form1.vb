Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim names = New String() {"荒俣", "夢野", "沼", "柄谷", "上野"}
        Dim index = comboBox1.SelectedIndex
        if index = -1 Then ' 選択されていないとき
            label1.Text = "クラスを選択してください。"
            Exit Sub
        End If
        label1.Text = comboBox1.SelectedItem +
            $" 担任：{names(index)} 先生"

    End Sub
End Class
