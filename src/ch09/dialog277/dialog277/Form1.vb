Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim dlg As New ColorDialog()
        If dlg.ShowDialog() = DialogResult.OK Then
            label1.BackColor = dlg.Color
        End If
    End Sub

End Class
