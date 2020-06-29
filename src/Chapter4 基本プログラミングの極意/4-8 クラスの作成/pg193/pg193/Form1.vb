Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        ' イベントを発生させる
        _obj.Name = "秀和次郎"
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        ' イベントハンドラを削除する
        RemoveHandler _obj.OnChangeName, AddressOf _obj_OnChangeName
    End Sub

    Private Sub _obj_OnChangeName(obj As DateTime)
        label1.Text = _obj.Name
        label2.Text = "Nameを変更した " + obj.ToString()
    End Sub

    Private _obj As SampleClass

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _obj = New SampleClass("秀和太郎")
        ' イベントハンドラを設定する
        AddHandler _obj.OnChangeName, AddressOf _obj_OnChangeName
        label1.Text = _obj.Name
        label2.Text = ""
    End Sub
End Class

' Sampleクラス
Public Class SampleClass
    Private _name As String
    Private _time As DateTime
    Private _id As String
    ' クラスのコンストラクタ
    Public Sub New(name As String)
        _name = name
    End Sub

    ' イベントの定義
    Public Event OnChangeName As Action(Of DateTime)
    ' Name プロパティの変更
    Public Property Name As String
        Get
            Return _name
        End Get
        Set
            _name = Value
            _time = DateTime.Now
            ' インベントを発生させる
            RaiseEvent OnChangeName(_time)
        End Set
    End Property
End Class

