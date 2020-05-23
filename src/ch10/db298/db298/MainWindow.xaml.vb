Imports db298.db298

Class MainWindow
    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        AddHandler Me.Loaded,
            Sub(s, e)
                Dim ent As New sampledbEntities()
                Dim q = From b In ent.Book
                        Select b
                dg.ItemsSource = q.ToList()
            End Sub
    End Sub
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        ' 要素が含まれているかチェックする
        Dim ent As New sampledbEntities()
        Dim x = ent.Book.Any(
    New Func(Of Book, Boolean)(
    Function(t)
        Return t.ID = 100
    End Function))
        MessageBox.Show($"真偽: {x}")
    End Sub
End Class
