Public Class Form1
    Private Sub Form1_Load(sender As Object,
            e As EventArgs) Handles MyBase.Load
        RadioButton1.Checked = True
        RadioButton6.Checked = True
    End Sub
    Private Sub Button1_Click(sender As Object,
            e As EventArgs) Handles Button1.Click
        Dim myText1 As String = "", myText2 As String = ""
        For Each myRB1 As RadioButton In GroupBox1.Controls
            If myRB1.Checked Then
                myText1 = "年代：" & myRB1.Text
                Exit For
            End If
        Next

        For Each myRB2 As RadioButton In GroupBox2.Controls
            If myRB2.Checked Then
                myText2 = "性別：" & myRB2.Text
                Exit For
            End If
        Next
        Label2.Text = myText1 & Environment.NewLine & myText2
    End Sub

End Class
