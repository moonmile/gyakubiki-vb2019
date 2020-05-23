Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        For Each obj As Control In Controls
            If TypeOf obj Is Button Then       ' Buttonと等しい場合
                obj.Text = "Clicked!"   ' プロパティの値を変更
            End If
        Next

    End Sub
End Class
