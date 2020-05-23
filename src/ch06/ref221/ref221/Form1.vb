Imports System.Reflection
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim obj As New SampleClass() With {
            .ID = 100,
            .Name = "マスダトモアキ",
            .Address = "板橋区"
        }
        ' クラスの属性を取得
        Dim at = GetType(SampleClass).GetCustomAttribute(Of TableAttribute)()
        textBox1.Text = at.Name
    End Sub
End Class

<Table("サンプルクラス")>
Public Class SampleClass
    <Key> <Column("識別子")>
    Public Property ID As String
    <Column("名前")>
    Public Property Name As String
    <Column("住所")>
    Public Property Address As String
    Public Function ShowData()
        Return $"{ID} : {Name} in {Address}"
    End Function
    Public Sub ChangeName(name As String)
        _Name = name
    End Sub
End Class

