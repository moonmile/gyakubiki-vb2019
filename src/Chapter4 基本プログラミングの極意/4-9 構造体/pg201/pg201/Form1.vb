Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim obj As SampleStruct
        obj.ID = 100
        obj.Name = "マスダトモアキ"
        obj.Address = "板橋区"
        label1.Text = showStruct(obj)
        ' Nothing は渡せない
        '  label1.Text = showStruct(Nothing) // コンパイルエラー
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim obj As New SampleClass With {
            .ID = 100,
            .Name = "マスダトモアキ",
            .Address = "板橋区"
        }
        label1.Text = showClass(obj)
        ' Nothing を渡せる
        ' label1.Text = showClass(Nothing); 
    End Sub

    Function showStruct(obj As SampleStruct) As String
        Return $"構造体 {obj.ID} : {obj.Name} IN {obj.Address}"
    End Function

    Function showClass(obj As SampleClass) As String
        If obj Is Nothing Then
            Return "クラスが null です"
        Else
            Return $"クラス {obj.ID} : {obj.Name} IN {obj.Address}"
        End If
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
