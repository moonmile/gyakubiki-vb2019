Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim dt = DateTime.Now
        Dim s = "来年は "
        nextyear(dt, s)
        label1.Text = dt.ToString()
        label2.Text = s
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim n = New NextYear(DateTime.Now)
        label1.Text = n.Date.ToString()
        label2.Text = n.Str("来年は ")
    End Sub

    Private Sub nextyear(dt As DateTime, s As String)
        ' 引数を変更しても元のデータは変更されない
        dt = dt.AddYears(1)
        s += dt.ToString("yyyy年MM月dd日")
    End Sub
End Class

Class NextYear
    Private _dt As DateTime
    Public Sub New(dt As DateTime)
        _dt = dt.AddYears(1)
    End Sub
    Public Function [Str](s As String)
        Return s + _dt.ToString("yyyy年MM月dd日")
    End Function
    Public ReadOnly Property [Date] As DateTime
        Get
            Return _dt
        End Get
    End Property
End Class

