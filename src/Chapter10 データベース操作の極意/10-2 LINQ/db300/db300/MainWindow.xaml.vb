Imports db300.db300

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
        Dim ent As New sampledbEntities()
        ' 最初の要素を表示する
        Dim it = ent.Book.ToList().LastOrDefault()
        MessageBox.Show($"最後のタイトル: {it.Title}")
    End Sub
End Class
