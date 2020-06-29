Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim ary() = New String() {
                "microsoft",
                "apple",
                "ibm",
                "oracle",
                "shuwasystem"
            }
        ' 表示する
        listBox1.Items.Clear()
        For Each it In ary
            listBox1.Items.Add(it)
        Next
        ' 変換する（配列を引数にしてchangeArrayメソッドを呼び出し、
        ' 結果を変数ary2に返す)
        Dim ary2() = changeArray(ary)
        ' 表示する
        listBox2.Items.Clear()
        For Each it In ary2
            listBox2.Items.Add(it)
        Next
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        ' リストlstのインスタンス生成と初期化
        Dim lst As New List(Of String)({
                "microsoft",
                "apple",
                "ibm",
                "oracle",
                "shuwasystem"
        })
        ' 表示する
        listBox1.Items.Clear()
        lst.ForEach(Function(it)
                        Return listBox1.Items.Add(it)
                    End Function)
        'ForEachメソッドの使用
        ' 変換する
        Dim lst2 = changeList(lst) ' リストを引数にメソッドを呼び出す
        ' 表示する
        listBox2.Items.Clear()
        lst2.ForEach(Function(it)
                         Return listBox2.Items.Add(it)
                     End Function)
    End Sub

    Public Function changeArray(ary As String()) As String()
        Dim result() = New String(ary.Length - 1) {}
        For i = 0 To ary.Length - 1
            result(i) = ary(i).ToUpper()
        Next
        Return result
    End Function

    Public Function changeList(lst As List(Of String)) As List(Of String)
        Dim result As New List(Of String)
        For Each it In lst
            result.Add(it.ToUpper())
        Next
        Return result
    End Function
End Class
