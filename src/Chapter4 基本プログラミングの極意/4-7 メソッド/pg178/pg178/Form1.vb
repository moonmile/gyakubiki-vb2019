Public Class Form1

    Private _cup As New Cup

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        _cup.add(20)
        label1.Text = $"Value is {_cup.Value}"
    End Sub
End Class

Public Class Cup
    Private _value As Integer = 0
    Const MAX = 100

    Public Sub add(x As Integer)
        _value += x
        If _value > MAX Then
            _value = MAX
        End If
    End Sub
    Public ReadOnly Property Value As Integer
        Get
            Return _value
        End Get
    End Property
End Class
