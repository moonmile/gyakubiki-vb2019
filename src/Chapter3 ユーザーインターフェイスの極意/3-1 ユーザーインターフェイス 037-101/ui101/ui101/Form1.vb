﻿Public Class Form1
    Private Sub Button1_Click(sender As Object,
            e As EventArgs) Handles Button1.Click
        ToolStripStatusLabel1.Text = ""
        Try
            WebBrowser1.Navigate(New Uri(TextBox1.Text))
        Catch ex As Exception
            ToolStripStatusLabel1.Text = ex.Message
        End Try
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object,
            e As WebBrowserDocumentCompletedEventArgs) _
            Handles WebBrowser1.DocumentCompleted
        ToolStripStatusLabel1.Text = "表示しました"
    End Sub
End Class
