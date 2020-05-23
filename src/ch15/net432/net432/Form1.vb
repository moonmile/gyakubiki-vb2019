Imports System.Net.Http
Imports System.Net.Http.Headers
Imports Newtonsoft.Json

Public Class Form1
    Private Async Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim cl As New HttpClient()
        Dim Uri As New Uri("http://localhost:5000/api/Sample2")
        Dim dic As New Dictionary(Of String, String)()
        dic.Add("name", textBox1.Text)
        dic.Add("age", textBox2.Text)
        Dim content As New FormUrlEncodedContent(dic)
        Dim Res = Await cl.PostAsync(Uri, content)
        Dim doc = System.Xml.Linq.XDocument.Load(Await Res.Content.ReadAsStreamAsync())
        textBox3.Text = doc.Document.Element("person").Element("name").Value
        textBox4.Text = doc.Document.Element("person").Element("age").Value
    End Sub
End Class
