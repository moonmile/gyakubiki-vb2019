Imports db288.db288

Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim ent As New sampledbEntities()
        Dim q = From t In ent.Book
                Where t.Title.Contains("逆引き")
                Select t
        dg.ItemsSource = q.ToList()
    End Sub
End Class
