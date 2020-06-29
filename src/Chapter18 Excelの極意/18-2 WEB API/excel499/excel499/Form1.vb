Imports System.Net.Http
Imports Microsoft.Office.Interop

Public Class Form1
    Private Async Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim url = "http://www.shuwasystem.co.jp/"
        Dim hc As New HttpClient()
        Dim html = Await hc.GetStringAsync(url)
        Dim hdoc As New HtmlAgilityPack.HtmlDocument()
        hdoc.LoadHtml(html)
        Dim lst = hdoc.DocumentNode.SelectNodes("//li[@class='items']")
        Dim items As New List(Of String)()
        Dim books As New List(Of Book)()
        For Each it In lst
            Dim a = it.SelectSingleNode(".//a")
            Dim img = it.SelectSingleNode(".//img")
            Dim Text = img.GetAttributeValue("alt", "")
            Dim link = a.GetAttributeValue("href", "")
            items.Add(Text)
            books.Add(New Book() With {.Title = Text, .Link = link})
        Next
        listBox1.DataSource = items
        ' excel に出力
        Dim xapp As New Excel.Application()
        Dim wb = xapp.Workbooks.Add()
        Dim sh As Excel.Worksheet = wb.ActiveSheet
        sh.Cells(1, 1).Value = "タイトル"
        sh.Cells(1, 2).Value = "リンク"
        Dim r = 2
        For Each it In books
            sh.Cells(r, 1).Value = it.Title
            sh.Cells(r, 2).Value = it.Link
            r = r + 1
        Next
        xapp.Visible = True
        xapp.Quit()
    End Sub
End Class

Public Class Book
    Public Title As String
    Public Link As String
End Class
