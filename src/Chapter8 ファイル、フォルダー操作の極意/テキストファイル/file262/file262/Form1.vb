Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        listBox1.Items.Clear()
        For Each info As System.IO.DriveInfo In
            System.IO.DriveInfo.GetDrives()
            listBox1.Items.Add($"{info.Name}    {info.DriveType}")
        Next
    End Sub
End Class
