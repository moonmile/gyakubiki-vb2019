Imports System.Net.Http
Imports System.Net.Http.Headers
Imports Newtonsoft.Json

Public Class Form1
    Private Async Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim Uri As New Uri(textBox1.Text)
        Dim cl As New HttpClient()
        Dim Res = Await cl.GetAsync(Uri)
        Dim json = Await Res.Content.ReadAsStringAsync()
        Dim book = JsonConvert.DeserializeObject(Of Book)(json)
        textBox6.Text =
            $"ID: {book.ID}" + vbCrLf +
            $"Title: {book.Title}" + vbCrLf +
            $"Price: {book.Price}" + vbCrLf +
            $"Pages: {book.Pages}" + vbCrLf
    End Sub
End Class

''' 書籍クラス
Public Class Book
    Public Property ID As Integer
    Public Property Title As String
    Public Property Price As Integer
    Public Property Pages As Integer
End Class

