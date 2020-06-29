Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim obj = New SampleClass("秀和太郎")
        ' 引数なしのメソッド呼び出し
        label1.Text = obj.ShowData()
        ' 引数ありのメソッド呼び出し
        label2.Text = obj.GetName("御中")
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

    ' 引数のないメソッド
    Public Function ShowData() As String
        ' 最初の5桁のみ表示する
        Return _name + " " + _id.Substring(0, 5) + "..."
    End Function

    ' 引数のあるメソッド
    Public Function GetName(post As String) As String
        ' ポストフィックスを付ける
        Return _name + " " + post
    End Function

End Class

