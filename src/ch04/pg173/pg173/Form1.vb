Public Class Form1
    Private dic As New Dictionary(Of Integer, String)

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim id = Integer.Parse(textBox1.Text)
        Dim Text = textBox2.Text
        ' キーと値を追加
        dic.Add(id, Text)

        ' dic(id)=text //インデクサ使用

        ' 表示
        listBox1.Items.Clear()
        For Each it In dic
            listBox1.Items.Add($"{it.Key} {it.Value}")
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
