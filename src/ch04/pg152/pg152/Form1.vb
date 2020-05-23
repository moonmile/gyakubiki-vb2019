Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Select Case comboBox1.Text
            Case "オレンジ"
                BackColor = Color.Orange
            Case "ブルー"
                BackColor = Color.Blue
            Case "イエロー"
                BackColor = Color.Yellow
            Case Else
                BackColor = Color.Empty
        End Select
    End Sub
End Class
