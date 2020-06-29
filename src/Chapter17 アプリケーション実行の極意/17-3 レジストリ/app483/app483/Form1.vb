Imports Microsoft.Win32

Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim key = Registry.CurrentUser
        key = key.OpenSubKey("software\逆引き大全VB2019", True)
        key.DeleteValue("sample")
        MessageBox.Show("レジストリから削除しました")
    End Sub
End Class
