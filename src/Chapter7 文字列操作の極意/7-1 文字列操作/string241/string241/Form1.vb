Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim Text = textBox1.Text
        ' 文字を指定して分割
        Dim ary = Text.Split("/")
        listBox1.Items.Clear()
        For Each t In ary
            listBox1.Items.Add(t)
        Next
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim Text = textBox1.Text
        ' 文字列を指定して分割
        Dim ary = Text.Split(New String() {"/"},
            StringSplitOptions.None)
        listBox1.Items.Clear()
        For Each t In ary
            listBox1.Items.Add(t)
        Next
    End Sub
End Class
