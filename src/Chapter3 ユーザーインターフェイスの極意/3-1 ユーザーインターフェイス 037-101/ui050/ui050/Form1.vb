Public Class Form1
    Private Sub Button1_Click(sender As Object,
            e As EventArgs) Handles Button1.Click
        Label1.Text = ""
        Form2.ShowDialog()
        Select Case Form2.DialogResult
            Case DialogResult.Yes
                Label1.Text = "「Yes」がクリックされました"
            Case DialogResult.No
                Label1.Text = "「No」がクリックされました"
            Case DialogResult.Cancel
                Label1.Text = "「Cancel」がクリックされました"
        End Select
    End Sub
End Class
