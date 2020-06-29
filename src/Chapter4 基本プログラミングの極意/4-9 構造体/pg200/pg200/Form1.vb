Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        ' 配列を利用
        Dim ary = New SampleStruct(2) {}
        ary(0).ID = 100
        ary(0).Name = "マスダトモアキ"
        ary(0).Address = "板橋区"
        ary(1).ID = 200
        ary(1).Name = "秀和太郎"
        ary(1).Address = "中央区"
        ary(2).ID = 300
        ary(2).Name = "極意はなこ"
        ary(2).Address = "北海道"

        listBox1.Items.Clear()
        For Each it In ary
            listBox1.Items.Add(it.ToString())
        Next
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        ' コレクションを利用
        Dim lst = New List(Of SampleStruct)()
        lst.Add(New SampleStruct() With {
            .ID = 100,
            .Name = "マスダトモアキ",
            .Address = "板橋区"
        })
        lst.Add(New SampleStruct() With {
            .ID = 200,
            .Name = "秀和太郎",
            .Address = "中央区"
        })
        lst.Add(New SampleStruct() With {
            .ID = 300,
            .Name = "極意はなこ",
            .Address = "北海道"
        })

        listBox1.Items.Clear()
        For Each it In lst
            listBox1.Items.Add(it.ToString())
        Next
    End Sub
End Class

Structure SampleStruct
    Public ID As Integer
    Public Name As String
    Public Address As String
    Public Overrides Function ToString() As String
        Return $"構造体 {ID} : {Name} in {Address}"
    End Function
End Structure
