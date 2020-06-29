Imports db294.db294

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
        Dim ent = New sampledbEntities()
        Dim q = From t In ent.Book
                Where t.Title.Contains("逆引き")
        Dim sum = q.Sum(New Func(Of Book, Integer)(
                    Function(t)
                        Return t.Price
                    End Function))
        MessageBox.Show($"合計は{sum}円です")
    End Sub
End Class
