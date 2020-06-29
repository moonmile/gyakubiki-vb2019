Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Reflection


Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim obj As New SampleClass() With {
            .ID = 100,
            .Address = "板橋区"
            }
        ' プライベートフィールドに設定
        Dim Name = "マスダトモアキ"
        SetField(obj, "_Name", Name)

        textBox1.Text = Name
        textBox2.Text = obj.Name
    End Sub

    Public Sub SetField(Of T)(target As T, name As String, value As Object)
        Dim tt = GetType(T)
        Dim pi = tt.GetTypeInfo().GetDeclaredField(name)
        pi.SetValue(target, Convert.ChangeType(value, pi.FieldType))
    End Sub

End Class

<Table("サンプルクラス")>
Public Class SampleClass
    Public Property ID As String
    ' プライベートフィールドのみ
    Private _Name As String
    Public ReadOnly Property Name As String
        Get
            Return _name
        End Get
    End Property
    Public Property Address As String

    Public Function ShowData()
        Return $"{ID} : {Name} in {Address}"
    End Function
End Class

