Imports db301.db301

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
        ' 最初にマッチした要素を表示
        Dim it = ent.Book.FirstOrDefault(
        New Func(Of Book, Boolean)(
        Function(t)
            Return t.Title.Contains("逆引き")
        End Function))

        If it Is Nothing Then
            MessageBox.Show("要素は見つかりませんでした")
        Else
            MessageBox.Show($"最初のタイトル: {it.Title}")
        End If
    End Sub
End Class
