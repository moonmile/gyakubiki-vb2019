Imports System.Net.Http
Imports System.Net.Http.Headers

Public Class Form1
    Private Async Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim doc = <Book>
                      <ID>{textBox1.Text}</ID>
                      <Title>{textBox2.Text}</Title>
                      <Price>{textBox3.Text}</Price>
                      <Page>{textBox4.Text}</Page>
                  </Book>
        Dim xml = doc.ToString()
        Dim cl As New HttpClient()
        Dim cont As New StringContent(xml)
        cont.Headers.ContentType =
        New MediaTypeHeaderValue("application/xml")
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

