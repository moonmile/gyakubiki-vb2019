Public Class Form1
    Private Sub Button1_Click(sender As Object,
            e As EventArgs) Handles Button1.Click
        Label1.AutoSize = False
        Label1.Size = New Size(250, 50)
        Label1.Text = "現在の日付：" _
            & ControlChars.NewLine & DateTime.Now.ToLongDateString
        Label1.ForeColor = Color.DarkGreen
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.TextAlign = ContentAlignment.MiddleCenter
    End Sub
End Class
