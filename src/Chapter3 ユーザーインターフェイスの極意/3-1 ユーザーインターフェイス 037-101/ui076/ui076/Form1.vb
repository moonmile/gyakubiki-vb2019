Public Class Form1
    Private Sub Form1_Load(sender As Object,
            e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("レモン")
        ComboBox1.Items.Add("リンゴ")
        ComboBox1.Items.Add("ブドウ")
        ComboBox1.Items.Add("メロン")
    End Sub

    Private Sub Button1_Click(sender As Object,
            e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex = -1 Then
            Label1.Text = "選択されていません"
        Else
            Label1.Text = ComboBox1.Text
        End If
    End Sub
End Class
