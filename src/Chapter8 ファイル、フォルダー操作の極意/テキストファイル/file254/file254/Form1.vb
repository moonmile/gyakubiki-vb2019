Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim asm = System.Reflection.Assembly.GetExecutingAssembly()
        Dim path = System.IO.Path.GetDirectoryName(asm.Location)
        textBox1.Text = path
    End Sub
End Class
