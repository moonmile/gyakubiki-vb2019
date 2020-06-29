Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        ' 基本クラスの利用
        Dim obj = New SampleClass() With {
                .Name = "マスダトモアキ",
                .Age = 51,
                .Address = "板橋区"
            }

        label1.Text = obj.Name
        label2.Text = obj.Age.ToString()
        label3.Text = obj.Address
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        ' 継承したクラスを利用
        Dim obj = New SubSampleClass() With {
                .Name = "マスダトモアキ",
                .Age = 51,
                .Address = "板橋区",
                .Tel = "090-XXXX-YYYY"
                }
        label1.Text = obj.Name
        label2.Text = obj.Age.ToString()
        label3.Text = obj.Address
        label4.Text = obj.Tel
    End Sub
End Class

' Sampleクラス
Public Class SampleClass
    Public Property Name As String
    Public Property Age As Integer
    Public Property Address As String

    Public Sub New()

    End Sub
    ' クラスのコンストラクタ
    Public Sub New(name As String, age As Integer, address As String)
        Me.Name = name
        Me.Age = age
        Me.Address = address
    End Sub
End Class

Public Class SubSampleClass
    Inherits SampleClass
    Public Property Tel As String
    Public Sub New()
    End Sub

    Public Sub New(name As String, age As Integer, address As String, tel As String)
        Me.Name = name
        Me.Age = age
        Me.Address = address
        Me.Tel = tel
    End Sub
End Class
