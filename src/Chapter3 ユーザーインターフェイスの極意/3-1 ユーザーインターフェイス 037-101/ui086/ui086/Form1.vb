Public Class Form1
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)
        If TextBox1.TextAlign = HorizontalAlignment.Center Then
            TextBox1.TextAlign = HorizontalAlignment.Left
            ToolStripButton1.Checked = False
        Else
            TextBox1.TextAlign = HorizontalAlignment.Center
            ToolStripButton1.Checked = True
        End If
    End Sub
End Class
