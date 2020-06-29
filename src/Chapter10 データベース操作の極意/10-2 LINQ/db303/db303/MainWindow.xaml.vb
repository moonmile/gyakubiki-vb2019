Imports System.Data.Entity.Core.Common.EntitySql
Imports db303.db303

Class MainWindow
    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        AddHandler Me.Loaded,
            Sub(s, e)
                Dim ent As New sampledbEntities()
                dg.ItemsSource = ent.Book.ToList()
            End Sub
    End Sub
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        ' カーソル行を得る
        Dim item = DirectCast(dg.SelectedItem, Book)
        If item Is Nothing Then
            Return
        End If
        ' カーソル行の要素を再度検索する
        Dim ent As New sampledbEntities()
        Dim it = ent.Book.FirstOrDefault(
        New Func(Of Book, Boolean)(
        Function(t)
            Return t.ID = item.ID
        End Function))
        If it Is Nothing Then
            Return
        End If
        ' 要素を削除する
        ent.Book.Remove(it)
        ent.SaveChanges()
        ' 再び検索して表示
        dg.ItemsSource = ent.Book.ToList()
    End Sub
End Class
