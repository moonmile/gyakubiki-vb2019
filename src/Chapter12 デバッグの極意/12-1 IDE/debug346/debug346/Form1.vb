Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
#If DEBUG Then
        MessageBox.Show("DEBUGモードでビルド")
#Else
        MessageBox.Show("RELEASEモードでビルド")
#End If
    End Sub
End Class
