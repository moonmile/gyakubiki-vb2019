Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim lst As New List(Of String)()
        For Each it In listBox1.Items
            lst.Add(it.ToString())
        Next
        textBox1.Text = String.Join("★", lst)
    End Sub
End Class
