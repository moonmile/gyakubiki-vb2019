Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim dlg As New FontDialog() With {
        .ShowColor = True,
        .Font = richTextBox1.SelectionFont,
        .Color = richTextBox1.SelectionColor
        }
        If dlg.ShowDialog() = DialogResult.OK Then
            richTextBox1.SelectionFont = dlg.Font
            richTextBox1.SelectionColor = dlg.Color
        End If
    End Sub
End Class
