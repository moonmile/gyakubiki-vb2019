Public Class Form1
    Private dic As New Dictionary(Of String, String)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dic.Add("JP", "Japan")
        dic.Add("CN", "China")
        dic.Add("KR", "Republic of Korea")
        dic.Add("GB", "United Kingdom")
        dic.Add("US", "United States of America")
        dic.Add("CA", "Canada")
        ' リストへ追加
        For Each it In dic
            listBox1.Items.Add($"{it.Key} {it.Value}")
        Next
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim key = textBox1.Text
        If dic.ContainsKey(key) = True Then
            label1.Text = dic(key)
        Else
            label1.Text = "値が存在しません"
        End If
    End Sub
End Class
