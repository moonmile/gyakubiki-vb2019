Public Class Form1
    Private dic As New Dictionary(Of String, ValueTuple(Of String, String))
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dic.Add("JP", ("Japan", "日本"))
        dic.Add("CN", ("China", "中国"))
        dic.Add("KR", ("Republic of Korea", "韓国"))
        dic.Add("GB", ("United Kingdom", "イギリス"))
        dic.Add("US", ("United States of America", "アメリカ"))
        dic.Add("CA", ("Canada", "カナダ"))
        ' リストへ表示
        For Each it In dic
            listBox1.Items.Add($"{it.Key} {it.Value}")
        Next
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        listBox2.Items.Clear()
        Dim Keys = dic.Keys
        For Each it In Keys
            listBox2.Items.Add(it)
        Next
    End Sub

End Class
