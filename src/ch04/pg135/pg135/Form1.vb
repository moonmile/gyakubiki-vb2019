Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim a As (String, Integer, String) = ("masuda", 51, "Itabashi")
        textBox1.Text = a.Item1
        textBox2.Text = a.Item2.ToString()
        textBox3.Text = a.Item3
        label2.Text = a.ToString()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Dim a = (Name:="masuda", age:=51, addrsss:="Itabashi")
        textBox1.Text = a.name
        textBox2.Text = a.age.ToString()
        textBox3.Text = a.addrsss
        label2.Text = a.ToString()
    End Sub
End Class
