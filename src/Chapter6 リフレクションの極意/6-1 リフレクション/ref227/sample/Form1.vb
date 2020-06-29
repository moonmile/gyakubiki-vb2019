Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

' 別アセンブリで定義
Public Class SampleClass
    Private _Name As String = "マスダトモアキ"
    Public Property MyName As String
        Get
            Return _Name
        End Get
        Set(value As String)
            _Name = value
        End Set
    End Property
End Class
