Imports System.Net.Http
Imports System.Net.Http.Headers
Imports Newtonsoft.Json

Public Class Form1
    Private Async Sub button1_Click(sender As Object, e As EventArgs) _
    Handles button1.Click
        Dim book = New Book() With {
        .ID = Integer.Parse(textBox1.Text),
        .Title = textBox2.Text,
        .Price = Integer.Parse(textBox3.Text),
        .Pages = Integer.Parse(textBox4.Text)}
        Dim json = JsonConvert.SerializeObject(book)
        Dim cl As New HttpClient()
        Dim cont As New StringContent(json)
        cont.Headers.ContentType =
        New MediaTypeHeaderValue("application/json")
        Dim res = Await cl.PostAsync($"http://localhost:5000/api/Books", cont)
        Dim text = Await res.Content.ReadAsStringAsync()
        textBox5.Text = text
    End Sub
End Class

''' 書籍クラス
Public Class Book
    Public Property ID As Integer
    Public Property Title As String
    Public Property Price As Integer
    Public Property Pages As Integer
End Class

