Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim name = textBox1.Text
        Dim pi = GetType(SampleClass).GetProperty(name)
        If pi Is Nothing Then
            textBox2.Text = "プロパティが見つかりませんでした"
        Else
            Dim text = $"
プロパティ名 : {pi.Name}
型 : {pi.PropertyType.ToString()}
読み取り : {pi.CanRead}
書き込み : {pi.CanWrite}
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
