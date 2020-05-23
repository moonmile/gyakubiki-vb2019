Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim Name = New ReadOnlyClass(Of String)("masuda")
        Dim age = New ReadOnlyClass(Of Integer)(51)
        label1.Text = Name.Value
        label2.Text = age.Value.ToString()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim a = "マスダ"
        Dim b = "智明"

        Swap(a, b)
        label1.Text = a
        label2.Text = b
    End Sub

    Private Sub Swap(Of T)(ByRef a As T, ByRef b As T)
        Dim temp As T = a
        a = b
        b = temp
    End Sub

End Class

' 読み取り専用クラス
Public Class ReadOnlyClass(Of T)
    Private _value As T
    Public Sub New(value As T)
        _value = value
    End Sub
    Public ReadOnly Property Value As T
        Get
            Return _value
        End Get
    End Property
End Class

