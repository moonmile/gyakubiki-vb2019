Imports db306.db306

Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim ent = New sampledbEntities()
        Dim q = From t In ent.Person
                Where t.Age >= 50
                Select t
        dg.ItemsSource = q.ToList()
    End Sub
End Class
