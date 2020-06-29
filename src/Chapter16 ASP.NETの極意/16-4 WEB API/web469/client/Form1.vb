Imports System.Net.Http
Imports System.Net.Http.Headers
Imports Newtonsoft.Json

Public Class Form1
    Private Async Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim Uri As New Uri(textBox1.Text)
        Dim cl As New HttpClient()
        Dim Book = New Book() With {
            .ID = Integer.Parse(textBox2.Text),
            .Title = textBox3.Text,
            .Price = Integer.Parse(textBox4.Text),
            .Pages = Integer.Parse(textBox5.Text)
        }
        Dim json = JsonConvert.SerializeObject(Book)
        Dim content = New StringContent(json)
        content.Headers.ContentType =
                New MediaTypeHeaderValue("application/json")
        Dim Res = Await cl.PostAsync(Uri, content)
        textBox6.Text = Await Res.Content.ReadAsStringAsync()
    End Sub
End Class

''' 書籍クラス
Public Class Book
    Public Property ID As Integer
    Public Property Title As String
    Public Property Price As Integer
    Public Property Pages As Integer
End Class


