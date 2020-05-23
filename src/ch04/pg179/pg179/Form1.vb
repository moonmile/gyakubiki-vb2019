Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim dt As DateTime
        Dim s As String = ""
        nowtime(dt, s)
        label1.Text = dt.ToString()
        label2.Text = s
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim Now = New NowTime()
        label1.Text = Now.Date.ToString()
        label2.Text = Now.Str
    End Sub

    Sub nowtime(ByRef dt As DateTime, ByRef s As String)
        dt = DateTime.Now
        s = dt.ToString("yyyy年MM月dd日 hh時mm分ss秒")
    End Sub
End Class

Class NowTime
    Private _dt As DateTime = DateTime.Now
    Public ReadOnly Property [Date] As DateTime
        Get
            Return _dt
        End Get
    End Property
    Public ReadOnly Property [Str] As String
        Get
            Return _dt.ToString("yyyy年MM月dd日 hh時mm分ss秒")
        End Get
    End Property
End Class
