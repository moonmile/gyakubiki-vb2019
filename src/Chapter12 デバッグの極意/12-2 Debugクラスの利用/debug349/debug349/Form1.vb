Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Debug.WriteLine("インデント前")
        Debug.Indent()
        Debug.WriteLine("インデント1回目")
        Debug.Indent()
        Debug.WriteLine("インデント2回目")
        Debug.Unindent()
        Debug.WriteLine("インデントを戻す")
        Debug.Unindent()
        Debug.WriteLine("インデントを戻す")
    End Sub
End Class
