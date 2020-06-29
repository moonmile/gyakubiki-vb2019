Imports System.Net.Http

Public Class Form1
    Private Async Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim cl As New HttpClient()
        Dim url As New Uri("http://localhost:5000/api/Sample/10")
        Dim Res = Await cl.GetStringAsync(url)
        textBox1.Text = Res
    End Sub
End Class
