Public Class Form1
    Private Sub Form1_Load(sender As Object,
            e As EventArgs) Handles MyBase.Load
        AcceptButton = Button1
        CancelButton = Button2
        Label1.Text = "フォームの読み込み時にAcceptボタン、" _
            + Environment.NewLine + "Cancelボタンを設定しました"
        Button1.Text = "OK"
        Button2.Text = "キャンセル"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("OKがクリックされました")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("キャンセルがクリックされました")
    End Sub
End Class
