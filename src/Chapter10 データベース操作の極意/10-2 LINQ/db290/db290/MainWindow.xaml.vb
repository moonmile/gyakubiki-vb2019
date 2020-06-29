Imports db290.db290

Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim ent As New sampledbEntities()
        Dim q = From t In ent.Book
                Order By t.Title Descending
                Select t
        dg.ItemsSource = q.ToList()
    End Sub
End Class
