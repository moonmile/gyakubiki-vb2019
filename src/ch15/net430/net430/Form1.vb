Imports System.Net.Http

Public Class Form1
    Private Async Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim cl As New HttpClient()
        Dim Uri As New Uri("http://localhost:5000/api/Sample")
        Dim dic As New Dictionary(Of String, String)()
        dic.Add("name", textBox1.Text)
        Dim content As New FormUrlEncodedContent(dic)
        Dim Res = Await cl.PostAsync(Uri, content)
        textBox2.Text = Await Res.Content.ReadAsStringAsync()
    End Sub
End Class
