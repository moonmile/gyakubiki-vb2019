Imports db295.db295

Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim ent As New sampledbEntities()
        Dim q = From b In ent.Book
                Join au In ent.Author On b.AuthorId Equals au.ID
                Select New With {b.ID, b.Title, au.Name}
        dg.ItemsSource = q.ToList()
    End Sub
End Class
