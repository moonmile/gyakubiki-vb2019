Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim obj = New SampleClass("新規のお客様")
        label1.Text = obj.Name
        label2.Text = obj.ID
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

    Public ReadOnly Property Name As String
        Get
            Return _name
        End Get
    End Property
    Public ReadOnly Property ID As String
        Get
            Return _id
        End Get
    End Property

End Class
