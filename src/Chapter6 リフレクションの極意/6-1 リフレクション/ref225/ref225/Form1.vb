Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Reflection

Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim obj As New SampleClass() With {
            .ID = 100,
            .Address = "板橋区"
        }
        ' プライベートプロパティに設定
        Dim Name = "マスダトモアキ"
        SetProperty(obj, "Name", Name)
        textBox1.Text = Name
        textBox2.Text = obj.Name
    End Sub

    Public Sub SetProperty(Of T)(target As T, name As String, value As Object)
        Dim tt = GetType(T)
        Dim pi = tt.GetRuntimeProperty(name)
        pi.SetValue(target, Convert.ChangeType(value, pi.PropertyType))
    End Sub

End Class

<Table("サンプルクラス")>
Public Class SampleClass
    Public Property ID As String
    Private _Name As String
    Public Property Name As String
        Get
            Return _Name
        End Get
        Private Set(value As String)
            _Name = value
        End Set
    End Property
    Public Property Address As String
    Public Function ShowData()
        Return $"{ID} : {Name} in {Address}"
    End Function
End Class

