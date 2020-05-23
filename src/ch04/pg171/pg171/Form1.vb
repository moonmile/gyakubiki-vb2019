Public Class Form1
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

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        ' リスト全体をコピー
        Dim lst2 = lst.ToList()
        ' 表示する
        listBox1.Items.Clear()
        listBox1.Items.AddRange(lst.ToArray())
        listBox2.Items.Clear()
        listBox2.Items.AddRange(lst2.ToArray())
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        ' 検索しながらコピー
        Dim lst2 = lst.Where(Function(t)
                                 Return t.EndsWith("ウルス")
                             End Function
        ).ToList()
        ' 表示する
        listBox1.Items.Clear()
        listBox1.Items.AddRange(lst.ToArray())
        listBox2.Items.Clear()
        listBox2.Items.AddRange(lst2.ToArray())
    End Sub
End Class
