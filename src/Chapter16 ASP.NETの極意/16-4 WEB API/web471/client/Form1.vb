Imports System.Net.Http
Imports System.Net.Http.Headers

Public Class Form1
    Private Async Sub button1_Click(sender As Object, e As EventArgs) _
Handles button1.Click
        Dim Uri As New Uri(textBox1.Text)
        Dim cl As New HttpClient()
        cl.DefaultRequestHeaders.Accept.Add(
        New MediaTypeWithQualityHeaderValue("application/xml"))
        Dim Res = Await cl.GetAsync(Uri)
        Dim st = Await Res.Content.ReadAsStreamAsync()
        Dim doc = XDocument.Load(st)
        textBox6.Text = doc.ToString()
    End Sub
End Class
''' 書籍クラス
Public Class Book
    Public Property ID As Integer
    Public Property Title As String
    Public Property Price As Integer
    Public Property Pages As Integer
End Class
