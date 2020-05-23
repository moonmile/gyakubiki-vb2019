Imports System.Net.Http
Imports Newtonsoft.Json

Public Class Form1
    Private Async Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim cl As New HttpClient()
        Dim Uri As New Uri("http://localhost/api/json.php")
        Dim dic As New Dictionary(Of String, String)()
        dic.Add("name", textBox1.Text)
        dic.Add("age", textBox2.Text)
        Dim content = New FormUrlEncodedContent(dic)
        Dim Res = Await cl.PostAsync(Uri, content)
        Dim json = Await Res.Content.ReadAsStringAsync()
        Dim obj = JsonConvert.DeserializeObject(json)
        textBox3.Text = obj.Item("name")
        textBox4.Text = obj.Item("age").ToString()
    End Sub
End Class
