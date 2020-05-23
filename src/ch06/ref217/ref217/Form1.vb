Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim name = textBox1.Text
        Dim mi = GetType(SampleClass).GetMethod(name)
        If mi Is Nothing Then
            textBox2.Text = "メソッドが見つかりませんでした"
        Else
            Dim text = $"
メソッド名 : {mi.Name}
引数の数 : {mi.GetParameters().Length}
戻り値の型 : {mi.ReturnType.ToString()}
"
            textBox2.Text = text
        End If
    End Sub
End Class

Public Class SampleClass
    Private _name As String = ""
    Public Property ID As String
    Public ReadOnly Property Name As String
        Get
            Return _name
        End Get
    End Property
    Public Property Address As String

    Public Sub New(name As String)
        _name = name
    End Sub
    Public Function ShowData()
        Return $"{ID} : {Name} in {Address}"
    End Function
    Public Sub ChangeName(name As String)
        _name = name
    End Sub
End Class

