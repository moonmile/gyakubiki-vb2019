Public Class Form1
    Private Sub Form1_Load(sender As Object,
            e As EventArgs) Handles MyBase.Load
        RadioButton1.Checked = True  'ラジオボタン1をオンにする
    End Sub

    Private Sub Button1_Click(sender As Object,
            e As EventArgs) Handles Button1.Click
        Dim myString As String = ""
        If RadioButton1.Checked Then
            myString = RadioButton1.Text
        ElseIf RadioButton2.Checked Then
            myString = RadioButton2.Text
        ElseIf RadioButton3.Checked Then
            myString = RadioButton3.Text
        End If
        Label1.Text = myString
    End Sub
End Class
