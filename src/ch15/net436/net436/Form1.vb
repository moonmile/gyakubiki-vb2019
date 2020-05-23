Imports System.Net.Http
Imports System.Net.Http.Headers
Imports Newtonsoft.Json

Public Class Form1
    Private _cookie As String
    ' 自前でCookieを指定する
    Private Async Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim cl As New HttpClient()
        Dim Uri As New Uri("http://localhost:5000/api/Sample")
        Dim obj As New With {
                .Name = "MASUDA",
                .Age = 51,
                .Address = "Itabshi"}
        Dim json = JsonConvert.SerializeObject(obj)
        Dim content As New StringContent(json)
        content.Headers.ContentType =
                New MediaTypeHeaderValue("application/json")
        ' クッキーを設定する
        If _cookie IsNot Nothing Then
            content.Headers.Add("Cookie", _cookie)
        End If
        Dim Res = Await cl.PostAsync(Uri, content)
        ' クッキーを取得する
        _cookie = Res.Headers.GetValues("Set-Cookie").First()
        textBox1.Text = Await Res.Content.ReadAsStringAsync()
    End Sub

    Private _cl As HttpClient
    ' 自動でCookieを指定する
    Private Async Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        If _cl Is Nothing Then
            _cl = New HttpClient(
                New HttpClientHandler() With {.UseCookies = True})
        End If
        Dim Uri As New Uri("http://localhost:5000/api/Sample")
        Dim obj As New With {
            .Name = "MASUDA",
            .Age = 51,
            .Address = "Itabshi"
        }
        Dim json = JsonConvert.SerializeObject(obj)
        Dim content As New StringContent(json)
        content.Headers.ContentType =
            New MediaTypeHeaderValue("application/json")
        Dim Res = Await _cl.PostAsync(Uri, content)
        textBox1.Text = Await Res.Content.ReadAsStringAsync()
    End Sub
End Class
