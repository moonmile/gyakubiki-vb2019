Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim obj As New SampleClass() With {
            .ID = 100,
            .Name = "マスダトモアキ",
            .Address = "板橋区"
        }
        textBox1.Text = obj.Name

        ' プロパティ情報を取得する
        Dim pi = GetType(SampleClass).GetProperty("Name")
        pi.SetValue(obj, "増田智明")
        ' プロパティを表示
        textBox2.Text = obj.Name

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
        _name = name
    End Sub
End Class
