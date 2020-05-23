Imports System.Reflection
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.ComponentModel

Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim obj As New SampleClass() With {
            .ID = 100,
            .Name = "マスダトモアキ",
            .Address = "板橋区"
        }
        ' プロパティの属性を取得
        listBox1.Items.Clear()
        For Each pi In GetType(SampleClass).GetProperties()
            Dim at = pi.GetCustomAttribute(Of DisplayNameAttribute)()
            If Not at Is Nothing Then
                listBox1.Items.Add($"{pi.Name} {at.DisplayName}")
            End If
        Next
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
    Public Function ShowData()
        Return $"{ID} : {Name} in {Address}"
    End Function
    Public Sub ChangeName(name As String)
        _Name = name
    End Sub
End Class


