Imports db289.db289

Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim ent As New sampledbEntities()
        dg.ItemsSource =
        ent.Book.Where(
        New Func(Of Book, Boolean)(
        Function(t)
            Return t.Title.Contains("逆引き")
        End Function)).ToList()
    End Sub
End Class
