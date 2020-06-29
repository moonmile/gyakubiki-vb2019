Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        listBox1.Items.Clear()
        For Each it In
            System.IO.Directory.GetLogicalDrives()
            listBox1.Items.Add(it)
        Next
    End Sub
End Class
