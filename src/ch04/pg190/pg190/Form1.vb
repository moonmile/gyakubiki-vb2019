Public Class Form1
    Private _obj As SampleClass

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        ' インスタンス生成時にプロパティを指定
        _obj = New SampleClass("新規のお客様")
        label1.Text = _obj.Name
        label2.Text = _obj.ID
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        ' 名前の変更
        _obj.Name = "名前を変更する"
        ' _obj.ID = "xxxxx"  ' IDプロパティは変更できない
        label1.Text = _obj.Name
        label2.Text = _obj.ID
    End Sub
End Class

' Sampleクラス
Public Class SampleClass
    Private _name As String
    Private _id As String
    ' クラスのコンストラクタ
    Public Sub New(name As String)
        _name = name
        _id = Guid.NewGuid().ToString()
    End Sub

    Public Property Name As String
        Get
            Return _name
        End Get
        Set
            _name = Value
        End Set
    End Property
    Public ReadOnly Property ID As String
        Get
            Return _id
        End Get
    End Property
End Class
