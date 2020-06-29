Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        ' 構造体は null にならない
        Dim obj = makeStruct(
            100, "マスダトモアキ", "板橋区")
        label1.Text = obj.ToString()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim obj = makeClass(
            100, "マスダトモアキ", "板橋区")
        label1.Text = obj.ToString()
    End Sub

    Public Function makeStruct(id As Integer, name As String, address As String) As SampleStruct
        ' 戻り値で返すときは、New 演算子で生成する
        Dim obj As New SampleStruct()
        obj.ID = id
        obj.Name = name
        obj.Address = address
        Return obj
    End Function

    Public Function makeClass(id As Integer, name As String, address As String) As SampleClass
        ' 戻り値で返すときは、New 演算子で生成する
        Dim obj As New SampleClass() With {
            .ID = id,
            .Name = name,
            .Address = address
        }

        obj.ID = id
        obj.Name = name
        obj.Address = address
        Return obj
    End Function

End Class

Public Structure SampleStruct
    Public ID As Integer
    Public Name As String
    Public Address As String
    Public Overrides Function ToString() As String
        Return $"構造体 {ID} : {Name} in {Address}"
    End Function
End Structure

Public Class SampleClass
    Public Property ID As Integer
    Public Property Name As String
    Public Property Address As String
    Public Overrides Function ToString() As String
        Return $"クラス {ID} : {Name} in {Address}"
    End Function
End Class
