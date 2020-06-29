Imports System.Reflection


Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim obj As New SampleClass() With {
            .ID = 100,
            .Name = "マスダトモアキ",
            .Address = "板橋区"
        }
        textBox1.Text = obj.Name
        textBox2.Text = DirectCast(_Invoke(obj, "ShowData", New Object() {}), String)
    End Sub

    Public Function _Invoke(Of T)(target As T, name As String, ParamArray args As Object())
        Dim tt = GetType(T)
        Dim lst As New List(Of Type)
        For Each it In args
            lst.Add(it.GetType())
        Next
        Dim mi = tt.GetTypeInfo().GetDeclaredMethod(name)
        Return mi.Invoke(target, args)
    End Function

End Class

Public Class SampleClass
    Public Property ID As String
    Public Property Name As String
    Public Property Address As String
    Public Function ShowData()
        Return $"{ID} : {Name} in {Address}"
    End Function
End Class


