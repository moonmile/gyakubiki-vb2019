Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        listBox1.Items.Clear()
        For i = 0 To 10 - 1
            listBox1.Items.Add(
            New SampleClass($"名前_{i}"))
        Next
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        ' リセットする
        SampleClass.Reset()
    End Sub
End Class

Public Class SampleClass
    Private Const init_id = 100
    Private Shared next_id = init_id

    Private _id As Integer
    Private _name As String

    ' コンストラクタ
    Public Sub New(name As String)
        _id = next_id
        _name = name
        ' とびとびの値にする
        next_id += 50 + New Random().Next(100)
    End Sub

    Public ReadOnly Property ID As Integer
        Get
            Return _id
        End Get
    End Property
    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return $"{ID} : {Name}"
    End Function

    Public Shared Sub Reset()
        next_id = init_id
    End Sub


End Class
