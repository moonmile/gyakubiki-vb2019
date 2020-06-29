Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        ' 基本クラスの利用
        Dim obj As New SampleClass() With {
            .Name = "秀和太郎",
            .Age = 51,
            .Address = "東京都"
        }
        label1.Text = obj.Name
        label2.Text = obj.ShowData()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        ' 継承クラスの利用
        Dim obj As New SubSampleClass() With {
            .Name = "秀和太郎",
            .Age = 51,
            .Address = "東京都"
        }
        label1.Text = obj.Name
        label2.Text = obj.ShowData()
    End Sub
End Class

Public Class SampleClass
    Public Property Name As String
    Public Property Age As Integer
    Public Property Address As String
    ' 既存のToStringメソッドをオーバーライドする
    Public Overridable Function ShowData() As String
        Return $"{Name} ({Age}) {Address}"
    End Function
End Class


Public Class SubSampleClass
    Inherits SampleClass
    Public Overrides Function ShowData() As String
        Return $"{Name} 様 {Age} 歳 IN {Address}"
    End Function
End Class

