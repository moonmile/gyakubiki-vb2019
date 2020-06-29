Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        For i = 0 To 9
            Debug.WriteLineIf(i Mod 2 = 0, $"{i}回目")
        Next
    End Sub
End Class
