Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim obj As New SampleStruct
        obj.ID = 100
        obj.Name = "マスダトモアキ"
        obj.Address = "板橋区"
        label1.Text = obj.ToString()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim obj As New SampleClass With {
            .ID = 100,
            .Name = "マスダトモアキ",
            .Address = "板橋区"
        }
        label1.Text = obj.ToString()
    End Sub
End Class

'構造体
Structure SampleStruct
    Public Property ID As Integer
    Public Property Name As String
    Public Property Address As String
    Public Overrides Function ToString() As String
        Return $"構造体 {ID} : {Name} IN {Address}"
    End Function
End Structure

'クラス
Class SampleClass
    Public Property ID As Integer
    Public Property Name As String
    Public Property Address As String
    Public Overrides Function ToString() As String
        Return $"クラス {ID} : {Name} IN {Address}"
    End Function
End Class