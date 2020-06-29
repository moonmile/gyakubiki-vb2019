Imports System.Net.Http
Imports Newtonsoft.Json

Public Class Form1
    Private Async Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim cl As New HttpClient()
        ' ヘッダにAPI-KEYを指定する
        cl.DefaultRequestHeaders.Add("X-API-KEY", "XXXX-XXXX-XXXX")
        Dim Uri As New Uri("http://localhost:5000/api/Sample")
        Dim obj As New With {
            .Name = "MASUDA",
            .Age = 51,
            .Address = "Itabshi"}
        Dim json = JsonConvert.SerializeObject(obj)
        Dim content As New StringContent(json)
        Dim Res = Await cl.PostAsync(Uri, content)
        textBox1.Text = Await Res.Content.ReadAsStringAsync()
    End Sub
End Class
