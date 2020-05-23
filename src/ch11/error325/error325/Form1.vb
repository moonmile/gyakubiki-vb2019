Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim a = Integer.Parse(textBox1.Text)
        Dim b = Integer.Parse(textBox2.Text)
        Try
            If b = 0 Then
                Throw New SampleException("0で除算はできません")
            End If
            Dim ans = a / b
            MessageBox.Show($"ans: {ans}")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "エラー発生")
        End Try
    End Sub
End Class

Public Class SampleException
    Inherits Exception
    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(msg As String)
        MyBase.New(msg)
    End Sub
    Public Sub New(msg As String, inner As Exception)
        MyBase.New(msg, inner)
    End Sub
End Class

