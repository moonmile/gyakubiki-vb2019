Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim ary = New String() {"東京", "名古屋", "大阪"}
        '配列aryの要素数と要素の値を表示する
        Dim s1 = "配列aryの要素数：" & ary.Length & vbLf
        For Each it In ary
            s1 += $"{it} "
        Next
        label1.Text = s1
        '要素数を変更後、要素数と値を表示する
        Dim lst = ary.ToList()
        lst.Add("広島")
        lst.Add("福岡")
        ary = lst.ToArray()

        Dim s2 = $"変更後の要素数 : {ary.Length} " + vbCrLf
        For Each it In ary
            s2 += $"{it} "
        Next
        label2.Text = s2
    End Sub
End Class
