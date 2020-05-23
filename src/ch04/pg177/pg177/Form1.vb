Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim x = -10
        Dim y = 20
        Dim z = Plus(x, y)
        label1.Text = z.ToString()

        Dim s3 = append(100, 200)
        label2.Text = s3

        Dim p = MakePerson("マスダトモアキ", 51, "板橋区")
        label3.Text = $"{p.Name} ({p.Age}) in {p.Address}"
    End Sub


    '' 数値を返すメソッド
    Function Plus(x As Integer, y As Integer) As Integer
        If x < 0 Or y < 0 Then
            Return 0
        Else
            Return x + y
        End If
    End Function

    '' 文字列を返すメソッド
    Function append(x As Integer, y As Integer) As String
        Dim z = Plus(x, y)
        Return $"{x} と {y} を渡した結果 {z}"
    End Function

    '' オブジェクトを返すメソッド
    Function MakePerson(name As String, age As Integer, address As String) As Person
        Dim p = New Person() With
            {
                .Name = name,
                .Age = age,
                .Address = address
            }
        Return p
    End Function

End Class

Public Class Person
    Public Property Name As String
    Public Property Age As Integer
    Public Property Address As String
End Class
