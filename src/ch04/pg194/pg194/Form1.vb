Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        ' プロパティを使い初期化
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
        ' コンストラクタで初期化
        Dim obj = New SampleClass(
                "マスダトモアキ",
                51,
                "板橋区"
            )
        label1.Text = obj.Name
        label2.Text = obj.Age.ToString()
        label3.Text = obj.Address
    End Sub


    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        ' 名前付き引数でコンストラクタを使い初期化
        Dim obj = New SampleClass(
                name:="マスダトモアキ",
                age:=51,
                address:="板橋区"
            )
        label1.Text = obj.Name
        label2.Text = obj.Age.ToString()
        label3.Text = obj.Address
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


