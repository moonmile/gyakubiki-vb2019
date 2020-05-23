Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim fname1 = textBox1.Text
        Dim fname2 = textBox2.Text
        ' 移動元フォルダーが存在し、移動先フォルダーが存在しなければ移動
        If System.IO.Directory.Exists(fname1) = True And
        System.IO.Directory.Exists(fname2) = False Then
            System.IO.Directory.Move(fname1, fname2)
            textBox3.Text = "移動しました。"
        Else
            textBox3.Text = "移動できませんでした。"
        End If
    End Sub


    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim fname1 = textBox1.Text
        Dim fname2 = textBox2.Text
        ' 移動元ファイルが存在し、移動先ファイルが存在しなければ移動
        If System.IO.File.Exists(fname1) = True And
        System.IO.File.Exists(fname2) = False Then
            System.IO.File.Move(fname1, fname2)
            textBox3.Text = "移動しました。"
        Else
            textBox3.Text = "移動できませんでした。"
        End If
    End Sub
End Class
