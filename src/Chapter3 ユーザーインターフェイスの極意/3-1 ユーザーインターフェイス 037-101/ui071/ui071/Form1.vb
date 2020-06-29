Public Class Form1

    Private Sub Form1_Load(sender As Object,
            e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("赤")
        ListBox1.Items.Add("白")
        ListBox1.Items.Add("黄")
        ListBox1.Items.Add("緑")
        ListBox1.Items.Add("青")
    End Sub

    Private Sub Button1_Click(sender As Object,
            e As EventArgs) Handles Button1.Click
        Dim myArray() As String = {"赤", "白", "黄", "緑", "青"}
        ListBox1.Items.Clear()
        ListBox1.Items.AddRange(myArray)
    End Sub

    Private Sub Button2_Click(sender As Object,
            e As EventArgs) Handles Button2.Click
        If ListBox1.Items.Count <> 0 Then
            ListBox1.Items.RemoveAt(0)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object,
            e As EventArgs) Handles Button3.Click
        If ListBox1.Items.Count <> 0 Then
            ListBox1.Items.RemoveAt(ListBox1.Items.Count - 1)
        End If
    End Sub
End Class
