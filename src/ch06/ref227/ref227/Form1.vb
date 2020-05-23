Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        ' あらかじめ sample.exe を同じフォルダーに
        ' コピーしておく
        Dim asm = System.Reflection.Assembly.LoadFrom("sample.exe")
        Dim t = asm.GetType("sample.SampleClass")
        Dim obj = System.Activator.CreateInstance(t)
        ' リフレクションで取得
        Dim pi = t.GetProperty("MyName")
        textBox1.Text = DirectCast(pi.GetValue(obj), String)
    End Sub
End Class
