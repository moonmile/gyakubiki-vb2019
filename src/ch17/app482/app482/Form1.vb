Imports Microsoft.Win32

Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        ' レジストリから読み込む
        Dim key = Registry.CurrentUser
        key = key.CreateSubKey("software\逆引き大全VB2019")
        key.SetValue("sample", textBox1.Text)
        key.Close()
        MessageBox.Show("レジストリへ書き込みました")
    End Sub
End Class
