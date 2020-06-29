Public Class Form1
    Private Sub Form1_Load(sender As Object,
            e As EventArgs) Handles MyBase.Load
        Dim myArray() As String = {"テニス", "バドミントン",
                                   "陸上", "柔道", "水泳"}
        CheckedListBox1.Items.AddRange(myArray)
        CheckedListBox1.SetItemChecked(0, True)
    End Sub

    Private Sub Button1_Click(sender As Object,
            e As EventArgs) Handles Button1.Click
        Dim myItem As Object
        ListBox1.Items.Clear()
        'チェックが付いている項目をリストボックスに追加
        For Each myItem In CheckedListBox1.CheckedItems
            ListBox1.Items.Add(myItem)
        Next
    End Sub
End Class
