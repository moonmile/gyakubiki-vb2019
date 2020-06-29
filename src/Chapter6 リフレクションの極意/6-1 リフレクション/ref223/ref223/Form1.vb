Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Reflection


Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim obj As New SampleClass() With {
            .ID = 100,
            .Name = "マスダトモアキ",
            .Address = "板橋区"
        }
        ' メソッドの属性を取得
        Dim mi = GetType(SampleClass).GetMethod("ShowData")
        Dim attr = mi.GetCustomAttribute(Of DisplayAttribute)()
        textBox1.Text = attr.Description
    End Sub
End Class

<Table("サンプルクラス")>
Public Class SampleClass
    <Key> <DisplayName("識別子")>
    Public Property ID As String
    <DisplayName("名前")>
    Public Property Name As String
    <DisplayName("住所")>
    Public Property Address As String
    <Display(Description:="フォーマットした文字列を取得する")>
    Public Function ShowData()
        Return $"{ID} : {Name} in {Address}"
    End Function
    Public Sub ChangeName(name As String)
        _Name = name
    End Sub
End Class

