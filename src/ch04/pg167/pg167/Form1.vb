Public Class Form1
    Private lst As New List(Of String)

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        ' 項目をひとつ追加
        lst.Add(DateTime.Now.ToString())
        ' 結果をリストボックスに表示
        listBox1.Items.Clear()
        listBox1.Items.AddRange(lst.ToArray())
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        ' 項目をすべて削除
        lst.Clear()
        ' 結果をリストボックスに表示
        listBox1.Items.Clear()
        listBox1.Items.AddRange(lst.ToArray())
    End Sub
End Class
