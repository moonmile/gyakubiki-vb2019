Public Class Form1

    ''' <summary>
    ''' 列挙型を定義する
    ''' </summary>
    Enum Rank
        Special     ' 0
        Standard    ' 1
        Basic       ' 2
    End Enum

    Private Function checkRank(num As Integer) As Rank
        If num >= 80 Then
            Return Rank.Special
        ElseIf num >= 60 Then
            Return Rank.Standard
        Else
            Return Rank.Basic
        End If
    End Function

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim num = Integer.Parse(textBox1.Text)

        Dim result = checkRank(num)
        label1.Text = result.ToString()
        label2.Text = DirectCast(result, Integer).ToString()
    End Sub
End Class
