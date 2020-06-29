Imports System.Collections.ObjectModel
Imports db309.db309

Class MainWindow

    Private ent As New sampledbEntities()
    Private items As ObservableCollection(Of Person)
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        items = New ObservableCollection(Of Person)(ent.Person.ToList())
        dg.ItemsSource = items
    End Sub
End Class
