Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        ' 先頭の項目を削除
        lst.RemoveAt(0)
        ' 表示する
        listBox1.Items.Clear()
        listBox1.Items.AddRange(lst.ToArray())
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        ' 項目を指定して削除
        lst.Remove("トリケラトプス")
        ' 表示する
        listBox1.Items.Clear()
        listBox1.Items.AddRange(lst.ToArray())
    End Sub

    Private lst As New List(Of String)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lst = New List(Of String)({
            "ティラノサウルス",
            "ブラキオサウルス",
            "トリケラトプス",
            "ヴェロキラプトル",
            "マイアサウラ"
        })
        listBox1.Items.AddRange(lst.ToArray())
    End Sub
End Class
