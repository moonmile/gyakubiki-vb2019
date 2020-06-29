Public Class Form1
    Dim a1 As Integer
    Dim b1 As Integer
    Dim c1 As Integer

    Private Sub Button1_Click(sender As Object,
            e As EventArgs) Handles Button1.Click
        Label1.Text = (a1 + b1 + c1).ToString("#,##0円")
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object,
            e As EventArgs) Handles CheckBox1.CheckedChanged
        'チェックが付いていれば変数a1に1000を代入し、
        'チェックが付いていなければ変数a1に0を代入する
        If CheckBox1.Checked Then
            a1 = 1000
        Else
            a1 = 0
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object,
            e As EventArgs) Handles CheckBox2.CheckedChanged
        'チェックが付いていれば変数b1に800を代入し、
        'チェックが付いていなければ変数b1に0を代入する
        If CheckBox2.Checked Then
            b1 = 800
        Else
            b1 = 0
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object,
            e As EventArgs) Handles CheckBox3.CheckedChanged
        'チェックが付いていれば変数c1に500を代入し、
        'チェックが付いていなければ変数c1に0を代入する
        If CheckBox3.Checked Then
            c1 = 500
        Else
            c1 = 0
        End If
    End Sub
End Class
