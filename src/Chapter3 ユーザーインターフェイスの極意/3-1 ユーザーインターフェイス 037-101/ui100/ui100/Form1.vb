Public Class Form1
    Private Sub Button1_Click(sender As Object,
            e As EventArgs) Handles Button1.Click
        Dim myTB As TextBox
        For Each myTB In Panel1.Controls
            myTB.Text = myTB.Name
        Next
    End Sub

    Private Sub Button2_Click(sender As Object,
            e As EventArgs) Handles Button2.Click
        Dim myTB As TextBox
        For Each myTB In Panel1.Controls
            myTB.Clear()
        Next
    End Sub
End Class
