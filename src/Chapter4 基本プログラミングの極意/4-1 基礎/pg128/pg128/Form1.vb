Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim i As Integer = 30
        Dim x As Long = i                     ' 暗黙の型変換

        Dim d As Double = 123.456
        label3.Text = d.ToString()
        i = CInt(d)                        ' キャスト（桁落ちする）
        label4.Text = i.ToString()         ' ラベルに表示

        Dim obj As Object = i              ' 暗黙の型変換
        obj = "Visual Visual Basic 2019"
        Dim stringX = DirectCast(obj, String)  ' 強制的にキャスト
        Dim stringY = CStr(obj)                ' キャスト

    End Sub
End Class
