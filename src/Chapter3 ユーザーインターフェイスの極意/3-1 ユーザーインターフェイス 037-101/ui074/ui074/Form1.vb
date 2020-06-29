Public Class Form1
    Private Sub Form1_Load(sender As Object,
            e As EventArgs) Handles MyBase.Load
        Dim myArray() As String = {"A4用紙", "A3用紙", "B5用紙",
                                   "B4用紙", "修正液", "付箋"}
        ListBox1.Items.AddRange(myArray)
        ListBox1.SelectionMode = SelectionMode.MultiSimple
        ListBox2.SelectionMode = SelectionMode.MultiSimple

    End Sub

    Private Sub Button1_Click(sender As Object,
            e As EventArgs) Handles Button1.Click
        Dim myList As Object
        If ListBox1.SelectedIndex <> -1 Then
            'リストボックス１で選択された項目をリストボックス２に追加
            For Each myList In ListBox1.SelectedItems
                ListBox2.Items.Add(myList)
            Next
        End If
        'リストボックス１で選択された項目を削除
        For i As Integer = ListBox1.Items.Count - 1 To 0 Step -1
            If ListBox1.GetSelected(i) Then
                ListBox1.Items.RemoveAt(i)
            End If
        Next
    End Sub
End Class
