﻿Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim dt = DateTime.Now               ' システム日付を取得
        label1.Text = dt.Hour.ToString()    ' 時を取得して表示
        label2.Text = dt.Minute.ToString()  ' 分を取得して表示
        label3.Text = dt.Second.ToString()  ' 秒を取得して表示
    End Sub
End Class
