Imports Newtonsoft.Json

Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim json = "{ name: ""masuda"", age: 51 }"
        ' object 型に変換してプロパティを使う
        Dim o = JsonConvert.DeserializeObject(json)
        label3.Text = o.Item("name").Value
        label4.Text = o.Item("age").Value.ToString()
    End Sub
End Class
