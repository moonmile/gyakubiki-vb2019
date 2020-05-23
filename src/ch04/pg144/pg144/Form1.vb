Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim dt = DateTime.Today   ' 今日の日付を取得

        Dim w As DayOfWeek = dt.DayOfWeek
        label1.Text = w.ToString()
        Dim lst = New List(Of String)(
            New String() {"日曜日", "月曜日", "火曜日",
                "水曜日", "木曜日", "金曜日", "土曜日"}
            )
        label2.Text = lst(w)
    End Sub
End Class
