Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MaximizeBox = True And MinimizeBox = True Then
            MaximizeBox = False
            MinimizeBox = False
        Else
            MaximizeBox = True
            MinimizeBox = True
        End If

    End Sub
End Class
