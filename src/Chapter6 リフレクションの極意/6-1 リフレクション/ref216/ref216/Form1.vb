Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim mis = GetType(SampleClass).GetMethods()
        listBox1.Items.Clear()
        For Each mi In mis
            listBox1.Items.Add($"{mi.Name}")
        Next
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

