Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim pis = GetType(SampleClass).GetProperties()
        listBox1.Items.Clear()
        For Each pi In pis
            listBox1.Items.Add($"{pi.Name} : {pi.PropertyType.ToString()}")
        Next
    End Sub
End Class

Public Class SampleClass
    Public Property ID As Integer
    Public Property Name As String
    Public Property Address As String
    Public Function ShowData()
        Return $"{ID} : {Name} in {Address}"
    End Function
    Public Sub ChangeName(name As String)
        Me.Name = name
    End Sub
End Class
