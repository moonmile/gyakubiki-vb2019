Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        ' 宣言と同時に初期化する
        Dim lst As New List(Of String)(
            {
                "ティラノサウルス",
                "ブラキオサウルス",
                "トリケラトプス",
                "ヴェロキラプトル",
                "マイアサウラ"
            })
        label1.Text = lst(0)
        label2.Text = lst.Count.ToString()
        listBox1.Items.Clear()
        listBox1.Items.AddRange(lst.ToArray())
    End Sub
End Class
