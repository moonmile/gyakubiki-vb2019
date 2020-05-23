Imports db296.db296
Imports System.Data.Entity.Infrastructure
Imports System.Linq

Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim ent As New sampledbEntities()
        Dim q = From b In ent.Book
                Group Join au In ent.Author On b.AuthorId Equals au.ID
            Into temp = Group
                From t In temp.DefaultIfEmpty()
                Select New With {b.ID, b.Title, t.Name}
        dg.ItemsSource = q.ToList()

    End Sub
End Class
