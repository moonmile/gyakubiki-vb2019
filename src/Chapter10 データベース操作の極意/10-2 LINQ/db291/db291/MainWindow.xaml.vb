Imports db291.db291

Class MainWindow
    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim ent As New sampledbEntities()
        dg.ItemsSource = ent.Book.ToList()
    End Sub

    Private Sub Button2_Click(sender As Object, e As RoutedEventArgs)
        Dim n = Integer.Parse(text1.Text)
        Dim ent As New sampledbEntities()
        Dim item = ent.Book.ToList()(n)
        MessageBox.Show($"{item.Title} を選択しました")
    End Sub

End Class
