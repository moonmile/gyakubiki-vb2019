Imports System.Net.Http
Imports System.Net.Http.Headers
Imports Newtonsoft.Json

Public Class Form1
    Private Async Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim cl As New HttpClient()
        Dim Uri As New Uri("http://localhost:5000/api/Sample")
        Dim obj As New With {
            .Name = "MASUDA",
            .Age = 51,
            .Address = "Itabshi"}
        Dim json = JsonConvert.SerializeObject(obj)
        Dim content = New StringContent(json)
        ' コンテキストタイプを指定する
        content.Headers.ContentType =
            New MediaTypeHeaderValue("application/json")
        Dim Res = Await cl.PostAsync(Uri, content)
        textBox1.Text = Await Res.Content.ReadAsStringAsync()
    End Sub
End Class
