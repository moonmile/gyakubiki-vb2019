Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim a = Integer.Parse(textBox1.Text)
        Dim b = Integer.Parse(textBox2.Text)
        Dim t = New TargetClass()
        Dim ans = t.add(a, b)
        textBox3.Text = ans.ToString()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim a = textBox1.Text
        Dim b = textBox2.Text
        Dim t As New TargetClass()
        Dim ans = t.add(a, b)
        textBox3.Text = ans
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Dim a = Integer.Parse(textBox1.Text)
        Dim b = Integer.Parse(textBox2.Text)
        Dim t = New TargetClass()
        Dim obj = t.CreatePointer(a, b)
        textBox3.Text = obj.ToString()
    End Sub
End Class
