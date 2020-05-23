Imports Microsoft.Win32

Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        ' レジストリから読み込む
        Dim key = Registry.CurrentUser
        key = key.OpenSubKey("software\逆引き大全VB2019")
        Dim Data = DirectCast(key.GetValue("sample"), String)
        key.Close()
        ' 結果を出力する
        textBox1.Text = Data
    End Sub
End Class
