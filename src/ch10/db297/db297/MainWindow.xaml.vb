Imports db297.db297

Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim ent As New sampledbEntities()
        Dim q = From b In ent.Book
                Group Join au In ent.Author On b.AuthorId Equals au.ID Into temp = Group
                From t In temp.DefaultIfEmpty()
                Select New Result With {.ID = b.ID, .Title = b.Title, .Author = t.Name}
        dg.ItemsSource = q.ToList()
    End Sub


    Public Class Result
        Public Property ID As Integer
        Public Property Title As String
        Public Property Author As String
    End Class

End Class


