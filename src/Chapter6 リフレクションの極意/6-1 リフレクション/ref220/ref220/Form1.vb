Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim obj As New SampleClass() With {
            .ID = 100,
            .Name = "マスダトモアキ",
            .Address = "板橋区"
        }
        ' 通常のメソッドで取得
        textBox1.Text = obj.ShowData()
        ' リフレクションでメソッドを実行
        Dim mi = GetType(SampleClass).GetMethod("ShowData")
        Dim v = DirectCast(mi.Invoke(obj, New Object() {}), String)
        textBox2.Text = v
    End Sub
End Class

Public Class SampleClass
    Public Property ID As String
    Public Property Name As String
    Public Property Address As String
    Public Function ShowData()
        Return $"{ID} : {Name} in {Address}"
    End Function
    Public Sub ChangeName(name As String)
        _Name = name
    End Sub
End Class
