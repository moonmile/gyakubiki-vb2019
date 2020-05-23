Imports System.Runtime.InteropServices.WindowsRuntime
Imports db292.db292

Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim ent As New sampledbEntities()
        Dim q = From t In ent.Book
                Select New With {
                .題名 = t.Title,
                .出版日 = t.PublicDate
            }
        dg.ItemsSource = q.ToList()
    End Sub
End Class
