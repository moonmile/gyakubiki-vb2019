Public Class Form1
    Private Sub Button1_Click(sender As Object,
            e As EventArgs) Handles Button1.Click
        Dim rd As RadioButton
        If RadioButton1.Checked Then
            rd = RadioButton1
        Else
            rd = RadioButton2
        End If
        MessageBox.Show("氏名：" & TextBox1.Text + Environment.NewLine +
                        "性別：" & rd.Text + Environment.NewLine +
                        "コメント：" & RichTextBox1.Text, "結果")
    End Sub
End Class
