Imports db308.db308

Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim ent As New sampledbEntities()
        dg.ItemsSource = ent.Person.ToList()
    End Sub
End Class
