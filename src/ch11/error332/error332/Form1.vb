Imports System.Data.OleDb

Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim path = textBox1.Text
        Dim cn As New OleDbConnection()
        Try
            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                $"Data Source={path}"
            cn.Open()
            MessageBox.Show("データベースに接続しました", "エラー発生")
            cn.Close()
        Catch ex As OleDbException
            MessageBox.Show(ex.Message, "エラー発生")
        End Try

    End Sub
End Class
