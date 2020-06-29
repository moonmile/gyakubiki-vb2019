Imports db293.db293

Class MainWindow
    Public Sub New()
        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()
        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        AddHandler Me.Loaded,
            Sub(s, e)
                Dim ent As New sampledbEntities()
                Dim q = From t In ent.Book
                        Where t.Title.Contains("逆引き")
                        Select t
                dg.ItemsSource = q.ToList()
            End Sub
    End Sub
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim ent As New sampledbEntities()
        Dim cnt = ent.Book.Count(
        New Func(Of Book, Boolean)(
        Function(t)
            Return t.Title.Contains("逆引き")
        End Function))
        MessageBox.Show($"{cnt}件あります")
    End Sub
End Class
