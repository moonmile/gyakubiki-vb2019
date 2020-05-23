Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim obj As New SampleClass() With {
            .ID = 100,
            .Name = "マスダトモアキ",
            .Address = "板橋区"
        }
        ' プロパティで取得
        textBox1.Text = obj.Name
        ' リフレクションで取得
        Dim pi = GetType(SampleClass).GetProperty("Name")
        textBox2.Text = DirectCast(pi.GetValue(obj), String)
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

