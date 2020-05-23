Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim x = 10
        Dim y = 20
        Dim z = add(x, y)
        label1.Text = z.ToString()

        Dim s1 = "Masuda"
        Dim s2 = "Tomoaki"
        Dim s3 = add(s1, s2)
        label2.Text = s3

        Dim p As Person = New Person() With {
            .Name = "マスダトモアキ",
            .Age = 51,
            .Address = "板橋区"}



        Dim Text = makeStr(p)
        label3.Text = Text
    End Sub


    '' 値を受け取るメソッド
    Private Function add(x As Integer, y As Integer) As Integer
        Return x + y
    End Function

    '' 文字列を受け取るメソッド
    Private Function add(s1 As String, s2 As String) As String
        Return s1 + " " + s2 + " 様宛"
    End Function

    '' オブジェクトを受け取るメソッド
    Private Function makeStr(p As Person) As String
        Return $"{p.Name} ({p.Age}) in {p.Address}"
    End Function

End Class

Class Person
    Public Property Name As String
    Public Property Age As Integer
    Public Property Address As String
End Class

