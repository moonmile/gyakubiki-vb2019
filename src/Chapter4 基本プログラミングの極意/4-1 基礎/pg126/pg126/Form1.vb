Public Class Form1

    Const APPLI = "Visual Basic 2019 逆引き大全"
    Const TIPS_NUM = 500

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Const STR = "の極意"
        label1.Text = APPLI + " " + TIPS_NUM.ToString() + STR
        label2.Text = $"{APPLI} {TIPS_NUM}{STR}"
    End Sub
End Class
